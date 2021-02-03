Imports Nano.clsFuncoes
Public Class frmConNF
    Public strData As String

    Private Sub frmConNF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "44")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmConTotNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.colCodConfig.Visible = Master

        Dim strFiltro As String = ""


        If Master = False Then
            strFiltro = " and EntradaNF.CodConfig =" & CodConfig
        End If

        CarregarDados("SELECT TotalEntradaNF.Data, CodProdInterno, Produto, Qtd, Convert(Numeric(15,2), " & _
        "ValorUnitario) as ValorUnitario, EntradaNF.Desconto, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        "TotalEntradaNF.NumeroNF, TotalEntradaNF.CodPedido, Fornecedor.Nome, Fornecedor.Codigo as CodFor, " & _
        "EntradaNF.CodConfig, ValProd , CFOP, EntradaNf.NCM, Regime, CST, Origem, CalculoCred, ValCalculoCred " & _
        "as ValCred, ModBC, RedBC, AliquotaICMS, ValICMS, ModBCST, RedBCST, MVaSTEnt as MVAST, AliquotaICMSST, " & _
        "ValICMSST, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, ValPIS, CSTCOFINS, AliquotaCOFINS, " & _
        "ValCOFINS, CodigoANPEnt, UFCombEnt, ValorCusto, UMProd, QtdProd, TotalEntradaNF.Obs, TotalEntradaNF.Chave FROM EntradaNF, TotalEntradaNF, Fornecedor " & _
        "where EntradaNF.CodTotNF = TotalEntradaNF.Codigo and TotalEntradaNF.CodFor = Fornecedor.Codigo" & strFiltro, Me.Grid1)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim I As Integer
        Dim dblLinha, dblResul As Double

        For I = 0 To grd1.RowCount - 1

            dblLinha = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblResul += dblLinha
        Next

        Me.txtValNota.Text = dblResul.ToString("###,###,###,##0.00")
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

        Dim strFiltro As String = ""
        If Master = False Then
            strFiltro = " and EntradaNF.CodConfig =" & CodConfig
        End If

        strData = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

        CarregarDados("SELECT TotalEntradaNF.Data, CodProdInterno, Produto, Qtd, Convert(Numeric(15,2), " & _
        "ValorUnitario) as ValorUnitario, EntradaNF.Desconto, Convert(Numeric(15,2), ValorTotal) as ValorTotal, " & _
        "TotalEntradaNF.NumeroNF, TotalEntradaNF.CodPedido,Fornecedor.Nome, Fornecedor.Codigo as CodFor, " & _
        "EntradaNF.CodConfig, ValProd , CFOP, NCM, Regime, CST, Origem, CalculoCred, ValCalculoCred as ValCred, " & _
        "ModBC, RedBC, AliquotaICMS, ValICMS, ModBCST, RedBCST, MVaSTEnt as MVAST, AliquotaICMSST, ValICMSST, " & _
        "CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, ValPIS, CSTCOFINS, AliquotaCOFINS, ValCOFINS, " & _
        "CodigoANPEnt, UFCombEnt, ValorCusto, UMProd, QtdProd, TotalEntradaNF.Obs, TotalEntradaNF.Chave FROM EntradaNF, TotalEntradaNF, Fornecedor where " & _
        "EntradaNF.CodTotNF = TotalEntradaNF.Codigo and TotalEntradaNF.CodFor = Fornecedor.Codigo and " & strData, Me.Grid1)
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelItens_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelItens.ItemClick
        Dim rel As New relEntradaNF
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.tbEntNF.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("NumeroNF") = grd1.GetRowCellDisplayText(I, Me.colNumeroNF)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Fornecedor") = grd1.GetRowCellDisplayText(I, Me.colFornecedor)
                .Item(I).Item("ValorUnitario") = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                .Item(I).Item("ValorTotal") = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                .Item(I).Item("Produto") = grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("CodProdInterno") = grd1.GetRowCellDisplayText(I, Me.colCodigoProduto)
                .Item(I).Item("Qtd") = grd1.GetRowCellDisplayText(I, Me.colQtd)
                .Item(I).Item("Desconto") = grd1.GetRowCellDisplayText(I, Me.colDesconto)
                .Item(I).Item("ValProd") = grd1.GetRowCellDisplayText(I, Me.colValProd)

            Next

            rel.lblValorTotal.Text = Me.txtValNota.Text.Trim

            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.Grid1.ShowPrintPreview()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class