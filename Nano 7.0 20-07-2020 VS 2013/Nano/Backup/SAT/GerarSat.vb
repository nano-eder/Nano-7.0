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
Public Class GerarSat
    Public Shared Function ArquivoNfeXml(ByVal parArquivo As String, ByVal parTagsBloco As String, ByVal parTags As String, ByVal parWhere As String) As DataTable
        Dim strSelect As String = ""
        If parTags <> "" Then
            strSelect = "select * FROM Openxml(@i,'" & parTagsBloco & "',3)with(" & parTags & ")" & parWhere
        Else
            strSelect = "select * FROM Openxml(@i,'" & parTagsBloco & "',6)" & parWhere
        End If


        Dim parCmdSql As String
        Dim conexao As New SqlConnection(StringDeConexao.Replace(NomeDoBancoSql, "Master"))
        parCmdSql = "declare @xml_text varchar(max), @i INT" & vbCrLf & _
        "select @xml_text =N'" & parArquivo & "'" & vbCrLf & _
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
    Public Shared Function GerarCupomSat(ByVal parXML As String, ByRef parChave As String)

        Dim intXML As Integer = parXML.Length
        Dim strChar As String = parXML.Substring(intXML - 1, 1)
        If strChar <> ">" Then
            parXML = parXML & ">"
        End If

        parXML = parXML.Replace("'", "")

        Dim vetXML As Array = Split(parXML, "</CFe")
        parXML = vetXML(0) & "</CFe>"

        Dim dtNF As DataTable = ArquivoNfeXml(parXML, "/CFe/infCFe", "Id Varchar(50) './@Id'", "")

        parChave = dtNF.Rows.Item(0).Item("Id").ToString
        Dim strChave As String = dtNF.Rows.Item(0).Item("Id").ToString.Replace("CFe", "")

        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/ide", "nserieSAT Varchar(20), nCFe varchar(20), " & _
        "dEmi varchar(20), hEmi varchar(20), assinaturaQRCODE varchar(Max)", "")

        Dim strNumeroSerie As String = dtNF.Rows.Item(0).Item("nserieSAT").ToString
        Dim strNumeroCupom As String = dtNF.Rows.Item(0).Item("nCFe").ToString
        Dim strDataEmissao As String = dtNF.Rows.Item(0).Item("dEmi").ToString
        Dim strHoraEmissao As String = dtNF.Rows.Item(0).Item("hEmi").ToString
        Dim strAssinaturaQrCode As String = dtNF.Rows.Item(0).Item("assinaturaQRCODE").ToString

        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/emit/enderEmit", "CNPJ Varchar(20) '../CNPJ', " & _
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

        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/dest", "CNPJ Varchar(20), xNome varchar(150), " & _
        "CPF varchar(20)", "")

        Dim strCPFDestinatario As String = dtNF.Rows.Item(0).Item("CPF").ToString
        If strCPFDestinatario = "" Then
            strCPFDestinatario = dtNF.Rows.Item(0).Item("CNPJ").ToString
            If strCPFDestinatario <> "" Then
                strCPFDestinatario = AddPonto(strCPFDestinatario, "J")
            End If
        Else
            strCPFDestinatario = AddPonto(strCPFDestinatario, "F")
        End If
        Dim strDestinatario As String = ""
        If strCPFDestinatario <> "" Then
            strDestinatario = "CPF/CNPJ do consumidor: " & strCPFDestinatario
        End If

        Dim dtNFProd As DataTable = ArquivoNfeXml(parXML, "/CFe/infCFe/det/prod", "nItem varchar(10) '../@nItem', " & _
        "cProd varchar(10), xProd varchar(100), uCom varchar(3), qCom varchar(10), " & _
        "vUnCom varchar(10), vProd varchar(10)", "")

        Dim I As Integer

        Dim strStringProduto As String = ""
        If GerarSATCrystal = False Then

            For I = 0 To dtNFProd.Rows.Count - 1
                Dim strCodigo As String = dtNFProd.Rows.Item(I).Item("nItem").ToString
                Dim strCodProduto As String = dtNFProd.Rows.Item(I).Item("cProd").ToString
                Dim strProduto As String = dtNFProd.Rows.Item(I).Item("xProd").ToString
                Dim strUM As String = dtNFProd.Rows.Item(I).Item("uCom").ToString
                Dim dblQtde As Double = dtNFProd.Rows.Item(I).Item("qCom").ToString.Replace(".", ",")
                Dim dblValUnit As Double = dtNFProd.Rows.Item(I).Item("vUnCom").ToString.Replace(".", ",")
                Dim dblTot As Double = dtNFProd.Rows.Item(I).Item("vProd").ToString.Replace(".", ",")

                Dim dtImp As DataTable = ArquivoNfeXml(parXML, "/CFe/infCFe/det/imposto", "nItem varchar(10) '../@nItem', " & _
                "vItem12741 varchar(10)", " where nItem = '" & strCodigo & "'")
                Dim strValorAproximado As String = dtImp.Rows.Item(0).Item("vItem12741").ToString
                Dim strItem As String = Format(CInt(strCodigo), "000") & " " & strCodProduto & " " & strProduto
                Dim strItem2 As String = dblQtde.ToString("0.0").Replace(",", ".") & " " & strUM & " X " & dblValUnit.ToString("0.00") & " " & "(" & strValorAproximado & ")"


                Dim intResul As Integer = strItem.Length + strItem2.Length
                Dim strVProd As String = dblTot.ToString("0.00")

                If intResul > 46 Then
                    If strItem.Length > 47 Then
                        strProduto = strItem.Substring(0, 47) & vbCrLf & strItem2
                    Else
                        strProduto = strItem & vbCrLf & strItem2
                    End If
                    strVProd = " " & vbCrLf & dblTot.ToString("0.00")
                Else
                    strProduto = strItem & " " & strItem2
                End If

                If ModeloImpSAT.Contains("ESC/POS") = True Then
                    Dim str As String = ""
                    If intResul > 47 Then
                        If strItem.Length > 47 Then
                            strProduto = strItem.Substring(0, 47)
                            str &= Dir(strProduto, 55) & vbCrLf
                            str &= Dir(strItem2, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                        Else
                            str &= Dir(strItem, 55) & vbCrLf
                            str &= Dir(strItem2, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                        End If
                    Else
                        strProduto = strItem & " " & strItem2
                        str &= Dir(strProduto, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                    End If
                    strStringProduto &= clsImprimir.Comp(str) & vbCrLf
                Else
                    If ModeloImpSAT = "MP-4200 TH" Or ModeloImpSAT = "EPSON" Then
                        Dim str As String = ""
                        If intResul > 40 Then
                            If strItem.Length > 41 Then
                                strProduto = strItem.Substring(0, 40)
                                str &= Dir(strProduto, 48) & vbCrLf
                                str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                            Else
                                str &= Dir(strItem, 48) & vbCrLf
                                str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                            End If
                        Else
                            strProduto = strItem & " " & strItem2
                            str &= Dir(strProduto, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                        End If
                        strStringProduto &= str & vbCrLf
                    End If
                End If

            Next

        End If
        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/total/ICMSTot", "vProd Varchar(10), vDesc varchar(10)", "")

        Dim dblValorProduto As Double = dtNF.Rows.Item(0).Item("vProd").ToString.Replace(".", ",")
        Dim dblValorDesconto As Double = dtNF.Rows.Item(0).Item("vDesc").ToString.Replace(".", ",")


        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/total/DescAcrEntr", "vDescSubtot Varchar(10)", "")
        If dtNF.Rows.Count > 0 Then
            dblValorDesconto = dtNF.Rows.Item(0).Item("vDescSubtot").ToString.Replace(".", ",")

        End If


        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/total", "vCFe Varchar(10), vCFeLei12741 varchar(10)", "")

        Dim dblValorTotal As Double = dtNF.Rows.Item(0).Item("vCFe").ToString.Replace(".", ",")
        Dim dblValorAproximado As Double = dtNF.Rows.Item(0).Item("vCFeLei12741").ToString.Replace(".", ",")

        Dim dtNFPag As DataTable = ArquivoNfeXml(parXML, "/CFe/infCFe/pgto/MP", "cMP varchar(10), vMP varchar(10)", "")
        Dim intPag As Integer = 0

        Dim strPagamento As String = ""
        Dim strValorPagamento As String = ""

        For I = 0 To dtNFPag.Rows.Count - 1
            Dim strPag As String = dtNFPag.Rows.Item(I).Item("cMP").ToString
            Dim dblValPag As Double = dtNFPag.Rows.Item(I).Item("vMP").ToString.Replace(".", ",")

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

            If ModeloImpSAT.Contains("ESC/POS") = True Then
                strPagamento &= Dir(strPag, 47) & Esq(dblValPag.ToString("####,##0.00"), 8) & vbCrLf
            Else
                strPagamento &= Dir(strPag, 40) & Esq(dblValPag.ToString("####,##0.00"), 8) & vbCrLf
            End If
        Next


        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/pgto", "vTroco varchar(10)", "")

        Dim dblTroco As Double = dtNF.Rows.Item(0).Item("vTroco").ToString.Replace(".", ",")

        Dim strNumSerie As String = strNumeroSerie.Substring(0, 3) & "." & strNumeroSerie.Substring(3, 3) & "." & strNumeroSerie.Substring(6, 3)

        Dim dtData As Date = strDataEmissao.Substring(0, 4) & "/" & strDataEmissao.Substring(4, 2) & "/" & strDataEmissao.Substring(6, 2)
        Dim strHora As String = strHoraEmissao.Substring(0, 2) & ":" & strHoraEmissao.Substring(2, 2) & ":" & strHoraEmissao.Substring(4, 2)

        Dim strChaveAcesso As String = strChave.Substring(0, 4) & " " & strChave.Substring(4, 4) & " " & strChave.Substring(8, 4) & " " & strChave.Substring(12, 4) & " " & strChave.Substring(16, 4) & " " & strChave.Substring(20, 4) & " " & strChave.Substring(24, 4) & " " & strChave.Substring(28, 4) & " " & strChave.Substring(32, 4) & " " & strChave.Substring(36, 4) & " " & strChave.Substring(40, 4)

        Dim strQrCode As String = strChave & "|" & strDataEmissao & strHoraEmissao & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & strAssinaturaQrCode

        dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/infAdic", "infCpl varchar(100)", "")
        Dim strInfCpl As String = ""
        If dtNF.Rows.Count > 0 Then
            strInfCpl = dtNF.Rows.Item(0).Item("infCpl").ToString
        End If


        If GerarSATCrystal = True Then
            Dim rptDoc As New SAT
            Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim dtCliente As DataTable
            Dim dtConfig As DataTable
            Dim dtBarra As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Produto")
            dt.Columns.Add("vProd")

            TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
            TextObjects(0).Text = strNomeEmitente

            TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
            TextObjects(1).Text = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

            TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
            TextObjects(2).Text = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente


            TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtExtrato")
            TextObjects(3).Text = "EXTRATO No." & strNumeroCupom
            If strCPFDestinatario <> "" Then
                TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtCPFCliente")
                TextObjects(4).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario

            Else
                rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
                rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True
            End If
            For I = 0 To dtNFProd.Rows.Count - 1
                Dim strCodigo As String = dtNFProd.Rows.Item(I).Item("nItem").ToString
                Dim strCodProduto As String = dtNFProd.Rows.Item(I).Item("cProd").ToString
                Dim strProduto As String = dtNFProd.Rows.Item(I).Item("xProd").ToString
                Dim strUM As String = dtNFProd.Rows.Item(I).Item("uCom").ToString
                Dim dblQtde As Double = dtNFProd.Rows.Item(I).Item("qCom").ToString.Replace(".", ",")
                Dim dblValUnit As Double = dtNFProd.Rows.Item(I).Item("vUnCom").ToString.Replace(".", ",")
                Dim dblTot As Double = dtNFProd.Rows.Item(I).Item("vProd").ToString.Replace(".", ",")

                Dim dtImp As DataTable = ArquivoNfeXml(parXML, "/CFe/infCFe/det/imposto", "nItem varchar(10) '../@nItem', " & _
                "vItem12741 varchar(10)", " where nItem = '" & strCodigo & "'")
                Dim strValorAproximado As String = dtImp.Rows.Item(0).Item("vItem12741").ToString

                dt.Rows.Add()


                Dim strItem As String = Format(CInt(strCodigo), "000") & " " & strCodProduto & " " & strProduto


                Dim strItem2 As String = dblQtde.ToString("0.0").Replace(",", ".") & " " & strUM & " X " & dblValUnit.ToString("0.00") & " " & "(" & strValorAproximado & ")"


                Dim intResul As Integer = strItem.Length + strItem2.Length
                Dim strVProd As String = dblTot.ToString("0.00")

                If intResul > 46 Then
                    If strItem.Length > 47 Then
                        strProduto = strItem.Substring(0, 47) & vbCrLf & strItem2
                    Else
                        strProduto = strItem & vbCrLf & strItem2
                    End If
                    strVProd = " " & vbCrLf & dblTot.ToString("0.00")
                Else
                    strProduto = strItem & " " & strItem2
                End If


                dt.Rows.Item(I).Item("Produto") = strProduto
                dt.Rows.Item(I).Item("vProd") = strVProd

            Next

            TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtTotalBruto")
            TextObjects(6).Text = dblValorProduto.ToString("0.00")



            TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtTotalDesconto")
            TextObjects(7).Text = dblValorDesconto.ToString("0.00")


            TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtTotal")
            TextObjects(8).Text = dblValorTotal.ToString("0.00")

            TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtValorAprox")
            TextObjects(9).Text = dblValorAproximado.ToString("0.00")


            For I = 0 To dtNFPag.Rows.Count - 1
                Dim strPag As String = dtNFPag.Rows.Item(I).Item("cMP").ToString
                Dim dblValPag As Double = dtNFPag.Rows.Item(I).Item("vMP").ToString.Replace(".", ",")

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


            Next

            TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtValorTroco")
            TextObjects(10).Text = dblTroco.ToString("0.00")

            If VersaoXmlSAT = "0.08" Then
                dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/obsFisco", "xTexto varchar(100)", "")

                If dtNF.Rows.Item(0).Item("xTexto").ToString <> "" Then
                    If dtNF.Rows.Item(0).Item("xTexto").ToString <> "xTexto1" Then
                        TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtFisco")
                        TextObjects(25).Text = dtNF.Rows.Item(0).Item("xTexto").ToString
                    End If
                End If
            Else
                dtNF = ArquivoNfeXml(parXML, "/CFe/infCFe/infAdic/obsFisco", "xTexto varchar(100)", "")

                If dtNF.Rows.Item(0).Item("xTexto").ToString <> "" Then
                    If dtNF.Rows.Item(0).Item("xTexto").ToString <> "xTexto1" Then
                        TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtFisco")
                        TextObjects(25).Text = dtNF.Rows.Item(0).Item("xTexto").ToString
                    End If
                End If
            End If
          




            TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtObservacao")
            TextObjects(11).Text = strInfCpl

            TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtNumSerie")
            TextObjects(12).Text = "SAT No. " & strNumSerie



            TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtData")
            TextObjects(13).Text = Format(dtData, "dd/MM/yyyy") & " " & strHora


            TextObjects(14) = rptDoc.Section1.ReportObjects.Item("txtChave")
            TextObjects(14).Text = strChaveAcesso

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


            Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")

            ' Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = CaminhoPastaSAT.Replace("Remessas", "Notas") & "\" & parChave & ".pdf"
            CrExportOptions = rptDoc.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rptDoc.Export()
            ' Catch ex As Exception
            ' MsgBox(ex.ToString)
            ' End Try

            Dim strPastaBackup As String = CaminhoPastaSAT.Replace("Remessas", "Backup") & "\" & CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "") & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00")

            If IO.Directory.Exists(strPastaBackup) = False Then
                IO.Directory.CreateDirectory(strPastaBackup)
            End If
            If IO.File.Exists(strPastaBackup & "\CFe" & strChave & ".pdf") = False Then
                File.Copy(CaminhoPastaSAT.Replace("Remessas", "Notas") & "\CFe" & strChave & ".pdf", strPastaBackup & "\CFe" & strChave & ".pdf")

            End If

            If ModeloImpSAT = "NORMAL" Then
                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                'Try
                margins.bottomMargin = 350
                margins.leftMargin = 350
                margins.rightMargin = 350
                margins.topMargin = 350


                rptDoc.PrintOptions.ApplyPageMargins(margins)
                'Catch ex As Exception

                'End Try


                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)
            ElseIf ModeloImpSAT = "TERMICA" Then

                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)

            ElseIf ModeloImpSAT = "TERMICA MARGEM" Then

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                'Try
                If CNPJEmpresa = "08462880000120" Then
                    margins.bottomMargin = 150
                    margins.leftMargin = 160
                    margins.rightMargin = 20
                    margins.topMargin = 150

                Else
                    margins.bottomMargin = 150
                    margins.leftMargin = 180
                    margins.rightMargin = 50
                    margins.topMargin = 150

                End If
             

                rptDoc.PrintOptions.ApplyPageMargins(margins)
                'Catch ex As Exception

                ' End Try
                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        Else
            If ModeloImpSAT = "MP-4200 TH" Then
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then

                End If
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & strNumeroCupom))) & vbCrLf
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
                StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(strInfCpl, 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
                iRetorno = clsBematech.IniciaPorta(NomeImpSAT)
                iRetorno = ConfiguraModeloImpressora(7)
                iRetorno = BematechTX(StringImpressao)

                iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

                iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



                iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
                iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

                iRetorno = BematechTX(clsImprimir.Corte)

                iRetorno = clsBematech.FechaPorta()


            ElseIf ModeloImpSAT = "DARUMA" Then
                Dim strCaminhoXmlSat As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\" & parChave & ".xml"
                Dim iRetorno As Integer = clsDarumaSatDLL.iImprimirCFe_SAT_Daruma(strCaminhoXmlSat, "1")
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
                StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(strInfCpl, 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
                StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


                iRetorno = clsEpson.IniciaPorta(NomeImpSAT)

                iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

                iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

                iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

                iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

                iRetorno = clsEpson.AcionaGuilhotina(1)

                iRetorno = clsEpson.FechaPorta()

            Else
                If ModeloImpSAT.Contains("ESC/POS") = True Then

                    If TemGaveta = True Then
                        clsImprimir.SendStringToPrinter(PortaImpressora, clsImprimir.AbreGaveta())
                    End If


                    'strTraco = clsImprimir.Comp("________________________________________________")
                    strTraco = "-------------------------------------------------------"

                    Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                    Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                    StringImpressao = clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strNomeEmitente)) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strEnd)) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strCNPJ)) & vbCrLf
                    StringImpressao &= strTraco & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT("EXTRATO No." & strNumeroCupom))) & vbCrLf
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
                    StringImpressao &= clsImprimir.NegSAT(Dir("Troco R$", 47) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                    StringImpressao &= strTraco & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT("OBSERVACOES DO CONTRIBUINTE")) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(Dir(strInfCpl, 55)) & vbCrLf
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



                End If

            End If

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
    Public Shared Function UnicodeStringToBytes(ByVal str As String) As Byte()

        Return System.Text.Encoding.Default.GetBytes(str)
    End Function
    Public Shared Function UnicodeBytesToString(ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Default.GetString(bytes)
    End Function
    Public Shared Function converteimagem(ByVal Imagem As System.Drawing.Image) As Byte()

        'Declare uma variável do Tipo MemoryStream

        Dim ms As New System.IO.MemoryStream()

        'Carrega o memory Stream

        Imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

        'retorna um array de bytes

        Return ms.ToArray()

    End Function
    Public Shared Function GerarCupomCancelamentoSat(ByVal parXML As String, ByVal parAssinatura As String)
        Dim rptDoc As New SAT
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

            rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
            rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True

        End If




        rptDoc.PageHeaderSection4.SectionFormat.EnableSuppress = False
        rptDoc.PageHeaderSection7.SectionFormat.EnableSuppress = False
        rptDoc.ReportFooterSection9.SectionFormat.EnableSuppress = False

        rptDoc.PageHeaderSection9.SectionFormat.EnableSuppress = True
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
            rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
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

    Public Shared Function GerarCupomSatAccess(ByVal parCaminhoXml As String, ByRef parChave As String)

        'Dim intXML As Integer = parXML.Length
        'Dim strChar As String = parXML.Substring(intXML - 1, 1)
        'If strChar <> ">" Then
        '    parXML = parXML & ">"
        'End If

        'parXML = parXML.Replace("'", "")

        'Dim vetXML As Array = Split(parXML, "</CFe")
        'parXML = vetXML(0) & "</CFe>"
        Dim parXML As String = ""

        Dim DS1 As New DataSet
        DS1.ReadXml(parCaminhoXml)
        Dim strChave As String = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(1).ColumnName).ToString.Replace("CFe", "")
        If strChave.Length < 20 Then
            strChave = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(2).ColumnName).ToString.Replace("CFe", "")
            If strChave.Length < 20 Then
                strChave = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(3).ColumnName).ToString.Replace("CFe", "")
                If strChave.Length < 20 Then
                    strChave = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(4).ColumnName).ToString.Replace("CFe", "")
                    If strChave.Length < 20 Then
                        strChave = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(5).ColumnName).ToString.Replace("CFe", "")
                        If strChave.Length < 20 Then
                            strChave = DS1.Tables(0).Rows(0)(DS1.Tables(0).Columns.Item(6).ColumnName).ToString.Replace("CFe", "")
                        End If
                    End If
                End If
            End If
        End If

        Dim oXML As System.Xml.XmlDocument = New System.Xml.XmlDocument
        Dim ns As System.Xml.XmlNamespaceManager = New System.Xml.XmlNamespaceManager(oXML.NameTable)
        Dim NodeRoot As System.Xml.XmlNode

        'ns.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe")
        oXML.Load(parCaminhoXml)
        Dim dtNF As DataTable

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/ide", ns)

        Dim strNumeroSerie As String = NodeRoot.Item("nserieSAT").InnerText
        Dim strNumeroCupom As String = NodeRoot.Item("nCFe").InnerText
        Dim strDataEmissao As String = NodeRoot.Item("dEmi").InnerText
        Dim strHoraEmissao As String = NodeRoot.Item("hEmi").InnerText
        Dim strAssinaturaQrCode As String = NodeRoot.Item("assinaturaQRCODE").InnerText

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/emit", ns)

        Dim strCNPJEmitente As String = NodeRoot.Item("CNPJ").InnerText
        Dim strNomeEmitente As String = NodeRoot.Item("xNome").InnerText
        Dim strIEEmitente As String = NodeRoot.Item("IE").InnerText

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/emit/enderEmit", ns)

        Dim strEnderecoEmitente As String = NodeRoot.Item("xLgr").InnerText
        Dim strNumeroEmitente As String = NodeRoot.Item("nro").InnerText
        Dim strBairroEmitente As String = NodeRoot.Item("xBairro").InnerText
        Dim strCidadeEmitente As String = NodeRoot.Item("xMun").InnerText
        Dim strCEPEmitente As String = NodeRoot.Item("CEP").InnerText

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/dest", ns)

        Dim strCPFDestinatario As String = ""
        Dim strNomeDestinatario As String = ""
        Try
            strCPFDestinatario = NodeRoot.Item("CPF").InnerText
        Catch ex As Exception
        End Try
        Try
            strNomeDestinatario = NodeRoot.Item("xNome").InnerText
        Catch ex As Exception
        End Try

        If strCPFDestinatario = "" Then
            Try
                strCPFDestinatario = NodeRoot.Item("CNPJ").InnerText
            Catch ex As Exception
            End Try

            If strCPFDestinatario <> "" Then
                strCPFDestinatario = AddPonto(strCPFDestinatario, "J")
            End If
        Else
            strCPFDestinatario = AddPonto(strCPFDestinatario, "F")
        End If
        Dim strDestinatario As String = ""
        If strCPFDestinatario <> "" Then
            If strNomeDestinatario <> "CONSUMIDOR" And strNomeDestinatario <> "" Then
                strDestinatario = "Consumidor: " & strNomeDestinatario & vbCrLf
            End If
            strDestinatario &= "CPF/CNPJ do consumidor: " & strCPFDestinatario
        End If



        NodeRoot = oXML.SelectSingleNode("CFe/infCFe", ns)


        Dim strStringProduto As String = ""
        If GerarSATCrystal = False Then
            Dim B As Integer = 1
            For Each outerNode1 As Xml.XmlNode In NodeRoot
                Select Case outerNode1.Name
                    Case "det"
                        Dim strCodigo As String = ""
                        Dim strCodProduto As String = ""
                        Dim strProduto As String = ""
                        Dim strUM As String = ""
                        Dim dblQtde As Double = 0
                        Dim dblValUnit As Double = 0
                        Dim dblTot As Double = 0

                        Dim strValorAproximado As String = ""

                        For Each outerNode As Xml.XmlNode In outerNode1.ChildNodes
                            If outerNode.Name = "prod" Then
                                For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                                    Select Case InnerNode2.Name
                                        Case "nItem"
                                            strCodigo = InnerNode2.InnerText
                                        Case "cProd"
                                            strCodProduto = InnerNode2.InnerText
                                        Case "xProd"
                                            strProduto = InnerNode2.InnerText
                                        Case "uCom"
                                            strUM = InnerNode2.InnerText
                                        Case "qCom"
                                            dblQtde = InnerNode2.InnerText.ToString.Replace(".", ",")
                                        Case "vUnCom"
                                            dblValUnit = InnerNode2.InnerText.ToString.Replace(".", ",")
                                        Case "vProd"
                                            dblTot = InnerNode2.InnerText.ToString.Replace(".", ",")
                                    End Select
                                Next
                            End If

                            If outerNode.Name = "imposto" Then
                                For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                                    Select Case InnerNode2.Name
                                        Case "vItem12741"
                                            strValorAproximado = InnerNode2.InnerText
                                    End Select
                                Next
                            End If


                        Next

                        Dim strItem As String = Format(CInt(B), "000") & " " & strCodProduto & " " & strProduto
                        Dim strItem2 As String = dblQtde.ToString("0.0").Replace(",", ".") & " " & strUM & " X " & dblValUnit.ToString("0.00") & " " & "(" & strValorAproximado & ")"

                        Dim intResul As Integer = strItem.Length + strItem2.Length
                        Dim strVProd As String = dblTot.ToString("0.00")

                        If intResul > 46 Then
                            If strItem.Length > 47 Then
                                strProduto = strItem.Substring(0, 47) & vbCrLf & strItem2
                            Else
                                strProduto = strItem & vbCrLf & strItem2
                            End If
                            strVProd = " " & vbCrLf & dblTot.ToString("0.00")
                        Else
                            strProduto = strItem & " " & strItem2
                        End If

                        If ModeloImpSAT.Contains("ESC/POS") = True Then
                            Dim str As String = ""
                            'If intResul > 47 Then
                            If strItem.Length > 47 Then
                                strProduto = strItem.Substring(0, 47)
                                Dim strProd2 As String = strItem.Substring(47, strItem.Length - 47)
                                If strProd2.Length > 47 Then
                                    strProd2 = strProd2.Substring(0, 47)
                                End If
                                str &= Dir(strProduto, 55) & vbCrLf
                                str &= Dir(strProd2, 55) & vbCrLf
                                str &= Dir(strItem2, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                            Else
                                str &= Dir(strItem, 55) & vbCrLf
                                str &= Dir(strItem2, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                            End If
                            'Else
                            '    strProduto = strItem & " " & strItem2
                            '    str &= Dir(strProduto, 47) & Esq(dblTot.ToString("####,##0.00"), 8)
                            'End If
                            strStringProduto &= clsImprimir.Comp(str) & vbCrLf
                        Else
                            If ModeloImpSAT = "MP-4200 TH" Or ModeloImpSAT = "EPSON" Then
                                Dim str As String = ""
                                'If intResul > 40 Then
                                If strItem.Length > 41 Then
                                    strProduto = strItem.Substring(0, 40)
                                    str &= Dir(strProduto, 48) & vbCrLf
                                    str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                                Else
                                    str &= Dir(strItem, 48) & vbCrLf
                                    str &= Dir(strItem2, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                                End If
                                'Else
                                '    strProduto = strItem & " " & strItem2
                                '    str &= Dir(strProduto, 40) & Esq(dblTot.ToString("####,##0.00"), 8)
                                'End If
                                strStringProduto &= str & vbCrLf
                            End If
                        End If
                        B += 1
                End Select
            Next
        End If

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/total/ICMSTot", ns)

        Dim dblValorProduto As Double = NodeRoot.Item("vProd").InnerText.ToString.Replace(".", ",")
        Dim dblValorDesconto As Double = NodeRoot.Item("vDesc").InnerText.ToString.Replace(".", ",")

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/total/DescAcrEntr", ns)
        If NodeRoot Is Nothing = False Then
            dblValorDesconto = NodeRoot.Item("vDescSubtot").InnerText.ToString.Replace(".", ",")
        End If

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/total", ns)

        Dim dblValorTotal As Double = NodeRoot.Item("vCFe").InnerText.ToString.Replace(".", ",")
        Dim dblValorAproximado As Double = NodeRoot.Item("vCFeLei12741").InnerText.ToString.Replace(".", ",")

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/pgto", ns)
        Dim strPagamento As String = ""
        Dim dblTroco As Double = 0
        If NodeRoot Is Nothing = False Then
            For Each outerNode As Xml.XmlNode In NodeRoot
                Select Case outerNode.Name
                    Case "MP"
                        Dim strPag As String = ""
                        Dim dblValPag As Double = 0

                        For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                            Select Case InnerNode2.Name
                                Case "cMP"
                                    strPag = InnerNode2.InnerText
                                Case "vMP"
                                    dblValPag = InnerNode2.InnerText.ToString.Replace(".", ",")

                            End Select
                        Next

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


                        If ModeloImpSAT.Contains("ESC/POS") = True Then
                            strPagamento &= Dir(strPag, 47) & Esq(dblValPag.ToString("####,##0.00"), 8) & vbCrLf
                        Else
                            strPagamento &= Dir(strPag, 40) & Esq(dblValPag.ToString("####,##0.00"), 8) & vbCrLf
                        End If
                    Case "vTroco"
                        dblTroco = outerNode.InnerText.ToString.Replace(".", ",")
                End Select
            Next
        End If


        Dim strNumSerie As String = strNumeroSerie.Substring(0, 3) & "." & strNumeroSerie.Substring(3, 3) & "." & strNumeroSerie.Substring(6, 3)

        Dim dtData As Date = strDataEmissao.Substring(0, 4) & "/" & strDataEmissao.Substring(4, 2) & "/" & strDataEmissao.Substring(6, 2)
        Dim strHora As String = strHoraEmissao.Substring(0, 2) & ":" & strHoraEmissao.Substring(2, 2) & ":" & strHoraEmissao.Substring(4, 2)
        Dim ddd As String = strChave
        Dim strChaveAcesso As String = strChave.Substring(0, 4) & " " & strChave.Substring(4, 4) & " " & strChave.Substring(8, 4) & " " & strChave.Substring(12, 4) & " " & strChave.Substring(16, 4) & " " & strChave.Substring(20, 4) & " " & strChave.Substring(24, 4) & " " & strChave.Substring(28, 4) & " " & strChave.Substring(32, 4) & " " & strChave.Substring(36, 4) & " " & strChave.Substring(40, 4)

        Dim strQrCode As String = strChave & "|" & strDataEmissao & strHoraEmissao & "|" & dblValorTotal.ToString("0.00").Replace(",", ".") & "|" & strCPFDestinatario & "|" & strAssinaturaQrCode

        NodeRoot = oXML.SelectSingleNode("CFe/infCFe/infAdic", ns)
        Dim strInfCpl As String = ""
        If NodeRoot Is Nothing = False Then
            strInfCpl = NodeRoot.Item("infCpl").InnerText
        End If

        If GerarSATCrystal = True Then
            Dim rptDoc As New SAT
            Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

            Dim dtCliente As DataTable
            Dim dtConfig As DataTable
            Dim dtBarra As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Produto")
            dt.Columns.Add("vProd")

            TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtRazaoEmitente")
            TextObjects(0).Text = strNomeEmitente

            TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtEnderecoEmitente")
            TextObjects(1).Text = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")

            TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCNPJ")
            TextObjects(2).Text = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente


            TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtExtrato")
            TextObjects(3).Text = "EXTRATO No." & strNumeroCupom
            If strCPFDestinatario <> "" Then
                TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtCPFCliente")
                TextObjects(4).Text = "CPF/CNPJ do consumidor: " & strCPFDestinatario

            Else
                rptDoc.PageHeaderSection2.SectionFormat.EnableSuppress = True
                rptDoc.PageHeaderSection5.SectionFormat.EnableSuppress = True
            End If
            NodeRoot = oXML.SelectSingleNode("CFe/infCFe", ns)

            Dim A As Integer
            For Each outerNode1 As Xml.XmlNode In NodeRoot
                Select Case outerNode1.Name
                    Case "det"
                        Dim strCodigo As String = ""
                        Dim strCodProduto As String = ""
                        Dim strProduto As String = ""
                        Dim strUM As String = ""
                        Dim dblQtde As Double = 0
                        Dim dblValUnit As Double = 0
                        Dim dblTot As Double = 0

                        Dim strValorAproximado As String = ""

                        For Each outerNode As Xml.XmlNode In outerNode1.ChildNodes
                            If outerNode.Name = "prod" Then
                                For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                                    Select Case InnerNode2.Name
                                        Case "nItem"
                                            strCodigo = InnerNode2.InnerText
                                        Case "cProd"
                                            strCodProduto = InnerNode2.InnerText
                                        Case "xProd"
                                            strProduto = InnerNode2.InnerText
                                        Case "uCom"
                                            strUM = InnerNode2.InnerText
                                        Case "qCom"
                                            dblQtde = InnerNode2.InnerText.ToString.Replace(".", ",")
                                        Case "vUnCom"
                                            dblValUnit = InnerNode2.InnerText.ToString.Replace(".", ",")
                                        Case "vProd"
                                            dblTot = InnerNode2.InnerText.ToString.Replace(".", ",")
                                    End Select
                                Next
                            End If

                            If outerNode.Name = "imposto" Then
                                For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                                    Select Case InnerNode2.Name
                                        Case "vItem12741"
                                            strValorAproximado = InnerNode2.InnerText
                                    End Select
                                Next
                            End If


                        Next
                        dt.Rows.Add()


                        Dim strItem As String = Format(CInt(A + 1), "000") & " " & strCodProduto & " " & strProduto


                        Dim strItem2 As String = dblQtde.ToString("0.0").Replace(",", ".") & " " & strUM & " X " & dblValUnit.ToString("0.00") & " " & "(" & strValorAproximado & ")"


                        Dim intResul As Integer = strItem.Length + strItem2.Length
                        Dim strVProd As String = dblTot.ToString("0.00")

                        If intResul > 46 Then
                            If strItem.Length > 47 Then
                                strProduto = strItem.Substring(0, 47) & vbCrLf & strItem2
                            Else
                                strProduto = strItem & vbCrLf & strItem2
                            End If
                            strVProd = " " & vbCrLf & dblTot.ToString("0.00")
                        Else
                            strProduto = strItem & " " & strItem2
                        End If


                        dt.Rows.Item(A).Item("Produto") = strProduto
                        dt.Rows.Item(A).Item("vProd") = strVProd
                        A += 1
                End Select
            Next

            TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtTotalBruto")
            TextObjects(6).Text = dblValorProduto.ToString("0.00")



            TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtTotalDesconto")
            TextObjects(7).Text = dblValorDesconto.ToString("0.00")


            TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtTotal")
            TextObjects(8).Text = dblValorTotal.ToString("0.00")

            TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtValorAprox")
            TextObjects(9).Text = dblValorAproximado.ToString("0.00")

            NodeRoot = oXML.SelectSingleNode("CFe/infCFe/pgto", ns)
            Dim I As Integer
            If NodeRoot Is Nothing = False Then
                For Each outerNode As Xml.XmlNode In NodeRoot
                    Select Case outerNode.Name
                        Case "MP"
                            Dim strPag As String = ""
                            Dim dblValPag As Double = 0

                            For Each InnerNode2 As Xml.XmlNode In outerNode.ChildNodes
                                Select Case InnerNode2.Name
                                    Case "cMP"
                                        strPag = InnerNode2.InnerText
                                    Case "vMP"
                                        dblValPag = InnerNode2.InnerText.ToString.Replace(".", ",")

                                End Select
                            Next

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
                            I += 1
                        Case "vTroco"
                            dblTroco = outerNode.InnerText.ToString.Replace(".", ",")
                    End Select
                Next
            End If

            TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtValorTroco")
            TextObjects(10).Text = dblTroco.ToString("0.00")



            If VersaoXmlSAT = "0.08" Then
                NodeRoot = oXML.SelectSingleNode("CFe/infCFe/obsFisco", ns)


                If NodeRoot Is Nothing = False Then
                    If NodeRoot.Item("xTexto").InnerText <> "" Then
                        If NodeRoot.Item("xTexto").InnerText <> "xTexto1" Then
                            TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtFisco")
                            TextObjects(25).Text = NodeRoot.Item("xTexto").InnerText
                        End If
                    End If
                End If
            Else

                NodeRoot = oXML.SelectSingleNode("CFe/infCFe/infAdic/obsFisco", ns)


                If NodeRoot Is Nothing = False Then
                    If NodeRoot.Item("xTexto").InnerText <> "" Then
                        If NodeRoot.Item("xTexto").InnerText <> "xTexto1" Then
                            TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtFisco")
                            TextObjects(25).Text = NodeRoot.Item("xTexto").InnerText
                        End If
                    End If
                End If
            End If

            TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtObservacao")
            TextObjects(11).Text = strInfCpl

            TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtNumSerie")
            TextObjects(12).Text = "SAT No. " & strNumSerie

            TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtData")
            TextObjects(13).Text = Format(dtData, "dd/MM/yyyy") & " " & strHora

            TextObjects(14) = rptDoc.Section1.ReportObjects.Item("txtChave")
            TextObjects(14).Text = strChaveAcesso

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

            Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")

            ' Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = CaminhoPastaSAT.Replace("Remessas", "Notas") & "\CFe" & strChave & ".pdf"
            CrExportOptions = rptDoc.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rptDoc.Export()
            ' Catch ex As Exception
            ' MsgBox(ex.ToString)
            ' End Try

            Dim strPastaBackup As String = CaminhoPastaSAT.Replace("Remessas", "Backup") & "\" & CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "") & "\" & Date.Today.Year & "\" & Format(CInt(Date.Today.Month), "00")

            If IO.Directory.Exists(strPastaBackup) = False Then
                IO.Directory.CreateDirectory(strPastaBackup)
            End If
            If IO.File.Exists(strPastaBackup & "\CFe" & strChave & ".pdf") = False Then
                File.Copy(CaminhoPastaSAT.Replace("Remessas", "Notas") & "\CFe" & strChave & ".pdf", strPastaBackup & "\CFe" & strChave & ".pdf")

            End If

            If ModeloImpSAT = "NORMAL" Then
                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                'Try
                margins.bottomMargin = 350
                margins.leftMargin = 350
                margins.rightMargin = 350
                margins.topMargin = 350


                rptDoc.PrintOptions.ApplyPageMargins(margins)

                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)
            ElseIf ModeloImpSAT = "TERMICA" Then

                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)

            ElseIf ModeloImpSAT = "TERMICA MARGEM" Then

                Dim margins As PageMargins = rptDoc.PrintOptions.PageMargins
                'Try
                If CNPJEmpresa = "08462880000120" Then
                    margins.bottomMargin = 150
                    margins.leftMargin = 160
                    margins.rightMargin = 20
                    margins.topMargin = 150

                Else
                    margins.bottomMargin = 150
                    margins.leftMargin = 180
                    margins.rightMargin = 50
                    margins.topMargin = 150

                End If


                rptDoc.PrintOptions.ApplyPageMargins(margins)
                'Catch ex As Exception

                ' End Try
                rptDoc.PrintOptions.PrinterName = NomeImpSAT
                rptDoc.PrintToPrinter(1, False, 0, 0)
            End If
        Else
            If ModeloImpSAT = "MP-4200 TH" Then
                strTraco = clsImprimir.Comp("------------------------------------------------")

                Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                StringImpressao = clsImprimir.Comp(clsImprimir.Centralizar(strNomeEmitente)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strEnd)) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(strCNPJ)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                If strDestinatario <> "" Then

                End If
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("EXTRATO No." & strNumeroCupom))) & vbCrLf
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
                StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(strInfCpl, 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
                StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
                iRetorno = clsBematech.IniciaPorta(NomeImpSAT)
                iRetorno = ConfiguraModeloImpressora(7)
                iRetorno = BematechTX(StringImpressao)

                iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

                iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



                iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
                iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

                iRetorno = BematechTX(clsImprimir.Corte)

                iRetorno = clsBematech.FechaPorta()


            ElseIf ModeloImpSAT = "DARUMA" Then
                Dim strCaminhoXmlSat As String = CaminhoPastaSAT.Replace("Remessas", "Autorizadas") & "\" & parChave & ".xml"
                Dim iRetorno As Integer = clsDarumaSatDLL.iImprimirCFe_SAT_Daruma(strCaminhoXmlSat, "1")
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
                StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
                StringImpressao &= Dir(strInfCpl, 48) & vbCrLf
                StringImpressao &= vbCrLf
                StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
                StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
                StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
                StringImpressao &= strTraco & vbCrLf
                StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
                StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
                StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


                iRetorno = clsEpson.IniciaPorta(NomeImpSAT)

                iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

                iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

                iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

                iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

                iRetorno = clsEpson.AcionaGuilhotina(1)

                iRetorno = clsEpson.FechaPorta()

            Else
                If ModeloImpSAT.Contains("ESC/POS") = True Then

                    If TemGaveta = True Then
                        clsImprimir.SendStringToPrinter(PortaImpressora, clsImprimir.AbreGaveta())
                    End If


                    'strTraco = clsImprimir.Comp("________________________________________________")
                    strTraco = "-------------------------------------------------------"

                    Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
                    Dim strCNPJ As String = "CNPJ: " & AddPonto(strCNPJEmitente, "J") & "  IE: " & strIEEmitente
                    StringImpressao = clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strNomeEmitente)) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strEnd)) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(strCNPJ)) & vbCrLf
                    StringImpressao &= strTraco & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT(clsImprimir.NegSAT("EXTRATO No." & strNumeroCupom))) & vbCrLf
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
                    StringImpressao &= clsImprimir.NegSAT(Dir("Troco R$", 47) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
                    StringImpressao &= strTraco & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(clsImprimir.CentralizarSAT("OBSERVACOES DO CONTRIBUINTE")) & vbCrLf
                    StringImpressao &= clsImprimir.CompSAT(Dir(strInfCpl, 55)) & vbCrLf
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



                End If

            End If

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
