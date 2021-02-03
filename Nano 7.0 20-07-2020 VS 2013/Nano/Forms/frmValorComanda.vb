Imports Nano.clsFuncoes
Public Class frmValorComanda

    Private Sub frmValorComanda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag = "FRETE" Then
            Me.Text = "Frete Bairro"
            Me.LabelControl1.Text = "Valor R$"
            Me.LabelControl2.Text = "Digite o valor R$ e pressione 'ENTER'."
        Else
            Me.Text = "Valor Produto"
            Me.LabelControl1.Text = "Valor Unit. R$"
            Me.LabelControl2.Text = "Digite o valor Unit. R$ e pressione 'ENTER'."
        End If
        Me.txtValor.ResetText()
    End Sub

    Private Sub txtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyDown

        If Me.txtValor.Text.Trim = "" Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Preco(Me.txtValor)
            ValorUnitComanda = Me.txtValor.Text
            Me.Close()
        End If
    End Sub
End Class