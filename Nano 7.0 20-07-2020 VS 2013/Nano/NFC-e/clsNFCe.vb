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
Public Class clsNFCe
    Public Shared Function GerarChave(ByVal parTipoEmi As Integer, ByVal parCodUF As String, ByVal parCNPJEmitente As String, _
    ByVal parCodNf As String, ByVal parNumNf As String, ByVal parModelo As String, ByVal parSerie As Integer, ByRef parDV As String) As String

        Dim strAno As String = Format(CDate(Date.Today), "yy")
        Dim strMes As String = Format(CDate(Date.Today), "MM")
        Dim strSerie As String = Format(CInt(parSerie), "000")

        Dim strChave As String = parCodUF & strAno & strMes & parCNPJEmitente.Replace(".", "").Replace("-", "").Replace("/", "") & parModelo & strSerie & parNumNf & parTipoEmi & parCodNf
        parDV = validachavenfe(strChave, False)
        strChave = strChave & parDV
        Return strChave
    End Function
    Public Shared Function ImprimirCupomNFCe(ByVal parCodOrdem As String, ByRef parCod As Integer) As Boolean
        Try

            If PastaRemessas = "" Then
                MsgBox("Configure o caminho da pasta Remessa!", MsgBoxStyle.Information)
                Return False
                Exit Function
            End If
            Dim A As Integer
            Dim dtPed As DataTable = CarregarDataTable("SELECT ValDesc, ValAcre, CodProdInterno, Produto, " & _
            "convert(Numeric(15,7),ValorUnitario) as ValorUnitario, convert(numeric(15,3),Qtd) as Qtd, ValorTotal, " & _
            "UM, Total.CodCli, Total.CodConfig, Total.Total, Total.Troco, Total.Recebido, Total.Data, Pedido.CodProd, " & _
            "CPFCliente as CPF, Cliente.Nome, Pedido.Devolvido, Total.NFP, Produto.CodigoInterno as CodInterno, Produto.CodigoBarra, Produto.UnidadeMedida  FROM ((Pedido left join  Produto on " & _
            "Pedido.CodProd = Produto.Codigo) left join Total on Pedido.CodOrdem = Total.CodOrdem) left join " & _
            "Cliente on Total.CodCli = Cliente.Codigo where Pedido.CodOrdem = " & parCodOrdem & " and " & _
            "Pedido.CodConfig =" & CodConfig & " and Total.CodConfig =" & CodConfig & " and Produto.Tipo <> 'SERVIÇO' and Produto.Tipo <> 'CONSUMO' and Pedido.TipoItens <> 'CONSUMO'")


            If dtPed.Rows.Count = 0 Then
                Return False
                Exit Function
            End If


            Dim strCliente As String = dtPed.Rows.Item(0).Item("Nome").ToString
            Dim strCPF As String = dtPed.Rows.Item(0).Item("CPF").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
            Dim bolNFP As Boolean = dtPed.Rows.Item(0).Item("NFP")
            Dim strCodCli As String = dtPed.Rows.Item(0).Item("CodCli").ToString
            Dim strTipoPessoa As String = "F"
            If bolNFP = False Then
                strCPF = "00000000000"
            Else
                If Len(strCPF) = 14 Then
                    strTipoPessoa = "J"
                End If
            End If

            'Dim strTipoDesc As String = "D"
            'Dim strValDesc As String = "0"
            'Dim dblValDesc As Double = dtPed.Rows.Item(0).Item("ValDesc").ToString
            'If dblValDesc <= 0 Then
            '    dblValDesc = dtPed.Rows.Item(0).Item("ValAcre").ToString
            '    If dblValDesc > 0 Then
            '        strTipoDesc = "A"
            '        strValDesc = dblValDesc.ToString("0.00")
            '    End If
            'Else
            '    strValDesc = dblValDesc.ToString("0.00")
            'End If



            Dim strDesconto As String = dtPed.Rows.Item(0).Item("ValDesc").ToString
            Dim dlbDescontoItem As Double = 0
            Dim dblValorDesc As Double = 0
            Dim strDescontoItem As String = "0"
            Dim strDescontoTotal As String = "0"
            If TipoDesconto = "TOTAL" Then
            
                If strDesconto <> "0,000" Then
                    Dim dblValDesc As Double = strDesconto
                    dblValorDesc = dblValDesc.ToString("0.00")
                    Dim dtPed2 As DataTable = CarregarDataTable("SELECT Pedido.CodProdInterno as CodProdInterno " & _
                    "FROM (Pedido left join Total on Pedido.CodOrdem = Total.CodOrdem and Pedido.CodConfig = Total.CodConfig) left join Produto on Pedido.CodProd = " & _
                    "Produto.Codigo where Pedido.CodOrdem = " & parCodOrdem & " and Pedido.CodConfig = " & CodConfig & " order by Pedido.Codigo")

                    dlbDescontoItem = dblValorDesc / dtPed2.Rows.Count
                    strDescontoItem = dlbDescontoItem.ToString("0.00")

                    dblValorDesc = dlbDescontoItem.ToString("0.00") * dtPed.Rows.Count

                    strDescontoTotal = dblValorDesc
                Else
                    dblValorDesc = "0"
                End If

            Else
                dblValorDesc = "0"
            End If

            If SatTeste = True Then
                EraSystemsCNPJ = "16.716.114/0001-72"

            End If

            Dim dblValorDevolvido As Double


            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, UF, CodUF, " & _
            "Pais, CodPais, CRT, Telefone, NatOp, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete, ObsCont, SerialName, " & _
            "PastaBackup, Email, IndFinal, IndPres, IdDest, VersaoXml, AutXml, PorValorAproximado, Complemento, TZDCce FROM ConfigNfe where Codigo = " & CodEmitente)

            If dt.Rows.Count > 0 Then
                PorValorAproximado = dt.Rows.Item(0).Item("PorValorAproximado").ToString
                Dim strNomeEmitente As String = dt.Rows.Item(0).Item("Razao").ToString
                Dim strFantasiaEmitente As String = dt.Rows.Item(0).Item("Fantasia").ToString
                Dim strCNPJEmitente As String = dt.Rows.Item(0).Item("CNPJ").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
                Dim strIEEmitente As String = dt.Rows.Item(0).Item("IE").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
                Dim strCRT As String = dt.Rows.Item(0).Item("CRT").ToString
                Dim strEnderecoEmitente As String = dt.Rows.Item(0).Item("Endereco").ToString
                Dim strBairroEmitente As String = dt.Rows.Item(0).Item("Bairro").ToString
                Dim strNumeroEmitente As String = dt.Rows.Item(0).Item("Numero").ToString
                Dim strCepEmitente As String = dt.Rows.Item(0).Item("Cep").ToString.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "")
                Dim strUFEmitente As String = dt.Rows.Item(0).Item("UF").ToString
                Dim UFEmitente As String = dt.Rows.Item(0).Item("UF").ToString
                Dim strCidadeEmitente As String = dt.Rows.Item(0).Item("Cidade").ToString
                Dim strCodMunEmitente As String = dt.Rows.Item(0).Item("CodMun").ToString
                Dim strCodUFEmitente As String = dt.Rows.Item(0).Item("CodUF").ToString
                Dim strPaisEmitente As String = dt.Rows.Item(0).Item("Pais").ToString
                Dim strCodPaisEmitente As String = dt.Rows.Item(0).Item("CodPais").ToString
                Dim strTelefoneEmitente As String = dt.Rows.Item(0).Item("Telefone").ToString.Replace(".", "").Replace("-", "").Replace("/", "").Replace("(", "").Replace(")", "")
                Dim strComplementoEmitente As String = dt.Rows.Item(0).Item("Complemento").ToString
                Dim strIMEmitente As String = ""
                Dim strCNAEEmitente As String = ""



                Dim strIndPag As String = "0"

                Dim strNatOp As String = dt.Rows.Item(0).Item("NatOp").ToString
                Dim strModelo As String = "65"
                Dim strSerie As String = dt.Rows.Item(0).Item("Serie").ToString
                Dim strTipoNf As String = dt.Rows.Item(0).Item("TipoNF").ToString
                Dim strTipoImp As String = "4" 'dt.Rows.Item(0).Item("TipoImp")
                Dim strTipoEmi As String = dt.Rows.Item(0).Item("TipoEmi")
                Dim strTipoAmb As String = dt.Rows.Item(0).Item("TipoAmb")


                Dim strFinalidade As String = dt.Rows.Item(0).Item("FinNfe")
                Dim strProcEmi As String = dt.Rows.Item(0).Item("ProcEmi").ToString
                Dim strVersaoProc As String = dt.Rows.Item(0).Item("VerProc").ToString
                Dim strObsCont As String = dt.Rows.Item(0).Item("ObsCont").ToString
                Dim strModFrete As String = dt.Rows.Item(0).Item("ModFrete")
                Dim strIndFinal As String = dt.Rows.Item(0).Item("IndFinal")
                Dim strIndPres As String = "1" 'dt.Rows.Item(0).Item("IndPres")
                Dim strIdDest As String = dt.Rows.Item(0).Item("IdDest")

                Dim dtTotal As DataTable = CarregarDataTable("SELECT Max(convert(integer,CodNf)) as CodNF FROM NFCe where CodEmitente = " & CodEmitente & " and StatusEmitente = '" & StatusEmitente & "'")
                Dim strCodNF As String = Format(CInt(GerarCodigoOrdemNFCe("NFCe", CodEmitente) + 2), "00000000")
                If dtTotal.Rows.Count > 0 Then
                    If dtTotal.Rows.Item(0).Item("CodNF").ToString <> "" Then
                        strCodNF = Format(CInt(dtTotal.Rows.Item(0).Item("CodNF") + 1), "00000000")
                    Else
                        strCodNF = Format(CInt(GerarCodigoOrdemNFCe("NFCe", CodEmitente) + 2), "00000000")
                    End If
                End If

                Dim intCodOrdem As Integer = GerarCodigoOrdemNFCe("NFCe", CodEmitente)
                parCod = intCodOrdem
                Dim strNumNF As String = Format(CInt(intCodOrdem), "000000000")

                Dim strDV As String
                Dim strChave As String = GerarChave(strTipoEmi, strCodUFEmitente, strCNPJEmitente, strCodNF, strNumNF, strModelo, strSerie, strDV)
                Dim strTZD As String = dt.Rows.Item(0).Item("TZDCce").ToString
                Dim strDEMi As String = Format(CDate(Date.Today), "yyyy-MM-dd").ToString
                strDEMi = strDEMi & "T" & Format(CDate(My.Computer.Clock.LocalTime), "HH:mm:ss").ToString & strTZD
                DataEmissao = strDEMi

                If Inserir("Insert into Ordens (Cod, Tabela, CodConfig, CodEmitente, StatusEmitente) Values(" & _
                  "" & intCodOrdem & ",'NFCe'," & CodConfig & "," & CodEmitente & ",'" & StatusEmitente & "')") = False Then

                    MsgBox("NFC-e não emitida!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If

                'Inserir("INSERT INTO NFCe (CodOrdem, NumNF, CodNF, Chave, Data, ValorTotal, CFPDest, CodConfig, CodEmitente, StatusEmitente) VALUES (" & parCodOrdem & "," & _
                '"'" & strNumNF & "','" & strCodNF & "','" & strChave & "','" & Date.Today & "'," & Num(dtPed.Rows.Item(0).Item("Total")) & ",'" & strCPF & "'," & CodConfig & "," & CodEmitente & ",'" & StatusEmitente & "')")

                Dim strIdentificador As String = clsXmlNFCe.Identificador(strCodUFEmitente, strCodNF, strNatOp, strIndPag, strModelo, strSerie, _
                intCodOrdem, strDEMi, strTipoNf, strIdDest, strCodMunEmitente, strTipoImp, strTipoEmi, strDV, strTipoAmb, strFinalidade, strIndFinal, _
                strIndPres, strProcEmi, strVersaoProc)

                Dim strEmitente As String = clsXmlNFCe.Emitente(strCNPJEmitente, strNomeEmitente, strFantasiaEmitente, strEnderecoEmitente, _
                strNumeroEmitente, strBairroEmitente, strCodMunEmitente, strCidadeEmitente, strUFEmitente, strCepEmitente, _
                strCodPaisEmitente, strPaisEmitente, strTelefoneEmitente, strIEEmitente, strCRT, strComplementoEmitente, strIMEmitente, strCNAEEmitente)

                Dim dtCli As DataTable = CarregarDataTable("SELECT Nome, RGIE, CPF, Endereco, Numero, Bairro, CodMunicipio, " & _
                "Cidade, Estado, Cep, CodPais, NomePais, Telefone, Email, Complemento FROM Cliente where Codigo = " & strCodCli)

                Dim strDestinatario As String = ""
                Dim strIndIEDest As String = "9"
                Dim strUFDest As String = ""
                If dtCli.Rows.Count > 0 Then
                    Dim strCNPJDest As String = ""
                    Dim strCPFDest As String = ""
                    Dim strIEDest As String = ""
                    strCNPJDest = Replace(Replace(Replace(strCPF, ".", "").ToString, "-", "").ToString, "/", "")
                    If Len(strCNPJDest) = 14 Then
                        If dtCli.Rows.Item(0).Item("RGIE").ToString <> "" Then
                            strIEDest = (Replace(Replace(Replace(dtCli.Rows.Item(0).Item("RGIE").ToString, ".", "").ToString, "/", "").ToString, "-", "").ToString)
                            strIndIEDest = "1"
                            If strIEDest = "ISENTO" Then
                                strIndIEDest = "2"
                                If UFEmitente = "SP" Then
                                    strIndIEDest = "9"
                                End If
                            End If
                        Else
                            strIndIEDest = "9"
                        End If
                    Else
                        strCNPJDest = Replace(Replace(strCPF, ".", "").ToString, "-", "")
                    End If

                    Dim strNomeDest As String = dtCli.Rows.Item(0).Item("Nome").ToString
                    If strNomeDest.Length > 59 Then
                        strNomeDest = strNomeDest.Substring(0, 59)
                    End If
                    Dim strComplemento As String = dtCli.Rows.Item(0).Item("Complemento").ToString
                    If strComplemento <> "" Then
                        strComplemento = " - " & strComplemento
                    End If

                    Dim strEndDest As String = dtCli.Rows.Item(0).Item("Endereco").ToString & strComplemento

                    If strNomeDest = "CONSUMIDOR" Then
                        strEndDest = ""
                    End If


                    Dim strNumDest As String = "SN"
                    If dtCli.Rows.Item(0).Item("Numero").ToString <> "" Then
                        strNumDest = dtCli.Rows.Item(0).Item("Numero").ToString
                    End If

                    Dim strBairroDest As String = dtCli.Rows.Item(0).Item("Bairro").ToString
                    Dim strCodMunDest As String = dtCli.Rows.Item(0).Item("CodMunicipio").ToString
                    Dim strMunicipioDest As String = dtCli.Rows.Item(0).Item("Cidade").ToString
                    strUFDest = dtCli.Rows.Item(0).Item("Estado").ToString
                    Dim strCepDest As String = dtCli.Rows.Item(0).Item("Cep").ToString.ToString.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "")
                    Dim strCodPaisDest As String = dtCli.Rows.Item(0).Item("CodPais").ToString
                    Dim strNomePaisDest As String = dtCli.Rows.Item(0).Item("NomePais").ToString


                    Dim strTelDest As String = dtCli.Rows.Item(0).Item("Telefone").ToString
                    If strTelDest <> "" Then
                        strTelDest = Replace(Replace(Replace(Replace(dtCli.Rows.Item(0).Item("Telefone").ToString, "(", "").ToString, ")", "").ToString, " ", "").ToString, "-", "").ToString()

                    End If

                    Dim strEmailDest As String = dtCli.Rows.Item(0).Item("Email").ToString


                    Dim strComplementoDest As String = dtCli.Rows.Item(0).Item("Complemento").ToString




                    strDestinatario = clsXmlNFCe.Destinatario(strTipoPessoa, strCNPJDest, strNomeDest, strEndDest, _
                    strNumDest, strBairroDest, strCodMunDest, strMunicipioDest, strUFDest, strCepDest, strCodPaisDest, _
                    strNomePaisDest, strTelDest, strIEDest, strEmailDest, strIndIEDest, strComplementoDest)
                Else
                    MsgBox("Verificar dados do destinatario!", MsgBoxStyle.Information)
                    Return False
                    Exit Function
                End If

                Dim strProduto As String = ""
                Dim strIPI As String = ""
                Dim strPIS As String = ""
                Dim strCOFINS As String = ""
                Dim strItens As String = ""
                Dim strICMSUFDest As String = ""

                Dim dblValICMS, dblValICMSST, dblValIPI, dblValPIS, dblValCOFINS, dblValProd, dblVBC, dblVBCST, dblValImp As Double
                Dim dblValUni, dblQtd, dblPercent, dblResto, dblResul, dblItens, dblSomaDifDesc, dblTotalAproximado As Double
                Dim dblTotalFCPDest As Double = 0
                Dim dblTotalICMSUFDest As Double = 0
                Dim dblTotalICMSUFRemet As Double = 0

                Dim dblDevolucao As Double = 0
                Dim dblValorTotalConf As Double

                'dtPed = CarregarDataTable("Select Pedido.Codigo, Pedido.Qtd, Pedido.CodProd, Pedido.Produto, " & _
                '"Pedido.ValorUnitario, Pedido.ValorTotal, Pedido.CodProdInterno, Produto.UnidadeMedida, " & _
                '"Produto.CodigoInterno as CodInterno, Produto.CodigoBarra from Pedido left join Produto on " & _
                '"Pedido.CodProd = Produto.Codigo where CodOrdem =" & parCodOrdem & " and Produto.Tipo <> 'CONSUMO' " & _
                '"and Produto.Tipo <> 'SERVIÇO' and Pedido.CodConfig =" & CodConfig)

                Dim I As Integer

                For I = 0 To dtPed.Rows.Count - 1


                    Dim strNomeProd As String = dtPed.Rows.Item(I).Item("Produto").ToString

                    If dtPed.Rows.Item(I).Item("CodProd").ToString = "" Then
                        MsgBox("Produto " & strNomeProd & " não cadastrado no sistema!", MsgBoxStyle.Information)
                        Exit Function
                    End If

                    Dim strCodProd As String = dtPed.Rows.Item(I).Item("CodProd").ToString
                    Dim strQtdProd As String = dtPed.Rows.Item(I).Item("Qtd").ToString
                    Dim strValUnitProd As String = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.0000")
                    Dim strValTotalProd As String = Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00")
                    Dim strCodigoInternoProd As String = dtPed.Rows.Item(I).Item("CodProdInterno").ToString
                    Dim strUMProd As String = CorrigirUnidadeMedida(dtPed.Rows.Item(I).Item("UnidadeMedida").ToString)


                    Dim dblValorConf As Double = Format(dtPed.Rows.Item(I).Item("ValorUnitario"), "0.00")

                    If dblValorConf < 0 Then
                        dblDevolucao += dblValorConf
                    Else
                        dblValorConf = strQtdProd * dblValorConf
                        dblValorTotalConf += dblValorConf.ToString("0.00")


                        Dim strCodBarraProd As String = dtPed.Rows.Item(I).Item("CodigoBarra").ToString
                        If ValidarCodigoBarraGTIN(strCodBarraProd) = False Then
                            strCodBarraProd = "SEM GTIN"
                        End If

                        Dim strCSTIPI As String = ""
                        Dim strCSTPIS As String = ""
                        Dim strCSTCOFINS As String = ""
                        Dim strCodEnq As String = ""
                        Dim strBCIPI As String = ""
                        Dim strPerIPI As String = ""
                        Dim strValIPI As String = ""
                        Dim strBCPIS As String = ""
                        Dim strPerPIS As String = ""
                        Dim strValPIS As String = ""
                        Dim strBCCOFINS As String = ""
                        Dim strPerCOFINS As String = ""
                        Dim strValCOFINS As String = ""

                        Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, " & _
                        "CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & " SAT'")
                        Dim ipi As New IPI

                        If dtTrib.Rows.Count > 0 Then
                            If dtTrib.Rows.Item(0).Item("CSTPIS").ToString = "" Then
                                MsgBox("Verificar o CST PIS do produto " & strNomeProd & "!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If
                            If dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString = "" Then
                                MsgBox("Verificar o CST COFINS do produto " & strNomeProd & "!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If

                            strCSTIPI = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                            strCSTPIS = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                            strCSTCOFINS = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                            strCodEnq = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                            strPerCOFINS = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString

                            ' ------------ IPI -----------
                            '
                            ipi.CST = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                            ipi.totalProd = CDec(Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00"))
                            Dim strPercentualIPI As String = "0"
                            If dtTrib.Rows.Item(0).Item("PerIPI").ToString <> "" Then
                                strPercentualIPI = CDec(dtTrib.Rows.Item(0).Item("PerIPI").ToString)
                            End If
                            ipi.pIPI = CDec(strPercentualIPI)
                            ipi.gerar()
                            ' BASE IPI
                            strBCIPI = FormatNumber(CDec(ipi.vBC), 2)
                            ' ALIQ IPI
                            strPerIPI = FormatNumber(CDec(ipi.pIPI), 2)
                            ' VALOR IPI
                            strValIPI = FormatNumber(CDec(ipi.vIPI), 2)

                            ' ------------ PIS -----------
                            '
                            Dim pis As New PIS
                            pis.CST = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                            pis.totalProd = CDec(Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00"))
                            Dim strPercentualPIS As String = "0"
                            If dtTrib.Rows.Item(0).Item("PerPIS").ToString <> "" Then
                                strPercentualPIS = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                            End If
                            pis.pPis = CDec(strPercentualPIS)
                            pis.gerar()
                            ' BASE PIS
                            strBCPIS = FormatNumber(CDec(pis.vBC), 2)
                            ' ALIQ PIS
                            strPerPIS = FormatNumber(CDec(pis.pPis), 2)
                            ' VALOR PIS
                            strValPIS = FormatNumber(CDec(pis.vPis), 2)

                            ' ------------ COFINS -----------
                            '
                            Dim cofins As New COFINS
                            cofins.CST = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                            cofins.totalProd = CDec(Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00"))
                            Dim strPercentualCofins As String = "0"
                            If dtTrib.Rows.Item(0).Item("PerCOFINS").ToString <> "" Then
                                strPercentualCofins = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
                            End If
                            cofins.pCofins = CDec(strPercentualCofins)
                            cofins.gerar()
                            ' BASE COFINS
                            strBCCOFINS = FormatNumber(CDec(cofins.vBC), 2)
                            ' ALIQ COFINS
                            strPerCOFINS = FormatNumber(CDec(cofins.pCofins), 2)
                            ' VALOR COFINS
                            strValCOFINS = FormatNumber(CDec(cofins.vCofins), 2)
                        Else
                            MsgBox("Verificar o código de enquadramento do IPI do produto " & strNomeProd & "!", MsgBoxStyle.Information)
                            Return False
                            Exit Function
                        End If


                        Dim strCestProd As String = ""
                        Dim strNCMProd As String = ""
                        Dim strCSTICMS As String = ""
                        Dim strCFOPProd As String = ""
                        Dim strOrigemProd As String = ""
                        Dim strValAproxProd As String = ""

                        Dim strModBC As String = ""
                        Dim strICMS As String = ""
                        Dim strRedBC As String = ""
                        Dim strModBCST As String = ""
                        Dim strRedBCST As String = ""
                        Dim strMVaST As String = ""
                        Dim strICMSST As String = ""
                        Dim strCalculoCred As String = ""
                        Dim strCodigoANP As String = ""
                        Dim strUFComb As String = ""
                        Dim strBCICMS As String = ""
                        Dim strPerICMS As String = ""
                        Dim strValICMS As String = ""
                        Dim strBCICMSST As String = ""
                        Dim strPerICMSST As String = ""
                        Dim strValICMSST As String = ""
                        Dim strValBCUFDest As String = ""
                        Dim strPerFCPUFDest As String = ""
                        Dim strPerICMSUFDest As String = ""
                        Dim strPerICMSInter As String = ""
                        Dim strPerICMSInterPart As String = ""
                        Dim strValFCPUFDest As String = ""
                        Dim strValICMSUFDest As String = ""
                        Dim strValICMSUFRemet As String = ""
                        Dim strValCalcCred As String = ""
                        Dim strDescANP As String = ""
                        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, " & _
                        "ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, " & _
                        "ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb, Cest, PerFCPUF, PerICMSUF FROM Nfe where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & " SAT'")

                        If dtNfe.Rows.Count > 0 Then

                            If dtNfe.Rows.Item(0).Item("CST").ToString <> "" Then
                                Dim strEXTIPI As String = dtNfe.Rows.Item(0).Item("EXTIPI").ToString

                                If dtNfe.Rows.Item(0).Item("NCM").ToString <> "" Then
                                    If dtNfe.Rows.Item(0).Item("NCM").ToString.Length < 8 Then
                                        If dtNfe.Rows.Item(0).Item("NCM").ToString <> "99" Then
                                            MsgBox("O produto " & strNomeProd & " esta com NCM invalido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                        End If
                                    End If
                                Else
                                    MsgBox("O produto " & strNomeProd & " esta sem a NCM!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                                End If

                                strCestProd = dtNfe.Rows.Item(0).Item("Cest").ToString
                                strNCMProd = dtNfe.Rows.Item(0).Item("NCM").ToString
                                strCSTICMS = dtNfe.Rows.Item(0).Item("CST").ToString

                                If strCSTICMS <> "" Then
                                    If strCRT = "3" Then
                                        If strCSTICMS.Length > 2 Then
                                            strCSTICMS = ""
                                            MsgBox("O produto " & strNomeProd & " esta com CST/CSOSN inválido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                        End If
                                    Else
                                        If strCSTICMS.Length = 2 Then
                                            strCSTICMS = ""
                                            MsgBox("O produto " & strNomeProd & " esta com CST/CSOSN inválido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                        End If
                                    End If
                                End If

                                If dtNfe.Rows.Item(0).Item("Cest").ToString = "" Then
                                    If strTipoAmb = "2" Then
                                        If strCSTICMS = "10" Or strCSTICMS = "30" Or strCSTICMS = "60" Or strCSTICMS = "70" Or strCSTICMS = "90" Or strCSTICMS = "201" Or strCSTICMS = "202" Or strCSTICMS = "203" Or strCSTICMS = "500" Or strCSTICMS = "900" Then
                                            MsgBox("O produto " & strNomeProd & " esta com Cest inválido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                        End If
                                    End If
                                Else
                                    If dtNfe.Rows.Item(0).Item("Cest").ToString.Length <> 7 Then
                                        If strCSTICMS = "10" Or strCSTICMS = "30" Or strCSTICMS = "60" Or strCSTICMS = "70" Or strCSTICMS = "90" Or strCSTICMS = "201" Or strCSTICMS = "202" Or strCSTICMS = "203" Or strCSTICMS = "500" Or strCSTICMS = "900" Then
                                            MsgBox("O produto " & strNomeProd & " esta com Cest inválido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                        End If
                                    End If
                                End If


                                strCFOPProd = dtNfe.Rows.Item(0).Item("CFOP").ToString

                                If dtNfe.Rows.Item(0).Item("CFOP").ToString = "" Then
                                    MsgBox("O produto " & strNomeProd & " esta sem a CFOP!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                                Else
                                    Select Case dtNfe.Rows.Item(0).Item("CFOP").ToString
                                        Case "5101", "5102", "5103", "5104", "5115", "5401", "5403", "5405", "5653", "5656", "5667", "5933"
                                        Case Else
                                            MsgBox("O produto " & strNomeProd & " esta com o CFOP inválido!", MsgBoxStyle.Information)
                                            Return False
                                            Exit Function
                                    End Select

                                End If

                                strOrigemProd = dtNfe.Rows.Item(0).Item("Origem").ToString
                                If dtNfe.Rows.Item(0).Item("Origem").ToString = "" Then
                                    MsgBox("O produto " & strNomeProd & " esta sem a origem!", MsgBoxStyle.Information)
                                    Return False
                                    Exit Function
                                End If

                                Dim dblTot As Double = dtPed.Rows.Item(I).Item("ValorTotal")

                                If DeOlhoNoImposto = True Then
                                    If PorValorAproximado = "" Then
                                        Dim dblValAprox As Double = 0
                                        Dim dtIBPT As DataTable = CarregarDataTable("SELECT AliqNac, AliqImp FROM TabelaIBPT " & _
                                        "where NCM = '" & dtNfe.Rows.Item(0).Item("NCM").ToString & "'")
                                        If dtIBPT.Rows.Count > 0 Then
                                            Dim dblAliqNac As Double = dtIBPT.Rows.Item(0).Item("AliqNac").ToString
                                            Dim dblAliqImp As Double = dtIBPT.Rows.Item(0).Item("AliqImp").ToString

                                            Select Case dtNfe.Rows.Item(0).Item("Origem").ToString
                                                Case "0", "3", "4", "5"
                                                    dblValAprox = (dblTot * dblAliqNac) / 100
                                                Case Else
                                                    dblValAprox = (dblTot * dblAliqImp) / 100
                                            End Select
                                            strValAproxProd = dblValAprox.ToString("0.00")

                                        Else
                                            strValAproxProd = "0,00"

                                        End If
                                    Else
                                        Dim dblValA As Double = PorValorAproximado
                                        dblValA = (dblTot * dblValA) / 100
                                        strValAproxProd = dblValA.ToString("0.00")
                                    End If

                                End If

                                strModBC = dtNfe.Rows.Item(0).Item("ModBC").ToString
                                strICMS = dtNfe.Rows.Item(0).Item("ICMS").ToString
                                strRedBC = dtNfe.Rows.Item(0).Item("RedBC").ToString
                                strModBCST = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                                strRedBCST = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                                strMVaST = dtNfe.Rows.Item(0).Item("MVaST").ToString
                                strICMSST = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                                strCalculoCred = dtNfe.Rows.Item(0).Item("CalculoCred").ToString

                                If strCSTICMS = "101" Then
                                    If strCalculoCred <> "0,00" And strCalculoCred <> "" Then
                                        Dim dblcalc As Double = (CDbl(strValTotalProd) * CDbl(strCalculoCred)) / 100
                                        strValCalcCred += dblcalc.ToString("0.00")
                                    End If
                                End If

                                strCodigoANP = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                                If strCodigoANP <> "" Then
                                    If strCodigoANP.Contains(" | ") = True Then
                                        Dim vetANP As Array = Split(strCodigoANP, " | ")
                                        strCodigoANP = vetANP(0)
                                        strDescANP = vetANP(1)
                                    End If
                                End If
                                strUFComb = dtNfe.Rows.Item(0).Item("UFComb").ToString

                                ' ------------ ICMS -----------
                                '
                                Dim icms As New ICMS
                                icms.totalProd = CDec(Format(dtPed.Rows.Item(I).Item("ValorTotal"), "0.00"))
                                icms.CST = dtNfe.Rows.Item(0).Item("CST").ToString
                                icms.IPI = CDec(ipi.vIPI)
                                '''''ARRUMAR BC Estabelecida'''''
                                If dtPed.Rows.Item(I).Item("ValorTotal").ToString.Equals("") = False Then
                                    icms.bcEstabelecida = CDec(dtPed.Rows.Item(I).Item("ValorTotal").ToString)
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
                                If dtPed.Rows.Item(I).Item("ValorTotal").ToString.Equals("") = False Then
                                    icms.bcEstabelecidaST = CDec(dtPed.Rows.Item(I).Item("ValorTotal").ToString)
                                End If
                                ''''''''''''''''''''''''''''''''''''''''''''
                                icms.modBCST = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                                If dtNfe.Rows.Item(0).Item("RedBCST").ToString.Equals("") = False Then
                                    icms.pRedBCST = CDec(dtNfe.Rows.Item(0).Item("RedBCST").ToString)
                                End If
                                icms.gerar()

                                ' BASE ICMS
                                strBCICMS = FormatNumber(CDec(icms.vBC), 2)
                                ' ALIQ ICMS
                                strPerICMS = FormatNumber(CDec(icms.pICMS), 2)
                                ' VALOR ICMS
                                strValICMS = FormatNumber(CDec(icms.vICMS), 2)
                                ' REDUCAO
                                strRedBC = FormatNumber(CDec(icms.pRedBC), 2)
                                ' MVA
                                'Item.SubItems.Add(FormatNumber(CDec(icms.mva), 2))

                                ' BASE ICMS ST
                                strBCICMSST = FormatNumber(CDec(icms.vBCST), 2)
                                ' ALIQ ICMS ST
                                strPerICMSST = FormatNumber(CDec(icms.pICMSST), 2)
                                ' VALOR ICMS ST
                                strValICMSST = FormatNumber(CDec(icms.vICMSST), 2)

                                ' REDUCAO ST
                                strRedBCST = FormatNumber(CDec(icms.pRedBCST), 2)
                                ' MVA ST
                                strMVaST = FormatNumber(CDec(icms.mvaST), 2)

                                If strIdDest = "2" And strIndIEDest = "9" And _
                                strIndFinal = "1" And strUFEmitente <> strUFDest Then
                                    Dim dblPerFCPUF As Double = 0
                                    Dim dblPerICMSUF As Double = 0
                                    Dim dblVBUFDEst As Double = dblTot
                                    Dim dblPerICMSInter As Double = clsICMSUFInter.AliquotaInterestadual(strUFEmitente, strUFDest)
                                    'dblPerICMSInter = 12
                                    Dim dblICMSPartDest As Double = clsICMSUFInter.AliquotaPartilhaDestino()
                                    Dim dblICMSPartOrigem As Double = clsICMSUFInter.AliquotaPartilhaOrigem()
                                    Dim dblValFCPUFDest As Double = 0
                                    Dim dblValICMSUFDest As Double = 0
                                    Dim dblValICMSUFRemet As Double = 0

                                    If dtNfe.Rows.Item(0).Item("PerFCPUF").ToString <> "" Then
                                        dblPerFCPUF = dtNfe.Rows.Item(0).Item("PerFCPUF")
                                        'dblPerFCPUF = 2
                                    End If
                                    If dtNfe.Rows.Item(0).Item("PerICMSUF").ToString <> "" Then
                                        dblPerICMSUF = dtNfe.Rows.Item(0).Item("PerICMSUF")
                                        'dblPerICMSUF = 17
                                    End If

                                    If dblPerFCPUF > 0 Then
                                        dblValFCPUFDest = (dblVBUFDEst * dblPerFCPUF) / 100
                                    End If

                                    Dim dblICMSDestino As Double = ((dblVBUFDEst * dblPerICMSUF) / 100) - ((dblVBUFDEst * dblPerICMSInter) / 100)

                                    dblValICMSUFDest = ((dblICMSDestino * dblICMSPartDest) / 100) + dblValFCPUFDest
                                    dblValICMSUFRemet = (dblICMSDestino * dblICMSPartOrigem) / 100

                                    strValBCUFDest = dblVBUFDEst.ToString("0.00")
                                    strPerFCPUFDest = dblPerFCPUF.ToString("0.00")
                                    strPerICMSUFDest = dblPerICMSUF.ToString("0.00")
                                    strPerICMSInter = dblPerICMSInter.ToString("0.00")
                                    strPerICMSInterPart = dblICMSPartDest.ToString("0.00")

                                    strValFCPUFDest = dblValFCPUFDest.ToString("0.00")
                                    strValICMSUFDest = dblValICMSUFDest.ToString("0.00")
                                    strValICMSUFRemet = dblValICMSUFRemet.ToString("0.00")
                                End If
                            Else
                                MsgBox("Verificar tributação do produto " & strNomeProd & "!", MsgBoxStyle.Information)
                                Return False
                                Exit Function
                            End If


                        Else
                            MsgBox("Verificar tributação do produto " & strNomeProd & "!", MsgBoxStyle.Information)
                            Return False
                            Exit Function
                        End If



                        If strBCICMS <> "" Then
                            dblVBC += strBCICMS
                        End If
                        If strValICMS <> "" Then
                            dblValICMS += strValICMS
                        End If

                        If strBCICMSST <> "" Then
                            dblVBCST += strBCICMSST
                        End If

                        If strValICMSST <> "" Then
                            dblValICMSST += strValICMSST
                        End If

                        If strValIPI <> "" Then
                            dblValIPI += strValIPI
                        End If

                        If strValPIS <> "" Then
                            dblValPIS += strValPIS
                        End If

                        If strValCOFINS <> "" Then
                            dblValCOFINS += strValCOFINS
                        End If

                        If strValTotalProd <> "" Then
                            dblValProd += strValTotalProd
                        End If

                        If strValAproxProd <> "" Then
                            dblTotalAproximado += strValAproxProd
                        End If

                        If strValFCPUFDest <> "" Then
                            dblTotalFCPDest += strValFCPUFDest
                        End If
                        If strValICMSUFDest <> "" Then
                            dblTotalICMSUFDest += strValICMSUFDest
                        End If
                        If strValAproxProd <> "" Then
                            dblTotalICMSUFRemet += strValAproxProd
                        End If
                        A += 1

                        strProduto = clsXmlNFCe.Produto(A, strCodigoInternoProd, strCodBarraProd, strNomeProd, strNCMProd, _
                        strCFOPProd, strUMProd, strQtdProd.Replace(",", "."), strValUnitProd.Replace(",", "."), strValTotalProd.Replace(",", "."), "", "", "1", _
                        strCodigoANP, strUFComb, strCestProd, "", "", "", "", _
                        "", "", "", "", "", "", _
                        "", "", "", strDescontoItem.Replace(",", "."), strDescANP)


                        strICMS = clsXmlNFCe.ICMS(strCSTICMS, strOrigemProd, strModBC, strBCICMS.Replace(",", "."), strRedBC.Replace(",", "."), _
                        strPerICMS.Replace(",", "."), strValICMS.Replace(",", "."), strModBCST, strMVaST.Replace(",", "."), _
                        strRedBCST.Replace(",", "."), strBCICMSST.Replace(",", "."), strICMSST.Replace(",", "."), strValICMSST.Replace(",", "."), _
                        strCalculoCred.Replace(",", "."), strValCalcCred.Replace(",", "."), strValAproxProd.Replace(",", "."))

                        'If strCSTIPI <> "" Then
                        'strIPI = clsXmlNFCe.IPI(strCodEnq, strCSTIPI, strBCIPI.Replace(",", "."), strPerIPI.Replace(",", "."), strValIPI.Replace(",", "."))
                        'Else
                        strIPI = ""
                        'End If

                        strPIS = clsXmlNFCe.PIS(strCSTPIS, strBCPIS.Replace(",", "."), strPerPIS.Replace(",", "."), strValPIS.Replace(",", "."))

                        Dim bolUFDest As Boolean = False
                        If strIdDest = "2" And strIndIEDest = "9" And strIndFinal = "1" And strUFEmitente <> strUFDest Then
                            strICMSUFDest = clsXmlNFCe.ICMSUFDest(strValBCUFDest.Replace(",", "."), strPerFCPUFDest.Replace(",", "."), _
                            strPerICMSUFDest.Replace(",", "."), strPerICMSInter.Replace(",", "."), strPerICMSInterPart.Replace(",", "."), _
                            strValFCPUFDest.Replace(",", "."), strValICMSUFDest.Replace(",", "."), strValAproxProd.Replace(",", "."))
                            bolUFDest = True
                        End If

                        strCOFINS = clsXmlNFCe.COFINS(strCSTCOFINS, strBCCOFINS.Replace(",", "."), strPerCOFINS.Replace(",", "."), strValCOFINS.Replace(",", "."), bolUFDest)

                        strItens &= strProduto & strICMS & strIPI & strPIS & strCOFINS & strICMSUFDest
                    End If
                Next


                'dblDevolucao = (dblDevolucao - dblDevolucao) - dblDevolucao

                Dim strTotalProduto As String = dblValProd.ToString("0.00")
                Dim strTotalBC As String = dblVBC.ToString("0.00")
                Dim strTotalBCST As String = dblVBCST.ToString("0.00")
                Dim strTotalICMS As String = dblValICMS.ToString("0.00")
                Dim strTotalICMSST As String = dblValICMSST.ToString("0.00")
                Dim strTotalIPI As String = dblValIPI.ToString("0.00")
                Dim strTotalPIS As String = dblValPIS.ToString("0.00")
                Dim strTotalCOFINS As String = dblValCOFINS.ToString("0.00")

                Dim dblTotal As Double = dblValICMSST + dblValIPI + dblValProd + dblValImp


                Dim strTotalValorAproximado As String = dblTotalAproximado.ToString("0.00")


                Dim strTotalFCPDest As String = dblTotalFCPDest.ToString("0.00")
                Dim strTotalICMSUFDest As String = dblTotalICMSUFDest.ToString("0.00")
                Dim strTotalICMSUFRemet As String = dblTotalICMSUFRemet.ToString("0.00")

                If TipoDesconto = "TOTAL" Then
                    If dblValorDesc > 0 Then
                        dblTotal = dblTotal - dblValorDesc
                    End If
                End If

                Dim strTotalNFCe As String = dblTotal.ToString("0.00")


                TotalNFCe = strTotalNFCe.Replace(",", ".")
                TotalICMS = strTotalICMS.Replace(",", ".")
                CPFDestinatario = strCPF



                Dim strTotal As String = clsXmlNFCe.Total(strTotalBC.Replace(",", "."), strTotalICMS.Replace(",", "."), _
                strTotalBCST.Replace(",", "."), strTotalICMSST.Replace(",", "."), strTotalProduto.Replace(",", "."), _
                "0.00", "0.00", dblValorDesc.ToString("0.00").Replace(",", "."), "0.00", strTotalIPI.Replace(",", "."), strTotalPIS.Replace(",", "."), _
                strTotalCOFINS.Replace(",", "."), "0.00", strTotalNFCe.Replace(",", "."), strTotalValorAproximado.Replace(",", "."), _
                strTotalFCPDest.Replace(",", "."), strTotalICMSUFDest.Replace(",", "."), strTotalICMSUFRemet.Replace(",", "."), _
                strICMSUFDest.Replace(",", "."))

                Dim strTransportadora As String = clsXmlNFCe.Transportadora(strModFrete, "", "", "", _
                "", "", "", "", "", "", "", "", "", "", "", "")

                Dim strFormaPagamento As String = ""

                Dim P As Integer
                Dim dblValTroco As Double = 0
                Dim dtPagTotal As DataTable = CarregarDataTable("SELECT sum(Valor) as Valor FROM Recebimento where Valor > 0 and CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                If dtPagTotal.Rows.Count > 0 Then
                    If dtPagTotal.Rows.Item(0).Item("Valor").ToString <> "" Then
                        If TipoDesconto = "TOTAL" Then
                            If dtPagTotal.Rows.Item(0).Item("Valor").ToString <> "" Then
                                Dim dblValT As Double = dtPagTotal.Rows.Item(0).Item("Valor").ToString
                                If dblValT > dblTotal Then
                                    dblValTroco = CDbl(dblValT) - CDbl(strTotalNFCe)
                                    'If dblValTroco > 0 Then
                                    '    strTroco = "<vTroco>" & dblValTroco.ToString.Replace(",", ".") & "</vTroco>"
                                    'End If
                                ElseIf dblValT < dblTotal Then
                                    dblValTroco = CDbl(strTotalNFCe) - CDbl(dblValT)
                                    dblValTroco = dblValTroco.ToString("0.00")
                                End If
                            End If
                        Else
                            Dim dblValT As Double = dtPagTotal.Rows.Item(0).Item("Valor").ToString
                            '' ''If dblValT > dblValProd Then
                            '' ''    dblValTroco = dblValT - dblValProd
                            '' ''End If


                            If dblValT > dblTotal Then
                                dblValTroco = CDbl(dblValT) - CDbl(strTotalNFCe)
                                'If dblValTroco > 0 Then
                                '    strTroco = "<vTroco>" & dblValTroco.ToString.Replace(",", ".") & "</vTroco>"
                                'End If
                            ElseIf dblValT < dblTotal Then
                                dblValTroco = CDbl(strTotalNFCe) - CDbl(dblValT)
                                dblValTroco = dblValTroco.ToString("0.00")
                            End If
                        End If



                    End If
                End If

                Dim dtPag As DataTable = CarregarDataTable("SELECT Pagamento, Valor, FormaPagamento FROM Recebimento where Valor > 0 and CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)

                Dim dblDif As Double = CDbl(strTotalNFCe) - dblValProd
                If TipoDesconto = "TOTAL" Then

                    dblDif = dblValorTotalConf - dblValProd
                End If
                dblDif = dblDif.ToString("0.00")


                If dtPag.Rows.Count > 0 Then

                    For P = 0 To dtPag.Rows.Count - 1
                        Dim dblValor As Double
                        Dim strPag As String = dtPag.Rows.Item(P).Item("Pagamento").ToString.ToUpper

                        Dim strFormaPag As String = dtPag.Rows.Item(P).Item("FormaPagamento").ToString
                        Dim bolPag As Boolean = True
                        If dtPag.Rows.Item(P).Item("Valor").ToString <> "" Then
                            dblValor = dtPag.Rows.Item(P).Item("Valor").ToString

                            ''''dblValor = dblValor - dblValTroco
                         
                            If dblValor > dblTotal Then
                                dblValor = dblValor - dblValTroco

                            ElseIf dblValor < dblTotal Then
                                dblValor = dblValor + dblValTroco

                            End If

                            If dblValor <= 0 Then
                                dblValTroco = (dblValor - dblValor) - dblValor
                                bolPag = False
                            Else
                                dblValTroco = 0
                            End If




                        End If
                        If bolPag = True Then
                            If P = 0 Then
                                If dblDif > 0 Or dblDif < 0 Then
                                    dblValor += dblDif
                                End If
                            End If

                            Dim strP As String = "99"
                            If strPag.ToUpper.Contains("DINHEIRO") Then
                                strP = "01"
                                'dblValor = dblValor - dblValTroco
                                'dblValTroco = 0
                            End If
                            If strPag.Contains("CHEQUE") Then
                                strP = "02"
                            End If
                            If strPag.Contains("CRÉDITO") Or strPag.Contains("CREDITO") Then
                                If strPag.Contains("CLIENTE") Then
                                    strP = "05"
                                Else
                                    strP = "03"
                                End If

                            End If
                            If strPag.Contains("DÉBITO") Or strPag.Contains("DEBITO") Then
                                strP = "04"
                            End If

                            strFormaPagamento &= clsXmlNFCe.Pagamento(strP, dblValor.ToString("0.00").Replace(",", "."), strPag)

                        End If

                    Next


                End If


                'If TipoDesconto <> "TOTAL" Then
                '    Dim dtTroca As DataTable = CarregarDataTable("SELECT sum(Qtde * Valor) as Valor FROM Devolucao where Motivo like '%NA VENDA Nº " & parCodOrdem & ",%' and CodConfig = " & CodConfig)
                '    If dtTroca.Rows.Count > 0 Then
                '        If dtTroca.Rows.Item(0).Item("Valor").ToString <> "" Then
                '            dblValorDevolvido = dtTroca.Rows.Item(0).Item("Valor").ToString
                '            strFormaPagamento &= clsXmlNFCe.Pagamento("99", dblValorDevolvido.ToString("0.00").Replace(",", "."), "99")
                '        End If
                '    End If
                'End If

                If strFormaPagamento <> "" Then
                    If VersaoXml = "4.00" Then
                        strFormaPagamento = "<pag>" & vbCrLf & strFormaPagamento & "</pag>"
                    End If
                End If
                Dim strAdicionais As String = clsXmlNFCe.Adicionais("", "Venda: " & parCodOrdem & "! " & strObsCont)


                Inserir("INSERT INTO NFCe (CodOrdem, NumNF, CodNF, Chave, Data, ValorTotal, CFPDest, CodConfig, CodEmitente, StatusEmitente) VALUES (" & parCodOrdem & "," & _
                "'" & strNumNF & "','" & strCodNF & "','" & strChave & "','" & Date.Today & "'," & Num(strTotalNFCe) & ",'" & strCPF & "'," & CodConfig & "," & CodEmitente & ",'" & StatusEmitente & "')")

                Atualizar("UPDATE Total Set StatusDAV = 'Faturado' where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)


                Dim strCabecalho As String = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf
                strCabecalho &= "<NFe xmlns=""http://www.portalfiscal.inf.br/nfe"">" & vbCrLf
                If VersaoXml = "3.10" Then
                    strCabecalho &= "<infNFe versao=""3.10"" Id=""NFe" & strChave & """>"

                ElseIf VersaoXml = "4.00" Then
                    strCabecalho &= "<infNFe versao=""4.00"" Id=""NFe" & strChave & """>"
                End If

                Dim strNota As String = strCabecalho & vbCrLf
                strNota &= strIdentificador & vbCrLf
                strNota &= strEmitente & vbCrLf
                strNota &= strDestinatario & vbCrLf
                strNota &= strItens & vbCrLf
                strNota &= strTotal & vbCrLf
                strNota &= strTransportadora & vbCrLf
                strNota &= strFormaPagamento & vbCrLf
                strNota &= strAdicionais & vbCrLf
                strNota &= "</infNFe>" & vbCrLf
                strNota &= "</NFe>" & vbCrLf

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
                strNota = Replace(strNota, "Â", "A")
                strNota = Replace(strNota, "Ë", "E")
                strNota = Replace(strNota, "Ï", "I")
                strNota = Replace(strNota, "Ö", "A")
                strNota = Replace(strNota, "Ü", "E")
                strNota = Replace(strNota, "Ú", "U")
                strNota = Replace(strNota, "Ù", "U")
                strNota = Replace(strNota, "´", "")
                strNota = Replace(strNota, "º", "")
                strNota = Replace(strNota, "ª", "")
                strNota = Replace(strNota, "Ê", "E")
                strNota = Replace(strNota, "°", "")

                Call SalvarArquivo(strNota, PastaRemessas & "\" & strChave & ".xml", False)

                CaminhoNFCe = PastaRemessas & "\" & strChave & ".xml"
                ChaveAcesso = strChave
                CodigoNF = CInt(strCodNF)
            End If


        Catch ex As Exception
            Return False
            Exit Function
        End Try


        Return True

    End Function
    Public Shared Function ImprimirCancelamentoNFCe(ByVal parCodOrdem As String, ByVal parNumNF As String, _
    ByVal parProtocolo As String, ByVal parChave As String, ByVal parCorrecao As String) As Boolean
        Dim Arquivo As String = ""
        Dim strNomeArq As String = ""
        Try

            Dim strCNPJ As String = parChave.Substring(6, 14)
            Dim strCodUF As String = parChave.Substring(0, 2)
        
            Dim strVersao As String = "1.00"
            Dim strTipoEvento As String = "110111"
            Dim strNumSeqEvento As String = "1"
            Dim strDescEvento As String = "Cancelamento"

            Dim strCondUso As String = ""

            Dim strDataHora As String = Format(CDate(Date.Today), "yyyy-MM-dd").ToString & "T" & Format(CDate(My.Computer.Clock.LocalTime), "HH:mm:ss").ToString & TZD

            Dim strEvento As String = ""

            strEvento = clsXmlNFCe.Cancelamento(strCodUF, TipoAmbiente, strCNPJ, parChave, strDataHora, strTipoEvento, _
            strNumSeqEvento, strVersao, strDescEvento, parProtocolo, parCorrecao)


            Dim strCabecalho As String = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf
            strCabecalho &= "<evento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & vbCrLf
            strCabecalho &= "<infEvento Id=""ID" & strTipoEvento & parChave & Format(CInt(strNumSeqEvento), "00") & """>"

            Dim strNota As String = strCabecalho & vbCrLf
            strNota &= strEvento & vbCrLf

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
            strNota = Replace(strNota, "Ê", "E")
            strNota = Replace(strNota, "°", "")
            Call SalvarArquivo(strNota, PastaRemessas & "\" & strTipoEvento & parChave & Format(CInt(strNumSeqEvento), "00") & ".xml", False)
      
            frmCancelarNFe.strCaminhoDaNfe = PastaRemessas & "\" & strTipoEvento & parChave & Format(CInt(strNumSeqEvento), "00") & ".xml"


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Shared Function ImprimeInutilizacaoNFCe(ByVal parChave As String, ByVal parInicial As String, ByVal parFinal As String, ByVal parMotivo As String) As Boolean
        Try
            Dim strCNPJ As String = parChave.Substring(4, 14)
            Dim strCodUF As String = parChave.Substring(0, 2)
            Dim strModelo As String = "65"
            Dim strSerie As String = parChave.Substring(22, 1)


            Dim strAno As String = parChave.Substring(2, 2)

            Dim strInutilizacao As String = clsXmlNFCe.Inutilizacao(TipoAmbiente, "INUTILIZAR", strCodUF, strAno, strCNPJ, strModelo, strSerie, parInicial, parFinal, parMotivo)

            Dim strCabecalho As String = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf

            strCabecalho &= "<inutNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""4.00"">" & vbCrLf

            strCabecalho &= "<infInut Id=""ID" & parChave & """>"

            Dim strNota As String = strCabecalho & vbCrLf
            strNota &= strInutilizacao & vbCrLf

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
            strNota = Replace(strNota, "Ê", "E")
            strNota = Replace(strNota, "°", "")
            Call SalvarArquivo(strNota, PastaRemessas & "\" & parChave & ".xml", False)

            frmMenuNFCe.strCaminhoDaNfe = PastaRemessas & "\" & parChave & ".xml"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Shared Function CarregarEmitente() As String

        Dim I As Integer
        Dim strCodigoEmitente As String = "1"
        Dim dtConfig As DataTable = CarregarDataTable("SELECT EmitentePadrao FROM Config WHERE Codigo = " & CodConfig)
        If dtConfig.Rows.Count > 0 Then
            If dtConfig.Rows.Item(0).Item("EmitentePadrao").ToString <> "" Then
                strCodigoEmitente = dtConfig.Rows.Item(0).Item("EmitentePadrao").ToString
            End If
        End If

        Dim dtPadrao As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigNFe where Padrao = 'True'")
        Select Case dtPadrao.Rows.Count
            Case 1
                CodEmitente = dtPadrao.Rows.Item(0).Item("Codigo").ToString
            Case Else
                CodEmitente = strCodigoEmitente
        End Select

        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CNPJ, UF, CodUF, CRT, " & _
        "Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, SerialName, " & _
        "PastaBackupNFCe, VersaoXml, AutXml, CSC, Impressora, PortaImpressora, ImpDireto, " & _
        "MensImpCupom, TZDCce, TokenNFCe FROM ConfigNfe where Codigo = " & CodEmitente)

        If dt.Rows.Count > 0 Then

            Dim strCNPJEmitente As String = dt.Rows.Item(0).Item("CNPJ").ToString.Replace(".", "").Replace("-", "").Replace("/", "")
            TipoAmbiente = dt.Rows.Item(0).Item("TipoAmb").ToString
            EstadoEmitente = dt.Rows.Item(0).Item("UF").ToString
            CSTEmitente = dt.Rows.Item(0).Item("CSC").ToString
            RegimeSAT = "SIMPLES NACIONAL"
            If dt.Rows.Item(0).Item("CRT").ToString = "3" Then
                RegimeSAT = "TRIBUTAÇÃO NORMAL"
            End If

            TokenNFCe = 0
            If dt.Rows.Item(0).Item("TokenNFCe").ToString <> "" Then
                TokenNFCe = dt.Rows.Item(0).Item("TokenNFCe").ToString
            End If

            TZD = dt.Rows.Item(0).Item("TZDCce").ToString
            If TipoAmbiente = "2" Then
                StatusEmitente = "HOMOLOGAÇÃO"
            Else
                StatusEmitente = "PRODUÇÃO"
            End If

            CertificadoDigital = dt.Rows.Item(0).Item("SerialName").ToString

            PastaBackup = dt.Rows.Item(0).Item("PastaBackupNFCe").ToString


            ImpressoraNFCe = dt.Rows.Item(0).Item("Impressora").ToString
            PortaImpressoraNFCe = dt.Rows.Item(0).Item("PortaImpressora").ToString
            ImpDiretoNFCe = dt.Rows.Item(0).Item("ImpDireto")
            MensImpCupomNFCe = dt.Rows.Item(0).Item("MensImpCupom")

            VersaoXml = dt.Rows.Item(0).Item("VersaoXml").ToString

            Select Case EstadoEmitente
                Case "SP"
                    TLS12 = True
                Case Else
                    TLS12 = False
            End Select
            If VersaoXml = "3.10" Then
                If (TipoAmbiente) - 1 = "1" Then
                    Select Case EstadoEmitente
                        Case "AC", "AL", "AP", "DF", "ES", "PB", "RJ", "RN", "RO", "RR", "SC", "SE", "TO", "CE", "GO", "MS", "PE", "RS", "PI"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                        Case "AM"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "2.01"
                            VersaoXmlAutorizacao = "3.10"
                        Case "BA", "MT"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                        Case "MG"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "2.00"
                            VersaoXmlConsulta = "2.01"
                            VersaoXmlAutorizacao = "3.10"
                        Case "PR", "SP", "PA"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                    End Select
                Else
                    Select Case dt.Rows.Item(0).Item("UF").ToString
                        Case "AC", "AL", "AP", "DF", "ES", "PB", "RJ", "RN", "RO", "RR", "SC", "SE", "TO", "CE", "GO", "MS", "PE", "RS", "AM", "MG", "PI"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                        Case "BA", "PR", "SP", "PA"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "3.10"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                        Case "MT"
                            VersaoXmlEvento = "1.00"
                            VersaoXmlInutilizacao = "2.00"
                            VersaoXmlConsulta = "3.10"
                            VersaoXmlAutorizacao = "3.10"
                    End Select
                End If
            Else
                VersaoXmlEvento = "1.00"
                VersaoXmlInutilizacao = "4.00"
                VersaoXmlConsulta = "4.00"
                VersaoXmlAutorizacao = "4.00"
            End If
            


            If StatusEmitente = "PRODUÇÃO" Then

                PastaAutorizadas = PastaRemessas.Replace("Remessas", "Autorizadas")
                PastaAssinadas = PastaRemessas.Replace("Remessas", "Assinadas")
                PastaNotas = PastaRemessas.Replace("Remessas", "Notas")
                PastaArquivos = PastaRemessas.Replace("Remessas", "Arquivos")
                PastaWebServices = PastaRemessas.Replace("Remessas", "WebServices")

                If PastaRemessas.Replace("Remessas", "Backup") = PastaBackup Then
                    PastaBackup = PastaRemessas.Replace("Remessas", "Backup") & "\" & strCNPJEmitente & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00")
                End If

            Else

                PastaAutorizadas = PastaRemessas.Replace("Remessas", "Homologação\Autorizadas")
                PastaAssinadas = PastaRemessas.Replace("Remessas", "Homologação\Assinadas")
                PastaNotas = PastaRemessas.Replace("Remessas", "Homologação\Notas")
                PastaArquivos = PastaRemessas.Replace("Remessas", "Arquivos")
                PastaWebServices = PastaRemessas.Replace("Remessas", "WebServices")

                If PastaRemessas.Replace("Remessas", "Backup") = PastaBackup Then
                    PastaBackup = PastaRemessas.Replace("Remessas", "Homologação\Backup") & "\" & strCNPJEmitente & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00")
                End If

                'VerificarPasta(PastaAutorizadas & "\Cancelamento")
                'VerificarPasta(PastaAutorizadas & "\CCe")
                'VerificarPasta(PastaAutorizadas & "\Inut")
                'VerificarPasta(PastaAssinadas)
                'VerificarPasta(PastaNotas & "\Cancelamento")
                'VerificarPasta(PastaNotas & "\CCe")
                'VerificarPasta(PastaNotas & "\Inut")
            End If

            'VerificarPasta(PastaBackup & "\Cancelamento")
            'VerificarPasta(PastaBackup & "\CCe")
            'VerificarPasta(PastaBackup & "\Inut")
        End If
    End Function

End Class
