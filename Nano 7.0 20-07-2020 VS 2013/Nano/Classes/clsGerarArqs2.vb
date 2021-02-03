Imports Nano.clsFuncoes
Public Class clsGerarArqs2

    Public Shared Function ArqUsuario(ByVal parTipoArquivo As String, ByVal parEcluido As Boolean, Optional ByVal parCodUser As String = "") As Integer

        RMREG2 = ""
        RMREG3 = ""

        Dim dt As DataTable = Nothing

        Dim intNumRegs As Integer = 0

        Select Case parTipoArquivo
            Case "TUDO"
                dt = CarregarDataTable("Select Login, Senha, Nivel, Codigo, Nome from Usuario")

            Case "UNICO"
                dt = CarregarDataTable("Select Login, Senha, Nivel, Codigo, Nome from Usuario WHERE Codigo =" & parCodUser)

        End Select

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            With dt.Rows

                Dim strLogi, strSen, strNiv, strCod, strNome, strAtivo As String
                strLogi = Dir(.Item(I).Item(0).ToString, 15)
                strLogi = Mid(strLogi, 1, 15)

                strSen = Dir(.Item(I).Item(1).ToString, 60)
                strSen = Mid(strSen, 1, 60)


                strNiv = .Item(I).Item(2).ToString.Trim
                strCod = Dir(.Item(I).Item(3).ToString, 10)
                strNome = .Item(I).Item(4).ToString

                If strNiv = "MASTER" Then
                    strNiv = "ADMINISTRADOR"
                End If

                Select Case strNiv
                    Case "ADMINISTRADOR"
                        strNiv = 2
                    Case "USUÁRIO"
                        strNiv = 1
                End Select

                If parEcluido = True Then
                    strAtivo = "I"
                Else
                    strAtivo = "A"
                End If


                RMREG2 &= "002" & strLogi & strSen & strAtivo & strNiv & "A" & vbCrLf

                RMREG3 &= "003" & strCod & Dir(strNome, 30) & strAtivo & vbCrLf

                intNumRegs += 2
            End With
        Next

        If parTipoArquivo = "UNICO" Then
            EscreveArquivosCupom("USUARIO", intNumRegs)
        Else
            Return intNumRegs
        End If

    End Function

    Public Shared Function ArqCliente(ByVal parTipoArquivo As String, ByVal parEcluido As Boolean, Optional ByVal parCodCli As Integer = 0) As Integer
        'CARREGA O REGISTRO DE CLIENTE PARA O CUPOM FISCAL

        RMREG4 = ""
        Dim dt As DataTable = Nothing
        Dim intNumRegs As Integer = 0

        Select Case parTipoArquivo
            Case "UNICO"
                dt = CarregarDataTable("Select CPF, Nome, Endereco, Numero, Complemento, Cidade, Bairro, Estado, Telefone, Email, Codigo from Cliente WHERE Codigo =" & parCodCli)

            Case "TUDO"
                dt = CarregarDataTable("Select CPF, Nome, Endereco, Numero, Complemento, Cidade, Bairro, Estado, Telefone, Email, Codigo from Cliente")

        End Select

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            Dim strCodCli, strCPF, strNome, strEnd, strCid, strBai, strUF, strTel, strMail As String

            With dt.Rows

                strCodCli = .Item(I).Item("Codigo").ToString
                strCodCli = Esq(strCodCli, 15).Replace(" ", "0")

                strCPF = .Item(I).Item(0).ToString


                Dim cpf1 As New clsValidar
                Dim bolValido As Boolean = False

                cpf1.cpf = strCPF
                If cpf1.isCpfValido() Then
                    bolValido = True
                Else
                    Dim Cnpj1 As New clsValidar
                    Cnpj1.cnpj = strCPF
                    If Cnpj1.isCnpjValido() Then
                        bolValido = True
                    Else

                    End If
                End If

                If bolValido = True Then
                    strCPF = strCPF.Replace(".", "").Replace("/", "").Replace("-", "")
                Else
                    strCPF = ""
                End If


                Dim strCpfOK As String = Dir(strCPF, 14)

                strNome = Dir(.Item(I).Item("Nome").ToString, 60)
                strNome = Mid(strNome, 1, 60)

                strEnd = Dir(.Item(I).Item("Endereco").ToString, 60)
                strEnd = Mid(strEnd, 1, 60)

                strCid = Dir(.Item(I).Item("Cidade").ToString, 30)
                strCid = Mid(strCid, 1, 30)

                strBai = Dir(.Item(I).Item("Bairro").ToString, 60)
                strBai = Mid(strBai, 1, 60)

                strUF = Dir(.Item(I).Item("Estado").ToString, 2)
                strUF = Mid(strUF, 1, 2)

                strTel = Dir(.Item(I).Item("Telefone").ToString.Replace("|", "").Replace("Res", "").Replace("Com", "").Replace("Cel", "").Replace("Fax", "").Replace("Cont", "").Replace("Rec", "").Replace("RES", "").Replace("COM", "").Replace("CEL", "").Replace("FAX", "").Replace("CONT", "").Replace("REC", "").Replace("SAC", "").Replace("ID", ""), 15)
                strTel = Mid(strTel, 1, 15)

                strMail = .Item(I).Item("Email").ToString.Replace("|", "").Replace("E-Mail", "").Replace("MSN", "").Replace("Skype", "").Replace("Site", "").Replace("EMAIL", "").Replace("SKYPE", "").Replace("SITE", "")
                strMail = Dir(strMail, 60)
                strMail = Mid(strMail, 1, 60)

                Dim strStatus As String = ""

                If parEcluido = True Then
                    strStatus = "I"
                Else
                    strStatus = "A"
                End If

                Dim strComplementar1, strComplementar2, strComplementar3, strComplementar4 As String

                strComplementar1 = ""
                strComplementar2 = ""
                strComplementar3 = ""
                strComplementar4 = ""

                strComplementar1 = Esq(strComplementar1, 20)
                strComplementar2 = Esq(strComplementar2, 20)
                strComplementar3 = Esq(strComplementar3, 40)
                strComplementar4 = Esq(strComplementar4, 40)

                Dim strRG, strCEP, strNumEnd, strCodIBGE, strComple, strSuframa, strEmailNFE, strLimite As String

                strRG = ""
                strRG = Dir(strRG, 14)

                strCEP = ""
                strCEP = Dir(strCEP, 8)

                strNumEnd = Dir(.Item(I).Item("Numero").ToString, 10)
                strNumEnd = Mid(strNumEnd, 1, 10)

                strCodIBGE = ""
                strCodIBGE = Dir(strCodIBGE, 7)

                strComple = Dir(.Item(I).Item("Complemento").ToString, 60)
                strComple = Mid(strComple, 1, 60)

                strSuframa = ""
                strSuframa = Dir(strSuframa, 9)

                strEmailNFE = ""
                strEmailNFE = Dir(strEmailNFE, 300)

                strLimite = "0000000000000"



                RMREG4 &= "004" & strCodCli & strCpfOK & strNome & strEnd & strCid & strBai & strUF & strTel & strMail & strStatus & Dir("", 25) & strComplementar1 & strComplementar2 & strComplementar3 & strComplementar4 & strRG & strCEP & strNumEnd & strCodIBGE & strComple & strSuframa & strEmailNFE & strLimite & vbCrLf
                intNumRegs += 1


            End With

        Next

        If parTipoArquivo = "UNICO" Then
            EscreveArquivosCupom("CLIENTE", intNumRegs)
        Else
            Return intNumRegs
        End If
    End Function


    Public Shared Function ArqProduto(ByVal parTipoArquivo As String, ByVal parEcluido As Boolean, Optional ByVal parCodProd As Integer = 0) As Integer

        RMREG5 = ""
        RMREG6 = ""

        Dim dt As DataTable = Nothing

        Dim intNumRegs As Integer = 0

        Select Case parTipoArquivo
            Case "TUDO"
                dt = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Grupo, Produto.Fabricante, Produto.CodigoInterno, Produto.ValorCusto, ImpostoProduto.ICMS, ImpostoProduto.Tributacao, ImpostoProduto.Cst, ImpostoProduto.OrigemICMS, ImpostoProduto.IPPT, ImpostoProduto.Pesavel, ImpostoProduto.TipoFIA, Produto.Valor, Produto.NivelComboCodCF, Produto.CodigoBarra From Produto Inner Join ImpostoProduto on Produto.Codigo = ImpostoProduto.CodProd")
            Case "UNICO"
                dt = CarregarDataTable("Select Produto.Codigo, Produto.Nome, Produto.UnidadeMedida, Produto.Grupo, Produto.Fabricante, Produto.CodigoInterno, Produto.ValorCusto, ImpostoProduto.ICMS, ImpostoProduto.Tributacao, ImpostoProduto.Cst, ImpostoProduto.OrigemICMS, ImpostoProduto.IPPT, ImpostoProduto.Pesavel, ImpostoProduto.TipoFIA, Produto.Valor, Produto.NivelComboCodCF, Produto.CodigoBarra From Produto Inner Join ImpostoProduto on Produto.Codigo = ImpostoProduto.CodProd where Produto.Codigo =" & parCodProd)

        End Select

        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            Dim strNome, strUM, strComp2, strComp3, strServ, strCodInterno, strCusto, strICMS, strTrib, strCST, strOriIcms, strIPPT, strPesa, strTipoFIA, strAtivo, strPreco, strNivelCombo, strCodBarra, strCodCF, strISSQN, strKIT As String
            Dim intCodProdu As Integer
            Dim dblCust, dblPreco As Double


            If dt.Rows.Count > 0 Then


                If dt.Rows.Item(I).Item("Cst").ToString <> "" Then


                    intCodProdu = dt.Rows.Item(I).ItemArray(0).ToString
                    strCodInterno = Dir(dt.Rows.Item(I).Item("CodigoInterno").ToString, 30)

                    strCodBarra = dt.Rows.Item(I).Item("CodigoBarra").ToString

                    strCodCF = ""

                    strNivelCombo = dt.Rows.Item(I).Item("NivelComboCodCF").ToString

                    Select Case strNivelCombo
                        Case "0", ""
                            strCodCF = intCodProdu
                        Case "1"
                            strCodCF = strCodInterno.Trim

                        Case "2"
                            strCodCF = strCodBarra.Trim
                        Case Else
                            strCodCF = intCodProdu
                    End Select

                    strCodCF = Dir(strCodCF, 14)
                    strCodCF = Mid(strCodCF, 1, 14)

                    If parEcluido = False Then
                        strAtivo = "A"
                    Else
                        strAtivo = "I"
                    End If


                    strNome = Dir(dt.Rows.Item(I).ItemArray(1).ToString, 40)
                    strNome = Mid(strNome, 1, 40)

                    strUM = dt.Rows.Item(I).Item("UnidadeMedida").ToString

                    strCodInterno = Mid(strCodInterno, 1, 30)

                    strComp2 = Dir(dt.Rows.Item(I).Item("Grupo").ToString, 30)
                    strComp2 = Mid(strComp2, 1, 30)

                    strComp3 = Dir(dt.Rows.Item(I).Item("Fabricante").ToString, 30)
                    strComp3 = Mid(strComp3, 1, 30)

                    If parEcluido = False Then
                        strAtivo = "A"
                    Else
                        strAtivo = "I"
                    End If

                    strCST = dt.Rows.Item(I).Item("Cst").ToString

                    strTrib = dt.Rows.Item(I).Item("Tributacao").ToString

                    Dim dblICMS As Double

                    dblICMS = dt.Rows.Item(I).Item("ICMS").ToString
                    strICMS = Esq(dblICMS.ToString("0.00").Replace(",", ""), 4)
                    strICMS = strICMS.Replace(" ", "0")

                    strIPPT = dt.Rows.Item(I).Item("IPPT").ToString

                    dblCust = dblPreco / 2
                    strCusto = Esq(dblCust.ToString("0.000"), 14)
                    strCusto = strCusto.Replace(",", "").Replace(" ", "0")

                    strPesa = dt.Rows.Item(I).Item("Pesavel").ToString

                    strTipoFIA = dt.Rows.Item(I).Item("TipoFIA").ToString

                    strServ = " "

                    strOriIcms = dt.Rows.Item(I).Item("OrigemICMS").ToString


                    strISSQN = " "

                    strKIT = "N"

                    dblPreco = dt.Rows.Item(I).Item("Valor").ToString
                    strPreco = Esq(dblPreco.ToString("0.00"), 14)
                    strPreco = strPreco.Replace(",", "").Replace(" ", "0")

                    RMREG5 &= "005" & Dir(strCodCF, 20) & strNome & Dir(strUM, 3) & strCodInterno & strComp2 & strComp3 & strAtivo & strCST & strTrib & strICMS & strIPPT & strCusto & strPesa & strTipoFIA & strServ & strOriIcms & strISSQN & strKIT & vbCrLf

                    RMREG6 &= "006" & Dir(strCodCF, 20) & Dir("A VISTA", 10) & strPreco & vbCrLf

                    intNumRegs += 2
                End If
            End If

        Next

        If parTipoArquivo = "UNICO" Then
            EscreveArquivosCupom("PRODUTO", intNumRegs)
        Else
            Return intNumRegs
        End If

    End Function


    Public Shared Function ArqVenda(ByVal parCodOrdem As Integer, ByVal parEcluido As Boolean, ByVal parDesconto As Double) As Boolean

        RMREG8 = ""
        RMREG7 = ""
        RMREG34 = ""

        Dim dt As DataTable = CarregarDataTable("Select CodCli, Total from Total where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

        Dim intNumRegs As Integer = 0

        Dim strCodCli, strTotal, strCpfOK As String
        Dim dblTotal As Double



        If dt.Rows.Count > 0 Then
            strCodCli = Esq(dt.Rows.Item(0).Item("CodCli").ToString, 15)

            'If parDesconto <> 0 Then
            '    Dim dtTot As DataTable = CarregarDataTable("Select sum(ValorTotal) as ValTotPed from Pedido where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)
            '    If dtTot.Rows.Count > 0 Then
            '        dblTotal = dtTot.Rows.Item(0).Item("ValTotPed").ToString
            '    End If

            'Else
            dblTotal = dt.Rows.Item(0).Item(1).ToString
            'End If

            strTotal = Esq(dblTotal.ToString("0.00"), 14)
            strTotal = strTotal.Replace(",", "").Replace(" ", "0")


            Dim dtCli As DataTable = CarregarDataTable("Select Nome, Endereco, Bairro, Cidade, Estado, Telefone, CPF From Cliente Where Codigo =" & strCodCli)

            Dim strNome, strEnd, strBairro, strCidade, strUF, strTelefone, strCPF As String


            If dtCli.Rows.Count > 0 Then

                strCPF = dtCli.Rows.Item(0).Item("CPF").ToString


                Dim bolCPFok As Boolean = False

                Dim cpf1 As New clsValidar

                cpf1.cpf = strCPF

                If cpf1.isCpfValido() Then
                    bolCPFok = True

                Else
                    Dim Cnpj1 As New clsValidar

                    Cnpj1.cnpj = strCPF
                    If Cnpj1.isCnpjValido() Then
                        bolCPFok = True
                    Else
                        bolCPFok = False
                    End If
                End If


                If bolCPFok = False Then
                    dtCli = CarregarDataTable("Select Codigo, Nome, Endereco, Bairro, Cidade, Estado, Telefone, CPF From Cliente Where Nome ='CONSUMIDOR'")
                    If dtCli.Rows.Count > 0 Then
                        strCodCli = Esq(dtCli.Rows.Item(0).Item("Codigo").ToString, 15)
                        strCPF = dtCli.Rows.Item(0).Item("CPF").ToString
                    Else
                        MsgBox("É necessário cadastrar o cliente Consumidor com um CPF válido!", MsgBoxStyle.Information)
                        Exit Function
                    End If

                End If

                strCodCli = strCodCli.Replace(" ", "0")

                strCPF = strCPF.Replace(".", "").Replace("-", "").Replace("/", "")

                strCpfOK = Dir(strCPF, 14)

                strNome = Dir(dtCli.Rows.Item(0).Item("Nome").ToString, 30)
                strNome = Mid(strNome, 1, 30)

                strEnd = Dir(dtCli.Rows.Item(0).Item("Endereco").ToString, 30)
                strEnd = Mid(strEnd, 1, 30)

                strBairro = Dir(dtCli.Rows.Item(0).Item("Bairro").ToString, 20)
                strBairro = Mid(strBairro, 1, 20)

                strCidade = Dir(dtCli.Rows.Item(0).Item("Cidade").ToString, 30)
                strCidade = Mid(strCidade, 1, 30)

                strUF = Dir(dtCli.Rows.Item(0).Item("Estado").ToString, 2)
                strUF = Mid(strUF, 1, 2)

                strTelefone = Dir(dtCli.Rows.Item(0).Item("Telefone").ToString.Replace("|", "").Replace("RES", "").Replace("Com", "").Replace("Cel", "").Replace("Fax", "").Replace("Cont", "").Replace("Rec", "").Replace("SAC", "").Replace("ID", ""), 15)
                strTelefone = Mid(strTelefone, 1, 15)



            Else
                MsgBox("É necessário cadastrar o cliente Consumidor com um CPF válido!!", MsgBoxStyle.Information)
                Exit Function
            End If

            Dim strFab, strMod, strAno As String

            strFab = Dir("", 20)
            strMod = Dir("", 20)

            strAno = Dir("", 4)

            Dim strComplementar1, strComplementar2, strComplementar3, strComplementar4, strDesconto, strAcrescimo As String

            strComplementar1 = ""
            strComplementar2 = ""
            strComplementar3 = ""
            strComplementar4 = ""
            strDesconto = ""
            strAcrescimo = ""

            strComplementar1 = Esq(strComplementar1, 20)
            strComplementar2 = Esq(strComplementar2, 20)
            strComplementar3 = Esq(strComplementar3, 40)
            strComplementar4 = Esq(strComplementar4, 40)
            strDesconto = Esq(strDesconto, 13)
            strAcrescimo = Esq(strAcrescimo, 13)
            strDesconto = strDesconto.Replace(" ", "0")
            strAcrescimo = strAcrescimo.Replace(" ", "0")



            RMREG7 = "007" & Dir(parCodOrdem, 15) & Dir("Orçamento", 15) & strTotal & Dir(strCodCli, 15) & strCpfOK & strNome & strEnd & strBairro & strCidade & strUF & strTelefone & Dir("A VISTA", 10) & " " & "             " & " " & Dir(CodUser, 10) & Dir("", 40) & Dir("", 40) & Dir("", 40) & Dir("", 40) & Dir("", 40) & "             " & " " & Dir(parCodOrdem, 20) & strFab & strMod & strAno & Dir("", 10) & Dir("", 10) & strComplementar1 & strComplementar2 & strComplementar3 & strComplementar4 & strDesconto & strAcrescimo & vbCrLf

            intNumRegs += 1
        End If

        dt = CarregarDataTable("Select CodProd, Qtd, ValorUnitario from Pedido where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig & " order by Qtd Desc")

        Dim strCodPro, strQtd, strUni As String
        Dim dblQtd, dblUnit, dblTot, dblDif As Double
        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            strCodPro = dt.Rows.Item(I).ItemArray(0).ToString

            Dim dtProd As DataTable = CarregarDataTable("Select Codigo, CodigoInterno, CodigoBarra, NivelComboCodCF from Produto where Codigo =" & strCodPro)

            If dtProd.Rows.Count > 0 Then
                Dim strNivelCombo As String

                strNivelCombo = dtProd.Rows.Item(0).Item(3).ToString.Trim
                Select Case strNivelCombo
                    Case "0", ""
                        strCodPro = dtProd.Rows.Item(0).Item(0).ToString
                    Case "1"
                        strCodPro = dtProd.Rows.Item(0).Item(1).ToString
                    Case "2"
                        strCodPro = dtProd.Rows.Item(0).Item(2).ToString
                End Select
            End If

            dblQtd = dt.Rows.Item(I).ItemArray(1).ToString.Replace(":", ",")
            dblUnit = dt.Rows.Item(I).ItemArray(2).ToString

            If parDesconto <> 0 Then
                Dim dblResulta As Double
                dblResulta = ((dblUnit / 100) * parDesconto).ToString("0.00")
                dblUnit = dblUnit - dblResulta

            End If

            dblTot += dblQtd * dblUnit

            If dt.Rows.Count - 1 = I Then
                If dblTotal <> dblTot Then
                    dblDif = (dblTotal - dblTot).ToString("0.00")
                    dblDif = dblDif / dblQtd
                    dblUnit = (dblUnit + dblDif).ToString("0.00")
                    dblTot += dblDif
                End If
            End If

            strQtd = Esq(dblQtd.ToString("0.000"), 14).Replace(",", "").Replace(" ", "0")
            strUni = Esq(dblUnit.ToString("0.00"), 14)
            strUni = strUni.Replace(",", "").Replace(" ", "0")

            RMREG8 &= "008" & Dir(parCodOrdem, 15) & Esq(I + 1, 4).Replace(" ", "0") & Dir(strCodPro, 20) & strQtd & strUni & Dir("", 20) & vbCrLf
            intNumRegs += 1
        Next

        'dt = CarregarDataTable("Select sum(Valor) as Valor from Recebimento where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)

        'Dim bolFormaPagamento As Boolean = True

        'If dt.Rows.Count > 0 Then
        '    Dim dblVal As Double
        '    If dt.Rows.Item(0).Item("Valor").ToString <> Nothing Then
        '        dblVal = dt.Rows.Item(0).Item("Valor").ToString
        '    End If

        '    dblTot = dblTot.ToString("0.00")

        '    If dblTot > dblVal Then
        '        bolFormaPagamento = False
        '        Dim dblDifer As Double = dblTot - dblVal

        '        MsgBox("Informe a forma de pagamento manualmente no cupom fiscal!" & vbCrLf & "NÃO ESQUECER DE DAR DESCONTO NO VALOR DE R$ " & dblDifer.ToString("0.00"), MsgBoxStyle.Information)
        '    End If
        'End If

        'If bolFormaPagamento = True Then

        dt = CarregarDataTable("Select Pagamento, Valor, Data from Recebimento where CodOrdem =" & parCodOrdem & " and CodConfig =" & CodConfig)


        Dim dblCredCli As Double = 0

        For I = 0 To dt.Rows.Count - 1

            Dim strPag As String = dt.Rows.Item(I).Item("Pagamento").ToString

            If strPag = "CRÉDITO CLIENTE" Then
                dblCredCli = dt.Rows.Item(I).Item("Valor").ToString
            End If

        Next

        For I = 0 To dt.Rows.Count - 1

            Dim strPag As String = dt.Rows.Item(I).Item("Pagamento").ToString

            If dt.Rows.Count = 1 Then
                If strPag = "CRÉDITO CLIENTE" Then
                    strPag = "DINHEIRO"
                End If
            End If

            If strPag <> "CRÉDITO CLIENTE" Then

                Dim dtPag As DataTable = CarregarDataTable("Select Codigo from Pagamento where Descricao ='" & strPag & "'")

                Dim strNumPar, strCodPag, strValor, strData As String
                Dim dblVal, dblTotPag, dblDife As Double

                strNumPar = "000" & I + 1

                strCodPag = dtPag.Rows(0).Item("Codigo").ToString

                If strCodPag.Length = 1 Then
                    strCodPag = "0" & strCodPag
                End If

                dblVal = CDbl(dt.Rows.Item(I).Item("Valor").ToString) + dblCredCli

                dblCredCli = 0

                strValor = dblVal.ToString("0.00")

                dblTotPag += strValor

                If dt.Rows.Count - 1 = I Then
                    If dblTotal <> dblTotPag Then
                        dblDife = (dblTotal - dblTotPag).ToString("0.00")
                        strValor = (CDbl(strValor) + dblDife).ToString("0.00")
                    End If
                End If

                strValor = strValor.Replace(",", "")

                strValor = Esq(strValor, 13)
                strValor = strValor.Replace(" ", "0")

                strData = dt.Rows.Item(I).Item("Data").ToString

                Dim vetData As Array = Split(strData, " ")

                strData = vetData(0).ToString

                strData = strData.Replace("/", "")

                RMREG34 &= "034" & Dir(parCodOrdem, 15) & strNumPar & strCodPag & strValor & strData & vbCrLf
                intNumRegs += 1
            End If
        Next
        'End If

        EscreveArquivosCupom("VENDA", intNumRegs)

    End Function


    Public Shared Function ArqPagamento(ByVal parTipoArquivo As String, ByVal parEcluido As Boolean, Optional ByVal parCodPagamento As String = "") As Integer

        RMREG9 = ""

        Dim dt As DataTable = Nothing
        Dim intNumRegs As Integer = 0

        Select Case parTipoArquivo
            Case "UNICO"
                dt = CarregarDataTable("Select Codigo, Descricao, Dias, Desconto, Prazo, FormaPagamento from Pagamento WHERE Codigo =" & parCodPagamento)

            Case "TUDO"
                dt = CarregarDataTable("Select Codigo, Descricao, Dias, Desconto, Prazo, FormaPagamento from Pagamento")

        End Select

        Dim strCod, strDesc, strDescECF, strPrazo, strForPag, strTipoPag, strTEF, strAtivo, strTroco, strParc As String
        strTroco = ""
        Dim I As Integer

        For I = 0 To dt.Rows.Count - 1

            strCod = Esq(dt.Rows.Item(I).Item(0).ToString, 2).Replace(" ", "0")

            strDesc = Dir(dt.Rows.Item(I).Item(1).ToString, 30)
            strDesc = Mid(strDesc, 1, 30)

            strDescECF = Mid(strDesc, 1, 15)
            strDescECF = Dir(strDescECF, 20)

            strPrazo = dt.Rows.Item(I).Item(4).ToString
            strForPag = dt.Rows.Item(I).Item(5).ToString

            Select Case strDesc.Trim
                Case "DINHEIRO"
                    strTipoPag = "D"
                    strTroco = "0000000009999"
                    strParc = "000"
                Case "CHEQUE"
                    strTipoPag = "C"
                    strParc = "024"
                    strTroco = "0000000000000"
                Case "CARTEIRA"
                    strTipoPag = "E"
                    strTroco = "0000000009999"
                    strParc = "024"
                Case "TROCO"
                    strTipoPag = "X"
                    strTroco = "0000000000000"
                    strParc = "000"
                Case Else
                    strTipoPag = "O"
                    strTroco = "0000000009999"
                    strParc = "000"
            End Select


            Select Case strForPag
                Case "A VISTA"
                    strForPag = "V"

                Case "A PRAZO"
                    strForPag = "P"

            End Select


            'If strPrazo = "True" Then
            '    strTipoPag = "T"
            '    strTroco = "0000000000000"
            '    strTEF = "S"
            'Else
            strTEF = " "
            'End If


            If parEcluido = False Then
                strAtivo = "A"
            Else
                strAtivo = "I"
            End If

            Dim strValCred, strExiCliVinc, strExiCliCad, ExiCliAti As String

            strValCred = "N"
            strExiCliVinc = "N"
            strExiCliCad = "N"
            ExiCliAti = "N"

            RMREG9 &= "009" & strCod & Dir(strDesc, 30) & strDescECF & strTipoPag & strForPag & strParc & strTEF & strAtivo & strTroco & strValCred & strExiCliVinc & strExiCliCad & ExiCliAti & vbCrLf
            intNumRegs += 1
        Next

        If parTipoArquivo = "UNICO" Then
            EscreveArquivosCupom("PAGAMENTO", intNumRegs)
        Else
            Return intNumRegs
        End If

    End Function

    Public Shared Function EscreveArquivosCupom(ByVal parTipoArquivo As String, ByVal parNumRegistros As Integer) As Boolean

        Dim strData, strHora As String

        Dim strDia, strMes, strAno, strHor, strMin, strSeg As String

        strDia = Date.Today.Day

        If strDia.Length = 1 Then
            strDia = "0" & strDia
        End If

        strMes = Date.Today.Month

        If strMes.Length = 1 Then
            strMes = "0" & strMes
        End If

        strAno = Date.Today.Year

        If strAno.Length = 2 Then
            strAno = "20" & strAno
        End If


        strHor = Date.Now.Hour

        If strHor.Length = 1 Then
            strHor = "0" & strHor
        End If

        strMin = Date.Now.Minute

        If strMin.Length = 1 Then
            strMin = "0" & strMin
        End If

        strSeg = Date.Now.Second

        If strSeg.Length = 1 Then
            strSeg = "0" & strSeg
        End If

        strData = strDia & strMes & strAno
        strHora = strHor & strMin & strSeg

        RMREG1 = "001" & CNPJdoCliente.Trim & "REM" & strData & strHora & "0000" & "009"

        RMREG99 = "099" & Esq(parNumRegistros, 10).Replace(" ", "0")

        Dim parTexto As String = ""

        Select Case parTipoArquivo

            Case "USUARIO"
                parTexto = RMREG1 & vbCrLf & RMREG2 & RMREG3 & RMREG99

            Case "CLIENTE"
                parTexto = RMREG1 & vbCrLf & RMREG4 & RMREG99

            Case "PRODUTO"
                parTexto = RMREG1 & vbCrLf & RMREG5 & RMREG6 & RMREG99

            Case "VENDA"
                parTexto = RMREG1 & vbCrLf & RMREG7 & RMREG8 & RMREG34 & RMREG99

            Case "PAGAMENTO"
                parTexto = RMREG1 & vbCrLf & RMREG9 & RMREG99

            Case "TUDO"
                parTexto = RMREG1 & vbCrLf & RMREG2 & RMREG3 & RMREG4 & RMREG5 & RMREG6 & RMREG9 & RMREG99

        End Select

        Dim strNumArqRM As String = ""
        Dim dt As DataTable = CarregarDataTable("Select NumArqRM from Config WHERE Codigo =" & CodConfig)

        If dt.Rows.Count > 0 Then
            strNumArqRM = Val(dt.Rows.Item(0).Item(0).ToString) + 1
            Atualizar("Update Config set NumArqRM =" & strNumArqRM & " WHERE Codigo =" & CodConfig)
        Else
            MsgBox("Tabela config ainda não foi configurada!", MsgBoxStyle.Information)
        End If
        strNumArqRM = Esq(strNumArqRM, 6).Replace(" ", "0")
        Try
            EscreveArquivo(CaminhoDaPastaMestra & "\RM" & strNumArqRM & ".R", parTexto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Function

End Class
