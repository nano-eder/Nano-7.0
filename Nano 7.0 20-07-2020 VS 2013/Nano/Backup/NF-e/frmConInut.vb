Imports Nano.clsFuncoes
Public Class frmConInut

    Private Sub frmConInut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNanoCommerce.Inutilizacao' table. You can move, or remove it, as needed.
        Me.InutilizacaoTableAdapter.Fill(Me.DsNanoCommerce.Inutilizacao)
        If TesteConexao() = False Then Exit Sub
        CarregarDados("SELECT Codigo, NumInicial, NumFinal, Data, Serie, Motivo FROM Inutilizacao where CodConfig = " & CodConfig, Me.GridControl1)
    End Sub

    Private Sub btnFiltrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        If TesteConexao() = False Then Exit Sub
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)

        CarregarDados("SELECT Codigo, NumInicial, NumFinal, Data, Serie, Motivo FROM Inutilizacao where CodConfig = " & CodConfig & " and " & strData, Me.GridControl1)

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relInut


        rel.lblTitulo.Text = "Relatório de Inutilização de Numeração"

        rel.picLogo.Image = LogoTipo

        Dim A As Integer = 0
        Dim I As Integer
        With rel.tbInut.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colNumFinal) <> "" Then
                    .Add()
                    .Item(A).Item("Codigo") = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                    .Item(A).Item("CodEmitente") = Me.grd1.GetRowCellDisplayText(I, Me.colCodEmitente)
                    .Item(A).Item("Data") = Me.grd1.GetRowCellDisplayText(I, Me.colData)
                    .Item(A).Item("NumInicial") = Me.grd1.GetRowCellDisplayText(I, Me.colNumInicial)
                    .Item(A).Item("NumFinal") = Me.grd1.GetRowCellDisplayText(I, Me.colNumFinal)
                    .Item(A).Item("Serie") = Me.grd1.GetRowCellDisplayText(I, Me.colSerie)
                    .Item(A).Item("Motivo") = Me.grd1.GetRowCellDisplayText(I, Me.colMotivo)
                    A += 1
                End If
            Next
        End With

        rel.ShowPreview()
       
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub
End Class