Imports Nano.clsFuncoes

Public Class frmRelTotCompra
    Dim strFiltro As String = ""

    Private Sub frmRelPedTot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)



        If Master = False Then
            strFiltro = " where TotalPedCompra.CodConfig =" & CodConfig
        End If


        Me.colCodConfig.Visible = Master


        CarregarDados("SET DATEFORMAT dmy Select TotalPedCompra.CodOrdens, Total.CodOrdem as CodVenda, Total.NumDav as Sat, Total.Data as DataVenda, TotalPedCompra.Data, TotalPedCompra.Total, Fornecedor.Nome as Fornecedor, TotalPedCompra.CodConfig, TotalPedCompra.Status, TotalPedCompra.CodFunc, TotalPedCompra.Descricao, TotalPedCompra.Desconto, TotalPedCompra.Acrescimo, TotalPedCompra.DataRetirada, TotalPedCompra.DataEntrega, TotalPedCompra.NumeroNF as NumNF from (TotalPedCompra left Join Fornecedor On TotalPedCompra.CodFor = Fornecedor.Codigo) left join Total on TotalPedCompra.CodOrdens = Total.CodPedido " & strFiltro & " order by TotalPedCompra.CodOrdens desc", Me.GridControl1)


    End Sub

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
            strFiltro = " and TotalPedCompra.CodConfig =" & CodConfig
        End If

        Dim strData As String = String.Format("where TotalPedCompra.Data >= '{0:dd/MM/yyyy}' AND TotalPedCompra.Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue) & strFiltro

        CarregarDados("SET DATEFORMAT dmy Select TotalPedCompra.CodOrdens, Total.CodOrdem as CodVenda, Total.NumDav as Sat, Total.Data as DataVenda, TotalPedCompra.Data, TotalPedCompra.Total, Fornecedor.Nome as Fornecedor, TotalPedCompra.CodConfig, TotalPedCompra.Status, TotalPedCompra.CodFunc, TotalPedCompra.Descricao, TotalPedCompra.Desconto, TotalPedCompra.Acrescimo, TotalPedCompra.DataRetirada, TotalPedCompra.DataEntrega, TotalPedCompra.NumeroNF as NumNF from (TotalPedCompra left Join Fornecedor On TotalPedCompra.CodFor = Fornecedor.Codigo) left join Total on TotalPedCompra.CodOrdens = Total.CodPedido " & strData & " order by TotalPedCompra.CodOrdens desc", Me.GridControl1)

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
                dblTot = .GetRowCellDisplayText(I, Me.colTotal)
                dblResTot += dblTot
            Next

            Me.txtTotGer.Text = dblResTot.ToString("###,###,##0.00")
        End With
    End Sub

    Private Sub btnConPed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPed.ItemClick
        If TipoNano = 3 Then
            Dim frm As New frmPedidoAnimal
            frm.Tag = "CONSULTA"
            frm.txtCodPed.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdens)
            frm.Show()
        Else
            Dim frm As New frmPedido
            frm.Tag = "CONSULTA"
            frm.txtCodPed.Text = grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodOrdens)
            frm.Show()
        End If
    End Sub

    Private Sub btnVisu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisu.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class