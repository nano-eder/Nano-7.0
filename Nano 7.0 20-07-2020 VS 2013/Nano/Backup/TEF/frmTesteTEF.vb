Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data
Imports Nano.clsFuncoes

Imports System.Threading
Public Class frmTesteTEF
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

    Dim bolProcesso As Boolean = False
    Dim strMensagem As String = ""
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub frmTesteTEF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolInicio = True
        Timer1.Start()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dataFiscal As String = Format(Date.Today, "yyyyMMdd")
        Dim horario As String = Format(My.Computer.Clock.LocalTime, "HHmmss")
        Dim operador As String = UserNano
        Dim restricoes As String = ""


        IniciaThreadBaixaCrystal()


    End Sub
    Private Sub BaixarCrystal()
        Venda(intCredDeb, strValor, cupomFiscal, dataFiscal, horario, operador, restricoes, intVezes, strNumTransacao, RetornoTEF)
    End Sub
    Private mThreadBaixarCrystal As Thread

    Public Sub IniciaThreadBaixaCrystal()
        mThreadBaixarCrystal = New Threading.Thread(AddressOf BaixarCrystal)
        mThreadBaixarCrystal.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If bolInicio = True Then
            Me.TextEdit1.Focus()
            bolInicio = False
            SimpleButton1_Click(sender, e)

        End If

        If bolProcesso = True Then

            Me.SimpleButton2_Click(sender, e)
            Me.bolProcesso = False
        End If
    End Sub
    Private Sub RotinaResultado(ByVal tipoCampo As Integer, ByVal buffer As Byte(), ByRef intRetorno As Integer)
        Dim mensagem As String = Encoding.UTF8.GetString(buffer)

        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))

        Select Case tipoCampo
            Case 1
                'System.Windows.Forms.MessageBox.Show("Finalizacao: [" + mensagem.ToString() + "]", "RotinaResultado")
                Exit Select

            Case 121
                ComprovanteTEF(0) = "Comprovante Cliente: " & vbLf + mensagem.ToString()
                'COMPROVANTE'
                'System.Windows.Forms.MessageBox.Show("Comprovante Cliente: " & vbLf + mensagem.ToString(), "RotinaResultado")
                Exit Select

            Case 122
                ComprovanteTEF(1) = "Comprovante Estabelecimento: " & vbLf + mensagem.ToString()
                'COMPROVANTE'
                'System.Windows.Forms.MessageBox.Show("Comprovante Estabelecimento: " & vbLf + mensagem.ToString(), "RotinaResultado")
                Exit Select

            Case 131
                'System.Windows.Forms.MessageBox.Show("Rede Destino: [" + mensagem.ToString() + "]", "RotinaResultado")
                Exit Select

            Case 132
                'System.Windows.Forms.MessageBox.Show("Tipo Cartao: [" + mensagem.ToString() + "]", "RotinaResultado")
                TipoCartao = Bandeira(mensagem.ToString())
                Exit Select
            Case 134
                NumTransacao = mensagem.ToString()
                Exit Select
            Case Else

                'System.Windows.Forms.MessageBox.Show("nTipoCampo: [" + tipoCampo.ToString() + "]" & vbLf & "Conteudo: [" + mensagem.ToString() + "]", "RotinaResultado")
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

        Dim mensagem As String = Encoding.UTF8.GetString(pDadosComando)

        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))

        If comando <> 23 Then
            nVezes = 0
        End If

        Select Case comando
            Case 1, 2, 3, 4
                Processando(mensagem.ToString())

                'System.Windows.Forms.MessageBox.Show("Mensagem Visor: [" + mensagem.ToString() + "]", "RotinaColeta")
                intRetorno = 0
                Exit Sub
            Case 11, 12, 13, 14

                Processando("")


                'System.Windows.Forms.MessageBox.Show("Apaga Visor: [" + comando.ToString() + "]", "RotinaColeta")
                intRetorno = 0
                Exit Sub
            Case 37
                Processando(mensagem.ToString())

                'System.Windows.Forms.MessageBox.Show("Coleta confirmacao no PinPad: [" + mensagem.ToString() + "]", "RotinaColeta", System.Windows.Forms.MessageBoxButtons.YesNo)
                intRetorno = 0
                Exit Sub
            Case 20
                Processando(mensagem.ToString())

                ' System.Windows.Forms.MessageBox.Show("Coleta Sim/Nao: [" + mensagem.ToString() + "]", "RotinaColeta", System.Windows.Forms.MessageBoxButtons.YesNo)
                intRetorno = 0
                Exit Sub
            Case 21
                Processando(mensagem.ToString())

                'System.Windows.Forms.MessageBox.Show("Menu: [" + mensagem.ToString() + "]", "RotinaColeta")

                intRetorno = 0
                Exit Sub
            Case 22
                Processando(mensagem.ToString())

                'System.Windows.Forms.MessageBox.Show("Obtem qualquer tecla: [" + mensagem.ToString() + "]", "RotinaColeta")
                intRetorno = 0
                Exit Sub
            Case 23
                System.Threading.Thread.Sleep(1000)

                If System.Math.Max(System.Threading.Interlocked.Increment(nVezes), nVezes - 1) > 30 Then
                    intRetorno = -1
                End If

                intRetorno = 0
                Exit Sub
            Case 30, 31, 32, 33, 34, 35, 38
                'System.Windows.Forms.MessageBox.Show("nComando: [" + comando.ToString() + "]" & vbLf & "TipoCampo: [" + tipoCampo.ToString() + "]", "RotinaColeta")
                intRetorno = 0
                Exit Sub
        End Select

        intRetorno = -1
    End Sub
    Private Shared Sub Cancelar()

        frmTEF.btnCancelar.Enabled = True
        frmTEF.btnCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

        Application.DoEvents()
        System.Threading.Thread.Sleep(40)
    End Sub

    Private Sub Venda(ByVal funcao As Integer, ByVal valor As String, ByVal cupomFiscal As String, _
    ByVal dataFiscal As String, ByVal horario As String, ByVal operador As String, _
    ByVal restricoes As String, ByVal parVezes As Integer, ByVal parNSU As String, ByRef intRetorno As String)
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

        Dim retorno As Integer = clsTEF.IniciaFuncaoSiTefInterativo(funcao, _valor, _cupomFiscal, _dataFiscal, _horario, _operador, _
         _restricoes)
        'Dim retorno As Integer = IniciaFuncaoSiTefInterativo(2, "1,00", "12345", "20170920", "160300", "Rubens", "")
        While retorno = 10000
            retorno = clsTEF.ContinuaFuncaoSiTefInterativo(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer.Length, _
             0)

            If comando = 0 Then
                RotinaResultado(tipoCampo, buffer, continua)
            Else
                RotinaColeta(comando, tipoCampo, tamanhoMinimo, tamanhoMaximo, buffer, buffer, continua)
                Select Case comando

                    Case 1, 2, 3, 4
                        Dim mensagem As String = Encoding.UTF8.GetString(buffer)
                        mensagem = mensagem.Substring(0, mensagem.IndexOf(ControlChars.NullChar))
                        If mensagem.Contains("Insira ou passe ou aproxime o cartao na leitora") = True Then
                            Cancelar()

                        End If
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

                        If mensagem.Contains("Forneca o numero do documento a ser cancelado") = True Then
                            Dim buffer2 As Byte() = Encoding.ASCII.GetBytes(parNSU & Convert.ToString(vbNullChar))
                            buffer = New Byte(19999) {}
                            Dim I As Integer
                            For I = 0 To buffer2.Length - 1
                                buffer(I) = buffer2(I)
                            Next
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
                        End If
                End Select

            End If
        End While

        intRetorno = retorno

        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.lblProcesso2.Text = ""
        Me.lblProcesso2.Text = strMensagem
    End Sub
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