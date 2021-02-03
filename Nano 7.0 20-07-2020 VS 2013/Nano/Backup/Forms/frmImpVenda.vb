Imports Nano.clsFuncoes
Public Class frmImpVenda
    Dim intCodOrdem As Integer
    Dim bolImprimir As Boolean = False
    Private Sub rdgOrdem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgOrdem.SelectedIndexChanged
        Select Case rdgOrdem.SelectedIndex
            Case 0
                Me.txtCodOrdem.Enabled = False
                Me.txtCodOrdem.Text = intCodOrdem
                Me.txtCodOrdem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Me.btnImprimir.Focus()
            Case Else
                Me.txtCodOrdem.ResetText()
                Me.txtCodOrdem.Enabled = True
                Me.txtCodOrdem.Focus()
                Me.txtCodOrdem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End Select
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        bolImprimir = True
        Me.Close()
    End Sub

    Private Sub frmImpVenda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bolImprimir = False Then
            Me.txtCodOrdem.Text = ""
        End If
    End Sub

    Private Sub frmImpVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmImpVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtTotal As DataTable = CarregarDataTable("SELECT Max(CodOrdem) FROM Total where CodConfig =" & CodConfig)
        intCodOrdem = dtTotal.Rows.Item(0).ItemArray(0).ToString
        Me.txtCodOrdem.Text = intCodOrdem
        Me.rdgOrdem.SelectedIndex = 0
        bolImprimir = False
    End Sub
End Class