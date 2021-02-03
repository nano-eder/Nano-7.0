Imports Nano.clsFuncoes
Public Class frmRelComanda
    Dim I As Integer
    Dim strFiltro As String = ""

    Private Sub frmConPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
     
    End Sub

    Private Sub frmConPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Funcionario' table. You can move, or remove it, as needed.
        Me.FuncionarioTableAdapter.Fill(Me.DsNanoCommerce.Funcionario)
        If TesteConexao() = False Then Exit Sub
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        If Nivel = "USUÁRIO" Then

        Else
            Me.grd1.OptionsView.ShowFooter = True
        End If

        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = "where Comanda.CodConfig =" & CodConfig
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where CodConfig =" & CodConfig & " and Ativo ='True'", Me.lueFunc)
        Else
            CarregarDadosLue2("Select Codigo, Nome from Funcionario where Ativo ='True'", Me.lueFunc)
        End If

        CarregarDados("Select Comanda.Codigo, Comanda.CodOrdens as CodOrdem, CodComanda, Comanda.CodFunc, " & _
        "Comanda.CodProdInterno as CodProduto, Comanda.Data, Comanda.Qtd, Comanda.Produto, " & _
        "Convert(Numeric(15,2),Comanda.ValorUnitario) as ValorUnitario, Convert(Numeric(15,2), Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
        "Cliente.Nome as Cliente, Comanda.CodConfig, Comanda.Troco, Comanda.Tempo, Comanda.Status, Comanda.Tipo from " & _
        "Comanda left join Cliente On Comanda.CodCli = Cliente.Codigo " & strFiltro, Me.PedidoGridControl)

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.txtTotGer.ResetText()
        Me.txtTotPro.ResetText()

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
        strFiltro = " and  Comanda.CodConfig =" & CodConfig

        CarregarDados("Select Comanda.Codigo, Comanda.CodOrdens as CodOrdem, CodComanda, Comanda.CodFunc, " & _
        "Comanda.CodProdInterno as CodProduto, Comanda.Data, Comanda.Qtd, Comanda.Produto, " & _
        "Convert(Numeric(15,2),Comanda.ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),Comanda.Qtd * Comanda.ValorUnitario) as ValorTotal, " & _
        "Cliente.Nome as Cliente, Comanda.CodConfig, Comanda.Troco, Comanda.Tempo, Comanda.Status, Comanda.Tipo from " & _
        "Comanda left join Cliente On Comanda.CodCli = Cliente.Codigo where " & _
        "" & String.Format("Comanda.Data >= '{0:dd/MM/yyyy}' AND Comanda.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dataFim.AddDays(1)) & strFiltro, Me.PedidoGridControl)

    End Sub

    Private Sub chkCusto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCusto.CheckedChanged
        If Me.chkCus.EditValue = False Then
            Me.colTroco.Visible = True
        Else
            Me.colTroco.Visible = False
        End If
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.PedidoGridControl.ShowPrintPreview()
    End Sub

    Private Sub btnRelVend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelVend.ItemClick
        Dim rel As New relComanda
        rel.picLogo.Image = LogoTipo
        With rel.tbComanda.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                .Item(I).Item("CodComanda") = grd1.GetRowCellDisplayText(I, Me.colCodComanda)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("ValorUnitario") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("CodProduto") = grd1.GetRowCellDisplayText(I, Me.colCodProduto)
                .Item(I).Item("CodFunc") = grd1.GetRowCellDisplayText(I, Me.colCodFunc)
                .Item(I).Item("Status") = grd1.GetRowCellDisplayText(I, Me.colStatus)
                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)
            Next
            rel.colCodConfig.Visible = Master

            rel.lblPro.Text = Me.txtTotPro.Text
            rel.lblTotal.Text = Me.txtTotGer.Text

            rel.ShowPreview()

        End With
    End Sub

    Private Sub chkDev_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDev.CheckedChanged
        If Me.chkDevol.EditValue = False Then
            Me.colTempo.Visible = True
        Else
            Me.colTempo.Visible = False
        End If
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class

