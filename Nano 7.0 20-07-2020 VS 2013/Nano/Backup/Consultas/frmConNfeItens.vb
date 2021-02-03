Imports Nano.clsFuncoes
Public Class frmConNfeItens

    Private Sub frmConNfeItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub

        CarregarDados("SELECT NumNF, DEmi as Data, CodInterno, Produto, QCom, VUnCom, ItensNfe.VProd, CSTICMS, ValICMS, ValICMSST, CSTIPI, ValIPI FROM ItensNfe left join TotalNfe on ItensNfe.CodOrdem = TotalNfe.CodOrdem and ItensNfe.CodConfig = TotalNfe.CodConfig where ItensNfe.CodConfig = " & CodConfig, Me.ItensNfeGridControl)
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

        Dim strData As String = String.Format("DEmi >= '{0:dd/MM/yyyy}' AND DEmi <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, Me.dtFinal.EditValue)

        CarregarDados("SELECT NumNF, DEmi as Data, CodInterno, Produto, QCom, VUnCom, ItensNfe.VProd, CSTICMS, ValICMS, ValICMSST, CSTIPI, ValIPI FROM ItensNfe left join TotalNfe on ItensNfe.CodOrdem = TotalNfe.CodOrdem and ItensNfe.CodConfig = TotalNfe.CodConfig where " & strData & " and ItensNfe.CodConfig = " & CodConfig, Me.ItensNfeGridControl)

    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relNfeItens

        rel.lblTitulo.Text = "Relatório de Itens de Notas Fiscais de Saída"
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim dblResulIcms, dblResulST, dblResulProd, dblResulIPI, dblResulQtde As Double

        With rel.tbItens.Rows
            For I = 0 To Me.grd1.RowCount - 1
                Dim dblIcms, dblST, dblProd, dblIPI, dblQtde As Double

                .Add()
                .Item(I).Item("NumNF") = Me.grd1.GetRowCellDisplayText(I, Me.colNumNF)
                .Item(I).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                .Item(I).Item("CodInterno") = Me.grd1.GetRowCellDisplayText(I, Me.colCodInterno)
                .Item(I).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                .Item(I).Item("QCom") = Me.grd1.GetRowCellDisplayText(I, Me.colQCom)
                .Item(I).Item("VUnCom") = Me.grd1.GetRowCellDisplayText(I, Me.colVUnCom)
                .Item(I).Item("VProd") = Me.grd1.GetRowCellDisplayText(I, Me.colVProd)
                .Item(I).Item("CSTICMS") = Me.grd1.GetRowCellDisplayText(I, Me.colCSTICMS)
                .Item(I).Item("ValICMS") = Me.grd1.GetRowCellDisplayText(I, Me.colValICMS)
                .Item(I).Item("ValICMSST") = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSST)
                .Item(I).Item("CSTIPI") = Me.grd1.GetRowCellDisplayText(I, Me.colCSTIPI)
                .Item(I).Item("ValIPI") = Me.grd1.GetRowCellDisplayText(I, Me.colValIPI)

                dblIcms = Me.grd1.GetRowCellDisplayText(I, Me.colValICMS)
                dblResulIcms += dblIcms


                dblST = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSST)
                dblResulST += dblST


                dblProd = Me.grd1.GetRowCellDisplayText(I, Me.colVProd)
                dblResulProd += dblProd


                dblIPI = Me.grd1.GetRowCellDisplayText(I, Me.colValIPI)
                dblResulIPI += dblIPI


                dblQtde = Me.grd1.GetRowCellDisplayText(I, Me.colQCom)
                dblResulQtde += dblQtde


            Next
        End With



        rel.lblICMS.Text = dblResulIcms.ToString("###,###,##0.00")
        rel.lblST.Text = dblResulST.ToString("###,###,##0.00")
        rel.lblProd.Text = dblResulProd.ToString("###,###,##0.00")
        rel.lblIPI.Text = dblResulIPI.ToString("###,###,##0.00")
        rel.lblQtde.Text = dblResulQtde.ToString("###,###,##0.00")

        rel.ShowPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class