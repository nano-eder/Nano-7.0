Imports Nano.clsFuncoes
Public Class frmRelPedido
    Dim strFiltro As String = ""
    Private Sub frmRelPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TipoNano <> 5 Then
            Me.colPlaca.Visible = False
            Me.colModelo.Visible = False
        End If
        If ComandaPedido = True Then
            Me.colComanda.Visible = True
        End If
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
   
        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = " and ItensConsig.CodConfig =" & CodConfig
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True'", Me.lueFunc)
        Else
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where Ativo ='True'", Me.lueFunc)
        End If

        Dim strData As String = String.Format(" where TotalConsig.Data >= '{0:dd/MM/yyyy}' AND TotalConsig.Data <= '{1:dd/MM/yyyy}'", Date.Today.AddDays(-30), Date.Today) & strFiltro


        CarregarDados("Select ItensConsig.CodOrdens as CodOrdem, Total.CodOrdem as CodVenda, " & _
        "ItensConsig.CodigoInterno as CodProd, TotalConsig.Data, ItensConsig.Qtd, ItensConsig.Produto, " & _
        "Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, " & _
        "Convert(Numeric(15," & CasaDecimal & "),UniSemDesc) as UniSemDesc, " & _
        "Convert(Numeric(15,2), ValorTotal) as ValorTotal, Cliente.Nome as Cliente, " & _
        "TotalConsig.CodConfig, TotalConsig.Status, TotalConsig.CodFunc as Vendedor, " & _
        "Produto.Obs as ObsProduto, Produto.Tipo, TotalConsig.Comanda, Produto.Fabricante, " & _
        "Produto.Grupo, Produto.Setor, DataAdd, ItensConsig.Custo as ValorCusto, TotalConsig.Placa, " & _
        "TotalConsig.Modelo, ItensConsig.Autorizado, TotalConsig.KMEntrada, TotalConsig.Descricao as Obs, TotalConsig.Operador from (((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) " & _
        "left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) " & _
        "left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido And TotalConsig.CodConfig = Total.CodConfig" & strData, Me.GridControl1)

        Dim index As Integer = -999997
        'grd1.FocusedRowHandle = index
        'grd1.FocusedColumn = Me.colAutorizado
        grd1.SetRowCellValue(index, Me.colAutorizado, True)
        grd1.ShowEditor()


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
            strFiltro = " and ItensConsig.CodConfig =" & CodConfig
        End If

        Dim strData As String = String.Format("TotalConsig.Data >= '{0:dd/MM/yyyy}' AND TotalConsig.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        'CarregarDados("Select ItensConsig.CodOrdens as CodOrdem, ItensConsig.CodigoInterno as CodProd, TotalConsig.Data, " & _
        '"ItensConsig.Qtd, ItensConsig.Produto, ValorUnitario, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        '"Cliente.Nome as Cliente, TotalConsig.CodConfig, TotalConsig.Status, TotalConsig.CodFunc as Vendedor, " & _
        '"Produto.Obs as ObsProduto, Produto.Tipo, TotalConsig.Comanda from ((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) " & _
        '"left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) " & _
        '"left Join Cliente On TotalConsig.CodCli = Cliente.Codigo where " & strData, Me.GridControl1)


        CarregarDados("Select ItensConsig.CodOrdens as CodOrdem, Total.CodOrdem as CodVenda, ItensConsig.CodigoInterno as CodProd, TotalConsig.Data, " & _
        "ItensConsig.Qtd, ItensConsig.Produto, Convert(Numeric(15," & CasaDecimal & "),ValorUnitario) as ValorUnitario, Convert(Numeric(15," & CasaDecimal & "),UniSemDesc) as UniSemDesc, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        "Cliente.Nome as Cliente, TotalConsig.CodConfig, TotalConsig.Status, TotalConsig.CodFunc as Vendedor, " & _
        "Produto.Obs as ObsProduto, Produto.Tipo, TotalConsig.Comanda, Produto.Fabricante, Produto.Grupo, " & _
        "Produto.Setor, DataAdd, ItensConsig.Custo as ValorCusto, TotalConsig.Placa, TotalConsig.Modelo, " & _
        "ItensConsig.Autorizado, TotalConsig.KMEntrada, TotalConsig.Descricao as Obs, TotalConsig.Operador from (((ItensConsig left join Produto on ItensConsig.CodigoProduto = Produto.Codigo) " & _
        "left join TotalConsig on ItensConsig.CodOrdens = TotalConsig.CodOrdens and ItensConsig.CodConfig = TotalConsig.CodConfig) " & _
        "left Join Cliente On TotalConsig.CodCli = Cliente.Codigo) left join Total on TotalConsig.CodOrdens = Total.CodPedido And TotalConsig.CodConfig = Total.CodConfig where " & strData, Me.GridControl1)
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
        If NomeEmpresa.Contains("SAFETYMED") Then
            Dim rel As New relPedidoConsig
            rel.picLogo.Image = LogoTipo
            Dim I As Integer
            With rel.tbPed.Rows
                For I = 0 To grd1.RowCount - 1
                    .Add()
                    .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                    .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                    .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                    .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                    .Item(I).Item("ValorUnitario") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                    .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                    .Item(I).Item("CodProd") = grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    .Item(I).Item("Status") = grd1.GetRowCellDisplayText(I, Me.colStatus)
                    .Item(I).Item("Vendedor") = grd1.GetRowCellDisplayText(I, Me.colVendedor)
                    .Item(I).Item("Obs") = grd1.GetRowCellDisplayText(I, Me.colObs)
                    .Item(I).Item("ValorCusto") = grd1.GetRowCellDisplayText(I, Me.colValorCusto)

                Next
                rel.colPlaca.Visible = False
                rel.colModelo.Visible = False
                rel.colObs.Visible = False

                rel.colCliente.Width = 60
                rel.colData.Width = 35
                rel.colQtd.Width = 30
                rel.colValorTotal.Width = 25
                rel.colProduto.Width = 120
                rel.colCodOrdem.Visible = False
                rel.colValorUnitario.Visible = False
                rel.colCodProd.Visible = False
                rel.colStatus.Visible = False
                rel.colVendedor.Visible = False
                rel.colObs.Visible = False
                rel.lblPro.Visible = False
                rel.lblQtdeProduto.Visible = False
                rel.lblTitulo.Text = "Relatório de Atendimentos"
                rel.lblTotal.Text = Me.txtTotGer.Text
                rel.colObs.Visible = Me.colObs.Visible
                rel.colValorCusto.Visible = Me.colValorCusto.Visible
                rel.ShowPreview()

            End With
        Else
            Dim rel As New relPedidoConsig
            rel.picLogo.Image = LogoTipo
            Dim I As Integer

            Dim dtDataInicial As Date
            Dim dtDataFinal As Date
            Dim dtDT As Date
     
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

                    .Item(I).Item("ValorCusto") = grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                    .Item(I).Item("Placa") = grd1.GetRowCellDisplayText(I, Me.colPlaca)
                    .Item(I).Item("Modelo") = grd1.GetRowCellDisplayText(I, Me.colModelo)

                    dtDT = grd1.GetRowCellDisplayText(I, Me.colData)
                    If I = 0 Then
                        dtDataInicial = dtDT
                        dtDataFinal = dtDT
                    End If
                    If dtDT < dtDataInicial Then
                        dtDataInicial = dtDT
                    End If
                    If dtDT > dtDataFinal Then
                        dtDataFinal = dtDT
                    End If
                Next
                If TipoNano <> 5 Then
                    rel.colPlaca.Visible = False
                    rel.colModelo.Visible = False
                    rel.colObs.Visible = Me.colObs.Visible
                    rel.colValorCusto.Visible = Me.colValorCusto.Visible
                Else
                    rel.colValorCusto.Visible = False
                    rel.colVendedor.Visible = False
                End If

                rel.lblPeriodo.Text = "De " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")
                rel.lblPro.Text = Me.txtTotPro.Text
                rel.lblTotal.Text = Me.txtTotGer.Text

                rel.ShowPreview()

            End With
        End If
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