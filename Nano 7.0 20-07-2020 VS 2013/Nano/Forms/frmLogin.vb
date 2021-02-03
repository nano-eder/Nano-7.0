Imports Nano.clsFuncoes
Imports Nano.clsBanco
Imports System.net.Mail
Imports System.IO
Imports System.Net
Imports System.Diagnostics

Public Class frmLogin
    Dim bolFecha As Boolean
    Public bolTroca As Boolean = False
    Dim intCont As Integer = 0
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Validar(txtUsu) = False Then Exit Sub
        If Validar(txtSenha) = False Then Exit Sub
        If ValidarUsuario(txtUsu, txtSenha) = False Then Exit Sub

        If SATExterno = True Then
            Me.Close()
            Exit Sub
        End If

        Me.Hide()

        Dim frm As New MDI

        frm.ShowDialog()

        If TrocaDeUsuario = True Then
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\TrocaDeUsuario.exe")
        End If

        Me.Close()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.V) Then e.SuppressKeyPress = True
    End Sub

    Private Sub txtSenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenha.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            Me.btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If SATExterno = True Then Exit Sub
        'CRIAR BANCO
        StringDeConexao = My.Settings.dsNanoCommerce
        'StringOnline = Decrypt("RGF0YSBTb3VyY2U9bWluaGFkbnMuZHluZG5zLm9yZywxNDM1O0luaXRpYWwgQ2F0YWxvZz1kYkVyYVN5c3RlbXM7IFBlcnNpc3QgU2VjdXJpdHkgSW5mbz1UcnVlO1VzZXIgSUQ9bmFub2VyYTtQYXNzd29yZD1zeXNuYW5v")

        StringOnline = Decrypt("RGF0YSBTb3VyY2U9MzUuMTk5LjExMy4xMTU7SW5pdGlhbCBDYXRhbG9nPWRiRXJhU3lzdGVtcztVc2VyIElEPWVyYTtQYXNzd29yZD1lZDMyMjM=")

        Dim vetNome As Array = Split(StringDeConexao, "=")
        Dim vetNomeComp As Array = Split(vetNome(1).ToString, ";")
        Dim strNomeDoComputador As String = vetNomeComp(0)

        vetNome = Split(vetNome(2).ToString, ";")

        NomeDoBancoSql = vetNome(0).ToString.Trim

        NomeComputador = My.Computer.Name

        Dim strMensagemBanco As String = ""

        Dim strVerificarBanco As String = ""
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\VerificarBanco.txt") = True Then
            strVerificarBanco = LerArquivo(My.Application.Info.DirectoryPath & "\VerificarBanco.txt", False)
        End If

        If strVerificarBanco <> "NÃO" Then
            If VerificaBanco(strMensagemBanco) = False Then
                If VerificarServicoBanco(strMensagemBanco) = True Then
                    Me.Close()
                    Exit Sub
                End If
            End If

            If ExisteBanco() = False Then
                CriarBanco()
                VersaoDoSistemaBanco = "1.0.0"
                GerenciaTabelas()
            End If
        End If
     
        Dim dt As DataTable = CarregarDataTable("Select VersaoNano from Config")

        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item(0).ToString <> "" Then
                VersaoDoSistemaBanco = dt.Rows.Item(0).Item(0).ToString
            End If
        End If

        GerenciaTabelas()

        dt = CarregarDataTable("Select Empresa, Mensalista, CompServidor, CNPJ from Config")
        Dim strCNPJCliente As String = ""
        If dt.Rows.Item(0).Item("Empresa").ToString = "" Then
            frmConfig.ShowDialog()
            MsgBox("O programa será fechado, abra-o novamente!", MsgBoxStyle.Information)
            Me.Close()
            Exit Sub
        Else
            Dim strTipDoc As String
           
            If dt.Rows.Item(0).Item("CNPJ").ToString.Length = 11 Then
                strTipDoc = "Cpf"
            Else
                strTipDoc = "Cnpj"
            End If

            strCNPJCliente = FormatarDocumentoString(dt.Rows.Item(0).Item("CNPJ").ToString, strTipDoc)
        End If

        Dim strVersaoSistema As String = "0"
        Dim dtProjeto As DataTable = DataTableOnline("Select Versao from Projeto where Nome ='NANO 7.0 COMMERCE'")
        If dtProjeto.Rows.Count > 0 Then
            strVersaoSistema = dtProjeto.Rows.Item(0).Item("Versao").ToString
        End If
        Dim bolAtualizar As Boolean = False
        Dim dtCliente As DataTable = DataTableOnline("Select Atualizar from Cliente where CPF ='" & strCNPJCliente & "'")
        If dtCliente.Rows.Count > 0 Then
            bolAtualizar = dtCliente.Rows.Item(0).Item("Atualizar")
        End If

        If bolAtualizar = True Then
            If dt.Rows.Item(0).Item("Mensalista") = True Then

                Dim strCompServidor As String = dt.Rows.Item(0).Item("CompServidor").ToString
                If strCompServidor = "" Then
                    If Val(strVersaoSistema.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
                        If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Try
                                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
                                Me.Close()
                            Catch ex As Exception
                                MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
                            End Try
                        End If
                    End If
                Else
                    If strCompServidor.ToUpper = NomeComputador.ToUpper Then
                        If Val(strVersaoSistema.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
                            If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Try
                                    System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
                                    Me.Close()
                                Catch ex As Exception
                                    MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
                                End Try
                            End If
                        End If
                    Else
                        Dim strVersao As String
                        strVersao = VersaoDoSistemaBanco
                        If Val(strVersao.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
                            If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Try
                                    System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
                                    Me.Close()
                                Catch ex As Exception
                                    MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
                                End Try
                            End If
                        End If
                    End If
                End If
            End If
        End If

        'Dim processo As Process() = Process.GetProcessesByName("TrocaDeUsuario")
        'If processo.Length = 0 Then
        '    If dt.Rows.Item(0).Item("Mensalista") = True Then

        '        Dim strCompServidor As String = dt.Rows.Item(0).Item("CompServidor").ToString
        '        If strCompServidor = "" Then
        '            Try
        '                If IO.File.Exists(My.Application.Info.DirectoryPath & "\VersaoCommerce.txt") = True Then
        '                    System.IO.File.Delete(My.Application.Info.DirectoryPath & "\VersaoCommerce.txt")

        '                End If

        '                Dim wc As New System.Net.WebClient()

        '                'wc.DownloadFile("https://sites.google.com/site/cotroles/inadimplencia/Controle.era?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Controle.era")
        '                wc.DownloadFile("https://sites.google.com/site/cotroles/versao/VersaoCommerce.txt?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\VersaoCommerce.txt")


        '            Catch ex As Exception

        '            End Try

        '            Dim strVersao As String

        '            strVersao = LerArquivo(My.Application.Info.DirectoryPath & "\VersaoCommerce.txt", True)
        '            If Val(strVersao.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
        '                If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                    Try
        '                        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
        '                        Me.Close()
        '                    Catch ex As Exception
        '                        MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
        '                    End Try
        '                End If
        '            End If
        '        Else
        '            If strCompServidor.ToUpper = NomeComputador.ToUpper Then
        '                Try
        '                    If IO.File.Exists(My.Application.Info.DirectoryPath & "\VersaoCommerce.era") = True Then
        '                        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\VersaoCommerce.era")

        '                    End If


        '                    Dim wc As New System.Net.WebClient()

        '                    'wc.DownloadFile("https://sites.google.com/site/cotroles/inadimplencia/Controle.era?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\Controle.era")
        '                    wc.DownloadFile("https://sites.google.com/site/cotroles/versao/VersaoCommerce.txt?attredirects=0&d=1", My.Application.Info.DirectoryPath & "\VersaoCommerce.txt")


        '                Catch ex As Exception

        '                End Try

        '                Dim strVersao As String

        '                strVersao = LerArquivo(My.Application.Info.DirectoryPath & "\VersaoCommerce.txt", True)
        '                If Val(strVersao.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
        '                    If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                        Try
        '                            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
        '                            Me.Close()
        '                        Catch ex As Exception
        '                            MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
        '                        End Try
        '                    End If
        '                End If

        '            Else
        '                Dim strVersao As String

        '                strVersao = VersaoDoSistemaBanco
        '                If Val(strVersao.Replace(".", "")) > Val(VersaoDoSistemaProjeto.Replace(".", "")) Then
        '                    If MsgBox("Você possui uma versão antiga do nano, deseja atualizá-lo agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                        Try
        '                            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & "UpdateNano.exe")
        '                            Me.Close()
        '                        Catch ex As Exception
        '                            MsgBox("Ocorreu uma falha ao iniciar o atualizador!", MsgBoxStyle.Information)
        '                        End Try
        '                    End If
        '                End If

        '            End If
        '        End If


        '    End If
        'Else

        '    Dim proc As Process
        '    For Each proc In Process.GetProcesses
        '        If proc.ProcessName = "TrocaDeUsuario" Then
        '            Try
        '                proc.Kill()
        '                proc.Close()
        '            Catch ex As Exception

        '            End Try
        '        End If
        '    Next
        'End If




        Dim strPC As String = Encryp(My.Computer.Name & My.Computer.Info.OSFullName)

        Dim dtReg As DataTable

        dtReg = CarregarDataTable("Select Codigo from Registro where Computador ='" & strPC & "'")

        If dtReg.Rows.Count = 0 Then
            frmSenhaReg.ShowDialog()
            If SenhaRegistro = False Then
                Me.Close()
                Exit Sub
            Else
                bwWork.RunWorkerAsync()
            End If
        End If

        If File.Exists(My.Application.Info.DirectoryPath & "\NanoBackupEmail.exe") Then
            Dim processo2 As Process() = Process.GetProcessesByName("NanoBackupEmail")
            If processo2.Length = 0 Then
                System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\NanoBackupEmail.exe")
            End If

        End If


    End Sub
    Private Shared Function VerificarServicoBanco(ByVal parMessagem As String) As Boolean
        If parMessagem.ToUpper.Contains("ERRO DE REDE") Then
            Try
                Dim vetNome As Array = Split(StringDeConexao, "=")

                Dim vetNomePC As Array = Split(vetNome(1), ";")
                Dim strNomePC As String = vetNomePC(0)
                If strNomePC.Contains("\") Then
                    vetNomePC = Split(strNomePC, "\")
                    strNomePC = vetNomePC(0)
                Else
                    If strNomePC.Contains(",") Then
                        vetNomePC = Split(strNomePC, ",")
                        strNomePC = vetNomePC(0)
                    End If
                End If
                '

                If strNomePC.ToUpper = My.Computer.Name.ToUpper Then
                    Dim strServices As String = "MSSQLSERVER|SQLEXPRESS|SQLEXPRESS1|MSSQL$SQLEXPRESS|MSSQL$SQLEXPRESS1|SQLEXPRESS2008|SQLEXPRESS2012|SQL|MSSQL$SQL|SQLAgent$SQL|SQLSERVERAGENT"
                    Dim vetService As Array = Split(strServices, "|")
                    Dim A As Integer

                    For A = 0 To vetService.Length
                        Try
                            Dim service As ServiceProcess.ServiceController = New ServiceProcess.ServiceController(vetService(A))

                            If ((service.Status.Equals(ServiceProcess.ServiceControllerStatus.Stopped)) Or (service.Status.Equals(ServiceProcess.ServiceControllerStatus.StopPending))) Then

                                service.Start()
                            End If

                        Catch ex1 As Exception

                        End Try


                    Next

                    MsgBox("O windowns não iniciou o banco de dados (SQL SERVER) o sistema irá inicia-lo. O sistema será fechado tente novamente após 30 segundos!" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & parMessagem, MsgBoxStyle.Information)
                    Return True
                    Exit Function
                Else
                    MsgBox("O sistema nã está conectando com o servidor. Faça as seguintes verificações: 1 verifique se o firewall do windows do servidor esta ativo, caso esteja desative; 2 verifique se este computador esta na mesma rede que o servidor; 3 verifique se possui rede com o servidor; 4 entre em contato com a erasystems." & vbCrLf & vbCrLf & vbCrLf & vbCrLf & parMessagem, MsgBoxStyle.Information)
                    Return True
                    Exit Function
                End If
            Catch ex As Exception
                Return False
                Exit Function
            End Try


        Else
            If parMessagem <> "" Then
                Return False
                Exit Function
            End If
        End If
    End Function
    Private Sub bwWork_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwWork.DoWork

        Try

            Dim dt As DataTable = CarregarDataTable("Select Empresa, Endereco, Telefone, CNPJ from Config")

            'If dt.Rows.Count > 0 Then

            '    Dim Mailmsg As New System.Net.Mail.MailMessage()
            '    'SERVIDOR DE SAÍDA

            '    Dim mSmtpCliente As New SmtpClient("smtp.mail.yahoo.com")

            '    'REMETENTE
            '    Mailmsg.To.Add("erasystems@ymail.com")
            '    'DESTINATÁRIO
            '    Mailmsg.From = New MailAddress("erasystems@ymail.com")
            '    'SENHA DO E-MAIL
            '    mSmtpCliente.Credentials = New System.Net.NetworkCredential("erasystems@ymail.com", "spfc4*5*6*")
            '    'FORMATO DO E-MAIL
            '    Mailmsg.IsBodyHtml = True
            '    'ASSUNTO
            '    Mailmsg.Subject = "Registro Nano Commerce " & dt.Rows.Item(0).Item("Empresa").ToString & " " & Date.Today
            '    'MENSSAGEM
            '    Mailmsg.Body = "Programa registrado no dia " & Date.Today & " para o cliente " & dt.Rows.Item(0).Item("Empresa").ToString & "." & vbCrLf & "Situada na " & dt.Rows.Item(0).Item("Endereco").ToString & "." & vbCrLf & "Contato: " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf & "CNPJ: " & dt.Rows.Item(0).Item("CNPJ").ToString & vbCrLf & "Computador: " & NomeComputador
            '    'E-MAIL É ENVIADO
            '    mSmtpCliente.Send(Mailmsg)
            'End If
            Dim strFrom As String = "erasyst@gmail.com"
            Dim strSenha As String = "spfc4*5*6*"
            Dim strRecepient As String = "erasystems@ymail.com"
            Dim strSubject As String = "Registro Nano Commerce " & dt.Rows.Item(0).Item("Empresa").ToString & " " & Date.Today
            Dim strBody As String = "Programa registrado no dia " & Date.Today & " para o cliente " & dt.Rows.Item(0).Item("Empresa").ToString & "." & vbCrLf & "Situada na " & dt.Rows.Item(0).Item("Endereco").ToString & "." & vbCrLf & "Contato: " & dt.Rows.Item(0).Item("Telefone").ToString & vbCrLf & "CNPJ: " & dt.Rows.Item(0).Item("CNPJ").ToString & vbCrLf & "Computador: " & NomeComputador
            Dim strServidorSaida As String = "smtp.gmail.com"
            Dim strPortaSaida As String = "587"
            Dim strServico As String = "Gmail"
            If enviaMensagemEmail(strFrom, strSenha, strRecepient, "", "", strSubject, strBody, strServidorSaida, "Normal", False, "ARQUIVO", strPortaSaida, strServico, Nothing) = True Then


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtUsu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsu.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If intCont < 5 Then
            intCont += 1
        Else
            intCont = 0
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub txtSenha_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSenha.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                MessageBox.Show(Me, "Botão direito não permitido")
        End Select
    End Sub
End Class