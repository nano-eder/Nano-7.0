Imports Nano.clsFuncoes
Public Class frmSenhaReg

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Me.txtSenha.Text.Trim = "SPFC4*5*6*7*" Then
            Dim strPC As String = Encryp(My.Computer.Name & My.Computer.Info.OSFullName)
            Inserir("Insert into Registro (Computador) Values('" & strPC & "')")
            SenhaRegistro = True
            MsgBox("Programa registrado com sucesso!", MsgBoxStyle.Information)
            Me.Close()
        Else
            SenhaRegistro = False
            MsgBox("Senha não confere, entre em contato com Suporte Nano!", MsgBoxStyle.Information)
            Me.txtSenha.Clear()
            Me.txtSenha.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        SenhaRegistro = False
        Me.Close()
    End Sub
End Class