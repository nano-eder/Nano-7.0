Imports System
Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports Nano.clsFuncoes
Public Class clsNfeXml

    Public Shared Function ArquivoNfeXml(ByVal parArquivo As String, ByVal parTagsBloco As String, ByVal parTags As String) As DataTable
        Dim strSelect As String = ""
        If parTags <> "" Then
            strSelect = "select * FROM Openxml(@i,'" & parTagsBloco & "',3)with(" & parTags & ")"
        Else
            strSelect = "select * FROM Openxml(@i,'" & parTagsBloco & "',6)"
        End If


        Dim parCmdSql As String
        Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
        parCmdSql = "declare @xml_text varchar(max), @i INT" & vbCrLf & _
        "select @xml_text =N'" & parArquivo & "'" & vbCrLf & _
        "set @xml_text = Replace(@xml_text, 'xmlns=""http://www.portalfiscal.inf.br/nfe""', '')" & vbCrLf & _
        "set @xml_text = Replace(@xml_text, 'versao=""2.00""', '')" & vbCrLf & _
        "set @xml_text = Replace(@xml_text, 'versao=""1.00""', '')" & vbCrLf & _
        "set @xml_text = Replace(@xml_text, 'versao=""1.10""', '')" & vbCrLf & _
        "set @xml_text = Replace(@xml_text, 'encoding=""UTF-8""', 'encoding=""ISO-8859-1""')" & vbCrLf & _
        "exec sp_xml_preparedocument @i output, @xml_text" & vbCrLf & _
        strSelect & vbCrLf & _
        "exec sp_xml_removedocument @i"

        Dim da As SqlDataAdapter
        Dim dt As DataTable

        da = New SqlDataAdapter(parCmdSql, conexao)

        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception

            If TelaErro(ex.Message, parCmdSql) = True Then
                MensagemDeErro = ex.Message
                Dim Erro As New clsFuncoes
                Erro.IniciaThread()
            Else
                If NovoComandoSQL <> Nothing Then
                    da = New SqlDataAdapter(NovoComandoSQL, conexao)
                    dt = New DataTable
                    da.Fill(dt)
                End If
            End If
        End Try

        Return dt
    End Function
   
    Public Shared Function ProdutoNfeXml(ByVal parArquivo As String) As DataTable
       
        Dim dt As DataTable = ArquivoNfeXml(parArquivo, "/nfeProc/NFe/infNFe/det/prod", "cProd varchar(10), cEAN varchar(25), uCom varchar(2), qCom Numeric(15,2), vUnCom Numeric(15,2), xProd varchar(100), vProd Numeric(15,2)")

        Return dt
    End Function
    Public Shared Function FornecedorNfeXml(ByVal parArquivo As String) As DataTable

        Dim dt As DataTable = ArquivoNfeXml(parArquivo, "/nfeProc/NFe/infNFe/emit/enderEmit", "CNPJ varchar(20) '../CNPJ' , xNome Varchar(100) '../xNome', xFant varchar(100) '../xFant', IE varchar(20) '../IE', nro Varchar(10), xLgr varchar(100), xBairro varchar(80), xMun varchar(80), UF varchar(2), CEP varchar(9), fone varchar(20)")

        Return dt
    End Function

    Public Shared Function NotaNfeXml(ByVal parArquivo As String) As DataTable

        Dim dt As DataTable = ArquivoNfeXml(parArquivo, "/nfeProc/NFe/infNFe/ide", "nNF varchar(20), serie Varchar(10), dEmi SmalldateTime")

        Return dt
    End Function
    Public Shared Function TotalNfeXml(ByVal parArquivo As String) As DataTable

        Dim dt As DataTable = ArquivoNfeXml(parArquivo, "/nfeProc/NFe/infNFe/total/ICMSTot", "vST Numeric(15,2), vFrete Numeric(15,2), vSeg Numeric(15,2), vDesc Numeric(15,2), vIPI Numeric(15,2), vOutro Numeric(15,2), vNF Numeric(15,2)")

        Return dt
    End Function

    Public Shared Function ChaveXml(ByVal parTexto As String) As String
        Dim strChave As String = ""
        Dim strTexto() As String = System.Text.RegularExpressions.Regex.Split(parTexto, "\n")

        For Each Linha As String In strTexto
            strChave = Linha
            If strChave.Contains("<infNFe versao=""3.10"" Id=""NFe") = True Or strChave.Contains("<infNFe versao=""4.00"" Id=""NFe") = True Or strChave.Contains("<infNFe Id=""") = True Then
                Dim str As String = strChave.Replace("<infNFe versao=""3.10"" Id=""NFe", "|").Replace("<infNFe versao=""4.00"" Id=""NFe", "|").Replace("<infNFe Id=""NFe", "|")
                Dim vet As String() = str.Split("|")
                strChave = vet(1).ToString.Substring(0, 44)
                Exit For
            End If
        Next

        Return strChave
    End Function

    Public Shared Function NfeXml(ByVal parArquivo As String) As Boolean
        ' Try
        Dim strTexto As String = LerArquivo(parArquivo, True)
        '
        strTexto = strTexto.Replace("xml version='1.0'", "xml version=""1.0""")

        strTexto = strTexto.Replace("'UTF-8'", """UTF-8""")
        strTexto = strTexto.Replace("'utf-8'", """utf-8""")

        strTexto = strTexto.Replace("'", """")

        If strTexto.Contains("?xml") = False Then
            strTexto = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>" & strTexto
        End If

        Dim strTags As String = "/nfeProc"
        If strTexto.Contains("nfeProc") = False Then
            strTags = ""
        End If


        
        '
        'Numero, serie e data da Nota Fiscal
        'Dim dtNF As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe", "")

        Dim dtNF As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/ide", "nNF varchar(20), serie Varchar(10), dEmi SmalldateTime")

        frmEntradaNF.txtNF.Text = dtNF.Rows.Item(0).Item("nNF").ToString
        frmEntradaNF.dtData.Text = Date.Today
        frmEntradaNF.txtSerie.Text = dtNF.Rows.Item(0).Item("serie").ToString
        frmEntradaNF.cboTipo.Text = "F"


        '
        'Carrega chave do xml
        'frmEntradaNF.txtChave.Text = ChaveXml(strTexto)
        Try
            dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/protNFe/infProt", "chNFe varchar(100)")
            If dtNF.Rows.Count > 0 Then
                frmEntradaNF.txtChave.Text = dtNF.Rows.Item(0).Item("chNFe").ToString
            End If
        Catch ex As Exception
        End Try



        'Dados do Fornecedor
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/emit/enderEmit", "xFant varchar(100) '../xFant', CNPJ varchar(20) '../CNPJ' , xNome Varchar(100) '../xNome', IE varchar(20) '../IE', nro Varchar(10), xLgr varchar(100), xBairro varchar(80), xMun varchar(80), UF varchar(2), CEP varchar(9), fone varchar(20)")

        frmEntradaNF.txtFor.Text = dtNF.Rows.Item(0).Item("xNome").ToString.ToUpper
        Dim strFornecedor As String = dtNF.Rows.Item(0).Item("xNome").ToString.ToUpper
        Dim strCNPJ As String = AddPonto(dtNF.Rows.Item(0).Item("CNPJ").ToString, "J")
        frmEntradaNF.txtCPF.Text = strCNPJ
        frmEntradaNF.tbFor.Rows.Clear()
        With frmEntradaNF.tbFor.Rows
            .Add()
            .Item(0).Item("Endereco") = dtNF.Rows.Item(0).Item("xLgr").ToString.ToUpper
            .Item(0).Item("Numero") = dtNF.Rows.Item(0).Item("nro").ToString
            .Item(0).Item("Bairro") = dtNF.Rows.Item(0).Item("xBairro").ToString.ToUpper
            .Item(0).Item("Cidade") = dtNF.Rows.Item(0).Item("xMun").ToString.ToUpper
            .Item(0).Item("Estado") = dtNF.Rows.Item(0).Item("UF").ToString
            .Item(0).Item("Cep") = AddPonto(dtNF.Rows.Item(0).Item("CEP").ToString, "CEP")
            .Item(0).Item("Telefone") = AddPonto(dtNF.Rows.Item(0).Item("fone").ToString, "TEL")
            .Item(0).Item("IE") = dtNF.Rows.Item(0).Item("IE").ToString
            .Item(0).Item("Fantasia") = dtNF.Rows.Item(0).Item("xFant").ToString.ToUpper
        End With

        Dim strNomeFor As String = ""
        Dim intCodFor As Integer = 0
        Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo, Nome FROM Fornecedor where CPF = '" & strCNPJ & "'")
        If dtFor.Rows.Count > 0 Then
            strNomeFor = dtFor.Rows.Item(0).Item("Nome").ToString
            intCodFor = dtFor.Rows.Item(0).Item("Codigo").ToString
        End If


        'Dados dos Produtos 
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/prod", "nItem Varchar(5) '../@nItem', cProd varchar(20), " & _
        "cEAN varchar(25), uCom varchar(6), qCom Numeric(15,3), vUnCom Numeric(15,10), xProd varchar(100), vProd Numeric(15,2), " & _
        "NCM varchar(8), CFOP varchar(4), EXTIPI varchar(3), genero varchar(2), uTrib varchar(6), vUnTrib NUMERIC(15,10), " & _
        "qTrib numeric(15,3), vFrete numeric(15,3), vSeg numeric(15,3), vOutro numeric(15,3)")


        Dim dtImp As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det", "")

        Dim A As Integer
        Dim B As Integer = 0
        Dim dtICMS As DataTable
        dtICMS = New DataTable

        dtICMS.Columns.Add("nItem")
        dtICMS.Columns.Add("ICMS")

        For A = 0 To dtImp.Rows.Count - 1
            If A > dtImp.Rows.Count Then Exit For
            If dtImp.Rows.Item(A).Item("Localname").ToString = "nItem" Then
                A += 1
                dtICMS.Rows.Add()
                dtICMS.Rows.Item(B).Item("nItem") = dtImp.Rows.Item(A).Item("Text").ToString
            End If

            If dtImp.Rows.Item(A).Item("Localname").ToString = "ICMS" Then
                A += 1
                dtICMS.Rows.Item(B).Item("ICMS") = dtImp.Rows.Item(A).Item("Localname").ToString
                B += 1
            End If

        Next

        frmEntradaNF.tbEntrada.Rows.Clear()

        With frmEntradaNF.tbEntrada.Rows
            Dim I As Integer
            For I = 0 To dtNF.Rows.Count - 1
                Dim strNItem As String = dtNF.Rows.Item(I).Item("nItem").ToString
                Dim strImp As String


                Dim strOrigem As String = ""
                Dim strCST As String = ""
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
                Dim strNCM As String = ""
                Dim strCFOP As String = ""
                Dim strRegime As String = ""
                Dim strCSTIPI As String = ""
                Dim strCodEnq As String
                Dim strPerIPI As String
                Dim strCSTPIS As String = ""
                Dim strPerPIS As String = ""
                Dim strCSTCOFINS As String = ""
                Dim strPerCOFINS As String = ""


                Dim strQuery1 As String = "nItem ='" & strNItem & "'"
                Dim drICMS As DataRow()
                drICMS = dtICMS.Select(strQuery1)


                'For B = 0 To dtICMS.Rows.Count - 1
                '    If strNItem = dtICMS.Rows.Item(B).Item("nItem") Then
                '        strImp = dtICMS.Rows.Item(B).Item("ICMS")
                strImp = drICMS(0).Item("ICMS").ToString

                dtImp = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/ICMS/" & strImp & "", "nItem Varchar(5) '../../../@nItem', " & _
                "orig Varchar(2), CST varchar(5), CSOSN varchar(5), modBC varchar(1), pRedBC varchar(10), " & _
                "pICMS varchar(10), pICMSST varchar(10), modBCST varchar(1), pMVAST varchar(10), pRedBCST varchar(10), " & _
                "pCredSN varchar(10), vBCST varchar(10), vBC varchar(10), vCredICMSSN varchar(10), vICMS varchar(10), " & _
                "vICMSST varchar(10), vFCPST varchar(10)")

                Dim strQuery As String = "nItem ='" & strNItem & "'"
                Dim dr As DataRow()
                dr = dtImp.Select(strQuery)

                strOrigem = dr(0).Item("orig").ToString

                If dr(0).Item("CST").ToString <> "" Then
                    strCST = dr(0).Item("CST").ToString
                Else
                    strCST = dr(0).Item("CSOSN").ToString
                End If

                strModBC = dr(0).Item("modBC").ToString
                strICMS = dr(0).Item("pICMS").ToString.Replace(".", ",")
                strRedBC = dr(0).Item("pRedBC").ToString
                strModBCST = dr(0).Item("modBCST").ToString
                strRedBCST = dr(0).Item("pRedBCST").ToString
                strMVaST = dr(0).Item("pMVAST").ToString
                strICMSST = dr(0).Item("pICMSST").ToString.Replace(".", ",")
                strCalculoCred = dr(0).Item("pCredSN").ToString



                Dim valBCST As String = dr(0).Item("vBCST").ToString.Replace(".", ",")

                Dim valBC As String = dr(0).Item("vBC").ToString.Replace(".", ",")





                Dim strOrigemEnt As String = dr(0).Item("orig").ToString
                Dim strCSTEnt As String = ""
                Dim strRegimeEnt As String = ""
                If dr(0).Item("CST").ToString <> "" Then
                    strCSTEnt = dr(0).Item("CST").ToString
                    strRegimeEnt = "TRIBUTAÇÃO NORMAL"
                    strRegime = "TRIBUTAÇÃO NORMAL"
                Else
                    strCSTEnt = dr(0).Item("CSOSN").ToString
                    strRegimeEnt = "SIMPLES NACIONAL"
                    strRegime = "SIMPLES NACIONAL"
                End If
                Dim strModBCEnt As String = dr(0).Item("modBC").ToString
                Dim strAliquotaICMSEnt As String = dr(0).Item("pICMS").ToString.Replace(".", ",")
                Dim strRedBCEnt As String = dr(0).Item("pRedBC").ToString
                Dim strValICMSEnt As String = dr(0).Item("vICMS").ToString.Replace(".", ",")
                Dim strModBCSTEnt As String = dr(0).Item("modBCST").ToString
                Dim strRedBCSTEnt As String = dr(0).Item("pRedBCST").ToString.Replace(".", ",")
                Dim strMVaSTEnt As String = dr(0).Item("pMVAST").ToString.Replace(".", ",")
                Dim strAliquotaICMSSTEnt As String = dr(0).Item("pICMSST").ToString.Replace(".", ",")
                Dim strValICMSSTEnt As String = dr(0).Item("vICMSST").ToString.Replace(".", ",")
                Dim strCalculoCredEnt As String = dr(0).Item("pCredSN").ToString.Replace(".", ",")
                Dim strValCredEnt As String = dr(0).Item("vCredICMSSN").ToString.Replace(".", ",")

                Dim strVFCPST As String = dr(0).Item("vFCPST").ToString.Replace(".", ",")

                Dim strNCMEnt As String = dtNF.Rows.Item(I).Item("NCM").ToString
                Dim strCFOPEnt As String = dtNF.Rows.Item(I).Item("CFOP").ToString


                strNCM = dtNF.Rows.Item(I).Item("NCM").ToString
                strCFOP = dtNF.Rows.Item(I).Item("CFOP").ToString

                Dim strFreteEnt As String = dtNF.Rows.Item(I).Item("vFrete").ToString
                Dim strDespesasEnt As String = dtNF.Rows.Item(I).Item("vOutro").ToString
                Dim strSeguroEnt As String = dtNF.Rows.Item(I).Item("vSeg").ToString



                Dim dtComb As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/prod/Comb", "cProdANP varchar(20), UFCons varchar(2)")

                Dim strCodigoANPEnt As String = ""
                Dim strUFCombEnt As String = ""
                If dtComb.Rows.Count > 0 Then
                    strCodigoANPEnt = dtComb.Rows.Item(0).Item("cProdANP").ToString
                    strUFCombEnt = dtComb.Rows.Item(0).Item("UFCons").ToString

                    strCodigoANP = dtComb.Rows.Item(0).Item("cProdANP").ToString
                    strUFComb = dtComb.Rows.Item(0).Item("UFCons").ToString
                End If
                'For A = 0 To dtImp.Rows.Count - 1
                '    If strNItem = dtImp.Rows.Item(A).Item("nItem") Then
                '        strOrigem = dtImp.Rows.Item(A).Item("orig").ToString
                '        If dtImp.Rows.Item(A).Item("CST").ToString <> "" Then
                '            strCST = dtImp.Rows.Item(A).Item("CST").ToString
                '        Else
                '            strCST = dtImp.Rows.Item(A).Item("CSOSN").ToString
                '        End If

                '        strModBC = dtImp.Rows.Item(A).Item("modBC").ToString
                '        strICMS = dtImp.Rows.Item(A).Item("pICMS").ToString
                '        strRedBC = dtImp.Rows.Item(A).Item("pRedBC").ToString
                '        strModBCST = dtImp.Rows.Item(A).Item("modBCST").ToString
                '        strRedBCST = dtImp.Rows.Item(A).Item("pRedBCST").ToString
                '        strMVaST = dtImp.Rows.Item(A).Item("pMVAST").ToString
                '        strICMSST = dtImp.Rows.Item(A).Item("pICMSST").ToString
                '        strCalculoCred = dtImp.Rows.Item(A).Item("pCredSN").ToString
                '        Exit For
                '    End If

                'Next
                '    Exit For
                '        End If
                'Next

                Dim dblValor As Double = dtNF.Rows.Item(I).Item("vUnCom").ToString
                Dim dblValorTotal As Double = dtNF.Rows.Item(I).Item("vProd").ToString
                Dim dblValorImposto As Double = dtNF.Rows.Item(I).Item("vUnCom").ToString
                Dim dblQtd As Double = dtNF.Rows.Item(I).Item("qCom").ToString


                Dim dtIPI As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/IPI/IPITrib", "nItem Varchar(5) '../../../@nItem', pIPI Varchar(15)")

                Dim dblResulIPI As Double = 0
                Dim dblResulICMS As Double = 0
                dr = dtIPI.Select(strQuery)
                Dim strIPI As String = "0"
                If dr.Length > 0 Then
                    If dr(0).Item("pIPI").ToString <> "" Then
                        strIPI = dr(0).Item("pIPI").ToString.Replace(".", ",")
                        If ImpostoPorItem = True Then

                            Dim dblPor As Double

                            dblPor = strIPI

                            dblResulIPI = (dblValorImposto * dblPor) / 100
                        End If
                    End If

                    If strICMSST <> "" Then
                        If ImpostoPorItem = True Then
                            'Dim dblPor As Double

                            'dblPor = strICMSST

                            'dblResulICMS = (dblValorImposto * dblPor) / 100
                            If strICMSST <> "" Then
                                Dim vICMS As Double
                                Dim dblMVaST As Double = 0
                                If strMVaST <> "" Then
                                    dblMVaST = strMVaST.Replace(".", ",")
                                Else
                                    Dim dblVTotal As Double = dblValor * dblQtd
                                    Dim dblVTotalBC As Double = dblVTotal + (dblResulIPI * dblQtd)
                                    dblMVaST = valBCST - dblVTotalBC
                                    dblMVaST = (dblMVaST * 100) / dblVTotalBC
                                    strMVaST = dblMVaST.ToString("0.00")
                                End If
                                vICMS = (valBC * strICMS) / 100
                                Dim vBCST As Double

                                vBCST = dblValor + dblResulIPI
                                vBCST = vBCST * dblMVaST
                                vBCST = vBCST / 100
                                vBCST = vBCST + (dblValor + dblResulIPI)



                                dblResulICMS = ((valBCST * strICMSST) / 100) - vICMS
                                dblResulICMS = dblResulICMS / dblQtd




                            End If

                        End If
                    End If
                End If



                dblValor = dblValor + dblResulIPI + dblResulICMS
                'dblValor = (dblValor / dblQtd) + dblValorImposto
                dblValorTotal = dblValor * dblQtd


                Dim strCSTIPIEnt As String = ""
                Dim strCodEnqEnt As String = ""
                Dim strAliquotaIPIEnt As String = ""
                Dim strValIPIEnt As String = ""
                Dim strCSTPISEnt As String = ""
                Dim strAliquotaPISEnt As String = ""
                Dim strValPISEnt As String = ""
                Dim strCSTCOFINSEnt As String = ""
                Dim strAliquotaCOFINSEnt As String = ""
                Dim strValCOFINSEnt As String = ""


                Dim intIndex As Integer = strNItem - 1

                ''''IPI
                Dim dtTributacao As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/IPI/IPITrib", "nItem Varchar(5) '../../../@nItem', cEnq Varchar(5) '../cEnq', " & _
                "CST varchar(3), pIPI Varchar(15), vIPI varchar(10)")

                Dim strQuery2 As String = "nItem ='" & strNItem & "'"
                Dim dr1 As DataRow()
                dr1 = dtTributacao.Select(strQuery2)

                If dr1.Length > 0 Then
                    strCSTIPIEnt = dr1(0).Item("CST").ToString
                    strCodEnqEnt = dr1(0).Item("cEnq").ToString
                    strAliquotaIPIEnt = dr1(0).Item("pIPI").ToString.Replace(".", ",")
                    strValIPIEnt = dr1(0).Item("vIPI").ToString.Replace(".", ",")

                    strCSTIPI = dr1(0).Item("CST").ToString
                    strCodEnq = dr1(0).Item("cEnq").ToString
                    strPerIPI = dr1(0).Item("pIPI").ToString.Replace(".", ",")
                Else

                    dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/IPI/IPINT", "nItem Varchar(5) '../../../@nItem', cEnq Varchar(5) '../cEnq', " & _
                    "CST varchar(3), pIPI Varchar(15), vIPI varchar(10)")
                    dr1 = dtTributacao.Select(strQuery2)

                    If dr1.Length > 0 Then
                        strCSTIPIEnt = dr1(0).Item("CST").ToString
                        strCodEnqEnt = dr1(0).Item("cEnq").ToString
                        strAliquotaIPIEnt = dr1(0).Item("pIPI").ToString.Replace(".", ",")
                        strValIPIEnt = dr1(0).Item("vIPI").ToString.Replace(".", ",")

                        strCSTIPI = dr1(0).Item("CST").ToString
                        strCodEnq = dr1(0).Item("cEnq").ToString
                        strPerIPI = dr1(0).Item("pIPI").ToString.Replace(".", ",")
                    End If
                End If


                ''''PIS


                dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/PIS/PISAliq", "" & _
                "nItem Varchar(5) '../../../@nItem', CST varchar(3), pPIS Varchar(15), vPIS varchar(10)")


                dr1 = dtTributacao.Select(strQuery2)

                If dr1.Length > 0 Then
                    strCSTPISEnt = dr1(0).Item("CST").ToString
                    strAliquotaPISEnt = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                    strValPISEnt = dr1(0).Item("vPIS").ToString.Replace(".", ",")

                    strCSTPIS = dr1(0).Item("CST").ToString
                    strPerPIS = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                Else
                    dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/PIS/PISNT", "" & _
                    "nItem Varchar(5) '../../../@nItem', CST varchar(3), pPIS Varchar(15), vPIS varchar(10)")

                    dr1 = dtTributacao.Select(strQuery2)
                    If dr1.Length > 0 Then
                        strCSTPISEnt = dr1(0).Item("CST").ToString
                        strAliquotaPISEnt = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                        strValPISEnt = dr1(0).Item("vPIS").ToString.Replace(".", ",")

                        strCSTPIS = dr1(0).Item("CST").ToString
                        strPerPIS = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                    Else
                        dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/PIS/PISOutr", "" & _
                        "nItem Varchar(5) '../../../@nItem',CST varchar(3), pPIS varchar(15), vPIS varchar(10)")
                        dr1 = dtTributacao.Select(strQuery2)
                        If dr1.Length > 0 Then
                            strCSTPISEnt = dr1(0).Item("CST").ToString
                            strAliquotaPISEnt = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                            strValPISEnt = dr1(0).Item("vPIS").ToString.Replace(".", ",")

                            strCSTPIS = dr1(0).Item("CST").ToString
                            strPerPIS = dr1(0).Item("pPIS").ToString.Replace(".", ",")
                        End If
                    End If
                End If



                dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/COFINS/COFINSAliq", "" & _
             "nItem Varchar(5) '../../../@nItem', CST varchar(3), pCOFINS Varchar(15), vCOFINS varchar(10)")

                dr1 = dtTributacao.Select(strQuery2)
                If dr1.Length > 0 Then
                    strCSTCOFINSEnt = dr1(0).Item("CST").ToString
                    strAliquotaCOFINSEnt = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                    strValCOFINSEnt = dr1(0).Item("vCOFINS").ToString.Replace(".", ",")

                    strCSTCOFINS = dr1(0).Item("CST").ToString
                    strPerCOFINS = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                Else
                    dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/COFINS/COFINSNT", "" & _
                     "nItem Varchar(5) '../../../@nItem', CST varchar(3), pCOFINS Varchar(15), vCOFINS varchar(10)")

                    dr1 = dtTributacao.Select(strQuery2)
                    If dr1.Length > 0 Then
                        strCSTCOFINSEnt = dr1(0).Item("CST").ToString
                        strAliquotaCOFINSEnt = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                        strValCOFINSEnt = dr1(0).Item("vCOFINS").ToString.Replace(".", ",")

                        strCSTCOFINS = dr1(0).Item("CST").ToString
                        strPerCOFINS = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                    Else
                        dtTributacao = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/det/imposto/COFINS/COFINSOutr", "" & _
                          "nItem Varchar(5) '../../../@nItem', CST varchar(3), pCOFINS varchar(15), vCOFINS varchar(10)")
                        dr1 = dtTributacao.Select(strQuery2)
                        If dr1.Length > 0 Then
                            strCSTCOFINSEnt = dr1(0).Item("CST").ToString
                            strAliquotaCOFINSEnt = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                            strValCOFINSEnt = dr1(0).Item("vCOFINS").ToString.Replace(".", ",")

                            strCSTCOFINS = dr1(0).Item("CST").ToString
                            strPerCOFINS = dr1(0).Item("pCOFINS").ToString.Replace(".", ",")
                        End If
                    End If
                End If





                Dim dtProd As DataTable = Nothing


                If dtNF.Rows.Item(I).Item("cEAN").ToString <> "" And dtNF.Rows.Item(I).Item("cEAN").ToString <> "SEM GTIN" Then

                    dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Inativo FROM Produto where CodigoInterno = '" & dtNF.Rows.Item(I).Item("cEAN").ToString & "' or CodigoBarra = '" & dtNF.Rows.Item(I).Item("cEAN").ToString & "'")

                    If dtProd.Rows.Count = 0 Then

                        Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & dtNF.Rows.Item(I).Item("cEAN").ToString & "' and Produto = '' or CodigoBarra = '" & dtNF.Rows.Item(I).Item("cEAN").ToString & "' and Produto is null")
                        If dtCodBarra.Rows.Count > 0 Then
                            Dim strCodigoDoProduto As String = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                            dtProd = CarregarDataTable("Select Codigo, CodigoInterno, convert(numeric(15," & CasaDecimal & "),Valor) as Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Inativo from Produto where Codigo=" & strCodigoDoProduto)
                        End If

                        If CNPJEmpresa <> "13496905000146" And CNPJEmpresa <> "29245765000173" And CNPJEmpresa <> "18432638000167" And CNPJEmpresa <> "09538209000188" And CNPJEmpresa <> "18432638000248" Then
                            If dtProd.Rows.Count = 0 Then

                                If strNomeFor <> "" Then
                                    'dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and Fabricante = '" & strNomeFor & "'")
                                    dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                    "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                    "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM ((EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo) " & _
                                    "left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                                    "EntradaNF.CodConfig = TotalEntradaNF.CodConfig) left join Fornecedor on " & _
                                    "TotalEntradaNF.CodFor = Fornecedor.Codigo where " & _
                                    "EntradaNF.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and " & _
                                    "Fornecedor.Nome = '" & strNomeFor & "' and Produto.Codigo <> ''")

                                End If

                                ''If NomeEmpresa.ToUpper.Contains("PINK FASHION") = False Then
                                ''    If dtProd.Rows.Count = 0 Then
                                ''        dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Inativo FROM Produto where Nome = '" & dtNF.Rows.Item(I).Item("xProd").ToString & "'")
                                ''    End If
                                ''End If


                                If CompararFornecedor = False Then
                                    If dtProd.Rows.Count = 0 Then
                                        dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                        "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                        "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM Produto where " & _
                                        "Produto.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "'")
                                    End If
                                Else
                                    If dtProd.Rows.Count = 0 Then
                                        dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                        "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                        "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM Produto where " & _
                                        "Produto.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and " & _
                                        "Produto.Fabricante = '" & strNomeFor & "'")
                                    End If
                                End If
                            End If
                        End If



                    End If
                Else
                    If strNomeFor = "" Then
                        ''If NomeEmpresa.ToUpper.Contains("PINK FASHION") = False Then
                        ''    dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Produto.Inativo FROM Produto where Nome = '" & dtNF.Rows.Item(I).Item("xProd").ToString & "'")

                        ''End If
                        dtProd = CarregarDataTable("SELECT Codigo FROM Produto where Nome = 'ERASYSTEMS1234'")
                    Else
                        If CNPJEmpresa = "18377821000107" Then
                            dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                           "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                           "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM Produto where " & _
                           "Produto.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and " & _
                           "Produto.Fabricante = '" & strNomeFor & "'")
                        Else
                            dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                            "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                            "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM ((EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo) " & _
                            "left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                            "EntradaNF.CodConfig = TotalEntradaNF.CodConfig) left join Fornecedor on " & _
                            "TotalEntradaNF.CodFor = Fornecedor.Codigo where " & _
                            "EntradaNF.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and " & _
                            "Fornecedor.Nome = '" & strNomeFor & "'")
                        End If
                        'dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and Fabricante = '" & strNomeFor & "'")

                        'If dtProd.Rows.Count > 0 Then
                        '    If dtProd.Rows.Item(0).Item("Codigo").ToString = "" Then
                        '        dtProd = CarregarDataTable("SELECT Codigo FROM Produto where codigo = 0")
                        '    End If
                        'End If
                        ''If NomeEmpresa.ToUpper.Contains("PINK FASHION") = False Then
                        ''    If dtProd.Rows.Count = 0 Then
                        ''        dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, " & _
                        ''        "CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Produto.Inativo FROM Produto " & _
                        ''        "where Nome = '" & dtNF.Rows.Item(I).Item("xProd").ToString & "'")
                        ''    End If
                        ''End If


                        If CompararFornecedor = False Then
                            If dtProd.Rows.Count = 0 Then
                                dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM Produto where " & _
                                "Produto.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "'")
                            End If
                        Else
                            If dtProd.Rows.Count = 0 Then
                                dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                "Produto.Tipo, Produto.UnidadeMedida, Produto.Inativo FROM Produto where " & _
                                "Produto.CodProdFor = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and " & _
                                "Produto.Fabricante = '" & strNomeFor & "'")
                            End If
                        End If

                    End If

                End If

                If dtProd.Rows.Count = 0 Then
                    Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "' and CodFor = " & intCodFor)
                    If dtCodBarra.Rows.Count > 0 Then
                        Dim strCodigoDoProduto As String = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                        dtProd = CarregarDataTable("Select Codigo, CodigoInterno, convert(numeric(15," & CasaDecimal & "),Valor) as Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo, UnidadeMedida, Inativo from Produto where Codigo=" & strCodigoDoProduto)
                    End If
                End If

                If dtProd Is Nothing Then
                    dtProd = CarregarDataTable("SELECT Codigo FROM Produto where Nome = 'ERASYSTEMS1234'")
                End If
                If CNPJEmpresa = "32235631000186" Then
                    dtProd = CarregarDataTable("SELECT Codigo FROM Produto where Nome = 'ERASYSTEMS1234'")
                End If
                Dim strCodProd As String = ""
                Dim strCodigoBarra As String = ""
                Dim strCodigoInterno As String = ""
                Dim strValor As String = ""
                Dim strPor As String = ""
                Dim strNomeProd As String
                Dim strGrupo As String = ""
                Dim strSetor As String = ""
                Dim strUM As String = ""


                Dim strEXTIPI As String = ""
                Dim strGenero As String = ""


                Dim strTipoProduto As String = ""

                If dtProd.Rows.Count > 0 Then
                    strCodProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                    strCodigoInterno = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                    strCodigoBarra = dtProd.Rows.Item(0).Item("CodigoBarra").ToString
                    If strCodigoBarra = "SEM GTIN" Then
                        strCodigoBarra = ""
                    End If
                    strNomeProd = dtProd.Rows.Item(0).Item("Nome").ToString
                    If dtProd.Rows.Item(0).Item("Valor").ToString <> "" Then
                        strValor = dtProd.Rows.Item(0).Item("Valor").ToString
                    End If
                    If dtProd.Rows.Item(0).Item("Porcentagens").ToString <> "" Then
                        strPor = dtProd.Rows.Item(0).Item("Porcentagens").ToString
                    End If


                    strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
                    strSetor = dtProd.Rows.Item(0).Item("Setor").ToString
                    strTipoProduto = dtProd.Rows.Item(0).Item("Tipo").ToString
                    strUM = dtProd.Rows.Item(0).Item("UnidadeMedida").ToString

                    'Verifica se o produto esta inativo e ativa
                    Dim bolInativo As Boolean = dtProd.Rows.Item(0).Item("Inativo")
                    If bolInativo = True Then
                        AtivarProduto(strCodProd, strNomeProd)
                        MsgBox("Produto " & strNomeProd & " estava inativo e foi reativado!", MsgBoxStyle.Information)
                    End If

                    Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
                                "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
                                "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb FROM Nfe where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & " NFE'")

                    If dtNfe.Rows.Count > 0 Then
                        strEXTIPI = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                        strGenero = dtNfe.Rows.Item(0).Item("Genero").ToString
                        strNCM = dtNfe.Rows.Item(0).Item("NCM").ToString
                        strRegime = dtNfe.Rows.Item(0).Item("Regime").ToString
                        strCST = dtNfe.Rows.Item(0).Item("CST").ToString
                        strOrigem = dtNfe.Rows.Item(0).Item("Origem").ToString
                        strModBC = dtNfe.Rows.Item(0).Item("ModBC").ToString
                        strICMS = dtNfe.Rows.Item(0).Item("ICMS").ToString
                        strRedBC = dtNfe.Rows.Item(0).Item("RedBC").ToString
                        strModBCST = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                        strRedBCST = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                        strMVaST = dtNfe.Rows.Item(0).Item("MVaST").ToString
                        strICMSST = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                        strCalculoCred = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
                        strCFOP = dtNfe.Rows.Item(0).Item("CFOP").ToString
                        strCodigoANP = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                        strUFComb = dtNfe.Rows.Item(0).Item("UFComb").ToString
                    Else
                        strNCM = dtNF.Rows.Item(I).Item("NCM").ToString
                        strCFOP = dtNF.Rows.Item(I).Item("CFOP").ToString
                        strEXTIPI = dtNF.Rows.Item(I).Item("EXTIPI").ToString
                        strGenero = dtNF.Rows.Item(I).Item("genero").ToString
                    End If



                    Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, PerCOFINS FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & "' or  CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & " NFE'")

                    If dtTrib.Rows.Count > 0 Then
                        strCSTIPI = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                        strCSTPIS = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                        strCSTCOFINS = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString

                        strCodEnq = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                        strPerIPI = dtTrib.Rows.Item(0).Item("PerIPI").ToString
                        strPerPIS = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                        strPerCOFINS = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
                    End If
                Else
                    strCodigoBarra = dtNF.Rows.Item(I).Item("cEAN").ToString
                    If strCodigoBarra = "SEM GTIN" Then
                        strCodigoBarra = ""
                    End If
                    strUM = dtNF.Rows.Item(I).Item("uCom").ToString
                    If strUM <> "UN" And strUM <> "JG" And strUM <> "KIT" And strUM <> "KG" And strUM <> "LT" And strUM <> "MT" Then
                        If strUM <> "CX" And strUM <> "GL" And strUM <> "FD" And strUM <> "CJ" And strUM <> "CT" And strUM <> "PCT" And strUM <> "DP" And strUM <> "FR" Then
                            strUM = "UN"
                        End If

                    End If
                    strNomeProd = dtNF.Rows.Item(I).Item("xProd").ToString.ToUpper

                    Dim dblCusto As Double = dtNF.Rows.Item(I).Item("vUnCom").ToString
                End If

                Dim F As Integer
                For F = 0 To .Count - 1
                    If .Item(F).Item("Produto").ToString = strNomeProd.Trim Then
                        MsgBox("Produto " & strNomeProd.Trim & " já adicionado!", MsgBoxStyle.Information)
                        Exit For
                    End If
                Next

                .Add()

                Dim Index As Integer = .Count - 1
                .Item(Index).Item("Codigo") = "Inserir"
                .Item(Index).Item("CodProd") = strCodProd
                .Item(Index).Item("CodProdInterno") = strCodigoInterno
                .Item(Index).Item("Qtd") = dtNF.Rows.Item(I).Item("qCom").ToString
                .Item(Index).Item("Tamanho") = "U"
                .Item(Index).Item("Produto") = strNomeProd.Trim
                .Item(Index).Item("ValorUnitario") = dblValor.ToString("0.00")
                .Item(Index).Item("ValorTotal") = dblValorTotal.ToString("0.00")
                .Item(Index).Item("ICMS") = strICMSST
                .Item(Index).Item("IPI") = strIPI
                .Item(Index).Item("Desconto") = "0"
                .Item(Index).Item("UnitarioImposto") = dblValorImposto.ToString("0.00")
                .Item(Index).Item("CodConfig") = CodConfig

                If ManterPorcProd = False Then

                    If strValor <> "" Then
                        .Item(Index).Item("ValProd") = CampoValor(strValor)
                        Dim dblValVenda As Double = strValor
                        Dim dblLucro As Double = dblValVenda - dblValor
                        Dim dblMargem As Double = (dblLucro * 100) / dblValor
                        Dim str As String = dblMargem
                        If str <> "+Infinito" Then
                            .Item(Index).Item("PorProd") = dblMargem.ToString("0.00")
                        Else
                            .Item(Index).Item("PorProd") = strPor

                        End If
                    Else
                        .Item(Index).Item("ValProd") = ""
                        .Item(Index).Item("PorProd") = strPor
                    End If
                Else
                    .Item(Index).Item("PorProd") = strPor

                    If strPor <> "" Then
                        Dim dblVal As Double = (dblValor * strPor) / 100
                        dblVal = dblValor + dblVal
                        strValor = dblVal.ToString("0.00")
                        .Item(Index).Item("ValProd") = CampoValor(strValor)
                    Else
                        If strValor <> "" Then
                            .Item(Index).Item("ValProd") = CampoValor(strValor)
                        Else
                            .Item(Index).Item("ValProd") = ""
                        End If

                    End If
                End If
                



                .Item(Index).Item("UM") = dtNF.Rows.Item(I).Item("uCom").ToString
                .Item(Index).Item("CodigoBarra") = strCodigoBarra

                .Item(Index).Item("EXTIPI") = strEXTIPI
                .Item(Index).Item("Genero") = strGenero
                .Item(Index).Item("NCM") = strNCM
                .Item(Index).Item("Regime") = strRegime
                .Item(Index).Item("CST") = strCST
                .Item(Index).Item("ModBC") = strModBC
                .Item(Index).Item("Origem") = strOrigem
                .Item(Index).Item("RedBC") = strRedBC
                .Item(Index).Item("IcmsNfe") = strICMS
                .Item(Index).Item("ModBCST") = strModBCST
                .Item(Index).Item("RedBCST") = strRedBCST
                .Item(Index).Item("IcmsST") = strICMSST
                .Item(Index).Item("CalculoCred") = strCalculoCred
                .Item(Index).Item("CFOP") = strCFOP
                .Item(Index).Item("CodigoANP") = strCodigoANP
                .Item(Index).Item("UFComb") = strUFComb
                .Item(Index).Item("CSTIPI") = strCSTIPI
                .Item(Index).Item("CSTPIS") = strCSTPIS
                .Item(Index).Item("CSTCOFINS") = strCSTCOFINS
                .Item(Index).Item("CodEnq") = strCodEnq
                .Item(Index).Item("PerIPI") = strPerIPI
                .Item(Index).Item("PerPIS") = strPerPIS
                .Item(Index).Item("PerCOFINS") = strPerCOFINS


                .Item(Index).Item("Grupo") = strGrupo
                .Item(Index).Item("Setor") = strSetor

                .Item(Index).Item("TipoProduto") = strTipoProduto


                .Item(Index).Item("CodProdFor") = dtNF.Rows.Item(I).Item("cProd").ToString

                .Item(Index).Item("UMProd") = strUM
                .Item(Index).Item("QtdProd") = dtNF.Rows.Item(I).Item("qCom").ToString
                .Item(Index).Item("ValorCusto") = dblValor.ToString("0.00")

                .Item(Index).Item("CSTEnt") = strCSTEnt
                .Item(Index).Item("OrigemEnt") = strOrigemEnt
                .Item(Index).Item("CFOPEnt") = strCFOPEnt
                .Item(Index).Item("NCMEnt") = strNCMEnt
                .Item(Index).Item("ModBCEnt") = strModBCEnt
                .Item(Index).Item("RedBCEnt") = strRedBCEnt
                .Item(Index).Item("AliquotaICMSEnt") = strAliquotaICMSEnt
                .Item(Index).Item("ValICMSEnt") = strValICMSEnt
                .Item(Index).Item("ModBCSTEnt") = strModBCSTEnt
                .Item(Index).Item("RedBCSTEnt") = strRedBCSTEnt
                .Item(Index).Item("MaVSTEnt") = strMVaSTEnt
                .Item(Index).Item("AliquotaICMSSTEnt") = strAliquotaICMSSTEnt
                .Item(Index).Item("ValICMSSTEnt") = strValICMSSTEnt
                .Item(Index).Item("VFCPSTEnt") = strVFCPST
                .Item(Index).Item("CalculoCredEnt") = strCalculoCredEnt
                .Item(Index).Item("ValCredEnt") = strValCredEnt
                .Item(Index).Item("CSTIPIEnt") = strCSTIPIEnt
                .Item(Index).Item("CodEnqEnt") = strCodEnqEnt
                .Item(Index).Item("AliquotaIPIEnt") = strAliquotaIPIEnt
                .Item(Index).Item("ValIPIEnt") = strValIPIEnt
                .Item(Index).Item("CSTPISEnt") = strCSTPISEnt
                .Item(Index).Item("AliquotaPISEnt") = strAliquotaPISEnt
                .Item(Index).Item("ValPISEnt") = strValPISEnt
                .Item(Index).Item("CSTCOFINSEnt") = strCSTCOFINSEnt
                .Item(Index).Item("AliquotaCOFINSEnt") = strAliquotaCOFINSEnt
                .Item(Index).Item("ValCOFINSEnt") = strValCOFINSEnt

                .Item(Index).Item("FreteEnt") = strFreteEnt
                .Item(Index).Item("DespesasEnt") = strDespesasEnt
                .Item(Index).Item("SeguroEnt") = strSeguroEnt


                .Item(Index).Item("CodigoANPEnt") = strCodigoANPEnt
                .Item(Index).Item("UFCombEnt") = strUFCombEnt
            Next
        End With


        'Totais da Nota Fiscal
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/total/ICMSTot", "vST Numeric(15,2), vFrete Numeric(15,2), vSeg Numeric(15,2), vDesc Numeric(15,2), vIPI Numeric(15,2), vOutro Numeric(15,2), vNF Numeric(15,2)")
        frmEntradaNF.txtValNota.Text = dtNF.Rows.Item(0).Item("vNF").ToString
        frmEntradaNF.txtValDesc.Text = dtNF.Rows.Item(0).Item("vDesc").ToString
        frmEntradaNF.txFrete.Text = dtNF.Rows.Item(0).Item("vFrete").ToString
        frmEntradaNF.txtSeguro.Text = dtNF.Rows.Item(0).Item("vSeg").ToString
        frmEntradaNF.txtDespesas.Text = dtNF.Rows.Item(0).Item("vOutro").ToString
        frmEntradaNF.txtIPI.Text = dtNF.Rows.Item(0).Item("vIPI").ToString
        frmEntradaNF.txtICMS.Text = dtNF.Rows.Item(0).Item("vST").ToString

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/cobr/dup", "dVenc SmallDateTime, vDup Numeric(15,2)")
        If dtNF.Rows.Count > 0 Then
            Dim J As Integer
            Dim strParcela As String = ""
            Dim dblValorConta As Double = 0
            For J = 0 To dtNF.Rows.Count - 1
                Dim strValParcela As String = dtNF.Rows.Item(J).Item("vDup").ToString
                Dim strVencimento As String = dtNF.Rows.Item(J).Item("dVenc").ToString.Replace("00:00:00", "").Trim
                If J = 0 Then
                    strParcela = strValParcela & "-" & strVencimento
                Else
                    strParcela &= "|" & strValParcela & "-" & strVencimento
                End If
                Dim dblValPar As Double = 0
                If strValParcela <> "" Then
                    dblValPar = strValParcela
                End If
                dblValorConta += dblValPar
            Next
            frmEntradaNF.strValorContaPagar = dblValorConta.ToString("0.00")
            frmEntradaNF.vetParcela = Split(strParcela, "|")
        End If
        Return True
        'Catch ex As Exception
        '    Return False
        'End Try



    End Function

    Private Shared Sub AtivarProduto(ByVal parCodigo As String, ByVal parProduto As String)
        Atualizar("UPDATE Produto set Inativo = 'False' where Codigo = " & parCodigo)
        If BaixaPorLote = True Then
            Atualizar("Update Qtde Set Acabou = 'True', Qtd =0, EmFalta = '1' where CodProd = " & parCodigo)

        Else

            Atualizar("UPDATE Qtde Set Qtd = 0 Where CodProd = " & parCodigo)

            If EstoqueSomado = True Then

                Dim A As Integer
                For A = 0 To QtdeLoja - 1

                    Dim strLoja As String = A + 1

                    Dim dblResul As Double = AjusteQtde(strLoja, parCodigo)

                    dblResul = dblResul - (dblResul + dblResul)
                    Inserir("INSERT INTO AjusteQtde (CodProd, Qtd, CodConfig, Tabela, Data, CodUser) " & _
                    "VALUES (" & parCodigo & "," & Num(dblResul) & "," & strLoja & ",'ATIVAR PROD. XML'," & _
                    "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ")")

                Next

            End If
        End If
        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'Produto Inativo'," & _
        "'" & parProduto & " - ATIVO','INATIVO','PRODUTO','ALTERAÇÃO'," & CodConfig & ")")

    End Sub

    Public Shared Function NumeroNota(ByVal parArquivo As String) As String
        Dim strNum As String = ""

        Dim strTexto As String = LerArquivo2(parArquivo)
        Dim strTags As String = "/nfeProc"
        If strTexto.Contains("nfeProc") = False Then
            strTags = ""
        End If

        'Numero, serie e data da Nota Fiscal
        Dim dtNF As DataTable = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/ide", "nNF varchar(20), serie Varchar(10), dEmi SmalldateTime")
        strNum = dtNF.Rows.Item(0).Item("nNF").ToString
        Return strNum
    End Function
End Class

