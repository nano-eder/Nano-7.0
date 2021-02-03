Imports Nano.clsFuncoes
Public Class frmConfigTEF
    Dim bolAlterar As Boolean = False
    Dim strCodigo As String
    Private Sub CarregarGrid()

        CarregarDados("SELECT Codigo, IP, NumCaixa, Computador, CodConfig, NomeAd FROM ConfigTEF", Me.GridControl1)

    End Sub
    Private Sub frmConfigTEF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CarregarGrid()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.txtNumCaixa) = False Then Exit Sub
        If Validar(Me.txtComputador) = False Then Exit Sub
        If Validar(Me.cboNomeAd) = False Then Exit Sub

        Dim I As Integer

        If bolAlterar = False Then

            Inserir("INSERT INTO ConfigTEF (IP, NumCaixa, Computador, CodConfig, NomeAd) VALUES ('" & Me.txtIP.Text & "'," & _
            "'" & Me.txtNumCaixa.Text & "','" & Me.txtComputador.Text & "'," & CodConfig & ",'" & Me.cboNomeAd.Text & "')")

        Else

            Atualizar("UPDATE ConfigTEF SET IP = '" & Me.txtIP.Text & "', NumCaixa = '" & Me.txtNumCaixa.Text & "', " & _
            "Computador = '" & Me.txtComputador.Text & "', NomeAd = '" & Me.cboNomeAd.Text & "' where Codigo = " & strCodigo)
     
        End If

        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
        Limpar()
        CarregarGrid()
        CarregarDadosTEF()
    
    End Sub
    Private Sub Limpar()
        bolAlterar = False
        Me.txtIP.ResetText()
        Me.txtNumCaixa.ResetText()
        Me.txtComputador.ResetText()
        Me.cboNomeAd.SelectedIndex = -1
        Me.txtIP.Focus()
    End Sub

    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim intIndex As Integer = grd1.FocusedRowHandle
        bolAlterar = True
        Me.txtIP.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colIP)
        Me.txtNumCaixa.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNumCaixa)
        Me.txtComputador.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colComputador)
        Me.cboNomeAd.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNomeAd)
        strCodigo = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigo)
        
    End Sub
    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        Alterar()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Tem certeza que deseja limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle
        If Index < 0 Then Exit Sub

        Dim strCodigoExc As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodigo)

        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Excluir("Delete from ConfigTEF where Codigo = " & strCodigoExc) = True Then
                MsgBox("Dado excluído com sucesso!", MsgBoxStyle.Information)
            End If

            CarregarGrid()

        End If
    End Sub

    Private Sub btnNomePc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNomePc.Click
        Me.txtComputador.Text = My.Computer.Name.ToUpper
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub
End Class