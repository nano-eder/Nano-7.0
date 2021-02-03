Public Class frmPmc3
    Public intIndexLinha As Integer = 0
    Public strColuna As String = 0

    Private Sub frmPmc1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer

        For I = 0 To 8
            Me.tbEti.Rows.Add()

            Me.tbEti.Rows.Item(I).Item("1") = I + 1
            Me.tbEti.Rows.Item(I).Item("2") = I + 1
            Me.tbEti.Rows.Item(I).Item("3") = I + 1
            Me.tbEti.Rows.Item(I).Item("4") = I + 1
            Me.tbEti.Rows.Item(I).Item("5") = I + 1
            Me.tbEti.Rows.Item(I).Item("6") = I + 1
            Me.tbEti.Rows.Item(I).Item("7") = I + 1
            Me.tbEti.Rows.Item(I).Item("8") = I + 1
            Me.tbEti.Rows.Item(I).Item("9") = I + 1
            Me.tbEti.Rows.Item(I).Item("10") = I + 1
            Me.tbEti.Rows.Item(I).Item("11") = I + 1

        Next
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        intIndexLinha = Me.GridView1.FocusedRowHandle + 1
        strColuna = Me.GridView1.FocusedColumn.Name.Replace("col", "")
        Me.Close()
    End Sub
End Class