Imports Nano.clsFuncoes
Public Class frmConVenda

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmConVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmConVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        Dim strFiltro As String = ""
        If Master = False Then
            strFiltro = " where Total.CodConfig = " & CodConfig
        End If

        CarregarDados("Select CodOrdem, Total.CodCli, Cliente.Nome as Cliente, Total.CPFCliente as CPF, " & _
        "Total.Total, Total.Data, Total.CodConfig, TotalConsig.Descricao as Observacao, Total.CodPedido " & _
        "from (Total Left Join Cliente on Total.CodCli = Cliente.Codigo) left join TotalConsig on " & _
        "Total.CodPedido = TotalConsig.CodOrdens and Total.CodConfig = TotalConsig.CodConfig " & strFiltro & " order by CodOrdem Desc", Me.GridControl1)
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick, dtData.DoubleClick, lueLoja.DoubleClick
        Retorna()
    End Sub

    Private Sub Retorna()
        frmVenda.intCodOrdemVenda = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodOrdem)
        frmVenda.intCodConfigVenda = Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colCodConfig)
        Me.Close()
    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Retorna()
    End Sub
End Class