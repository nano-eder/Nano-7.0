Imports Nano.clsFuncoes
Imports Nano.modFuncoes

Public Class frmCadComp

    Private Sub Salvar()

        Try
            Dim strCNPJ As String = CNPJEmpresa
            If strCNPJ.Length = 14 Then
                strCNPJ = AddPonto(strCNPJ, "J")
            Else
                strCNPJ = AddPonto(strCNPJ, "F")
            End If

            Dim dtEmpresa As DataTable = DataTableOnline("Select Codigo From Cliente Where CPF ='" & strCNPJ & "'")

            Dim CodEmpresa As Integer
            Dim NomePC, SO As String
            Dim bolServer As Boolean = Me.chkServidor.Checked


            NomePC = My.Computer.Name.ToString.Trim.ToUpper
            SO = My.Computer.Info.OSFullName.ToString.Trim.ToUpper

            If SO.Contains("WINDOWS XP") = True Then
                SO = "WINDOWS XP"
            ElseIf SO.Contains("WINDOWS VISTA") = True Then
                SO = "WINDOWS VISTA"
            ElseIf SO.Contains("WINDOWS 7") = True Then
                SO = "WINDOWS 7"
            ElseIf SO.Contains("WINDOWS SERVER") = True Then
                SO = "WINDOWS SERVER"
            ElseIf SO.Contains("WINDOWS 8") = True Then
                SO = "WINDOWS 8"
            ElseIf SO.Contains("WINDOWS 10") = True Then
                SO = "WINDOWS 10"
            End If


            If Validar(Me.txtID) = False Then Exit Sub
            If Validar(Me.txtSenha) = False Then Exit Sub

            If dtEmpresa.Rows.Count > 0 Then
                CodEmpresa = dtEmpresa.Rows.Item(0).Item("Codigo").ToString()

                Dim bolSalvou As Boolean = False
                bolSalvou = ExecCmdOnline("Insert Into DadosComp (CodCli, ID, Senha, NomeComp, SO, Servidor) " & _
                " Values(" & CodEmpresa & ",'" & Me.txtID.Text.Trim & "','" & Me.txtSenha.Text.Trim & "'," & _
                "'" & NomePC & "','" & SO.Trim & "','" & bolServer & "')")

                If bolSalvou = True Then
                    MsgBox("Computador cadastrado com sucesso!", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Não foi possivel cadastrar o computador!", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox("Não foi possivel cadastrar o computador!", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Sub Limpar()
        Me.txtID.ResetText()
        Me.txtSenha.ResetText()
        Me.chkServidor.Checked = False
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If

        If Char.IsLetter(e.KeyChar) = True And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmTeamViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpar()
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        Salvar()
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class