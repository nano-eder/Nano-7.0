Public Class frmComandaMensagem

    Private Sub frmComandaMensagem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.lblMensagem2.Visible = False
    End Sub

    Private Sub frmComandaMensagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LocationMensagem = 0 Then
            LocationMensagem = Me.Location.Y
        End If
        Me.btnNao.Appearance.BackColor = CorBotoes
        Me.btnSim.Appearance.BackColor = CorBotoes
        Me.PictureEdit3.BackColor = CorFundo
        If TecladoVirtual = True Then
            If Me.Tag = "Excluir" Then
                Me.Location = New System.Drawing.Point(Me.Location.X, 50)
            Else
                Me.Location = New System.Drawing.Point(Me.Location.X, LocationMensagem)
            End If
        End If

    End Sub

    Private Sub btnSim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSim.Click
        RetornoMensagemComanda = True
        Me.Close()
    End Sub

    Private Sub btnNao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNao.Click
        RetornoMensagemComanda = False
        Me.Close()
    End Sub

End Class