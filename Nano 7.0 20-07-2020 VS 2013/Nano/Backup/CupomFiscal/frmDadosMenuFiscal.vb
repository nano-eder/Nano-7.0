Imports Nano.clsFuncoes
Imports Nano.clsFuncoesBematech
Imports Nano.DarumaFiscal

Public Class frmDadosMenuFiscal

    Private Sub frmDadosMenuFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtInicio.Enabled = False
        Me.txtFim.Enabled = False

        Select Case Me.Tag
            Case "LX"
                Me.Text = "Leitura X"
                Me.Size = New System.Drawing.Size(371, 137)
                Me.pnlBusca.Visible = False
            Case "LMFC"
                Me.Text = "LMFC"

            Case "LMFS"
                Me.Text = "LMFS"

            Case "Espelho"
                Me.Text = "Espelho MFD"

                Me.Size = New System.Drawing.Size(371, 182)
                Me.pnlBusca.Location = New System.Drawing.Point(12, 12)

                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")
                Me.cboBusca.Properties.Items.Add("COO")

                Me.lblInicio.Text = "Coo Inicio"
                Me.lblFim.Text = "Coo Fim"
            Case "ArquivoMFD"
                Me.Text = "Arquivo MFD"

                Me.Size = New System.Drawing.Size(371, 182)
                Me.pnlBusca.Location = New System.Drawing.Point(12, 12)

                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")
                Me.cboBusca.Properties.Items.Add("COO")

                Me.lblInicio.Text = "Coo Inicio"
                Me.lblFim.Text = "Coo Fim"
            Case "MeioPag"
                Me.Text = "Meio Pagamento"


                Me.Size = New System.Drawing.Size(371, 157)
                Me.pnlBusca.Location = New System.Drawing.Point(12, 12)
                Me.pnlBusca.Size = New System.Drawing.Size(331, 62)


                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")

                Me.lblInicio.Visible = False
                Me.lblFim.Visible = False
                Me.txtFim.Visible = False
                Me.txtInicio.Visible = False
            Case "DAV"

                Me.Text = "DAV Emitidos"

                Me.Size = New System.Drawing.Size(371, 203)
                Me.pnlBusca.Size = New System.Drawing.Size(331, 62)


                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")

                Me.lblInicio.Visible = False
                Me.lblFim.Visible = False
                Me.txtFim.Visible = False
                Me.txtInicio.Visible = False
            Case "NFP"
                Me.Text = "Nota Fiscal Paulista"


                Me.Size = New System.Drawing.Size(371, 157)
                Me.pnlBusca.Location = New System.Drawing.Point(12, 12)
                Me.pnlBusca.Size = New System.Drawing.Size(331, 62)


                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")

                Me.lblInicio.Visible = False
                Me.lblFim.Visible = False
                Me.txtFim.Visible = False
                Me.txtInicio.Visible = False

            Case "MOVIMENTACAO"
                Me.Text = "Movimentação por ECF"


                Me.Size = New System.Drawing.Size(371, 157)
                Me.pnlBusca.Location = New System.Drawing.Point(12, 12)
                Me.pnlBusca.Size = New System.Drawing.Size(331, 62)


                Me.cboBusca.Properties.Items.Clear()
                Me.cboBusca.Properties.Items.Add("PERÍODO")

                Me.lblInicio.Visible = False
                Me.lblFim.Visible = False
                Me.txtFim.Visible = False
                Me.txtInicio.Visible = False
        End Select

    End Sub

    Private Function VerificaData() As Boolean
        Dim data1, data2 As String
        data1 = dtInicial.EditValue
        data2 = dtFinal.EditValue

        If data1 = "" Then MsgBox("Selecione a Data Inicial!", MsgBoxStyle.Information) : Exit Function
        If data2 = "" Then MsgBox("Selecione a Data Final!", MsgBoxStyle.Information) : Exit Function

        Dim dataFim, dataIni As Date
        dataIni = data1
        dataFim = data2

        If dataIni > dataFim Then
            MsgBox("A Data Inicial não pode ser maior que Data Final!", MsgBoxStyle.Information)

            Return False
        End If

        Return True

    End Function
    Private Function VerificaTexto() As Boolean
        If Me.txtInicio.Text = "" Then MsgBox("Selecione o inicio!", MsgBoxStyle.Information) : Return False
        If Me.txtFim.Text = "" Then MsgBox("Selecione o fim!", MsgBoxStyle.Information) : Return False

        Dim intInicio As Integer = Me.txtInicio.Text
        Dim intFim As Integer = Me.txtFim.Text

        If intInicio > intFim Then
            MsgBox("O número Inicial não pode ser maior que o número Final!", MsgBoxStyle.Information)

            Return False
        End If

        Return True
    End Function
    Private Sub btnOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOk.ItemClick
        Select Case Me.Tag
            Case "LX"
                If Me.cboTipoSaida.SelectedIndex = 0 Then
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.iLeituraX_ECF_Daruma()
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                    Else
                        Retorno = Bematech_FI_LeituraX()

                    End If
                   


                Else
                    If TipoImpressoraFiscal = "DARUMA" Then
                        DarumaFiscal.iRetorno = DarumaFiscal.rLeituraX_ECF_Daruma()
                        DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                    Else
                        Retorno = Bematech_FI_LeituraXSerial()
                    End If

                End If

            Case "LMFC"

                If Me.cboBusca.SelectedIndex = 0 Then
                    If VerificaData() = False Then Exit Sub
                    Dim dtIni As Date = Me.dtInicial.EditValue
                    Dim dtFin As Date = Me.dtFinal.EditValue
                    Dim strDataIni As String = Format(dtIni, "ddMMyyyy")
                    Dim strDataFin As String = Format(dtFin, "ddMMyyyy")
                    If TipoImpressoraFiscal = "DARUMA" Then
                        If Me.cboTipoSaida.SelectedIndex = 0 Then

                            DarumaFiscal.iRetorno = DarumaFiscal.eMemoriaFiscal_ECF_Daruma(strDataIni, strDataFin, True, "IMP")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("LMFC+[EAD]c:\NANO\Chave", "DATAM", strDataIni, strDataFin)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                       
                        End If
                    Else
                        If Me.cboTipoSaida.SelectedIndex = 0 Then
                            Retorno = Bematech_FI_LeituraMemoriaFiscalDataMFD(Me.dtInicial.Text, Me.dtFinal.Text, "c")
                        Else
                            Retorno = Bematech_FI_LeituraMemoriaFiscalSerialDataMFD(Me.dtInicial.Text, Me.dtFinal.Text, "c")

                            If Retorno = 1 Then
                                Dim strCaminho As String = "C:\Retorno.txt"
                                MsgBox("Arquivo LMFC gerado com sucesso." & vbCrLf & "Caminho do arquivo " & strCaminho & "!", MsgBoxStyle.Information)
                                AssinarArquivo(strCaminho)
                            End If
                        End If
                    End If
                    
                Else
                    If VerificaTexto() = False Then Exit Sub
                    If TipoImpressoraFiscal = "DARUMA" Then
                        If Me.cboTipoSaida.SelectedIndex = 0 Then
                           
                            DarumaFiscal.iRetorno = DarumaFiscal.eMemoriaFiscal_ECF_Daruma(Format(CInt(Me.txtInicio.Text), "0000"), Format(CInt(Me.txtFim.Text), "0000"), True, "IMP")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

                        Else
                            DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("LMFC+[EAD]c:\NANO\Chave", "CRZ", Format(CInt(Me.txtInicio.Text), "0000"), Format(CInt(Me.txtFim.Text), "0000"))
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        End If
                    Else
                        If Me.cboTipoSaida.SelectedIndex = 0 Then
                            Retorno = Bematech_FI_LeituraMemoriaFiscalReducaoMFD(Format(Me.txtInicio.Text, "0000"), Format(Me.txtFim.Text, "0000"), "c")
                        Else
                            Retorno = Bematech_FI_LeituraMemoriaFiscalSerialReducaoMFD(Format(Me.txtInicio.Text, "0000"), Format(Me.txtFim.Text, "0000"), "c")

                            If Retorno = 1 Then
                                Dim strCaminho As String = "C:\Retorno.txt"
                                MsgBox("Arquivo LMFC gerado com sucesso." & vbCrLf & "Caminho do arquivo " & strCaminho & "!", MsgBoxStyle.Information)
                                AssinarArquivo(strCaminho)
                            End If
                        End If
                    End If
                  
                End If
            Case "LMFS"

                If Me.cboBusca.SelectedIndex = 0 Then
                    If VerificaData() = False Then Exit Sub
                    Dim dtIni As Date = Me.dtInicial.EditValue
                    Dim dtFin As Date = Me.dtFinal.EditValue
                    Dim strDataIni As String = Format(dtIni, "ddMMyyyy")
                    Dim strDataFin As String = Format(dtFin, "ddMMyyyy")
                    If TipoImpressoraFiscal = "DARUMA" Then
                        If Me.cboTipoSaida.SelectedIndex = 0 Then

                            DarumaFiscal.iRetorno = DarumaFiscal.eMemoriaFiscal_ECF_Daruma(strDataIni, strDataFin, False, "IMP")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("LMFS+[EAD]c:\NANO\Chave", "DATAM", strDataIni, strDataFin)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        End If
                    Else
                        If Me.cboTipoSaida.SelectedIndex = 0 Then
                            Retorno = Bematech_FI_LeituraMemoriaFiscalDataMFD(Me.dtInicial.Text, Me.dtFinal.Text, "s")
                        Else
                            Retorno = Bematech_FI_LeituraMemoriaFiscalSerialDataMFD(Me.dtInicial.Text, Me.dtFinal.Text, "s")

                            If Retorno = 1 Then
                                Dim strCaminho As String = "C:\Retorno.txt"
                                MsgBox("Arquivo LMFS gerado com sucesso." & vbCrLf & "Caminho do arquivo " & strCaminho & "!", MsgBoxStyle.Information)
                                AssinarArquivo(strCaminho)
                            End If
                        End If
                    End If
                    
                Else
                    If VerificaTexto() = False Then Exit Sub
                    If TipoImpressoraFiscal = "DARUMA" Then
                        If Me.cboTipoSaida.SelectedIndex = 0 Then

                            DarumaFiscal.iRetorno = DarumaFiscal.eMemoriaFiscal_ECF_Daruma(Format(CInt(Me.txtInicio.Text), "0000"), Format(CInt(Me.txtFim.Text), "0000"), False, "IMP")
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("LMFS+[EAD]c:\NANO\Chave", "CRZ", Format(CInt(Me.txtInicio.Text), "0000"), Format(CInt(Me.txtFim.Text), "0000"))
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        End If
                    Else
                        If Me.cboTipoSaida.SelectedIndex = 0 Then
                            Retorno = Bematech_FI_LeituraMemoriaFiscalReducaoMFD(Format(Me.txtInicio.Text, "0000"), Format(Me.txtFim.Text, "0000"), "s")
                        Else
                            Retorno = Bematech_FI_LeituraMemoriaFiscalSerialReducaoMFD(Format(Me.txtInicio.Text, "0000"), Format(Me.txtFim.Text, "0000"), "s")

                            If Retorno = 1 Then
                                Dim strCaminho As String = "C:\Retorno.txt"
                                MsgBox("Arquivo LMFS gerado com sucesso." & vbCrLf & "Caminho do arquivo " & strCaminho & "!", MsgBoxStyle.Information)
                                AssinarArquivo(strCaminho)
                            End If
                        End If
                    End If
                   
                End If
            Case "Espelho"
                If VerificaData() = False Then Exit Sub
                Dim dtIni As Date = Me.dtInicial.EditValue
                Dim dtFin As Date = Me.dtFinal.EditValue
                Dim strDataIni As String = Format(dtIni, "ddMMyy")
                Dim strDataFin As String = Format(dtFin, "ddMMyy")
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.rGerarEspelhoMFD_ECF_Daruma("1", strDataIni, strDataFin)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                    If DarumaFiscal.iRetorno <> 1 Then Exit Sub
                    AssinarArquivo("C:\NFP DARUMA\Espelho_MFD.txt")
                Else
                    Retorno = Bematech_FI_EspelhoMFD("C:\NFP\ESPELHO.txt", Me.dtInicial.EditValue, Me.dtFinal.EditValue, "D", "1", ChavePublica, ChavePrivada)

                    AssinarArquivo("C:\NFP\ESPELHO.txt")
                End If


            Case "ArquivoMFD"
                Dim dtIni As Date = Me.dtInicial.EditValue
                Dim dtFin As Date = Me.dtFinal.EditValue
                Dim strDataIni As String = Format(dtIni, "ddMMyyyy")
                Dim strDataFin As String = Format(dtFin, "ddMMyyyy")
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("MFD+[EAD]c:\NANO\Chave", "DATAM", strDataIni, strDataFin)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    Retorno = Bematech_FI_ArquivoMFDPath("", "C:\NFP\Saida.txt", Me.dtInicial.EditValue, Me.dtFinal.EditValue, "D", "01", 2, ChavePublica, ChavePrivada, 0)
                    Call VerificaRetornoImpressora("", "", "Arquivo MFD")
                    AssinarArquivo("C:\NFP\Saida.txt")
                End If
               
            Case "MeioPag"

                If VerificaData() = False Then Exit Sub

                Dim strData1 As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
                Dim dt As DataTable = CarregarDataTable("SELECT Convert(Varchar(10),Total.Data,103) as Data, Pagamento, " & _
                "convert(Numeric(15,2),sum(Valor)) as Valor FROM (Total left join Recebimento on Total.CodOrdem = Recebimento.CodOrdem " & _
                "and Total.CodConfig = Recebimento.CodConfig) inner join R4 on Total.CodOrdem = R4.CodOrdem and Total.Codconfig = R4.CodConfig " & _
                "where CodConfigECF = " & CodConfigECF & " and " & strData1 & " and Total.CodConfig = " & CodConfig & " group by Total.Data, Pagamento")
                Dim I As Integer
                Me.tbPag.Rows.Clear()
                If dt.Rows.Count > 0 Then

                    For I = 0 To dt.Rows.Count - 1
                        Dim strDataDav As String = dt.Rows.Item(I).Item("Data").ToString
                        Dim strPag As String = dt.Rows.Item(I).Item("Pagamento").ToString
                        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

                        Me.tbPag.Rows.Add()
                        Me.tbPag.Rows.Item(I).Item("Data") = strDataDav
                        Me.tbPag.Rows.Item(I).Item("Descricao") = strPag
                        Me.tbPag.Rows.Item(I).Item("Valor") = strValor
                        Me.tbPag.Rows.Item(I).Item("Tipo") = "CF"
                    Next
                End If

                Dim strData2 As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))
                dt = CarregarDataTable("SELECT convert(Varchar(10),Data,103) as Data, sum(Entrada) as Valor " & _
                "FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData2 & "  and Tipo <> 'Saida' " & _
                "and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " group by convert(Varchar(10),Data,103)")

                If dt.Rows.Count > 0 Then
                    For I = 0 To dt.Rows.Count - 1
                        Dim strDataDav As String = dt.Rows.Item(I).Item("Data").ToString
                        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

                        Me.tbPag.Rows.Add()
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Data") = strDataDav
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Descricao") = "SUPRIMENTO"
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Valor") = strValor
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Tipo") = "CN"
                    Next
                End If

                dt = CarregarDataTable("SELECT convert(Varchar(10),Data,103) as Data, sum(Entrada) as Valor " & _
                "FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData2 & "  and Tipo <> 'Entrada' " & _
                "and Tipo <> 'Suprimento' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " group by convert(Varchar(10),Data,103)")

                If dt.Rows.Count > 0 Then
                    For I = 0 To dt.Rows.Count - 1
                        Dim strDataDav As String = dt.Rows.Item(I).Item("Data").ToString
                        Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

                        Me.tbPag.Rows.Add()
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Data") = strDataDav
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Descricao") = "SANGRIA"
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Valor") = strValor
                        Me.tbPag.Rows.Item(Me.tbPag.Rows.Count - 1).Item("Tipo") = "CN"
                    Next
                End If

                GerarMeioPag()

            Case "DAV"


                If VerificaData() = False Then Exit Sub

                Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
                Dim dtDav As DataTable = CarregarDataTable("SELECT REPLICATE( '0' ,13 - len(NumDav) ) + NumDav as NumDav, CCF as NumCupom, COO as NumCOO, Convert(Varchar(10),Data,103) as Data, Data as Data2, convert(Numeric(15,2),Total) as Total FROM Total inner join R4 on Total.CodOrdem = R4.CodOrdem and Total.CodConfig = R4.CodConfig where CodConfigECF = " & CodConfigECF & " and " & strData & " and NumDav <> '0' and Total.CodConfig = " & CodConfig)
                If dtDav.Rows.Count > 0 Then
                    Dim I As Integer
                    Dim strTextoDav As String = ""
                    If Me.cboTipoSaida.SelectedIndex = 0 Then
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iRGAbrirIndice_ECF_Daruma(1)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                            If DarumaFiscal.iRetorno <> 1 Then Exit Sub
                        Else
                            Retorno = Bematech_FI_AbreRelatorioGerencialMFD("01")
                        End If

                        Dim strTraco As String = "------------------------------------------------"
                        strTextoDav = strTraco & vbCrLf
                        strTextoDav &= Cent("DAV EMITIDOS", 48) & vbCrLf
                        strTextoDav &= strTraco & vbCrLf
                        strTextoDav &= Dir("Número DAV    Emissão     Título", 40) & Esq("Total R$", 8) & vbCrLf
                        strTextoDav &= strTraco & vbCrLf
                        For I = 0 To dtDav.Rows.Count - 1
                            Dim strNumDav As String = dtDav.Rows.Item(I).Item("NumDav").ToString
                            Dim strDataDav As String = dtDav.Rows.Item(I).Item("Data").ToString
                            Dim strValorDav As String = dtDav.Rows.Item(I).Item("Total").ToString
                            Dim strNumCupom As String = dtDav.Rows.Item(I).Item("NumCupom").ToString

                            strTextoDav &= Dir(strNumDav & " " & strDataDav & " Orçamento", 38) & Esq(strValorDav, 10) & vbCrLf
                            strTextoDav &= "CCF: " & strNumCupom & vbCrLf
                            strTextoDav = VerificaTamnhoTexto(strTextoDav)
                        Next
                        If TipoImpressoraFiscal = "DARUMA" Then
                            DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strTextoDav)
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                            DarumaFiscal.iRetorno = DarumaFiscal.iRGFechar_ECF_Daruma()
                            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                        Else
                            Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strTextoDav)
                            Retorno = Bematech_FI_FechaRelatorioGerencial()
                        End If



                        SalvarDocumento("RG")
                    Else
                        Dim strCNPJ As String
                        strCNPJ = CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "").Trim
                        strTextoDav = "D1" & strCNPJ & IEECF.Replace(".", "").Trim & vbCrLf

                        For I = 0 To dtDav.Rows.Count - 1
                            Dim strNumDav As String = dtDav.Rows.Item(I).Item("NumDav").ToString
                            Dim dtDataDav As Date = dtDav.Rows.Item(I).Item("Data2").ToString
                            Dim strValorDav As String = dtDav.Rows.Item(I).Item("Total").ToString
                            Dim strNumCupom As String = dtDav.Rows.Item(I).Item("NumCupom").ToString
                            Dim strNumCOO As String = dtDav.Rows.Item(I).Item("NumCOO").ToString
                            Dim strDataDav As String = Format(dtDataDav, "yyyyMMdd")

                            strTextoDav &= "D2" & Espaco(strCNPJ, 14, True) & Espaco(NumeroSerieECF, 20, False) & Espaco(MFAdicionalECF, 1, False) & Espaco(TipoECF, 7, False) & Espaco(MarcaECF, 20, False) & Espaco(ModeloECF, 20, False)

                            strTextoDav &= Espaco("0", 6, True) & Espaco(strNumDav, 13, False) & Espaco(strDataDav, 8, False) & Espaco("Orçamento", 30, False) & Espaco(strValorDav.Replace(",", "").Replace(".", ""), 8, True) & Espaco(strNumCOO, 6, True) & vbCrLf

                        Next

                        strTextoDav &= "D9" & strCNPJ & Espaco(IEECF.Replace(".", ""), 14, False) & Espaco(dtDav.Rows.Count, 6, True) & vbCrLf


                        'strTextoDav &= "EAD" & ChavePublica


                        EscreveArquivo("C:\NFP\DAV_EMITIDOS.txt", strTextoDav)

                        AssinarArquivo("C:\NFP\DAV_EMITIDOS.txt")

                        MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP\DAV_EMITIDOS.txt", MsgBoxStyle.Information)
                    End If
                End If

            Case "NFP"
                If VerificaData() = False Then Exit Sub

                Dim dtIni As Date = Me.dtInicial.EditValue
                Dim dtFin As Date = Me.dtFinal.EditValue
                Dim strDataIni As String = Format(dtIni, "ddMMyyyy")
                Dim strDataFin As String = Format(dtFin, "ddMMyyyy")
                If TipoImpressoraFiscal = "DARUMA" Then
                    DarumaFiscal.iRetorno = DarumaFiscal.rGerarRelatorio_ECF_Daruma("NFP+[EAD]c:\NANO\Chave", "DATAM", strDataIni, strDataFin)
                    DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
                Else
                    strDataIni = Format(dtIni, "dd/MM/yyyy")
                    strDataFin = Format(dtFin, "dd/MM/yyyy")
                    Retorno = Bematech_FI_ArquivoMFDPath("", "C:\NFP\Saida.txt", strDataIni, strDataFin, "D", Format(CodUser, "00"), 1, ChavePublica, ChavePrivada, 0)
                    If VerificaRetornoImpressora("", "", "Status Impressora") = False Then Exit Sub
                    MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP\", MsgBoxStyle.Information)

                End If

              
                'Dim dtIni As Date = Me.dtInicial.EditValue
                'Dim dtFin As Date = Me.dtFinal.EditValue

                'Dim strIni As String = Format(dtIni, "ddMMyyyy")
                'Dim strFin As String = Format(dtFin, "ddMMyyyy")
                'Retorno = Bematech_FI_DownloadMFD("C:\NFP\DOWNLOAD.MFD", "1", strIni, strFin, CodUser)
                'If VerificaRetornoImpressora("", "", "Status Impressora") = False Then Exit Sub

                'Retorno = Bematech_FI_GeraRegistrosCAT52MFD("C:\NFP\DOWNLOAD.MFD", Format(Date.Today, "ddMMyyyy"))

                'If VerificaRetornoImpressora("", "", "Status Impressora") = False Then Exit Sub
              
            Case "MOVIMENTACAO"
                If VerificaData() = False Then Exit Sub

                GerarArquivoMovimentacao("Manual", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        End Select

        Me.Close()
    End Sub
    Private Sub GerarMeioPag()
        Dim I As Integer
        Dim strData1 As String = String.Format("Total.Data >= '{0:dd/MM/yyyy}' AND Total.Data <= '{1:dd/MM/yyyy}'", Me.dtInicial.EditValue, Me.dtFinal.EditValue)
        Dim strData2 As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))
        If TipoImpressoraFiscal = "DARUMA" Then
            DarumaFiscal.iRetorno = DarumaFiscal.iRGAbrirIndice_ECF_Daruma(1)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_AbreRelatorioGerencialMFD("01")
        End If


        Dim strTextoDav As String = ""
        Dim strTraco As String = "------------------------------------------------"
        Dim strTraco2 As String = "----           ------------------           ----"
        strTextoDav = strTraco & vbCrLf
        strTextoDav &= Cent("MEIOS DE PAGAMENTO", 48) & vbCrLf
        strTextoDav &= strTraco & vbCrLf
        strTextoDav &= Dir("Data           Descrição     Tipo", 40) & Esq("Valor R$", 8) & vbCrLf
        strTextoDav &= strTraco & vbCrLf
        Dim strDataComp As String = ""
        For I = 0 To Me.grd1.RowCount - 1
            Dim strData As String = Me.grd1.GetRowCellDisplayText(I, Me.colData)
            Dim strDescricao As String = Me.grd1.GetRowCellDisplayText(I, Me.colDescricao)
            Dim strValor As String = Me.grd1.GetRowCellDisplayText(I, Me.colValor)
            Dim strTipo As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipo)


            strTextoDav &= Dir(strData, 12) & Dir(strDescricao, 18) & Dir(strTipo, 8) & Esq(strValor, 10) & vbCrLf

            If I = 0 Then
                strDataComp = strData
            End If

            If I = Me.grd1.RowCount - 1 Then
                strTextoDav &= strTraco & vbCrLf
                Exit For
            End If
            If strData <> strDataComp Then
                strTextoDav &= strTraco2 & vbCrLf

            End If
           strTextoDav = VerificaTamnhoTexto(strTextoDav)
        Next

        strTextoDav &= Cent("TOTAIS", 48) & vbCrLf
        strTextoDav &= strTraco & vbCrLf

        Dim dt As DataTable = CarregarDataTable("SELECT Pagamento, convert(Numeric(15,2),sum(Valor)) as Valor FROM (Total left join Recebimento on Total.CodOrdem = Recebimento.CodOrdem and Total.CodConfig = Recebimento.Codconfig) inner join R4 on Total.CodOrdem = R4.CodOrdem and Total.CodConfig = R4.CodConfig where CodConfigECF = " & CodConfigECF & " and " & strData1 & " and Total.CodConfig = " & CodConfig & " group by Pagamento")

        For I = 0 To dt.Rows.Count - 1
            Dim strPag As String = dt.Rows.Item(I).Item("Pagamento").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

            strTextoDav &= Dir("", 12) & Dir(strPag, 26) & Esq(strValor, 10) & vbCrLf
           strTextoDav = VerificaTamnhoTexto(strTextoDav)
        Next
        dt = CarregarDataTable("SELECT  sum(Entrada) as Valor FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData2 & " and Tipo <> 'Entrada' and Tipo <> 'Suprimento' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig)
        For I = 0 To dt.Rows.Count - 1
            Dim strPag As String = "SANGRIA"
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

            strTextoDav &= Dir("", 12) & Dir(strPag, 26) & Esq(strValor, 10) & vbCrLf
           strTextoDav = VerificaTamnhoTexto(strTextoDav)
        Next

        dt = CarregarDataTable("SELECT sum(Entrada) as Valor FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData2 & " and Tipo <> 'Saida' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig)
        For I = 0 To dt.Rows.Count - 1
            Dim strPag As String = "SUPRIMENTO"
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString

            strTextoDav &= Dir("", 12) & Dir(strPag, 26) & Esq(strValor, 10) & vbCrLf
           strTextoDav = VerificaTamnhoTexto(strTextoDav)
        Next

        If TipoImpressoraFiscal = "DARUMA" Then
            DarumaFiscal.iRetorno = DarumaFiscal.iRGImprimirTexto_ECF_Daruma(strTextoDav)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            DarumaFiscal.iRetorno = DarumaFiscal.iRGFechar_ECF_Daruma()
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else
            Retorno = Bematech_FI_UsaRelatorioGerencialMFD(strTextoDav)
            Retorno = Bematech_FI_FechaRelatorioGerencial()
        End If

        SalvarDocumento("RG")


    End Sub
    
    Private Sub cboBusca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBusca.SelectedIndexChanged

        If Me.cboBusca.SelectedIndex = 0 Then
            Me.txtInicio.ResetText()
            Me.txtFim.ResetText()
            Me.dtInicial.Enabled = True
            Me.dtFinal.Enabled = True
            Me.txtInicio.Enabled = False
            Me.txtFim.Enabled = False
        Else
            Me.dtInicial.ResetText()
            Me.dtFinal.ResetText()
            Me.dtInicial.Enabled = False
            Me.dtFinal.Enabled = False
            Me.txtInicio.Enabled = True
            Me.txtFim.Enabled = True
        End If
    End Sub

    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub
End Class