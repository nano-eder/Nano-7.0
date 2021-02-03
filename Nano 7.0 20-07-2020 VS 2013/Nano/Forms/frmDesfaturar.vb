Imports Nano.clsFuncoes
Imports System.IO
Imports Nano.clsFuncoesBematech
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Public Class frmDesfaturar

    Private Sub frmDesfaturar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.rdgOpcao.SelectedIndex = 0
        Me.txtPed.ResetText()
        Me.memMotivo.ResetText()
        Me.txtPed.Focus()

    End Sub

    Private Sub frmDesfaturar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "66")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmDesfaturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TesteConexao() = False Then Exit Sub

        If ExcluirVendas = False Then
            Dim rdgItem1 As New RadioGroupItem
            rdgItem1.Description = "Desfaturar Pedido"
            Me.rdgOpcao.Properties.Items.Clear()
            Me.rdgOpcao.Properties.Items.Add(rdgItem1)

            Me.Text = "Desfaturar Pedido"
            Me.lblNum.Text = "Nº do Pedido"
            Me.btnExcluirVen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnDesfaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        If DesfaturarPedidos = False Then
            Dim rdgItem1 As New RadioGroupItem
            rdgItem1.Description = "Excluir Venda"
            Me.rdgOpcao.Properties.Items.Clear()
            Me.rdgOpcao.Properties.Items.Add(rdgItem1)

            Me.Text = "Excluir Venda"
            Me.lblNum.Text = "Nº da Venda"
            Me.btnExcluirVen.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnDesfaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        End If
    End Sub

    Private Sub btnExcluirVen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluirVen.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Validar(Me.txtPed) = False Then Exit Sub

        
        If ExcluirVendaPedido(Me.txtPed.Text.Trim, Me.memMotivo.Text, "VENDA", True, False) = True Then
            Me.txtPed.ResetText()
            MsgBox("Venda excluída com sucesso!", MsgBoxStyle.Information)
            Me.Close()
        End If
       
      
    End Sub

    Private Sub rdgOpcao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgOpcao.SelectedIndexChanged
        Select Case Me.rdgOpcao.SelectedIndex

            Case 0
                Me.Text = "Excluir Venda"
                Me.lblNum.Text = "Nº da Venda"
                Me.btnExcluirVen.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                Me.btnDesfaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Case 1
                Me.Text = "Desfaturar Pedido"
                Me.lblNum.Text = "Nº do Pedido"
                Me.btnExcluirVen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Me.btnDesfaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        End Select

        Me.txtPed.ResetText()
        Me.memMotivo.ResetText()

    End Sub

    Private Sub btnDesfaturar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesfaturar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If Me.txtPed.Text.Trim = "" Then
            MsgBox("Informe o Nº do Pedido!", MsgBoxStyle.Information)
            Me.txtPed.Focus()
        End If

        If ExcluirVendaPedido(Me.txtPed.Text.Trim, Me.memMotivo.Text.Trim, "PEDIDO", True, False) = True Then
            Me.Close()
        End If

    End Sub

    Private Sub txtPed_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPed.Enter
        Me.txtPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    End Sub
End Class