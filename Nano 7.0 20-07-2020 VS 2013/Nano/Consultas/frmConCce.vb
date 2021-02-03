Imports Nano.clsFuncoes
Public Class frmConCce

    Private Sub frmConCce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        CarregarDados("SELECT Cce.Codigo, Cce.Chave, Cce.DEmi, Cce.HEmi, Cce.Correcao, Cce.NumSeqEvento, TotalNfe.NumNF as CodOrdem FROM Cce left join TotalNfe on Cce.CodOrdem = TotalNfe.CodOrdem and Cce.CodConfig = TotalNfe.Codconfig where Cce.CodConfig = " & CodConfig, Me.GridControl1)

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

        CarregarDados("SELECT Cce.Codigo, Cce.Chave, Cce.DEmi, Cce.HEmi, Cce.Correcao, Cce.NumSeqEvento, TotalNfe.NumNF as CodOrdem FROM Cce left join TotalNfe on Cce.CodOrdem = TotalNfe.CodOrdem and Cce.CodConfig = TotalNfe.CodConfig where " & strData & " and CodConfig = " & CodConfig, Me.GridControl1)

    End Sub

    Private Sub grd1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grd1.FocusedRowChanged
        Me.lblChave.Visible = False
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Me.lblChave.Visible = True
        Me.lblChave.Text = "Chave de Acesso:  " & Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colChave)
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relNfetotal

        rel.lblTitulo.Text = "Relatório de Carta de Correção"
        rel.picLogo.Image = LogoTipo

        Dim I As Integer
        Dim A As Integer = 0
        With rel.tbTotal.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem) <> "" Then
                    .Add()
                    .Item(A).Item("CodOrdem") = Me.grd1.GetRowCellDisplayText(I, Me.colCodOrdem)
                    .Item(A).Item("DEmi") = Me.grd1.GetRowCellDisplayText(I, Me.colDEmi)
                    .Item(A).Item("HEmi") = Me.grd1.GetRowCellDisplayText(I, Me.colHEmi)
                    .Item(A).Item("Correcao") = Me.grd1.GetRowCellDisplayText(I, Me.colCorrecao)
                    .Item(A).Item("NumSeqEvento") = Me.grd1.GetRowCellDisplayText(I, Me.colNumSeqEvento)
                    A += 1
                End If
            Next
        End With

        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class