Imports Nano.clsFuncoes
Public Class frmSenhaExcluir

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        BotaoOK()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmSenhaExcluir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolSenhaOK = False
    End Sub

    Private Sub BotaoOK()
        'If Me.Tag = Nothing Then
        '    If Me.txtSenha.Text.Trim = Senha.Trim Then
        '        bolSenhaOK = True
        '        Me.Close()
        '    Else
        '        MsgBox("Senha Incorreta!", MsgBoxStyle.Information)
        '        Me.txtSenha.ResetText()
        '        Me.txtSenha.Focus()
        '    End If
        'End If

        If Me.Tag = "VENDEDOR" Then
            Dim dtFunc As DataTable = DataTableOnline("Select Codigo From Funcionario Where Codigo = '" & Me.txtSenha.Text.Trim & "'")

            If dtFunc.Rows.Count > 0 Then
                CodigoVendedor = dtFunc.Rows.Item(0).Item("Codigo").ToString
                Me.Close()
            Else
                CodigoVendedor = 0
                MsgBox("Senha de registro incorreta!", MsgBoxStyle.Exclamation)
            End If
        Else
            'Dim dt As DataTable = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel <> 'USUÁRIO'")
            Dim dt As DataTable = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel = 'MASTER'")

            If dt.Rows.Count = 0 Then
                dt = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel = 'ADMINISTRADOR' and CodConfig = " & CodConfig)
            End If

            If dt.Rows.Count > 0 Then
                bolSenhaOK = True
                Me.Close()
            Else
                MsgBox("Senha inválida!", MsgBoxStyle.Information)
                Me.txtSenha.ResetText()
                Me.txtSenha.Focus()
            End If
        End If
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            BotaoOK()
        End If

        If e.Control AndAlso (e.KeyCode = Keys.V) Then e.SuppressKeyPress = True
    End Sub

    Private Sub txtSenha_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSenha.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub
End Class