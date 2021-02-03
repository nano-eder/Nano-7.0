Imports Nano.clsFuncoes
Public Class frmConfRelRevisao
    Dim strFiltro As String = ""
    Dim strFiltro2 As String = ""
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If TesteConexao() = False Then Exit Sub
        Dim frm As New frmRelRevisao
        If Master = False Then
            strFiltro = " and CodConfig = " & CodConfig
            strFiltro2 = " where CodConfig = " & CodConfig
        End If
        frm.colCodConfig.Visible = Master
        Select Case rdgProduto.SelectedIndex
            Case 0
                'PLACA
                If Validar(Me.txtDesc) = False Then Exit Sub
                CarregarDados("Select * From Revisao where Placa Like '%" & txtDesc.Text.Trim & "%'" & strFiltro, frm.RevisaoGridControl)
            Case 1
                'DATA
                Dim data1, data2 As String
                data1 = dtInicial.EditValue
                data2 = dtFinal.EditValue

                If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Sub
                If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Sub

                Dim dataFim, dataIni As Date
                dataIni = data1
                dataFim = data2

                If dataIni > dataFim Then MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information) : Exit Sub

                Dim Sql As String = String.Format("Revisao >= '{0:dd/MM/yyyy}' AND Revisao <= '{1:dd/MM/yyyy}'", dtInicial.EditValue, dtFinal.EditValue)
                CarregarDados("Select * From Revisao where " & Sql & strFiltro, frm.RevisaoGridControl)

            Case 2
                'VENCIDAS

                Dim Sql As String = String.Format("Revisao <= '{0:dd/MM/yyyy}'", Date.Today)
                CarregarDados("Select * From Revisao where " & Sql & strFiltro, frm.RevisaoGridControl)
            Case 3
                'TODAS
                CarregarDados("Select * From Revisao" & strFiltro2, frm.RevisaoGridControl)
        End Select

        frm.Show()
        Me.Close()
        Me.txtDesc.ResetText()
        Me.rdgProduto.SelectedIndex = 0
        Me.dtFinal.Text = ""
        Me.dtInicial.Text = ""
    End Sub

    Private Sub rdgProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgProduto.SelectedIndexChanged
        Select Case Me.rdgProduto.SelectedIndex
            Case 0
                Me.Label3.Visible = False
                Me.Label4.Visible = False
                Me.dtFinal.Visible = False
                Me.dtInicial.Visible = False
                Me.txtDesc.Enabled = True
                Me.txtDesc.Visible = True
                Me.Label2.Visible = True
            Case 1
                Me.Label3.Visible = True
                Me.Label4.Visible = True
                Me.dtFinal.Visible = True
                Me.dtInicial.Visible = True
                Me.txtDesc.Visible = False
                Me.Label2.Visible = False
            Case Else
                Me.Label3.Visible = False
                Me.Label4.Visible = False
                Me.dtFinal.Visible = False
                Me.dtInicial.Visible = False
                Me.txtDesc.Visible = False
                Me.Label2.Visible = False

        End Select
    End Sub

    Private Sub frmConfRelRevisao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.rdgProduto.SelectedIndex = 0
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar <> vbBack And e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
End Class