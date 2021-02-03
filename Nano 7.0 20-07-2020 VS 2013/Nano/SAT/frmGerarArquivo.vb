Imports Nano.clsFuncoes
Imports System.IO
Imports System

Imports System.IO.Compression
Imports System.IO.Packaging
Public Class frmGerarArquivo

    Private Sub frmGerarArquivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intAno As Integer
        intAno = 2014
        intAno = Date.Today.Year - 2014

        Dim I As Integer
        Me.cboAno.Properties.Items.Clear()
        For I = 0 To intAno
            Me.cboAno.Properties.Items.Add(2014 + I)
        Next

        Me.cboAno.Enabled = False
        Me.cboMes.Enabled = False
        Me.dtInicial.Enabled = False
        Me.dtFinal.Enabled = False
        Me.txtNumInicial.Enabled = False
        Me.txtNumFinal.Enabled = False
    End Sub

    Private Sub AddToArchive(ByVal zip As Package, _
                     ByVal fileToAdd As String)

        'Replace spaces with an underscore (_) 
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/" 
        Dim zipUri As String = String.Concat("/", _
                   IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = _
                   Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information: 
        ' Where to extract the file when it's extracted (partUri) 
        ' The type of content stream (MIME type):  (contentType) 
        ' The type of compression:  (CompressionOption.Normal)   
        Dim pkgPart As PackagePart = zip.CreatePart(partUri, _
                   contentType, CompressionOption.Normal)

        'Read all of the bytes from the file to add to the zip file 
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file 
        pkgPart.GetStream().Write(bites, 0, bites.Length)

    End Sub

    Private Sub rdgTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTipo.SelectedIndexChanged
        Me.cboAno.Enabled = False
        Me.cboMes.Enabled = False
        Me.dtInicial.Enabled = False
        Me.dtFinal.Enabled = False
        Me.txtNumInicial.Enabled = False
        Me.txtNumFinal.Enabled = False

        Me.cboAno.SelectedIndex = -1
        Me.cboMes.SelectedIndex = -1
        Me.dtInicial.ResetText()
        Me.dtFinal.ResetText()
        Me.txtNumInicial.ResetText()
        Me.txtNumFinal.ResetText()
        Select Case Me.rdgTipo.SelectedIndex
            Case 0
                Me.cboAno.Enabled = True
                Me.cboMes.Enabled = True
                Me.cboMes.Focus()
            Case 1
                Me.dtInicial.Enabled = True
                Me.dtFinal.Enabled = True
                Me.dtInicial.EditValue = Date.Today
                Me.dtFinal.EditValue = Date.Today
                Me.dtInicial.Focus()

            Case 2
                Me.txtNumInicial.Enabled = True
                Me.txtNumFinal.Enabled = True
                Me.txtNumInicial.Focus()
        End Select
    End Sub

    Private Sub txtDestino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDestino.ButtonClick
        Me.fbdDestino.SelectedPath = ""
        Me.fbdDestino.ShowDialog()
        Me.txtDestino.Text = fbdDestino.SelectedPath
    End Sub

    Private Sub btnGerar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGerar.ItemClick
        If Validar(Me.txtDestino) = False Then Exit Sub
        Dim dataFim, dataIni As Date
        Dim intNumInicial, intNumFinal As Integer
        If IO.Directory.Exists(CaminhoPastaSAT) = False Then MsgBox("Pasta Sat não localizada!", MsgBoxStyle.Information) : Exit Sub


        Dim PastaAutorizadas As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas")
        Dim PastaAutorizadasCanc As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento")

        Select Case Me.rdgTipo.SelectedIndex
            Case 0
                If Validar(Me.cboMes) = False Then Exit Sub
                If Validar(Me.cboAno) = False Then Exit Sub
            Case 1
                Dim data1, data2 As String
                data1 = dtInicial.EditValue
                data2 = dtFinal.EditValue

                If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
                If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub


                dataIni = data1
                dataFim = data2

                If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub
            Case 2
                If Me.txtNumInicial.Text = "" Then MsgBox("Selecione o Número Inicial!", MsgBoxStyle.Information) : Exit Sub
                If Me.txtNumFinal.Text = "" Then MsgBox("Selecione a Número Final!", MsgBoxStyle.Information) : Exit Sub


                intNumInicial = Me.txtNumInicial.Text
                intNumFinal = Me.txtNumFinal.Text

                If intNumInicial > intNumFinal Then MsgBox("O Número Inicial não pode ser maior que o Número Final!", MsgBoxStyle.Information) : Exit Sub

            Case Else
                MsgBox("Selecione o tipo de pesquisa!", MsgBoxStyle.Information)
                Exit Sub
        End Select


        Dim strDestino As String = Me.txtDestino.Text & "\ArquivosNFe"
        If IO.Directory.Exists(strDestino) = True Then
            IO.Directory.Delete(strDestino)
        Else
            IO.Directory.CreateDirectory(strDestino)
        End If

        Dim zipPath As String = Me.txtDestino.Text & "\ArquivosNFe.zip"

        If IO.File.Exists(zipPath) = True Then
            IO.File.Delete(zipPath)

        End If

        Dim zip As Package = ZipPackage.Open(zipPath, _
             IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

        Dim bolOk As Boolean = False
        Select Case Me.rdgTipo.SelectedIndex
            Case 0


                Dim strComboMes As String = Format(CInt(Me.cboMes.SelectedIndex), "00")

                If IO.Directory.Exists(PastaAutorizadas) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadas, "*.xml")

                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadas & "\CFe", "")
                        '35160714566555000100550010000008961000000604
                        'CFe35160561099008000141599000022500003801357661
                        Dim strAno As String = strChave.Substring(2, 2)
                        Dim strMes As String = strChave.Substring(4, 2)
                        strAno = "20" & strAno

                        If strComboMes = strMes And Me.cboAno.Text = strAno Then
                            bolOk = True
                            File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadas, strDestino))
                            AddToArchive(zip, strArquivo.Replace(PastaAutorizadas, strDestino))
                        End If


                    Next
                End If



                If IO.Directory.Exists(PastaAutorizadasCanc) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadasCanc, "*.xml")

                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadasCanc & "\CFeCanc", "")

                        Dim strAno As String = strChave.Substring(2, 2)
                        Dim strMes As String = strChave.Substring(4, 2)
                        strAno = "20" & strAno

                        If strComboMes = strMes And Me.cboAno.Text = strAno Then
                            bolOk = True
                            File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                            AddToArchive(zip, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                        End If


                    Next
                End If
            Case 1


                If IO.Directory.Exists(PastaAutorizadas) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadas, "*.xml")

                    Dim strMesInicial As String = Format(CInt(dataIni.Month), "00")
                    Dim strMesFinal As String = Format(CInt(dataFim.Month), "00")
                    Dim strAnoInicial As String = dataIni.Year
                    Dim strAnoFinal As String = dataFim.Year
                    Dim dtDataIni As Date = "01/" & strMesInicial & "/" & strAnoInicial

                    Dim strUltimoDia As String = DateAdd("m", 1, DateSerial(strAnoFinal, strMesFinal, 1))
                    strUltimoDia = DateAdd("d", -1, strUltimoDia)

                    Dim dtDataFim As Date = strUltimoDia
                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadas & "\CFe", "")
                        Dim strCNPJ As String = strChave.Substring(6, 14)

                        Dim strAno As String = strChave.Substring(2, 2)
                        Dim strMes As String = strChave.Substring(4, 2)
                        strAno = "20" & strAno

                        Dim dtData As Date = "01/" & strMes & "/" & strAno

                        If dtDataIni <= dtData And dtDataFim >= dtData Then

                            Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
                            Dim ns As System.Xml.XmlNamespaceManager = New System.Xml.XmlNamespaceManager(oXML.NameTable)
                            Dim NodeRoot As System.Xml.XmlNode

                            ns.AddNamespace("nfe", "")
                            oXML.Load(strArquivo)

                            NodeRoot = oXML.SelectSingleNode("nfe:CFe/nfe:infCFe/nfe:ide", ns)
                            If NodeRoot Is Nothing = False Then
                                Dim strD As String = NodeRoot.Item("dEmi").InnerText.Substring(0, 4) & "/" & NodeRoot.Item("dEmi").InnerText.Substring(4, 2) & "/" & NodeRoot.Item("dEmi").InnerText.Substring(6, 2)
                                Dim dtDataNFe As Date = Format(CDate(strD), "dd/MM/yyyy")

                                If dataIni <= dtDataNFe And dataFim >= dtDataNFe Then
                                    bolOk = True
                                    File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadas, strDestino))
                                    AddToArchive(zip, strArquivo.Replace(PastaAutorizadas, strDestino))
                                End If
                            End If

                        End If




                    Next
                End If



                If IO.Directory.Exists(PastaAutorizadasCanc) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadasCanc, "*.xml")

                    Dim strMesInicial As String = Format(CInt(dataIni.Month), "00")
                    Dim strMesFinal As String = Format(CInt(dataFim.Month), "00")
                    Dim strAnoInicial As String = dataIni.Year
                    Dim strAnoFinal As String = dataFim.Year
                    Dim dtDataIni As Date = "01/" & strMesInicial & "/" & strAnoInicial

                    Dim strUltimoDia As String = DateAdd("m", 1, DateSerial(strAnoFinal, strMesFinal, 1))
                    strUltimoDia = DateAdd("d", -1, strUltimoDia)

                    Dim dtDataFim As Date = strUltimoDia
                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadasCanc & "\CFeCanc", "")

                        Dim strAno As String = strChave.Substring(2, 2)
                        Dim strMes As String = strChave.Substring(4, 2)
                        strAno = "20" & strAno

                        Dim dtData As Date = "01/" & strMes & "/" & strAno

                        If dtDataIni <= dtData And dtDataFim >= dtData Then

                            Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
                            Dim ns As System.Xml.XmlNamespaceManager = New System.Xml.XmlNamespaceManager(oXML.NameTable)
                            Dim NodeRoot As System.Xml.XmlNode

                            ns.AddNamespace("nfe", "")
                            oXML.Load(strArquivo)

                            NodeRoot = oXML.SelectSingleNode("nfe:CFeCanc/nfe:infCFe/nfe:ide", ns)
                            If NodeRoot Is Nothing = False Then
                                Dim strD As String = NodeRoot.Item("dEmi").InnerText.Substring(0, 4) & "/" & NodeRoot.Item("dEmi").InnerText.Substring(4, 2) & "/" & NodeRoot.Item("dEmi").InnerText.Substring(6, 2)
                                Dim dtDataNFe As Date = Format(CDate(strD), "dd/MM/yyyy")

                                If dataIni <= dtDataNFe And dataFim >= dtDataNFe Then
                                    bolOk = True
                                    File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                                    AddToArchive(zip, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                                End If
                            End If

                        End If




                    Next
                End If
            Case 2




                If IO.Directory.Exists(PastaAutorizadas) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadas, "*.xml")

                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadas & "\CFe", "")
                        '35160561099008000141599000022500003801357661
                        Dim intNumero As Integer = strChave.Substring(31, 6)

                        If intNumInicial <= intNumero And intNumFinal >= intNumero Then
                            bolOk = True
                            File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadas, strDestino))
                            AddToArchive(zip, strArquivo.Replace(PastaAutorizadas, strDestino))
                        End If


                    Next
                End If

                If IO.Directory.Exists(PastaAutorizadasCanc) = True Then

                    Dim vetLista As Array = Directory.GetFiles(PastaAutorizadasCanc, "*.xml")

                    Dim I As Integer

                    For I = 0 To vetLista.Length - 1
                        Dim strArquivo As String = vetLista(I)
                        Dim strChave As String = strArquivo.Replace(PastaAutorizadasCanc & "\CFeCanc", "")

                        Dim intNumero As Integer = strChave.Substring(31, 6)

                        If intNumInicial <= intNumero And intNumFinal >= intNumero Then
                            bolOk = True
                            File.Copy(strArquivo, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                            AddToArchive(zip, strArquivo.Replace(PastaAutorizadasCanc, strDestino))
                        End If


                    Next
                End If
        End Select
        IO.Directory.Delete(strDestino, True)
        zip.Close()
        If bolOk = False Then
            MsgBox("Arquivos não encontrado!", MsgBoxStyle.Information)
            If IO.File.Exists(zipPath) = True Then
                IO.File.Delete(zipPath)

            End If
        Else
            MsgBox("Arquivos gerados com sucesso!", MsgBoxStyle.Information)
            Me.txtDestino.ResetText()
            Me.rdgTipo.SelectedIndex = -1
            Me.txtDestino.Focus()
        End If


    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class