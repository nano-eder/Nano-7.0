Imports Nano.clsFuncoes
Public Class frmEditarCPF
    Dim strCpfCnpj As String
    Public strCodOrdem As String
    Private Sub frmEditarCPF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdgDoc.SelectedIndex = 0
    End Sub
    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged

        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strCpfCnpj = "Cpf"

            Case 1
                strCpfCnpj = "Cnpj"

        End Select
        Me.txtCPF.ResetText()
        Me.txtCPF.Focus()
    End Sub
    Private Sub Salvar()
        If Me.txtCPF.Text.Trim <> "" Then
            If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
                Me.txtCPF.ResetText()
                Me.txtCPF.Focus()
                Exit Sub
            End If
        End If

        If Me.txtCPF.Text.Trim = "000.000.000-00" Or Me.txtCPF.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPF.ResetText()
            Exit Sub
        End If
        'If Validar(Me.txtCPF) = False Then Exit Sub
        Dim bolNFP As Boolean = True
        If Me.txtCPF.Text = "" Then
            bolNFP = False
        End If
        Atualizar("UPDATE Total set CPFCliente = '" & Me.txtCPF.Text & "', NFP = '" & bolNFP & "' where CodOrdem = " & strCodOrdem & " and CodConfig = " & CodConfig)

        Me.Close()
    End Sub

    Private Sub txtCPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCPF.KeyDown
        If e.KeyCode = Keys.Enter Then
            Salvar()
        End If
    End Sub
   
    Private Sub txtCPF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress

        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
        FormatarDocumento(Me.txtCPF, strCpfCnpj)

    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Salvar()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class