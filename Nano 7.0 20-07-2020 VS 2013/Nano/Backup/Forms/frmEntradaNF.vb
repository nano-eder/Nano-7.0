Imports Nano.clsFuncoes
Imports Nano.clsDarBaixa
Imports Nano.clsNfeXml
Imports Nano.clsGerarArqsNfe
Public Class frmEntradaNF
    Dim bolDecimais As Boolean
    Dim bolAlterado As Boolean = False
    Dim IndexGrid As Integer
    Dim strBCIcms As String
    Dim strIPI As String
    Dim strTemFocus As String = ""
    Dim intCodFornecedor As Integer
    Dim strUM As String
    Dim intCodConfig As Integer

    Dim intCodigoTotalNF As Integer
    Dim intCodigoConfig As Integer
    Dim strItensDeletado As String
    Dim strLoteTotal As String
    Public strCodigoFornecedor As String
    Dim strCodigoBarra As String
    Dim strCodigoInterno As String
    Dim ContaPagarGerada As Boolean = False

    Public strValorContaPagar As String = ""
    Public vetParcela As Array = Nothing
    Dim bolLimpar As Boolean = False
    Dim strRegimeNfeGeral, strCstNfeGeral, strOrigemNfeGeral, strCalcCredNfeGeral, strModBCNfeGeral, _
      strRedBCNfeGeral, strIcmsNfeGeral, strModBCSTNfeGeral, strRedBCSTNfeGeral, strIcmsSTNfeGeral, _
      strMVaSTNfeGeral, strCFOPGeral, strEXTIPIGeral, strNCMGeral, strGeneroGeral, strCodigoANPGeral, strUFCombGeral As String
    Dim strCSTIPIGeral, strPerIPIGeral, strCodEnqGeral, strCSPPISGeral, strPerPISGeral, strCSTCOFINSGeral, strPerCOFINSGeral As String

    Public strNCMGeral2 As String

    Private Sub frmEntradaNF_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.grd1.RowCount > 0 Then
            If MsgBox("Deseja realmente fechar a tela?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmEntradaNF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                If VerificaHelp() = True Then
                    Help.ShowHelp(Me, My.Application.Info.DirectoryPath & "\HelpNanoCommerce.chm", HelpNavigator.TopicId, "17")
                End If
            Catch ex As Exception
                MsgBox("Erro ao abrir: Ajuda do Sistema Indisponível.", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub frmEntradaNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtVal.CasasDecimais = CasaDecimal
        If TipoNano = 5 Then
            Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANOAutomotivo
            'Me.colSetor.Caption = "Marca"
        End If
        If TesteConexao() = False Then Exit Sub
        Limpar()
        Select Case ImpostoPorItem
            Case False
                Me.txtIPIItem.Visible = False
                Me.txtICMSItem.Visible = False
                Me.lblICMS.Visible = False
                Me.lblIPI.Visible = False
                Me.txtMVaST.Visible = False
                Me.txtPorICMS.Visible = False
                Me.lblMVaST.Visible = False
                Me.lblPorICMS.Visible = False

                Me.lblValIPI.Visible = True
                Me.lblValICMS.Visible = True
                Me.txtIPI.Visible = True
                Me.txtICMS.Visible = True

                Me.colICMS.Visible = False
                Me.colIPI.Visible = False
                Me.colUnitarioImposto.Visible = False

            Case True
                Me.lblCodProdFor.Visible = False
                Me.txtCodProdFor.Visible = False

                Me.lblConv.Visible = False
                Me.cboUniMed.Visible = False
                Me.lblQtdProd.Visible = False
                Me.txtQtdProd.Visible = False

                Me.txtIPIItem.Visible = True
                Me.txtICMSItem.Visible = True
                Me.lblICMS.Visible = True
                Me.lblIPI.Visible = True
                Me.txtMVaST.Visible = True
                Me.txtPorICMS.Visible = True
                Me.lblMVaST.Visible = True
                Me.lblPorICMS.Visible = True

                Me.lblValIPI.Visible = False
                Me.lblValICMS.Visible = False
                Me.txtIPI.Visible = False
                Me.txtICMS.Visible = False

                Me.colICMS.Visible = True
                Me.colIPI.Visible = True
                Me.colUnitarioImposto.Visible = True
                Me.colUnitarioImposto.VisibleIndex = 13
                Me.colICMS.VisibleIndex = 14
                Me.colIPI.VisibleIndex = 15
        End Select
        bolSalvo = False
        Me.lueLoja.Visible = Master
        Me.lblLoja.Visible = Master
        Me.colCodConfig.Visible = Master

        CarregarDadosLue("Select Codigo, Descricao from Config", Me.lueLoja)

        intCodConfig = CodConfig

        Me.txtCodPro.Tag = ""

        If Me.Tag = "CONSULTA" Then
            Me.btnConsultar.Enabled = True
            Me.Text = "Consulta Nota Fiscal de Entrada"
            Me.grpProd.Enabled = False
            Me.txtObs.Properties.ReadOnly = True
            Me.txtDesconto.Properties.ReadOnly = True
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.cboTipo.Properties.ReadOnly = True
            Me.txtSerie.Properties.ReadOnly = True
            Me.txFrete.Properties.ReadOnly = True
            Me.txtSeguro.Properties.ReadOnly = True
            Me.txtDespesas.Properties.ReadOnly = True
            Me.txtCodPed.Enabled = False
            Me.btnConPed.Enabled = False
            Me.txtCodPed.BackColor = Color.White

        ElseIf Me.Tag = "ALTERA" Then
            Me.Text = "Alteração de Nota Fiscal de Entrada"
            Me.btnConsultar.Enabled = True
            Me.txtCodPed.Enabled = False
            Me.btnConPed.Enabled = False
            Me.txtCodPed.BackColor = Color.White
        ElseIf Me.Tag = "CANCELA" Then
            Me.btnConsultar.Enabled = True
            Me.Text = "Cancelamento de Nota Fiscal de Entrada"
            Me.grpProd.Enabled = False
            Me.txtObs.Properties.ReadOnly = True
            Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.btnCanNota.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.cboTipo.Properties.ReadOnly = True
            Me.txtSerie.Properties.ReadOnly = True
            Me.txFrete.Properties.ReadOnly = True
            Me.txtSeguro.Properties.ReadOnly = True
            Me.txtDespesas.Properties.ReadOnly = True
            Me.txtCodPed.Enabled = False
            Me.btnConPed.Enabled = False
            Me.txtCodPed.BackColor = Color.White
        Else
            Me.btnConsultar.Enabled = False
            Me.btnNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnAddValor.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.txtValVendaPorc.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Me.btnXML.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        If NomeEmpresa.Contains("TAUÁ") = True Then
            Me.txtVal.Visible = False
            Me.txtPor1.Visible = False
            Me.lblVenda.Visible = False
            Me.lblPor.Visible = False
        End If

        PreencherGrupoSetorCusto("S", Me.cboSet)
        PreencherGrupoSetorCusto("G", Me.cboGrp)

        If EmiteNFE = True Or AbaSatFiscal = True Then
            'If EmiteNFE = True Then
            'Me.btnEditarNfe.Visible = True
            Me.btnEditarNfe.Enabled = True
            Me.colCFOP.Visible = True
            Me.colCFOP.VisibleIndex = 10
            Me.colNCM.Visible = True
            Me.colCST.Visible = True
            Me.colCSTIPI.Visible = True
            Me.colCodEnq.Visible = True
            Me.colCSTPIS.Visible = True
            Me.colCSTCOFINS.Visible = True
        End If
        If TipoNano = 2 Then
            Me.LabelControl18.Text = "Marca"
            Me.colSetor.Caption = "Marca"
        End If
      

        If TresCasasDecimais = True Then
            Me.txtVal.CasasDecimais = 3
            Me.txtPor1.CasasDecimais = 3
        End If

        ConfigurarGrid(Me.grd1, Me, True, Me.btnPadrao)

        CarregarDadosLue("Select * from Pagamento", Me.luePag)
        Me.txtDias.Text = "30"
        Tamanho(True)
    End Sub

    Private Sub Calcular()
        Me.txtDesconto.ResetText()
        Dim I As Integer
        Dim dblLinha, dblTotal As Double

        
        Dim dblTotalProduto As Double = 0
        Dim dblUni, dblPorIPI, dblPorICMS, dblResulIPI, dblResulICMS, dblQTD As Double
        Dim dblValorIPI As Double = 0
        Dim dblValorICMS As Double = 0
        Dim dblValorFCPST As Double = 0

        Dim dblValorFreteEnt As Double = 0
        Dim dblValorDespesasEnt As Double = 0
        Dim dblValorSeguroEnt As Double = 0
        For I = 0 To grd1.RowCount - 1

            dblLinha = grd1.GetRowCellDisplayText(I, Me.colValorTotal)
            dblTotalProduto += dblLinha.ToString("0.00")
            dblTotalProduto = dblTotalProduto.ToString("0.00")
            dblLinha = dblLinha.ToString("0.00")
            dblTotal += dblLinha.ToString("0.00")
            dblTotal = dblTotal.ToString("0.00")
            dblQTD = grd1.GetRowCellDisplayText(I, Me.colQtd)
            dblUni = grd1.GetRowCellDisplayText(I, Me.colUnitarioImposto)

            'CALCULO DO IPI
            If grd1.GetRowCellDisplayText(I, Me.colIPI).Trim <> "" Then
                dblPorIPI = grd1.GetRowCellDisplayText(I, Me.colIPI)
                dblResulIPI += (dblUni / 100) * dblPorIPI * dblQTD
            End If

            'CALCULO DO ICMS
            If grd1.GetRowCellDisplayText(I, Me.colICMS).Trim <> "" Then
                dblPorICMS = grd1.GetRowCellDisplayText(I, Me.colICMS)
                dblResulICMS += (dblUni / 100) * dblPorICMS * dblQTD
            End If

            Dim dblValProdUnit As Double = grd1.GetRowCellDisplayText(I, Me.colValorUnitario)

            If Me.chkImpostoItens.Checked = True Then

                Dim dblQtdProduto As Double = dblQTD
                'If dblQtdProduto < 1 Then
                '    dblQtdProduto = 1
                'End If
                If grd1.GetRowCellDisplayText(I, Me.colValIPIEnt).Trim <> "" Then
                    Dim dblValIPITot As Double = grd1.GetRowCellDisplayText(I, Me.colValIPIEnt)
                    Dim dblValIPIUnit As Double = dblValIPITot / dblQtdProduto
                    dblValProdUnit += dblValIPIUnit
                    dblValorIPI += dblValIPITot
                End If
                If grd1.GetRowCellDisplayText(I, Me.colValICMSSTEnt).Trim <> "" Then
                    Dim dblValICMSTot As Double = grd1.GetRowCellDisplayText(I, Me.colValICMSSTEnt)
                    Dim dblValICMSUnit As Double = dblValICMSTot / dblQtdProduto
                    dblValProdUnit += dblValICMSUnit
                    dblValorICMS += dblValICMSTot
                End If

                If grd1.GetRowCellDisplayText(I, Me.colVFCPSTEnt).Trim <> "" Then
                    Dim dblVFCPSTTot As Double = grd1.GetRowCellDisplayText(I, Me.colVFCPSTEnt)
                    Dim dblVFCPSTUnit As Double = dblVFCPSTTot / dblQtdProduto
                    dblValProdUnit += dblVFCPSTUnit
                    dblValorFCPST += dblVFCPSTTot
                End If



                If grd1.GetRowCellDisplayText(I, Me.colFreteEnt).Trim <> "" Then
                    Dim dblFreteEntTot As Double = grd1.GetRowCellDisplayText(I, Me.colFreteEnt)
                    Dim dblFreteEntUnit As Double = dblFreteEntTot / dblQtdProduto
                    dblValProdUnit += dblFreteEntUnit
                    dblValorFreteEnt += dblFreteEntTot
                End If

                If grd1.GetRowCellDisplayText(I, Me.colDespesasEnt).Trim <> "" Then
                    Dim dblDespesasEntTot As Double = grd1.GetRowCellDisplayText(I, Me.colDespesasEnt)
                    Dim dblDespesasEntUnit As Double = dblDespesasEntTot / dblQtdProduto
                    dblValProdUnit += dblDespesasEntUnit
                    dblValorDespesasEnt += dblDespesasEntTot
                End If

                If grd1.GetRowCellDisplayText(I, Me.colSeguroEnt).Trim <> "" Then
                    Dim dblSeguroEntTot As Double = grd1.GetRowCellDisplayText(I, Me.colSeguroEnt)
                    Dim dblSeguroEntUnit As Double = dblSeguroEntTot / dblQtdProduto
                    dblValProdUnit += dblSeguroEntUnit
                    dblValorSeguroEnt += dblSeguroEntTot
                End If

                Dim dblQtdProd As Double = grd1.GetRowCellDisplayText(I, Me.colQtdProd)
                If dblQtdProd <> dblQTD Then
                    dblValProdUnit = (dblValProdUnit * dblQTD) / dblQtdProd
                    'dblValProdUnit = dblValProdUnit / dblQtdProd
                End If
                Me.grd1.SetRowCellValue(I, Me.colValorCusto, CampoValor(dblValProdUnit))
            End If
            'dblTotalProduto += grd1.GetRowCellDisplayText(I, Me.colValorCusto)
        Next

        If Me.cboTipo.Text = "F" Then
            If ImpostoPorItem = False Then
                If Me.txFrete.Text.Trim <> "" Then
                    dblTotal += Me.txFrete.Text.Trim
                End If

                If Me.txtSeguro.Text.Trim <> "" Then
                    dblTotal += Me.txtSeguro.Text.Trim
                End If

                If Me.txtDespesas.Text.Trim <> "" Then
                    dblTotal += Me.txtDespesas.Text.Trim
                End If

                If Me.txtICMS.Text.Trim <> "" And Me.txtICMS.Text.Trim <> "0" And Me.txtICMS.Text.Trim <> "0,00" And Me.txtICMS.Text.Trim <> "0,000" Then
                    dblTotal += Me.txtICMS.Text.Trim
                Else
                    Me.txtICMS.Text = dblValorICMS.ToString("0.00")
                    dblTotal += dblValorICMS
                End If
                If Me.txtIPI.Text.Trim <> "" And Me.txtIPI.Text.Trim <> "0" And Me.txtIPI.Text.Trim <> "0,00" And Me.txtIPI.Text.Trim <> "0,000" Then
                    dblTotal += Me.txtIPI.Text.Trim
                Else
                    Me.txtIPI.Text = dblValorIPI.ToString("0.00")
                    dblTotal += dblValorIPI
                End If

                dblTotal += dblValorFCPST
            End If

        End If
        If ImpostoPorItem = True Then
            Me.txtIPI.Text = dblResulIPI.ToString("0.00")
            Me.txtICMS.Text = dblResulICMS.ToString("0.00")
        End If
      

        Me.txtDesconto.Tag = dblTotal.ToString("0.00")
        Me.txtValNota.Text = dblTotal.ToString("0.00")
        Me.txtValTotProd.Text = dblTotalProduto.ToString("0.00")
    End Sub

    Private Sub Limpar()
        bolLimpar = True
        Me.chkImpostoItens.Checked = CalcularImpostoProduto
        Me.luePag.EditValue = DBNull.Value
        CarregarDadosLue("Select * from Pagamento", Me.luePag)
        Me.txtDias.Text = "30"
        Me.seParcela.ResetText()
        Me.dtVenc.ResetText()
        Me.tbContaPagar.Rows.Clear()
        Me.grpConta.Visible = False
        strValorContaPagar = ""
        vetParcela = Nothing
        Me.chkDescontoItens.Checked = False
        Me.chkDescontoItens.Visible = False
        Me.picFundo.Visible = True
        Me.tbFor.Rows.Clear()
        strLoteTotal = ""
        Me.dsNano.Fornecedor.Rows.Clear()
        Me.tbEntrada.Rows.Clear()
        Me.dsNano.TotalEntradaNF.Rows.Clear()
        Me.txtNF.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtQtd.ResetText()
        Me.txtValor.ResetText()
        Me.txtValNota.ResetText()
        Me.txtValTotProd.ResetText()
        Me.txtValDesc.ResetText()
        dtData.EditValue = ""
        Me.txtObs.ResetText()
        bolAlterado = False
        Me.txtNomePro.BackColor = Color.White
        Me.txtQtd.BackColor = Color.White
        Me.txtValor.BackColor = Color.White
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.Image = My.Resources.Resources.edit_add
        Me.txtDesconto.ResetText()
        Me.cboTipo.SelectedIndex = -1
        Me.txtSerie.ResetText()
        Me.txFrete.ResetText()
        Me.txtSeguro.ResetText()
        Me.txtDespesas.ResetText()
        Me.txtFor.ResetText()
        Me.txtICMS.ResetText()
        Me.txtIPI.ResetText()
        Me.txtCodPed.ResetText()
        CPFFornecedor = ""
        NomeFornecedor = ""
        Tamanho(True)
        Me.txtNF.Focus()
        Me.cboGrp.SelectedIndex = -1
        Me.cboSet.SelectedIndex = -1
        Me.txtVal.ResetText()
        Me.txtPor1.ResetText()
        bolLimpar = False


        Me.txtCodBarra.Properties.AppearanceDisabled.BackColor = Color.White
        Me.txtCodBarra.BackColor = Color.White
        Me.txtVal.BackColor = Color.White
        Me.cboGrp.BackColor = Color.White
        Me.cboSet.BackColor = Color.White
        Me.txtCodPro.BackColor = Color.White
        Me.txtNomePro.BackColor = Color.White
        Me.txtQtd.BackColor = Color.White
        Me.txtValor.BackColor = Color.White
        Me.txtPerDesc.BackColor = Color.White
        Me.txtTam.BackColor = Color.White
        Me.txtCodProdFor.BackColor = Color.White
        Me.txtValorCusto.BackColor = Color.White
        Me.cboTipoProduto.BackColor = Color.White
        Me.cboUniMed.BackColor = Color.White
        Me.txtQtdProd.BackColor = Color.White
        Me.txtCodProdFor.BackColor = Color.White
        Me.txtIPIItem.ResetText()
        Me.txtICMSItem.ResetText()
        Me.txtCodBarra.ResetText()
        Me.cboTipoProduto.SelectedIndex = -1
        Me.cboGrp.SelectedIndex = -1
        Me.cboSet.SelectedIndex = -1
        Me.txtQtd.ResetText()
        Me.txtValor.ResetText()
        Me.txtNomePro.ResetText()
        Me.txtCodPro.Tag = ""
        Me.txtCodPro.ResetText()
        Me.txtPerDesc.ResetText()
        Me.txtTam.ResetText()
        Me.txtPor1.ResetText()
        Me.txtVal.ResetText()
        Me.txtCodProdFor.ResetText()
        Me.txtValorCusto.ResetText()
        Me.cboUniMed.SelectedIndex = -1
        Me.txtQtdProd.ResetText()

    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress, txtDespesas.KeyPress, txtSeguro.KeyPress, txFrete.KeyPress, txtPerDesc.KeyPress, txtPorICMS.Properties.KeyPress, txtMVaST.Properties.KeyPress, txtIPIItem.Properties.KeyPress, txtICMSItem.Properties.KeyPress, txtValorCusto.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.Leave
        If Me.txtValor.Text.Trim = "" Then Exit Sub
        Preco(txtValor)
        If Me.txtValorCusto.Text = "" Then
            Me.txtValorCusto.Text = Me.txtValor.Text.Trim
        End If
        Me.txtValor.Tag = Me.txtValor.Text.Trim

        If Me.chkImpostoItens.Checked = True Then
            Me.txtValorCusto.Text = Me.txtValor.Text.Trim
            Dim dblValCus As Double = Me.txtValorCusto.Text
            If ManterPorcProd = False Then
                If Me.txtVal.Text <> "" Then
                    Dim dblPor As Double = ((CDbl(Me.txtVal.Text) - dblValCus) * 100) / dblValCus
                    Me.txtPor1.Text = dblPor.ToString("0.000")
                End If
            
            Else
                If Me.txtPor1.Text <> "" Then
                    Dim dblVal As Double = dblValCus + ((dblValCus * CDbl(Me.txtPor1.Text)) / 100)
                    Me.txtVal.Text = dblVal.ToString("0.000")
                End If
                
            End If
        End If
        'If Me.txtValor.Text.Trim <> Me.txtValor.Tag.ToString.Trim Then
        CalcularIPI()
        'End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Validar(txtNF) = False Then Exit Sub
        If Validar(txtFor) = False Then Exit Sub
        If Validar(dtData) = False Then Exit Sub
        If Validar(Me.txtNomePro) = False Then Exit Sub
        If Validar(Me.txtQtd) = False Then Exit Sub
        If Validar(Me.txtTam) = False Then Exit Sub
        If Master = True Then
            If Validar(Me.lueLoja) = False Then Exit Sub
        End If
        If Validar(txtValor) = False Then Exit Sub


        Dim dblPerDesc, dblUniImposto, dblTotUniImposto As Double
        If Me.txtPerDesc.Text.Trim = "" Then
            dblPerDesc = 0
        Else
            dblPerDesc = Me.txtPerDesc.Text.Trim
        End If

        'If Not Me.txtCodPro.Tag.ToString.Trim = "" Then

        Dim dblTotal, dblResulPor As Double

        'CALCULA O IMPOSTO
        dblUniImposto = txtValor.Text.Trim

        dblTotUniImposto = txtValor.Tag.Trim

        'Dim dblCalcImp As Double

        'If strBCIcms <> "0" And strBCIcms <> "" Then
        '    dblCalcImp = (dblUniImposto / 100) * strBCIcms
        '    dblTotUniImposto = dblUniImposto + dblCalcImp
        'End If

        'If strIPI <> "0" And strIPI <> "" Then
        '    dblCalcImp = (dblUniImposto / 100) * strIPI
        '    dblTotUniImposto += dblCalcImp
        'End If

        strBCIcms = Me.txtICMSItem.Text
        strIPI = Me.txtIPIItem.Text
        If TresCasasDecimais = True Then
            dblUniImposto = dblUniImposto.ToString("0.000")
        Else
            dblUniImposto = dblUniImposto.ToString("0.00")
        End If
        dblTotal = txtQtd.Text.Trim * dblUniImposto
        dblResulPor = (dblTotal / 100) * dblPerDesc
        dblTotal = dblTotal - dblResulPor
        If TresCasasDecimais = True Then
            dblTotal = dblTotal.ToString("0.000")
            dblTotUniImposto = dblTotUniImposto.ToString("0.000")
        Else
            dblTotal = dblTotal.ToString("0.00")
            dblTotUniImposto = dblTotUniImposto.ToString("0.00")
        End If
        If Me.cboTipoProduto.Text = "" Then
            Me.cboTipoProduto.Text = "VENDA"
        End If

        If Me.txtValorCusto.Text = "" Then
            Me.txtValorCusto.Text = Me.txtValor.Text
        End If

        Dim dblQtdProd As Double = Me.txtQtd.Text

        If Me.txtQtdProd.Text = "" Then
            Me.txtQtdProd.Text = Me.txtQtd.Text

        Else
            Dim dblQtd As Double = Me.txtQtd.Text
            dblQtdProd = Me.txtQtdProd.Text
            dblQtdProd = dblQtdProd * dblQtd

            Me.txtValorCusto.Text = CampoValor((Me.txtValorCusto.Text * dblQtd) / dblQtdProd)
            'Me.txtValorCusto.Text = Me.txtValorCusto.Text / dblQtdProd


            If ManterPorcProd = False Then
                If Me.txtVal.Text <> "" Then
                    Dim dblPor As Double = ((Me.txtVal.Text - Me.txtValorCusto.Text) * 100) / Me.txtValorCusto.Text
                    Me.txtPor1.Text = dblPor.ToString("0.000")
                End If
   
            Else
                If Me.txtPor1.Text <> "" Then
                    Dim dblVal As Double = (Me.txtValorCusto.Text * Me.txtPor1.Text) / 100
                    Me.txtVal.Text = CampoValor(Me.txtValorCusto.Text + dblVal)
                End If
         
            End If
        End If

        Me.picFundo.Visible = False

        If bolAlterado = False Then
            JaInserido(Me.txtNomePro.Text, -1)
            With Me.tbEntrada.Rows
                .Add()
                Dim Index As Integer = .Count - 1
                .Item(Index).Item("Codigo") = "Inserir"
                .Item(Index).Item("CodProd") = Me.txtCodPro.Tag
                .Item(Index).Item("CodProdInterno") = Me.txtCodPro.Text.Trim
                Dim dblQtd As Double = txtQtd.Text.Trim
                .Item(Index).Item("Qtd") = dblQtd.ToString("0.000").Replace(".", ",")
                If BaixaPorLote = True Then
                    .Item(Index).Item("Tamanho") = Me.txtTam.Text.Trim
                Else
                    .Item(Index).Item("Tamanho") = "U"
                End If

                .Item(Index).Item("Produto") = txtNomePro.Text.Trim
                .Item(Index).Item("ValorUnitario") = txtValor.Text.Trim
                .Item(Index).Item("ValorTotal") = dblTotal
                .Item(Index).Item("ICMS") = strBCIcms
                .Item(Index).Item("IPI") = strIPI
                .Item(Index).Item("Desconto") = dblPerDesc
                .Item(Index).Item("UnitarioImposto") = dblTotUniImposto

                .Item(Index).Item("CodConfig") = intCodConfig

                .Item(Index).Item("ValProd") = Me.txtVal.Text
                .Item(Index).Item("PorProd") = Me.txtPor1.Text

                .Item(Index).Item("CodigoBarra") = Me.txtCodBarra.Text

                .Item(Index).Item("Grupo") = Me.cboGrp.Text
                .Item(Index).Item("Setor") = Me.cboSet.Text

                .Item(Index).Item("TipoProduto") = Me.cboTipoProduto.Text

                .Item(Index).Item("CodProdFor") = Me.txtCodProdFor.Text

                .Item(Index).Item("ValorCusto") = Me.txtValorCusto.Text

                .Item(Index).Item("QtdProd") = dblQtdProd.ToString("0.000")
                .Item(Index).Item("UMProd") = Me.cboUniMed.Text


                If EmiteNFE = True Or SATFiscal = True Then
                    .Item(Index).Item("EXTIPI") = strEXTIPIGeral
                    .Item(Index).Item("Genero") = strGeneroGeral
                    .Item(Index).Item("NCM") = strNCMGeral
                    .Item(Index).Item("Regime") = strRegimeNfeGeral
                    .Item(Index).Item("CST") = strCstNfeGeral
                    .Item(Index).Item("ModBC") = strModBCNfeGeral
                    .Item(Index).Item("Origem") = strOrigemNfeGeral
                    .Item(Index).Item("RedBC") = strRedBCNfeGeral
                    .Item(Index).Item("IcmsNfe") = strIcmsNfeGeral
                    .Item(Index).Item("ModBCST") = strModBCSTNfeGeral
                    .Item(Index).Item("RedBCST") = strRedBCSTNfeGeral
                    .Item(Index).Item("IcmsST") = strIcmsSTNfeGeral
                    .Item(Index).Item("CalculoCred") = strCalcCredNfeGeral
                    .Item(Index).Item("CFOP") = strCFOPGeral
                    .Item(Index).Item("CodigoANP") = strCodigoANPGeral
                    .Item(Index).Item("UFComb") = strUFCombGeral
                    .Item(Index).Item("CSTIPI") = strCSTIPIGeral
                    .Item(Index).Item("CSTPIS") = strCSPPISGeral
                    .Item(Index).Item("CSTCOFINS") = strCSTCOFINSGeral
                    .Item(Index).Item("CodEnq") = strCodEnqGeral
                    .Item(Index).Item("PerIPI") = strPerIPIGeral
                    .Item(Index).Item("PerPIS") = strPerPISGeral
                    .Item(Index).Item("PerCOFINS") = strPerCOFINSGeral
                Else
                    .Item(Index).Item("MVaST") = Me.txtMVaST.Text
                    .Item(Index).Item("IcmsNfe") = Me.txtPorICMS.Text
                End If
            End With

        Else
            JaInserido(Me.txtNomePro.Text, IndexGrid)
            Me.txtCodBarra.Properties.AppearanceDisabled.BackColor = Color.White
            Me.txtCodBarra.BackColor = Color.White
            Me.txtVal.BackColor = Color.White
            Me.cboGrp.BackColor = Color.White
            Me.cboSet.BackColor = Color.White
            Me.txtCodPro.BackColor = Color.White
            Me.txtNomePro.BackColor = Color.White
            Me.txtQtd.BackColor = Color.White
            Me.txtValor.BackColor = Color.White
            Me.txtPerDesc.BackColor = Color.White
            Me.txtTam.BackColor = Color.White
            Me.txtCodProdFor.BackColor = Color.White
            Me.btnAdd.Text = "Adicionar"
            Me.txtValorCusto.BackColor = Color.White
            Me.cboTipoProduto.BackColor = Color.White
            Me.cboUniMed.BackColor = Color.White
            Me.txtQtdProd.BackColor = Color.White
            Me.txtCodProdFor.BackColor = Color.White

            Me.btnAdd.Image = My.Resources.Resources.edit_add

            grd1.SetRowCellValue(IndexGrid, Me.colCodProd, Me.txtCodPro.Tag.ToString)
            grd1.SetRowCellValue(IndexGrid, Me.colCodProdInterno, Me.txtCodPro.Text.Trim)
            grd1.SetRowCellValue(IndexGrid, Me.colProduto, Me.txtNomePro.Text.Trim)
            grd1.SetRowCellValue(IndexGrid, Me.colQtd, Me.txtQtd.Text.Trim)
            grd1.SetRowCellValue(IndexGrid, Me.colTamanho, Me.txtTam.Text.Trim)
            grd1.SetRowCellValue(IndexGrid, Me.colValorUnitario, Me.txtValor.Text.Trim)
            grd1.SetRowCellValue(IndexGrid, Me.colValorTotal, dblTotal)
            grd1.SetRowCellValue(IndexGrid, Me.colICMS, strBCIcms)
            grd1.SetRowCellValue(IndexGrid, Me.colIPI, strIPI)
            grd1.SetRowCellValue(IndexGrid, Me.colDescontoNF, dblPerDesc)
            grd1.SetRowCellValue(IndexGrid, Me.colUnitarioImposto, dblTotUniImposto)
            grd1.SetRowCellValue(IndexGrid, Me.colCodConfig, intCodConfig)

            grd1.SetRowCellValue(IndexGrid, Me.colValProd, Me.txtVal.Text)
            grd1.SetRowCellValue(IndexGrid, Me.colPorProd, Me.txtPor1.Text)

            grd1.SetRowCellValue(IndexGrid, Me.colGrupo, Me.cboGrp.Text)
            grd1.SetRowCellValue(IndexGrid, Me.colSetor, Me.cboSet.Text)

            grd1.SetRowCellValue(IndexGrid, Me.colTipoProduto, Me.cboTipoProduto.Text)

            grd1.SetRowCellValue(IndexGrid, Me.colCodProdFor, Me.txtCodProdFor.Text)
            grd1.SetRowCellValue(IndexGrid, Me.colValorCusto, Me.txtValorCusto.Text)

            grd1.SetRowCellValue(IndexGrid, Me.colQtdProd, dblQtdProd.ToString("0.000"))
            grd1.SetRowCellValue(IndexGrid, Me.colUMProd, Me.cboUniMed.Text)

            If EmiteNFE = True Or SATFiscal = True Then
                grd1.SetRowCellValue(IndexGrid, Me.colEXTIPI, strEXTIPIGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colGenero, strGeneroGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colNCM, strNCMGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colRegime, strRegimeNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCST, strCstNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colModBC, strModBCNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colOrigem, strOrigemNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colRedBC, strRedBCNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colIcmsNfe, strIcmsNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colModBCST, strModBCSTNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colRedBCST, strRedBCSTNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colIcmsST, strIcmsSTNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCalculoCred, strCalcCredNfeGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCFOP, strCFOPGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCodigoANP, strCodigoANPGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colUFComb, strUFCombGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCSTIPI, strCSTIPIGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCSTPIS, strCSPPISGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCSTCOFINS, strCSTCOFINSGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colCodEnq, strCodEnqGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colPerIPI, strPerIPIGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colPerPIS, strPerPISGeral)
                grd1.SetRowCellValue(IndexGrid, Me.colPerCOFINS, strPerCOFINSGeral)

            Else
                grd1.SetRowCellValue(IndexGrid, Me.colMVaST, Me.txtMVaST.Text)
                grd1.SetRowCellValue(IndexGrid, Me.colIcmsNfe, Me.txtPorICMS.Text)
            End If


            grd1.SetRowCellValue(IndexGrid, Me.colCodigoBarra, Me.txtCodBarra.Text)
        End If
        'Else
        'MsgBox("Produto não cadastrado no sistema!", MsgBoxStyle.Exclamation)
        'End If


        bolAlterado = False

        If MsgBox("Inserir um novo produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strCodigoBarra = ""
            Me.txtIPIItem.ResetText()
            Me.txtICMSItem.ResetText()
            Me.txtCodBarra.ResetText()
            Me.cboTipoProduto.Text = "VENDA"
            Me.cboGrp.SelectedIndex = -1
            Me.cboSet.SelectedIndex = -1
            Me.txtQtd.ResetText()
            Me.txtValor.ResetText()
            Me.txtNomePro.ResetText()
            Me.txtCodPro.Tag = ""
            Me.txtCodPro.ResetText()
            Me.txtPerDesc.ResetText()
            Me.txtTam.ResetText()
            Me.txtPor1.ResetText()
            Me.txtVal.ResetText()
            Me.txtCodProdFor.ResetText()
            Me.txtValorCusto.ResetText()
            Me.cboUniMed.SelectedIndex = -1
            Me.txtQtdProd.ResetText()
            Tamanho(True)
            Me.txtCodPro.Focus()
            Me.txtCodPro.Focus()
            'Me.txtCodBarra.Enabled = False
        Else
            Me.txtQtdProd.ResetText()
            Me.lueLoja.Focus()
        End If

        'Me.lueLoja.EditValue = DBNull.Value

        Calcular()

    End Sub
    Private Function JaInserido(ByVal parNome As String, ByVal parIndex As Integer) As Boolean

        Dim I As Integer

        For I = 0 To Me.grd1.RowCount - 1
            If I <> parIndex Then
                Dim strNome As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                If strNome = parNome Then
                    MsgBox("Produto ja inserido!", MsgBoxStyle.Information)
                    Exit Function
                End If
            End If

        Next
    End Function

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Not Me.Tag = "CONSULTA" Then
            bolAlterado = True
            IndexGrid = grd1.FocusedRowHandle

            Me.txtCodPro.BackColor = Color.PeachPuff
            Me.txtCodPro.Tag = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodProd)
            Me.txtNomePro.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colProduto)
            Me.txtNomePro.BackColor = Color.PeachPuff
            Me.txtQtd.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colQtd)
            Me.txtQtd.BackColor = Color.PeachPuff
            Me.txtTam.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colTamanho)
            Me.txtTam.BackColor = Color.PeachPuff
         
            Me.txtCodPro.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodProdInterno)

            Me.txtValor.BackColor = Color.PeachPuff
       
            Me.txtPerDesc.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colDescontoNF)
            Me.txtPerDesc.BackColor = Color.PeachPuff

            Me.txtVal.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colValProd)
            Me.txtVal.BackColor = Color.PeachPuff
            Me.txtPor1.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colPorProd)
            txtValor.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colValorUnitario)
            txtValor.Tag = grd1.GetRowCellDisplayText(IndexGrid, Me.colUnitarioImposto)
            If ImpostoPorItem = True Then
                strBCIcms = grd1.GetRowCellDisplayText(IndexGrid, Me.colICMS)
                strIPI = grd1.GetRowCellDisplayText(IndexGrid, Me.colIPI)
                Me.txtICMSItem.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colICMS)
                Me.txtIPIItem.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colIPI)
                Me.txtPorICMS.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colIcmsNfe)
                Me.txtMVaST.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colMVaST)
            End If

            Me.cboSet.BackColor = Color.PeachPuff
            Me.cboGrp.BackColor = Color.PeachPuff
            Me.cboGrp.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colGrupo)
            Me.cboSet.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colSetor)

            Me.txtCodBarra.Properties.AppearanceDisabled.BackColor = Color.PeachPuff
            Me.txtCodBarra.BackColor = Color.PeachPuff
            Me.txtCodBarra.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodigoBarra)
            strCodigoBarra = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodigoBarra)

            Me.cboTipoProduto.BackColor = Color.PeachPuff
            Me.cboTipoProduto.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colTipoProduto)

            Me.txtCodProdFor.BackColor = Color.PeachPuff
            Me.txtCodProdFor.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodProdFor)

            Me.txtValorCusto.BackColor = Color.PeachPuff

            Me.txtValorCusto.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colValorCusto)

            Me.txtQtdProd.BackColor = Color.PeachPuff
            Dim dblQtdProd As Double = grd1.GetRowCellDisplayText(IndexGrid, Me.colQtdProd)
            Dim dblQtd As Double = grd1.GetRowCellDisplayText(IndexGrid, Me.colQtd)
            If dblQtdProd <> dblQtd Then
                Dim dblVC As Double = (dblQtdProd * grd1.GetRowCellDisplayText(IndexGrid, Me.colValorCusto)) / dblQtd

                'Dim dblVC As Double = dblQtdProd * grd1.GetRowCellDisplayText(IndexGrid, Me.colValorCusto)
                Me.txtValorCusto.Text = CampoValor(dblVC)


                dblQtdProd = dblQtdProd / dblQtd
                Me.txtQtdProd.Text = dblQtdProd.ToString("0.000")


            Else
                Me.txtQtdProd.Text = ""

            End If
         
            Me.cboUniMed.BackColor = Color.PeachPuff
            Me.cboUniMed.Text = grd1.GetRowCellDisplayText(IndexGrid, Me.colUMProd)


            Me.lueLoja.EditValue = grd1.GetRowCellValue(IndexGrid, Me.colCodConfig)

            If EmiteNFE = True Or SATFiscal = True Then

                strEXTIPIGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colEXTIPI)
                strGeneroGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colGenero)
                strNCMGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colNCM)
                strNCMGeral2 = strNCMGeral
                strRegimeNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colRegime)
                strCstNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCST)
                strModBCNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colModBC)
                strIcmsNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colIcmsNfe)
                strOrigemNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colOrigem)
                strRedBCNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colRedBC)
                strModBCSTNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colModBCST)
                strRedBCSTNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colRedBCST)
                strMVaSTNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colMVaST)
                strIcmsSTNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colIcmsST)
                strCalcCredNfeGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCalculoCred)
                strCFOPGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCFOP)
                strCodigoANPGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodigoANP)
                strUFCombGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colUFComb)

                strCSTIPIGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCSTIPI)
                strCSPPISGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCSTPIS)
                strCSTCOFINSGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCSTCOFINS)
                strCodEnqGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colCodEnq)
                strPerIPIGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colPerIPI)
                strPerPISGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colPerPIS)
                strPerCOFINSGeral = grd1.GetRowCellDisplayText(IndexGrid, Me.colPerCOFINS)

            End If
            Me.btnAdd.Text = "Alterar"
            Me.btnAdd.Image = My.Resources.Alterar
        End If
    End Sub

    Private Sub btnLimpar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick
        If MsgBox("Deseja realmente limpar todos os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Limpar()
        End If
    End Sub

    Private Sub btnCancelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar.ItemClick
        Me.Close()
    End Sub

    Private Sub GerCodigo()

        'strCodigoInterno = GerarCodigoOrdens("Produto", CodConfig)
        'Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & strCodigoInterno & ",'Produto'" & "," & CodConfig & ")")



        Dim intCodOrdem As Integer = GerarCodigoOrdens("Produto", CodConfig)

        Dim bolOk As Boolean = False
        While bolOk = False
            strCodigoInterno = intCodOrdem
            If AcrescentarZeroCodProd = True Then

                Select Case strCodigoInterno.Length
                    Case 1
                        strCodigoInterno = "000" & strCodigoInterno
                    Case 2
                        strCodigoInterno = "00" & strCodigoInterno
                    Case 3
                        strCodigoInterno = "0" & strCodigoInterno
                    Case 4
                    Case Else
                        If Not strCodigoInterno.Length Mod 2 = 0 Then
                            strCodigoInterno = "0" & strCodigoInterno
                        End If
                End Select
            End If
            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & strCodigoInterno & "'")
            If dt.Rows.Count > 0 Then
                intCodOrdem += 1
            Else
                bolOk = True
            End If

        End While

        Inserir("Insert into Ordens (Cod, Tabela, CodConfig) Values(" & strCodigoInterno & ",'Produto'" & "," & CodConfig & ")")

    End Sub
    Private Sub VerificarQtdDiferente(ByRef parOk As Boolean)
        Dim I As Integer
        For I = 0 To Me.grd1.RowCount - 1
            Dim dblQtd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            Dim dblQtdProd As Double = Me.grd1.GetRowCellDisplayText(I, Me.colQtdProd)
            Dim strProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
            If dblQtd <> dblQtdProd Then
                MsgBox("Qtde do produto " & strProduto & " está diferente qtd real!", MsgBoxStyle.Information)
                parOk = False
                Exit Sub
            End If
        Next
        parOk = True
    End Sub
    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        If TesteConexao() = False Then Exit Sub

        If txtValNota.Text.Trim = "" Then MsgBox("Não existe nenhum item para dar entrada!", MsgBoxStyle.Information) : Exit Sub
        If Validar(txtNF) = False Then Exit Sub
        If Validar(txtFor) = False Then Exit Sub
        If Validar(cboTipoProduto) = False Then Exit Sub
        If Validar(cboTipo) = False Then Exit Sub
        'If Validar(txtCPF) = False Then Exit Sub

        If Validar(dtData) = False Then Exit Sub
        If grd1.RowCount = 0 Then MsgBox("Não existem itens na NF!", 64) : Exit Sub

        Dim I As Integer

        If NomeEmpresa.Trim.ToUpper.Contains("O REI DOS") = True Then
            Dim bolOk As Boolean = True
            VerificarQtdDiferente(bolOk)
            If bolOk = False Then Exit Sub
        End If

        Me.grd1.ClearColumnsFilter()


        If Me.Tag <> "ALTERA" Then

            For I = 0 To Me.grd1.RowCount - 1
                Dim strValProd As String
                strValProd = Me.grd1.GetRowCellDisplayText(I, Me.colValProd)
                If strValProd = "" Then
                    MsgBox("Preencher o valor de venda dos produtos!", MsgBoxStyle.Information)
                    Exit Sub
                End If

            Next

            'If Me.txtCPF.Text.Trim <> "" Then
            '    Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "'")
            '    If dtFor.Rows.Count = 0 Then
            '        If Me.tbFor.Rows.Count > 0 Then
            '            Dim strEndereco As String = tbFor.Rows.Item(0).Item("Endereco").ToString
            '            Dim strNumero As String = tbFor.Rows.Item(0).Item("Numero").ToString
            '            Dim strBairro As String = tbFor.Rows.Item(0).Item("Bairro").ToString
            '            Dim strCidade As String = tbFor.Rows.Item(0).Item("Cidade").ToString
            '            Dim strEstado As String = tbFor.Rows.Item(0).Item("Estado").ToString
            '            Dim strCep As String = tbFor.Rows.Item(0).Item("Cep").ToString
            '            Dim strTelefone As String = tbFor.Rows.Item(0).Item("Telefone").ToString
            '            Dim strIE As String = tbFor.Rows.Item(0).Item("IE").ToString
            '            Dim strFantasia As String = tbFor.Rows.Item(0).Item("Fantasia").ToString
            '            Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, IE, Data, Fantasia, Tipo, Inativo) VALUES ('" & Me.txtFor.Text.Trim & "','" & Me.txtCPF.Text.Trim & "','" & strEndereco & "','" & strNumero & "','" & strBairro & "','" & strCidade & "','" & strEstado & "','" & strCep & "','" & strTelefone & "','" & strIE & "','" & Date.Today & "','" & strFantasia & "','F','False')")
            '            Dim dtFor2 As DataTable = CarregarDataTable("Select Codigo from Fornecedor where CPF ='" & Me.txtCPF.Text.Trim & "'")
            '            If dtFor2.Rows.Count > 0 Then
            '                intCodFornecedor = dtFor2.Rows.Item(0).Item("Codigo").ToString
            '            Else
            '                intCodFornecedor = GerarCodigo("Fornecedor", "Codigo", 0) - 1
            '            End If

            '        End If
            '    Else
            '        intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
            '    End If
            'End If
            VerificarFornecedor()

            If PesquisarNF(txtNF, intCodFornecedor) = True Then
                Me.txtNF.Focus()
                Exit Sub
            End If



            If Me.grd3.RowCount = 0 Then
                If MsgBox("Deseja cadastrar a conta a pagar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Me.grpConta.Visible = True
                    Timer1.Start()
                    Exit Sub
                End If
            Else
                If Validar(Me.luePag) = False Then Exit Sub
            End If




            Inserir("INSERT INTO TotalEntradaNF (NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, Desconto, Tipo, " & _
            "Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, CodConfig, CodPedido, CTPagarOk, Chave, CalcImpProd) VALUES (" & _
            "'" & Me.txtNF.Text.Trim & "'," & intCodFornecedor & "," & Num(Me.txtValNota.Text.Trim) & "," & _
            "'" & Me.txtObs.Text.Trim & "','" & Me.dtData.Text.Trim & "','" & Me.chkEstoqueOK.Checked & "'," & _
            "'" & Me.txtDesconto.Text.Trim & "|" & Me.txtValDesc.Text.Trim & "','" & Me.cboTipo.Text.Trim & "'," & _
            "'" & Me.txtSerie.Text.Trim & "','" & Me.txFrete.Text.Trim & "','" & Me.txtSeguro.Text.Trim & "'," & _
            "'" & Me.txtDespesas.Text.Trim & "','" & Me.txtICMS.Text.Trim & "','" & Me.txtIPI.Text.Trim & "'," & _
            "" & CodConfig & ",'" & Me.txtCodPed.Text.Trim & "','False','" & Me.txtChave.Text.Trim & "','" & Me.chkImpostoItens.Checked & "')")

            Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM TotalEntradaNF where NumeroNF = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
            Dim intCodTotNF As Integer = dt.Rows.Item(0).Item("Codigo").ToString
            intCodigoTotalNF = dt.Rows.Item(0).Item("Codigo").ToString

            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodConfig, strTamanho, strCodigo, strCodTotNF, strCodProd, strQtd, strValorUnitario, strValorTotal, strProduto, strCodProdInterno, strICMS, strDesconto, strIPI, strUnitario As String
                Dim strRegimeNfe, strCstNfe, strOrigemNfe, strCalcCredNfe, strModBCNfe, _
                           strRedBCNfe, strIcmsNfe, strModBCSTNfe, strRedBCSTNfe, strIcmsSTNfe, _
                           strMVaSTNfe, strNCM, strCFOP, strEXTIPI, strGenero, strUnidTrib, _
                           strValTrib, strQtdTrib, strUnidCom, strValCom, strCodigoANP, strUFComb As String
                Dim strCSTIPI, strPerIPI, strCodEnq, strCSPPIS, strPerPIS, strCSTCOFINS, strPerCOFINS As String

                Dim strCest As String = ""
                strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                strCodTotNF = Me.txtNF.Text.Trim
                strCodProd = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strValorUnitario = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                strValorTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                strCodProdInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno)
                strICMS = Me.grd1.GetRowCellDisplayText(I, Me.colICMS)
                strDesconto = Me.grd1.GetRowCellDisplayText(I, Me.colDescontoNF)
                strIPI = Me.grd1.GetRowCellDisplayText(I, Me.colIPI)

                strUnitario = Me.grd1.GetRowCellDisplayText(I, Me.colUnitarioImposto)

                strCodConfig = Me.grd1.GetRowCellDisplayText(I, Me.colCodConfig)
                strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)

                Dim strValProd, strPorProd As String
                strValProd = Me.grd1.GetRowCellDisplayText(I, Me.colValProd)
                strPorProd = Me.grd1.GetRowCellDisplayText(I, Me.colPorProd)

                Dim strGrupo As String = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                Dim strSetor As String = Me.grd1.GetRowCellDisplayText(I, Me.colSetor)
                Dim strCodProdFor As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdFor)

                Dim strTipoProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipoProduto)
                Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)

                Dim strUMProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colUMProd)
                Dim strQtdProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtdProd)


                Dim strMVaST As String = ""
                Dim strPorICMS As String = ""
                Dim bolExiteProduto As Boolean = True
                If EmiteNFE = True Or SATFiscal = True Then


                    strNCM = Me.grd1.GetRowCellDisplayText(I, Me.colNCM)
                    If strNCM = "" Then
                        strNCM = Me.grd1.GetRowCellDisplayText(I, Me.colNCMEnt)
                    End If
                    strCFOP = Me.grd1.GetRowCellDisplayText(I, Me.colCFOP)
                    strEXTIPI = Me.grd1.GetRowCellDisplayText(I, Me.colEXTIPI)
                    strGenero = Me.grd1.GetRowCellDisplayText(I, Me.colGenero)
                    strUnidTrib = Me.grd1.GetRowCellDisplayText(I, Me.colUnidTrib)
                    strValTrib = Me.grd1.GetRowCellDisplayText(I, Me.colValTrib)
                    strQtdTrib = Me.grd1.GetRowCellDisplayText(I, Me.colQtdTrib)
                    strUnidCom = Me.grd1.GetRowCellDisplayText(I, Me.colUnidCom)
                    strValCom = Me.grd1.GetRowCellDisplayText(I, Me.colValCom)

                    strCstNfe = Me.grd1.GetRowCellDisplayText(I, Me.colCST)

                    If strCstNfe.Length = 2 Then
                        strRegimeNfe = "TRIBUTAÇÃO NORMAL"
                    Else
                        strRegimeNfe = "SIMPLES NACIONAL"
                    End If
                    strOrigemNfe = Me.grd1.GetRowCellDisplayText(I, Me.colOrigem)
                    strCalcCredNfe = Me.grd1.GetRowCellDisplayText(I, Me.colCalculoCred)
                    strModBCNfe = Me.grd1.GetRowCellDisplayText(I, Me.colModBC)
                    strRedBCNfe = Me.grd1.GetRowCellDisplayText(I, Me.colRedBC)
                    strIcmsNfe = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsNfe)
                    strModBCSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colModBCST)
                    strRedBCSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCST)
                    strMVaSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colMVaST)
                    strIcmsSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsST)

                    strCodigoANP = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoANP)
                    strUFComb = Me.grd1.GetRowCellDisplayText(I, Me.colUFComb)

                    strMVaST = Me.grd1.GetRowCellDisplayText(I, Me.colMVaST)
                    strPorICMS = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsNfe)

                    If strCstNfe.Length = 2 Then
                        strRegimeNfe = "TRIBUTAÇÃO NORMAL"
                    Else
                        strRegimeNfe = "SIMPLES NACIONAL"
                    End If

                    strCSTIPI = Me.grd1.GetRowCellDisplayText(I, Me.colCSTIPI)
                    strPerIPI = Me.grd1.GetRowCellDisplayText(I, Me.colPerIPI)
                    strCodEnq = Me.grd1.GetRowCellDisplayText(I, Me.colCodEnq)
                    strCSPPIS = Me.grd1.GetRowCellDisplayText(I, Me.colCSTPIS)
                    strPerPIS = Me.grd1.GetRowCellDisplayText(I, Me.colPerPIS)
                    strCSTCOFINS = Me.grd1.GetRowCellDisplayText(I, Me.colCSTCOFINS)
                    strPerCOFINS = Me.grd1.GetRowCellDisplayText(I, Me.colPerCOFINS)
                    strCest = Me.grd1.GetRowCellDisplayText(I, Me.colCest)
                End If
                If strCodProd = "" Then
                    Dim strUM As String = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                    Dim strCodigoBarra As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)


                    Dim dtProd As DataTable = Nothing
                    If strCodProdInterno <> "" Then
                        dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodigoInterno = '" & strCodProdInterno & "'")
                    End If
                    If strCodigoBarra <> "" Then
                        dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodigoBarra = '" & strCodigoBarra & "'")
                    Else
                        If dtProd Is Nothing Then
                            If CNPJEmpresa = "18377821000107" Then
                                dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, " & _
                                "CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where " & _
                                "Produto.CodProdFor = '" & strCodProdFor & "' and " & _
                                "Produto.Fabricante = '" & Me.txtFor.Text & "'")

                            Else
                                If Me.txtFor.Text <> "" And strCodProdFor <> "" Then
                                    'dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodProdFor = '" & strCodProdFor & "' and Fabricante = '" & Me.txtFor.Text & "'")

                                    dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                    "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                    "Produto.Tipo FROM ((EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo) " & _
                                    "left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                                    "EntradaNF.CodConfig = TotalEntradaNF.CodConfig) left join Fornecedor on " & _
                                    "TotalEntradaNF.CodFor = Fornecedor.Codigo where " & _
                                    "EntradaNF.CodProdFor = '" & strCodProdFor & "' and " & _
                                    "Fornecedor.Nome = '" & Me.txtFor.Text & "'")
                                End If

                                If dtProd Is Nothing Then
                                    dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where Nome = '" & strProduto & "'")

                                Else
                                    If NomeEmpresa.ToUpper.Contains("PINK FASHION") = False Then
                                        If dtProd.Rows.Count = 0 Then
                                            dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where Nome = '" & strProduto & "'")
                                        End If
                                    End If

                                End If
                            End If
             

                        Else

                            If dtProd.Rows.Count = 0 Then
                                If Me.txtFor.Text <> "" And strCodProdFor <> "" Then
                                    ' dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where CodProdFor = '" & strCodProdFor & "' and Fabricante = '" & Me.txtFor.Text & "'")
                                    dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno, Produto.Valor, " & _
                                                                    "Produto.Porcentagens, Produto.CodigoBarra, Produto.Nome, Produto.Grupo, Produto.Setor, " & _
                                                                    "Produto.Tipo FROM ((EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo) " & _
                                                                    "left join TotalEntradaNF on EntradaNF.CodTotNF = TotalEntradaNF.Codigo and " & _
                                                                    "EntradaNF.CodConfig = TotalEntradaNF.CodConfig) left join Fornecedor on " & _
                                                                    "TotalEntradaNF.CodFor = Fornecedor.Codigo where " & _
                                                                    "EntradaNF.CodProdFor = '" & strCodProdFor & "' and " & _
                                                                    "Fornecedor.Nome = '" & Me.txtFor.Text & "'")
                                End If
                                If NomeEmpresa.ToUpper.Contains("PINK FASHION") = False Then
                                    If dtProd.Rows.Count = 0 Then
                                        dtProd = CarregarDataTable("SELECT Codigo, CodigoInterno, Valor, Porcentagens, CodigoBarra, Nome, Grupo, Setor, Tipo FROM Produto where Nome = '" & strProduto & "'")
                                    End If
                                End If

                            End If
                        End If
                    End If

                    If CNPJEmpresa = "32235631000186" Then
                        dtProd = CarregarDataTable("SELECT Codigo FROM Produto where Nome = 'ERASYSTEMS1234'")
                    End If

                    Dim bolCadastraProduto As Boolean = False
                    If dtProd Is Nothing Then
                        bolCadastraProduto = True
                    Else
                        If dtProd.Rows.Count = 0 Then
                            bolCadastraProduto = True
                        End If
                    End If



                    If bolCadastraProduto = True Then
                       
                        If strCodProdInterno = "" Then
                            GerCodigo()

                        Else
                            If AcrescentarZeroCodProd = True Then
                                Select Case strCodProdInterno.Length
                                    Case 1
                                        strCodigoInterno = "000" & strCodProdInterno
                                    Case 2
                                        strCodigoInterno = "00" & strCodProdInterno
                                    Case 3
                                        strCodigoInterno = "0" & strCodProdInterno
                                    Case 4
                                    Case Else
                                        If Not strCodProdInterno.Length Mod 2 = 0 Then
                                            strCodigoInterno = "0" & strCodProdInterno
                                        End If
                                End Select
                            Else
                                strCodigoInterno = strCodProdInterno
                            End If
                        End If
                  


                        If strGrupo = "" Then
                            Dim dtGrupo As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = 'DIVERSOS'")
                            If dtGrupo.Rows.Count = 0 Then
                                Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('DIVERSOS','G')")
                            End If
                            If I > 0 Then
                                If Me.grd1.GetRowCellDisplayText(I - 1, Me.colGrupo) <> "" Then
                                    strGrupo = Me.grd1.GetRowCellDisplayText(I - 1, Me.colGrupo)
                                Else
                                    strGrupo = "DIVERSOS"
                                End If
                            Else
                                If Me.cboGrp.Text = "" Then
                                    strGrupo = "DIVERSOS"
                                Else
                                    strGrupo = Me.cboGrp.Text.Trim
                                End If

                            End If

                            Me.grd1.SetRowCellValue(I, Me.colGrupo, strGrupo)
                        End If

                        If strSetor = "" Then
                            If Me.cboSet.Text.Trim <> "" Then
                                strSetor = Me.cboSet.Text.Trim
                                Me.grd1.SetRowCellValue(I, Me.colSetor, strSetor)
                            End If
                        End If

                        If Me.cboTipoProduto.Text.Trim = "" Then
                            strTipoProduto = "VENDA"
                        Else
                            strTipoProduto = Me.cboTipoProduto.Text.Trim
                        End If

                        If strUMProd = "" Then
                            strUMProd = "UN"
                        End If


                        Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, CodigoInterno, " & _
                        "CodigoBarra, Porcentagens, Fabricante, Grupo, Data, Desconto, Tipo, Setor, CodProdFor, " & _
                        "Inativo, Validade, Comissao, TributacaoPadrao, AlterarPreco, QtdEmb) VALUES ('" & strProduto & "','" & strUMProd & "'," & _
                        "" & Num(strValProd) & "," & Num(strValorCusto) & ",'" & strCodigoInterno & "'," & _
                        "'" & strCodigoBarra & "','" & strPorProd & "','" & Me.txtFor.Text.Trim & "'," & _
                        "'" & strGrupo & "','" & Date.Today & "',0.00,'" & strTipoProduto & "','" & strSetor & "'," & _
                        "'" & strCodProdFor & "','False','01/01/2050',0,'False','False',0)")

                        Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                        "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & ",''," & _
                        "'" & strCodigoInterno & " - " & strProduto & "','PRODUTO','PRODUTO','CADASTRO ENTRADA NF'," & _
                        "" & CodConfig & ")")

                        bolExiteProduto = False

                        Dim dtCodAut As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where Nome = '" & strProduto & "' and " & _
                        "CodigoInterno = '" & strCodigoInterno & "' and Fabricante = '" & Me.txtFor.Text.Trim & "'")
                        If dtCodAut.Rows.Count > 0 Then
                            strCodProd = dtCodAut.Rows.Item(0).Item("Codigo").ToString
                        Else
                            strCodProd = GerarCodigo("Produto", "Codigo", 0) - 1
                        End If


                        If BaixaPorLote = False Then
                            Dim dtConf As DataTable = CarregarDataTable("Select Codigo from Config Order by Codigo")
                            Dim Y As Integer

                            For Y = 0 To dtConf.Rows.Count - 1

                                Dim intCodConfigTabQtde As Integer

                                intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString

                                Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, " & _
                                "ValorCusto, Acabou, CodConfig) Values(" & strCodProd & ",'U','0','0','U','0'," & _
                                "'" & Num(strValorUnitario) & "','False'," & intCodConfigTabQtde & ")")
                            Next
                        End If

                        If EmiteNFE = True Or SATFiscal = True Then
                            'Dim strRegimeNfe, strCstNfe, strOrigemNfe, strCalcCredNfe, strModBCNfe, strRedBCNfe, strIcmsNfe, strModBCSTNfe, strRedBCSTNfe, strIcmsSTNfe, strMVaSTNfe As String
                            'Dim strNCM As String = Me.grd1.GetRowCellDisplayText(I, Me.colNCM)
                            'Dim strCFOP As String = Me.grd1.GetRowCellDisplayText(I, Me.colCFOP)
                            'Dim strEXTIPI As String = Me.grd1.GetRowCellDisplayText(I, Me.colEXTIPI)
                            'Dim strGenero As String = Me.grd1.GetRowCellDisplayText(I, Me.colGenero)
                            'Dim strUnidTrib As String = Me.grd1.GetRowCellDisplayText(I, Me.colUnidTrib)
                            'Dim strValTrib As String = Me.grd1.GetRowCellDisplayText(I, Me.colValTrib)
                            'Dim strQtdTrib As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtdTrib)
                            'Dim strUnidCom As String = Me.grd1.GetRowCellDisplayText(I, Me.colUnidCom)
                            'Dim strValCom As String = Me.grd1.GetRowCellDisplayText(I, Me.colValCom)

                            'strCstNfe = Me.grd1.GetRowCellDisplayText(I, Me.colCST)

                            'If strCstNfe.Length = 2 Then
                            '    strRegimeNfe = "TRIBUTAÇÃO NORMAL"
                            'Else
                            '    strRegimeNfe = "SIMPLES NACIONAL"
                            'End If
                            'strOrigemNfe = Me.grd1.GetRowCellDisplayText(I, Me.colOrigem)
                            'strCalcCredNfe = Me.grd1.GetRowCellDisplayText(I, Me.colCalculoCred)
                            'strModBCNfe = Me.grd1.GetRowCellDisplayText(I, Me.colModBC)
                            'strRedBCNfe = Me.grd1.GetRowCellDisplayText(I, Me.colRedBC)
                            'strIcmsNfe = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsNfe)
                            'strModBCSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colModBCST)
                            'strRedBCSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCST)
                            'strMVaSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colMVaST)
                            'strIcmsSTNfe = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsST)

                            'Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, UnidCom, ValCom) VALUES (" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "','" & strUnidTrib & "','" & strValProd & "','" & strQtdTrib & "','" & strCstNfe & "','" & strOrigemNfe & "','" & strModBCNfe & "','" & strIcmsNfe & "','" & strRedBCNfe & "','" & strModBCSTNfe & "','" & strRedBCSTNfe & "','" & strMVaSTNfe & "','" & strCFOP & "','" & strIcmsSTNfe & "','" & strNCM & "','" & strRegimeNfe & "','" & strCalcCredNfe & "','" & strUnidCom & "','" & strValProd & "')")
                            'strMVaST = Me.grd1.GetRowCellDisplayText(I, Me.colMVaST)
                            'strPorICMS = Me.grd1.GetRowCellDisplayText(I, Me.colIcmsNfe)
                            'Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, UnidTrib, ValTrib, QtdTrib, CFOP, NCM, UnidCom, ValCom) VALUES (" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "','" & strUnidTrib & "','" & strValProd & "','" & strQtdTrib & "','" & strCFOP & "','" & strNCM & "','" & strUnidCom & "','" & strValProd & "')")

                            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, " & _
                            "Cest) VALUES (" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "'," & _
                            "'" & strCstNfe & "','" & strOrigemNfe & "','" & strModBCNfe & "','" & strIcmsNfe & "'," & _
                            "'" & strRedBCNfe & "','" & strModBCSTNfe & "','" & strRedBCSTNfe & "'," & _
                            "'" & strMVaSTNfe & "','" & strCFOP & "','" & strIcmsSTNfe & "','" & strNCM & "'," & _
                            "'" & strRegimeNfe & "','" & strCalcCredNfe & "','" & strCodigoANP & "'," & _
                            "'" & strUFComb & "','" & strCest & "')")

                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & strCodProd & ",'" & strCSTIPI & "','" & strPerIPI & "'," & _
                            "'" & strCodEnq & "','" & strCSPPIS & "','" & strPerPIS & "','" & strCSTCOFINS & "'," & _
                            "'" & strPerCOFINS & "','" & strRegimeNfe & "')")

                            'ArquivoNfeProduto(strCodProd, False)
                        End If
                    Else
                        strGrupo = dtProd.Rows.Item(0).Item("Grupo").ToString
                        strCodigoInterno = dtProd.Rows.Item(0).Item("CodigoInterno").ToString
                        strCodProd = dtProd.Rows.Item(0).Item("Codigo").ToString
                    End If
                    Me.grd1.SetRowCellValue(I, Me.colCodProdInterno, strCodigoInterno)
                    Me.grd1.SetRowCellValue(I, Me.colCodProd, strCodProd)
                    Me.grd1.SetRowCellValue(I, Me.colGrupo, strGrupo)
                    strCodProd = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    strCodProdInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno)

                End If

                If EmiteNFE = True Or SATFiscal = True Then

                    If bolExiteProduto = True Then
                        Dim dtRegime As DataTable = CarregarDataTable("SELECT Regime FROM Nfe where CodProd = " & strCodProd & " and Regime like '%" & strRegimeNfe & "%' order by Regime")

                        Dim strTipoFiscal As String = ""
                        If dtRegime.Rows.Count > 0 Then
                            Dim strRegimeNFeSat As String = dtRegime.Rows.Item(0).Item("Regime").ToString
                            If strRegimeNFeSat.Contains("SAT") Or strRegimeNFeSat.Contains("NFE") Then
                                strTipoFiscal = " NFE"
                            End If
                        End If
                  

                        Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & strTipoFiscal & "'")
                        If dtNfe.Rows.Count = 0 Then
                            Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                            "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest) VALUES (" & _
                            "" & strCodProd & ",'" & strEXTIPI & "','" & strGenero & "','" & strCstNfe & "'," & _
                            "'" & strOrigemNfe & "','" & strModBCNfe & "','" & strIcmsNfe & "','" & strRedBCNfe & "'," & _
                            "'" & strModBCSTNfe & "','" & strRedBCSTNfe & "','" & strMVaSTNfe & "'," & _
                            "'" & strCFOP & "','" & strIcmsSTNfe & "','" & strNCM & "'," & _
                            "'" & strRegimeNfe & strTipoFiscal & "','" & strCalcCredNfe & "','" & strCodigoANP & "'," & _
                            "'" & strUFComb & "','" & strCest & "')")
                        Else
                            Atualizar("UPDATE Nfe SET EXTIPI = '" & strEXTIPI & "', Genero = '" & strGenero & "', " & _
                            "CST = '" & strCstNfe & "', Origem = '" & strOrigemNfe & "', ModBC = '" & strModBCNfe & "', " & _
                            "ICMS = '" & strIcmsNfe & "', RedBC = '" & strRedBCNfe & "', " & _
                            "ModBCST = '" & strModBCSTNfe & "', RedBCST = '" & strRedBCSTNfe & "', " & _
                            "MVaST = '" & strMVaSTNfe & "', CFOP = '" & strCFOP & "', " & _
                            "ICMSST = '" & strIcmsSTNfe & "', NCM = '" & strNCM & "', " & _
                            "CalculoCred = '" & strCalcCredNfe & "', " & _
                            "CodigoANP = '" & strCodigoANP & "', UFComb = '" & strUFComb & "', Cest = '" & strCest & "' where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & strTipoFiscal & "'")
                        End If


                        Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & strTipoFiscal & "'")
                        If dtTrib.Rows.Count = 0 Then
                            Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS, Regime) Values (" & strCodProd & ",'" & strCSTIPI & "','" & strPerIPI & "'," & _
                            "'" & strCodEnq & "','" & strCSPPIS & "','" & strPerPIS & "','" & strCSTCOFINS & "'," & _
                            "'" & strPerCOFINS & "','" & strRegimeNfe & strTipoFiscal & "')")
                        Else
                            Atualizar("UPDATE Tributos SET CSTIPI = '" & strCSTIPI & "', PerIPI = '" & strPerIPI & "', " & _
                            "CodEnq = '" & strCodEnq & "', CSTPIS = '" & strCSPPIS & "', PerPIS = '" & strPerPIS & "', " & _
                            "CSTCOFINS = '" & strCSTCOFINS & "', PerCOFINS = '" & strPerCOFINS & "' where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & strTipoFiscal & "'")

                        End If
                        'If strTipoFiscal = "" Then

                        '    Excluir("DELETE FROM NFe where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & " NFE' or CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & " SAT'")
                        '    Excluir("DELETE FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & " NFE' or CodProd = " & strCodProd & " and Regime = '" & strRegimeNfe & " SAT'")
                        'End If
                   End If

                End If


                Dim strCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTEnt)
                Dim strOrigemEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colOrigemEnt)
                Dim strModBCEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colModBCEnt)
                Dim strAliquotaICMSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaICMSEnt)
                Dim strValICMSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSEnt)
                Dim strRedBCEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCEnt)
                Dim strModBCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colModBCSTEnt)
                Dim strRedBCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCSTEnt)
                Dim strMVaSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colMVaSTEnt)
                Dim strAliquotaICMSSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaICMSSTEnt)
                Dim strValICMSSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSSTEnt)
                Dim strNCMEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colNCMEnt)
                Dim strRegimeEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRegimeEnt)
                Dim strCalculoCredEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCalculoCredEnt)
                Dim strValCalculoCredEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValCredEnt)
                Dim strCFOPEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCFOPEnt)
                Dim strCSTIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTIPIEnt)
                Dim strCodEnqEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodEnqEnt)
                Dim strAliquotaIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaIPIEnt)
                Dim strValIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValIPIEnt)
                Dim strCSTPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTPISEnt)
                Dim strAliquotaPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaPISEnt)
                Dim strValPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValPISEnt)
                Dim strCSTCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTCOFINSEnt)
                Dim strAliquotaCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaCOFINSEnt)
                Dim strValCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValCOFINSEnt)

                Dim strCodigoANPEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoANPEnt)
                Dim strUFCombEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colUFCombEnt)
                Dim strVFCPSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colVFCPSTEnt)

                Dim strFreteEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colFreteEnt)
                Dim strDespesasEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colDespesasEnt)
                Dim strSeguroEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colSeguroEnt)


                Inserir("INSERT INTO EntradaNF (CodTotNF, CodProd, Qtd, ValorUnitario, ValorTotal, Produto, " & _
                "CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, Tamanho, CodConfig, ValProd, PorProd, " & _
                "Grupo, Setor, MVaST, PorICMS, TipoProduto, CFOP, NCM, Regime, CST, Origem, CalculoCred, " & _
                "ValCalculoCred, ModBC, RedBC, AliquotaICMS, ValICMS, ModBCST, RedBCST, MVaSTEnt, AliquotaICMSST, " & _
                "ValICMSST, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, ValPIS, CSTCOFINS, " & _
                "AliquotaCOFINS, ValCOFINS, CodigoANPEnt, UFCombEnt, CodProdFor, ValorCusto, UMProd, QtdProd, " & _
                "VFCPST, FreteEnt, DespesasEnt, SeguroEnt) VALUES (" & _
                "" & intCodTotNF & "," & strCodProd & "," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "'," & _
                "'" & strDesconto & "','" & strIPI & "'," & Num(strUnitario) & ",'" & strTamanho & "'," & _
                "'" & strCodConfig & "'," & Num(strValProd) & "," & Num(strPorProd) & ",'" & strGrupo & "'," & _
                "'" & strSetor & "','" & strMVaST & "','" & strPorICMS & "','" & strTipoProduto & "'," & _
                "'" & strCFOPEnt & "','" & strNCMEnt & "','" & strRegimeEnt & "','" & strCSTEnt & "'," & _
                "'" & strOrigemEnt & "','" & strCalculoCredEnt & "','" & strValCalculoCredEnt & "'," & _
                "'" & strModBCEnt & "','" & strRedBCEnt & "','" & strAliquotaICMSEnt & "','" & strValICMSEnt & "'," & _
                "'" & strModBCSTEnt & "','" & strRedBCSTEnt & "','" & strMVaSTEnt & "'," & _
                "'" & strAliquotaICMSSTEnt & "','" & strValICMSSTEnt & "','" & strCSTIPIEnt & "','" & strCodEnqEnt & "'," & _
                "'" & strAliquotaIPIEnt & "','" & strValIPIEnt & "','" & strCSTPISEnt & "','" & strAliquotaPISEnt & "'," & _
                "'" & strValPISEnt & "','" & strCSTCOFINSEnt & "','" & strAliquotaCOFINSEnt & "','" & strValCOFINSEnt & "'," & _
                "'" & strCodigoANPEnt & "','" & strUFCombEnt & "','" & strCodProdFor & "'," & Num(strValorCusto) & "," & _
                "'" & strUMProd & "'," & Num(strQtdProd) & ",'" & strVFCPSTEnt & "','" & strFreteEnt & "'," & _
                "'" & strDespesasEnt & "','" & strSeguroEnt & "')")

            Next

            If Me.txtCodPed.Text.Trim <> "" Then
                Atualizar("Update TotalPedCompra set Status ='Finalizado', NumeroNF ='" & Me.txtNF.Text.Trim & "' Where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND CodConfig=" & CodConfig)
            End If
            
            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'','" & Me.txtNF.Text & " - " & Me.txtFor.Text & "'," & _
            "'ENTRADA NF','ENTRADA NF','CADASTRO'," & CodConfig & ")")



            MsgBox("Entrada de Nota concluída com sucesso!", MsgBoxStyle.Information)

        Else
            If Me.grd3.RowCount = 0 Then
                If MsgBox("Deseja cadastrar a conta a pagar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Me.grpConta.Visible = True
                    Timer1.Start()
                    Exit Sub
                End If
            Else
                If Validar(Me.luePag) = False Then Exit Sub


            End If
            Dim vetDelete As Array = Split(strItensDeletado, "|")

            For I = 0 To vetDelete.Length - 1
                If vetDelete(I) <> "" And vetDelete(I).ToString.ToUpper <> "INSERIR" Then
                    Dim strDelete As String
                    strDelete = "Delete From EntradaNF where Codigo =" & vetDelete(I)
                    Excluir(strDelete)
                End If

            Next

            strItensDeletado = ""

            For I = 0 To Me.grd1.RowCount - 1
                Dim strCodConfig, strTamanho, strCodigo, strCodTotNF, strCodProd, strQtd, strValorUnitario, strValorTotal, strProduto, strCodProdInterno, strICMS, strDesconto, strIPI, strUnitario As String
                strCodigo = Me.grd1.GetRowCellDisplayText(I, Me.colCodigo)
                strCodTotNF = Me.grd1.GetRowCellDisplayText(I, Me.colCodTotNF)
                strCodProd = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                strQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strValorUnitario = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                strValorTotal = Me.grd1.GetRowCellDisplayText(I, Me.colValorTotal)
                strProduto = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                strCodProdInterno = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno)
                strICMS = Me.grd1.GetRowCellDisplayText(I, Me.colICMS)
                strDesconto = Me.grd1.GetRowCellDisplayText(I, Me.colDescontoNF)
                strIPI = Me.grd1.GetRowCellDisplayText(I, Me.colIPI)
                strUnitario = Me.grd1.GetRowCellDisplayText(I, Me.colUnitarioImposto)
                strCodConfig = Me.grd1.GetRowCellDisplayText(I, Me.colCodConfig)
                strTamanho = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho)

                Dim strValProd, strPorProd As String
                strValProd = Me.grd1.GetRowCellDisplayText(I, Me.colValProd)
                strPorProd = Me.grd1.GetRowCellDisplayText(I, Me.colPorProd)

                Dim strGrupo As String = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                Dim strSetor As String = Me.grd1.GetRowCellDisplayText(I, Me.colSetor)
                Dim strTipoProduto As String = Me.grd1.GetRowCellDisplayText(I, Me.colTipoProduto)
                Dim strCodProdFor As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdFor)
                Dim strValorCusto As String = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                Dim strUMProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colUMProd)
                Dim strQtdProd As String = Me.grd1.GetRowCellDisplayText(I, Me.colQtdProd)

                'If strCodProd = "" Then
                '    Dim strUM As String = Me.grd1.GetRowCellDisplayText(I, Me.colUM)
                '    Dim strCodigoBarra As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoBarra)

                '    Dim strCodigoInterno As String = "0" & GerarCodigo("Produto", "Codigo", 0)
                '    If NomeEmpresa.Trim.ToUpper.Contains("LUCIA FREITAS") = True Then
                '        Select Case strCodigoInterno.Length
                '            Case 1
                '                strCodigoInterno = "000" & strCodigoInterno
                '            Case 2
                '                strCodigoInterno = "00" & strCodigoInterno
                '            Case 3
                '                strCodigoInterno = "0" & strCodigoInterno
                '            Case 4
                '            Case Else
                '                If Not strCodigoInterno.Length Mod 2 = 0 Then
                '                    strCodigoInterno = "0" & strCodigoInterno
                '                End If
                '        End Select
                '    End If
                '    Dim dtGrupo As DataTable = CarregarDataTable("SELECT Codigo FROM Grupo where Nome = 'DIVERSOS'")
                '    If dtGrupo.Rows.Count = 0 Then
                '        Inserir("INSERT INTO Grupo (Nome, Tipo) VALUES ('DIVERSOS','G')")
                '    End If
                '    Inserir("INSERT INTO Produto (Nome, UnidadeMedida, Valor, ValorCusto, CodigoInterno, CodigoBarra, Porcentagens, Fabricante, Grupo, Data, Desconto, Tipo) VALUES ('" & strProduto & "','" & strUM & "'," & Num(strValProd) & "," & Num(strValorUnitario) & ",'" & strCodigoInterno & "','" & strCodigoBarra & "','" & strPorProd & "','" & Me.txtFor.Text.Trim & "','DIVERSOS','" & Date.Today & "',0.00,'VENDA')")
                '    strCodProd = GerarCodigo("Produto", "Codigo", 0) - 1
                '    Me.grd1.SetRowCellValue(I, Me.colCodProd, strCodProd)
                'End If

                Dim strCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTEnt)
                Dim strOrigemEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colOrigemEnt)
                Dim strModBCEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colModBCEnt)
                Dim strAliquotaICMSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaICMSEnt)
                Dim strValICMSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSEnt)
                Dim strRedBCEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCEnt)
                Dim strModBCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colModBCSTEnt)
                Dim strRedBCSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRedBCSTEnt)
                Dim strMVaSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colMVaSTEnt)
                Dim strAliquotaICMSSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaICMSSTEnt)
                Dim strValICMSSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValICMSSTEnt)
                Dim strNCMEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colNCMEnt)
                Dim strRegimeEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colRegimeEnt)
                Dim strCalculoCredEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCalculoCredEnt)
                Dim strValCalculoCredEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValCredEnt)
                Dim strCFOPEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCFOPEnt)
                Dim strCSTIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTIPIEnt)
                Dim strCodEnqEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodEnqEnt)
                Dim strAliquotaIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaIPIEnt)
                Dim strValIPIEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValIPIEnt)
                Dim strCSTPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTPISEnt)
                Dim strAliquotaPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaPISEnt)
                Dim strValPISEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValPISEnt)
                Dim strCSTCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCSTCOFINSEnt)
                Dim strAliquotaCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colAliquotaCOFINSEnt)
                Dim strValCOFINSEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colValCOFINSEnt)
                Dim strCodigoANPEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colCodigoANPEnt)
                Dim strUFCombEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colUFCombEnt)
                Dim strVFCPSTEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colVFCPSTEnt)

                Dim strFreteEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colFreteEnt)
                Dim strDespesasEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colDespesasEnt)
                Dim strSeguroEnt As String = Me.grd1.GetRowCellDisplayText(I, Me.colSeguroEnt)


                If strCodigo = "Inserir" Then
                    grd1.SetRowCellValue(I, Me.colCodigo, "OK")
                    Inserir("INSERT INTO EntradaNF (CodTotNF, CodProd, Qtd, ValorUnitario, ValorTotal, Produto, " & _
                    "CodProdInterno, ICMS, Desconto, IPI, UnitarioImposto, Tamanho, CodConfig, ValProd, PorProd, " & _
                    "Grupo, Setor, TipoProduto, CFOP, NCM, Regime, CST, Origem, CalculoCred, " & _
                    "ValCalculoCred, ModBC, RedBC, AliquotaICMS, ValICMS, ModBCST, RedBCST, MVaSTEnt, AliquotaICMSST, " & _
                    "ValICMSST, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, ValPIS, CSTCOFINS, " & _
                    "AliquotaCOFINS, ValCOFINS, CodigoANPEnt, UFCombEnt, CodProdFor, ValorCusto, UMProd, QtdProd, " & _
                    "VFCPST, FreteEnt, DespesasEnt, SeguroEnt) VALUES (" & _
                    "" & intCodigoTotalNF & "," & strCodProd & "," & Num(strQtd) & "," & Num(strValorUnitario) & "," & _
                    "" & Num(strValorTotal) & ",'" & strProduto & "','" & strCodProdInterno & "','" & strICMS & "'," & _
                    "'" & strDesconto & "','" & strIPI & "'," & Num(strUnitario) & ",'" & strTamanho & "','" & strCodConfig & "'," & _
                    "" & Num(strValProd) & "," & Num(strPorProd) & ",'" & strGrupo & "','" & strSetor & "'," & _
                    "'" & strTipoProduto & "','" & strCFOPEnt & "','" & strNCMEnt & "','" & strRegimeEnt & "'," & _
                    "'" & strCSTEnt & "','" & strOrigemEnt & "','" & strCalculoCredEnt & "','" & strValCalculoCredEnt & "'," & _
                    "'" & strModBCEnt & "','" & strRedBCEnt & "','" & strAliquotaICMSEnt & "','" & strValICMSEnt & "'," & _
                    "'" & strModBCSTEnt & "','" & strRedBCSTEnt & "','" & strMVaSTEnt & "','" & strAliquotaICMSSTEnt & "'," & _
                    "'" & strValICMSSTEnt & "','" & strCSTIPIEnt & "','" & strCodEnqEnt & "','" & strAliquotaIPIEnt & "'," & _
                    "'" & strValIPIEnt & "','" & strCSTPISEnt & "','" & strAliquotaPISEnt & "','" & strValPISEnt & "'," & _
                    "'" & strCSTCOFINSEnt & "','" & strAliquotaCOFINSEnt & "','" & strValCOFINSEnt & "'," & _
                    "'" & strCodigoANPEnt & "','" & strUFCombEnt & "','" & strCodProdFor & "'," & Num(strValorCusto) & "," & _
                    "'" & strUMProd & "'," & Num(strQtdProd) & ",'" & strVFCPSTEnt & "','" & strFreteEnt & "'," & _
                    "'" & strDespesasEnt & "','" & strSeguroEnt & "')")

                Else
                    If strCodigo <> "OK" Then
                        Atualizar("UPDATE EntradaNF SET CodProd = " & strCodProd & ", Qtd = " & Num(strQtd) & ", " & _
                        "ValorUnitario = " & Num(strValorUnitario) & ", ValorTotal = " & Num(strValorTotal) & ", " & _
                        "Produto = '" & strProduto & "', CodProdInterno = '" & strCodProdInterno & "', " & _
                        "ICMS = '" & strICMS & "', IPI = '" & strIPI & "', UnitarioImposto = " & Num(strUnitario) & ", " & _
                        "Tamanho = '" & strTamanho & "', CodConfig = '" & strCodConfig & "', ValProd = " & Num(strValProd) & ", " & _
                        "PorProd = " & Num(strPorProd) & ", Grupo = '" & strGrupo & "', Setor = '" & strSetor & "', " & _
                        "TipoProduto = '" & strTipoProduto & "', CFOP = '" & strCFOPEnt & "', NCM = '" & strNCMEnt & "', " & _
                        "Regime = '" & strRegimeEnt & "', CST = '" & strCSTEnt & "', Origem = '" & strOrigemEnt & "', " & _
                        "CalculoCred = '" & strCalculoCredEnt & "', ValCalculoCred = '" & strValCalculoCredEnt & "', " & _
                        "ModBC = '" & strModBCEnt & "', RedBC = '" & strRedBCEnt & "', AliquotaICMS = '" & strAliquotaICMSEnt & "', " & _
                        "ValICMS = '" & strValICMSEnt & "', ModBCST = '" & strModBCSTEnt & "', RedBCST = '" & strRedBCSTEnt & "', " & _
                        "MVaSTEnt = '" & strMVaSTEnt & "', AliquotaICMSST = '" & strAliquotaICMSSTEnt & "', " & _
                        "ValICMSST = '" & strValICMSSTEnt & "', CSTIPI = '" & strCSTIPIEnt & "', CodEnq = '" & strCodEnqEnt & "', " & _
                        "AliquotaIPI = '" & strAliquotaIPIEnt & "', ValIPI = '" & strValIPIEnt & "', CSTPIS = '" & strCSTPISEnt & "', " & _
                        "AliquotaPIS = '" & strAliquotaPISEnt & "', ValPIS = '" & strValPISEnt & "', CSTCOFINS = '" & strCSTCOFINSEnt & "', " & _
                        "AliquotaCOFINS = '" & strAliquotaCOFINSEnt & "', ValCOFINS = '" & strValCOFINSEnt & "', " & _
                        "CodigoANPEnt = '" & strCodigoANPEnt & "', UFCombEnt = '" & strUFCombEnt & "', " & _
                        "CodProdFor = '" & strCodProdFor & "', ValorCusto = " & Num(strValorCusto) & ", " & _
                        "UMProd = '" & strUMProd & "', QtdProd = " & Num(strQtdProd) & ", VFCPST = '" & strVFCPSTEnt & "', " & _
                        "FreteEnt = '" & strFreteEnt & "', DespesasEnt = '" & strDespesasEnt & "', " & _
                        "SeguroEnt = '" & strSeguroEnt & "' where Codigo = " & strCodigo)

                    End If
                End If
            Next

            Atualizar("UPDATE TotalEntradaNF SET NumeroNF = '" & Me.txtNF.Text.Trim & "', CodFor = " & intCodFornecedor & ", " & _
            "Total = " & Num(Me.txtValNota.Text.Trim) & ", Obs = '" & Me.txtObs.Text.Trim & "', " & _
            "Data = '" & Me.dtData.Text.Trim & "', EstoqueOK = '" & Me.chkEstoqueOK.Checked & "', " & _
            "Desconto = '" & Me.txtDesconto.Text.Trim & "|" & Me.txtValDesc.Text.Trim & "', " & _
            "Tipo = '" & Me.cboTipo.Text.Trim & "', Serie = '" & Me.txtSerie.Text.Trim & "', " & _
            "ValorFrete = '" & Me.txFrete.Text.Trim & "', ValorSeguro = '" & Me.txtSeguro.Text.Trim & "', " & _
            "OutrasDespesas = '" & Me.txtDespesas.Text.Trim & "', ICMS = '" & Me.txtICMS.Text.Trim & "', " & _
            "IPI = '" & Me.txtIPI.Text.Trim & "', CodConfig = " & CodConfig & ", CalcImpProd = '" & Me.chkImpostoItens.Checked & "' where Codigo = " & intCodigoTotalNF)
            MsgBox("Alteração de Nota concluída com sucesso!", MsgBoxStyle.Information)
        End If

        VerificarContaPagar()

        If MsgBox("Deseja realmente atualizar o estoque?" & vbCrLf & "Se clicar em 'Sim' essa nota não poderá ser mais alterada!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim intDia, intMes, intAno, intHora, intMinuto As Integer
            Dim strLote As String

            intDia = Date.Today.Day
            intMes = Month(Now)
            intAno = Year(Now)
            intHora = Hour(Now)
            intMinuto = Minute(Now)

            strLote = intDia.ToString("00") & intMes.ToString("00") & intAno & "-" & intHora.ToString("00") & intMinuto.ToString("00")


            Dim strValorLog As String = ""
            Dim strValorCustoLog As String = ""
            Dim strCodInterno As String = ""

            With grd1
                For I = 0 To .RowCount - 1
                    Dim strUniMed As String = ""
                    Dim strQtd As String = ""
                    Dim strVal As String = ""
                    Dim strTam As String = ""
                    Dim intCodProd As Integer
                    Dim dblQtd As Double
                    Dim strCodProdFornec As String = ""
                    Dim strCodConfig As String = ""
                    Dim strValor As String = .GetRowCellDisplayText(I, Me.colValProd)
                    Dim strPorProd As String = .GetRowCellDisplayText(I, Me.colPorProd)
                    dblQtd = .GetRowCellDisplayText(I, Me.colQtdProd)
                    intCodProd = .GetRowCellDisplayText(I, Me.colCodProd)
                    strVal = .GetRowCellDisplayText(I, Me.colValorCusto)
                    strTam = .GetRowCellDisplayText(I, Me.colTamanho)
                    strCodConfig = .GetRowCellDisplayText(I, Me.colCodConfig)
                    strCodProdFornec = .GetRowCellDisplayText(I, Me.colCodProdFor).Trim



                    Dim strGrupo As String = Me.grd1.GetRowCellDisplayText(I, Me.colGrupo)
                    Dim strSetor As String = Me.grd1.GetRowCellDisplayText(I, Me.colSetor)

                    Dim dt As DataTable = CarregarDataTable("Select UnidadeMedida, convert(numeric(15,2),ValorCusto) as ValorCusto, convert(numeric(15,2),Valor) as Valor, CodigoInterno from Produto where Codigo =" & intCodProd)

                    If dt.Rows.Count > 0 Then
                        strValorLog = dt.Rows.Item(0).Item("Valor").ToString
                        strValorCustoLog = dt.Rows.Item(0).Item("ValorCusto").ToString
                        strCodInterno = dt.Rows.Item(0).Item("CodigoInterno").ToString

                        If strValor <> strValorLog Then
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strValorLog & "'," & _
                            "'Nº NF: " & Me.txtNF.Text & " Forn: " & Me.txtFor.Text & " Código: " & strCodInterno & " Valor: " & strValor & "','VALOR VENDA','ENTRADA NF','ALTERAÇÃO'," & CodConfig & ")")
                        End If

                        If strVal <> strValorCustoLog Then
                            Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, CodConfig) VALUES (" & _
                            "'" & My.Computer.Clock.LocalTime & "'," & CodUser & ",'" & strValorCustoLog & "'," & _
                            "'Nº NF: " & Me.txtNF.Text & " Forn: " & Me.txtFor.Text & " Código: " & strCodInterno & " Valor Custo: " & strVal & "','VALOR CUSTO','ENTRADA NF','ALTERAÇÃO'," & CodConfig & ")")
                        End If

                        strUniMed = .GetRowCellDisplayText(I, Me.colUMProd)
                        If strUniMed = "" Then
                            strUniMed = dt.Rows.Item(0).Item("UnidadeMedida").ToString
                        End If

                        If strUniMed = "" Then
                            strUniMed = "UN"
                        End If
                        If NomeEmpresa.Contains("TAUÁ") = True Then
                            strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                        Else
                            If AtuPreCusto = False Then
                                strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                            End If
                        End If
                 
                    End If

                    Select Case strUniMed
                        Case "UN", "JG", "KIT", ""
                            strQtd = dblQtd.ToString("0")

                        Case "MT"
                            strQtd = dblQtd.ToString("0.00")

                        Case "LT", "KG"
                            strQtd = dblQtd.ToString("0.000")
                        Case Else
                            strQtd = dblQtd.ToString("0.000")
                    End Select

                    If BaixaPorLote = True Then

                        Atualizar("UPDATE Qtde SET DataFim = '01/01/1900' where CodProd = " & intCodProd & " and CodConfig = " & strCodConfig)

                        Inserir("Insert Into Qtde (CodProd, Tamanho, QtdMinima, Qtd, Lote, EmFalta, " & _
                        "ValorCusto, CodConfig, Acabou, DataFim) Values(" & intCodProd & ",'" & strTam & "'," & _
                        "" & 0 & "," & Num(strQtd) & ",'" & strLote & "','" & 0 & "'," & Num(strVal) & "," & _
                        "" & strCodConfig & ",'False','01/01/1900')")

                        If NomeEmpresa.Contains("TAUÁ") = False Then
                            Dim strValores As String = ""
                            If AtuPreCusto = True Then
                                strValores = "Valor = " & Num(strValor) & ", Porcentagens = '" & strPorProd & "',"
                                Atualizar("Update Produto SET " & strValores & " UnidadeMedida = '" & strUniMed & "', CodProdFor ='" & strCodProdFornec & "' where Codigo = " & intCodProd)
                            End If
                        End If

                    Else

                        Dim dtConf As DataTable = CarregarDataTable("Select Codigo from Config Order by Codigo")
                        Dim Y As Integer
                        For Y = 0 To dtConf.Rows.Count - 1

                            Dim intCodConfigTabQtde, intCodConfigItemNF As Integer

                            intCodConfigTabQtde = dtConf.Rows.Item(Y).Item("Codigo").ToString
                            intCodConfigItemNF = Me.grd1.GetRowCellDisplayText(I, Me.colCodConfig)

                            If intCodConfigTabQtde = intCodConfigItemNF Then

                                Dim dtQtd5 As DataTable = CarregarDataTable("Select Qtd, QtdMinima from Qtde where CodProd =" & intCodProd & " and CodConfig=" & intCodConfigItemNF)
                                If dtQtd5.Rows.Count > 0 Then

                                    Dim dblQtd5, dblQtdMin5, dblResQtd As Double
                                    Dim intFalta As Integer = 0

                                    dblQtd5 = dtQtd5.Rows.Item(0).Item("Qtd").ToString
                                    dblQtdMin5 = dtQtd5.Rows.Item(0).Item("QtdMinima").ToString
                                    If EstoqueSomado = True Then
                                        dblQtd5 = AjusteQtde(intCodConfigItemNF, intCodProd)
                                        dblResQtd = dblQtd5 + CDbl(strQtd)
                                    Else
                                        dblResQtd = dblQtd5 + CDbl(strQtd)

                                    End If
                                 
                                    If dblQtdMin5 >= dblResQtd Then
                                        intFalta = 1
                                    End If



                                    If NomeEmpresa.ToUpper.Contains("CAMPOS") = False Then
                                        If MediaCusto = True Then
                                            'MEDIA VALOR DE CUSTO - Somente Estoque Somado  
                                            If EstoqueSomado = True Then
                                                'Dim dblCustoAntigo As Double = 0
                                                'Dim dblCustoNovo As Double = 0
                                                'Dim dblAntigo As Double = strValorCustoLog
                                                'Dim dblCusto As Double = strVal
                                                'Dim dblTotalCusto As Double = 0

                                                'Dim dblQtdAtual As Double = 0

                                                'Dim F As Integer
                                                'For F = 0 To dtConf.Rows.Count - 1
                                                '    Dim intCodConfigAjuste As Integer = dtConf.Rows.Item(F).Item("Codigo").ToString
                                                '    dblQtdAtual += AjusteQtde(intCodConfigAjuste, intCodProd)
                                                'Next

                                                'If dblQtdAtual > 0 Then
                                                '    dblCustoAntigo = dblAntigo * dblQtdAtual
                                                '    dblCustoNovo = dblCusto * dblQtd

                                                '    dblResQtd = dblQtdAtual + dblQtd

                                                '    dblTotalCusto = dblCustoAntigo + dblCustoNovo
                                                '    Dim dblResultado As Double = dblTotalCusto / dblResQtd
                                                '    Dim strResultado As String = dblResultado.ToString("0.00")

                                                '    If strResultado.Contains("+Infinito") = False Or strResultado.Contains("NaN") = False Then
                                                '        strVal = strResultado
                                                '    Else
                                                '        strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                                                '    End If
                                                '    If dblQtdAtual < 0 Then
                                                '        strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                                                '    End If

                                                '    Dim dblPor As Double = ((strValor - strVal) * 100) / strVal
                                                '    strPorProd = dblPor.ToString("0.000")
                                                'End If

                                                Dim strData As String = String.Format("Data >= '{0:dd/MM/yyyy}' AND Data <= '{1:dd/MM/yyyy}'", Date.Today.AddMonths(-3), Date.Today)

                                                'Dim dtCustoTotal As DataTable = CarregarDataTable("SELECT sum(Qtd * ValorCusto) as ValorCusto, sum(Qtd) as Qtd FROM EntradaNF left join TotalEntradaNf on EntradaNF.CodTotNF = TotalEntradaNF.Codigo where CodProd = " & intCodProd & " and " & strData & " group by CodProd")
                                                Dim dtCustoTotal As DataTable = CarregarDataTable("SELECT sum(QtdProd * ValorCusto) as ValorCusto, sum(QtdProd) as Qtd FROM (Select Top 3 QtdProd, ValorCusto From EntradaNF left join TotalEntradaNf on EntradaNF.CodTotNF = TotalEntradaNF.Codigo where CodProd = " & intCodProd & " And " & strData & " Order by Data Desc, TotalEntradaNf.Codigo Desc) As Media")
                                                If dtCustoTotal.Rows.Count > 0 Then
                                                    If dtCustoTotal.Rows.Item(0).Item("ValorCusto").ToString <> "" Then
                                                        Dim dblValCustoTotal As Double = dtCustoTotal.Rows.Item(0).Item("ValorCusto").ToString
                                                        Dim intQtdCustoTotal As Integer = dtCustoTotal.Rows.Item(0).Item("Qtd").ToString

                                                        'dblValCustoTotal += strVal
                                                        'intQtdCustoTotal += 1
                                                        Dim dlbResulTotal As Double = dblValCustoTotal / intQtdCustoTotal
                                                        Dim strResultado As String = dlbResulTotal.ToString("0.00")

                                                        If strResultado.Contains("+Infinito") = False Or strResultado.Contains("NaN") = False Then
                                                            strVal = strResultado
                                                        Else
                                                            strVal = dt.Rows.Item(0).Item("ValorCusto").ToString
                                                        End If

                                                        If ManterPorcProd = False Then
                                                            Dim dblPor As Double = ((strValor - strVal) * 100) / strVal
                                                            strPorProd = dblPor.ToString("0.000")
                                                        Else
                                                            Dim dblVal As Double = (strVal * strPorProd) / 100
                                                            strValor = strVal + dblVal
                                                        End If

                                                     
                                                    End If

                                                End If
                                            End If
                                        End If
                                    End If

                                    Atualizar("Update Produto set ValorCusto =" & Num(strVal) & " where Codigo =" & intCodProd)

                                    Atualizar("Update Qtde set Qtd =" & Num(dblResQtd) & ", EmFalta ='" & intFalta & "', ValorCusto =" & Num(strVal) & " where CodProd =" & intCodProd & " and CodConfig=" & intCodConfigItemNF)

                                End If
                            End If

                        Next


                        If NomeEmpresa.Contains("TAUÁ") = False Then
                            Dim strValores As String = ""
                            If AtuPreCusto = True Then
                                strValores = "ValorCusto =" & Num(strVal) & ", Valor = " & Num(strValor) & ", Porcentagens = '" & strPorProd & "',"

                                Atualizar("Update Qtde set ValorCusto =" & Num(strVal) & " where CodProd =" & intCodProd)

                            End If
                            Atualizar("Update Produto SET " & strValores & " Grupo = '" & strGrupo & "', Setor = '" & strSetor & "', UnidadeMedida = '" & strUniMed & "', CodProdFor ='" & strCodProdFornec & "' where Codigo = " & intCodProd)
                        End If

                    End If
                Next

                Atualizar("Update TotalEntradaNF set Lote ='" & strLote & "', EstoqueOK = 'True' where NumeroNF ='" & Me.txtNF.Text.Trim & "' and CodFor =" & intCodFornecedor)

            End With

            MsgBox("Estoque Atualizado com sucesso!", MsgBoxStyle.Information)

            'If ContaPagarGerada = False Then
            '    If MsgBox("Deseja informar a Conta a Pagar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '        GerarContaPagar()
            '    End If
            'End If

            If NomeImpCodigoBarra <> "" Then
                If MsgBox("Deseja Imprimir as etiquetas dos produtos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    SelecaoEtiqueta()
                End If
            End If

            If Me.Tag = "ALTERA" Then
                Me.Close()
            End If

        End If
        Limpar()
    End Sub
    Private Function VerificarContaPagar() As Boolean
        'If intCodFornecedor = 0 Or intCodFornecedor = Nothing Then
        '    'MsgBox("Conta a pagar não cadastrada!", MsgBoxStyle.Information)
        '    Return False
        'End If
        If vetParcela Is Nothing Then Exit Function


        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ContaPagar where NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
        If dt.Rows.Count = 0 Then
            Dim I As Integer
            Dim bolCTPagarNF As Boolean = False
            For I = 0 To Me.grd3.RowCount - 1

                'Dim vetPar As Array = Split(vetParcela(I), "-")

                Dim strValParcela As String = Me.grd3.GetRowCellDisplayText(I, Me.colValorParcela)
                Dim strVenc As String = Me.grd3.GetRowCellDisplayText(I, Me.colVencimento)


                Inserir("INSERT INTO ContaPagar (CodFor, TipoConta, Valor, FormaPagamento, Parcelas, " & _
                "ValorParcela, Vencimento, Pagamento, ValorPago, Descricao, PagoOK, NumeroDocumento, " & _
                "TipoCusto, Banco, CentroCusto, CodConfig, Data) VALUES (" & intCodFornecedor & "," & _
                "'" & Me.cboTipConta.Text & "'," & Num(strValorContaPagar) & ",'" & Me.luePag.Text & "','" & I + 1 & "'," & _
                "" & Num(strValParcela) & ",'" & strVenc & "','" & Me.luePag.GetColumnValue("FormaPagamento").ToString & "'," & _
                "0,'','" & False & "','" & Me.txtNF.Text & "','" & Me.cboTipCus.Text & "','','" & Me.cboCenCus.Text & "'," & CodConfig & ",'" & Me.dtData.Text.Trim & "')")
                bolCTPagarNF = True
            Next
            If bolCTPagarNF = True Then
                Atualizar("UPDATE TotalEntradaNF SET CTPagarOk = 'True' where Codigo = " & intCodigoTotalNF)
            End If
        Else
            Atualizar("UPDATE TotalEntradaNF SET CTPagarOk = 'True' where Codigo = " & intCodigoTotalNF)
        End If
        Return True
    End Function
    Private Sub btnConPagar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPagar.ItemClick
        If Me.txtCPF.Text.Trim <> "" Then
            Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "'")
            If dtFor.Rows.Count = 0 Then
                If Me.tbFor.Rows.Count > 0 Then
                    Dim strEndereco As String = tbFor.Rows.Item(0).Item("Endereco").ToString
                    Dim strNumero As String = tbFor.Rows.Item(0).Item("Numero").ToString
                    Dim strBairro As String = tbFor.Rows.Item(0).Item("Bairro").ToString
                    Dim strCidade As String = tbFor.Rows.Item(0).Item("Cidade").ToString
                    Dim strEstado As String = tbFor.Rows.Item(0).Item("Estado").ToString
                    Dim strCep As String = tbFor.Rows.Item(0).Item("Cep").ToString
                    Dim strTelefone As String = tbFor.Rows.Item(0).Item("Telefone").ToString
                    Dim strIE As String = tbFor.Rows.Item(0).Item("IE").ToString
                    Dim strFantasia As String = tbFor.Rows.Item(0).Item("Fantasia").ToString
                    If MsgBox("Fornecedor não cadastrado, deseja cadastra-lo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, IE, Data, Fantasia, Tipo) VALUES ('" & Me.txtFor.Text.Trim & "','" & Me.txtCPF.Text.Trim & "','" & strEndereco & "','" & strNumero & "','" & strBairro & "','" & strCidade & "','" & strEstado & "','" & strCep & "','" & strTelefone & "','" & strIE & "','" & Date.Today & "','" & strFantasia & "','F')")
                        intCodFornecedor = GerarCodigo("Fornecedor", "Codigo", 0) - 1
                        MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If
            Else
                intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
            End If
        End If

        Dim frm As New frmPagar
        frm.Tag = "PESQUISA"
        frm.txtFornecedor.Text = Me.txtFor.Text.Trim
        frm.cboTipConta.Text = "FORNECEDOR"
        frm.txtValConta.Text = Me.txtValNota.Text.Trim
        frm.strNumDocumento = Me.txtNF.Text
        frm.luePag.Focus()
        frm.ShowDialog()

        Dim dtConta As DataTable = CarregarDataTable("SELECT Valor, Parcelas, ValorParcela, " & _
        "convert(varchar(10),Vencimento,103) as Vencimento FROM ContaPagar where " & _
        "NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
        If dtConta.Rows.Count > 0 Then
            Dim I As Integer
            Me.tbContaPagar.Rows.Clear()
            For I = 0 To dtConta.Rows.Count - 1
                Me.tbContaPagar.Rows.Add()
                Me.tbContaPagar.Rows.Item(I).Item("ValorParcela") = dtConta.Rows.Item(I).Item("ValorParcela").ToString
                Me.tbContaPagar.Rows.Item(I).Item("ValorConta") = dtConta.Rows.Item(I).Item("Valor").ToString
                Me.tbContaPagar.Rows.Item(I).Item("Vencimento") = dtConta.Rows.Item(I).Item("Vencimento").ToString
                Me.tbContaPagar.Rows.Item(I).Item("Parcela") = dtConta.Rows.Item(I).Item("Parcelas").ToString
            Next
            Me.grpConta.Visible = True
        Else
            Me.grpConta.Visible = False
        End If

    End Sub
    Private Sub SelecaoEtiqueta()
        frmModEtiqueta.ShowDialog()

        CodigoProdutoEtiqueta = ""
        QtdeEtiqueta = ""
        TamanhoEtiqueta = ""
        Select Case frmModEtiqueta.cboEti.Text
            Case "DUPLA GRANDE"
                Etiquetas()

            Case Else
                Dim P As Integer

                For P = 0 To Me.grd1.RowCount - 1
                    CodigoProdutoEtiqueta &= Me.grd1.GetRowCellDisplayText(P, Me.colCodProd) & "|"
                    QtdeEtiqueta &= Me.grd1.GetRowCellDisplayText(P, Me.colQtd) & "|"
                    If BaixaPorLote = True Then
                        TamanhoEtiqueta &= Me.grd1.GetRowCellDisplayText(P, Me.colTamanho) & "|"
                    End If
                Next
        End Select

        frmImpProd.Tag = frmModEtiqueta.cboEti.Text
        frmImpProd.Show()
        

    End Sub
    Private Sub Etiquetas()

        Dim strTexto, strProd, strCod As String
        Dim I As Integer

        If NomeImpCodigoBarra = "ARGOX OS-214 PLUS" Then

            'strTexto = LerArquivo("C:\DuplaGrande.prn", True)

            'Dim intCont As Integer = 0
            'Dim intArq As Integer = 0
            'For I = 0 To Me.grd1.RowCount - 1

            '    Dim dt As DataTable = CarregarDataTable("Select CodigoInterno, Fabricante, Valor from Produto where Codigo=" & Me.grd1.GetRowCellDisplayText(I, Me.colCodProd))

            '    Dim dblQtd As Double
            '    Dim strTam, strPreco, strMarca As String
            '    Dim strProd1, strProd2 As String

            '    strProd = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Trim
            '    strCod = dt.Rows.Item(0).Item("CodigoInterno").ToString

            '    If strProd.Trim.Length > 29 Then
            '        strProd1 = Mid(strProd, 1, 29)
            '        strProd2 = Mid(strProd, 30, strProd.Trim.Length)
            '    Else
            '        strProd1 = strProd
            '        strProd2 = ""
            '    End If

            '    dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            '    strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
            '    Dim dblPreco As Double = dt.Rows.Item(0).Item("Valor").ToString

            '    strPreco = dblPreco.ToString("0.00")
            '    strMarca = dt.Rows.Item(0).Item("Fabricante").ToString

            '    Dim J As Integer

            '    For J = 0 To dblQtd - 1
            '        intCont += 1

            '        If intCont = 1 Then
            '            strTexto = strTexto.Replace("EEEE", NomeEmpresa)
            '            strTexto = strTexto.Replace("191100102270022PPPP", "191100102270022" & strProd1)
            '            strTexto = strTexto.Replace("191100102130022PPP2", "191100102130022" & strProd2)
            '            strTexto = strTexto.Replace("191100101980022MMMM", "191100101980022" & strMarca)
            '            strTexto = strTexto.Replace("1a420250067003000000-0", "1a4202500670030" & strCod & "-" & strTam)
            '            strTexto = strTexto.Replace("1a420250142002900000-0", "1a4202501420029" & strCod & "-" & strTam)
            '            strTexto = strTexto.Replace("131100000290070VVVV", "131100000290070R$ " & strPreco)
            '            strTexto = strTexto.Replace("121100001820022TTTT", "121100001820022Tam.: " & strTam)


            '            strTexto = strTexto.Replace("121100001300057CCCCCC", "121100001300057" & strCod & "-" & strTam)
            '            strTexto = strTexto.Replace("121100000540057CCCCCC", "121100000540057" & strCod & "-" & strTam)
            '        Else

            '            strTexto = strTexto.Replace("191100102270203PPPP", "191100102270203" & strProd1)
            '            strTexto = strTexto.Replace("191100102130203PPP2", "191100102130203" & strProd2)
            '            strTexto = strTexto.Replace("191100101980203MMMM", "191100101980203" & strMarca)
            '            strTexto = strTexto.Replace("131100000290251VVVV", "131100000290251R$ " & strPreco)
            '            strTexto = strTexto.Replace("121100001820203TTTT", "121100001820203Tam.: " & strTam)
            '            strTexto = strTexto.Replace("1a420250067021100000-0", "1a4202500670211" & strCod & "-" & strTam)
            '            strTexto = strTexto.Replace("1a420250142021000000-0", "1a4202501420210" & strCod & "-" & strTam)

            '            strTexto = strTexto.Replace("121100001300238CCCCCC", "121100001300238" & strCod & "-" & strTam)
            '            strTexto = strTexto.Replace("121100000540238CCCCCC", "121100000540238" & strCod & "-" & strTam)

            '        End If

            '        If intCont = 2 Then
            '            EscreveArquivo("C:\Etiqueta1.prn", strTexto)
            '            System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
            '            System.IO.File.Delete("C:\Etiqueta1.prn")
            '            strTexto = LerArquivo("C:\DuplaGrande.prn", True)
            '            intCont = 0
            '        End If

            '    Next

            'Next

            'If intCont = 1 Then
            '    EscreveArquivo("C:\Etiqueta1.prn", strTexto)
            '    System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
            '    System.IO.File.Delete("C:\Etiqueta1.prn")
            '    strTexto = LerArquivo("C:\DuplaGrande.prn", True)
            '    intCont = 0
            'End If

            strTexto = LerArquivo("C:\DuplaGrande.prn", True)

            Dim intCont As Integer = 0
            Dim intArq As Integer = 0
            Dim J As Integer

            For I = 0 To Me.grd1.RowCount - 1
                'If Me.grd1.GetRowCellValue(I, Me.colImprimir) = True Then

                Dim dblQtd As Double
                Dim strTam As String
                Dim strProd1, strProd2 As String

                strProd = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Trim
                strCod = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno).Trim

                If strProd.Trim.Length > 29 Then
                    strProd1 = Mid(strProd, 1, 29)
                    strProd2 = Mid(strProd, 30, strProd.Trim.Length)
                Else
                    strProd1 = strProd
                    strProd2 = ""
                End If

                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                Dim dblPreco As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValProd).Trim
                Dim strPreco As String = dblPreco.ToString("0.00")
                Dim strMarca As String = Me.txtFor.Text
                For J = 0 To dblQtd - 1
                    intCont += 1


                    If intCont = 1 Then
                        strTexto = strTexto.Replace("EEEE", NomeEmpresa)
                        strTexto = strTexto.Replace("PPP1", strProd1)
                        strTexto = strTexto.Replace("PPP2", strProd2)
                        strTexto = strTexto.Replace("MMM1", strMarca)
                        strTexto = strTexto.Replace("00000-1", strCod & "-" & strTam)
                        strTexto = strTexto.Replace("VVV1", "R$ " & strPreco)
                        strTexto = strTexto.Replace("TTT1", "Tam.: " & strTam)

                        strTexto = strTexto.Replace("CCCCC1", strCod & "-" & strTam)


                    Else

                        strTexto = strTexto.Replace("PPP3", strProd1)
                        strTexto = strTexto.Replace("PPP4", strProd2)
                        strTexto = strTexto.Replace("MMM2", strMarca)
                        strTexto = strTexto.Replace("VVV2", "R$ " & strPreco)
                        strTexto = strTexto.Replace("TTT2", "Tam.: " & strTam)
                        strTexto = strTexto.Replace("00000-2", strCod & "-" & strTam)

                        strTexto = strTexto.Replace("CCCCC2", strCod & "-" & strTam)

                    End If

                    If intCont = 2 Then
                        EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                        System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                        System.IO.File.Delete("C:\Etiqueta1.prn")
                        strTexto = LerArquivo("C:\DuplaGrande.prn", True)
                        intCont = 0
                    End If

                Next


                'End If
            Next

            If intCont = 1 Then
                EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                System.IO.File.Delete("C:\Etiqueta1.prn")
                strTexto = LerArquivo("C:\DuplaGrande.prn", True)
                intCont = 0
            End If

        End If


        If NomeImpCodigoBarra = "ZEBRA TLP 2844" Then

            strTexto = LerArquivo("C:\TemplateZebra.prn", True)

            Dim intCont As Integer = 0
            Dim intArq As Integer = 0
            Dim strAspas As String = """"
            For I = 0 To Me.grd1.RowCount - 1

                Dim dblQtd As Double
                Dim strTam, strPreco As String
                Dim strProd1, strProd2 As String

                strProd = Me.grd1.GetRowCellDisplayText(I, Me.colProduto).Trim
                strCod = Me.grd1.GetRowCellDisplayText(I, Me.colCodProdInterno).Trim

                If strProd.Trim.Length > 29 Then
                    strProd1 = Mid(strProd, 1, 23)
                    strProd2 = Mid(strProd, 24, strProd.Trim.Length)
                Else
                    strProd1 = strProd
                    strProd2 = ""
                End If

                dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
                strTam = Me.grd1.GetRowCellDisplayText(I, Me.colTamanho).Trim
                Dim dblPreco As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario).Trim
                strPreco = dblPreco.ToString("0.00")

                Dim strMes, strAno As String

                strMes = Now.Month
                strAno = Now.Year
                strAno = Mid(strAno, 3, strAno.Length)

                Dim J As Integer

                For J = 0 To dblQtd - 1
                    intCont += 1

                    If intCont = 1 Then
                        strTexto = strTexto.Replace("NOME DA LOJA", NomeEmpresa)
                        strTexto = strTexto.Replace("A331,342,2,3,1,1,N,'PPPP1'", "A331,342,2,3,1,1,N,'" & strProd1 & "'")
                        strTexto = strTexto.Replace("A331,321,2,3,1,1,N,'PPPP2'", "A331,321,2,3,1,1,N,'" & strProd2 & "'")
                        strTexto = strTexto.Replace("B330,285,2,1,3,9,75,B,'123456-T'", "B330,285,2,1,3,9,75,B,'" & strCod & "-" & strTam & "'")
                        strTexto = strTexto.Replace("A309,96,2,4,3,3,N,'00,00'", "A309,96,2,4,3,3,N,'" & strPreco & "'")
                        strTexto = strTexto.Replace("MAA", strMes & strAno)
                    Else
                        strTexto = strTexto.Replace("A699,342,2,3,1,1,N,'PPPP1'", "A699,342,2,3,1,1,N,'" & strProd1 & "'")
                        strTexto = strTexto.Replace("A699,321,2,3,1,1,N,'PPPP2'", "A699,321,2,3,1,1,N,'" & strProd2 & "'")
                        strTexto = strTexto.Replace("B698,285,2,1,3,9,75,B,'123456-T'", "B698,285,2,1,3,9,75,B,'" & strCod & "-" & strTam & "'")
                        strTexto = strTexto.Replace("A677,96,2,4,3,3,N,'00,00'", "A677,96,2,4,3,3,N,'" & strPreco & "'")

                    End If

                    If intCont = 2 Then
                        strTexto = strTexto.Replace("'", strAspas)
                        EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                        System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                        System.IO.File.Delete("C:\Etiqueta1.prn")
                        strTexto = LerArquivo("C:\TemplateZebra.prn", True)
                        intCont = 0
                    End If

                Next



            Next

            If intCont = 1 Then
                strTexto = strTexto.Replace("'", strAspas)
                EscreveArquivo("C:\Etiqueta1.prn", strTexto)
                System.IO.File.Copy("C:\Etiqueta1.prn", PortaImpressoraCodigoBarra, True)
                System.IO.File.Delete("C:\Etiqueta1.prn")
                strTexto = LerArquivo("C:\TemplateZebra.prn", True)
                intCont = 0
            End If

        End If
    End Sub
    Private Sub txtNF_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNF.EditValueChanged
        If Me.txtNF.Text.Trim = "" Then
            Limpar()
        End If
    End Sub

    Private Sub btnExcluir_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick
        If bolAlterado = True Then MsgBox("Existe um item sendo alterado, conclua a alteração antes de excluir algum item!", MsgBoxStyle.Information) : Exit Sub
        If grd1.RowCount = 0 Then Exit Sub
        If MsgBox("Deseja realmente excluir este item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strItensDeletado &= grd1.GetRowCellDisplayText(grd1.FocusedRowHandle, Me.colCodigo) & "|"
            Me.grd1.DeleteRow(grd1.FocusedRowHandle)

            If Me.grd1.RowCount = 0 Then
                Me.picFundo.Visible = True
            End If

            ' Me.EntradaNFBindingSource.RemoveAt(grd1.FocusedRowHandle)
        End If
        Calcular()
    End Sub

    Private Sub txtCodPro_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodPro.ButtonClick
        frmCadProduto.Close()
        'Dim frm As New frmCadProduto
        frmCadProduto.Tag = "ENTRADANF"
        frmCadProduto.ShowDialog()
        InserirProduto(True)
        Me.txtCodPro_Leave(sender, e)
    End Sub

    Private Sub btnCanNota_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCanNota.ItemClick
        With grd1

            If MsgBox("Deseja realmente Cancela a Entrada dessa NF?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                If BaixaPorLote = True Then
                    If strLoteTotal <> "" Then
                        Excluir("Delete from Qtde where Lote ='" & strLoteTotal & "'")
                    End If
                Else

                    Dim dt As DataTable = CarregarDataTable("Select Codigo From TotalEntradaNF where NumeroNF ='" & Me.txtNF.Text.Trim & "' and CodFor =" & intCodFornecedor & " and CodConfig =" & CodConfig)

                    Dim intCodTotNF As Integer

                    If dt.Rows.Count > 0 Then
                        intCodTotNF = dt.Rows.Item(0).Item("Codigo").ToString
                    End If

                    dt = CarregarDataTable("Select CodProd, QtdProd, CodConfig from EntradaNF where CodTotNF =" & intCodTotNF)

                    Dim T As Integer

                    For T = 0 To dt.Rows.Count - 1

                        Dim intCodPro, intCodConf As Integer
                        Dim dblQtd As Double
                        intCodPro = dt.Rows.Item(T).Item("CodProd").ToString
                        dblQtd = dt.Rows.Item(T).Item("QtdProd").ToString
                        intCodConf = dt.Rows.Item(T).Item("CodConfig").ToString

                        AlteraEstoque(intCodPro, dblQtd, "-", intCodConf)

                    Next

                End If

                If Me.txtCodPed.Text.Trim <> "" Then
                    Atualizar("Update TotalPedCompra set Status ='Pendente', NumeroNF ='' Where CodOrdens =" & Me.txtCodPed.Text.Trim & " AND NumeroNF ='" & Me.txtNF.Text.Trim & "' AND CodConfig=" & CodConfig)

                End If
                

                Excluir("Delete from TotalEntradaNF where Codigo = " & intCodigoTotalNF)

                Dim dtContaPagar As DataTable = CarregarDataTable("SELECT Codigo FROM ContaPagar  where NumeroDocumento = '" & Me.txtNF.Text.Trim & "' and CodFor = " & intCodFornecedor & " AND CodConfig=" & CodConfig)
                If dtContaPagar.Rows.Count > 0 Then
                    'If MsgBox("Existe conta a pagar vinculada! Deseja excluí-la?", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Excluir("Delete from ContaPagar where NumeroDocumento = '" & Me.txtNF.Text.Trim & "' and CodFor = " & intCodFornecedor & " AND CodConfig=" & CodConfig)

                    'End If

                End If

                Inserir("INSERT INTO Log (Data, CodUser, Antigo, Novo, Coluna, Tabela, Motivo, " & _
                "CodConfig) VALUES ('" & My.Computer.Clock.LocalTime & "'," & CodUser & "," & _
                "'" & "Nº NF " & Me.txtNF.Text.Trim & " For. " & Me.txtFor.Text & "','EXCLUSÃO','ENTRADA NF','ENTRADA NF','EXCLUSÃO'," & CodConfig & ")")


                MsgBox("Nota Fiscal de Entrada Cancelada com sucesso!", MsgBoxStyle.Information)

                Limpar()
            End If

        End With
    End Sub

    'Private Sub btnConPagar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConPagar.ItemClick
    '    GerarContaPagar()
    'End Sub

    'Private Sub GerarContaPagar()

    '    Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo, CPF FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "'")
    '    If dtFor.Rows.Count = 0 Then
    '        If Me.tbFor.Rows.Count > 0 Then
    '            Dim strEndereco As String = tbFor.Rows.Item(0).Item("Endereco").ToString
    '            Dim strNumero As String = tbFor.Rows.Item(0).Item("Numero").ToString
    '            Dim strBairro As String = tbFor.Rows.Item(0).Item("Bairro").ToString
    '            Dim strCidade As String = tbFor.Rows.Item(0).Item("Cidade").ToString
    '            Dim strEstado As String = tbFor.Rows.Item(0).Item("Estado").ToString
    '            Dim strCep As String = tbFor.Rows.Item(0).Item("Cep").ToString
    '            Dim strTelefone As String = tbFor.Rows.Item(0).Item("Telefone").ToString
    '            Dim strIE As String = tbFor.Rows.Item(0).Item("IE").ToString
    '            Dim strFantasia As String = tbFor.Rows.Item(0).Item("Fantasia").ToString
    '            If MsgBox("Fornecedor não cadastrado, deseja cadastra-lo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, IE, Data, Fantasia, Tipo) VALUES ('" & Me.txtFor.Text.Trim & "','" & Me.txtCPF.Text.Trim & "','" & strEndereco & "','" & strNumero & "','" & strBairro & "','" & strCidade & "','" & strEstado & "','" & strCep & "','" & strTelefone & "','" & strIE & "','" & Date.Today & "','" & strFantasia & "','F')")

    '                Dim dtFor2 As DataTable = CarregarDataTable("Select Codigo from Fornecedor where CPF ='" & Me.txtCPF.Text.Trim & "'")

    '                If dtFor.Rows.Count > 0 Then
    '                    intCodFornecedor = dtFor2.Rows.Item(0).Item("Codigo")
    '                Else
    '                    Exit Sub
    '                End If
    '                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information)
    '            Else
    '                Exit Sub
    '            End If
    '        End If
    '    Else
    '        If dtFor.Rows.Item(0).Item("CPF").ToString <> "" Then
    '            intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
    '        Else
    '            If intCodFornecedor <= 0 Then
    '                Exit Sub
    '            End If
    '        End If
    '    End If

    '    Dim frm As New frmPagar
    '    frm.Tag = "PESQUISA"
    '    frm.txtFornecedor.Text = Me.txtFor.Text.Trim
    '    frm.intCodFornecedor = intCodFornecedor
    '    frm.cboTipConta.Text = "FORNECEDOR"
    '    frm.txtValConta.Text = Me.txtValNota.Text.Trim
    '    frm.strNumDocumento = Me.txtNF.Text
    '    frm.ShowDialog()
    '    ContaPagarGerada = True
    'End Sub

    Private Sub txtCodPro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPro.Leave

        CarregarDadosLue("Select TOP 5 ValorUnitario, TotalEntradaNF.Data from EntradaNF Inner Join TotalEntradaNF on TotalEntradaNF.Codigo = EntradaNF.CodTotNF  where CodProdInterno =" & Me.txtCodPro.Tag.ToString.Trim & " order by Data DESC", Me.lueHis)
        If Me.txtCodPro.Text = "" Then
            Me.txtNomePro.Focus()
        Else
            Me.txtQtd.Focus()
        End If
       
    End Sub

    Private Sub txtDesconto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesconto.KeyPress, txtValDesc.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.Leave
        If Me.txtDesconto.Properties.ReadOnly = True Then Exit Sub
        If txtDesconto.Text.Trim = "" Then txtDesconto.Text = 0
        If Me.txtValNota.Text = "0,00" Then Exit Sub

        If Preco(Me.txtDesconto) = False Then Exit Sub
        Dim dblTotal, dblPor, dblResul As Double
        Try
            dblTotal = Me.txtDesconto.Tag
            dblPor = Me.txtDesconto.Text.Trim

            dblResul = (dblTotal * dblPor) / 100

            Me.txtValDesc.Text = dblResul.ToString("0.00")

            dblResul = dblTotal - dblResul

            txtValNota.Text = dblResul.ToString("0.00")
        Catch ex As Exception

        End Try
      
    End Sub


    Private Sub txFrete_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txFrete.Leave
        If Me.txFrete.Properties.ReadOnly = True Then Exit Sub
        Preco(txFrete)
        Calcular()
    End Sub

    Private Sub txtSeguro_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeguro.Leave
        If Me.txtSeguro.Properties.ReadOnly = True Then Exit Sub
        Preco(txtSeguro)
        Calcular()
    End Sub

    Private Sub txtDespesas_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDespesas.Leave
        If Me.txtDespesas.Properties.ReadOnly = True Then Exit Sub
        Preco(txtDespesas)
        Calcular()
    End Sub

    Private Sub txtValDesc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValDesc.Leave
        If txtValDesc.Properties.ReadOnly = True Then Exit Sub
        If txtValDesc.Text.Trim = "" Then txtValDesc.Text = "0,00"
        If Me.txtValNota.Text.Trim = "" Or Me.txtValNota.Text.Trim = "0,00" Then Exit Sub
        If Preco(Me.txtValDesc) = False Then Exit Sub

        Dim dblTotal, dblValDesc, dblResul As Double

        dblTotal = Me.txtDesconto.Tag
        dblValDesc = Me.txtValDesc.Text.Trim

        dblResul = (dblTotal - dblValDesc)

        Me.txtValNota.Text = dblResul.ToString("0.00")


        dblTotal = Me.txtDesconto.Tag

        dblValDesc = dblValDesc * 100

        dblResul = dblValDesc / dblTotal


        Me.txtDesconto.Text = dblResul.ToString("0.00")
    End Sub

    Private Sub txtPerDesc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPerDesc.Leave
        Preco(Me.txtPerDesc)
        If Me.txtPerDesc.Text.Trim <> "" And Me.txtPerDesc.Text <> "0,00" Then
            If Preco(Me.txtPerDesc) = False Then Exit Sub
        End If
    End Sub

    Private Sub AbreNF()

        If Me.Tag = "CONSULTA" Or Me.Tag = "ALTERA" Or Me.Tag = "CANCELA" Then

            Me.TotalEntradaNFBindingSource.Filter = " NumeroNF = '" & Me.txtNF.Text.Trim & "' and CodFor = " & intCodFornecedor
            Me.TotalEntradaNFTableAdapter.Fill(Me.dsNano.TotalEntradaNF)

            If grd2.RowCount = 0 Then

                MsgBox("Nota Fiscal não cadastrada no sistema!", MsgBoxStyle.Information)

                Limpar()
                Exit Sub
            End If

            Me.chkEstoqueOK.Checked = Me.grd2.GetRowCellValue(0, Me.colEstoqueOK)


            If Me.Tag = "ALTERA" Then
                If Me.chkEstoqueOK.Checked = True Then
                    MsgBox("Itens da Nota Fiscal já atualizaram o estoque, não é possivel alterá-la!", MsgBoxStyle.Information) : Limpar() : Exit Sub
                End If
            End If

            Me.EntradaNFBindingSource1.Filter = "CodTotNF =" & grd2.GetRowCellDisplayText(0, Me.colCodigo1)
            Me.EntradaNFTableAdapter.Fill(Me.dsNano.EntradaNF)


            Me.txtValNota.Text = grd2.GetRowCellDisplayText(0, Me.colTotal)
            Me.dtData.Text = grd2.GetRowCellDisplayText(0, Me.colData1)
            Me.txtObs.Text = grd2.GetRowCellDisplayText(0, Me.colDescricao)
            Dim vetDesconto As Array = Split(grd2.GetRowCellDisplayText(0, Me.colDesconto), "|")

            If vetDesconto.Length > 1 Then
                Me.txtDesconto.Text = vetDesconto(0).ToString
                Me.txtValDesc.Text = vetDesconto(1).ToString
            Else
                Me.txtDesconto.Text = vetDesconto(0).ToString
            End If

            'Me.txtDesconto.Text = grd2.GetRowCellDisplayText(0, Me.colDesconto)

            Me.txtSerie.Text = grd2.GetRowCellDisplayText(0, Me.colSerie)
            Me.cboTipo.Text = grd2.GetRowCellDisplayText(0, Me.colTipo)
            Me.txFrete.Text = grd2.GetRowCellDisplayText(0, Me.colValorFrete)
            Me.txtSeguro.Text = grd2.GetRowCellDisplayText(0, Me.colValorSeguro)
            Me.txtDespesas.Text = grd2.GetRowCellDisplayText(0, Me.colOutrasDespesas)

            Me.txtIPI.Text = grd2.GetRowCellDisplayText(0, Me.colIPI1)
            Me.txtICMS.Text = grd2.GetRowCellDisplayText(0, Me.colICMS1)

            Dim dblValTot As Double = Somar("Select sum(ValorTotal) from EntradaNF where NumeroNF = '" & Me.txtNF.Text.Trim & "' and CPF = '" & Me.txtCPF.Text.Trim & "'")

            Me.txtDesconto.Tag = dblValTot.ToString("0.00")
            If grd1.RowCount = 0 Then
                MsgBox("Nota Fiscal não cadastrada no sistema!", MsgBoxStyle.Information)
                txtNF.Focus()
            End If

        Else
            If PesquisarNF(txtNF, intCodFornecedor) = True Then
                Me.txtNF.Focus()
                Exit Sub
            End If
        End If

    End Sub
    Private Sub CarregarForm()

        If Me.Tag = "CONSULTA" Or Me.Tag = "ALTERA" Or Me.Tag = "CANCELA" Then


            Dim dtTot As DataTable = CarregarDataTable("SELECT Codigo, NumeroNF, CodFor, Total, Obs, Data, EstoqueOK, " & _
            "Desconto, Tipo, Serie, ValorFrete, ValorSeguro, OutrasDespesas, ICMS, IPI, Lote, CodConfig, CodPedido, " & _
            "Chave, CalcImpProd FROM TotalEntradaNF where NumeroNF = '" & Me.txtNF.Text.Trim & "' and CodFor = " & intCodFornecedor)
            If dtTot.Rows.Count = 0 Then
                MsgBox("Nota Fiscal não cadastrada no sistema!", MsgBoxStyle.Information) : Limpar() : Exit Sub
            End If

            Me.chkEstoqueOK.Checked = dtTot.Rows.Item(0).Item("EstoqueOK").ToString

            If Me.Tag = "ALTERA" Then
                If Me.chkEstoqueOK.Checked = True Then
                    MsgBox("Itens da Nota Fiscal já atualizaram o estoque, não é possivel alterá-la!", MsgBoxStyle.Information) : Limpar() : Exit Sub
                End If
            End If

            Dim intCodTotNF As Integer = dtTot.Rows.Item(0).Item("Codigo").ToString
            intCodigoTotalNF = dtTot.Rows.Item(0).Item("Codigo").ToString
            intCodigoConfig = dtTot.Rows.Item(0).Item("CodConfig").ToString
            strLoteTotal = dtTot.Rows.Item(0).Item("Lote").ToString
            Me.txtValNota.Text = dtTot.Rows.Item(0).Item("Total").ToString
            Dim dtData As String() = dtTot.Rows.Item(0).Item("Data").ToString.Split(" ")
            Me.dtData.Text = dtData(0)
            Me.txtObs.Text = dtTot.Rows.Item(0).Item("Obs").ToString
            Dim vetDesconto As Array = Split(dtTot.Rows.Item(0).Item("Desconto").ToString, "|")

            If vetDesconto.Length > 1 Then
                Me.txtDesconto.Text = vetDesconto(0).ToString
                Me.txtValDesc.Text = vetDesconto(1).ToString
            Else
                Me.txtDesconto.Text = vetDesconto(0).ToString
            End If

            'Me.txtDesconto.Text = grd2.GetRowCellDisplayText(0, Me.colDesconto)

            Me.txtSerie.Text = dtTot.Rows.Item(0).Item("Serie").ToString
            Me.cboTipo.Text = dtTot.Rows.Item(0).Item("Tipo").ToString
            Me.txFrete.Text = dtTot.Rows.Item(0).Item("ValorFrete").ToString
            Me.txtSeguro.Text = dtTot.Rows.Item(0).Item("ValorSeguro").ToString
            Me.txtDespesas.Text = dtTot.Rows.Item(0).Item("OutrasDespesas").ToString

            Me.txtIPI.Text = dtTot.Rows.Item(0).Item("IPI").ToString
            Me.txtICMS.Text = dtTot.Rows.Item(0).Item("ICMS").ToString
            Me.txtChave.Text = dtTot.Rows.Item(0).Item("Chave").ToString

            Dim dblValTot As Double = Somar("Select sum(ValorTotal) from EntradaNF where CodTotNF = " & intCodTotNF)

            Me.txtDesconto.Tag = dblValTot.ToString("0.00")

            Me.txtCodPed.Text = dtTot.Rows.Item(0).Item("CodPedido").ToString

            Me.chkImpostoItens.Checked = dtTot.Rows.Item(0).Item("CalcImpProd")
            Me.picFundo.Visible = False

            Dim dtEnt As DataTable = CarregarDataTable("SELECT EntradaNF.Codigo, EntradaNF.CodTotNF, EntradaNF.CodProd, EntradaNF.Qtd, " & _
            "EntradaNF.ValorUnitario, EntradaNF.ValorTotal, EntradaNF.Produto, EntradaNF.CodProdInterno, EntradaNF.ICMS, EntradaNF.Desconto, " & _
            "EntradaNF.IPI, EntradaNF.UnitarioImposto, EntradaNF.Tamanho, EntradaNF.CodConfig, EntradaNF.ValProd, EntradaNF.PorProd, " & _
            "Produto.CodigoBarra, EntradaNF.Grupo, EntradaNF.Setor, EntradaNF.MVaST, EntradaNF.PorICMS, EntradaNF.TipoProduto, " & _
            "CFOP, NCM, Regime, CST, Origem, CalculoCred, ValCalculoCred, ModBC, RedBC, AliquotaICMS, ValICMS, ModBCST, RedBCST, " & _
            "MVaSTEnt, AliquotaICMSST, ValICMSST, CSTIPI, CodEnq, AliquotaIPI, ValIPI, CSTPIS, AliquotaPIS, ValPIS, CSTCOFINS, " & _
            "AliquotaCOFINS, ValCOFINS, CodigoANPEnt, UFCombEnt, EntradaNF.ValorCusto, EntradaNF.QtdProd, EntradaNF.VFCPST, " & _
            "EntradaNF.FreteEnt, EntradaNF.DespesasEnt, EntradaNF.SeguroEnt FROM EntradaNF left join Produto on EntradaNF.CodProd = Produto.Codigo " & _
            "where CodTotNF = " & intCodTotNF)
            Dim I As Integer
            Me.tbEntrada.Rows.Clear()
            If dtEnt.Rows.Count > 0 Then

                For I = 0 To dtEnt.Rows.Count - 1
                    With Me.tbEntrada.Rows
                        .Add()
                        .Item(I).Item("Codigo") = dtEnt.Rows.Item(I).Item("Codigo").ToString
                        .Item(I).Item("CodProd") = dtEnt.Rows.Item(I).Item("CodProd").ToString
                        .Item(I).Item("CodProdInterno") = dtEnt.Rows.Item(I).Item("CodProdInterno").ToString
                        .Item(I).Item("Qtd") = dtEnt.Rows.Item(I).Item("Qtd").ToString

                        .Item(I).Item("Produto") = dtEnt.Rows.Item(I).Item("Produto").ToString
                        .Item(I).Item("ValorUnitario") = dtEnt.Rows.Item(I).Item("ValorUnitario").ToString
                        .Item(I).Item("ValorTotal") = dtEnt.Rows.Item(I).Item("ValorTotal").ToString
                        .Item(I).Item("ICMS") = dtEnt.Rows.Item(I).Item("ICMS").ToString
                        .Item(I).Item("IPI") = dtEnt.Rows.Item(I).Item("IPI").ToString
                        .Item(I).Item("Desconto") = dtEnt.Rows.Item(I).Item("Desconto").ToString
                        .Item(I).Item("UnitarioImposto") = dtEnt.Rows.Item(I).Item("UnitarioImposto").ToString
                        .Item(I).Item("Tamanho") = dtEnt.Rows.Item(I).Item("Tamanho").ToString
                        .Item(I).Item("CodConfig") = dtEnt.Rows.Item(I).Item("CodConfig").ToString

                        .Item(I).Item("ValProd") = dtEnt.Rows.Item(I).Item("ValProd").ToString
                        .Item(I).Item("PorProd") = dtEnt.Rows.Item(I).Item("PorProd").ToString
                       
                        .Item(I).Item("CodigoBarra") = dtEnt.Rows.Item(I).Item("CodigoBarra").ToString

                        .Item(I).Item("Grupo") = dtEnt.Rows.Item(I).Item("Grupo").ToString
                        .Item(I).Item("Setor") = dtEnt.Rows.Item(I).Item("Setor").ToString

                        .Item(I).Item("TipoProduto") = dtEnt.Rows.Item(I).Item("TipoProduto").ToString

                        .Item(I).Item("MVaST") = dtEnt.Rows.Item(I).Item("MVaST").ToString

                        .Item(I).Item("IcmsNfe") = dtEnt.Rows.Item(I).Item("PorICMS").ToString

                        If dtEnt.Rows.Item(I).Item("ValorCusto").ToString <> "" Then
                            .Item(I).Item("ValorCusto") = dtEnt.Rows.Item(I).Item("ValorCusto").ToString
                        Else
                            .Item(I).Item("ValorCusto") = dtEnt.Rows.Item(I).Item("ValorUnitario").ToString
                        End If

                        If dtEnt.Rows.Item(I).Item("QtdProd").ToString <> "" Then
                            Dim dblQtdProd As Double = dtEnt.Rows.Item(I).Item("QtdProd").ToString
                            If dblQtdProd > 0 Then
                                .Item(I).Item("QtdProd") = dtEnt.Rows.Item(I).Item("QtdProd").ToString
                            Else
                                .Item(I).Item("QtdProd") = dtEnt.Rows.Item(I).Item("Qtd").ToString
                            End If

                        Else
                            .Item(I).Item("QtdProd") = dtEnt.Rows.Item(I).Item("Qtd").ToString
                        End If


                        .Item(I).Item("RegimeEnt") = dtEnt.Rows.Item(I).Item("Regime").ToString
                        .Item(I).Item("CSTEnt") = dtEnt.Rows.Item(I).Item("CST").ToString
                        .Item(I).Item("OrigemEnt") = dtEnt.Rows.Item(I).Item("Origem").ToString
                        .Item(I).Item("CFOPEnt") = dtEnt.Rows.Item(I).Item("CFOP").ToString
                        .Item(I).Item("NCMEnt") = dtEnt.Rows.Item(I).Item("NCM").ToString
                        .Item(I).Item("ModBCEnt") = dtEnt.Rows.Item(I).Item("ModBC").ToString
                        .Item(I).Item("RedBCEnt") = dtEnt.Rows.Item(I).Item("RedBC").ToString
                        .Item(I).Item("AliquotaICMSEnt") = dtEnt.Rows.Item(I).Item("AliquotaICMS").ToString
                        .Item(I).Item("ValICMSEnt") = dtEnt.Rows.Item(I).Item("ValICMS").ToString
                        .Item(I).Item("ModBCSTEnt") = dtEnt.Rows.Item(I).Item("ModBCST").ToString
                        .Item(I).Item("RedBCSTEnt") = dtEnt.Rows.Item(I).Item("RedBCST").ToString
                        .Item(I).Item("MaVSTEnt") = dtEnt.Rows.Item(I).Item("MVaSTEnt").ToString
                        .Item(I).Item("AliquotaICMSSTEnt") = dtEnt.Rows.Item(I).Item("AliquotaICMSST").ToString
                        .Item(I).Item("ValICMSSTEnt") = dtEnt.Rows.Item(I).Item("ValICMSST").ToString

                        .Item(I).Item("CalculoCredEnt") = dtEnt.Rows.Item(I).Item("CalculoCred").ToString
                        .Item(I).Item("ValCredEnt") = dtEnt.Rows.Item(I).Item("ValCalculoCred").ToString
                        .Item(I).Item("CSTIPIEnt") = dtEnt.Rows.Item(I).Item("CSTIPI").ToString
                        .Item(I).Item("CodEnqEnt") = dtEnt.Rows.Item(I).Item("CodEnq").ToString
                        .Item(I).Item("AliquotaIPIEnt") = dtEnt.Rows.Item(I).Item("AliquotaIPI").ToString
                        .Item(I).Item("ValIPIEnt") = dtEnt.Rows.Item(I).Item("ValIPI").ToString
                        .Item(I).Item("CSTPISEnt") = dtEnt.Rows.Item(I).Item("CSTPIS").ToString
                        .Item(I).Item("AliquotaPISEnt") = dtEnt.Rows.Item(I).Item("AliquotaPIS").ToString
                        .Item(I).Item("ValPISEnt") = dtEnt.Rows.Item(I).Item("ValPIS").ToString
                        .Item(I).Item("CSTCOFINSEnt") = dtEnt.Rows.Item(I).Item("CSTCOFINS").ToString
                        .Item(I).Item("AliquotaCOFINSEnt") = dtEnt.Rows.Item(I).Item("AliquotaCOFINS").ToString
                        .Item(I).Item("ValCOFINSEnt") = dtEnt.Rows.Item(I).Item("ValCOFINS").ToString


                        .Item(I).Item("CodigoANPEnt") = dtEnt.Rows.Item(I).Item("CodigoANPEnt").ToString
                        .Item(I).Item("UFCombEnt") = dtEnt.Rows.Item(I).Item("UFCombEnt").ToString

                        .Item(I).Item("VFCPSTEnt") = dtEnt.Rows.Item(I).Item("VFCPST").ToString
                        .Item(I).Item("FreteEnt") = dtEnt.Rows.Item(I).Item("FreteEnt").ToString
                        .Item(I).Item("DespesasEnt") = dtEnt.Rows.Item(I).Item("DespesasEnt").ToString
                        .Item(I).Item("SeguroEnt") = dtEnt.Rows.Item(I).Item("SeguroEnt").ToString

                    End With

                Next

            End If

            Dim dtConta As DataTable = CarregarDataTable("SELECT Valor, Parcelas, ValorParcela, convert(varchar(10),Vencimento,103) as Vencimento FROM ContaPagar where NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)

            Me.tbContaPagar.Rows.Clear()
            If dtConta.Rows.Count > 0 Then
                For I = 0 To dtConta.Rows.Count - 1
                    Me.tbContaPagar.Rows.Add()
                    Me.tbContaPagar.Rows.Item(I).Item("ValorParcela") = dtConta.Rows.Item(I).Item("ValorParcela").ToString
                    Me.tbContaPagar.Rows.Item(I).Item("ValorConta") = dtConta.Rows.Item(I).Item("Valor").ToString
                    Me.tbContaPagar.Rows.Item(I).Item("Vencimento") = dtConta.Rows.Item(I).Item("Vencimento").ToString
                    Me.tbContaPagar.Rows.Item(I).Item("Parcela") = dtConta.Rows.Item(I).Item("Parcelas").ToString
                Next
                Me.grpConta.Visible = True
            Else
                Me.grpConta.Visible = False
            End If
        Else
            If PesquisarNF(txtNF, intCodFornecedor) = True Then
                Me.txtNF.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub BuscarFornec()
        frmCadFornecedor.Close()
        frmCadFornecedor.Tag = "PESQUISA"
        frmCadFornecedor.ShowDialog()

        'Dim frm As New frmCadFornecedor
        'frm.Tag = "PESQUISA"
        'frm.ShowDialog()
        TrazFornec(CodigoDoFornecedor)

    End Sub

    Private Sub TrazFornec(ByVal parCodFor As Integer)
        Dim dt As DataTable = CarregarDataTable("Select Nome, CPF from Fornecedor where Codigo =" & parCodFor)

        If dt.Rows.Count > 0 Then
            intCodFornecedor = CodigoDoFornecedor
            Me.txtFor.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtCPF.Text = dt.Rows.Item(0).Item("CPF").ToString
        End If
    End Sub

    Private Sub txtFor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFor.KeyDown
        If e.KeyCode = Keys.F10 Then
            BuscarFornec()
            CarregarForm()
        End If
    End Sub

    Private Sub txtCodPro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodPro.KeyDown
        If e.KeyCode = Keys.F10 Then
            frmCadProduto.Close()
            'Dim frm As New frmCadProduto
            frmCadProduto.Tag = "ENTRADANF"
            frmCadProduto.ShowDialog()
            InserirProduto(True)
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.txtCodPro.Text.Trim = "" Then
                'Me.txtNomePro.Focus()
                Exit Sub
            End If
            InserirProduto(False)
        End If

    End Sub

    Private Sub InserirProduto(ByVal PesquisaPorNome As Boolean)

        Dim dtProd As DataTable

        If PesquisaPorNome = False Then
            If Me.txtCodPro.Text.Trim = "" Then Exit Sub
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Porcentagens, CodigoBarra, Grupo, Setor, Tipo, CodProdFor, Inativo from Produto where CodigoInterno ='" & Me.txtCodPro.Text.Trim & "' or CodigoBarra ='" & Me.txtCodPro.Text.Trim & "'")
            If dtProd.Rows.Count = 0 Then
                Dim dtCodBarra As DataTable = CarregarDataTable("SELECT CodProd FROM CodigoBarra where CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto = '' or CodigoBarra = '" & Me.txtCodPro.Text & "' and Produto is null")
                If dtCodBarra.Rows.Count > 0 Then
                    CodigoDoProduto = dtCodBarra.Rows.Item(0).Item("CodProd").ToString
                    dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, Porcentagens, CodigoBarra, Grupo, Setor, Tipo, CodProdFor, Inativo from Produto where Codigo=" & CodigoDoProduto)
                End If
            End If
            If dtProd.Rows.Count > 0 Then
                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    Exit Sub
                End If
            End If
        Else
            dtProd = CarregarDataTable("Select Codigo, Nome, UnidadeMedida, ValorCusto, Valor, CodigoInterno, Porcentagens, CodigoBarra, Grupo, Setor, Tipo, CodProdFor, Inativo from Produto where Codigo=" & CodigoDoProduto)
            If dtProd.Rows.Count > 0 Then

                If dtProd.Rows.Item(0).Item("Inativo") = True Then
                    MsgBox("Produto Inativo!", MsgBoxStyle.Information)
                    Me.txtCodPro.ResetText()
                    Exit Sub
                End If

                If NomeEmpresa.Replace("Ã", "A").Trim.Contains("CAVALAO") = True Then
                    If dtProd.Rows.Item(0).Item("CodigoBarra").ToString <> "" Then
                        Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoBarra")
                    Else
                        Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
                    End If
                Else
                    Me.txtCodPro.Text = dtProd.Rows.Item(0).Item("CodigoInterno")
                End If
            End If
        End If

        If dtProd.Rows.Count > 0 Then

            With dtProd.Rows.Item(0)
                Dim intCodProdAut As Integer

                intCodProdAut = .Item(0).ToString


                Me.txtCodPro.Tag = intCodProdAut
                Me.txtNomePro.Text = .Item(1).ToString
                strUM = .Item(2).ToString
                Dim dblCusto As Double
                If .Item("ValorCusto").ToString <> "" Then
                    dblCusto = .Item("ValorCusto").ToString
                End If
                Dim dblValor As Double
                If .Item("Valor").ToString <> "" Then
                    dblValor = .Item("Valor").ToString
                    

                End If
               
                Dim dblPorProd As Double
                If .Item("Porcentagens").ToString <> "" Then
                    dblPorProd = .Item("Porcentagens").ToString

                    If ManterMargemProd = True Then
                        dblCusto = dtProd.Rows.Item(0).Item("ValorCusto").ToString
                        Dim dblResul As Double = (dblCusto * dblPorProd) / 100
                        dblValor = dblCusto + dblResul
                    End If
                End If


                If TresCasasDecimais = True Then

                    Me.txtValor.Text = dblCusto.ToString("0.000")
                    If bolAlterado = False Then
                        'If Me.chkImpostoItens.Checked = False Then
                        Me.txtValorCusto.Text = dblCusto.ToString("0.000")
                        'End If

                    End If
                    Me.txtValor.Tag = dblCusto.ToString("0.000")
                    Me.txtVal.Text = CampoValor(dblValor)
                    Me.txtPor1.Text = dblPorProd.ToString("0.000")
                Else
                    Me.txtValor.Text = dblCusto.ToString("0.00")
                    If bolAlterado = False Then
                        ' If Me.chkImpostoItens.Checked = False Then
                        Me.txtValorCusto.Text = dblCusto.ToString("0.00")
                        'End If

                End If
                Me.txtValor.Tag = dblCusto.ToString("0.00")
                Me.txtVal.Text = CampoValor(dblValor)
                Me.txtPor1.Text = dblPorProd.ToString("0.00")
                End If



        'CalcularIPI()
        Me.cboUniMed.Text = .Item(2).ToString
        strCodigoBarra = .Item("CodigoBarra").ToString
        Me.txtCodBarra.Text = .Item("CodigoBarra").ToString
        Me.cboGrp.Text = .Item("Grupo").ToString
        Me.cboSet.Text = .Item("Setor").ToString

        Me.cboTipoProduto.Text = .Item("Tipo").ToString
        Me.txtCodProdFor.Text = .Item("CodProdFor").ToString
        'Me.txtCodBarra.Enabled = False
        bolSalvo = False
        If EmiteNFE = True Or SATFiscal = True Then
            Dim dtRegime As DataTable = CarregarDataTable("SELECT Regime FROM Nfe where CodProd = " & intCodProdAut & " and Regime like '%" & RegimeSAT & "%' order by Regime")

            Dim strTipoFiscal As String = ""
            If dtRegime.Rows.Count > 0 Then
                Dim strRegimeNFeSat As String = dtRegime.Rows.Item(0).Item("Regime").ToString
                If strRegimeNFeSat.Contains("SAT") Or strRegimeNFeSat.Contains("NFE") Then
                    strTipoFiscal = " NFE"
                End If
            End If

            Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
            "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
            "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb FROM Nfe where CodProd = " & intCodProdAut & " and Regime = '" & RegimeSAT & strTipoFiscal & "'")

            If dtNfe.Rows.Count > 0 Then
                strEXTIPIGeral = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                strGeneroGeral = dtNfe.Rows.Item(0).Item("Genero").ToString
                strNCMGeral = dtNfe.Rows.Item(0).Item("NCM").ToString
                strRegimeNfeGeral = dtNfe.Rows.Item(0).Item("Regime").ToString
                strCstNfeGeral = dtNfe.Rows.Item(0).Item("CST").ToString
                strOrigemNfeGeral = dtNfe.Rows.Item(0).Item("Origem").ToString
                strModBCNfeGeral = dtNfe.Rows.Item(0).Item("ModBC").ToString
                strIcmsNfeGeral = dtNfe.Rows.Item(0).Item("ICMS").ToString
                strRedBCNfeGeral = dtNfe.Rows.Item(0).Item("RedBC").ToString
                strModBCSTNfeGeral = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                strRedBCSTNfeGeral = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                strMVaSTNfeGeral = dtNfe.Rows.Item(0).Item("MVaST").ToString
                strIcmsSTNfeGeral = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                strCalcCredNfeGeral = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
                strCFOPGeral = dtNfe.Rows.Item(0).Item("CFOP").ToString
                strCodigoANPGeral = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                strUFCombGeral = dtNfe.Rows.Item(0).Item("UFComb").ToString
            End If

            Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS FROM Tributos where CodProd = " & intCodProdAut & " and Regime = '" & RegimeSAT & strTipoFiscal & "'")

            If dtTrib.Rows.Count > 0 Then
                strCSTIPIGeral = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                strCSPPISGeral = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                strCSTCOFINSGeral = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                strCodEnqGeral = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                strPerIPIGeral = dtTrib.Rows.Item(0).Item("PerIPI").ToString
                strPerPISGeral = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                strPerCOFINSGeral = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
            End If
        End If

            End With
        Else
            Me.cboTipoProduto.Text = "VENDA"
            Me.txtNomePro.ResetText()
            Me.txtCodPro.ResetText()
            Me.txtQtd.ResetText()
            strUM = ""
            strCodigoBarra = ""
            Me.txtValor.ResetText()
            Exit Sub
        End If

        CarregarDadosLue("Select TOP 5 Fornecedor.Nome as Nome, ValorUnitario, EntradaNF.Data from EntradaNF inner join Fornecedor on EntradaNF.CodFor = Fornecedor.Codigo where CodProd =" & Me.txtCodPro.Tag & " order by EntradaNF.Data DESC", Me.lueHis)
    End Sub

    Private Sub txtQtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.Enter
        Select Case strUM
            Case "UN", "JG", "KIT"
                Me.txtQtd.CasasDecimais = 0
            Case "KG", "LT"
                Me.txtQtd.CasasDecimais = 3
            Case "MT"
                Me.txtQtd.CasasDecimais = 2
            Case Else
                Me.txtQtd.CasasDecimais = 3
        End Select
    End Sub

    Private Sub txtNF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNF.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFor_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtFor.ButtonClick
        BuscarFornec()
        CarregarForm()
    End Sub

    Private Sub txtFor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFor.Enter
        If Validar(Me.txtNF) = False Then Exit Sub
    End Sub

    Private Sub chkTamanho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTamanho.CheckedChanged
        Select Case Me.chkTamanho.Checked
            Case True
                Tamanho(True)
            Case False
                Tamanho(False)
        End Select
    End Sub
    Private Sub Tamanho(ByVal chk As Boolean)
        Me.chkTamanho.Checked = chk
        Select Case Me.chkTamanho.Checked
            Case True
                Me.txtTam.Enabled = False
                Me.txtTam.Text = "U"
                Me.txtValor.Focus()
            Case False
                Me.txtTam.Enabled = True
                Me.txtTam.Text = ""
                Me.txtTam.Focus()
        End Select
    End Sub

    Private Sub lueLoja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLoja.TextChanged
        If Me.lueLoja.EditValue.ToString <> "" Then
            intCodConfig = Me.lueLoja.EditValue
        End If
    End Sub

    Private Sub btnEtiq_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiq.ItemClick
        SelecaoEtiqueta()
    End Sub


 

    Private Sub txtIPI_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIPI.Leave
        'If Preco(Me.txtIPI) = False Then Exit Sub
        'If Me.txtIPI.Text.Trim <> "" And Me.txtIPI.Text.Trim <> "0,00" Then
        '    If Me.txtIPI.Tag.ToString.Trim <> Me.txtIPI.Text.Trim Then
        '        CalcularIPI()
        '        Me.txtIPI.Tag = Me.txtIPI.Text.Trim
        '    End If
        'End If
        Preco(Me.txtIPI)
        Calcular()
    End Sub

    Private Sub txtICMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtICMS.Leave
        'If Preco(Me.txtICMS) = False Then Exit Sub
        'If Me.txtICMS.Text.Trim <> "" And Me.txtICMS.Text.Trim <> "0,00" Then
        '    If Me.txtICMS.Tag.ToString.Trim <> Me.txtICMS.Text.Trim Then
        '        CalcularIPI()
        '        Me.txtICMS.Tag = Me.txtICMS.Text.Trim
        '    End If
        'End If
        Preco(Me.txtICMS)
        Calcular()
    End Sub

    Private Sub txtVal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVal.Leave
        If Me.txtVal.Text.Trim = "" Then
            Me.txtPor1.Focus()
            Exit Sub
        End If

        If Me.txtValorCusto.Text.Trim = "" Then Exit Sub
        If Preco(Me.txtVal) = False Then Exit Sub

        Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

        dblValVenda = Me.txtVal.Text.Trim
        If Me.txtValorCusto.Text = "" Then
            dblValCusto = Me.txtValor.Text.Trim
        Else
            dblValCusto = Me.txtValorCusto.Text.Trim
        End If
       
        dblLucro = dblValVenda - dblValCusto

        dblMargem = (dblLucro * 100) / dblValCusto
        Dim str As String = dblMargem

        If str <> "+Infinito" Then
            If TresCasasDecimais = True Then
                Me.txtPor1.Text = dblMargem.ToString("0.000")
            Else
                Me.txtPor1.Text = dblMargem.ToString("0.00")
            End If

        End If
    End Sub

    Private Sub txtPor1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPor1.Leave
        If Me.txtValor.Text.Trim = "" Then Exit Sub
        If Me.txtPor1.Text.Trim = "" Then
            Me.txtPerDesc.Focus()
            Exit Sub
        End If


        Dim dblValCus, dblResul As Double
        Dim dblPor As Double = txtPor1.Text
        If Me.txtValorCusto.Text = "" Then
            dblValCus = Me.txtValor.Text

        Else
            dblValCus = Me.txtValorCusto.Text

        End If

     
        dblResul = (dblValCus * dblPor) / 100

        dblResul = dblValCus + dblResul

        Me.txtVal.Text = CampoValor(dblResul)


        Me.txtPerDesc.Focus()
    End Sub

    Private Sub btnNfe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNfe.ItemClick
        If Me.grd1.RowCount > 0 Then
            If MsgBox("Deseja realmente abrir um arquivo XML?" & vbCrLf & "Se você fizer isso irá remover todos os produtos da tela!", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Limpar()

                ofdArquivo.FileName = ""
                ofdArquivo.Filter = "Xml files (*.xml)|*.xml"
                ofdArquivo.ShowDialog()
                If ofdArquivo.FileName <> "" Then
                    vetParcela = Nothing
                    If NfeXml(ofdArquivo.FileName) = True Then
                        Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "' or Nome = '" & Me.txtFor.Text.Trim.Replace("'", "´") & "'")
                        If dtFor.Rows.Count > 0 Then
                            CodigoDoFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                            intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                        End If
                        Calcular()
                        If Me.txtValDesc.Text <> "" Then
                            'Me.txtValDesc.Focus()
                            Me.txtValDesc_Leave(sender, e)
                            Me.chkDescontoItens.Enabled = True
                            Me.chkDescontoItens.Visible = True
                        End If
                        If Me.grd1.RowCount > 0 Then
                            Me.picFundo.Visible = False
                        End If

                        If vetParcela Is Nothing Then
                            Me.grpConta.Visible = False
                            Exit Sub
                        End If
                        Me.tbContaPagar.Rows.Clear()

                        Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ContaPagar where NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
                        If dt.Rows.Count = 0 Then
                            Dim I As Integer
                            For I = 0 To vetParcela.Length - 1

                                Dim vetPar As Array = Split(vetParcela(I), "-")

                                Dim strValParcela As String = vetPar(0)
                                Dim strVenc As String = vetPar(1)
                                If I = 0 Then
                                    Me.dtVenc.EditValue = strVenc
                                    Me.seParcela.Text = vetParcela.Length
                                End If
                                Me.tbContaPagar.Rows.Add()
                                Me.tbContaPagar.Rows.Item(I).Item("ValorParcela") = strValParcela
                                Me.tbContaPagar.Rows.Item(I).Item("ValorConta") = Me.txtValNota.Text
                                Me.tbContaPagar.Rows.Item(I).Item("Vencimento") = strVenc
                                Me.tbContaPagar.Rows.Item(I).Item("Parcela") = I + 1
                            Next

                            Me.grpConta.Visible = True
                        Else
                            Me.grpConta.Visible = False
                        End If
                    Else
                        MsgBox("Arquivo XML com erro!", MsgBoxStyle.Information)
                    End If
                End If
            End If

        Else
            Limpar()

            ofdArquivo.FileName = ""
            ofdArquivo.Filter = "Xml files (*.xml)|*.xml"
            ofdArquivo.ShowDialog()
            If ofdArquivo.FileName <> "" Then
                vetParcela = Nothing
                If NfeXml(ofdArquivo.FileName) = True Then
                    Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "' or Nome = '" & Me.txtFor.Text.Trim & "'")
                    If dtFor.Rows.Count > 0 Then
                        CodigoDoFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                        intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                    End If
                    Calcular()
                    If Me.txtValDesc.Text <> "" Then
                        'Me.txtValDesc.Focus()
                        Me.txtValDesc_Leave(sender, e)
                        Me.chkDescontoItens.Enabled = True
                        Me.chkDescontoItens.Visible = True
                    End If
                    If Me.grd1.RowCount > 0 Then
                        Me.picFundo.Visible = False
                    End If

                    If vetParcela Is Nothing Then
                        Me.grpConta.Visible = False
                        Exit Sub
                    End If
                    Me.tbContaPagar.Rows.Clear()

                    Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ContaPagar where NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
                    If dt.Rows.Count = 0 Then
                        Dim I As Integer
                        For I = 0 To vetParcela.Length - 1

                            Dim vetPar As Array = Split(vetParcela(I), "-")

                            Dim strValParcela As String = vetPar(0)
                            Dim strVenc As String = vetPar(1)
                            If I = 0 Then
                                Me.dtVenc.EditValue = strVenc
                                Me.seParcela.Text = vetParcela.Length
                            End If
                            Me.tbContaPagar.Rows.Add()
                            Me.tbContaPagar.Rows.Item(I).Item("ValorParcela") = strValParcela
                            Me.tbContaPagar.Rows.Item(I).Item("ValorConta") = Me.txtValNota.Text
                            Me.tbContaPagar.Rows.Item(I).Item("Vencimento") = strVenc
                            Me.tbContaPagar.Rows.Item(I).Item("Parcela") = I + 1
                        Next

                        Me.grpConta.Visible = True
                    Else
                        Me.grpConta.Visible = False
                    End If
                Else
                    MsgBox("Arquivo XML com erro!", MsgBoxStyle.Information)
                End If
            End If
        End If

        'Dim dtNF As DataTable = NotaNfeXml(ofdArquivo.FileName)

        'Me.txtNF.Text = dtNF.Rows.Item(0).Item("nNF").ToString
        'Dim vet As Array = Split(dtNF.Rows.Item(0).Item("dEmi").ToString, " ")
        'Me.dtData.Text = vet(0)
        'Me.txtSerie.Text = dtNF.Rows.Item(0).Item("serie").ToString
        'Me.cboTipo.Text = "F"


        'dtNF = FornecedorNfeXml(ofdArquivo.FileName)

        'Me.txtFor.Text = dtNF.Rows.Item(0).Item("xNome").ToString
        'Me.txtCPF.Text = AddPonto(dtNF.Rows.Item(0).Item("CNPJ").ToString, "J")

        'Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "'")
        'If dt.Rows.Count = 0 Then
        '    Dim strEndereco As String = dtNF.Rows.Item(0).Item("xLgr").ToString
        '    Dim strNumero As String = dtNF.Rows.Item(0).Item("nro").ToString
        '    Dim strBairro As String = dtNF.Rows.Item(0).Item("xBairro").ToString
        '    Dim strCidade As String = dtNF.Rows.Item(0).Item("xMun").ToString
        '    Dim strEstado As String = dtNF.Rows.Item(0).Item("UF").ToString
        '    Dim strCep As String = AddPonto(dtNF.Rows.Item(0).Item("CEP").ToString, "CEP")
        '    Dim strTelefone As String = AddPonto(dtNF.Rows.Item(0).Item("fone").ToString, "TEL")
        '    Dim strIE As String = dtNF.Rows.Item(0).Item("IE").ToString
        '    Dim strFantasia As String = dtNF.Rows.Item(0).Item("xFant").ToString
        '    Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, IE, Fantasia, Data) VALUES ('" & Me.txtFor.Text.Trim & "','" & Me.txtCPF.Text.Trim & "','" & strEndereco & "','" & strNumero & "','" & strBairro & "','" & strCidade & "','" & strEstado & "','" & strCep & "','" & strTelefone & "','" & strIE & "','" & strFantasia & "','" & Date.Today & "')")
        '    intCodFornecedor = GerarCodigo("Fornecedor", "Codigo", 0) - 1
        'Else
        '    intCodFornecedor = dt.Rows.Item(0).Item("Codigo").ToString
        'End If


        'dtNF = ProdutoNfeXml(ofdArquivo.FileName)

        'Me.tbEntrada.Rows.Clear()
        'With Me.tbEntrada.Rows
        '    Dim I As Integer
        '    For I = 0 To dtNF.Rows.Count - 1
        '        Dim dtProd As DataTable = CarregarDataTable("SELECT Codigo FROM Produto where CodigoInterno = '" & dtNF.Rows.Item(I).Item("cProd").ToString & "'")
        '        Dim strCodProd As String
        '        If dtProd.Rows.Count > 0 Then
        '            strCodProd = dtProd.Rows.Item(0).Item("Codigo").ToString
        '            .Add()
        '            Dim Index As Integer = .Count - 1
        '            .Item(Index).Item("Codigo") = "Inserir"
        '            .Item(Index).Item("CodProd") = strCodProd
        '            .Item(Index).Item("CodProdInterno") = dtNF.Rows.Item(I).Item("cProd").ToString
        '            .Item(Index).Item("Qtd") = dtNF.Rows.Item(I).Item("qCom").ToString
        '            .Item(Index).Item("Tamanho") = "U"
        '            .Item(Index).Item("Produto") = dtNF.Rows.Item(I).Item("xProd").ToString
        '            .Item(Index).Item("ValorUnitario") = dtNF.Rows.Item(I).Item("vUnCom").ToString
        '            .Item(Index).Item("ValorTotal") = dtNF.Rows.Item(I).Item("vProd").ToString
        '            .Item(Index).Item("ICMS") = "0"
        '            .Item(Index).Item("IPI") = "0"
        '            .Item(Index).Item("Desconto") = "0"
        '            .Item(Index).Item("UnitarioImposto") = dtNF.Rows.Item(I).Item("vUnCom").ToString
        '            .Item(Index).Item("CodConfig") = intCodConfig
        '        End If
        '    Next
        'End With

        'dtNF = TotalNfeXml(ofdArquivo.FileName)

        'Me.txtValNota.Text = dtNF.Rows.Item(0).Item("vNF").ToString
        'Me.txtValDesc.Text = dtNF.Rows.Item(0).Item("vDesc").ToString
        'Me.txFrete.Text = dtNF.Rows.Item(0).Item("vFrete").ToString
        'Me.txtSeguro.Text = dtNF.Rows.Item(0).Item("vSeg").ToString
        'Me.txtDespesas.Text = dtNF.Rows.Item(0).Item("vOutro").ToString
        'Me.txtIPI.Text = dtNF.Rows.Item(0).Item("vIPI").ToString
        'Me.txtICMS.Text = dtNF.Rows.Item(0).Item("vST").ToString

    End Sub

    Private Sub btnCadSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadSet.Click
        Dim frm As New frmGrupo
        frm.Tag = "SETOR"
        frm.ShowDialog()
        Me.cboSet.Properties.Items.Clear()
        PreencherGrupoSetorCusto("S", Me.cboSet)
        Me.cboSet.Focus()
    End Sub

    Private Sub btnCadGrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadGrp.Click
        Dim frm As New frmGrupo
        frm.Tag = "GRUPO"
        frm.ShowDialog()
        Me.cboGrp.Properties.Items.Clear()
        PreencherGrupoSetorCusto("G", Me.cboGrp)
        Me.cboGrp.Focus()
    End Sub

    Private Sub btnAddValor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddValor.ItemClick
        If Me.txtValVendaPorc.EditValue = Nothing Then Exit Sub
        If MsgBox("Deseja realmente inserir essa margem de lucro para todos os produtos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If Me.txtDesconto.Text <> "" Then
                Dim dblDesc As Double = Me.txtDesconto.Text
                If dblDesc > 0 Then
                    If MsgBox("Deseja aplicar o desconto nos itens?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        DescontoItens()
                    End If
                End If

            End If

            Dim dblPor As Double = Me.txtValVendaPorc.EditValue
            Dim I As Integer
            For I = 0 To Me.grd1.RowCount - 1
                Dim dblCusto As Double = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)
                If Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto) <> "" Then
                    dblCusto = Me.grd1.GetRowCellDisplayText(I, Me.colValorCusto)
                End If
                Dim dblResul As Double
                dblResul = (dblCusto * dblPor) / 100

                dblResul = dblCusto + dblResul

                Me.grd1.SetRowCellValue(I, Me.colValProd, dblResul.ToString("0.00"))
                Me.grd1.SetRowCellValue(I, Me.colPorProd, dblPor.ToString("0.00"))
            Next
        End If
    End Sub

    Private Sub txtValVendaPor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValVendaPor.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack And e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValVendaPor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValVendaPor.Leave
        If Me.txtValVendaPorc.EditValue = Nothing Then Exit Sub
        Try
            Dim dblVal As Double = Me.txtValVendaPorc.EditValue.ToString.Replace(".", ",")
            Me.txtValVendaPorc.EditValue = dblVal.ToString("0.00")
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            Me.txtValVendaPorc.EditValue = Nothing
        End Try
    End Sub
    Private Sub CalcularIPI()
        If Me.txtValor.Text.Trim = "" Then Exit Sub
        If Preco(Me.txtValor) = False Then Exit Sub



        '''''''IPI

        Dim dblValor, dblResulIPI, dblResul As Double
        Dim dblPor As Double
        If Me.txtIPIItem.Text <> "" Then
            dblPor = Me.txtIPIItem.Text
        Else
            dblPor = "0,00"
        End If
        dblValor = Me.txtValor.Tag

        dblResulIPI = (dblValor * dblPor) / 100



        ''''''IPIST
        If Me.txtICMSItem.Text <> "" Then
            dblPor = Me.txtICMSItem.Text
        Else
            dblPor = "0,00"
        End If


        dblValor = Me.txtValor.Tag

        'dblResulICMS = (dblValor * dblPor) / 100

        'dblResul = dblResulIPI + dblResulICMS

        'dblValor = dblValor + dblResul
        Dim vICMSST As Double = 0
        If dblPor > 0 Then
            Dim vICMS As Double
            Dim pICMS As Double
            If Me.txtPorICMS.Text <> "" Then
                pICMS = Me.txtPorICMS.Text
            Else
                pICMS = "0,00"
            End If
            vICMS = (dblValor * pICMS) / 100
            Dim vBCST As Double
            Dim mvaST As Double
            If Me.txtMVaST.Text <> "" Then
                mvaST = Me.txtMVaST.Text
            Else
                mvaST = "0,00"
            End If
            vBCST = (dblValor + dblResulIPI) + (((dblValor + dblResulIPI) * mvaST) / 100)



            vICMSST = ((vBCST * dblPor) / 100) - vICMS



        End If


        dblResul = dblResulIPI + vICMSST

        dblValor = dblValor + dblResul



        '''''Porcentagem

        'If Me.chkImpostoItens.Checked = False Then
        '    Dim dblValVenda, dblValCusto, dblLucro, dblMargem As Double

        '    If ManterPorcProd = False Then
        '        If Me.txtVal.Text.Trim <> "" Then
        '            dblValVenda = Me.txtVal.Text.Trim
        '            dblValCusto = dblValor

        '            dblLucro = dblValVenda - dblValCusto

        '            dblMargem = (dblLucro * 100) / dblValCusto
        '            Dim str As String = dblMargem

        '            If str <> "+Infinito" Then
        '                Me.txtPor1.Text = dblMargem.ToString("0.00")
        '            End If
        '        End If
        '    Else
        '        If Me.txtPor1.Text <> "" Then
        '            dblValCusto = dblValor
        '            Dim dblVal As Double = dblValCusto + ((dblValCusto * CDbl(Me.txtPor1.Text)) / 100)
        '            Me.txtVal.Text = dblVal.ToString("0.000")
        '        End If
        '    End If


        'End If
       

        Me.txtValor.Text = CampoValor(dblValor)

    End Sub

    Private Sub txtIPIItem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIPIItem.Leave
        Preco(Me.txtIPIItem)
        'If Me.txtIPIItem.Text.Trim <> "" And Me.txtIPIItem.Text.Trim <> "0,00" Then
        If Me.txtIPIItem.Tag.ToString.Trim <> Me.txtIPIItem.Text.Trim Then
            CalcularIPI()
            Me.txtIPIItem.Tag = Me.txtIPIItem.Text.Trim
        End If
        'End If
        Calcular()
        Me.txtMVaST.Focus()
    End Sub

    Private Sub txtICMSItem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtICMSItem.Leave
        Preco(Me.txtICMSItem)
        'If Me.txtICMSItem.Text.Trim <> "" And Me.txtICMSItem.Text.Trim <> "0,00" Then
        If Me.txtICMSItem.Tag.ToString.Trim <> Me.txtICMSItem.Text.Trim Then
            CalcularIPI()
            Me.txtICMSItem.Tag = Me.txtICMSItem.Text.Trim
        End If
        'End If
        Calcular()
    End Sub


    Private Sub txtMVaST_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMVaST.Leave
        Preco(Me.txtMVaST)
        If Me.txtMVaST.Tag.ToString.Trim <> Me.txtMVaST.Text.Trim Then
            CalcularIPI()
            Me.txtMVaST.Tag = Me.txtMVaST.Text.Trim
        End If
    End Sub

    Private Sub txtPorICMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorICMS.Leave
        Preco(Me.txtPorICMS)
        If Me.txtPorICMS.Tag.ToString.Trim <> Me.txtPorICMS.Text.Trim Then
            CalcularIPI()
            Me.txtPorICMS.Tag = Me.txtPorICMS.Text.Trim
        End If
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress, txtNomePro.KeyPress, txtCodPro.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "&" Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtCodBarra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBarra.Leave
        If Me.txtCodBarra.Text.Trim = "" Then Exit Sub
        If Me.txtCodBarra.Text = strCodigoBarra Then Exit Sub
        PesquisarProduto(txtCodBarra, "CodigoInterno")
        PesquisarProduto(txtCodBarra, "CodigoBarra")
    End Sub

    Private Sub txtNomePro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomePro.Leave
        If Me.txtNomePro.Text <> "" Then
            If Me.txtCodPro.Text = "" Then
                Me.txtCodBarra.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkDescontoItens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDescontoItens.CheckedChanged
        If Me.chkDescontoItens.Checked = True Then
            DescontoItens()
        End If
    End Sub

    Private Sub DescontoItens()
        If Me.txtDesconto.Text = "" Then Exit Sub

        Dim dblDesconto As Double = Me.txtDesconto.Text

        If dblDesconto <= 0 Then Exit Sub

        Dim dblTotal, dblValUni, dblQtd, dblPercent, dblCusto, dblResto, dblResul, dblTotSemDesc, dblItens, dblSomaDifDesc As Double

        Dim I As Integer
        For I = 0 To grd1.RowCount - 1
            dblQtd = Me.grd1.GetRowCellDisplayText(I, Me.colQtd)
            dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)

            dblItens += dblQtd

            If dblValUni > 0 Then

                dblValUni = Me.grd1.GetRowCellDisplayText(I, Me.colValorUnitario)

                dblPercent = dblDesconto

                dblResto = (dblValUni / 100) * dblPercent

                dblValUni = dblValUni - dblResto


                dblSomaDifDesc += CampoValor(dblValUni) * dblQtd

                If CasaDecimal = "2" Or CasaDecimal = "3" Then
                    If I = grd1.RowCount - 1 Then

                        If dblQtd = 1 Then
                            If Me.txtValDesc.Text <> "0,00" And Me.txtValDesc.Text.Trim <> "" Then
                                Dim strDifer As String

                                strDifer = (Me.txtDesconto.Tag - CDbl(dblSomaDifDesc).ToString("0.00")).ToString("0.00")

                                If strDifer <> Me.txtValDesc.Text Then
                                    Dim dblDifer As Double

                                    dblDifer = (CDbl(Me.txtValDesc.Text) - CDbl(strDifer)).ToString("0.00")

                                    dblValUni = dblValUni - dblDifer

                                End If

                            End If
                        End If
                    End If
                End If
   


                Me.grd1.SetRowCellValue(I, Me.colValorUnitario, CampoValor(dblValUni))
            End If

            dblResul = CampoValor(dblValUni) * dblQtd

            Me.grd1.SetRowCellValue(I, Me.colValorTotal, dblResul.ToString("0.00"))


            dblTotal += dblResul.ToString("0.00")


            'dblTotSemDesc += CDbl(Me.grd1.GetRowCellDisplayText(I, Me.colValorSemDesconto)) * dblQtd

        Next

        Me.chkDescontoItens.Enabled = False
        Me.txtDesconto.Text = ""
        Me.txtValDesc.Text = ""
    End Sub

    Private Sub btnEditarNfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarNfe.Click


        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If bolAlterado = True Then
            MsgBox("Exite um item sendo alterado, conclua a alteração antes de editar tributos nf-e!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim frm As New frmDetProduto
        frm.Tag = "ENTRADANF"
        frm.intIndex = Me.grd1.FocusedRowHandle
        frm.txtCodProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProdInterno)
        frm.txtProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        frm.lueCFOP.EditValue = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCFOP)
        frm.txtEXTIPI.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colEXTIPI)
        frm.txtNfeNCM.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNCM)

        If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNCM) = "" Then
            frm.txtNfeNCM.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNCMEnt)
        End If
        Dim strRegimeNfe As Integer = 1
        If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRegime) = "TRIBUTAÇÃO NORMAL" Then
            strRegimeNfe = 3
        End If

        frm.Regime(strRegimeNfe)
        If strRegimeNfe = "3" Then
            frm.cboRegime.SelectedIndex = 0
        Else
            frm.cboRegime.SelectedIndex = 1
        End If

        SelecionarCombo(frm.cboNfeCST, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCST))

        SelecionarCombo(frm.cboOrigem, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colOrigem))
        SelecionarCombo(frm.cboModBC, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colModBC))
        frm.txtNfeICMS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colICMS)
        frm.txtRedBC.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRedBC)
        SelecionarCombo(frm.cboModBCST, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colModBCST))
        frm.txtRedBCST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRedBCST)
        frm.txtMVAST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colMVaST)
        frm.txtICMSST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colIcmsST)
        frm.txtCalcCred.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCalculoCred)


        SelecionarCombo(frm.cboCSTIPI, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTIPI))
        frm.txtCodEnq.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodEnq)
        frm.txtAliquotaIPI.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPerIPI)

        SelecionarCombo(frm.cboCSTPIS, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTPIS))
        frm.txtAliquotaPIS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPerPIS)

        SelecionarCombo(frm.cboCSTCOFINS, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTCOFINS))
        frm.txtAliquotaCOFINS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colPerCOFINS)
        frm.cboCodigoANP.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoANP)

        frm.cboUF.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colUFComb)
        frm.txtCest.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCest)
        frm.ShowDialog()
    End Sub
    Private Sub SelecionarCombo(ByVal parCombo As Object, ByVal parTexto As String)
        Dim I As Integer
        Dim index As Integer
        Dim strCombo As String
        If parTexto <> "" Then
            For I = 0 To parCombo.Properties.Items.Count - 1
                strCombo = parCombo.Properties.Items.Item(I).ToString
                If strCombo <> "" Then
                    strCombo = strCombo.Substring(0, 3)
                    If strCombo.Contains(parTexto) Then
                        index = I
                    End If
                End If
            Next
        Else
            index = -1
        End If

        parCombo.SelectedIndex = index
    End Sub

    Private Sub ConsultaEntrada()
        RetornaEntradaNF = ""
        frmConPed.Tag = "ENTRADANF" & Me.Tag
        frmConPed.ShowDialog()

        If RetornaEntradaNF <> "" Then

            Dim vetEntrada As Array = Split(RetornaEntradaNF, "|")
            If vetEntrada.Length > 1 Then
                Me.txtNF.Text = vetEntrada(0)
                If vetEntrada(1).ToString <> "" Then
                    intCodFornecedor = vetEntrada(1)
                    Dim dt As DataTable = CarregarDataTable("SELECT Nome, CPF FROM Fornecedor where Codigo = " & intCodFornecedor)
                    If dt.Rows.Count > 0 Then
                        Me.txtFor.Text = dt.Rows.Item(0).Item("Nome").ToString
                        Me.txtCPF.Text = dt.Rows.Item(0).Item("CPF").ToString
                    Else
                        Me.txtFor.ResetText()
                        Me.txtCPF.ResetText()
                    End If
                    CarregarForm()

                Else
                    Me.txtNF.ResetText()
                    Me.txtFor.ResetText()
                    Me.txtCPF.ResetText()
                    Me.txtNF.Focus()
                End If
                
            End If
        Else
            Me.txtNF.ResetText()
            Me.txtFor.ResetText()
            Me.txtCPF.ResetText()
            Me.txtNF.Focus()
        End If
    End Sub

    Private Sub btnConsultar_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnConsultar.ButtonClick
        ConsultaEntrada()
    End Sub


    Private Sub btnEditarNFeEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarNFeEntrada.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If bolAlterado = True Then
            MsgBox("Exite um item sendo alterado, conclua a alteração antes de editar tributos nf-e!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim frm As New frmDetProduto
        frm.Tag = "ENTRADANFEnt"
        frm.intIndex = Me.grd1.FocusedRowHandle
        frm.txtCodProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProdInterno)
        frm.txtProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)

        frm.lueCFOP.EditValue = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCFOPEnt)
        frm.txtNfeNCM.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colNCMEnt)
        Dim strRegimeNfe As Integer = 1

        If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTEnt) <> "" Then
            If Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTEnt).Length = 2 Then
                strRegimeNfe = 3
            End If
        End If
      
        frm.Regime(strRegimeNfe)
        If strRegimeNfe = "3" Then
            frm.cboRegime.SelectedIndex = 0
        Else
            frm.cboRegime.SelectedIndex = 1
        End If
        SelecionarCombo(frm.cboNfeCST, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTEnt))
        SelecionarCombo(frm.cboOrigem, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colOrigemEnt))
        SelecionarCombo(frm.cboModBC, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colModBCEnt))
        frm.txtNfeICMS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAliquotaICMSEnt)
        frm.txtRedBC.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRedBCEnt)
        SelecionarCombo(frm.cboModBCST, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colModBCSTEnt))
        frm.txtRedBCST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colRedBCSTEnt)
        frm.txtMVAST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colMVaSTEnt)
        frm.txtICMSST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAliquotaICMSSTEnt)
        frm.txtCalcCred.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCalculoCredEnt)
        SelecionarCombo(frm.cboCSTIPI, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTIPIEnt))
        frm.txtCodEnq.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodEnqEnt)
        frm.txtAliquotaIPI.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAliquotaIPIEnt)
        SelecionarCombo(frm.cboCSTPIS, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTPISEnt))
        frm.txtAliquotaPIS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAliquotaPISEnt)
        SelecionarCombo(frm.cboCSTCOFINS, Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCSTCOFINSEnt))
        frm.txtAliquotaCOFINS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colAliquotaCOFINSEnt)
        frm.cboCodigoANP.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigoANPEnt)
        frm.cboUF.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colUFCombEnt)

        frm.txtValICMS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValICMSEnt)
        frm.txtValICMSST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValICMSSTEnt)
        frm.txtValIPI.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValIPIEnt)
        frm.txtValPIS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValPISEnt)
        frm.txtValCOFINS.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValCOFINSEnt)
        frm.txtValCred.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValCredEnt)
        frm.txtVFCPST.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colVFCPSTEnt)

        frm.ShowDialog()
        Calcular()

    End Sub

    Private Sub txtValorCusto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorCusto.Leave
        If Me.txtValorCusto.Text.Trim = "" Then Exit Sub
        Preco(txtValorCusto)

        If ManterPorcProd = False Then
            Me.txtVal.Focus()
        Else
            Me.txtPor1.Focus()
        End If
    End Sub


    Private Sub txtQtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.Leave
        'If Me.txtQtdProd.Text = "" Then
        '    Me.txtQtdProd.Text = Me.txtQtd.Text
        'End If
        If Me.txtValorCusto.Enabled = False Then
            If ManterPorcProd = False Then
                Me.txtVal.Focus()
            Else
                Me.txtPor1.Focus()
            End If
        End If
     
    End Sub

    Private Sub btnConPed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConPed.Click
        ConsultaPedido = ""
        Dim frm As New frmConPed
        frm.Tag = "CONSULTACOMPRANF"
        frm.ShowDialog()

        Me.txtCodPed.Text = ConsultaPedido
        ConsultarPedido(ConsultaPedido)
    End Sub

    Private Sub btnConPed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConPed.Enter
        If Validar(Me.txtNF) = False Then Exit Sub
    End Sub

    Private Sub txtCodPed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPed.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodPed_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPed.Leave
        ConsultarPedido(Me.txtCodPed.Text.Trim)
    End Sub

    Private Sub txtCodPed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPed.Enter
        If Validar(Me.txtNF) = False Then Exit Sub
    End Sub

    Private Sub ConsultarPedido(ByVal parCodPedido As String)
        If parCodPedido = "" Then Exit Sub
        Dim dtFornecedor As DataTable = CarregarDataTable("Select CodOrdens, CodFor, Status From TotalPedCompra Where CodOrdens = " & parCodPedido & " And CodConfig =" & CodConfig)
        If dtFornecedor.Rows.Count > 0 Then
            If dtFornecedor.Rows.Item(0).Item("Status").ToString = "Pendente" Then
                CarregarFornecedor(dtFornecedor.Rows.Item(0).Item("CodFor").ToString)
                CarregarItensPedido(dtFornecedor.Rows.Item(0).Item("CodOrdens").ToString)
            Else
                MsgBox("Pedido de compra nº " & Me.txtCodPed.Text.Trim & " já finalizado!", MsgBoxStyle.Information)
                Me.txtCodPed.Text = ""
                Me.txtCodPed.Focus()
            End If
        Else
            MsgBox("Pedido de compra nº " & Me.txtCodPed.Text.Trim & " não cadastrado no sistema!", MsgBoxStyle.Information)
            Me.txtCodPed.Text = ""
            Me.txtCodPed.Focus()
        End If
    End Sub

    Private Sub CarregarFornecedor(ByVal parCodFor As String)
        If parCodFor.Trim = Nothing Then Exit Sub
        Dim dt As DataTable = CarregarDataTable("Select Nome, CPF From Fornecedor Where Codigo =" & parCodFor)
        If dt.Rows.Count > 0 Then
            intCodFornecedor = parCodFor
            Me.txtFor.Text = dt.Rows.Item(0).Item("Nome").ToString
            Me.txtCPF.Text = dt.Rows.Item(0).Item("CPF").ToString
        End If
    End Sub

    Private Sub CarregarItensPedido(ByVal parCodOrdens As String)
        If Me.grd1.RowCount <= 0 Then
            Dim dt As String() = Date.Now.ToString.Split(" ")
            Me.dtData.Text = dt(0)
            Dim dtCompra As DataTable = CarregarDataTable("Select PedCompra.CodOrdens, PedCompra.Qtd, PedCompra.CodigoProduto, " & _
            "PedCompra.Produto, PedCompra.ValorUnitario, PedCompra.ValorTotal, PedCompra.CodigoInterno, PedCompra.Custo, PedCompra.UM, " & _
            "PedCompra.Tamanho, PedCompra.CodConfig, PedCompra.UniSemDesc, PedCompra.Promocao, PedCompra.Desconto, Produto.CodigoBarra, " & _
            "Produto.Grupo, Produto.Setor, Produto.Tipo as TipoProduto, Produto.Valor as ValProd, Produto.Porcentagens as PorProd, " & _
            "Produto.UnidadeMedida, Produto.CodProdFor From Produto Inner JOIN PedCompra ON Produto.Codigo = PedCompra.CodigoProduto Where CodOrdens =" & parCodOrdens & " AND CodConfig=" & CodConfig)

            Me.picFundo.Visible = False
            Me.tbEntrada.Rows.Clear()
            If dtCompra.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To dtCompra.Rows.Count - 1
                    With Me.tbEntrada.Rows
                        .Add()
                        .Item(I).Item("CodProd") = dtCompra.Rows.Item(I).Item("CodigoProduto").ToString
                        .Item(I).Item("CodProdInterno") = dtCompra.Rows.Item(I).Item("CodigoInterno").ToString
                        .Item(I).Item("Qtd") = dtCompra.Rows.Item(I).Item("Qtd").ToString
                        .Item(I).Item("QtdProd") = dtCompra.Rows.Item(I).Item("Qtd").ToString
                        .Item(I).Item("Produto") = dtCompra.Rows.Item(I).Item("Produto").ToString
                        .Item(I).Item("ValorUnitario") = dtCompra.Rows.Item(I).Item("ValorUnitario").ToString
                        .Item(I).Item("ValorTotal") = dtCompra.Rows.Item(I).Item("ValorTotal").ToString
                        .Item(I).Item("Desconto") = dtCompra.Rows.Item(I).Item("Desconto").ToString
                        .Item(I).Item("Tamanho") = dtCompra.Rows.Item(I).Item("Tamanho").ToString
                        .Item(I).Item("CodConfig") = dtCompra.Rows.Item(I).Item("CodConfig").ToString

                        .Item(I).Item("CodProdFor") = dtCompra.Rows.Item(I).Item("CodProdFor").ToString

                        Dim dblValorImposto As Double = 0
                        .Item(I).Item("UnitarioImposto") = dblValorImposto.ToString("0.00")

                        .Item(I).Item("CodigoBarra") = dtCompra.Rows.Item(I).Item("CodigoBarra").ToString
                        .Item(I).Item("Grupo") = dtCompra.Rows.Item(I).Item("Grupo").ToString
                        .Item(I).Item("Setor") = dtCompra.Rows.Item(I).Item("Setor").ToString
                        .Item(I).Item("TipoProduto") = dtCompra.Rows.Item(I).Item("TipoProduto").ToString

                        'If dtCompra.Rows.Item(I).Item("Custo").ToString <> "" Then
                        '    .Item(I).Item("ValorCusto") = dtCompra.Rows.Item(I).Item("Custo").ToString
                        'Else
                        '    .Item(I).Item("ValorCusto") = dtCompra.Rows.Item(I).Item("ValorUnitario").ToString
                        'End If

                        'Dim CodProd As Integer = dtCompra.Rows.Item(I).Item("CodigoProduto").ToString
                        'Dim dtCusto As DataTable = CarregarDataTable("Select ValorCusto From Produto Where Codigo =" & CodProd & "")
                        '.Item(I).Item("ValorCusto") = dtCusto.Rows.Item(0).Item("ValorCusto").ToString

                        .Item(I).Item("ValorCusto") = dtCompra.Rows.Item(I).Item("ValorUnitario").ToString
                        .Item(I).Item("ValProd") = dtCompra.Rows.Item(I).Item("ValProd").ToString
                        .Item(I).Item("PorProd") = dtCompra.Rows.Item(I).Item("PorProd").ToString

                        If EmiteNFE = True Or SATFiscal = True Then
                            Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
                            "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
                            "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb FROM Nfe where CodProd = " & dtCompra.Rows.Item(I).Item("CodigoProduto").ToString)

                            If dtNfe.Rows.Count > 0 Then
                                .Item(I).Item("EXTIPI") = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                                .Item(I).Item("Genero") = dtNfe.Rows.Item(0).Item("Genero").ToString
                                .Item(I).Item("NCM") = dtNfe.Rows.Item(0).Item("NCM").ToString
                                .Item(I).Item("Regime") = dtNfe.Rows.Item(0).Item("Regime").ToString
                                .Item(I).Item("CST") = dtNfe.Rows.Item(0).Item("CST").ToString
                                .Item(I).Item("Origem") = dtNfe.Rows.Item(0).Item("Origem").ToString
                                .Item(I).Item("ModBC") = dtNfe.Rows.Item(0).Item("ModBC").ToString
                                .Item(I).Item("IcmsNfe") = dtNfe.Rows.Item(0).Item("ICMS").ToString
                                .Item(I).Item("RedBC") = dtNfe.Rows.Item(0).Item("RedBC").ToString
                                .Item(I).Item("ModBCST") = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                                .Item(I).Item("RedBCST") = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                                .Item(I).Item("MVaST") = dtNfe.Rows.Item(0).Item("MVaST").ToString
                                .Item(I).Item("IcmsST") = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                                .Item(I).Item("CalculoCred") = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
                                .Item(I).Item("CFOP") = dtNfe.Rows.Item(0).Item("CFOP").ToString
                                .Item(I).Item("CodigoANP") = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                                .Item(I).Item("UFComb") = dtNfe.Rows.Item(0).Item("UFComb").ToString
                            End If

                            Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                            "PerCOFINS FROM Tributos where CodProd = " & dtCompra.Rows.Item(I).Item("CodigoProduto").ToString)

                            If dtTrib.Rows.Count > 0 Then
                                .Item(I).Item("CSTIPI") = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                                .Item(I).Item("CSTPIS") = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                                .Item(I).Item("CSTCOFINS") = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                                .Item(I).Item("CodEnq") = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                                .Item(I).Item("PerIPI") = dtTrib.Rows.Item(0).Item("PerIPI").ToString
                                .Item(I).Item("PerPIS") = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                                .Item(I).Item("PerCOFINS") = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
                            End If
                        End If
                    End With
                Next
                Calcular()

            End If
        End If
    End Sub
    Private Sub GerarParecelas()

        If bolLimpar = True Then Exit Sub

        If Me.grpConta.Visible = False Then Exit Sub

        If Validar(Me.txtValNota) = False Then Exit Sub
        If Validar(Me.dtVenc) = False Then Exit Sub
        If Validar(Me.txtDias) = False Then Exit Sub

        Dim I As Integer
        Dim dblValConta, dblValPar As Double

        dblValConta = Me.txtValNota.Text.Trim

        dblValPar = dblValConta / Me.seParcela.Value

        Dim dtDate As Date = Me.dtVenc.DateTime

        Me.tbContaPagar.Rows.Clear()
        Dim strParcelas As String = ""
        vetParcela = Nothing
        Dim dblTotal As Double
        For I = 0 To Me.seParcela.Value - 1

            With Me.tbContaPagar.Rows
                .Add()
                If I = 0 Then
                    strParcelas = I + 1
                Else
                    strParcelas &= "|" & I + 1
                End If
                strParcelas = I + 1
                .Item(I).Item("Parcela") = I + 1
                .Item(I).Item("ValorParcela") = dblValPar.ToString("0.00")
                .Item(I).Item("Vencimento") = Format(dtDate, "dd/MM/yyyy")
                '.Item(I).Item("Documento") = Me.txtNF.Text
                If Me.txtDias.Text = "30" Then
                    dtDate = dtDate.AddMonths(1)
                Else
                    dtDate = dtDate.AddDays(Me.txtDias.Text)
                End If

                dblTotal += dblValPar
            End With

        Next
        vetParcela = Split(strParcelas, "|")
        strValorContaPagar = dblValConta
        If dblTotal > 0 Then
            Dim dblResul As Double = dblValConta - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        End If

    End Sub
    Private Sub seParcela_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seParcela.EditValueChanged
        GerarParecelas()
    End Sub

    Private Sub txtValorParcela_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorParcela.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "," And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorParcela_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorParcela.Leave
        If Me.grd3.GetFocusedDisplayText = "" Then Exit Sub
        If bolAlterado = True Then Exit Sub
        Try
            Dim dblVal As Double = Me.grd3.GetFocusedDisplayText
            Me.grd3.SetFocusedValue(dblVal.ToString("0.00"))


            If Me.txtValNota.Text = "" Then Exit Sub
            If Me.seParcela.Text = "" Then Exit Sub
            Dim dblTotal As Double
            Dim I As Integer
            For I = 0 To Me.grd3.RowCount - 1
                dblTotal += Me.grd3.GetRowCellDisplayText(I, Me.colValorParcela)

            Next

            Dim dblvalor As Double = Me.txtValNota.Text
            Dim dblResul As Double = dblvalor - dblTotal
            If dblResul > "0,5" Then
                MsgBox("A soma das parcelas não batem com o valor da conta!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Caracter digitado não é permitido para este campo!", MsgBoxStyle.Exclamation)
            Me.grd3.SetFocusedValue("")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.luePag.Focus()

        If Me.luePag.Focus = True Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub dtVenc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtVenc.Leave
        Me.seParcela.Focus()
    End Sub

    Private Sub dtData_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtData.GotFocus
        If Me.dtData.Text = "" Then
            Me.dtData.EditValue = Date.Today
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim vetNfe As String() = Nothing
        Dim intIndex As Integer = 0
        If LocalNFe <> "" Then
            vetNfe = LocalNFe.Split("\")
            intIndex = vetNfe.Length - 1
        Else
            Me.Timer2.Stop()
        End If
        Try
            If System.IO.File.Exists("C:\NANOXML\" & vetNfe(intIndex).ToString.Trim & "") = True Then
                If LocalNFe <> "" Then
                    Me.Timer2.Stop()
                    AbrirXML(LocalNFe)
                    LocalNFe = ""
                End If
            ElseIf System.IO.File.Exists("C:\Users\" & Environment.UserName.ToString.Trim() & "\Downloads\" & vetNfe(intIndex).ToString.Trim & "") = True Then
                If LocalNFe <> "" Then
                    Me.Timer2.Stop()
                    AbrirXML(LocalNFe)
                    LocalNFe = ""
                End If
            ElseIf System.IO.File.Exists("C:\Users\" & Environment.UserName.ToString.Trim() & "\Desktop\" & vetNfe(intIndex).ToString.Trim & "") = True Then
                If LocalNFe <> "" Then
                    Me.Timer2.Stop()
                    AbrirXML(LocalNFe)
                    LocalNFe = ""
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AbrirXML(ByVal parLocal As String)
        Limpar()
        If parLocal <> "" Then
            vetParcela = Nothing
            If NfeXml(parLocal) = True Then
                Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "' or Nome = '" & Me.txtFor.Text.Trim & "'")
                If dtFor.Rows.Count > 0 Then
                    CodigoDoFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                    intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
                End If
                Calcular()
                If Me.txtValDesc.Text <> "" Then
                    Me.chkDescontoItens.Enabled = True
                    Me.chkDescontoItens.Visible = True
                End If
                If Me.grd1.RowCount > 0 Then
                    Me.picFundo.Visible = False
                End If

                If vetParcela Is Nothing Then
                    Me.grpConta.Visible = False
                    Exit Sub
                End If
                Me.tbContaPagar.Rows.Clear()

                Dim dt As DataTable = CarregarDataTable("SELECT Codigo FROM ContaPagar where NumeroDocumento = '" & Me.txtNF.Text & "' and CodFor = " & intCodFornecedor)
                If dt.Rows.Count = 0 Then
                    Dim I As Integer
                    For I = 0 To vetParcela.Length - 1

                        Dim vetPar As Array = Split(vetParcela(I), "-")

                        Dim strValParcela As String = vetPar(0)
                        Dim strVenc As String = vetPar(1)
                        If I = 0 Then
                            Me.dtVenc.EditValue = strVenc
                            Me.seParcela.Text = vetParcela.Length
                        End If
                        Me.tbContaPagar.Rows.Add()
                        Me.tbContaPagar.Rows.Item(I).Item("ValorParcela") = strValParcela
                        Me.tbContaPagar.Rows.Item(I).Item("ValorConta") = Me.txtValNota.Text
                        Me.tbContaPagar.Rows.Item(I).Item("Vencimento") = strVenc
                        Me.tbContaPagar.Rows.Item(I).Item("Parcela") = I + 1

                    Next
                    Me.grpConta.Visible = True
                Else
                    Me.grpConta.Visible = False
                End If
            Else
                MsgBox("Arquivo XML com erro!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXML.ItemClick
        Dim frm As New frmBaixarXML
        frm.ShowDialog()
        Me.Timer2.Start()
    End Sub
    Private Sub VerificarFornecedor()
        If Me.txtCPF.Text.Trim <> "" Then
            Dim dtFor As DataTable = CarregarDataTable("SELECT Codigo FROM Fornecedor where CPF = '" & Me.txtCPF.Text.Trim & "'")
            If dtFor.Rows.Count = 0 Then
                If Me.tbFor.Rows.Count > 0 Then
                    Dim strEndereco As String = tbFor.Rows.Item(0).Item("Endereco").ToString
                    Dim strNumero As String = tbFor.Rows.Item(0).Item("Numero").ToString
                    Dim strBairro As String = tbFor.Rows.Item(0).Item("Bairro").ToString
                    Dim strCidade As String = tbFor.Rows.Item(0).Item("Cidade").ToString
                    Dim strEstado As String = tbFor.Rows.Item(0).Item("Estado").ToString
                    Dim strCep As String = tbFor.Rows.Item(0).Item("Cep").ToString
                    Dim strTelefone As String = tbFor.Rows.Item(0).Item("Telefone").ToString
                    Dim strIE As String = tbFor.Rows.Item(0).Item("IE").ToString
                    Dim strFantasia As String = tbFor.Rows.Item(0).Item("Fantasia").ToString
                    Inserir("INSERT INTO Fornecedor (Nome, CPF, Endereco, Numero, Bairro, Cidade, Estado, Cep, Telefone, IE, Data, Fantasia, Tipo, Inativo) VALUES ('" & Me.txtFor.Text.Trim & "','" & Me.txtCPF.Text.Trim & "','" & strEndereco & "','" & strNumero & "','" & strBairro & "','" & strCidade & "','" & strEstado & "','" & strCep & "','" & strTelefone & "','" & strIE & "','" & Date.Today & "','" & strFantasia & "','F','False')")
                    Dim dtFor2 As DataTable = CarregarDataTable("Select Codigo from Fornecedor where CPF ='" & Me.txtCPF.Text.Trim & "'")
                    If dtFor2.Rows.Count > 0 Then
                        intCodFornecedor = dtFor2.Rows.Item(0).Item("Codigo").ToString
                    Else
                        intCodFornecedor = GerarCodigo("Fornecedor", "Codigo", 0) - 1
                    End If

                End If
            Else
                intCodFornecedor = dtFor.Rows.Item(0).Item("Codigo").ToString
            End If
        End If
    End Sub
    Private Sub btnVincularProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincularProduto.Click
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim strIndex As String = Me.grd1.FocusedRowHandle
        Dim strCodProd As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
        If strCodProd <> "" Then MsgBox("Produto ja cadastrado no sistema!", MsgBoxStyle.Information) : Exit Sub

        Dim strCodProdFor As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProdFor)
        Dim strProduto As String = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
        Dim dblValCusto As Double = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colValorCusto)
        VerificarFornecedor()
        Dim frm As New frmConProduto
        frm.Tag = "VENDA"
        CodigoDoProduto = -1
        frm.ShowDialog()
        If CodigoDoProduto = -1 Then Exit Sub
        strCodProd = CodigoDoProduto

        Dim dtProd As DataTable = CarregarDataTable("Select Codigo, Nome, CodigoInterno, Nome as Produto, UnidadeMedida, ValorCusto, convert(Numeric(15," & CasaDecimal & "),Valor) as Valor, " & _
        "Porcentagens, CodigoBarra, Grupo, Setor, Tipo, CodProdFor, Inativo from Produto where Codigo = " & strCodProd)

        grd1.SetRowCellValue(strIndex, Me.colCodProd, strCodProd)
        grd1.SetRowCellValue(strIndex, Me.colCodProdInterno, dtProd.Rows.Item(0).Item("CodigoInterno"))
        grd1.SetRowCellValue(strIndex, Me.colCodigoBarra, dtProd.Rows.Item(0).Item("CodigoBarra"))
        grd1.SetRowCellValue(strIndex, Me.colProduto, dtProd.Rows.Item(0).Item("Produto"))
        grd1.SetRowCellValue(strIndex, Me.colTamanho, Me.txtTam.Text.Trim)
       

        If ManterPorcProd = True Then
            grd1.SetRowCellValue(strIndex, Me.colPorProd, dtProd.Rows.Item(0).Item("Porcentagens"))

            Dim dblPor As Double = dtProd.Rows.Item(0).Item("Porcentagens")

            Dim dblResul As Double = (dblValCusto * dblPor) / 100
            dblResul = dblValCusto + dblResul
            grd1.SetRowCellValue(strIndex, Me.colValProd, dblResul.ToString("0.000"))

        Else
            grd1.SetRowCellValue(strIndex, Me.colValProd, dtProd.Rows.Item(0).Item("Valor"))

            Dim dblValVenda As Double = dtProd.Rows.Item(0).Item("Valor")
            Dim dblLucro As Double = dblValVenda - dblValCusto
            Dim dblMargem As Double = (dblLucro * 100) / dblValCusto
            Dim str As String = dblMargem
            If str <> "+Infinito" Then
                grd1.SetRowCellValue(strIndex, Me.colPorProd, dblMargem.ToString("0.00"))
            End If
        End If
       

        grd1.SetRowCellValue(strIndex, Me.colGrupo, dtProd.Rows.Item(0).Item("Grupo"))
        grd1.SetRowCellValue(strIndex, Me.colSetor, dtProd.Rows.Item(0).Item("Setor"))

        grd1.SetRowCellValue(strIndex, Me.colTipoProduto, dtProd.Rows.Item(0).Item("Tipo"))

        grd1.SetRowCellValue(strIndex, Me.colCodProdFor, dtProd.Rows.Item(0).Item("CodProdFor"))
    
        grd1.SetRowCellValue(strIndex, Me.colUMProd, dtProd.Rows.Item(0).Item("UnidadeMedida"))

        If EmiteNFE = True Or SATFiscal = True Then
            Dim dtRegime As DataTable = CarregarDataTable("SELECT Regime FROM Nfe where CodProd = " & strCodProd & " and Regime like '%" & RegimeSAT & "%' order by Regime")

            Dim strTipoFiscal As String = ""
            If dtRegime.Rows.Count > 0 Then
                Dim strRegimeNFeSat As String = dtRegime.Rows.Item(0).Item("Regime").ToString
                If strRegimeNFeSat.Contains("SAT") Or strRegimeNFeSat.Contains("NFE") Then
                    strTipoFiscal = " NFE"
                End If
            End If
            Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
            "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
            "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb FROM Nfe where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & strTipoFiscal & "'")

            If dtNfe.Rows.Count > 0 Then
                strEXTIPIGeral = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                strGeneroGeral = dtNfe.Rows.Item(0).Item("Genero").ToString
                strNCMGeral = dtNfe.Rows.Item(0).Item("NCM").ToString
                strRegimeNfeGeral = dtNfe.Rows.Item(0).Item("Regime").ToString
                strCstNfeGeral = dtNfe.Rows.Item(0).Item("CST").ToString
                strOrigemNfeGeral = dtNfe.Rows.Item(0).Item("Origem").ToString
                strModBCNfeGeral = dtNfe.Rows.Item(0).Item("ModBC").ToString
                strIcmsNfeGeral = dtNfe.Rows.Item(0).Item("ICMS").ToString
                strRedBCNfeGeral = dtNfe.Rows.Item(0).Item("RedBC").ToString
                strModBCSTNfeGeral = dtNfe.Rows.Item(0).Item("ModBCST").ToString
                strRedBCSTNfeGeral = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                strMVaSTNfeGeral = dtNfe.Rows.Item(0).Item("MVaST").ToString
                strIcmsSTNfeGeral = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                strCalcCredNfeGeral = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
                strCFOPGeral = dtNfe.Rows.Item(0).Item("CFOP").ToString
                strCodigoANPGeral = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                strUFCombGeral = dtNfe.Rows.Item(0).Item("UFComb").ToString
            End If

            Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & RegimeSAT & strTipoFiscal & "'")

            If dtTrib.Rows.Count > 0 Then
                strCSTIPIGeral = dtTrib.Rows.Item(0).Item("CSTIPI").ToString
                strCSPPISGeral = dtTrib.Rows.Item(0).Item("CSTPIS").ToString
                strCSTCOFINSGeral = dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString
                strCodEnqGeral = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                strPerIPIGeral = dtTrib.Rows.Item(0).Item("PerIPI").ToString
                strPerPISGeral = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                strPerCOFINSGeral = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
            End If

            grd1.SetRowCellValue(strIndex, Me.colEXTIPI, strEXTIPIGeral)
            grd1.SetRowCellValue(strIndex, Me.colGenero, strGeneroGeral)
            grd1.SetRowCellValue(strIndex, Me.colNCM, strNCMGeral)
            grd1.SetRowCellValue(strIndex, Me.colRegime, strRegimeNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colCST, strCstNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colModBC, strModBCNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colOrigem, strOrigemNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colRedBC, strRedBCNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colIcmsNfe, strIcmsNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colModBCST, strModBCSTNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colRedBCST, strRedBCSTNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colIcmsST, strIcmsSTNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colCalculoCred, strCalcCredNfeGeral)
            grd1.SetRowCellValue(strIndex, Me.colCFOP, strCFOPGeral)
            grd1.SetRowCellValue(strIndex, Me.colCodigoANP, strCodigoANPGeral)
            grd1.SetRowCellValue(strIndex, Me.colUFComb, strUFCombGeral)
            grd1.SetRowCellValue(strIndex, Me.colCSTIPI, strCSTIPIGeral)
            grd1.SetRowCellValue(strIndex, Me.colCSTPIS, strCSPPISGeral)
            grd1.SetRowCellValue(strIndex, Me.colCSTCOFINS, strCSTCOFINSGeral)
            grd1.SetRowCellValue(strIndex, Me.colCodEnq, strCodEnqGeral)
            grd1.SetRowCellValue(strIndex, Me.colPerIPI, strPerIPIGeral)
            grd1.SetRowCellValue(strIndex, Me.colPerPIS, strPerPISGeral)
            grd1.SetRowCellValue(strIndex, Me.colPerCOFINS, strPerCOFINSGeral)
        End If

        Inserir("INSERT INTO CodigoBarra (CodProd, CodigoBarra, CodFor, Produto) VALUES (" & strCodProd & ",'" & strCodProdFor & "'," & intCodFornecedor & ",'" & strProduto & "')")

    End Sub

    Private Sub btnManter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManter.Click
        ConfigurarGrid(Me.grd1, Me, False, Me.btnPadrao)
    End Sub

    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        ConfigurarGridPadrao(Me, Me.btnPadrao)
    End Sub

    Private Sub cboGrp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrp.Leave
        If Me.txtCodBarra.Text <> "" Then
            Me.txtQtd.Focus()
        End If
    End Sub

    Private Sub btnCenCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCenCus.Click
        Dim frm As New frmGrupo
        frm.Tag = "CENTROCUSTO"
        frm.ShowDialog()
        Me.cboCenCus.Properties.Items.Clear()
        PreencherGrupoSetorCusto("C", Me.cboCenCus)
        Me.cboCenCus.Focus()
    End Sub

    Private Sub grpConta_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpConta.VisibleChanged
        If Me.grpConta.Visible = True Then
            Me.cboCenCus.Properties.Items.Clear()
            PreencherGrupoSetorCusto("C", Me.cboCenCus)
            Me.cboTipCus.Text = "F"
            Dim dt As DataTable = CarregarDataTable("Select TipoConta from ContaPagar group by TipoConta order by TipoConta")

            Dim I As Integer

            Me.cboTipConta.Properties.Items.Clear()

            For I = 0 To dt.Rows.Count - 1
                Me.cboTipConta.Properties.Items.Add(dt.Rows.Item(I).Item("TipoConta").ToString)
            Next
            Me.cboTipConta.Text = "FORNECEDOR"
            Me.luePag.Focus()
        End If
       
    End Sub

    Private Sub txtChave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChave.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
            Exit Sub
        End If
    End Sub

    Private Sub chkImpostoItens_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImpostoItens.CheckedChanged
        Me.txtValorCusto.ResetText()

        If Me.chkImpostoItens.Checked = True Then
            Me.txtValorCusto.Enabled = False

        Else
            Me.txtValorCusto.Enabled = True

        End If
        Calcular()

    End Sub

    Private Sub txtQtdProd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtdProd.Enter
       
        Me.txtQtdProd.CasasDecimais = 3

    End Sub

    Private Sub txtValor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.EditValueChanged

    End Sub
End Class