Imports Nano.clsFuncoes
Public Class frmCadOpcoes

    Dim bolAlterado As Boolean = False
    Dim intCodOpc As Integer


    Private Sub frmCadOpcoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarComboTipo()
        CarregaForm()
        CarregarComboTipo()
    End Sub

    Private Sub CarregaForm()
        CarregarDados("Select * from ProdOpc", Me.ProdOpcGridControl)
    End Sub

    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        bolAlterado = True
        intCodOpc = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Me.txtDesc.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        Me.cboTipo.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colTipo)
        Me.txtValor.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValor)

    End Sub

    Private Sub CarregarComboTipo()
        Me.cboTipo.Properties.Items.Clear()

        Dim dt As DataTable = CarregarDataTable("Select Sum(Codigo), Tipo from ProdOpc group by Tipo")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            Me.cboTipo.Properties.Items.Add(dt.Rows.Item(I).Item("Tipo").ToString)
        Next

    End Sub

    Private Sub Limpar()
        bolAlterado = False
        intCodOpc = 0
        Me.txtDesc.ResetText()
        Me.cboTipo.SelectedIndex = -1
        Me.txtValor.ResetText()
        Me.txtDesc.Focus()
        CarregarComboTipo()
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If Validar(Me.txtDesc) = False Then Exit Sub
        If Validar(Me.cboTipo) = False Then Exit Sub
        If Validar(Me.txtValor) = False Then Exit Sub

        If bolAlterado = False Then
            Inserir("Insert into ProdOpc (Produto, Valor, Tipo) Values('" & Me.txtDesc.Text.Trim & "'," & Num(Me.txtValor.Text.Trim) & ",'" & Me.cboTipo.Text.Trim & "')")
            MsgBox("Opcional cadastrado com sucesso!", MsgBoxStyle.Information)
        Else

            Atualizar("Update ProdOpc set Produto ='" & Me.txtDesc.Text.Trim & "', Valor =" & Num(Me.txtValor.Text.Trim) & ", Tipo ='" & Me.cboTipo.Text.Trim & "' where Codigo =" & intCodOpc)
            MsgBox("Opcional alterado com sucesso!", MsgBoxStyle.Information)
        End If

        CarregaForm()
        Limpar()

    End Sub


    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir o Opcional " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto) & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Excluir("Delete from ProdOpc where Codigo = " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo))
        End If

        CarregaForm()
        Limpar()

    End Sub

    Private Sub btnAlter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlter.ItemClick
        Alterar()
    End Sub

    Private Sub btnClear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClear.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If

    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub
End Class