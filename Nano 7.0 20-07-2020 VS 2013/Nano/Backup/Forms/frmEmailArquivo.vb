Imports Nano.clsFuncoes
Public Class frmEmailArquivo

    Private Sub frmEmailArquivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = CarregarDataTable("SELECT EmailArquivo From Config where codigo = " & CodConfig)
        If dt.Rows.Count > 0 Then
            Me.txtEmail.Text = dt.Rows.Item(0).Item("EmailArquivo").ToString
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.txtEmail) = False Then Exit Sub
        Try
            Atualizar("UPDATE Config set EmailArquivo = '" & Me.txtEmail.Text & "' where Codigo = " & CodConfig)
            MsgBox("Email salvo com sucesso!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnServidorSaida_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnServidorSaida.ItemClick
        frmServidorSaida.Show()
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        Me.txtEmail.ResetText()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub


End Class