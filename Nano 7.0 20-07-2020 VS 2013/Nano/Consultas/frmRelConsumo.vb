Imports Nano.clsFuncoes
Public Class frmRelConsumo
    Dim intCodConfig As Integer
    Dim strFiltro As String = ""

    Private Sub frmRelConsumo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "46")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDadosLue3("Select Codigo, Descricao from Config", Me.lueLoja)
        intCodConfig = CodConfig
        If Master = False Then
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        If Me.Tag = "CLIENTE" Then
            If Master = False Then
                strFiltro = " and Pedido.CodConfig =" & intCodConfig

            Else
                If Me.lueLoja.EditValue <> Nothing Then
                    strFiltro = " and Pedido.CodConfig =" & intCodConfig
                End If
            End If
            Me.colTamanho.Visible = False
            CarregarDados("Select Cliente.Nome as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)  left Join Cliente on Total.CodCli = Cliente.Codigo where Devolvido = 'False' " & strFiltro & " group by Cliente.Nome, TipoItens", Me.PedidoGridControl)

            Me.colProduto.Caption = "Cliente"

            Timer1.Start()
        End If
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
        CalcularPorcentagem()

    End Sub
    Private Sub Calcular()
        Me.txtTot.ResetText()
        Me.txtTotCusto.ResetText()
        Me.txtLucro.ResetText()

        Dim I As Integer
        Dim dblResTot, dblTotCusto, dblResLucro As Double
        With grd1

            For I = 0 To .RowCount - 1
                Dim dblTot, dblCusto, dblLucro As Double

                If .GetRowCellDisplayText(I, Me.colValorTotal) <> "" Then
                    dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                    dblResTot += dblTot
                End If


                If .GetRowCellDisplayText(I, Me.colCusto) <> "" Then
                    dblCusto = .GetRowCellDisplayText(I, Me.colCusto)
                    dblTotCusto += dblCusto
                End If

                If .GetRowCellDisplayText(I, Me.colLucro) <> "" Then
                    dblLucro = .GetRowCellDisplayText(I, Me.colLucro)
                    dblResLucro += dblLucro
                End If
            Next

            Me.txtTot.Text = dblResTot.ToString("###,###,##0.00")

            Me.txtTotCusto.Text = dblTotCusto.ToString("###,###,##0.00")

            Me.txtLucro.Text = dblResLucro.ToString("###,###,##0.00")


            Dim dblMargem As Double


            dblMargem = (dblResLucro * 100) / dblTotCusto

            Me.txtPorc.Text = dblMargem.ToString("0.00")
        End With
    End Sub
    Private Sub CalcularPorcentagem()
        Dim I As Integer
        Dim dblTotalLucro As Double = Me.txtLucro.Text

        For I = 0 To Me.grd1.RowCount - 1
            Dim dblLucro As Double = Me.grd1.GetRowCellDisplayText(I, Me.colLucro)
            Dim dblCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colCusto)
            Dim dblPor As Double
            dblPor = (dblLucro * 100) / dblCusto

            Dim strVeri As String = dblPor

            If strVeri = "+Infinito" Then
                dblPor = 100
            End If
            If strVeri = "-Infinito" Then
                dblPor = 0
            End If

            If strVeri = "NaN (Não é um número)" Then
                dblPor = 0
            End If
            Me.grd1.SetRowCellValue(I, Me.colPorcentagem, dblPor.ToString("0.00"))
        Next
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

        If Me.cboPesquisa.EditValue = "" Then
            MsgBox("Selecione o tipo de pesquisa!", MsgBoxStyle.Information)
        End If

        Dim strData As String
        strData = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        If Master = False Then
            strFiltro = " and Pedido.CodConfig =" & intCodConfig

        Else
            If Me.lueLoja.EditValue <> Nothing Then
                strFiltro = " and Pedido.CodConfig =" & intCodConfig
            End If
        End If
        Me.colTamanho.Caption = "Tamanho"
        Select Case Me.cboPesquisa.EditValue
            Case "PRODUTO"
                Me.colCodigoProduto.Visible = True
                Me.colTamanho.Visible = True
                Me.colFornecedor.Visible = True

                Me.colEntrada.Visible = True
                Me.colCodigoProduto.VisibleIndex = 0
                Me.colProduto.VisibleIndex = 1
                Me.colFornecedor.VisibleIndex = 2
                Dim strDataEntrada As String = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' and TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & " AND EstoqueOk ='True' and TotalEntradaNF.CodConfig = " & CodConfig


                Dim strNomeProd As String = "Produto"
                If NomeEmpresa.Contains("TEM DESCONTO") = True Then
                    strNomeProd = "Produto.Nome"
                End If
                CarregarDados("Select Produto.CodigoInterno as CodigoProduto, Pedido.Tamanho, " & strNomeProd & " as Produto, Sum(Pedido.Qtd) as Qtd, " & _
                "Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, " & _
                "Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, " & _
                "Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, " & _
                "TipoItens, Fabricante as Fornecedor, (select case when sum(Qtd) is null then 0 else sum(Qtd) end FROM " & _
                "EntradaNF left join TotalentradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                "EntradaNF.CodConfig = TotalEntradaNF.CodConfig where " & strDataEntrada & " and " & _
                "EntradaNf.CodProd = Pedido.CodProd) as Entrada, Produto.Grupo from (Pedido left join Total on " & _
                "Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join Produto on Pedido.CodProd = Produto.Codigo " & _
                "where " & strData & strFiltro & " and Devolvido = 'False' group by Produto.Grupo, CodigoInterno, Fabricante, Pedido.Tamanho, " & strNomeProd & ", TipoItens, Pedido.CodProd", Me.PedidoGridControl)

                'CarregarDados("Select Pedido.CodProdInterno as CodigoProduto, Pedido.Tamanho, Produto, Sum(Pedido.Qtd) as Qtd, " & _
                '"Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, " & _
                '"Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, " & _
                '"Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, " & _
                '"TipoItens, Fabricante as Fornecedor, (select case when sum(Qtd) is null then 0 else sum(Qtd) end FROM " & _
                '"EntradaNF left join TotalentradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                '"EntradaNF.CodConfig = TotalEntradaNF.CodConfig where " & strDataEntrada & " and " & _
                '"EntradaNf.CodProd = Pedido.CodProd) as Entrada from (Pedido left join Total on " & _
                '"Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join Produto on Pedido.CodProd = Produto.Codigo " & _
                '"where " & strData & strFiltro & " and Devolvido = 'False' group by CodProdInterno, Fabricante, Pedido.Tamanho, Produto, TipoItens, Pedido.CodProd", Me.PedidoGridControl)
                Me.colProduto.Caption = "Produto"
                Me.colFornecedor.Caption = "Fornecedor"

            Case "GRUPO"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colFornecedor.Visible = False
                Me.colEntrada.Visible = False
                Me.colTamanho.Visible = False
                CarregarDados("Select Produto.Grupo as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left Join Produto on Pedido.CodProd = Produto.Codigo where " & strData & strFiltro & " and Devolvido = 'False' group by Produto.Grupo, TipoItens", Me.PedidoGridControl)
                Me.colProduto.Caption = "Grupo"

            Case "FORNECEDOR"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colFornecedor.Visible = False
                Me.colEntrada.Visible = False
                Me.colTamanho.Visible = False
                CarregarDados("Select Produto.Fabricante as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left Join Produto on Pedido.CodProd = Produto.Codigo where " & strData & strFiltro & " and Devolvido = 'False' group by Produto.Fabricante, TipoItens", Me.PedidoGridControl)
                Me.colProduto.Caption = "Fornecedor"

            Case "SETOR"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colFornecedor.Visible = False
                Me.colEntrada.Visible = False
                Me.colTamanho.Visible = False
                CarregarDados("Select Produto.Setor as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left Join Produto on Pedido.CodProd = Produto.Codigo where " & strData & strFiltro & " and Devolvido = 'False' group by Produto.Setor, TipoItens", Me.PedidoGridControl)
                Me.colProduto.Caption = "Setor"
            Case "FAMILIA"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colFornecedor.Visible = False
                Me.colEntrada.Visible = False
                Me.colTamanho.Visible = False
                CarregarDados("Select Produto.Familia as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left Join Produto on Pedido.CodProd = Produto.Codigo where " & strData & strFiltro & " and Devolvido = 'False' group by Produto.Familia, TipoItens", Me.PedidoGridControl)
                Me.colProduto.Caption = "Família"

            Case "CLIENTE"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colEntrada.Visible = False
                'Me.colTamanho.Visible = False
                Me.colTamanho.Caption = "Data Ult. Venda"
                Me.colTamanho.Width = 100
                Me.colFornecedor.Visible = True
                Me.colProduto.VisibleIndex = 0
                Me.colFornecedor.VisibleIndex = 1

                CarregarDados("Select Cliente.Nome as Produto, Cliente.Cidade as Fornecedor, Sum(Pedido.Qtd) as Qtd, " & _
                "Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, " & _
                "Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2), " & _
                "Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens, Max(Total.Data) as Tamanho " & _
                "from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) " & _
                "left Join Cliente on Total.CodCli = Cliente.Codigo where " & strData & strFiltro & " and Devolvido = 'False' " & _
                "group by Cliente.Nome, Cliente.Cidade, TipoItens", Me.PedidoGridControl)

                Me.colProduto.Caption = "Cliente"
                Me.colFornecedor.Caption = "Cidade"

            Case "FUNCIONÁRIO"
                Me.colGrupo.Visible = False
                Me.colCodigoProduto.Visible = False
                Me.colFornecedor.Visible = False
                Me.colEntrada.Visible = False
                Me.colTamanho.Visible = False
                CarregarDados("Select Funcionario.Nome as Produto, Sum(Pedido.Qtd) as Qtd, Convert(Numeric(15,2),Sum(ValorTotal)) as ValorTotal, Convert(Numeric(15,2),Sum(Pedido.Custo)) as Custo, Convert(Numeric(15,2),Sum(ValorTotal) - Sum(Pedido.Custo)) as Lucro, Convert(Numeric(15,2),Sum(Pedido.Custo)-Sum(Pedido.Custo)) as Porcentagem, TipoItens from (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig)  left Join Funcionario on Pedido.CodFunc = Funcionario.Codigo where " & strData & strFiltro & " and Devolvido = 'False' group by Funcionario.Nome, TipoItens", Me.PedidoGridControl)
                Me.colProduto.Caption = "Funcinário"

        End Select
        Calcular()
        CalcularPorcentagem()
    End Sub

    Private Sub lueLoj_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoj.Leave
        If Me.lueLoja.EditValue <> Nothing Then
            intCodConfig = Me.lueLoja.EditValue
        End If

    End Sub

    Private Sub btnRelCons_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCons.ItemClick
        Dim rel As New relConsumo
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.tbPed.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Valor") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Custo") = grd1.GetRowCellDisplayText(I, Me.colCusto)
                .Item(I).Item("Lucro") = grd1.GetRowCellDisplayText(I, Me.colLucro)
                .Item(I).Item("Porcentagem") = grd1.GetRowCellDisplayText(I, Me.colPorcentagem)
                .Item(I).Item("Tamanho") = grd1.GetRowCellDisplayText(I, Me.colTamanho)
            Next

            rel.lblPeriodo.Text = "De " & Format(Me.dtInicial.EditValue, "dd/MM/yyyy") & " a " & Format(Me.dtFinal.EditValue, "dd/MM/yyyy")

            Select Case Me.cboPesquisa.EditValue
                Case "PRODUTO"
                    rel.colTamanho.Visible = True
                    rel.colProduto.Caption = "Produto"
                Case "GRUPO"
                    rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Grupo"
                Case "FORNECEDOR"
                    rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Fornecedor"
                Case "SETOR"
                    rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Setor"
                Case "FAMILIA"
                    rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Família"
                Case "CLIENTE"
                    rel.colTamanho.Caption = "Data Ult. Venda"
                    rel.colTamanho.Width = 100
                    'rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Cliente"
                Case "FUNCIONÁRIO"
                    rel.colTamanho.Visible = False
                    rel.colProduto.Caption = "Funcionário"
            End Select

            rel.lblTotal.Text = Me.txtTot.Text
            rel.lblCusto.Text = Me.txtTotCusto.Text.Trim
            rel.lblLucro.Text = Me.txtLucro.Text.Trim
            rel.lblPorc.Text = Me.txtPorc.Text.Trim
            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCust.ItemClick
        Me.PedidoGridControl.ShowPrintPreview()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) = NomeDoCliente Then
                Me.grd1.FocusedRowHandle = I
                grd1.FocusedColumn = Me.colProduto
                grd1.ShowEditor()
                Exit For
            End If
        Next
        'If Me.Tag = "CLIENTE" Then
        '    Dim index As Integer = -999997
        '    grd1.FocusedRowHandle = index
        '    grd1.FocusedColumn = Me.colProduto
        '    grd1.SetRowCellValue(index, Me.colProduto, NomeDoCliente)
        '    grd1.ShowEditor()

        'End If

        Calcular()
        CalcularPorcentagem()
        Me.Timer1.Stop()

    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

End Class