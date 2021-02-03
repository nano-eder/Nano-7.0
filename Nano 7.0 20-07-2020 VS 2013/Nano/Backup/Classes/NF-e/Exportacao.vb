Imports System.IO
Imports System.Threading
Imports Nano.clsFuncoes
Module Exportacao
    Public SQL As String = ""
    Public tipoOperacaNFe As String = "Autorizacao"
    Dim DirDiretorio As DirectoryInfo
    Dim oFileInfoCollection() As FileInfo
    Dim oFileInfo As FileInfo
    Dim sAtualiza As Thread

    'Dim sDiretorioNFe As String = "C:\NFE"
    Function LerConteudoArquivo(ByVal Arquivo As String) As String
        Dim Texto As IO.StreamReader
        LerConteudoArquivo = ""
        If Arquivo = Nothing Then
            LerConteudoArquivo = ""
        Else
            If IO.File.Exists(Arquivo) = True Then
                Texto = File.OpenText(Arquivo)
                LerConteudoArquivo = Texto.ReadToEnd
                Texto.Close()
            End If
        End If
    End Function

    Function RetiraAcentos(ByVal Conteudo As String) As String
        Conteudo = Replace(Conteudo, "Ç", "C")
        Conteudo = Replace(Conteudo, "Á", "A")
        Conteudo = Replace(Conteudo, "É", "E")
        Conteudo = Replace(Conteudo, "Í", "I")
        Conteudo = Replace(Conteudo, "Ã", "A")
        Conteudo = Replace(Conteudo, "&", "E")
        Conteudo = Replace(Conteudo, "Õ", "O")
        Conteudo = Replace(Conteudo, "Ó", "O")
        Conteudo = Replace(Conteudo, "Ô", "O")
        Conteudo = Replace(Conteudo, "Ä", "A")
        Conteudo = Replace(Conteudo, "Ë", "E")
        Conteudo = Replace(Conteudo, "Ï", "I")
        Conteudo = Replace(Conteudo, "Ö", "A")
        Conteudo = Replace(Conteudo, "Ü", "E")
        RetiraAcentos = Conteudo
    End Function
    Function ExportaCancelamento(ByVal ChaveAcesso As String, ByVal Motivo As String, ByVal Protocolo As String, ByVal NotaFiscal As String) As Boolean
        Try
            Dim Arquivo As String
            Arquivo = ""
            Arquivo = "CANCELAMENTO|1|" & vbNewLine
            Arquivo = Arquivo & "A|" & ChaveAcesso & "|" & Protocolo.ToString & "|" & Motivo & "|" & vbNewLine
            Arquivo = RetiraAcentos(Arquivo)
            SalvarArquivo(Arquivo, PastaNotaNfe & "\CANC" & Format(CInt(NotaFiscal), "00000") & ".txt", False)
            'AbrirNFe()
            'Thread.Sleep(2000)
            'tipoOperacaNFe = "Cancelamento"
            'LerRetornoProcessamento()
        Catch ex As Exception

        End Try
    End Function
    Public Function validachavenfe(ByVal chave As String, ByVal validar As Boolean) As String
        Try
            'Vetor que irá receber os dígitos da chave
            Dim Numero(42) As Integer

            'Vetor com o peso de cada um dos dígitos
            Dim pesos() As Integer = {4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}

            Dim soma As Integer = 0

            Dim i As Integer

            Dim resultado1 As Integer

            'Atribuindo ao vetor cada valor da chave até o indice 43.

            For i = 0 To Numero.Length - 1
                Numero(i) = CInt(chave.Substring(i, 1))
            Next

            'Multiplica os valors da chave pelo seu peso e soma o resultado.

            For i = 0 To Numero.Length - 1
                soma = soma + (Numero(i) * pesos(i))
            Next

            'Efetua o resto da divisão

            soma = soma - (11 * (Int(soma / 11)))

            'Como regra da validação se o resultado for 0 ou 1 o digito verificador tem que ser igual a 0

            If soma = 0 Or soma = 1 Then
                resultado1 = 0
            Else
                'Se for maior que 1 tem que diminuir de 11;
                resultado1 = 11 - soma
            End If


            'Verifica se o resultado é igual ao ultimo digito e retorna true ou false
            If validar = True Then
                If resultado1 = CInt(chave.Substring(43, 1)) Then
                    Return "OK"
                Else
                    Return "NOK"
                End If
            Else
                Return resultado1
            End If


        Catch ex As Exception
            Return "NOK"
        End Try
       
        'Fim da Função
    End Function
    Function ExportarNotas(ByVal parCodOrdem As String, Optional ByVal NotaFiscal As String = "") As Boolean
        Dim Arquivo As String = ""
        Dim NumNF As String = ""
        Try

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, UF, CodUF, " & _
            "Pais, CodPais, CRT, Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete FROM ConfigNfe where CodConfig = " & CodConfig)
       
            If dt.Rows.Count > 0 Then
                Dim strRazao As String = dt.Rows.Item(0).Item("Razao").ToString
                Dim strFantasia As String = dt.Rows.Item(0).Item("Fantasia").ToString
                Dim strCNPJEmitente As String = dt.Rows.Item(0).Item("CNPJ").ToString
                Dim strIEEmitente As String = dt.Rows.Item(0).Item("IE").ToString
                Dim strCRT As String = dt.Rows.Item(0).Item("CRT").ToString
                Dim strEnderecoEmitente As String = dt.Rows.Item(0).Item("Endereco").ToString
                Dim strBairroEmitente As String = dt.Rows.Item(0).Item("Bairro").ToString
                Dim strNumeroEmitente As String = dt.Rows.Item(0).Item("Numero").ToString
                Dim strCepEmitente As String = dt.Rows.Item(0).Item("Cep").ToString
                Dim strUFEmitente As String = dt.Rows.Item(0).Item("UF").ToString
                Dim strCidadeEmitente As String = dt.Rows.Item(0).Item("Cidade").ToString
                Dim strCodMunEmitente As String = dt.Rows.Item(0).Item("CodMun").ToString
                Dim strCodUFEmitente As String = dt.Rows.Item(0).Item("CodUF").ToString
                Dim strPaisEmitente As String = dt.Rows.Item(0).Item("Pais").ToString
                Dim strCodPaisEmitente As String = dt.Rows.Item(0).Item("CodPais").ToString
                Dim strTelefoneEmitente As String = dt.Rows.Item(0).Item("Telefone").ToString
                'Dim strNatOpe As String = dt.Rows.Item(0).Item("NatOp").ToString
                Dim strModelo As String = dt.Rows.Item(0).Item("Mod").ToString
                Dim strSerie As String = dt.Rows.Item(0).Item("Serie").ToString
                'Dim strTipoNF As String = dt.Rows.Item(0).Item("TipoNF").ToString
                'Dim strTipoImp As String = dt.Rows.Item(0).Item("TipoImp").ToString
                'Dim strTipoEmi As String = dt.Rows.Item(0).Item("TipoEmi").ToString
                'Dim strTipoAmb As String = dt.Rows.Item(0).Item("TipoAmb").ToString
                'Dim strFinalidade As String = dt.Rows.Item(0).Item("FinNfe").ToString
                'Dim strProcEmi As String = dt.Rows.Item(0).Item("ProcEmi").ToString
                'Dim strVerProc As String = dt.Rows.Item(0).Item("VerProc").ToString
                'Dim strModFrete As String = dt.Rows.Item(0).Item("ModFrete")
                strCNPJEmitente = strCNPJEmitente.Replace(".", "").Replace("/", "").Replace("-", "")




                Dim dtTotal As DataTable = CarregarDataTable("SELECT Codigo, CodOrdem, NumNF, CodNF, Chave, IndPag, DEmi, DEntSai, HEntSai, CDV, CodCli, VBC, VICMS, VBCST, " & _
                "VST, VProd, VFrete, VSeg, VDesc, VII, VIPI, VPIS, VCOFINS, VOutro, VNF, DCont, HCont, JustCont, NatOp, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, " & _
                "VerProc, ModFrete, ObsFisco, ObsCont, CodForn, NomeTrans, CNPJTrans, IETRans, EndTrans, BairroTrans, NumTrans, UFTrans, CidadeTrans, Placa, UFVei, RNTC, " & _
                "Serie, NumFatura, ValOrigFatura, ValDescFatura, ValLiqFatura FROM TotalNfe where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
               
                Dim dblTotalValAprox As Double
                If dtTotal.Rows.Count > 0 Then

                    Dim strNatOpe As String = dtTotal.Rows.Item(0).Item("NatOp").ToString
                    Dim strTipoNF As String = dtTotal.Rows.Item(0).Item("TipoNF").ToString
                    Dim strTipoImp As String = dtTotal.Rows.Item(0).Item("TipoImp").ToString
                    Dim strTipoEmi As String = dtTotal.Rows.Item(0).Item("TipoEmi").ToString
                    Dim strTipoAmb As String = dtTotal.Rows.Item(0).Item("TipoAmb").ToString
                    Dim strFinalidade As String = dtTotal.Rows.Item(0).Item("FinNfe").ToString
                    Dim strProcEmi As String = dtTotal.Rows.Item(0).Item("ProcEmi").ToString
                    Dim strVerProc As String = dtTotal.Rows.Item(0).Item("VerProc").ToString
                    Dim strModFrete As String = dtTotal.Rows.Item(0).Item("ModFrete")

                    Arquivo = ""
                    Arquivo = "NOTA FISCAL|" & "1" & "|" & vbNewLine
                    Arquivo = Arquivo & "A|" & "2.00" & "|"

                    Dim strAno As String = Format(Date.Today, "yy")
                    Dim strMes As String = Format(Date.Today, "MM")

                    Dim strNumNF As String = dtTotal.Rows.Item(0).Item("NumNF").ToString

                    Dim strCodNF As String = dtTotal.Rows.Item(0).Item("CodNF").ToString
                    NumNF = strCodNF

                    strSerie = dtTotal.Rows.Item(0).Item("Serie").ToString

                    Dim strCodCli As String = dtTotal.Rows.Item(0).Item("CodCli").ToString

                    Dim strChave As String = dtTotal.Rows.Item(0).Item("Chave").ToString
                    Dim strDV As String = dtTotal.Rows.Item(0).Item("CDV").ToString

                    Dim strCodFor As String = dtTotal.Rows.Item(0).Item("CodForn").ToString



                    Dim strNomeTrans As String = dtTotal.Rows.Item(0).Item("NomeTrans").ToString
                    Dim strCNPJTrans As String = dtTotal.Rows.Item(0).Item("CNPJTrans").ToString
                    Dim strIETrans As String = dtTotal.Rows.Item(0).Item("IETrans").ToString
                    Dim strEndTrans As String = dtTotal.Rows.Item(0).Item("EndTrans").ToString
                    Dim strBairroTrans As String = dtTotal.Rows.Item(0).Item("BairroTrans").ToString
                    Dim strNumTrans As String = dtTotal.Rows.Item(0).Item("NumTrans").ToString
                    Dim strUFTrans As String = dtTotal.Rows.Item(0).Item("UFTrans").ToString
                    Dim strCidadeTrans As String = dtTotal.Rows.Item(0).Item("CidadeTrans").ToString

                    Dim strEnderecoTrans As String = strEndTrans & ", " & strNumTrans & " " & strBairroTrans

                    Dim strPlaca As String = dtTotal.Rows.Item(0).Item("Placa").ToString
                    Dim strUFVei As String = dtTotal.Rows.Item(0).Item("UFVei").ToString
                    Dim strRTNC As String = dtTotal.Rows.Item(0).Item("RNTC").ToString

                    Arquivo = Arquivo & "NFe" & strChave & "|" & vbNewLine


                    If (strCodUFEmitente <> "Null") And (strCodUFEmitente <> "") Then
                        Arquivo = Arquivo & "B|" & strCodUFEmitente & "|"
                    Else
                        Arquivo = Arquivo & "B| " & "|"
                    End If
                    If (strCodNF <> "Null") And (strCodNF <> "") Then
                        Arquivo = Arquivo & strCodNF & "|"
                        NumNF = strCodNF
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strNatOpe <> "Null") And (strNatOpe <> "") Then
                        Arquivo = Arquivo & Trim(Left(strNatOpe, 60)) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("IndPag").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("IndPag").ToString <> "") Then

                        Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("IndPag").ToString & "|"

                    Else
                        Arquivo = Arquivo & "0" & "|"
                    End If
                    If (strModelo <> "Null") And (strModelo <> "") Then
                        Arquivo = Arquivo & Left(strModelo, 2) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strSerie <> "Null") And (strSerie <> "") Then
                        Arquivo = Arquivo & Left(strSerie, 3) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strNumNF <> "Null") And (strNumNF <> "") Then
                        Arquivo = Arquivo & Left(strNumNF, 9) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("DEmi").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("DEmi").ToString <> "") Then
                        Arquivo = Arquivo & Format(CDate(dtTotal.Rows.Item(0).Item("DEmi")), "yyyy-MM-dd").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("DEntSai").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("DEntSai").ToString <> "") Then
                        Arquivo = Arquivo & Format(CDate(dtTotal.Rows.Item(0).Item("DEntSai")), "yyyy-MM-dd").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    'AQUI
                    If (dtTotal.Rows.Item(0).Item("HEntSai").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("HEntSai").ToString <> "") Then
                        Arquivo = Arquivo & Format(CDate(dtTotal.Rows.Item(0).Item("HEntSai")), "HH:mm:ss").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    '---------
                    If (strTipoNF <> "Null") And (strTipoNF <> "") Then
                        Arquivo = Arquivo & strTipoNF & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strCodMunEmitente <> "Null") And (strCodMunEmitente <> "") Then
                        Arquivo = Arquivo & Left(strCodMunEmitente, 7) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strTipoImp <> "Null") And (strTipoImp <> "") Then
                        Arquivo = Arquivo & strTipoImp & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strTipoEmi <> "Null") And (strTipoEmi <> "") Then
                        Arquivo = Arquivo & strTipoEmi & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If

                    If (strDV <> "Null") And (strDV <> "") Then
                        Arquivo = Arquivo & strDV & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strTipoAmb <> "Null") And (strTipoAmb <> "") Then
                        Arquivo = Arquivo & strTipoAmb & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strFinalidade <> "Null") And (strFinalidade <> "") Then
                        Arquivo = Arquivo & strFinalidade & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strProcEmi <> "Null") And (strProcEmi <> "") Then
                        Arquivo = Arquivo & strProcEmi & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strVerProc <> "Null") And (strVerProc <> "") Then
                        Arquivo = Arquivo & strVerProc & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    'AQUI  
                    Dim strDataCont As String = dtTotal.Rows.Item(0).Item("DCont").ToString
                    Dim strHoraCont As String = dtTotal.Rows.Item(0).Item("HCont").ToString

                    If (strDataCont <> "Null") And (strDataCont <> "") Then
                        If (strHoraCont <> "Null") And (strHoraCont <> "") Then
                            strHoraCont = Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
                        End If
                        strDataCont = Format(CDate(strDataCont), "yyyy-MM-dd")
                        strHoraCont = Format(CDate(strHoraCont), "HH:mm:ss")
                        Arquivo = Arquivo & strDataCont & "T" & strHoraCont & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("JustCont").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("JustCont").ToString <> "") Then
                        Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("JustCont").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    Arquivo &= vbNewLine


                    ' NOTAS REFERENCIADAS
                    Dim dtRef As DataTable = CarregarDataTable("SELECT Tipo, Chave, Serie, Numero, Modelo, UF, Emissao, CNPJ FROM RefNfe where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig & " order by Tipo")
                    Dim R As Integer
                    If dtRef.Rows.Count > 0 Then
                        For R = 0 To dtRef.Rows.Count - 1
                            Select Case dtRef.Rows.Item(R).Item("Tipo").ToString.ToUpper
                                Case "NF-E"
                                    Arquivo &= "B13|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("Chave").ToString.Trim & "|"
                                    Arquivo &= vbNewLine
                                Case "NOTA FISCAL"
                                    Arquivo &= "B14|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("UF").ToString.Trim & "|"
                                    If dtRef.Rows.Item(R).Item("Emissao").ToString.Trim.Equals("") = False Then
                                        Arquivo &= Format(CDate(dtRef.Rows.Item(R).Item("Emissao").ToString.Trim), "yyMM") & "|"
                                    Else
                                        Arquivo &= "" & "|"
                                    End If
                                    Arquivo &= dtRef.Rows.Item(R).Item("CNPJ").ToString.Trim.Replace(".", "").Replace("/", "").Replace("-", "") & "|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("Modelo").ToString.Trim & "|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("Serie").ToString.Trim & "|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("Numero").ToString.Trim & "|"
                                    Arquivo &= vbNewLine
                                Case "CT-E"
                                    Arquivo &= "B20i|"
                                    Arquivo &= dtRef.Rows.Item(R).Item("Chave").ToString.Trim & "|"
                                    Arquivo &= vbNewLine

                            End Select

                        Next
                    End If

                    'Select Case ReaderVar.Item("TIPO").ToString.ToUpper
                    '    Case "NF-e".ToUpper

                    '    Case "NF Talão".ToUpper

                    '    Case "NF Produtor".ToUpper
                    '        Arquivo &= "B20a|"
                    '        Arquivo &= ReaderVar.Item("UF").ToString.ToUpper.Trim & "|"
                    '        If ReaderVar.Item("EMISSAO").ToString.Trim.Equals("") = False Then
                    '            Arquivo &= Format(CDate(ReaderVar.Item("EMISSAO").ToString.ToUpper.Trim), "yyMM") & "|"
                    '        Else
                    '            Arquivo &= "" & "|"
                    '        End If
                    '        Arquivo &= ReaderVar.Item("IE").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= ReaderVar.Item("MOD").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= ReaderVar.Item("SERIE").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= ReaderVar.Item("NUMERO").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= vbNewLine
                    '        ' CNPJ
                    '        If ReaderVar.Item("CNPJ").ToString.Trim.Equals("") = False Then
                    '            Arquivo &= "B20d|"
                    '            Arquivo &= ReaderVar.Item("CNPJ").ToString.Replace(".", "").Replace("/", "").Replace("-", "")
                    '            Arquivo &= vbNewLine
                    '        End If
                    '        ' CPF
                    '        If ReaderVar.Item("CFP").ToString.Trim.Equals("") = False Then
                    '            Arquivo &= "B20e|"
                    '            Arquivo &= ReaderVar.Item("CFP").ToString.Replace(".", "").Replace("-", "")
                    '            Arquivo &= vbNewLine
                    '        End If
                    '    Case "CT-e".ToUpper

                    '    Case "Cupom Fiscal".ToUpper
                    '        Arquivo &= "B20j|"
                    '        Arquivo &= ReaderVar.Item("MOD").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= ReaderVar.Item("NUMERO_ECF").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= ReaderVar.Item("NUMERO_COO").ToString.ToUpper.Trim & "|"
                    '        Arquivo &= vbNewLine
                    'End Select

                    Arquivo = Arquivo & "C|"

                    'Nome do Emitente'
                    If (strRazao <> "Null") And (strRazao <> "") Then
                        Arquivo = Arquivo & Trim(Left(strRazao, 60)) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If

                    'Fantasia do Emitente'
                    If (strFantasia <> "Null") And (strFantasia <> "") Then
                        Arquivo = Arquivo & Trim(Left(strFantasia, 60)) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If

                    'IE do Emitente'


                    If (strIEEmitente <> "Null") And (strIEEmitente <> "") Then
                        Arquivo = Arquivo & Trim(Left(Replace(strIEEmitente, ".", "").ToString, 14)) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    Arquivo = Arquivo & " " & "|"
                    Arquivo = Arquivo & " " & "|"
                    Arquivo = Arquivo & " " & "|"

                    'CRT do Emitente'

                    If (strCRT <> "Null") And ((strCRT <> "")) Then
                        Arquivo = Arquivo & strCRT & "|" & vbNewLine
                    Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                    End If

                    'CNPJ do Emitente'
                    If (strCNPJEmitente <> "Null") And (strCNPJEmitente <> "") Then
                        Arquivo = Arquivo & "C02|" & strCNPJEmitente & "|" & vbNewLine
                    Else
                        Arquivo = Arquivo & "C02| " & "|" & vbNewLine
                    End If

                    'Endereco do Emitente'
                    Arquivo = Arquivo & "C05|"
                    If (strEnderecoEmitente <> "Null") And (strEnderecoEmitente <> "") Then
                        Arquivo = Arquivo & Trim(Left(strEnderecoEmitente, 60)) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strNumeroEmitente <> "Null") And (strNumeroEmitente <> "") Then
                        Arquivo = Arquivo & strNumeroEmitente & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    Arquivo = Arquivo & " " & "|"
                    If (strBairroEmitente <> "Null") And (strBairroEmitente <> "") Then
                        Arquivo = Arquivo & strBairroEmitente & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strCodMunEmitente <> "Null") And (strCodMunEmitente <> "") Then
                        Arquivo = Arquivo & strCodMunEmitente & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strCidadeEmitente <> "Null") And (strCidadeEmitente <> "") Then
                        Arquivo = Arquivo & Left(strCidadeEmitente, 60) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                    End If
                    If (strUFEmitente <> "Null") And (strUFEmitente <> "") Then
                        Arquivo = Arquivo & Left(strUFEmitente, 60) & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strCepEmitente <> "Null") And (strCepEmitente <> "") Then
                        Arquivo = Arquivo & Replace(Replace(strCepEmitente, ".", "").ToString, "-", "").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strCodPaisEmitente <> "Null") And (strCodPaisEmitente <> "") Then
                        Arquivo = Arquivo & strCodPaisEmitente & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strPaisEmitente <> "Null") And (strPaisEmitente <> "") Then
                        Arquivo = Arquivo & strPaisEmitente & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (strTelefoneEmitente <> "Null") And (strTelefoneEmitente <> "") Then
                        strTelefoneEmitente = strTelefoneEmitente.Replace(".", "").Replace("#", "").Replace(":", "")

                        Arquivo = Arquivo & Replace(Replace(Replace(Replace(strTelefoneEmitente, "(", "").ToString, ")", "").ToString, " ", "").ToString, "-", "").ToString & "|" & vbNewLine
                    Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                    End If



                    ''''CLIENTE''''


                    Dim dtCli As DataTable = Nothing
                    Dim strIE As String = ""
                    If strCodCli <> "NULL" And strCodCli <> "" Then
                        dtCli = CarregarDataTable("SELECT Nome, RGIE, CPF, Endereco, Numero, Bairro, CodMunicipio, Cidade, Estado, Cep, CodPais, NomePais, Telefone FROM Cliente where Codigo = " & strCodCli)
                        strIE = "RGIE"
                    Else
                        If strCodFor <> "NULL" And strCodFor <> "" Then
                            dtCli = CarregarDataTable("SELECT Nome, IE, CPF, Endereco, Numero, Bairro, CodMunicipio, Cidade, Estado, Cep, CodPais, NomePais, Telefone FROM Fornecedor where Codigo = " & strCodFor)
                            strIE = "IE"
                        End If
                    End If


                    If dtCli.Rows.Count > 0 Then



                        Arquivo = Arquivo & "E|"
                        If (dtCli.Rows.Item(0).Item("Nome").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Nome").ToString <> "") Then
                            Arquivo = Arquivo & Trim(Left(dtCli.Rows.Item(0).Item("Nome").ToString, 60)) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        Dim CNPJ As String
                        CNPJ = ""
                        CNPJ = Replace(Replace(Replace(dtCli.Rows.Item(0).Item("CPF").ToString, ".", "").ToString, "-", "").ToString, "/", "")
                        If Len(CNPJ) = 14 Then
                            If (dtCli.Rows.Item(0).Item(strIE).ToString <> "Null") And (dtCli.Rows.Item(0).Item(strIE).ToString <> "") Then
                                Arquivo = Arquivo & Trim(Replace(Replace(Replace(dtCli.Rows.Item(0).Item(strIE).ToString, ".", "").ToString, "/", "").ToString, "-", "").ToString) & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        Arquivo = Arquivo & " " & "|"
                        'AQUI
                        'If (Reader.Item("EMAIL_DESTINO").ToString <> "Null") And (Reader.Item("EMAIL_DESTINO").ToString <> "") Then
                        '    Arquivo = Arquivo & Reader.Item("EMAIL_DESTINO").ToString & "|" & vbNewLine
                        'Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                        'End If
                        '--------
                        If dtCli.Rows.Item(0).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "").Length = 11 Then
                            Arquivo = Arquivo & "E03|"
                        Else
                            Arquivo = Arquivo & "E02|"
                        End If
                        If (dtCli.Rows.Item(0).Item("CPF").ToString <> "Null") And (dtCli.Rows.Item(0).Item("CPF").ToString <> "") Then
                            Arquivo = Arquivo & Replace(Replace(Replace(dtCli.Rows.Item(0).Item("CPF").ToString, ".", "").ToString, "/", "").ToString, "-", "").ToString & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        End If
                        Arquivo = Arquivo & "E05|"
                        If (dtCli.Rows.Item(0).Item("Endereco").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Endereco").ToString <> "") Then
                            Arquivo = Arquivo & Trim(Left(dtCli.Rows.Item(0).Item("Endereco").ToString, 60)) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("Numero").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Numero").ToString <> "") Then
                            Arquivo = Arquivo & dtCli.Rows.Item(0).Item("Numero").ToString & "|"
                        Else
                            Arquivo = Arquivo & "SN" & "|"
                        End If
                        'If (Reader.Item("COMPLE_DESTINO").ToString <> "Null") And (Reader.Item("COMPLE_DESTINO").ToString <> "") Then
                        '    Arquivo = Arquivo & Trim(Reader.Item("COMPLE_DESTINO")) & "|"
                        'Else
                        Arquivo = Arquivo & " " & "|"
                        'End If
                        If (dtCli.Rows.Item(0).Item("Bairro").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Bairro").ToString <> "") Then
                            Arquivo = Arquivo & Left(dtCli.Rows.Item(0).Item("Bairro").ToString, 60) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("CodMunicipio").ToString <> "Null") And (dtCli.Rows.Item(0).Item("CodMunicipio").ToString <> "") Then
                            Arquivo = Arquivo & Left(dtCli.Rows.Item(0).Item("CodMunicipio").ToString, 7) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("Cidade").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Cidade").ToString <> "") Then
                            Arquivo = Arquivo & Left(dtCli.Rows.Item(0).Item("Cidade").ToString, 60) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("Estado").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Estado").ToString <> "") Then
                            Arquivo = Arquivo & Left(dtCli.Rows.Item(0).Item("Estado").ToString, 2) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("Cep").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Cep").ToString <> "") Then
                            Arquivo = Arquivo & Left(Replace(Replace(dtCli.Rows.Item(0).Item("Cep").ToString, ".", "").ToString, "-", "").ToString, 8) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("CodPais").ToString <> "Null") And (dtCli.Rows.Item(0).Item("CodPais").ToString <> "") Then
                            Arquivo = Arquivo & Left(Replace(Replace(dtCli.Rows.Item(0).Item("CodPais").ToString, ".", "").ToString, "-", "").ToString, 8) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("NomePais").ToString <> "Null") And (dtCli.Rows.Item(0).Item("NomePais").ToString <> "") Then
                            Arquivo = Arquivo & Left(Replace(Replace(dtCli.Rows.Item(0).Item("NomePais").ToString, ".", "").ToString, "-", "").ToString, 8) & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (dtCli.Rows.Item(0).Item("Telefone").ToString <> "Null") And (dtCli.Rows.Item(0).Item("Telefone").ToString <> "") Then
                            Arquivo = Arquivo & Replace(Replace(Replace(Replace(dtCli.Rows.Item(0).Item("Telefone").ToString, "(", "").ToString, ")", "").ToString, " ", "").ToString, "-", "").ToString & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        End If
                    End If

                    Dim I As Integer
                    I = 0
                    Dim FreteInformado As Decimal = 0

                    Dim dtItens As DataTable = CarregarDataTable("SELECT Codigo, CodOrdem, CodProd, Produto, CodInterno, CodBarra, NCM, CFOP, EXTIPI, UCom, QCom, VUnCom, " & _
                    "VProd, Origem, CSTICMS, ModBC, VBCICMS, ICMS, ValICMS, RedBC, ModBCST, VBCST, RedBCST, MVaST, ICMSST, ValICMSST, CalcCred, CodEnq, CSTIPI, VBCIPI, " & _
                    "PerIPI, ValIPI, CSTPIS, VBCPIS, PerPIS, valPIS, CSTCOFINS, VCBCOFINS, PerCOFINS, ValCOFINS, VCalcCred, ValAprox FROM ItensNfe where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig & " order by CodProd")



                    If dtItens.Rows.Count > 0 Then
                        For I = 0 To dtItens.Rows.Count - 1



                            Arquivo = Arquivo & "H|" & I + 1 & "| |" & vbNewLine
                            Arquivo = Arquivo & "I|"
                            If (dtItens.Rows.Item(I).Item("CodInterno").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CodInterno").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CodInterno").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("CodBarra").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CodBarra").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CodBarra").ToString & "|"
                            Else
                                Arquivo = Arquivo & "" & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("Produto").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Produto").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Produto").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("NCM").ToString <> "Null") And (dtItens.Rows.Item(I).Item("NCM").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("NCM").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("EXTIPI").ToString <> "Null") And (dtItens.Rows.Item(I).Item("EXTIPI").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("EXTIPI").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            'Arquivo = Arquivo & " " & "|"
                            If (dtItens.Rows.Item(I).Item("CFOP").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CFOP").ToString <> "") Then
                                Arquivo = Arquivo & Replace(dtItens.Rows.Item(I).Item("CFOP").ToString, ".", "").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("UCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("UCom").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("UCom").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("QCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("QCom").ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("QCom").ToString), 4).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("VUnCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VUnCom").ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VUnCom").ToString), 4).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("VProd").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VProd").ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VProd").ToString), 2).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            Arquivo = Arquivo & " " & "|"
                            If (dtItens.Rows.Item(I).Item("UCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("UCom").ToString <> "") Then
                                Arquivo = Arquivo & dtItens.Rows.Item(I).Item("UCom").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("QCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("QCom").ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("QCom").ToString), 4).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            If (dtItens.Rows.Item(I).Item("VUnCom").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VUnCom").ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VUnCom").ToString), 4).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            Dim intQtd As Integer = dtItens.Rows.Count


                            Dim dblFrete As Double = 0
                            Dim dblFreteTotal As Double = 0
                            If dtTotal.Rows.Item(0).Item("VFrete").ToString <> "" Then
                                dblFreteTotal = dtTotal.Rows.Item(0).Item("VFrete").ToString
                            End If

                            dblFrete = dblFreteTotal / intQtd
                            dblFrete = dblFrete.ToString("0.00")
                            If I = intQtd - 1 Then
                                dblFrete = dblFrete * I

                                dblFrete = dblFreteTotal - dblFrete
                            End If


                            If dblFrete > 0 Then
                                Arquivo = Arquivo & Replace(dblFrete.ToString("0.00"), ",", ".") & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            'If (ReaderVar.Item("VFRETE").ToString <> "Null") And (ReaderVar.Item("VFRETE").ToString <> "") Then
                            '    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("VFRETE").ToString), 2).ToString), ",", ".").ToString & "|"
                            'Else
                            'Arquivo = Arquivo & " " & "|"
                            'End If
                            'If (ReaderVar.Item("VSEGURO").ToString <> "Null") And (ReaderVar.Item("VSEGURO").ToString <> "") Then
                            '    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("VSEGURO").ToString), 2).ToString), ",", ".").ToString & "|"
                            'Else
                            Arquivo = Arquivo & " " & "|"
                            'End If

                            'If (ReaderVar.Item("VDESCONTO").ToString <> "Null") And (ReaderVar.Item("VDESCONTO").ToString <> "") Then
                            '    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("VDESCONTO").ToString), 2).ToString), ",", ".").ToString & "|"
                            'Else
                            Arquivo = Arquivo & " " & "|"
                            'End If

                            'If (ReaderVar.Item("VOUTRO").ToString <> "Null") And (ReaderVar.Item("VOUTRO").ToString <> "") Then
                            '    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("VOUTRO").ToString), 2).ToString), ",", ".").ToString & "|"
                            'Else
                            Dim dblOutro As Double = 0
                            Dim dblTotalOutro As Double = 0
                            If dtTotal.Rows.Item(0).Item("VOutro").ToString <> "" Then
                                dblTotalOutro = dtTotal.Rows.Item(0).Item("VOutro").ToString
                            End If

                            dblOutro = dblTotalOutro / intQtd

                            dblOutro = dblOutro.ToString("0.00")
                            If I = intQtd - 1 Then
                                dblOutro = dblOutro * I

                                dblOutro = dblTotalOutro - dblOutro
                            End If


                            If dblOutro > 0 Then
                                Arquivo = Arquivo & Replace(dblOutro.ToString("0.00"), ",", ".") & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If
                            ' Arquivo = Arquivo & " " & "|"
                            'End If
                            'If dtItens.Rows.Count > 1 Then
                            '    Arquivo = Arquivo & "0" & "|"
                            'Else
                            Arquivo = Arquivo & "1" & "|"
                            'End If

                            'If (ReaderVar.Item("XPED") <> "Null") And (ReaderVar.Item("XPED") <> "") Then

                            '    Arquivo = Arquivo & ReaderVar.Item("XPED") & "|"
                            'Else
                            Arquivo = Arquivo & " " & "|"
                            'End If
                            'If (ReaderVar.Item("NITEMPED").ToString <> "Null") And (ReaderVar.Item("NITEMPED").ToString <> "") Then
                            '    Arquivo = Arquivo & ReaderVar.Item("NITEMPED").ToString & "|" & vbNewLine
                            'Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                            'End If


                            Dim strValAprox As String = "0.00"
                            If (dtItens.Rows.Item(I).Item("ValAprox").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValAprox").ToString <> "") Then
                                strValAprox = Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValAprox").ToString), 2).ToString), ",", ".").ToString
                                dblTotalValAprox += strValAprox.Replace(".", ",")
                            End If
                            If PorValorAproximado <> "" Then
                                Arquivo = Arquivo & "M|0.00|" & vbNewLine
                            Else
                                Arquivo = Arquivo & "M|" & strValAprox & "|" & vbNewLine
                            End If

                            'Arquivo = Arquivo & "M|" & vbNewLine
                            Arquivo = Arquivo & "N|" & vbNewLine
                            If dtItens.Rows.Item(I).Item("CSTICMS").ToString = "00" Then
                                Arquivo = Arquivo & "N02|"

                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("ModBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBC").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBC").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "3" & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "10" Then
                                Arquivo = Arquivo & "N03|"

                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("ModBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBC").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBC").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "3" & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                    If IsNumeric(dtItens.Rows.Item(I).Item("ICMS").ToString) = True Then
                                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Else
                                        Arquivo = Arquivo & "0" & "|"
                                    End If
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If

                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                '    Arquivo = Arquivo & "4" & "|"
                                'ElseIf ReaderVar.Item("TP_TRIB") = "1" Then
                                '    Arquivo = Arquivo & "5" & "|"
                                'Else
                                '    Arquivo = Arquivo & "0" & "|"
                                'End If

                                If (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBCST").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                If (dtItens.Rows.Item(I).Item("MVaST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("MVaST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("MVaST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "20" Then
                                Arquivo = Arquivo & "N04|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("ModBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBC").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBC").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "3" & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("RedBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBC").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBC").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "30" Then
                                Arquivo = Arquivo & "N05|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                If (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBCST").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "4" & "|"
                                End If

                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                If (dtItens.Rows.Item(I).Item("MVaST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("MVaST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("MVaST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "40").ToString Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "41") Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "50") Then
                                Arquivo = Arquivo & "N06|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "51" Then
                                Arquivo = Arquivo & "N07|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "60" Then
                                Arquivo = Arquivo & "N08|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & " " & "|"
                                'If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                '    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                'Else
                                '    Arquivo = Arquivo & " " & "|"
                                'End If
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "70") Then
                                Arquivo = Arquivo & "N09|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ModBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBC").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBC").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "3" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("RedBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBC").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBC").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                '    Arquivo = Arquivo & "4" & "|"
                                'ElseIf ReaderVar.Item("TP_TRIB") = "1" Then
                                '    Arquivo = Arquivo & "5" & "|"
                                'Else
                                '    Arquivo = Arquivo & "0" & "|"
                                'End If
                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                '    If (ReaderVar.Item("MVA").ToString <> "Null") And (ReaderVar.Item("MVA").ToString <> "") Then
                                '        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("MVA")), 2).ToString), ",", ".").ToString & "|"
                                '    Else
                                '        Arquivo = Arquivo & " " & "|"
                                '    End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBCST").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                If (dtItens.Rows.Item(I).Item("MVaST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("MVaST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("MVaST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "90") Then
                                Arquivo = Arquivo & "N10|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ModBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBC").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBC").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "3" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("RedBC").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBC").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBC").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                '    Arquivo = Arquivo & "4" & "|"
                                'ElseIf ReaderVar.Item("TP_TRIB") = "1" Then
                                '    Arquivo = Arquivo & "5" & "|"
                                'Else
                                '    Arquivo = Arquivo & "0" & "|"
                                'End If
                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                '    If (ReaderVar.Item("MVA").ToString <> "Null") And (ReaderVar.Item("MVA").ToString <> "") Then
                                '        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("MVA")), 2).ToString), ",", ".").ToString & "|"
                                '    Else
                                '        Arquivo = Arquivo & " " & "|"
                                '    End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ModBCST").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("ModBCST").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If

                                'If ReaderVar.Item("TP_TRIB") = "2" Then
                                If (dtItens.Rows.Item(I).Item("MVaST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("MVaST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("MVaST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                'End If
                                If (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("RedBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("RedBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "101" Then
                                Arquivo = Arquivo & "N10c|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CalcCred").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CalcCred").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("CalcCred").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("VCalcCred").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VCalcCred").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VCalcCred").ToString), 2).ToString), ",", ".").ToString & "|"
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                'Arquivo = Arquivo & "0" & "|"
                                'Arquivo = Arquivo & "0" & "|"
                                'Arquivo = Arquivo & "0" & "|" & vbNewLine
                                'Arquivo = Arquivo & "0" & "|" & vbNewLine
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "102") Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "103") Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "300") Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "400") Then
                                Arquivo = Arquivo & "N10d|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "201") Then

                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "202") Or (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "203") Then
                                Arquivo = Arquivo & "N10f|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & "0|"
                                Arquivo = Arquivo & " |"
                                Arquivo = Arquivo & " |"
                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(dtItens.Rows.Item(I).Item("ICMSST").ToString, 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "500") Then
                                Arquivo = Arquivo & "N10g|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & " |"
                                Arquivo = Arquivo & "0|"
                                Arquivo = Arquivo & "0|"
                            ElseIf (dtItens.Rows.Item(I).Item("CSTICMS").ToString = "900") Then
                                Arquivo = Arquivo & "N10h|"
                                If (dtItens.Rows.Item(I).Item("Origem").ToString <> "Null") And (dtItens.Rows.Item(I).Item("Origem").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("Origem").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTICMS").ToString <> "") Then
                                    Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTICMS").ToString & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & "2|"
                                If (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & "" & "|"
                                If CDec(dtItens.Rows.Item(I).Item("VBCICMS").ToString) > 0 Then
                                    If (dtItens.Rows.Item(I).Item("ICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMS").ToString <> "") Then
                                        Arquivo = Arquivo & Replace(FormatNumber(dtItens.Rows.Item(I).Item("ICMS").ToString, 2), ",", ".") & "|"
                                    Else
                                        Arquivo = Arquivo & "0" & "|"
                                    End If
                                Else
                                    Arquivo = Arquivo & "0" & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMS").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMS").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & "0|"
                                Arquivo = Arquivo & " |"
                                Arquivo = Arquivo & " |"
                                If (dtItens.Rows.Item(I).Item("VBCST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("VBCST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCST").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(dtItens.Rows.Item(I).Item("ICMSST").ToString, 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                If (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "Null") And (dtItens.Rows.Item(I).Item("ValICMSST").ToString <> "") Then
                                    Arquivo = Arquivo & Replace(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValICMSST").ToString), 2), ",", ".") & "|"
                                Else
                                    Arquivo = Arquivo & " " & "|"
                                End If
                                Arquivo = Arquivo & "0" & "|"
                                Arquivo = Arquivo & "0" & "|"
                            ElseIf dtItens.Rows.Item(I).Item("CSTICMS").ToString = "" Then

                                MsgBox("O CST do produto " & dtItens.Rows.Item(I).Item("CodInterno").ToString & " da NF " & Format(CInt(dtItens.Rows.Item(I).Item("NumNF").ToString), "000000") & " não foi informado, FAVOR VERIFICAR!" & vbNewLine & "Nenhuma nota será exportada!", MsgBoxStyle.Information)

                                Exit Function
                            End If
                            Arquivo = Arquivo & vbNewLine
                            Arquivo = Arquivo & "O|"
                            Arquivo = Arquivo & " " & "|"
                            Arquivo = Arquivo & " " & "|"
                            Arquivo = Arquivo & " " & "|"
                            Arquivo = Arquivo & " " & "|"
                            Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CodEnq").ToString & "|" & vbNewLine
                            Select Case dtItens.Rows.Item(I).Item("CSTIPI").ToString
                                Case "01", "02", "03", "04", "05", "51", "52", "53", "54", "55"
                                    Arquivo = Arquivo & "O08|"
                                    If (dtItens.Rows.Item(I).Item("CSTIPI").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTIPI").ToString <> "") Then
                                        Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTIPI").ToString & "|" & vbNewLine
                                    Else
                                        Arquivo = Arquivo & " " & "|" & vbNewLine
                                    End If
                                Case "00", "49", "50", "99"
                                    Arquivo = Arquivo & "O07|"
                                    If (dtItens.Rows.Item(I).Item("CSTIPI").ToString <> "Null") And (dtItens.Rows.Item(I).Item("CSTIPI").ToString <> "") Then
                                        Arquivo = Arquivo & dtItens.Rows.Item(I).Item("CSTIPI").ToString & "|"
                                    Else
                                        Arquivo = Arquivo & " " & "|"
                                    End If
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValIPI").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                    Arquivo = Arquivo & "O10|"
                                    If CDec(dtItens.Rows.Item(0).Item("PerIPI").ToString) > 0 Then
                                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCIPI").ToString), 2).ToString), ",", ".").ToString & "|"
                                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("PerIPI").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                    Else
                                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(0), 2).ToString), ",", ".").ToString & "|"
                                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(0), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                    End If
                            End Select
                            Arquivo = Arquivo & "Q|" & vbNewLine
                            Select Case dtItens.Rows.Item(I).Item("CSTPIS").ToString
                                Case "01", "02"
                                    Arquivo = Arquivo & "Q02|" & dtItens.Rows.Item(I).Item("CSTPIS").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCPIS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("PerPIS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValPIS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                Case "03"
                                    'Arquivo = Arquivo & "Q03|" & ReaderVar.Item("CSTPIS").ToString & "|"

                                Case "04", "06", "07", "08", "09"
                                    Arquivo = Arquivo & "Q04|" & dtItens.Rows.Item(I).Item("CSTPIS").ToString & "|" & vbNewLine
                                Case "99", "98", "49", "50", "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75"
                                    Arquivo = Arquivo & "Q05|" & dtItens.Rows.Item(I).Item("CSTPIS").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValPIS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                    Arquivo = Arquivo & "Q07|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VBCPIS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("PerPIS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                Case Else
                                    Arquivo = Arquivo & "Q04| " & "|" & vbNewLine
                            End Select
                            Arquivo = Arquivo & "S|" & vbNewLine
                            Select Case dtItens.Rows.Item(I).Item("CSTCOFINS").ToString
                                Case "01", "02"
                                    Arquivo = Arquivo & "S02|" & dtItens.Rows.Item(I).Item("CSTCOFINS").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VCBCOFINS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("PerCOFINS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValCOFINS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                Case "04", "06", "07", "08", "09"
                                    Arquivo = Arquivo & "S04|" & dtItens.Rows.Item(I).Item("CSTCOFINS").ToString & "|" & vbNewLine
                                Case "99", "98", "49", "50", "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75"
                                    Arquivo = Arquivo & "S05|" & dtItens.Rows.Item(I).Item("CSTCOFINS").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("ValCOFINS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                    Arquivo = Arquivo & "S07|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("VCBCOFINS").ToString), 2).ToString), ",", ".").ToString & "|"
                                    Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtItens.Rows.Item(I).Item("PerCOFINS").ToString), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                                Case Else
                                    Arquivo = Arquivo & "S04| " & "|" & vbNewLine
                            End Select
                        Next
                    Else
                        MsgBox("Nota Fiscal sem Itens para ser Exportada, favor verificar!", MsgBoxStyle.Information)
                        Exit Function
                    End If
                    Arquivo = Arquivo & "W|" & vbNewLine
                    Arquivo = Arquivo & "W02|"
                    If (dtTotal.Rows.Item(0).Item("VBC").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VBC").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VBC").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VICMS").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VICMS").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VICMS").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VBCST").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VBCST").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VBCST").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VST").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VST").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VST").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VProd").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VProd").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VProd").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VFrete").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VFrete").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VFrete").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VSeg").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VSeg").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VSeg").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VDesc").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VDesc").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VDesc").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If
                    Arquivo = Arquivo & "0.00" & "|"
                    If (dtTotal.Rows.Item(0).Item("VIPI").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VIPI").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VIPI").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & "0.00" & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VPIS").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VPIS").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VPIS").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & "0.00" & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VCOFINS").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VCOFINS").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VCOFINS").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & "0.00" & "|"
                    End If
                    If (dtTotal.Rows.Item(0).Item("VOutro").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VOutro").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VOutro").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & " " & "|"
                    End If

                    If (dtTotal.Rows.Item(0).Item("VNF").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("VNF").ToString <> "") Then
                        Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dtTotal.Rows.Item(0).Item("VNF").ToString), 2).ToString), ",", ".").ToString & "|"
                    Else
                        Arquivo = Arquivo & "0.00" & "|"
                    End If

                    If DeOlhoNoImposto = True Then
                        If PorValorAproximado <> "" Then
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        Else
                            If (dblTotalValAprox.ToString <> "Null") And (dblTotalValAprox.ToString <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(dblTotalValAprox), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                            Else
                                Arquivo = Arquivo & " " & "|" & vbNewLine
                            End If
                        End If
                      
                    Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                    End If


                    Arquivo = Arquivo & "X|"
                    If (strModFrete <> "Null") And (strModFrete <> "") Then
                        Arquivo = Arquivo & strModFrete & "|" & vbNewLine
                    Else
                        Arquivo = Arquivo & " " & "|" & vbNewLine
                    End If

                    If (strNomeTrans <> "Null") And (strNomeTrans <> "") Then
                        Arquivo = Arquivo & "X03|"
                        Arquivo = Arquivo & strNomeTrans & "|"
                        If (strIETrans.Length > 0) And (strIETrans <> "Null") Then
                            Arquivo = Arquivo & Replace(Replace(Replace(strIETrans, ".", "").ToString, "/", "").ToString, "-", "") & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (strEnderecoTrans <> "Null") And (strEnderecoTrans <> "") Then
                            Arquivo = Arquivo & Replace(strEnderecoTrans, ".", "").ToString & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (strUFTrans <> "Null") And (strUFTrans <> "") Then
                            Arquivo = Arquivo & strUFTrans & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (strCidadeTrans <> "Null") And (strCidadeTrans <> "") Then
                            Arquivo = Arquivo & strCidadeTrans & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        End If
                        If (strCNPJTrans <> "Null") And (strCNPJTrans <> "") Then
                            If Len(Trim(Replace(Replace(Replace(strCNPJTrans, ".", "").ToString, "/", "").ToString, "-", ""))) = 11 Then
                                Arquivo = Arquivo & "X05|" & Trim(Replace(Replace(Replace(strCNPJTrans, ".", "").ToString, "/", "").ToString, "-", "")) & "|" & vbNewLine
                            Else
                                Arquivo = Arquivo & "X04|" & Trim(Replace(Replace(Replace(strCNPJTrans, ".", "").ToString, "/", "").ToString, "-", "")) & "|" & vbNewLine
                            End If
                        Else
                            MsgBox("Transportador da Nota: " & strNumNF & " sem CPF/CNPJ Definido! Favor Verificar!" & vbNewLine & "Nenhuma Nota Será Exportada!", MsgBoxStyle.Exclamation)
                            Exit Function
                        End If
                        Arquivo = Arquivo & "X18" & "|"
                        If (strPlaca <> "Null") And (strPlaca <> "") Then
                            Arquivo = Arquivo & Replace(strPlaca, "-", "").ToString & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If
                        If (strUFVei <> "Null") And (strUFVei <> "") Then
                            Arquivo = Arquivo & strUFVei & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If

                        If (strRTNC <> "Null") And (strRTNC <> "") Then
                            Arquivo = Arquivo & strRTNC & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        End If
                    Else
                        'Arquivo = Arquivo & vbNewLine
                    End If

                    Dim dtVol As DataTable = CarregarDataTable("SELECT Qtde, Especie, Marca, Numero, PesoLiq, PesoBruto FROM VolumeNfe where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                    If dtVol.Rows.Count > 0 Then
                        Dim V As Integer
                        For V = 0 To dtVol.Rows.Count - 1
                            Arquivo = Arquivo & "X26" & "|"
                            Dim strQtdeVol As String = dtVol.Rows.Item(V).Item("Qtde").ToString
                            Dim strEspecieVol As String = dtVol.Rows.Item(V).Item("Especie").ToString
                            Dim strMarcaVol As String = dtVol.Rows.Item(V).Item("Marca").ToString
                            Dim strNumeroVol As String = dtVol.Rows.Item(V).Item("Numero").ToString
                            Dim strPesoLiq As String = dtVol.Rows.Item(V).Item("PesoLiq").ToString
                            Dim strPesoBruto As String = dtVol.Rows.Item(V).Item("PesoBruto").ToString
                            If (strQtdeVol <> "Null") And (strQtdeVol <> "") Then
                                Arquivo = Arquivo & strQtdeVol & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strEspecieVol <> "Null") And (strEspecieVol <> "") Then
                                Arquivo = Arquivo & strEspecieVol & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strMarcaVol <> "Null") And (strMarcaVol <> "") Then
                                Arquivo = Arquivo & strMarcaVol & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strNumeroVol <> "Null") And (strNumeroVol <> "") Then
                                Arquivo = Arquivo & strNumeroVol & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strPesoLiq <> "Null") And (strPesoLiq <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strPesoLiq), 3).ToString), ",", ".").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strPesoBruto <> "Null") And (strPesoBruto <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strPesoBruto), 3).ToString), ",", ".").ToString & "|" & vbNewLine
                            Else
                                Arquivo = Arquivo & " " & "|" & vbNewLine
                            End If
                        Next
                    End If
                    
                 
                    Dim strNumFatura As String = dtTotal.Rows.Item(0).Item("NumFatura").ToString
                    Dim strValOrigFatura As String = dtTotal.Rows.Item(0).Item("ValOrigFatura").ToString
                    Dim strValDescFautra As String = dtTotal.Rows.Item(0).Item("ValDescFatura").ToString
                    Dim strValLiqFatura As String = dtTotal.Rows.Item(0).Item("ValLiqFatura").ToString

                    Dim bolFatura As Boolean = False

                    If strNumFatura <> "" Or strValOrigFatura <> "" Or strValDescFautra <> "" Or strValLiqFatura <> "" Then
                        Arquivo = Arquivo & "Y" & "|" & vbNewLine
                        Arquivo = Arquivo & "Y02" & "|"

                        bolFatura = True
                        If (strNumFatura <> "Null") And (strNumFatura <> "") Then
                            Arquivo = Arquivo & strNumFatura & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If

                        If (strValOrigFatura <> "Null") And (strValOrigFatura <> "") Then
                            Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strValOrigFatura), 2).ToString), ",", ".").ToString & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If

                        If (strValDescFautra <> "Null") And (strValDescFautra <> "") Then
                            Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strValDescFautra), 2).ToString), ",", ".").ToString & "|"
                        Else
                            Arquivo = Arquivo & " " & "|"
                        End If

                        If (strValLiqFatura <> "Null") And (strValLiqFatura <> "") Then
                            Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strValLiqFatura), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & " " & "|" & vbNewLine
                        End If

                    End If



                    Dim dtDup As DataTable = CarregarDataTable("SELECT Numero, Data, Valor FROM DuplicataNfe where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig)
                    If dtDup.Rows.Count > 0 Then
                        Dim V As Integer
                        If bolFatura = False Then
                            Arquivo = Arquivo & "Y" & "|" & vbNewLine
                        End If
                        For V = 0 To dtDup.Rows.Count - 1
                            Arquivo = Arquivo & "Y07" & "|"
                            Dim strNumero As String = dtDup.Rows.Item(V).Item("Numero").ToString
                            Dim strData As String = dtDup.Rows.Item(V).Item("Data").ToString
                            Dim strValor As String = dtDup.Rows.Item(V).Item("Valor").ToString

                            If (strNumero <> "Null") And (strNumero <> "") Then
                                Arquivo = Arquivo & Replace(strNumero, "/", "").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strData <> "Null") And (strData <> "") Then
                                Arquivo = Arquivo & Format(CDate(strData), "yyyy-MM-dd").ToString & "|"
                            Else
                                Arquivo = Arquivo & " " & "|"
                            End If

                            If (strValor <> "Null") And (strValor <> "") Then
                                Arquivo = Arquivo & Replace(CDec(FormatNumber(CDec(strValor), 2).ToString), ",", ".").ToString & "|" & vbNewLine
                            Else
                                Arquivo = Arquivo & "0" & "|" & vbNewLine
                            End If

                        Next
                    End If
                    
                   
                  
                    'If confXML.tables.conrec.NOME_TABLE.Trim <> "" Then
                    '    SQL = "SELECT * FROM CONREC WHERE" & _
                    '          " CODCVENDAS='" & Reader.Item("CODCVENDAS") & "'"
                    '    If ExecutaComando(SQL, True) = True Then
                    '        If CountSQL > 0 Then
                    '            ReaderVar.Read()
                    '            Arquivo = Arquivo & "Y" & "|" & vbNewLine
                    '            Arquivo = Arquivo & "Y02" & "|" & ReaderVar.Item("NFORIG").ToString & "|" & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("TOTAL").ToString), 2).ToString), ",", ".") & "||" & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("TOTAL").ToString), 2).ToString), ",", ".") & vbNewLine
                    '            For I = 0 To CountSQL - 1
                    '                Arquivo = Arquivo & "Y07" & "|" & Replace(ReaderVar.Item("DOCUMENTO").ToString, "/", "").ToString & "|" & Format(CDate(ReaderVar.Item("VENCTO")), "yyyy-MM-dd").ToString & "|" & Replace(CDec(FormatNumber(CDec(ReaderVar.Item("VALOR").ToString), 2).ToString), ",", ".") & vbNewLine
                    '                ReaderVar.Read()
                    '            Next
                    '        End If
                    '    End If
                    '    End If
                    'If dtTotal.Rows.Item(0).Item("Obs").ToString <> "" Then

                    '    Arquivo = Arquivo & "Z" & "|"

                    '    'If (Reader.Item("OBS_FISCO").ToString <> "Null") And (Reader.Item("OBS_FISCO").ToString <> "") Then
                    '    '    Arquivo = Arquivo & Reader.Item("OBS_FISCO").ToString & "|"
                    '    '    If (Reader.Item("OBS").ToString <> "Null") And (Reader.Item("OBS").ToString <> "") Then
                    '    '        Arquivo = Arquivo & Reader.Item("OBS").ToString & "|"
                    '    '    Else
                    '    '        Arquivo = Arquivo & " " & "|" & vbNewLine
                    '    '    End If
                    '    'Else
                    '    Arquivo = Arquivo & " " & "|"
                    '    If (dtTotal.Rows.Item(0).Item("Obs").ToString <> "Null") And (dtTotal.Rows.Item(0).Item("Obs").ToString <> "") Then
                    '        Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("Obs").ToString & "|" & vbNewLine
                    '    Else
                    '        Arquivo = Arquivo & " " & "|" & vbNewLine
                    '    End If
                    '    'End If
                    'End If
                    Dim strDeOlhoNoImposto As String = ""
                    If PorValorAproximado <> "" Then

                        Dim dblPerAproximado As Double = PorValorAproximado
                        Dim dblValorTotal As Double = dtTotal.Rows.Item(0).Item("VNF").ToString
                        Dim dblValorAproximado As Double = (dblPerAproximado * dblValorTotal) / 100
                        strDeOlhoNoImposto = "Val Aprox dos Tributos R$ " & dblValorAproximado.ToString("0.00") & " (" & dblPerAproximado.ToString("0.00") & "%) Fonte: IBPT."
                    End If
                    If dtTotal.Rows.Item(0).Item("ObsFisco").ToString <> "" Then
                        Arquivo = Arquivo & "Z" & "|"
                        Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("ObsFisco").ToString & "|"

                  

                        If dtTotal.Rows.Item(0).Item("ObsCont").ToString <> "" Then
                            Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("ObsCont").ToString & " " & strDeOlhoNoImposto & "|" & vbNewLine
                        Else
                            Arquivo = Arquivo & strDeOlhoNoImposto & " " & "|" & vbNewLine
                        End If
                    Else
                        If dtTotal.Rows.Item(0).Item("ObsCont").ToString <> "" Then
                            Arquivo = Arquivo & "Z" & "|"
                            Arquivo = Arquivo & " " & "|"
                            Arquivo = Arquivo & dtTotal.Rows.Item(0).Item("ObsCont").ToString & " " & strDeOlhoNoImposto & "|" & vbNewLine
                        Else
                            If strDeOlhoNoImposto <> "" Then
                                Arquivo = Arquivo & "Z" & "|"
                                Arquivo = Arquivo & " " & "|"
                                Arquivo = Arquivo & strDeOlhoNoImposto & "|" & vbNewLine
                            End If
                      
                        End If
                    End If



                    If File.Exists(PastaNotaNfe & "\" & Format(CInt(strNumNF.ToString), "00000") & ".TXT") = True Then
                        File.Delete(PastaNotaNfe & "\" & Format(CInt(strNumNF.ToString), "00000") & ".TXT")
                    End If
                    Arquivo = Replace(Arquivo, "Ç", "C")
                    Arquivo = Replace(Arquivo, "Á", "A")
                    Arquivo = Replace(Arquivo, "É", "E")
                    Arquivo = Replace(Arquivo, "Í", "I")
                    Arquivo = Replace(Arquivo, "Ã", "A")
                    Arquivo = Replace(Arquivo, "&", "E")
                    Arquivo = Replace(Arquivo, "Õ", "O")
                    Arquivo = Replace(Arquivo, "Ó", "O")
                    Arquivo = Replace(Arquivo, "Ô", "O")
                    Arquivo = Replace(Arquivo, "Ä", "A")
                    Arquivo = Replace(Arquivo, "À", "A")
                    Arquivo = Replace(Arquivo, "Ë", "E")
                    Arquivo = Replace(Arquivo, "Ï", "I")
                    Arquivo = Replace(Arquivo, "Ö", "A")
                    Arquivo = Replace(Arquivo, "Ü", "E")
                    Arquivo = Replace(Arquivo, "Ú", "U")
                    Arquivo = Replace(Arquivo, "Ù", "U")
                    Arquivo = Replace(Arquivo, "/", "")
                    Arquivo = Replace(Arquivo, "º", "")
                    Arquivo = Replace(Arquivo, "ª", "")
                    Call SalvarArquivo(Arquivo, PastaNotaNfe & "\" & Format(CInt(strNumNF.ToString), "00000") & ".TXT", False)


                    'SQL = "UPDATE CVENDAS SET" & _
                    '      " EXPORTAR='0'" & _
                    '      " WHERE EXPORTAR='1'"
                    'If ExecutaComando(SQL, True) = True Then
                    'AbrirNFe(NotaFiscal)
                    'Thread.Sleep(5000)
                    'If NotaFiscal.ToString.Trim <> "" Then
                    '    LerRetornoProcessamento()
                    'End If
                    'End If
                End If




            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Function ExportarCce(ByVal parCodOrdem As String, ByVal parNumSeq As String, ByVal parNumNF As String) As Boolean
        Dim Arquivo As String = ""
        Dim strNomeArq As String = ""
        Try

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, CodOrdem, Versao, Id, CUF, TipoAmb, Chave, DEmi, HEmi, TZD, TipoEvento, " & _
            "NumSeqEvento, CNPJ, DescEvento, Correcao, CondUso FROM Cce where CodOrdem = " & parCodOrdem & " and CodConfig = " & CodConfig & " and NumSeqEvento = '" & parNumSeq & "'")

            If dt.Rows.Count > 0 Then

                Dim strCNPJ As String = dt.Rows.Item(0).Item("CNPJ").ToString
                Dim strCodUF As String = dt.Rows.Item(0).Item("CUF").ToString
                strCNPJ = strCNPJ.Replace(".", "").Replace("/", "").Replace("-", "")

                Dim strVersao As String = dt.Rows.Item(0).Item("Versao").ToString
                Dim strId As String = dt.Rows.Item(0).Item("Id").ToString
                Dim strChave As String = dt.Rows.Item(0).Item("Chave").ToString

                Dim strTipoAmb As String = dt.Rows.Item(0).Item("TipoAmb").ToString

                Dim strTZD As String = dt.Rows.Item(0).Item("TZD").ToString
                Dim strTipoEvento As String = dt.Rows.Item(0).Item("TipoEvento").ToString
                Dim strNumSeqEvento As String = dt.Rows.Item(0).Item("NumSeqEvento").ToString
                Dim strDescEvento As String = dt.Rows.Item(0).Item("DescEvento").ToString
                Dim strCorrecao As String = dt.Rows.Item(0).Item("Correcao").ToString
                Dim strCondUso As String = dt.Rows.Item(0).Item("CondUso").ToString

                strNomeArq = parNumNF & "-" & strNumSeqEvento

                Arquivo = ""
                Arquivo = "EVENTO|" & "1" & vbNewLine
                Arquivo = Arquivo & "A|" & strVersao & "|CCE" & vbNewLine

                'If (strId <> "Null") And (strId <> "") Then
                '    Arquivo = Arquivo & strId & "|" & vbNewLine
                'Else
                '    Arquivo = Arquivo & " " & "|" & vbNewLine
                'End If

                If (strCodUF <> "Null") And (strCodUF <> "") Then
                    Arquivo = Arquivo & "B|" & strCodUF & "|"
                Else
                    Arquivo = Arquivo & "B| " & "|"
                End If

                If (strTipoAmb <> "Null") And (strTipoAmb <> "") Then
                    Arquivo = Arquivo & strTipoAmb & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strChave <> "Null") And (strChave <> "") Then
                    Arquivo = Arquivo & strChave & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (dt.Rows.Item(0).Item("DEmi").ToString <> "Null") And (dt.Rows.Item(0).Item("DEmi").ToString <> "") Then
                    Arquivo = Arquivo & Format(CDate(dt.Rows.Item(0).Item("DEmi")), "yyyy-MM-dd").ToString & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (dt.Rows.Item(0).Item("HEmi").ToString <> "Null") And (dt.Rows.Item(0).Item("HEmi").ToString <> "") Then
                    Arquivo = Arquivo & Format(CDate(dt.Rows.Item(0).Item("HEmi")), "HH:mm:ss").ToString & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strTZD <> "Null") And (strTZD <> "") Then
                    Arquivo = Arquivo & strTZD & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strTipoEvento <> "Null") And (strTipoEvento <> "") Then
                    Arquivo = Arquivo & strTipoEvento & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strNumSeqEvento <> "Null") And (strNumSeqEvento <> "") Then
                    Arquivo = Arquivo & strNumSeqEvento & "|" & vbNewLine
                Else
                    Arquivo = Arquivo & " " & "|" & vbNewLine
                End If


                If (strCNPJ <> "Null") And (strCNPJ <> "") Then
                    Arquivo = Arquivo & "C02|" & strCNPJ & vbNewLine
                Else
                    Arquivo = Arquivo & "C02| " & vbNewLine
                End If

                Arquivo = Arquivo & "D|"
                If (strDescEvento <> "Null") And (strDescEvento <> "") Then
                    Arquivo = Arquivo & strDescEvento & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strCorrecao <> "Null") And (strCorrecao <> "") Then
                    Arquivo = Arquivo & strCorrecao & "|"
                Else
                    Arquivo = Arquivo & " " & "|"
                End If

                If (strCondUso <> "Null") And (strCondUso <> "") Then
                    Arquivo = Arquivo & strCondUso & vbNewLine
                Else
                    Arquivo = Arquivo & " " & vbNewLine
                End If




                If File.Exists(PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT") = True Then
                    File.Delete(PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT")
                End If
                Arquivo = Replace(Arquivo, "Ç", "C")
                Arquivo = Replace(Arquivo, "Á", "A")
                Arquivo = Replace(Arquivo, "É", "E")
                Arquivo = Replace(Arquivo, "Í", "I")
                Arquivo = Replace(Arquivo, "Ã", "A")
                Arquivo = Replace(Arquivo, "&", "E")
                Arquivo = Replace(Arquivo, "Õ", "O")
                Arquivo = Replace(Arquivo, "Ó", "O")
                Arquivo = Replace(Arquivo, "Ô", "O")
                Arquivo = Replace(Arquivo, "Ä", "A")
                Arquivo = Replace(Arquivo, "À", "A")
                Arquivo = Replace(Arquivo, "Ë", "E")
                Arquivo = Replace(Arquivo, "Ï", "I")
                Arquivo = Replace(Arquivo, "Ö", "A")
                Arquivo = Replace(Arquivo, "Ü", "E")
                Arquivo = Replace(Arquivo, "Ú", "U")
                Arquivo = Replace(Arquivo, "Ù", "U")
                'Arquivo = Replace(Arquivo, "/", "")
                Arquivo = Replace(Arquivo, "º", "")
                Arquivo = Replace(Arquivo, "ª", "")
                Call SalvarArquivo(Arquivo, PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT", False)

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    Function ExportarInutilizacao(ByVal parNumInicial As String, ByVal parNumFinal As String, ByVal parMotivo As String, ByVal parSerie As String, ByVal parAno As String, ByVal parCodigo As String) As Boolean
        Dim Arquivo As String = ""
        Dim strNomeArq As String = ""
        Try

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo, Razao, Fantasia, CNPJ, IE, Endereco, Bairro, Numero, Cidade, CodMun, Cep, UF, CodUF, " & _
            "Pais, CodPais, CRT, Telefone, NatOp, Mod, Serie, TipoNF, TipoImp, TipoEmi, TipoAmb, FinNfe, ProcEmi, VerProc, ModFrete FROM ConfigNfe where CodConfig = " & CodConfig)

            If dt.Rows.Count > 0 Then

                Dim strCNPJEmitente As String = dt.Rows.Item(0).Item("CNPJ").ToString
                Dim strCodUFEmitente As String = dt.Rows.Item(0).Item("CodUF").ToString
                Dim strModelo As String = dt.Rows.Item(0).Item("Mod").ToString
                Dim strSerie As String = dt.Rows.Item(0).Item("Serie").ToString
                strCNPJEmitente = strCNPJEmitente.Replace(".", "").Replace("/", "").Replace("-", "")

                Arquivo = ""
                Arquivo = "INUTILIZA|" & "1" & "|" & vbNewLine

                Arquivo = Arquivo & "A|" & strCodUFEmitente & "|" & parNumInicial & "|" & parNumFinal & "|" & strCNPJEmitente & "|" & parSerie & "|" & strModelo & "|" & parAno & "|" & parMotivo & vbNewLine

                strNomeArq = "Inut-" & parCodigo



                If File.Exists(PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT") = True Then
                    File.Delete(PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT")
                End If
                Arquivo = Replace(Arquivo, "Ç", "C")
                Arquivo = Replace(Arquivo, "Á", "A")
                Arquivo = Replace(Arquivo, "É", "E")
                Arquivo = Replace(Arquivo, "Í", "I")
                Arquivo = Replace(Arquivo, "Ã", "A")
                Arquivo = Replace(Arquivo, "&", "E")
                Arquivo = Replace(Arquivo, "Õ", "O")
                Arquivo = Replace(Arquivo, "Ó", "O")
                Arquivo = Replace(Arquivo, "Ô", "O")
                Arquivo = Replace(Arquivo, "Ä", "A")
                Arquivo = Replace(Arquivo, "À", "A")
                Arquivo = Replace(Arquivo, "Ë", "E")
                Arquivo = Replace(Arquivo, "Ï", "I")
                Arquivo = Replace(Arquivo, "Ö", "A")
                Arquivo = Replace(Arquivo, "Ü", "E")
                Arquivo = Replace(Arquivo, "Ú", "U")
                Arquivo = Replace(Arquivo, "Ù", "U")
                Arquivo = Replace(Arquivo, "/", "")
                Arquivo = Replace(Arquivo, "º", "")
                Arquivo = Replace(Arquivo, "ª", "")
                Call SalvarArquivo(Arquivo, PastaNotaNfe & "\" & strNomeArq.ToString & ".TXT", False)


            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
    'Function VerRetornoNF(Optional ByVal NotaFiscal As String = "", Optional ByVal Serie As String = "", Optional ByVal Arquivo As String = "") As Boolean
    '    VerRetornoNF = False
    '    Try
    '        Dim Conteudo As String = ""
    '        Dim Chave As String = ""
    '        Dim DigValue As String = ""
    '        Dim Protocolo As String = ""
    '        Dim Retorno As String = ""
    '        Dim Motivo As String = ""
    '        Dim ConteudoLinha() As String
    '        If NotaFiscal.ToString.Trim <> "" Then
    '            If File.Exists("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                Conteudo = LerConteudoArquivo("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '            ElseIf File.Exists(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                Conteudo = LerConteudoArquivo(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '            End If
    '        Else
    '            Conteudo = LerConteudoArquivo(Arquivo)
    '        End If
    '        Dim Linhas() As String = Split(Conteudo, Chr(13))
    '        Dim TipoArquivo() As String = Split(Linhas(0).ToString, "|")
    '        If TipoArquivo(0).ToString = "NOTA FISCAL" Then
    '            Dim MSGRET As String = ""
    '            For i As Integer = 0 To UBound(Linhas) - 1
    '                ConteudoLinha = Split(Linhas(i).ToString, "|")
    '                If ConteudoLinha(0).ToString.Trim = "B" Then
    '                    Serie = ConteudoLinha(6).ToString.Trim
    '                    NotaFiscal = ConteudoLinha(7).ToString.Trim
    '                ElseIf ConteudoLinha(0).ToString.Trim = "RP" Then
    '                    Protocolo = ConteudoLinha(1).ToString.Trim
    '                    DigValue = ConteudoLinha(2).ToString.Trim
    '                    Retorno = ConteudoLinha(3).ToString.Trim
    '                    Motivo = ConteudoLinha(4).ToString.Trim
    '                    Chave = ConteudoLinha(5).ToString.Trim.Replace("NFe", "")
    '                    If File.Exists("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                        If verDiretorio("N:\NSNFe\Processados\Lidos") = True Then
    '                            File.Move("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt", "N:\NSNFe\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                        End If
    '                    ElseIf File.Exists(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                        If verDiretorio(sDiretorioNFe & "\Processados\Lidos") = True Then
    '                            If File.Exists(sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                                File.Delete(sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                            End If
    '                            File.Move(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt", sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                        End If
    '                    End If
    '                    Exit For
    '                ElseIf ConteudoLinha(0).ToUpper.Trim = "MSG" Then
    '                    MSGRET &= "- " & ConteudoLinha(1).ToString & vbNewLine
    '                    If File.Exists("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                        If verDiretorio("N:\NSNFe\Processados\Lidos") = True Then
    '                            File.Move("N:\NSNFe\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt", "N:\NSNFe\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                        End If
    '                    ElseIf File.Exists(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                        If verDiretorio(sDiretorioNFe & "\Processados\Lidos") = True Then
    '                            If File.Exists(sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                                File.Delete(sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                            End If
    '                            File.Move(sDiretorioNFe & "\Processados\" & Format(CInt(NotaFiscal), "00000") & ".txt", sDiretorioNFe & "\Processados\Lidos\" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '                        End If
    '                    End If
    '                End If
    '            Next
    '            If MSGRET.Equals("") = False Then
    '                frmVendas.TimerProcessamento.Enabled = False
    '                frmVendas.Enabled = True
    '                frmVendas.cmdLimpar.PerformClick()
    '                MessageBox.Show(MSGRET, TitleMSG, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If
    '            If Chave.ToString.Trim <> "" Then
    '                Sql = "UPDATE CVENDAS SET" & _
    '                      " CSTAT='" & Retorno.ToString & "'," & _
    '                      " DIGVALUE='" & DigValue.ToString & "'," & _
    '                      " XMOTIVO='" & Motivo.ToString.ToUpper & "'," & _
    '                      " PROTOCOLO='" & Protocolo.ToString & "'," & _
    '                      " CHAVE='" & Chave.ToString & "'"
    '                Select Case Retorno
    '                    Case "100"
    '                        Sql &= " ,STATUS='NORMAL'"
    '                    Case "110", "205", "301", "302"
    '                        Sql &= " ,STATUS='DENEGADA'"
    '                    Case Else
    '                        Sql &= " ,STATUS=''"
    '                End Select
    '                Sql &= " WHERE NOTAFISCAL='" & CInt(NotaFiscal) & "' AND" & _
    '                       " SERIE='" & Serie.ToString.Trim.ToUpper & "' AND" & _
    '                       " MODELO='55'"
    '                If ExecutaComando(Sql) = True Then
    '                    VerRetornoNF = True
    '                Else
    '                    VerRetornoNF = False
    '                End If
    '                Try
    '                    If IsDBNull(dadosNFeParam.Tables(0).Rows(0).Item("CODDEPOSITO")) = False Then
    '                        Sql = "UPDATE CENTRADAS SET" & _
    '                              " NOTADEPOSITO='" & NotaFiscal & "'" & _
    '                              " WHERE CODENTRADA='" & dadosNFeParam.Tables(0).Rows(0).Item("CODDEPOSITO") & "'"
    '                        ExecutaComando(Sql)
    '                    End If
    '                Catch ex As Exception
    '                End Try
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Function
    '    Function VerRetornoCancelaNF(ByVal NotaFiscal As String, ByVal Serie As String, ByVal MotivoCanc As String, ByVal Modelo As String) As Boolean
    '        VerRetornoCancelaNF = False
    '        Try
    '            Dim Conteudo As String = ""
    '            Dim Protocolo As String = ""
    '            Dim Retorno As String = ""
    '            Dim Motivo As String = ""
    '            Dim ConteudoLinha() As String
    '            If File.Exists("N:\NSNFe\Processados\CANC" & Format(CInt(NotaFiscal), "00000") & ".txt") = True Then
    '                Conteudo = LerConteudoArquivo("N:\NSNFe\Processados\CANC" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '            Else
    '                Conteudo = LerConteudoArquivo(sDiretorioNFe & "\Processados\CANC" & Format(CInt(NotaFiscal), "00000") & ".txt")
    '            End If
    '            Dim Linhas() As String = Split(Conteudo, Chr(13))
    '            Dim TipoArquivo() As String = Split(Linhas(0).ToString, "|")
    '            If TipoArquivo(0).ToString = "CANCELAMENTO" Then
    '                For i As Integer = 0 To UBound(Linhas) - 1
    '                    ConteudoLinha = Split(Linhas(i).ToString, "|")
    '                    If ConteudoLinha(0).ToString.Trim = "RP" Then
    '                        Retorno = ConteudoLinha(1).ToString.Trim
    '                        Motivo = ConteudoLinha(2).ToString.Trim
    '                        Protocolo = ConteudoLinha(3).ToString.Trim
    '                        Exit For
    '                    End If
    '                Next
    '                If Protocolo.ToString.Trim <> "" Then
    '                    Select Case Retorno
    '                        Case "101", "420"
    '                            Sql = "EXECUTE PROCEDURE CANCELA_NOTA_SAIDA(" & _
    '                              "'" & CInt(NotaFiscal) & "'," & _
    '                              "'" & Serie.ToString.Trim & "'," & _
    '                              "'" & Retorno & "'," & _
    '                              "'" & Motivo & "'," & _
    '                              "'" & Protocolo & "'," & _
    '                              "'" & MotivoCanc.ToString.ToUpper & "'," & _
    '                              "'" & Modelo & "')"
    '                            If ExecutaComando(Sql) = True Then
    '                                VerRetornoCancelaNF = True
    '                            Else
    '                                VerRetornoCancelaNF = False
    '                            End If
    '                    End Select
    '                End If
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '    Sub AbrirNFe(Optional ByVal NotaFiscal As String = "")
    '        Try
    '            If NotaFiscal.ToString.Trim <> "" Then
    '                If File.Exists("N:\NSNFe\NFe.exe") = True Then
    '                    System.Diagnostics.Process.Start("N:\NSNFe\NFe.exe", CInt(NotaFiscal))
    '                ElseIf File.Exists(sDiretorioNFe & "\NFe.exe") = True Then
    '                    System.Diagnostics.Process.Start(sDiretorioNFe & "\NFe.exe", CInt(NotaFiscal))
    '                Else
    '                    MessageBox.Show("Emissor de NFe não Localizado!", TitleMSG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    Exit Sub
    '                End If
    '            Else
    '                If File.Exists("N:\NSNFe\NFe.exe") = True Then
    '                    System.Diagnostics.Process.Start("N:\NSNFe\NFe.exe")
    '                ElseIf File.Exists(sDiretorioNFe & "\NFe.exe") = True Then
    '                    System.Diagnostics.Process.Start(sDiretorioNFe & "\NFe.exe")
    '                Else
    '                    MessageBox.Show("Emissor de NFe não Localizado!", TitleMSG, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    Exit Sub
    '                End If
    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Function verDiretorio(ByVal Diretorio As String) As Boolean
    '        Try
    '            If Directory.Exists(Diretorio) = False Then
    '                Directory.CreateDirectory(Diretorio)
    '                Return True
    '            Else
    '                Return True
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Function
    '    Sub LerRetornoProcessamento()
    '        Try
    '            frmVendas.TabGeral.SelectTab(1)
    '            frmVendas.Enabled = False
    '            frmVendas.TimerProcessamento.Enabled = True
    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Sub ReprocessarNFesSemRetorno()
    '        'Sql = "UPDATE CVENDAS SET" & _
    '        '" EXPORTAR='1'" & _
    '        '" WHERE CHAVE IS NULL" & _
    '        '" AND CSTAT IS NULL" & _
    '        '" AND MODELO='55'" & _
    '        '" AND EMISSAO>='01/01/2012'"
    '        'If ExecutaComando(Sql) = True Then
    '        'ExportarNotas()
    'volta:
    '        DirDiretorio = New DirectoryInfo(sDiretorioNFe & "\Processados\")
    '        oFileInfoCollection = DirDiretorio.GetFiles("*.txt")
    '        If oFileInfoCollection.Length > 0 Then

    '            For i As Integer = 0 To oFileInfoCollection.Length - 1
    '                oFileInfo = oFileInfoCollection.GetValue(i)
    '                VerRetornoNF("", "", oFileInfo.FullName)
    '            Next
    '        End If

    '        DirDiretorio = New DirectoryInfo(sDiretorioNFe & "\Processados\")
    '        oFileInfoCollection = DirDiretorio.GetFiles("*.txt")
    '        If oFileInfoCollection.Length > 0 Then
    '            GoTo volta
    '        End If
    '        'End If
    '    End Sub
End Module
