Imports Nano.clsFuncoes
Public Class frmEmissaoCce

    Dim strVersao As String
    Dim strCUF As String
    Dim strTipoAmb As String
    Dim strTZD As String
    Dim strTipoEvento As String
    Dim strCNPJ As String
    Dim strDescEvento As String
    Dim strNumNF As String
    Private Sub frmEmissaoCce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpar()
        Me.txtCodPed.Enabled = False

        VerificarNSNFe()

    End Sub

    Private Sub Limpar()
        Dim dt As DataTable = CarregarDataTable("SELECT VersaoCce, TZDCce, TipoEventoCce, CNPJ, DescEventoCce, CodUF, TipoAmbCce, CondUsoCce FROM ConfigNfe where CodConfig = " & CodConfig)

        Dim tzFusoHorario As TimeZone = TimeZone.CurrentTimeZone

        Dim tmHoras As TimeSpan

        tmHoras = tzFusoHorario.GetUtcOffset(Now)

        If dt.Rows.Count > 0 Then
            strVersao = dt.Rows.Item(0).Item("VersaoCce").ToString
            strCUF = dt.Rows.Item(0).Item("CodUF").ToString
            strTipoAmb = dt.Rows.Item(0).Item("TipoAmbCce").ToString
            strTZD = Format(tmHoras.Hours, "00") & ":00"

            strTipoEvento = dt.Rows.Item(0).Item("TipoEventoCce").ToString
            strCNPJ = dt.Rows.Item(0).Item("CNPJ").ToString
            strDescEvento = dt.Rows.Item(0).Item("DescEventoCce").ToString
            Me.memCondUso.Text = dt.Rows.Item(0).Item("CondUsoCce").ToString

        End If
        strNumNF = ""
        Me.tbCce.Rows.Clear()
        Me.dtData.ResetText()
        Me.txtNumSeqEvento.ResetText()
        Me.memCorrecao.ResetText()
        Me.txtCodPed.ResetText()
        Me.txtChave.ResetText()
        Me.txtNumNF.ResetText()
        Me.dtData.Enabled = False
        Me.memCorrecao.Enabled = False

        Me.txtCodPed.Focus()
    End Sub

    Private Sub btnSalvar1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar1.ItemClick
        If Validar(Me.memCorrecao) = False Then Exit Sub
        Me.dtData.Text = Data(Me.dtData.Text)
        If Validar(Me.dtData) = False Then Exit Sub
        If Validar(Me.txtChave) = False Then Exit Sub

        Try

            Dim strHora As String = Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)

            Inserir("INSERT INTO Cce (CodOrdem, Versao, Id, CUF, TipoAmb, Chave, DEmi, HEmi, TZD, TipoEvento, " & _
            "NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso, CodConfig) VALUES (" & Me.txtCodPed.Text & "," & _
            "'" & strVersao & "','','" & strCUF & "','" & strTipoAmb & "','" & Me.txtChave.Text & "'," & _
            "'" & Me.dtData.Text & "','" & strHora & "','" & strTZD & "','" & strTipoEvento & "'," & _
            "'" & Me.txtNumSeqEvento.Text & "','" & strCNPJ & "','" & strDescEvento & "'," & _
            "'" & Me.memCorrecao.Text & "','" & Me.memCondUso.Text & "'," & CodConfig & ")")


            ExportarCce(Me.txtCodPed.Text, Me.txtNumSeqEvento.Text, strNumNF)


            MsgBox("Carta de correção salva com sucesso!", MsgBoxStyle.Information)

            
        Catch ex As Exception

        End Try

        Limpar()

        Me.Close()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        ConsultaNFE = ""
        Dim frm As New frmConNfe
        frm.ShowDialog()

        If ConsultaNFE <> "" Then
            Me.txtCodPed.Text = ConsultaNFE
            CarregaForm()
        Else
            Me.txtCodPed.Text = ""
            Me.txtCodPed.Focus()
        End If
    End Sub

    Private Sub CarregaForm()

        Dim dtTotalNfe As DataTable = CarregarDataTable("SELECT NumNF, Chave FROM TotalNfe where CodOrdem = " & Me.txtCodPed.Text.Trim & " and CodConfig = " & CodConfig)

        If dtTotalNfe.Rows.Count > 0 Then
            Me.txtChave.Text = dtTotalNfe.Rows.Item(0).Item("Chave").ToString
            strNumNF = dtTotalNfe.Rows.Item(0).Item("NumNF").ToString
            Me.txtNumNF.Text = dtTotalNfe.Rows.Item(0).Item("NumNF").ToString
        End If

        Dim dtCce As DataTable = CarregarDataTable("SELECT Codigo, DEmi, HEmi, Correcao, NumSeqEvento FROM Cce where CodOrdem = " & Me.txtCodPed.Text & " and CodConfig = " & CodConfig)
        Me.tbCce.Rows.Clear()
        If dtCce.Rows.Count > 0 Then
            Me.txtNumSeqEvento.Text = dtCce.Rows.Count + 1

            Dim I As Integer
            With Me.tbCce.Rows
                For I = 0 To dtCce.Rows.Count - 1
                    .Add()
                    .Item(I).Item("Data") = Format(CDate(dtCce.Rows.Item(I).Item("DEmi")), "dd/MM/yyyy").ToString
                    .Item(I).Item("Hora") = Format(CDate(dtCce.Rows.Item(I).Item("HEmi")), "HH:mm:ss").ToString
                    .Item(I).Item("Correcao") = dtCce.Rows.Item(I).Item("Correcao").ToString
                    .Item(I).Item("NumSeq") = dtCce.Rows.Item(I).Item("NumSeqEvento").ToString
                Next
            End With

        Else
            Me.txtNumSeqEvento.Text = "1"
        End If

        Me.dtData.Enabled = True
        Me.memCorrecao.Enabled = True
        Me.dtData.Text = Date.Today
        Me.memCorrecao.Focus()
    End Sub

    Private Sub btnDetalhar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalhar.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Dim frm As New frmDetCce

        frm.txtNumSeqEvento.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNumSeq)
        frm.strCodOrdem = Me.txtCodPed.Text
        frm.strNumNF = strNumNF

        frm.ShowDialog()
    End Sub

    Private Sub memCorrecao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles memCorrecao.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.V) Then e.SuppressKeyPress = True
    End Sub

    Private Sub memCorrecao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles memCorrecao.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar = "'" Then
            e.Handled = True
        End If
        If e.KeyChar = "|" Then
            e.Handled = True
        End If
    End Sub

 
    Private Sub memCorrecao_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles memCorrecao.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub
End Class