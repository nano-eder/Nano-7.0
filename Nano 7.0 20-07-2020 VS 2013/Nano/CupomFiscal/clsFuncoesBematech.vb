Imports Nano.clsFuncoes
Imports System.IO
Imports System.Text
Public Class clsFuncoesBematech

    Public Shared Function VerificaRetornoImpressora(ByVal Label As String, ByVal RetornoFuncao As String, ByVal TituloJanela As String) As Boolean
        Dim ACK As Integer
        Dim ST1 As Integer
        Dim ST2 As Integer
        Dim ST3 As Integer

        Dim RetornaMensagem As Integer
        Dim StringRetorno As String = ""
        Dim ValorRetorno As String
        Dim RetornoStatus As Integer
        Dim Mensagem As String = ""

        VerificaRetornoImpressora = False

        If Retorno = 0 Then
            MsgBox("Erro de comunicação com a impressora.", vbOKOnly + vbCritical, TituloJanela)
            Exit Function

        ElseIf Retorno = 1 Or Retorno = -27 Then
            If SATFiscal = True Then
                RetornoStatus = Bematech_FI_RetornoImpressoraMFD(ACK, ST1, ST2, ST3)
                ValorRetorno = Str(ACK) & "," & Str(ST1) & "," & Str(ST2) & "," & Str(ST3)

            Else
                If RetornoEstendidoHabilitado = True Then
                    RetornoStatus = Bematech_FI_RetornoImpressoraMFD(ACK, ST1, ST2, ST3)
                    ValorRetorno = Str(ACK) & "," & Str(ST1) & "," & Str(ST2) & "," & Str(ST3)

                Else
                    RetornoStatus = Bematech_FI_RetornoImpressora(ACK, ST1, ST2)
                    ValorRetorno = Str(ACK) & "," & Str(ST1) & "," & Str(ST2)
                End If
            End If
        


            If Label <> "" And RetornoFuncao <> "" Then
                RetornaMensagem = 1
            End If

            If ACK = 21 Then
                MsgBox("Status da Impressora: 21" & vbCr & vbLf & "Comando não executado", vbOKOnly + vbInformation, TituloJanela)
                Exit Function
            End If

            If (ST1 <> 0 Or ST2 <> 0) Then
                If (ST1 >= 128) Then
                    StringRetorno = "Fim de Papel" & vbCr
                    ST1 = ST1 - 128
                End If

                If (ST1 >= 64) Then
                    StringRetorno = StringRetorno & "Pouco Papel" & vbCr
                    ST1 = ST1 - 64
                    Return True
                    Exit Function
                End If

                If (ST1 >= 32) Then
                    StringRetorno = StringRetorno & "Erro no relógio" & vbCr
                    ST1 = ST1 - 32
                End If

                If (ST1 >= 16) Then
                    StringRetorno = StringRetorno & "Impressora em erro" & vbCr
                    ST1 = ST1 - 16
                End If

                If (ST1 >= 8) Then
                    StringRetorno = StringRetorno & "Primeiro dado do comando não foi Esc" & vbCr
                    ST1 = ST1 - 8
                End If

                If (ST1 >= 4) Then
                    StringRetorno = StringRetorno & "Comando inexistente" & vbCr
                    ST1 = ST1 - 4
                End If

                If (ST1 >= 2) Then
                    StringRetorno = StringRetorno & "Cupom fiscal aberto" & vbCr
                    ST1 = ST1 - 2
                End If

                If (ST1 >= 1) Then
                    StringRetorno = StringRetorno & "Número de parâmetros inválido no comando" & vbCr
                    ST1 = ST1 - 1
                End If

                If (ST2 >= 128) Then
                    StringRetorno = "Tipo de Parâmetro de comando inválido" & vbCr
                    ST2 = ST2 - 128
                End If

                If (ST2 >= 64) Then
                    StringRetorno = StringRetorno & "Memória fiscal lotada" & vbCr
                    ST2 = ST2 - 64
                End If

                If (ST2 >= 32) Then
                    StringRetorno = StringRetorno & "Erro na CMOS" & vbCr
                    ST2 = ST2 - 32
                End If

                If (ST2 >= 16) Then
                    StringRetorno = StringRetorno & "Alíquota não programada" & vbCr
                    ST2 = ST2 - 16
                End If

                If (ST2 >= 8) Then
                    StringRetorno = StringRetorno & "Capacidade de alíquota programáveis lotada" & vbCr
                    ST2 = ST2 - 8
                End If

                If (ST2 >= 4) Then
                    StringRetorno = StringRetorno & "Cancelamento não permitido" & vbCr
                    ST2 = ST2 - 4
                End If

                If (ST2 >= 2) Then
                    StringRetorno = StringRetorno & "CGC/IE do proprietário não programados" & vbCr
                    ST2 = ST2 - 2
                End If

                If (ST2 >= 1) Then
                    StringRetorno = StringRetorno & "Comando não executado" & vbCr
                    ST2 = ST2 - 1
                End If

                If RetornaMensagem Then
                    Mensagem = "Status da Impressora: " & ValorRetorno & _
                           vbCr & vbLf & StringRetorno & vbCr & vbLf & _
                           Label & RetornoFuncao
                Else
                    Mensagem = "Status da Impressora: " & ValorRetorno & _
                       vbCr & vbLf & StringRetorno
                End If

                MsgBox(Mensagem, vbOKOnly + vbInformation, TituloJanela)
                Exit Function
            End If 'fim do ST1 <> 0 and ST2 <> 0

            If RetornaMensagem Then
                Mensagem = Label & RetornoFuncao
            End If

            If Mensagem <> "" Then
                MsgBox(Mensagem, vbOKOnly + vbInformation, TituloJanela)
            End If

            Return True

            Exit Function
        ElseIf Retorno = -1 Then
            MsgBox("Erro de execução da função.", vbOKOnly + vbCritical, TituloJanela)
            Exit Function

        ElseIf Retorno = -2 Then
            MsgBox("Parâmetro inválido na função.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -3 Then
            MsgBox("Alíquota não programada.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -4 Then
            MsgBox("O arquivo de inicialização BemaFI32.ini não foi encontrado no diretório default. " + vbCr + "Por favor, copie esse arquivo para o diretório de sistema do Windows." + vbCr + "Se for o Windows 95 ou 98 é o diretório 'System' se for o Windows NT é o diretório 'System32'.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -5 Then
            MsgBox("Erro ao abrir a porta de comunicação.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -6 Then
            MsgBox("Impressora desligada ou cabo de comunicação desconectado.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -7 Then
            MsgBox("Banco não encontrado no arquivo BemaFI32.ini.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -8 Then
            MsgBox("Erro ao criar ou gravar no arquivo status.txt ou retorno.txt.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -18 Then
            MsgBox("Não foi possível abrir arquivo INTPOS.001 !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -19 Then
            MsgBox("Parâmetro diferentes !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -20 Then
            MsgBox("Transação cancelada pelo Operador !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -21 Then
            MsgBox("A Transação não foi aprovada !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -22 Then
            MsgBox("Não foi possível terminal a Impressão !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -23 Then
            MsgBox("Não foi possível terminal a Operação !", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -24 Then
            MsgBox("Forma de pagamento não programada.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -25 Then
            MsgBox("Totalizador não fiscal não programado.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -26 Then
            MsgBox("Transação já realizada.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function

        ElseIf Retorno = -28 Then
            MsgBox("Não há dados para serem impressos.", vbOKOnly + vbExclamation, TituloJanela)
            Exit Function
        End If

        Return True

    End Function


    Public Shared Function ImprimirCupom(ByVal parCodOrdem As String, ByVal parDAV As String) As Boolean




        Dim dtPed As DataTable = CarregarDataTable("SELECT ValDesc, ValAcre, CodProdInterno, Produto, ValorUnitario, Qtd, ValorTotal, UM, Total.CodCli, Total.CodConfig, Total.Total, Total.Troco, Total.Recebido, Total.Data, Pedido.CodProd, CPFCliente as CPF, Cliente.Nome, Pedido.Devolvido, Total.NFP FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.TipoItens <> 'CONSUMO' and Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig)
       

        If dtPed.Rows.Count = 0 Then Exit Function

        Dim strCliente As String = dtPed.Rows.Item(0).Item("Nome").ToString
        Dim strCPF As String = dtPed.Rows.Item(0).Item("CPF").ToString
        Dim bolNFP As Boolean = dtPed.Rows.Item(0).Item("NFP")

        If bolNFP = False Then
            strCPF = ""
        End If

        Dim strTipoDesc As String = "D"
        Dim strValDesc As String = "0"
        Dim dblValDesc As Double = dtPed.Rows.Item(0).Item("ValDesc").ToString
        If dblValDesc <= 0 Then
            dblValDesc = dtPed.Rows.Item(0).Item("ValAcre").ToString
            If dblValDesc > 0 Then
                strTipoDesc = "A"
                strValDesc = dblValDesc.ToString("0.00")
            End If
        Else
            strValDesc = dblValDesc.ToString("0.00")
        End If


        If VerificaImpressora() = False Then Exit Function

        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strFormasPagamento As String = ""
            MeiosDePagamento = ""
            Dim strFor As New StringBuilder(" ", 573)
            strFor.Length = 573
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("169", strFor)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            If DarumaFiscal.iRetorno <> 1 Then Exit Function


            strFormasPagamento = strFor.ToString.Trim.Replace(";", ",")

            Dim strPaga As String = strFormasPagamento.Substring(0, 300).Replace("ÿ", "")
            Dim intPag As Integer = strPaga.Length / 15
            Dim J As Integer
            'For J = 0 To intPag - 1
            '    If J = 0 Then
            '        MeiosDePagamento = strPaga.Substring(J * 15, 15).Trim
            '    Else
            '        MeiosDePagamento &= "," & strPaga.Substring(J * 15, 15).Trim
            '    End If
            'Next

            Dim strVal As String = strFormasPagamento.Substring(300, 260)

            For J = 0 To intPag - 1
                If J = 0 Then
                    MeiosDePagamento = strVal.Substring(J * 13, 13).Trim

                Else
                    MeiosDePagamento &= "," & strVal.Substring(J * 13, 13).Trim
                End If
            Next

            MeiosDePagamento &= "|" & strFormasPagamento.Substring(560, 13)
        End If






        Dim dblValorDevolvido As Double

        If TipoImpressoraFiscal = "DARUMA" Then
            DarumaFiscal.iRetorno = DarumaFiscal.iCFAbrir_ECF_Daruma(strCPF, "", "")
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            If DarumaFiscal.iRetorno <> 1 Then Exit Function
        Else
            Retorno = Bematech_FI_AbreCupom(strCPF)
            If VerificaRetornoImpressora("", "", "Abertura de Cupom") = False Then Exit Function


            If Retorno <> 1 Then Exit Function
        End If

        Try
            Dim L As Integer
            Dim dblQtd As Double
            Dim dblValorTotal As Double = 0
            Dim dblValorAproximado As Double = 0
            For L = 0 To dtPed.Rows.Count - 1
                Dim strCod, strProd, strUM As String
                Dim dblUni, dblTot As Double

                strCod = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                strProd = dtPed.Rows.Item(L).Item("Produto").ToString
                dblUni = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                dblQtd = dtPed.Rows.Item(L).Item("Qtd").ToString
                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString
                strUM = dtPed.Rows.Item(L).Item("UM").ToString
                Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")
                If dblUni >= 0 Then


                    If bolDevolvido = True Then
                        dblValorDevolvido += dblTot
                    End If
                    dblValorTotal += dblTot

                    Dim dtImp As DataTable = CarregarDataTable("SELECT ICMS, Tributacao, NCM, OrigemICMS FROM ImpostoProduto where CodProd = " & dtPed.Rows.Item(L).Item("CodProd").ToString)

                    Dim strTrib As String = dtImp.Rows.Item(0).Item("Tributacao").ToString
                    Dim dblICMS As Double = dtImp.Rows.Item(0).Item("ICMS")
                    Dim strICMS As String = dblICMS.ToString("0.00")
                    Dim strNCM As String = dtImp.Rows.Item(0).Item("NCM").ToString
                    Dim strOrigemICMS As String = dtImp.Rows.Item(0).Item("OrigemICMS").ToString

                    If DeOlhoNoImposto = True Then
                        Dim dblValAprox As Double = 0
                        Dim dtIBPT As DataTable = CarregarDataTable("SELECT AliqNac, AliqImp FROM TabelaIBPT where NCM = '" & strNCM & "'")
                        If dtIBPT.Rows.Count > 0 Then
                            Dim dblAliqNac As Double = dtIBPT.Rows.Item(0).Item("AliqNac").ToString
                            Dim dblAliqImp As Double = dtIBPT.Rows.Item(0).Item("AliqImp").ToString

                            Select Case strOrigemICMS
                                Case "0", "3", "4", "5"
                                    dblValAprox = (dblTot * dblAliqNac) / 100
                                Case Else
                                    dblValAprox = (dblTot * dblAliqImp) / 100
                            End Select
                        Else
                            dblValAprox = 0
                        End If
                        dblValorAproximado += dblValAprox
                    End If


                    Select Case strTrib
                        Case "I"
                            strICMS = "II"
                        Case "F"
                            strICMS = "FF"
                        Case "N"
                            strICMS = "NN"
                        Case Else
                            If TipoImpressoraFiscal = "DARUMA" Then
                                strICMS = strICMS.Replace(",", "").Replace(".", "")
                                If strICMS.Length = 3 Then
                                    strICMS = "0" & strICMS
                                End If
                                strICMS = "T" & strICMS
                            End If
                    End Select

                    'If VerificaImpressora() = False Then Exit Function
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.iCFVender_ECF_Daruma(strICMS, dblQtd.ToString("0.000"), dblUni.ToString("0.00"), "D%", "0", strCod, "UN", strProd)
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                        If DarumaFiscal.iRetorno <> 1 Then
                            ErroCupom(parCodOrdem)
                            Exit Function
                        End If
                    Else
                        Retorno = Bematech_FI_VendeItemDepartamento(strCod, strProd, strICMS, dblUni.ToString("0.000"), dblQtd.ToString("0.000"), "0", "0", "01", "UN")
                        If VerificaRetornoImpressora("", "", "Emissão de Cupom Fiscal") = False Then Exit Function
                        If Retorno <> 1 Then
                            ErroCupom(parCodOrdem)
                            Exit Function
                        End If

                    End If
                End If
            Next
            ' If TipoDesconto = "ITENS"
            If TipoImpressoraFiscal = "DARUMA" Then
                If TipoDesconto = "ITENS" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.iCFTotalizarCupom_ECF_Daruma("D%", "0")
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    DarumaFiscal.iRetorno = DarumaFiscal.iCFTotalizarCupom_ECF_Daruma(strTipoDesc & "$", strValDesc.Replace(",", "").Replace(".", ""))
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                End If
               

                If DarumaFiscal.iRetorno <> 1 Then
                    ErroCupom(parCodOrdem)
                    Exit Function
                End If
            Else
                If TipoDesconto = "ITENS" Then
                    Retorno = Bematech_FI_IniciaFechamentoCupom("A", "%", "0000")

                Else
                    Retorno = Bematech_FI_IniciaFechamentoCupom(strTipoDesc, "$", strValDesc.Replace(",", "").Replace(".", ""))
                End If

                If Retorno <> 1 Then
                    ErroCupom(parCodOrdem)
                    Exit Function
                End If
            End If

            Dim P As Integer
            Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor, FormaPagamento FROM Recebimento where Valor > 0 and CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

            If dtPag.Rows.Count > 0 Then

                For P = 0 To dtPag.Rows.Count - 1
                    Dim dblValor As Double
                    Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString

                    Dim strFormaPag As String = dtPag.Rows.Item(P).Item("FormaPagamento").ToString

                    If strFormaPag = "A VISTA" Then

                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString

                        End If
                        If strPag = "CRÉDITO CLIENTE" Then
                            strPag = "TROCA"
                        End If
                        If TipoImpressoraFiscal = "DARUMA" Then

                            DarumaFiscal.iRetorno = DarumaFiscal.iCFEfetuarPagamento_ECF_Daruma(strPag, dblValor.ToString("0.00"), "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                            If DarumaFiscal.iRetorno <> 1 Then
                                ErroCupom(parCodOrdem)
                                Exit Function
                            End If
                        Else
                            If NomeEmpresa.ToUpper.Contains("CAVALAO") = True Then
                                If strPag = "DINHEIRO" Then
                                    strPag = "Dinheiro"
                                End If
                            End If
                            Retorno = Bematech_FI_EfetuaFormaPagamento(strPag, dblValor.ToString("0.00"))
                            If Retorno <> 1 Then

                                ErroCupom(parCodOrdem)
                                Exit Function
                            End If

                        End If
                    Else
                        Dim dtRec As DataTable = CarregarDataTable("SELECT convert(varchar(10),Vencimento,103) as Vencimento, ValorParcela FROM ContaReceber where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                        If dtRec.Rows.Count > 0 Then
                            Dim A As Integer
                            For A = 0 To dtRec.Rows.Count - 1
                                Dim strVenc As String = dtRec.Rows.Item(A).Item("Vencimento").ToString
                                Dim dblValorParc As Double
                                If dtRec.Rows.Item(A).Item("ValorParcela").ToString <> "" Then
                                    dblValorParc = dtRec.Rows.Item(A).Item("ValorParcela").ToString
                                End If

                                If TipoImpressoraFiscal = "DARUMA" Then
                                    DarumaFiscal.iRetorno = DarumaFiscal.iCFEfetuarPagamento_ECF_Daruma(strPag, dblValor.ToString("0.00"), "Vencimento em " & strVenc)
                                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                                    If DarumaFiscal.iRetorno <> 1 Then
                                        ErroCupom(parCodOrdem)
                                        Exit Function
                                    End If
                                Else
                                    Retorno = Bematech_FI_EfetuaFormaPagamentoDescricaoForma(strPag, dblValorParc.ToString("0.00"), "Vencimento em " & strVenc)
                                    If Retorno <> 1 Then
                                        ErroCupom(parCodOrdem)
                                        Exit Function
                                    End If
                                End If
                            Next
                        Else
                            If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                                dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                            End If
                        End If

                        'If VerificaImpressora() = False Then Exit Function

                        If TipoImpressoraFiscal = "DARUMA" Then

                            DarumaFiscal.iRetorno = DarumaFiscal.iCFEfetuarPagamento_ECF_Daruma(strPag, dblValor.ToString("0.00"), "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                            If DarumaFiscal.iRetorno <> 1 Then
                                ErroCupom(parCodOrdem)
                                Exit Function
                            End If
                        Else
                            Retorno = Bematech_FI_EfetuaFormaPagamento(strPag, dblValor.ToString("0.00"))
                            If Retorno <> 1 Then
                                ErroCupom(parCodOrdem)
                                Exit Function
                            End If
                        End If
                    End If



                Next
            End If

            Dim dtTroca As DataTable = CarregarDataTable("SELECT sum(Valor) as Valor FROM Devolucao where Motivo like '%NA VENDA Nº " & parCodOrdem & "%'")
            If dtTroca.Rows.Count > 0 Then
                If dtTroca.Rows.Item(0).Item("Valor").ToString <> "" Then
                    dblValorDevolvido = dtTroca.Rows.Item(0).Item("Valor").ToString
                    If TipoImpressoraFiscal = "DARUMA" Then

                        DarumaFiscal.iRetorno = DarumaFiscal.iCFEfetuarPagamento_ECF_Daruma("TROCA", dblValorDevolvido.ToString("0.00"), "")
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                        If DarumaFiscal.iRetorno <> 1 Then
                            ErroCupom(parCodOrdem)
                            Exit Function
                        End If
                    Else
                        Retorno = Bematech_FI_EfetuaFormaPagamento("TROCA", dblValorDevolvido.ToString("0.00"))
                        If Retorno <> 1 Then
                            ErroCupom(parCodOrdem)
                            Exit Function
                        End If
                    End If
                End If
               
            End If
            Dim strTexto As String = " " & vbCrLf
            If DeOlhoNoImposto = True Then
                If TipoDesconto = "TOTAL" Then
                    dblValorTotal = dtPed.Rows.Item(0).Item("Total").ToString
                End If
                Dim dblPerAproximado As Double = (dblValorAproximado / dblValorTotal) * 100

                If PorValorAproximado <> "" Then
                    dblPerAproximado = PorValorAproximado
                   
                    dblValorAproximado = (dblPerAproximado * dblValorTotal) / 100
                End If

                If dblPerAproximado > 0 Then
                    strTexto &= "Val Aprox dos Tributos R$ " & dblValorAproximado.ToString("0.00") & " (" & dblPerAproximado.ToString("0.00") & "%) Fonte: IBPT" & vbCrLf
                End If
            End If
            If SimplesNacional = True Then
                strTexto &= "ICMS a ser recolhido conforme LC 123/2006 - Simples Nacional." & vbCrLf
            End If
            If parDAV <> "" Then
                strTexto &= "DAV: " & parDAV & vbCrLf & "Venda: " & parCodOrdem & vbCrLf & "Obrigado, volte sempre !!!"
            Else
                strTexto &= "Venda: " & parCodOrdem & vbCrLf & "Obrigado, volte sempre !!!"
            End If

            'If VerificaImpressora() = False Then Exit Function
            If TipoImpressoraFiscal = "DARUMA" Then

                DarumaFiscal.iRetorno = DarumaFiscal.iCFEncerrar_ECF_Daruma("0", strTexto)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                If DarumaFiscal.iRetorno <> 1 Then
                    ErroCupom(parCodOrdem)
                    Exit Function
                End If
            Else
                Retorno = Bematech_FI_TerminaFechamentoCupom(strTexto)
                If Retorno <> 1 Then
                    ErroCupom(parCodOrdem)
                    Exit Function
                End If
            End If



            If parDAV <> "" Then
                Atualizar("UPDATE Total Set StatusDAV = 'Faturado' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                SalvarOperacao("ValorLiquido", dblValorTotal.ToString("0.00"))
                SalvarCupomFiscal(parCodOrdem)
            End If

        Catch ex As Exception

            SalvarCupomFiscal(parCodOrdem)
            If MsgBox("Erro ao imprimir o cupom." & vbCrLf & "Deseja realizar o cancelamento deste cupom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CancelarCupom(False, "")
            End If

        End Try


    End Function

    Private Shared Function ErroCupom(ByVal parCodOrdem As String) As Boolean
        SalvarCupomFiscal(parCodOrdem)
        If MsgBox("Erro ao imprimir o cupom." & vbCrLf & "Deseja realizar o cancelamento deste cupom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CancelarCupom(False, "")
        End If
        Return True
    End Function

    Public Shared Function SalvarOperacao(ByVal parTipo As String, ByVal parValor As String) As Boolean
        If TesteConexao() = False Then Exit Function
        Inserir("INSERT INTO Operador (Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) VALUES " & _
        "('" & Login & "','" & parTipo & "'," & Num(parValor) & ",'" & My.Computer.Clock.LocalTime & "'," & _
        "" & CodConfig & "," & CodConfigECF & ")")
    End Function

    Public Shared Function Espaco(ByVal parCampo As String, ByVal parTamanho As Integer, ByVal parNumerico As Boolean) As String

        Dim I As Integer

        Dim strCampo As String = ""
        For I = 0 To parCampo.Length - 1
            Dim strChar As Char = parCampo.Substring(I, 1)

            If Char.IsLetter(strChar) = False Then
                If Char.IsPunctuation(strChar) = False Then
                    If Char.IsNumber(strChar) = False Then
                        If Char.IsSeparator(strChar) = True Then
                            strCampo &= strChar
                        End If
                    Else
                        strCampo &= strChar
                    End If
                Else
                    strCampo &= strChar
                End If
            Else
                strCampo &= strChar
            End If
        Next
        Dim intQ As Integer
        parCampo = strCampo.Trim

        If parCampo.Length < parTamanho Then
            intQ = parTamanho - parCampo.Length
            If parNumerico = True Then
                For I = 0 To intQ - 1
                    parCampo = "0" & parCampo
                Next
            Else
                For I = 0 To intQ - 1
                    parCampo = parCampo & " "
                Next
            End If

        Else
            If parNumerico = True Then
                Dim intCampo As Long = parCampo
                parCampo = intCampo
                intQ = parTamanho - parCampo.Length
                For I = 0 To intQ - 1
                    parCampo = "0" & parCampo
                Next
            End If
        End If
        Return parCampo
    End Function

    Public Shared Function FormatarValor(ByVal parValor As String) As String
        If parValor = "" Then
            Return ""
            Exit Function
        End If

        Dim intValor As Integer = parValor
        Dim strValor As String = ""
        Dim I As Integer
        Dim intQ As Integer = intValor.ToString.Length - 2

        Select Case intQ
            Case 0
                strValor = "0," & intValor
            Case -1
                strValor = "0,0" & intValor
            Case Else
                For I = 0 To intValor.ToString.Length - 1
                    Dim strVal As String = intValor.ToString.Substring(I, 1)
                    If I = intQ Then
                        strValor &= ","
                    End If
                    strValor &= strVal

                Next

        End Select

        Return strValor

    End Function
    Public Shared Function SalvarReducaoZ() As Boolean
        Try

            If VerificaImpressora() = False Then Exit Function

            If TipoImpressoraFiscal = "DARUMA" Then
                Dim I As Integer
                Dim sDados As New StringBuilder(" ", 1209)
                sDados.Length = 1209
                DarumaFiscal.iRetorno = DarumaFiscal.rRetornarDadosReducaoZ_ECF_Daruma(sDados)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                Dim strtt As String = sDados.ToString
                Dim vet As Array = Split(sDados.ToString.Trim, ";")

                Dim strDataHora As New StringBuilder(" ", 14)
                strDataHora.Length = 14
                DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("172", strDataHora)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                Dim strData As String = ""
                Dim strHora As String = ""

                For I = 0 To strDataHora.Length - 2
                    Dim strD As String = strDataHora.ToString.Substring(I, 2)

                    Select Case I
                        Case 0
                            strData = strD
                        Case 2
                            strData &= "/" & strD
                        Case 4
                            strData &= "/" & strD
                        Case 6
                            strData &= strD
                        Case 8
                            strHora = strD

                        Case 10
                            strHora &= ":" & strD
                        Case 12
                            strHora &= ":" & strD
                    End Select

                    I += 1
                Next
                Dim dtData As Date = strData

                Dim strCRZ As String = vet(28)
                Dim strCOO As String = vet(30)
                Dim strCRO As String = vet(27)

                Dim strDataEmissao As String = dtData
                Dim strHoraEmissao As String = strHora

                For I = 0 To vet(0).ToString.Length - 2
                    Dim strD As String = vet(0).ToString.Substring(I, 2)

                    Select Case I
                        Case 0
                            strData = strD
                        Case 2
                            strData &= "/" & strD
                        Case 4
                            strData &= "/" & strD
                        Case 6
                            strData &= strD
                        Case 8
                            strHora = strD

                        Case 10
                            strHora &= ":" & strD
                        Case 12
                            strHora &= ":" & strD
                    End Select
                    I += 1
                Next
                Dim dtDataMov As Date = strData
                Dim strDataMov As String = dtDataMov

                DarumaFiscal.iRetorno = DarumaFiscal.rGerarMapaResumo_ECF_Daruma()
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                Dim strMapa As String = LerArquivo("C:\NFP DARUMA\MAPA_RESUMO.txt", False)
                Dim reader As New StreamReader("C:\NFP DARUMA\MAPA_RESUMO.txt")

                Dim linha As String = String.Empty
                Dim vetLinha As Array = Nothing
                Dim B As Integer = 0

                Dim strVendaBruta As String = ""
                Dim strCancelamentoICMS As String = FormatarValor(vet(5).ToString)
                Dim strCancelamentoISSQN As String = FormatarValor(vet(6).ToString)
                Dim strDescontoICMS As String = FormatarValor(vet(4).ToString)
                Dim strDescontoISSQN As String = FormatarValor(vet(5).ToString)
                Dim strIsencaoICMS As String = FormatarValor(vet(12).ToString)
                Dim strIsencaoISSQN As String = FormatarValor(vet(18).ToString)
                Dim strIncidenciaICMS As String = FormatarValor(vet(14).ToString)
                Dim strIncidenciaISSQN As String = FormatarValor(vet(20).ToString)
                Dim strTributacaoICMS As String = FormatarValor(vet(10).ToString)
                Dim strTributacaoISSQN As String = FormatarValor(vet(16).ToString)
                Dim strTotalizador As String = vet(9).ToString

                Dim strAliquota As String = vet(26).ToString

                Dim intAli As Integer = strAliquota.Length / 5
                Dim strT As String = ""
                For I = 0 To intAli - 1
                    Dim strAli As String = strAliquota.Substring(I * 5, 5)
                    If strAli <> "00000" Then
                        Dim strTot As String = strTotalizador.Substring(I * 14, 14)

                        strT &= strAli.Substring(1, 4) & "|" & FormatarValor(strTot) & ";"
                    Else
                        Exit For
                    End If

                Next
                strTotalizador = strT
                Do
                    linha = reader.ReadLine()
                    If linha <> "" Then
                        vetLinha = Split(linha, ":")
                        If B < 17 Then
                            If linha.Contains("Venda Bruta") Then
                                strVendaBruta = vetLinha(1).ToString.Trim
                            End If
                        Else
                            If linha.Contains("0000") Then
                                Exit Do
                            End If
                            Dim vetAliq As Array = Split(vetLinha(0), ".")

                            strTotalizador &= vetAliq(0) & "|" & vetLinha(1).ToString.Trim & ";"
                        End If
                        B += 1
                    End If
                    If (linha Is Nothing) Then
                        Exit Do
                    End If
                Loop

                Inserir("INSERT INTO R2 (CodUser, CRZ, COO, CRO, DataMovimentacao, DataEmissao, HoraEmissao, VendaBruta, " & _
                "CodConfig, CodConfigECF) VALUES (" & CodUser & ",'" & Espaco(strCRZ, 6, False).Trim & "'," & _
                "'" & Espaco(strCOO, 6, False).Trim & "','" & Espaco(strCRO, 6, False).Trim & "','" & strDataMov & "'," & _
                "'" & strDataEmissao & "','" & strHoraEmissao & "'," & Num(strVendaBruta.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")

                Dim strCodR2 As String = GerarCodigo("R2", "Codigo", CodConfig) - 1


                Dim vetTotalizadores As Array = Split(strTotalizador, ";")


                For I = 0 To vetTotalizadores.Length - 1
                    If vetTotalizadores(I).ToString <> "" Then
                        Dim vetTot As Array = Split(vetTotalizadores(I), "|")
                        Dim strTot As String = Format(I + 1, "00") & "T" & vetTot(0)

                        Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                        "VALUES (" & strCodR2 & ",'" & strTot & "'," & Num(vetTot(1).ToString.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                    End If
                Next


                If strTributacaoICMS <> "" And strTributacaoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'F1'," & Num(strTributacaoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIsencaoICMS <> "" And strIsencaoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'I1'," & Num(strIsencaoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIncidenciaICMS <> "" And strIncidenciaICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'N1'," & Num(strIncidenciaICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strTributacaoISSQN <> "" And strTributacaoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'FS1'," & Num(strTributacaoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIsencaoISSQN <> "" And strIsencaoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Is1'," & Num(strIsencaoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIncidenciaISSQN <> "" And strIncidenciaISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'NS1'," & Num(strIncidenciaISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strDescontoICMS <> "" And strDescontoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'DT'," & Num(strDescontoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strDescontoISSQN <> "" And strDescontoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'DS'," & Num(strDescontoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strCancelamentoICMS <> "" And strCancelamentoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Can-T'," & Num(strCancelamentoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strCancelamentoISSQN <> "" And strCancelamentoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Can-S'," & Num(strCancelamentoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If

                GerarArquivoMovimentacao("Automatico", strDataMov, strDataMov)

            Else
                Dim I As Integer
                Dim sDados As String = Space(1279)

                Retorno = Bematech_FI_DadosUltimaReducaoMFD(sDados)

                Dim vet As Array = Split(sDados, ",")

                Dim strValord As String = Space(19)

                Retorno = Bematech_FI_VendaBruta(strValord)


                Dim sDataHora As String = Space(13)
                Retorno = Bematech_FI_DataHoraUltimoDocumentoMFD(sDataHora)
                Dim strData As String = ""
                Dim strHora As String = ""

                For I = 0 To sDataHora.Length - 2
                    Dim strD As String = sDataHora.Substring(I, 2)

                    Select Case I
                        Case 0
                            strData = strD
                        Case 2
                            strData &= "/" & strD
                        Case 4
                            strData &= "/" & strD
                        Case 6
                            strHora = strD
                        Case 8
                            strHora &= ":" & strD
                        Case 10
                            strHora &= ":" & strD
                    End Select

                    I += 1
                Next
                Dim dtData As Date = strData

                Dim strCRZ As String = vet(2)
                Dim strCOO As String = vet(3)
                Dim strCRO As String = vet(1)

                Dim strDataEmissao As String = dtData
                Dim strHoraEmissao As String = strHora

                For I = 0 To vet(36).ToString.Length - 2
                    Dim strD As String = vet(36).ToString.Substring(I, 2)

                    Select Case I
                        Case 0
                            strData = strD
                        Case 2
                            strData &= "/" & strD
                        Case 4
                            strData &= "/" & strD
                        Case 6
                            strHora = strD
                        Case 8
                            strHora &= ":" & strD
                        Case 10
                            strHora &= ":" & strD
                    End Select

                    I += 1
                Next
                Dim dtDataMov As Date = strData
                Dim strDataMov As String = dtDataMov

                Retorno = Bematech_FI_MapaResumoMFD()

                Dim strMapa As String = LerArquivo("C:\NFP\Retorno.txt", False)
                Dim reader As New StreamReader("C:\NFP\Retorno.txt")

                Dim linha As String = String.Empty
                Dim vetLinha As Array = Nothing
                Dim B As Integer = 0

                Dim strVendaBruta As String = ""
                Dim strCancelamentoICMS As String = ""
                Dim strCancelamentoISSQN As String = ""
                Dim strDescontoICMS As String = ""
                Dim strDescontoISSQN As String = ""
                Dim strIsencaoICMS As String = ""
                Dim strIsencaoISSQN As String = ""
                Dim strIncidenciaICMS As String = ""
                Dim strIncidenciaISSQN As String = ""
                Dim strTributacaoICMS As String = ""
                Dim strTributacaoISSQN As String = ""
                Dim strTotalizador As String = ""

                Do
                    linha = reader.ReadLine()
                    If linha <> "" Then
                        vetLinha = Split(linha, ":")
                        If B < 17 Then
                            If linha.Contains("Venda Bruta") Then
                                strVendaBruta = vetLinha(1).ToString.Trim
                            ElseIf linha.Contains("Cancelamentos de ICMS") Then
                                strCancelamentoICMS = vetLinha(1).ToString.Trim
                            ElseIf linha.Contains("Cancelamentos de ISSQN") Then
                                strCancelamentoISSQN = vetLinha(1).ToString.Trim
                            ElseIf linha.Contains("Descontos de ICMS") Then
                                strDescontoICMS = vetLinha(1).ToString.Trim
                            ElseIf linha.Contains("Descontos de ISSQN") Then
                                strDescontoISSQN = vetLinha(1).ToString.Trim
                            ElseIf linha.Contains("Isen") Then
                                If linha.Contains("ICMS") Then
                                    strIsencaoICMS = vetLinha(1).ToString.Trim
                                Else
                                    strIsencaoISSQN = vetLinha(1).ToString.Trim
                                End If
                            ElseIf linha.Contains("Incid") Then
                                If linha.Contains("ICMS") Then
                                    strIncidenciaICMS = vetLinha(1).ToString.Trim
                                Else
                                    strIncidenciaISSQN = vetLinha(1).ToString.Trim
                                End If
                            ElseIf linha.Contains("Substitui") Then
                                If linha.Contains("ICMS") Then
                                    strTributacaoICMS = vetLinha(1).ToString.Trim
                                Else
                                    strTributacaoISSQN = vetLinha(1).ToString.Trim
                                End If
                            End If
                        Else
                            If linha.Contains("0000") Then
                                Exit Do
                            End If
                            Dim vetAliq As Array = Split(vetLinha(0), ".")

                            strTotalizador &= vetAliq(0) & "|" & vetLinha(1).ToString.Trim & ";"
                        End If
                        B += 1
                    End If
                    If (linha Is Nothing) Then
                        Exit Do
                    End If
                Loop

                Inserir("INSERT INTO R2 (CodUser, CRZ, COO, CRO, DataMovimentacao, DataEmissao, HoraEmissao, VendaBruta, " & _
                "CodConfig, CodConfigECF) VALUES (" & CodUser & ",'" & Espaco(strCRZ, 6, False).Trim & "'," & _
                "'" & Espaco(strCOO, 6, False).Trim & "','" & Espaco(strCRO, 6, False).Trim & "','" & strDataMov & "'," & _
                "'" & strDataEmissao & "','" & strHoraEmissao & "'," & Num(strVendaBruta.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")

                Dim strCodR2 As String = GerarCodigo("R2", "Codigo", CodConfig) - 1


                Dim vetTotalizadores As Array = Split(strTotalizador, ";")


                For I = 0 To vetTotalizadores.Length - 1
                    If vetTotalizadores(I).ToString <> "" Then
                        Dim vetTot As Array = Split(vetTotalizadores(I), "|")
                        Dim strTot As String = Format(I + 1, "00") & "T" & vetTot(0)

                        Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                        "VALUES (" & strCodR2 & ",'" & strTot & "'," & Num(vetTot(1).ToString.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                    End If
                Next


                If strTributacaoICMS <> "" And strTributacaoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'F1'," & Num(strTributacaoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIsencaoICMS <> "" And strIsencaoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'I1'," & Num(strIsencaoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIncidenciaICMS <> "" And strIncidenciaICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'N1'," & Num(strIncidenciaICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strTributacaoISSQN <> "" And strTributacaoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'FS1'," & Num(strTributacaoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIsencaoISSQN <> "" And strIsencaoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Is1'," & Num(strIsencaoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strIncidenciaISSQN <> "" And strIncidenciaISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'NS1'," & Num(strIncidenciaISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strDescontoICMS <> "" And strDescontoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'DT'," & Num(strDescontoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strDescontoISSQN <> "" And strDescontoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'DS'," & Num(strDescontoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strCancelamentoICMS <> "" And strCancelamentoICMS <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Can-T'," & Num(strCancelamentoICMS.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If
                If strCancelamentoISSQN <> "" And strCancelamentoISSQN <> "0,00" Then
                    Inserir("INSERT INTO R3 (CodR2, TotalizadorParcial, ValorAcumulado, CodConfig, CodConfigECF) " & _
                    "VALUES (" & strCodR2 & ",'Can-S'," & Num(strCancelamentoISSQN.Replace(".", "")) & "," & CodConfig & "," & CodConfigECF & ")")
                End If

                GerarArquivoMovimentacao("Automatico", strDataMov, strDataMov)

            End If


        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function SalvarCupomFiscal(ByVal parCodOrdem As String) As Boolean

        If VerificaImpressora() = False Then Exit Function
        Dim strContadorCupom As String = ""
        Dim strContadorCupomFiscal As String = ""
        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strCOO As New StringBuilder(" ", 7)
            strCOO.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("26", strCOO)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strContadorCupom = strCOO.ToString.Trim

            Dim strCCF As New StringBuilder(" ", 7)
            strCCF.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("30", strCCF)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strContadorCupomFiscal = strCCF.ToString.Trim
        Else
            Dim strNumCupom As String = Space(7)
            Retorno = Bematech_FI_ContadorCupomFiscalMFD(strNumCupom)
            strContadorCupomFiscal = Espaco(strNumCupom, 6, False).Trim
            Dim strCOO As String = Space(7)
            Retorno = Bematech_FI_NumeroCupom(strCOO)
            strContadorCupom = Espaco(strCOO, 6, False).Trim
        End If



        Inserir("INSERT INTO R4 (CodOrdem, CodUser, CCF, COO, DataEmissao, Cancelado, CodConfig, CodConfigECF) " & _
        "VALUES (" & parCodOrdem & "," & CodUser & ",'" & strContadorCupomFiscal & "','" & strContadorCupom & "'," & _
        "'" & Date.Today & "','N'," & CodConfig & "," & CodConfigECF & ")")


        SalvarFormasDePagamento(strContadorCupom, strContadorCupomFiscal, "")



    End Function

    Public Shared Function SalvarFormasDePagamento(ByVal parCOO As String, ByVal parCCF As String, ByVal parGNF As String) As Boolean
        Dim I As Integer

        Dim strFormasPagamento As String = ""
        If TipoImpressoraFiscal = "DARUMA" Then

            Dim strFor As New StringBuilder(" ", 573)
            strFor.Length = 573
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("169", strFor)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strFormasPagamento = strFor.ToString.Trim.Replace(";", ",")

            Dim strPag As String = strFormasPagamento.Substring(0, 300).Replace("ÿ", "")
            Dim intPag As Integer = strPag.Length / 15
            Dim vetPag(intPag - 1) As String

            For I = 0 To intPag - 1
                vetPag(I) = strPag.Substring(I * 15, 15).Trim
            Next

            Dim vetMeioDePag As Array = Split(MeiosDePagamento, "|")
            Dim strTrocoGeral As String = vetMeioDePag(1)
            vetMeioDePag = Split(vetMeioDePag(0), ",")
            Dim strVal As String = strFormasPagamento.Substring(300, 260)
            Dim vetVal(intPag - 1) As String
            Dim vetValor(intPag - 1) As String
            Dim strFormasPag As String = ""
            For I = 0 To intPag - 1
                vetVal(I) = strVal.Substring(I * 13, 13).Trim
                vetValor(I) = CInt(vetVal(I)) - CInt(vetMeioDePag(I))
                If CInt(vetValor(I)) > 0 Then
                    If strFormasPag = "" Then
                        strFormasPag &= Espaco(vetPag(I), 16, False) & Espaco(vetValor(I), 14, True)

                    Else
                        strFormasPag &= "," & Espaco(vetPag(I), 16, False) & Espaco(vetValor(I), 14, True)

                    End If
                End If
            Next

            Dim strTro As String = strFormasPagamento.Substring(560, 13)
            Dim strTroco As String = CInt(strTro) - CInt(strTrocoGeral)
            If CInt(strTroco) > 0 Then
                If strFormasPag = "" Then
                    strFormasPag &= Espaco("Troco", 16, False) & Espaco(strTroco, 14, True)

                Else
                    strFormasPag &= "," & Espaco("Troco", 16, False) & Espaco(strTroco, 14, True)

                End If

            End If

            Dim vetFormaPag As Array = Split(strFormasPag, ",")

            For I = 0 To vetFormaPag.Length - 1
                If vetFormaPag(I).ToString = "" Then
                    Exit For
                End If
                Dim strPaga As String = vetFormaPag(I).ToString.Substring(0, 16)
                Dim intValor As Integer = vetFormaPag(I).ToString.Substring(16, 14)
                Dim strValor As String = FormatarValor(intValor)

                If strValor <> "" And strValor <> "0,00" Then
                    Inserir("INSERT INTO R7 (CodUser, COO, CCF, GNF, Pagamento, ValorPago, Estorno, ValorEstorno, DataEmissao, " & _
                    "CodConfig, CodConfigECF) VALUES (" & CodUser & ", '" & Espaco(parCOO, 6, False).Trim & "'," & _
                    "'" & Espaco(parCCF, 6, False).Trim & "','" & Espaco(parGNF, 6, False).Trim & "','" & strPaga.Trim & "'," & _
                    "" & Num(strValor) & ",'N',0,'" & Date.Today & "'," & CodConfig & "," & CodConfigECF & ")")
                End If
            Next

        Else
            Dim strFor As String = Space(3017)
            Retorno = Bematech_FI_VerificaFormasPagamentoMFD(strFor)
            strFormasPagamento = strFor


            Dim vetFormaPag As Array = Split(strFormasPagamento, ",")

            For I = 0 To vetFormaPag.Length - 1
                If vetFormaPag(I).ToString = "" Then
                    Exit For
                End If
                Dim strPag As String = vetFormaPag(I).ToString.Substring(0, 16)
                Dim intValor As Integer = vetFormaPag(I).ToString.Substring(30, 14)
                Dim strValor As String = FormatarValor(intValor)

                If strValor <> "" And strValor <> "0,00" Then
                    Inserir("INSERT INTO R7 (CodUser, COO, CCF, GNF, Pagamento, ValorPago, Estorno, ValorEstorno, DataEmissao, " & _
                    "CodConfig, CodConfigECF) VALUES (" & CodUser & ", '" & Espaco(parCOO, 6, False).Trim & "'," & _
                    "'" & Espaco(parCCF, 6, False).Trim & "','" & Espaco(parGNF, 6, False).Trim & "','" & strPag.Trim & "'," & _
                    "" & Num(strValor) & ",'N',0,'" & Date.Today & "'," & CodConfig & "," & CodConfigECF & ")")
                End If
            Next
        End If


    End Function
    Public Shared Function SalvarDocumento(ByVal parTipo As String) As Boolean
        If TipoImpressoraFiscal = "DARUMA" Then

            Dim strCOO As New StringBuilder(" ", 7)
            strCOO.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("26", strCOO)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strGNF As New StringBuilder(" ", 7)
            strGNF.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("28", strGNF)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strCDC As New StringBuilder(" ", 7)
            strCDC.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("45", strCDC)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)



            Dim strGRG As String = ""
            If parTipo <> "RG" Then
                Dim strGRG1 As New StringBuilder(" ", 7)
                strGRG1.Length = 7
                DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("33", strGRG1)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                strGRG = strGRG1.ToString.Trim
            End If




            Dim strDataHora As New StringBuilder(" ", 14)
            strDataHora.Length = 14
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("172", strDataHora)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strData As String = ""
            Dim strHora As String = ""
            Dim I As Integer
            For I = 0 To strDataHora.Length - 2
                Dim strD As String = strDataHora.ToString.Trim.Substring(I, 2)

                Select Case I
                    Case 0
                        strData = strD
                    Case 2
                        strData &= "/" & strD
                    Case 4
                        strData &= "/" & strD
                    Case 6
                        strData &= strD
                    Case 8
                        strHora = strD

                    Case 10
                        strHora &= ":" & strD
                    Case 12
                        strHora &= ":" & strD
                End Select

                I += 1
            Next
            Dim dtData As Date = strData

            Inserir("INSERT INTO R6 (CodUser, GNF, COO, GRG, CDC, Denominacao, Data, Hora, CodConfig, CodConfigECF) " & _
            "VALUES (" & CodUser & ",'" & Espaco(strGNF.ToString.Trim, 6, False).Trim & "','" & Espaco(strCOO.ToString.Trim, 6, False).Trim & "'," & _
            "'" & Espaco(strGRG.ToString.Trim, 6, False).Trim & "','','" & parTipo & "','" & dtData & "','" & strHora & "'," & CodConfig & "," & CodConfigECF & ")")
            If parTipo <> "RG" Then
                SalvarFormasDePagamento(strCOO.ToString.Trim, "", strGNF.ToString.Trim)
            End If
        Else
            Dim strCOO As String = Space(7)
            Retorno = Bematech_FI_NumeroCupom(strCOO)

            Dim strGNF As String = Space(7)
            Retorno = Bematech_FI_NumeroOperacoesNaoFiscais(strGNF)

            Dim strCDC As String = Space(5)
            Retorno = Bematech_FI_ContadorComprovantesCreditoMFD(strCDC)

            Dim strGRG As String = Space(7)

            If parTipo = "RG" Then
                strGRG = ""
            Else
                Retorno = Bematech_FI_ContadorRelatoriosGerenciaisMFD(strGRG)
            End If

            Dim strDataHora As String = Space(13)
            Retorno = Bematech_FI_DataHoraUltimoDocumentoMFD(strDataHora)
            Dim strData As String = ""
            Dim strHora As String = ""
            Dim I As Integer
            For I = 0 To strDataHora.Length - 2
                Dim strD As String = strDataHora.Substring(I, 2)

                Select Case I
                    Case 0
                        strData = strD
                    Case 2
                        strData &= "/" & strD
                    Case 4
                        strData &= "/" & strD
                    Case 6
                        strHora = strD
                    Case 8
                        strHora &= ":" & strD
                    Case 10
                        strHora &= ":" & strD
                End Select

                I += 1
            Next
            Dim dtData As Date = strData

            Inserir("INSERT INTO R6 (CodUser, GNF, COO, GRG, CDC, Denominacao, Data, Hora, CodConfig, CodConfigECF) " & _
            "VALUES (" & CodUser & ",'" & Espaco(strGNF, 6, False).Trim & "','" & Espaco(strCOO, 6, False).Trim & "'," & _
            "'" & Espaco(strGRG, 6, False).Trim & "','','" & parTipo & "','" & dtData & "','" & strHora & "'," & CodConfig & "," & CodConfigECF & ")")
            If parTipo <> "RG" Then
                SalvarFormasDePagamento(strCOO, "", strGNF)
            End If
        End If

        Return True
    End Function
    Public Shared Function AssinarArquivo(ByVal parCaminho As String) As Boolean
        If TipoImpressoraFiscal = "DARUMA" Then

            DarumaFiscal.iRetorno = DarumaFiscal.eRSAAssinarArquivo_ECF_Daruma(parCaminho, "C:\NANO\Chave")
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

        Else
            Retorno = setLibType(0)
            Dim cRegistroEAD As String = Space(256)
            Dim cNomeArquivo As String = parCaminho
            Retorno = generateEAD(cNomeArquivo, ChavePublica, ChavePrivada, cRegistroEAD, 1)
            Retorno = validateFile(cNomeArquivo, ChavePublica, ChavePrivada)



            Dim cMD5 As String = Space(33)
            Retorno = md5FromFile(cNomeArquivo, cMD5)
        End If


        Return True


    End Function

    Public Shared Function VerificarAberturaFechamento(ByVal parFechamento As Boolean) As Boolean

        'DarumaFiscal.iRetorno = DarumaFiscal.iReducaoZ_ECF_Daruma("", "")
        'DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Dim strDataAtual As String = Format(Date.Today, "dd/MM/yy").Replace("/", "")
        Dim dt As DataTable = CarregarDataTable("SELECT Operador, Tipo, convert(Varchar(10),Data,103) as Data FROM Operador " & _
        "where CodConfigECF = " & CodConfigECF & " and CodConfig = " & CodConfig & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'Saida' and Tipo <> 'ValorLiquido' order by Codigo Desc")
        Dim bolMsg As Boolean = False
        If dt.Rows.Count > 0 Then

            Dim strOperador As String = dt.Rows.Item(0).Item("Operador").ToString
            Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString
            Dim dtData As Date = dt.Rows.Item(0).Item("Data").ToString
            Dim strData As String = Format(dtData, "dd/MM/yy").Replace("/", "")
            If strTipo = "Entrada" Then
                If dtData < Date.Today Then
                    If MsgBox("Movimento aberto para o dia " & dtData & "." & vbCrLf & "Deseja realizar o fechamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim strDataMovimento As String = ""
                        If TipoImpressoraFiscal = "DARUMA" Then


                            Dim strDataMov As New StringBuilder(" ", 1164)
                            strDataMov.Length = 1164
                            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("140", strDataMov)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                            strDataMovimento = strDataMov.ToString.Trim.Substring(0, 8)
                            Dim I As Integer
                            Dim strDt As String = ""
                            For I = 0 To strDataMovimento.Length - 2
                                Dim strD As String = strDataMovimento.ToString.Trim.Substring(I, 2)

                                Select Case I
                                    Case 0
                                        strDt = strD
                                    Case 2
                                        strDt &= "/" & strD
                                    Case 4
                                        strDt &= "/" & strD
                                    Case 6
                                        strDt &= strD

                                End Select

                                I += 1
                            Next

                            strDataMovimento = Format(CDate(strDt), "ddMMyy")
                        Else
                            Dim strDataMov As String = Space(7)
                            Retorno = Bematech_FI_DataMovimentoUltimaReducaoMFD(strDataMov)
                            strDataMovimento = strDataMov.Substring(0, 6)

                        End If

                        If strDataMovimento = strData Then

                            SalvarOperacao("Fechamento", "0")
                            SaidaOperador()
                            Return True
                            Exit Function
                        End If

                        parFechamento = True
                    Else
                        Return True
                        Exit Function
                    End If
                    bolMsg = True
                End If
                If parFechamento = True Then
                    If bolMsg = False Then
                        If MsgBox("Deseja realmente realizar o fechamento do dia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            SalvarOperacao("Fechamento", "0")
                            If TipoImpressoraFiscal = "DARUMA" Then
                                DarumaFiscal.iRetorno = DarumaFiscal.iReducaoZ_ECF_Daruma("", "")
                                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                            Else
                                Retorno = Bematech_FI_FechamentoDoDia()
                            End If

                            SalvarReducaoZ()
                            Return True
                            Exit Function
                        End If
                    Else
                        SalvarOperacao("Fechamento", "0")
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iReducaoZ_ECF_Daruma("", "")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_FechamentoDoDia()
                        End If
                        SalvarReducaoZ()
                        Return True
                        Exit Function
                    End If

                End If
            Else
                If parFechamento = True Then
                    MsgBox("Não existe movimento aberto." & vbCrLf & "Não foi possivel realizar o fechamento do dia!", MsgBoxStyle.Information)
                End If
                Return False
                Exit Function
            End If
        End If

        Return False
    End Function
    Public Shared Function SaidaOperador() As Boolean
        Dim I As Integer
        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))
        Dim dtSaida As DataTable = CarregarDataTable("SELECT Tipo, Data FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " order by Codigo Desc")
        Dim strDataEntrada As String = ""
        Dim strDataSaida As String = ""
        Dim bolEntrada As Boolean = False
        Dim intQtdSeq As Integer
        For I = 0 To dtSaida.Rows.Count - 1
            Dim strTipo As String = dtSaida.Rows.Item(I).Item("Tipo").ToString
            Dim strDataOperacao As String = dtSaida.Rows.Item(I).Item("Data").ToString
            strDataSaida = dtSaida.Rows.Item(0).Item("Data").ToString
            If strTipo = "Entrada" Then
                If bolEntrada = False Then
                    strDataEntrada = strDataOperacao
                    bolEntrada = True
                End If
            Else
                intQtdSeq += 1
            End If
        Next

        strData = String.Format("Data >= '{0:dd/MM/yyyy HH:mm:ss}' AND Data <= '{1:dd/MM/yyyy HH:mm:ss}'", strDataEntrada, strDataSaida)

        Dim dt As DataTable = CarregarDataTable("SELECT Tipo, sum(Entrada) as Valor FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and Operador = '" & Login & "' and CodConfig = " & CodConfig & " group by Tipo")

        Dim strEntrada As String = "0,00"
        Dim strSaida As String = "0,00"
        Dim strSangria As String = "0,00"
        Dim strSuprimento As String = "0,00"
        Dim strValorLiquido As String = "0,00"

        Dim dblCaixa As Double
        For I = 0 To dt.Rows.Count - 1
            Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

            Select Case strTipo
                Case "Entrada"
                    strEntrada = strValor
                    dblCaixa += strValor
                Case "Saida", "Fechamento"
                    strSaida = strValor
                Case "Sangria"
                    strSangria = strValor
                    dblCaixa -= strValor
                Case "Suprimento"
                    strSuprimento = strValor
                    dblCaixa += strValor
                Case "ValorLiquido"
                    strValorLiquido = strValor
                    dblCaixa += strValor
            End Select
        Next


        Dim dblDiferenca As Double = strSaida - dblCaixa

        If TipoImpressoraFiscal = "DARUMA" Then

            DarumaFiscal.iRetorno = DarumaFiscal.iRGAbrirIndice_ECF_Daruma(1)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_AbreRelatorioGerencialMFD("01")

        End If

        Dim strTexto As String = ""
        Dim strTraco As String = "------------------------------------------------"
        strTexto = strTraco & vbCrLf
        strTexto &= Dir("RESUMO DE CAIXA DO OPERADOR " & Login, 41) & Esq("SEQ: " & Format(intQtdSeq, "00"), 7) & vbCrLf
        strTexto &= strTraco & vbCrLf
        strTexto &= Dir(strDataEntrada, 20) & Dir("Entrada:", 16) & Esq(strEntrada, 12) & vbCrLf

        strTexto = VerificaTamnhoTexto(strTexto)

        strTexto &= Dir("", 20) & Dir("Suprimentos:", 16) & Esq(strSuprimento, 12) & vbCrLf
        strTexto &= Dir("", 20) & Dir("Sangrias:", 16) & Esq(strSangria, 12) & vbCrLf

        strTexto = VerificaTamnhoTexto(strTexto)

        strTexto &= Dir("", 20) & Dir("Venda Líquida:", 16) & Esq(strValorLiquido, 12) & vbCrLf
        strTexto &= strTraco & vbCrLf

        strTexto = VerificaTamnhoTexto(strTexto)

        strTexto &= Dir("", 20) & Dir("Total Caixa:", 16) & Esq(dblCaixa.ToString("0.00"), 12) & vbCrLf
        strTexto &= Dir(strDataSaida, 20) & Dir("Saída:", 16) & Esq(strSaida, 12) & vbCrLf

        strTexto = VerificaTamnhoTexto(strTexto)

        strTexto &= Dir("", 20) & Dir("Diferença:", 16) & Esq(dblDiferenca.ToString("0.00"), 12) & vbCrLf

        If TipoImpressoraFiscal = "DARUMA" Then

            DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strTexto)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strTexto)


        End If


        If TipoImpressoraFiscal = "DARUMA" Then

            DarumaFiscal.iRetorno = DarumaFiscal.iRGFechar_ECF_Daruma()
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_FechaRelatorioGerencial()


        End If

        SalvarDocumento("RG")
    End Function
    Public Shared Function VerificaTamnhoTexto(ByVal parTexto As String) As String
        If parTexto.Length > 300 Then
            If TipoImpressoraFiscal = "DARUMA" Then
                DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(parTexto)
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Else
                Retorno = Bematech_FI_UsaRelatorioGerencialMFD(parTexto)
            End If

            parTexto = ""
        End If
        Return parTexto
    End Function

    Public Shared Function GerarArquivoMovimentacao(ByVal parTipo As String, ByVal parDataInicial As String, ByVal parDataFinal As String) As Boolean
        Dim strTexto As String = ""
        Dim strCNPJ As String
        strCNPJ = CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "").Trim
        Dim dtDataSB As Date


        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strDataSB As String = ""
            Dim strHoraSB As String = ""
            Dim strDSB As String = DataSBECF.Replace(" ", "")
            Dim J As Integer
            For J = 0 To strDSB.Length - 2

                Dim strD As String = strDSB.Substring(J, 2)

                Select Case J
                    Case 0
                        strDataSB = strD
                    Case 2
                        strDataSB &= "/" & strD
                    Case 4
                        strDataSB &= "/" & strD
                    Case 6
                        strDataSB &= strD
                    Case 8
                        strHoraSB = strD

                    Case 10
                        strHoraSB &= ":" & strD
                    Case 12
                        strHoraSB &= ":" & strD
                End Select



                J += 1
            Next
            dtDataSB = strDataSB & " " & strHoraSB
        Else

            'Dim strdataUsuario As String = Space(21)
            'Dim strdataSWBasico As String = Space(21)
            'Dim strMFAdicional As String = Space(2)
            'Retorno = Bematech_FI_DataHoraGravacaoUsuarioSWBasicoMFAdicional(strdataUsuario, strdataSWBasico, strMFAdicional)
            'DataSBECF = strdataSWBasico

            dtDataSB = DataSBECF
        End If

        Dim strData As String = Format(dtDataSB, "yyyyMMdd")
        Dim strHora As String = Format(dtDataSB, "HHMMss")

        strTexto = "R01" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(TipoECF, 7, False)
        strTexto &= Espaco(MarcaECF, 20, False) & Espaco(ModeloECF, 20, False) & Espaco(VersaoSBECF, 10, False) & strData & strHora & Espaco(NumeroEcfECF, 3, True)
        strTexto &= strCNPJ & Espaco(IEECF.Replace(".", "").Trim, 14, False) & EraSystemsCNPJ.Replace(".", "").Replace("/", "").Replace("-", "").Trim & Espaco("", 14, False)
        strTexto &= Espaco(EraSystemsIM, 14, True) & Espaco(EraSystemsRazao, 40, False) & Espaco(NomePAFECF, 40, False) & Espaco(VersaoPAFECF, 10, False)


        Dim dtInicial As Date = parDataInicial
        Dim dtFinal As Date = parDataFinal

        Dim strDataInicial As String = Format(dtInicial, "yyyyMMdd")
        Dim strDataFinal As String = Format(dtInicial, "yyyyMMdd")


        strTexto &= Espaco("", 32, True) & strDataInicial & strDataFinal & Espaco("", 4, False) & vbCrLf

        Dim strData1 As String = String.Format("DataMovimentacao >= '{0:dd/MM/yyyy}' AND DataMovimentacao <= '{1:dd/MM/yyyy}'", dtInicial, dtFinal)

        Dim dtR2 As DataTable = CarregarDataTable("SELECT R2.Codigo, CodUser, CRZ, COO, CRO, DataMovimentacao, DataEmissao, " & _
        "HoraEmissao, VendaBruta, TotalizadorParcial, ValorAcumulado FROM R2 left join R3 on R2.Codigo = R3.CodR2 and R2.CodConfigECF = R3.CodConfigECF " & _
        "where R2.CodConfigECF = " & CodConfigECF & " and " & strData1 & " and R2.CodConfig = " & CodConfig & " and R3.CodConfig = " & CodConfig)
        Dim I As Integer
        Dim strTextoR3 As String = ""
        Dim strCodR2 As String = ""
        For I = 0 To dtR2.Rows.Count - 1
            Dim strCodigo As String = dtR2.Rows.Item(I).Item("Codigo").ToString

            Dim strCodUser As String = dtR2.Rows.Item(I).Item("CodUser").ToString
            Dim strCRZ As String = dtR2.Rows.Item(I).Item("CRZ").ToString
            Dim strCOO As String = dtR2.Rows.Item(I).Item("COO").ToString
            Dim strCRO As String = dtR2.Rows.Item(I).Item("CRO").ToString
            Dim dtDataMov As Date = dtR2.Rows.Item(I).Item("DataMovimentacao")
            Dim dtDataEmi As Date = dtR2.Rows.Item(I).Item("DataEmissao") & " " & dtR2.Rows.Item(I).Item("HoraEmissao").ToString
            Dim strVendaBruta As String = dtR2.Rows.Item(I).Item("VendaBruta").ToString

            Dim strDataMov As String = Format(dtDataMov, "yyyyMMdd")
            Dim strDataEmi As String = Format(dtDataEmi, "yyyyMMdd")
            Dim strHoraEmi As String = Format(dtDataEmi, "HHMMss")

            If strCodigo <> strCodR2 Then
                strTexto &= "R02" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
                strTexto &= Espaco(strCodUser, 2, True) & Espaco(strCRZ, 6, True) & Espaco(strCOO, 6, True) & Espaco(strCRO, 6, True)
                strTexto &= strDataMov & strDataEmi & strHoraEmi & Espaco(strVendaBruta.Replace(",", "").Replace(".", ""), 14, True) & " " & vbCrLf
                strCodR2 = strCodigo
            End If

            Dim strTotalizador As String = dtR2.Rows.Item(I).Item("TotalizadorParcial").ToString
            Dim strValorAcu As String = dtR2.Rows.Item(I).Item("ValorAcumulado").ToString

            strTextoR3 &= "R03" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
            strTextoR3 &= Espaco(strCodUser, 2, True) & Espaco(strCRZ, 6, True) & Espaco(strTotalizador, 7, False) & Espaco(strValorAcu.Replace(",", "").Replace(".", ""), 13, True) & vbCrLf
        Next

        strData1 = String.Format("DataEmissao >= '{0:dd/MM/yyyy}' AND DataEmissao <= '{1:dd/MM/yyyy}'", dtInicial, dtFinal)

        Dim dtR4 As DataTable = CarregarDataTable("SELECT R4.CodOrdem, CodUser, CCF, COO, DataEmissao, Cancelado, Total, ValDesc, CPF, Nome, CodProd, " & _
        "CodProdInterno, Produto, Qtd, UM, Convert(Numeric(15,2),ValorUnitario) as ValorUnitario, Convert(Numeric(15,2),ValorTotal) as ValorTotal " & _
        "FROM ((R4 left join Total on R4.CodOrdem = Total.CodOrdem and R4.CodConfig = Total.CodConfig) left join Cliente on Total.CodCli = Cliente.Codigo) " & _
        "left join Pedido on Total.CodOrdem = Pedido.CodOrdem and Pedido.CodConfig = Total.CodConfig where CodConfigECF = " & CodConfigECF & " and " & strData1 & " and R4.Codconfig = " & CodConfig)

        Dim strTextoR4 As String = ""
        Dim strTextoR5 As String = ""
        Dim strCodigoPed As String = ""
        Dim A As Integer = 0
        For I = 0 To dtR4.Rows.Count - 1
            Dim strCodOrdem As String = dtR4.Rows.Item(I).Item("CodOrdem").ToString
            Dim strCodUser As String = dtR4.Rows.Item(I).Item("CodUser").ToString
            Dim strCCF As String = dtR4.Rows.Item(I).Item("CCF").ToString
            Dim strCOO As String = dtR4.Rows.Item(I).Item("COO").ToString
            Dim dtDataEmi As Date = dtR4.Rows.Item(I).Item("DataEmissao")
            Dim strCancelado As String = dtR4.Rows.Item(I).Item("Cancelado")
            Dim strDataEmi As String = Format(dtDataEmi, "yyyyMMdd")


            Dim strCliente As String = dtR4.Rows.Item(I).Item("Nome").ToString
            If dtR4.Rows.Item(I).Item("Nome").ToString = "CONSUMIDOR" Then
                strCliente = ""
            End If
            Dim strCpf As String = dtR4.Rows.Item(I).Item("CPF").ToString


            Dim dblTotal As Double = dtR4.Rows.Item(I).Item("Total").ToString
            Dim dblValDesc As Double = dtR4.Rows.Item(I).Item("ValDesc").ToString
            Dim strValorTotal As String = dtR4.Rows.Item(I).Item("Total").ToString
            If dblValDesc > 0 Then
                strValorTotal = dblTotal + dblValDesc
            End If
            If strCodOrdem <> strCodigoPed Then
                strTextoR4 &= "R04" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
                strTextoR4 &= Espaco(strCodUser, 2, True) & Espaco(strCCF, 6, True) & Espaco(strCOO, 6, True) & strDataEmi
                strTextoR4 &= Espaco(dblTotal.ToString.Replace(",", "").Replace(".", ""), 14, True) & Espaco(dblValDesc.ToString.Replace(",", "").Replace(".", ""), 13, True)
                strTextoR4 &= "V" & Espaco("0", 13, True) & "V" & Espaco(strValorTotal.Replace(",", "").Replace(".", ""), 14, True) & strCancelado
                strTextoR4 &= Espaco("0", 13, True) & "D" & Espaco(strCliente, 40, False) & Espaco(strCpf.Replace(".", "").Replace("-", "").Replace("/", "").Trim, 14, True) & vbCrLf
                strCodigoPed = strCodOrdem
            End If

            Dim strCodProd As String = dtR4.Rows.Item(I).Item("CodProd").ToString
            Dim strCodProdInterno As String = dtR4.Rows.Item(I).Item("CodProdInterno").ToString
            Dim strProduto As String = dtR4.Rows.Item(I).Item("Produto").ToString
            Dim strUM As String = dtR4.Rows.Item(I).Item("UM").ToString
            Dim strQtd As String = dtR4.Rows.Item(I).Item("Qtd").ToString
            Dim strValorUnitario As String = dtR4.Rows.Item(I).Item("ValorUnitario").ToString
            Dim strValorTotalProduto As String = dtR4.Rows.Item(I).Item("ValorTotal").ToString

            If strCodOrdem = strCodigoPed Then
                A += 1
            Else
                A = 1
            End If
            Dim strTrib As String = "I"
            Dim strIPPT As String = "T"
            Dim strIAT As String = "T"
            Dim dtImp As DataTable = CarregarDataTable("SELECT Tributacao, IPPT FROM ImpostoProduto where CodProd = " & strCodProd)
            If dtImp.Rows.Count > 0 Then
                strTrib = dtImp.Rows.Item(0).Item("Tributacao").ToString
                strIPPT = dtImp.Rows.Item(0).Item("IPPT").ToString
            End If
            strTextoR5 &= "R05" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
            strTextoR5 &= Espaco(strCodUser, 2, True) & Espaco(strCOO, 6, True) & Espaco(strCCF, 6, True) & Espaco(A, 3, True)
            strTextoR5 &= Espaco(strCodProdInterno, 14, False) & Espaco(strProduto, 100, False) & Espaco(strQtd.Replace(",", "").Replace(".", ""), 7, True)
            strTextoR5 &= Espaco(strUM, 3, False) & Espaco(strValorUnitario.Replace(",", "").Replace(".", ""), 8, True) & Espaco("0", 8, True)
            strTextoR5 &= Espaco("0", 8, True) & Espaco(strValorTotalProduto.Replace(",", "").Replace(".", ""), 14, True)
            strTextoR5 &= Espaco(strTrib, 7, False) & "N" & Espaco("0", 7, True) & Espaco("0", 13, True) & Espaco("0", 13, True) & strIAT
            strTextoR5 &= strIPPT & "32" & vbCrLf

        Next


        strData1 = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", dtInicial, dtFinal)

        Dim dtR6 As DataTable = CarregarDataTable("SELECT CodUser, GNF, COO, GRG, CDC, Denominacao, Data, Hora FROM R6 where CodConfigECF = " & CodConfigECF & " and " & strData1 & " and CodConfig = " & CodConfig)
        Dim strTextoR6 As String = ""
        For I = 0 To dtR6.Rows.Count - 1

            Dim strCodUser As String = dtR6.Rows.Item(I).Item("CodUser").ToString
            Dim strGNF As String = dtR6.Rows.Item(I).Item("GNF").ToString
            Dim strCOO As String = dtR6.Rows.Item(I).Item("COO").ToString
            Dim strGRG As String = dtR6.Rows.Item(I).Item("GRG").ToString
            Dim strCDC As String = dtR6.Rows.Item(I).Item("CDC").ToString
            Dim strDenominacao As String = dtR6.Rows.Item(I).Item("Denominacao").ToString
            Dim dtData As Date = dtR6.Rows.Item(I).Item("Data")
            Dim strHoraR6 As String = dtR6.Rows.Item(I).Item("Hora")
            Dim strDataEmi As String = Format(dtData, "yyyyMMdd")

            strTextoR6 &= "R06" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
            strTextoR6 &= Espaco(strCodUser, 2, True) & Espaco(strCOO, 6, True) & Espaco(strGNF, 6, True) & Espaco(strGRG, 6, True)
            strTextoR6 &= Espaco(strCDC, 4, True) & strDenominacao & strDataEmi & strHoraR6.Replace(":", "") & vbCrLf

        Next

        strData1 = String.Format("DataEmissao >= '{0:dd/MM/yyyy}' AND DataEmissao <= '{1:dd/MM/yyyy}'", dtInicial, dtFinal)

        Dim dtR7 As DataTable = CarregarDataTable("SELECT CodUser, COO, CCF, GNF, Pagamento, ValorPago, Estorno, ValorEstorno FROM R7 where CodConfigECF = " & CodConfigECF & " and " & strData1 & " and CodConfig = " & CodConfig)
        Dim strTextoR7 As String = ""
        For I = 0 To dtR7.Rows.Count - 1

            Dim strCodUser As String = dtR7.Rows.Item(I).Item("CodUser").ToString
            Dim strGNF As String = dtR7.Rows.Item(I).Item("GNF").ToString
            Dim strCOO As String = dtR7.Rows.Item(I).Item("COO").ToString
            Dim strCCF As String = dtR7.Rows.Item(I).Item("CCF").ToString
            Dim strPagamento As String = dtR7.Rows.Item(I).Item("Pagamento").ToString
            Dim strValorPago As String = dtR7.Rows.Item(I).Item("ValorPago").ToString

            Dim strEstorno As String = dtR7.Rows.Item(I).Item("Estorno").ToString
            Dim strValorEstorno As String = dtR7.Rows.Item(I).Item("ValorEstorno").ToString

            strTextoR7 &= "R07" & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(ModeloECF, 20, False)
            strTextoR7 &= Espaco(strCodUser, 2, True) & Espaco(strCOO, 6, True) & Espaco(strCCF, 6, True) & Espaco(strGNF, 6, True)
            strTextoR7 &= Espaco(strPagamento, 15, False) & Espaco(strValorPago.Replace(",", "").Replace(".", ""), 13, True) & strEstorno & Espaco(strValorPago.Replace(",", "").Replace(".", ""), 13, True) & vbCrLf

        Next

        strTexto &= strTextoR3
        strTexto &= strTextoR4
        strTexto &= strTextoR5
        strTexto &= strTextoR6
        strTexto &= strTextoR7
        'strTexto &= "EAD" & ChavePublica

        Dim intQNumSerie As Integer = NumeroSerieECF.Length
        Dim intInicio As Integer = intQNumSerie - 14
        Dim strCaminho As String
        If parTipo = "Automatico" Then
            strCaminho = CodigoEquipamento & NumeroSerieECF.Substring(intInicio, 14) & Format(dtInicial, "ddMMyyyy")
        Else
            strCaminho = CodigoEquipamento & NumeroSerieECF.Substring(intInicio, 14) & Format(Date.Today, "ddMMyyyy")
        End If

        If TipoImpressoraFiscal = "DARUMA" Then
            EscreveArquivo("C:\NFP DARUMA\" & strCaminho & ".txt", strTexto)
            AssinarArquivo("C:\NFP DARUMA\" & strCaminho & ".txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP DARUMA\" & strCaminho & ".txt", MsgBoxStyle.Information)
        Else
            EscreveArquivo("C:\NFP\" & strCaminho & ".txt", strTexto)
            AssinarArquivo("C:\NFP\" & strCaminho & ".txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP\" & strCaminho & ".txt", MsgBoxStyle.Information)
        End If


        Return True
    End Function
    Public Shared Function VerificaAbertura(ByVal parTipo As String) As Boolean

        Dim dt As DataTable = CarregarDataTable("SELECT Operador, Tipo, convert(Varchar(10),Data,103) as Data FROM Operador where CodConfigECF = " & CodConfigECF & " and CodConfig = " & CodConfig & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' order by Codigo Desc")
        If dt.Rows.Count > 0 Then

            Dim strOperador As String = dt.Rows.Item(0).Item("Operador").ToString
            Dim strTipo As String = dt.Rows.Item(0).Item("Tipo").ToString

            If strTipo = "Entrada" Then
                If parTipo = "Operador" Then
                    If strOperador <> Login Then
                        MsgBox("Caixa aberto para o operador " & strOperador & "!", MsgBoxStyle.Information)
                        Return False
                        Exit Function
                    End If
                End If
            Else
                If parTipo = "Abertura" Then
                    Return False
                    Exit Function
                End If
            End If
        End If
        Return True
    End Function
    Public Shared Function CadastrarFormasPagamento(ByVal parDescricao As String) As Boolean
        Dim strFormasPagamento As String = ""

        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strFor As New StringBuilder(" ", 330)
            strFor.Length = 330
            DarumaFiscal.iRetorno = DarumaFiscal.rLerMeiosPagto_ECF_Daruma(strFor)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strFormasPagamento = strFor.ToString.Trim.Replace(";", ",")
        Else
            Dim strFor As String = Space(3017)

            Retorno = Bematech_FI_VerificaFormasPagamento(strFor)
            strFormasPagamento = strFor
        End If


        Dim vetFormaPag As Array = Split(strFormasPagamento, ",")
        Dim I As Integer
        Dim bolExite As Boolean = False
        For I = 0 To vetFormaPag.Length - 1
            If vetFormaPag(I).ToString = "" Then
                Exit For
            End If

            Dim strPag As String
            If TipoImpressoraFiscal = "DARUMA" Then
                strPag = vetFormaPag(I).ToString.Trim
            Else
                strPag = vetFormaPag(I).ToString.Substring(0, 16)
            End If
            If parDescricao.ToUpper = strPag.ToUpper.Trim Then
                bolExite = True
                Exit For
            End If
        Next

        If bolExite = False Then
            If TipoImpressoraFiscal = "DARUMA" Then

                DarumaFiscal.iRetorno = DarumaFiscal.confCadastrar_ECF_Daruma("FPGTO", parDescricao, "")
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Else
                Retorno = Bematech_FI_ProgramaFormaPagamentoMFD(parDescricao, "1")
            End If

        End If
        Return True
    End Function
    Public Shared Function ExcluirVendaDAV(ByVal parCodOrdem As String) As Boolean
        Dim dt As DataTable = CarregarDataTable("SELECT StatusDAV FROM Total where CodOrdem = " & parCodOrdem & " and Codconfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            Dim strStatus As String = dt.Rows.Item(0).Item("StatusDAV").ToString
            If strStatus = "Faturado" Then

                If CancelarCupom(True, parCodOrdem) = False Then
                    'MsgBox("A venda " & parCodOrdem & " não pode ser excluída!", MsgBoxStyle.Information)
                    'Return False
                End If
            End If
        End If
        Return True
    End Function
    Public Shared Function CancelarCupom(ByVal parExcluirDav As Boolean, ByVal parCodOrdem As String) As Boolean
        Dim dtR4 As DataTable = CarregarDataTable("SELECT Codigo, CCF, COO FROM R4 where CodConfigECF = " & CodConfigECF & " and CodConfig = " & CodConfig & " order by Codigo Desc")
        Dim intCCF As Integer
        Dim intCOO As Integer
        Dim strCodigo As String = ""


        Dim intNumCupom As Integer
        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strCCF As New StringBuilder(" ", 7)
            strCCF.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("30", strCCF)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            intNumCupom = strCCF.ToString.Trim
        Else
            Dim strNumCupom As String = Space(7)
            Retorno = Bematech_FI_ContadorCupomFiscalMFD(strNumCupom)
            If Retorno <> 1 Then
                MsgBox("Erro ao Cancelar Cupom, por favor verifique o status da impressore e tente mais tarde!", MsgBoxStyle.Information)
                Exit Function
            End If
            intNumCupom = strNumCupom
        End If



        If dtR4.Rows.Count > 0 Then
            intCCF = dtR4.Rows.Item(0).Item("CCF").ToString
            intCOO = dtR4.Rows.Item(0).Item("COO").ToString
            strCodigo = dtR4.Rows.Item(0).Item("Codigo").ToString

            If parExcluirDav = True Then
                Dim dtDav As DataTable = CarregarDataTable("SELECT CCF FROM R4 where CodConfigECF = " & CodConfigECF & " and CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If dtDav.Rows.Count > 0 Then
                    Dim intCCFDav As Integer = dtDav.Rows.Item(0).Item("CCF").ToString

                    If intCCFDav <> intNumCupom Then
                        MsgBox("Cupom não pode ser cancelado!", MsgBoxStyle.Information)
                        Return False
                    End If
                End If
            End If
        End If


        'Dim dtR2 As DataTable = CarregarDataTable("SELECT * FROM R2 where CodConfigECF = " & CodConfigECF & " and CodConfig = " & CodConfig & " order by Codigo Desc")
        'Dim intCOOR As Integer
        'If dtR2.Rows.Count > 0 Then
        '    intCOOR = dtR2.Rows.Item(0).Item("COO").ToString

        '    If intCOOR > intCOO Then
        '        MsgBox("A Redução Z já foi emitida não é possível cancelar o ultimo cupom fiscal!", MsgBoxStyle.Information)
        '        Return False
        '        Exit Function
        '    End If
        'End If


        If MsgBox("Deseja realmente cancelar o cupom fiscal Nº " & intNumCupom & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim bolRetorno As Boolean = False
            If TipoImpressoraFiscal = "DARUMA" Then

                DarumaFiscal.iRetorno = DarumaFiscal.iCFCancelar_ECF_Daruma()
                DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                If DarumaFiscal.iRetorno = 1 Then
                    bolRetorno = True
                End If
            Else
                Retorno = Bematech_FI_CancelaCupom()
                If VerificaRetornoImpressora("", "", "Cancelamento de Cupom") = False Then Exit Function
                If Retorno = 1 Then
                    bolRetorno = True
                Else

                    MsgBox("Erro ao Cancelar Cupom, por favor verifique o status da impressore e tente mais tarde!", MsgBoxStyle.Information)
                    Exit Function

                End If
            End If

            If bolRetorno = True Then
                If strCodigo <> "" Then
                    Atualizar("UPDATE R4 SET Cancelado = 'S' where CodConfigECF = " & CodConfigECF & " and Codigo = " & strCodigo & " and CodConfig = " & CodConfig)
                End If
                MsgBox("Cupom Fiscal Nº " & intNumCupom & " cancelado com sucesso!", MsgBoxStyle.Information)
                Return True
            End If
        End If


        Return False
    End Function

    Public Shared Function VerificaImpressora() As Boolean
        VerificaImpressora = False
        If TipoImpressoraFiscal = "DARUMA" Then
            DarumaFiscal.iRetorno = DarumaFiscal.eBuscarPortaVelocidade_ECF_Daruma()
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_VerificaImpressoraLigada()
            If VerificaRetornoImpressora("", "", "Status da Impressora") = False Then
                Return False
            End If

        End If
        Return True
    End Function
   
End Class

