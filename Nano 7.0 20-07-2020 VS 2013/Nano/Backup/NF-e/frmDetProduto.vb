Imports Nano.clsFuncoes

Public Class frmDetProduto
    Public strCodigoProduto As String
    Dim strCST As String

    Public strCodigoAut As String
    Public strValorTotal As String
    Public intIndex As Integer
    Public strRegime As String
    Private Sub frmDetProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        If TesteConexao() = False Then Exit Sub
        If Me.Tag.ToString.Contains("ENTRADA") = False Then
            Limpar()
        End If

        CarregarDadosLue("SELECT * FROM CFOP", Me.lueCFOP)

        If Me.Tag = "PESQUISA" Then
            Me.lblValICMS.Visible = False
            Me.lblValICMSST.Visible = False
            Me.lblValCred.Visible = False
            Me.txtValICMS.Visible = False
            Me.txtValICMSST.Visible = False
            Me.txtValCred.Visible = False
            Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo, CodProd, EXTIPI, Genero, UnidTrib, ValTrib, " & _
                    "QtdTrib, MIPI, QtdN, CST, Origem, ModBC, ICMS, RedBC, ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, " & _
                    "Regime, CalculoCred, UnidCom, ValCom, CodigoANP, UFComb, Cest FROM Nfe where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")

            If dtNfe.Rows.Count > 0 Then

                Me.txtEXTIPI.Text = dtNfe.Rows.Item(0).Item("EXTIPI").ToString
                Me.txtGenero.Text = dtNfe.Rows.Item(0).Item("Genero").ToString
                Me.txtNfeNCM.Text = dtNfe.Rows.Item(0).Item("NCM").ToString
                Me.cboRegime.Text = strRegime.Replace(" NFE", "").Replace(" SAT", "")
                Me.cboRegime.Enabled = False
                Regime(strRegime)
                SelecionarCombo(Me.cboNfeCST, dtNfe.Rows.Item(0).Item("CST").ToString)
                CST()
                Me.cboRegime.Enabled = False
                SelecionarCombo(Me.cboOrigem, dtNfe.Rows.Item(0).Item("Origem").ToString)
                SelecionarCombo(Me.cboModBC, dtNfe.Rows.Item(0).Item("ModBC").ToString)
                Me.txtNfeICMS.Text = dtNfe.Rows.Item(0).Item("ICMS").ToString
                Me.txtRedBC.Text = dtNfe.Rows.Item(0).Item("RedBC").ToString
                SelecionarCombo(Me.cboModBCST, dtNfe.Rows.Item(0).Item("ModBCST").ToString)
                Me.txtRedBCST.Text = dtNfe.Rows.Item(0).Item("RedBCST").ToString
                Me.txtMVAST.Text = dtNfe.Rows.Item(0).Item("MVaST").ToString
                Me.txtICMSST.Text = dtNfe.Rows.Item(0).Item("ICMSST").ToString
                Me.txtCalcCred.Text = dtNfe.Rows.Item(0).Item("CalculoCred").ToString
                Me.lueCFOP.EditValue = dtNfe.Rows.Item(0).Item("CFOP").ToString
                Me.lueCFOP.ClosePopup()

                CFOPCombustivel()
                Me.cboCodigoANP.Text = dtNfe.Rows.Item(0).Item("CodigoANP").ToString
                Me.cboUF.Text = dtNfe.Rows.Item(0).Item("UFComb").ToString
                Me.txtCest.Text = dtNfe.Rows.Item(0).Item("Cest").ToString

            Else
                Me.txtNfeNCM.ResetText()
                Dim dtNCM As DataTable = CarregarDataTable("SELECT  NCM  FROM Nfe where CodProd = " & strCodigoAut)
                If dtNCM.Rows.Count > 0 Then
                    Me.txtNfeNCM.Text = dtNCM.Rows.Item(0).Item("NCM").ToString
                End If
                Me.txtEXTIPI.ResetText()
                Me.txtGenero.ResetText()
                Me.lueCFOP.EditValue = DBNull.Value
                CarregarDadosLue("SELECT * FROM CFOP", Me.lueCFOP)
                Me.cboNfeCST.SelectedIndex = -1
                Me.cboOrigem.SelectedIndex = -1
                Me.cboModBC.SelectedIndex = -1
                Me.txtNfeICMS.ResetText()
                Me.txtRedBC.ResetText()
                Me.cboModBCST.SelectedIndex = -1
                Me.txtRedBCST.ResetText()
                Me.txtMVAST.ResetText()
                Me.txtICMSST.ResetText()
                Me.txtCalcCred.ResetText()
                Me.cboRegime.Text = strRegime
                Me.cboRegime.Enabled = False
                Regime(strRegime)
                Me.txtCest.ResetText()
            End If

            Dim dtTrib As DataTable = CarregarDataTable("SELECT CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
            "PerCOFINS FROM Tributos where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")

            If dtTrib.Rows.Count > 0 Then
                If dtTrib.Rows.Item(0).Item("CSTIPI").ToString <> "" Then
                    SelecionarCombo(Me.cboCSTIPI, dtTrib.Rows.Item(0).Item("CSTIPI").ToString)
                End If
                If dtTrib.Rows.Item(0).Item("CSTPIS").ToString <> "" Then
                    SelecionarCombo(Me.cboCSTPIS, dtTrib.Rows.Item(0).Item("CSTPIS").ToString)
                End If
                If dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString <> "" Then
                    SelecionarCombo(Me.cboCSTCOFINS, dtTrib.Rows.Item(0).Item("CSTCOFINS").ToString)
                End If

                Me.txtCodEnq.Text = dtTrib.Rows.Item(0).Item("CodEnq").ToString
                Me.txtAliquotaIPI.Text = dtTrib.Rows.Item(0).Item("PerIPI").ToString
                Me.txtAliquotaPIS.Text = dtTrib.Rows.Item(0).Item("PerPIS").ToString
                Me.txtAliquotaCOFINS.Text = dtTrib.Rows.Item(0).Item("PerCOFINS").ToString
            End If
            strCST = Me.cboNfeCST.Text
        End If


        If Me.Tag = "ENTRADANF" Then
            Me.txtValICMS.Visible = False
            Me.txtValICMSST.Visible = False
            Me.txtValIPI.Visible = False
            Me.txtValPIS.Visible = False
            Me.txtValCOFINS.Visible = False
            Me.txtValCred.Visible = False

            Me.lblValICMS.Visible = False
            Me.lblValICMSST.Visible = False
            Me.lblValIPI.Visible = False
            Me.lblValPIS.Visible = False
            Me.lblValCOFINS.Visible = False
            Me.lblValCred.Visible = False

        End If
        If Me.Tag <> "ENTRADANFEnt" Then
            Me.txtVFCPST.Visible = False
            Me.LabelControl3.Visible = False

            Me.lblFrete.Visible = False
            Me.txtFreteEnt.Visible = False

            Me.lblDespesas.Visible = False
            Me.txtDespesasEnt.Visible = False

            Me.lblSeguro.Visible = False
            Me.txtSeguroEnt.Visible = False
        End If
    End Sub

    Private Sub Limpar()
        CFOPCombustivel()
        Me.txtEXTIPI.ResetText()
        Me.txtGenero.ResetText()
        Me.txtNfeNCM.ResetText()
        Me.cboOrigem.SelectedIndex = -1
        Me.cboModBC.SelectedIndex = -1
        Me.txtNfeICMS.ResetText()
        Me.txtRedBC.ResetText()
        Me.cboModBCST.SelectedIndex = -1
        Me.txtRedBCST.ResetText()
        Me.txtMVAST.ResetText()
        Me.txtICMSST.ResetText()
        Me.txtCalcCred.ResetText()
        Me.cboNfeCST.SelectedIndex = -1
        Me.cboCSTIPI.SelectedIndex = -1
        Me.txtCodEnq.ResetText()
        Me.txtAliquotaIPI.ResetText()
        Me.cboCSTPIS.SelectedIndex = -1
        Me.txtAliquotaPIS.ResetText()
        Me.cboCSTCOFINS.SelectedIndex = -1
        Me.txtAliquotaCOFINS.ResetText()

        Me.txtVFCPST.ResetText()
        Me.txtFreteEnt.ResetText()
        Me.txtDespesasEnt.ResetText()
        Me.txtSeguroEnt.ResetText()

        Me.lueCFOP.EditValue = DBNull.Value
        CarregarDadosLue("SELECT * FROM CFOP", Me.lueCFOP)

        Me.txtCest.ResetText()
    End Sub
    Private Sub LimparNFE(ByVal parTudo As Boolean)
        If parTudo = True Then
            Me.cboNfeCST.SelectedIndex = -1
        End If

        Me.cboOrigem.SelectedIndex = -1
        Me.cboModBC.SelectedIndex = -1
        Me.txtNfeICMS.ResetText()
        Me.txtRedBC.ResetText()
        Me.cboModBCST.SelectedIndex = -1
        Me.txtRedBCST.ResetText()
        Me.txtMVAST.ResetText()
        Me.txtICMSST.ResetText()
        Me.txtCalcCred.ResetText()

        Me.cboOrigem.Enabled = True
        Me.cboModBC.Enabled = True
        Me.txtNfeICMS.Enabled = True
        Me.txtRedBC.Enabled = True
        Me.cboModBCST.Enabled = True
        Me.txtRedBCST.Enabled = True
        Me.txtMVAST.Enabled = True
        Me.txtCalcCred.Enabled = True
        Me.txtICMSST.Enabled = True


        Me.cboCSTIPI.SelectedIndex = -1
        Me.txtAliquotaIPI.ResetText()
        Me.txtCodEnq.ResetText()


        Me.cboCSTPIS.SelectedIndex = -1
        Me.txtAliquotaPIS.ResetText()

        Me.cboCSTCOFINS.SelectedIndex = -1
        Me.txtAliquotaCOFINS.ResetText()
    End Sub

    Private Sub Bloquear(ByVal parBloquear As Boolean)
        If parBloquear = True Then
            'Me.txtEXTIPI.Enabled = True
            'Me.txtGenero.Enabled = True
            'Me.txtUniTrib.Enabled = True
            'Me.txtValTrib.Enabled = True
            'Me.txtQtdTrib.Enabled = True
            'Me.txtQtdCom.Enabled = True
            'Me.txtNfeNCM.Enabled = True
            'Me.txtUniCom.Enabled = True
            'Me.txtValCom.Enabled = True


            Me.cboOrigem.Enabled = True
            'Me.cboNfeCST.Enabled = True

            Me.cboModBC.Enabled = True
            Me.txtNfeICMS.Enabled = True
            Me.txtRedBC.Enabled = True
            Me.cboModBCST.Enabled = True
            Me.txtRedBCST.Enabled = True
            Me.txtMVAST.Enabled = True
            Me.txtCalcCred.Enabled = True
            Me.txtICMSST.Enabled = True

            Me.cboCSTIPI.Enabled = True
            Me.txtCodEnq.Enabled = True
            Me.txtAliquotaIPI.Enabled = True

            Me.cboCSTPIS.Enabled = True
            Me.txtAliquotaPIS.Enabled = True

            Me.cboCSTCOFINS.Enabled = True
            Me.txtAliquotaCOFINS.Enabled = True

            Me.txtValCOFINS.Enabled = True
            Me.txtValICMS.Enabled = True
            Me.txtValICMSST.Enabled = True
            Me.txtValIPI.Enabled = True
            Me.txtValPIS.Enabled = True
            'Me.lueCFOP.Enabled = True

            Me.txtValCred.Enabled = True
        Else

            Me.txtEXTIPI.Enabled = False
            Me.txtGenero.Enabled = False
            Me.txtNfeNCM.Enabled = False

            Me.cboOrigem.Enabled = False
            'Me.cboNfeCST.Enabled = False

            Me.cboModBC.Enabled = False
            Me.txtNfeICMS.Enabled = False
            Me.txtRedBC.Enabled = False
            Me.cboModBCST.Enabled = False
            Me.txtRedBCST.Enabled = False
            Me.txtMVAST.Enabled = False
            Me.txtCalcCred.Enabled = False
            Me.txtICMSST.Enabled = False

            Me.cboCSTIPI.Enabled = False
            Me.txtCodEnq.Enabled = False
            Me.txtAliquotaIPI.Enabled = False

            Me.cboCSTPIS.Enabled = False
            Me.txtAliquotaPIS.Enabled = False

            Me.cboCSTCOFINS.Enabled = False
            Me.txtAliquotaCOFINS.Enabled = False

            Me.txtValCOFINS.Enabled = False
            Me.txtValICMS.Enabled = False
            Me.txtValICMSST.Enabled = False
            Me.txtValIPI.Enabled = False
            Me.txtValPIS.Enabled = False
            'Me.lueCFOP.Enabled = True

            Me.txtValCred.Enabled = False
        End If
    End Sub
    Public Sub Regime(ByVal parRegime As String)
        LimparNFE(True)
        Me.cboNfeCST.Properties.Items.Clear()
        Me.cboNfeCST.Properties.Items.Add("")
        Select Case parRegime
            Case "TRIBUTAÇÃO NORMAL", "TRIBUTAÇÃO NORMAL NFE", "TRIBUTAÇÃO NORMAL SAT"

                Me.cboNfeCST.Properties.Items.Add("00 – Tributada integralmente")
                Me.cboNfeCST.Properties.Items.Add("10 - Tributada e com cobrança do ICMS por substituição tributária")
                Me.cboNfeCST.Properties.Items.Add("20 - Com redução de base de cálculo")
                Me.cboNfeCST.Properties.Items.Add("30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária")
                Me.cboNfeCST.Properties.Items.Add("40 - Isenta")
                Me.cboNfeCST.Properties.Items.Add("41 - Não tributada")
                Me.cboNfeCST.Properties.Items.Add("50 – Suspensão")
                Me.cboNfeCST.Properties.Items.Add("51 - Diferimento - A exigência do preenchimento das informações do ICMS diferido fica à critério de cada UF")
                Me.cboNfeCST.Properties.Items.Add("60 - ICMS cobrado anteriormente por substituição tributária")
                Me.cboNfeCST.Properties.Items.Add("70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária")
                Me.cboNfeCST.Properties.Items.Add("90 – Outros")

            Case Else

                Me.cboNfeCST.Properties.Items.Add("101 - Tributada com permissão de crédito")
                Me.cboNfeCST.Properties.Items.Add("102 - Tributada sem permissão de crédito")
                Me.cboNfeCST.Properties.Items.Add("103 - Isenção do ICMS para faixa de receita bruta")
                Me.cboNfeCST.Properties.Items.Add("201 - Tributada com permissão de crédito e com cobrança do ICMS por ST")
                Me.cboNfeCST.Properties.Items.Add("202 - Tributada sem permissão de crédito e com cobrança do ICMS por ST")
                Me.cboNfeCST.Properties.Items.Add("203 - Isenção do ICMS para faixa de receita bruta e com cobrança do ICMS por ST")
                Me.cboNfeCST.Properties.Items.Add("300 - Imune")
                Me.cboNfeCST.Properties.Items.Add("400 - Não Tributada")
                Me.cboNfeCST.Properties.Items.Add("500 - ICMS cobrado anteriormente por ST ou por antecipação")
                Me.cboNfeCST.Properties.Items.Add("900 - Outros")

        End Select
    End Sub
    Private Sub CST()
        Bloquear(True)
        Dim strNFECST As String = Me.cboNfeCST.Text
        If Me.cboRegime.SelectedIndex = 0 Then
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 2)
            End If
        Else
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 3)
            End If
        End If

        Select Case strNFECST
            Case "00"
                Me.txtRedBC.Enabled = False
                Me.cboModBCST.Enabled = False
                Me.txtRedBCST.Enabled = False
                Me.txtMVAST.Enabled = False
                Me.txtICMSST.Enabled = False
                Me.txtCalcCred.Enabled = False

            Case "10"
                Me.txtRedBC.Enabled = False
                Me.txtCalcCred.Enabled = False

            Case "20", "51"
                Me.cboModBCST.Enabled = False
                Me.txtRedBCST.Enabled = False
                Me.txtMVAST.Enabled = False
                Me.txtICMSST.Enabled = False
                Me.txtCalcCred.Enabled = False
            
            Case "30", "202", "203"
                Me.txtRedBC.Enabled = False
                Me.cboModBC.Enabled = False
                Me.txtNfeICMS.Enabled = False
                Me.txtCalcCred.Enabled = False
              
            Case "40", "41", "50", "60", "102", "103", "300", "400", "500"
                Me.cboModBC.Enabled = False
                Me.txtNfeICMS.Enabled = False
                Me.txtRedBC.Enabled = False
                Me.cboModBCST.Enabled = False
                Me.txtRedBCST.Enabled = False
                Me.txtMVAST.Enabled = False
                Me.txtICMSST.Enabled = False
                Me.txtCalcCred.Enabled = False

            Case "101"
                Me.cboModBC.Enabled = False
                Me.txtNfeICMS.Enabled = False
                Me.txtRedBC.Enabled = False
                Me.cboModBCST.Enabled = False
                Me.txtRedBCST.Enabled = False
                Me.txtMVAST.Enabled = False
                Me.txtICMSST.Enabled = False

            Case "201"
                Me.txtRedBC.Enabled = False
                Me.cboModBC.Enabled = False
                Me.txtNfeICMS.Enabled = False
            Case "70", "90", "900"
                Me.txtCalcCred.Enabled = False

        End Select

    End Sub


    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Limpar()
        Me.Close()
    End Sub

    Private Sub btnEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        CST()
    End Sub

    Private Sub cboNfeCST_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNfeCST.EditValueChanged
        If strCST <> Me.cboNfeCST.Text Then
            LimparNFE(False)
            CST()
            strCST = Me.cboNfeCST.Text
        End If
    End Sub

    Private Sub btnSalvar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick
        If Validar(Me.lueCFOP) = False Then Exit Sub
        If Validar(Me.txtNfeNCM) = False Then Exit Sub
        If Validar(Me.cboOrigem) = False Then Exit Sub
        If Validar(Me.cboNfeCST) = False Then Exit Sub
        If Validar(Me.cboCSTPIS) = False Then Exit Sub
        If Validar(Me.cboCSTCOFINS) = False Then Exit Sub

        Dim strNFECST As String = Me.cboNfeCST.Text
        If Me.cboRegime.SelectedIndex = 0 Then
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 2)
            End If
        Else
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 3)
            End If
        End If

     
        Dim strOrig As String = Me.cboOrigem.Text
        If strOrig <> "" Then
            strOrig = strOrig.Substring(0, 1)
        End If
        Dim strModBC As String = Me.cboModBC.Text
        If strModBC <> "" Then
            strModBC = strModBC.Substring(0, 1)
        End If
        Dim strModBCST As String = Me.cboModBCST.Text
        If strModBCST <> "" Then
            strModBCST = strModBCST.Substring(0, 1)
        End If

        Dim strCstIPI As String = Me.cboCSTIPI.Text
        If strCstIPI <> "" Then
            strCstIPI = strCstIPI.Substring(0, 2)
        End If

        Dim strCstPIS As String = Me.cboCSTPIS.Text
        If strCstPIS <> "" Then
            strCstPIS = strCstPIS.Substring(0, 2)
        End If

        Dim strCstCOFINS As String = Me.cboCSTCOFINS.Text
        If strCstCOFINS <> "" Then
            strCstCOFINS = strCstCOFINS.Substring(0, 2)
        End If

        If Me.Tag = "PESQUISA" Then


            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colICMS, strNFECST)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colIPI, strCstIPI)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCodEnq, txtCodEnq.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colPIS, strCstPIS)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCOFINS, strCstCOFINS)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCFOP, Me.lueCFOP.EditValue)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colNCM, Me.txtNfeNCM.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaIPI, Me.txtAliquotaIPI.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaPIS, Me.txtAliquotaPIS.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaCOFINS, Me.txtAliquotaCOFINS.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colOrigem, strOrig)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colModBC, strModBC)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colModBCST, strModBCST)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRedBC, Me.txtRedBC.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRedBCST, Me.txtRedBCST.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colICMSST, Me.txtICMSST.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaICMS, Me.txtNfeICMS.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCalculoCred, Me.txtCalcCred.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRegime, Me.cboRegime.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCodigoANP, Me.cboCodigoANP.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colUFComb, Me.cboUF.Text)
            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colMVaST, Me.txtMVAST.Text)

            frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCest, Me.txtCest.Text)

            Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")
            If dtTrib.Rows.Count = 0 Then
                Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                "PerCOFINS, Regime) Values (" & strCodigoAut & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','" & strRegime & "')")
            Else
                Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPI & "', PerIPI = '" & Me.txtAliquotaIPI.Text & "', " & _
                "CodEnq = '" & Me.txtCodEnq.Text & "', CSTPIS = '" & strCstPIS & "', PerPIS = '" & Me.txtAliquotaPIS.Text & "', " & _
                "CSTCOFINS = '" & strCstCOFINS & "', PerCOFINS = '" & Me.txtAliquotaCOFINS.Text & "' where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")
            End If
            If strRegime.Contains("SIMPLES NACIONAL") Then
                If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                    Excluir("DELETE FROM Tributos where CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL'")
                Else
                    Excluir("DELETE FROM Tributos where CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL SAT'")
                End If
            Else
                If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                    Excluir("DELETE FROM Tributos where CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                Else
                    Excluir("DELETE FROM Tributos where CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                End If
            End If
      
    
            Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")
            If dtNfe.Rows.Count = 0 Then
                Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest) VALUES (" & _
                "" & strCodigoAut & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "','" & strNFECST & "'," & _
                "'" & strOrig & "','" & strModBC & "','" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "'," & _
                "'" & strModBCST & "','" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "'," & _
                "'" & Me.lueCFOP.EditValue & "','" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "'," & _
                "'" & strRegime & "','" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "'," & _
                "'" & Me.cboUF.Text & "','" & Me.txtCest.Text & "')")
            Else
                Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', Genero = '" & Me.txtGenero.Text & "', " & _
                "CST = '" & strNFECST & "', Origem = '" & strOrig & "', ModBC = '" & strModBC & "', " & _
                "ICMS = '" & Me.txtNfeICMS.Text.Trim & "', RedBC = '" & Me.txtRedBC.Text.Trim & "', " & _
                "ModBCST = '" & strModBCST & "', RedBCST = '" & Me.txtRedBCST.Text.Trim & "', " & _
                "MVaST = '" & Me.txtMVAST.Text.Trim & "', CFOP = '" & Me.lueCFOP.EditValue & "', " & _
                "ICMSST = '" & Me.txtICMSST.Text.Trim & "', NCM = '" & Me.txtNfeNCM.Text.Trim & "', " & _
                "Regime = '" & strRegime & "', CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', " & _
                "CodigoANP = '" & Me.cboCodigoANP.Text & "', UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "' where CodProd = " & strCodigoAut & " and Regime = '" & strRegime & "'")
            End If
            If strRegime.Contains("SIMPLES NACIONAL") Then
                If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                    Excluir("DELETE FROM Nfe where CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL'")
                Else
                    Excluir("DELETE FROM Nfe where CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & strCodigoAut & " and Regime = 'SIMPLES NACIONAL SAT'")
                End If
            Else
                If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                    Excluir("DELETE FROM Nfe where CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                Else
                    Excluir("DELETE FROM Nfe where CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & strCodigoAut & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                End If
            End If


        ElseIf Me.Tag = "ENTRADANF" Then
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCFOP, Me.lueCFOP.EditValue)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCST, strNFECST)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colOrigem, strOrig)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colModBC, strModBC)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colICMS, txtNfeICMS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRedBC, txtRedBC.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colModBCST, strModBCST)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRedBCST, txtRedBCST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colMVaST, txtMVAST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colIcmsST, txtICMSST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCalculoCred, txtCalcCred.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTIPI, strCstIPI)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCodEnq, txtCodEnq.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colPerIPI, txtAliquotaIPI.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTPIS, strCstPIS)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colPerPIS, txtAliquotaPIS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTCOFINS, strCstCOFINS)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colPerCOFINS, txtAliquotaCOFINS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCodigoANP, Me.cboCodigoANP.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colUFComb, Me.cboUF.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colNCM, Me.txtNfeNCM.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCest, Me.txtCest.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRegime, Me.cboRegime.Text)

        ElseIf Me.Tag = "ENTRADANFEnt" Then
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCFOPEnt, Me.lueCFOP.EditValue)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTEnt, strNFECST)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colOrigemEnt, strOrig)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colModBCEnt, strModBC)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colAliquotaICMSEnt, txtNfeICMS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRedBCEnt, txtRedBC.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colModBCSTEnt, strModBCST)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRedBCSTEnt, txtRedBCST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colMVaSTEnt, txtMVAST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colAliquotaICMSSTEnt, txtICMSST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCalculoCredEnt, txtCalcCred.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTIPIEnt, strCstIPI)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCodEnqEnt, txtCodEnq.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colAliquotaIPIEnt, txtAliquotaIPI.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTPISEnt, strCstPIS)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colAliquotaPISEnt, txtAliquotaPIS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCSTCOFINSEnt, strCstCOFINS)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colAliquotaCOFINSEnt, txtAliquotaCOFINS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCodigoANPEnt, Me.cboCodigoANP.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colUFCombEnt, Me.cboUF.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colNCMEnt, Me.txtNfeNCM.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValCOFINSEnt, Me.txtValCOFINS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValICMSEnt, Me.txtValICMS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValICMSSTEnt, Me.txtValICMSST.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValIPIEnt, Me.txtValIPI.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValPISEnt, Me.txtValPIS.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colValCredEnt, Me.txtValCred.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCodigoANPEnt, Me.cboCodigoANP.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colUFCombEnt, Me.cboUF.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colCest, Me.txtCest.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colRegime, Me.cboRegime.Text)

            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colVFCPSTEnt, Me.txtVFCPST.Text)

            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colFreteEnt, Me.txtFreteEnt.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colDespesasEnt, Me.txtDespesasEnt.Text)
            frmEntradaNF.grd1.SetRowCellValue(intIndex, frmEntradaNF.colSeguroEnt, Me.txtSeguroEnt.Text)
        End If


        Limpar()
        Me.Close()
    End Sub
    Private Sub btnTodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTodos.ItemClick
        If Validar(Me.lueCFOP) = False Then Exit Sub
        If Validar(Me.txtNfeNCM) = False Then Exit Sub
        If Validar(Me.cboOrigem) = False Then Exit Sub
        If Validar(Me.cboNfeCST) = False Then Exit Sub
        If Validar(Me.cboCSTPIS) = False Then Exit Sub
        If Validar(Me.cboCSTCOFINS) = False Then Exit Sub

        Dim strNFECST As String = Me.cboNfeCST.Text
        If Me.cboRegime.SelectedIndex = 0 Then
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 2)
            End If
        Else
            If strNFECST <> "" Then
                strNFECST = strNFECST.Substring(0, 3)
            End If
        End If


        Dim strOrig As String = Me.cboOrigem.Text
        If strOrig <> "" Then
            strOrig = strOrig.Substring(0, 1)
        End If
        Dim strModBC As String = Me.cboModBC.Text
        If strModBC <> "" Then
            strModBC = strModBC.Substring(0, 1)
        End If
        Dim strModBCST As String = Me.cboModBCST.Text
        If strModBCST <> "" Then
            strModBCST = strModBCST.Substring(0, 1)
        End If

        Dim strCstIPI As String = Me.cboCSTIPI.Text
        If strCstIPI <> "" Then
            strCstIPI = strCstIPI.Substring(0, 2)
        End If

        Dim strCstPIS As String = Me.cboCSTPIS.Text
        If strCstPIS <> "" Then
            strCstPIS = strCstPIS.Substring(0, 2)
        End If

        Dim strCstCOFINS As String = Me.cboCSTCOFINS.Text
        If strCstCOFINS <> "" Then
            strCstCOFINS = strCstCOFINS.Substring(0, 2)
        End If

        If MsgBox("Tem certeza que deseja inserir para todos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub


        Dim I As Integer
        If Me.Tag = "PESQUISA" Then
            Dim intGridCount As Integer = frmPesquisaImp.grd1.RowCount

            Dim bolNCM As Boolean = False
            If MsgBox("Deseja alterar o NCM de todos os produtos listados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                bolNCM = True
            End If

            For I = 0 To frmPesquisaImp.grd1.RowCount - 1
                Dim intIndex As Integer = intGridCount - (I + 1)

                Dim strCodProd As String = frmPesquisaImp.grd1.GetRowCellDisplayText(intIndex, frmPesquisaImp.colCodigo)

                Dim strCodProdInterno As String = frmPesquisaImp.grd1.GetRowCellDisplayText(intIndex, frmPesquisaImp.colCodProd)

                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colICMS, strNFECST)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colIPI, strCstIPI)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCodEnq, txtCodEnq.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colPIS, strCstPIS)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCOFINS, strCstCOFINS)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCFOP, Me.lueCFOP.EditValue)
                If bolNCM = True Then
                    frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colNCM, Me.txtNfeNCM.Text)
                End If
              

                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaIPI, Me.txtAliquotaIPI.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaPIS, Me.txtAliquotaPIS.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaCOFINS, Me.txtAliquotaCOFINS.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colOrigem, strOrig)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colModBC, strModBC)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colModBCST, strModBCST)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRedBC, Me.txtRedBC.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRedBCST, Me.txtRedBCST.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colICMSST, Me.txtICMSST.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colAliquotaICMS, Me.txtNfeICMS.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCalculoCred, Me.txtCalcCred.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colRegime, Me.cboRegime.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCodigoANP, Me.cboCodigoANP.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colUFComb, Me.cboUF.Text)
                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colMVaST, Me.txtMVAST.Text)

                frmPesquisaImp.grd1.SetRowCellValue(intIndex, frmPesquisaImp.colCest, Me.txtCest.Text)


                Dim inttt As Integer = frmPesquisaImp.grd1.RowCount
                Dim dtTrib As DataTable = CarregarDataTable("SELECT Codigo FROM Tributos where CodProd = " & strCodProd & " and Regime = '" & strRegime & "'")
                If dtTrib.Rows.Count = 0 Then
                    Inserir("INSERT INTO Tributos (CodProd, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPIS, CSTCOFINS, " & _
                    "PerCOFINS, Regime) Values (" & strCodProd & ",'" & strCstIPI & "','" & Me.txtAliquotaIPI.Text & "'," & _
                    "'" & Me.txtCodEnq.Text & "','" & strCstPIS & "','" & Me.txtAliquotaPIS.Text & "'," & _
                    "'" & strCstCOFINS & "','" & Me.txtAliquotaCOFINS.Text & "','" & strRegime & "')")
                Else
                    Atualizar("UPDATE Tributos SET CSTIPI = '" & strCstIPI & "', PerIPI = '" & Me.txtAliquotaIPI.Text & "', " & _
                    "CodEnq = '" & Me.txtCodEnq.Text & "', CSTPIS = '" & strCstPIS & "', PerPIS = '" & Me.txtAliquotaPIS.Text & "', " & _
                    "CSTCOFINS = '" & strCstCOFINS & "', PerCOFINS = '" & Me.txtAliquotaCOFINS.Text & "' where CodProd = " & strCodProd & " and Regime = '" & strRegime & "'")
                End If
                If strRegime.Contains("SIMPLES NACIONAL") Then
                    If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                        Excluir("DELETE FROM Tributos where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL'")
                    Else
                        Excluir("DELETE FROM Tributos where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL SAT'")
                    End If
                Else
                    If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                        Excluir("DELETE FROM Tributos where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                    Else
                        Excluir("DELETE FROM Tributos where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                    End If
                End If
            

                Dim dtNfe As DataTable = CarregarDataTable("SELECT Codigo FROM Nfe where CodProd = " & strCodProd & " and Regime = '" & strRegime & "'")
                If dtNfe.Rows.Count = 0 Then
                    If bolNCM = True Then
                        Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                     "ModBCST, RedBCST, MVaST, CFOP, ICMSST, NCM, Regime, CalculoCred, CodigoANP, UFComb, Cest) VALUES (" & _
                                     "" & strCodProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "','" & strNFECST & "'," & _
                                     "'" & strOrig & "','" & strModBC & "','" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "'," & _
                                     "'" & strModBCST & "','" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "'," & _
                                     "'" & Me.lueCFOP.EditValue & "','" & Me.txtICMSST.Text.Trim & "','" & Me.txtNfeNCM.Text.Trim & "'," & _
                                     "'" & strRegime & "','" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "'," & _
                                     "'" & Me.cboUF.Text & "','" & Me.txtCest.Text & "')")
                    Else
                        Dim dtNCM As DataTable = CarregarDataTable("SELECT  NCM  FROM Nfe where CodProd = " & strCodProd)
                        Dim strNCM As String = ""
                        If dtNCM.Rows.Count > 0 Then
                            strNCM = dtNCM.Rows.Item(0).Item("NCM").ToString
                        End If
                        Inserir("INSERT INTO Nfe (CodProd, EXTIPI, Genero, CST, Origem, ModBC, ICMS, RedBC, " & _
                                     "ModBCST, RedBCST, MVaST, CFOP, ICMSST, Regime, CalculoCred, CodigoANP, UFComb, Cest, NCM) VALUES (" & _
                                     "" & strCodProd & ",'" & Me.txtEXTIPI.Text & "','" & Me.txtGenero.Text & "','" & strNFECST & "'," & _
                                     "'" & strOrig & "','" & strModBC & "','" & Me.txtNfeICMS.Text.Trim & "','" & Me.txtRedBC.Text.Trim & "'," & _
                                     "'" & strModBCST & "','" & Me.txtRedBCST.Text.Trim & "','" & Me.txtMVAST.Text.Trim & "'," & _
                                     "'" & Me.lueCFOP.EditValue & "','" & Me.txtICMSST.Text.Trim & "'," & _
                                     "'" & strRegime & "','" & Me.txtCalcCred.Text.Trim & "','" & Me.cboCodigoANP.Text & "'," & _
                                     "'" & Me.cboUF.Text & "','" & Me.txtCest.Text & "','" & strNCM & "')")
                    End If
                    If strRegime.Contains("SIMPLES NACIONAL") Then
                        If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL'")
                        Else
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End If
                    Else
                        If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                        Else
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End If
                    End If
         

                Else
                    If bolNCM = True Then
                        Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', Genero = '" & Me.txtGenero.Text & "', " & _
                        "CST = '" & strNFECST & "', Origem = '" & strOrig & "', ModBC = '" & strModBC & "', " & _
                        "ICMS = '" & Me.txtNfeICMS.Text.Trim & "', RedBC = '" & Me.txtRedBC.Text.Trim & "', " & _
                        "ModBCST = '" & strModBCST & "', RedBCST = '" & Me.txtRedBCST.Text.Trim & "', " & _
                        "MVaST = '" & Me.txtMVAST.Text.Trim & "', CFOP = '" & Me.lueCFOP.EditValue & "', " & _
                        "ICMSST = '" & Me.txtICMSST.Text.Trim & "', NCM = '" & Me.txtNfeNCM.Text.Trim & "', " & _
                        "Regime = '" & strRegime & "', CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', " & _
                        "CodigoANP = '" & Me.cboCodigoANP.Text & "', UFComb = '" & Me.cboUF.Text & "', Cest = '" & Me.txtCest.Text & "' where CodProd = " & strCodProd & " and Regime = '" & strRegime & "'")

                    Else
                        Dim dtNCM As DataTable = CarregarDataTable("SELECT  NCM  FROM Nfe where CodProd = " & strCodProd)
                        Dim strNCM As String = ""
                        If dtNCM.Rows.Count > 0 Then
                            strNCM = dtNCM.Rows.Item(0).Item("NCM").ToString
                        End If
                        Atualizar("UPDATE Nfe SET EXTIPI = '" & Me.txtEXTIPI.Text & "', Genero = '" & Me.txtGenero.Text & "', " & _
                        "CST = '" & strNFECST & "', Origem = '" & strOrig & "', ModBC = '" & strModBC & "', " & _
                        "ICMS = '" & Me.txtNfeICMS.Text.Trim & "', RedBC = '" & Me.txtRedBC.Text.Trim & "', " & _
                        "ModBCST = '" & strModBCST & "', RedBCST = '" & Me.txtRedBCST.Text.Trim & "', " & _
                        "MVaST = '" & Me.txtMVAST.Text.Trim & "', CFOP = '" & Me.lueCFOP.EditValue & "', " & _
                        "ICMSST = '" & Me.txtICMSST.Text.Trim & "', " & _
                        "Regime = '" & strRegime & "', CalculoCred = '" & Me.txtCalcCred.Text.Trim & "', " & _
                        "CodigoANP = '" & Me.cboCodigoANP.Text & "', UFComb = '" & Me.cboUF.Text & "', " & _
                        "Cest = '" & Me.txtCest.Text & "', NCM = '" & strNCM & "' where CodProd = " & strCodProd & " and Regime = '" & strRegime & "'")

                    End If
                    If strRegime.Contains("SIMPLES NACIONAL") Then
                        If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL'")
                        Else
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL NFE' or CodProd = " & strCodProd & " and Regime = 'SIMPLES NACIONAL SAT'")
                        End If
                    Else
                        If strRegime.Contains("NFE") = True Or strRegime.Contains("SAT") Then
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL'")
                        Else
                            Excluir("DELETE FROM Nfe where CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL NFE' or CodProd = " & strCodProd & " and Regime = 'TRIBUTAÇÃO NORMAL SAT'")
                        End If
                    End If

                End If
            Next

            Dim index As Integer = -999997
            frmPesquisaImp.grd1.FocusedRowHandle = index
            frmPesquisaImp.grd1.FocusedColumn = frmPesquisaImp.colProduto
            frmPesquisaImp.grd1.ShowEditor()

        ElseIf Me.Tag = "ENTRADANF" Then
            Dim bolNCM As Boolean = False
            If MsgBox("Deseja alterar o NCM de todos os produtos listados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                bolNCM = True
            End If

            For I = 0 To frmEntradaNF.grd1.RowCount - 1
                
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCFOP, Me.lueCFOP.EditValue)

                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCST, strNFECST)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRegime, Me.cboRegime.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colOrigem, strOrig)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colModBC, strModBC)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colICMS, txtNfeICMS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRedBC, txtRedBC.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colModBCST, strModBCST)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRedBCST, txtRedBCST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colMVaST, txtMVAST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colIcmsST, txtICMSST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCalculoCred, txtCalcCred.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTIPI, strCstIPI)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCodEnq, txtCodEnq.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colPerIPI, txtAliquotaIPI.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTPIS, strCstPIS)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colPerPIS, txtAliquotaPIS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTCOFINS, strCstCOFINS)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colPerCOFINS, txtAliquotaCOFINS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCodigoANP, Me.cboCodigoANP.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colUFComb, Me.cboUF.Text)
                If bolNCM = True Then
                    frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colNCM, Me.txtNfeNCM.Text)
                End If

                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCest, Me.txtCest.Text)
            Next

        ElseIf Me.Tag = "ENTRADANFEnt" Then

            For I = 0 To frmEntradaNF.grd1.RowCount - 1

                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCFOPEnt, Me.lueCFOP.EditValue)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTEnt, strNFECST)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colOrigemEnt, strOrig)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colModBCEnt, strModBC)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colAliquotaICMSEnt, txtNfeICMS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRedBCEnt, txtRedBC.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colModBCSTEnt, strModBCST)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRedBCSTEnt, txtRedBCST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colMVaSTEnt, txtMVAST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colAliquotaICMSSTEnt, txtICMSST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCalculoCredEnt, txtCalcCred.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTIPIEnt, strCstIPI)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCodEnqEnt, txtCodEnq.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colAliquotaIPIEnt, txtAliquotaIPI.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTPISEnt, strCstPIS)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colAliquotaPISEnt, txtAliquotaPIS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCSTCOFINSEnt, strCstCOFINS)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colAliquotaCOFINSEnt, txtAliquotaCOFINS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCodigoANPEnt, Me.cboCodigoANP.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colUFCombEnt, Me.cboUF.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colNCMEnt, Me.txtNfeNCM.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValCOFINSEnt, Me.txtValCOFINS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValICMSEnt, Me.txtValICMS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValICMSSTEnt, Me.txtValICMSST.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValIPIEnt, Me.txtValIPI.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValPISEnt, Me.txtValPIS.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colValCredEnt, Me.txtValCred.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colCest, Me.txtCest.Text)
                frmEntradaNF.grd1.SetRowCellValue(I, frmEntradaNF.colRegime, Me.cboRegime.Text)
            Next

        End If

        Limpar()
        Me.Close()
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

    Private Sub lueCFOP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueCFOP.EditValueChanged
        CFOPCombustivel()

    End Sub
    Private Sub CFOPCombustivel()
        Combustivel(False)
        Dim strCFOP As String = ""
        If Me.lueCFOP.EditValue Is DBNull.Value = False Then

            strCFOP = Me.lueCFOP.EditValue
        End If

        If strCFOP <> "Nothing" And strCFOP <> "" Then
            Dim intCFOP As Integer = Me.lueCFOP.EditValue


            If intCFOP >= 1651 And intCFOP <= 1664 Then

                Combustivel(True)
            ElseIf intCFOP >= 2651 And intCFOP <= 2664 Then
                Combustivel(True)

            ElseIf intCFOP >= 3651 And intCFOP <= 3653 Then
                Combustivel(True)

            ElseIf intCFOP >= 5651 And intCFOP <= 5667 Then
                Combustivel(True)
            ElseIf intCFOP >= 6651 And intCFOP <= 6667 Then
                Combustivel(True)
            ElseIf intCFOP >= 7651 And intCFOP <= 7667 Then
                Combustivel(True)
            Else
                Combustivel(False)
            End If
        End If
    End Sub
    Private Sub Combustivel(ByVal parCombustivel As Boolean)
        If parCombustivel = True Then
            Me.cboCodigoANP.Text = ""
            Me.cboUF.Text = "SP"
            Me.cboCodigoANP.Enabled = True
            Me.cboUF.Enabled = True
        Else
            Me.cboCodigoANP.Text = ""
            Me.cboUF.Text = "SP"
            Me.cboCodigoANP.Enabled = False
            Me.cboUF.Enabled = False
        End If
    End Sub

    Private Sub cboRegime_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRegime.SelectedIndexChanged
      
        Regime(Me.cboRegime.Text)
    End Sub

    
    Private Sub txtNfeNCM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNfeNCM.Leave
        If Me.txtNfeNCM.Text = "" Then Exit Sub

        Dim strNCM As String = Me.txtNfeNCM.Text
        If strNCM.Length = 1 Then
            MsgBox("O campo NCM só aceita de 2 a 8 caracteres!", MsgBoxStyle.Information)
            Me.txtNfeNCM.ResetText()
            Me.txtNfeNCM.Focus()
        End If

        If Me.txtNfeNCM.Text <> "" Then
            Dim dtTributos As DataTable = CarregarDataTable("Select CFOP, Nfe.Regime, CST, Origem, RedBC, ModBC, RedBCST, " & _
            " ModBCST, MVaST, ICMSST, CalculoCred, CodigoANP, UFComb, Cest, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPis, " & _
            " CSTCOFINS, PerCOFINS, ICMS From Nfe left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
            " Where NCM ='" & Me.txtNfeNCM.Text.Trim & "' and Nfe.Regime = '" & strRegime & "' And CFOP <> '' And CST <> '' And Origem <> '' " & _
            " And CSTPIS <> '' And CSTCOFINS <> '' " & _
            " Group by CFOP, Nfe.Regime, CST, Origem, CSTIPI, PerIPI, CodEnq, CSTPIS, PerPis, CSTCOFINS, " & _
            " PerCOFINS, RedBC, ModBC, RedBCST, ModBCST, MVaST, ICMSST, CalculoCred, CodigoANP, UFComb, Cest, ICMS, Nfe.CodProd order by Nfe.CodProd")

            If dtTributos.Rows.Count > 0 Then

                If dtTributos.Rows.Item(0).Item("Regime").ToString.Contains("SIMPLES NACIONAL") Then
                    cboRegime.SelectedIndex = 1

                Else
                    cboRegime.SelectedIndex = 0

                End If
              
                lueCFOP.EditValue = dtTributos.Rows.Item(0).Item("CFOP").ToString
                txtICMSST.Text = dtTributos.Rows.Item(0).Item("CST").ToString
                txtAliquotaIPI.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString
                txtAliquotaPIS.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString
                txtAliquotaCOFINS.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                If dtTributos.Rows.Item(0).Item("CST").ToString <> "" Then
                    SelecionarCombo(cboNfeCST, dtTributos.Rows.Item(0).Item("CST").ToString)

                End If
                If dtTributos.Rows.Item(0).Item("Origem").ToString <> "" Then
                    SelecionarCombo(cboOrigem, dtTributos.Rows.Item(0).Item("Origem").ToString)

                End If
                If dtTributos.Rows.Item(0).Item("ModBC").ToString <> "" Then
                    SelecionarCombo(cboModBC, dtTributos.Rows.Item(0).Item("ModBC").ToString)

                End If

                txtRedBC.Text = dtTributos.Rows.Item(0).Item("RedBC").ToString
                If dtTributos.Rows.Item(0).Item("ModBCST").ToString <> "" Then
                    SelecionarCombo(cboModBCST, dtTributos.Rows.Item(0).Item("ModBCST").ToString)
                End If

                txtRedBCST.Text = dtTributos.Rows.Item(0).Item("RedBCST").ToString
                txtMVAST.Text = dtTributos.Rows.Item(0).Item("MVaST").ToString
                txtICMSST.Text = dtTributos.Rows.Item(0).Item("ICMSST").ToString
                txtCalcCred.Text = dtTributos.Rows.Item(0).Item("CalculoCred").ToString

                If dtTributos.Rows.Item(0).Item("CSTIPI").ToString <> "" Then
                    SelecionarCombo(cboCSTIPI, dtTributos.Rows.Item(0).Item("CSTIPI").ToString)
                End If
                txtCodEnq.Text = dtTributos.Rows.Item(0).Item("CodEnq").ToString
                txtAliquotaIPI.Text = dtTributos.Rows.Item(0).Item("PerIPI").ToString


                If dtTributos.Rows.Item(0).Item("CSTPIS").ToString <> "" Then
                    SelecionarCombo(cboCSTPIS, dtTributos.Rows.Item(0).Item("CSTPIS").ToString)
                End If
                txtAliquotaPIS.Text = dtTributos.Rows.Item(0).Item("PerPis").ToString


                If dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString <> "" Then
                    SelecionarCombo(cboCSTCOFINS, dtTributos.Rows.Item(0).Item("CSTCOFINS").ToString)

                End If
                txtAliquotaCOFINS.Text = dtTributos.Rows.Item(0).Item("PerCOFINS").ToString


                txtNfeICMS.Text = dtTributos.Rows.Item(0).Item("ICMS").ToString
                cboCodigoANP.Text = dtTributos.Rows.Item(0).Item("CodigoANP").ToString
                cboUF.Text = dtTributos.Rows.Item(0).Item("UFComb").ToString
                txtCest.Text = dtTributos.Rows.Item(0).Item("Cest").ToString

            End If
        End If


    End Sub

 
End Class