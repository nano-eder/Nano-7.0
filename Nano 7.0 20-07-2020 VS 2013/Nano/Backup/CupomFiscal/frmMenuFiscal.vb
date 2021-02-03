Imports Nano.clsFuncoes
Imports Nano.clsFuncoesBematech
Imports System.Text
Public Class frmMenuFiscal


    Private Sub btnLX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLX.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "LX"
        frm.ShowDialog()

    End Sub


    Private Sub btnLMFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLMFC.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "LMFC"
        frm.ShowDialog()
    End Sub

    Private Sub btnLMFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLMFS.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "LMFS"
        frm.ShowDialog()
    End Sub

    Private Sub btnEspelho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEspelho.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "Espelho"
        frm.ShowDialog()
    End Sub

    Private Sub btnArqMDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArqMDF.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "ArquivoMFD"
        frm.ShowDialog()
    End Sub

    Private Sub btnMeioPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeioPag.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "MeioPag"
        frm.ShowDialog()
    End Sub

    Private Sub btnDavEmitido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDavEmitido.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "DAV"
        frm.ShowDialog()
    End Sub

    Private Sub nbiMenuFiscal_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiMenuFiscal.LinkClicked
        Painel("MenuFiscal")
    End Sub

    Private Sub nbiECF_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiECF.LinkClicked
        Painel("ECF")
    End Sub
    Private Sub Painel(ByVal parPainel As String)
        Me.pnlMenuFiscal.Visible = False
        Me.pnlInf.Visible = False
        Me.pnlCaixa.Visible = False
        Me.pnlConfig.Visible = False
        Select Case parPainel

            Case "MenuFiscal"

                Me.pnlMenuFiscal.Visible = True
            Case "ECF"
                Me.pnlInf.Visible = True

            Case "Caixa"
                Me.pnlCaixa.Visible = True
            Case "Config"
                Me.pnlConfig.Visible = True
        End Select
    End Sub

    Private Sub btnAtualizarECF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarECF.Click
        Me.txtCnpj.Text = CNPJECF
        Me.txtIE.Text = IEECF
        Me.memCliche.Text = ClicheECF
        Me.txtTipo.Text = TipoECF
        Me.txtModelo.Text = ModeloECF
        Me.txtMarca.Text = MarcaECF
        Me.txtNumSerie.Text = NumeroSerieECF
        Me.txtNumECF.Text = NumeroEcfECF
        Me.txtVersaoSB.Text = VersaoSBECF
        Me.txtDataSB.Text = DataSBECF

        If TipoImpressoraFiscal = "DARUMA" Then
            Dim strCOO As New StringBuilder(" ", 7)
            strCOO.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("26", strCOO)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCOO.Text = strCOO.ToString.Trim

            Dim strCRO As New StringBuilder(" ", 7)
            strCRO.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("23", strCRO)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCRO.Text = strCRO.ToString.Trim

            Dim strCC As New StringBuilder(" ", 13)
            strCC.Length = 13
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("13", strCC)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCC.Text = strCC.ToString.Trim

            Dim strCCF As New StringBuilder(" ", 7)
            strCCF.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("30", strCCF)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCCF.Text = strCCF.ToString.Trim

            Dim strCRZ As New StringBuilder(" ", 7)
            strCRZ.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("24", strCRZ)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCRZ.Text = strCRZ.ToString.Trim

            Dim strCRZ_R As New StringBuilder(" ", 7)
            strCRZ_R.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("25", strCRZ_R)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCRZ_R.Text = strCRZ_R.ToString.Trim

            Dim strGNF As New StringBuilder(" ", 7)
            strGNF.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("28", strGNF)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtGNF.Text = strGNF.ToString.Trim

            Dim strCDC As New StringBuilder(" ", 7)
            strCDC.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("45", strCDC)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtCDC.Text = strCDC.ToString.Trim

            Dim strGRG As New StringBuilder(" ", 7)
            strGRG.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("33", strGRG)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtGRG.Text = strGRG.ToString.Trim

            Dim strGT As New StringBuilder(" ", 18)
            strGT.Length = 18
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("1", strGT)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtGT.Text = strGT.ToString.Trim


            Dim strDataReducao As New StringBuilder(" ", 14)
            strDataReducao.Length = 14
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("154", strDataReducao)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtDataUltimaRZ.Text = strDataReducao.ToString.Trim.Substring(0, 8) & " " & strDataReducao.ToString.Trim.Substring(8, 6)


            Dim strData As New StringBuilder(" ", 14)
            strData.Length = 14
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("66", strData)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtDataHoraECF.Text = strData.ToString.Trim.Substring(0, 8) & " " & strData.ToString.Trim.Substring(8, 6)

            Dim strDataMovimento As New StringBuilder(" ", 8)
            strDataMovimento.Length = 8
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("70", strDataMovimento)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtDataUltimoMov.Text = strDataMovimento.ToString.Trim

            Dim strAliquotasCad As New StringBuilder(" ", 150)
            strAliquotasCad.Length = 150
            DarumaFiscal.iRetorno = DarumaFiscal.rLerAliquotas_ECF_Daruma(strAliquotasCad)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtAliquotasCad.Text = strAliquotasCad.ToString.Trim

            Dim strHorarioV As New StringBuilder(" ", 1)
            strHorarioV.Length = 1
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("108", strHorarioV)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Select Case strHorarioV.ToString
                Case "1"
                    Me.txtVerao.Text = "Habilitado"
                Case Else
                    Me.txtVerao.Text = "Desabilitado"
            End Select



        Else



            Dim strCOO As String = Space(7)
            Retorno = Bematech_FI_NumeroCupom(strCOO)
            Me.txtCOO.Text = strCOO

            Dim strCRO As String = Space(5)
            Retorno = Bematech_FI_NumeroIntervencoes(strCRO)
            Me.txtCRO.Text = strCRO

            Dim strCC As String = Space(5)
            Retorno = Bematech_FI_NumeroCuponsCancelados(strCC)
            Me.txtCC.Text = strCC

            Dim strCCF As String = Space(7)
            Retorno = Bematech_FI_ContadorCupomFiscalMFD(strCCF)
            Me.txtCCF.Text = strCCF

            Dim strCRZ As String = Space(5)
            Retorno = Bematech_FI_NumeroReducoes(strCRZ)
            Me.txtCRZ.Text = strCRZ

            Dim strCRZ_R As String = Space(5)
            Retorno = Bematech_FI_ReducoesRestantesMFD(strCRZ_R)
            Me.txtCRZ_R.Text = strCRZ_R

            Dim strGNF As String = Space(7)
            Retorno = Bematech_FI_NumeroOperacoesNaoFiscais(strGNF)
            Me.txtGNF.Text = strGNF

            Dim strCDC As String = Space(5)
            Retorno = Bematech_FI_ContadorComprovantesCreditoMFD(strCDC)
            Me.txtCDC.Text = strCDC

            Dim strGRG As String = Space(7)
            Retorno = Bematech_FI_ContadorRelatoriosGerenciaisMFD(strGRG)
            Me.txtGRG.Text = strGRG

            Dim strGT As String = Space(19)
            Retorno = Bematech_FI_GrandeTotal(strGT)
            Me.txtGT.Text = strGT


            Dim strDataReducao As String = Space(7)
            Dim strHoraReducao As String = Space(7)
            Retorno = Bematech_FI_DataHoraReducao(strDataReducao, strHoraReducao)
            Me.txtDataUltimaRZ.Text = strDataReducao & " " & strHoraReducao

            Dim strData As String = Space(7)
            Dim strHora As String = Space(7)
            Retorno = Bematech_FI_DataHoraImpressora(strData, strHora)
            Me.txtDataHoraECF.Text = strData & " " & strHora

            Dim strDataMovimento As String = Space(7)
            Retorno = Bematech_FI_DataMovimento(strDataMovimento)
            Me.txtDataUltimoMov.Text = strDataMovimento

            Dim strAliquotasCad As String = Space(80)
            Retorno = Bematech_FI_RetornoAliquotas(strAliquotasCad)
            Me.txtAliquotasCad.Text = strAliquotasCad

            Dim intFlag As Integer
            Retorno = Bematech_FI_FlagsFiscais(intFlag)

            Select Case intFlag
                Case 4, 12, 13, 15, 20, 21, 23, 36, 37, 39, 44, 45, 47, 132, 133, 135, 164, 165, 167, 172, 173, 175
                    Me.txtVerao.Text = "Habilitado"
                Case Else
                    Me.txtVerao.Text = "Desabilitado"
            End Select

        End If
        

    End Sub

    Private Sub btnNFP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNFP.Click
        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "NFP"
        frm.ShowDialog()
    End Sub

    Private Sub btnIndPAF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndPAF.Click

    End Sub

    Private Sub nbgCaixa_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgCaixa.ItemChanged
        If Me.nbgCaixa.Expanded = True Then
            Painel("Caixa")
        Else
            Me.pnlCaixa.Visible = False
        End If
    End Sub


    Private Sub frmMenuFiscal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If VerificaImpressora() = True Then
            VerificarAberturaFechamento(False)
        End If


        Me.pnlInf.Dock = DockStyle.Fill
        Me.pnlMenuFiscal.Dock = DockStyle.Fill
        Me.pnlCaixa.Dock = DockStyle.Fill
        Me.pnlConfig.Dock = DockStyle.Fill

        Me.pnlInf.Visible = False
        Me.pnlCaixa.Visible = False
        Me.pnlMenuFiscal.Visible = False
        Me.pnlConfig.Visible = False

        Me.lblOperador.Caption = "Operador: " & Login
        Timer1.Start()
        'CarregarDadosECF()
 
    End Sub
    Private Sub CarregarDadosECF()
        Dim dt As DataTable = CarregarDataTable("SELECT ChavePublica, ChavePrivada, CNPJ, IE, Cliche, " & _
         "Tipo, Modelo, Marca, NumeroSerie, NumeroECF, VersaoSB, DataSB, MFAdicional FROM ConfigECF where CodConfig = " & CodConfig)
        If dt.Rows.Count > 0 Then
            If dt.Rows.Item(0).Item("ChavePublica").ToString <> "" Then
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
            End If
        End If
    End Sub
    Private Sub nbgECF_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgECF.ItemChanged
        If Me.nbgECF.Expanded = True Then
            Painel("ECF")
        Else
            Me.pnlInf.Visible = False
        End If
    End Sub

    Private Sub nbgMenuFiscal_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgMenuFiscal.ItemChanged

        If Me.nbgMenuFiscal.Expanded = True Then
            Painel("MenuFiscal")
        Else
            Me.pnlMenuFiscal.Visible = False
        End If
    End Sub

    Private Sub btnAtualizaCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizaCaixa.Click
        Me.txtEntradaOp.Text = "0,00"
        Me.txtEntradaDia.Text = "0,00"
        Me.txtSuprimentoOp.Text = "0,00"
        Me.txtSuprimentoDia.Text = "0,00"
        Me.txtSangriaDia.Text = "0,00"
        Me.txtSangriaOp.Text = "0,00"
        Me.txtVendaOp.Text = "0,00"
        Me.txtVendaDia.Text = "0,00"
        Me.txtTotalCaixaDia.Text = "0,00"
        Me.txtTotalCaixaOp.Text = "0,00"
        Me.txtOperador.ResetText()
        Me.txtDataHoraOp.ResetText()
        Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today, Date.Today.AddDays(1))

        Dim dt As DataTable = CarregarDataTable("SELECT Operador, Data, Tipo FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and Tipo <> 'Suprimento' and Tipo <> 'Sangria' and Tipo <> 'ValorLiquido' and CodConfig = " & CodConfig & " order by Codigo DESC")
        Dim I As Integer
        If dt.Rows.Count > 0 Then
            Dim strTipoOp As String = dt.Rows.Item(0).Item("Tipo").ToString
            If strTipoOp = "Entrada" Then
                Me.txtOperador.Text = dt.Rows.Item(0).Item("Operador").ToString
                Me.txtDataHoraOp.Text = dt.Rows.Item(0).Item("Data").ToString

                Dim strData2 As String = String.Format("Data >= '{0:dd/MM/yyyy HH:mm:ss}' AND Data <= '{1:dd/MM/yyyy}'", Me.txtDataHoraOp.Text, Date.Today.AddDays(1))

                dt = CarregarDataTable("SELECT Tipo, sum(Entrada) as Valor FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData2 & " and Operador = '" & Me.txtOperador.Text & "' and CodConfig = " & CodConfig & " group by Tipo")
                If dt.Rows.Count > 0 Then
                    Dim dblValorSangria As Double = 0
                    Dim dblTotalCaixa As Double = 0
                    For I = 0 To dt.Rows.Count - 1
                        Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
                        If dt.Rows.Item(I).Item("Valor").ToString <> "" Then
                            Select Case strTipo
                                Case "Entrada"
                                    Me.txtEntradaOp.Text = dt.Rows.Item(I).Item("Valor").ToString
                                    dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                                Case "Saida"
                                    dblValorSangria += dt.Rows.Item(I).Item("Valor").ToString
                                    dblTotalCaixa -= dt.Rows.Item(I).Item("Valor").ToString
                                Case "Sangria"
                                    dblValorSangria += dt.Rows.Item(I).Item("Valor").ToString
                                    dblTotalCaixa -= dt.Rows.Item(I).Item("Valor").ToString
                                Case "Suprimento"
                                    Me.txtSuprimentoOp.Text = dt.Rows.Item(I).Item("Valor").ToString
                                    dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                                Case "ValorLiquido"
                                    Me.txtVendaOp.Text = dt.Rows.Item(I).Item("Valor").ToString
                                    dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                            End Select
                        End If

                    Next
                    Me.txtSangriaOp.Text = dblValorSangria.ToString("0.00")
                    Me.txtTotalCaixaOp.Text = dblTotalCaixa.ToString("0.00")
                End If
            End If
            

            dt = CarregarDataTable("SELECT Tipo, sum(Entrada) as Valor FROM Operador where CodConfigECF = " & CodConfigECF & " and " & strData & " and CodConfig = " & CodConfig & " group by Tipo")
            If dt.Rows.Count > 0 Then
                Dim dblValorSangria As Double = 0
                Dim dblTotalCaixa As Double = 0
                For I = 0 To dt.Rows.Count - 1

                    Dim strTipo As String = dt.Rows.Item(I).Item("Tipo").ToString
                    If dt.Rows.Item(I).Item("Valor").ToString <> "" Then
                        Select Case strTipo
                            Case "Entrada"

                                Me.txtEntradaDia.Text = dt.Rows.Item(I).Item("Valor").ToString
                                dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                            Case "Saida"
                                dblValorSangria += dt.Rows.Item(I).Item("Valor").ToString
                                dblTotalCaixa -= dt.Rows.Item(I).Item("Valor").ToString
                            Case "Sangria"
                                dblValorSangria += dt.Rows.Item(I).Item("Valor").ToString
                                dblTotalCaixa -= dt.Rows.Item(I).Item("Valor").ToString
                            Case "Suprimento"
                                Me.txtSuprimentoDia.Text = dt.Rows.Item(I).Item("Valor").ToString
                                dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                            Case "ValorLiquido"
                                Me.txtVendaDia.Text = dt.Rows.Item(I).Item("Valor").ToString
                                dblTotalCaixa += dt.Rows.Item(I).Item("Valor").ToString
                        End Select
                    End If

                Next
                Me.txtSangriaDia.Text = dblValorSangria.ToString("0.00")
                Me.txtTotalCaixaDia.Text = dblTotalCaixa.ToString("0.00")
            End If
        End If

    End Sub
    Private Function AcrescentarVirgula(ByVal parValor As String) As String
        If parValor = "" Then
            Return ""
            Exit Function
        End If
        Dim intQ As Integer = parValor.Length

        Dim strValor As String = ""
        Select Case intQ
            Case 1
                strValor = "00,0" & parValor
            Case 2
                strValor = "00," & parValor
            Case Else
                intQ = intQ - 3
                Dim I As Integer
                For I = 0 To parValor.Length - 1
                    strValor &= parValor.Substring(I, 1)

                    If I = intQ Then
                        strValor &= ","
                    End If
                Next
        End Select

        Return strValor
    End Function

    Private Sub nbiEntradaOperador_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEntradaOperador.LinkClicked
        If VerificarAberturaFechamento(False) = False Then
            frmAbertura.Tag = "Entrada"
            frmAbertura.ShowDialog()
        End If
      
    End Sub

    Private Sub nbiSangria_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSangria.LinkClicked
        If VerificarAberturaFechamento(False) = False Then
            frmAbertura.Tag = "Sangria"
            frmAbertura.ShowDialog()
        End If
    
    End Sub

    Private Sub nbiSuprimento_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSuprimento.LinkClicked
        If VerificarAberturaFechamento(False) = False Then
            frmAbertura.Tag = "Suprimento"
            frmAbertura.ShowDialog()
        End If
  
    End Sub

    Private Sub nbiSaidaOperador_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSaidaOperador.LinkClicked
        If VerificarAberturaFechamento(False) = False Then
            frmAbertura.Tag = "Saida"
            frmAbertura.ShowDialog()
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

    Private Sub btnGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerar.Click
        If MsgBox("Tem certeza que deseja gerar uma nova chave?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cChavePublica As String = Space(256)

            Dim cChavePrivada As String = Space(256)
            Retorno = genkkey(cChavePublica, cChavePrivada)

            Atualizar("UPDATE ConfigECF SET ChavePublica = '" & cChavePublica & "', ChavePrivada = '" & cChavePrivada & "' where CodConfig = " & CodConfig & "")
            CarregarDadosECF()

            MsgBox("Chave gerada com sucesso!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub nbiConfig_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiConfig.LinkClicked
        Painel("Config")
    End Sub

    Private Sub nbgConfig_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbgConfig.ItemChanged
        If Me.nbgConfig.Expanded = True Then
            Painel("Config")
        Else
            Me.pnlConfig.Visible = False
        End If
    End Sub

    Private Sub btnEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstoque.Click
        Dim strTexto As String = ""
        Dim strCNPJ As String
        strCNPJ = CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "").Trim
        strTexto = "E1" & strCNPJ & IEECF.Replace(".", "").Trim & vbCrLf

        Dim dt As DataTable = CarregarDataTable("SELECT CodigoInterno, Nome, sum(Qtd) as Qtd, UnidadeMedida, Data FROM Produto left join Qtde on Produto.Codigo = Qtde.CodProd where Qtde.CodConfig = " & CodConfig & " group by CodigoInterno, Nome, UnidadeMedida, Data")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim intQtd As Integer = dt.Rows.Item(I).Item("Qtd").ToString
            Dim strUM As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
            Dim strData As Date = dt.Rows.Item(I).Item("Data").ToString
            Dim strDataEst As String = Format(strData, "yyyyMMdd")
            Dim strMensuracao As String = "+"
            If intQtd < 0 Then
                strMensuracao = "-"
            End If
            strTexto &= "E2" & Espaco(strCNPJ, 14, True) & Espaco(strCodigoInterno, 14, False) & Espaco(strProduto, 50, False) & Espaco(strUM, 6, False) & strMensuracao & Espaco(intQtd, 9, True) & Espaco(strDataEst, 8, False) & vbCrLf

        Next

        strTexto &= "E9" & strCNPJ & Espaco(IEECF.Replace(".", ""), 14, False) & Espaco(dt.Rows.Count, 6, True) & vbCrLf


        'strTexto &= "EAD" & ChavePublica

        If TipoImpressoraFiscal = "DARUMA" Then
            EscreveArquivo("C:\NFP DARUMA\ESTOQUE.txt", strTexto)
            AssinarArquivo("C:\NFP DARUMA\ESTOQUE.txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP DARUMA\ESTOQUE.txt", MsgBoxStyle.Information)
        Else
            EscreveArquivo("C:\NFP\ESTOQUE.txt", strTexto)
            AssinarArquivo("C:\NFP\ESTOQUE.txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP\ESTOQUE.txt", MsgBoxStyle.Information)

        End If
    
       
    End Sub

    Private Sub btnMovPorECF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovPorECF.Click

        Dim frm As New frmDadosMenuFiscal
        frm.Tag = "MOVIMENTACAO"
        frm.ShowDialog()

    End Sub

    Private Sub btnTabProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTabProd.Click
        Dim strTexto As String = ""
        Dim strCNPJ As String 
        strCNPJ = CNPJECF.Replace(".", "").Replace("/", "").Replace("-", "").Trim
        strTexto = "P1" & strCNPJ & IEECF.Replace(".", "").Trim & vbCrLf

        Dim dt As DataTable = CarregarDataTable("SELECT CodigoInterno, Nome, UnidadeMedida, Data, convert(numeric(15,2), Valor) as Valor, convert(numeric(15,2),ICMS) as ICMS, Tributacao, Cst, IPPT FROM Produto left join ImpostoProduto on Produto.Codigo = ImpostoProduto.CodProd")
        Dim I As Integer
        For I = 0 To dt.Rows.Count - 1
            Dim strCodigoInterno As String = dt.Rows.Item(I).Item("CodigoInterno").ToString
            Dim strProduto As String = dt.Rows.Item(I).Item("Nome").ToString
            Dim strUM As String = dt.Rows.Item(I).Item("UnidadeMedida").ToString
            Dim strData As Date = dt.Rows.Item(I).Item("Data").ToString
            Dim strValor As String = dt.Rows.Item(I).Item("Valor").ToString
            Dim strDataEst As String = Format(strData, "yyyyMMdd")
            Dim strIcms As String = dt.Rows.Item(I).Item("ICMS").ToString
            Dim strTributacao As String = dt.Rows.Item(I).Item("Tributacao").ToString
            Dim strIPPT As String = dt.Rows.Item(I).Item("IPPT").ToString
            Dim strCst As String = dt.Rows.Item(I).Item("Cst").ToString
            Dim strIAT As String = "T"
            strTexto &= "P2" & Espaco(strCNPJ, 14, True) & Espaco(strCodigoInterno, 14, False) & Espaco(strProduto, 50, False) & Espaco(strUM, 6, False) & strIAT & Espaco(strIPPT, 1, False) & Espaco(strTributacao, 1, False)
            strTexto &= Espaco(strIcms, 4, True) & Espaco(strValor, 12, True) & vbCrLf
        Next

        strTexto &= "P9" & strCNPJ & Espaco(IEECF.Replace(".", ""), 14, False) & Espaco(dt.Rows.Count, 6, True) & vbCrLf

        'strTexto &= "EAD" & ChavePublica
        If TipoImpressoraFiscal = "DARUMA" Then
            EscreveArquivo("C:\NFP DARUMA\TAB_PRODUTO.txt", strTexto)
            AssinarArquivo("C:\NFP DARUMA\TAB_PRODUTO.txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP DARUMA\TAB_PRODUTO.txt", MsgBoxStyle.Information)
        Else
            EscreveArquivo("C:\NFP\TAB_PRODUTO.txt", strTexto)
            AssinarArquivo("C:\NFP\TAB_PRODUTO.txt")
            MsgBox("Arquivo emitido com sucesso!" & vbCrLf & "C:\NFP\TAB_PRODUTO.txt", MsgBoxStyle.Information)
        End If
     
    End Sub

    Private Sub nbiFechamento_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFechamento.LinkClicked

        If VerificaAbertura("Operador") = False Then Exit Sub

        VerificarAberturaFechamento(True)

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

    End Sub

    Private Sub btnGerarDadosECF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarDadosECF.Click
        If TipoImpressoraFiscal = "DARUMA" Then
           
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

            Dim strMarca As New StringBuilder(" ", 20)
            strMarca.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("80", strMarca)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strModelo As New StringBuilder(" ", 20)
            strModelo.Length = 20
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("81", strModelo)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Dim strTipo As New StringBuilder(" ", 7)
            strTipo.Length = 7
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("79", strTipo)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)

            Me.txtEcfMarca.Text = strMarca.ToString.Trim
            Me.txtEcfModelo.Text = strModelo.ToString.Trim
            Me.txtEcfTipo.Text = strTipo.ToString.Trim

            Dim strNumeroCaixa As New StringBuilder(" ", 2)
            strNumeroCaixa.Length = 2
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("94", strNumeroCaixa)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfNumECF.Text = strNumeroCaixa.ToString.Trim

            Dim strVersaoFirmware As New StringBuilder(" ", 6)
            strVersaoFirmware.Length = 6
            DarumaFiscal.iRetorno = DarumaFiscal.rRetornarInformacao_ECF_Daruma("137", strVersaoFirmware)
            DarumaFiscal.TrataRetorno(DarumaFiscal.iRetorno)
            Me.txtEcfVersaoSB.Text = strVersaoFirmware.ToString.Trim

            Dim strdataSWBasico As New StringBuilder(" ", 14)
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

    Private Sub btnFecha_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFecha.ItemClick
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblData.Caption = My.Computer.Clock.LocalTime
    End Sub

    Private Sub nbiCancelaCupom_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCancelaCupom.LinkClicked
        CancelarCupom(False, "")
      
    End Sub

    Private Sub btnSalvarEcf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarEcf.Click
        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ConfigECF where CodConfig = " & CodConfig)
        If dt.Rows.Count = 0 Then
            Inserir("INSERIR ConfigECF (CNPJ, IE, Cliche, Tipo, Modelo, Marca, NumeroSerie, NumeroECF, VersaoSB, " & _
            "DataSB, MFAdicional, CodigoEquipamento, CodConfig) VALUES('" & Me.txtEcfCNPJ.Text & "'," & _
            "'" & Me.txtEcfIE.Text & "','" & Me.txtEcfCliche.Text & "','" & Me.txtEcfTipo.Text & "','" & Me.txtEcfModelo.Text & "', " & _
            "'" & Me.txtEcfMarca.Text & "','" & Me.txtEcfNumSerie.Text & "','" & Me.txtEcfNumECF.Text & "', " & _
            "'" & Me.txtEcfVersaoSB.Text & "','" & Me.txtEcfDataSB.Text & "','" & Me.txtMFAdicional.Text & "'," & _
            "'" & Me.txtCodigoEquipamento.Text & "'," & CodConfig & ")")
        Else
            Atualizar("UPDATE ConfigECF SET CNPJ = '" & Me.txtEcfCNPJ.Text & "', IE = '" & Me.txtEcfIE.Text & "', " & _
            "Cliche = '" & Me.txtEcfCliche.Text & "', Tipo = '" & Me.txtEcfTipo.Text & "', Modelo = '" & Me.txtEcfModelo.Text & "', " & _
            "Marca = '" & Me.txtEcfMarca.Text & "', NumeroSerie = '" & Me.txtEcfNumSerie.Text & "', NumeroECF = '" & Me.txtEcfNumECF.Text & "', " & _
            "VersaoSB = '" & Me.txtEcfVersaoSB.Text & "', DataSB = '" & Me.txtEcfDataSB.Text & "', MFAdicional = '" & Me.txtMFAdicional.Text & "'," & _
            "CodigoEquipamento = '" & Me.txtCodigoEquipamento.Text & "' where CodConfig = " & CodConfig)
        End If

   

        MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information)
        CarregarDadosECF()
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
    Private Sub btnCarregarAliquota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarAliquota.Click
        AtualizarGridAliquota()
    End Sub

    Private Sub btnSalvarAliquota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarAliquota.Click
        If Me.txtCadAliquota.Text = "" Then Exit Sub
        Dim dblAliquota As Double = Me.txtCadAliquota.Text
        Dim strAliquota As String = dblAliquota.ToString("0.00").Replace(",", "").Replace(".", "")

        Dim I As Integer

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


            For A = 0 To Me.tbFormaPag.Rows.Count - 1
                Dim strFormaPag As String = Me.tbFormaPag.Rows.Item(A).Item("FormaPag").ToString
                If strFormaPag = strDescricao Then
                    bolExite = True
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
End Class