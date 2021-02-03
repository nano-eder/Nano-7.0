
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.IO
Imports System.Windows.Forms
Imports System.Security.Cryptography.xml
Imports System.Security.Cryptography.X509Certificates

Public Class AssinaturaDigital
    Public vResultado As Integer
    Public vResultadoString As String
    Public vXMLStringAssinado As String
    Public XmlDoc As XmlDocument

    Sub Assinar(ByVal pArqXMLAssinar As String, ByVal pUri As String, ByVal pCertificado As X509Certificate, ByRef pResultado As Integer, ByRef pResultadoString As String, ByVal parCaminho As String)

        'Abrir o arquivo XML a ser assinado e ler o seu conteúdo
        Dim SR As StreamReader
        Dim vXMLString As String

        SR = File.OpenText(pArqXMLAssinar)
        vXMLString = SR.ReadToEnd()
        SR.Close()

        ' //Atualizar atributos de retorno com conteúdo padrão
        pResultado = 0
        pResultadoString = "Assinatura realizada com sucesso"

        Try

            'Verifica o certificado a ser utilizado na assinatura
            Dim _xnome As String
            Dim _X509Cert As X509Certificate2
            Dim store As X509Store
            Dim collection As X509Certificate2Collection
            Dim collection1 As X509Certificate2Collection

            _xnome = ""

            _xnome = pCertificado.Subject.ToString()

            _X509Cert = New X509Certificate2()
            store = New X509Store("MY", StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

            collection = store.Certificates
            collection1 = collection.Find(X509FindType.FindBySubjectDistinguishedName, _xnome, False)


            If (collection1.Count = 0) Then
                pResultado = 2
                pResultadoString = "Problemas no certificado digital"
            Else

                ' certificado ok
                'oX509Cert = scollection.Item(0)

                _X509Cert = collection1.Item(0)
                Dim x As String
                x = _X509Cert.GetKeyAlgorithm().ToString()

                ' Create a new XML document.
                Dim doc As New XmlDocument
                doc = New XmlDocument()

                'Format the document to ignore white spaces.
                doc.PreserveWhitespace = False

                ' Load the passed XML file using it’s name.
                Try

                    doc.LoadXml(vXMLString)

                    ' Verifica se a tag a ser assinada existe é única
                    Dim qtdeRefUri As Integer
                    qtdeRefUri = doc.GetElementsByTagName(pUri).Count

                    If (qtdeRefUri = 0) Then
                        ' a URI indicada não existe
                        pResultado = 4
                        pResultadoString = "A tag de assinatura " + pUri.Trim() + " não existe"

                    Else
                        ' Existe mais de uma tag a ser assinada 
                        If (qtdeRefUri > 1) Then
                            ' existe mais de uma URI indicada
                            pResultado = 5
                            pResultadoString = "A tag de assinatura " + pUri.Trim() + " não é unica"
                        Else

                            Try
                                ' Create a SignedXml object.
                                Dim signedXml As SignedXml
                                signedXml = New SignedXml(doc)

                                ' Add the key to the SignedXml document
                                signedXml.SigningKey = _X509Cert.PrivateKey

                                ' Create a reference to be signed
                                Dim reference As New Reference
                                reference = New Reference()

                                '--------- RETIRAR COMENTÁRIOS DAS LINHAS ABAIXO
                                ' pega o uri que deve ser assinada
                                Dim _Uri As XmlAttributeCollection
                                Dim _atributo As XmlAttribute

                                _Uri = doc.GetElementsByTagName(pUri).Item(0).Attributes
                                For Each _atributo In _Uri
                                    If (_atributo.Name = "Id") Then
                                        reference.Uri = "#" + _atributo.InnerText

                                    End If
                                Next

                                ' Add an enveloped transformation to the reference.
                                Dim env As New XmlDsigEnvelopedSignatureTransform
                                env = New XmlDsigEnvelopedSignatureTransform()
                                reference.AddTransform(env)

                                Dim c14 As New XmlDsigC14NTransform
                                c14 = New XmlDsigC14NTransform()
                                reference.AddTransform(c14)

                                ' Add the reference to the SignedXml object.
                                signedXml.AddReference(reference)

                                ' Create a new KeyInfo object
                                Dim keyinfo As New KeyInfo
                                keyinfo = New KeyInfo()

                                ' Load the certificate into a KeyInfoX509Data object
                                ' and add it to the KeyInfo object.
                                keyinfo.AddClause(New KeyInfoX509Data(_X509Cert))

                                ' Add the KeyInfo object to the SignedXml object.
                                signedXml.KeyInfo = keyinfo
                                signedXml.ComputeSignature()

                                ' Get the XML representation of the signature and save
                                ' it to an XmlElement object.
                                Dim xmlDigitalSignature As XmlElement
                                xmlDigitalSignature = signedXml.GetXml()

                                ' Gravar o elemento no documento XML
                                doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, True))
                                XmlDoc = New XmlDocument()
                                XmlDoc.PreserveWhitespace = False
                                XmlDoc = doc

                                ' Atualizar a string do XML já assinada
                                vXMLStringAssinado = XmlDoc.OuterXml


                                File.WriteAllText(pArqXMLAssinar, vXMLStringAssinado)
                                ' Gravar o XML no HD
                                ' abre um stream para escrita e cria um StreamWriter para implementar o stream
                                'Dim fs As New FileStream(pArqXMLAssinar, FileMode.OpenOrCreate, FileAccess.Write)
                                'Dim SW_2 As New StreamWriter(fs)
                                'SW_2.Flush()
                                'SW_2.BaseStream.Seek(0, SeekOrigin.Begin)
                                'SW_2.Write(vXMLStringAssinado)
                                'SW_2.Flush()
                                'SW_2.Close()

                            Catch ex As Exception
                                pResultado = 6
                                pResultadoString = "Erro ao assinar o documento - " + ex.Message

                            End Try

                        End If

                    End If

                Catch ex As Exception

                    pResultado = 3
                    pResultadoString = "XML mal formado - " + ex.Message

                End Try

            End If

        Catch ex As Exception

            pResultado = 1
            pResultadoString = "Problema ao acessar o certificado digital" + ex.Message

        End Try

    End Sub

    'Function SelecionarCertificado() As Boolean

    '    Dim vRetorna As Boolean
    '    Dim oX509Cert As New X509Certificate2
    '    Dim store As New X509Store
    '    Dim collection As New X509Certificate2Collection
    '    Dim collection1 As New X509Certificate2Collection
    '    Dim collection2 As New X509Certificate2Collection
    '    Dim scollection As New X509Certificate2Collection
    '    Dim msgResultado As String
    '    Dim xnome As String

    '    ' xnome = "CN=ERASYST SOLUCOES EM INFORMATICA EPP:14566555000100, OU=Autenticado por AR Ciesp, OU=RFB e-CNPJ A3, OU=Secretaria da Receita Federal do Brasil - RFB, L=INDAIATUBA, S=SP, O=ICP-Brasil, C=BR"

    '    oX509Cert = New X509Certificate2()
    '    store = New X509Store("MY", StoreLocation.CurrentUser)
    '    store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
    '    collection = store.Certificates
    '    collection1 = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, False)
    '    collection2 = collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, False)

    '    'Encontra o certificado digital pelo nome do mesmo, se precisar pergunta por isso
    '    'Resolvido em 13/05/2009 às 15:05h
    '    scollection = collection.Find(X509FindType.FindBySubjectDistinguishedName, xnome, False)


    '    'Para selecionar o certificado de uma lista
    '    'scollection = X509Certificate2UI.SelectFromCollection(collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o certificado digital para uso no aplicativo", X509SelectionFlag.SingleSelection)

    '    If (scollection.Count = 0) Then

    '        msgResultado = "Nenhum certificado digital foi selecionado ou o certificado selecionado está com problemas."
    '        MessageBox.Show(msgResultado, "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        vRetorna = False

    '    Else

    '        oX509Cert = scollection.Item(0) 'Para selecionar o item em Vb.NET
    '        oCertificado = oX509Cert
    '        vRetorna = True
    '        'msgResultado = "Certificado Selecionado."
    '        'MessageBox.Show(msgResultado, "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return vRetorna

    '    End If

    'End Function

    Public Function SelecionarCertificado(ByVal CerSerie As String, ByRef parRetorno As String) As X509Certificate2
        'Dim certificate As New X509Certificate2
        parRetorno = ""
        Try
            Dim certificatesSel As X509Certificate2Collection
            Dim store As New X509Store("MY", StoreLocation.CurrentUser)
            store.Open(OpenFlags.OpenExistingOnly)
            Dim certificates As X509Certificate2Collection = store.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, True).Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, True)
            If (CerSerie = "") Then
                certificatesSel = X509Certificate2UI.SelectFromCollection(certificates, "Certificados Digitais", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection)
                If (certificatesSel.Count = 0) Then
                    certificate.Reset()
                    Throw New Exception("Nenhum certificado digital foi selecionado ou o certificado selecionado está com problemas.")
                Else
                    certificate = certificatesSel.Item(0)
                End If
            Else
                certificatesSel = certificates.Find(X509FindType.FindBySerialNumber, CerSerie, True)
                If (certificatesSel.Count = 0) Then
                    certificate.Reset()
                    Throw New Exception("Certificado digital não encontrado")
                Else
                    certificate = certificatesSel.Item(0)
                End If
            End If
            store.Close()
            Return certificate
        Catch exception As Exception
            parRetorno = exception.Message
        End Try


    End Function
End Class
