Imports Nano.clsFuncoes
Public Class frmRelTabelaPreco
    Dim strGrupo As String = ""
    Private Sub frmRelTabelaPreco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Nome from Grupo where Tipo = 'T'")

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            Dim strCodigo As String = dt.Rows.Item(I).Item("Codigo").ToString
            Dim strNome As String = dt.Rows.Item(I).Item("Nome").ToString

            strGrupo &= ", (SELECT T.Valor FROM TabelaPreco T where T.CodProd = P.Codigo and T.CodTabela = " & strCodigo & ") as '" & strNome & "'"


        Next

        'dt = CarregarDataTable("SELECT P.Nome, P.Valor " & strGrupo & " FROM Produto P")

        'CarregarDados("SELECT P.Nome, P.Valor " & strGrupo & " FROM Produto P", Me.GridControl1)


        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CarregarDados("SELECT P.CodigoInterno as 'Código', P.CodigoBarra as 'Código Barra', P.Nome, P.Valor as 'Valor Padrão R$' " & strGrupo & " FROM Produto P where P.Inativo = 'False'", Me.GridControl1)
        Dim I As Integer

        For I = 0 To Me.GridView1.Columns.Count - 1
            If I < 2 Then
                Me.GridView1.Columns.Item(I).Width = 50
                Me.GridView1.Columns.Item(I).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            ElseIf I = 2 Then
                Me.GridView1.Columns.Item(I).Width = 200

            Else
                Me.GridView1.Columns.Item(I).Width = 50
            End If

            Me.GridView1.Columns.Item(I).OptionsColumn.ReadOnly = True
        Next
        Timer1.Stop()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class