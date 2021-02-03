Imports Nano.clsFuncoes
Imports Nano.clsValidar
Public Class clsGerarArqsNfe
    Public Shared Function ArquivoNfeCliente(ByVal parCPF As String, ByVal parTudo As Boolean) As Boolean
        Dim dtCliente As DataTable = Nothing
        If parTudo = True Then
            dtCliente = CarregarDataTable("SELECT * FROM Cliente order by Codigo")
        Else
            dtCliente = CarregarDataTable("SELECT * FROM Cliente where CPF = '" & parCPF & "'")
        End If

        Try
            Dim I As Integer
            For I = 0 To dtCliente.Rows.Count - 1

                Dim bolCPFok As Boolean = False

                Dim cpf1 As New clsValidar

                cpf1.cpf = dtCliente.Rows.Item(I).Item("CPF").ToString

                If cpf1.isCpfValido() Then
                    bolCPFok = True
                Else
                    Dim Cnpj1 As New clsValidar

                    Cnpj1.cnpj = dtCliente.Rows.Item(I).Item("CPF").ToString
                    If Cnpj1.isCnpjValido() Then
                        bolCPFok = True
                    End If
                End If
                If bolCPFok = True Then
                    If dtCliente.Rows.Item(I).Item("CodPais").ToString <> "" Then
                        If Not IO.File.Exists(PastaCliProdEmissor & "\Cliente" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "") & ".xml") Then
                            IO.File.Create(PastaCliProdEmissor & "\Cliente" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "") & ".xml").Close()
                        End If
                        If IO.File.Exists(PastaCliProdEmissor & "\Cliente" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "") & ".xml") Then

                            Dim fluxoTexto As IO.StreamWriter

                            fluxoTexto = New IO.StreamWriter(PastaCliProdEmissor & "\Cliente" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "") & ".xml")
                            fluxoTexto.WriteLine("<sistema versao= ""1.02"" xmlns= ""http://www.portalfiscal.inf.br/nfe"">")

                            fluxoTexto.WriteLine("<dest>")
                            If dtCliente.Rows.Item(I).Item("CPF").ToString.Contains("/") Then
                                fluxoTexto.WriteLine("<CNPJ>" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("/", "").Replace("-", "") & "</CNPJ>")
                            Else
                                fluxoTexto.WriteLine("<CPF>" & dtCliente.Rows.Item(I).Item("CPF").ToString.Replace(".", "").Replace("-", "") & "</CPF>")
                            End If

                            fluxoTexto.WriteLine("<xNome>" & dtCliente.Rows.Item(I).Item("Nome").ToString.Replace("&", "&amp;") & "</xNome>")
                            fluxoTexto.WriteLine("<enderDest>")
                            If dtCliente.Rows.Item(I).Item("Endereco").ToString <> "" Then
                                fluxoTexto.WriteLine("<xLgr>" & dtCliente.Rows.Item(I).Item("Endereco").ToString & "</xLgr>")
                            End If

                            If dtCliente.Rows.Item(I).Item("Numero").ToString <> "" Then
                                fluxoTexto.WriteLine("<nro>" & dtCliente.Rows.Item(I).Item("Numero").ToString & "</nro>")
                            End If

                            If dtCliente.Rows.Item(I).Item("Complemento").ToString <> "" Then
                                fluxoTexto.WriteLine("<xCpl>" & dtCliente.Rows.Item(I).Item("Complemento").ToString & "</xCpl>")
                            End If

                            If dtCliente.Rows.Item(I).Item("Bairro").ToString <> "" Then
                                fluxoTexto.WriteLine("<xBairro>" & dtCliente.Rows.Item(I).Item("Bairro").ToString & "</xBairro>")

                            End If

                            Dim strUF As String = dtCliente.Rows.Item(I).Item("Estado").ToString
                            Select Case dtCliente.Rows.Item(I).Item("Estado").ToString

                                Case "Acre", "ACRE"
                                    strUF = "AC"

                                Case "Alagoas", "ALAGOAS"
                                    strUF = "AL"

                                Case "Amapá"
                                    strUF = "AP"

                                Case "Amazonas", "AMAZONAS"
                                    strUF = "AM"

                                Case "Bahia", "BAHIA"
                                    strUF = "BA"

                                Case "Ceará", "CEARÁ"
                                    strUF = "CE"

                                Case "Distrito Federal", "DISTRITO FEDERAL"
                                    strUF = "DF"

                                Case "Espírito Santo", "ESPÍRITO SANTO"
                                    strUF = "ES"

                                Case "Goiás", "GOIÁS"
                                    strUF = "GO"

                                Case "Maranhão", "MARANHÃO"
                                    strUF = "MA"

                                Case "Mato Grosso", "MATO GROSSO"
                                    strUF = "MT"

                                Case "Mato Grosso do Sul", "MATO GROSSO DO SUL"
                                    strUF = "MS"

                                Case "Minas Gerais", "MINAS GERAIS"
                                    strUF = "MG"

                                Case "Pará", "PARÁ"
                                    strUF = "PA"

                                Case "Paraíba", "PARAÍBA"
                                    strUF = "PB"

                                Case "Paraná", "PARANÁ"
                                    strUF = "PR"

                                Case "Pernambuco", "PERNAMBUCO"
                                    strUF = "PE"

                                Case "Piauí", "PIAUÍ"
                                    strUF = "PI"

                                Case "Rio de Janeiro", "RIO DE JANEIRO"
                                    strUF = "RJ"

                                Case "Rio Grande do Norte", "RIO GRANDE DO NORTE"
                                    strUF = "RN"

                                Case "Rio Grande do Sul", "RIO GRANDE DO SUL"
                                    strUF = "RS"

                                Case "Rondônia", "RONDÔNIA"
                                    strUF = "RO"

                                Case "Roraima", "RORAIMA"
                                    strUF = "RR"

                                Case "Santa Catarina", "SANTA CATARINA"
                                    strUF = "SC"

                                Case "São Paulo", "SÃO PAULO"
                                    strUF = "SP"

                                Case "Sergipe", "SERGIPE"
                                    strUF = "SE"

                                Case "Tocantins", "TOCANTINS"
                                    strUF = "TO"

                            End Select
                            Dim strCodMun As String = dtCliente.Rows.Item(I).Item("CodMunicipio").ToString
                            If strCodMun = "" Then
                                If dtCliente.Rows.Item(I).Item("Cidade").ToString <> "" Then
                                    Dim dt As DataTable = CarregarDataTable("SELECT CodIBGE FROM Cidade where Nome = '" & dtCliente.Rows.Item(I).Item("Cidade").ToString.Replace("'", "´") & "' and UF = '" & strUF & "'")
                                    If dt.Rows.Count > 0 Then
                                        strCodMun = dt.Rows.Item(0).Item("CodIBGE").ToString
                                        fluxoTexto.WriteLine("<cMun>" & strCodMun & "</cMun>")
                                    End If
                                End If
                            Else
                                fluxoTexto.WriteLine("<cMun>" & strCodMun & "</cMun>")
                            End If


                            If dtCliente.Rows.Item(I).Item("Cidade").ToString <> "" Then
                                Dim strCidade As String = dtCliente.Rows.Item(I).Item("Cidade").ToString
                                strCidade = strCidade.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("â", "a").Replace("Á", "A").Replace("À", "A").Replace("Ã", "A").Replace("Â", "A").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("É", "E").Replace("È", "E").Replace("Ê", "E").Replace("í", "i").Replace("ì", "i").Replace("Í", "I").Replace("Ì", "I").Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("Ó", "O").Replace("Ò", "O").Replace("Õ", "O").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U").Replace("Ç", "C").Replace("ç", "c")

                                fluxoTexto.WriteLine("<xMun>" & strCidade & "</xMun>")
                            End If
                            If strUF <> "" Then
                                fluxoTexto.WriteLine("<UF>" & strUF.Trim & "</UF>")
                            End If

                            If dtCliente.Rows.Item(I).Item("Cep").ToString <> "" Then
                                fluxoTexto.WriteLine("<CEP>" & dtCliente.Rows.Item(I).Item("Cep").ToString.Replace("-", "").Replace(".", "") & "</CEP>")
                            End If
                            fluxoTexto.WriteLine("<cPais>" & dtCliente.Rows.Item(I).Item("CodPais").ToString & "</cPais>")
                            fluxoTexto.WriteLine("<xPais>" & dtCliente.Rows.Item(I).Item("NomePais").ToString & "</xPais>")
                            fluxoTexto.WriteLine("</enderDest>")
                            Dim strIE As String = dtCliente.Rows.Item(I).Item("RGIE").ToString
                            If ChecaInscrE(strUF, strIE) = False Then
                                strIE = ""
                            Else
                                fluxoTexto.WriteLine("<IE>" & strIE.Trim & "</IE>")
                            End If

                            fluxoTexto.WriteLine("</dest>")
                            fluxoTexto.WriteLine("</sistema>")

                            fluxoTexto.Close()
                        End If
                    End If

                End If
            Next
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Function
    Public Shared Function ArquivoNfeProduto(ByVal parCodigo As String, ByVal parTudo As Boolean) As Boolean
        Dim dtProd As DataTable = Nothing

        If parTudo = True Then
            dtProd = CarregarDataTable("SELECT * FROM Produto order by Codigo")
        Else
            dtProd = CarregarDataTable("SELECT * FROM Produto where Codigo = " & parCodigo)
        End If

        Dim I As Integer
        Dim A As Integer
        Try
            For I = 0 To dtProd.Rows.Count - 1
                Dim dtNFe As DataTable = CarregarDataTable("SELECT EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom FROM Nfe where CodProd = " & dtProd.Rows.Item(I).Item("Codigo").ToString)
                If dtNFe.Rows.Count > 0 Then
                    If dtNFe.Rows.Item(0).Item("CST").ToString <> "" Then

                        Dim strNome As String = dtProd.Rows.Item(I).Item("Nome").ToString.Replace("/", "")
                        Dim strC As String = dtProd.Rows.Item(I).Item("Codigo").ToString
                        Dim strCaminho As String = PastaCliProdEmissor & "\" & strNome & "-" & strC & ".xml"

                        Dim strValor As String = dtProd.Rows.Item(I).Item("Valor").ToString
                        Dim strUnidadeMedida As String = dtProd.Rows.Item(I).Item("UnidadeMedida").ToString

                        If Not IO.File.Exists(strCaminho) Then
                            IO.File.Create(strCaminho).Close()
                        End If
                        If IO.File.Exists(strCaminho) Then

                            Dim fluxoTexto As IO.StreamWriter

                            fluxoTexto = New IO.StreamWriter(strCaminho)
                            fluxoTexto.WriteLine("<sistema versao= ""1.02"" xmlns= ""http://www.portalfiscal.inf.br/nfe"">")



                            fluxoTexto.WriteLine("<det>")
                            fluxoTexto.WriteLine("<prod>")

                            fluxoTexto.WriteLine("<cProd>" & dtProd.Rows.Item(I).Item("CodigoInterno").ToString & "</cProd>")


                            If dtProd.Rows.Item(I).Item("CodigoBarra").ToString <> "" Then
                                fluxoTexto.WriteLine("<cEAN>" & dtProd.Rows.Item(I).Item("CodigoBarra").ToString & "</cEAN>")
                            End If
                            Dim strUM As String
                            'If dtNFe.Rows.Item(0).Item("UnidTrib").ToString <> "" Then
                            '    strUM = dtNFe.Rows.Item(0).Item("UnidTrib").ToString
                            'Else
                            strUM = strUnidadeMedida
                            'End If

                            Select Case strUM
                                Case "UNIDADE"
                                    strUM = "UN"
                                Case "JOGO"
                                    strUM = "JG"

                                Case "KIT"
                                    strUM = "KIT"

                                Case "PESO"
                                    strUM = "KG"

                                Case "LÍTRO"
                                    strUM = "LT"

                                Case "METRO"
                                    strUM = "MT"
                                Case "HORA"
                                    strUM = "HR"
                            End Select
                            'Dim strUniCom As String
                            'If dtNFe.Rows.Item(0).Item("UnidCom").ToString <> "" Then
                            '    strUniCom = dtNFe.Rows.Item(0).Item("UnidCom").ToString
                            'Else
                            '    strUniCom = strUnidadeMedida
                            'End If

                            'Select Case strUniCom
                            '    Case "UNIDADE"
                            '        strUniCom = "UN"
                            '    Case "JOGO"
                            '        strUniCom = "JG"

                            '    Case "KIT"
                            '        strUniCom = "KIT"

                            '    Case "PESO"
                            '        strUniCom = "KG"

                            '    Case "LÍTRO"
                            '        strUniCom = "LT"

                            '    Case "METRO"
                            '        strUniCom = "MT"
                            '    Case "HORA"
                            '        strUniCom = "HR"
                            'End Select

                            Dim dblQtdTrib, dblUnCom, dblUnTrib As Double

                            fluxoTexto.WriteLine("<xProd>" & dtProd.Rows.Item(I).Item("Nome").ToString & "</xProd>")

                            If dtNFe.Rows.Item(0).Item("NCM").ToString <> "" Then
                                fluxoTexto.WriteLine("<NCM>" & dtNFe.Rows.Item(0).Item("NCM").ToString & "</NCM>")
                            End If

                            If dtNFe.Rows.Item(0).Item("EXTIPI").ToString <> "" Then
                                fluxoTexto.WriteLine("<EXTIPI>" & dtNFe.Rows.Item(0).Item("EXTIPI").ToString & "</EXTIPI>")
                            End If

                            If dtNFe.Rows.Item(0).Item("Genero").ToString <> "" Then
                                fluxoTexto.WriteLine("<genero>" & dtNFe.Rows.Item(0).Item("Genero").ToString & "</genero>")
                            End If


                            If strUM <> "" Then
                                fluxoTexto.WriteLine("<uCom>" & strUM & "</uCom>")
                            End If

                            If strUM <> "" Then
                                fluxoTexto.WriteLine("<uTrib>" & strUM & "</uTrib>")
                            End If



                            'If dtNFe.Rows.Item(0).Item("QtdTrib").ToString <> "" Then
                            dblQtdTrib = 1
                            fluxoTexto.WriteLine("<qTrib>" & dblQtdTrib.ToString("0.0000").Replace(",", ".") & "</qTrib>")

                            'End If
                            If strValor <> "" Then
                                dblUnCom = strValor
                                fluxoTexto.WriteLine("<vUnCom>" & dblUnCom.ToString("0.0000").Replace(",", ".") & "</vUnCom>")
                                'Else
                                '    dblUnCom = strValor
                                '    fluxoTexto.WriteLine("<vUnCom>" & dblUnCom.ToString("0.0000").Replace(",", ".") & "</vUnCom>")
                            End If

                            If strValor <> "" Then
                                dblUnTrib = strValor
                                fluxoTexto.WriteLine("<vUnTrib>" & dblUnTrib.ToString("0.0000").Replace(",", ".") & "</vUnTrib>")
                                'Else
                                '    dblUnTrib = strValor
                                '    fluxoTexto.WriteLine("<vUnTrib>" & dblUnTrib.ToString("0.0000").Replace(",", ".") & "</vUnTrib>")
                            End If


                            fluxoTexto.WriteLine("</prod>")


                            fluxoTexto.WriteLine("<imposto>")

                            A = 0
                            'For A = 0 To dtNFe.Rows.Count - 1
                            fluxoTexto.WriteLine("<ICMS>")
                            If dtNFe.Rows.Item(A).Item("Origem").ToString <> "" Then

                                fluxoTexto.WriteLine("<orig>" & dtNFe.Rows.Item(A).Item("Origem").ToString & "</orig>")

                            End If
                            fluxoTexto.WriteLine("<CST>" & dtNFe.Rows.Item(A).Item("CST").ToString & "</CST>")

                            If dtNFe.Rows.Item(A).Item("modBC").ToString <> "" Then
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "00", "10", "20", "70", "90", "900"
                                        fluxoTexto.WriteLine("<modBC>" & dtNFe.Rows.Item(A).Item("modBC").ToString & "</modBC>")
                                End Select
                            End If

                            Dim dblICMS, dblICMSST, dblRedBC, dblMaVast As Double
                            If dtNFe.Rows.Item(A).Item("RedBC").ToString <> "" Then
                                dblRedBC = dtNFe.Rows.Item(A).Item("RedBC").ToString()
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "20", "70", "90", "900"
                                        fluxoTexto.WriteLine("<pRedBC>" & dblRedBC.ToString("0.00").Replace(",", ".") & "</pRedBC>")
                                End Select
                            End If


                            If dtNFe.Rows.Item(A).Item("ICMS").ToString <> "" Then
                                dblICMS = dtNFe.Rows.Item(A).Item("ICMS").ToString()
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "00", "10", "20", "70", "90", "900"
                                        fluxoTexto.WriteLine("<pICMS>" & dblICMS.ToString("0.00").Replace(",", ".") & "</pICMS>")
                                End Select
                            End If

                            If dtNFe.Rows.Item(A).Item("ICMSST").ToString <> "" Then
                                dblICMS = dtNFe.Rows.Item(A).Item("ICMSST").ToString()
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "10", "30", "70", "90", "201", "202", "203", "900"
                                        fluxoTexto.WriteLine("<pICMSST>" & dblICMS.ToString("0.00").Replace(",", ".") & "</pICMSST>")
                                End Select
                            End If

                            If dtNFe.Rows.Item(A).Item("modBCST").ToString <> "" Then
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "10", "30", "70", "90", "201", "202", "203", "900"
                                        fluxoTexto.WriteLine("<modBCST>" & dtNFe.Rows.Item(A).Item("modBCST").ToString & "</modBCST>")
                                End Select
                            End If

                            If dtNFe.Rows.Item(A).Item("MVaST").ToString <> "" Then
                                dblMaVast = dtNFe.Rows.Item(A).Item("MVaST").ToString()
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "10", "30", "70", "90", "201", "202", "203", "900"
                                        fluxoTexto.WriteLine("<pMVAST>" & dblMaVast.ToString("0.00").Replace(",", ".") & "</pMVAST>")
                                End Select
                            End If

                            If dtNFe.Rows.Item(A).Item("RedBCST").ToString <> "" Then
                                dblICMSST = dtNFe.Rows.Item(A).Item("RedBCST").ToString()
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "10", "30", "70", "90", "201", "202", "203", "900"
                                        fluxoTexto.WriteLine("<pRedBCST>" & dblICMSST.ToString("0.00").Replace(",", ".") & "</pRedBCST>")
                                End Select
                            End If
                            If dtNFe.Rows.Item(A).Item("CalculoCred").ToString <> "" Then
                                Dim dblCalcCred As Double = dtNFe.Rows.Item(A).Item("CalculoCred").ToString
                                Select Case dtNFe.Rows.Item(A).Item("CST").ToString
                                    Case "101", "201", "900"
                                        fluxoTexto.WriteLine("<pCredSN>" & dblCalcCred.ToString("0.00").Replace(",", ".") & "</pCredSN>")
                                End Select
                            End If
                            fluxoTexto.WriteLine("</ICMS>")
                            'Next


                            fluxoTexto.WriteLine("</imposto>")

                            fluxoTexto.WriteLine("</det>")
                            fluxoTexto.WriteLine("</sistema>")

                            fluxoTexto.Close()

                        End If

                    End If


                End If
            Next
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
End Class
