Imports Nano.clsFuncoes
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports BusinessRefinery.Barcode


Imports System
Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient

Imports System.Globalization
Imports System.Runtime.InteropServices

Public Class clsSAT
    Public Shared Function ImprimirCupomSAT(ByVal parCodOrdem As String) As Boolean

        Dim dtPed As DataTable = CarregarDataTable("SELECT ValDesc, ValAcre, CodProdInterno, Produto, " & _
        "convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(numeric(15,2),Qtd) as Qtd, ValorTotal, UM, Total.CodCli, Total.CodConfig, Total.Total, Total.Troco, " & _
        "Total.Recebido, Total.Data, Pedido.CodProd, CPFCliente as CPF, Cliente.Nome, Pedido.Devolvido, " & _
        "Total.NFP FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem) " & _
        "left join Cliente on Total.CodCli = Cliente.Codigo where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.TipoItens <> 'CONSUMO' and Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig)

        If dtPed.Rows.Count = 0 Then Exit Function

        Dim strCliente As String = dtPed.Rows.Item(0).Item("Nome").ToString
        Dim strCPF As String = dtPed.Rows.Item(0).Item("CPF").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
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

        If clsFuncoesBematech.VerificaImpressora() = False Then
            Return False
            Exit Function
        End If


        Dim dblValorDevolvido As Double

        Retorno = ImportsDLL.Bematech_FI_AbreCupom(strCPF)
        System.Threading.Thread.Sleep(200)

        If clsFuncoesBematech.VerificaRetornoImpressora("", "", "Abertura de Cupom") = False Then
            Return False
            Exit Function
        End If


        If Retorno <> 1 Then
            Return False
            Exit Function
        End If

        Try
            Dim L As Integer
            Dim dblValorTotal As Double = 0
            Dim dblValorAproximado As Double = 0
            For L = 0 To dtPed.Rows.Count - 1
                Dim strCod, strProd As String
                Dim dblTot As Double

                Dim codigo As String = ""
                Dim EAN13 As String = ""
                Dim descricao As String = ""
                Dim indiceDepartamento As String = "01"
                Dim aliquota As String = ""
                Dim unidadeMedida As String = "UN"
                Dim tipoQuantidade As String = "I"
                Dim casasDecimaisQuantidade As String = "2"
                Dim quantidade As String = ""
                Dim casasDecimaisValorUnitario As String = "2"
                Dim valorUnitario As String = ""
                Dim tipoAcrescimoDesconto As String = "$"
                Dim valorAcrescimo As String = "00,00"
                Dim valorDesconto As String = "00,00"
                Dim tipoCalculo As String = "A"

                Dim NCM As String = ""
                Dim CFOP As String = ""
                Dim informacoesAdicionais As String = ""
                Dim CST_ICMS As String = ""
                Dim origemProduto As String = ""
                Dim itemListaServico As String = ""
                Dim codigoISS As String = ""
                Dim naturezaOperacaoISS As String = "00"
                Dim indicadorIncentivoISS As String = ""
                Dim codigoIBGE As String = ""
                Dim CSOSN As String = ""
                Dim baseCalculoValorRetido As String = ""
                Dim ICMS_ValorRetido As String = ""
                Dim modoBaseCalculo As String = ""
                Dim percentualReducaoBaseCalculo As String = ""
                Dim ICMS_ST_ModoBaseCalculo As String = ""
                Dim ICMS_ST_PercentualMargemAdicionado As String = ""
                Dim ICMS_ST_PercentualReducaoBaseCalculo As String = ""
                Dim ICMS_ST_ValorReducaoBaseCalculo As String = ""
                Dim ICMS_ST_Aliquota As String = ""
                Dim ICMS_ST_Valor As String = ""
                Dim valorDesoneracaoICMS As String = ""
                Dim motivoDesoneracaoICMS As String = ""
                Dim aliquotaCalculoCredito As String = ""
                Dim creditoICMSSimples As String = ""
                Dim impostosIncidentes As String = ""

                Dim CST_PIS As String = ""
                Dim PIS_BaseCalculo As String = ""
                Dim PIS_Aliquota As String = ""
                Dim PIS_Valor As String = ""
                Dim PIS_QuantidadeVendida As String = ""
                Dim PIS_ValorAliquotaReais As String = ""
                Dim CST_COFINS As String = ""
                Dim COFINS_BaseCalculo As String = ""
                Dim COFINS_Aliquota As String = ""
                Dim COFINS_Valor As String = ""
                Dim COFINS_QuantidadeVendida As String = ""
                Dim COFINS_ValorAliquotaReais As String = ""

                strCod = dtPed.Rows.Item(L).Item("CodProd").ToString
                codigo = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                descricao = dtPed.Rows.Item(L).Item("Produto").ToString
                valorUnitario = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                quantidade = dtPed.Rows.Item(L).Item("Qtd").ToString
                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString

                If dblTot < 0 Then

                    dblValorDevolvido += -dblTot

                Else
                    If dtPed.Rows.Item(L).Item("UM").ToString <> "" Then
                        unidadeMedida = dtPed.Rows.Item(L).Item("UM").ToString
                        Select Case unidadeMedida
                            Case "UN", "JG", "KT", "KG", "LT", "MT", "CX", "GL", "FD", "CJ", "CT", "PC", "DP", "FR", "ML"
                                unidadeMedida = unidadeMedida
                            Case Else
                                Dim dtUni As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCod)
                                If dtUni.Rows.Count > 0 Then
                                    unidadeMedida = dtUni.Rows.Item(0).Item("UnidadeMedida").ToString
                                    If unidadeMedida = "" Then
                                        unidadeMedida = "UN"
                                    End If
                                End If
                        End Select
                    End If
                    EAN13 = ""
                    Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")

                    If bolDevolvido = True Then
                        dblValorDevolvido += dblTot
                    End If
                    dblValorTotal += dblTot


                    Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCod)
                    Dim ipi As New IPI
                    If dtTrib.Rows.Count > 0 Then
                        ' ------------ PIS -----------
                        '
                        Dim pis As New PIS
                        pis.CST = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        pis.totalProd = CDec(Format(dblTot, "0.00"))
                        Dim strPerPis As String = ""
                        If dtTrib.Rows.Item(0).Item("PerPIS").ToString <> "" Then
                            strPerPis = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                        Else
                            strPerPis = "0"
                        End If
                        pis.pPis = CDec(strPerPis)
                        pis.gerar()

                        CST_PIS = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        PIS_BaseCalculo = FormatNumber(CDec(pis.vBC), 2)
                        PIS_Aliquota = FormatNumber(CDec(pis.pPis), 2)
                        PIS_Valor = FormatNumber(CDec(pis.vPis), 2)
                        PIS_QuantidadeVendida = ""
                        PIS_ValorAliquotaReais = ""

                        ' ------------ COFINS -----------
                        '
                        Dim cofins As New COFINS
                        cofins.CST = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                        cofins.totalProd = CDec(Format(dblTot, "0.00"))

                        Dim strPerCofins As String = ""
                        If dtTrib.Rows.Item(0).Item("PerCOFINS").ToString <> "" Then
                            strPerCofins = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
                        Else
                            strPerCofins = "0"
                        End If

                        cofins.pCofins = CDec(strPerCofins)
                        cofins.gerar()

                        CST_COFINS = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                        COFINS_BaseCalculo = FormatNumber(CDec(cofins.vBC), 2)
                        COFINS_Aliquota = FormatNumber(CDec(cofins.pCofins), 2)
                        COFINS_Valor = FormatNumber(CDec(cofins.vCofins), 2)
                        COFINS_QuantidadeVendida = ""
                        COFINS_ValorAliquotaReais = ""

                    Else
                        MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                        Return False
                        Exit Function
                    End If



                    Dim dtNfe As DataTable = CarregarDataTable("SELECT Tributacao, AliquotaICMS, Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom FROM Nfe where CodProd = " & strCod)

                    If dtNfe.Rows.Count > 0 Then

                        If dtNfe.Rows.Item(0).Item("CST").ToString <> "" Then
                            If dtNfe.Rows.Item(0).Item("NCM").ToString <> "" Then
                                If dtNfe.Rows.Item(0).Item("NCM").ToString.Length < 8 Then
                                    If dtNfe.Rows.Item(0).Item("NCM").ToString <> "99" Then
                                        MsgBox("O produto " & descricao & " esta com NCM inválido!", MsgBoxStyle.Information)
                                        Return False
                                        Exit Function
                                    End If

                                End If
                            Else
                                MsgBox("O produto " & descricao & " esta sem NCM!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If

                            NCM = dtNfe.Rows.Item(0).Item("NCM").ToString

                            If dtNfe.Rows.Item(0).Item("Regime").ToString = "SIMPLES NACIONAL" Then
                                CSOSN = dtNfe.Rows.Item(0).Item("CST").ToString
                                'CST_ICMS = "00"
                            Else
                                CST_ICMS = dtNfe.Rows.Item(0).Item("CST").ToString
                            End If


                            CFOP = dtNfe.Rows.Item(0).Item("CFOP").ToString

                            If dtNfe.Rows.Item(0).Item("Origem").ToString <> "" Then
                                origemProduto = dtNfe.Rows.Item(0).Item("Origem").ToString
                            Else
                                MsgBox("O produto " & descricao & " esta sem a origem!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If



                            If DeOlhoNoImposto = True Then
                                Dim dblValAprox As Double = 0

                                If PorValorAproximado = "" Then
                                    Dim dtIBPT As DataTable = CarregarDataTable("SELECT AliqNac, AliqImp FROM TabelaIBPT where NCM = '" & NCM & "'")
                                    If dtIBPT.Rows.Count > 0 Then
                                        Dim dblAliqNac As Double = dtIBPT.Rows.Item(0).Item("AliqNac").ToString
                                        Dim dblAliqImp As Double = dtIBPT.Rows.Item(0).Item("AliqImp").ToString

                                        Select Case origemProduto
                                            Case "0", "3", "4", "5"
                                                dblValAprox = (dblTot * dblAliqNac) / 100
                                            Case Else
                                                dblValAprox = (dblTot * dblAliqImp) / 100
                                        End Select
                                    Else
                                        dblValAprox = 0
                                    End If
                                Else
                                    Dim dblValA As Double = PorValorAproximado
                                    dblValA = (dblTot * dblValA) / 100
                                    dblValAprox = dblValA.ToString("0.00")
                                End If

                                impostosIncidentes = dblValAprox.ToString("0.00")
                                dblValorAproximado += dblValAprox.ToString("0.00")

                            End If


                            Dim strTrib As String = dtNfe.Rows.Item(0).Item("Tributacao").ToString
                            Dim dblICMS As Double = 0
                            Dim strIMCS As String = ""

                            strTrib = CST_ICMS
                            If strTrib = "" Then
                                strTrib = CSOSN
                            End If

                            Select Case strTrib
                                Case "40", "300"
                                    aliquota = "I1"
                                Case "60", "500", "102"
                                    aliquota = "F1"
                                Case "41", "50"
                                    aliquota = "N1"
                                Case "00", "20", "90", "900"
                                    If dtNfe.Rows.Item(0).Item("ICMS").ToString <> "" Then
                                        dblICMS = dtNfe.Rows.Item(0).Item("ICMS").ToString
                                        dblICMS = dblICMS.ToString("0.00")
                                    End If

                                    aliquota = dblICMS.ToString.Replace(",", "").Replace(".", "")
                            End Select


                            ' ------------ ICMS -----------
                            '
                            Dim icms As New ICMS
                            icms.totalProd = CDec(Format(dblTot, "0.00"))
                            icms.CST = dtNfe.Rows.Item(0).Item("CST").ToString
                            icms.IPI = CDec(ipi.vIPI)
                            '''''ARRUMAR BC Estabelecida'''''
                            If dblTot.ToString.Equals("") = False Then
                                icms.bcEstabelecida = CDec(dblTot)
                            End If
                            '''''''''''''''''''''''''''''''''
                            icms.modBC = dtNfe.Rows.Item(0).Item("ModBC").ToString
                            If dtNfe.Rows.Item(0).Item("RedBC").ToString.Equals("") = False Then
                                icms.pRedBC = CDec(dtNfe.Rows.Item(0).Item("RedBC").ToString)
                            End If
                            'If DentroEstado = True Then
                            If dtNfe.Rows.Item(0).Item("ICMS").ToString.Equals("") = False Then
                                icms.pICMS = CDec(dtNfe.Rows.Item(0).Item("ICMS").ToString)
                            End If
                            ''''ARRUMAR Mva'''''''
                            If dtNfe.Rows.Item(0).Item("MVaST").ToString.Equals("") = False Then
                                icms.mva = CDec(dtNfe.Rows.Item(0).Item("MVaST").ToString)
                            End If
                            ''''''''''''''''''''''
                            If dtNfe.Rows.Item(0).Item("ICMSST").ToString.Equals("") = False Then
                                icms.pICMSST = CDec(dtNfe.Rows.Item(0).Item("ICMSST").ToString)
                            End If
                            If dtNfe.Rows.Item(0).Item("MVaST").ToString.Equals("") = False Then
                                icms.mvaST = CDec(dtNfe.Rows.Item(0).Item("MVaST").ToString)
                            End If
                            'Else
                            '    icms.pICMS = CDec(ALIQ_FORA)
                            '    If ReaderVar.Item("MVA_EXT").ToString.Equals("") = False Then
                            '        icms.mva = CDec(ReaderVar.Item("MVA_EXT").ToString)
                            '    End If
                            '    icms.pICMSST = CDec(ALIQ_FORA)
                            '    If ReaderVar.Item("MVA_EXT_ST").ToString.Equals("") = False Then
                            '        icms.mvaST = CDec(ReaderVar.Item("MVA_EXT_ST").ToString)
                            '    End If
                            'End If
                            '''''''ARRUMAR BC Estabelecida ST'''''''''''''
                            If dblTot.ToString.Equals("") = False Then
                                icms.bcEstabelecidaST = CDec(dblTot)
                            End If
                            ''''''''''''''''''''''''''''''''''''''''''''
                            icms.modBCST = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                            If dtNfe.Rows.Item(0).Item("RedBCST").ToString.Equals("") = False Then
                                icms.pRedBCST = CDec(dtNfe.Rows.Item(0).Item("RedBCST").ToString)
                            End If
                            icms.gerar()

                            ' BASE ICMS
                            ' ALIQ ICMS
                            ' REDUCAO
                            percentualReducaoBaseCalculo = FormatNumber(CDec(icms.pRedBC), 2)
                            ' MVA
                            'Item.SubItems.Add(FormatNumber(CDec(icms.mva), 2))

                            ' BASE ICMS ST
                            ' ALIQ ICMS ST
                            ICMS_ST_Aliquota = FormatNumber(CDec(icms.pICMSST), 2)
                            ' VALOR ICMS ST
                            ICMS_ST_Valor = FormatNumber(CDec(icms.vICMSST), 2)

                            ' REDUCAO ST
                            ICMS_ST_PercentualReducaoBaseCalculo = FormatNumber(CDec(icms.pRedBCST), 2)
                            ' MVA ST
                            ICMS_ST_PercentualMargemAdicionado = FormatNumber(CDec(icms.mvaST), 2)

                            aliquotaCalculoCredito = dtNfe.Rows.Item(0).Item("CalculoCred").ToString

                            Dim strVCalcCred As String = ""


                            If aliquotaCalculoCredito <> "0,00" And aliquotaCalculoCredito <> "" Then
                                Dim dblCalcCredito As Double = aliquotaCalculoCredito
                                Dim dblcalc As Double = (dblTot * dblCalcCredito) / 100
                                creditoICMSSimples = dblcalc.ToString("0.00")
                            End If



                            modoBaseCalculo = dtNfe.Rows.Item(0).Item("ModBC").ToString
                            ICMS_ST_ModoBaseCalculo = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                        Else
                            MsgBox("Verificar tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                            Return False
                        End If


                    Else
                        MsgBox("Verificar tributação do produto " & descricao & "!", MsgBoxStyle.Information)

                        Return False
                    End If



                    Dim strItemCompleto As String = FormataJSON(codigo, EAN13, descricao, indiceDepartamento, aliquota, _
                    unidadeMedida, tipoQuantidade, casasDecimaisQuantidade, quantidade, casasDecimaisValorUnitario, _
                    valorUnitario, tipoAcrescimoDesconto, valorAcrescimo, valorDesconto, tipoCalculo, NCM, CFOP, _
                    informacoesAdicionais, CST_ICMS, origemProduto, itemListaServico, codigoISS, naturezaOperacaoISS, _
                    indicadorIncentivoISS, codigoIBGE, CSOSN, baseCalculoValorRetido, ICMS_ValorRetido, modoBaseCalculo, _
                    percentualReducaoBaseCalculo, ICMS_ST_ModoBaseCalculo, ICMS_ST_PercentualMargemAdicionado, _
                    ICMS_ST_PercentualReducaoBaseCalculo, ICMS_ST_ValorReducaoBaseCalculo, ICMS_ST_Aliquota, _
                    ICMS_ST_Valor, valorDesoneracaoICMS, motivoDesoneracaoICMS, aliquotaCalculoCredito, creditoICMSSimples, _
                    impostosIncidentes, CST_PIS, PIS_BaseCalculo, PIS_Aliquota, PIS_Valor, PIS_QuantidadeVendida, _
                    PIS_ValorAliquotaReais, CST_COFINS, COFINS_BaseCalculo, COFINS_Aliquota, COFINS_Valor, _
                    COFINS_QuantidadeVendida, COFINS_ValorAliquotaReais)

                    Retorno = ImportsDLL.Bematech_FI_VendeItemCompletoJSON(strItemCompleto)
                    System.Threading.Thread.Sleep(200)

                    If clsFuncoesBematech.VerificaRetornoImpressora("", "", "Emissão de Cupom Fiscal") = False Then
                        iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                        Return False
                        Exit Function
                    End If

                    If Retorno <> 1 Then
                        iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                        Return False
                        Exit Function
                    End If
                End If




            Next


            If strTipoDesc = "D" Then
                Retorno = Bematech_FI_IniciaFechamentoCupomMFD("D", "$", strValDesc, "00,00")
            Else
                Retorno = Bematech_FI_IniciaFechamentoCupomMFD("A", "$", "00,00", strValDesc)
            End If

            System.Threading.Thread.Sleep(200)

            If Retorno <> 1 Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                Return False
                Exit Function
            End If


            ''Retorno = Bematech_FI_DadosSoftwareHouseSAT("16716114000172", AssinaturaAC)

            Retorno = Bematech_FI_DadosSoftwareHouseSAT(EraSystemsCNPJ.Replace(".", "").Replace("/", "").Replace("-", ""), AssinaturaAC)

            System.Threading.Thread.Sleep(200)

            If Retorno <> 1 Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                Return False
                Exit Function
            End If

            iRetorno = ImportsDLL.Bematech_FI_SubTotalizaCupomMFD()
            iRetorno = ImportsDLL.Bematech_FI_TotalizaCupomMFD()

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
                        strPag = "Outros"
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString = "CRÉDITO CLIENTE" Then
                            strPag = "TROCA"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString = "DINHEIRO" Then
                            strPag = "Dinheiro"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("CRÉDITO") Then
                            strPag = "Cartao Credito"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("DÉBITO") Then
                            strPag = "Cartao Debito"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("CHEQUE") Then
                            strPag = "Cheque"
                        End If
                        Retorno = Bematech_FI_EfetuaFormaPagamento(strPag, dblValor.ToString("0.00"))
                        If Retorno <> 1 Then
                            iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                            Return False
                            Exit Function
                        End If

                    Else

                        'Dim dtRec As DataTable = CarregarDataTable("SELECT convert(varchar(10),Vencimento,103) as Vencimento, ValorParcela FROM ContaReceber where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                        'If dtRec.Rows.Count > 0 Then
                        '    Dim A As Integer
                        '    For A = 0 To dtRec.Rows.Count - 1
                        '        Dim strVenc As String = dtRec.Rows.Item(A).Item("Vencimento").ToString
                        '        Dim dblValorParc As Double
                        '        If dtRec.Rows.Item(A).Item("ValorParcela").ToString <> "" Then
                        '            dblValorParc = dtRec.Rows.Item(A).Item("ValorParcela").ToString
                        '        End If


                        '        Retorno = Bematech_FI_EfetuaFormaPagamentoMFD(strPag, dblValorParc.ToString("0.00"), A, "Vencimento em " & strVenc)
                        '        If Retorno <> 1 Then
                        '            iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                        '            Return False
                        '            Exit Function
                        '        End If

                        '    Next
                        'Else



                        'End If
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                        End If
                        'If VerificaImpressora() = False Then Exit Function
                        strPag = "Outros"
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString = "CRÉDITO CLIENTE" Then
                            strPag = "TROCA"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString = "DINHEIRO" Then
                            strPag = "Dinheiro"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("CRÉDITO") Then
                            strPag = "Cartao Credito"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("DÉBITO") Then
                            strPag = "Cartao Debito"
                        End If
                        If dtPag.Rows.Item(P).Item("Pagamento").ToString.Contains("CHEQUE") Then
                            strPag = "Cheque"
                        End If

                        Retorno = Bematech_FI_EfetuaFormaPagamento(strPag, dblValor.ToString("0.00"))
                        If Retorno <> 1 Then
                            iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                            Return False
                            Exit Function
                        End If
                    End If

                Next
            End If

            Dim dtTroca As DataTable = CarregarDataTable("SELECT sum(Valor) as Valor FROM Devolucao where Motivo like '%NA VENDA Nº " & parCodOrdem & "%'")
            If dtTroca.Rows.Count > 0 Then
                If dtTroca.Rows.Item(0).Item("Valor").ToString <> "" Then
                    dblValorDevolvido = dtTroca.Rows.Item(0).Item("Valor").ToString

                    Retorno = Bematech_FI_EfetuaFormaPagamento("TROCA", dblValorDevolvido.ToString("0.00"))
                    If Retorno <> 1 Then
                        iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                        Return False
                        Exit Function
                    End If
                End If

            End If
            'Dim strTexto As String = " " & vbCrLf
            'If DeOlhoNoImposto = True Then
            '    If TipoDesconto = "TOTAL" Then
            '        dblValorTotal = dtPed.Rows.Item(0).Item("Total").ToString
            '    End If
            '    Dim dblPerAproximado As Double = (dblValorAproximado / dblValorTotal) * 100

            '    If PorValorAproximado <> "" Then
            '        dblPerAproximado = PorValorAproximado

            '        dblValorAproximado = (dblPerAproximado * dblValorTotal) / 100
            '    End If

            '    If dblPerAproximado > 0 Then
            '        strTexto &= "Val Aprox dos Tributos R$ " & dblValorAproximado.ToString("0.00") & " (" & dblPerAproximado.ToString("0.00") & "%) Fonte: IBPT" & vbCrLf
            '    End If
            'End If
            'If SimplesNacional = True Then
            '    strTexto &= "ICMS a ser recolhido conforme LC 123/2006 - Simples Nacional." & vbCrLf
            'End If

            Dim strTexto As String = "Venda: " & parCodOrdem & " Obrigado, volte sempre !!!"

            'Retorno = Bematech_FI_TerminaFechamentoCupom(strTexto)
            Retorno = Bematech_FI_TerminaFechamentoCupomNFCe(strTexto, dblValorAproximado.ToString("0.00"))
            If clsFuncoesBematech.VerificaRetornoImpressora("", "", "Termina Fechamento do Cupom Fiscal") = False Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                Return False
                Exit Function
            End If
            If Retorno <> 1 Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()

                Return False
                Exit Function
            End If

            Atualizar("UPDATE Total Set StatusDAV = 'Faturado' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)


            'Inserir("INSERT INTO Operador (Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) VALUES " & _
            '"('" & Login & "','ValorLiquido'," & Num(dblValorTotal.ToString("0.00")) & ",'" & My.Computer.Clock.LocalTime & "'," & _
            '"" & CodConfig & "," & CodConfigECF & ")")


            Inserir("INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, CNPJ, Data, " & _
            "NumeroCupom, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig) VALUES (" & parCodOrdem & "," & _
            "'" & "" & "','" & NumeroSerieECF & "','" & NumeroEcfECF & "','" & CNPJECF & "'," & _
            "'" & My.Computer.Clock.LocalTime & "','" & "" & "'," & Num(dblValorTotal) & ",'" & strCPF & "'," & _
            "'" & "" & "'," & CodConfig & ")")



        Catch ex As Exception

            If MsgBox("Erro ao imprimir o cupom." & vbCrLf & "Deseja realizar o cancelamento deste cupom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                Return False
                Exit Function
            End If

        End Try
        Return True

    End Function

    Private Shared Function FormataJSON(ByVal codigo As String, ByVal EAN13 As String, ByVal descricao As String, _
       ByVal indiceDepartamento As String, ByVal aliquota As String, ByVal unidadeMedida As String, ByVal tipoQuantidade As String, _
       ByVal casasDecimaisQuantidade As String, ByVal quantidade As String, ByVal casasDecimaisValorUnitario As String, _
       ByVal valorUnitario As String, ByVal tipoAcrescimoDesconto As String, ByVal valorAcrescimo As String, _
       ByVal valorDesconto As String, ByVal tipoCalculo As String, ByVal NCM As String, ByVal CFOP As String, _
       ByVal informacoesAdicionais As String, ByVal CST_ICMS As String, ByVal origemProduto As String, _
       ByVal itemListaServico As String, ByVal codigoISS As String, ByVal naturezaOperacaoISS As String, _
       ByVal indicadorIncentivoISS As String, ByVal codigoIBGE As String, ByVal CSOSN As String, _
       ByVal baseCalculoValorRetido As String, ByVal ICMS_ValorRetido As String, ByVal modoBaseCalculo As String, _
       ByVal percentualReducaoBaseCalculo As String, ByVal ICMS_ST_ModoBaseCalculo As String, ByVal ICMS_ST_PercentualMargemAdicionado As String, _
       ByVal ICMS_ST_PercentualReducaoBaseCalculo As String, ByVal ICMS_ST_ValorReducaoBaseCalculo As String, ByVal ICMS_ST_Aliquota As String, _
       ByVal ICMS_ST_Valor As String, ByVal valorDesoneracaoICMS As String, ByVal motivoDesoneracaoICMS As String, _
       ByVal aliquotaCalculoCredito As String, ByVal creditoICMSSimples As String, ByVal impostosIncidentes As String, _
       ByVal CST_PIS As String, ByVal PIS_BaseCalculo As String, ByVal PIS_Aliquota As String, ByVal PIS_Valor As String, _
       ByVal PIS_QuantidadeVendida As String, ByVal PIS_ValorAliquotaReais As String, ByVal CST_COFINS As String, _
       ByVal COFINS_BaseCalculo As String, ByVal COFINS_Aliquota As String, ByVal COFINS_Valor As String, ByVal COFINS_QuantidadeVendida As String, _
   ByVal COFINS_ValorAliquotaReais As String) As String


        Dim JSON As String

        JSON = "{" & _
                    Chr(34) & "codigo" & Chr(34) & ":" & Chr(34) & codigo & Chr(34) & "," & _
                    Chr(34) & "EAN13" & Chr(34) & ":" & Chr(34) & EAN13 & Chr(34) & "," & _
                    Chr(34) & "descricao" & Chr(34) & ":" & Chr(34) & descricao & Chr(34) & "," & _
                    Chr(34) & "indiceDepartamento" & Chr(34) & ":" & Chr(34) & indiceDepartamento & Chr(34) & "," & _
                    Chr(34) & "aliquota" & Chr(34) & ":" & Chr(34) & aliquota & Chr(34) & "," & _
                    Chr(34) & "unidadeMedida" & Chr(34) & ":" & Chr(34) & unidadeMedida & Chr(34) & "," & _
                    Chr(34) & "tipoQuantidade" & Chr(34) & ":" & Chr(34) & tipoQuantidade & Chr(34) & "," & _
                    Chr(34) & "casasDecimaisQuantidade" & Chr(34) & ":" & Chr(34) & casasDecimaisQuantidade & Chr(34) & "," & _
                    Chr(34) & "quantidade" & Chr(34) & ":" & Chr(34) & quantidade & Chr(34) & "," & _
                    Chr(34) & "casasDecimaisValorUnitario" & Chr(34) & ":" & Chr(34) & casasDecimaisValorUnitario & Chr(34) & "," & _
                    Chr(34) & "valorUnitario" & Chr(34) & ":" & Chr(34) & valorUnitario & Chr(34) & "," & _
                    Chr(34) & "tipoAcrescimoDesconto" & Chr(34) & ":" & Chr(34) & tipoAcrescimoDesconto & Chr(34) & "," & _
                    Chr(34) & "valorAcrescimo" & Chr(34) & ":" & Chr(34) & valorAcrescimo & Chr(34) & "," & _
                    Chr(34) & "valorDesconto" & Chr(34) & ":" & Chr(34) & valorDesconto & Chr(34) & "," & _
                    Chr(34) & "tipoCalculo" & Chr(34) & ":" & Chr(34) & tipoCalculo & Chr(34) & "," & _
                    Chr(34) & "NCM" & Chr(34) & ":" & Chr(34) & NCM & Chr(34) & "," & _
                    Chr(34) & "CFOP" & Chr(34) & ":" & Chr(34) & CFOP & Chr(34) & "," & _
                    Chr(34) & "informacoesAdicionais" & Chr(34) & ":" & Chr(34) & informacoesAdicionais & Chr(34) & "," & _
                    Chr(34) & "CST_ICMS" & Chr(34) & ":" & Chr(34) & CST_ICMS & Chr(34) & "," & _
                    Chr(34) & "origemProduto" & Chr(34) & ":" & Chr(34) & origemProduto & Chr(34) & "," & _
                    Chr(34) & "itemListaServico" & Chr(34) & ":" & Chr(34) & itemListaServico & Chr(34) & "," & _
                    Chr(34) & "codigoISS" & Chr(34) & ":" & Chr(34) & codigoISS & Chr(34) & "," & _
                    Chr(34) & "naturezaOperacaoISS" & Chr(34) & ":" & Chr(34) & naturezaOperacaoISS & Chr(34) & "," & _
                    Chr(34) & "indicadorIncentivoISS" & Chr(34) & ":" & Chr(34) & indicadorIncentivoISS & Chr(34) & "," & _
                    Chr(34) & "codigoIBGE" & Chr(34) & ":" & Chr(34) & codigoIBGE & Chr(34) & "," & _
                    Chr(34) & "CSOSN" & Chr(34) & ":" & Chr(34) & CSOSN & Chr(34) & "," & _
                    Chr(34) & "baseCalculoValorRetido" & Chr(34) & ":" & Chr(34) & baseCalculoValorRetido & Chr(34) & "," & _
                    Chr(34) & "ICMS_ValorRetido" & Chr(34) & ":" & Chr(34) & ICMS_ValorRetido & Chr(34) & "," & _
                    Chr(34) & "modoBaseCalculo" & Chr(34) & ":" & Chr(34) & modoBaseCalculo & Chr(34) & "," & _
                    Chr(34) & "percentualReducaoBaseCalculo" & Chr(34) & ":" & Chr(34) & percentualReducaoBaseCalculo & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_ModoBaseCalculo" & Chr(34) & ":" & Chr(34) & ICMS_ST_ModoBaseCalculo & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_PercentualMargemAdicionado" & Chr(34) & ":" & Chr(34) & ICMS_ST_PercentualMargemAdicionado & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_PercentualReducaoBaseCalculo" & Chr(34) & ":" & Chr(34) & ICMS_ST_PercentualReducaoBaseCalculo & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_ValorReducaoBaseCalculo" & Chr(34) & ":" & Chr(34) & ICMS_ST_ValorReducaoBaseCalculo & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_Aliquota" & Chr(34) & ":" & Chr(34) & ICMS_ST_Aliquota & Chr(34) & "," & _
                    Chr(34) & "ICMS_ST_Valor" & Chr(34) & ":" & Chr(34) & ICMS_ST_Valor & Chr(34) & "," & _
                    Chr(34) & "valorDesoneracaoICMS" & Chr(34) & ":" & Chr(34) & valorDesoneracaoICMS & Chr(34) & "," & _
                    Chr(34) & "motivoDesoneracaoICMS" & Chr(34) & ":" & Chr(34) & motivoDesoneracaoICMS & Chr(34) & "," & _
                    Chr(34) & "aliquotaCalculoCredito" & Chr(34) & ":" & Chr(34) & aliquotaCalculoCredito & Chr(34) & "," & _
                    Chr(34) & "creditoICMSSimples" & Chr(34) & ":" & Chr(34) & creditoICMSSimples & Chr(34) & "," & _
                    Chr(34) & "impostosIncidentes" & Chr(34) & ":" & Chr(34) & impostosIncidentes & Chr(34) & "," & _
                    Chr(34) & "CST_PIS" & Chr(34) & ":" & Chr(34) & CST_PIS & Chr(34) & "," & _
                    Chr(34) & "PIS_BaseCalculo" & Chr(34) & ":" & Chr(34) & PIS_BaseCalculo & Chr(34) & "," & _
                    Chr(34) & "PIS_Aliquota" & Chr(34) & ":" & Chr(34) & PIS_Aliquota & Chr(34) & "," & _
                    Chr(34) & "PIS_Valor" & Chr(34) & ":" & Chr(34) & PIS_Valor & Chr(34) & "," & _
                    Chr(34) & "PIS_QuantidadeVendida" & Chr(34) & ":" & Chr(34) & PIS_QuantidadeVendida & Chr(34) & "," & _
                    Chr(34) & "PIS_ValorAliquotaReais" & Chr(34) & ":" & Chr(34) & PIS_ValorAliquotaReais & Chr(34) & "," & _
                    Chr(34) & "CST_COFINS" & Chr(34) & ":" & Chr(34) & CST_COFINS & Chr(34) & "," & _
                    Chr(34) & "COFINS_BaseCalculo" & Chr(34) & ":" & Chr(34) & COFINS_BaseCalculo & Chr(34) & "," & _
                    Chr(34) & "COFINS_Aliquota" & Chr(34) & ":" & Chr(34) & COFINS_Aliquota & Chr(34) & "," & _
                    Chr(34) & "COFINS_Valor" & Chr(34) & ":" & Chr(34) & COFINS_Valor & Chr(34) & "," & _
                    Chr(34) & "COFINS_QuantidadeVendida" & Chr(34) & ":" & Chr(34) & COFINS_QuantidadeVendida & Chr(34) & "," & _
                    Chr(34) & "COFINS_ValorAliquotaReais" & Chr(34) & ":" & Chr(34) & COFINS_ValorAliquotaReais & Chr(34) & _
               "}"

        'MsgBox(JSON)

        Return JSON

    End Function

    Public Shared Function VerificarFechamentoSAT() As Boolean
        Dim strDataAtual As String = Format(Date.Today, "dd/MM/yy").Replace("/", "")
        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' and Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))

        Dim dt As DataTable = CarregarDataTable("SELECT Operador, Tipo, convert(Varchar(10),Data,103) as Data FROM Operador " & _
        "where CodConfig = " & CodConfig & " and Tipo = 'Fechamento' and CodConfigEcf = " & CodConfigECF & " and " & strData)
        If dt.Rows.Count = 0 Then
            If MsgBox("É necessário realizar o fechamento do dia anterior." & vbCrLf & "Deseja realizar o fechamento agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim strDataMovimento As String = ""

                iRetorno = ImportsDLL.Bematech_FI_ReducaoZ("", "")
               
                If iRetorno = 1 Then

                    Dim dtConfigEcf As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigEcf where CodigoEquipamento = '" & CodigoEquipamento & "'")
                    If dtConfigEcf.Rows.Count > 0 Then
                        Dim I As Integer

                        For I = 0 To dtConfigEcf.Rows.Count - 1
                            Dim strCod As String = dtConfigEcf.Rows.Item(I).Item("Codigo").ToString

                            Inserir("INSERT INTO Operador (Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) VALUES " & _
                                                              "('" & Login & "','Fechamento',0,'" & My.Computer.Clock.LocalTime & "'," & _
                                                              "" & CodConfig & "," & strCod & ")")
                        Next
                    End If
                  
                    Return True
                    Exit Function
                Else
                    Return False
                    Exit Function
                End If
                
            Else
                Return False
                Exit Function
            End If
        Else
            Return True
            Exit Function
        End If

    End Function
    Public Shared Function VerificaRetornoEstendido(ByVal parRetorno As String)

        Select Case parRetorno

            Case "0"
                parRetorno = "COMANDO(OK)"

            Case "1"
                parRetorno = "COMANDO(INVÁLIDO)"

            Case "2"
                parRetorno = " ERRO(DESCONHECIDO)"

            Case "3"
                parRetorno = "NÚMERO DE PARÂMETRO INVÁLIDO"

            Case "4"
                parRetorno = "TIPO DE PARÂMETRO INVÁLIDO"

            Case "5"
                parRetorno = "TODAS ALÍQUOTAS JÁ PROGRAMADAS"

            Case "6"
                parRetorno = "TOTALIZADOR NÃO FISCAL JÁ PROGRAMADO"

            Case "7"
                parRetorno = "CUPOM FISCAL ABERTO"

            Case "8"
                parRetorno = "CUPOM FISCAL FECHADO"

            Case "9"
                parRetorno = "ECF(OCUPADO)"

            Case "10"
                parRetorno = "IMPRESSORA EM ERRO"

            Case "11"
                parRetorno = "IMPRESSORA SEM PAPEL"

            Case "12"
                parRetorno = "IMPRESSORA COM CABEÇA LEVANTADA"

            Case "13"
                parRetorno = "IMPRESSORA OFF LINE"

            Case "14"
                parRetorno = "ALÍQUOTA NÃO PROGRAMADA"

            Case "15"
                parRetorno = "TERMINADOR DE STRING FALTANDO"

            Case "16"
                parRetorno = " ACRÉSCIMO OU DESCONTO MAIOR QUE O TOTAL DO CUPOM FISCAL"

            Case "17"
                parRetorno = "CUPOM FISCAL SEM ITEM VENDIDO"

            Case "18"
                parRetorno = "COMANDO NÃO EFETIVADO"

            Case "19"
                parRetorno = "SEM ESPAÇO PARA NOVAS FORMAS DE PAGAMENTO"

            Case "20"
                parRetorno = "FORMA DE PAGAMENTO NÃO PROGRAMADA"

            Case "21"
                parRetorno = "ÍNDICE MAIOR QUE NÚMERO DE FORMA DE PAGAMENTO"

            Case "22"
                parRetorno = "FORMAS DE PAGAMENTO ENCERRADAS"

            Case "23"
                parRetorno = " CUPOM NÃO TOTALIZADO"

            Case "24"
                parRetorno = "COMANDO MAIOR QUE 7Fh (127d)"

            Case "25"
                parRetorno = "CUPOM FISCAL ABERTO E SEM ÍTEM"

            Case "26"
                parRetorno = "CANCELAMENTO NÃO IMEDIATAMENTE APÓS"

            Case "27"
                parRetorno = "CANCELAMENTO JÁ EFETUADO"

            Case "28"
                parRetorno = "COMPROVANTE DE CRÉDITO OU DÉBITO NÃO PERMITIDO OU JÁ EMITIDO"

            Case "29"
                parRetorno = "MEIO DE PAGAMENTO NÃO PERMITE TEF"

            Case "30"
                parRetorno = " SEM COMPROVANTE NÃO FISCAL ABERTO"

            Case "31"
                parRetorno = "COMPROVANTE DE CRÉDITO OU DÉBITO JÁ ABERTO"

            Case "32"
                parRetorno = "REIMPRESSÃO NÃO PERMITIDA"

            Case "33"
                parRetorno = "COMPROVANTE NÃO FISCAL JÁ ABERTO"

            Case "34"
                parRetorno = "TOTALIZADOR NÃO FISCAL NÃO PROGRAMADO"

            Case "35"
                parRetorno = "CUPOM NÃO FISCAL SEM ÍTEM VENDIDO"

            Case "36"
                parRetorno = "ACRÉSCIMO E DESCONTO MAIOR QUE TOTAL CNF"

            Case "37"
                parRetorno = "MEIO DE PAGAMENTO NÃO INDICADO"

            Case "38"
                parRetorno = "MEIO DE PAGAMENTO DIFERENTE DO TOTAL DO RECEBIMENTO"

            Case "39"
                parRetorno = "NÃO PERMITIDO MAIS DE UMA SANGRIA OU SUPRIMENTO"

            Case "40"
                parRetorno = "RELATÓRIO GERENCIAL JÁ PROGRAMADO"

            Case "41"
                parRetorno = "RELATÓRIO GERENCIAL NÃO PROGRAMADO"

            Case "42"
                parRetorno = "RELATÓRIO GERENCIAL NÃO PERMITIDO"

            Case "43"
                parRetorno = "MFD NÃO INICIALIZADA"

            Case "44"
                parRetorno = "MFD(AUSENTE)"

            Case "45"
                parRetorno = "MFD SEM NÚMERO DE SÉRIE"

            Case "46"
                parRetorno = "MFD JÁ INICIALIZADA"

            Case "47"
                parRetorno = "MFD(LOTADA)"

            Case "48"
                parRetorno = "CUPOM NÃO FISCAL ABERTO"

            Case "49"
                parRetorno = "MEMÓRIA FISCAL DESCONECTADA"

            Case "50"
                parRetorno = "MEMÓRIA FISCAL SEM NÚMERO DE SÉRIE DA MFD"

            Case "51"
                parRetorno = "MEMÓRIA FISCAL LOTADA"

            Case "52"
                parRetorno = "DATA INICIAL INVÁLIDA"

            Case "53"
                parRetorno = "DATA FINAL INVÁLIDA"

            Case "54"
                parRetorno = "CONTADOR DE REDUÇÃO Z INICIAL INVÁLIDO"

            Case "55"
                parRetorno = "CONTADOR DE REDUÇÃO Z FINAL INVÁLIDO"

            Case "56"
                parRetorno = "ERRO DE ALOCAÇÃO"

            Case "57"
                parRetorno = "DADOS DO RTC INCORRETOS"

            Case "58"
                parRetorno = "DATA ANTERIOR AO ÚLTIMO DOCUMENTO EMITIDO"

            Case "59"
                parRetorno = "FORA DE INTERVENÇÃO TÉCNICA"

            Case "60"
                parRetorno = "EM INTERVENÇÃO TÉCNICA"

            Case "61"
                parRetorno = "ERRO NA MEMÓRIA DE TRABALHO"

            Case "62"
                parRetorno = "JÁ HOUVE MOVIMENTO NO DIA"

            Case "63"
                parRetorno = "BLOQUEIO POR RZ"

            Case "64"
                parRetorno = "FORMA DE PAGAMENTO ABERTA"

            Case "65"
                parRetorno = "AGUARDANDO PRIMEIRO PROPRIETÁRIO"

            Case "66"
                parRetorno = "AGUARDANDO(RZ)"

            Case "67"
                parRetorno = "ECF OU LOJA IGUAL A ZERO"

            Case "68"
                parRetorno = "CUPOM ADICIONAL NÃO PERMITIDO"

            Case "69"
                parRetorno = "DESCONTO MAIOR QUE TOTAL VENDIDO EM ICMS"

            Case "70"
                parRetorno = "RECEBIMENTO NÃO FISCAL NULO NÃO PERMITIDO"

            Case "71"
                parRetorno = "ACRÉSCIMO OU DESCONTO MAIOR QUE TOTAL NÃO FISCAL"

            Case "72"
                parRetorno = "MEMÓRIA FISCAL LOTADA PARA NOVO CARTUCHO"

            Case "73"
                parRetorno = "ERRO DE GRAVAÇÃO NA MF"

            Case "74"
                parRetorno = "ERRO DE GRAVAÇÃO NA MFD"

            Case "75"
                parRetorno = "DADOS DO RTC ANTERIORES AO ÚLTIMO DOC ARMAZENADO"

            Case "76"
                parRetorno = "MEMÓRIA FISCAL SEM ESPAÇO PARA GRAVAR LEITURAS DA MFD"

            Case "77"
                parRetorno = "MEMÓRIA FISCAL SEM ESPAÇO PARA GRAVAR VERSAO DO SB"

            Case "78"
                parRetorno = "DESCRIÇÃO IGUAL A DEFAULT NÃO PERMITIDO"
            Case "79"
                parRetorno = "EXTRAPOLADO NÚMERO DE REPETIÇÕES PERMITIDAS"

            Case "80"
                parRetorno = "SEGUNDA VIA DO COMPROVANTE DE CRÉDITO OU DÉBITO NÃO PERMITIDO"

            Case "81"
                parRetorno = "PARCELAMENTO FORA DA SEQUÊNCIA"

            Case "82"
                parRetorno = "COMPROVANTE DE CRÉDITO OU DÉBITO ABERTO"

            Case "83"
                parRetorno = "TEXTO COM SEQUÊNCIA DE ESC INVÁLIDA"

            Case "84"
                parRetorno = "TEXTO COM SEQUÊNCIA DE ESC INCOMPLETA"

            Case "85"
                parRetorno = "VENDA COM VALOR NULO"

            Case "86"
                parRetorno = "ESTORNO DE VALOR NULO"

            Case "87"
                parRetorno = "FORMA DE PAGAMENTO DIFERENTE DO TOTAL DA SANGRIA"

            Case "88"
                parRetorno = "REDUÇÃO NÃO PERMITIDA EM INTERVENÇÃO TÉCNICA"

            Case "89"
                parRetorno = "AGUARDANDO RZ PARA ENTRADA EM INTERVENÇÃO TÉCNICA"

            Case "90"
                parRetorno = "FORMA DE PAGAMENTO COM VALOR NULO NÃO PERMITIDO"

            Case "91"
                parRetorno = "ACRÉSCIMO E DESCONTO MAIOR QUE VALOR DO ÍTEM"

            Case "92"
                parRetorno = "AUTENTICAÇÃO NÃO PERMITIDA"

            Case "93"
                parRetorno = "TIMEOUT NA VALIDAÇÃO"

            Case "94"
                parRetorno = "COMANDO NÃO EXECUTADO EM IMPRESSORA BILHETE DE PASSAGEM"

            Case "95"
                parRetorno = "COMANDO NÃO EXECUTADO EM IMPRESSORA DE CUPOM FISCAL"

            Case "96"
                parRetorno = "CUPOM NÃO FISCAL FECHADO"

            Case "97"
                parRetorno = "PARÂMETRO NÃO ASCII EM CAMPO ASCII"

            Case "98"
                parRetorno = "PARÂMETRO NÃO ASCII NUMÉRICO EM CAMPO ASCII NUMÉRICO"

            Case "99"
                parRetorno = "TIPO DE TRANSPORTE INVÁLIDO"

            Case "100"
                parRetorno = "DATA E HORA INVÁLIDA"

            Case "101"
                parRetorno = "SEM RELATÓRIO GERENCIAL OU COMPROVANTE DE CRÉDITO OU DÉBITO ABERTO"

            Case "102"
                parRetorno = "NÚMERO DO TOTALIZADOR NÃO FISCAL INVÁLIDO"

            Case "103"
                parRetorno = "PARÂMETRO DE ACRÉSCIMO OU DESCONTO INVÁLIDO"

            Case "104"
                parRetorno = "ACRÉSCIMO OU DESCONTO EM SANGRIA OU SUPRIMENTO NÃO PERMITIDO"

            Case "105"
                parRetorno = "NÚMERO DO RELATÓRIO GERENCIAL INVÁLIDO"

            Case "106"
                parRetorno = "FORMA DE PAGAMENTO ORIGEM NÃO PROGRAMADA"

            Case "107"
                parRetorno = "FORMA DE PAGAMENTO DESTINO NÃO PROGRAMADA"

            Case "108"
                parRetorno = "ESTORNO MAIOR QUE FORMA PAGAMENTO"

            Case "109"
                parRetorno = "CARACTER NUMÉRICO NA CODIFICAÇÃO GT NÃO PERMITIDO"

            Case "110"
                parRetorno = "ERRO NA INICIALIZAÇÃO DA MF"

            Case "111"
                parRetorno = "NOME DO TOTALIZADOR EM BRANCO NÃO PERMITIDO"

            Case "112"
                parRetorno = "DATA E HORA ANTERIORES AO ÚLTIMO DOC ARMAZENADO"

            Case "113"
                parRetorno = "PARÂMETRO DE ACRÉSCIMO OU DESCONTO INVÁLIDO"

            Case "114"
                parRetorno = "ÍTEM ANTERIOR AOS TREZENTOS ÚLTIMOS"

            Case "115"
                parRetorno = "ÍTEM NÃO EXISTE OU JÁ CANCELADO"

            Case "116"
                parRetorno = "CÓDIGO COM ESPAÇOS NÃO PERMITIDO"

            Case "117"
                parRetorno = "DESCRICAO SEM CARACTER ALFABÉTICO NÃO PERMITIDO"

            Case "118"
                parRetorno = "ACRÉSCIMO MAIOR QUE VALOR DO ÍTEM"

            Case "119"
                parRetorno = "DESCONTO MAIOR QUE VALOR DO ÍTEM"

            Case "120"
                parRetorno = "DESCONTO EM ISS NÃO PERMITIDO"

            Case "121"
                parRetorno = "ACRÉSCIMO EM ÍTEM JÁ EFETUADO"

            Case "122"
                parRetorno = "DESCONTO EM ÍTEM JÁ EFETUADO"

            Case "123"
                parRetorno = "ERRO NA MEMÓRIA FISCAL CHAMAR CREDENCIADO"

            Case "124"
                parRetorno = "AGUARDANDO GRAVAÇÃO NA MEMÓRIA FISCAL"

            Case "125"
                parRetorno = "CARACTER REPETIDO NA CODIFICAÇÃO DO GT"

            Case "126"
                parRetorno = "VERSÃO JÁ GRAVADA NA MEMÓRIA FISCAL"

            Case "127"
                parRetorno = "ESTOURO DE CAPACIDADE NO CHEQUE"

            Case "128"
                parRetorno = "TIMEOUT NA LEITURA DO CHEQUE"

            Case "129"
                parRetorno = "MÊS(INVÁLIDO)"

            Case "130"
                parRetorno = "COORDENADA(INVÁLIDA)"

            Case "131"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO"

            Case "132"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO VALOR"

            Case "133"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO EXTENSO"

            Case "134"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO FAVORECIDO"

            Case "135"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NA LOCALIDADE"

            Case "136"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO OPCIONAL"

            Case "137"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO DIA"

            Case "138"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO MÊS"

            Case "139"
                parRetorno = "SOBREPOSIÇÃO DE TEXTO NO ANO"

            Case "140"
                parRetorno = "USANDO MFD DE OUTRO ECF"

            Case "141"
                parRetorno = "PRIMEIRO DADO DIFERENTE DE ESC OU 1C"

            Case "142"
                parRetorno = "NÃO PERMITIDO ALTERAR SEM INTERVENÇÃO TÉCNICA"

            Case "143"
                parRetorno = "DADOS DA ÚLTIMA RZ CORROMPIDOS"

            Case "144"
                parRetorno = "COMANDO NÃO PERMITIDO NO MODO INICIALIZAÇÃO"

            Case "145"
                parRetorno = "AGUARDANDO ACERTO DE RELÓGIO"

            Case "146"
                parRetorno = "MFD JÁ INICIALIZADA PARA OUTRA MF"

            Case "147"
                parRetorno = "AGUARDANDO ACERTO DO RELÓGIO OU DESBLOQUEIO PELO TECLADO"

            Case "148"
                parRetorno = "VALOR FORMA DE PAGAMENTO MAIOR QUE MÁXIMO PERMITIDO"

            Case "149"
                parRetorno = "RAZÃO SOCIAL EM BRANCO"

            Case "150"
                parRetorno = "NOME DE FANTASIA EM BRANCO"

            Case "151"
                parRetorno = "ENDEREÇO EM BRANCO"

            Case "152"
                parRetorno = "ESTORNO DE CDC NÃO PERMITIDO"

            Case "153"
                parRetorno = "DADOS DO PROPRIETÁRIO IGUAIS AO ATUAL"

            Case "154"
                parRetorno = "ESTORNO DE FORMA DE PAGAMENTO NÃO PERMITIDO"

            Case "155"
                parRetorno = "DESCRIÇÃO FORMA DE PAGAMENTO IGUAL JÁ PROGRAMADA"

            Case "156"
                parRetorno = "ACERTO DE HORÁRIO DE VERÃO SÓ IMEDIATAMENTE APÓS RZ"

            Case "157"
                parRetorno = "IT NÃO PERMITIDA MF RESERVADA PARA RZ"

            Case "158"
                parRetorno = "SENHA CNPJ INVÁLIDA"

            Case "159"
                parRetorno = "TIMEOUT NA INICIALIZAÇÃO DA NOVA MF"

            Case "160"
                parRetorno = "NÃO ENCONTRADO DADOS NA MFD"

            Case "161"
                parRetorno = "SANGRIA OU SUPRIMENTO DEVEM SER ÚNICOS NO CNF"

            Case "162"
                parRetorno = "ÍNDICE DA FORMA DE PAGAMENTO NULO NÃO PERMITIDO"

            Case "163"
                parRetorno = "UF DESTINO INVÁLIDA"

            Case "164"
                parRetorno = "TIPO DE TRANSPORTE INCOMPATÍVEL COM UF DESTINO"

            Case "165"
                parRetorno = "DESCRIÇÃO DO PRIMEIRO ÍTEM DO BILHETE DE PASSAGEM DIFERENTE DE TARIFA"

            Case "166"
                parRetorno = "AGUARDANDO IMPRESSÃO DE CHEQUE OU AUTENTICAÇÃO"

            Case "167"
                parRetorno = "NÃO PERMITIDO PROGRAMAÇAO CNPJ IE COM ESPAÇOS EM BRANCO"

            Case "168"
                parRetorno = "NÃO PERMITIDO PROGRAMAÇÃO UF COM ESPAÇOS EM BRANCO"

            Case "169"
                parRetorno = "NÚMERO DE IMPRESSÕES DA FITA DETALHE NESTA INTERVENÇÃO TÉCNICA ESGOTADO"

            Case "170"
                parRetorno = "CF JÁ SUBTOTALIZADO"

            Case "171"
                parRetorno = "CUPOM NÃO SUBTOTALIZADO"

            Case "172"
                parRetorno = "ACRÉSCIMO EM SUBTOTAL JÁ EFETUADO"

            Case "173"
                parRetorno = "DESCONTO EM SUBTOTAL JÁ EFETUADO"

            Case "174"
                parRetorno = "ACRÉSCIMO NULO NÃO PERMITIDO"

            Case "175"
                parRetorno = "DESCONTO NULO NÃO PERMITIDO"

            Case "176"
                parRetorno = "CANCELAMENTO DE ACRÉSCIMO OU DESCONTO EM SUBTOTAL NÃO PERMITIDO"

            Case "177"
                parRetorno = "Data(INVÁLIDA)"

            Case "178"
                parRetorno = "VALOR DO CHEQUE NULO NÃO PERMITIDO"

            Case "179"
                parRetorno = "VALOR DO CHEQUE INVÁLIDO"

            Case "180"
                parRetorno = "CHEQUE SEM LOCALIDADE NÃO PERMITIDO"

            Case "181"
                parRetorno = "CANCELAMENTO ACRÉSCIMO EM ÍTEM NÃO PERMITIDO"

            Case "182"
                parRetorno = "CANCELAMENTO DESCONTO EM ÍTEM NÃO PERMITIDO"

            Case "183"
                parRetorno = "NÚMERO MÁXIMO DE ÍTENS ATINGIDO"

            Case "184"
                parRetorno = "NÚMERO DE ÍTEM NULO NÃO PERMITIDO"

            Case "185"
                parRetorno = "MAIS QUE DUAS ALÍQUOTAS DIFERENTES NO BILHETE DE PASSAGEM NÃO PERMITIDO"

            Case "186"
                parRetorno = "ACRÉSCIMO OU DESCONTO EM ITEM NÃO PERMITIDO"

            Case "187"
                parRetorno = "CANCELAMENTO DE ACRÉSCIMO OU DESCONTO EM ITEM NÃO PERMITIDO"

            Case "188"
                parRetorno = "CLICHE JÁ IMPRESSO"

            Case "189"
                parRetorno = "TEXTO OPCIONAL DO CHEQUE EXCEDEU O MÁXIMO PERMITIDO"

            Case "190"
                parRetorno = "IMPRESSÃO AUTOMÁTICA NO VERSO NÃO PERMITIDO NESTE EQUIPAMENTO"

            Case "191"
                parRetorno = "TIMEOUT NA INSERÇÃO DO CHEQUE"

            Case "192"
                parRetorno = "OVERFLOW NA CAPACIDADE DE TEXTO DO COMPROVANTE DE CRÉDITO OU DÉBITO"

            Case "193"
                parRetorno = "PROGRAMAÇÃO DE ESPAÇOS ENTRE CUPONS MENOR QUE O MÍNIMO PERMITIDO"

            Case "194"
                parRetorno = "EQUIPAMENTO NÃO POSSUI LEITOR DE CHEQUE"

            Case "195"
                parRetorno = "PROGRAMAÇÃO DE ALÍQUOTA COM VALOR NULO NÃO PERMITIDO"

            Case "196"
                parRetorno = "PARÂMETRO BAUD RATE INVÁLIDO"

            Case "197"
                parRetorno = "CONFIGURAÇÃO PERMITIDA SOMENTE PELA PORTA DOS FISCO"

            Case "198"
                parRetorno = "VALOR TOTAL DO ITEM EXCEDE 11 DÍGITOS"

            Case "199"
                parRetorno = "PROGRAMAÇÃO DA MOEDA COM ESPAÇOS EM BRACO NÃO PERMITIDO"

            Case "200"
                parRetorno = "CASAS DECIMAIS DEVEM SER PROGRAMADAS COM 2 OU 3"

            Case "201"
                parRetorno = "NÃO PERMITE CADASTRAR USUÁRIOS DIFERENTES NA MESMA MFD"

            Case "202"
                parRetorno = "IDENTIFICAÇÃO DO CONSUMIDOR NÃO PERMITIDA PARA SANGRIA OU SUPRIMENTO"

            Case "203"
                parRetorno = "CASAS DECIMAIS EM QUANTIDADE MAIOR DO QUE A PERMITIDA"

            Case "204"
                parRetorno = "CASAS DECIMAIS DO UNITÁRIO MAIOR DO QUE O PERMITIDA"

            Case "205"
                parRetorno = "POSIÇÃO RESERVADA PARA ICMS"

            Case "206"
                parRetorno = "POSIÇÃO RESERVADA PARA ISS"

            Case "207"
                parRetorno = "TODAS AS ALÍQUOTAS COM A MESMA VINCULAÇÃO NÃO PERMITIDO"

            Case "208"
                parRetorno = "DATA DE EMBARQUE ANTERIOR A DATA DE EMISSÃO"

            Case "209"
                parRetorno = "ALÍQUOTA DE ISS NÃO PERMITIDA SEM INSCRIÇÃO MUNICIPAL"

            Case "210"
                parRetorno = "RETORNO PACOTE CLICHE FORA DA SEQUÊNCIA"

            Case "211"
                parRetorno = "ESPAÇO PARA ARMAZENAMENTO DO CLICHE ESGOTADO"

            Case "212"
                parRetorno = "CLICHE GRÁFICO NÃO DISPONÍVEL PARA CONFIRMAÇÃO"

            Case "213"
                parRetorno = "CRC DO CLICHE GRÁFICO DIFERENTE DO INFORMADO"

            Case "214"
                parRetorno = "INTERVALO(INVÁLIDO)"

            Case "215"
                parRetorno = "USUÁRIO JÁ PROGRAMADO"

            Case "217"
                parRetorno = "DETECTADA ABERTURA DO EQUIPAMENTO"

            Case "218"
                parRetorno = "CANCELAMENTO DE ACRÉSCIMO/DESCONTO NÃO PERMITIDO "

        End Select
        Return parRetorno
    End Function

    Public Shared Function ImprimirCupomSatDll(ByVal parCodOrdem As String) As Boolean
        Dim strCodProdPadrao As String = ""
        Dim dtPadrao As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where TributacaoPadrao = 'True'")
        If dtPadrao.Rows.Count > 0 Then
            If dtPadrao.Rows.Item(0).Item("Codigo").ToString <> "" Then
                strCodProdPadrao = dtPadrao.Rows.Item(0).Item("Codigo").ToString
            End If
        End If

        Dim dtPed As DataTable = CarregarDataTable("SELECT ValDesc, ValAcre, CodProdInterno, Produto, " & _
        "convert(Numeric(15,2),ValorUnitario) as ValorUnitario, convert(numeric(15,3),Qtd) as Qtd, ValorTotal, " & _
        "UM, Total.CodCli, Total.CodConfig, Total.Total, Total.Troco, Total.Recebido, Total.Data, Pedido.CodProd, " & _
        "CPFCliente as CPF, Cliente.Nome, Pedido.Devolvido, Total.NFP FROM ((Pedido left join  Produto on " & _
        "Pedido.CodProd = Produto.Codigo) left join Total on Pedido.CodOrdem = Total.CodOrdem) left join " & _
        "Cliente on Total.CodCli = Cliente.Codigo where Pedido.CodOrdem = " & parCodOrdem & " and " & _
        "Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig & " and Produto.Tipo <> 'SERVIÇO' and Produto.Tipo <> 'CONSUMO' and Pedido.TipoItens <> 'CONSUMO'")
        'len(Produto.Tipo) = 5 and 
        If dtPed.Rows.Count = 0 Then Exit Function

        Dim strCliente As String = dtPed.Rows.Item(0).Item("Nome").ToString
        Dim strCPF As String = dtPed.Rows.Item(0).Item("CPF").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
        Dim bolNFP As Boolean = dtPed.Rows.Item(0).Item("NFP")
        Dim strTipoPessoa As String = "F"
        If bolNFP = False Then
            strCPF = "00000000000"
        Else
            If Len(strCPF) = 14 Then
                strTipoPessoa = "J"
            End If
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

        If SatTeste = True Then
            EraSystemsCNPJ = "16.716.114/0001-72"
            If ModeloSAT = "SWEDA" Then
                EraSystemsCNPJ = "10.615.281/0001-40"
            End If
        End If

        Dim dblValorDevolvido As Double

        Dim strIdentificador As String = clsXmlSat.Identificador(EraSystemsCNPJ.Replace(".", "").Replace("/", "").Replace("-", ""), AssinaturaAC, NumeroEcfECF)

        Dim strEmitente As String = clsXmlSat.Emitente(CNPJECF.Replace(".", "").Replace("/", "").Replace("-", ""), IEECF.Replace(".", "").Replace("/", "").Replace("-", ""), "N")

        Dim strDestinatario As String = clsXmlSat.Destinatario(strTipoPessoa, strCPF, strCliente)

        Dim strProduto As String = ""

        Dim strICMS As String = ""

        Dim strPIS As String = ""

        Dim strCOFINS As String = ""

        Dim strItens As String = ""

        Dim strTotal As String = ""

        Dim strPagamento As String = ""

        Dim strAdicionais As String = ""

        Dim dblValorAproximado As Double = 0
        Dim dblValorTotal As Double = 0

        Dim dblValorTotalConf As Double
        Try
            Dim L As Integer
            Dim A As Integer = 0
            For L = 0 To dtPed.Rows.Count - 1
                Dim strCod, strProd As String
                Dim dblTot As Double

                Dim codigo As String = ""
                Dim EAN13 As String = ""
                Dim descricao As String = ""
                Dim indiceDepartamento As String = "01"
                Dim aliquota As String = ""
                Dim unidadeMedida As String = "UN"
                Dim tipoQuantidade As String = "I"
                Dim casasDecimaisQuantidade As String = "2"
                Dim quantidade As String = ""
                Dim casasDecimaisValorUnitario As String = "2"
                Dim valorUnitario As String = ""
                Dim tipoAcrescimoDesconto As String = "$"
                Dim valorAcrescimo As String = "00,00"
                Dim valorDesconto As String = "00,00"
                Dim tipoCalculo As String = "A"

                Dim NCM As String = ""
                Dim CFOP As String = ""
                Dim informacoesAdicionais As String = ""
                Dim CST_ICMS As String = ""
                Dim origemProduto As String = ""
                Dim itemListaServico As String = ""
                Dim codigoISS As String = ""
                Dim naturezaOperacaoISS As String = "00"
                Dim indicadorIncentivoISS As String = ""
                Dim codigoIBGE As String = ""
                Dim CSOSN As String = ""
                Dim baseCalculoValorRetido As String = ""
                Dim ICMS_ValorRetido As String = ""
                Dim modoBaseCalculo As String = ""
                Dim percentualReducaoBaseCalculo As String = ""
                Dim ICMS_ST_ModoBaseCalculo As String = ""
                Dim ICMS_ST_PercentualMargemAdicionado As String = ""
                Dim ICMS_ST_PercentualReducaoBaseCalculo As String = ""
                Dim ICMS_ST_ValorReducaoBaseCalculo As String = ""
                Dim ICMS_ST_Aliquota As String = ""
                Dim ICMS_ST_Valor As String = ""
                Dim valorDesoneracaoICMS As String = ""
                Dim motivoDesoneracaoICMS As String = ""
                Dim aliquotaCalculoCredito As String = ""
                Dim creditoICMSSimples As String = ""
                Dim impostosIncidentes As String = ""

                Dim CST_PIS As String = ""
                Dim PIS_BaseCalculo As String = ""
                Dim PIS_Aliquota As String = ""
                Dim PIS_Valor As String = ""
                Dim PIS_QuantidadeVendida As String = ""
                Dim PIS_ValorAliquotaReais As String = ""
                Dim CST_COFINS As String = ""
                Dim COFINS_BaseCalculo As String = ""
                Dim COFINS_Aliquota As String = ""
                Dim COFINS_Valor As String = ""
                Dim COFINS_QuantidadeVendida As String = ""
                Dim COFINS_ValorAliquotaReais As String = ""
                Dim strCodigoANP As String = ""
                Dim strCestProd As String = ""
                strCod = dtPed.Rows.Item(L).Item("CodProd").ToString
                codigo = dtPed.Rows.Item(L).Item("CodProdInterno").ToString
                descricao = dtPed.Rows.Item(L).Item("Produto").ToString
                Dim dblValUnit As Double = dtPed.Rows.Item(L).Item("ValorUnitario").ToString
                valorUnitario = dblValUnit.ToString("0.00").Replace(",", ".")
                Dim dblQtde As Double = dtPed.Rows.Item(L).Item("Qtd").ToString
                quantidade = dblQtde.ToString("0.0000").Replace(",", ".")
                dblTot = dtPed.Rows.Item(L).Item("ValorTotal").ToString



                If dblTot < 0 Then

                    dblValorDevolvido += -dblTot

                Else
                    Dim dblValorConf As Double = dblValUnit.ToString("0.00")
                    dblValorConf = dblQtde * dblValorConf
                    dblValorTotalConf += dblValorConf.ToString("0.00")

                    If dtPed.Rows.Item(L).Item("UM").ToString <> "" Then
                        unidadeMedida = dtPed.Rows.Item(L).Item("UM").ToString
                        Select Case unidadeMedida
                            Case "UN", "JG", "KT", "KG", "LT", "MT", "CX", "GL", "FD", "CJ", "CT", "PC", "DP", "FR", "ML"
                                unidadeMedida = unidadeMedida
                            Case Else
                                Dim dtUni As DataTable = CarregarDataTable("SELECT UnidadeMedida FROM Produto where Codigo = " & strCod)
                                If dtUni.Rows.Count > 0 Then
                                    unidadeMedida = dtUni.Rows.Item(0).Item("UnidadeMedida").ToString
                                    If unidadeMedida = "" Then
                                        unidadeMedida = "UN"
                                    End If

                                End If
                        End Select

                    End If
                    EAN13 = ""
                    Dim bolDevolvido As Boolean = dtPed.Rows.Item(L).Item("Devolvido")

                    If bolDevolvido = True Then
                        dblValorDevolvido += dblTot
                    End If
                    dblValorTotal += dblTot



                    Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCod & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCod & " and Regime = '" & RegimeSAT & " SAT'")
                    Dim ipi As New IPI
                    If dtTrib.Rows.Count = 0 Then
                        If strCodProdPadrao <> "" Then
                            dtTrib = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & " SAT'")
                            MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                        End If

                    Else
                        Dim bolVerificarPadrao As Boolean = False
                        Dim strCSTPIS As String = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        Dim strCSTCOFINS As String = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                        If strCSTPIS = "" Then
                            bolVerificarPadrao = True
                        Else
                            Select Case dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                                Case "01", "02", "03", "04", "05", "06", "07", "08", "09", "49", "99"
                                Case Else
                                    bolVerificarPadrao = True
                            End Select
                        End If
                        If strCSTCOFINS = "" Then
                            bolVerificarPadrao = True
                        Else
                            Select Case dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                                Case "01", "02", "03", "04", "05", "06", "07", "08", "09", "49", "99"
                                Case Else
                                    bolVerificarPadrao = True
                            End Select
                        End If
                        If bolVerificarPadrao = True Then
                            If strCodProdPadrao <> "" Then
                                dtTrib = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCod & " and Regime = '" & RegimeSAT & " SAT'")
                                MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                            End If

                        End If
                    End If

                    If dtTrib.Rows.Count > 0 Then
                        ' ------------ PIS -----------
                        '
                        Dim pis As New PIS
                        pis.CST = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        pis.totalProd = CDec(Format(dblTot, "0.00"))
                        Dim strPerPis As String = ""
                        If dtTrib.Rows.Item(0).Item("PerPIS").ToString <> "" Then
                            strPerPis = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                        Else
                            strPerPis = "0"
                        End If
                        pis.pPis = CDec(strPerPis)
                        'pis.gerar()

                        CST_PIS = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        If CST_PIS = "" Then
                            MsgBox("O produto " & descricao & " está sem CST PIS!", MsgBoxStyle.Information)
                            Return False
                            Exit Function
                        Else
                            Select Case dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                                Case "01", "02", "03", "04", "05", "06", "07", "08", "09", "49", "99"

                                Case Else
                                    MsgBox("O produto " & descricao & " esta com CST PIS inválido!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                            End Select
                        End If
                        PIS_BaseCalculo = CDec(Format(dblTot, "0.00"))
                        PIS_Aliquota = CDec(Format(CDbl(strPerPis), "0.00"))
                        If PIS_Aliquota > 0 Then
                            Dim dblAliqPIS As Double = PIS_Aliquota
                            dblAliqPIS = dblAliqPIS / 100
                            PIS_Aliquota = dblAliqPIS.ToString("0.0000")
                        Else
                            PIS_Aliquota = "0,0000"
                        End If
                        PIS_Valor = FormatNumber(CDec(pis.vPis), 2)
                        PIS_QuantidadeVendida = ""
                        PIS_ValorAliquotaReais = ""

                        ' ------------ COFINS -----------
                        '
                        Dim cofins As New COFINS
                        cofins.CST = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                        cofins.totalProd = CDec(Format(dblTot, "0.00"))

                        Dim strPerCofins As String = ""
                        If dtTrib.Rows.Item(0).Item("PerCOFINS").ToString <> "" Then
                            strPerCofins = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
                        Else
                            strPerCofins = "0"
                        End If

                        cofins.pCofins = CDec(strPerCofins)
                        'cofins.gerar()

                        CST_COFINS = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                        If CST_COFINS = "" Then
                            MsgBox("O produto " & descricao & " está sem CST CONFIS!", MsgBoxStyle.Information)
                            Return False
                            Exit Function
                        Else
                            Select Case dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                                Case "01", "02", "03", "04", "05", "06", "07", "08", "09", "49", "99"

                                Case Else
                                    MsgBox("O produto " & descricao & " esta com CST COFINS inválido!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                            End Select
                        End If
                        COFINS_BaseCalculo = CDec(Format(dblTot, "0.00"))
                        COFINS_Aliquota = CDec(Format(CDbl(strPerCofins), "0.00"))
                        If COFINS_Aliquota > 0 Then
                            Dim dblAliqCOFINS As Double = COFINS_Aliquota
                            dblAliqCOFINS = dblAliqCOFINS / 100
                            COFINS_Aliquota = dblAliqCOFINS.ToString("0.0000")
                        Else
                            COFINS_Aliquota = "0,0000"
                        End If
                        COFINS_Valor = FormatNumber(CDec(cofins.vCofins), 2)
                        COFINS_QuantidadeVendida = ""
                        COFINS_ValorAliquotaReais = ""

                    Else
                        MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                        Return False
                        Exit Function
                    End If



                    Dim dtNfe As DataTable = CarregarDataTable("SELECT Tributacao, AliquotaICMS, Codigo, " & _
                    "CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, " & _
                    "ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, " & _
                    "ValCom, CodigoANP, Cest FROM Nfe where CodProd = " & strCod & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCod & " and Regime = '" & RegimeSAT & " SAT'")
                    If dtNfe.Rows.Count = 0 Then
                        If strCodProdPadrao <> "" Then
                            dtNfe = CarregarDataTable("SELECT Tributacao, AliquotaICMS, Codigo, CodProd, EXTIPI, " & _
                            "Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, " & _
                            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom, " & _
                            "CodigoANP, Cest FROM Nfe where CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & " SAT'")
                            MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                        End If

                    Else
                        Dim bolVerificarPadrao As Boolean = False

                        If dtNfe.Rows.Item(0).Item("CST").ToString = "" Then
                            bolVerificarPadrao = True
                        End If
                        Select Case dtNfe.Rows.Item(0).Item("CST").ToString
                            Case "00", "20", "40", "41", "60", "90", "102", "300", "500", "900"
                            Case Else
                                bolVerificarPadrao = True
                        End Select

                        If dtNfe.Rows.Item(0).Item("NCM").ToString <> "" Then
                            If dtNfe.Rows.Item(0).Item("NCM").ToString.Length < 8 Then
                                If dtNfe.Rows.Item(0).Item("NCM").ToString <> "99" Then
                                    bolVerificarPadrao = True
                                End If
                            End If
                        Else
                            bolVerificarPadrao = True
                        End If

                        If dtNfe.Rows.Item(0).Item("CFOP").ToString = "" Then
                            bolVerificarPadrao = True
                        End If

                        If dtNfe.Rows.Item(0).Item("Origem").ToString = "" Then
                            bolVerificarPadrao = True
                        End If
                        If bolVerificarPadrao = True Then
                            If strCodProdPadrao <> "" Then
                                dtNfe = CarregarDataTable("SELECT Tributacao, AliquotaICMS, Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom FROM Nfe where CodProd = " & strCodProdPadrao & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCod & " and Regime = '" & RegimeSAT & " SAT'")
                                MsgBox("Verificar Tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                            End If

                        End If
                    End If
                    If dtNfe.Rows.Count > 0 Then

                        If dtNfe.Rows.Item(0).Item("CST").ToString <> "" Then
                            Select Case dtNfe.Rows.Item(0).Item("CST").ToString
                                Case "00", "20", "40", "41", "60", "90", "102", "300", "500", "900"

                                Case Else
                                    MsgBox("O produto " & descricao & " esta com CST inválido!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                            End Select

                            If dtNfe.Rows.Item(0).Item("NCM").ToString <> "" Then
                                If dtNfe.Rows.Item(0).Item("NCM").ToString.Length < 8 Then
                                    If dtNfe.Rows.Item(0).Item("NCM").ToString <> "99" Then
                                        MsgBox("O produto " & descricao & " esta com NCM inválido!", MsgBoxStyle.Information)
                                        Return False
                                        Exit Function
                                    End If

                                End If
                            Else
                                MsgBox("O produto " & descricao & " esta sem NCM!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If

                            NCM = dtNfe.Rows.Item(0).Item("NCM").ToString
                            strCestProd = dtNfe.Rows.Item(0).Item("Cest").ToString

                            'If dtNfe.Rows.Item(0).Item("Regime").ToString = "SIMPLES NACIONAL" Then
                            '    CSOSN = dtNfe.Rows.Item(0).Item("CST").ToString
                            '    'CST_ICMS = "00"
                            'Else
                            CST_ICMS = dtNfe.Rows.Item(0).Item("CST").ToString
                            'End If


                            CFOP = dtNfe.Rows.Item(0).Item("CFOP").ToString
                            If CFOP = "" Then
                                MsgBox("O produto " & descricao & " esta sem a CFOP!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If

                            strCodigoANP = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                            If strCodigoANP <> "" Then
                                If strCodigoANP.Contains(" | ") = True Then
                                    Dim vetANP As Array = Split(strCodigoANP, " | ")
                                    strCodigoANP = vetANP(0)
                                End If
                            End If

                            If dtNfe.Rows.Item(0).Item("Origem").ToString <> "" Then
                                origemProduto = dtNfe.Rows.Item(0).Item("Origem").ToString
                            Else
                                MsgBox("O produto " & descricao & " esta sem a origem!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If



                            If DeOlhoNoImposto = True Then
                                Dim dblValAprox As Double = 0
                                Dim dtIBPT As DataTable = CarregarDataTable("SELECT AliqNac, AliqImp FROM TabelaIBPT where NCM = '" & NCM & "'")
                                If dtIBPT.Rows.Count > 0 Then
                                    Dim dblAliqNac As Double = dtIBPT.Rows.Item(0).Item("AliqNac").ToString
                                    Dim dblAliqImp As Double = dtIBPT.Rows.Item(0).Item("AliqImp").ToString

                                    Select Case origemProduto
                                        Case "0", "3", "4", "5"
                                            dblValAprox = (dblTot * dblAliqNac) / 100
                                        Case Else
                                            dblValAprox = (dblTot * dblAliqImp) / 100
                                    End Select
                                Else
                                    dblValAprox = 0
                                End If
                                impostosIncidentes = dblValAprox.ToString("0.00").Replace(",", ".")
                                dblValorAproximado += dblValAprox
                            End If


                            Dim strTrib As String = dtNfe.Rows.Item(0).Item("Tributacao").ToString
                            Dim dblICMS As String = 0
                            Dim strIMCS As String = ""

                            strTrib = CST_ICMS
                            If strTrib = "" Then
                                strTrib = CSOSN
                            End If

                            Select Case strTrib
                                Case "40", "300"
                                    aliquota = "I1"
                                Case "60", "500"
                                    aliquota = "F1"
                                Case "41", "50"
                                    aliquota = "N1"
                                Case "00", "20", "90", "102", "900"
                                    If dtNfe.Rows.Item(0).Item("ICMS").ToString <> "" Then
                                        Dim dblICMSAliq As Double = dtNfe.Rows.Item(0).Item("ICMS").ToString
                                        dblICMS = dblICMSAliq.ToString("0.00")
                                    End If
                                    aliquota = dblICMS.ToString.Replace(",", ".")
                            End Select


                            ' ------------ ICMS -----------
                            '
                            Dim icms As New ICMS
                            icms.totalProd = CDec(Format(dblTot, "0.00"))
                            icms.CST = dtNfe.Rows.Item(0).Item("CST").ToString
                            icms.IPI = CDec(ipi.vIPI)
                            '''''ARRUMAR BC Estabelecida'''''
                            If dblTot.ToString.Equals("") = False Then
                                icms.bcEstabelecida = CDec(dblTot)
                            End If
                            '''''''''''''''''''''''''''''''''
                            icms.modBC = dtNfe.Rows.Item(0).Item("ModBC").ToString
                            If dtNfe.Rows.Item(0).Item("RedBC").ToString.Equals("") = False Then
                                icms.pRedBC = CDec(dtNfe.Rows.Item(0).Item("RedBC").ToString)
                            End If
                            'If DentroEstado = True Then
                            If dtNfe.Rows.Item(0).Item("ICMS").ToString.Equals("") = False Then
                                icms.pICMS = CDec(dtNfe.Rows.Item(0).Item("ICMS").ToString)
                            End If
                            ''''ARRUMAR Mva'''''''
                            If dtNfe.Rows.Item(0).Item("MVaST").ToString.Equals("") = False Then
                                icms.mva = CDec(dtNfe.Rows.Item(0).Item("MVaST").ToString)
                            End If
                            ''''''''''''''''''''''
                            If dtNfe.Rows.Item(0).Item("ICMSST").ToString.Equals("") = False Then
                                icms.pICMSST = CDec(dtNfe.Rows.Item(0).Item("ICMSST").ToString)
                            End If
                            If dtNfe.Rows.Item(0).Item("MVaST").ToString.Equals("") = False Then
                                icms.mvaST = CDec(dtNfe.Rows.Item(0).Item("MVaST").ToString)
                            End If
                            'Else
                            '    icms.pICMS = CDec(ALIQ_FORA)
                            '    If ReaderVar.Item("MVA_EXT").ToString.Equals("") = False Then
                            '        icms.mva = CDec(ReaderVar.Item("MVA_EXT").ToString)
                            '    End If
                            '    icms.pICMSST = CDec(ALIQ_FORA)
                            '    If ReaderVar.Item("MVA_EXT_ST").ToString.Equals("") = False Then
                            '        icms.mvaST = CDec(ReaderVar.Item("MVA_EXT_ST").ToString)
                            '    End If
                            'End If
                            '''''''ARRUMAR BC Estabelecida ST'''''''''''''
                            If dblTot.ToString.Equals("") = False Then
                                icms.bcEstabelecidaST = CDec(dblTot)
                            End If
                            ''''''''''''''''''''''''''''''''''''''''''''
                            icms.modBCST = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                            If dtNfe.Rows.Item(0).Item("RedBCST").ToString.Equals("") = False Then
                                icms.pRedBCST = CDec(dtNfe.Rows.Item(0).Item("RedBCST").ToString)
                            End If
                            icms.gerar()

                            ' BASE ICMS
                            ' ALIQ ICMS
                            ' REDUCAO
                            percentualReducaoBaseCalculo = FormatNumber(CDec(icms.pRedBC), 2)
                            ' MVA
                            'Item.SubItems.Add(FormatNumber(CDec(icms.mva), 2))

                            ' BASE ICMS ST
                            ' ALIQ ICMS ST
                            ICMS_ST_Aliquota = FormatNumber(CDec(icms.pICMSST), 2)
                            ' VALOR ICMS ST
                            ICMS_ST_Valor = FormatNumber(CDec(icms.vICMSST), 2)

                            ' REDUCAO ST
                            ICMS_ST_PercentualReducaoBaseCalculo = FormatNumber(CDec(icms.pRedBCST), 2)
                            ' MVA ST
                            ICMS_ST_PercentualMargemAdicionado = FormatNumber(CDec(icms.mvaST), 2)

                            aliquotaCalculoCredito = dtNfe.Rows.Item(0).Item("CalculoCred").ToString

                            Dim strVCalcCred As String = ""


                            If aliquotaCalculoCredito <> "0,00" And aliquotaCalculoCredito <> "" Then
                                Dim dblCalcCredito As Double = aliquotaCalculoCredito
                                Dim dblcalc As Double = (dblTot * dblCalcCredito) / 100
                                creditoICMSSimples = dblcalc.ToString("0.00")
                            End If



                            modoBaseCalculo = dtNfe.Rows.Item(0).Item("ModBC").ToString
                            ICMS_ST_ModoBaseCalculo = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                        Else
                            MsgBox("Verificar tributação do produto " & descricao & "!", MsgBoxStyle.Information)
                            Return False
                        End If


                    Else
                        MsgBox("Verificar tributação do produto " & descricao & "!", MsgBoxStyle.Information)

                        Return False
                    End If

                    A += 1
                    strProduto = clsXmlSat.Produto(A, codigo, EAN13, descricao, NCM, CFOP, unidadeMedida, quantidade, valorUnitario, "A", strCestProd, strCodigoANP)


                    strICMS = clsXmlSat.ICMS(CST_ICMS, origemProduto, aliquota, impostosIncidentes)


                    strPIS = clsXmlSat.PIS(CST_PIS, valorUnitario, PIS_Aliquota.Replace(",", "."))


                    strCOFINS = clsXmlSat.COFINS(CST_COFINS, valorUnitario, COFINS_Aliquota.Replace(",", "."))

                    strItens &= strProduto & strICMS & strPIS & strCOFINS

                End If
            Next

            Dim dblValorDesc As Double = 0
            If TipoDesconto <> "ITENS" Then
                If strValDesc <> "" Then
                    dblValorDesc = strValDesc
                End If
            End If

            strTotal = clsXmlSat.Total(dblValorDesc.ToString("0.00").Replace(",", "."), dblValorAproximado.ToString("0.00").Replace(",", "."))

            Dim strFormaPagamento As String = ""
            Dim P As Integer
            Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor, FormaPagamento FROM Recebimento where Valor > 0 and CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

            Dim dtTroco As DataTable = CarregarDataTable("SELECT Valor FROM Caixa where CodConfig = " & CodConfig & " and Motivo = 'Troco Venda Nº " & parCodOrdem & "'")
            Dim dblTroco As Double = 0
            If dtTroco.Rows.Count > 0 Then
                If dtTroco.Rows.Item(0).Item("Valor").ToString <> "" Then
                    dblTroco = dtTroco.Rows.Item(0).Item("Valor").ToString
                End If
            End If
            dblValorTotal = dblValorTotal.ToString("0.00")
            Dim dblDif As Double = dblValorTotalConf - dblValorTotal
            dblDif = dblDif.ToString("0.00")

            If dtPag.Rows.Count > 0 Then

                For P = 0 To dtPag.Rows.Count - 1
                    Dim dblValor As Double
                    Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString.ToUpper

                    Dim strFormaPag As String = dtPag.Rows.Item(P).Item("FormaPagamento").ToString

                    If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                        dblValor = dtPag.Rows.Item(P).Item("Valor").ToString
                    End If

                    If P = 0 Then
                        If dblDif > 0 Or dblDif < 0 Then
                            dblValor += dblDif
                        End If
                    End If

                    Dim strP As String = "99"
                    If strPag.ToUpper.Contains("DINHEIRO") Then
                        dblValor += dblTroco
                        dblTroco = 0
                        strP = "01"
                    End If
                    If strPag.Contains("CHEQUE") Then
                        strP = "02"
                    End If
                    If strPag.Contains("CRÉDITO") Then
                        If strPag.Contains("CLIENTE") Then
                            strP = "05"
                        Else
                            strP = "03"
                        End If

                    End If
                    If strPag.Contains("DÉBITO") Then
                        strP = "04"
                    End If

                    strFormaPagamento &= clsXmlSat.Pagamento(strP, dblValor.ToString("0.00").Replace(",", "."))

                Next
            End If

            Dim dtTroca As DataTable = CarregarDataTable("SELECT sum(Qtde * Valor) as Valor FROM Devolucao where Motivo like '%NA VENDA Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
            If dtTroca.Rows.Count > 0 Then
                If dtTroca.Rows.Item(0).Item("Valor").ToString <> "" Then
                    dblValorDevolvido = dtTroca.Rows.Item(0).Item("Valor").ToString
                    strFormaPagamento &= clsXmlSat.Pagamento("99", dblValorDevolvido.ToString("0.00").Replace(",", "."))
                End If
            End If

            If strFormaPagamento <> "" Then
                strPagamento = "<pgto>" & vbCrLf
                strPagamento &= strFormaPagamento
                strPagamento &= "</pgto>"
            End If

            strAdicionais = clsXmlSat.Adicionais("Venda: " & parCodOrdem & " Obrigado, volte sempre!!! Consulte o QRCode deste extrato atraves do App DeOlhoNaNota")

            Atualizar("UPDATE Total Set StatusDAV = 'Faturado' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

            'Inserir("INSERT INTO Operador (Operador, Tipo, Entrada, Data, CodConfig, CodConfigECF) VALUES " & _
            '"('" & Login & "','ValorLiquido'," & Num(dblValorTotal.ToString("0.00")) & ",'" & My.Computer.Clock.LocalTime & "'," & _
            '"" & CodConfig & "," & CodConfigECF & ")")

        Catch ex As Exception

            If MsgBox("Erro ao imprimir o cupom." & vbCrLf & "Deseja realizar o cancelamento deste cupom?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                iRetorno = ImportsDLL.Bematech_FI_CancelaCupom()
                Return False
                Exit Function
            End If

        End Try


        Dim strCabecalho As String = "" '"<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf
        strCabecalho &= "<CFe>" & vbCrLf
        strCabecalho &= "<infCFe versaoDadosEnt=""" & VersaoXmlSAT & """>"
        'strCabecalho &= "<infCFe versaoDadosEnt=""0.06"">"
        'strCabecalho &= "<infCFe versaoDadosEnt=""0.07"">"
        Dim strNota As String = strCabecalho & vbCrLf
        strNota &= strIdentificador & vbCrLf
        strNota &= strEmitente & vbCrLf
        strNota &= strDestinatario & vbCrLf
        strNota &= strItens & vbCrLf
        strNota &= strTotal & vbCrLf
        strNota &= strPagamento & vbCrLf
        strNota &= strAdicionais & vbCrLf
        strNota &= "</infCFe>" & vbCrLf
        strNota &= "</CFe>" & vbCrLf

        strNota = Replace(strNota, "Ç", "C")
        strNota = Replace(strNota, "Á", "A")
        strNota = Replace(strNota, "É", "E")
        strNota = Replace(strNota, "Ê", "E")
        strNota = Replace(strNota, "Í", "I")
        strNota = Replace(strNota, "Ã", "A")
        strNota = Replace(strNota, "&", "E")
        strNota = Replace(strNota, "Õ", "O")
        strNota = Replace(strNota, "Ó", "O")
        strNota = Replace(strNota, "Ô", "O")
        strNota = Replace(strNota, "Ä", "A")
        strNota = Replace(strNota, "À", "A")
        strNota = Replace(strNota, "Ë", "E")
        strNota = Replace(strNota, "Ï", "I")
        strNota = Replace(strNota, "Ö", "A")
        strNota = Replace(strNota, "Ü", "E")
        strNota = Replace(strNota, "Ú", "U")
        strNota = Replace(strNota, "Ù", "U")
        strNota = Replace(strNota, "Â", "A")
        strNota = Replace(strNota, "´", "")
        strNota = Replace(strNota, "º", "")
        strNota = Replace(strNota, "ª", "")
        strNota = Replace(strNota, "–", "-")
        strNota = Replace(strNota, "|", "")
        strNota = Replace(strNota, "Â", "")

        Call SalvarArquivo(strNota, CaminhoPastaSAT & "\" & parCodOrdem & "Pre.xml", False)

        Dim outputEnc As Encoding = New UTF8Encoding(False)

        Dim file As TextWriter = New StreamWriter(CaminhoPastaSAT & "\" & parCodOrdem & ".xml", False, outputEnc)

        Dim reader As New StreamReader(CaminhoPastaSAT & "\" & parCodOrdem & "Pre.xml")

        Dim linha As String = String.Empty

        file.WriteLine("<?xml version=""1.0"" encoding=""UTF-8""?>")

        Do

            linha = reader.ReadLine()

            file.WriteLine(linha)

            If (linha Is Nothing) Then
                Exit Do
            End If

        Loop

        file.Close()

        reader.Close()

        IO.File.Delete(CaminhoPastaSAT & "\" & parCodOrdem & "Pre.xml")
        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""

        If IO.File.Exists(CaminhoPastaSAT & "\" & parCodOrdem & ".xml") Then
            fluxoTexto = New IO.StreamReader(CaminhoPastaSAT & "\" & parCodOrdem & ".xml")
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()
        End If
        Dim cmdLineStr As IntPtr
        If ModeloSAT = "DIMEP" Then
            'SatRetorno = SATFiscalDLL.EnviarDadosVenda(parCodOrdem, NumeroSerieECF, strTexto)

            cmdLineStr = clsDimepSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "ELGIN" Then

            cmdLineStr = clsElginSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

        ElseIf ModeloSAT = "ELGIN 2" Then

            cmdLineStr = clsElginSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

        ElseIf ModeloSAT = "GERTEC" Then

            cmdLineStr = clsGertecSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EPSON" Then

            cmdLineStr = clsEpsonSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EASYS" Then

            cmdLineStr = clsEasysSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "BEMATECHDLL" Then
            cmdLineStr = clsBematechSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "TANCA" Then

            cmdLineStr = clsTancaSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "SWEDA" Then

            cmdLineStr = clsSwedaSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CONTROLID" Then

            cmdLineStr = clsControlidSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CUSTOM" Then

            cmdLineStr = clsCustomSatDLL.EnviarDadosVenda(NumeroSessaoSat(), NumeroSerieECF, strTexto)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        End If

        ' MsgBox(SatRetorno, MsgBoxStyle.Information)
        If SatRetorno.Contains("Emitido com sucesso") = True Or SatRetorno.Contains("Alerta: ") = True Then
            Dim bolSatEmitido As Boolean = False
            'MsgBox(SatRetorno, MsgBoxStyle.Information)
            Dim strChave As String = ""
            Dim strQrCode As String = ""
            Dim vetChave As Array = Split(SatRetorno, "|")
            Dim strCPFDest As String = ""
            strChave = vetChave(8).ToString.Replace("CFe", "")
            strQrCode = vetChave(11).ToString
            Try

                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "ELGIN" Then

                    cmdLineStr = clsElginSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"

                ElseIf ModeloSAT = "ELGIN 2" Then

                    SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "GERTEC" Then

                    SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "EPSON" Then

                    SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "EASYS" Then

                    SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "BEMATECHDLL" Then

                    SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)
                ElseIf ModeloSAT = "TANCA" Then

                    SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "SWEDA" Then

                    SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "CONTROLID" Then

                    SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "CUSTOM" Then

                    SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                End If


            Catch ex As Exception
                Try
                    Dim dtOrdem As DataTable = CarregarDataTable("SELECT Max(Cod) as Cod FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig)
                    Dim strNumSessao As String
                    If dtOrdem.Rows.Count > 0 Then
                        strNumSessao = dtOrdem.Rows.Item(0).Item("Cod").ToString
                    End If
                    If ModeloSAT = "DIMEP" Then
                        cmdLineStr = clsDimepSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                        cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    ElseIf ModeloSAT = "ELGIN" Then
                        cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                        cmdLineStr = clsElginSatDLL.Base64ToAscii()
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)



                    ElseIf ModeloSAT = "ELGIN 2" Then
                        cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)



                    ElseIf ModeloSAT = "GERTEC" Then
                        cmdLineStr = clsGertecSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)


                    ElseIf ModeloSAT = "EPSON" Then
                        cmdLineStr = clsEpsonSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)



                    ElseIf ModeloSAT = "EASYS" Then
                        cmdLineStr = clsEasysSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)



                    ElseIf ModeloSAT = "BEMATECHDLL" Then

                        cmdLineStr = clsBematechSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                        SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)
                    ElseIf ModeloSAT = "TANCA" Then

                        cmdLineStr = clsTancaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                        SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                    ElseIf ModeloSAT = "SWEDA" Then
                        cmdLineStr = clsSwedaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "CONTROLID" Then
                        cmdLineStr = clsControlidSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 6)

                    ElseIf ModeloSAT = "CUSTOM" Then
                        cmdLineStr = clsCustomSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)



                    End If
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                Catch ex2 As Exception
                    MsgBox("Verificar status sat!", MsgBoxStyle.Information)
                    Return True
                    Exit Function
                End Try
            End Try

            If strChave = "" Then
                'Dim strXml As String = SatRetorno
                'Dim intXML As Integer = strXml.Length
                'Dim strChar As String = strXml.Substring(intXML - 1, 1)
                'If strChar <> ">" Then
                '    strXml = strXml & ">"
                'End If

                'strXml = strXml.Replace("'", "")

                'Dim dtNF As DataTable = GerarSat.ArquivoNfeXml(strXml, "/CFe/infCFe", "Id Varchar(50) './@Id'", "")
                'If dtNF.Rows.Count > 0 Then
                '    strChave = dtNF.Rows.Item(0).Item("Id").ToString
                '    strChave = dtNF.Rows.Item(0).Item("Id").ToString.Replace("CFe", "")
                'End If
                Dim vetRetornoXml As Array = Split(SatRetorno, "Id=""CFe")
                strChave = vetRetornoXml(1).ToString.Substring(0, 44)
            End If
            If strChave <> "" Then

                Call SalvarArquivo(SatRetorno, CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", False)
                'Atualizar("UPDATE Total Set ChaveSAT = '" & strChave & "' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

                Dim strPastaBackup As String = CaminhoPastaSAT.Replace("Remessas", "Backup") & "\" & CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "") & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00")

                If IO.Directory.Exists(strPastaBackup) = False Then
                    IO.Directory.CreateDirectory(strPastaBackup)
                End If
                If IO.File.Exists(strPastaBackup & "\CFe" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", strPastaBackup & "\CFe" & strChave & ".xml")

                End If


                Dim strBackupEmail As String = CaminhoPastaSAT.Replace("Remessas", "BackupEmail")

                If IO.Directory.Exists(strBackupEmail) = False Then
                    IO.Directory.CreateDirectory(strBackupEmail)
                End If
                If IO.File.Exists(strBackupEmail & "\CFe" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", strBackupEmail & "\CFe" & strChave & ".xml")

                End If

                SatRetorno = SatRetorno.Replace("'", "")
                Dim strNumCupom As String = ""
                'Dim dtNF As DataTable = GerarSat.ArquivoNfeXml(SatRetorno, "/CFe/infCFe/ide", "nCFe varchar(20)", "")
                'If dtNF.Rows.Count > 0 Then
                '    strNumCupom = dtNF.Rows.Item(0).Item("nCFe").ToString
                'End If

                Dim vetRetornoXml As Array = Split(SatRetorno, "<nCFe>")
                vetRetornoXml = Split(vetRetornoXml(1), "</nCFe>")
                strNumCupom = vetRetornoXml(0)


                Try
                    Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
                    Dim ns As System.Xml.XmlNamespaceManager = New System.Xml.XmlNamespaceManager(oXML.NameTable)
                    Dim NodeRoot As System.Xml.XmlNode
                    oXML.Load(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml")
                    NodeRoot = oXML.SelectSingleNode("CFe/infCFe/total", ns)
                    dblValorTotal = NodeRoot.Item("vCFe").InnerText.ToString.Replace(".", ",")
                Catch ex As Exception

                End Try
           
             

                Inserir("INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, CNPJ, Data, " & _
                "NumeroCupom, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig) VALUES (" & parCodOrdem & "," & _
                "'" & strChave & "','" & NumeroSerieECF & "','" & NumeroEcfECF & "','" & CNPJECF & "'," & _
                "'" & My.Computer.Clock.LocalTime & "','" & strNumCupom & "'," & Num(dblValorTotal) & ",'" & strCPF & "'," & _
                "'" & strQrCode & "'," & CodConfig & ")")

                Atualizar("UPDATE SATFiscal set CodOrdem2 = " & parCodOrdem & " where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)


            End If
            Dim bolImp As Boolean = True
            If MensImpCupomSAT = True Then

                If MsgBox("Deseja imprimir o cupom SAT?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    bolImp = False
                End If

            End If
            If bolImp = True Then
                Try

                    GerarSat.GerarCupomSatAccess(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", strChave)
                    'GerarSat.GerarCupomSat(SatRetorno, strChave)
                    bolSatEmitido = True
                Catch ex As Exception
                    bolSatEmitido = False
                End Try

                If bolSatEmitido = False Then
                    Try
                        'GerarSat.GerarCupomSat(SatRetorno, strChave)
                        GerarSat.GerarCupomSatAccess(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", strChave)

                    Catch ex As Exception
                        MsgBox(ex.Message & vbCrLf & "Falha ao gerar o cupom!", MsgBoxStyle.Information)
                    End Try

                End If
            Else
                bolSatEmitido = True
            End If
        Else

            Dim vetSat As Array = Split(SatRetorno, "|")

            If vetSat.Length > 3 Then
                Dim strMensagem As String = vetSat(3)

                If strMensagem.ToUpper.Contains("BLOQUEADO") Then
                    MsgBox("SAT Bloqueado." & vbCrLf & "Venda não finalizada!", MsgBoxStyle.Information)
                Else
                    MsgBox(strMensagem & vbCrLf & "Venda não finalizada!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox(SatRetorno & vbCrLf & "Venda não finalizada!", MsgBoxStyle.Information)
            End If

            Return False
            Exit Function
        End If

        Return True

    End Function
    
    Public Shared Function ImprimirCupomCancelamentoSatDll(ByVal parCodOrdem As String, ByVal parChave As String, ByVal parCPF As String, ByVal parQrCode As String) As Boolean




        Dim strCPF As String = parCPF.Replace(".", "").Replace("-", "").Replace("/", "")

        Dim strTipoPessoa As String = "F"

        If strCPF <> "00000000000" Then
            If Len(strCPF) = 14 Then
                strTipoPessoa = "J"
            End If
        Else
            If ModeloSAT <> "TANCA" Then
                strCPF = ""
            End If
        End If
        If ModeloSAT <> "TANCA" Then
            strCPF = ""
        End If

        strCPF = ""
        'EraSystemsCNPJ = "16.716.114/0001-72"
        If SatTeste = True Then
            EraSystemsCNPJ = "16.716.114/0001-72"

        End If
        Dim strIdentificador As String = clsXmlSat.Identificador(EraSystemsCNPJ.Replace(".", "").Replace("/", "").Replace("-", ""), AssinaturaAC, NumeroEcfECF)

        Dim strEmitente As String = clsXmlSat.Emitente("", "", "")

        Dim strDestinatario As String = clsXmlSat.Destinatario(strTipoPessoa, strCPF.ToString.Replace(".", "").Replace("-", "").Replace("/", ""), "")

        Dim strTotal As String = clsXmlSat.Total("", "")

        Dim strAdicionais As String = clsXmlSat.Adicionais("")

        Dim strCabecalho As String = "" '"<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf
        strCabecalho &= "<CFeCanc>" & vbCrLf
        strCabecalho &= "<infCFe chCanc=""CFe" & parChave & """>"

        Dim strNota As String = strCabecalho & vbCrLf
        strNota &= strIdentificador & vbCrLf

        strNota &= strEmitente & vbCrLf
        strNota &= strDestinatario & vbCrLf
        strNota &= strTotal & vbCrLf
        strNota &= strAdicionais & vbCrLf


        strNota &= "</infCFe>" & vbCrLf
        strNota &= "</CFeCanc>" & vbCrLf

        strNota = Replace(strNota, "Ç", "C")
        strNota = Replace(strNota, "Á", "A")
        strNota = Replace(strNota, "É", "E")
        strNota = Replace(strNota, "Ê", "E")
        strNota = Replace(strNota, "Í", "I")
        strNota = Replace(strNota, "Ã", "A")
        strNota = Replace(strNota, "&", "E")
        strNota = Replace(strNota, "Õ", "O")
        strNota = Replace(strNota, "Ó", "O")
        strNota = Replace(strNota, "Ô", "O")
        strNota = Replace(strNota, "Ä", "A")
        strNota = Replace(strNota, "À", "A")
        strNota = Replace(strNota, "Ë", "E")
        strNota = Replace(strNota, "Ï", "I")
        strNota = Replace(strNota, "Ö", "A")
        strNota = Replace(strNota, "Ü", "E")
        strNota = Replace(strNota, "Ú", "U")
        strNota = Replace(strNota, "Ù", "U")
        strNota = Replace(strNota, "Â", "A")
        strNota = Replace(strNota, "´", "")
        strNota = Replace(strNota, "º", "")
        strNota = Replace(strNota, "ª", "")

        Call SalvarArquivo(strNota, CaminhoPastaSAT & "\Canc" & parCodOrdem & "Pre.xml", False)

        Dim outputEnc As Encoding = New UTF8Encoding(False)

        Dim file As TextWriter = New StreamWriter(CaminhoPastaSAT & "\Canc" & parCodOrdem & ".xml", False, outputEnc)

        Dim reader As New StreamReader(CaminhoPastaSAT & "\Canc" & parCodOrdem & "Pre.xml")

        Dim linha As String = String.Empty

        file.WriteLine("<?xml version=""1.0"" encoding=""UTF-8""?>")

        Do

            linha = reader.ReadLine()

            file.WriteLine(linha)

            If (linha Is Nothing) Then
                Exit Do
            End If

        Loop

        file.Close()

        reader.Close()

        IO.File.Delete(CaminhoPastaSAT & "\Canc" & parCodOrdem & "Pre.xml")
        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""

        If IO.File.Exists(CaminhoPastaSAT & "\Canc" & parCodOrdem & ".xml") Then
            fluxoTexto = New IO.StreamReader(CaminhoPastaSAT & "\Canc" & parCodOrdem & ".xml")
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()
        End If
        Dim cmdLineStr As IntPtr
        Try
            If ModeloSAT = "DIMEP" Then
                cmdLineStr = clsDimepSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN" Then
                cmdLineStr = clsElginSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN 2" Then
                cmdLineStr = clsElginSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            ElseIf ModeloSAT = "GERTEC" Then
                cmdLineStr = clsGertecSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EPSON" Then
                cmdLineStr = clsEpsonSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EASYS" Then
                cmdLineStr = clsEasysSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            ElseIf ModeloSAT = "BEMATECHDLL" Then
                cmdLineStr = clsBematechSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "TANCA" Then
                cmdLineStr = clsTancaSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            ElseIf ModeloSAT = "SWEDA" Then
                cmdLineStr = clsSwedaSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CONTROLID" Then
                cmdLineStr = clsControlidSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CUSTOM" Then
                cmdLineStr = clsCustomSatDLL.CancelarUltimaVenda(NumeroSessaoSat(), NumeroSerieECF, "CFe" & parChave, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            End If
          

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try

        If SatRetorno.Contains("Cupom cancelado com sucesso") = True Then
            Dim bolSatEmitido As Boolean = False

            Try
                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "ELGIN" Then
                    cmdLineStr = clsElginSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "ELGIN 2" Then
                    SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"

                ElseIf ModeloSAT = "GERTEC" Then
                    SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "EPSON" Then
                    SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"

                ElseIf ModeloSAT = "EASYS" Then
                    SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "BEMATECHDLL" Then

                    SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "TANCA" Then

                    SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                ElseIf ModeloSAT = "SWEDA" Then
                    SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"

                ElseIf ModeloSAT = "CONTROLID" Then
                    SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"

                ElseIf ModeloSAT = "CUSTOM" Then
                    SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)

                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFeCanc")
                    SatRetorno = vetXML(0) & "</CFeCanc>"
                End If
             
            Catch ex As Exception
                Try
                    Dim dtOrdem As DataTable = CarregarDataTable("SELECT Max(Cod) as Cod FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig)
                    Dim strNumSessao As String
                    If dtOrdem.Rows.Count > 0 Then
                        strNumSessao = dtOrdem.Rows.Item(0).Item("Cod").ToString
                    End If
                    If ModeloSAT = "DIMEP" Then
                        cmdLineStr = clsDimepSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    ElseIf ModeloSAT = "ELGIN" Then
                        cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        cmdLineStr = clsElginSatDLL.Base64ToAscii()
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    ElseIf ModeloSAT = "ELGIN 2" Then
                        cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "GERTEC" Then
                        cmdLineStr = clsGertecSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "EPSON" Then
                        cmdLineStr = clsEpsonSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "EASYS" Then
                        cmdLineStr = clsEasysSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "BEMATECHDLL" Then
                        cmdLineStr = clsBematechSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)
                    ElseIf ModeloSAT = "TANCA" Then
                        cmdLineStr = clsTancaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                    ElseIf ModeloSAT = "SWEDA" Then
                        cmdLineStr = clsSwedaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "CONTROLID" Then
                        cmdLineStr = clsControlidSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)
                    ElseIf ModeloSAT = "CUSTOM" Then
                        cmdLineStr = clsCustomSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)

                        SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

                        SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)
                    End If


                Catch ex2 As Exception
                    MsgBox("Verificar status sat!", MsgBoxStyle.Information)
                    Return True
                    Exit Function
                End Try
            End Try

            Dim strChave As String = ""
            Dim vetChave As Array = Split(SatRetorno, """CFe")
            vetChave = Split(vetChave(1), """")
            strChave = vetChave(0)
            If strChave <> "" Then
                If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento")) = False Then
                    IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento"))
                End If
                Call SalvarArquivo(SatRetorno, CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChave & ".xml", False)
                'Atualizar("UPDATE Total Set ChaveSAT = '" & strChave & "' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

                Dim strPastaBackup As String = CaminhoPastaSAT.Replace("Remessas", "Backup") & "\" & CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "") & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00") & "\Cancelamento"

                If IO.Directory.Exists(strPastaBackup) = False Then
                    IO.Directory.CreateDirectory(strPastaBackup)
                End If
                If IO.File.Exists(strPastaBackup & "\CFeCanc" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChave & ".xml", strPastaBackup & "\CFeCanc" & strChave & ".xml")
                End If


                Dim strBackupEmail As String = CaminhoPastaSAT.Replace("Remessas", "BackupEmail")

                If IO.Directory.Exists(strBackupEmail) = False Then
                    IO.Directory.CreateDirectory(strBackupEmail)
                End If
                If IO.File.Exists(strBackupEmail & "\CFeCanc" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChave & ".xml", strBackupEmail & "\CFeCanc" & strChave & ".xml")

                End If


                Dim strNumCupom As String = ""

                Dim strChar As String = SatRetorno.Substring(SatRetorno.Length - 1, 1)
                If strChar <> ">" Then
                    SatRetorno = SatRetorno & ">"
                End If
                SatRetorno = SatRetorno.Replace("'", "")
                Dim dtNF As DataTable = GerarSat.ArquivoNfeXml(SatRetorno, "/CFeCanc/infCFe/ide", "nCFe varchar(20)", "")
                If dtNF.Rows.Count > 0 Then
                    strNumCupom = dtNF.Rows.Item(0).Item("nCFe").ToString
                End If

                Atualizar("UPDATE SATFiscal SET ChaveCancelamento = '" & strChave & "', NumeroCupomCancelado = '" & strNumCupom & "', CodOrdem2 = 0 where Chave = '" & parChave & "' and CodConfig = " & CodConfig)
                Atualizar("UPDATE SATFiscal SET CodOrdem2 = 0 where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
            End If

            Try
                GerarSat.GerarCupomCancelamentoSat(SatRetorno, parQrCode)
                bolSatEmitido = True
            Catch ex As Exception
                bolSatEmitido = False
            End Try

            If bolSatEmitido = False Then
                Try
                    GerarSat.GerarCupomCancelamentoSat(SatRetorno, parQrCode)
                Catch ex As Exception
                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                End Try

            End If
        Else

            Dim vetSat As Array = Split(SatRetorno, "|")

            If vetSat.Length > 3 Then
                Dim strMensagem As String = vetSat(3)

                If strMensagem.ToUpper.Contains("BLOQUEADO") Then
                    MsgBox("SAT Bloqueado.", MsgBoxStyle.Information)
                Else
                    MsgBox(strMensagem & "!", MsgBoxStyle.Information)
                End If
            Else
                MsgBox(SatRetorno & "!", MsgBoxStyle.Information)
            End If

            Return False
        End If
        MsgBox("Cupom cancelado com sucesso!", MsgBoxStyle.Information)
        Return True

    End Function
    Public Shared Function ConfigurarRede(ByVal parTipoInterface As String, ByVal parNomeRede As String, ByVal parSeguranca As String, _
    ByVal parSenhaInterface As String, ByVal parTipoRede As String, ByVal parIPRede As String, ByVal parMascara As String, _
    ByVal parGateway As String, ByVal parDNS1 As String, ByVal parDNS2 As String, ByVal parProxy As String, _
    ByVal parIPProxy As String, ByVal parPorta As String, ByVal parUsuario As String, ByVal parSenhaProxy As String) As String


        Dim strTipoInterface As String = clsXmlSat.TipoInterface(parTipoInterface, parNomeRede, parSeguranca, parSenhaInterface)

        Dim strTipoRede As String = clsXmlSat.TipoRede(parTipoRede, parIPRede, parMascara, parGateway, parDNS1, parDNS2)

        Dim strProxy As String = clsXmlSat.Proxy(parProxy, parIPProxy, parPorta, parUsuario, parSenhaProxy)

        Dim strCabecalho As String = ""
        strCabecalho &= "<config>" & vbCrLf


        Dim strNota As String = strCabecalho & vbCrLf
        strNota &= strTipoInterface & vbCrLf
        strNota &= strTipoRede & vbCrLf
        strNota &= strProxy & vbCrLf
        strNota &= "</config>" & vbCrLf

        strNota = Replace(strNota, "Ç", "C")
        strNota = Replace(strNota, "Á", "A")
        strNota = Replace(strNota, "É", "E")
        strNota = Replace(strNota, "Í", "I")
        strNota = Replace(strNota, "Ã", "A")
        strNota = Replace(strNota, "&", "E")
        strNota = Replace(strNota, "Õ", "O")
        strNota = Replace(strNota, "Ó", "O")
        strNota = Replace(strNota, "Ô", "O")
        strNota = Replace(strNota, "Ä", "A")
        strNota = Replace(strNota, "À", "A")
        strNota = Replace(strNota, "Ë", "E")
        strNota = Replace(strNota, "Ï", "I")
        strNota = Replace(strNota, "Ö", "A")
        strNota = Replace(strNota, "Ü", "E")
        strNota = Replace(strNota, "Ú", "U")
        strNota = Replace(strNota, "Ù", "U")
        strNota = Replace(strNota, "º", "")
        strNota = Replace(strNota, "ª", "")


        Dim intNumSessao As Integer = NumeroSessaoSatAtivacao()

        Call SalvarArquivo(strNota, CaminhoPastaSAT & "\ConfigRedePre.xml", False)

        Dim outputEnc As Encoding = New UTF8Encoding(False)

        Dim file As TextWriter = New StreamWriter(CaminhoPastaSAT & "\ConfigRede" & intNumSessao & ".xml", False, outputEnc)

        Dim reader As New StreamReader(CaminhoPastaSAT & "\ConfigRedePre.xml")

        Dim linha As String = String.Empty

        file.WriteLine("<?xml version=""1.0"" encoding=""UTF-8""?>")

        Do

            linha = reader.ReadLine()

            file.WriteLine(linha)

            If (linha Is Nothing) Then
                Exit Do
            End If

        Loop

        file.Close()

        reader.Close()

        IO.File.Delete(CaminhoPastaSAT & "\ConfigRedePre.xml")

        Dim fluxoTexto As IO.StreamReader
        Dim strTexto As String = ""

        If IO.File.Exists(CaminhoPastaSAT & "\ConfigRede" & intNumSessao & ".xml") Then
            fluxoTexto = New IO.StreamReader(CaminhoPastaSAT & "\ConfigRede" & intNumSessao & ".xml")
            strTexto = fluxoTexto.ReadToEnd
            fluxoTexto.Close()
        End If
        Dim cmdLineStr As IntPtr
        Dim strCodAtivacao As String = NumeroSerieECF
        If strCodAtivacao = "" Then
            strCodAtivacao = "00000000"
        End If

        Try
            If ModeloSAT = "DIMEP" Then
                cmdLineStr = clsDimepSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN" Then
                cmdLineStr = clsElginSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "ELGIN 2" Then
                cmdLineStr = clsElginSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "GERTEC" Then
                cmdLineStr = clsGertecSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EPSON" Then
                cmdLineStr = clsEpsonSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "EASYS" Then
                cmdLineStr = clsEasysSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "BEMATECHDLL" Then
                cmdLineStr = clsBematechSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "TANCA" Then
                cmdLineStr = clsTancaSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "SWEDA" Then
                cmdLineStr = clsSwedaSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)

            ElseIf ModeloSAT = "CONTROLID" Then
                cmdLineStr = clsControlidSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            ElseIf ModeloSAT = "CUSTOM" Then
                cmdLineStr = clsCustomSatDLL.ConfigurarInterfaceDeRede(intNumSessao, strCodAtivacao, strTexto)
                SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
            End If


        Catch ex As Exception
            SatRetorno = ex.Message

        End Try
        Return SatRetorno
        

    End Function

    Public Shared Function VerificarUltimaSessao(ByVal parNumSessao As String) As String
        Dim strChave As String = ""
        Dim strQrCode As String = ""
        Dim strCPF As String = ""
        Dim dblValorTotal As Double = 0
        Dim strData As String = ""
        Dim dtData As Date
        Dim strNumSessao As String = "0"

        If parNumSessao <> "" Then
            strNumSessao = parNumSessao
        Else
            Dim dtOrdem As DataTable = CarregarDataTable("SELECT Max(Cod) as Cod FROM Ordens where Tabela = 'Sat' and CodConfig = " & CodConfig & " and CodEmitente = " & CodConfigECF)

            If dtOrdem.Rows.Count > 0 Then
                strNumSessao = dtOrdem.Rows.Item(0).Item("Cod").ToString
            End If
        End If
     

        Dim cmdLineStr As IntPtr
        If ModeloSAT = "DIMEP" Then
            cmdLineStr = clsDimepSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "TANCA" Then
            cmdLineStr = clsTancaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "ELGIN" Then
            cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "ELGIN 2" Then
            cmdLineStr = clsElginSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "GERTEC" Then
            cmdLineStr = clsGertecSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EPSON" Then
            cmdLineStr = clsEpsonSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "EASYS" Then
            cmdLineStr = clsEasysSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "BEMATECHDLL" Then
            cmdLineStr = clsBematechSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "SWEDA" Then
            cmdLineStr = clsSwedaSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CONTROLID" Then
            cmdLineStr = clsControlidSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        ElseIf ModeloSAT = "CUSTOM" Then
            cmdLineStr = clsCustomSatDLL.ConsultarNumeroSessao(NumeroSessaoSat(), NumeroSerieECF, strNumSessao)
            SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
        End If

        'MsgBox(SatRetorno, MsgBoxStyle.Information)
        If SatRetorno.Contains("Emitido com sucesso") = True Or SatRetorno.Contains("Alerta: ") = True Then
            Try

                Dim vetChave As Array = Split(SatRetorno, "|")

                strChave = vetChave(8).ToString.Replace("CFe", "")
                dblValorTotal = vetChave(9)
                strCPF = vetChave(10)
                strData = vetChave(7)
                Dim strData2 As String = ""
                Dim I As Integer
                For I = 0 To 13
                    Dim strChar As String = strData.Substring(I, 1)
                    strData2 &= strChar
                    Select Case I
                        Case 3, 5
                            strData2 &= "/"
                        Case 7
                            strData2 &= " "
                        Case 9, 11
                            strData2 &= ":"
                    End Select
                Next
                dtData = strData2
                strQrCode = vetChave(11).ToString
                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "ELGIN" Then
                    cmdLineStr = clsElginSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"

                ElseIf ModeloSAT = "ELGIN 2" Then
                    SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "GERTEC" Then
                    SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "EPSON" Then
                    SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "EASYS" Then
                    SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "BEMATECHDLL" Then
                    SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)

                ElseIf ModeloSAT = "TANCA" Then
                    SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                ElseIf ModeloSAT = "SWEDA" Then
                    SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "CONTROLID" Then
                    SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                ElseIf ModeloSAT = "CUSTOM" Then
                    SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)
                    Dim strRR As String = SatRetorno
                    Dim vetXML As Array = Split(SatRetorno, "</CFe")
                    SatRetorno = vetXML(0) & "</CFe>"
                End If

                'MsgBox(SatRetorno, MsgBoxStyle.Information)
            Catch ex2 As Exception
                MsgBox("Verificar status sat!", MsgBoxStyle.Information)
                Exit Function
            End Try



            If strChave <> "" Then
                If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml") = False Then
                    Call SalvarArquivo(SatRetorno, CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", False)
                End If

                'Atualizar("UPDATE Total Set ChaveSAT = '" & strChave & "' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup")) = False Then
                    IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Backup"))
                End If
                If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup") & "\CFe" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\CFe" & strChave & ".xml", CaminhoPastaSAT.Replace("Remessas", "Backup") & "\CFe" & strChave & ".xml")

                End If
                Dim vetVenda As Array = Split(SatRetorno, "<infCpl>")
                vetVenda = Split(vetVenda(1), " Obrigado")
                Dim strVenda As String = vetVenda(0).ToString.Replace("Venda: ", "")

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM SATFiscal where CodOrdem = " & strVenda & " and CodConfig=" & CodConfig)
                If dt.Rows.Count = 0 Then

                    Dim strNumCupom As String = ""
                    Dim dtNF As DataTable = GerarSat.ArquivoNfeXml(SatRetorno, "/CFe/infCFe/ide", "nCFe varchar(20)", "")
                    If dtNF.Rows.Count > 0 Then
                        strNumCupom = dtNF.Rows.Item(0).Item("nCFe").ToString
                    End If

                    Inserir("INSERT INTO SATFiscal(CodOrdem, Chave, NumeroSerie, NumeroCaixa, CNPJ, Data, " & _
                    "NumeroCupom, ValorTotal, CFPDest, AssinaturaQrCode, CodConfig) VALUES (" & strVenda & "," & _
                    "'" & strChave & "','" & NumeroSerieECF & "','" & NumeroEcfECF & "','" & CNPJECF & "'," & _
                    "'" & dtData & "','" & "" & "'," & Num(dblValorTotal) & ",'" & strCPF & "'," & _
                    "'" & strQrCode & "'," & CodConfig & ")")
                End If




            End If
            Dim bolSatEmitido As Boolean = False

            Try
                GerarSat.GerarCupomSat(SatRetorno, strChave)
                bolSatEmitido = True
            Catch ex As Exception
                bolSatEmitido = False
            End Try

            If bolSatEmitido = False Then
                Try
                    GerarSat.GerarCupomSat(SatRetorno, strChave)
                Catch ex As Exception
                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                End Try

            End If
        ElseIf SatRetorno.Contains("Cupom cancelado com sucesso") = True Then
            Dim bolSatEmitido As Boolean = False

            Try
                If ModeloSAT = "DIMEP" Then
                    cmdLineStr = clsDimepSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "ELGIN" Then
                    cmdLineStr = clsElginSatDLL.Base64ToAscii()
                    SatRetorno = Marshal.PtrToStringAnsi(cmdLineStr)
                ElseIf ModeloSAT = "ELGIN 2" Then
                    SatRetorno = clsElginSatDLL.Base64ToAscii2(SatRetorno, 6)
                ElseIf ModeloSAT = "GERTEC" Then
                    SatRetorno = clsGertecSatDLL.Base64ToAscii2(SatRetorno, 6)
                ElseIf ModeloSAT = "EPSON" Then
                    SatRetorno = clsEpsonSatDLL.Base64ToAscii2(SatRetorno, 6)
                ElseIf ModeloSAT = "EASYS" Then
                    SatRetorno = clsEasysSatDLL.Base64ToAscii2(SatRetorno, 6)

                ElseIf ModeloSAT = "BEMATECHDLL" Then

                    SatRetorno = clsBematechSatDLL.Base64ToAscii(SatRetorno, 6)
                ElseIf ModeloSAT = "TANCA" Then

                    SatRetorno = clsTancaSatDLL.Base64ToAscii(SatRetorno, 6)
                ElseIf ModeloSAT = "SWEDA" Then

                    SatRetorno = clsSwedaSatDLL.Base64ToAscii2(SatRetorno, 6)
                ElseIf ModeloSAT = "CONTROLID" Then
                    SatRetorno = clsControlidSatDLL.Base64ToAscii2(SatRetorno, 6)
                ElseIf ModeloSAT = "CUSTOM" Then
                    SatRetorno = clsCustomSatDLL.Base64ToAscii2(SatRetorno, 6)
                End If

            Catch ex As Exception
                MsgBox("Verificar status sat!", MsgBoxStyle.Information)
                Exit Function
            End Try


            Dim vetChave As Array = Split(SatRetorno, """CFe")
            vetChave = Split(vetChave(1), """")
            strChave = vetChave(0)
            If strChave <> "" Then
                If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento")) = False Then
                    IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento"))
                End If
                Call SalvarArquivo(SatRetorno, CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChave & ".xml", False)
                'Atualizar("UPDATE Total Set ChaveSAT = '" & strChave & "' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup\Cancelamento")) = False Then
                    IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Backup\Cancelamento"))
                End If
                If IO.File.Exists(CaminhoPastaSAT.Replace("Remessas", "Backup\Cancelamento") & "\CFeCanc" & strChave & ".xml") = False Then
                    IO.File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChave & ".xml", CaminhoPastaSAT.Replace("Remessas", "Backup\Cancelamento") & "\CFeCanc" & strChave & ".xml")
                End If

                Dim strNumCupom As String = ""
                Dim dtNF As DataTable = GerarSat.ArquivoNfeXml(SatRetorno, "/CFeCanc/infCFe/ide", "nCFe varchar(20)", "")
                If dtNF.Rows.Count > 0 Then
                    strNumCupom = dtNF.Rows.Item(0).Item("nCFe").ToString
                End If

                dtNF = GerarSat.ArquivoNfeXml(SatRetorno, "/CFeCanc/infCFe", "Id Varchar(50) './@Id', chCanc Varchar(50) './@chCanc'", "")

                'parChave = dtNF.Rows.Item(0).Item("Id").ToString
                Dim strChaveVenda As String = dtNF.Rows.Item(0).Item("chCanc").ToString.Replace("CFe", "")
                Dim strChaveCanc As String = dtNF.Rows.Item(0).Item("Id").ToString.Replace("CFe", "")

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Satfiscal where Chave = '" & strChaveVenda & "'")
                If dt.Rows.Count > 0 Then
                    Dim strCodigoSat As String = dt.Rows.Item(0).Item("Codigo").ToString
                    Atualizar("UPDATE SATFiscal SET ChaveCancelamento = '" & strChave & "', NumeroCupomCancelado = '" & strNumCupom & "' where Codigo = " & strCodigoSat)

                End If
            End If

            Try
                GerarSat.GerarCupomCancelamentoSat(SatRetorno, "")
                bolSatEmitido = True
            Catch ex As Exception
                bolSatEmitido = False
            End Try

            If bolSatEmitido = False Then
                Try
                    GerarSat.GerarCupomCancelamentoSat(SatRetorno, "")
                Catch ex As Exception
                    MsgBox("Falha ao gerar o cupom!", MsgBoxStyle.Information)
                End Try

            End If
        Else
            Dim vetSat As Array = Split(SatRetorno, "|")


            Return SatRetorno

            'If vetSat.Length > 3 Then
            '    Dim strMensagem As String = vetSat(3)

            '    If strMensagem.ToUpper.Contains("BLOQUEADO") Then
            '        MsgBox("SAT Bloqueado." & vbCrLf & "!", MsgBoxStyle.Information)
            '    Else

            '    End If
            'Else
            '    Return SatRetorno
            'End If
        End If
    End Function
End Class
