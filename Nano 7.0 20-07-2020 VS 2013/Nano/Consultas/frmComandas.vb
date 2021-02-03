Imports Nano.clsFuncoes
Public Class frmComandas


    Private Sub frmComandas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TesteConexao() = False Then Exit Sub
        'CarregarDados("SELECT DISTINCT CodComanda FROM Comanda where Status = 'Fechado' and CodConfig =" & CodConfig, Me.ComandaGridControl)
        'CarregarDados("SELECT DISTINCT CodComanda, convert(bit,'False') as Selecao FROM Comanda where Status <> 'Faturado' and APP = 'True' and CodConfig =" & CodConfig, Me.ComandaGridControl)


        Dim dt As DataTable = CarregarDataTable("SELECT DISTINCT CodComanda FROM Comanda where Status <> 'Faturado' and APP = 'True' and CodConfig =" & CodConfig)

        Dim I As Integer


        With Me.tbCom.Rows
            For I = 0 To dt.Rows.Count - 1
                .Add()
                .Item(I).Item("CodComanda") = dt.Rows.Item(I).Item("CodComanda").ToString
                .Item(I).Item("Selecao") = False
            Next
        End With
      

        'If ConsultaPedido <> "" Then
        '    Dim vetComanda As Array = Split(ConsultaPedido, ",")
        '    Dim A As Integer
        '    With Me.tbCom.Rows
        '        For A = 0 To vetComanda.Length - 1
        '            Dim strCodComanda As String = vetComanda(I).ToString.Trim

        '            For I = 0 To dt.Rows.Count - 1
        '                If strCodComanda = dt.Rows.Item(I).Item("CodComanda").ToString Then
        '                    .Item(I).Item("Selecao") = True
        '                    Exit Sub
        '                End If

        '            Next
        '        Next

        '    End With
        'End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer = -999997
        Me.grd1.FocusedRowHandle = index
        Me.grd1.FocusedColumn = Me.colCodComanda
        Me.grd1.ShowEditor()
        Timer1.Stop()
    End Sub

    Private Sub txtRetorno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetorno.DoubleClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Retorno()

    End Sub

    Private Sub txtRetorno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRetorno.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodComanda) <> "" Then
                Retorno()
            End If
        End If
    End Sub

    Private Sub txtRetorno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetorno.KeyPress

        If Me.grd1.FocusedColumn.Name <> Me.colCodComanda.Name Then Exit Sub

        If IsNumeric(e.KeyChar) = False Then
            If e.KeyChar = vbBack Then Exit Sub
            e.Handled = True
        End If

    End Sub

    Private Sub Retorno()
        ConsultaPedido = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodComanda)
        Me.Close()
    End Sub

    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub

        Dim index As Integer = -999997
        grd1.FocusedRowHandle = index
        grd1.FocusedColumn = Me.colCodComanda
        grd1.ShowEditor()
        Dim I As Integer
        Dim strCli As String = ""
        ConsultaPedido = ""

        For I = 0 To Me.grd1.RowCount - 1

            If Me.grd1.GetRowCellValue(I, Me.colSelecao) = True Then
                If ConsultaPedido = "" Then
                    ConsultaPedido &= Me.grd1.GetRowCellDisplayText(I, Me.colCodComanda)
                Else
                    ConsultaPedido &= "," & Me.grd1.GetRowCellDisplayText(I, Me.colCodComanda)
                End If
            End If
        Next

        If ConsultaPedido = "" Then
            ConsultaPedido = Me.grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodComanda)
        End If


        Me.Close()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class

