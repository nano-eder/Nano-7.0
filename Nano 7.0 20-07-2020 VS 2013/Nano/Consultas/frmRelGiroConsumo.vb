Imports Nano.clsFuncoes
Public Class frmRelGiroConsumo
    Dim intCodConfig As Integer
    Dim strFiltroPed As String = ""
    Dim strFiltroEnt As String = ""
    Dim strFiltroAjuste As String = ""

    Private Sub frmRelGiroConsumo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "49")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRelGiroConsumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        CarregarDadosLue3("Select Codigo, Descricao from Config", Me.lueLoja)
        intCodConfig = CodConfig

        If Master = False Then
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If


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
            strFiltroPed = " and Pedido.CodConfig =" & intCodConfig
            strFiltroEnt = " and EntradaNF.CodConfig =" & intCodConfig
            strFiltroAjuste = " and AjusteQtde.CodConfig = " & intCodConfig
        Else
            If Me.lueLoja.EditValue <> Nothing Then
                strFiltroPed = " and Pedido.CodConfig =" & intCodConfig
                strFiltroEnt = " and EntradaNF.CodConfig =" & intCodConfig
                strFiltroAjuste = " and AjusteQtde.CodConfig = " & intCodConfig
            End If
        End If

        Dim strData As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        Dim dtProd, dtPed As DataTable

        If EstoqueSomado = False Then
            dtProd = CarregarDataTable("SELECT Produto.Grupo, Produto.Codigo, CodigoInterno, Nome, Fabricante, Setor, " & _
            "(SELECT sum(Qtde.Qtd) FROM Qtde where Qtde.CodProd = Produto.Codigo and Qtde.CodConfig = " & intCodConfig & ") as Qtd " & _
            "FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' group by Produto.Grupo, Produto.Codigo, " & _
            "CodigoInterno, Nome, Fabricante, Setor order by Produto.Codigo")

        Else
            dtProd = CarregarDataTable("SELECT Produto.Grupo, Produto.Codigo, CodigoInterno, Nome, Fabricante, Setor, " & _
            "(SELECT case when sum(EntradaNf.QtdProd) is null then 0 else sum(EntradaNf.QtdProd) end " & _
            "FROM EntradaNf left join TotalEntradaNf on EntradaNf.CodTotNf = TotalEntradaNf.Codigo where " & _
            "EntradaNf.CodProd = Produto. Codigo and EstoqueOk = 'True' " & strFiltroEnt & ") - (SELECT case when " & _
            "sum(Pedido.Qtd) is null then 0 else sum(Pedido.Qtd) end FROM Pedido where " & _
            "Pedido.CodProd = Produto.Codigo and Pedido.Devolvido = 'False' " & strFiltroPed & ") + (SELECT case when sum(AjusteQtde.Qtd) is null then 0 else  sum(AjusteQtde.Qtd) end " & _
            "FROM AjusteQtde where AjusteQtde.CodProd = Produto.Codigo " & strFiltroAjuste & ") as Qtd FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Produto.Inativo = 'False' group by Produto.Grupo, Produto.Codigo, CodigoInterno, Nome, Fabricante, Setor order by Produto.Codigo")

        End If

        'dtPed = CarregarDataTable("SELECT Produto.Codigo, sum(Qtd) as Qtd FROM (Produto left join Pedido on Produto.Codigo = Pedido.CodProd) left join Total on Pedido.CodOrdem = Total.CodOrdem where Pedido.CodConfig = " & intCodConfig & " and Total.CodConfig = " & intCodConfig & " and " & strData & " group by Produto.Codigo order by Produto.Codigo")
        If NomeEmpresa.Contains("DESCONTO") = True Then
            dtPed = CarregarDataTable("SELECT Produto.Codigo, (Select case when Sum(Qtd) is null then 0 " & _
            "else sum(Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and " & _
            "Pedido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo and Pedido.TipoItens <> 'CONSUMO' and " & strData & " and " & _
            "Devolvido = 'false' " & strFiltroPed & ") as Qtd FROM Produto where Produto.Inativo = 'False' order by Produto.Codigo")

        Else
            dtPed = CarregarDataTable("SELECT Produto.Codigo, (Select case when Sum(Qtd) is null then 0 " & _
            "else sum(Qtd) end FROM Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and " & _
            "Pedido.CodConfig = Total.CodConfig where Pedido.CodProd = Produto.Codigo and " & strData & " and " & _
            "Devolvido = 'false' " & strFiltroPed & ") as Qtd FROM Produto where Produto.Inativo = 'False' order by Produto.Codigo")

        End If

        Me.tbGiro.Rows.Clear()
        Dim I As Integer
        Dim A As Integer = 0
        For I = 0 To dtProd.Rows.Count - 1
            Dim strCodigo As String = dtProd.Rows.Item(I).Item("Codigo").ToString
            Dim dblQtdEst As Double = 0
            Dim dblQtdPed As Double = 0
            Dim dblSaldo As Double
            Dim dblGiro As Double
            If dtProd.Rows.Item(I).Item("Qtd").ToString <> "" Then
                dblQtdEst = dtProd.Rows.Item(I).Item("Qtd").ToString
            End If

            If A < dtPed.Rows.Count Then
                Dim strCodProd As String = dtPed.Rows.Item(A).Item("Codigo").ToString
                If strCodProd = strCodigo Then
                    dblQtdPed = dtPed.Rows.Item(A).Item("Qtd").ToString
                    A += 1
                End If

            End If

            dblSaldo = dblQtdEst - dblQtdPed

            dblGiro = (dblQtdEst / dblQtdPed)
            Dim strGiro As String = dblGiro
            If strGiro = "NaN (Não é um número)" Or strGiro = "+Infinito" Or strGiro = "-Infinito" Then
                dblGiro = 0
            End If
            Me.tbGiro.Rows.Add()
            Me.tbGiro.Rows.Item(I).Item("Fornecedor") = dtProd.Rows.Item(I).Item("Fabricante").ToString
            Me.tbGiro.Rows.Item(I).Item("CodProd") = dtProd.Rows.Item(I).Item("CodigoInterno").ToString
            Me.tbGiro.Rows.Item(I).Item("Produto") = dtProd.Rows.Item(I).Item("Nome").ToString
            Me.tbGiro.Rows.Item(I).Item("Saida") = dblQtdPed.ToString("0.000")
            Me.tbGiro.Rows.Item(I).Item("Entrada") = dblQtdEst.ToString("0.000")
            Me.tbGiro.Rows.Item(I).Item("Saldo") = dblSaldo.ToString("0.000")
            Me.tbGiro.Rows.Item(I).Item("Giro") = dblGiro.ToString("0.000")
            Me.tbGiro.Rows.Item(I).Item("Setor") = dtProd.Rows.Item(I).Item("Setor").ToString
            Me.tbGiro.Rows.Item(I).Item("Grupo") = dtProd.Rows.Item(I).Item("Grupo").ToString
        Next


    End Sub

    Private Sub lueLoj_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueLoj.Leave
        If Me.lueLoja.EditValue <> Nothing Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelGir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelGir.ItemClick
        Dim rel As New relGiroConsumo
        rel.picLogo.Image = LogoTipo
        With rel.tbGiro.Rows
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                .Add()
                .Item(I).Item("Fornecedor") = Me.grd1.GetRowCellDisplayText(I, Me.colFornecedor)
                .Item(I).Item("CodProd") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("Entrada") = Me.grd1.GetRowCellDisplayText(I, Me.colEntrada)
                .Item(I).Item("Saida") = Me.grd1.GetRowCellDisplayText(I, Me.colSaida)
                .Item(I).Item("Saldo") = Me.grd1.GetRowCellDisplayText(I, Me.colSaldo)
                .Item(I).Item("Giro") = Me.grd1.GetRowCellDisplayText(I, Me.colGiro)
                .Item(I).Item("Setor") = Me.grd1.GetRowCellDisplayText(I, Me.colSetor)

            Next
        End With

        rel.XrLabel2.Text = Me.TextEdit1.Text
        rel.lblTotal.Text = Me.txtTotPro.Text
        rel.lblTotCom.Text = Me.txtTotGer.Text

        rel.colSetor.Visible = Me.colSetor.Visible
        rel.ShowPreview()
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

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim dblEstoque, dblSaida, dblTotal As Double

        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            dblEstoque = dblEstoque + CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colEntrada))
            dblSaida = dblSaida + CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colSaida))
        Next

        Me.TextEdit1.Text = dblEstoque.ToString("0.000")
        Me.txtTotPro.Text = dblSaida.ToString("0.000")

        dblTotal = dblSaida / dblEstoque
        Me.txtTotGer.Text = dblTotal.ToString("0.000")
    End Sub
End Class