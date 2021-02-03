
Imports Nano.clsFuncoes
Public Class frmCadNatOpe

    Dim bolAlterado As Boolean = False
    Dim intCodNatOpe As Integer

    Private Sub frmCadNatOpe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarGrid()
    End Sub

    Private Sub CarregarGrid()

        Me.tbNO.Rows.Clear()

        Dim dt As DataTable = CarregarDataTable("Select * from NatOpe")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1
            Me.tbNO.Rows.Add()
            Me.tbNO.Rows.Item(I).Item("Codigo") = dt.Rows.Item(I).Item("Codigo")
            Me.tbNO.Rows.Item(I).Item("Descricao") = dt.Rows.Item(I).Item("Descricao")
        Next
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick

        If Validar(Me.txtDesc) = False Then Exit Sub

        If bolAlterado = False Then
            If Existe("Descricao", "NatOpe", "Descricao", Me.txtDesc.Text.Trim, False) = True Then MsgBox("Natureza da Operação já cadastrada!", MsgBoxStyle.Information) : Me.txtDesc.ResetText() : Exit Sub

            Inserir("Insert Into NatOpe (Descricao) Values('" & Me.txtDesc.Text.Trim & "')")

            MsgBox("Natureza da Operação cadastrada com sucesso!")
        Else
            Atualizar("Update NatOpe set Descricao ='" & Me.txtDesc.Text.Trim & "' where Codigo =" & intCodNatOpe)
            MsgBox("Natureza da Operação alterada com sucesso!")
        End If

        Limpar()
        CarregarGrid()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        Alterar()
    End Sub

    Private Sub Alterar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        intCodNatOpe = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo)
        Me.txtDesc.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDescricao)
        bolAlterado = True
    End Sub

    Private Sub Limpar()
        intCodNatOpe = 0
        Me.txtDesc.ResetText()
        bolAlterado = False
    End Sub

    Private Sub btnClear_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClear.ItemClick
        Limpar()

    End Sub

    Private Sub btnAlter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlter.ItemClick
        Alterar()
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        If MsgBox("Deseja realmente excluir a Natureza da Operação " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colDescricao) & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Excluir("Delete From NatOpe where Codigo =" & Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodigo))
        End If
        CarregarGrid()
    End Sub
End Class