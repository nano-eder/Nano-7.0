Imports Nano.clsFuncoes
Imports Nano.clsValidar
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions


Imports Nano.clsNfeXml

Public Class frmEmail
    Dim strEmails As String
    Dim strNivel As String
    Dim strArrayImagem(9) As String
    Public intQtdCliente As Integer

    Public strEmailCliente As String = ""
    Public strCaminhoArquivo As String = ""

    Private Sub btnPesquisarAni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarAni.Click
        If TesteConexao() = False Then Exit Sub
        Dim strData As String = ""
        Dim dt As DataTable = Nothing
        Select Case Me.RadioGroup1.SelectedIndex
            Case 0
                dt = CarregarDataTable("SELECT Email FROM Cliente where month(Nascimento) = '" & Month(Now) & "' and day(Nascimento) = '" & Date.Today.Day & "' and year(Nascimento) > '1910'")
            Case 1
                If Validar(Me.cboMesAni) = False Then Exit Sub
                Select Case Me.cboMesAni.Text
                    Case "JANEIRO"
                        strData = "1"
                    Case "FEVEREIRO"
                        strData = "2"
                    Case "MARÇO"
                        strData = "3"
                    Case "ABRIL"
                        strData = "4"
                    Case "MAIO"
                        strData = "5"
                    Case "JUNHO"
                        strData = "6"
                    Case "JULHO"
                        strData = "7"
                    Case "AGOSTO"
                        strData = "8"
                    Case "SETEMBRO"
                        strData = "9"
                    Case "OUTUBRO"
                        strData = "10"
                    Case "NOVEMBRO"
                        strData = "11"
                    Case "DEZEMBRO"
                        strData = "12"
                End Select
                dt = CarregarDataTable("SELECT Email FROM Cliente where month(Nascimento) = '" & strData & "' and year(Nascimento) > '1910'")
        End Select

        Me.txtPara.ResetText()
        Me.txtCc.ResetText()
        Me.txtCco.ResetText()
        strEmails = ""
        Me.txtQtdRev.ResetText()
        Me.txtQtd.ResetText()
        Me.txtCliMala.ResetText()




        Dim I, intQtd As Integer

        For I = 0 To dt.Rows.Count - 1
            If dt.Rows.Item(I).Item("Email").ToString <> "" Then
                If strEmails = "" Then
                    strEmails = dt.Rows.Item(I).Item("Email").ToString.ToLower
                Else
                    strEmails += ";" & dt.Rows.Item(I).Item("Email").ToString.ToLower
                End If
                intQtd += 1
            End If
        Next
        Me.txtCco.Text = strEmails
        Me.txtQtd.Text = intQtd

    End Sub

    Private Sub btnEnviar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviar.ItemClick
        'If Validar(Me.rtbTexto) = False Then Exit Sub

        If Me.txtPara.Text = "" And Me.txtCco.Text = "" And Me.txtCc.Text = "" Then
            MsgBox("Informe o destino!", MsgBoxStyle.Information)
            Exit Sub
        End If

        OrdenarImagem()

        Dim dtServ As DataTable = CarregarDataTable("SELECT Servidor, Email, Senha, Porta, Servico FROM Email")
        Dim strServidor As String = dtServ.Rows.Item(0).Item("Servidor").ToString
        Dim strEmail As String = dtServ.Rows.Item(0).Item("Email").ToString
        Dim strSenha As String = dtServ.Rows.Item(0).Item("Senha").ToString
        Dim strServico As String = dtServ.Rows.Item(0).Item("Servico").ToString
        Dim strPorta As String = dtServ.Rows.Item(0).Item("Porta").ToString
        Dim strTexto As String
        Dim vet As Array = Nothing




        Dim rel As New relMail
        Dim strTeste As String = Me.rtbTexto.Rtf
        Dim I As Integer
        Dim strChar As String


        For I = 0 To strTeste.Length
            strChar = strTeste.Substring(strTeste.Length - 1)
            strTeste = strTeste.Substring(0, strTeste.Length - 1)

            If strChar = "}" Then
                Exit For
            End If
        Next

        strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf


        strTeste = strTeste & "_______________________________________________________________________________________________________________ \par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf
        strTeste = strTeste & NomeEmpresa & " \par" & vbCrLf
        strTeste = strTeste & TelefoneEmpresa & " \par" & vbCrLf
        strTeste = strTeste & EnderecoEmpresa & " \par" & vbCrLf
        strTeste = strTeste & " \par" & vbCrLf & "\par" & vbCrLf & "\par" & vbCrLf & "." & vbCrLf & "}"



        rel.rtMail.Rtf = strTeste

        If IO.Directory.Exists("C:/NANO") = False Then
            IO.Directory.CreateDirectory("C:/NANO")
        End If

        rel.ExportToHtml("C:/NANO/Mail.html")
        strTexto = LerArquivoMail("C:/NANO/Mail.html")
        If strTexto.Contains("Mail_files/") = True Then
            Dim vetTe As Array = Split(strTexto, """Mail_files/")
            Dim B As Integer
            strTexto = vetTe(0)
            For B = 1 To vetTe.Length - 1
                Dim vetB As Array = Split(vetTe(B), " alt=")
                strTexto &= "cid:Imagem" & B & ">" & vetB(1).ToString.Replace(""""" style=""border-width:0px;"" />", "")
            Next

        End If
        If enviaMensagemEmail(strEmail, strSenha, Me.txtPara.Text, Me.txtCco.Text.Trim, Me.txtCc.Text, Me.txtAssunto.Text, strTexto, strServidor, strNivel, Me.chkConfirmacao.Checked, "", strPorta, strServico, Nothing) = True Then
            Me.Close()
        End If

    End Sub
    Private Function rtPadFontStyle() As FontStyle
        Dim fs As FontStyle = New FontStyle()
        If btnN.Down Then
            fs = fs Or FontStyle.Bold
        End If
        If btnI.Down Then
            fs = fs Or FontStyle.Italic
        End If
        If btnS.Down Then
            fs = fs Or FontStyle.Underline
        End If
        Return fs
    End Function
    Dim strEstilo As String
    Private modified_Renamed As Boolean
    Private open_Renamed As Boolean

    Private docName_Renamed As String
    Private currentCursor As Cursor

    Protected Property DocName() As String
        Get
            Return docName_Renamed
        End Get
        Set(ByVal value As String)
            If value <> docName_Renamed Then
                docName_Renamed = value
            End If
        End Set
    End Property

    Protected Property Open() As Boolean
        Get
            Return open_Renamed
        End Get
        Set(ByVal value As Boolean)
            If value <> open_Renamed Then
                open_Renamed = value
                rtbTexto.HideSelection = Not open_Renamed
            End If
        End Set
    End Property

    Protected Sub InitFormat()
        btnN.Down = SelectFont.Bold
        btnI.Down = SelectFont.Italic
        btnS.Down = SelectFont.Underline
        Select Case rtbTexto.SelectionAlignment
            Case HorizontalAlignment.Left
                btnLe.Down = True
            Case HorizontalAlignment.Center
                btnCe.Down = True
            Case HorizontalAlignment.Right
                btnRi.Down = True
        End Select
    End Sub

    Protected Sub rtPadClear()
        RefreshForm(True)
        rtbTexto.SelectionBullet = False
        rtbTexto.SelectionProtected = False
        rtbTexto.Clear()
        rtbTexto.ClearUndo()
        rtbTexto.Focus()
        RefreshForm(False)
    End Sub

    Protected ReadOnly Property SelectFont() As Font
        Get
            If Not rtbTexto.SelectionFont Is Nothing Then
                Return rtbTexto.SelectionFont
            End If
            Return rtbTexto.Font
        End Get
    End Property
    Protected Sub RefreshForm(ByVal b As Boolean)
        If b Then
            currentCursor = Windows.Forms.Cursor.Current
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Refresh()
        Else
            Windows.Forms.Cursor.Current = currentCursor
        End If
    End Sub

    Private Sub btnN_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnN.ItemClick

        strEstilo = "N"
        Me.rtbTexto.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
    End Sub

    Private Sub btnI_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnI.ItemClick

        strEstilo = "I"
        rtbTexto.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
    End Sub

    Private Sub btnS_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnS.ItemClick

        strEstilo = "S"
        rtbTexto.SelectionFont = New Font(SelectFont.FontFamily.Name, SelectFont.Size, rtPadFontStyle())
    End Sub

    Private Sub btnLe_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLe.ItemClick

        If btnLe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left
        End If
        If btnCe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Center
        End If
        If btnRi.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub btnCe_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCe.ItemClick

        If btnLe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left
        End If
        If btnCe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Center
        End If
        If btnRi.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub btnRi_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRi.ItemClick

        If btnLe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left
        End If
        If btnCe.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Center
        End If
        If btnRi.Down Then
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right
        End If
    End Sub

    Private Sub btnF_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnF.ItemClick
        Dim dlg As FontDialog = New FontDialog()
        dlg.Font = CType(SelectFont.Clone(), Font)
        dlg.ShowColor = True
        dlg.Color = rtbTexto.SelectionColor
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            rtbTexto.SelectionFont = CType(dlg.Font.Clone(), Font)
            rtbTexto.SelectionColor = dlg.Color
        End If
    End Sub

    Private Sub frmEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "83")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmTeste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If TipoNano <> 3 Then
            Me.nbgRetorno.Visible = False
        End If
        If Me.Tag = "NFECLIENTE" Then
            lstAnexo.Items.Add("C:\NANO\EMail\Aquivo.zip")
            Me.nbcAnexo.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
        End If

        Nivel(Me.btnPriNor, Me.btnPriAlt, Me.btnPriBai, "Normal")

        Me.cboMesAni.Enabled = False

        If Me.Tag = "PEDIDO" Then
            Me.nbcAvisos.Visible = False
            Me.txtPara.Text = Me.strEmailCliente
            Me.txtAssunto.Text = Me.strCaminhoArquivo.Trim.Replace("C:\NANO\Pedidos\", "").Replace(".pdf", "")
            Me.rpgTipo.Visible = False
            rtbTexto.Text = Me.txtAssunto.Text & " enviado em " & My.Computer.Clock.LocalTime & "."
            AnexarArquivo(True)
        ElseIf Me.Tag = "RETORNO" Then
            Me.txtCco.Text = ""
            Me.txtCco.Text = strEmailCliente

        End If
        Dim dtServ As DataTable = CarregarDataTable("SELECT Copia FROM Email")
        If dtServ.Rows.Count > 0 Then
            If dtServ.Rows.Item(0).Item("Copia").ToString <> "" Then
                Me.txtCco.Text = dtServ.Rows.Item(0).Item("Copia").ToString
            End If
        End If

    End Sub

    Private Sub cboTipo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.EditValueChanged
        Select Case Me.cboTipo.EditValue
            Case "ANIVERSARIANTES"
                Me.nbcAvisos.ActiveGroup = Me.nbgAniv
            Case "MALA DIRETA"
                Me.nbcAvisos.ActiveGroup = Me.nbgMala
            Case "REVISÕES"
                Me.nbcAvisos.ActiveGroup = Me.nbgRevisao
            Case "RETORNO"
                Me.nbcAvisos.ActiveGroup = Me.nbgRetorno
        End Select
    End Sub

    Private Sub nbcAvisos_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles nbcAvisos.ActiveGroupChanged
        If Me.nbcAvisos.ActiveGroup.Equals(Me.nbgAniv) Then
            Me.cboTipo.EditValue = "ANIVERSARIANTES"
        ElseIf Me.nbcAvisos.ActiveGroup.Equals(Me.nbgMala) Then
            Me.cboTipo.EditValue = "MALA DIRETA"
        ElseIf Me.nbcAvisos.ActiveGroup.Equals(Me.nbgRevisao) Then
            Me.cboTipo.EditValue = "REVISÕES"
        ElseIf Me.nbcAvisos.ActiveGroup.Equals(Me.nbgRetorno) Then
            Me.cboTipo.EditValue = "RETORNO"
        End If
    End Sub
    Private Sub btnServidorSaida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnServidorSaida.ItemClick
        frmServidorSaida.Show()
    End Sub

    Private Sub btnPesRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesRev.Click
        If TesteConexao() = False Then Exit Sub
        If Validar(Me.cboDataRevisao) = False Then Exit Sub
        If Validar(Me.dtRevInicial) = False Then Exit Sub
        If Validar(Me.dtRevFinal) = False Then Exit Sub
        If dtRevInicial.Text > dtRevFinal.Text Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Me.txtPara.ResetText()
        Me.txtCc.ResetText()
        Me.txtCco.ResetText()
        strEmails = ""
        Me.txtQtdRev.ResetText()
        Me.txtQtd.ResetText()
        Me.txtCliMala.ResetText()

        Dim strData As String
        Dim dtRev As DataTable = Nothing
        Dim I, intQtd As Integer
        Select Case Me.cboDataRevisao.SelectedIndex
            Case 0
                strData = String.Format("Revisao >= '{0:dd/MM/yyyy}' AND Revisao <= '{1:dd/MM/yyyy}'", dtRevInicial.Text, dtRevFinal.Text)
                dtRev = CarregarDataTable("SELECT Cliente.Email FROM (Revisao left join Total on Revisao.CodigoPedido = Total.Cod)left join Cliente on Total.CPF = Cliente.CPF where " & strData)

            Case 1
                strData = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtRevInicial.Text, dtRevFinal.Text)
                dtRev = CarregarDataTable("SELECT Cliente.Email FROM (Revisao left join Total on Revisao.CodigoPedido = Total.Cod)left join Cliente on Total.CPF = Cliente.CPF where " & strData)
        End Select
        For I = 0 To dtRev.Rows.Count - 1
            If dtRev.Rows.Item(I).Item("Email").ToString <> "" Then
                If strEmails = "" Then
                    strEmails = dtRev.Rows.Item(I).Item("Email").ToString.ToLower
                Else
                    strEmails += ";" & dtRev.Rows.Item(I).Item("Email").ToString.ToLower
                End If
                intQtd += 1

            End If
        Next
        Me.txtCco.Text = strEmails
        Me.txtQtdRev.Text = intQtd
    End Sub

    Private Sub btnTextoSemFor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTextoSemFor.ItemClick
        If Me.btnTextoSemFor.Down = True Then
            Me.btnN.Down = False
            Me.btnI.Down = False
            Me.btnS.Down = False
            Me.btnF.Down = False

            Me.btnCe.Down = False
            Me.btnLe.Down = True

            Me.btnRi.Down = False

            Me.rtbTexto.SelectAll()
            Me.rtbTexto.SelectionFont = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
            ' Me.rtbTexto.Font = New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)
            Me.btnLe_ItemClick(sender, e)
            Me.btnLe.Down = False
            Me.btnN.Enabled = False
            Me.btnI.Enabled = False
            Me.btnS.Enabled = False
            Me.btnF.Enabled = False
            Me.btnCe.Enabled = False
            Me.btnLe.Enabled = False
            Me.btnRi.Enabled = False
        Else
            Me.btnN.Enabled = True
            Me.btnI.Enabled = True
            Me.btnS.Enabled = True
            Me.btnF.Enabled = True
            Me.btnCe.Enabled = True
            Me.btnLe.Enabled = True
            Me.btnRi.Enabled = True
        End If
    End Sub
    Private Sub Nivel(ByVal par1 As Object, ByVal par2 As Object, ByVal par3 As Object, ByVal parNivel As String)
        par1.Down = True
        par2.Down = False
        par3.Down = False
        strNivel = parNivel

    End Sub
    Private Sub btnPriNor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPriNor.ItemClick
        Nivel(Me.btnPriNor, Me.btnPriAlt, Me.btnPriBai, "Normal")
        Me.GroupControl1.Text = "Mensagem"
    End Sub

    Private Sub btnPriAlt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPriAlt.ItemClick
        Nivel(Me.btnPriAlt, Me.btnPriNor, Me.btnPriBai, "High")
        Me.GroupControl1.Text = "Mensagem  (Esta mensagem é de alta prioridade)"
    End Sub

    Private Sub btnPriBai_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPriBai.ItemClick
        Nivel(Me.btnPriBai, Me.btnPriNor, Me.btnPriAlt, "Low")
        Me.GroupControl1.Text = "Mensagem  (Esta mensagem é de baixa prioridade)"
    End Sub

    Private Sub btnPesMala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesMala.Click
        Me.txtPara.ResetText()
        Me.txtCc.ResetText()
        Me.txtCco.ResetText()
        Me.txtQtdRev.ResetText()
        Me.txtQtd.ResetText()
        Me.txtCliMala.ResetText()
        frmCadCliente.Tag = "Email"
        frmCadCliente.ShowDialog()
        Me.txtCliMala.Text = intQtdCliente
        Me.txtCco.Text = EnviarEmail
    End Sub

    Private Sub btnNovo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNovo.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos e começar um novo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Me.txtPara.ResetText()
            Me.txtCc.ResetText()
            Me.txtCco.ResetText()
            strEmails = ""
            Me.txtQtdRev.ResetText()
            Me.txtQtd.ResetText()
            Me.txtCliMala.ResetText()
            Me.txtAssunto.ResetText()
            Me.cboMesAni.SelectedIndex = Month(Date.Today) + 1
            Me.cboDataRevisao.SelectedIndex = -1
            Me.rtbTexto.ResetText()
            Me.btnTextoSemFor.Down = False
            Nivel(Me.btnPriNor, Me.btnPriAlt, Me.btnPriBai, "Normal")
            Me.GroupControl1.Text = "Mensagem"
        End If
        'If PrintDialog1.ShowDialog() = DialogResult.OK Then
        '    PrintDocument1.Print()
        'End If
    End Sub
    
    Private Sub btnAnexar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnexar.ItemClick
      
        AnexarArquivo(False)
    End Sub

    Private Sub AnexarArquivo(ByVal parPedido As Boolean)
        Dim Conta As Integer

        If parPedido = False Then

            ofdAnexo.CheckFileExists = True
            ofdAnexo.Title = "Selecione um arquivo para anexar"
            ofdAnexo.ShowDialog()

            For Conta = 0 To UBound(ofdAnexo.FileNames)
                lstAnexo.Items.Add(ofdAnexo.FileNames(Conta))
            Next

        Else
            lstAnexo.Items.Add(Me.strCaminhoArquivo)
        End If

        Me.nbcAnexo.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded
    End Sub

    Private Sub GalleryDropDown1_GalleryItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles GalleryDropDown1.GalleryItemClick


        Dim intIndex As Integer = e.Item.ImageIndex
        Clipboard.SetImage(Me.ImageList2.Images.Item(intIndex))
        Me.rtbTexto.Paste()

    End Sub

    Private Sub btnExcluirAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAnexo.Click
        If lstAnexo.SelectedIndex > -1 Then
            lstAnexo.Items.RemoveAt(lstAnexo.SelectedIndex)
        End If
        Dim intQtd As Integer = Me.lstAnexo.Items.Count
        If intQtd = 0 Then
            Me.nbcAnexo.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        End If
    End Sub

    Private Sub btnFoto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFoto.ItemClick
        InserirFoto()
    End Sub

    Private Sub InserirFoto()
        Dim Conta As Integer
        ofdAnexo.CheckFileExists = True
        ofdAnexo.Title = "Selecione um arquivo"
        ofdAnexo.ShowDialog()

        'Dim img As Image = Image.FromFile("C:\Users\Acer\Pictures\Imagem\pagina.jpg")
        'Clipboard.SetImage(img)
        'Me.rtbTexto.Paste()
        'rtbTexto.AppendText(vbCrLf)
        Dim I As Integer
        Dim B As Integer
        Dim A As Integer
        For Conta = 0 To UBound(ofdAnexo.FileNames)
            Dim img As Image = Image.FromFile(ofdAnexo.FileNames(Conta))

            For A = 0 To strArrayImagem.Length
                If strArrayImagem(A) = "" Then
                    strArrayImagem(A) = ofdAnexo.FileNames(Conta)
                    Exit For
                End If
            Next
            'dim intLen as Integer =

            Clipboard.SetImage(img)
            Me.rtbTexto.Paste()
            Me.rtbTexto.AppendText(vbCrLf)

            Dim strd As String = Me.rtbTexto.Rtf
            Dim vetarrr As Array = Split(strd, "{\pict")
            For B = 1 To vetarrr.Length - 1

                If Me.tbImagem.Rows.Count = 0 Then
                    Me.tbImagem.Rows.Add()
                    Dim vett As Array = Split(vetarrr(1), "}")
                    Me.tbImagem.Rows.Item(Me.tbImagem.Rows.Count - 1).Item("Imagem") = vett(0)
                    Me.tbImagem.Rows.Item(Me.tbImagem.Rows.Count - 1).Item("Caminho") = ofdAnexo.FileNames(Conta)

                Else
                    Dim bolAdd As Boolean = True
                    Dim vett As Array = Split(vetarrr(B), "}")
                    For I = 0 To Me.tbImagem.Rows.Count - 1
                        Dim strT As String = Me.tbImagem.Rows.Item(I).Item("Imagem")
                        If vett(0) = Me.tbImagem.Rows.Item(I).Item("Imagem") Then
                            bolAdd = False
                            Exit For
                        End If
                    Next
                    If bolAdd = True Then
                        Me.tbImagem.Rows.Add()
                        Me.tbImagem.Rows.Item(Me.tbImagem.Rows.Count - 1).Item("Imagem") = vett(0)
                        Me.tbImagem.Rows.Item(Me.tbImagem.Rows.Count - 1).Item("Caminho") = ofdAnexo.FileNames(Conta)

                    End If
                End If

            Next
         

        Next
        OrdenarImagem()
    End Sub

    Private Sub OrdenarImagem()
        Dim strd As String = Me.rtbTexto.Rtf
        Dim vetarrr As Array = Split(strd, "{\pict")
        Dim B As Integer
        Dim I As Integer

        For I = 0 To Me.tbImagem.Rows.Count - 1
            Me.tbImagem.Rows.Item(I).Item("Ordem") = ""
        Next

        For B = 1 To vetarrr.Length - 1
            Dim bolAdd As Boolean = True
            Dim vett As Array = Split(vetarrr(B), "}")
            For I = 0 To Me.tbImagem.Rows.Count - 1
                Dim strT As String = Me.tbImagem.Rows.Item(I).Item("Imagem")
                If vett(0) = Me.tbImagem.Rows.Item(I).Item("Imagem") Then
                    Me.tbImagem.Rows.Item(I).Item("Ordem") = B
                    Exit For
                End If
            Next
        Next

        For I = 0 To Me.tbImagem.Rows.Count - 1
            If Me.tbImagem.Rows.Item(I).Item("Ordem") = "" Then
                Me.tbImagem.Rows.RemoveAt(I)
                I -= 1
            End If
        Next
    End Sub
    Private Sub btnLinha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLinha.ItemClick

        'Dim p As Point = rtbTexto.GetPositionFromCharIndex(rtbTexto.SelectionStart)

        'Dim CaretTop As Integer = rtbTexto.Top + p.Y + rtbTexto.Font.Height + 5



        ''Dim line As Integer
        ''Me.rtbTexto.SelectionStart = vbCrLf
        ' ''Me.rtbTexto.Text = vbCrLf
        ''line = rtbTexto.GetLineFromCharIndex(rtbTexto.SelectionStart)

        Dim myP As Point = rtbTexto.GetPositionFromCharIndex(rtbTexto.SelectionStart)

        Dim mypen As New System.Drawing.Pen(Color.Black)
        Dim formA As System.Drawing.Graphics

        formA = Me.rtbTexto.CreateGraphics()
        formA.DrawLine(mypen, 0, myP.Y - 1, Me.rtbTexto.Width, myP.Y - 1)
        mypen.Dispose()
        formA.Dispose()

    End Sub

    Dim sAchar As String
    Private Sub btnCorrecao_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorrecao.ItemClick
        If Me.rtbTexto.Text = "" Then Exit Sub
        'correcaoortografica()
    End Sub

    'Dim objWord As Microsoft.Office.Interop.Word.ApplicationClass
    'Private Sub correcaoortografica()

    '    If objWord Is Nothing Then
    '        objWord = New Microsoft.Office.Interop.Word.ApplicationClass()
    '    End If

    '    objWord.Documents.Add()

    '    objWord.Selection.TypeText(rtbTexto.Text)

    '    objWord.Documents.Item(objWord.Documents.Count).CheckSpelling()

    '    rtbTexto.Text = objWord.Documents.Item(objWord.Documents.Count).Content.Text

    '    objWord.Documents.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges)
    '    objWord.Quit()
    '    objWord = Nothing
    'End Sub

    Private Sub btnLocalizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLocalizar.ItemClick
        sAchar = InputBox("Informe a palavra a localizar :", "Busca", sAchar)
        If sAchar = "" Then Exit Sub
        rtbTexto.SelectionStart = rtbTexto.SelectionStart + rtbTexto.SelectionLength + 1
        rtbTexto.Find(sAchar, Me.rtbTexto.SelectionStart, RichTextBoxFinds.None)

    End Sub

    Private Sub btnEmo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmo.ItemClick
        Clipboard.SetImage(Me.ImageList2.Images.Item(10))
        Me.rtbTexto.Paste()
    End Sub

    Private Sub btnAne_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAne.ItemClick
        'Dim img As Image = Image.FromFile("C:\Users\Acer\Documents\Visual Studio 2005\Projects\Nano 7.0 20-07-2020\Nano\bin\Debug\Logo.png")
        
        AnexarArquivo(False)
    End Sub

    Private Sub btnFot_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFot.ItemClick
        InserirFoto()

    End Sub

    Private Sub btnSel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSel.ItemClick
        Me.rtbTexto.SelectAll()
    End Sub

    Private Sub rtbTexto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtbTexto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.rtbTexto.AppendText(" ")
        End If
    End Sub

    Private Sub btnQtd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQtd.ItemClick
        Dim cont As Integer

        'remove os espaços em excesso
        Do While Me.rtbTexto.Text.IndexOf(Space(2)) >= 0
            Me.rtbTexto.Text = Me.rtbTexto.Text.Replace(Space(2), Space(1))
        Loop

        'conta as palavras
        cont = Split(Me.rtbTexto.Text, Space(1)).Length
        Console.WriteLine("A frase contém " & cont & " palavras")

        Dim intCaracteres As Integer = Me.rtbTexto.Text.Length
        Dim strTexto As String = Me.rtbTexto.Text
        strTexto = Regex.Replace(strTexto, "\s", "")

        Dim intCaracSemEspaço As Integer = strTexto.Length

        Dim intLinhas As Integer = Me.rtbTexto.Lines.Length
        MsgBox("Palavras :  " & cont & vbCrLf & "Caracteres (Com espaço):  " & intCaracteres & vbCrLf & "Caracteres (Sem espaço):  " & intCaracSemEspaço & vbCrLf & "Linhas  :" & intLinhas & "", MsgBoxStyle.Information)

    End Sub

    Private Sub btnLink_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLink.ItemClick
        'Dim linkLa As New LinkLabel
        'linkLa.LinkColor = Color.Blue
        'Dim link As LinkLabel.Link = linkLa.Links.Add(0, 11, "http://www.erasystems.com")
        'linkLa.Text = "Era Systems"
        'linkLa.Location = Me.rtbTexto.GetPositionFromCharIndex(Me.rtbTexto.TextLength)
        'Me.rtbTexto.Controls.Add(linkLa)
        'Me.rtbTexto.AppendText(linkLa.Text & "   ")
        'Me.rtbTexto.SelectionStart = Me.rtbTexto.TextLength
    End Sub


    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case Me.RadioGroup1.SelectedIndex
            Case 0
                Me.cboMesAni.Enabled = False
            Case 1
                Me.cboMesAni.Enabled = True
        End Select
    End Sub
    Private Sub btnNfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNfe.Click
       
        'Dim vetLista As Array = Directory.GetFiles(PastaXML, "*.xml")


        'Dim I As Integer
        'frmEnviarArq.tbNfe.Rows.Clear()

        'If Me.rgpContador.SelectedIndex = 1 Then
        '    frmEnviarArq.Tag = "CONTADOR"
        'Else
        '    frmEnviarArq.Tag = "CLIENTE"
        'End If
        'Dim bolExiste As Boolean = False
        'If Me.txtNum.Text <> "" Then

        '    Dim A As Integer = 0
        '    With frmEnviarArq.tbNfe.Rows
        '        For I = 0 To vetLista.Length - 1
        '            Dim intNum As Integer = NumeroNota(vetLista(I))
        '            If intNum = Me.txtNum.Text Then
        '                Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(vetLista(I))
        '                Dim dtData As Date = File.GetCreationTime(vetLista(I))
        '                .Add()
        '                .Item(A).Item("Num") = intNum
        '                .Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
        '                .Item(A).Item("Xml") = vetLista(I)

        '                Dim vetPdf As Array = Split(vetLista(I), "XML\")
        '                Dim strArquivo As String = vetPdf(1)

        '                .Item(A).Item("Pdf") = PastaPDF & "\" & strArquivo.Replace("xml", "pdf")
        '                .Item(A).Item("Ok") = False


        '                Dim vetChave As Array = Split(strArquivo, "-")
        '                .Item(A).Item("Chave") = vetChave(0)

        '                A += 1
        '                bolExiste = True
        '                Exit For
        '            End If
        '        Next
        '    End With

        'Else
        '    Dim data1, data2 As String
        '    data1 = dtInicial.EditValue
        '    data2 = dtFinal.EditValue

        '    If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        '    If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        '    Dim dataFim, dataIni As Date
        '    dataIni = data1
        '    dataFim = data2

        '    If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub



        '    Dim A As Integer = 0
        '    With frmEnviarArq.tbNfe.Rows
        '        For I = 0 To vetLista.Length - 1

        '            Dim dtData As Date = File.GetCreationTime(vetLista(I))
        '            If dtData >= dataIni And dtData <= dataFim Then
        '                Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(vetLista(I))
        '                .Add()
        '                .Item(A).Item("Num") = NumeroNota(vetLista(I))
        '                .Item(A).Item("Data") = Format(dtData, "dd/MM/yyyy")
        '                .Item(A).Item("Xml") = vetLista(I)

        '                Dim vetPdf As Array = Split(vetLista(I), "XML\")
        '                Dim strArquivo As String = vetPdf(1)

        '                .Item(A).Item("Pdf") = PastaPDF & "\" & strArquivo.Replace("xml", "pdf")
        '                .Item(A).Item("Ok") = False


        '                Dim vetChave As Array = Split(strArquivo, "-")
        '                .Item(A).Item("Chave") = vetChave(0)
        '                bolExiste = True
        '                A += 1
        '            End If

        '        Next
        '    End With

        'End If




        'If bolExiste = True Then
        '    frmEnviarArq.ShowDialog()
        '    If Me.Tag = "NFE" Then
        '        lstAnexo.Items.Add("C:\NANO\EMail\Aquivo.zip")

        '        Me.nbcAnexo.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded

        '    End If
        'Else
        '    MsgBox("Arquivo não encontrado!", MsgBoxStyle.Information)
        'End If


 
    End Sub

    Private Sub rtbTexto_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtbTexto.SelectionChanged
        Me.btnN.Down = rtbTexto.SelectionFont.Bold
        Me.btnI.Down = rtbTexto.SelectionFont.Italic
        Me.btnS.Down = rtbTexto.SelectionFont.Underline

        If rtbTexto.SelectionAlignment = HorizontalAlignment.Left Then
            Me.btnLe.Down = True
            Me.btnRi.Down = False
            Me.btnCe.Down = False
        ElseIf rtbTexto.SelectionAlignment = HorizontalAlignment.Right Then
            Me.btnLe.Down = False
            Me.btnRi.Down = True
            Me.btnCe.Down = False
        Else
            Me.btnLe.Down = False
            Me.btnRi.Down = False
            Me.btnCe.Down = True
        End If
    End Sub

    Private Sub btnPesquisaRetorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaRetorno.Click
        Dim data1, data2 As String
        data1 = dtInicialRetorno.EditValue
        data2 = dtFinalRetorno.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String = String.Format("DATEADD(day,convert(integer,Retorno),TotalConsig.Data) >= '{0:dd/MM/yyyy}' AND DATEADD(day,convert(integer,Retorno),TotalConsig.Data) <= '{1:dd/MM/yyyy}'", dtInicialRetorno.EditValue, dtFinalRetorno.EditValue) & " and TotalConsig.CodConfig = " & CodConfig

        Dim dt As DataTable = CarregarDataTable("SELECT Cliente.Email " & _
        "FROM ((ItensConsig left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and " & _
        "ItensConsig.CodConfig = TotalConsig.CodConfig) left join Cliente on TotalConsig.CodCli = Cliente.Codigo) " & _
        "left join Animal on TotalConsig.CodAnimal = Animal.Codigo where " & strData & " and Retorno <> ''")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            If Me.txtCco.Text = "" Then
                If dt.Rows.Item(I).Item("Email").ToString <> "" Then
                    Me.txtCco.Text = dt.Rows.Item(I).Item("Email").ToString.ToLower
                End If

            Else
                If dt.Rows.Item(I).Item("Email").ToString <> "" Then
                    Me.txtCco.Text = ";" & dt.Rows.Item(I).Item("Email").ToString.ToLower
                End If

            End If

        Next
        Me.txtQtdRetorno.Text = dt.Rows.Count
    End Sub

    Private Sub btnAssinatura_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAssinatura.ItemClick
        frmEmailAssinatura.ShowDialog()
    End Sub
End Class