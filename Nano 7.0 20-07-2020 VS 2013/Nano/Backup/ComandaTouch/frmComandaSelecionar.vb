Imports Nano.clsFuncoes
Public Class frmComandaSelecionar

    Private Sub frmComandaSelecionar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FecharTecladoArquivo(False)
    End Sub

    Private Sub frmComandaSelecionar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNumero.ResetText()

        Me.btnCancelar.Appearance.BackColor = CorBotoes
        Me.btnOk.Appearance.BackColor = CorBotoes
        Me.btnMenos.Appearance.BackColor = CorBotoes
        Me.btnMais.Appearance.BackColor = CorBotoes

        Me.PictureEdit3.BackColor = CorFundo
        RetornoNumeroComanda = 0
        Me.txtNumero.Text = ""
        If TecladoVirtual = True Then
            Me.Location = New System.Drawing.Point(Me.Location.X, 50)
            AbrirTecladoArquivo(True)
        End If

        If Me.Tag = "TRANSFERIR" Then
            Me.lblFrase.Text = "Informe para qual Comanda os produtos serão transferidos."
            Me.Text = "Transferência de Comanda"
        Else
            Me.lblFrase.Text = "Informe a qtde de pessoas na mesa."
            Me.Text = "Qtde de Pessoas na mesa"
        End If

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txtNumero.Focus()
        Me.Timer1.Stop()
    End Sub


    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click

        If Me.txtNumero.Text = "" Then Exit Sub
        Dim dblQtde As Double = Me.txtNumero.Text
        If dblQtde <= 1 Then Exit Sub

        dblQtde -= 1
        Me.txtNumero.Text = dblQtde

    End Sub

    Private Sub btnMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMais.Click
        If Me.txtNumero.Text = "" Then
            Me.txtNumero.Text = "1"
        End If
        Dim dblQtde As Double = Me.txtNumero.Text

        dblQtde += 1
        Me.txtNumero.Text = dblQtde

    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Me.txtNumero.Text = "" Then
            Me.txtNumero.Text = "0"
        End If
        RetornoNumeroComanda = Me.txtNumero.Text
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class