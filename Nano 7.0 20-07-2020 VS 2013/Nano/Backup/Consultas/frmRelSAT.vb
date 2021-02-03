Imports Nano.clsFuncoes

Public Class frmRelSAT

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
            strFiltro = " and satfiscal.CodConfig =" & CodConfig
        End If

        Dim strData As String = String.Format("where satfiscal.Data >= '{0:dd/MM/yyyy}' AND satfiscal.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dataFim.AddDays(1)) & strFiltro

        ' CarregarDados("SET DATEFORMAT dmy Select CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, Data, NumeroCupom, NumeroCupomCancelado, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig from SATFiscal " & strData & " order by CodOrdem desc", Me.GridControl1)

        If CNPJEmpresa = "21182292000109" Then
            CarregarDados("SET DATEFORMAT dmy Select SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, SATFiscal.CodConfig, " & _
            "ChaveCancelamento, SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, CFPDest, AssinaturaQrCode, " & _
            "case when sum(convert(Numeric(15,2),Pedido.Qtd * convert(Numeric(15,2),Pedido.ValorUnitario))) is null then satfiscal.valortotal else sum(convert(Numeric(15,2),Pedido.Qtd * convert(Numeric(15,2),Pedido.ValorUnitario))) end as ValorTotal, " & _
            "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
            "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado, " & _
            "case when Total.ValDesc is null then 0.000 Else Total.ValDesc End as ValDesc " & _
            "from (SATFiscal left join Total on Satfiscal.codordem = total.codordem and satfiscal.codconfig = total.codconfig) left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig " & strData & " group by SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, " & _
            "SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, CFPDest, AssinaturaQrCode, SATFiscal.CodConfig, Total.CodOrdem, satfiscal.valortotal, Total.ValDesc", Me.GridControl1)

        Else
            CarregarDados("SET DATEFORMAT dmy Select SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, " & _
            "SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, SATFiscal.ValorTotal, CFPDest, AssinaturaQrCode, SATFiscal.CodConfig, " & _
            "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
            "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado, " & _
            "case when Total.ValDesc is null then 0.000 Else Total.ValDesc End as ValDesc from SATFiscal left join Total " & _
            "on Satfiscal.codordem = total.codordem and satfiscal.codconfig = total.codconfig " & strData & " order by satfiscal.CodOrdem desc", Me.GridControl1)

        End If

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
                If .GetRowCellValue(I, Me.colCancelado) = False Then
                    If .GetRowCellDisplayText(I, Me.colValorTotal) <> "" Then
                        dblTot = .GetRowCellDisplayText(I, Me.colValorTotal)
                        dblResTot += dblTot
                    End If
                End If
           

            Next

            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub

    Private Sub btnConPed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPed.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        ImprimirVendaNormal(Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodOrdem), Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodConfig))

    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub frmRelSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        If Master = False Then
            strFiltro = " where SATFiscal.CodConfig =" & CodConfig
        End If


        Me.colCodConfig.Visible = Master

        If CNPJEmpresa = "21182292000109" Then
            CarregarDados("SET DATEFORMAT dmy Select SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, SATFiscal.CodConfig, " & _
            "ChaveCancelamento, SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, CFPDest, AssinaturaQrCode, " & _
            "case when sum(convert(Numeric(15,2),Pedido.Qtd * convert(Numeric(15,2),Pedido.ValorUnitario))) is null then satfiscal.valortotal else sum(convert(Numeric(15,2),Pedido.Qtd * convert(Numeric(15,2),Pedido.ValorUnitario))) end as ValorTotal, " & _
            "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
            "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado, " & _
            "case when Total.ValDesc is null then 0.000 Else Total.ValDesc End as ValDesc " & _
            "from (SATFiscal left join Total on Satfiscal.codordem = total.codordem and satfiscal.codconfig = total.codconfig) left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Total.CodConfig = Pedido.CodConfig " & strFiltro & "  group by SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, " & _
            "SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, CFPDest, AssinaturaQrCode, SATFiscal.CodConfig, Total.CodOrdem, satfiscal.valortotal, Total.ValDesc", Me.GridControl1)

        Else
            CarregarDados("SET DATEFORMAT dmy Select SATFiscal.CodOrdem, Chave, NumeroCupom, NumeroCaixa, ChaveCancelamento, " & _
            "SATFiscal.Data, NumeroCupom, NumeroCupomCancelado, SATFiscal.ValorTotal, CFPDest, AssinaturaQrCode, SATFiscal.CodConfig, " & _
            "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
            "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado, " & _
            "case when Total.ValDesc is null then 0.000 Else Total.ValDesc End as ValDesc from SATFiscal left join Total " & _
            "on Satfiscal.codordem = total.codordem and satfiscal.codconfig = total.codconfig " & strFiltro & " order by satfiscal.CodOrdem desc", Me.GridControl1)

        End If

    End Sub
End Class