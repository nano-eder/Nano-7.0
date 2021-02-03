Imports Nano.clsFuncoes
Public Class frmRelPedCompra
    Dim strFiltro As String = ""
    Private Sub frmRelPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = " where PedCompra.CodConfig =" & CodConfig
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True'", Me.lueFunc)
        Else
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where Ativo ='True'", Me.lueFunc)
        End If

        CarregarDados("Select PedCompra.CodOrdens as CodOrdem, Total.CodOrdem as CodVenda, PedCompra.CodigoInterno as CodProd, TotalPedCompra.Data, " & _
        "PedCompra.Qtd, PedCompra.Produto, ValorUnitario, UniSemDesc, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        "Fornecedor.Nome as Fornecedor, TotalPedCompra.CodConfig, TotalPedCompra.Status, TotalPedCompra.CodFunc as Vendedor, TotalPedCompra.NumeroNF as NumNF, " & _
        "Produto.Obs as ObsProduto, Produto.Fabricante, Produto.Tipo, TotalPedCompra.Descricao as Obs From (((PedCompra left join Produto on PedCompra.CodigoProduto = convert(varchar(20),Produto.Codigo)) " & _
        "left join TotalPedCompra on PedCompra.CodOrdens = TotalPedCompra.CodOrdens and PedCompra.CodConfig = TotalPedCompra.CodConfig) " & _
        "left Join Fornecedor On TotalPedCompra.CodFor = Fornecedor.Codigo) left join Total on TotalPedCompra.CodOrdens = Total.CodPedido" & strFiltro, Me.GridControl1)
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
        If Master = False Then
            strFiltro = " and PedCompra.CodConfig =" & CodConfig
        End If

        Dim strData As String = String.Format("TotalPedCompra.Data >= '{0:dd/MM/yyyy}' AND TotalPedCompra.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        CarregarDados("Select PedCompra.CodOrdens as CodOrdem, PedCompra.CodigoInterno as CodProd, TotalPedCompra.Data, " & _
        "PedCompra.Qtd, PedCompra.Produto, ValorUnitario, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        "Fornecedor.Nome as Fornecedor, TotalPedCompra.CodConfig, TotalPedCompra.Status, TotalPedCompra.CodFunc as Vendedor, TotalPedCompra.NumeroNF as NumNF, " & _
        "Produto.Obs as ObsProduto, Produto.Fabricante, Produto.Tipo from ((PedCompra left join Produto on PedCompra.CodigoProduto = convert(varchar(20),Produto.Codigo)) " & _
        "left join TotalPedCompra on PedCompra.CodOrdens = TotalPedCompra.CodOrdens and PedCompra.CodConfig = TotalPedCompra.CodConfig) " & _
        "left Join Fornecedor On TotalPedCompra.CodFor = Fornecedor.Codigo where " & strData, Me.GridControl1)
        Calcular()
    End Sub
    Private Sub Calcular()
        Me.txtTotGer.ResetText()
        Me.txtTotPro.ResetText()
        Dim I As Integer
        With grd1
            Dim dblResPro, dblResTot As Double
            For I = 0 To .RowCount - 1
                Dim dblPro, dblTot As Double

                If Not .GetRowCellDisplayText(I, Me.colQtd).Contains(":") Then
                    dblPro = .GetRowCellDisplayText(I, Me.colQtd)
                    dblResPro += dblPro
                End If

                dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                dblResTot += dblTot

            Next
            Me.txtTotPro.Text = dblResPro.ToString("###,###,##0.000")
            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub
    Private Sub btnRelPed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelPed.ItemClick
        Dim rel As New relPedidoConsig
        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        With rel.tbPed.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("ValorUnitario") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("CodProd") = grd1.GetRowCellDisplayText(I, Me.colCodProd)
                .Item(I).Item("Status") = grd1.GetRowCellDisplayText(I, Me.colStatus)
                .Item(I).Item("Vendedor") = grd1.GetRowCellDisplayText(I, Me.colVendedor)
                .Item(I).Item("Obs") = grd1.GetRowCellDisplayText(I, Me.colObs)

            Next
            rel.lblPro.Text = Me.txtTotPro.Text
            rel.lblTotal.Text = Me.txtTotGer.Text

            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub chkObsProd_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkObsProd.CheckedChanged
        If Me.chkObsProduto.EditValue = False Then
            Me.colObsProduto.Visible = True
        Else
            Me.colObsProduto.Visible = False
        End If
    End Sub

    Private Sub btnConsultar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultar.ItemClick
        If TipoNano = 3 Then
            Dim frm As New frmPedidoAnimal
            frm.Tag = "CONSULTA"
            frm.txtCodPed.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdem)
            frm.Show()
        Else
            Dim frm As New frmPedido
            frm.Tag = "CONSULTA"
            frm.txtCodPed.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdem)
            frm.Show()
        End If

    End Sub
End Class