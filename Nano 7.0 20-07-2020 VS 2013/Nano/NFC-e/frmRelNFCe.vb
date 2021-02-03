Imports Nano.clsFuncoes

Public Class frmRelNFCe

    Dim strFiltro As String = ""

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
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
            strFiltro = " and NFCe.CodConfig =" & CodConfig & " and CodEmitente = " & CodEmitente
        End If

        Dim strData As String = String.Format("where NFCe.Data >= '{0:dd/MM/yyyy}' AND NFCe.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue) & strFiltro

        ' CarregarDados("SET DATEFORMAT dmy Select CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, Data, NumeroCupom, NumeroCupomCancelado, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig from SATFiscal " & strData & " order by CodOrdem desc", Me.GridControl1)
        CarregarDados("SET DATEFORMAT dmy Select NFCe.CodOrdem, Chave, NumNF as NumeroCupom, ChaveCancelamento, " & _
          "NFCe.Data, NFCe.ValorTotal, CFPDest, NFCe.CodConfig, " & _
          "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
          "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado from NFCe left join Total " & _
          "on NFCe.codordem = total.codordem and NFCe.codconfig = total.codconfig " & strData & " order by NFCe.CodOrdem desc", Me.GridControl1)

        Calcular()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()

    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub Calcular()

        Me.txtTotGer.ResetText()
        Dim I As Integer
        With grd1
            Dim dblTot, dblResTot As Double
            For I = 0 To .RowCount - 1
                dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                dblResTot += dblTot
            Next

            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub

    Private Sub btnConPed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        ImprimirVendaNormal(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem), Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig))

    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub frmRelSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If Master = False Then
            strFiltro = " where NFCe.CodConfig =" & CodConfig & " and CodEmitente = " & CodEmitente
        End If


        Me.colCodConfig.Visible = Master


        CarregarDados("SET DATEFORMAT dmy Select NFCe.CodOrdem, Chave, NumNF as NumeroCupom, ChaveCancelamento, " & _
        "NFCe.Data, NFCe.ValorTotal, CFPDest, NFCe.CodConfig, " & _
        "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
        "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado from NFCe left join Total " & _
        "on NFCe.codordem = total.codordem and NFCe.codconfig = total.codconfig " & strFiltro & " order by NFCe.CodOrdem desc", Me.GridControl1)


    End Sub

    Private Sub brnCancelarNFCe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles brnCancelarNFCe.ItemClick

        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle

        If Index < 0 Then Exit Sub

        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodOrdem)
        Dim strChave As String = Me.grd1.GetRowCellDisplayText(Index, Me.colChave)
        Dim strNumNF As String = Me.grd1.GetRowCellDisplayText(Index, Me.colNumeroCupom)

        If strCodOrdem = "" Then
            MsgBox("Selecione uma nota!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM NFCe where ChaveCancelamento <>'' and CodOrdem = " & strCodOrdem & " and CodEmitente = " & CodEmitente)
        If dt.Rows.Count > 0 Then
            MsgBox("NFC-e ja cancelada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        frmCancelarNFe.strChave = strChave
        frmCancelarNFe.strCodOrdem = strCodOrdem
        frmCancelarNFe.strNumNF = strNumNF
        frmCancelarNFe.ShowDialog()
    End Sub
End Class