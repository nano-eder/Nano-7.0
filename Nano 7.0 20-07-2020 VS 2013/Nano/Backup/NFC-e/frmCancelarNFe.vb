Imports Nano.clsFuncoes

Public Class frmCancelarNFe
    Public strNumNF As String
    Public strCodOrdem As String
    Public strChave As String
    Public strArquivoProcessado As String
    Public strCaminhoDaNfe As String

    Dim strCodCCe As String = ""
    Dim strStatus As String

    Dim NanoBanco As String
    Private Sub frmCancelarNFe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\iconenfe.ico") = True Then
            Me.Icon = New Icon(My.Application.Info.DirectoryPath & "\iconenfe.ico")
        End If
        Me.memMotivo.ResetText()
        Me.memMotivo.Focus()
    End Sub
    Private Sub VerificarPendete()
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, NumSeqEvento, Correcao FROM Cce where " & _
        "TipoEvento = '110111' and Status <> 'OK' and CodOrdem = " & strCodOrdem & " and " & _
        "CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")

        If dt.Rows.Count > 0 Then
            strCodCCe = dt.Rows.Item(0).Item("Codigo").ToString
            Me.memMotivo.Text = dt.Rows.Item(0).Item("Correcao").ToString
            Me.memMotivo.Enabled = False
            strStatus = "AGUARDANDO"
        End If
    End Sub
    Private Sub memMotivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles memMotivo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso (e.KeyCode = Keys.V) Then e.SuppressKeyPress = True
    End Sub

    Private Sub memMotivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles memMotivo.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar = "'" Then
            e.Handled = True
        End If
        If e.KeyChar = "|" Then
            e.Handled = True
        End If
    End Sub

    Private Sub memMotivo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles memMotivo.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Validar(Me.memMotivo) = False Then Exit Sub

        If Me.memMotivo.Text.Length < 15 Then
            MsgBox("Motivo deve ter no mínimo 15 caracteres!", MsgBoxStyle.Information)
            Exit Sub
        End If
        If strStatus <> "AGUARDANDO" Then
            Try
                Dim dtNF As DataTable
                Dim strTexto As String = LerArquivo(PastaAutorizadas & "\" & strChave & "-procNfe.xml", True)
                Dim strTags As String = "/nfeProc"
                If strTexto.Contains("nfeProc") = False Then
                    strTags = ""
                End If

                dtNF = GerarNFCe.ArquivoNfeXml(strTexto, "" & strTags & "/protNFe/infProt", "nProt Varchar(50)", "")
                If dtNF.Rows.Count > 0 Then
                    If dtNF.Rows.Item(0).Item("nProt").ToString <> "" Then
                        Dim strProtocolo As String = dtNF.Rows.Item(0).Item("nProt").ToString

                        clsNFCe.ImprimirCancelamentoNFCe(strCodOrdem, strNumNF, strProtocolo, strChave, Me.memMotivo.Text)
                    Else
                        MsgBox("Xml não encontrado!", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                Else
                    MsgBox("Xml não encontrado!", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Catch ex As Exception

                Exit Sub
            End Try
        End If
        



        frmProcesNfe.strStatus = strStatus
        frmProcesNfe.strChaveAcesso = strChave
        frmProcesNfe.strNumSeq = "1"
        frmProcesNfe.strTipoEvento = "110111"
        frmProcesNfe.strUF = SelecionarUF(strChave.Substring(0, 2))
        frmProcesNfe.strTipoAmb = TipoAmbiente
        frmProcesNfe.intCodCce = 1
        frmProcesNfe.Tag = "Cancelamento"
        frmProcesNfe.strCaminhoNfe = strCaminhoDaNfe
        frmProcesNfe.ShowDialog()

        If strArquivoProcessado = "OK" Then
      
            Atualizar("UPDATE NFCe set ChaveCancelamento = '110111" & strChave & "01' where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig & " and CodEmitente = " & CodEmitente)

            Me.Close()
        ElseIf strArquivoProcessado = "NOK" Then
            MsgBox("A Nota Fiscal não foi emitida com sucesso!", MsgBoxStyle.Information)
            strStatus = ""
            Me.memMotivo.Enabled = True
        Else
            strStatus = "AGUARDANDO"
            Me.Close()
        End If


    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class