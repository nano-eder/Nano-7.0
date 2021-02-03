Imports Nano.clsFuncoes
Public Class frmComandaExcluir

    Private Sub frmComandaExcluir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FecharTecladoArquivo(False)
    End Sub

    Private Sub frmComandaExcluir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtSenha.ResetText()

        Me.btnCancelar.Appearance.BackColor = CorBotoes
        Me.btnOk.Appearance.BackColor = CorBotoes
        Me.PictureEdit3.BackColor = CorFundo
        RetornoMensagemComanda = False

        If TecladoVirtual = True Then
            Me.Location = New System.Drawing.Point(Me.Location.X, 50)
            AbrirTecladoArquivo(True)
        End If

        Timer1.Start()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        BotaoOK()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BotaoOK()
        'Dim dt As DataTable = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel <> 'USUÁRIO'")
        Dim dt As DataTable = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel = 'MASTER'")

        If dt.Rows.Count = 0 Then
            dt = CarregarDataTable("Select Nome from Usuario where Senha ='" & Me.txtSenha.Text.Trim & "' and Nivel = 'ADMINISTRADOR' and CodConfig = " & CodConfig)
        End If

        If dt.Rows.Count > 0 Then
            RetornoMensagemComanda = True
            Me.Close()
        Else
            frmComandaMensagem.Tag = "Excluir"
            frmComandaMensagem.lblMensagem.Text = "Senha inválida!"
            frmComandaMensagem.btnSim.Visible = False
            frmComandaMensagem.btnNao.Text = "Ok"
            frmComandaMensagem.Size = New System.Drawing.Size(353, 210)
            frmComandaMensagem.btnNao.Location = New System.Drawing.Point(81, 107)
            frmComandaMensagem.ShowDialog()

            Me.txtSenha.ResetText()
            Me.txtSenha.Focus()
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
                'MessageBox.Show(Me, "Botão direito não permitido")
                frmComandaMensagem.Tag = "Excluir"
                frmComandaMensagem.lblMensagem.Text = "Botão direito não permitido"
                frmComandaMensagem.btnSim.Visible = False
                frmComandaMensagem.btnNao.Text = "Ok"
                frmComandaMensagem.Size = New System.Drawing.Size(649, 210)
                frmComandaMensagem.btnNao.Location = New System.Drawing.Point(210, 107)
                frmComandaMensagem.ShowDialog()
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtSenha.Focus()
        Me.Timer1.Stop()
    End Sub
End Class