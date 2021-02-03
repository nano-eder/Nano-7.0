Imports Nano.clsFuncoes

Public Class frmSenha

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If validar(Me.txtAnt) = False Then Exit Sub
        If Validar(Me.txtNova) = False Then Exit Sub
        If Validar(Me.txtConf) = False Then Exit Sub

        If txtAnt.Text <> Senha Then MsgBox("Senha antiga não confere!", MsgBoxStyle.Information) : limpar() : Exit Sub
        If txtNova.Text <> txtConf.Text Then
            MsgBox("O campo Nova Senha está diferente do campo Confirma Senha!", MsgBoxStyle.Exclamation)
            txtNova.Clear()
            txtConf.Clear()
            txtNova.Focus()
            Exit Sub
        Else

            If txtNova.Text.Trim = Senha Then
                MsgBox("Senha nova é igual a senha Atual!", MsgBoxStyle.Exclamation)
                txtNova.Clear()
                txtConf.Clear()
                txtNova.Focus()
                Exit Sub
            End If
            Dim sql As String

            sql = "update Usuario set Senha = '" & txtNova.Text.Trim & "' where Login ='" & Login & "'"

            If Atualizar(sql) = False Then Exit Sub
            MsgBox("Alterações salvas com sucesso!", MsgBoxStyle.Information)
            Senha = txtNova.Text.Trim
            Me.Close()

        End If
    End Sub

    Private Sub limpar()
        Me.txtAnt.Clear()
        Me.txtConf.Clear()
        Me.txtNova.Clear()
        txtAnt.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "84")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmSenha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        limpar()
    End Sub
End Class