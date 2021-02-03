Imports Nano.clsFuncoes
Public Class frmConTotNF
    Public strData As String
    Dim strFiltro As String = ""

    Private Sub frmConTotNF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Help.ShowHelp(Me, "C:\NANO\HelpNanoCommerce.chm", HelpNavigator.TopicId, "45")
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmConTotNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        If TesteConexao() = False Then Exit Sub

        'TODO: This line of code loads data into the 'DsNanoCommerce.Config' table. You can move, or remove it, as needed.
        'Me.ConfigTableAdapter.Fill(Me.DsNanoCommerce.Config)
        'TODO: This line of code loads data into the 'DsNanoCommerce.Total' table. You can move, or remove it, as needed.
        'Me.TotalTableAdapter.Fill(Me.DsNanoCommerce.Total)

        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = " where TotalEntradaNF.CodConfig =" & CodConfig
        End If

        CarregarDados("SELECT TotalEntradaNF.Data, NumeroNF, Serie, TotalEntradaNF.Tipo, ValorFrete, ValorSeguro, " & _
        "OutrasDespesas, Convert(Numeric(15,2),Total) as Total, Fornecedor.Nome, Fornecedor.Codigo as CodFor, " & _
        "TotalEntradaNF.CodConfig, TotalEntradaNF.CodPedido, EstoqueOK, TotalEntradaNF.Chave FROM TotalEntradaNF " & _
        "inner join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo " & strFiltro, Me.Grid1)

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim I As Integer
        Dim dblLinha, dblResul As Double

        For I = 0 To grd1.RowCount - 1

            dblLinha = grd1.GetRowCellDisplayText(I, Me.colTotal)
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

        If Master = False Then
            strFiltro = " and TotalEntradaNF.CodConfig =" & CodConfig
        End If

        strData = String.Format("TotalEntradaNF.Data >= '{0:dd/MM/yyyy}' AND TotalEntradaNF.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)

        CarregarDados("SELECT TotalEntradaNF.Data, NumeroNF, Serie, TotalEntradaNF.Tipo, ValorFrete, ValorSeguro, " & _
        "OutrasDespesas, Convert(Numeric(15,2),Total) as Total, Fornecedor.Nome, Fornecedor.Codigo as CodFor, " & _
        "TotalEntradaNF.CodConfig, TotalEntradaNF.CodPedido, EstoqueOK, TotalEntradaNF.Chave FROM TotalEntradaNF " & _
        "inner join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo where " & strData & strFiltro, Me.Grid1)

    End Sub

    Private Sub btnWord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnWord.ItemClick
        Me.sfdSalvar.FileName = ""
        Me.sfdSalvar.ShowDialog()
        If Me.sfdSalvar.FileName <> "" Then
            grd1.ExportToRtf(Me.sfdSalvar.FileName & ".rtf")
            MsgBox("Exportação concluída com sucesso!", MsgBoxStyle.Information)
            If MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(Me.sfdSalvar.FileName & ".rtf")
            End If
        End If
    End Sub

    Private Sub btnExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Me.sfdSalvar.FileName = ""
        Me.sfdSalvar.ShowDialog()
        If Me.sfdSalvar.FileName <> "" Then
            Grid1.ExportToXls(Me.sfdSalvar.FileName & ".xls")
            MsgBox("Exportação concluída com sucesso!", MsgBoxStyle.Information)
            If MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(Me.sfdSalvar.FileName & ".xls")
            End If
        End If
    End Sub

    Private Sub btnPdf_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPdf.ItemClick
        Me.sfdSalvar.FileName = ""
        Me.sfdSalvar.ShowDialog()
        If Me.sfdSalvar.FileName <> "" Then
            Grid1.ExportToPdf(Me.sfdSalvar.FileName & ".pdf")
            MsgBox("Exportação concluída com sucesso!", MsgBoxStyle.Information)
            If MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(Me.sfdSalvar.FileName & ".pdf")
            End If
        End If
    End Sub

    Private Sub pdfHtml_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles pdfHtml.ItemClick
        Me.sfdSalvar.FileName = ""
        Me.sfdSalvar.ShowDialog()
        If Me.sfdSalvar.FileName <> "" Then
            Grid1.ExportToHtml(Me.sfdSalvar.FileName & ".html")
            MsgBox("Exportação concluída com sucesso!", MsgBoxStyle.Information)
            If MsgBox("Deseja abrir o arquivo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(Me.sfdSalvar.FileName & ".html")
            End If
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRelNF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelNF.ItemClick
        Dim rel As New relTotalEntradaNF
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.tbTotEntNf.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("NumeroNF") = grd1.GetRowCellDisplayText(I, Me.colNumeroNF)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("Fornecedor") = grd1.GetRowCellDisplayText(I, Me.colNome)
                .Item(I).Item("Serie") = grd1.GetRowCellDisplayText(I, Me.colSerie)
                .Item(I).Item("Tipo") = grd1.GetRowCellDisplayText(I, Me.colTipo)
                .Item(I).Item("ValorFrete") = grd1.GetRowCellDisplayText(I, Me.colValorFrete)
                .Item(I).Item("ValorSeguro") = grd1.GetRowCellDisplayText(I, Me.colValorSeguro)
                .Item(I).Item("OutDespesas") = grd1.GetRowCellDisplayText(I, Me.colOutrasDespesas)
                .Item(I).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("EstoqueOK") = grd1.GetRowCellValue(I, Me.colEstoqueOK)

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