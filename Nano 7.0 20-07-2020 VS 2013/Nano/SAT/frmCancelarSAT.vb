Imports Nano.clsFuncoes
Public Class frmCancelarSAT


    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Dim dt As DataTable = Nothing

        Select Case Me.rdgOpcao.SelectedIndex
            Case 0
                dt = CarregarDataTable("SELECT Top 1 CodOrdem, Chave, Data, CFPDest, AssinaturaQrCode FROM SATFiscal order by Codigo DESC")

            Case 1
                dt = CarregarDataTable("SELECT CodOrdem, Chave, Data, CFPDest, AssinaturaQrCode FROM SATFiscal where CodOrdem = " & Me.txtPed.Text & " order by Codigo DESC")

            Case 2
                dt = CarregarDataTable("SELECT CodOrdem, Chave, Data, CFPDest, AssinaturaQrCode FROM SATFiscal where Chave = '" & Me.txtChave.Text & "' order by Codigo DESC")

        End Select
        If dt.Rows.Count > 0 Then
            Dim strChave As String = dt.Rows.Item(0).Item("Chave").ToString
            Dim strData As Date = dt.Rows.Item(0).Item("Data")
            Dim strCPF As String = dt.Rows.Item(0).Item("CFPDest").ToString
            Dim strCodOrdem As String = dt.Rows.Item(0).Item("CodOrdem").ToString
            Dim dtDataAtual As Date = My.Computer.Clock.LocalTime
            Dim strQrCode As String = dt.Rows.Item(0).Item("AssinaturaQrCode").ToString
            Dim dif As TimeSpan = dtDataAtual.Subtract(strData)
            If dif.Days = 0 And dif.Hours = 0 And dif.Minutes < 30 Then

                clsSAT.ImprimirCupomCancelamentoSatDll(strCodOrdem, strChave, strCPF, strQrCode)


                Limpar()
            Else
                MsgBox("Cancelamento não permitido, pois já se passaram 30 min!", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Dados inválidos!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
    Private Sub Limpar()
        Me.txtPed.ResetText()
        Me.txtChave.ResetText()
        Me.txtChave.Enabled = False
        Me.txtPed.Enabled = False
        Me.rdgOpcao.SelectedIndex = 0
    End Sub
    Private Sub frmCancelarSAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpar()
    End Sub

    Private Sub rdgOpcao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgOpcao.SelectedIndexChanged
        Me.txtPed.ResetText()
        Me.txtChave.ResetText()
        Select Case Me.rdgOpcao.SelectedIndex
            Case 0
                Me.txtChave.Enabled = False
                Me.txtPed.Enabled = False
            Case 1
                Me.txtChave.Enabled = False
                Me.txtPed.Enabled = True
                Me.txtPed.Focus()
            Case 2
                Me.txtPed.Enabled = False
                Me.txtChave.Enabled = True
                Me.txtChave.Focus()
        End Select
    End Sub
End Class