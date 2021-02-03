Imports Nano.clsFuncoes
Imports System.Net.Mail
Imports System.Net.Mime

Public Class frmServidorSaida

    Private Sub frmServidorSaida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNano.Email' table. You can move, or remove it, as needed.
        Me.EmailTableAdapter.Fill(Me.DsNanoCommerce.Email)


    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Me.Validate()
        Me.EmailBindingSource.EndEdit()
        Me.EmailTableAdapter.Update(Me.DsNanoCommerce.Email)
        MsgBox("Conta salva com sucesso!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnTestar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTestar.ItemClick
        If Validar(Me.ServidorTextEdit) = False Then Exit Sub
        If Validar(Me.EmailTextEdit) = False Then Exit Sub
        If Validar(Me.SenhaTextEdit) = False Then Exit Sub
        enviaMensagemEmail(Me.EmailTextEdit.Text, Me.SenhaTextEdit.Text, Me.EmailTextEdit.Text, "", "", "Teste de Conta", "Teste de conta efetuado com sucesso!", Me.ServidorTextEdit.Text, 0, False, "TESTE", Me.txtPorta.Text, Me.ServicoComboBoxEdit.Text.Trim, Nothing)
    End Sub

    Private Sub ServicoComboBoxEdit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicoComboBoxEdit.SelectedIndexChanged
        Select Case Me.ServicoComboBoxEdit.SelectedText
            Case "Gmail"
                Me.ServidorTextEdit.Text = "smtp.gmail.com"
                Me.txtPorta.Text = "587"

            Case "Hotmail"
                Me.ServidorTextEdit.Text = "smtp.live.com"
                Me.txtPorta.Text = "587"

            Case "Yahoo"
                Me.ServidorTextEdit.Text = "smtp.mail.yahoo.com"
                Me.txtPorta.Text = "587"

            Case "LocaWeb"
                Me.ServidorTextEdit.Text = "mail."
                Me.txtPorta.Text = "587"

            Case "Outros"
                Me.ServidorTextEdit.Text = ""
                Me.txtPorta.Text = "587"

        End Select
    End Sub
End Class