Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports Nano.clsFuncoes

Public Class frmErro

    Public bolMail As Boolean
    Public intOrdemVenda As Integer

    Private Sub btnTeste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeste.Click

        If TesteConexao() = True Then
            Me.txtMsg.Text = "Sua conexão está OK!"
            Me.btnDetails.Visible = True
        Else
            Me.txtMsg.Text = "Seu computador não possui conexão com o banco de dados." & vbCrLf & "Verifique sua conexão de rede!"
        End If

    End Sub

    Private Sub frmErro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "70")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub frmErro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grpEmail.Visible = False
        Me.btnMail.Text = "Enviar E-Mail"
        Me.btnTentar.Visible = True
        NovoComandoSQL = ""
        MensagemEmailUsuario = ""
        Me.txtMail.Text = ""

    End Sub

    Private Sub btnMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click

        If Me.btnMail.Text = "Enviar E-Mail" Then
            Me.btnMail.Text = "Enviar"
            Me.grpEmail.Visible = True
            Me.btnTentar.Visible = False
        Else

            If Conectado() = False Then MsgBox("Você não possui conexão com a internet!", MsgBoxStyle.Information) : Exit Sub

            If My.Computer.Network.Ping("www.terra.com.br") = False Then MsgBox("Você não possui conexão com a internet!", MsgBoxStyle.Information) : Exit Sub
            bolMail = True
            MensagemEmailUsuario = Me.txtMail.Rtf
            Me.Close()
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub

    Private Shared Function Conectado() As Boolean
        Try
            Conectado = My.Computer.Network.Ping("www.google.com")

        Catch ex As Exception
            Conectado = False
        End Try
    End Function
    Private Sub btnTentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTentar.Click
        If ExecutaCMDErro(Me.txtDetalhes.Text, intOrdemVenda) = True Then
            MsgBox("Comando executado com sucesso!", MsgBoxStyle.Information)
            ComandoOK = True
            NovoComandoSQL = Me.txtDetalhes.Text.Trim
            Me.Close()
        End If
    End Sub


    Private Shared Function ExecutaCMDErro(ByVal strSQL As String, ByVal parOrdemVenda As Integer) As Boolean
        Try
            strSQL = "SET DATEFORMAT dmy " & strSQL
            Dim conexao = New SqlClient.SqlConnection(StringDeConexao)
            Dim cmd As SqlCommand
            conexao.open()
            cmd = New SqlCommand(strSQL, conexao)

            cmd.ExecuteNonQuery()
            cmd.UpdatedRowSource = UpdateRowSource.Both
            conexao.close()
            Return True
        Catch ex As Exception
            frmErro.txtMsg.Text = ex.Message
            ExcluirVendaPedido(parOrdemVenda, "VENDA EXCLUÍDA POR MOTIVO DE ERRO NA HORA DE SALVAR OS DADOS!", "VENDA", False, False)
            Return False
        End Try
    End Function

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        Me.grpTetalhe.Visible = True
    End Sub

End Class

