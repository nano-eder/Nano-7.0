Imports Nano.clsFuncoes
Imports System.Text
Imports Nano.clsFuncoesBematech
Public Class frmConfigFiscal

    Private Sub frmConfigFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarDadosECF()

        If SATFiscal = True Then
            Me.LabelControl2.Visible = True
            Me.PanelControl2.Visible = True
            Me.XtraTabPage4.PageVisible = False

            Dim dt As DataTable = CarregarDataTable("SELECT Assinatura FROM ConfigECF group by Assinatura")
            Dim I As Integer
            Me.txtAssinatura.Properties.Items.Clear()
            Me.txtAssinatura.Properties.Items.Add("")
            For I = 0 To dt.Rows.Count - 1
                Me.txtAssinatura.Properties.Items.Add(dt.Rows.Item(I).Item("Assinatura"))
            Next

        End If
    End Sub
    Private Sub CarregarDadosECF()
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo, ChavePublica, ChavePrivada, CNPJ, IE, Cliche, " & _
         "Tipo, Modelo, Marca, NumeroSerie, NumeroECF, VersaoSB, DataSB, MFAdicional, Impressora, " & _
         "Computador, Assinatura, CodigoEquipamento, ImpDiretoSAT FROM ConfigECF where Computador = '" & My.Computer.Name & "' and CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then

            CodConfigECF = dt.Rows.Item(0).Item("Codigo").ToString
            ChavePublica = dt.Rows.Item(0).Item("ChavePublica").ToString
            ChavePrivada = dt.Rows.Item(0).Item("ChavePrivada").ToString
            CNPJECF = dt.Rows.Item(0).Item("CNPJ").ToString
            IEECF = dt.Rows.Item(0).Item("IE").ToString
            ClicheECF = dt.Rows.Item(0).Item("Cliche").ToString
            TipoECF = dt.Rows.Item(0).Item("Tipo").ToString
            ModeloECF = dt.Rows.Item(0).Item("Modelo").ToString
            MarcaECF = dt.Rows.Item(0).Item("Marca").ToString
            NumeroSerieECF = dt.Rows.Item(0).Item("NumeroSerie").ToString
            NumeroEcfECF = dt.Rows.Item(0).Item("NumeroECF").ToString
            VersaoSBECF = dt.Rows.Item(0).Item("VersaoSB").ToString
            DataSBECF = dt.Rows.Item(0).Item("DataSB").ToString
            MFAdicionalECF = dt.Rows.Item(0).Item("MFAdicional").ToString
            TipoImpressoraFiscal = dt.Rows.Item(0).Item("Impressora").ToString
            Me.cboImpressora.Text = TipoImpressoraFiscal
            ComputadorECF = dt.Rows.Item(0).Item("Computador").ToString
            AssinaturaAC = dt.Rows.Item(0).Item("Assinatura").ToString
            If SATFiscal = True Then
                CodigoEquipamento = dt.Rows.Item(0).Item("CodigoEquipamento").ToString
                ImpDiretoSAT = dt.Rows.Item(0).Item("ImpDiretoSAT")
            End If
           
            MDI.btnMenuFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
    End Sub

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click
        If MsgBox("Tem certeza que deseja gerar uma nova chave?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If NumeroSerieECF = "" Then MsgBox("Tem que salvar os dados do ecf primeiro!", MsgBoxStyle.Information) : Exit Sub
            Dim cChavePublica As String = Space(256)

            Dim cChavePrivada As String = Space(256)
            Retorno = genkkey(cChavePublica, cChavePrivada)

            Atualizar("UPDATE ConfigECF SET ChavePublica = '" & cChavePublica & "', ChavePrivada = '" & cChavePrivada & "' where NumeroSerie = '" & NumeroSerieECF & "' and CodConfig = " & CodConfig & "")
            CarregarDadosECF()

            MsgBox("Chave gerada com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If ChavePublica <> "" Then
            Me.txtChavePublica.Text = ChavePublica
            Me.txtChavePrivada.Text = ChavePrivada
        Else
            MsgBox("Chaves não geradas!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnConsultarDadosECF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarDadosECF.Click
        Me.txtEcfCNPJ.Text = CNPJECF
        Me.txtEcfIE.Text = IEECF
        Me.txtEcfCliche.Text = ClicheECF
        Me.txtEcfTipo.Text = TipoECF
        Me.txtEcfModelo.Text = ModeloECF
        Me.txtEcfMarca.Text = MarcaECF
        Me.txtEcfNumSerie.Text = NumeroSerieECF
        Me.txtEcfNumECF.Text = NumeroEcfECF
        Me.txtEcfVersaoSB.Text = VersaoSBECF
        Me.txtEcfDataSB.Text = DataSBECF
        Me.txtAssinatura.Text = AssinaturaAC
    End Sub

    Private Sub btnGerarDadosECF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarDadosECF.Click
        If Validar(Me.cboImpressora) = False Then Exit Sub

        If Me.cboImpressora.Text = "DARUMA" Then

            Dim strCNPJ As New StringBuilder(" ", 20)
            strCNPJ.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("90", strCNPJ)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfCNPJ.Text = strCNPJ.ToString.Trim

            Dim strIE As New StringBuilder(" ", 20)
            strIE.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("91", strIE)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfIE.Text = strIE.ToString.Trim

            Dim strClicheProprietario As New StringBuilder(" ", 219)
            strClicheProprietario.Length = 219
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("132", strClicheProprietario)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfCliche.Text = strClicheProprietario.ToString.Trim

            Dim strNumeroSerie As New StringBuilder(" ", 20)
            strNumeroSerie.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("77", strNumeroSerie)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfNumSerie.Text = strNumeroSerie.ToString.Trim

            Dim strMarca As New StringBuilder(" ", 2000)
            strMarca.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("80", strMarca)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strModelo As New StringBuilder(" ", 2000)
            strModelo.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("81", strModelo)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strTipo As New StringBuilder(" ", 2000)
            strTipo.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("79", strTipo)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Me.txtEcfMarca.Text = strMarca.ToString.Trim
            Me.txtEcfModelo.Text = strModelo.ToString.Trim
            Me.txtEcfTipo.Text = strTipo.ToString.Trim

            Dim strNumeroCaixa As New StringBuilder(" ", 2000)
            strNumeroCaixa.Length = 2
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("94", strNumeroCaixa)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfNumECF.Text = strNumeroCaixa.ToString.Trim

            Dim strVersaoFirmware As New StringBuilder(" ", 2000)
            strVersaoFirmware.Length = 6
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("137", strVersaoFirmware)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfVersaoSB.Text = strVersaoFirmware.ToString.Trim

            Dim strdataSWBasico As New StringBuilder(" ", 2000)
            strdataSWBasico.Length = 14
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("85", strdataSWBasico)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            'Dim strMFAdicional As New StringBuilder(2)
            'DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("85", strdataSWBasico)
            'DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfDataSB.Text = strdataSWBasico.ToString.Trim.Substring(0, 8) & " " & strdataSWBasico.ToString.Trim.Substring(8, 6)

            Me.txtMFAdicional.Text = ""



        Else


            Dim strCNPJ As String = Space(21)
            Retorno = Bematech_FI_CNPJMFD(strCNPJ)
            Me.txtEcfCNPJ.Text = strCNPJ

            Dim strIE As String = Space(20)
            Retorno = Bematech_FI_InscricaoEstadualMFD(strIE)
            Me.txtEcfIE.Text = strIE

            Dim strClicheProprietario As String = Space(187)
            Retorno = Bematech_FI_ClicheProprietario(strClicheProprietario)
            Me.txtEcfCliche.Text = strClicheProprietario

            Dim strNumeroSerie As String = Space(21)
            Retorno = Bematech_FI_NumeroSerieMFD(strNumeroSerie)
            Me.txtEcfNumSerie.Text = strNumeroSerie

            Dim strMarca As String = Space(16)
            Dim strModelo As String = Space(21)
            Dim strTipo As String = Space(8)
            Retorno = Bematech_FI_MarcaModeloTipoImpressoraMFD(strMarca, strModelo, strTipo)
            Me.txtEcfMarca.Text = strMarca
            Me.txtEcfModelo.Text = strModelo
            Me.txtEcfTipo.Text = strTipo

            Dim strNumeroCaixa As String = Space(5)
            Retorno = Bematech_FI_NumeroCaixa(strNumeroCaixa)
            Me.txtEcfNumECF.Text = strNumeroCaixa

            Dim strVersaoFirmware As String = Space(7)
            Retorno = Bematech_FI_VersaoFirmwareMFD(strVersaoFirmware)
            Me.txtEcfVersaoSB.Text = strVersaoFirmware

            Dim strdataUsuario As String = Space(21)
            Dim strdataSWBasico As String = Space(21)
            Dim strMFAdicional As String = Space(2)
            Retorno = Bematech_FI_DataHoraGravacaoUsuarioSWBasicoMFAdicional(strdataUsuario, strdataSWBasico, strMFAdicional)
            Me.txtEcfDataSB.Text = strdataSWBasico
            Me.txtMFAdicional.Text = strMFAdicional

        End If

    End Sub

    Private Sub btnSalvarEcf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarEcf.Click
        If Validar(Me.txtEcfNumSerie) = False Then Exit Sub
        Dim dt As DataTable
        If SATFiscal = True Then
            dt = CarregarDataTable("SELECT Codigo FROM ConfigECF where Computador = '" & My.Computer.Name & "' and CodConfig = " & CodConfig)

        Else
            dt = CarregarDataTable("SELECT Codigo FROM ConfigECF where NumeroSerie = '" & Me.txtEcfNumSerie.Text & "' and CodConfig = " & CodConfig)

        End If
        If dt.Rows.Count = 0 Then
            Inserir("INSERT INTO ConfigECF (CNPJ, IE, Cliche, Tipo, Modelo, Marca, NumeroSerie, NumeroECF, VersaoSB, " & _
            "DataSB, MFAdicional, CodigoEquipamento, CodConfig, Impressora, Computador, Assinatura, ImpDiretoSAT) VALUES('" & Me.txtEcfCNPJ.Text & "'," & _
            "'" & Me.txtEcfIE.Text & "','" & Me.txtEcfCliche.Text & "','" & Me.txtEcfTipo.Text & "','" & Me.txtEcfModelo.Text & "', " & _
            "'" & Me.txtEcfMarca.Text & "','" & Me.txtEcfNumSerie.Text & "','" & Me.txtEcfNumECF.Text & "', " & _
            "'" & Me.txtEcfVersaoSB.Text & "','" & Me.txtEcfDataSB.Text & "','" & Me.txtMFAdicional.Text & "'," & _
            "'" & Me.txtCodigoEquipamento.Text & "'," & CodConfig & ",'" & Me.cboImpressora.Text & "','" & My.Computer.Name & "','" & Me.txtAssinatura.Text & "','" & Me.chkDireto.Checked & "')")
        Else
            Atualizar("UPDATE ConfigECF SET CNPJ = '" & Me.txtEcfCNPJ.Text & "', IE = '" & Me.txtEcfIE.Text & "', " & _
            "Cliche = '" & Me.txtEcfCliche.Text & "', Tipo = '" & Me.txtEcfTipo.Text & "', Modelo = '" & Me.txtEcfModelo.Text & "', " & _
            "Marca = '" & Me.txtEcfMarca.Text & "', NumeroSerie = '" & Me.txtEcfNumSerie.Text & "', NumeroECF = '" & Me.txtEcfNumECF.Text & "', " & _
            "VersaoSB = '" & Me.txtEcfVersaoSB.Text & "', DataSB = '" & Me.txtEcfDataSB.Text & "', MFAdicional = '" & Me.txtMFAdicional.Text & "'," & _
            "CodigoEquipamento = '" & Me.txtCodigoEquipamento.Text & "', Impressora = '" & Me.cboImpressora.Text & "', " & _
            "Computador = '" & My.Computer.Name & "', Assinatura = '" & Me.txtAssinatura.Text & "', ImpDiretoSAT = '" & Me.chkDireto.Checked & "' where NumeroSerie = '" & Me.txtEcfNumSerie.Text & "' and CodConfig = " & CodConfig)
        End If



        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
        CarregarDadosECF()
    End Sub

    Private Sub btnCarregarAliquota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarAliquota.Click
        AtualizarGridAliquota()
    End Sub

    Private Sub btnSalvarAliquota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarAliquota.Click
        If Me.txtCadAliquota.Text = "" Then Exit Sub
        Dim dblAliquota As Double = Me.txtCadAliquota.Text
        Dim strAliquota As String = dblAliquota.ToString("00.00").Replace(",", "").Replace(".", "")

        Dim I As Integer
        Dim bolSat As Boolean = True
        For I = 0 To Me.grd1.RowCount - 1
            Dim strAli As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquota).ToString.Replace(",", "").Replace(".", "")

            If strAliquota = strAli Then
                MsgBox("Aliquota já cadastrada!", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next
        If TipoImpressoraFiscal = "DARUMA" Then
            DarumaFiscal.iRetorno = DarumaFiscal.confCadastrar_ECF_Daruma("ALIQUOTA", strAliquota, "")
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
        Else

           
            Retorno = Bematech_FI_ProgramaAliquota(strAliquota, 0)


        End If
    End Sub
    Private Sub AtualizarGridAliquota()
        Me.tbAliquota.Rows.Clear()
        Me.tbAliquotaBD.Rows.Clear()
        Dim strAliquota As String = ""
        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strAliquotasCad As New StringBuilder(" ", 150)
            strAliquotasCad.Length = 150
            DarumaFiscal.iRetorno = DarumaFiscal.rLerAliquotas_ECF_Daruma(strAliquotasCad)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strAliquota = strAliquotasCad.ToString.Trim
            strAliquota = strAliquota.Replace(";", ",").Replace("T", "")
            strAliquota = strAliquota.Substring(0, 79)
        Else
            Dim strAliquotasCad As String = Space(80)
            Retorno = Bematech_FI_RetornoAliquotas(strAliquotasCad)
            strAliquota = strAliquotasCad
        End If


        Dim vetAliquota As Array = Split(strAliquota.Trim, ",")

        Dim I As Integer
        Dim A As Integer = 0
        For I = 0 To vetAliquota.Length - 1
            Dim strAli As String = vetAliquota(I)
            Dim strValor As String = FormatarValor(strAli)
            If strValor <> "0000" And strValor <> "0,00" Then
                Me.tbAliquota.Rows.Add()
                Me.tbAliquota.Rows.Item(A).Item("Indica") = A + 1

                Me.tbAliquota.Rows.Item(A).Item("Aliquota") = strValor
                A += 1
            End If
        Next

        A = 0
        Dim B As Integer = 0
        Dim dtImp As DataTable = CarregarDataTable("SELECT convert(numeric(15,2),ICMS)as ICMS, sum(Codigo) FROM ImpostoProduto group by ICMS")
        Dim bolExite As Boolean = False
        For I = 0 To dtImp.Rows.Count - 1
            Dim strAliquotaImp As String = dtImp.Rows.Item(I).Item("ICMS").ToString.Replace(",", "").Replace(".", "")

            If strAliquotaImp <> "000" Then

                For A = 0 To Me.tbAliquota.Rows.Count - 1
                    Dim strAliEcf As String = Me.tbAliquota.Rows.Item(A).Item("Aliquota").ToString.Replace(",", "").Replace(".", "")
                    If strAliEcf = strAliquotaImp Then
                        bolExite = True
                    End If
                Next

                If bolExite = False Then
                    Me.tbAliquotaBD.Rows.Add()
                    Me.tbAliquotaBD.Rows.Item(B).Item("Indica") = B + 1
                    Me.tbAliquotaBD.Rows.Item(B).Item("Aliquota") = FormatarValor(strAliquotaImp)
                    B += 1
                End If
            End If

        Next
    End Sub
    Private Sub btnCarregarFormaPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarFormaPag.Click

        Me.tbFormaPag.Rows.Clear()
        Me.tbFormaPagBD.Rows.Clear()
        Dim strFormasPagamento As String = ""
        If TipoImpressoraFiscal = "DARUMA" Then

            Dim strFor As New StringBuilder(" ", 330)
            strFor.Length = 330
            DarumaFiscal.iRetorno = DarumaFiscal.rLerMeiosPagto_ECF_Daruma(strFor)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            strFormasPagamento = strFor.ToString.Trim.Replace(";", ",")
        Else
            Dim strFor As String = Space(3017)

            Retorno = Bematech_FI_VerificaFormasPagamento(strFor)
            strFormasPagamento = strFor
        End If

        Dim vetFormaPag As Array = Split(strFormasPagamento, ",")
        Dim I As Integer
        Dim A As Integer = 0
        For I = 0 To vetFormaPag.Length - 1
            If vetFormaPag(I).ToString = "" Then
                Exit For
            End If
            Dim strPag As String = ""

            If TipoImpressoraFiscal = "DARUMA" Then
                strPag = vetFormaPag(I).ToString.Trim
            Else
                strPag = vetFormaPag(I).ToString.Substring(0, 16)
            End If
            If strPag.Trim <> "" Then
                Me.tbFormaPag.Rows.Add()
                Me.tbFormaPag.Rows.Item(A).Item("Indice") = A + 1
                Me.tbFormaPag.Rows.Item(A).Item("FormaPag") = strPag.Trim
                A += 1
            End If

        Next

        A = 0
        Dim B As Integer = 0
        Dim dtImp As DataTable = CarregarDataTable("SELECT Descricao FROM Pagamento")
        Dim bolExite As Boolean = False
        For I = 0 To dtImp.Rows.Count - 1
            Dim strDescricao As String = dtImp.Rows.Item(I).Item("Descricao").ToString
            bolExite = False

            For A = 0 To Me.tbFormaPag.Rows.Count - 1
                Dim strFormaPag As String = Me.tbFormaPag.Rows.Item(A).Item("FormaPag").ToString
                If strFormaPag = strDescricao Then
                    bolExite = True
                    Exit For
                End If
            Next

            If bolExite = False Then
                Me.tbFormaPagBD.Rows.Add()
                Me.tbFormaPagBD.Rows.Item(B).Item("Indice") = B + 1
                Me.tbFormaPagBD.Rows.Item(B).Item("FormaPag") = strDescricao
                B += 1
            End If


        Next
    End Sub

    Private Sub pnlConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlConfig.Click
        Select Case Me.pnlConfig.SelectedTabPageIndex
            Case 2
                If Me.cboImpressora.Text = "DARUMA" Then

                End If
        End Select
    End Sub

    
    Private Sub btnPagSat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagSat.Click
        CadastrarFormasPagamento("Dinheiro")
        CadastrarFormasPagamento("Cheque")
        CadastrarFormasPagamento("Cartao Credito")
        CadastrarFormasPagamento("Cartao Debito")
        CadastrarFormasPagamento("Credito Loja")
        CadastrarFormasPagamento("Vale Presente")

    End Sub


End Class