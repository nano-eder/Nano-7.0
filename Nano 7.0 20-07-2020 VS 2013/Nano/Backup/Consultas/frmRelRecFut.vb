Imports Nano.clsFuncoes
Public Class frmRelRecFut
    Dim strFiltro As String

    Private Sub frmRelRecFut_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "39")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmRelRecFut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDadosLue2("Select Codigo, Descricao from Config", Me.lueLoja)

        Me.colCodConfig.Visible = Master
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)
        If Master = False Then
            strFiltro = "CodConfig =" & CodConfig
            Me.FuturoBindingSource.Filter = strFiltro
        End If

        CarregarDados("SELECT * FROM Futuro", Me.FuturoGridControl)
        'Me.FuturoTableAdapter.Fill(Me.DsNanoCommerce.Futuro)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnFilter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilter.ItemClick
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
            strFiltro = " and CodConfig =" & CodConfig
        End If

        Dim strData As String
        strData = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        CarregarDados("SELECT * FROM Futuro where " & strData, Me.FuturoGridControl)
        'Me.FuturoBindingSource.Filter = strData & strFiltro
        'Me.FuturoTableAdapter.Fill(Me.DsNanoCommerce.Futuro)
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

    Private Sub btnRelCar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCar.ItemClick
        Dim rel As New relRecFut
        Dim I As Integer
        rel.lblTitulo.Text = Me.Text
        rel.picLogo.Image = LogoTipo

        Dim dtDataInicial As Date
        Dim dtDataFinal As Date
        Dim dtDT As Date
        With rel.DsNano.Futuro.Rows
            For I = 0 To grd1.RowCount - 1
                .Add()
                .Item(I).Item("Pagamento") = grd1.GetRowCellDisplayText(I, Me.colPagamento)
                .Item(I).Item("Total") = grd1.GetRowCellDisplayText(I, Me.colTotal)
                .Item(I).Item("TotalDesconto") = grd1.GetRowCellDisplayText(I, Me.colTotalDesconto)
                .Item(I).Item("Data") = grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("CodOrdem") = grd1.GetRowCellDisplayText(I, Me.colPedido)

                .Item(I).Item("CodConfig") = grd1.GetRowCellDisplayText(I, Me.colCodConfig)

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