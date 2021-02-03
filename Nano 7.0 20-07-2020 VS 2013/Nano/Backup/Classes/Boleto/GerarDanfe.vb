Imports System
Imports System.Data
Imports System.Data.sql
Imports System.Data.SqlClient
Imports Nano.clsFuncoes
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization

Public Class GerarDanfe
    Dim strDigitoVerificador As String
    Public Shared Function GerarEvento(ByVal parCodigo As String, ByVal parAtualizado As Boolean)
        Dim rptDoc As New Boleto2
        Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim dtBarra As DataTable
        dtBarra = New DataTable

        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))

        Dim dtConfig As DataTable

        dtConfig = New DataTable
        Dim strNomeSacado As String = ""

        Dim dtBoleto As DataTable
        dtBoleto = New DataTable
        Dim dt As DataTable = DataTableOnline("SELECT Boleto.CodBanco, Boleto.CodCli, Boleto.CodFor, " & _
        "Boleto.NossoNumero, Boleto.PerMulta, Boleto.CodigoCarteira, Boleto.Especie, Boleto.Instrucao, " & _
        "Boleto.TipoAceite, Boleto.ValorMora, Boleto.CodigoBarras, Boleto.LinhaDigitavel, " & _
        "convert(Varchar(10),Boleto.Vencimento,103) as Vencimento, Boleto.Valor, convert(Varchar(10),Boleto.DataEmissao,103) as DataEmissao, Banco.CodigoCedente, " & _
        "Boleto.NumeroDocumento, Banco.NomeBanco, Banco.Cedente, Banco.CodigoBanco, " & _
        "Banco.CPF, Banco.Agencia, Banco.ContaCorrente, Boleto.DiasMora " & _
        "FROM Boleto left join Banco on Boleto.CodBanco = Banco.Codigo " & _
        "where Boleto.Codigo = " & parCodigo)

        Dim strEmailCliente As String = ""
        If dt.Rows.Count > 0 Then

            Dim strCodigoBanco As String = dt.Rows.Item(0).Item("CodigoBanco").ToString
            Dim strCedente As String = dt.Rows.Item(0).Item("Cedente").ToString
            Dim strCPF As String = dt.Rows.Item(0).Item("CPF").ToString
            Dim strDataEmissao As String = dt.Rows.Item(0).Item("DataEmissao").ToString
            Dim strEspecie As String = dt.Rows.Item(0).Item("Especie").ToString

            strEspecie = "DM"

            Dim strTipoAceite As String = dt.Rows.Item(0).Item("TipoAceite").ToString
            Dim strCodigoCarteira As String = dt.Rows.Item(0).Item("CodigoCarteira").ToString

            Dim strTipoCarteira As String = ""

            If strCodigoCarteira.Contains("SEM") = True Then
                strCodigoCarteira = "COBRANÇA SIMPLES CSR"
                strTipoCarteira = "102"
            Else
                strCodigoCarteira = "COBRANÇA SIMPLES ECR"
                strTipoCarteira = "101"
            End If

            Dim strAgencia As String = dt.Rows.Item(0).Item("Agencia").ToString
            Dim strCodigoCedente As String = dt.Rows.Item(0).Item("CodigoCedente").ToString
            Dim strContaCorrente As String = dt.Rows.Item(0).Item("ContaCorrente").ToString

            Dim strDiasMora As String = dt.Rows.Item(0).Item("DiasMora").ToString
            Dim strValorMora As String = dt.Rows.Item(0).Item("ValorMora").ToString
            Dim strPerMulta As String = dt.Rows.Item(0).Item("PerMulta").ToString
            Dim strInstrucao As String = ""
            Dim strInstrucao2 As String = ""
            If strValorMora <> "" Then
                Dim intDias As Integer = 0
                Dim strDias As String = "dia"
                If strDiasMora <> "" Then
                    intDias = strDiasMora
                    If intDias > 1 Then
                        strDias = "dias"
                    End If
                End If
                strInstrucao = "Após " & strDiasMora & " " & strDias & " Cobrar mora diária de R$: " & strValorMora
            End If

            If strPerMulta <> "" Then
                strInstrucao2 = "Cobrar " & strPerMulta & "% de multa após o vencimento."
            End If

            Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString
            Dim strCodFor As String = dt.Rows.Item(0).Item("CodFor").ToString
            Dim dtCli As DataTable = Nothing
            If strCodCli <> "NULL" And strCodCli <> "" Then
                Dim strRG As String = ""

                strRG = "RGIE"

                dtCli = DataTableOnline("SELECT Nome, " & strRG & ", CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, Email FROM Cliente where Codigo = " & strCodCli)
            Else
                If strCodFor <> "NULL" And strCodFor <> "" Then
                    dtCli = DataTableOnline("SELECT Nome, IE, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, Email FROM Fornecedor where Codigo = " & strCodFor)
                End If
            End If

            Dim strIstrucao3 As String = dt.Rows.Item(0).Item("Instrucao").ToString
            Dim strEnderecoSacado As String = ""
            Dim strBairroSacado As String = ""
            Dim strCepSacado As String = ""
            Dim strMunicipioSacado As String = ""
            Dim strUfSacado As String = ""
            Dim strCpfSacado As String = ""
            Dim strTipoCpfSacado As String = "01"
            Dim strNumeroSacado As String = ""
            If dtCli.Rows.Count > 0 Then

                strNomeSacado = dtCli.Rows.Item(0).Item("Nome").ToString

                strCpfSacado = dtCli.Rows.Item(0).Item("CPF").ToString
                If strCpfSacado.Contains("/") = True Then
                    strTipoCpfSacado = "02"
                End If
                strNumeroSacado = dtCli.Rows.Item(0).Item("Numero").ToString
                strEnderecoSacado = dtCli.Rows.Item(0).Item("Endereco").ToString
                strBairroSacado = dtCli.Rows.Item(0).Item("Bairro").ToString
                strCepSacado = dtCli.Rows.Item(0).Item("Cep").ToString
                strMunicipioSacado = dtCli.Rows.Item(0).Item("Cidade").ToString
                strUfSacado = dtCli.Rows.Item(0).Item("Estado").ToString
                strEmailCliente = dtCli.Rows.Item(0).Item("Email").ToString
            End If

            TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco")
            TextObjects(0).Text = strCodigoBanco & "-7"

            TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtLocalPagamento")
            TextObjects(1).Text = "Pagável em qualquer Banco até o vencimento"

            TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCedente")
            TextObjects(2).Text = strCedente

            TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtDataDocumento")
            TextObjects(3).Text = strDataEmissao

            TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtEspecieDocumento")
            TextObjects(4).Text = strEspecie

            TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtAceite")
            TextObjects(5).Text = strTipoAceite

            TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtDataProcessamento")
            TextObjects(6).Text = strDataEmissao

            TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtCarteira")
            TextObjects(7).Text = strCodigoCarteira

            TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtEspecie")
            TextObjects(8).Text = "R$"

            TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtQuantidade")
            TextObjects(9).Text = ""

            TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtValorQtd")
            TextObjects(10).Text = ""

            TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtAgencia")
            TextObjects(11).Text = strAgencia & "   " & strCodigoCedente

            TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtDesconto")
            TextObjects(12).Text = ""
            TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtAbatimento")
            TextObjects(13).Text = ""
            TextObjects(14) = rptDoc.Section1.ReportObjects.Item("txtMora")
            TextObjects(14).Text = ""
            TextObjects(15) = rptDoc.Section1.ReportObjects.Item("txtOutros")
            TextObjects(15).Text = ""
            TextObjects(16) = rptDoc.Section1.ReportObjects.Item("txtTotal")
            TextObjects(16).Text = ""


            TextObjects(17) = rptDoc.Section1.ReportObjects.Item("txtSacado")
            TextObjects(17).Text = strNomeSacado & "                          " & strCpfSacado
            TextObjects(18) = rptDoc.Section1.ReportObjects.Item("txtEndereco1")
            TextObjects(18).Text = strEnderecoSacado & ", " & strNumeroSacado & " - " & strBairroSacado

            TextObjects(19) = rptDoc.Section1.ReportObjects.Item("txtEndereco2")
            TextObjects(19).Text = strMunicipioSacado & " - " & strUfSacado & " CEP: " & strCepSacado


            TextObjects(20) = rptDoc.Section1.ReportObjects.Item("txtInstrucao")
            TextObjects(20).Text = strInstrucao


            TextObjects(21) = rptDoc.Section1.ReportObjects.Item("txtCedente1")
            TextObjects(21).Text = strCedente
            TextObjects(22) = rptDoc.Section1.ReportObjects.Item("txtCpfCedente")
            TextObjects(22).Text = strCPF
            TextObjects(23) = rptDoc.Section1.ReportObjects.Item("txtAgencia1")
            TextObjects(23).Text = strAgencia & "   " & strCodigoCedente
            TextObjects(24) = rptDoc.Section1.ReportObjects.Item("txtEspecie1")
            TextObjects(24).Text = "R$"
            TextObjects(25) = rptDoc.Section1.ReportObjects.Item("txtSacado1")
            TextObjects(25).Text = strNomeSacado
            TextObjects(26) = rptDoc.Section1.ReportObjects.Item("txtRazao")
            TextObjects(26).Text = "ERA SYSTEMS SOLUÇÕES EM SOFTWARE"
            TextObjects(27) = rptDoc.Section1.ReportObjects.Item("txtEndereco")
            TextObjects(27).Text = "Rua: 15 de Novembro, 949 - Sala 1 - Centro - Indaiatuba - SP"
            TextObjects(28) = rptDoc.Section1.ReportObjects.Item("txtTelefone")
            TextObjects(28).Text = "Fone: (19) 3318-3952 Email: contato@erasystems.com.br"
            TextObjects(28) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco1")
            TextObjects(28).Text = strCodigoBanco & "-7"

            TextObjects(29) = rptDoc.Section1.ReportObjects.Item("txtInstrucao2")
            TextObjects(29).Text = strInstrucao2


            TextObjects(32) = rptDoc.Section1.ReportObjects.Item("txtNomeSacado2")
            TextObjects(32).Text = strNomeSacado & "                          " & strCpfSacado

            TextObjects(33) = rptDoc.Section1.ReportObjects.Item("txtEnd2")
            TextObjects(33).Text = strEnderecoSacado & ", " & strNumeroSacado & "  " & strBairroSacado & " - " & strMunicipioSacado & " - " & strUfSacado & " CEP: " & strCepSacado

            TextObjects(34) = rptDoc.Section1.ReportObjects.Item("txtSacadoAssinatura")
            TextObjects(34).Text = strNomeSacado

            TextObjects(35) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco2")
            TextObjects(35).Text = strCodigoBanco & "-7"

            TextObjects(36) = rptDoc.Section1.ReportObjects.Item("txtAgencia2")
            TextObjects(36).Text = strAgencia & "   " & strCodigoCedente

            TextObjects(37) = rptDoc.Section1.ReportObjects.Item("txtEndBeneficiario")
            TextObjects(37).Text = "Rua: 15 de Novembro, 949 - Sala 1 - Centro - Indaiatuba - SP"

            ' If ReciboBoleto = False Then
            rptDoc.PageHeaderSection1.SectionFormat.EnableSuppress = True
            'End If


            Dim picLogo As New PictureBox

            picLogo.Size = New System.Drawing.Size(361, 104)


            If File.Exists(My.Application.Info.DirectoryPath & "\logosantander.jpg") = True Then
                picLogo.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\logosantander.jpg")

            End If


            If picLogo.Image Is Nothing = False Then
                dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
                dtConfig.Rows.Add()

                Dim bLogo As Byte() = converteimagem(picLogo.Image)

                dtConfig.Rows.Item(0).Item("Logo") = bLogo
            End If


            Dim picLogo2 As New PictureBox

            picLogo2.Size = New System.Drawing.Size(361, 104)


            If File.Exists(My.Application.Info.DirectoryPath & "\logo.png") = True Then
                picLogo2.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\logo.png")
            End If

            dtBarra.Rows.Add()
            If picLogo2.Image Is Nothing = False Then
                Dim bLogo As Byte() = converteimagem(picLogo2.Image)
                dtBarra.Rows.Item(0).Item("PlanoFundo") = bLogo
            End If

            dtBoleto.Columns.Add(New DataColumn("NumeroDocumento", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("Vencimento", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("Valor", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("NossoNumero", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("LinhaDigitavel", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("CodigoBarras", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("CodBarra", GetType(Byte())))
            dtBoleto.Columns.Add(New DataColumn("CodigoOcorrencia", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("PrimeiraInstrucao", GetType(String)))

            Dim vetCodigo As Array = Split(parCodigo, ",")
            Dim A As Integer
            For A = 0 To vetCodigo.Length - 1
                Dim strCod As String = vetCodigo(A)

                Dim dtBol As DataTable = DataTableOnline("SELECT NossoNumero, Convert(Varchar(10),Vencimento,103) as Vencimento, " & _
                "Valor, NumeroDocumento, CodigoBarras, LinhaDigitavel, Instrucao, Instrucao2 FROM Boleto where Codigo = " & strCod)

                If dtBol.Rows.Count > 0 Then
                    Dim strNumeroDocumento As String = dtBol.Rows.Item(0).Item("NumeroDocumento").ToString
                    Dim strVencimento As String = dtBol.Rows.Item(0).Item("Vencimento").ToString
                    Dim strValor As String = dtBol.Rows.Item(0).Item("Valor").ToString
                    Dim strNossoNumero As String = dtBol.Rows.Item(0).Item("NossoNumero").ToString
                    Dim strLinhaDigitavel As String = dtBol.Rows.Item(0).Item("LinhaDigitavel").ToString
                    Dim strCodigoBarras As String = dtBol.Rows.Item(0).Item("CodigoBarras").ToString
                    If parAtualizado = True Then
                        If CDate(strVencimento) < Date.Today Then

                            Dim culture As New CultureInfo("pt-BR")
                            Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                            Dim dia As Integer = DateTime.Now.Day
                            Dim ano As Integer = DateTime.Now.Year
                            Dim dtVenc As Date = strVencimento

                            Dim strVenc As String = dtVenc.AddDays(5)

                            Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(CDate(strVenc).DayOfWeek))

                            Dim dblValor As Double = strValor
                            If diasemana.Trim = "Sábado" Then
                                dtVenc = strVenc
                                strVencimento = dtVenc.AddDays(2)
                            ElseIf diasemana.Trim = "Domingo" Then
                                dtVenc = strVenc
                                strVencimento = dtVenc.AddDays(1)
                            End If


                            If CDate(strVencimento) < Date.Today Then

                                Dim intDias As Integer = DateDiff("d", CDate(strVencimento), Date.Today)
                                Dim dblValorMora As Double = strValorMora
                                Dim dblPerMulta As Double = strPerMulta

                                dblValorMora = (dblValor / 100) * dblValorMora
                                dblValorMora = dblValorMora * intDias
                                dblPerMulta = (dblValor / 100) * dblPerMulta

                                dblValor = dblValor + dblValorMora + dblPerMulta
                                strVencimento = Date.Today

                            End If


                            strValor = dblValor.ToString("0.00")
                            Dim strDigito As String = DigitoVerificador(strVencimento, strValor, strNossoNumero, strTipoCarteira)
                            'strCodigoBarras = CodigoBarra(strVencimento, strValor, strNossoNumero, strTipoCarteira)
                            strCodigoBarras = CodigoBarra(strVencimento, strValor, strNossoNumero, "", strAgencia.Substring(0, 4), strContaCorrente.Substring(0, 7))
                            strLinhaDigitavel = LinhaDigitavel(strVencimento, strValor, strNossoNumero, strTipoCarteira, strDigito, strCodigoBarras)
                        End If
                    End If
                    

                    Dim strIntrucaoBoleto As String = dtBol.Rows.Item(0).Item("Instrucao").ToString
                    Dim strIntrucaoBoleto2 As String = dtBol.Rows.Item(0).Item("Instrucao2").ToString
                    strNossoNumero = strNossoNumero.Substring(0, strNossoNumero.Length - 1) & "-" & strNossoNumero.Substring(strNossoNumero.Length - 1, 1)


                    Dim intImagem As New PictureBox

                    intImagem.Size = New System.Drawing.Size(300, 100)

                    Dim Barcode As New BarcodeLib.Barcode(strCodigoBarras, BarcodeLib.TYPE.Interleaved2of5)
                    intImagem.Image = Barcode.Encode(BarcodeLib.TYPE.Interleaved2of5, strCodigoBarras, 750, 200)



                    Dim imagem As Byte() = converteimagem(intImagem.Image)


                    dtBoleto.Rows.Add()
                    dtBoleto.Rows.Item(A).Item("NumeroDocumento") = strNumeroDocumento
                    dtBoleto.Rows.Item(A).Item("Vencimento") = strVencimento
                    dtBoleto.Rows.Item(A).Item("Valor") = strValor
                    dtBoleto.Rows.Item(A).Item("NossoNumero") = strNossoNumero
                    dtBoleto.Rows.Item(A).Item("LinhaDigitavel") = strLinhaDigitavel
                    dtBoleto.Rows.Item(A).Item("CodigoBarras") = strCodigoBarras
                    dtBoleto.Rows.Item(A).Item("CodBarra") = imagem
                    dtBoleto.Rows.Item(A).Item("CodigoOcorrencia") = strIntrucaoBoleto
                    dtBoleto.Rows.Item(A).Item("PrimeiraInstrucao") = strIntrucaoBoleto2
                End If
            Next



        End If

        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        dtBoleto.TableName = "Boleto"
        Dim ds As New DataSet

        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        ds.Tables.Add(dtBoleto)
        rptDoc.SetDataSource(ds)

        Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")
        'Try
        '    Dim CrExportOptions As ExportOptions
        '    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        '    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        '    CrDiskFileDestinationOptions.DiskFileName = PastaBoleto & "\Boleto\" & strNomeSacado & strDataBoleto & ".pdf"
        '    CrExportOptions = rptDoc.ExportOptions
        '    With CrExportOptions
        '        .ExportDestinationType = ExportDestinationType.DiskFile
        '        .ExportFormatType = ExportFormatType.PortableDocFormat
        '        .DestinationOptions = CrDiskFileDestinationOptions
        '        .FormatOptions = CrFormatTypeOptions
        '    End With
        '    rptDoc.Export()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        frmBoleto.strEmailCliente = strEmailCliente
        'frmBoleto.strCaminho(0) = PastaBoleto & "\Boleto\" & strNomeSacado & strDataBoleto & ".pdf"
        frmBoleto.CrystalReportViewer1.ReportSource = rptDoc
        frmBoleto.CrystalReportViewer1.ShowLastPage()
        Dim intPageFinal As Integer = frmBoleto.CrystalReportViewer1.GetCurrentPageNumber
        frmBoleto.intPageFinal = intPageFinal
        frmBoleto.intPageAtual = 1
        frmBoleto.CrystalReportViewer1.ShowFirstPage()
        frmBoleto.lblPaginaAtual.Text = frmBoleto.lblPaginaAtual.Tag & "1"
        frmBoleto.lblTotalPagina.Text = frmBoleto.lblTotalPagina.Tag & intPageFinal
        frmBoleto.BarCheckItem6.Checked = True
        frmBoleto.Show()

        Return Nothing
    End Function
    Public Shared Function GerarBoletoBradesco(ByVal parCodigo As String, ByVal parAtualizado As Boolean)
        Dim rptDoc As New Boleto2
        Dim TextObjects(38) As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim dtBarra As DataTable
        dtBarra = New DataTable

        dtBarra.Columns.Add(New DataColumn("PlanoFundo", GetType(Byte())))

        Dim dtConfig As DataTable

        dtConfig = New DataTable
        Dim strNomeSacado As String = ""

        Dim dtBoleto As DataTable
        dtBoleto = New DataTable
        StringOnline = Decrypt("RGF0YSBTb3VyY2U9MzUuMTk5LjExMy4xMTU7SW5pdGlhbCBDYXRhbG9nPWRiRXJhU3lzdGVtcztVc2VyIElEPXNhO1Bhc3N3b3JkPU5AbjA=")

        Dim dt As DataTable = DataTableOnline("SELECT Boleto.CodBanco, Boleto.CodCli, Boleto.CodFor, " & _
        "Boleto.NossoNumero, Boleto.PerMulta, Boleto.CodigoCarteira, Boleto.Especie, Boleto.Instrucao, " & _
        "Boleto.TipoAceite, Banco.ValorMora, Boleto.CodigoBarras, Boleto.LinhaDigitavel, " & _
        "convert(Varchar(10),Boleto.Vencimento,103) as Vencimento, Boleto.Valor, convert(Varchar(10),Boleto.DataEmissao,103) as DataEmissao, Banco.CodigoCedente, " & _
        "Boleto.NumeroDocumento, Banco.NomeBanco, Banco.Cedente, Banco.CodigoBanco, " & _
        "Banco.CPF, Banco.Agencia, Banco.ContaCorrente, Boleto.DiasMora " & _
        "FROM Boleto left join Banco on Boleto.CodBanco = Banco.Codigo " & _
        "where Boleto.Codigo = " & parCodigo)

        StringOnline = Decrypt("RGF0YSBTb3VyY2U9MzUuMTk5LjExMy4xMTU7SW5pdGlhbCBDYXRhbG9nPWRiRXJhU3lzdGVtcztVc2VyIElEPWVyYTtQYXNzd29yZD1lZDMyMjM=")

        Dim strEmailCliente As String = ""
        If dt.Rows.Count > 0 Then

            Dim strCodigoBanco As String = dt.Rows.Item(0).Item("CodigoBanco").ToString
            Dim strCedente As String = dt.Rows.Item(0).Item("Cedente").ToString
            Dim strCPF As String = dt.Rows.Item(0).Item("CPF").ToString
            Dim strDataEmissao As String = dt.Rows.Item(0).Item("DataEmissao").ToString
            Dim strEspecie As String = dt.Rows.Item(0).Item("Especie").ToString

            strEspecie = "DM"

            Dim strTipoAceite As String = dt.Rows.Item(0).Item("TipoAceite").ToString
            Dim strCodigoCarteira As String = dt.Rows.Item(0).Item("CodigoCarteira").ToString

            If strCodigoCarteira.Contains("SEM") = True Then
                strCodigoCarteira = "06"
            Else
                strCodigoCarteira = "09"
            End If

            Dim strAgencia As String = dt.Rows.Item(0).Item("Agencia").ToString
            Dim strCodigoCedente As String = dt.Rows.Item(0).Item("CodigoCedente").ToString

            Dim strContaCorrente As String = dt.Rows.Item(0).Item("ContaCorrente").ToString
            Dim strDiasMora As String = dt.Rows.Item(0).Item("DiasMora").ToString
            Dim strValorMora As String = dt.Rows.Item(0).Item("ValorMora").ToString
            Dim strPerMulta As String = dt.Rows.Item(0).Item("PerMulta").ToString
            Dim strInstrucao As String = ""
            Dim strInstrucao2 As String = ""
            If strValorMora <> "" Then
                Dim intDias As Integer = 0
                Dim strDias As String = "dia"
                If strDiasMora <> "" Then
                    intDias = strDiasMora
                    If intDias > 1 Then
                        strDias = "dias"
                    End If
                End If
                strInstrucao = "Após " & strDiasMora & " " & strDias & " Cobrar mora diária de " & strValorMora & "%"
            End If

            If strPerMulta <> "" Then
                strInstrucao2 = "Cobrar " & strPerMulta & "% de multa após o vencimento."
            End If

            Dim strCodCli As String = dt.Rows.Item(0).Item("CodCli").ToString
            Dim strCodFor As String = dt.Rows.Item(0).Item("CodFor").ToString

            Dim dtCli As DataTable = Nothing
            If strCodCli <> "NULL" And strCodCli <> "" Then
                dtCli = DataTableOnline("SELECT Nome, RGIE, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, Email FROM Cliente where Codigo = " & strCodCli)
            Else
                If strCodFor <> "NULL" And strCodFor <> "" Then
                    dtCli = DataTableOnline("SELECT Nome, IE, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, Email FROM Fornecedor where Codigo = " & strCodFor)
                End If
            End If

            Dim strIstrucao3 As String = dt.Rows.Item(0).Item("Instrucao").ToString
            Dim strEnderecoSacado As String = ""
            Dim strBairroSacado As String = ""
            Dim strCepSacado As String = ""
            Dim strMunicipioSacado As String = ""
            Dim strUfSacado As String = ""
            Dim strCpfSacado As String = ""
            Dim strTipoCpfSacado As String = "01"
            Dim strNumeroSacado As String = ""
            If dtCli.Rows.Count > 0 Then

                strNomeSacado = dtCli.Rows.Item(0).Item("Nome").ToString

                strCpfSacado = dtCli.Rows.Item(0).Item("CPF").ToString
                If strCpfSacado.Contains("/") = True Then
                    strTipoCpfSacado = "02"
                End If
                strNumeroSacado = dtCli.Rows.Item(0).Item("Numero").ToString
                strEnderecoSacado = dtCli.Rows.Item(0).Item("Endereco").ToString
                strBairroSacado = dtCli.Rows.Item(0).Item("Bairro").ToString
                strCepSacado = dtCli.Rows.Item(0).Item("Cep").ToString
                strMunicipioSacado = dtCli.Rows.Item(0).Item("Cidade").ToString
                strUfSacado = dtCli.Rows.Item(0).Item("Estado").ToString
                strEmailCliente = dtCli.Rows.Item(0).Item("Email").ToString
            End If

            TextObjects(0) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco")
            TextObjects(0).Text = strCodigoBanco & "-2"

            TextObjects(1) = rptDoc.Section1.ReportObjects.Item("txtLocalPagamento")
            TextObjects(1).Text = "Pagável preferencialmente na Rede Bradesco ou Bradesco Expresso"

            TextObjects(2) = rptDoc.Section1.ReportObjects.Item("txtCedente")
            TextObjects(2).Text = strCedente & " CNPJ: " & strCPF & " End.: " & EnderecoEmpresa

            TextObjects(3) = rptDoc.Section1.ReportObjects.Item("txtDataDocumento")
            TextObjects(3).Text = strDataEmissao

            TextObjects(4) = rptDoc.Section1.ReportObjects.Item("txtEspecieDocumento")
            TextObjects(4).Text = strEspecie

            TextObjects(5) = rptDoc.Section1.ReportObjects.Item("txtAceite")
            TextObjects(5).Text = strTipoAceite

            TextObjects(6) = rptDoc.Section1.ReportObjects.Item("txtDataProcessamento")
            TextObjects(6).Text = strDataEmissao

            TextObjects(7) = rptDoc.Section1.ReportObjects.Item("txtCarteira")
            TextObjects(7).Text = strCodigoCarteira

            TextObjects(8) = rptDoc.Section1.ReportObjects.Item("txtEspecie")
            TextObjects(8).Text = "R$"

            TextObjects(9) = rptDoc.Section1.ReportObjects.Item("txtQuantidade")
            TextObjects(9).Text = ""

            TextObjects(10) = rptDoc.Section1.ReportObjects.Item("txtValorQtd")
            TextObjects(10).Text = ""

            TextObjects(11) = rptDoc.Section1.ReportObjects.Item("txtAgencia")
            TextObjects(11).Text = strAgencia & "/" & strContaCorrente

            TextObjects(12) = rptDoc.Section1.ReportObjects.Item("txtDesconto")
            TextObjects(12).Text = ""
            TextObjects(13) = rptDoc.Section1.ReportObjects.Item("txtAbatimento")
            TextObjects(13).Text = ""
            TextObjects(14) = rptDoc.Section1.ReportObjects.Item("txtMora")
            TextObjects(14).Text = ""
            TextObjects(15) = rptDoc.Section1.ReportObjects.Item("txtOutros")
            TextObjects(15).Text = ""
            TextObjects(16) = rptDoc.Section1.ReportObjects.Item("txtTotal")
            TextObjects(16).Text = ""

            TextObjects(20) = rptDoc.Section1.ReportObjects.Item("txtInstrucao")
            TextObjects(20).Text = strInstrucao

            TextObjects(21) = rptDoc.Section1.ReportObjects.Item("txtCedente1")
            TextObjects(21).Text = strCedente
            TextObjects(22) = rptDoc.Section1.ReportObjects.Item("txtCpfCedente")
            TextObjects(22).Text = strCPF
            TextObjects(23) = rptDoc.Section1.ReportObjects.Item("txtAgencia1")
            TextObjects(23).Text = strAgencia & "/" & strContaCorrente
            TextObjects(24) = rptDoc.Section1.ReportObjects.Item("txtEspecie1")
            TextObjects(24).Text = "R$"

            TextObjects(26) = rptDoc.Section1.ReportObjects.Item("txtRazao")
            TextObjects(26).Text = strCedente
            TextObjects(27) = rptDoc.Section1.ReportObjects.Item("txtEndereco")
            TextObjects(27).Text = EnderecoEmpresa
            TextObjects(28) = rptDoc.Section1.ReportObjects.Item("txtTelefone")
            TextObjects(28).Text = "Tel.: (19) 3318-3952 E-mail: contato@erasystems.com.br"
            TextObjects(28) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco1")
            TextObjects(28).Text = strCodigoBanco & "-2"

            TextObjects(29) = rptDoc.Section1.ReportObjects.Item("txtInstrucao2")
            TextObjects(29).Text = strInstrucao2

            TextObjects(35) = rptDoc.Section1.ReportObjects.Item("txtCodigoBanco2")
            TextObjects(35).Text = strCodigoBanco & "-2"

            TextObjects(36) = rptDoc.Section1.ReportObjects.Item("txtAgencia2")
            TextObjects(36).Text = strAgencia & "/" & strContaCorrente

            TextObjects(37) = rptDoc.Section1.ReportObjects.Item("txtEndBeneficiario")
            TextObjects(37).Text = EnderecoEmpresa.ToUpper

            'If ReciboBoleto = False Then
            rptDoc.PageHeaderSection1.SectionFormat.EnableSuppress = True
            'End If

            Dim picLogo As New PictureBox

            picLogo.Size = New System.Drawing.Size(361, 104)


            If File.Exists("C:\NANOBoleto\Logo\logobradesco.jpg") = True Then
                picLogo.Image = System.Drawing.Bitmap.FromFile("C:\NANOBoleto\Logo\logobradesco.jpg")

            End If


            If picLogo.Image Is Nothing = False Then
                dtConfig.Columns.Add(New DataColumn("Logo", GetType(Byte())))
                dtConfig.Rows.Add()

                Dim bLogo As Byte() = converteimagem(picLogo.Image)

                dtConfig.Rows.Item(0).Item("Logo") = bLogo
            End If


            Dim picLogo2 As New PictureBox

            picLogo2.Size = New System.Drawing.Size(361, 104)

            picLogo2.Image = Global.Nano.My.Resources.Resources.logoEra2
            'If File.Exists("C:\NANOBoleto\Logo\logo.png") = True Then
            '    picLogo2.Image = System.Drawing.Bitmap.FromFile("C:\NANOBoleto\Logo\logo.png")
            'End If

            dtBarra.Rows.Add()
            If picLogo2.Image Is Nothing = False Then
                Dim bLogo As Byte() = converteimagem(picLogo2.Image)
                dtBarra.Rows.Item(0).Item("PlanoFundo") = bLogo
            End If

            dtBoleto.Columns.Add(New DataColumn("NumeroDocumento", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("Vencimento", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("Valor", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("NossoNumero", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("LinhaDigitavel", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("CodigoBarras", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("CodBarra", GetType(Byte())))
            dtBoleto.Columns.Add(New DataColumn("CodigoOcorrencia", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("PrimeiraInstrucao", GetType(String)))
            dtBoleto.Columns.Add(New DataColumn("TipoAceite", GetType(String)))

            dtBoleto.Columns.Add(New DataColumn("Especie", GetType(String)))

            dtBoleto.Columns.Add(New DataColumn("Status", GetType(String)))

            dtBoleto.Columns.Add(New DataColumn("CodigoCarteira", GetType(String)))

            dtBoleto.Columns.Add(New DataColumn("Instrucao", GetType(String)))

            dtBoleto.Columns.Add(New DataColumn("StatusRetorno", GetType(String)))


            Dim vetCodigo As Array = Split(parCodigo, ",")
            Dim A As Integer
            For A = 0 To vetCodigo.Length - 1
                Dim strCod As String = vetCodigo(A)

                Dim dtBol As DataTable = DataTableOnline("SELECT NossoNumero, Convert(Varchar(10),Vencimento,103) as Vencimento, " & _
                "Valor, NumeroDocumento, CodigoBarras, LinhaDigitavel, Instrucao, Instrucao2, CodCli, CodFor FROM Boleto where Codigo = " & strCod)

                If dtBol.Rows.Count > 0 Then
                    Dim strNumeroDocumento As String = dtBol.Rows.Item(0).Item("NumeroDocumento").ToString
                    Dim strVencimento As String = dtBol.Rows.Item(0).Item("Vencimento").ToString
                    Dim strValor As String = dtBol.Rows.Item(0).Item("Valor").ToString
                    Dim strNossoNumero As String = dtBol.Rows.Item(0).Item("NossoNumero").ToString
                    Dim strLinhaDigitavel As String = dtBol.Rows.Item(0).Item("LinhaDigitavel").ToString
                    Dim strCodigoBarras As String = dtBol.Rows.Item(0).Item("CodigoBarras").ToString

                    If parAtualizado = True Then
                        If CDate(strVencimento) < Date.Today Then

                            Dim culture As New CultureInfo("pt-BR")
                            Dim dtfi As DateTimeFormatInfo = culture.DateTimeFormat
                            Dim dia As Integer = DateTime.Now.Day
                            Dim ano As Integer = DateTime.Now.Year
                            Dim dtVenc As Date = strVencimento

                            Dim strVenc As String = dtVenc.AddDays(0)

                            Dim diasemana As String = culture.TextInfo.ToTitleCase(dtfi.GetDayName(CDate(strVenc).DayOfWeek))

                            Dim dblValor As Double = strValor
                            If diasemana.Trim = "Sábado" Then
                                dtVenc = strVenc
                                strVencimento = dtVenc.AddDays(2)
                            ElseIf diasemana.Trim = "Domingo" Then
                                dtVenc = strVenc
                                strVencimento = dtVenc.AddDays(1)
                            End If


                            If CDate(strVencimento) < Date.Today Then

                                Dim intDias As Integer = DateDiff("d", CDate(strVencimento), Date.Today)
                                Dim dblValorMora As Double = strValorMora
                                Dim dblPerMulta As Double = strPerMulta

                                dblValorMora = (dblValor / 100) * dblValorMora
                                dblValorMora = dblValorMora * intDias
                                dblPerMulta = (dblValor / 100) * dblPerMulta

                                dblValor = dblValor + dblValorMora + dblPerMulta
                                strVencimento = Date.Today

                            End If


                            strValor = dblValor.ToString("0.00")
                            Dim strDigito As String = DigitoVerificador(strVencimento, strValor, strNossoNumero, "")
                            'strCodigoBarras = CodigoBarra(strVencimento, strValor, strNossoNumero, "")
                            strCodigoBarras = CodigoBarra(strVencimento, strValor, strNossoNumero, "", strAgencia.Substring(0, 4), strContaCorrente.Substring(0, 7))
                            strLinhaDigitavel = LinhaDigitavel(strVencimento, strValor, strNossoNumero, "", strDigito, strCodigoBarras)
                        End If
                    End If

                    Dim strIntrucaoBoleto As String = dtBol.Rows.Item(0).Item("Instrucao").ToString
                    Dim strIntrucaoBoleto2 As String = dtBol.Rows.Item(0).Item("Instrucao2").ToString
                    strNossoNumero = strNossoNumero.Substring(0, 2) & "/" & strNossoNumero.Substring(2, strNossoNumero.Length - 3) & "-" & strNossoNumero.Substring(strNossoNumero.Length - 1, 1)

                    Dim intImagem As New PictureBox

                    intImagem.Size = New System.Drawing.Size(300, 100)

                    Dim Barcode As New BarcodeLib.Barcode(strCodigoBarras, BarcodeLib.TYPE.Interleaved2of5)
                    intImagem.Image = Barcode.Encode(BarcodeLib.TYPE.Interleaved2of5, strCodigoBarras, 750, 200)



                    Dim imagem As Byte() = converteimagem(intImagem.Image)


                    dtBoleto.Rows.Add()
                    dtBoleto.Rows.Item(A).Item("NumeroDocumento") = strNumeroDocumento
                    dtBoleto.Rows.Item(A).Item("Vencimento") = strVencimento
                    dtBoleto.Rows.Item(A).Item("Valor") = strValor
                    dtBoleto.Rows.Item(A).Item("NossoNumero") = strNossoNumero
                    dtBoleto.Rows.Item(A).Item("LinhaDigitavel") = strLinhaDigitavel
                    dtBoleto.Rows.Item(A).Item("CodigoBarras") = strCodigoBarras
                    dtBoleto.Rows.Item(A).Item("CodBarra") = imagem
                    dtBoleto.Rows.Item(A).Item("CodigoOcorrencia") = strIntrucaoBoleto
                    dtBoleto.Rows.Item(A).Item("PrimeiraInstrucao") = strIntrucaoBoleto2


                    dtBoleto.Rows.Item(A).Item("TipoAceite") = strNomeSacado
                    dtBoleto.Rows.Item(A).Item("Instrucao") = strNomeSacado & "                          " & strCpfSacado
                    dtBoleto.Rows.Item(A).Item("StatusRetorno") = strNomeSacado & "                          " & strCpfSacado

                    dtBoleto.Rows.Item(A).Item("Status") = strEnderecoSacado & ", " & strNumeroSacado & " - " & strBairroSacado
                    dtBoleto.Rows.Item(A).Item("Especie") = strMunicipioSacado & " - " & strUfSacado & " CEP: " & strCepSacado

                    dtBoleto.Rows.Item(A).Item("CodigoCarteira") = strEnderecoSacado & ", " & strNumeroSacado & "  " & strBairroSacado & " - " & strMunicipioSacado & " - " & strUfSacado & " CEP: " & strCepSacado

                End If
            Next


        End If

        dtConfig.TableName = "Config"
        dtBarra.TableName = "Usuario"
        dtBoleto.TableName = "Boleto"
        Dim ds As New DataSet

        ds.Tables.Add(dtConfig)
        ds.Tables.Add(dtBarra)
        ds.Tables.Add(dtBoleto)
        rptDoc.SetDataSource(ds)

        Dim strDataBoleto As String = My.Computer.Clock.LocalTime.ToString.Replace("/", "").Replace(":", "")
        'Try
        '    Dim CrExportOptions As ExportOptions
        '    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        '    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        '    CrDiskFileDestinationOptions.DiskFileName = PastaBoleto & "\Boleto\" & strNomeSacado & strDataBoleto & ".pdf"
        '    CrExportOptions = rptDoc.ExportOptions
        '    With CrExportOptions
        '        .ExportDestinationType = ExportDestinationType.DiskFile
        '        .ExportFormatType = ExportFormatType.PortableDocFormat
        '        .DestinationOptions = CrDiskFileDestinationOptions
        '        .FormatOptions = CrFormatTypeOptions
        '    End With
        '    rptDoc.Export()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        frmBoleto.strEmailCliente = strEmailCliente
        'frmBoleto.strCaminho(0) = PastaBoleto & "\Boleto\" & strNomeSacado & strDataBoleto & ".pdf"
        frmBoleto.CrystalReportViewer1.ReportSource = rptDoc
        frmBoleto.CrystalReportViewer1.ShowLastPage()
        Dim intPageFinal As Integer = frmBoleto.CrystalReportViewer1.GetCurrentPageNumber
        frmBoleto.intPageFinal = intPageFinal
        frmBoleto.intPageAtual = 1
        frmBoleto.CrystalReportViewer1.ShowFirstPage()
        frmBoleto.lblPaginaAtual.Text = frmBoleto.lblPaginaAtual.Tag & "1"
        frmBoleto.lblTotalPagina.Text = frmBoleto.lblTotalPagina.Tag & intPageFinal
        frmBoleto.BarCheckItem6.Checked = True
        frmBoleto.Show()
    End Function
    Private Shared Function DigitoVerificador(ByVal parVencimento As String, ByVal parValor As String, ByVal parNossoNumero As String, ByVal parTipoCarteira As String) As String
        'Dim strPrimeiro As String = "0339"

        'Dim strValor As String = CDbl(parValor) * 100
        'Dim strSegundo As String = FatorVencimento(parVencimento).Substring(0, 4) & Format(CInt(strValor), "0000000000") & "9"

        'Dim strTerceiro As String = "5394694" & parNossoNumero & "0" & parTipoCarteira

        '' sequencia sem o DV
        'Dim strSequencia As String = strPrimeiro & strSegundo & strTerceiro

        '' calculo do DV
        'Dim intDac As Integer = calcula_DV_CodBarras(strSequencia)
        'DigitoVerificador = intDac


        Dim strPrimeiro As String = "2379"

        Dim strValor As String = CDbl(parValor) * 100
        Dim strSegundo As String = FatorVencimento(parVencimento).Substring(0, 4) & Format(CInt(strValor), "0000000000")


        Dim strTerceiro As String = "0316" & "09" & parNossoNumero.Substring(2, 11) & "0011303" & "0"

        ' sequencia sem o DV
        Dim strSequencia As String = strPrimeiro & strSegundo & strTerceiro



        ' calculo do DV


        Dim intDac As Integer = calcula_DV_CodBarras(strSequencia)
        DigitoVerificador = intDac

    End Function

    Private Shared Function CodigoBarra(ByVal parVencimento As String, ByVal parValor As String, ByVal parNossoNumero As String, ByVal parTipoCarteira As String, ByVal parAgencia As String, ByVal parConta As String) As String


        'Dim strPrimeiro As String = "0339"

        'Dim strValor As String = CDbl(parValor) * 100
        'Dim strSegundo As String = FatorVencimento(parVencimento).Substring(0, 4) & Format(CInt(strValor), "0000000000") & "9"

        'Dim strTerceiro As String = "5394694" & parNossoNumero & "0" & parTipoCarteira

        '' sequencia sem o DV
        'Dim strSequencia As String = strPrimeiro & strSegundo & strTerceiro

        '' calculo do DV
        'Dim intDac As Integer = calcula_DV_CodBarras(strSequencia)

        '' monta a sequencia para o codigo de barras com o DV
        'CodigoBarra = Microsoft.VisualBasic.Left(strSequencia, 4) & intDac & Microsoft.VisualBasic.Right(strSequencia, 39)


        Dim strPrimeiro As String = "2379"

        Dim strValor As String = CDbl(parValor) * 100
        Dim strSegundo As String = FatorVencimento(parVencimento).Substring(0, 4) & Format(CInt(strValor), "0000000000")

        Dim strTerceiro As String = parAgencia & "09" & parNossoNumero.Substring(2, 11) & parConta & "0"
        'Dim strTerceiro As String = "0316" & "09" & parNossoNumero.Substring(2, 11) & "0011303" & "0"

        ' sequencia sem o DV
        Dim strSequencia As String = strPrimeiro & strSegundo & strTerceiro



        ' calculo do DV


        Dim intDac As Integer = calcula_DV_CodBarras(strSequencia)
        'strDigitoVerificador = intDac
        ' monta a sequencia para o codigo de barras com o DV
        CodigoBarra = Microsoft.VisualBasic.Left(strSequencia, 4) & intDac & Microsoft.VisualBasic.Right(strSequencia, 39)

    End Function
    Private Shared Function LinhaDigitavel(ByVal parVencimento As String, ByVal parValor As String, ByVal parNossoNumero As String, ByVal parTipoCarteira As String, ByVal parDigitoVerificador As String, ByVal parCodigoBarra As String) As String

        'Dim strPrimeiro As String = "033995394"

        'Dim strSegundo As String = "694" & parNossoNumero.Substring(0, 7)

        'Dim strTerceiro As String = parNossoNumero.Substring(7, 6) & "0" & parTipoCarteira
        'Dim strValor As String = CDbl(parValor) * 100
        'Dim strQuarto As String = FatorVencimento(parVencimento).Substring(0, 4) & Format(CInt(strValor), "0000000000")

        'Dim strdv1 As String = Val(Calculo_DV10(strPrimeiro))
        'Dim strdv2 As String = Val(Calculo_DV10(strSegundo))
        'Dim strdv3 As String = Val(Calculo_DV10(strTerceiro))

        ''formata a sequencia
        'strPrimeiro = Microsoft.VisualBasic.Left(strPrimeiro & strdv1, 5) & "." & Microsoft.VisualBasic.Right(strPrimeiro & strdv1, 5)
        'strSegundo = Microsoft.VisualBasic.Left(strSegundo & strdv2, 5) & "." & Microsoft.VisualBasic.Right(strSegundo & strdv2, 6)
        'strTerceiro = Microsoft.VisualBasic.Left(strTerceiro & strdv3, 5) & "." & Microsoft.VisualBasic.Right(strTerceiro & strdv3, 6)

        'LinhaDigitavel = strPrimeiro & " " & strSegundo & " " & strTerceiro & " " & parDigitoVerificador & " " & strQuarto




        Dim strPrimeiro As String = parCodigoBarra.Substring(0, 4) & parCodigoBarra.Substring(19, 5)

        Dim strSegundo As String = parCodigoBarra.Substring(24, 10)

        Dim strTerceiro As String = parCodigoBarra.Substring(34, 10)

        Dim strQuarto As String = parCodigoBarra.Substring(4, 1)


        Dim strValor As String = CDbl(parValor) * 100
        strValor = Format(CInt(strValor), "0000000000")

        Dim strQuinto As String = FatorVencimento(parVencimento).Substring(0, 4) & strValor

        Dim strdv1 As String = Val(Calculo_DV10(strPrimeiro))
        Dim strdv2 As String = Val(Calculo_DV10(strSegundo))
        Dim strdv3 As String = Val(Calculo_DV10(strTerceiro))



        strPrimeiro = Microsoft.VisualBasic.Left(strPrimeiro & strdv1, 5) & "." & Microsoft.VisualBasic.Right(strPrimeiro & strdv1, 5)
        strSegundo = Microsoft.VisualBasic.Left(strSegundo & strdv2, 5) & "." & Microsoft.VisualBasic.Right(strSegundo & strdv2, 6)
        strTerceiro = Microsoft.VisualBasic.Left(strTerceiro & strdv3, 5) & "." & Microsoft.VisualBasic.Right(strTerceiro & strdv3, 6)

        LinhaDigitavel = strPrimeiro & " " & strSegundo & " " & strTerceiro & " " & strQuarto & " " & strQuinto

    End Function
    Private Shared Function FatorVencimento(ByVal parVencimento As String) As String
        FatorVencimento = DateDiff(DateInterval.Day, CType("07/10/1997", Date), CType(parVencimento, Date))

    End Function

    Private Shared Function Calculo_DV10(ByVal strNumero As String) As String
        'declara As variáveis
        Dim intContador As Integer
        Dim intNumero As Integer

        Dim intTotalNumero As Integer

        Dim intMultiplicador As Integer

        Dim intResto As Integer

        ' se nao for um valor numerico sai da função
        If Not IsNumeric(strNumero) Then
            Calculo_DV10 = ""
            Exit Function
        End If

        'inicia o multiplicador
        intMultiplicador = 2


        'For I = 1 To strNumero.Length
        '    Dim intChar As Integer = strNumero.Substring(strNumero.Length - I, 1)

        '    Select Case intMultiplicador
        '        Case 1
        '            intMultiplicador = 2
        '        Case 2
        '            intMultiplicador = 1
        '    End Select
        'Next
        'pega cada caracter do numero a partir da direita
        For intContador = Len(strNumero) To 1 Step -1

            'extrai o caracter e multiplica pelo multiplicador
            intNumero = Val(Mid(strNumero, intContador, 1)) * intMultiplicador

            ' se o resultado for maior que nove soma os algarismos do resultado
            If intNumero > 9 Then
                intNumero = Val(Microsoft.VisualBasic.Left(intNumero, 1)) + Val(Microsoft.VisualBasic.Right(intNumero, 1))
            End If

            'soma o resultado para totalização
            intTotalNumero = intTotalNumero + intNumero

            'se o multiplicador for igual a 2 atribuir valor 1 se for 1 atribui 2
            intMultiplicador = IIf(intMultiplicador = 2, 1, 2)

        Next

        Dim DezenaSuperior As Integer
        If intTotalNumero < 10 Then
            DezenaSuperior = 10
        Else
            DezenaSuperior = 10 * (Val(Microsoft.VisualBasic.Left(CStr(intTotalNumero), 1)) + 1)
        End If
        intResto = DezenaSuperior - intTotalNumero


        'verifica as exceções ( 0 -> DV=0 )
        Select Case intResto
            Case 0, 10
                Calculo_DV10 = "0"


            Case Else
                Calculo_DV10 = Str(intResto)
        End Select

    End Function
    Private Shared Function calcula_DV_CodBarras(ByVal sequencia As String) As Integer

        Dim intContador, intNumero, intTotalNumero As Integer
        Dim intMultiplicador, intResto, intresultado As Integer
        Dim caracter As String

        intMultiplicador = 2

        For intContador = 1 To 43
            caracter = Mid(Microsoft.VisualBasic.Right(sequencia, intContador), 1, 1)
            If intMultiplicador > 9 Then
                intMultiplicador = 2
                intNumero = 0
            End If
            intNumero = caracter * intMultiplicador
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = intMultiplicador + 1
        Next

        intResto = intTotalNumero Mod 11

        intresultado = 11 - intResto

        If intresultado = 10 Or intresultado = 11 Then
            calcula_DV_CodBarras = 1
        Else
            calcula_DV_CodBarras = intresultado
        End If


        If intresultado = 0 Then
            calcula_DV_CodBarras = 1
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

End Class
