Imports Nano.clsFuncoes
Public Class frmDigitaCnpj
    Dim strTipDoc As String
    Public bolOK As Boolean = False

    Private Sub rdgDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDoc.SelectedIndexChanged
        Select Case Me.rdgDoc.SelectedIndex
            Case 0
                strTipDoc = "Cpf"
            Case 1
                strTipDoc = "Cnpj"
        End Select
        Me.txtCPF.ResetText()
        Me.txtCPF.Focus()
    End Sub

    Private Sub txtCPF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        FormatarDocumento(Me.txtCPF, strTipDoc)
    End Sub

    Private Sub txtCPF_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPF.Leave
        If Me.txtCPF.Text.Trim = "" Then Exit Sub
        If ValidaCPF(Me.txtCPF.Text.Trim) = False Then
            Me.txtCPF.ResetText()
            Me.txtCPF.Focus()
        End If

        If Me.txtCPF.Text.Trim = "000.000.000-00" Or Me.txtCPF.Text.Trim = "00.000.000/0000-00" Then
            Me.txtCPF.ResetText()
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Validar(Me.txtCPF) = False Then Exit Sub

        Dim dt As DataTable

        If Me.txtCPF.Text.Trim <> "" Then
            dt = DataTableOnline("Select Codigo, CPF, Ativado, Inativo from Cliente where CPF ='" & txtCPF.Text.Trim & "'")

            If dt.Rows.Count > 0 Then

                Dim bolInativo As Boolean = dt.Rows.Item(0).Item("Inativo")
                Dim bolAtivado As Boolean = dt.Rows.Item(0).Item("Ativado")

                If bolInativo = True Then
                    MsgBox("O seu sistema está bloqueado!" & vbCrLf & "Entre em contato com a Era Systems!", MsgBoxStyle.Critical)
                    bolOK = False
                    Me.Close()
                    Exit Sub
                End If

                If bolAtivado = False Then
                    ExecCmdOnline("Update Cliente set Ativado = 'True' where Codigo =" & dt.Rows.Item(0).Item("Codigo").ToString)
                    CNPJEmpresa = Me.txtCPF.Text.Trim.Replace(".", "").Replace("/", "").Replace("-", "")

                Else
                    MsgBox("CPF ou CNPJ já registrado para outro Cliente!", MsgBoxStyle.Information)
                    bolOK = False
                    Me.Close()
                    Exit Sub
                End If

                Atualizar("Update Config set CNPJ ='" & txtCPF.Text.Trim.Replace(".", "").Replace("/", "").Replace("-", "").Trim & "' where Codigo = " & CodConfig)

                bolOK = True
                Me.Close()
            Else
                MsgBox("CPF ou CNPJ não autorizado para usar o sistema!" & vbCrLf & "Favor entrar em contato com a Era Systems!", MsgBoxStyle.Information)
                Me.txtCPF.ResetText()
                Me.txtCPF.Focus()
                bolOK = False
            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        bolOK = False
        Me.Close()

    End Sub

    Private Sub frmDigitaCnpj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.rdgDoc.SelectedIndex = 1
        Me.txtCPF.Focus()
        Me.lblEmp.Text = NomeEmpresa
    End Sub
End Class