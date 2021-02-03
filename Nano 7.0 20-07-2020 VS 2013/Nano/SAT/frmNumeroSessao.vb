Imports Nano.clsFuncoes
Imports Nano.clsSAT
Public Class frmNumeroSessao


    Private Sub txtCodOrdem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodOrdem.KeyPress
        If IsNumeric(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmOrdemNfe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCodOrdem.ResetText()
        Me.txtCodOrdem.Focus()


        If Me.Tag = "ALTERAR" Then
            Me.rdgOpcao.Enabled = False
            Me.txtCodOrdem.Enabled = True
            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            Me.rdgOpcao.Enabled = True
            Me.rdgOpcao.SelectedIndex = 0
            Me.txtCodOrdem.Enabled = False
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnAlterar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    

    End Sub

    Private Sub btnAlterar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAlterar.ItemClick
        If Validar(Me.txtCodOrdem) = False Then Exit Sub
        If MsgBox("Você tem certeza que deseja atualizar o número sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Excluir("DELETE FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig & " and CodEmitente = " & CodConfigECF)

        Catch ex As Exception
            MsgBox("Erro ao excluir ordens!", MsgBoxStyle.Information)
            Exit Sub
        End Try

        Dim intCodOrdem As Integer = Me.txtCodOrdem.Text
        intCodOrdem = intCodOrdem - 1
        Try
            Inserir("INSERT INTO Ordens (Cod, Tabela, CodConfig, CodEmitente) VALUES (" & intCodOrdem & ",'Sat'," & _
                "" & CodConfig & "," & CodConfigECF & ")")

        Catch ex As Exception
            MsgBox("Erro ao salvar ordens!", MsgBoxStyle.Information)
        End Try

        MsgBox("Número ordem salvo com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        frmMenuSAT.rtfSAT.Text = VerificarUltimaSessao(Me.txtCodOrdem.Text)

        Me.Close()
    End Sub

    Private Sub rdgOpcao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgOpcao.SelectedIndexChanged
        Me.txtCodOrdem.ResetText()
        Select Case Me.rdgOpcao.SelectedIndex
            Case 0
                Me.txtCodOrdem.Enabled = False

            Case 1
                Me.txtCodOrdem.Enabled = True
        End Select
    End Sub
End Class