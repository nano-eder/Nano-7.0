Imports Nano.clsFuncoes
Public Class frmConCTPagarNF
    Public strCodFor As String

    Private Sub frmConCTPagarNF_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If ValorTotalCT <= 0 Then
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellValue(I, Me.colOk) = True Then
                    Me.grd1.SetRowCellValue(I, Me.colOk, False)
                End If
            Next
        End If
    End Sub
    Private Sub frmConCTPagarNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub
        CarregarDados("SELECT NumeroNF as NF, Fornecedor.Nome as Fornecedor, Total as Valor, CTPagarOk as Ok " & _
        "FROM TotalEntradaNF left join Fornecedor on TotalEntradaNF.CodFor = Fornecedor.Codigo " & _
        "where CTPagarOk = 'False' and TotalEntradaNF.CodConfig = " & CodConfig & " and CodFor = " & strCodFor, Me.GridControl1)
        Calcular()
    End Sub

    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick

        ValorTotalCT = Me.txtValNota.Text
        Me.Close()
    End Sub
    Private Sub Calcular()
        Dim I As Integer
        Dim dblValor As Double
        For I = 0 To Me.grd1.RowCount - 1
            If Me.grd1.GetRowCellValue(I, Me.colOk) = True Then
                dblValor += Me.grd1.GetRowCellDisplayText(I, Me.colValor)
            End If
        Next
        Me.txtValNota.Text = dblValor.ToString("###,###,##0.00")
    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        ValorTotalCT = 0
        Me.Close()
    End Sub

    Private Sub chkOk_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles chkOk.EditValueChanging
        If Me.grd1.GetRowCellValue(Me.grd1.FocusedRowHandle, Me.colOk) = False Then
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colOk, True)
        Else
            Me.grd1.SetRowCellValue(Me.grd1.FocusedRowHandle, Me.colOk, False)
        End If
        Calcular()
    End Sub
End Class