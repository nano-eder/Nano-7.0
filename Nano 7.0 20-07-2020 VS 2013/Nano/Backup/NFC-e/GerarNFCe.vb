Imports System
Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports Nano.clsFuncoes
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization
Imports BusinessRefinery.Barcode

Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Public Class GerarNFCe
    Public Shared Function ArquivoNfeXml(ByVal parArquivo As String, ByVal parTagsBloco As String, ByVal parTags As String, ByVal parWhere As String) As DataTable

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

    Public Shared Function GerarCupomNFCe(ByVal parXML As String, ByVal parConsulta As Boolean)
        Dim rptDoc As New NFCe

        Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim dtCliente As DataTable
        Dim dtConfig As DataTable
        Dim dtBarra As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("CodInterno")
        dt.Columns.Add("Produto")
        'dt.Columns.Add("CodProd")
        dt.Columns.Add("uCom")
        dt.Columns.Add("qCom")
        dt.Columns.Add("vUnCom")
        dt.Columns.Add("vProd")
        'dt.Columns.Add("ValAprox")


        Dim strCaminhoNfe As String = parXML

        parXML = LerArquivo(parXML, True)

        parXML = parXML.Replace("xml version='1.0'", "xml version=""1.0""")

        parXML = parXML.Replace("'UTF-8'", """UTF-8""")
        parXML = parXML.Replace("'utf-8'", """utf-8""")

        parXML = parXML.Replace("'", "")

        If parXML.Contains("?xml") = False Then
            parXML = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>" & parXML
        End If

        Dim intXML As Integer = parXML.Length
        Dim strChar As String = parXML.Substring(intXML - 1, 1)
        If strChar <> ">" Then
            parXML = parXML & ">"
        End If

        'parXML = parXML.Replace("'", "")

        Dim strTags As String = "/nfeProc"
        If parXML.Contains("nfeProc") = False Then
            strTags = ""

        End If

        Dim dtNF As DataTable = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe", "Id Varchar(50) './@Id'", "")

        Dim strChave As String = dtNF.Rows.Item(0).Item("Id").ToString

        strChave = dtNF.Rows.Item(0).Item("Id").ToString.Replace("NFe", "")


        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/ide", "nNF Varchar(20), tpAmb Varchar(20), serie varchar(20), " & _
        "dhEmi varchar(50)", "")

        Dim strNumNF As String = dtNF.Rows.Item(0).Item("nNF").ToString
        Dim strSerie As String = dtNF.Rows.Item(0).Item("serie").ToString
        Dim strDataEmissao As String = dtNF.Rows.Item(0).Item("dhEmi").ToString
        Dim strTipoAmb As String = dtNF.Rows.Item(0).Item("tpAmb").ToString



        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/emit/enderEmit", "CNPJ Varchar(20) '../CNPJ', " & _
        "xNome varchar(150) '../xNome', IE varchar(20) '../IE', xLgr varchar(100), nro varchar(20), " & _
        "xBairro varchar(60), xMun varchar(80), CEP varchar(20), UF varchar (2)", "")

        Dim strCNPJEmitente As String = dtNF.Rows.Item(0).Item("CNPJ").ToString
        Dim strNomeEmitente As String = dtNF.Rows.Item(0).Item("xNome").ToString
        Dim strIEEmitente As String = dtNF.Rows.Item(0).Item("IE").ToString
        Dim strEnderecoEmitente As String = dtNF.Rows.Item(0).Item("xLgr").ToString
        Dim strNumeroEmitente As String = dtNF.Rows.Item(0).Item("nro").ToString
        Dim strBairroEmitente As String = dtNF.Rows.Item(0).Item("xBairro").ToString
        Dim strCidadeEmitente As String = dtNF.Rows.Item(0).Item("xMun").ToString
        Dim strCEPEmitente As String = dtNF.Rows.Item(0).Item("CEP").ToString


        'rptDoc.PageHeaderSection1.SectionFormat.EnableSuppress = True


        TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
        TextObjects(0).Text = strNomeEmitente

        TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
        TextObjects(1).Text = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

        TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
        TextObjects(2).Text = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/dest/enderDest", "CNPJ Varchar(20) '../CNPJ', " & _
        "CPF Varchar(20) '../CPF', xNome varchar(150) '../xNome', xLgr varchar(100), nro varchar(20), " & _
        "xBairro varchar(60), xMun varchar(80), CEP varchar(20)", "")

        Dim strCPFDestinatario As String = ""
        Dim strDestinatario As String = ""

        If dtNF.Rows.Count > 0 Then
            strCPFDestinatario = dtNF.Rows.Item(0).Item("CPF").ToString()
            Dim strNomeDest As String = dtNF.Rows.Item(0).Item("xNome").ToString()
            If strCPFDestinatario = "" Then
                strCPFDestinatario = dtNF.Rows.Item(0).Item("CNPJ").ToString
                If strCPFDestinatario <> "" Then
                    strCPFDestinatario = AddPonto(strCPFDestinatario, "J")
                End If
            Else
                strCPFDestinatario = AddPonto(strCPFDestinatario, "F")
            End If

            If strCPFDestinatario <> "" Then
                TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtCPFDest")
                TextObjects(4).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario
                strDestinatario = "CPF/CNPJ do consumidor: " & strCPFDestinatario
                TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtNomeDest")
                TextObjects(5).Text = strNomeDest

                Dim strEnderecoDest As String = dtNF.Rows.Item(0).Item("xLgr").ToString

                If strEnderecoDest = "" Then
                    rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True
                    TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtCPFConsumidor")
                    TextObjects(13).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario
                Else
                    Dim strNumeroDest As String = dtNF.Rows.Item(0).Item("nro").ToString
                    Dim strBairroDest As String = dtNF.Rows.Item(0).Item("xBairro").ToString
                    Dim strCidadeDest As String = dtNF.Rows.Item(0).Item("xMun").ToString
                    Dim strCEPDest As String = dtNF.Rows.Item(0).Item("CEP").ToString
                    Dim strEndDestinatario As String = strEnderecoDest & ", " & strNumeroDest & ", " & strBairroDest & ", " & strCidadeDest & ", " & strCEPDest
                    TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtEndDest")
                    TextObjects(13).Text = strEndDestinatario

                    rptDoc.ReportFooterSection12.SectionFormat.EnableSuppress = True
                End If


            Else

                rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True

            End If
        Else
            dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/dest", "CNPJ Varchar(20), " & _
            "CPF Varchar(20), xNome varchar(150)", "")
            If dtNF.Rows.Count > 0 Then
                strCPFDestinatario = dtNF.Rows.Item(0).Item("CPF").ToString()
                Dim strNomeDest As String = dtNF.Rows.Item(0).Item("xNome").ToString()
                If strCPFDestinatario = "" Then
                    strCPFDestinatario = dtNF.Rows.Item(0).Item("CNPJ").ToString
                    If strCPFDestinatario <> "" Then
                        strCPFDestinatario = AddPonto(strCPFDestinatario, "J")
                    End If
                Else
                    strCPFDestinatario = AddPonto(strCPFDestinatario, "F")
                End If
                rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True
                TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtCPFConsumidor")
                TextObjects(13).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario
            End If
            rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True
        End If

        rptDoc.ReportFooterSection14.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection15.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection16.SectionFormat.EnableSuppress = True

        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/det/prod", "nItem varchar(10) '../@nItem', " & _
        "cProd varchar(10), xProd varchar(100), uCom varchar(3), qCom varchar(10), " & _
        "vUnCom varchar(10), vProd varchar(10)", "")

        Dim I As Integer

        Dim strStringProduto As String = ""
        For I = 0 To dtNF.Rows.Count - 1
            Dim strCodigo As String = dtNF.Rows.Item(I).Item("nItem").ToString
            Dim strCodProduto As String = dtNF.Rows.Item(I).Item("cProd").ToString
            Dim strProduto As String = dtNF.Rows.Item(I).Item("xProd").ToString
            Dim strUM As String = dtNF.Rows.Item(I).Item("uCom").ToString
            Dim dblQtde As Double = dtNF.Rows.Item(I).Item("qCom").ToString.Replace(".", ",")
            Dim dblValUnit As Double = dtNF.Rows.Item(I).Item("vUnCom").ToString.Replace(".", ",")
            Dim dblTot As Double = dtNF.Rows.Item(I).Item("vProd").ToString.Replace(".", ",")

            Dim dtImp As DataTable = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/det/imposto", "nItem varchar(10) '../@nItem', " & _
            "vItem12741 varchar(10)", " where nItem = '" & strCodigo & "'")
            Dim strValorAproximado As String = dtImp.Rows.Item(0).Item("vItem12741").ToString

            dt.Rows.Add()


            'Dim strItem As String = Format(CInt(strCodigo), "000") & " " & strCodProduto & " " & strProduto


            'Dim strItem2 As String = dblQtde.ToString("0.0").Replace(",", ".") & " " & strUM & " X " & dblValUnit.ToString("0.00") & " " & "(" & strValorAproximado & ")"


            'Dim intResul As Integer = strItem.Length + strItem2.Length
            'Dim strVProd As String = dblTot.ToString("0.00")

            'If intResul > 46 Then
            '    If strItem.Length > 47 Then
            '        strProduto = strItem.Substring(0, 47) & vbCrLf & strItem2
            '    Else
            '        strProduto = strItem & vbCrLf & strItem2
            '    End If
            '    strVProd = " " & vbCrLf & dblTot.ToString("0.00")
            'Else
            '    strProduto = strItem & " " & strItem2
            'End If


            dt.Rows.Item(I).Item("CodInterno") = strCodProduto
            dt.Rows.Item(I).Item("Produto") = strProduto
            ' dt.Rows.Item(I).Item("CodProd") = Format(CInt(strCodigo), "000")
            dt.Rows.Item(I).Item("uCom") = strUM
            dt.Rows.Item(I).Item("qCom") = dblQtde.ToString("0,0")
            dt.Rows.Item(I).Item("vUnCom") = dblValUnit.ToString("0.00")
            dt.Rows.Item(I).Item("vProd") = dblTot.ToString("0.00")
            'dt.Rows.Item(I).Item("ValAprox") = "(" & strValorAproximado & ")"




            'If ModeloImpSAT = "MP-4200 TH" Or ModeloImpSAT = "EPSON" Then
            '    Dim str As String = ""
            '    If intResul > 40 Then
            '        If strItem.Length > 41 Then
            '            strProduto = strItem.Substring(0, 40)
            '            str &= Dir(strProduto, 48) & vbCrLf
            '            str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
            '        Else
            '            str &= Dir(strItem, 48) & vbCrLf
            '            str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
            '        End If
            '    Else
            '        strProduto = strItem & " " & strItem2
            '        str &= Dir(strProduto, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
            '    End If
            '    strStringProduto &= str & vbCrLf
            'End If




        Next

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtTotalItens")
        TextObjects(3).Text = dtNF.Rows.Count


        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/total/ICMSTot", "vProd Varchar(10), vDesc varchar(10)", "")

        Dim dblValorProduto As Double = dtNF.Rows.Item(0).Item("vProd").ToString.Replace(".", ",")
        Dim dblValorDesconto As Double = dtNF.Rows.Item(0).Item("vDesc").ToString.Replace(".", ",")

        TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtTotal")
        TextObjects(6).Text = dblValorProduto.ToString("0.00")

        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/total/DescAcrEntr", "vDescSubtot Varchar(10)", "")
        If dtNF.Rows.Count > 0 Then
            dblValorDesconto = dtNF.Rows.Item(0).Item("vDescSubtot").ToString.Replace(".", ",")

        End If

        TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtTotalDesconto")
        TextObjects(7).Text = dblValorDesconto.ToString("0.00")

        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/total/ICMSTot", "vNF Varchar(10), vTotTrib varchar(10)", "")

        Dim dblValorTotal As Double = dtNF.Rows.Item(0).Item("vNF").ToString.Replace(".", ",")
        Dim dblValorAproximado As Double = dtNF.Rows.Item(0).Item("vTotTrib").ToString.Replace(".", ",")


        TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtTotal")
        TextObjects(8).Text = dblValorTotal.ToString("0.00")

        TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtValorAprox")
        TextObjects(9).Text = dblValorAproximado.ToString("0.00")

        If VersaoXml = "3.10" Then
            dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/pag", "tPag varchar(10), vPag varchar(10)", "")
        ElseIf VersaoXml = "4.00" Then
            dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/pag/detPag", "tPag varchar(10), vPag varchar(10)", "")
        End If

        Dim intPag As Integer = 0

        Dim strPagamento As String = ""
        Dim strValorPagamento As String = ""

        For I = 0 To dtNF.Rows.Count - 1
            Dim strPag As String = dtNF.Rows.Item(I).Item("tPag").ToString
            Dim dblValPag As Double = dtNF.Rows.Item(I).Item("vPag").ToString.Replace(".", ",")

            Select Case strPag
                Case "01"
                    strPag = "Dinheiro"
                Case "02"
                    strPag = "Cheque"
                Case "03"
                    strPag = "Cartão de Crédito"
                Case "04"
                    strPag = "Cartão de Débito"
                Case "05"
                    strPag = "Crédito Loja"
                Case "10"
                    strPag = "Vale Alimentação"
                Case "11"
                    strPag = "Vale Refeição"
                Case "12"
                    strPag = "Vale Presente"
                Case "13"
                    strPag = "Vale Combustível"
                Case "99"
                    strPag = "Outros"

            End Select

            Select Case I


                Case 0
                    TextObjects(15) = rptDoc.Section1.ReportObjects.Item("txtPag1")
                    TextObjects(15).Text = strPag
                    TextObjects(16) = rptDoc.Section1.ReportObjects.Item("txtValor1")
                    TextObjects(16).Text = dblValPag.ToString("0.00")
                Case 1
                    rptDoc.ReportFooterSection2.SectionFormat.EnableSuppress = False
                    TextObjects(17) = rptDoc.Section1.ReportObjects.Item("txtPag2")
                    TextObjects(17).Text = strPag
                    TextObjects(18) = rptDoc.Section1.ReportObjects.Item("txtValor2")
                    TextObjects(18).Text = dblValPag.ToString("0.00")
                Case 2
                    rptDoc.ReportFooterSection4.SectionFormat.EnableSuppress = False
                    TextObjects(19) = rptDoc.Section1.ReportObjects.Item("txtPag3")
                    TextObjects(19).Text = strPag
                    TextObjects(20) = rptDoc.Section1.ReportObjects.Item("txtValor3")
                    TextObjects(20).Text = dblValPag.ToString("0.00")
                Case 3
                    rptDoc.ReportFooterSection5.SectionFormat.EnableSuppress = False
                    TextObjects(21) = rptDoc.Section1.ReportObjects.Item("txtPag4")
                    TextObjects(21).Text = strPag
                    TextObjects(22) = rptDoc.Section1.ReportObjects.Item("txtValor4")
                    TextObjects(22).Text = dblValPag.ToString("0.00")

                Case 4
                    rptDoc.ReportFooterSection6.SectionFormat.EnableSuppress = False
                    TextObjects(23) = rptDoc.Section1.ReportObjects.Item("txtPag5")
                    TextObjects(23).Text = strPag
                    TextObjects(24) = rptDoc.Section1.ReportObjects.Item("txtValor5")
                    TextObjects(24).Text = dblValPag.ToString("0.00")
            End Select
            strPagamento &= Dir(strPag, 40) & Esq(dblValPag.ToString("####,##0.00"), 8) & vbCrLf

        Next

        '''VERIFICAR TROCO

        ''dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/pag", "vTroco varchar(10)", "")

        ''Dim dblTroco As Double = dtNF.Rows.Item(0).Item("vTroco").ToString.Replace(".", ",")
        ''TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtValorTroco")
        ''TextObjects(10).Text = dblTroco.ToString("0.00")

        'dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/infAdic/obsFisco", "xTexto varchar(100)", "")

        'If dtNF.Rows.Item(0).Item("xTexto").ToString <> "" Then
        '    If dtNF.Rows.Item(0).Item("xTexto").ToString <> "xTexto1" Then
        '        TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtFisco")
        '        TextObjects(25).Text = dtNF.Rows.Item(0).Item("xTexto").ToString
        '    End If
        'End If



        'dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFe/infAdic", "infCpl varchar(100)", "")

        'TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtObservacao")
        'TextObjects(11).Text = dtNF.Rows.Item(0).Item("infCpl").ToString



        Dim strNumSerie As String = strSerie

        Dim dtData As Date = strDataEmissao
        Dim strHora As String = strDataEmissao.Substring(11, 8)

        TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtInformacao")
        TextObjects(12).Text = "Número: " & strNumNF & " Série: " & strSerie & " Data Emissão: " & Format(dtData, "dd/MM/yyyy") & " " & strHora & " - Via Consumidor"

        Dim strChaveAcesso As String = strChave.Substring(0, 4) & " " & strChave.Substring(4, 4) & " " & strChave.Substring(8, 4) & " " & strChave.Substring(12, 4) & " " & strChave.Substring(16, 4) & " " & strChave.Substring(20, 4) & " " & strChave.Substring(24, 4) & " " & strChave.Substring(28, 4) & " " & strChave.Substring(32, 4) & " " & strChave.Substring(36, 4) & " " & strChave.Substring(40, 4)
        TextObjects(14) = rptDoc.Section1.ReportObjects.Item("txtChave")
        TextObjects(14).Text = strChaveAcesso


        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/NFe/infNFeSupl", "qrCode varchar(Max)", "")
        Dim strQrCode As String = "" 'strChave & "|" & strDataEmissao & strHoraEmissao & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & strAssinaturaQrCode

        If dtNF.Rows.Count > 0 Then
            strQrCode = dtNF.Rows.Item(0).Item("qrCode").ToString
        End If


        TextObjects(27) = rptDoc.Section1.ReportObjects.Item("txtConsulta")
        TextObjects(27).Text = "Consulte pela Chave de Acesso em " & SelecionarURLQrCode(EstadoEmitente, TipoAmbiente)


        dtNF = ArquivoNfeXml(parXML, "" & strTags & "/protNFe/infProt", _
        "nProt Varchar(30)", "")

        Dim strProtocolo As String = ""
        If dtNF.Rows.Count > 0 Then
            strProtocolo = dtNF.Rows.Item(0).Item("nProt").ToString
        End If


        TextObjects(28) = rptDoc.Section1.ReportObjects.Item("txtProtocolo")
        TextObjects(28).Text = strProtocolo

        'Dim strAmbiente As String = "Amb. de Produção"
        'If strTipoAmb = "2" Then
        '    strAmbiente = "Amb. de Homologação"
        'End If

        'TextObjects(29) = rptDoc.Section1.ReportObjects.Item("txtRodape")
        'TextObjects(29).Text = strAmbiente & " Versão XML: " & VersaoXmlAutorizacao & " Versão XSLT: 1.02"


        If TipoAmbiente = "1" Then
            rptDoc.ReportFooterSection8.SectionFormat.EnableSuppress = True
        End If
        ''Dim barcode As BusinessRefinery.Barcode.QRCode = New BusinessRefinery.Barcode.QRCode()

        ''barcode.DataMode = QRCodeDataMode.Auto
        ''barcode.Code = strChave & "|" & strDataEmissao & strHoraEmissao & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & strAssinaturaQrCode
        ''barcode.Version = QRCodeVersion.V15



        ''barcode.Resolution = 104
        ' ''barcode.Rotate = BusinessRefinery.Barcode.Rotate.Rotate270
        ''barcode.Format = System.Drawing.Imaging.ImageFormat.Png

        ''barcode.drawBarcode2ImageFile(My.Application.Info.DirectoryPath & "/QrCode.png")



        Dim picQrCode As New PictureBox

        picQrCode.Size = New System.Drawing.Size(104, 104)


        ''If File.Exists(My.Application.Info.DirectoryPath & "/QrCode.png") = True Then
        ''    picQrCode.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "/QrCode.png")

        ''End If



        Dim qrcode As New QRCodeEncoder
        qrcode.QRCodeVersion = 16
        Dim qr As Bitmap = qrcode.Encode(strQrCode)
        picQrCode.Image = TryCast(qr, Image)




        Dim imagem As Byte() = converteimagem(picQrCode.Image)
        dtCliente = New DataTable
        dtCliente.Columns.Add(New DataColumn("Imagem", GetType(Byte())))
        dtCliente.Rows.Add()
        dtCliente.Rows.Item(0).Item("Imagem") = imagem


        dtConfig = New DataTable
        Dim picLogo As New PictureBox
        picLogo.Size = New System.Drawing.Size(361, 104)
        picLogo.Image = LogoTipo
        If picLogo.Image Is Nothing = False Then
            dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
            dtConfig.Rows.Add()
            Dim bLogo As Byte() = converteimagem(picLogo.Image)
            dtConfig.Rows.Item(0).Item("Logo") = bLogo
        End If



        dtBarra = New DataTable
        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))
        dtBarra.Rows.Add()
        'Dim intImagem As New PictureBox
        'intImagem.Size = New System.Drawing.Size(361, 104)

        'Dim BarcodeChave As New BarcodeLib.Barcode(strChave, BarcodeLib.TYPE.CODE128C)
        'intImagem.Image = BarcodeChave.Encode(BarcodeLib.TYPE.CODE128C, strChave, 300, 150)
        'Dim imgChave As Byte() = converteimagem(intImagem.Image)
        'dtBarra.Rows.Item(0).Item("PlanoFundo") = imgChave



        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        dtCliente.TableName = "Cliente"
        dt.TableName = "ItensNfe"
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        ds.Tables.Add(dtCliente)
        rptDoc.SetDataSource(ds)

        'Dim PrintDialog1 As New PrintDialog
        'PrintDialog1.Document = New Printing.PrintDocument
        'PrintDialog1.AllowSelection = False
        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        '    rptDoc.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
        '    rptDoc.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, PrintDialog1.PrinterSettings.Collate, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
        'End If
        'PrintDialog1.Dispose()



        'Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")




        If parConsulta = False Then


            Try
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CrDiskFileDestinationOptions.DiskFileName = strCaminhoNfe.Replace("Autorizadas", "Notas").Replace("xml", "pdf")
                CrExportOptions = rptDoc.ExportOptions
                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With
                rptDoc.Export()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



            If IO.Directory.Exists(PastaBackup) = False Then
                IO.Directory.CreateDirectory(PastaBackup)
            End If

            If IO.File.Exists(strCaminhoNfe.Replace(PastaAutorizadas, PastaBackup)) = False Then
                File.Copy(strCaminhoNfe, strCaminhoNfe.Replace(PastaAutorizadas, PastaBackup))
            End If

            If IO.File.Exists(PastaBackup & "\" & strChave & "-procNfe.pdf") = False Then

                File.Copy(PastaNotas & "\" & strChave & "-procNfe.pdf", PastaBackup & "\" & strChave & "-procNfe.pdf")

            End If

            If ImpressoraNFCe = "MP-4200 TH" Then
                'strTraco = clsImprimir.Comp("________________________________________________")
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then

                End If
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & ""))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("CUPOM FISCAL ELETRÔNICO - SAT"))) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If
                StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= strStringProduto
                StringImpressao &= vbCrLf

                StringImpressao &= clsImprimir.Neg(Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= clsImprimir.Neg(Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
                StringImpressao &= clsImprimir.Neg(Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= clsImprimir.Neg(strPagamento)
                ''' StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
                'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(Chr(27) + "!" + Chr(1) & strChaveAcesso)) & vbCrLf
                'StringImpressao &= clsImprimir.GerarBarCode(strChave) & vbCrLf
                iRetorno = clsBematech.IniciaPorta(PortaImpressoraNFCe)
                iRetorno = ConfiguraModeloImpressora(7)
                iRetorno = BematechTX(StringImpressao)




                'iRetorno = FormataTX("#   |COD | DESC |QTD | UN |VL UN R$|(VL TR R$)*|VL ITEM R$", 1, 0, 0, 0, 0)
                iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

                iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



                iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
                iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

                iRetorno = BematechTX(clsImprimir.Corte)

                iRetorno = clsBematech.FechaPorta()
                'StringImpressao &= Chr(29) + Chr(107) + Chr(73) + Chr(110) + strChave & vbCrLf

                'clsImprimir.Rodape(StringImpressao)

            ElseIf ImpressoraNFCe.Contains("ESC/POS") = True Then


                'strTraco = clsImprimir.Comp("________________________________________________")
                strTraco = "-------------------------------------------------------"

                Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                StringImpressao = clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strNomeEmitente)) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strEnd)) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strCNPJ)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT("EXTRATO No." & ""))) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT("CUPOM FISCAL ELETRONICO - SAT"))) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 55) & vbCrLf
                    StringImpressao &= strTraco & vbCrLf
                End If
                StringImpressao &= clsImprimir.CentralizarSAT(clsImprimir.NegSAT("# |COD |DESC |QT |UN | VL UN R$|(VL TR R$)*| VL ITEM R$")) & vbCrLf

                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= strStringProduto
                StringImpressao &= vbCrLf

                StringImpressao &= clsImprimir.NegSAT(Dir("Total bruto do item", 47) & Esq(dblValorProduto.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= clsImprimir.NegSAT(Dir("Total de descontos/acréscimos sobre item", 47) & Esq(dblValorDesconto.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= Dir(" ", 37) & Esq("------------------", 18) & vbCrLf
                StringImpressao &= clsImprimir.NegSAT(Dir("TOTAL R$", 47) & Esq(dblValorTotal.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= clsImprimir.NegSAT(strPagamento)
                ''StringImpressao &= clsImprimir.NegSAT(Dir("Troco R$", 47) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT("OBSERVACOES DO CONTRIBUINTE")) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 55)) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= clsImprimir.CompSAT(Dir("Valor aproximado dos tributos em R$", 47) & Esq(dblValorAproximado.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(Dir("(Conforme Lei Fed. 12.741/2012)", 55)) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(Dir("*Valor aproximado dos tributos do item", 55)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT("SAT No. " & strNumSerie))) & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf


                StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT(strChaveAcesso))) & vbCrLf
                clsImprimir.SendStringToPrinter(NomeImpSAT, StringImpressao)
                StringImpressao = clsImprimir.CodigoBarraSAT(strChave)

                clsImprimir.SendStringToPrinter(NomeImpSAT, StringImpressao)

                StringImpressao = clsImprimir.QrCodeSAT(strQrCode)

                clsImprimir.SendStringToPrinter(NomeImpSAT, StringImpressao)
                StringImpressao = clsImprimir.CompSAT(" ") & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(" ") & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(" ") & vbCrLf
                StringImpressao &= clsImprimir.CompSAT(" ") & vbCrLf


                StringImpressao &= clsImprimir.Corte()

                clsImprimir.SendStringToPrinter(NomeImpSAT, StringImpressao)




            ElseIf ImpressoraNFCe = "NORMAL" Then
                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 350
                    margins.leftMargin = 350
                    margins.rightMargin = 350
                    margins.topMargin = 350


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try


                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)
            ElseIf ImpressoraNFCe = "DARUMA" Then
                Dim iRetorno As Integer = clsDarumaSatDLL.iCFImprimirParametrizado_NFCe_Daruma(strCaminhoNfe, "", "", "48", "1", "")
            ElseIf ImpressoraNFCe = "EPSON" Then
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

                StringImpressao = "<ce><b>" & strNomeEmitente & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce>" & strEnd & "</ce>" & vbCrLf
                StringImpressao &= "<ce>" & strCNPJ & "</ce>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf

                StringImpressao &= "<ce><b>" & "EXTRATO No." & "" & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & "CUPOM FISCAL ELETRÔNICO - SAT" & "</b></ce>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf

                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If
                StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= strStringProduto
                StringImpressao &= vbCrLf

                StringImpressao &= "<b>" & Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= "<b>" & Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
                StringImpressao &= "<b>" & Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= "<b>" & strPagamento & "</b>"
                '' StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
                StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


                iRetorno = clsEpson.IniciaPorta(PortaImpressoraNFCe)

                iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

                iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

                iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

                iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

                iRetorno = clsEpson.AcionaGuilhotina(1)

                iRetorno = clsEpson.FechaPorta()

            ElseIf ImpressoraNFCe = "TERMICA" Then

                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)

            ElseIf ImpressoraNFCe = "TERMICA MARGEM" Then

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 150
                    margins.leftMargin = 180
                    margins.rightMargin = 50
                    margins.topMargin = 150


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try
                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        Else
            frmMenuNFCe.CrystalReportViewer1.ReportSource = rptDoc
            frmMenuNFCe.CrystalReportViewer1.ShowLastPage()
            Dim intPageFinal As Integer = frmBoleto.CrystalReportViewer1.GetCurrentPageNumber
            frmMenuNFCe.CrystalReportViewer1.ShowFirstPage()

            Try
                Dim tabFicha As Windows.Forms.TabControl
                Dim myControl As System.Windows.Forms.Control
                For Each myControl In frmMenuNFCe.CrystalReportViewer1.Controls
                    If UCase(myControl.GetType.Name) = "PAGEVIEW" Then
                        tabFicha = CType(myControl.Controls(0), TabControl)
                        With tabFicha
                            .ItemSize = New Size(0, 1)
                            .SizeMode = TabSizeMode.Fixed
                            .Appearance = TabAppearance.Buttons
                        End With
                    End If
                Next
            Catch ex As Exception

            End Try
        End If









        Exit Function




    End Function
    Public Shared Function GerarEvento(ByVal CaminhoXml As String)

        Dim rptDoc As New NFCe

        Dim TextObjects(16) As CrystalDecisions.CrystalReports.Engine.TextObject


        Dim dtNF As DataTable
        Dim strTexto As String = LerArquivo(CaminhoXml, True)

        Dim strTags As String = "/procEventoNFe"
        If strTexto.Contains("procEventoNFe") = False Then
            strTags = ""

        End If

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/evento/infEvento", "Id Varchar(60) '@Id'", "")


        Dim strChave As String = dtNF.Rows.Item(0).Item("Id").ToString.Replace("ID", "")

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/evento/infEvento/detEvento", _
        "xCorrecao varchar(max), xCondUso Varchar(Max), xJust varchar (200)", "")

        Dim strCorrecao As String = dtNF.Rows.Item(0).Item("xCorrecao").ToString
        Dim strCondUso As String = dtNF.Rows.Item(0).Item("xCondUso").ToString
        Dim strJustificativa As String = dtNF.Rows.Item(0).Item("xJust").ToString

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/retEvento/infEvento", _
        "nSeqEvento varchar(2), chNFe Varchar(50), dhRegEvento varchar(30), nProt Varchar(30)", "")

        Dim strNumSeq As String = dtNF.Rows.Item(0).Item("nSeqEvento").ToString
        Dim strChaveNfe As String = dtNF.Rows.Item(0).Item("chNFe").ToString

        Dim strDataEvento As String = dtNF.Rows.Item(0).Item("dhRegEvento").ToString

        strDataEvento = strDataEvento.Substring(0, 19).Replace("T", " ")

        strDataEvento = Format(CDate(strDataEvento), "dd/MM/yyyy HH:mm:ss")

        Dim strProtocolo As String = dtNF.Rows.Item(0).Item("nProt").ToString

        strTexto = LerArquivo(PastaAutorizadas & "\" & strChaveNfe & "-procNfe.xml", True)

        strTags = "/nfeProc"
        If strTexto.Contains("nfeProc") = False Then
            strTags = ""

        End If
        Dim strNumNF As String = ""
        Dim strSerie As String = ""
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/ide", _
        "nNF varchar(20), serie Varchar(10), dhEmi varchar(30)", "")
        Dim strData As String = ""
        If dtNF.Rows.Count > 0 Then
            strNumNF = Format(CInt(dtNF.Rows.Item(0).Item("nNF").ToString), "000000")
            strSerie = dtNF.Rows.Item(0).Item("serie").ToString
            strData = dtNF.Rows.Item(0).Item("dhEmi").ToString

            strData = strData.Substring(0, 19).Replace("T", " ")

            strData = Format(CDate(strData), "dd/MM/yyyy HH:mm:ss")

        End If

        Dim strRazaoEmitente As String = ""
        Dim strIEEmitente As String = ""
        Dim strEnderecoEmitente As String = ""
        Dim strCNPJEmitente As String = ""
        Dim strEmail As String = ""
        Dim strNomeEmitente As String
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/emit/enderEmit", _
        "CNPJ varchar(20) '../CNPJ',xNome Varchar(100) '../xNome', IE varchar(20) '../IE', nro Varchar(10), xLgr varchar(100), " & _
        "xBairro varchar(80), xMun varchar(80), UF varchar(2), CEP varchar(9), fone varchar(20)", "")
        If dtNF.Rows.Count > 0 Then
            strCNPJEmitente = dtNF.Rows.Item(0).Item("CNPJ").ToString
            strRazaoEmitente = dtNF.Rows.Item(0).Item("xNome").ToString
            strIEEmitente = dtNF.Rows.Item(0).Item("IE").ToString
            Dim strEndEmitente As String = dtNF.Rows.Item(0).Item("xLgr").ToString
            Dim strNumeroEmitente As String = dtNF.Rows.Item(0).Item("nro").ToString
            Dim strBairroEmitente As String = dtNF.Rows.Item(0).Item("xBairro").ToString
            Dim strCidadeEmitente As String = dtNF.Rows.Item(0).Item("xMun").ToString
            Dim strCEPEmitente As String = dtNF.Rows.Item(0).Item("CEP").ToString

            Dim strTelEmitente As String = ""
            If dtNF.Rows.Item(0).Item("fone").ToString <> "" Then
                strTelEmitente = " FONE: " & AddPonto(dtNF.Rows.Item(0).Item("fone").ToString, "Telefone")
            End If
            strEnderecoEmitente = strEndEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

        End If
        Dim strDestinatario As String = ""
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/dest/enderDest", _
        "xNome Varchar(100) '../xNome', email varchar(80) '../email'", "")
        If dtNF.Rows.Count > 0 Then
            strDestinatario = dtNF.Rows.Item(0).Item("xNome").ToString

            If strDestinatario <> "" Then
                TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtCPFConsumidor")
                TextObjects(13).Text = strDestinatario
            End If
        End If



        TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtChave")
        TextObjects(0).Text = strChave

        TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtDataNFCe")
        TextObjects(1).Text = "NFC-e: " & strNumNF & " Série: " & strSerie & " Data Emissão: " & strData


        TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtDataCencelamento")
        TextObjects(2).Text = "Data Emissão: " & strDataEvento

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtMotivo")
        TextObjects(3).Text = "Motivo: " & strJustificativa

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtCupomFiscal")
        TextObjects(3).Text = "Cancelamento"

  

        TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
        TextObjects(7).Text = strRazaoEmitente

        TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
        TextObjects(8).Text = strEnderecoEmitente

        TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
        TextObjects(9).Text = AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

        rptDoc.Section3.SectionFormat.EnableSuppress = True
        rptDoc.Section4.SectionFormat.EnableSuppress = True
        rptDoc.Section1.SectionFormat.EnableSuppress = True

        rptDoc.ReportFooterSection10.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection3.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection7.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection8.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection1.SectionFormat.EnableSuppress = True

        rptDoc.PageHeaderSection8.SectionFormat.EnableSuppress = True

        TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtProtocolo")
        TextObjects(12).Text = strProtocolo


        Dim dtBarra As DataTable
        dtBarra = New DataTable

        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))
        dtBarra.Rows.Add()

        Dim dtConfig As DataTable

        dtConfig = New DataTable


        dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
        dtConfig.Rows.Add()

        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        Dim ds As New DataSet

        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        rptDoc.SetDataSource(ds)



        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            Dim dddd As String = CaminhoXml.Replace("Autorizadas", "Notas").Replace("xml", "pdf")
            CrDiskFileDestinationOptions.DiskFileName = CaminhoXml.Replace("Autorizadas", "Notas").Replace("xml", "pdf")
            CrExportOptions = rptDoc.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rptDoc.Export()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If PastaBackup <> "" Then
            Try
                If IO.Directory.Exists(PastaBackup & "\Cancelamento") = False Then
                    IO.Directory.CreateDirectory(PastaBackup & "\Cancelamento")
                End If

                If IO.File.Exists(CaminhoXml.Replace(PastaAutorizadas, PastaBackup).Replace("xml", "pdf")) = False Then

                    File.Copy(CaminhoXml.Replace("Autorizadas", "Notas").Replace("xml", "pdf"), CaminhoXml.Replace(PastaAutorizadas, PastaBackup).Replace("xml", "pdf"))

                End If
                If IO.File.Exists(CaminhoXml.Replace(PastaAutorizadas, PastaBackup)) = False Then
                    File.Copy(CaminhoXml, CaminhoXml.Replace(PastaAutorizadas, PastaBackup))

                End If

                If PastaAutorizadas.Contains("\\") = True Then
                    If IO.File.Exists(CaminhoXml.Replace("Autorizadas", "Backup").Replace("xml", "pdf")) = False Then
                        File.Copy(CaminhoXml.Replace("Autorizadas", "Notas").Replace("xml", "pdf"), CaminhoXml.Replace("Autorizadas", "Backup").Replace("xml", "pdf"))
                    End If
                    If IO.File.Exists(CaminhoXml.Replace("Autorizadas", "Backup")) = False Then
                        File.Copy(CaminhoXml, CaminhoXml.Replace("Autorizadas", "Backup"))
                    End If

                End If
            Catch ex As Exception

            End Try



            If ImpressoraNFCe = "MP-4200 TH" Then
                'strTraco = clsImprimir.Comp("________________________________________________")
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then

                End If
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & ""))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("CUPOM FISCAL ELETRÔNICO - SAT"))) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If
                StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                'StringImpressao &= strStringProduto
                StringImpressao &= vbCrLf

                'StringImpressao &= clsImprimir.Neg(Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8)) & vbCrLf
                'StringImpressao &= clsImprimir.Neg(Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
                'StringImpressao &= clsImprimir.Neg(Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= vbCrLf
                ' StringImpressao &= clsImprimir.Neg(strPagamento)
                ''' StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
                StringImpressao &= vbCrLf
                'StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                ' StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
                ' 'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
                'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(Chr(27) + "!" + Chr(1) & strChaveAcesso)) & vbCrLf
                'StringImpressao &= clsImprimir.GerarBarCode(strChave) & vbCrLf
                iRetorno = clsBematech.IniciaPorta(PortaImpressoraNFCe)
                iRetorno = ConfiguraModeloImpressora(7)
                iRetorno = BematechTX(StringImpressao)




                'iRetorno = FormataTX("#   |COD | DESC |QTD | UN |VL UN R$|(VL TR R$)*|VL ITEM R$", 1, 0, 0, 0, 0)
                'iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

                iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



                iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
                ' iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

                iRetorno = BematechTX(clsImprimir.Corte)

                iRetorno = clsBematech.FechaPorta()
                'StringImpressao &= Chr(29) + Chr(107) + Chr(73) + Chr(110) + strChave & vbCrLf

                'clsImprimir.Rodape(StringImpressao)

            ElseIf ImpressoraNFCe = "NORMAL" Then
                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 350
                    margins.leftMargin = 350
                    margins.rightMargin = 350
                    margins.topMargin = 350


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try


                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)
            ElseIf ImpressoraNFCe = "DARUMA" Then
                Dim iRetorno As Integer = clsDarumaSatDLL.iCFImprimirParametrizado_NFCe_Daruma(CaminhoXml, "", "", "48", "5", "")
            ElseIf ImpressoraNFCe = "EPSON" Then
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

                StringImpressao = "<ce><b>" & strNomeEmitente & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce>" & strEnd & "</ce>" & vbCrLf
                StringImpressao &= "<ce>" & strCNPJ & "</ce>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf

                StringImpressao &= "<ce><b>" & "EXTRATO No." & "" & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & "CUPOM FISCAL ELETRÔNICO - SAT" & "</b></ce>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf

                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If
                StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                ' StringImpressao &= strStringProduto
                StringImpressao &= vbCrLf

                ' StringImpressao &= "<b>" & Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                'StringImpressao &= "<b>" & Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
                'StringImpressao &= "<b>" & Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= vbCrLf
                'StringImpressao &= "<b>" & strPagamento & "</b>"
                '' StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
                StringImpressao &= vbCrLf
                ' StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                ' StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
                ' StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
                ' StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


                iRetorno = clsEpson.IniciaPorta(PortaImpressoraNFCe)

                iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

                iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

                iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

                'iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

                iRetorno = clsEpson.AcionaGuilhotina(1)

                iRetorno = clsEpson.FechaPorta()

            ElseIf ImpressoraNFCe = "TERMICA" Then

                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)

            ElseIf ImpressoraNFCe = "TERMICA MARGEM" Then

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                Try
                    margins.bottomMargin = 150
                    margins.leftMargin = 180
                    margins.rightMargin = 50
                    margins.topMargin = 150


                    rptDoc.PrintOptions.ApplyPageMargins(margins)
                Catch ex As Exception

                End Try
                rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        End If



    End Function



    Public Shared Function GerarInutilizacao(ByVal CaminhoXml As String)

        Dim rptDoc As New NFCe

        Dim TextObjects(16) As CrystalDecisions.CrystalReports.Engine.TextObject


        Dim dtNF As DataTable
        Dim strTexto As String = LerArquivo(CaminhoXml, True)

        Dim strTags As String = "/procInut"
        If strTexto.Contains("procInut") = False Then
            strTags = ""

        End If

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/inutNFe/infInut", "Id Varchar(60) '@Id'", "")


        Dim strChave As String = dtNF.Rows.Item(0).Item("Id").ToString.Replace("ID", "")

        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/inutNFe/infInut", _
          "nNFIni varchar(30), nNFFin Varchar(30), xJust varchar (200)", "")

        Dim strJustificativa As String = dtNF.Rows.Item(0).Item("xJust").ToString
        Dim strNumInicial As String = dtNF.Rows.Item(0).Item("nNFIni").ToString
        Dim strNumFinal As String = dtNF.Rows.Item(0).Item("nNFFin").ToString


        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/retInutNFe/infInut", _
        "dhRecbto varchar(30), xMotivo Varchar(MAx), nProt varchar(30)", "")
        Dim strDataEvento As String = dtNF.Rows.Item(0).Item("dhRecbto").ToString
        strDataEvento = strDataEvento.Substring(0, 19).Replace("T", " ")
        strDataEvento = Format(CDate(strDataEvento), "dd/MM/yyyy HH:mm:ss")
        Dim strMotivo As String = dtNF.Rows.Item(0).Item("xMotivo").ToString()
        Dim strProtocolo As String = dtNF.Rows.Item(0).Item("nProt").ToString



        If IO.Directory.Exists(PastaAutorizadas) = True Then



            Dim vetLista As Array = Directory.GetFiles(PastaAutorizadas, "*.xml")

            Dim I As Integer
            Dim A As Integer
            For I = 0 To vetLista.Length - 1
                Dim strNumN As String = vetLista(I)

                Dim fluxoTexto As IO.StreamReader

                If IO.File.Exists(strNumN) Then
                    fluxoTexto = New IO.StreamReader(strNumN)
                    strTexto = fluxoTexto.ReadToEnd
                    fluxoTexto.Close()

                    Exit For
                End If
            Next

        End If


        strTags = "/nfeProc"
        If strTexto.Contains("nfeProc") = False Then
            strTags = ""
        End If

        Dim strRazaoEmitente As String = ""
        Dim strIEEmitente As String = ""
        Dim strEnderecoEmitente As String = ""
        Dim strCNPJEmitente As String = ""
        Dim strEmail As String = ""
        Dim strNomeEmitente As String
        dtNF = ArquivoNfeXml(strTexto, "" & strTags & "/NFe/infNFe/emit/enderEmit", _
        "CNPJ varchar(20) '../CNPJ',xNome Varchar(100) '../xNome', IE varchar(20) '../IE', nro Varchar(10), xLgr varchar(100), " & _
        "xBairro varchar(80), xMun varchar(80), UF varchar(2), CEP varchar(9), fone varchar(20)", "")
        If dtNF.Rows.Count > 0 Then
            strCNPJEmitente = dtNF.Rows.Item(0).Item("CNPJ").ToString
            strRazaoEmitente = dtNF.Rows.Item(0).Item("xNome").ToString
            strIEEmitente = dtNF.Rows.Item(0).Item("IE").ToString
            Dim strEndEmitente As String = dtNF.Rows.Item(0).Item("xLgr").ToString
            Dim strNumeroEmitente As String = dtNF.Rows.Item(0).Item("nro").ToString
            Dim strBairroEmitente As String = dtNF.Rows.Item(0).Item("xBairro").ToString
            Dim strCidadeEmitente As String = dtNF.Rows.Item(0).Item("xMun").ToString
            Dim strCEPEmitente As String = dtNF.Rows.Item(0).Item("CEP").ToString

            Dim strTelEmitente As String = ""
            If dtNF.Rows.Item(0).Item("fone").ToString <> "" Then
                strTelEmitente = " FONE: " & AddPonto(dtNF.Rows.Item(0).Item("fone").ToString, "Telefone")
            End If
            strEnderecoEmitente = strEndEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

        End If

        TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtChave")
        TextObjects(0).Text = strChave

        TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtDataCencelamento")
        TextObjects(2).Text = "Data Emissão: " & strDataEvento

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtMotivo")
        TextObjects(3).Text = "Número Inicial: " & strNumInicial & "    Número Final: " & strNumFinal & "    Motivo: " & strJustificativa

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtCupomFiscal")
        TextObjects(3).Text = "Inutilização"
        TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtDadosCanc")
        TextObjects(5).Text = "DADOS INUTLIZAÇÃO"

        TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
        TextObjects(7).Text = strRazaoEmitente

        TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
        TextObjects(8).Text = strEnderecoEmitente

        TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
        TextObjects(9).Text = AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

        rptDoc.Section3.SectionFormat.EnableSuppress = True
        rptDoc.Section4.SectionFormat.EnableSuppress = True
        rptDoc.Section1.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection15.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection10.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection12.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection11.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection3.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection7.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection8.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection1.SectionFormat.EnableSuppress = True

        rptDoc.PageHeaderSection8.SectionFormat.EnableSuppress = True

        TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtProtocolo")
        TextObjects(12).Text = strProtocolo


        Dim dtBarra As DataTable
        dtBarra = New DataTable

        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))
        dtBarra.Rows.Add()

        Dim dtConfig As DataTable

        dtConfig = New DataTable


        dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
        dtConfig.Rows.Add()

        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        Dim ds As New DataSet

        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        rptDoc.SetDataSource(ds)


        If ImpressoraNFCe = "MP-4200 TH" Then
            ''strTraco = clsImprimir.Comp("________________________________________________")
            'strTraco = clsImprimir.Comp("------------------------------------------------")

            'Dim strEnd As String = strEnderecoEmitente
            'Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
            'StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'If strDestinatario <> "" Then

            'End If
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & ""))) & vbCrLf
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("CUPOM FISCAL ELETRÔNICO - SAT"))) & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'If strDestinatario <> "" Then
            '    StringImpressao &= Dir(strDestinatario, 48)
            '    StringImpressao &= strTraco & vbCrLf
            'End If
            'StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            ''StringImpressao &= strStringProduto
            'StringImpressao &= vbCrLf

            ''StringImpressao &= clsImprimir.Neg(Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8)) & vbCrLf
            ''StringImpressao &= clsImprimir.Neg(Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
            ''StringImpressao &= clsImprimir.Neg(Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= vbCrLf
            '' StringImpressao &= clsImprimir.Neg(strPagamento)
            '''' StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
            'StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
            'StringImpressao &= vbCrLf
            ''StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
            'StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
            'StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
            'StringImpressao &= strTraco & vbCrLf
            '' StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
            '' 'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
            ''StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(Chr(27) + "!" + Chr(1) & strChaveAcesso)) & vbCrLf
            ''StringImpressao &= clsImprimir.GerarBarCode(strChave) & vbCrLf
            'iRetorno = clsBematech.IniciaPorta(PortaImpressoraNFCe)
            'iRetorno = ConfiguraModeloImpressora(7)
            'iRetorno = BematechTX(StringImpressao)




            ''iRetorno = FormataTX("#   |COD | DESC |QTD | UN |VL UN R$|(VL TR R$)*|VL ITEM R$", 1, 0, 0, 0, 0)
            ''iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

            'iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



            'iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
            '' iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

            'iRetorno = BematechTX(clsImprimir.Corte)

            'iRetorno = clsBematech.FechaPorta()
            ''StringImpressao &= Chr(29) + Chr(107) + Chr(73) + Chr(110) + strChave & vbCrLf

            ''clsImprimir.Rodape(StringImpressao)

        ElseIf ImpressoraNFCe = "NORMAL" Then
            Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
            Try
                margins.bottomMargin = 350
                margins.leftMargin = 350
                margins.rightMargin = 350
                margins.topMargin = 350


                rptDoc.PrintOptions.ApplyPageMargins(margins)
            Catch ex As Exception

            End Try


            rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
            rptDoc.PrintToPrinter(1, False, 0, 0)
        ElseIf ImpressoraNFCe = "DARUMA" Then
            'Dim strCaminhoXmlSat As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\" & strChaveNfe & ".xml"
            'Dim iRetorno As Integer = clsDarumaSatDLL.iImprimirCFe_SAT_Daruma(strCaminhoXmlSat, "1")
        ElseIf ImpressoraNFCe = "EPSON" Then
            'strTraco = clsImprimir.Comp("------------------------------------------------")

            'Dim strEnd As String = strEnderecoEmitente
            'Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

            'StringImpressao = "<ce><b>" & strNomeEmitente & "</b></ce>" & vbCrLf
            'StringImpressao &= "<ce>" & strEnd & "</ce>" & vbCrLf
            'StringImpressao &= "<ce>" & strCNPJ & "</ce>" & vbCrLf
            'StringImpressao &= strTraco & vbCrLf

            'StringImpressao &= "<ce><b>" & "EXTRATO No." & "" & "</b></ce>" & vbCrLf
            'StringImpressao &= "<ce><b>" & "CUPOM FISCAL ELETRÔNICO - SAT" & "</b></ce>" & vbCrLf
            'StringImpressao &= strTraco & vbCrLf

            'If strDestinatario <> "" Then
            '    StringImpressao &= Dir(strDestinatario, 48)
            '    StringImpressao &= strTraco & vbCrLf
            'End If
            'StringImpressao &= clsImprimir.Comp("#|COD|DESC|QT|UN|VL UN R$|(VL TR R$)*|VL ITEM R$") & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            '' StringImpressao &= strStringProduto
            'StringImpressao &= vbCrLf

            '' StringImpressao &= "<b>" & Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            ''StringImpressao &= "<b>" & Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
            ''StringImpressao &= "<b>" & Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= vbCrLf
            ''StringImpressao &= "<b>" & strPagamento & "</b>"
            ' '' StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
            'StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
            'StringImpressao &= vbCrLf
            '' StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
            'StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
            'StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
            'StringImpressao &= strTraco & vbCrLf
            '' StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
            '' StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
            '' StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


            'iRetorno = clsEpson.IniciaPorta(PortaImpressoraNFCe)

            'iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

            'iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

            'iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

            ''iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

            'iRetorno = clsEpson.AcionaGuilhotina(1)

            'iRetorno = clsEpson.FechaPorta()

        ElseIf ImpressoraNFCe = "TERMICA" Then

            rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
            rptDoc.PrintToPrinter(1, False, 0, 0)

        ElseIf ImpressoraNFCe = "TERMICA MARGEM" Then

            Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
            Try
                margins.bottomMargin = 150
                margins.leftMargin = 180
                margins.rightMargin = 50
                margins.topMargin = 150


                rptDoc.PrintOptions.ApplyPageMargins(margins)
            Catch ex As Exception

            End Try
            rptDoc.PrintOptions.PrinterName = PortaImpressoraNFCe
            rptDoc.PrintToPrinter(1, False, 0, 0)

        End If
    End Function


    Public Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function

    Public Shared Function GerarCupomCancelamentoNFCe(ByVal parXML As String, ByVal parAssinatura As String)
        Dim rptDoc As New NFCe
        Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim dtCliente As DataTable
        Dim dtConfig As DataTable
        Dim dtBarra As DataTable
        Dim dtQrCodeCanc As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Produto")
        dt.Columns.Add("vProd")
        dt.Rows.Add()
        dt.Rows.Item(0).Item("Produto") = "TESTE"

        Dim intXML As Integer = parXML.Length
        Dim strChar As String = parXML.Substring(intXML - 1, 1)
        If strChar <> ">" Then
            parXML = parXML & ">"
        End If
        parXML = parXML.Replace("'", "")
        Dim dtNF As DataTable = ArquivoNfeXml(parXML, "/CFeCanc/infCFe", "Id Varchar(50) './@Id', chCanc Varchar(50) './@chCanc'", "")

        'parChave = dtNF.Rows.Item(0).Item("Id").ToString
        Dim strChave As String = dtNF.Rows.Item(0).Item("chCanc").ToString.Replace("CFe", "")
        Dim strChaveCanc As String = dtNF.Rows.Item(0).Item("Id").ToString.Replace("CFe", "")


        dtNF = ArquivoNfeXml(parXML, "/CFeCanc/infCFe", "dEmi varchar(20), hEmi varchar(20)", "")

        Dim strDataEmissao As String = dtNF.Rows.Item(0).Item("dEmi").ToString
        Dim strHoraEmissao As String = dtNF.Rows.Item(0).Item("hEmi").ToString

        dtNF = ArquivoNfeXml(parXML, "/CFeCanc/infCFe/ide", "nserieSAT Varchar(20), nCFe varchar(20), " & _
        "dEmi varchar(20), hEmi varchar(20), assinaturaQRCODE varchar(Max)", "")

        Dim strNumeroSerie As String = dtNF.Rows.Item(0).Item("nserieSAT").ToString

        Dim strNumeroCupom As String = dtNF.Rows.Item(0).Item("nCFe").ToString

        Dim strDataEmissaoCanc As String = dtNF.Rows.Item(0).Item("dEmi").ToString
        Dim strHoraEmissaoCanc As String = dtNF.Rows.Item(0).Item("hEmi").ToString
        Dim strAssinaturaCanc As String = dtNF.Rows.Item(0).Item("assinaturaQRCODE").ToString

        dtNF = ArquivoNfeXml(parXML, "/CFeCanc/infCFe/emit/enderEmit", "CNPJ Varchar(20) '../CNPJ', " & _
        "xNome varchar(150) '../xNome', IE varchar(20) '../IE', xLgr varchar(100), nro varchar(20), " & _
        "xBairro varchar(60), xMun varchar(80), CEP varchar(20)", "")

        Dim strCNPJEmitente As String = dtNF.Rows.Item(0).Item("CNPJ").ToString
        Dim strNomeEmitente As String = dtNF.Rows.Item(0).Item("xNome").ToString
        Dim strIEEmitente As String = dtNF.Rows.Item(0).Item("IE").ToString
        Dim strEnderecoEmitente As String = dtNF.Rows.Item(0).Item("xLgr").ToString
        Dim strNumeroEmitente As String = dtNF.Rows.Item(0).Item("nro").ToString
        Dim strBairroEmitente As String = dtNF.Rows.Item(0).Item("xBairro").ToString
        Dim strCidadeEmitente As String = dtNF.Rows.Item(0).Item("xMun").ToString
        Dim strCEPEmitente As String = dtNF.Rows.Item(0).Item("CEP").ToString


        'rptDoc.PageHeaderSection1.SectionFormat.EnableSuppress = True


        TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
        TextObjects(0).Text = strNomeEmitente

        TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
        TextObjects(1).Text = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

        TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
        TextObjects(2).Text = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

        TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtExtrato")
        TextObjects(3).Text = "EXTRATO No." & strNumeroCupom


        dtNF = ArquivoNfeXml(parXML, "/CFeCanc/infCFe/dest", "CNPJ Varchar(20), " & _
        "CPF varchar(20)", "")

        Dim strCPFDestinatario As String = dtNF.Rows.Item(0).Item("CPF").ToString
        Dim strDestinatario As String = ""
        If strCPFDestinatario = "" Then
            strCPFDestinatario = dtNF.Rows.Item(0).Item("CNPJ").ToString
            If strCPFDestinatario <> "" Then
                strCPFDestinatario = AddPonto(strCPFDestinatario, "J")
            End If
        Else
            strCPFDestinatario = AddPonto(strCPFDestinatario, "F")
        End If
        If strCPFDestinatario <> "" Then
            TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtCPFCliente")
            TextObjects(4).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario

            strDestinatario = "CPF/CNPJ do consumidor: " & strCPFDestinatario

        Else

            'rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
            rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True

        End If




        rptDoc.PageHeaderSection4.SectionFormat.EnableSuppress = False
        rptDoc.PageHeaderSection7.SectionFormat.EnableSuppress = False
        rptDoc.ReportFooterSection9.SectionFormat.EnableSuppress = False

        'rptDoc.PageHeaderSection9.SectionFormat.EnableSuppress = True
        rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True
        rptDoc.PageHeaderSection8.SectionFormat.EnableSuppress = True
        rptDoc.Section3.SectionFormat.EnableSuppress = True
        rptDoc.Section4.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection1.SectionFormat.EnableSuppress = True
        rptDoc.ReportFooterSection3.SectionFormat.EnableSuppress = True

        dtNF = ArquivoNfeXml(parXML, "/CFeCanc/infCFe/total", "vCFe Varchar(10)", "")

        Dim dblValorTotal As Double = dtNF.Rows.Item(0).Item("vCFe").ToString.Replace(".", ",")

        TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtTotalCanc")
        TextObjects(5).Text = "TOTAL R$    " & dblValorTotal.ToString("0.00")


        Dim strNumSerie As String = strNumeroSerie.Substring(0, 3) & "." & strNumeroSerie.Substring(3, 3) & "." & strNumeroSerie.Substring(6, 3)
        TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtNumSerie")
        TextObjects(6).Text = "SAT No. " & strNumSerie

        Dim dtData As Date = strDataEmissao.Substring(0, 4) & "/" & strDataEmissao.Substring(4, 2) & "/" & strDataEmissao.Substring(6, 2)
        Dim strHora As String = strHoraEmissao.Substring(0, 2) & ":" & strHoraEmissao.Substring(2, 2) & ":" & strHoraEmissao.Substring(4, 2)

        TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtData")
        TextObjects(7).Text = Format(dtData, "dd/MM/yyyy") & " " & strHora

        Dim strChaveAcesso As String = strChave.Substring(0, 4) & " " & strChave.Substring(4, 4) & " " & strChave.Substring(8, 4) & " " & strChave.Substring(12, 4) & " " & strChave.Substring(16, 4) & " " & strChave.Substring(20, 4) & " " & strChave.Substring(24, 4) & " " & strChave.Substring(28, 4) & " " & strChave.Substring(32, 4) & " " & strChave.Substring(36, 4) & " " & strChave.Substring(40, 4)
        TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtChave")
        TextObjects(8).Text = strChaveAcesso

        Dim strQrCode As String = strChave & "|" & strDataEmissao & strHoraEmissao & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & parAssinatura




        TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtNumSerie2")
        TextObjects(9).Text = "SAT No. " & strNumSerie

        Dim dtDataCanc As Date = strDataEmissaoCanc.Substring(0, 4) & "/" & strDataEmissaoCanc.Substring(4, 2) & "/" & strDataEmissaoCanc.Substring(6, 2)
        Dim strHoraCanc As String = strHoraEmissaoCanc.Substring(0, 2) & ":" & strHoraEmissaoCanc.Substring(2, 2) & ":" & strHoraEmissaoCanc.Substring(4, 2)

        TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtData2")
        TextObjects(10).Text = Format(dtDataCanc, "dd/MM/yyyy") & " " & strHoraCanc

        Dim strChaveAcessoCanc As String = strChaveCanc.Substring(0, 4) & " " & strChaveCanc.Substring(4, 4) & " " & _
        strChaveCanc.Substring(8, 4) & " " & strChaveCanc.Substring(12, 4) & " " & strChaveCanc.Substring(16, 4) & " " & _
        strChaveCanc.Substring(20, 4) & " " & strChaveCanc.Substring(24, 4) & " " & strChaveCanc.Substring(28, 4) & " " & _
        strChaveCanc.Substring(32, 4) & " " & strChaveCanc.Substring(36, 4) & " " & strChaveCanc.Substring(40, 4)
        TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtChave2")
        TextObjects(11).Text = strChaveAcessoCanc


        If parAssinatura = "" Then
            rptDoc.PageHeaderSection4.ReportObjects.Item("Line9").ObjectFormat.EnableSuppress = True
            rptDoc.PageHeaderSection4.ReportObjects.Item("Line7").ObjectFormat.EnableSuppress = True
            rptDoc.PageHeaderSection7.SectionFormat.EnableSuppress = True
            ' rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
            rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True
            rptDoc.ReportFooterSection7.SectionFormat.EnableSuppress = True
            TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtDadosCancelamento1")
            TextObjects(12).Text = ""
        End If


        Dim strQrCodeCanc As String = strChaveCanc & "|" & strDataEmissaoCanc & strHoraEmissaoCanc & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & strAssinaturaCanc



        Dim picQrCode As New PictureBox
        picQrCode.Size = New System.Drawing.Size(104, 104)

        Dim qrcode As New QRCodeEncoder
        qrcode.QRCodeVersion = 16
        Dim qr As Bitmap = qrcode.Encode(strQrCode)
        picQrCode.Image = TryCast(qr, Image)

        Dim imagem As Byte() = converteimagem(picQrCode.Image)
        dtCliente = New DataTable
        dtCliente.Columns.Add(New DataColumn("Imagem", GetType(Byte())))
        dtCliente.Rows.Add()
        dtCliente.Rows.Item(0).Item("Imagem") = imagem

        Dim picQrCodeCanc As New PictureBox
        picQrCodeCanc.Size = New System.Drawing.Size(104, 104)

        Dim qrcodeCanc As New QRCodeEncoder
        qrcodeCanc.QRCodeVersion = 16
        Dim qrCanc As Bitmap = qrcodeCanc.Encode(strQrCodeCanc)
        picQrCodeCanc.Image = TryCast(qrCanc, Image)

        Dim imagemCanc As Byte() = converteimagem(picQrCodeCanc.Image)
        dtQrCodeCanc = New DataTable

        dtQrCodeCanc.Columns.Add(New DataColumn("Imagem1", GetType(Byte())))
        dtQrCodeCanc.Columns.Add(New DataColumn("Imagem2", GetType(Byte())))

        dtQrCodeCanc.Rows.Add()
        dtQrCodeCanc.Rows.Item(0).Item("Imagem2") = imagemCanc



        dtConfig = New DataTable
        Dim picLogo As New PictureBox
        picLogo.Size = New System.Drawing.Size(361, 104)
        picLogo.Image = LogoTipo
        If picLogo.Image Is Nothing = False Then
            dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
            dtConfig.Rows.Add()
            Dim bLogo As Byte() = converteimagem(picLogo.Image)
            dtConfig.Rows.Item(0).Item("Logo") = bLogo
        End If



        dtBarra = New DataTable
        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))
        dtBarra.Rows.Add()
        Dim intImagem As New PictureBox
        intImagem.Size = New System.Drawing.Size(361, 104)

        Dim BarcodeChave As New BarcodeLib.Barcode(strChave, BarcodeLib.TYPE.CODE128C)
        intImagem.Image = BarcodeChave.Encode(BarcodeLib.TYPE.CODE128C, strChave, 300, 150)
        Dim imgChave As Byte() = converteimagem(intImagem.Image)
        dtBarra.Rows.Item(0).Item("PlanoFundo") = imgChave




        Dim intImagemCanc As New PictureBox
        intImagemCanc.Size = New System.Drawing.Size(361, 104)

        Dim BarcodeChaveCanc As New BarcodeLib.Barcode(strChaveCanc, BarcodeLib.TYPE.CODE128C)
        intImagemCanc.Image = BarcodeChaveCanc.Encode(BarcodeLib.TYPE.CODE128C, strChaveCanc, 300, 150)
        Dim imgChaveCanc As Byte() = converteimagem(intImagemCanc.Image)
        dtQrCodeCanc.Rows.Item(0).Item("Imagem1") = imgChaveCanc



        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        dtCliente.TableName = "Cliente"
        dtQrCodeCanc.TableName = "Produto"

        dt.TableName = "ItensNfe"
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        ds.Tables.Add(dtCliente)
        ds.Tables.Add(dtQrCodeCanc)

        rptDoc.SetDataSource(ds)


        Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")
        If IO.Directory.Exists(CaminhoPastaSAT.Replace("Remessas", "Notas\Cancelamento")) = False Then
            IO.Directory.CreateDirectory(CaminhoPastaSAT.Replace("Remessas", "Notas\Cancelamento"))
        End If
        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = CaminhoPastaSAT.Replace("Remessas", "Notas\Cancelamento") & "\CFeCanc" & strChaveCanc & ".pdf"
            CrExportOptions = rptDoc.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rptDoc.Export()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Dim strPastaBackup As String = CaminhoPastaSAT.Replace("Remessas", "Backup") & "\" & CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "") & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00") & "\Cancelamento"

        If IO.Directory.Exists(strPastaBackup) = False Then
            IO.Directory.CreateDirectory(strPastaBackup)
        End If

        
        If IO.File.Exists(strPastaBackup & "\CFeCanc" & strChaveCanc & ".pdf") = False Then
            File.Copy(CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChaveCanc & "-procNfe.xml", strPastaBackup & "\CFeCanc" & strChaveCanc & "-procNfe.xml")

        End If

        If IO.File.Exists(strPastaBackup & "\CFeCanc" & strChaveCanc & ".pdf") = False Then
            File.Copy(CaminhoPastaSAT.Replace("Remessas", "Notas\Cancelamento") & "\CFeCanc" & strChaveCanc & ".pdf", strPastaBackup & "\CFeCanc" & strChaveCanc & ".pdf")

        End If




        If ModeloImpSAT = "MP-4200 TH" Then
            strTraco = clsImprimir.Comp("------------------------------------------------")

            Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
            Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
            StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
            StringImpressao &= strTraco & vbCrLf

            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & strNumeroCupom))) & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("CUPOM FISCAL ELETRÔNICO - SAT"))) & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("CANCELAMENTO"))) & vbCrLf





            iRetorno = clsBematech.IniciaPorta(NomeImpSAT)
            iRetorno = ConfiguraModeloImpressora(7)

            If parAssinatura <> "" Then
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("DADOS DO CUPOM FISCAL ELETRÔNICO CANCELADO"))) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If

                StringImpressao &= clsImprimir.Neg(Dir("TOTAL R$", 12) & Dir(dblValorTotal.ToString("####,##0.00"), 36)) & vbCrLf
                StringImpressao &= vbCrLf


                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf

                iRetorno = BematechTX(StringImpressao)


                iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

                iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



                iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
                iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)
                StringImpressao = ""
            End If


            StringImpressao &= strTraco & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("DADOS DO CUPOM FISCAL ELETRÔNICO DE CANCELAMENTO"))) & vbCrLf
            StringImpressao &= vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
            StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtDataCanc, "dd/MM/yyyy") & " " & strHoraCanc))) & vbCrLf
            iRetorno = BematechTX(StringImpressao)

            iRetorno = clsBematech.FormataTX(strChaveAcessoCanc, 1, 0, 0, 0, 0)

            iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)

            iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChaveCanc)
            iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCodeCanc)

            iRetorno = BematechTX(clsImprimir.Corte)

            iRetorno = clsBematech.FechaPorta()


        ElseIf ModeloImpSAT = "NORMAL" Then
            Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
            Try
                margins.bottomMargin = 350
                margins.leftMargin = 350
                margins.rightMargin = 350
                margins.topMargin = 350


                rptDoc.PrintOptions.ApplyPageMargins(margins)
            Catch ex As Exception

            End Try


            rptDoc.PrintOptions.PrinterName = NomeImpSAT
            rptDoc.PrintToPrinter(1, False, 0, 0)
        ElseIf ModeloImpSAT = "DARUMA" Then
            Dim strCaminhoXmlSat As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas\Cancelamento") & "\CFeCanc" & strChaveCanc & ".xml"
            Dim iRetorno As Integer = clsDarumaSatDLL.iImprimirCFe_SAT_Daruma(strCaminhoXmlSat, "2")

        ElseIf ModeloImpSAT = "EPSON" Then

            strTraco = clsImprimir.Comp("------------------------------------------------")

            Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
            Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente

            StringImpressao = "<ce><b>" & strNomeEmitente & "</b></ce>" & vbCrLf
            StringImpressao &= "<ce>" & strEnd & "</ce>" & vbCrLf
            StringImpressao &= "<ce>" & strCNPJ & "</ce>" & vbCrLf
            StringImpressao &= strTraco & vbCrLf
            StringImpressao &= "<ce><b>" & "EXTRATO No." & strNumeroCupom & "</b></ce>" & vbCrLf
            StringImpressao &= "<ce><b>" & "CUPOM FISCAL ELETRÔNICO - SAT" & "</b></ce>" & vbCrLf
            StringImpressao &= "<ce><b>" & "CANCELAMENTO" & "</b></ce>" & vbCrLf



            iRetorno = clsEpson.IniciaPorta(NomeImpSAT)

            If parAssinatura <> "" Then
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= "<ce><b>" & "DADOS DO CUPOM FISCAL ELETRÔNICO CANCELADO" & "</b></ce>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then
                    StringImpressao &= Dir(strDestinatario, 48)
                    StringImpressao &= strTraco & vbCrLf
                End If

                StringImpressao &= "<b>" & Dir("TOTAL R$", 12) & Dir(dblValorTotal.ToString("####,##0.00"), 36) & "</b>" & vbCrLf
                StringImpressao &= vbCrLf

                StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
                StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"

                iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

                iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

                iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

                iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)
                StringImpressao = ""
            End If



            StringImpressao &= strTraco & vbCrLf
            StringImpressao &= "<ce><b>" & "DADOS DO CUPOM FISCAL ELETRÔNICO DE CANCELAMENTO" & "</b></ce>" & vbCrLf & vbCrLf
            StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
            StringImpressao &= "<ce><b>" & Format(dtDataCanc, "dd/MM/yyyy") & " " & strHoraCanc & "</b></ce>" & vbCrLf & vbCrLf
            StringImpressao &= "<c><ce>" & strChaveAcessoCanc & "</ce></c>"
            iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

            iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

            iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChaveCanc)

            iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCodeCanc)

            iRetorno = clsEpson.AcionaGuilhotina(1)

            iRetorno = clsEpson.FechaPorta()

        Else
            rptDoc.PrintOptions.PrinterName = NomeImpSAT
            rptDoc.PrintToPrinter(1, False, 0, 0)
        End If








        Exit Function


        'frmBoleto.CrystalReportViewer1.ReportSource = rptDoc
        'frmBoleto.CrystalReportViewer1.ShowLastPage()
        'Dim intPageFinal As Integer = frmBoleto.CrystalReportViewer1.GetCurrentPageNumber
        'frmBoleto.intPageFinal = intPageFinal
        'frmBoleto.intPageAtual = 1
        'frmBoleto.CrystalReportViewer1.ShowFirstPage()
        'frmBoleto.lblPaginaAtual.Text = frmBoleto.lblPaginaAtual.Tag & "1"
        'frmBoleto.lblTotalPagina.Text = frmBoleto.lblTotalPagina.Tag & intPageFinal
        'frmBoleto.BarCheckItem6.Checked = True
        'frmBoleto.Show()
    End Function

End Class
