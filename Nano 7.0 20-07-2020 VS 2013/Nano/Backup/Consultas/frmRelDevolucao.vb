Imports Nano.clsFuncoes
Public Class frmRelDevolucao
    Dim strFiltro As String = ""

    Private Sub AtualizarGrid()
        CarregarDados("SELECT Devolucao.Codigo, Produto.CodigoInterno as CodProd, Produto.CodigoBarra, " & _
        "Qtde, Motivo, Produto.Nome as Produto, Convert(Numeric(15,2),Devolucao.Valor) as Valor, " & _
        "Convert(Numeric(15,2),(Devolucao.Qtde * Devolucao.Valor)) as ValorTotal, CodCli, Cliente.Nome as Cliente, " & _
        "Devolucao.CodFunc, Funcionario.Nome as Funcionario, Devolucao.Data, Devolucao.Tamanho, Devolucao.CodConfig " & _
        "FROM Devolucao, Produto, Cliente, Funcionario where Devolucao.CodProd = Produto.Codigo and " & _
        "Devolucao.CodCli = Cliente.Codigo and Devolucao.CodFunc = Funcionario.Codigo" & strFiltro, Me.GridControl1)
    End Sub

    Private Sub frmRelDevolucao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "50")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelDevolucao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        If Master = False Then
            strFiltro = " and Devolucao.CodConfig =" & CodConfig
        End If
        AtualizarGrid()
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.txtQtde.ResetText()
        Me.txtValorTotal.ResetText()
        Dim I As Integer
        With grd1

            For I = 0 To .RowCount - 1
                Dim dblPro, dblTot As Double
                If Not .GetRowCellDisplayText(I, Me.colQtde).Contains(":") Then
                    dblPro = .GetRowCellDisplayText(I, Me.colQtde)
                End If
                dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)

                Dim dblResPro, dblResTot As Double
                dblResPro += dblPro
                dblResTot += dblTot

                Me.txtQtde.Text = dblResPro.ToString
                Me.txtValorTotal.Text = dblResTot.ToString("###,###,##0.00")

            Next

        End With
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

        CarregarDados("SELECT Devolucao.Codigo, Produto.CodigoInterno as CodProd, Produto.CodigoBarra, Qtde, " & _
        "Motivo, Produto.Nome as Produto, Convert(Numeric(15,2),Devolucao.Valor) as Valor, Convert(Numeric(15,2)," & _
        "(Devolucao.Qtde * Devolucao.Valor)) as ValorTotal, CodCli, Cliente.Nome as Cliente, Devolucao.CodFunc, " & _
        "Funcionario.Nome as Funcionario, Devolucao.Data, Devolucao.Tamanho, Devolucao.CodConfig FROM " & _
        "Devolucao, Produto, Cliente, Funcionario where Devolucao.CodProd = Produto.Codigo and Devolucao.CodCli = Cliente.Codigo and Devolucao.CodFunc = Funcionario.Codigo and " & String.Format("Devolucao.Data >= '{0:dd/MM/yyyy}' AND Devolucao.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro, Me.GridControl1)

        ' CarregarDados("SELECT Devolucao.Codigo, CodProd, Qtde, Motivo, Produto.Nome as Produto, Convert(Numeric(15,2),Devolucao.Valor) as Valor, Convert(Numeric(15,2),(Devolucao.Qtde * Devolucao.Valor)) as ValorTotal, CodCli, Cliente.Nome as Cliente, CodFunc, Funcionario.Nome as Funcionario, Devolucao.Data, Devolucao.Tamanho, Devolucao.CodConfig FROM Devolucao, Produto, Cliente, Funcionario where Devolucao.CodProd = Produto.Codigo and Devolucao.CodCli = Cliente.Codigo and Devolucao.CodFunc = Funcionario.Codigo" & strFiltro, Me.GridControl1)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick

        Me.Close()
    End Sub

    Private Sub btnRelDev_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelDev.ItemClick
        Dim rel As New relDevolucao
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text

        rel.picLogo.Image = LogoTipo

        With rel.tbRelDevol.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("CodProd") = grd1.GetRowCellDisplayText(I, Me.colCodProd)
                .Item(I).Item("CodigoBarra") = grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Qtde") = grd1.GetRowCellDisplayText(I, Me.colQtde)
                .Item(I).Item("ValorUni") = grd1.GetRowCellDisplayText(I, Me.colValorUni)
                .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Cliente") = grd1.GetRowCellDisplayText(I, Me.colCliente)
                .Item(I).Item("Funcionario") = grd1.GetRowCellDisplayText(I, Me.colFuncionario)
                .Item(I).Item("Motivo") = grd1.GetRowCellDisplayText(I, Me.colMotivo)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
            Next


            rel.lblQtde.Text = Me.txtQtde.Text
            rel.lblValorTotal.Text = Me.txtValorTotal.Text.Trim

            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class