Imports Nano.clsFuncoes
Public Class frmRelComissao

    Private Sub Calcular()
        Dim I As Integer
        Dim dblValor As Double
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellDisplayText(I, Me.colTotal) <> "" Then
                dblValor += Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
            End If
        Next
        Me.txtTotGer.Text = dblValor.ToString("###,###,##0.00")
    End Sub

   
    Private Sub frmRelComissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDados("SELECT Pedido.CodOrdem, Cliente.Nome as Cliente, Convert(Numeric(15,2),sum(ValorTotal)) as Total, CodFunc, PorDesc, Total.Data FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem)left join Cliente on Total.CodCli = Cliente.Codigo where Devolvido <> 'true' group by Pedido.CodOrdem, Cliente.Nome, CodFunc, Total.Data,PorDesc", Me.GridControl1)
        Calcular()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relComissao
        rel.picLogo.Image = LogoTipo
        rel.lblTitulo.Text = Me.Text
        With rel.tbComissao.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Cliente") = Me.grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("CodFunc") = Me.grd1.GetRowCellDisplayText(I, Me.colCodFunc)
                .Item(I).Item("ValorTotal") = Me.grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("PorDesc") = Me.grd1.GetRowCellDisplayText(I, Me.colPorDesc)

            Next
        End With
        rel.lblTotal.Text = Me.txtTotGer.Text.Trim
        rel.ShowPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        If TesteConexao() = False Then Exit Sub

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("SELECT Pedido.CodOrdem, Cliente.Nome as Cliente, Convert(Numeric(15,2),sum(ValorTotal)) as Total, CodFunc, PorDesc, Total.Data FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem)left join Cliente on Total.CodCli = Cliente.Codigo where " & strData & " and Devolvido <> 'true' group by Pedido.CodOrdem, Cliente.Nome, CodFunc, Total.Data,PorDesc", Me.GridControl1)
        Calcular()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub
End Class