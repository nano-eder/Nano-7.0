Imports Nano.clsFuncoes
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization
Public Class frmMenuNFCe

    Public strRetorno As String
    Public strArquivoProcessado As String
    Public strCaminhoDaNfe As String
    Dim strCaminhoNFCe As String
    Private Sub Limpar()
        Me.btnImprimir.Checked = False
        Me.btnConsultaChave.Checked = False
        Me.btnInutilizar.Checked = False
        Me.btnCancelar.Checked = False
        Me.XtraTabControl1.SelectedTabPageIndex = 0
        Me.CrystalReportViewer1.ReportSource = Nothing
        strCaminhoNFCe = ""
        Me.txtChave.ResetText()
        Me.rtfConsulta.Text = ""
        Me.picFundo.Focus()
    End Sub
    Private Sub btnImprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.CheckedChanged
     
        Select Case Me.btnImprimir.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 1
                Me.btnConsultaChave.Checked = False
                Me.btnInutilizar.Checked = False
                Me.btnCancelar.Checked = False
                Me.btnImprimir.Checked = True


               
            Case False
                Limpar()

        End Select
    End Sub

    Private Sub btnConsultaChave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaChave.CheckedChanged

        Select Case Me.btnConsultaChave.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 2
                Me.btnImprimir.Checked = False
                Me.btnInutilizar.Checked = False
                Me.btnCancelar.Checked = False
                Me.btnConsultaChave.Checked = True
                Me.rdgTipoAmb.SelectedIndex = TipoAmbiente - 1

                Me.txtChave.Focus()
            Case False
                Limpar()

        End Select
    End Sub

    Private Sub btnCancelar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.CheckedChanged
 
        Select Case Me.btnCancelar.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 3
                Me.btnImprimir.Checked = False
                Me.btnInutilizar.Checked = False

                Me.btnConsultaChave.Checked = False
                Me.btnCancelar.Checked = True
                CarregarNfce()
            Case False
                Limpar()

        End Select
    End Sub
    Private Sub CarregarNfce()
        Dim strFiltro As String = ""
        If Master = False Then
            strFiltro = " and NFCe.CodConfig =" & CodConfig & " and CodEmitente = " & CodEmitente
        End If


        CarregarDados("SET DATEFORMAT dmy Select NFCe.CodOrdem, Chave, NumNF as NumeroCupom, ChaveCancelamento, " & _
        "NFCe.Data, NFCe.ValorTotal, CFPDest, NFCe.CodConfig, " & _
        "convert(bit,case when Total.codordem <> '' then 'False' else 'True' end) as VendaExcluida, " & _
        "convert(bit,case when ChaveCancelamento <> '' then 'True' else 'False' end) as Cancelado from NFCe left join Total " & _
        "on NFCe.codordem = total.codordem and NFCe.codconfig = total.codconfig  where ChaveCancelamento is null " & strFiltro & "   order by NFCe.CodOrdem desc", Me.GridControl1)

    End Sub
    Private Sub btnInutilizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInutilizar.CheckedChanged
  
        Select Case Me.btnInutilizar.Checked
            Case True
                Me.XtraTabControl1.SelectedTabPageIndex = 4
                Me.btnImprimir.Checked = False

                Me.btnCancelar.Checked = False
                Me.btnConsultaChave.Checked = False
                Me.btnInutilizar.Checked = True
            Case False
                Limpar()

        End Select

    End Sub
    Private Sub btnConChave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConChave.Click
        If Validar(Me.txtChave) = False Then Exit Sub
        frmProcesNfe.strStatus = "Consulta"
        frmProcesNfe.strChaveAcesso = Me.txtChave.Text
        frmProcesNfe.Tag = "ConsultaChave"

        frmProcesNfe.strUF = SelecionarUF(Me.txtChave.Text.Substring(0, 2))
        frmProcesNfe.strTipoAmb = Me.rdgTipoAmb.SelectedIndex + 1
        frmProcesNfe.strCaminhoNfe = ""
        frmProcesNfe.ShowDialog()

        If strRetorno <> "" Then
            If strRetorno = "NOK" Then Exit Sub

            Dim vetRetorno As Array = Split(strRetorno, "|EVENTO|")
            strRetorno = "<?xml version=""1.0"" encoding=""UTF-8""?><nfeProc><NFe>" & strRetorno & "</NFe></nfeProc>"

            Dim strTexto As String = ""

            Dim dtNF As DataTable = GerarNFCe.ArquivoNfeXml(strRetorno, "/nfeProc/NFe/infProt", "tpAmb Varchar(1), verAplic varchar(20), " & _
            "chNFe varchar(50), dhRecbto varchar(20), nProt varchar(30), digVal varchar(20), cStat varchar(10), xMotivo varchar(50)", "")
            If dtNF.Rows.Count > 0 Then

                strTexto = "NFC-e" & vbCrLf
                strTexto &= "Ambiente: " & dtNF.Rows.Item(0).Item("tpAmb").ToString & vbCrLf
                strTexto &= "Versão: " & dtNF.Rows.Item(0).Item("verAplic").ToString & vbCrLf
                strTexto &= "Chave: " & dtNF.Rows.Item(0).Item("chNFe").ToString & vbCrLf
                strTexto &= "Data Recebimento: " & dtNF.Rows.Item(0).Item("dhRecbto").ToString & vbCrLf
                strTexto &= "Nº Protocolo: " & dtNF.Rows.Item(0).Item("nProt").ToString & vbCrLf
                strTexto &= "Digest Value: " & dtNF.Rows.Item(0).Item("digVal").ToString & vbCrLf
                strTexto &= "Cód. Status: " & dtNF.Rows.Item(0).Item("cStat").ToString & vbCrLf
                strTexto &= "Motivo: " & dtNF.Rows.Item(0).Item("xMotivo").ToString & vbCrLf & vbCrLf & vbCrLf
            End If


            dtNF = GerarNFCe.ArquivoNfeXml(strRetorno, "/nfeProc/NFe/infEvento", "tpAmb Varchar(1), verAplic varchar(20), " & _
            "cOrgao varchar(2), cStat varchar(10), xMotivo varchar(50), chNFe varchar(50), tpEvento varchar(10), " & _
            "xEvento varchar(30), nSeqEvento varchar(2), CPFDest varchar(20), emailDest varchar(30), " & _
            "dhRegEvento varchar(30), nProt varchar(30)", "")
            Dim I As Integer
            For I = 0 To dtNF.Rows.Count - 1



                strTexto &= "EVENTO" & vbCrLf
                strTexto &= "Ambiente: " & dtNF.Rows.Item(I).Item("tpAmb").ToString & vbCrLf
                strTexto &= "Versão: " & dtNF.Rows.Item(I).Item("verAplic").ToString & vbCrLf
                strTexto &= "Cód. Orgão: " & dtNF.Rows.Item(I).Item("cOrgao").ToString & vbCrLf
                strTexto &= "Cód. Status: " & dtNF.Rows.Item(I).Item("cStat").ToString & vbCrLf
                strTexto &= "Motivo: " & dtNF.Rows.Item(I).Item("xMotivo").ToString & vbCrLf
                strTexto &= "Chave: " & dtNF.Rows.Item(I).Item("chNFe").ToString & vbCrLf
                strTexto &= "Tipo Evento: " & dtNF.Rows.Item(I).Item("tpEvento").ToString & vbCrLf
                strTexto &= "Evento: " & dtNF.Rows.Item(I).Item("xEvento").ToString & vbCrLf
                strTexto &= "Nº Seq. Evento: " & dtNF.Rows.Item(I).Item("nSeqEvento").ToString & vbCrLf
                strTexto &= "CPF Dest.: " & dtNF.Rows.Item(I).Item("CPFDest").ToString & vbCrLf
                strTexto &= "Email Dest.: " & dtNF.Rows.Item(I).Item("emailDest").ToString & vbCrLf
                strTexto &= "Data Registro: " & dtNF.Rows.Item(I).Item("dhRegEvento").ToString & vbCrLf
                strTexto &= "Nº Protocolo: " & dtNF.Rows.Item(I).Item("nProt").ToString & vbCrLf & vbCrLf & vbCrLf


            Next

            Me.rtfConsulta.Text = strTexto

        End If
    End Sub


    Private Sub frmMenuNFCe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpar()
        If Login = "ADM" And Senha = "SPFC" Then
            Me.btnConfig.Enabled = True
            Me.btnInstalacao.Enabled = True
            Me.btnAtualizacao.Enabled = True
        End If
    End Sub

    Private Sub btnLocalizarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalizarXml.Click
        ofdXml.FileName = ""
        ofdXml.Filter = "|*xml"
        ofdXml.ShowDialog()
        If ofdXml.FileName <> "" Then

            Dim fluxoTexto As IO.StreamReader
            Dim strTexto As String = ""

            If IO.File.Exists(ofdXml.FileName) Then
                fluxoTexto = New IO.StreamReader(ofdXml.FileName)
                strTexto = fluxoTexto.ReadToEnd
                fluxoTexto.Close()
                strCaminhoNFCe = ofdXml.FileName
                GerarNFCe.GerarCupomNFCe(ofdXml.FileName, True)
            Else
                strCaminhoNFCe = ""
                MsgBox("Arquivo inválido!", MsgBoxStyle.Information)
            End If


        End If
    End Sub

    Private Sub btnImprimirXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirXml.Click
        If ImpressoraNFCe = "MP-4200 TH" Then
            ''strTraco = clsImprimir.Comp("________________________________________________")
            'strTraco = clsImprimir.Comp("------------------------------------------------")

            'Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
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
            'StringImpressao &= strStringProduto
            'StringImpressao &= vbCrLf

            'StringImpressao &= clsImprimir.Neg(Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= clsImprimir.Neg(Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
            'StringImpressao &= clsImprimir.Neg(Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= vbCrLf
            'StringImpressao &= clsImprimir.Neg(strPagamento)
            '''' StringImpressao &= clsImprimir.Neg(Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8)) & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
            'StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
            'StringImpressao &= vbCrLf
            'StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
            'StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
            'StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg("SAT No. " & strNumSerie))) & vbCrLf
            'StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(clsImprimir.Neg(Format(dtData, "dd/MM/yyyy") & " " & strHora))) & vbCrLf
            ''StringImpressao &= clsImprimir.Comp(clsImprimir.Centralizar(Chr(27) + "!" + Chr(1) & strChaveAcesso)) & vbCrLf
            ''StringImpressao &= clsImprimir.GerarBarCode(strChave) & vbCrLf
            'iRetorno = clsBematech.IniciaPorta(PortaImpressoraNFCe)
            'iRetorno = ConfiguraModeloImpressora(7)
            'iRetorno = BematechTX(StringImpressao)




            ''iRetorno = FormataTX("#   |COD | DESC |QTD | UN |VL UN R$|(VL TR R$)*|VL ITEM R$", 1, 0, 0, 0, 0)
            'iRetorno = clsBematech.FormataTX(strChaveAcesso, 1, 0, 0, 0, 0)

            'iRetorno = clsBematech.ConfiguraCodigoBarras(50, 0, 0, 0, 5)



            'iRetorno = clsBematech.ImprimeCodigoBarrasCODE128(strChave)
            'iRetorno = clsBematech.ImprimeCodigoQRCODE(1, 6, 0, 16, 1, strQrCode)

            'iRetorno = BematechTX(clsImprimir.Corte)

            'iRetorno = clsBematech.FechaPorta()
            ''StringImpressao &= Chr(29) + Chr(107) + Chr(73) + Chr(110) + strChave & vbCrLf

            ''clsImprimir.Rodape(StringImpressao)

        ElseIf ImpressoraNFCe = "NORMAL" Then
            Dim margins As PageMargins = CrystalReportViewer1.ReportSource.PrintOptions.PageMargins
            Try
                margins.bottomMargin = 350
                margins.leftMargin = 350
                margins.rightMargin = 350
                margins.topMargin = 350


                CrystalReportViewer1.ReportSource.PrintOptions.ApplyPageMargins(margins)
            Catch ex As Exception

            End Try


            CrystalReportViewer1.ReportSource.PrintOptions.PrinterName = PortaImpressoraNFCe
            CrystalReportViewer1.ReportSource.PrintToPrinter(1, False, 0, 0)
        ElseIf ImpressoraNFCe = "DARUMA" Then
            Dim iRetorno As Integer = clsDarumaSatDLL.iCFImprimirParametrizado_NFCe_Daruma(strCaminhoNFCe, "", "", "48", "1", "")
        ElseIf ImpressoraNFCe = "EPSON" Then
            'strTraco = clsImprimir.Comp("------------------------------------------------")

            'Dim strEnd As String = strEnderecoEmitente & " " & strNumeroEmitente & " " & strBairroEmitente & " " & strCidadeEmitente & " CEP: " & AddPonto(strCEPEmitente, "CEP")
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
            'StringImpressao &= strStringProduto
            'StringImpressao &= vbCrLf

            'StringImpressao &= "<b>" & Dir("Total bruto do item", 40) & Esq(dblValorProduto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= "<b>" & Dir("Total de descontos/acréscimos sobre item", 40) & Esq(dblValorDesconto.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= Dir(" ", 30) & Esq("------------------", 18) & vbCrLf
            'StringImpressao &= "<b>" & Dir("TOTAL R$", 40) & Esq(dblValorTotal.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= vbCrLf
            'StringImpressao &= "<b>" & strPagamento & "</b>"
            ' '' StringImpressao &= "<b>" & Dir("Troco R$", 40) & Esq(dblTroco.ToString("####,##0.00"), 8) & "</b>" & vbCrLf
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= Dir("OBSERVAÇÕES DO CONTRIBUINTE", 48) & vbCrLf
            'StringImpressao &= Dir(dtNF.Rows.Item(0).Item("infCpl").ToString(), 48) & vbCrLf
            'StringImpressao &= vbCrLf
            'StringImpressao &= Dir("Valor aproximado dos tributos em R$", 40) & Esq(dblValorAproximado, 8) & vbCrLf
            'StringImpressao &= Dir("(Conforme Lei Fed. 12.741/2012)", 48)
            'StringImpressao &= Dir("*Valor aproximado dos tributos do item", 48)
            'StringImpressao &= strTraco & vbCrLf
            'StringImpressao &= "<ce><b>" & "SAT No. " & strNumSerie & "</b></ce>" & vbCrLf
            'StringImpressao &= "<ce><b>" & Format(dtData, "dd/MM/yyyy") & " " & strHora & "</b></ce>" & vbCrLf & vbCrLf
            'StringImpressao &= "<c><ce>" & strChaveAcesso & "</ce></c>"


            'iRetorno = clsEpson.IniciaPorta(PortaImpressoraNFCe)

            'iRetorno = clsEpson.ImprimeTextoTag(StringImpressao)

            'iRetorno = clsEpson.ConfiguraCodigoBarras(65, 0, 0, 0, 5)

            'iRetorno = clsEpson.ImprimeCodigoBarrasCODE128(strChave)

            'iRetorno = clsEpson.ImprimeCodigoQRCODE(1, 4, 0, 16, 1, strQrCode)

            'iRetorno = clsEpson.AcionaGuilhotina(1)

            'iRetorno = clsEpson.FechaPorta()

        ElseIf ImpressoraNFCe = "TERMICA" Then

            CrystalReportViewer1.ReportSource.PrintOptions.PrinterName = PortaImpressoraNFCe
            CrystalReportViewer1.ReportSource.PrintToPrinter(1, False, 0, 0)

        ElseIf ImpressoraNFCe = "TERMICA MARGEM" Then

            Dim margins As PageMargins = CrystalReportViewer1.ReportSource.PrintOptions.PageMargins
            Try
                margins.bottomMargin = 150
                margins.leftMargin = 180
                margins.rightMargin = 50
                margins.topMargin = 150


                CrystalReportViewer1.ReportSource.PrintOptions.ApplyPageMargins(margins)
            Catch ex As Exception

            End Try
            CrystalReportViewer1.ReportSource.PrintOptions.PrinterName = PortaImpressoraNFCe
            CrystalReportViewer1.ReportSource.PrintToPrinter(1, False, 0, 0)
        End If
    End Sub


    'Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
    '    Select Case Me.XtraTabControl1.SelectedTabPageIndex
    '        Case 0
    '            Me.btnConsultaChave.Checked = False
    '            Me.btnInutilizar.Checked = False
    '            Me.btnCancelar.Checked = False
    '            Me.btnImprimir.Checked = False

    '        Case 1
    '            Me.btnImprimir.Checked = False
    '            Me.btnConsultaChave.Checked = False
    '            Me.btnInutilizar.Checked = False
    '            Me.btnCancelar.Checked = False
    '            Me.btnImprimir.Checked = True

    '        Case 2
    '            Me.btnConsultaChave.Checked = False
    '            Me.btnInutilizar.Checked = False
    '            Me.btnCancelar.Checked = False
    '            Me.btnImprimir.Checked = False
    '            Me.btnConsultaChave.Checked = True
    '        Case 3
    '            Me.btnCancelar.Checked = False
    '            Me.btnConsultaChave.Checked = False
    '            Me.btnInutilizar.Checked = False
    '            Me.btnImprimir.Checked = False
    '            Me.btnCancelar.Checked = True

    '        Case 4
    '            Me.btnInutilizar.Checked = False
    '            Me.btnConsultaChave.Checked = False
    '            Me.btnCancelar.Checked = False
    '            Me.btnImprimir.Checked = False
    '            Me.btnInutilizar.Checked = True
    '    End Select

    'End Sub

    Private Sub btnCancelarNFCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarNFCe.Click

        If grd1.RowCount = 0 Then Exit Sub
        Dim Index As Integer = grd1.FocusedRowHandle

        If Index < 0 Then Exit Sub

        Dim strCodOrdem As String = Me.grd1.GetRowCellDisplayText(Index, Me.colCodOrdem)
        Dim strChave As String = Me.grd1.GetRowCellDisplayText(Index, Me.colChave)
        Dim strNumNF As String = Me.grd1.GetRowCellDisplayText(Index, Me.colNumeroCupom)

        If strCodOrdem = "" Then
            MsgBox("Selecione uma nota!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM NFCe where ChaveCancelamento <>'' and CodOrdem = " & strCodOrdem & " and CodEmitente = " & CodEmitente)
        If dt.Rows.Count > 0 Then
            MsgBox("NFC-e ja cancelada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        frmCancelarNFe.strChave = strChave
        frmCancelarNFe.strCodOrdem = strCodOrdem
        frmCancelarNFe.strNumNF = strNumNF
        frmCancelarNFe.ShowDialog()

        CarregarNfce()
    End Sub

    Private Sub btnInutilizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInutilizacao.Click
        Dim strCodigo As String = ""
        Dim dt As DataTable = CarregarDataTable("SELECT CNPJ, CodUF, Serie FROM ConfigNfe where Codigo = " & CodEmitente)
        If dt.Rows.Count > 0 Then
            Dim strCNPJ As String = dt.Rows.Item(0).Item("CNPJ").ToString.Replace(".", "").Replace("/", "").Replace("-", "")
            Dim strModelo As String = "65"
            Dim strSerie As String = dt.Rows.Item(0).Item("Serie").ToString
            Dim strCodUF As String = dt.Rows.Item(0).Item("CodUF").ToString
            Try
                If Validar(Me.txtInicial) = False Then Exit Sub
                If Validar(Me.txtFinal) = False Then Exit Sub
                If Validar(Me.memMotivo) = False Then Exit Sub

                Dim strChave As String = ""
                If Me.txtInicial.Text = "" Then Exit Sub
                If Me.txtFinal.Text = "" Then Exit Sub
                Dim strNumInicial As String = Format(CInt(Me.txtInicial.Text), "000000000")

                Dim strNumFinal As String = Format(CInt(Me.txtFinal.Text), "000000000")

                Dim strAno As String = Format(CDate(Date.Today), "yy")


                strSerie = Format(CInt(strSerie), "000")
                strChave = strCodUF & strAno & strCNPJ & strModelo & strSerie & strNumInicial & strNumFinal
                '00 00 0000000000000 00 000 000000000 000000000


                Dim intQ As Integer = Me.memMotivo.Text.Length

                If intQ <= 15 Then
                    MsgBox("O motivo deve ter mais de 15 caracteres!", MsgBoxStyle.Information)
                    Exit Sub
                End If


                Dim intInicial As Integer = Me.txtInicial.Text
                Dim intFinal As Integer = Me.txtFinal.Text
                If intInicial > intFinal Then MsgBox("A Numeração Inicial não pode ser maior que Numeração Final!", MsgBoxStyle.Information) : Exit Sub


                clsNFCe.ImprimeInutilizacaoNFCe(strChave, Me.txtInicial.Text, Me.txtFinal.Text, Me.memMotivo.Text)







            Catch ex As Exception
                Exit Sub
            End Try
            frmProcesNfe.strUF = EstadoEmitente
            frmProcesNfe.strTipoAmb = TipoAmbiente
            frmProcesNfe.Tag = "Inut"
            frmProcesNfe.strCaminhoNfe = strCaminhoDaNfe
            frmProcesNfe.ShowDialog()

            If strArquivoProcessado = "OK" Then
                MsgBox("Inutilização salva com sucesso!", MsgBoxStyle.Information)

                Inserir("Insert Into Inutilizacao (NumInicial, NumFinal, Data Serie, Motivo, CodConfig, Chave, CodEmitente, Status, " & _
                " StatusEmitente) Values('" & Me.txtInicial.Text & "','" & Me.txtFinal.Text & "','" & Date.Now & "',''," & _
                " '" & Me.memMotivo.Text & "'," & CodConfig & ",'" & Me.txtChave.Text & "'," & CodEmitente & ",'','" & StatusEmitente & "')")

                Me.txtInicial.ResetText()
                Me.txtFinal.ResetText()
                Me.memMotivo.ResetText()
                
            ElseIf strArquivoProcessado = "NOK" Then
                MsgBox("A Nota Fiscal não foi emitida com sucesso!", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        Limpar()
        frmConfigNfe.ShowDialog()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstalacao.Click
        Limpar()
        frmInstalarSat.Tag = "NFCe"
        frmInstalarSat.ShowDialog()
    End Sub

    Private Sub btnAtualizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizacao.Click
        Atualizar("Update ConfigNfe set VersaoXml ='4.00'")
        VersaoXmlEvento = "1.00"
        VersaoXmlInutilizacao = "4.00"
        VersaoXmlConsulta = "4.00"
        VersaoXmlAutorizacao = "4.00"
        frmVersoes.ShowDialog()
    End Sub
End Class