Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data
Imports Nano.clsFuncoes

Imports System.Threading
Public Class frmTEF
    Public strValor As String
    Public intVezes As Integer
    Public intCredDeb As Integer
    Public strNumTransacao As String
    Dim bolInicio As Boolean
    Public cupomFiscal As String
    Private Shared nVezes As Integer = 0
    Private Shared _tamanhoRecebido As Integer = 0
    Private Shared _configurado As Boolean = False
    Private Shared _recebido As Byte() = New Byte(19999) {}
    Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
    Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
    Dim operador As String = UserNano
    Dim restricoes As String = ""

    Dim bolFechar As Boolean = False
    Dim bolProcesso As Boolean = False
    Dim strMensagem As String

    Dim bolCancelar As Boolean = False

    Public intCreditoDebito As Integer

    Private Sub frmTEF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnCancelar.Enabled = False
        bolInicio = True

        If Me.Tag = "TESTE" Then
            Me.btnCancelar.Caption = "&Fechar"
        End If
        Timer1.Start()
    End Sub
    Private Sub BaixarCrystal()

        Venda(intCredDeb, strValor, cupomFiscal, dataFiscal, horario, operador, restricoes, intVezes, strNumTransacao, RetornoTEF)

    End Sub
    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        dataFiscal = Format(Date.Today, "yyyyMMdd")
        horario = Format(My.Computer.Clock.LocalTime, "HHmmss")
        operador = UserNano
        restricoes = ""

        IniciaThreadBaixaCrystal()
    End Sub
    Private mThreadBaixarCrystal As Thread

    Public Sub IniciaThreadBaixaCrystal()
        mThreadBaixarCrystal = New Threading.Thread(AddressOf BaixarCrystal)
        mThreadBaixarCrystal.Start()
    End Sub
    Private Sub Cancelar()
        Dim comando As Integer = 0
        Dim continua As Integer = 0
        Dim tipoCampo As Integer = 0
        Dim tamanhoMinimo As Short = 0
        Dim tamanhoMaximo As Short = 0

        Dim buffer As Byte() = New Byte(19999) {}

        Dim retorno As Integer = 10000
        While retorno = 10000

            retorno = clsTEF.ContinuaFuncaoSiTefInterativo(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer.Length, -1)

            If comando = 0 Then
                RotinaResultado(tipoCampo, buffer, continua)
            Else
                RotinaColeta(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer, continua)
                Select Case comando

                    Case 1, 2, 3, 4
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        'Case 22
                        '    Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        '    mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        '    If mensagem.Contains("13 - Operacao Cancelada") = True Then
                        '        RetornoTEF = -1
                        '    End If

                    Case 20
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("13 - Operacao Cancelada?") = True Then

                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes("SIM" & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                End Select

            End If
        End While
    End Sub
    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        If Me.Tag = "TESTE" Then
            Me.Close()
        Else
            If MsgBox("Tem certeza que cancelar a operação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Try
                    mThreadBaixarCrystal.Suspend()
                    mThreadBaixarCrystal.Abort()
                Catch ex As Exception

                End Try
                'Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
                'Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
                'clsTEF.FinalizaTransacaoSiTefInterativo(0, cupomFiscal, dataFiscal, horario)
                Cancelar()
                Me.lblProcesso2.Text = "Operação Cancelada!"

                MsgBox("Operação Cancelada!", MsgBoxStyle.Information)
                RetornoTEF = -1
                Me.Close()
            End If
        End If
        
    End Sub
    Private Sub btnMensagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMensagem.Click
        Me.lblProcesso2.Text = ""
        Me.lblProcesso2.Text = strMensagem
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolInicio = True Then
            Me.TextEdit1.Focus()
            bolInicio = False
            btnInicio_Click(sender, e)
        End If

        If bolFechar = True Then
            bolFechar = False
            Me.Close()
        End If

        If bolProcesso = True Then
            bolProcesso = False
            btnMensagem_Click(sender, e)
        End If

        If bolCancelar = True Then
            Me.btnCancelar.Enabled = True
        Else
            Me.btnCancelar.Enabled = False
        End If
    End Sub

    Private ReadOnly Property Configurado() As Boolean
        Get
            Return _configurado
        End Get
    End Property

    Private ReadOnly Property TamanhoRecebido() As Integer
        Get
            Return _tamanhoRecebido
        End Get
    End Property

    Private ReadOnly Property Recebido() As Byte()
        Get
            Return _recebido
        End Get
    End Property
    Public Sub Conectar(ByVal IP As Object, ByVal parCaixa As String)
        Dim _endereco As Byte() = Encoding.ASCII.GetBytes(IP & Convert.ToString(vbNullChar))
        Dim _loja As Byte() = Encoding.ASCII.GetBytes(Format(CInt(parCaixa), "00000000") & Convert.ToString(vbNullChar)) 'Encoding.ASCII.GetBytes("00000000" & Convert.ToString(vbNullChar))
        Dim _terminal As Byte() = Encoding.ASCII.GetBytes(Format(CInt(CodigoTerminal), "00000000") & Convert.ToString(vbNullChar))

        Dim cmdLineStr As Integer = clsTEF.ConfiguraIntSiTefInterativo(_endereco, _loja, _terminal, 0)


        If (cmdLineStr = 0) Then

        Else
            Processando("Erro: Retorno -> " & CStr(cmdLineStr))
        End If

    End Sub
    Private Function Configura(ByVal endereco As String, ByVal loja As String, ByVal terminal As String) As Integer
        Dim _endereco As Byte() = Encoding.ASCII.GetBytes(endereco & Convert.ToString(vbNullChar))
        Dim _loja As Byte() = Encoding.ASCII.GetBytes(loja & Convert.ToString(vbNullChar))
        Dim _terminal As Byte() = Encoding.ASCII.GetBytes(terminal & Convert.ToString(vbNullChar))

        Try
            Dim result As Integer = clsTEF.ConfiguraIntSiTefInterativo(_endereco, _loja, _terminal, 0)

            _configurado = (result = 0)

            Return result
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "Erro")
        End Try

        Return -999
    End Function

    Private Sub RotinaResultado(ByVal tipoCampo As Integer, ByVal buffer As Byte(), ByRef intRetorno As Integer)
        Dim mensagem As String = Encoding.UTF8.GetString(buffer)

        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))

        Select Case tipoCampo
            Case 1
                Exit Select
            Case 121
                ComprovanteTEF(0) = "Comprovante Cliente: " & vbLf + mensagem.ToString()
                Exit Select
            Case 122
                ComprovanteTEF(1) = "Comprovante Estabelecimento: " & vbLf + mensagem.ToString()
                Exit Select
            Case 131
                Exit Select
            Case 132
                TipoCartao = Bandeira(mensagem.ToString())
                Exit Select
            Case 134
                NumTransacao = mensagem.ToString()
                Exit Select
            Case Else
                Exit Select
        End Select

        intRetorno = 0
    End Sub

    Private Shared Function TrataMenu(ByVal pOpcoes As Byte(), ByVal pEscolha As Byte()) As Integer
        Return 0
    End Function

    Private Shared Function LeCampo(ByVal tamanhoMinimo As Short, ByVal tamanhoMaximo As Short, ByVal pMensagem As Byte(), ByVal pCampo As Byte()) As Integer
        Return 0
    End Function

    Private Sub Processando(ByVal parMensagem As String)
        Me.strMensagem = ""
        Me.strMensagem = parMensagem
        Me.bolProcesso = True
    End Sub
    Private Sub RotinaColeta(ByVal comando As Integer, ByVal tipoCampo As Integer, ByRef pTamanhoMinimo As Short, ByRef pTamanhoMaximo As Short, ByVal pDadosComando As Byte(), ByVal pCampo As Byte(), ByRef intRetorno As Integer)
        Dim c As Char
        Dim mensagem As String = Encoding.UTF8.GetString(pDadosComando)

        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))

        If comando <> 23 Then
            nVezes = 0
        End If

        Select Case comando
            Case 1, 2, 3, 4
                ' MsgBox(mensagem.ToString())
                Processando(mensagem.ToString())
                intRetorno = 0
                Exit Sub
            Case 11, 12, 13, 14
                Processando("")
                intRetorno = 0
                Exit Sub
            Case 37
                Processando(mensagem.ToString())
                intRetorno = 0
                Exit Sub
            Case 20
                Processando(mensagem.ToString())
                intRetorno = 0
                Exit Sub
            Case 21
                Processando(mensagem.ToString())
                intRetorno = 0
                'Return TrataMenu(pDadosComando, pCampo)
                Exit Sub
            Case 22
                'MsgBox(mensagem.ToString())
                Processando(mensagem.ToString())
                intRetorno = 0
                Exit Sub
            Case 23
                System.Threading.Thread.Sleep(1000)
                If System.Math.Max(System.Threading.Interlocked.Increment(nVezes), nVezes - 1) > 30 Then
                    intRetorno = -1
                    Exit Sub
                End If
                intRetorno = 0
                Exit Sub
            Case 30, 31, 32, 33, 34, 35, 38
                intRetorno = 0
                Exit Sub
                'Return LeCampo(pTamanhoMinimo, pTamanhoMaximo, pDadosComando, pCampo)
        End Select

        intRetorno = -1
    End Sub


    Private Sub Venda(ByVal funcao As Integer, ByVal valor As String, ByVal cupomFiscal As String, _
    ByVal dataFiscal As String, ByVal horario As String, ByVal operador As String, _
    ByVal restricoes As String, ByVal parVezes As Integer, ByVal parNSU As String, ByRef intRetorno As Integer)
        Dim comando As Integer = 0
        Dim continua As Integer = 0
        Dim tipoCampo As Integer = 0
        Dim tamanhoMinimo As Short = 0
        Dim tamanhoMaximo As Short = 0

        Dim _valor As Byte() = Encoding.ASCII.GetBytes(valor & Convert.ToString(vbNullChar))
        Dim _cupomFiscal As Byte() = Encoding.ASCII.GetBytes(cupomFiscal & Convert.ToString(vbNullChar))
        Dim _dataFiscal As Byte() = Encoding.ASCII.GetBytes(dataFiscal & Convert.ToString(vbNullChar))
        Dim _horario As Byte() = Encoding.ASCII.GetBytes(horario & Convert.ToString(vbNullChar))
        Dim _operador As Byte() = Encoding.ASCII.GetBytes(operador & Convert.ToString(vbNullChar))
        Dim _restricoes As Byte() = Encoding.ASCII.GetBytes(restricoes & Convert.ToString(vbNullChar))

        Dim buffer As Byte() = New Byte(19999) {}

        Dim retorno As Integer = clsTEF.IniciaFuncaoSiTefInterativo(funcao, _valor, _cupomFiscal, _dataFiscal, _horario, _operador, _restricoes)

        While retorno = 10000
            retorno = clsTEF.ContinuaFuncaoSiTefInterativo(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer.Length, 0)

            If comando = 0 Then
                RotinaResultado(tipoCampo, buffer, continua)
            Else
                RotinaColeta(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer, continua)
                Select Case comando

                    Case 1, 2, 3, 4


                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("Insira ou passe ou aproxime o cartao na leitora") = True Then
                            bolCancelar = True
                        End If
                        If mensagem.Contains("SELECIONADO") = True Then
                            bolCancelar = False
                        End If
                        If mensagem.Contains("SENHA") = True Then
                            bolCancelar = True
                        End If
                        If mensagem.Contains("Aguarde") = True Then
                            bolCancelar = False
                        End If


                        If mensagem.Contains("Tipo do comprovante a ser re-impresso") = True Then
                            Dim strTi As String = parNSU.Substring(0, 3)
                            If strTi = "999" Then
                                strTi = "1"
                            Else
                                strTi = "2"
                            End If
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(strTi & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                    Case 13
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        Dim I As Integer = 1
                    Case 20
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("13 - Operacao Cancelada?") = True Then

                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes("SIM" & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("Confirma Cancelamento?") = True Then

                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes("0" & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("Confirma o teste de comunicacao com o SiTef ") = True Then

                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes("0" & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                    Case 22
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("Sem conexao SiTef") = True Then

                            retorno = -1

                        End If

                    Case 23
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("Sem conexao SiTef") = True Then

                            retorno = -1

                        End If
                    Case 21
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("Parcelado pelo") = True Then
                            Dim intPar As Integer = 1
                            If parVezes > 1 Then
                                intPar = 2
                            End If
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(intPar & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("1:Via Lojista;2:Via Portador;3:Todos") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes("2" & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                        '1:A Vista;2:Financ. Loja;3:Financ.
                        '1:A Vista;2:Financ. Loja;3:Financ. Adm.
                        If mensagem.Contains("1:A Vista;2:Financ. Loja;3:Financ.") = True Then
                            Dim intPar As Integer = 1
                            If parVezes > 1 Then
                                intPar = 2
                            End If
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(intPar & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                        If mensagem.Contains("Cancelamento de Cartao") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(intCreditoDebito & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("1:Rede;2:Cielo;3:Outros") = True Then
                            Dim strTi As String = parNSU.Substring(0, 3)
                            If strTi = "999" Then
                                strTi = "1"
                            Else
                                If NomeAd = "REDE" Then
                                    strTi = "1"
                                ElseIf NomeAd = "CIELO" Then
                                    strTi = "2"
                                Else
                                    strTi = "3"
                                End If

                            End If
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(strTi & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                    Case 30
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))

                      
                 
                        If mensagem.Contains("Forneca o numero de parcelas") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(parVezes & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("Forneca o codigo do supervisor") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(parNSU & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If

                        If mensagem.Contains("Data da transacao") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(Format(Date.Today, "ddMMyyyy") & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        End If
                        '
                        If mensagem.Contains("Forneca o numero do documento a ser cancelado") = True Or mensagem.Contains("Forneca o documento a ser re-impresso") = True Then

                            Dim strTi As String = parNSU.Substring(0, 3)
                            If strTi = "999" Then
                                strTi = parNSU
                            Else
                                If NomeAd = "REDE" Or NomeAd = "OUTROS" Then
                                    strTi = parNSU
                                Else
                                    strTi = parNSU.Substring(3, 6)
                                End If

                            End If

                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(strTi & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        Else
                            If mensagem.Contains("Numero do Doc") = True Then
                                Dim strTi As String = parNSU.Substring(0, 3)
                                If strTi = "999" Then
                                    strTi = parNSU
                                Else
                                    strTi = parNSU.Substring(3, 6)
                                End If
                                Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(strTi & Convert.ToString(vbNullChar))
                                buffer = New Byte(19999) {}
                                Dim I As Integer
                                For I = 0 To buffer2.Length - 1
                                    buffer(I) = buffer2(I)
                                Next
                            End If
                        End If
                    Case 34
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        If mensagem.Contains("Forneca o valor da transacao a ser cancelada") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(valor & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
                        Else
                            If mensagem.ToLower.Contains("valor da transacao") = True Then
                                Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(valor & Convert.ToString(vbNullChar))
                                buffer = New Byte(19999) {}
                                Dim I As Integer
                                For I = 0 To buffer2.Length - 1
                                    buffer(I) = buffer2(I)
                                Next
                            End If
                        End If
                End Select

            End If
        End While

        intRetorno = retorno
        If Me.Tag <> "TESTE" Then
            If intRetorno = 0 Then
                bolFechar = True
            Else
                bolCancelar = True
            End If
        Else
            bolCancelar = True
        End If

        mThreadBaixarCrystal.Abort()
    End Sub

    Public Function LeConfirmacaoPinPad(ByVal mensagem As String) As Integer
        Try
            Dim _pcampo As Byte() = New Byte(1999) {}
            Dim _mensagem As Byte() = Encoding.ASCII.GetBytes(mensagem & Convert.ToString(vbNullChar))

            Dim retorno As Integer = clsTEF.LeSimNaoPinPad(_mensagem)

            Return retorno
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "Erro")
        End Try

        Return -999
    End Function

    Public Function AbrirPinPad() As Integer
        Try
            Dim retorno As Integer = clsTEF.AbrePinPad()

            Return retorno
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "Erro")
        End Try

        Return -999
    End Function

    Public Function FecharPinPad() As Integer
        Try
            Dim retorno As Integer = clsTEF.FechaPinPad()

            Return retorno
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "Erro")
        End Try

        Return -999
    End Function

    Public Function LeCartao(ByVal mensagem As String, ByRef trilha1 As String, ByRef trilha2 As String) As Integer
        Try
            Dim _mensagem As Byte() = Encoding.ASCII.GetBytes(mensagem & Convert.ToString(vbNullChar))
            Dim _trilha1 As Byte() = New Byte(1999) {}
            Dim _trilha2 As Byte() = New Byte(1999) {}

            clsTEF.LeCartaoDireto(_mensagem, _trilha1, _trilha2)

            trilha1 = System.Text.Encoding.UTF8.GetString(_trilha1)
            trilha1 = trilha1.Substring(0, trilha1.IndexOf(ControlChars.NullChar))

            trilha2 = System.Text.Encoding.UTF8.GetString(_trilha2)
            trilha2 = trilha2.Substring(0, trilha2.IndexOf(ControlChars.NullChar))

            Return 0
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "Erro")
        End Try

        trilha1 = Nothing
        trilha2 = Nothing

        Return -999
    End Function

    Private Shared Function Bandeira(ByVal parCodigo As String) As String
        Dim strBandeira As String = ""
        Select Case parCodigo
            Case "00000"
                strBandeira = "Desconhecido"
            Case "00001"
                strBandeira = "Visa Crédito"
            Case "10001"
                strBandeira = "Ticket Voucher"
            Case "20001"
                strBandeira = "Maestro Débito"
            Case "00002"
                strBandeira = "Mastercard Crédito"
            Case "10002"
                strBandeira = "Visa Vale Voucher"
            Case "20002"
                strBandeira = "Visa Electron Débito"
            Case "00003"
                strBandeira = "Diners Crédito"
            Case "10003"
                strBandeira = "Sodexo Voucher"
            Case "20003"
                strBandeira = "Cabal Débito"
            Case "00004"
                strBandeira = "Amex Crédito"
            Case "10004"
                strBandeira = "Nutricash Voucher"
            Case "00005"
                strBandeira = "Sollo Crédito"
            Case "10005"
                strBandeira = "Greencard Voucher"
            Case "00006"
                strBandeira = "Sidecard Crédito"
            Case "10006"
                strBandeira = "Planvale Voucher"
            Case "00007"
                strBandeira = "Private Label Crédito"
            Case "10007"
                strBandeira = "Banquet Voucher"
            Case "20007"
                strBandeira = "Private Label Débito"
            Case "00008"
                strBandeira = "Redeshop Crédito"
            Case "10008"
                strBandeira = "Verocheque Voucher"
            Case "00009"
                strBandeira = "Pão de Açucar Crédito"
            Case "10009"
                strBandeira = "Sapore Voucher"
            Case "00010"
                strBandeira = "Fininvest Crédito"
            Case "10010"
                strBandeira = "BNB Clube Voucher"
            Case "00011"
                strBandeira = "JCB Crédito"
            Case "10011"
                strBandeira = "Valecard Voucher"
            Case "00012"
                strBandeira = "Hipercard Crédito"
            Case "10012"
                strBandeira = "Cabal Voucher"
            Case "20012"
                strBandeira = "Cabal Débito"
            Case "00013"
                strBandeira = "Aura Crédito"
            Case "10013"
                strBandeira = "Elo Voucher"
            Case "20013"
                strBandeira = "Elo Débito"
            Case "00014"
                strBandeira = "Losango Crédito"
            Case "00030"
                strBandeira = "Cabal Crédito"
            Case "00031"
                strBandeira = "Elo Crédito"
            Case "20032"
                strBandeira = "Elo Débito"
            Case "00033"
                strBandeira = "Policard Crédito"
            Case "20034"
                strBandeira = "Policard Débito"
            Case "00035"
                strBandeira = "Banescard Crédito"
            Case "20036"
                strBandeira = "Banescard Débito"
            Case "10037"
                strBandeira = "Sorocred Voucher"
            Case "20037"
                strBandeira = "Hipercard Débito"
            Case "00038"
                strBandeira = "Cetelem Crédito"
            Case "10039"
                strBandeira = "Valemulti Voucher"
            Case "10040"
                strBandeira = "Valefrota Voucher Combustível"
            Case "00041"
                strBandeira = "Sicredi Crédito"
            Case "20042"
                strBandeira = "Sicredi Débito"
            Case "00043"
                strBandeira = "Coopercred Crédito"
            Case "10044"
                strBandeira = "Coopercred Voucher"
            Case "00045"
                strBandeira = "A Vista Crédito"
            Case "10046"
                strBandeira = "Valefácil Voucher"
            Case "10047"
                strBandeira = "VR Voucher Refeição"
            Case "10048"
                strBandeira = "VR Voucher Alimentação"
            Case "10049"
                strBandeira = "VR Voucher Combustível"
            Case "10050"
                strBandeira = "VR Voucher Cultura"
            Case "10052"
                strBandeira = "Banrisul Voucher Cultura"
            Case "00057"
                strBandeira = "Credisystem Crédito"
            Case "00058"
                strBandeira = "Banpará Crédito"
            Case "20059"
                strBandeira = "Banpará Débito"
            Case "00060"
                strBandeira = "Amazoncard Crédito"
            Case "00061"
                strBandeira = "Yamada Crédito"
            Case "00062"
                strBandeira = "Goiascard Crédito"
            Case "00063"
                strBandeira = "Credpar Crédito"
            Case "00064"
                strBandeira = "Boticario Crédito"
            Case "00065"
                strBandeira = "Ascard Crédito"
            Case "00066"
                strBandeira = "Jetpar Crédito"
            Case "00067"
                strBandeira = "Maxxcard Crédito"
            Case "00068"
                strBandeira = "Garantido Crédito"
            Case "00069"
                strBandeira = "Amazon Prime Crédito"
            Case "00070"
                strBandeira = "CredZ Crédito"
            Case "10070"
                strBandeira = "VR Voucher Benefício"
            Case "00071"
                strBandeira = "Credishop Crédito"
            Case "10071"
                strBandeira = "Planvale Voucher Benefício"
            Case "20071"
                strBandeira = "Sorocred Débito"
            Case "10072"
                strBandeira = "Planvale Voucher Alimentação"
            Case "20072"
                strBandeira = "Maxxicard Débito"
            Case "00073"
                strBandeira = "Libercard Crédito"
            Case "10073"
                strBandeira = "Planvale Voucher Refeição"
            Case "20073"
                strBandeira = "Maxxicard Crédito"
            Case "10074"
                strBandeira = "Planvale Voucher Combustível"
            Case "20074"
                strBandeira = "Maxxicard Gift"
            Case "10075"
                strBandeira = "Planvale Voucher Farmácia"
            Case "20075"
                strBandeira = "Maxxicard Voucher Combustível"
            Case "10076"
                strBandeira = "Peela Gift"
            Case "10077"
                strBandeira = "Libercard Voucher"
            Case "00078"
                strBandeira = "Peela Crédito"
            Case "10079"
                strBandeira = "Up Voucher"
            Case "10080"
                strBandeira = "Up Voucher Combustível"
            Case "10081"
                strBandeira = "Up Voucher Cultura"
            Case "10082"
                strBandeira = "Elo Voucher Combustível"
            Case "10083"
                strBandeira = "VR Voucher"
            Case "00084"
                strBandeira = "Banrisul Crédito"
            Case "20085"
                strBandeira = "Banrisul Débito"
            Case "00086"
                strBandeira = "Verdecard Crédito"
            Case "00087"
                strBandeira = "Refeisul Crédito"
            Case "10088"
                strBandeira = "Refeisul Voucher Combustível"
            Case "10089"
                strBandeira = "Refeisul Voucher Alimentação"

        End Select

        Return strBandeira
    End Function
End Class