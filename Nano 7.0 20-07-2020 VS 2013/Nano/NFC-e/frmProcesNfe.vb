Imports Nano.clsFuncoes
Imports System.IO
Imports System.Threading

Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports System.Windows.Forms
Imports System.Security.Cryptography.xml
Imports System.Security.Cryptography.X509Certificates
'Imports Nano.C_WebService
Imports System.Web.Services.Protocols
Imports Nano.AssinaturaDigital
Imports Nano.GerarDanfe1
Public Class frmProcesNfe
    Public strCaminhoNfe As String
    Dim intCont As Integer
    Dim intQuinze As Integer
    Dim intCrono As Integer
    Dim Resultado As Boolean
    Dim strArquivo As String
    Dim bolInicio As Boolean = True
    Public strUF As String
    Public strTipoAmb As String
    Public intCodCce As Integer
    Public strChaveAcesso As String
    Public strNumSeq As String
    Public strTipoEvento As String
    Public strStatus As String
    Public strDataEmissao As String
    Dim intMax As Integer

    Public Shared Sub Main()
        Application.Run(New frmProcesNfe())
    End Sub
    Private Sub frmProcesNfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolInicio = True
        lstValidando.Size = New System.Drawing.Size(398, 273)
        Me.btnFechar.Enabled = False
        lstValidando.Items.Clear()
        lstErro.Items.Clear()
        intCont = 0
        intCrono = 15
        intQuinze = 15
        Timer1.Start()
        Me.pb.Value = 0
        Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
   
    Private Sub Verificar()

        'If ExisteConexaoInternet() = False Then
        '    Processando("Verifique sua conexão com a internet", True)
        '    If strStatus = "AGUARDANDO" Then
        '        strArquivo = ""
        '    Else
        '        strArquivo = "NOK"
        '    End If

        '    Exit Sub
        'End If

     
        If strStatus = "AGUARDANDO" Then
            Select Case Me.Tag
                Case "NFe"
                    intMax = 90
                Case "CCe", "Cancelamento"
                    Me.btnFechar.Enabled = True
                    intMax = 80
            End Select
        Else
            Select Case Me.Tag
                Case "NFe"
                    intMax = 100
                Case "CCe", "Cancelamento"
                    Me.btnFechar.Enabled = True
                    intMax = 90
                Case "Inut"
                    intMax = 80
            End Select
        End If
        pb.Maximum = intMax

        Dim strResultado As String = ""
        Dim intResultado As Integer = 0


        Processando("Verificando a exitência da nota", False)

        'Dim dddd As String = strCaminhoNfe.Replace("Remessas", "Assinadas")
        If strStatus <> "AGUARDANDO" Then
            If strStatus <> "Consulta" Then

                If File.Exists(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)) = True Then
                    File.Delete(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                End If

                File.Copy(strCaminhoNfe, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))

                Processando("Assinando arquivo xml", False)
            End If
           
        End If

        Dim OAd As New AssinaturaDigital

        OAd.SelecionarCertificado(CertificadoDigital, strResultado)



        If strResultado <> "" Then
            Processando(strResultado, True)

            strArquivo = "NOK"
            Exit Sub
        End If
        If Me.Tag = "ConsultaChave" Then
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(strResultado, strChaveAcesso, "", "", False)
                Case "PR"
                    ConsultaNfePR(strResultado, strChaveAcesso, "", "", False)
                Case Else
                    ConsultaNfe4(strResultado, strChaveAcesso, "", "", False)
            End Select

            strArquivo = strResultado
            Exit Sub
        End If



        If strStatus = "AGUARDANDO" Then
            strResultado = ""
            Select Case Me.Tag
                Case "NFe"
                    ConsultaNfe4(strResultado, strChaveAcesso, "NFe", "", False)
                Case "CCe", "Cancelamento"
                    ConsultaNfe4(strResultado, strChaveAcesso, "Evento", strNumSeq, False)
            End Select
            strArquivo = strResultado
            Exit Sub
        End If


        Dim strUri As String = ""
        Select Case Me.Tag
            Case "NFe"
                strUri = "infNFe"
            Case "CCe", "Cancelamento"
                strUri = "infEvento"
            Case "Inut"
                strUri = "infInut"
        End Select

        OAd.Assinar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), strUri, certificate, intResultado, strResultado, strCaminhoNfe)

        If intResultado > 0 Then
            Processando(strResultado, True)

            strArquivo = "NOK"
            Exit Sub
        End If
        'Select Case Me.Tag
        '    Case "NFe"
        '        Dim SR As StreamReader
        '        Dim vXMLString As String

        '        SR = File.OpenText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        '        vXMLString = SR.ReadToEnd()


        '        SR.Close()
        '        Dim strDigestValue As String = ""
        '        Dim vetXml As Array = Split(vXMLString, "<DigestValue>")
        '        If vetXml.Length > 0 Then
        '            Dim vetXml1 As Array = Split(vetXml(1), "</DigestValue>")
        '            strDigestValue = vetXml1(0)
        '        End If

        '        Dim strURL As String = SelecionarURLQrCode(strUF, strTipoAmb)

        '        strDataEmissao = ConverterHexadecimal(strDataEmissao)
        '        strDigestValue = ConverterHexadecimal(strDigestValue)

        '        Dim strChaveQrCode As String = "chNFe=" & strChaveAcesso
        '        Dim strVersaoQrCode As String = "&nVersao=2"
        '        Dim strTipoAmbQrCode As String = "&tpAmb=" & strTipoAmb
        '        Dim strCPFDestQrCode As String = "&cDest=" & CPFDestinatario
        '        If CPFDestinatario = "" Or CPFDestinatario = "00000000000" Then
        '            strCPFDestQrCode = ""
        '        End If
        '        Dim strDataEmiQrCode As String = "&dhEmi=" & strDataEmissao
        '        Dim strValNFQrCode As String = "&vNF=" & TotalNFCe
        '        Dim strValICMSQrCode As String = "&vICMS=" & TotalICMS
        '        Dim strDigValQrCode As String = "&digVal=" & strDigestValue
        '        Dim strIdToken As String = "&cIdToken=" & Format(TokenNFCe, "000000")

        '        Dim strCodeSha As String = strChaveQrCode & strVersaoQrCode & strTipoAmbQrCode & _
        '        strCPFDestQrCode & strDataEmiQrCode & strValNFQrCode & strValICMSQrCode & strDigValQrCode & strIdToken & CSTEmitente

        '        Call ConverterSHA1(strCodeSha) ' Lets call the first password encryption function for SHA1
        '        strCodeSha = ConverterSHA1(strCodeSha)

        '        Dim strCSC As String = "&cHashQRCode=" & strCodeSha

        '        Dim strCode As String = "<![CDATA[" & strURL & "?" & strChaveQrCode & strVersaoQrCode & strTipoAmbQrCode & _
        '        strCPFDestQrCode & strDataEmiQrCode & strValNFQrCode & strValICMSQrCode & strDigValQrCode & strIdToken & strCSC & "]]>"

        '        Dim strQrCode As String = clsXmlNFCe.QrCode(strCode, strURL)
        '        vXMLString = vXMLString.Replace("</infNFe>", "</infNFe>" & strQrCode)
        '        File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), vXMLString)


        'End Select

        Select Case Me.Tag
            Case "NFe"
                Dim SR As StreamReader
                Dim vXMLString As String

                SR = File.OpenText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                vXMLString = SR.ReadToEnd()


                SR.Close()
                Dim strDigestValue As String = ""
                Dim vetXml As Array = Split(vXMLString, "<DigestValue>")
                If vetXml.Length > 0 Then
                    Dim vetXml1 As Array = Split(vetXml(1), "</DigestValue>")
                    strDigestValue = vetXml1(0)
                End If

                Dim strURL As String = SelecionarURLQrCode(strUF, strTipoAmb)

                strDataEmissao = ConverterHexadecimal(strDataEmissao)
                strDigestValue = ConverterHexadecimal(strDigestValue)

                Dim strChaveQrCode As String = strChaveAcesso
                Dim strVersaoQrCode As String = "2"
                Dim strTipoAmbQrCode As String = strTipoAmb

                Dim strDataEmiQrCode As String = "&dhEmi=" & strDataEmissao
                Dim strValNFQrCode As String = "&vNF=" & TotalNFCe
                Dim strValICMSQrCode As String = "&vICMS=" & TotalICMS
                Dim strDigValQrCode As String = "&digVal=" & strDigestValue
                Dim strIdToken As String = "&cIdToken=" & Format(TokenNFCe, "000000")

                Dim strCodeSha As String = strChaveQrCode & "|" & strVersaoQrCode & "|" & strTipoAmbQrCode & "|" & TokenNFCe & CSTEmitente

                Call ConverterSHA1(strCodeSha) ' Lets call the first password encryption function for SHA1
                strCodeSha = ConverterSHA1(strCodeSha)

                Dim strCSC As String = strCodeSha

                'Dim strCode As String = strURL & "?p=" & strChaveQrCode & "|" & strVersaoQrCode & "|" & strTipoAmbQrCode & "|" & TokenNFCe & "|" & strCSC

                Dim strCode As String = "<![CDATA[" & strURL & "?p=" & strChaveQrCode & "|" & strVersaoQrCode & "|" & strTipoAmbQrCode & "|" & TokenNFCe & "|" & strCSC.ToUpper & "]]>"
                Dim strURL2 As String = SelecionarURLQrCode2(strUF, strTipoAmb)


                Dim strQrCode As String = clsXmlNFCe.QrCode(strCode, strURL2)
                vXMLString = vXMLString.Replace("</infNFe>", "</infNFe>" & strQrCode)
                File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), vXMLString)


        End Select

        'Select Case Me.Tag
        '    Case "NFe"
        '        Dim SR As StreamReader
        '        Dim vXMLString As String

        '        SR = File.OpenText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        '        vXMLString = SR.ReadToEnd()


        '        SR.Close()
        '        Dim strDigestValue As String = ""
        '        Dim vetXml As Array = Split(vXMLString, "<DigestValue>")
        '        If vetXml.Length > 0 Then
        '            Dim vetXml1 As Array = Split(vetXml(1), "</DigestValue>")
        '            strDigestValue = vetXml1(0)
        '        End If

        '        Dim strURL As String = SelecionarURLQrCode(strUF, strTipoAmb)

        '        strDataEmissao = ConverterHexadecimal(strDataEmissao)
        '        strDigestValue = ConverterHexadecimal(strDigestValue)

        '        Dim strChaveQrCode As String = strChaveAcesso
        '        Dim strVersaoQrCode As String = "2"
        '        Dim strTipoAmbQrCode As String = strTipoAmb

        '        Dim strDataEmiQrCode As String = Date.Today.Day
        '        Dim strValNFQrCode As String = TotalNFCe
        '        Dim strValICMSQrCode As String = TotalICMS
        '        Dim strDigValQrCode As String = strDigestValue
        '        Dim strIdToken As String = TokenNFCe

        '        Dim strCodeSha As String = strChaveQrCode & "|" & strVersaoQrCode & "|" & strTipoAmbQrCode & "|" & strDataEmiQrCode & "|" & strValNFQrCode & "|" & strDigValQrCode e & "|" &  TokenNFCe & "|" & CSTEmitente

        '        Call ConverterSHA1(strCodeSha) ' Lets call the first password encryption function for SHA1
        '        strCodeSha = ConverterSHA1(strCodeSha)

        '        Dim strCSC As String = strCodeSha

        '        Dim strCode As String = strChaveQrCode & "|" & strVersaoQrCode & "|" & strTipoAmbQrCode & "|" & TokenNFCe & "|" & strCSC

        '        Dim strQrCode As String = clsXmlNFCe.QrCode(strCode, strURL)
        '        vXMLString = vXMLString.Replace("</infNFe>", "</infNFe>" & strQrCode)
        '        File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), vXMLString)


        'End Select


        Processando("Validando o arquivo xml", False)

        Dim strNota As String = File.ReadAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim strRetornoValidar As String = ""
        Select Case Me.Tag
            Case "NFe"
                If VersaoXml = "3.10" Then
                    Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas_3.10") & "\nfe_v3.10.xsd", strRetornoValidar)
                    If strRetornoValidar = "NOK" Then
                        strArquivo = "NOK"
                        Exit Sub
                    End If

                    strNota = strNota.Replace("<NFe xmlns=", "<enviNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""3.10""><idLote>" & Format(CodigoNF, "000000000000000") & "</idLote><indSinc>0</indSinc><NFe xmlns=")

                ElseIf VersaoXml = "4.00" Then
                    Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas_4.00") & "\nfe_v4.00.xsd", strRetornoValidar)
                    If strRetornoValidar = "NOK" Then
                        strArquivo = "NOK"
                        Exit Sub
                    End If

                    strNota = strNota.Replace("<NFe xmlns=", "<enviNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""4.00""><idLote>" & Format(CodigoNF, "000000000000000") & "</idLote><indSinc>0</indSinc><NFe xmlns=")

                End If
             
        

                strNota = strNota.Replace("</NFe>", "</NFe></enviNFe>")
                File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), strNota)

            Case "CCe"
                Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas") & "\CCe\CCe_v1.00.xsd", strRetornoValidar)
                If strRetornoValidar = "NOK" Then
                    strArquivo = "NOK"
                    Exit Sub
                End If
           
                strNota = strNota.Replace("<evento xmlns=", "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00""><idLote>" & intCodCce & "</idLote><evento xmlns=")


                strNota = strNota.Replace("</evento>", "</evento></envEvento>")
                File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), strNota)

                Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas") & "\CCe\envCCe_v1.00.xsd", strRetornoValidar)
                If strRetornoValidar = "NOK" Then
                    strArquivo = "NOK"
                    Exit Sub
                End If
            Case "Cancelamento"
                Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas") & "\Cancelamento\eventoCancNFe_v1.00.xsd", strRetornoValidar)
                If strRetornoValidar = "NOK" Then
                    strArquivo = "NOK"
                    Exit Sub
                End If
                
                strNota = strNota.Replace("<evento xmlns=", "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00""><idLote>" & intCodCce & "</idLote><evento xmlns=")

                strNota = strNota.Replace("</evento>", "</evento></envEvento>")
                File.WriteAllText(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), strNota)
                Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas") & "\Cancelamento\envEventoCancNFe_v1.00.xsd", strRetornoValidar)
                If strRetornoValidar = "NOK" Then
                    strArquivo = "NOK"
                    Exit Sub
                End If

            Case "Inut"
                If VersaoXml = "3.10" Then
                    Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas_3.10") & "\inutNFe_v3.10.xsd", strRetornoValidar)

                ElseIf VersaoXml = "4.00" Then
                    Validar(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas), PastaRemessas.Replace("Remessas", "Schemas_4.00") & "\inutNFe_v4.00.xsd", strRetornoValidar)

                End If
              
                If strRetornoValidar = "NOK" Then
                    strArquivo = "NOK"
                    Exit Sub
                End If

        End Select



        Processando("Enviando NF-e", False)

        Dim strRetorno As String = ""
        Select Case Me.Tag
            Case "NFe"
                Select Case strUF
                    Case "MT"
                        EnviarMT(strRetorno)

                    Case "PR"
                        EnviarPR(strRetorno)

                    Case Else
                        Enviar4(strRetorno)
                        'Enviar(strRetorno)
                End Select



            Case "CCe", "Cancelamento"

                EnviarEvento4(strRetorno)
            Case "Inut"

                EnviarInutilizacao4(strRetorno)
        End Select


        strArquivo = strRetorno
    End Sub

    Public Sub ValidationEventHandler(ByVal sender As Object, ByVal args As ValidationEventArgs)


        Resultado = False

        'lstValida.Items.Add(vbTab + "Erro de Validação : " + args.Message)

        If args.Severity = XmlSeverityType.Warning Then

            MsgBox("Nenhum arquivo de Schema foi encontrado para efetuar a validação...")

        ElseIf args.Severity = XmlSeverityType.Error Then

            'lstValidando.Items.Add(args.Message)
            'MsgBox("Ocorreu um erro durante a validação....")
            Processando(args.Message, True)
        End If

        If Not (args.Exception Is Nothing) Then ' Erro na validação do schema XSD

            'lstValida.Items.Add(args.Exception.SourceUri + "," & args.Exception.LinePosition & "," & args.Exception.LineNumber)
            'MsgBox(args.Exception.SourceUri + "," & args.Exception.LinePosition & "," & args.Exception.LineNumber)

        End If

    End Sub
    Private Sub Validar(ByVal parCaminho As String, ByVal parSchema As String, ByRef parRetorno As String)

        Dim TxtXSD As String

        TxtXSD = parSchema
        parRetorno = "OK"
        If Not parCaminho = String.Empty And Not TxtXSD = String.Empty Then

            Resultado = True
            Dim settings As New XmlReaderSettings()
            AddHandler settings.ValidationEventHandler, AddressOf Me.ValidationEventHandler

            'Valida o arquivo XML com o seu Schema XSD
            'lstValidando.Items.Add("Validando o arquivo XML " & parCaminho & " com o arquivo de Schema : " & TxtXSD)
            Processando("Validando o arquivo XML " & parCaminho & " com o arquivo de Schema : " & TxtXSD, False)
            Try

                settings.ValidationType = ValidationType.Schema
                settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", XmlReader.Create(TxtXSD))
                Using XmlValidatingReader As XmlReader = XmlReader.Create(parCaminho, settings)
                    While XmlValidatingReader.Read()

                    End While

                End Using

            Catch ex As Exception
                Processando(ex.Message, True)
                parRetorno = "NOK"
                'lstValidando.Items.Add(ex.Message)
                Exit Sub
            End Try

            If Resultado = True Then
                Processando("Arquivo validado com SUCESSO", False)

            Else
                Processando("Validação FALHOU", True)
                parRetorno = "NOK"
            End If
            'Processando("Status Validação -> " & IIf(Resultado = True, "Arquivo validado com SUCESSO", "Validação FALHOU"), False)
            'lstValidando.Items.Add("Status Validação -> " & IIf(Resultado = True, "Arquivo validado com SUCESSO", "Validação FALHOU"))


        Else
            parRetorno = "NOK"
            Processando("Informe o arquivo XML e o arquivo XSD.", True)

        End If

    End Sub
    Private Sub Processando(ByVal parMensagem As String, ByVal parErro As Boolean)
      
        If parErro = False Then
            If pb.Value < intMax Then
                pb.Value = pb.Value + 10
            End If
            lstValidando.Items.Add(parMensagem)
        Else
            pb.Value = intMax
            Me.btnFechar.Enabled = True
            lstValidando.Size = New System.Drawing.Size(398, 174)
            lstErro.Items.Add(parMensagem)
        End If

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolInicio = True Then
            bolInicio = False
            btnInicio_Click(sender, e)

        End If
        intCont += 1

        Cronometro()

        If intCont = intQuinze Then
            intQuinze += 15
        End If

        If strArquivo = "OK" Then
            Select Case Me.Tag
                Case "NFe"
                    If ImpDiretoNFCe = True Then

                        frmVenda.strArquivoProcessado = "OK"

                    Else
                        frmDav.strArquivoProcessado = "OK"
                    End If
                  
                  
                    'Case "CCe"
                    '    frmEmissaoCce.strArquivoProcessado = "OK"

                Case "Cancelamento"
                    frmCancelarNFe.strArquivoProcessado = "OK"
                    'Case "Inut"
                    '    frmInutilizacao.strArquivoProcessado = "OK"

            End Select
           ' mThread.Abort()
            Timer1.Stop()
            Me.Close()
            Exit Sub
        End If
        If strArquivo = "NOK" Then
            Me.btnFechar.Enabled = True
            Select Case Me.Tag
                Case "NFe"
                    If ImpDiretoNFCe = True Then
                        frmVenda.strArquivoProcessado = "NOK"

                    Else
                        frmDav.strArquivoProcessado = "NOK"

                    End If
                   
                    'Case "CCe"
                    '    frmEmissaoCce.strArquivoProcessado = "NOK"

                Case "Cancelamento"
                    frmCancelarNFe.strArquivoProcessado = "NOK"

                    'Case "Inut"
                    '    frmInutilizacao.strArquivoProcessado = "NOK"
                    'Case "ConsultaChave"
                    '    frmConsultaChave2.strRetorno = "NOK"
            End Select
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Timer1.Stop()
            Exit Sub
        End If

        If intCont = 120 Then
            Me.btnFechar.Enabled = True
            MsgBox("Tempo limite esgotou!", MsgBoxStyle.Information)
            Timer1.Stop()
            Exit Sub
        End If
    End Sub
    Private Sub Contador15Segundos()
        Dim intSegundo As Integer = Second(Now)
        Dim intContador As Integer = 0
        While intContador <= 5
            If intSegundo <> Second(Now) Then
                intSegundo = Second(Now)
                intContador += 1
            End If
        End While
    End Sub
    Private Sub Cronometro()
        intCrono = intCrono - 1

        marquee.Text = intCrono

        If intCrono = 1 Then
            intCrono = 16
        End If
    End Sub
    Public Structure RetEnvio
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String
    End Structure
    Public Structure RetRetorno
        Dim tpAmb As String
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim L_Retornos As List(Of RetRecibo) 'LISTA DE NOTAS PARA QUANDO MAIS DE UMA NOTA FOI ENVIADA NO LOTE
    End Structure
    'VARIAVEL COM AS INFORMACOES DA NFE PARA USAR NA CONSULTA RETORNO
    Public Structure RetRecibo
        Dim Id As String
        Dim tpAmb As String
        Dim verAplic As String
        Dim chNFe As String
        Dim dhRecbto As String
        Dim digVal As String
        Dim cStat As String
        Dim xMotivo As String
        Dim nProt As String
        Dim XmlRecibo As String
    End Structure
    Public Structure SEvento
        Dim Id As String
        Dim tpAmb As String
        Dim verAplic As String
        Dim cOrgao As String
        Dim cStat As String
        Dim xMotivo As String
        Dim chNfe As String
        Dim tpEvento As String
        Dim xEvento As String
        Dim nSeqEvento As String
        Dim CNPJDest As String
        Dim CPFDest As String
        Dim emailDest As String
        Dim dhRetEvento As String
        Dim nProt As String
    End Structure
    Public Structure RetornoEvento
        Dim versao As String
        Dim IdLote As String
        Dim tpAmb As String
        Dim verAplic As String
        Dim cOrgao As String
        Dim cStat As String
        Dim xMotivo As String
        Dim infEvento As SEvento
        Dim XmlRecibo As String
    End Structure

    Public Structure RetornoInutilizacao
        Dim tpAmb As String
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim ano As String
        Dim CNPJ As String
        Dim strmod As String
        Dim serie As String
        Dim nNFIni As String
        Dim nNFFin As String
        Dim dhRecbto As String
        Dim nProt As String
    End Structure
   
    Private Sub Enviar(ByRef parOK As String)
        'ENVIA LOTE DE NOTAS VERSÃO 2.00
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strCcc As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeAutorizacao.NfeAutorizacao
            Dim cab As New wsNFeAutorizacao.nfeCabecMsg

            'UF E VERSÃO DO CABEÇALHO
            cab.versaoDados = VersaoXmlAutorizacao

            cab.cUF = SelecionarCodigoUF(strUF)
         
            Dim Notas As String
            'CABEÇALHO USADA PARA ENVIO DE LOTE
      
            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If
            wsMsg = New wsNFeAutorizacao.NfeAutorizacao(URLNfe)


            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12
            Notas = xmldoc.OuterXml

            'RETORNO DA SEFAZ

            'If ExisteConexaoInternet() = False Then
            '    Processando("Verifique sua conexão com a internet", True)
            '    If strStatus = "AGUARDANDO" Then
            '        strArquivo = ""
            '    Else
            '        strArquivo = "NOK"
            '    End If
            '    Exit Sub
            'End If

          

            strRetorno = wsMsg.nfeAutorizacaoLote(xmldoc)

            'Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            'strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
            'strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            'strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
            'strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf


            'Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

            'SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

            'SW.Close() 'Fecha o arquivo de texto

            'SW.Dispose() 'Libera a memória utilizada


            'DESMEMBRA RETORNO XML
            ' Dim StrRetNota As RetEnvio = Nothing
            Dim XmlText As XmlDocument = New XmlDocument

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In strRetorno
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        xMotivo = InnerNode.InnerText
                        If xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                        If xMotivo.Contains("Rejeicao") = True Then
                            bolRetorno = False
                        End If
                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nRec" Or outerNode.Name = "nRec") Then
                        nRec = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tMed" Or outerNode.Name = "tMed") Then
                        tMed = InnerNode.InnerText
                    End If
                Next
            Next

            If bolRetorno = False Then
                Processando(cStat & " " & xMotivo, True)
                parOK = "NOK"
                Exit Sub
            End If
        Catch ex As Exception

            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select
            Exit Sub

        End Try

        Dim RetonoConsulta As New RetRetorno
        Processando("Aguardando processamento das informações", False)

        Contador15Segundos()


        Try
            Dim wsMsg As wsNFeRetAutorizacao.NfeRetAutorizacao
            Dim cab As New wsNFeRetAutorizacao.nfeCabecMsg

            'UF E VERSÃO DO CABEÇALHO
            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlAutorizacao

            'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE

            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERETRECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERETRECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If

            wsMsg = New wsNFeRetAutorizacao.NfeRetAutorizacao(URLNfe)
            wsMsg.Url = URLNfe

            'ASSOCIA CABEÇALHO NFE
            wsMsg.nfeCabecMsgValue = cab

            'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
            wsMsg.Timeout = 100000

            'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
            wsMsg.ClientCertificates.Add(CERT)

            'DEFINE PROTOCOLO USADO NA CONEXÃO
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'CRIA UM NOVO DOCUMENTO XML
            Dim dados As XmlDocument = New XmlDocument

            'ASSOCIA O NOVO XML COM A VARIAVEL DE RETORNO DA SEFAZ
            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlAutorizacao & """><tpAmb>" & strTipoAmb & "</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")



            'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
            Dim bolProcessando As Boolean = True

            While bolProcessando = True


                strRetorno = wsMsg.nfeRetAutorizacaoLote(dados)

                'DESMEMBRA RETORNO XML
                '-----------------------------------------------------------------------------------
                'VARIAVER QUE VAI RECEBER O RETORNO
                Dim Retornos As New RetRetorno
                'CRIA LISTA PARA RECEBER RETORNOS
                Retornos.L_Retornos = New List(Of RetRecibo)
                'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO

                Dim VarRecibo As New RetRecibo

                'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
                For Each outerNode As XmlNode In strRetorno
                    'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
                    If (outerNode.Name = "tpAmb") Then
                        Retornos.tpAmb = outerNode.InnerText
                    End If
                    If (outerNode.Name = "verAplic") Then
                        Retornos.verAplic = outerNode.InnerText
                    End If
                    If (outerNode.Name = "nRec") Then
                        Retornos.nRec = outerNode.InnerText
                    End If
                    If (outerNode.Name = "cStat") Then
                        Retornos.cStat = outerNode.InnerText
                    End If
                    If (outerNode.Name = "xMotivo") Then
                        'Retornos.xMotivo = outerNode.InnerText
                        'If Retornos.xMotivo = "Lote em processamento" Then
                        '    bolProcessando = True
                        'Else
                        '    bolProcessando = False
                        'End If

                        Retornos.xMotivo = outerNode.InnerText
                        If Retornos.xMotivo = "Lote em processamento" Then
                            bolProcessando = True
                        Else
                            If Retornos.xMotivo.Contains("Rejeição") Then
                                If Retornos.xMotivo.Contains("Consumo") Then
                                    Processando(Retornos.xMotivo & ". Aguarde cerca de 30 min. e tente novamente!", True)
                                    parOK = "NOK"
                                    Exit Sub
                                End If
                                Processando(Retornos.xMotivo, True)
                                parOK = "NOK"
                                Exit Sub
                            End If
                            bolProcessando = False
                        End If
                    End If
                    If (outerNode.Name = "cUF") Then
                        Retornos.cUF = outerNode.InnerText
                    End If
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "infProt" Then
                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                    If VarRecibo.xMotivo = "Lote em processamento" Then
                                        bolProcessando = True
                                    Else
                                        bolProcessando = False
                                    End If

                                End If
                            Next
                            'ADICIONA A NOTA NA LISTA DE RETORNO
                            Retornos.L_Retornos.Add(VarRecibo)

                            Dim strM As String = VarRecibo.xMotivo
                            ''''MsgBox(VarRecibo.xMotivo, MsgBoxStyle.Information)


                        End If
                    Next
                Next


                If bolProcessando = False Then
                    Processando("Verificando retornos da nota", False)


                    Dim strChave As String = ""

                   

                    For Each RetC As RetRecibo In Retornos.L_Retornos

                        If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                            Processando(RetC.xMotivo, False)

                        
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            Dim strRecibo As String = RetC.XmlRecibo.Replace("<infProt xmlns=""http://www.portalfiscal.inf.br/nfe"">", "<infProt Id=""ID" & VarRecibo.nProt & """>")
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                        Else
                            If RetC.xMotivo.ToUpper.Contains("DENEGADO") = True Or RetC.xMotivo.ToUpper.Contains("DENEGADA") = True Then
                                Dim XmlNota1 As XmlDocument = New XmlDocument
                                XmlNota1.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                GerarNotaProcessada(SepararNota(XmlNota1.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                MsgBox(RetC.xMotivo, MsgBoxStyle.Information)
                                parOK = "OK"
                                Exit Sub
                            End If
                            Processando(RetC.xMotivo, True)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)

                            parOK = "NOK"
                            Exit Sub
                        End If
                        strChave = RetC.chNFe
                    Next


                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If

                    parOK = "OK"
                Else
                    Contador15Segundos()

                End If
            End While





        Catch ex As Exception
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select
        End Try



    End Sub

    Private Sub Enviar4(ByRef parOK As String)
        If TLS12 = True Then
            Try
                System.Net.ServicePointManager.SecurityProtocol = 3072
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If

        Dim intTimeout As Integer = 100000
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\TimeoutNFCe.txt") = True Then
            intTimeout = LerArquivo(My.Application.Info.DirectoryPath & "\TimeoutNFCe.txt", False).Trim
        End If
        'Try
        '    System.Net.ServicePointManager.SecurityProtocol = 3072
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try
        'ENVIA LOTE DE NOTAS VERSÃO 2.00
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strCcc As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeAutorizacao4.NFeAutorizacao4
            Dim cab As New wsNFeAutorizacao4.nfeCabecMsg

            'UF E VERSÃO DO CABEÇALHO
            'cab.versaoDados = VersaoXmlAutorizacao

            'cab.cUF = SelecionarCodigoUF(strUF)

            Dim Notas As String
            'CABEÇALHO USADA PARA ENVIO DE LOTE

            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If
            wsMsg = New wsNFeAutorizacao4.NFeAutorizacao4(URLNfe)


            wsMsg.Url = URLNfe
            'wsMsg.nfeCabecMsgValue = cab
          
            wsMsg.Timeout = intTimeout
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12
            Notas = xmldoc.OuterXml

            'RETORNO DA SEFAZ

            ' MsgBox("1", MsgBoxStyle.Information)
            strRetorno = wsMsg.nfeAutorizacaoLote(xmldoc)

            Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf

            'strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            'strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
            'strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            'strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
            'strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf

            'Dim SW As New StreamWriter("C:\NANONFCe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

            'SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

            'SW.Close() 'Fecha o arquivo de texto

            'SW.Dispose() 'Libera a memória utilizada

            '''MsgBox("1", MsgBoxStyle.Information)

            'DESMEMBRA RETORNO XML
            ' Dim StrRetNota As RetEnvio = Nothing
            Dim XmlText As XmlDocument = New XmlDocument

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In strRetorno
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        xMotivo = InnerNode.InnerText
                        If xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                        If xMotivo.Contains("Rejeicao") = True Then
                            bolRetorno = False
                        End If
                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nRec" Or outerNode.Name = "nRec") Then
                        nRec = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tMed" Or outerNode.Name = "tMed") Then
                        tMed = InnerNode.InnerText
                    End If
                Next
            Next

            If bolRetorno = False Then
                Processando(cStat & " " & xMotivo, True)
                parOK = "NOK"
                Exit Sub
            End If
        Catch ex As Exception
            ConsultaNfe4(parOK, strChaveAcesso, "NFe", "", False)
            parOK = parOK
            Exit Sub

        End Try

        Dim RetonoConsulta As New RetRetorno
        Processando("Aguardando processamento das informações", False)

        Contador15Segundos()

        '''MsgBox("2", MsgBoxStyle.Information)
        Try
            Dim wsMsg As wsNFeRetAutorizacao4.NfeRetAutorizacao4
            Dim cab As New wsNFeRetAutorizacao4.nfeCabecMsg

            'UF E VERSÃO DO CABEÇALHO
            ''cab.cUF = SelecionarCodigoUF(strUF)
            ''cab.versaoDados = VersaoXmlAutorizacao

            'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE

            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERETRECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERETRECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If

            wsMsg = New wsNFeRetAutorizacao4.NfeRetAutorizacao4(URLNfe)
            wsMsg.Url = URLNfe

            'ASSOCIA CABEÇALHO NFE
            ''wsMsg.nfeCabecMsgValue = cab

            'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
      
            wsMsg.Timeout = intTimeout

            'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
            wsMsg.ClientCertificates.Add(CERT)

            'DEFINE PROTOCOLO USADO NA CONEXÃO
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'CRIA UM NOVO DOCUMENTO XML
            Dim dados As XmlDocument = New XmlDocument

            'ASSOCIA O NOVO XML COM A VARIAVEL DE RETORNO DA SEFAZ
            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlAutorizacao & """><tpAmb>" & strTipoAmb & "</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")


            MsgBox(intTimeout, MsgBoxStyle.Information)

            'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
            Dim bolProcessando As Boolean = True

            While bolProcessando = True


                strRetorno = wsMsg.nfeRetAutorizacaoLote(dados)
                MsgBox("4", MsgBoxStyle.Information)

                'DESMEMBRA RETORNO XML
                '-----------------------------------------------------------------------------------
                'VARIAVER QUE VAI RECEBER O RETORNO
                Dim Retornos As New RetRetorno
                'CRIA LISTA PARA RECEBER RETORNOS
                Retornos.L_Retornos = New List(Of RetRecibo)
                'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO

                Dim VarRecibo As New RetRecibo

                'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
                For Each outerNode As XmlNode In strRetorno
                    'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
                    If (outerNode.Name = "tpAmb") Then
                        Retornos.tpAmb = outerNode.InnerText
                    End If
                    If (outerNode.Name = "verAplic") Then
                        Retornos.verAplic = outerNode.InnerText
                    End If
                    If (outerNode.Name = "nRec") Then
                        Retornos.nRec = outerNode.InnerText
                    End If
                    If (outerNode.Name = "cStat") Then
                        Retornos.cStat = outerNode.InnerText
                    End If
                    If (outerNode.Name = "xMotivo") Then
                        Retornos.xMotivo = outerNode.InnerText
                        If Retornos.xMotivo = "Lote em processamento" Then
                            bolProcessando = True
                        Else
                            If Retornos.xMotivo.Contains("Rejeição") Then
                                If Retornos.xMotivo.Contains("Consumo") Then
                                    Processando(Retornos.xMotivo & ". Aguarde cerca de 30 min. e tente novamente!", True)
                                    parOK = "NOK"
                                    Exit Sub
                                End If
                                Processando(Retornos.xMotivo, True)
                                parOK = "NOK"
                                Exit Sub
                            End If
                            bolProcessando = False
                        End If


                    End If
                    If (outerNode.Name = "cUF") Then
                        Retornos.cUF = outerNode.InnerText
                    End If
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "infProt" Then
                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                    If VarRecibo.xMotivo = "Lote em processamento" Then
                                        bolProcessando = True
                                    Else
                                        bolProcessando = False
                                    End If

                                End If
                            Next
                            'ADICIONA A NOTA NA LISTA DE RETORNO
                            Retornos.L_Retornos.Add(VarRecibo)
                            MsgBox(VarRecibo.xMotivo, MsgBoxStyle.Information)
                        End If
                    Next
                Next


                If bolProcessando = False Then
                    Processando("Verificando retornos da nota", False)


                    Dim strChave As String = ""



                    For Each RetC As RetRecibo In Retornos.L_Retornos

                        If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                            Processando(RetC.xMotivo, False)


                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            Dim strRecibo As String = RetC.XmlRecibo.Replace("<infProt xmlns=""http://www.portalfiscal.inf.br/nfe"">", "<infProt Id=""ID" & VarRecibo.nProt & """>")
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                        Else
                            If RetC.xMotivo.ToUpper.Contains("DENEGADO") = True Or RetC.xMotivo.ToUpper.Contains("DENEGADA") = True Then
                                Dim XmlNota1 As XmlDocument = New XmlDocument
                                XmlNota1.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                GerarNotaProcessada(SepararNota(XmlNota1.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                MsgBox(RetC.xMotivo, MsgBoxStyle.Information)
                                parOK = "OK"
                                Exit Sub
                            End If
                            Processando(RetC.xMotivo, True)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)

                            parOK = "NOK"
                            Exit Sub
                        End If
                        strChave = RetC.chNFe
                    Next

                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If
                    parOK = "OK"
                Else
                    Contador15Segundos()

                End If
            End While





        Catch ex As Exception
            ConsultaNfe4(parOK, strChaveAcesso, "NFe", "", False)
        End Try
    End Sub
    Private Sub EnviarPR(ByRef parOK As String)
        'ENVIA LOTE DE NOTAS VERSÃO 2.00
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strCcc As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)

        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeAutorizacaoPR.NfeAutorizacao3
            Dim cab As New wsNFeAutorizacaoPR.nfeCabecMsg

            cab.versaoDados = VersaoXmlAutorizacao

            cab.cUF = SelecionarCodigoUF(strUF)

            Dim Notas As String
            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If
            wsMsg = New wsNFeAutorizacaoPR.NfeAutorizacao3(URLNfe)

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12
            Notas = xmldoc.OuterXml

            'If ExisteConexaoInternet() = False Then
            '    Processando("Verifique sua conexão com a internet", True)
            '    If strStatus = "AGUARDANDO" Then
            '        strArquivo = ""
            '    Else
            '        strArquivo = "NOK"
            '    End If
            '    Exit Sub
            'End If
            strRetorno = wsMsg.nfeAutorizacaoLote(xmldoc)

            'Dim strTeste1 As String = wsMsg.Url & vbCrLf & vbCrLf
            'strTeste1 &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            'strTeste1 &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            'strTeste1 &= wsMsg.Timeout & vbCrLf & vbCrLf
            'strTeste1 &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            'strTeste1 &= strRetorno.InnerXml & vbCrLf & vbCrLf
            'strTeste1 &= strRetorno.OuterXml & vbCrLf & vbCrLf


            'Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto1.txt") ' Cria o arquivo de texto

            'SW.WriteLine(strTeste1) ' Grava uma linha no arquivo de texto

            'SW.Close() 'Fecha o arquivo de texto

            'SW.Dispose() 'Libera a memória utilizada

            Dim XmlText As XmlDocument = New XmlDocument

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In strRetorno
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        xMotivo = InnerNode.InnerText
                        If xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                        If xMotivo.Contains("Rejeicao") = True Then
                            bolRetorno = False
                        End If

                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nRec" Or outerNode.Name = "nRec") Then
                        nRec = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tMed" Or outerNode.Name = "tMed") Then
                        tMed = InnerNode.InnerText
                    End If
                Next
            Next

            If bolRetorno = False Then
                Processando(cStat & " " & xMotivo, True)
                parOK = "NOK"
                Exit Sub
            End If

        Catch ex As Exception
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select

            Exit Sub
        End Try

        Dim RetonoConsulta As New RetRetorno
        Processando("Aguardando processamento das informações", False)

        Contador15Segundos()


        Try
            Dim wsMsg As wsNFeRetAutorizacaoPR.NfeRetAutorizacao3
            Dim cab As New wsNFeRetAutorizacaoPR.nfeCabecMsg

            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlAutorizacao
            URLNfe = ""
            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERETRECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERETRECEPCAOHOMOLOGA")
            End If
            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If

            wsMsg = New wsNFeRetAutorizacaoPR.NfeRetAutorizacao3(URLNfe)
            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab
            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            Dim dados As XmlDocument = New XmlDocument

            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlAutorizacao & """><tpAmb>" & strTipoAmb & "</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")

            Dim bolProcessando As Boolean = True

            While bolProcessando = True
                strRetorno = wsMsg.nfeRetAutorizacao(dados)

                'Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf
                'strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
                'strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
                'strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
                'strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
                'strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
                'strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf


                'Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

                'SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

                'SW.Close() 'Fecha o arquivo de texto

                'SW.Dispose() 'Libera a memória utilizada


                Dim Retornos As New RetRetorno

                Retornos.L_Retornos = New List(Of RetRecibo)
                Dim VarRecibo As New RetRecibo
                For Each outerNode As XmlNode In strRetorno
                    If (outerNode.Name = "tpAmb") Then
                        Retornos.tpAmb = outerNode.InnerText
                    End If
                    If (outerNode.Name = "verAplic") Then
                        Retornos.verAplic = outerNode.InnerText
                    End If
                    If (outerNode.Name = "nRec") Then
                        Retornos.nRec = outerNode.InnerText
                    End If
                    If (outerNode.Name = "cStat") Then
                        Retornos.cStat = outerNode.InnerText
                    End If
                    If (outerNode.Name = "xMotivo") Then
                        Retornos.xMotivo = outerNode.InnerText
                        If Retornos.xMotivo = "Lote em processamento" Then
                            bolProcessando = True
                        Else
                            bolProcessando = False
                        End If
                    End If
                    If (outerNode.Name = "cUF") Then
                        Retornos.cUF = outerNode.InnerText
                    End If
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml
                        If InnerNode.Name = "infProt" Then
                            VarRecibo.Id = ""
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                    If VarRecibo.xMotivo = "Lote em processamento" Then
                                        bolProcessando = True
                                    Else
                                        bolProcessando = False
                                    End If
                                End If
                            Next
                            Retornos.L_Retornos.Add(VarRecibo)
                            MsgBox(VarRecibo.xMotivo, MsgBoxStyle.Information)
                        End If
                    Next
                Next

                If bolProcessando = False Then
                    Processando("Verificando retornos da nota", False)
                    Dim strChave As String = ""
                    For Each RetC As RetRecibo In Retornos.L_Retornos
                        If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                            Processando(RetC.xMotivo, False)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            Dim strRecibo As String = RetC.XmlRecibo.Replace("<infProt xmlns=""http://www.portalfiscal.inf.br/nfe"">", "<infProt Id=""ID" & VarRecibo.nProt & """>")
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                        Else
                            If RetC.xMotivo.ToUpper.Contains("DENEGADO") = True Or RetC.xMotivo.ToUpper.Contains("DENEGADA") = True Then
                                Dim XmlNota1 As XmlDocument = New XmlDocument
                                XmlNota1.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                GerarNotaProcessada(SepararNota(XmlNota1.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                MsgBox(RetC.xMotivo, MsgBoxStyle.Information)
                                parOK = "OK"
                                Exit Sub
                            End If
                            Processando(RetC.xMotivo, True)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                            parOK = "NOK"
                            Exit Sub
                        End If
                        strChave = RetC.chNFe
                    Next
                    Try
                        Dim bolImp As Boolean = True
                        If MensImpCupomNFCe = True Then

                            If MsgBox("Deseja imprimir o cupom NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                bolImp = False
                            End If

                        End If
                        Dim bolSatEmitido As Boolean = False
                        If bolImp = True Then
                            Try
                                GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                                bolSatEmitido = True
                            Catch ex As Exception
                                bolSatEmitido = False
                            End Try

                            If bolSatEmitido = False Then
                                Try
                                    GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas), False)
                                Catch ex As Exception
                                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                                End Try

                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                    End Try
                    parOK = "OK"
                Else
                    Contador15Segundos()
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select
        End Try
    End Sub

    Private Sub EnviarMT(ByRef parOK As String)
        'ENVIA LOTE DE NOTAS VERSÃO 2.00
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strCcc As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)

        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeAutorizacaoMT.NfeAutorizacaoMT
            Dim cab As New wsNFeAutorizacaoMT.nfeCabecMsg

            cab.versaoDados = VersaoXmlAutorizacao

            cab.cUF = SelecionarCodigoUF(strUF)

            Dim Notas As String
            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If
            wsMsg = New wsNFeAutorizacaoMT.NfeAutorizacaoMT(URLNfe)

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12
            Notas = xmldoc.OuterXml

            'If ExisteConexaoInternet() = False Then
            '    Processando("Verifique sua conexão com a internet", True)
            '    If strStatus = "AGUARDANDO" Then
            '        strArquivo = ""
            '    Else
            '        strArquivo = "NOK"
            '    End If
            '    Exit Sub
            'End If

            strRetorno = wsMsg.nfeAutorizacaoLote(xmldoc)

            Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf
            strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
            strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
            strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf


            Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

            SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

            SW.Close() 'Fecha o arquivo de texto

            SW.Dispose() 'Libera a memória utilizada

            Dim XmlText As XmlDocument = New XmlDocument

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In strRetorno
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        xMotivo = InnerNode.InnerText
                        If xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                        If xMotivo.Contains("Rejeicao") = True Then
                            bolRetorno = False
                        End If
                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nRec" Or outerNode.Name = "nRec") Then
                        nRec = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tMed" Or outerNode.Name = "tMed") Then
                        tMed = InnerNode.InnerText
                    End If
                Next
            Next

            If bolRetorno = False Then
                Processando(cStat & " " & xMotivo, True)
                parOK = "NOK"
                Exit Sub
            End If
        Catch ex As Exception
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select

            Exit Sub
        End Try

        Dim RetonoConsulta As New RetRetorno
        Processando("Aguardando processamento das informações", False)

        Contador15Segundos()


        Try
            Dim wsMsg As wsNFeRetAutorizacao.NfeRetAutorizacao
            Dim cab As New wsNFeRetAutorizacao.nfeCabecMsg
            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlAutorizacao
            URLNfe = ""
            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERETRECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERETRECEPCAOHOMOLOGA")
            End If
            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If

            wsMsg = New wsNFeRetAutorizacao.NfeRetAutorizacao(URLNfe)
            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab
            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            Dim dados As XmlDocument = New XmlDocument

            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlAutorizacao & """><tpAmb>" & strTipoAmb & "</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")

            Dim bolProcessando As Boolean = True

            While bolProcessando = True
                strRetorno = wsMsg.nfeRetAutorizacaoLote(dados)


                Dim strTeste1 As String = wsMsg.Url & vbCrLf & vbCrLf
                strTeste1 &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
                strTeste1 &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
                strTeste1 &= wsMsg.Timeout & vbCrLf & vbCrLf
                strTeste1 &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
                strTeste1 &= strRetorno.InnerXml & vbCrLf & vbCrLf
                strTeste1 &= strRetorno.OuterXml & vbCrLf & vbCrLf


                Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto1.txt") ' Cria o arquivo de texto

                SW.WriteLine(strTeste1) ' Grava uma linha no arquivo de texto

                SW.Close() 'Fecha o arquivo de texto

                SW.Dispose() 'Libera a memória utilizada

                Dim Retornos As New RetRetorno

                Retornos.L_Retornos = New List(Of RetRecibo)
                Dim VarRecibo As New RetRecibo
                For Each outerNode As XmlNode In strRetorno
                    If (outerNode.Name = "tpAmb") Then
                        Retornos.tpAmb = outerNode.InnerText
                    End If
                    If (outerNode.Name = "verAplic") Then
                        Retornos.verAplic = outerNode.InnerText
                    End If
                    If (outerNode.Name = "nRec") Then
                        Retornos.nRec = outerNode.InnerText
                    End If
                    If (outerNode.Name = "cStat") Then
                        Retornos.cStat = outerNode.InnerText
                    End If
                    If (outerNode.Name = "xMotivo") Then
                        Retornos.xMotivo = outerNode.InnerText
                        If Retornos.xMotivo = "Lote em processamento" Then
                            bolProcessando = True
                        Else
                            bolProcessando = False
                        End If
                    End If
                    If (outerNode.Name = "cUF") Then
                        Retornos.cUF = outerNode.InnerText
                    End If
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml
                        If InnerNode.Name = "infProt" Then
                            VarRecibo.Id = ""
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                    If VarRecibo.xMotivo = "Lote em processamento" Then
                                        bolProcessando = True
                                    Else
                                        bolProcessando = False
                                    End If
                                End If
                            Next
                            Retornos.L_Retornos.Add(VarRecibo)
                            MsgBox(VarRecibo.xMotivo, MsgBoxStyle.Information)
                        End If
                    Next
                Next

                If bolProcessando = False Then
                    Processando("Verificando retornos da nota", False)
                    Dim strChave As String = ""
                    For Each RetC As RetRecibo In Retornos.L_Retornos
                        If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                            Processando(RetC.xMotivo, False)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            Dim strRecibo As String = RetC.XmlRecibo.Replace("<infProt xmlns=""http://www.portalfiscal.inf.br/nfe"">", "<infProt Id=""ID" & VarRecibo.nProt & """>")
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                        Else
                            If RetC.xMotivo.ToUpper.Contains("DENEGADO") = True Or RetC.xMotivo.ToUpper.Contains("DENEGADA") = True Then
                                Dim XmlNota1 As XmlDocument = New XmlDocument
                                XmlNota1.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                GerarNotaProcessada(SepararNota(XmlNota1.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                MsgBox(RetC.xMotivo, MsgBoxStyle.Information)
                                parOK = "OK"
                                Exit Sub
                            End If
                            Processando(RetC.xMotivo, True)
                            Dim XmlNota As XmlDocument = New XmlDocument
                            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                            parOK = "NOK"
                            Exit Sub
                        End If
                        strChave = RetC.chNFe
                    Next
                    Try
                        Dim bolImp As Boolean = True
                        If MensImpCupomNFCe = True Then

                            If MsgBox("Deseja imprimir o cupom NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                bolImp = False
                            End If

                        End If
                        Dim bolSatEmitido As Boolean = False
                        If bolImp = True Then
                            Try
                                GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                                bolSatEmitido = True
                            Catch ex As Exception
                                bolSatEmitido = False
                            End Try

                            If bolSatEmitido = False Then
                                Try
                                    GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas), False)
                                Catch ex As Exception
                                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                                End Try

                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                    End Try
                    parOK = "OK"
                Else
                    Contador15Segundos()
                End If
            End While
        Catch ex As Exception
            Select Case strUF
                Case "BA"
                    ConsultaNfeBA(parOK, strChaveAcesso, "NFe", "", False)
                Case "PR"
                    ConsultaNfePR(parOK, strChaveAcesso, "NFe", "", False)
                Case Else
                    ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)
            End Select
        End Try
    End Sub

    Private Sub EnviarMT2(ByRef parOK As String)
        'ENVIA LOTE DE NOTAS VERSÃO 2.00
        Dim verAplic As String
        Dim cStat As String
        Dim xMotivo As String
        Dim cUF As String
        Dim nRec As String
        Dim dhRecbto As String
        Dim tMed As String
        Dim XmlRecibo As String

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strCcc As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)

        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeAutorizacaoMT.NfeAutorizacaoMT
            Dim cab As New wsNFeAutorizacaoMT.nfeCabecMsg

            cab.versaoDados = VersaoXmlAutorizacao

            cab.cUF = SelecionarCodigoUF(strUF)

            Dim Notas As String
            URLNfe = ""

            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFERECEPCAO")
            Else
                URLNfe = WebService(strUF, "NFERECEPCAOHOMOLOGA")
            End If

            If URLNfe = "" Then
                Processando("Não foi possível encontrar o arquivo webservice", True)
                strArquivo = "NOK"
                Exit Sub
            End If
            wsMsg = New wsNFeAutorizacaoMT.NfeAutorizacaoMT(URLNfe)

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12
            Notas = xmldoc.OuterXml

            'If ExisteConexaoInternet() = False Then
            '    Processando("Verifique sua conexão com a internet", True)
            '    If strStatus = "AGUARDANDO" Then
            '        strArquivo = ""
            '    Else
            '        strArquivo = "NOK"
            '    End If
            '    Exit Sub
            'End If

            strRetorno = wsMsg.nfeAutorizacaoLote(xmldoc)

            Dim Retornos As New RetRetorno
            Dim bolProcessando As Boolean = True
            Retornos.L_Retornos = New List(Of RetRecibo)
            Dim VarRecibo As New RetRecibo
            For Each outerNode As XmlNode In strRetorno
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                    If Retornos.xMotivo = "Lote em processamento" Then
                        bolProcessando = True
                    Else
                        bolProcessando = False
                    End If
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    VarRecibo.XmlRecibo = InnerNode.OuterXml
                    If InnerNode.Name = "infProt" Then
                        VarRecibo.Id = ""
                        For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                            If (InnerNode2.Name = "tpAmb") Then
                                VarRecibo.tpAmb = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "verAplic") Then
                                VarRecibo.verAplic = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "chNFe") Then
                                VarRecibo.chNFe = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "dhRecbto") Then
                                VarRecibo.dhRecbto = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "nProt") Then
                                VarRecibo.nProt = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "digVal") Then
                                VarRecibo.digVal = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "cStat") Then
                                VarRecibo.cStat = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "xMotivo") Then
                                VarRecibo.xMotivo = InnerNode2.InnerText
                                If VarRecibo.xMotivo = "Lote em processamento" Then
                                    bolProcessando = True
                                Else
                                    bolProcessando = False
                                End If
                            End If
                        Next
                        Retornos.L_Retornos.Add(VarRecibo)
                        MsgBox(VarRecibo.xMotivo, MsgBoxStyle.Information)
                    End If
                Next
            Next

            If bolProcessando = False Then
                Processando("Verificando retornos da nota", False)
                Dim strChave As String = ""
                For Each RetC As RetRecibo In Retornos.L_Retornos
                    If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                        Processando(RetC.xMotivo, False)
                        Dim XmlNota As XmlDocument = New XmlDocument
                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                        Dim strRecibo As String = RetC.XmlRecibo.Replace("<infProt xmlns=""http://www.portalfiscal.inf.br/nfe"">", "<infProt Id=""ID" & VarRecibo.nProt & """>")
                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                    Else
                        If RetC.xMotivo.ToUpper.Contains("DENEGADO") = True Or RetC.xMotivo.ToUpper.Contains("DENEGADA") = True Then
                            Dim XmlNota1 As XmlDocument = New XmlDocument
                            XmlNota1.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                            GerarNotaProcessada(SepararNota(XmlNota1.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                            MsgBox(RetC.xMotivo, MsgBoxStyle.Information)
                            parOK = "OK"
                            Exit Sub
                        End If
                        Processando(RetC.xMotivo, True)
                        Dim XmlNota As XmlDocument = New XmlDocument
                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                        parOK = "NOK"
                        Exit Sub
                    End If
                    strChave = RetC.chNFe

                Next

                Try
                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas).Replace(".xml", "") & "-procNfe.xml", False)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarCupomNFCe(strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas), False)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                End Try
                parOK = "OK"
            Else

                ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)

            End If
            

          
        Catch ex As Exception

            ConsultaNfe(parOK, strChaveAcesso, "NFe", "", False)

            Exit Sub
        End Try


    End Sub
    'Private Sub EnviarConsulta(ByRef parOK As String, ByVal paret As String)
    '    'ENVIA LOTE DE NOTAS VERSÃO 2.00
    '    Dim verAplic As String
    '    Dim cStat As String
    '    Dim xMotivo As String
    '    Dim cUF As String
    '    Dim nRec As String
    '    Dim dhRecbto As String
    '    Dim tMed As String
    '    Dim XmlRecibo As String

    '    Dim strRetorno As XmlElement
    '    Dim xmldoc = New XmlDocument()
    '    Dim strCcc As String = strCaminhoNfe.Replace("Remessas", "Assinadas")
    '    'Carrega o arquivo XML 
    '    xmldoc.Load(strCaminhoNfe.Replace("Remessas", "Assinadas"))
    '    Dim CERT As X509Certificate2
    '    CERT = certificate

    '    Try
    '        Dim wsMsg As Consulta2.NfeConsulta2
    '        Dim cab As New Consulta2.nfeCabecMsg

    '        'UF E VERSÃO DO CABEÇALHO
    '        cab.cUF = SelecionarCodigoUF(strUF)
    '        cab.versaoDados = "2.00"

    '        'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE
    '        wsMsg = New Consulta2.NfeConsulta2

    '        URLNfe = ""
    '        If strTipoAmb = "1" Then
    '            URLNfe = WebService(strUF, "NFECONSULTA")
    '        Else
    '            URLNfe = WebService(strUF, "NFECONSULTAHOMOLOGA")
    '        End If

    '        If URLNfe = "" Then
    '            Processando("Não foi possível encontrar o arquivo webservice", True)
    '            strArquivo = "NOK"
    '            Exit Sub
    '        End If

    '        wsMsg.Url = URLNfe

    '        'ASSOCIA CABEÇALHO NFE
    '        wsMsg.nfeCabecMsgValue = cab

    '        'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
    '        wsMsg.Timeout = 100000

    '        'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
    '        wsMsg.ClientCertificates.Add(CERT)

    '        'DEFINE PROTOCOLO USADO NA CONEXÃO
    '        wsMsg.SoapVersion = SoapProtocolVersion.Soap12

    '        'CRIA UM NOVO DOCUMENTO XML
    '        Dim dados As XmlDocument = New XmlDocument

    '        'ASSOCIA O NOVO XML COM A VARIAVEL DE RETORNO DA SEFAZ
    '        If strTipoAmb = "1" Then
    '            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""2.00""><tpAmb>1</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")

    '        Else
    '            dados.LoadXml("<?xml version=""1.0"" encoding=""utf-8""?><consReciNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""2.00""><tpAmb>2</tpAmb><nRec>" & nRec & "</nRec></consReciNFe>")

    '        End If

    '        'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
    '        If ExisteConexaoInternet() = False Then
    '            Processando("Verifique sua conexão com a internet", True)
    '            strArquivo = "NOK"
    '            Exit Sub
    '        End If

    '        strRetorno = wsMsg.nfeConsultaNF2(dados)

    '        'DESMEMBRA RETORNO XML
    '        '-----------------------------------------------------------------------------------
    '        'VARIAVER QUE VAI RECEBER O RETORNO
    '        Dim Retornos As New RetRetorno
    '        'CRIA LISTA PARA RECEBER RETORNOS
    '        Retornos.L_Retornos = New List(Of RetRecibo)
    '        'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO
    '        Dim VarRecibo As New RetRecibo

    '        'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
    '        For Each outerNode As XmlNode In strRetorno
    '            'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
    '            If (outerNode.Name = "tpAmb") Then
    '                Retornos.tpAmb = outerNode.InnerText
    '            End If
    '            If (outerNode.Name = "verAplic") Then
    '                Retornos.verAplic = outerNode.InnerText
    '            End If
    '            If (outerNode.Name = "nRec") Then
    '                Retornos.nRec = outerNode.InnerText
    '            End If
    '            If (outerNode.Name = "cStat") Then
    '                Retornos.cStat = outerNode.InnerText
    '            End If
    '            If (outerNode.Name = "xMotivo") Then
    '                Retornos.xMotivo = outerNode.InnerText
    '            End If
    '            If (outerNode.Name = "cUF") Then
    '                Retornos.cUF = outerNode.InnerText
    '            End If
    '            For Each InnerNode As XmlNode In outerNode.ChildNodes
    '                VarRecibo.XmlRecibo = InnerNode.OuterXml

    '                'SE O NOME DO NO FOR infProt ENTRA NO MESMO
    '                If InnerNode.Name = "infProt" Then
    '                    'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
    '                    VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
    '                    'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
    '                    For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
    '                        If (InnerNode2.Name = "tpAmb") Then
    '                            VarRecibo.tpAmb = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "verAplic") Then
    '                            VarRecibo.verAplic = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "chNFe") Then
    '                            VarRecibo.chNFe = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "dhRecbto") Then
    '                            VarRecibo.dhRecbto = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "nProt") Then
    '                            VarRecibo.nProt = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "digVal") Then
    '                            VarRecibo.digVal = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "cStat") Then
    '                            VarRecibo.cStat = InnerNode2.InnerText
    '                        End If
    '                        If (InnerNode2.Name = "xMotivo") Then
    '                            VarRecibo.xMotivo = InnerNode2.InnerText
    '                        End If
    '                    Next
    '                    'ADICIONA A NOTA NA LISTA DE RETORNO
    '                    Retornos.L_Retornos.Add(VarRecibo)
    '                End If
    '            Next
    '        Next
    '        Processando("Verificando retornos da nota", False)

    '        Dim strChave As String = ""
    '        For Each RetC As RetRecibo In Retornos.L_Retornos

    '            If RetC.xMotivo = "Autorizado o uso da NF-e" Then
    '                Processando(RetC.xMotivo, False)

    '                Dim XmlNota As XmlDocument = New XmlDocument
    '                XmlNota.Load(strCaminhoNfe.Replace("Remessas", "Assinadas"))
    '                GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace("Remessas", "Assinadas").Replace(".Xml", ""), Date.Today)
    '            Else
    '                Processando(RetC.xMotivo, True)
    '                Dim XmlNota As XmlDocument = New XmlDocument
    '                XmlNota.Load(strCaminhoNfe.Replace("Remessas", "Assinadas"))
    '                GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, strCaminhoNfe.Replace("Remessas", "Assinadas").Replace(".Xml", ""), Date.Today)

    '                parOK = "NOK"
    '                Exit Sub
    '            End If
    '            strChave = RetC.chNFe
    '        Next
    '        Try
    '            GerarDanfe.GerarDanfe(PastaNotaNfe.Replace("Remessas", "Autorizadas") & "\" & strChave & "-procNfe.xml", True)

    '        Catch ex As Exception
    '            MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
    '        End Try
    '       parOK = "OK"

    '    Catch ex As Exception
    '        Processando(ex.Message, True)
    '        parOK = "NOK"
    '    End Try



    'End Sub
    Private Sub EnviarEvento(ByRef parOK As String)

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strdd As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As RecepcaoEvento.RecepcaoEvento
            Dim cab As New RecepcaoEvento.nfeCabecMsg

            cab.cUF = SelecionarCodigoUF(strUF)

            cab.versaoDados = VersaoXmlEvento

            'CABEÇALHO USADA PARA ENVIO DE LOTE
            wsMsg = New RecepcaoEvento.RecepcaoEvento()

            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "RECEPCAOEVENTO")
            Else
                URLNfe = WebService(strUF, "RECEPCAOEVENTOHOMOLOGA")
            End If


            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'RETORNO DA SEFAZ

            strRetorno = wsMsg.nfeRecepcaoEvento(xmldoc)

            'DESMEMBRA RETORNO XML
            Dim StrRetCarta As RetornoEvento = Nothing
            Dim XmlText As XmlDocument = New XmlDocument

            Dim nodelist As XmlNodeList = strRetorno.ChildNodes

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In nodelist

                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "versao" Or outerNode.Name = "versao") Then
                        StrRetCarta.versao = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "idLote" Or outerNode.Name = "idLote") Then
                        StrRetCarta.IdLote = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tpAmb" Or outerNode.Name = "tbAmb") Then
                        StrRetCarta.tpAmb = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        StrRetCarta.verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cOrgao" Or outerNode.Name = "cOrgao") Then
                        StrRetCarta.cOrgao = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then

                        StrRetCarta.cStat = InnerNode.InnerText
                       
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        StrRetCarta.xMotivo = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "retEvento" Or outerNode.Name = "retEvento") Then
                        StrRetCarta.XmlRecibo = outerNode.OuterXml
                        For Each n As XmlNode In InnerNode

                            If (n.Name = "infEvento" Or InnerNode.Name = "infEvento") Then
                                For Each n2 As XmlNode In n
                                    If (n2.Name = "Id" Or n.Name = "Id") Then
                                        StrRetCarta.infEvento.Id = n.InnerText
                                    End If
                                    If (n2.Name = "tpAmb" Or n.Name = "tpAmb") Then
                                        StrRetCarta.infEvento.tpAmb = n.InnerText
                                    End If
                                    If (n2.Name = "verAplic" Or n.Name = "verAplic") Then
                                        StrRetCarta.infEvento.verAplic = n.InnerText
                                    End If
                                    If (n2.Name = "cOrgao" Or n.Name = "cOrgao") Then
                                        StrRetCarta.infEvento.cOrgao = n.InnerText
                                    End If
                                    If (n2.Name = "cStat" Or n.Name = "cStat") Then
                                        StrRetCarta.infEvento.cStat = n.InnerText
                                    End If
                                    If (n2.Name = "xMotivo" Or n.Name = "xMotivo") Then
                                        StrRetCarta.infEvento.xMotivo = n.InnerText
                                        If StrRetCarta.infEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        End If
                                    End If
                                    If (n2.Name = "chNFe" Or n.Name = "chNFe") Then
                                        StrRetCarta.infEvento.chNfe = n.InnerText
                                    End If
                                    If (n2.Name = "tpEvento" Or n.Name = "tpEvento") Then
                                        StrRetCarta.infEvento.tpEvento = n.InnerText
                                    End If
                                    If (n2.Name = "xEvento" Or n.Name = "xEvento") Then
                                        StrRetCarta.infEvento.xEvento = n.InnerText
                                    End If
                                    If (n2.Name = "nSeqEvento" Or n.Name = "nSeqEvento") Then
                                        StrRetCarta.infEvento.nSeqEvento = n.InnerText
                                    End If
                                    If (n2.Name = "CNPJDest" Or n.Name = "CNPJDest") Then
                                        StrRetCarta.infEvento.CNPJDest = n.InnerText
                                    End If
                                    If (n2.Name = "CPFDest" Or n.Name = "CPFDest") Then
                                        StrRetCarta.infEvento.CPFDest = n.InnerText
                                    End If
                                    If (n2.Name = "emailDest" Or n.Name = "emailDest") Then
                                        StrRetCarta.infEvento.emailDest = n.InnerText
                                    End If
                                    If (n2.Name = "dhRegEvento" Or n.Name = "dhRegEvento") Then
                                        StrRetCarta.infEvento.dhRetEvento = n.InnerText
                                    End If
                                    If (n2.Name = "nProt" Or n.Name = "nProt") Then
                                        StrRetCarta.infEvento.nProt = n.InnerText
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Next
            Dim XmlNota As XmlDocument = New XmlDocument
            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), StrRetCarta.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
            If bolRetorno = True Then
                Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                Try
                  
                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom de cancelamento do NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarEvento(strCaminho)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarEvento(strCaminho)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                End Try
              
                parOK = "OK"
            Else
                Processando(StrRetCarta.infEvento.xMotivo, True)
                parOK = "NOK"
            End If

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information, "")
            'If ex.Message.Contains("esgotou") Or ex.Message.Contains("O tempo limite da operação foi atingido") Then
            ConsultaNfe(parOK, strChaveAcesso, strTipoEvento, strNumSeq, False)
            'End If
        End Try



    End Sub
    Private Sub EnviarEvento4(ByRef parOK As String)
        If TLS12 = True Then
            Try
                System.Net.ServicePointManager.SecurityProtocol = 3072
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strdd As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeRecepcaoEvento4.NFeRecepcaoEvento4
            Dim cab As New wsNFeRecepcaoEvento4.nfeCabecMsg

            'cab.cUF = SelecionarCodigoUF(strUF)

            'cab.versaoDados = VersaoXmlEvento

            'CABEÇALHO USADA PARA ENVIO DE LOTE
           
            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "RECEPCAOEVENTO")
            Else
                URLNfe = WebService(strUF, "RECEPCAOEVENTOHOMOLOGA")
            End If

            wsMsg = New wsNFeRecepcaoEvento4.NFeRecepcaoEvento4(URLNfe)

            wsMsg.Url = URLNfe
            'wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'RETORNO DA SEFAZ

            strRetorno = wsMsg.nfeRecepcaoEvento4(xmldoc)

            'DESMEMBRA RETORNO XML
            Dim StrRetCarta As RetornoEvento = Nothing
            Dim XmlText As XmlDocument = New XmlDocument

            Dim nodelist As XmlNodeList = strRetorno.ChildNodes

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In nodelist

                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "versao" Or outerNode.Name = "versao") Then
                        StrRetCarta.versao = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "idLote" Or outerNode.Name = "idLote") Then
                        StrRetCarta.IdLote = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "tpAmb" Or outerNode.Name = "tbAmb") Then
                        StrRetCarta.tpAmb = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        StrRetCarta.verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cOrgao" Or outerNode.Name = "cOrgao") Then
                        StrRetCarta.cOrgao = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then

                        StrRetCarta.cStat = InnerNode.InnerText

                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        StrRetCarta.xMotivo = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "retEvento" Or outerNode.Name = "retEvento") Then
                        StrRetCarta.XmlRecibo = outerNode.OuterXml
                        For Each n As XmlNode In InnerNode

                            If (n.Name = "infEvento" Or InnerNode.Name = "infEvento") Then
                                For Each n2 As XmlNode In n
                                    If (n2.Name = "Id" Or n.Name = "Id") Then
                                        StrRetCarta.infEvento.Id = n.InnerText
                                    End If
                                    If (n2.Name = "tpAmb" Or n.Name = "tpAmb") Then
                                        StrRetCarta.infEvento.tpAmb = n.InnerText
                                    End If
                                    If (n2.Name = "verAplic" Or n.Name = "verAplic") Then
                                        StrRetCarta.infEvento.verAplic = n.InnerText
                                    End If
                                    If (n2.Name = "cOrgao" Or n.Name = "cOrgao") Then
                                        StrRetCarta.infEvento.cOrgao = n.InnerText
                                    End If
                                    If (n2.Name = "cStat" Or n.Name = "cStat") Then
                                        StrRetCarta.infEvento.cStat = n.InnerText
                                    End If
                                    If (n2.Name = "xMotivo" Or n.Name = "xMotivo") Then
                                        StrRetCarta.infEvento.xMotivo = n.InnerText
                                        If StrRetCarta.infEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        End If
                                    End If
                                    If (n2.Name = "chNFe" Or n.Name = "chNFe") Then
                                        StrRetCarta.infEvento.chNfe = n.InnerText
                                    End If
                                    If (n2.Name = "tpEvento" Or n.Name = "tpEvento") Then
                                        StrRetCarta.infEvento.tpEvento = n.InnerText
                                    End If
                                    If (n2.Name = "xEvento" Or n.Name = "xEvento") Then
                                        StrRetCarta.infEvento.xEvento = n.InnerText
                                    End If
                                    If (n2.Name = "nSeqEvento" Or n.Name = "nSeqEvento") Then
                                        StrRetCarta.infEvento.nSeqEvento = n.InnerText
                                    End If
                                    If (n2.Name = "CNPJDest" Or n.Name = "CNPJDest") Then
                                        StrRetCarta.infEvento.CNPJDest = n.InnerText
                                    End If
                                    If (n2.Name = "CPFDest" Or n.Name = "CPFDest") Then
                                        StrRetCarta.infEvento.CPFDest = n.InnerText
                                    End If
                                    If (n2.Name = "emailDest" Or n.Name = "emailDest") Then
                                        StrRetCarta.infEvento.emailDest = n.InnerText
                                    End If
                                    If (n2.Name = "dhRegEvento" Or n.Name = "dhRegEvento") Then
                                        StrRetCarta.infEvento.dhRetEvento = n.InnerText
                                    End If
                                    If (n2.Name = "nProt" Or n.Name = "nProt") Then
                                        StrRetCarta.infEvento.nProt = n.InnerText
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Next
            Dim XmlNota As XmlDocument = New XmlDocument
            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), StrRetCarta.XmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
            If bolRetorno = True Then
                Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                Try

                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom de cancelamento do NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarEvento(strCaminho)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarEvento(strCaminho)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                End Try

                parOK = "OK"
            Else
                Processando(StrRetCarta.infEvento.xMotivo, True)
                parOK = "NOK"
            End If

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information, "")
            'If ex.Message.Contains("esgotou") Or ex.Message.Contains("O tempo limite da operação foi atingido") Then
            ConsultaNfe4(parOK, strChaveAcesso, strTipoEvento, strNumSeq, False)
            'End If
        End Try



    End Sub
    Private Sub ConsultaNfe4(ByRef parOk As String, ByVal parChave As String, ByVal parTipo As String, ByVal parNumSeq As String, ByVal parConsultarAnterior As Boolean)
        If TLS12 = True Then
            Try
                System.Net.ServicePointManager.SecurityProtocol = 3072
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        'Try
        '    System.Net.ServicePointManager.SecurityProtocol = 3072
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try
        Dim strNotaConsultada As String = ""
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim CERT As X509Certificate2
        CERT = certificate

        parOk = ""
        Try
            Dim wsMsg As wsNFeConsulta4.NfeConsulta4
            Dim cab As New wsNFeConsulta4.nfeCabecMsg
            strTipoAmb = strTipoAmb.Substring(0, 1)
            'UF E VERSÃO DO CABEÇALHO
            'cab.cUF = SelecionarCodigoUF(strUF)
            'cab.versaoDados = VersaoXmlConsulta

            'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE
            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "NFECONSULTA")
            Else
                URLNfe = WebService(strUF, "NFECONSULTAHOMOLOGA")
            End If

            wsMsg = New wsNFeConsulta4.NfeConsulta4(URLNfe)

            wsMsg.Url = URLNfe
            'wsMsg.nfeCabecMsgValue = cab

            'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
            wsMsg.Timeout = 100000

            'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
            wsMsg.ClientCertificates.Add(CERT)

            'DEFINE PROTOCOLO USADO NA CONEXÃO
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'CRIA UM NOVO DOCUMENTO XML
            Dim dados As XmlDocument = New XmlDocument
            Dim sDados As String = vbNullString

            sDados &= "<consSitNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlConsulta & """>"
            sDados &= "<tpAmb>" & strTipoAmb & "</tpAmb>"
            sDados &= "<xServ>CONSULTAR</xServ>"
            sDados &= "<chNFe>" & parChave & "</chNFe>"
            sDados &= "</consSitNFe>"


            dados.LoadXml(sDados)
            'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
            strRetorno = wsMsg.nfeConsultaNF(dados)

            'Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            'strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
            'strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            'strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
            'strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf


            'Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

            'SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

            'SW.Close() 'Fecha o arquivo de texto

            'SW.Dispose() 'Libera a memória utilizada
            'DESMEMBRA RETORNO XML
            '-----------------------------------------------------------------------------------
            'VARIAVER QUE VAI RECEBER O RETORNO
            Dim Retornos As New RetRetorno
            Dim strXmlRecibo As String = ""
            'CRIA LISTA PARA RECEBER RETORNOS
            Retornos.L_Retornos = New List(Of RetRecibo)
            'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO
            Dim VarRecibo As New RetRecibo
            Dim VarReciboEvento As New SEvento
            Dim bolRetorno As Boolean = False
            'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
            For Each outerNode As XmlNode In strRetorno
                'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                If parTipo = "NFe" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        If InnerNode.Name = "infProt" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                End If
                            Next
                            'ADICIONA A NOTA NA LISTA DE RETORNO
                            Retornos.L_Retornos.Add(VarRecibo)

                            Dim strChave As String = ""
                            For Each RetC As RetRecibo In Retornos.L_Retornos

                                If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                                    Processando(RetC.xMotivo, False)

                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)
                                Else
                                    Processando(RetC.xMotivo, True)
                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)

                                    parOk = "NOK"
                                    Exit Sub
                                End If
                                strChave = RetC.chNFe
                            Next
                            'If parConsultarAnterior = False Then
                            '    Try
                            '        If NanoBanco = "0" Then
                            '            GerarDanfe.GerarDanfe(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                            '        Else
                            '            GerarDanfe.GerarDanfeAccess(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                            '        End If

                            '    Catch ex As Exception
                            '        MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                            '    End Try
                            'End If

                            parOk = "OK"
                            Exit Sub
                        End If
                    Next
                ElseIf parTipo = "Evento" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "retEvento" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo = InnerNode2.OuterXml
                                    For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                        If (InnerNode3.Name = "tpAmb") Then
                                            VarReciboEvento.tpAmb = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "verAplic") Then
                                            VarReciboEvento.verAplic = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cOrgao") Then
                                            VarReciboEvento.cOrgao = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cStat") Then
                                            VarReciboEvento.cStat = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xMotivo") Then
                                            VarReciboEvento.xMotivo = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "chNfe") Then
                                            VarReciboEvento.chNfe = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "tpEvento") Then
                                            VarReciboEvento.tpEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xEvento") Then
                                            VarReciboEvento.xEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nSeqEvento") Then
                                            VarReciboEvento.nSeqEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "CNPJDest") Then
                                            VarReciboEvento.CNPJDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "emailDest") Then
                                            VarReciboEvento.emailDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nProt") Then
                                            VarReciboEvento.nProt = InnerNode3.InnerText
                                        End If
                                    Next
                                    Dim strTipoEvento As String
                                    If parTipo = "Evento" Then
                                        strTipoEvento = "110110"
                                    Else
                                        strTipoEvento = "110111"
                                    End If
                                    If VarReciboEvento.nSeqEvento = parNumSeq And VarReciboEvento.tpEvento = strTipoEvento Then
                                        If VarReciboEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        Else
                                            bolRetorno = True
                                        End If

                                        Dim XmlNota As XmlDocument = New XmlDocument

                                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                        If bolRetorno = True Then
                                            Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                                            'If parConsultarAnterior = False Then
                                            '    Try
                                            '        If NanoBanco = "0" Then
                                            '            GerarDanfe.GerarEvento(strCaminho, True, Me.Tag)

                                            '        Else
                                            '            GerarDanfe.GerarEventoAccess(strCaminho, True, Me.Tag)

                                            '        End If

                                            '    Catch ex As Exception
                                            '        MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                            '    End Try

                                            'End If

                                            parOk = "OK"
                                            Exit Sub
                                        Else
                                            Processando(VarReciboEvento.xMotivo, True)
                                            parOk = "NOK"
                                            Exit Sub
                                        End If
                                    End If
                                End If

                            Next

                        End If
                    Next

                Else
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO

                        If InnerNode.Name = "infProt" Then
                            strXmlRecibo = InnerNode.OuterXml

                            strNotaConsultada = "NFE|"
                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            'For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                            '    If (InnerNode2.Name = "tpAmb") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "verAplic") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "chNFe") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "dhRecbto") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "digVal") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "nProt") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "cStat") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "xMotivo") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            'Next

                        End If
                    Next
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "retEvento" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            strNotaConsultada &= "EVENTO|"
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then

                                    strXmlRecibo &= InnerNode2.OuterXml
                                    'For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                    '    If (InnerNode3.Name = "tpAmb") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "verAplic") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "cOrgao") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "cStat") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "xMotivo") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "chNfe") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "tpEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "xEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "nSeqEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "CNPJDest") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "emailDest") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "nProt") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    'Next


                                End If

                            Next

                        End If
                    Next
                End If

            Next
            If strNotaConsultada <> "" Then
                frmMenuNFCe.strRetorno = strXmlRecibo
                parOk = "OK"
            Else
                Processando("Nota não emitida!", True)
                parOk = "NOK"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFechar.Enabled = True
        End Try

    End Sub
    Private Sub ConsultaNfe(ByRef parOk As String, ByVal parChave As String, ByVal parTipo As String, ByVal parNumSeq As String, ByVal parConsultarAnterior As Boolean)
        Dim strNotaConsultada As String = ""
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim CERT As X509Certificate2
        CERT = certificate

        parOk = ""
        Try
            Dim wsMsg As Consulta2.NfeConsulta2
            Dim cab As New Consulta2.nfeCabecMsg
            strTipoAmb = strTipoAmb.Substring(0, 1)
            'UF E VERSÃO DO CABEÇALHO
            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlConsulta

            'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE
            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "NFECONSULTA")
            Else
                URLNfe = WebService(strUF, "NFECONSULTAHOMOLOGA")
            End If
           
            wsMsg = New Consulta2.NfeConsulta2

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
            wsMsg.Timeout = 100000

            'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
            wsMsg.ClientCertificates.Add(CERT)

            'DEFINE PROTOCOLO USADO NA CONEXÃO
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'CRIA UM NOVO DOCUMENTO XML
            Dim dados As XmlDocument = New XmlDocument
            Dim sDados As String = vbNullString

            sDados &= "<consSitNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlConsulta & """>"
            sDados &= "<tpAmb>" & strTipoAmb & "</tpAmb>"
            sDados &= "<xServ>CONSULTAR</xServ>"
            sDados &= "<chNFe>" & parChave & "</chNFe>"
            sDados &= "</consSitNFe>"


            dados.LoadXml(sDados)
            'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
            strRetorno = wsMsg.nfeConsultaNF2(dados)

            'Dim strTeste As String = wsMsg.Url & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.cUF & vbCrLf & vbCrLf
            'strTeste &= wsMsg.nfeCabecMsgValue.versaoDados & vbCrLf & vbCrLf
            'strTeste &= wsMsg.Timeout & vbCrLf & vbCrLf
            'strTeste &= "SoapProtocolVersion.Soap12" & vbCrLf & vbCrLf
            'strTeste &= strRetorno.InnerXml & vbCrLf & vbCrLf
            'strTeste &= strRetorno.OuterXml & vbCrLf & vbCrLf


            'Dim SW As New StreamWriter("C:\NANONFe\MeuArquivoDeTexto.txt") ' Cria o arquivo de texto

            'SW.WriteLine(strTeste) ' Grava uma linha no arquivo de texto

            'SW.Close() 'Fecha o arquivo de texto

            'SW.Dispose() 'Libera a memória utilizada
            'DESMEMBRA RETORNO XML
            '-----------------------------------------------------------------------------------
            'VARIAVER QUE VAI RECEBER O RETORNO
            Dim Retornos As New RetRetorno
            Dim strXmlRecibo As String = ""
            'CRIA LISTA PARA RECEBER RETORNOS
            Retornos.L_Retornos = New List(Of RetRecibo)
            'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO
            Dim VarRecibo As New RetRecibo
            Dim VarReciboEvento As New SEvento
            Dim bolRetorno As Boolean = False
            'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
            For Each outerNode As XmlNode In strRetorno
                'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                If parTipo = "NFe" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        If InnerNode.Name = "infProt" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                End If
                            Next
                            'ADICIONA A NOTA NA LISTA DE RETORNO
                            Retornos.L_Retornos.Add(VarRecibo)

                            Dim strChave As String = ""
                            For Each RetC As RetRecibo In Retornos.L_Retornos

                                If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                                    Processando(RetC.xMotivo, False)

                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)
                                Else
                                    Processando(RetC.xMotivo, True)
                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)

                                    parOk = "NOK"
                                    Exit Sub
                                End If
                                strChave = RetC.chNFe
                            Next
                            If parConsultarAnterior = False Then
                                Try
                                    'If NanoBanco = "0" Then
                                    '    GerarDanfe.GerarDanfe(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'Else
                                    '    GerarDanfe.GerarDanfeAccess(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'End If
                                   
                                Catch ex As Exception
                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                End Try
                            End If

                            parOk = "OK"
                            Exit Sub
                        End If
                    Next
                ElseIf parTipo = "Evento" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "retEvento" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo = InnerNode2.OuterXml
                                    For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                        If (InnerNode3.Name = "tpAmb") Then
                                            VarReciboEvento.tpAmb = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "verAplic") Then
                                            VarReciboEvento.verAplic = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cOrgao") Then
                                            VarReciboEvento.cOrgao = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cStat") Then
                                            VarReciboEvento.cStat = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xMotivo") Then
                                            VarReciboEvento.xMotivo = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "chNfe") Then
                                            VarReciboEvento.chNfe = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "tpEvento") Then
                                            VarReciboEvento.tpEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xEvento") Then
                                            VarReciboEvento.xEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nSeqEvento") Then
                                            VarReciboEvento.nSeqEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "CNPJDest") Then
                                            VarReciboEvento.CNPJDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "emailDest") Then
                                            VarReciboEvento.emailDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nProt") Then
                                            VarReciboEvento.nProt = InnerNode3.InnerText
                                        End If
                                    Next
                                    Dim strTipoEvento As String
                                    If parTipo = "Evento" Then
                                        strTipoEvento = "110110"
                                    Else
                                        strTipoEvento = "110111"
                                    End If
                                    If VarReciboEvento.nSeqEvento = parNumSeq And VarReciboEvento.tpEvento = strTipoEvento Then
                                        If VarReciboEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        Else
                                            bolRetorno = True
                                        End If

                                        Dim XmlNota As XmlDocument = New XmlDocument

                                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                        If bolRetorno = True Then
                                            Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                                            If parConsultarAnterior = False Then
                                                Try
                                                    'If NanoBanco = "0" Then
                                                    '    GerarDanfe.GerarEvento(strCaminho, True, Me.Tag)

                                                    'Else
                                                    '    GerarDanfe.GerarEventoAccess(strCaminho, True, Me.Tag)

                                                    'End If
                                                  
                                                Catch ex As Exception
                                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                                End Try

                                            End If

                                            parOk = "OK"
                                            Exit Sub
                                        Else
                                            Processando(VarReciboEvento.xMotivo, True)
                                            parOk = "NOK"
                                            Exit Sub
                                        End If
                                    End If
                                End If

                            Next

                        End If
                    Next

                Else
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO

                        If InnerNode.Name = "infProt" Then
                            strXmlRecibo = InnerNode.OuterXml

                            strNotaConsultada = "NFE|"
                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            'For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                            '    If (InnerNode2.Name = "tpAmb") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "verAplic") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "chNFe") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "dhRecbto") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "digVal") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "nProt") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "cStat") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            '    If (InnerNode2.Name = "xMotivo") Then
                            '        strNotaConsultada &= InnerNode2.InnerText & "|"
                            '    End If
                            'Next

                        End If
                    Next
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                        If InnerNode.Name = "retEvento" Then

                            'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                            VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                            'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                            strNotaConsultada &= "EVENTO|"
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then

                                    strXmlRecibo &= InnerNode2.OuterXml
                                    'For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                    '    If (InnerNode3.Name = "tpAmb") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "verAplic") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "cOrgao") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "cStat") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "xMotivo") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "chNfe") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "tpEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "xEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "nSeqEvento") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "CNPJDest") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "emailDest") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    '    If (InnerNode3.Name = "nProt") Then
                                    '        strNotaConsultada &= InnerNode3.InnerText & "|"
                                    '    End If
                                    'Next


                                End If

                            Next

                        End If
                    Next
                End If

            Next
            If strNotaConsultada <> "" Then
                frmMenuNFCe.strRetorno = strXmlRecibo
                parOk = "OK"
            Else
                Processando("Nota não emitida!", True)
                parOk = "NOK"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFechar.Enabled = True
        End Try

    End Sub

    Private Sub ConsultaNfeBA(ByRef parOk As String, ByVal parChave As String, ByVal parTipo As String, ByVal parNumSeq As String, ByVal parConsultarAnterior As Boolean)
        Dim strNotaConsultada As String = ""
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim CERT As X509Certificate2
        CERT = certificate
        parOk = ""
        Try
            Dim wsMsg As ConsultaBA.NfeConsulta
            Dim cab As New ConsultaBA.nfeCabecMsg
            strTipoAmb = strTipoAmb.Substring(0, 1)

            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlConsulta
            URLNfe = ""
            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFECONSULTA")
            Else
                URLNfe = WebService(strUF, "NFECONSULTAHOMOLOGA")
            End If
            wsMsg = New ConsultaBA.NfeConsulta

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab
            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            Dim dados As XmlDocument = New XmlDocument
            Dim sDados As String = vbNullString

            sDados &= "<consSitNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlConsulta & """>"
            sDados &= "<tpAmb>" & strTipoAmb & "</tpAmb>"
            sDados &= "<xServ>CONSULTAR</xServ>"
            sDados &= "<chNFe>" & parChave & "</chNFe>"
            sDados &= "</consSitNFe>"

            dados.LoadXml(sDados)

            strRetorno = wsMsg.nfeConsultaNF(dados)

            Dim Retornos As New RetRetorno
            Dim strXmlRecibo As String = ""

            Retornos.L_Retornos = New List(Of RetRecibo)

            Dim VarRecibo As New RetRecibo
            Dim VarReciboEvento As New SEvento
            Dim bolRetorno As Boolean = False

            For Each outerNode As XmlNode In strRetorno
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                If parTipo = "NFe" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        If InnerNode.Name = "infProt" Then
                            VarRecibo.Id = "" 
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                End If
                            Next

                            Retornos.L_Retornos.Add(VarRecibo)

                            Dim strChave As String = ""
                            For Each RetC As RetRecibo In Retornos.L_Retornos

                                If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                                    Processando(RetC.xMotivo, False)

                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)
                                Else
                                    Processando(RetC.xMotivo, True)
                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)

                                    parOk = "NOK"
                                    Exit Sub
                                End If
                                strChave = RetC.chNFe
                            Next
                            If parConsultarAnterior = False Then
                                Try
                                    'If NanoBanco = "0" Then
                                    '    GerarDanfe.GerarDanfe(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'Else
                                    '    GerarDanfe.GerarDanfeAccess(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'End If

                                Catch ex As Exception
                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                End Try
                            End If

                            parOk = "OK"
                            Exit Sub
                        End If
                    Next
                ElseIf parTipo = "Evento" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "retEvento" Then
                            VarRecibo.Id = "" 
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo = InnerNode2.OuterXml
                                    For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                        If (InnerNode3.Name = "tpAmb") Then
                                            VarReciboEvento.tpAmb = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "verAplic") Then
                                            VarReciboEvento.verAplic = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cOrgao") Then
                                            VarReciboEvento.cOrgao = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cStat") Then
                                            VarReciboEvento.cStat = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xMotivo") Then
                                            VarReciboEvento.xMotivo = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "chNfe") Then
                                            VarReciboEvento.chNfe = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "tpEvento") Then
                                            VarReciboEvento.tpEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xEvento") Then
                                            VarReciboEvento.xEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nSeqEvento") Then
                                            VarReciboEvento.nSeqEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "CNPJDest") Then
                                            VarReciboEvento.CNPJDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "emailDest") Then
                                            VarReciboEvento.emailDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nProt") Then
                                            VarReciboEvento.nProt = InnerNode3.InnerText
                                        End If
                                    Next
                                    Dim strTipoEvento As String
                                    If parTipo = "Evento" Then
                                        strTipoEvento = "110110"
                                    Else
                                        strTipoEvento = "110111"
                                    End If
                                    If VarReciboEvento.nSeqEvento = parNumSeq And VarReciboEvento.tpEvento = strTipoEvento Then
                                        If VarReciboEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        Else
                                            bolRetorno = True
                                        End If

                                        Dim XmlNota As XmlDocument = New XmlDocument

                                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                        If bolRetorno = True Then
                                            Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                                            If parConsultarAnterior = False Then
                                                Try
                                                    'If NanoBanco = "0" Then
                                                    '    GerarDanfe.GerarEvento(strCaminho, True, Me.Tag)

                                                    'Else
                                                    '    GerarDanfe.GerarEventoAccess(strCaminho, True, Me.Tag)

                                                    'End If

                                                Catch ex As Exception
                                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                                End Try

                                            End If

                                            parOk = "OK"
                                            Exit Sub
                                        Else
                                            Processando(VarReciboEvento.xMotivo, True)
                                            parOk = "NOK"
                                            Exit Sub
                                        End If
                                    End If
                                End If

                            Next

                        End If
                    Next

                Else
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "infProt" Then
                            strXmlRecibo = InnerNode.OuterXml
                            strNotaConsultada = "NFE|"
                            VarRecibo.Id = "" 
                        End If
                    Next
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "retEvento" Then
                            VarRecibo.Id = ""
                            strNotaConsultada &= "EVENTO|"
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo &= InnerNode2.OuterXml
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            If strNotaConsultada <> "" Then
                frmConsultaChave2.strRetorno = strXmlRecibo
                parOk = "OK"
            Else
                Processando("Nota não emitida!", True)
                parOk = "NOK"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFechar.Enabled = True
        End Try

    End Sub

    Private Sub ConsultaNfePR(ByRef parOk As String, ByVal parChave As String, ByVal parTipo As String, ByVal parNumSeq As String, ByVal parConsultarAnterior As Boolean)
        Dim strNotaConsultada As String = ""
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim CERT As X509Certificate2
        CERT = certificate
        parOk = ""
        Try
            Dim wsMsg As ConsultaPR.NfeConsulta3
            Dim cab As New ConsultaPR.nfeCabecMsg
            strTipoAmb = strTipoAmb.Substring(0, 1)

            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlConsulta
            URLNfe = ""
            If strTipoAmb = "1" Then
                URLNfe = WebService(strUF, "NFECONSULTA")
            Else
                URLNfe = WebService(strUF, "NFECONSULTAHOMOLOGA")
            End If
            wsMsg = New ConsultaPR.NfeConsulta3

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab
            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            Dim dados As XmlDocument = New XmlDocument
            Dim sDados As String = vbNullString

            sDados &= "<consSitNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""" & VersaoXmlConsulta & """>"
            sDados &= "<tpAmb>" & strTipoAmb & "</tpAmb>"
            sDados &= "<xServ>CONSULTAR</xServ>"
            sDados &= "<chNFe>" & parChave & "</chNFe>"
            sDados &= "</consSitNFe>"

            dados.LoadXml(sDados)

            strRetorno = wsMsg.nfeConsultaNF(dados)

            Dim Retornos As New RetRetorno
            Dim strXmlRecibo As String = ""

            Retornos.L_Retornos = New List(Of RetRecibo)

            Dim VarRecibo As New RetRecibo
            Dim VarReciboEvento As New SEvento
            Dim bolRetorno As Boolean = False

            For Each outerNode As XmlNode In strRetorno
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                If parTipo = "NFe" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        VarRecibo.XmlRecibo = InnerNode.OuterXml

                        If InnerNode.Name = "infProt" Then
                            VarRecibo.Id = ""
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If (InnerNode2.Name = "tpAmb") Then
                                    VarRecibo.tpAmb = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "verAplic") Then
                                    VarRecibo.verAplic = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "chNFe") Then
                                    VarRecibo.chNFe = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "dhRecbto") Then
                                    VarRecibo.dhRecbto = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "digVal") Then
                                    VarRecibo.digVal = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "nProt") Then
                                    VarRecibo.nProt = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "cStat") Then
                                    VarRecibo.cStat = InnerNode2.InnerText
                                End If
                                If (InnerNode2.Name = "xMotivo") Then
                                    VarRecibo.xMotivo = InnerNode2.InnerText
                                End If
                            Next

                            Retornos.L_Retornos.Add(VarRecibo)

                            Dim strChave As String = ""
                            For Each RetC As RetRecibo In Retornos.L_Retornos

                                If RetC.xMotivo = "Autorizado o uso da NF-e" Then
                                    Processando(RetC.xMotivo, False)

                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)
                                Else
                                    Processando(RetC.xMotivo, True)
                                    Dim XmlNota As XmlDocument = New XmlDocument
                                    XmlNota.Load(PastaAssinadas & "\" & parChave & ".xml")
                                    GerarNotaProcessada(SepararNota(XmlNota.OuterXml), RetC.XmlRecibo, PastaAssinadas & "\" & parChave, Date.Today)

                                    parOk = "NOK"
                                    Exit Sub
                                End If
                                strChave = RetC.chNFe
                            Next
                            If parConsultarAnterior = False Then
                                Try
                                    'If NanoBanco = "0" Then
                                    '    GerarDanfe.GerarDanfe(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'Else
                                    '    GerarDanfe.GerarDanfeAccess(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)

                                    'End If

                                Catch ex As Exception
                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                End Try
                            End If

                            parOk = "OK"
                            Exit Sub
                        End If
                    Next
                ElseIf parTipo = "Evento" Then
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "retEvento" Then
                            VarRecibo.Id = ""
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes

                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo = InnerNode2.OuterXml
                                    For Each InnerNode3 As XmlNode In InnerNode2.ChildNodes
                                        If (InnerNode3.Name = "tpAmb") Then
                                            VarReciboEvento.tpAmb = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "verAplic") Then
                                            VarReciboEvento.verAplic = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cOrgao") Then
                                            VarReciboEvento.cOrgao = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "cStat") Then
                                            VarReciboEvento.cStat = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xMotivo") Then
                                            VarReciboEvento.xMotivo = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "chNfe") Then
                                            VarReciboEvento.chNfe = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "tpEvento") Then
                                            VarReciboEvento.tpEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "xEvento") Then
                                            VarReciboEvento.xEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nSeqEvento") Then
                                            VarReciboEvento.nSeqEvento = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "CNPJDest") Then
                                            VarReciboEvento.CNPJDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "emailDest") Then
                                            VarReciboEvento.emailDest = InnerNode3.InnerText
                                        End If
                                        If (InnerNode3.Name = "nProt") Then
                                            VarReciboEvento.nProt = InnerNode3.InnerText
                                        End If
                                    Next
                                    Dim strTipoEvento As String
                                    If parTipo = "Evento" Then
                                        strTipoEvento = "110110"
                                    Else
                                        strTipoEvento = "110111"
                                    End If
                                    If VarReciboEvento.nSeqEvento = parNumSeq And VarReciboEvento.tpEvento = strTipoEvento Then
                                        If VarReciboEvento.xMotivo.Contains("Rejeição") = True Then
                                            bolRetorno = False
                                        Else
                                            bolRetorno = True
                                        End If

                                        Dim XmlNota As XmlDocument = New XmlDocument

                                        XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
                                        GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXmlRecibo, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
                                        If bolRetorno = True Then
                                            Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procEven.xml")
                                            If parConsultarAnterior = False Then
                                                Try
                                                    'If NanoBanco = "0" Then
                                                    '    GerarDanfe.GerarEvento(strCaminho, True, Me.Tag)

                                                    'Else
                                                    '    GerarDanfe.GerarEventoAccess(strCaminho, True, Me.Tag)

                                                    'End If

                                                Catch ex As Exception
                                                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                                                End Try

                                            End If

                                            parOk = "OK"
                                            Exit Sub
                                        Else
                                            Processando(VarReciboEvento.xMotivo, True)
                                            parOk = "NOK"
                                            Exit Sub
                                        End If
                                    End If
                                End If

                            Next

                        End If
                    Next

                Else
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "infProt" Then
                            strXmlRecibo = InnerNode.OuterXml
                            strNotaConsultada = "NFE|"
                            VarRecibo.Id = ""
                        End If
                    Next
                    For Each InnerNode As XmlNode In outerNode.ChildNodes
                        If InnerNode.Name = "retEvento" Then
                            VarRecibo.Id = ""
                            strNotaConsultada &= "EVENTO|"
                            For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                                If InnerNode2.Name = "infEvento" Then
                                    strXmlRecibo &= InnerNode2.OuterXml
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            If strNotaConsultada <> "" Then
                frmConsultaChave2.strRetorno = strXmlRecibo
                parOk = "OK"
            Else
                Processando("Nota não emitida!", True)
                parOk = "NOK"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnFechar.Enabled = True
        End Try

    End Sub
    Private Sub EnviarInutilizacao(ByRef parOK As String)

        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strdd As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As NfeInutilizacao2.NfeInutilizacao2
            Dim cab As New NfeInutilizacao2.nfeCabecMsg

            cab.cUF = SelecionarCodigoUF(strUF)
            cab.versaoDados = VersaoXmlInutilizacao

            'CABEÇALHO USADA PARA ENVIO DE LOTE
            wsMsg = New NfeInutilizacao2.NfeInutilizacao2

            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "NFEINUTILIZACAO")
            Else
                URLNfe = WebService(strUF, "NFEINUTILIZACAOHOMOLOGA")
            End If




            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'RETORNO DA SEFAZ

            strRetorno = wsMsg.nfeInutilizacaoNF2(xmldoc)

            'DESMEMBRA RETORNO XML
            Dim strRetInut As RetornoInutilizacao = Nothing
            Dim XmlText As XmlDocument = New XmlDocument
            Dim strXML As String = ""
            Dim nodelist As XmlNodeList = strRetorno.ChildNodes

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In nodelist
               For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "tpAmb" Or outerNode.Name = "tpAmb") Then
                        strRetInut.tpAmb = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        strRetInut.verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        strRetInut.cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        strRetInut.xMotivo = InnerNode.InnerText
                        If strRetInut.xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        strRetInut.cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "ano" Or outerNode.Name = "ano") Then
                        strRetInut.ano = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "CNPJ" Or outerNode.Name = "CNPJ") Then
                        strRetInut.CNPJ = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "mod" Or outerNode.Name = "mod") Then
                        strRetInut.strmod = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "serie" Or outerNode.Name = "serie") Then
                        strRetInut.serie = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nNFIni" Or outerNode.Name = "nNFIni") Then
                        strRetInut.nNFIni = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nNFFin" Or outerNode.Name = "nNFFin") Then
                        strRetInut.nNFFin = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        strRetInut.dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nProt" Or outerNode.Name = "nProt") Then
                        strRetInut.nProt = InnerNode.InnerText
                    End If
                Next
            Next
            If strRetorno.OuterXml <> "" Then
                strXML = strRetorno.OuterXml
            End If

            Dim strff As String = ""
            Dim XmlNota As XmlDocument = New XmlDocument
            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXML, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
            If bolRetorno = True Then
                Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procInut.xml")
                Try
                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom de inutilização de numeração do NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarInutilizacao(strCaminho)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarEvento(strCaminho)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If
                  
                Catch ex As Exception
                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                End Try

                parOK = "OK"
            Else
                Processando(strRetInut.xMotivo, True)
                parOK = "NOK"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "")
            parOK = "NOK"
        End Try



    End Sub

    Private Sub EnviarInutilizacao4(ByRef parOK As String)
        If TLS12 = True Then
            Try
                System.Net.ServicePointManager.SecurityProtocol = 3072
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim strdd As String = strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas)
        'Carrega o arquivo XML 
        xmldoc.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
        Dim CERT As X509Certificate2
        CERT = certificate
        Try
            Dim wsMsg As wsNFeInutilizacao4.NFeInutilizacao4
            Dim cab As New wsNFeInutilizacao4.nfeCabecMsg

            'cab.cUF = SelecionarCodigoUF(strUF)
            'cab.versaoDados = VersaoXmlInutilizacao

            'CABEÇALHO USADA PARA ENVIO DE LOTE
           
            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "NFEINUTILIZACAO")
            Else
                URLNfe = WebService(strUF, "NFEINUTILIZACAOHOMOLOGA")
            End If


            wsMsg = New wsNFeInutilizacao4.NFeInutilizacao4(URLNfe)


            wsMsg.Url = URLNfe
            ' wsMsg.nfeCabecMsgValue = cab

            wsMsg.Timeout = 100000
            wsMsg.ClientCertificates.Add(CERT)
            wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'RETORNO DA SEFAZ

            strRetorno = wsMsg.nfeInutilizacaoNF(xmldoc)

            'DESMEMBRA RETORNO XML
            Dim strRetInut As RetornoInutilizacao = Nothing
            Dim XmlText As XmlDocument = New XmlDocument
            Dim strXML As String = ""
            Dim nodelist As XmlNodeList = strRetorno.ChildNodes

            Dim bolRetorno As Boolean = True
            For Each outerNode As XmlNode In nodelist
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    If (InnerNode.Name = "tpAmb" Or outerNode.Name = "tpAmb") Then
                        strRetInut.tpAmb = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "verAplic" Or outerNode.Name = "verAplic") Then
                        strRetInut.verAplic = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "cStat" Or outerNode.Name = "cStat") Then
                        strRetInut.cStat = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "xMotivo" Or outerNode.Name = "xMotivo") Then
                        strRetInut.xMotivo = InnerNode.InnerText
                        If strRetInut.xMotivo.Contains("Rejeição") = True Then
                            bolRetorno = False
                        End If
                    End If
                    If (InnerNode.Name = "cUF" Or outerNode.Name = "cUF") Then
                        strRetInut.cUF = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "ano" Or outerNode.Name = "ano") Then
                        strRetInut.ano = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "CNPJ" Or outerNode.Name = "CNPJ") Then
                        strRetInut.CNPJ = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "mod" Or outerNode.Name = "mod") Then
                        strRetInut.strmod = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "serie" Or outerNode.Name = "serie") Then
                        strRetInut.serie = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nNFIni" Or outerNode.Name = "nNFIni") Then
                        strRetInut.nNFIni = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nNFFin" Or outerNode.Name = "nNFFin") Then
                        strRetInut.nNFFin = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "dhRecbto" Or outerNode.Name = "dhRecbto") Then
                        strRetInut.dhRecbto = InnerNode.InnerText
                    End If
                    If (InnerNode.Name = "nProt" Or outerNode.Name = "nProt") Then
                        strRetInut.nProt = InnerNode.InnerText
                    End If
                Next
            Next
            If strRetorno.OuterXml <> "" Then
                strXML = strRetorno.OuterXml
            End If

            Dim strff As String = ""
            Dim XmlNota As XmlDocument = New XmlDocument
            XmlNota.Load(strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas))
            GerarNotaProcessada(SepararNota(XmlNota.OuterXml), strXML, strCaminhoNfe.Replace(PastaRemessas, PastaAssinadas).Replace(".Xml", ""), Date.Today)
            If bolRetorno = True Then
                Dim strCaminho As String = strCaminhoNfe.Replace(PastaRemessas, PastaAutorizadas & "\" & Me.Tag).Replace(".xml", "-procInut.xml")
                Try
                    Dim bolImp As Boolean = True
                    If MensImpCupomNFCe = True Then

                        If MsgBox("Deseja imprimir o cupom de inutilização de numeração do NFC-e?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            bolImp = False
                        End If

                    End If
                    Dim bolSatEmitido As Boolean = False
                    If bolImp = True Then
                        Try
                            GerarNFCe.GerarInutilizacao(strCaminho)
                            bolSatEmitido = True
                        Catch ex As Exception
                            bolSatEmitido = False
                        End Try

                        If bolSatEmitido = False Then
                            Try
                                GerarNFCe.GerarEvento(strCaminho)
                            Catch ex As Exception
                                MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                            End Try

                        End If
                    End If

                Catch ex As Exception
                    MsgBox("Falha ao gerar o danfe!", MsgBoxStyle.Information)
                End Try

                parOK = "OK"
            Else
                Processando(strRetInut.xMotivo, True)
                parOK = "NOK"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "")
            parOK = "NOK"
        End Try



    End Sub

    Public Function GerarNotaProcessada(ByVal vStringNfe As String, ByVal VStringRecibo As String, ByVal NUMERONOTA As String, ByVal EmissaoNota As Date) As String
        Dim cVersaoDados As String = "3.10"
        Processando("Editando NF-e Original", False)
        Dim vStringLoteNfe As String = String.Empty
        Dim PastaNota As String = ""

        Select Case Me.Tag
            Case "NFe"
              
                cVersaoDados = "4.00"

                vStringLoteNfe += "<?xml version=""1.0"" encoding=""utf-8""?>"
                vStringLoteNfe += "<nfeProc versao=""" & cVersaoDados & """ xmlns=""http://www.portalfiscal.inf.br/nfe"">"
                vStringLoteNfe += vStringNfe
                vStringLoteNfe += "<protNFe versao=""" & cVersaoDados & """ xmlns=""http://www.portalfiscal.inf.br/nfe"">"
                vStringLoteNfe += VStringRecibo
                vStringLoteNfe += "</protNFe>"
                vStringLoteNfe += "</nfeProc>"

                PastaNota = NUMERONOTA.Replace("Assinadas", "Autorizadas").Replace(".xml", "") & "-procNfe.xml"
            Case "CCe", "Cancelamento"
                'If strUF = "MT" Then
                '    cVersaoDados = "2.00"
                '    vStringLoteNfe += "<?xml version=""1.0"" encoding=""utf-8""?>"
                '    vStringLoteNfe += "<procEventoNFe versao=""" & cVersaoDados & """ xmlns=""http://www.portalfiscal.inf.br/nfe"">"
                '    vStringLoteNfe += vStringNfe

                '    If VStringRecibo.Contains("retEvento") = False Then
                '        VStringRecibo = "<retEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""2.00"">" & VStringRecibo & "</retEvento>"
                '    End If
                'Else
                cVersaoDados = "1.00"
                vStringLoteNfe += "<?xml version=""1.0"" encoding=""utf-8""?>"
                vStringLoteNfe += "<procEventoNFe versao=""" & cVersaoDados & """ xmlns=""http://www.portalfiscal.inf.br/nfe"">"
                vStringLoteNfe += vStringNfe

                If VStringRecibo.Contains("retEvento") = False Then
                    VStringRecibo = "<retEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & VStringRecibo & "</retEvento>"
                End If
                'End If

                vStringLoteNfe += VStringRecibo
                vStringLoteNfe += "</procEventoNFe>"
                PastaNota = NUMERONOTA.Replace("Assinadas", "Autorizadas\" & Me.Tag & "").Replace(".xml", "") & "-procEven.xml"
            Case "Inut"
                cVersaoDados = "2.00"
                vStringLoteNfe += "<?xml version=""1.0"" encoding=""utf-8""?>"
                vStringLoteNfe += "<procInut>"
                vStringLoteNfe += vStringNfe
                vStringLoteNfe += VStringRecibo
                vStringLoteNfe += "</procInut>"
                PastaNota = NUMERONOTA.Replace("Assinadas", "Autorizadas\" & Me.Tag & "").Replace(".xml", "") & "-procInut.xml"
        End Select




        Dim NDoc As New XmlDocument

        NDoc.LoadXml(vStringLoteNfe)
        Using xmltw As New XmlTextWriter(PastaNota, New UTF8Encoding(False))
            NDoc.WriteTo(xmltw)
            xmltw.Close()
        End Using

        Return PastaNota
    End Function
    Public Function SepararNota(ByVal vNfeDadosMsg As String) As String
        Dim vStringNfe As String = ""
        'Separar somente o conteúdo a partir da tag <NFe> até </NFe>
        Select Case Me.Tag
            Case "NFe"
                Dim nPosI As Int32 = vNfeDadosMsg.IndexOf("<NFe")
                Dim nPosF As Int32 = vNfeDadosMsg.Length - nPosI
                vStringNfe = vNfeDadosMsg.Substring(nPosI, nPosF - 10)
            Case "CCe", "Cancelamento"
                Dim nPosI As Int32 = vNfeDadosMsg.IndexOf("<evento")
                Dim nPosF As Int32 = vNfeDadosMsg.Length - nPosI
                vStringNfe = vNfeDadosMsg.Substring(nPosI, nPosF - 12)
            Case "Inut"
                Dim nPosI As Int32 = vNfeDadosMsg.IndexOf("<inutNFe")
                Dim nPosF As Int32 = vNfeDadosMsg.Length - nPosI
                vStringNfe = vNfeDadosMsg.Substring(nPosI, nPosF - 0)
        End Select
       
        Return vStringNfe

    End Function

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Verificar()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        If strArquivo = "" Then
            'If MsgBox("Deseja verficar se a nota foi emitida?" & vbCrLf & "Esse procedimento poderá demorar cerca de 2 minutos!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '    Dim strRetorno As String = ""
            '    intCont = 1
            '    Select Case Me.Tag
            '        Case "NFe"
            '            ConsultaNfe(strRetorno, strChaveAcesso, "NFe", "", False)

            '        Case "CCe", "Cancelamento"
            '            ConsultaNfe(strRetorno, strChaveAcesso, "Evento", strNumSeq, False)
            '        Case "ConsultaChave"
            '            ConsultaNfe(strRetorno, strChaveAcesso, "", "", False)
            '    End Select
            '    strArquivo = strRetorno
            'Else

            '    Select Case Me.Tag
            '        Case "NFe"
            '            frmEmisaoNfe.strArquivoProcessado = "AGUARDANDO"

            '        Case "CCe"
            '            frmEmissaoCce.strArquivoProcessado = "AGUARDANDO"

            '        Case "Cancelamento"
            '            frmCancelarNFe.strArquivoProcessado = "AGUARDANDO"
            '        Case "Inut"
            '            frmInutilizacao.strArquivoProcessado = "AGUARDANDO"
            '        Case "ConsultaChave"
            '            frmConsultaChave2.strRetorno = "AGUARDANDO"
            '    End Select
            '    Me.Close()
            'End If

            Select Case Me.Tag
                Case "NFe"
                    frmDav.strArquivoProcessado = "AGUARDANDO"
                    'Case "CCe"
                    '    frmEmissaoCce.strArquivoProcessado = "AGUARDANDO"
                    'Case "Cancelamento"
                    '    frmCancelarNFe.strArquivoProcessado = "AGUARDANDO"
                    'Case "Inut"
                    '    frmInutilizacao.strArquivoProcessado = "AGUARDANDO"
                    'Case "ConsultaChave"
                    '    frmConsultaChave2.strRetorno = "AGUARDANDO"
            End Select
        End If
        

        Me.Close()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub
    Private Sub ConsultaStatusWs()
        Dim strRetorno As XmlElement
        Dim xmldoc = New XmlDocument()
        Dim CERT As X509Certificate2
        CERT = certificate


        Try
            Dim wsMsg As StatusServico2.NfeStatusServico2
            Dim cab As New StatusServico2.nfeCabecMsg

            'UF E VERSÃO DO CABEÇALHO
            cab.cUF = SelecionarCodigoUF(strUF)

            cab.versaoDados = "2.00"

            'CRIA UMA INSTANCIA DA CONEXÃO COM O WEBSERVICE
            URLNfe = ""
            'URLNfe = WebService(strUF, "NFECANCELAMENTOHOMOLOGA")
            If strTipoAmb = "1" Then

                URLNfe = WebService(strUF, "NFESTATUSSERVICO")
            Else
                URLNfe = WebService(strUF, "NFESTATUSSERVICOHOMOLOGA")
            End If

            wsMsg = New StatusServico2.NfeStatusServico2()

            wsMsg.Url = URLNfe
            wsMsg.nfeCabecMsgValue = cab

            'DEFINE TEMPO MAXIMO DE ESPERA POR RETORNO
            wsMsg.Timeout = 100000


            'ASSOCIA CERTIFICADO A CONEXAO WEBSERVICE
            wsMsg.ClientCertificates.Add(CERT)

            'DEFINE PROTOCOLO USADO NA CONEXÃO
            'wsMsg.SoapVersion = SoapProtocolVersion.Soap12

            'CRIA UM NOVO DOCUMENTO XML
            Dim dados As XmlDocument = New XmlDocument

            'ASSOCIA O NOVO XML COM A VARIAVEL DE RETORNO DA SEFAZ
            dados.LoadXml("<?xml version=""1.0"" encoding=""UTF-8""?><consStatServ xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""2.00""><tpAmb>" & strTipoAmb & "</tpAmb><cUF>" & SelecionarCodigoUF(strUF) & "</cUF><xServ>STATUS</xServ></consStatServ>")

            'ENVIA CONSULTA PARA SEFAZ E OBTEM RETORNO EM FORMATO STRING
            strRetorno = wsMsg.nfeStatusServicoNF2(dados)

            'DESMEMBRA RETORNO XML
            '-----------------------------------------------------------------------------------
            'VARIAVER QUE VAI RECEBER O RETORNO
            Dim Retornos As New RetRetorno
            'CRIA LISTA PARA RECEBER RETORNOS
            Retornos.L_Retornos = New List(Of RetRecibo)
            'VARIAVEL QUE VAI RECEBER A LISTA ANTES DE SER COLOCADA NO RETORNO
            Dim VarRecibo As New RetRecibo

            'PERCORRE TODOS OS NOS DO XML E PROCURA A TAG DE RETORNO infProt
            For Each outerNode As XmlNode In strRetorno
                'PARA CADA NO VERIFICA SE O MESMO POSSUI FILHOS E VARRE OS MESMOS
                If (outerNode.Name = "tpAmb") Then
                    Retornos.tpAmb = outerNode.InnerText
                End If
                If (outerNode.Name = "verAplic") Then
                    Retornos.verAplic = outerNode.InnerText
                End If
                If (outerNode.Name = "nRec") Then
                    Retornos.nRec = outerNode.InnerText
                End If
                If (outerNode.Name = "cStat") Then
                    Retornos.cStat = outerNode.InnerText
                End If
                If (outerNode.Name = "xMotivo") Then
                    Retornos.xMotivo = outerNode.InnerText
                End If
                If (outerNode.Name = "cUF") Then
                    Retornos.cUF = outerNode.InnerText
                End If
                For Each InnerNode As XmlNode In outerNode.ChildNodes
                    'SE O NOME DO NO FOR infProt ENTRA NO MESMO
                    If InnerNode.Name = "infProt" Then
                        'PEGA A VARIAVEL ID QUE É UM ATRIBUTO E NAO UM ITEM
                        VarRecibo.Id = "" 'InnerNode.Attributes.ItemOf("Id").InnerText
                        'PERCORRE CAMPOS DO RETORNO PARA CAPTURAR AS INFORMAÇÕES
                        For Each InnerNode2 As XmlNode In InnerNode.ChildNodes
                            If (InnerNode2.Name = "tpAmb") Then
                                VarRecibo.tpAmb = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "verAplic") Then
                                VarRecibo.verAplic = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "chNFe") Then
                                VarRecibo.chNFe = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "dhRecbto") Then
                                VarRecibo.dhRecbto = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "digVal") Then
                                VarRecibo.digVal = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "cStat") Then
                                VarRecibo.cStat = InnerNode2.InnerText
                            End If
                            If (InnerNode2.Name = "xMotivo") Then
                                VarRecibo.xMotivo = InnerNode2.InnerText
                            End If
                        Next
                        'ADICIONA A NOTA NA LISTA DE RETORNO
                        Retornos.L_Retornos.Add(VarRecibo)
                    End If
                Next
            Next

      
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "")
            Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Try
    End Sub

    Private Sub btnVerificar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerificar.ItemClick
        intCont = 1
        Dim strRetorno As String = ""
        Select Case Me.Tag

            Case "NFe"
                ConsultaNfe(strRetorno, strChaveAcesso, "NFe", "", False)

            Case "CCe", "Cancelamento"
                ConsultaNfe(strRetorno, strChaveAcesso, "Evento", strNumSeq, False)
            Case "ConsultaChave"
                ConsultaNfe(strRetorno, strChaveAcesso, "", "", False)
        End Select
        strArquivo = strRetorno
    End Sub
End Class