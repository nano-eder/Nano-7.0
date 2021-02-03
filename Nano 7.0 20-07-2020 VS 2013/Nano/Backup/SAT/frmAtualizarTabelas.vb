Imports Nano.clsFuncoes
Imports Nano.clsAtualizarTabelas
Imports System.IO
Public Class frmAtualizarTabelas
    Dim intPB As Integer
    Dim bolSalvar As Boolean = False
    Public strUF As String
    Public Shared Sub Main()
        Application.Run(New frmAtualizarTabelas())
    End Sub
    Private Sub Timer(ByVal parSegundos As Integer)
        Dim intSeg As Integer = Second(Now)
        intSeg += parSegundos

        If intSeg > 59 Then
            intSeg = intSeg - 59
        End If
        Dim bolOk As Boolean = False
        While bolOk = False
            Dim intSegundo As Integer = Second(Now)

            If intSeg = intSegundo Then
                bolOk = True
            End If

        End While
    End Sub
    Private Sub Cidade()
        Dim bolOk As Boolean = False

        Me.lblVerificar.Text = "Veiricando tabela cidade"
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
        If Login = "ADM" And Senha = "SPFC" Then
            Dim dt As DataTable = CarregarDataTable("SELECT * FROM Cidade")
            If dt.Rows.Count > 0 Then
                If MsgBox("Já existe dados na tabela cidade deseja substituir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bolOk = True

                End If
            Else
                bolOk = True
            End If
        Else
            bolOk = True
        End If

        intPB = 24
        pb1.Maximum = intPB
        pb1.Value = 0
        If bolOk = True Then
            Excluir("DELETE FROM Cidade")
            Me.lblVerificar.Text = "Inseririndo dados na tabela cidade"
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)

            Dim I As Integer
            For I = 0 To 11
                InserirCidade(I + 1)
                BarraProgresso()
                Timer(10)
                BarraProgresso()
            Next
        End If
    End Sub
    Private Sub CFOP()
        Dim bolOk As Boolean = False
        Me.lblVerificar.Text = "Veiricando tabela cfop"
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
        If Login = "ADM" And Senha = "SPFC" Then
            Dim dt As DataTable = CarregarDataTable("SELECT * FROM CFOP")
            If dt.Rows.Count > 0 Then
                If MsgBox("Já existe dados na tabela cfop deseja substituir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bolOk = True

                End If
            Else
                bolOk = True
            End If
        Else
            bolOk = True
        End If

        intPB = 6
        pb1.Maximum = intPB
        pb1.Value = 0
        If bolOk = True Then
            Excluir("DELETE FROM CFOP")
            Me.lblVerificar.Text = "Inseririndo dados na tabela cfop"
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)

            Dim I As Integer
            For I = 0 To 2
                InserirCFOP(I + 1)
                BarraProgresso()
                Timer(10)
                BarraProgresso()
            Next
        End If
    End Sub
    Private Sub Pais()
        Dim bolOk As Boolean = False
        Me.lblVerificar.Text = "Veiricando tabela pais"
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
        If Login = "ADM" And Senha = "SPFC" Then
            Dim dt As DataTable = CarregarDataTable("SELECT * FROM Pais")
            If dt.Rows.Count > 0 Then
                If MsgBox("Já existe dados na tabela pais deseja substituir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bolOk = True

                End If
            Else
                bolOk = True
            End If
        Else
            bolOk = True
        End If

        intPB = 4
        pb1.Maximum = intPB
        pb1.Value = 0
        If bolOk = True Then
            Excluir("DELETE FROM Pais")
            Me.lblVerificar.Text = "Inseririndo dados na tabela pais"
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)

            Dim I As Integer
            For I = 0 To 1
                InserirPais(I + 1)
                BarraProgresso()
                Timer(10)
                BarraProgresso()
            Next
        End If
    End Sub
    Private Sub TabelaIBPT()
        Dim bolOk As Boolean = False
        Me.lblVerificar.Text = "Veiricando tabela IBPT"
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
        If Login = "ADM" And Senha = "SPFC" Then
            Dim dt As DataTable = CarregarDataTable("SELECT * FROM TabelaIBPT where Versao = '20.1'")
            If dt.Rows.Count > 0 Then
                If MsgBox("Já existe dados na tabela IBPT pais deseja substituir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    bolOk = True

                End If
            Else
                bolOk = True
            End If
        Else
            bolOk = True
        End If

        intPB = 48
        pb1.Maximum = intPB
        pb1.Value = 0
        If bolOk = True Then
            Excluir("DELETE FROM TabelaIBPT")
            Me.lblVerificar.Text = "Inseririndo dados na tabela IBPT"
            Application.DoEvents()
            System.Threading.Thread.Sleep(40)

            Dim I As Integer
            'For I = 0 To 23
            '    InserirTabelaIBPT(I + 1)
            '    BarraProgresso()
            '    Timer(10)
            '    BarraProgresso()
            'Next

            Try
                Select Case strUF
                    Case "AC"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Acre.txt?attredirects=0&d=1")
                    Case "AL"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Alagoas.txt?attredirects=0&d=1")
                    Case "AP"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Amapa.txt?attredirects=0&d=1")
                    Case "AM"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Amazonas.txt?attredirects=0&d=1")
                    Case "BA"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Bahia.txt?attredirects=0&d=1")
                    Case "CE"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Ceara.txt?attredirects=0&d=1")
                    Case "DF"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/DistritoFederal.txt?attredirects=0&d=1")
                    Case "ES"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/EspiritoSanto.txt?attredirects=0&d=1")
                    Case "GO"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Goias.txt?attredirects=0&d=1")
                    Case "MA"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Maranhao.txt?attredirects=0&d=1")
                    Case "MT"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/MatoGrosso.txt?attredirects=0&d=1")
                    Case "MS"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/MatoGrossodoSul.txt?attredirects=0&d=1")
                    Case "MG"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/MinasGerais.txt?attredirects=0&d=1")
                    Case "PA"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Para.txt?attredirects=0&d=1")
                    Case "PB"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Paraiba.txt?attredirects=0&d=1")
                    Case "PR"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Parana.txt?attredirects=0&d=1")
                    Case "PE"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Pernambuco.txt?attredirects=0&d=1")
                    Case "PI"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Piaui.txt?attredirects=0&d=1")
                    Case "RJ"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/RiodeJaneiro.txt?attredirects=0&d=1")
                    Case "RN"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/RioGrandedoNorte.txt?attredirects=0&d=1")
                    Case "RS"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/RioGrandedoSul.txt?attredirects=0&d=1")
                    Case "RO"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Rondonia.txt?attredirects=0&d=1")
                    Case "RR"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Roraima.txt?attredirects=0&d=1")
                    Case "SC"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/SantaCatarina.txt?attredirects=0&d=1")
                    Case "SE"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Sergipe.txt?attredirects=0&d=1")
                    Case "SP"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/SaoPaulo.txt?attredirects=0&d=1")
                    Case "TO"
                        DownloadTabelaIbpt("https://sites.google.com/site/cotroles/tabelaibpt/Tocantins.txt?attredirects=0&d=1")
                End Select
            Catch ex As Exception
            End Try
            
            If IO.File.Exists(My.Application.Info.DirectoryPath & "\TABELAIBPT" & strUF & ".txt") = True Then
                Dim reader As New StreamReader(My.Application.Info.DirectoryPath & "\TABELAIBPT" & strUF & ".txt")

                Dim linha As String = String.Empty

                Dim strRP As String = ""

                Do
                    linha = reader.ReadLine()
                    If linha <> "" Then

                        Inserir(linha)

                    End If
                    I += 1

                    If I = 1 Then
                        BarraProgresso()
                    ElseIf I = 250 Then
                        I = 1
                        BarraProgresso()
                    End If

                    If (linha Is Nothing) Then
                        Exit Do
                    End If
                Loop

                reader.Close()

            Else
                MsgBox("O Download da Tabela IBPT não foi realizado com sucesso, entre em contato com a Era Systems!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub DownloadTabelaIbpt(ByVal parHttp As String)
        Try
            System.IO.File.Delete(My.Application.Info.DirectoryPath & "\TABELAIBPT" & strUF & ".txt")
        Catch ex As Exception
        End Try
        If parHttp <> "" Then
            Try
                Dim wc As New System.Net.WebClient()
                wc.DownloadFile(parHttp, My.Application.Info.DirectoryPath & "\TABELAIBPT" & strUF & ".txt")
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & "Feche o sistema e tente novamente, se permacer o erro entre em contato com nosso suporte!", MsgBoxStyle.Information)
            End Try
        End If

    End Sub
    Private Sub BarraProgresso()
        If pb1.Value < intPB Then
            pb1.Value = pb1.Value + 1
        End If
        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmCorrecaoEstoque_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bolSalvar = False Then
            Dim strDesTabela As String = "da tabela "
            If Me.Tag.ToString.Contains("-") Then
                strDesTabela = "das tabelas "
            End If
            If MsgBox("É necessário fazer a atualização " & strDesTabela & Me.Tag & "." & vbCrLf & "Deseja realizar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Me.Tag.ToString.Contains("Cidade") = True Then
                    Cidade()
                End If

                If Me.Tag.ToString.Contains("Cfop") = True Then
                    CFOP()
                End If

                If Me.Tag.ToString.Contains("Pais") = True Then
                    Pais()
                End If

                If Me.Tag.ToString.Contains("TabelaIBPT") = True Then
                    TabelaIBPT()
                End If
                bolSalvar = True
                MsgBox("Atualização realizada com sucesso!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub frmCorrecaoEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Tag.ToString.Contains("-") Then
            Me.Text = "Atualizar tabelas " & Me.Tag

        Else
            Me.Text = "Atualizar tabela " & Me.Tag

        End If

    End Sub


    Private Sub btnIniciar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIniciar.ItemClick
        If Me.Tag.ToString.Contains("Cidade") = True Then
            Cidade()
        End If

        If Me.Tag.ToString.Contains("Cfop") = True Then
            CFOP()
        End If

        If Me.Tag.ToString.Contains("Pais") = True Then
            Pais()
        End If

        If Me.Tag.ToString.Contains("TabelaIBPT") = True Then
            TabelaIBPT()
        End If
        bolSalvar = True
        MsgBox("Atualização realizada com sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class