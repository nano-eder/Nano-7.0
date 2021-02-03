Imports Nano.clsFuncoes
Public Class frmConNfe

    Private Sub frmConNfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDados("SELECT CodOrdem, NumNF, case when Cliente.Nome is null then Fornecedor.Nome else Cliente.Nome end  as Destinatario, DEmi as Data, NatOp FROM (TotalNfe left join Cliente on TotalNfe.CodCli = Cliente.Codigo) left join Fornecedor on TotalNfe.CodForn = Fornecedor.Codigo", Me.GridControl1)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colNumNF
        grd1.ShowEditor()
        Timer1.Stop()
    End Sub

    Private Sub txtRetorna_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetorna.DoubleClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        ConsultaNFE = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdem)
        Me.Close()
    End Sub

    Private Sub txtRetorna_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorna.KeyDown
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            ConsultaNFE = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdem)
            Me.Close()
        End If
    End Sub
End Class