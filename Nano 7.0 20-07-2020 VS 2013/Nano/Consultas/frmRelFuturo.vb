Imports Nano.clsFuncoes
Public Class frmRelFuturo
    Dim strFiltro As String = ""
    Dim dtDataInicial As Date
    Dim dtDataFinal As Date
    Private Sub frmRelFuturo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "38")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub
    Private Sub frmRelFuturo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        Me.colCodConfig.Visible = Master

        If Master = False Then
            strFiltro = " where CodConfig = " & CodConfig
        End If

        CarregarDados("Select Pagamento, CodConfig, Convert(Numeric(15,2),sum(Total)) as Total, Convert(Numeric(15,2),sum(TotalDesconto)) as TotalDesconto, Bandeira from Futuro" & strFiltro & " group by Pagamento,CodConfig, Bandeira order by Pagamento", Me.FuturoGridControl)


        Dim dt As DataTable = CarregarDataTable("SELECT min(Data) as DataInicio, Max(Data) as DataFim from Futuro" & strFiltro)
        If dt.Rows.Count > 0 Then
            dtDataInicial = dt.Rows.Item(0).Item("DataInicio").ToString
            dtDataFinal = dt.Rows.Item(0).Item("DataFim").ToString
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Me.txtTotal.ResetText()
        Me.txtTotalDesc.ResetText()

        Dim I As Integer
        Dim dblResTot, dblResTotDesc As Double
        With grd1

            For I = 0 To .RowCount - 1
                Dim dblTot, dblTotDesc As Double

                If .GetRowCellDisplayText(I, Me.colTotal) <> "" Then
                    dblTot = .GetRowCellDisplayText(I, Me.colTotal)
                    dblResTot += dblTot
                End If


                If .GetRowCellDisplayText(I, Me.colTotalDesconto) <> "" Then
                    dblTotDesc = .GetRowCellDisplayText(I, Me.colTotalDesconto)
                    dblResTotDesc += dblTotDesc
                End If


            Next
            Me.txtTotal.Text = dblResTot.ToString("###,###,##0.00")
            Me.txtTotalDesc.Text = dblResTotDesc.ToString("###,###,##0.00")

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

        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
        End If
        dtDataInicial = Me.dtInicial.EditValue
        dtDataFinal = Me.dtFinal.EditValue
        Dim strData As String
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("SELECT  Pagamento, CodConfig, Convert(Numeric(15,2),sum(Total)) as Total, Convert(Numeric(15,2),sum(TotalDesconto)) as TotalDesconto, Bandeira from Futuro  where " & strData & strFiltro & " group by Pagamento, CodConfig, Bandeira", Me.FuturoGridControl)
    End Sub

    Private Sub btnRelCar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCar.ItemClick
        Dim rel As New relFuturo
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo
        With rel.DsNano.Futuro.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                .Item(I).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("TotalDesconto") = grd1.GetRowCellDisplayText(I, Me.colTotalDesconto)
                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)

            Next
            rel.colCodConfig.Visible = Me.colCodConfig.Visible
            rel.lblPeriodo.Text = "De " & Format(dtDataInicial, "dd/MM/yyyy") & " a " & Format(dtDataFinal, "dd/MM/yyyy")
            rel.lblTotal.Text = Me.txtTotal.Text
            rel.lblTotalDesc.Text = Me.txtTotalDesc.Text.Trim


            rel.ShowPreview()

        End With
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.FuturoGridControl.ShowPrintPreview()
    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub
End Class