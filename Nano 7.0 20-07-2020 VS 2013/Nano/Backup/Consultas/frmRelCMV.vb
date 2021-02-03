Imports Nano.clsFuncoes
Public Class frmRelCMV

    Private Sub frmRelCMV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-1), Date.Today)

        CarregarDados("SELECT Pedido.CodOrdem, Total.Data, CodProdInterno as Codigo, Produto, convert(Numeric(15,2),ValorTotal) as ValorVenda, Qtd, convert(Numeric(15,2),Pedido.Custo) as ValorCusto, convert(Numeric(15,2),(Qtd * Pedido.Custo)) as ValorCMV FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where " & strData & " and Pedido.Devolvido = 'False' and Pedido.CodConfig = " & CodConfig, Me.GridControl1)
        Calcular()

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

        CarregarDados("SELECT Pedido.CodOrdem, Total.Data, CodProdInterno as Codigo, Produto, convert(Numeric(15,2),ValorTotal) as ValorVenda, Qtd, convert(Numeric(15,2),Pedido.Custo) as ValorCusto, convert(Numeric(15,2),(Qtd * Pedido.Custo)) as ValorCMV FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig where " & strData & " and Pedido.Devolvido = 'False' and Pedido.CodConfig = " & CodConfig, Me.GridControl1)
        Calcular()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub
    Private Sub Calcular()
        Me.txtTotGer.ResetText()
        Me.txtTotPro.ResetText()
        Dim I As Integer
        With Me.GridView1
            Dim dblResPro, dblResTot As Double
            For I = 0 To .RowCount - 1
                Dim dblPro, dblTot As Double


                If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                    dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                    dblResPro += dblPro

                End If
                dblTot = .GetRowCellDisplayText(I, Me.colValorCMV)
                dblResTot += dblTot


            Next
            Me.txtTotPro.Text = dblResPro.ToString("###,###,##0.000")
            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relCMV
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim I As Integer

        Dim A As Integer = 0

        With rel.tbProd.Rows
            For I = 0 To Me.GridView1.RowCount - 1
                If Me.GridView1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    .Add()
                    .Item(I).Item("Codigo") = Me.GridView1.GetRowCellDisplayText(I, Me.colCodigo)
                    .Item(I).Item("Produto") = Me.GridView1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(I).Item("Qtd") = Me.GridView1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(I).Item("ValorVenda") = Me.GridView1.GetRowCellDisplayText(I, Me.colValorVenda)
                    .Item(I).Item("ValorCusto") = Me.GridView1.GetRowCellDisplayText(I, Me.colValorCusto)
                    .Item(I).Item("ValorCMV") = Me.GridView1.GetRowCellDisplayText(I, Me.colValorCMV)
                    A += 1
                End If
            Next
        End With
        rel.lblQtd.Text = Me.txtTotPro.Text
        rel.lblCMV.Text = Me.txtTotGer.Text
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class