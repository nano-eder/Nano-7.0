Imports Nano.clsFuncoes
Public Class frmPesquisaImp
    Dim strRegimeNFe As String
    Dim strTipoFiscal As String = ""

    Private Sub frmPesquisaImp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TipoFiscal = "AMBOS" Then
            Me.cboTipoFiscal.Enabled = True
        Else
            Me.cboTipoFiscal.Enabled = False
        End If



        If Me.Tag = "PESQUISA" Then
            Me.rgpDados.Enabled = False
            Me.btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.cboTipoFiscal.Text = "AMBOS"
            strTipoFiscal = ""
            If RegimeSAT <> "" Then
                If RegimeSAT = "SIMPLES NACIONAL" Then
                    Me.rdgRegime.SelectedIndex = 0
                Else
                    Me.rdgRegime.SelectedIndex = 1
                End If


            End If
        ElseIf Me.Tag = "CUPOM" Then
            Me.rgpDados.Enabled = False
            Me.btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.rgpDados.Properties.Items.Item(0).Description = "TRIBUTAÇÃO"
            Me.rgpDados.Properties.Items.Item(1).Description = "ALÍQUOTA"
            Me.rgpDados.Properties.Items.Item(2).Description = "NCM"
            Me.rgpDados.Properties.Items.RemoveAt(6)
            Me.rgpDados.Properties.Items.RemoveAt(5)
            Me.rgpDados.Properties.Items.RemoveAt(4)
            Me.rgpDados.Properties.Items.RemoveAt(3)

            Me.colCFOP.Caption = "Tributação"

            Me.colRegime.Visible = False
            Me.colAliquotaCOFINS.Visible = False
            Me.colAliquotaIPI.Visible = False
            Me.colAliquotaPIS.Visible = False
            Me.colCalculoCred.Visible = False
            Me.colCodEnq.Visible = False
            Me.colCodigoANP.Visible = False
            Me.colCOFINS.Visible = False
            Me.colICMSST.Visible = False
            Me.colIPI.Visible = False
            Me.colModBC.Visible = False
            Me.colModBCST.Visible = False
            Me.colMVaST.Visible = False
            Me.colPIS.Visible = False
            Me.colRedBC.Visible = False
            Me.colRedBCST.Visible = False
            Me.colUFComb.Visible = False
            Me.colICMS.Visible = False
            Me.colOrigem.Visible = False

            Me.grd1.OptionsView.ColumnAutoWidth = True
            Me.colCodProd.VisibleIndex = 0
            Me.colProduto.VisibleIndex = 1
            Me.colCFOP.VisibleIndex = 2
            Me.colAliquotaICMS.VisibleIndex = 3
            Me.colNCM.VisibleIndex = 4
            Me.cboTipoFiscal.Visible = False
            Me.LabelControl96.Visible = False
        Else
            If RegimeSAT <> "" Then
                If RegimeSAT = "SIMPLES NACIONAL" Then
                    Me.rdgRegime.SelectedIndex = 0
                Else
                    Me.rdgRegime.SelectedIndex = 1
                End If
            End If
            If Me.cboTipoFiscal.Text = "AMBOS" Then
                strTipoFiscal = ""
            Else
                strTipoFiscal = " " & Me.cboTipoFiscal.Text
            End If

            Me.btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            CarregarGrid()

            Me.grd1.OptionsView.ShowGroupPanel = False
            Me.BarSubItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Me.GroupControl1.Dock = DockStyle.Fill
            'Me.Controls.Add(Me.GroupControl2)
            'Me.colCodProd.Visible = False
            'Me.colProduto.Visible = False
            'Me.GroupControl1.Visible = False

            'Me.LabelControl1.Visible = False
            'Me.lblPesquisa.Visible = False
            'Me.PanelControl1.Visible = False
            'Me.pnlPesquisa.Visible = False
            'Me.btnPesquisar.Visible = False

            'Me.colRegime.Visible = True
            'Me.colRedBCST.Visible = True
            'Me.colRedBC.Visible = True
            'Me.colOrigem.Visible = True
            'Me.colMVaST.Visible = True
            'Me.colModBCST.Visible = True
            'Me.colModBC.Visible = True
            'Me.colICMSST.Visible = True
            'Me.colCalculoCred.Visible = True
            'Me.colCodigoANP.Visible = NanoNfe
            'Me.colUFComb.Visible = NanoNfe

            'CarregarDados("SELECT sum(Nfe.Codigo), Nfe.CFOP, Nfe.NCM, Nfe.CST as ICMS, Nfe.Genero, Nfe.Origem, " & _
            '"Nfe.ModBC, Nfe.ICMS as AliquotaICMS, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, " & _
            '"Nfe.Regime, Nfe.CalculoCred, Tributos.CSTIPI as IPI, Tributos.PerIPI as AliquotaIPI, Tributos.CodEnq, " & _
            '"Tributos.CSTPIS as PIS, Tributos.PerPIS as AliquotaPIS, Tributos.CSTCOFINS as COFINS, " & _
            '"Tributos.PerCOFINS as AliquotaCOFINS, CodigoANP, UFComb FROM Nfe left join Tributos on " & _
            '"Nfe.CodProd = Tributos.CodProd GROUP BY Nfe.CFOP, Nfe.NCM, Nfe.CST, Nfe.Genero, Nfe.Origem, Nfe.ModBC, " & _
            '"Nfe.ICMS, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, Nfe.CalculoCred, " & _
            '"Tributos.CSTIPI, Tributos.PerIPI, Tributos.CodEnq, Tributos.CSTPIS, Tributos.PerPIS, Tributos.CSTCOFINS, " & _
            '"Tributos.PerCOFINS, CodigoANP, UFComb", Me.GridControl1)

            'Condition()

            'Dim index As Integer = -999997
            'grd1.FocusedRowHandle = index
            'grd1.FocusedColumn = Me.colCFOP
            'grd1.ShowEditor()

        End If

        Timer1.Start()
    End Sub

    Private Sub rgpTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgpTipo.SelectedIndexChanged
        Select Case Me.rgpTipo.SelectedIndex
            Case 0
                Me.rgpDados.SelectedIndex = 0
                Me.rgpDados.Enabled = False
            Case Else
                Me.rgpDados.Enabled = True
        End Select
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        If Me.Tag = "PESQUISA" Then
            CarregarGrid()
        Else
            CarregarGridCupom()
        End If

    End Sub

    Private Sub CarregarGrid()
        Dim strPesquisa As String = ""
        Dim strTipo As String = ""
        Dim strNull As String = ""
        strRegimeNFe = "SIMPLES NACIONAL"
        If Me.rdgRegime.SelectedIndex = 1 Then
            strRegimeNFe = "TRIBUTAÇÃO NORMAL"
        End If
        Dim bolTributosVazio As Boolean = False
        If Me.rgpTipo.SelectedIndex > 0 Then
            If Me.rgpTipo.SelectedIndex = 1 Then
                strTipo = "= ''"
                strNull = "is null"
            Else
                strTipo = "<> ''"
                strNull = "<> ''"
            End If
            'Select Case Me.rgpDados.SelectedIndex
            '    Case 0
            '        strPesquisa = " and Nfe.CFOP " & strTipo & " or Nfe.CFOP " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 1
            '        strPesquisa = " and Nfe.NCM " & strTipo & " or Nfe.NCM " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 2
            '        strPesquisa = " and Nfe.CST " & strTipo & " or Nfe.CST " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 3
            '        strPesquisa = " and Tributos.CSTIPI " & strTipo & " or Tributos.CSTIPI " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 4
            '        strPesquisa = " and Tributos.CodEnq " & strTipo & " or Tributos.CodEnq " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 5
            '        strPesquisa = " and Tributos.CSTPIS " & strTipo & " or Tributos.CSTPIS " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            '    Case 6
            '        strPesquisa = " and Tributos.CSTCOFINS " & strTipo & " or Tributos.CSTCOFINS " & strNull & " and Nfe.Regime = '" & strRegimeNFe & "'"
            'End Select
            Select Case Me.rgpDados.SelectedIndex
                Case 0
                    strPesquisa = " and Nfe.CFOP " & strTipo
                Case 1
                    strPesquisa = " and Nfe.NCM " & strTipo
                Case 2
                    strPesquisa = " and Nfe.CST " & strTipo
                Case 3
                    strPesquisa = " and Tributos.CSTIPI " & strTipo
                    bolTributosVazio = True
                Case 4
                    strPesquisa = " and Tributos.CodEnq " & strTipo
                    bolTributosVazio = True
                Case 5
                    strPesquisa = " and Tributos.CSTPIS " & strTipo
                    bolTributosVazio = True
                Case 6
                    strPesquisa = " and Tributos.CSTCOFINS " & strTipo
                    bolTributosVazio = True
            End Select
        End If

        strTipoFiscal = ""
        If Me.cboTipoFiscal.Visible = True Then
            Select Case Me.cboTipoFiscal.Text
                Case "NFE"
                    strTipoFiscal = " NFE"
                Case "SAT"
                    strTipoFiscal = " SAT"
            End Select
        End If

        'Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
        '"Produto.Nome as Produto,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI as IPI, Tributos.CodEnq, " & _
        '"Tributos.CSTPIS as PIS, Tributos.CSTCOFINS as COFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, Nfe.Origem, " & _
        '"Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, Nfe.CalculoCred, " & _
        '"Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest FROM (Produto left join Nfe on Produto.Codigo = Nfe.CodProd) " & _
        '"left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime where Nfe.Regime = '" & strRegimeNFe & "'" & strPesquisa)
        Dim dtProd As DataTable = Nothing
        If Me.rgpTipo.SelectedIndex = 2 Then
            dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
            "Produto.Nome as Produto,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI as IPI, Tributos.CodEnq, " & _
            "Tributos.CSTPIS as PIS, Tributos.CSTCOFINS as COFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, " & _
            "Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, " & _
            "Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest FROM (Produto left join Nfe on Produto.Codigo = " & _
            "Nfe.CodProd) left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
            "where Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "'" & strPesquisa & " And Produto.Inativo=0 group by Produto.Codigo, Produto.CodigoInterno, " & _
            "Produto.Nome,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI, Tributos.CodEnq, Tributos.CSTPIS, " & _
            "Tributos.CSTCOFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, " & _
            "Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest")
        Else
            If bolTributosVazio = False Then
                dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
                "Produto.Nome as Produto,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI as IPI, Tributos.CodEnq, " & _
                "Tributos.CSTPIS as PIS, Tributos.CSTCOFINS as COFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, " & _
                "Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, " & _
                "Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest FROM (Produto left join Nfe on Produto.Codigo = " & _
                "Nfe.CodProd) left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
                "where Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "'" & strPesquisa & " And Produto.Inativo=0 group by Produto.Codigo, Produto.CodigoInterno, " & _
                "Produto.Nome,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI, Tributos.CodEnq, Tributos.CSTPIS, " & _
                "Tributos.CSTCOFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, " & _
                "Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest " & _
                "UNION SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, Produto.Nome as Produto,'' as CST, " & _
                "'' as CFOP, '' as NCM, '' as IPI, '' as CodEnq, '' as PIS, '' as COFINS, '' as PerIPI, '' as PerPIS, " & _
                "'' as PerCOFINS, '' as ICMS, '' as Origem, '' as ModBC, '' as RedBC, '' as ModBCST, '' as RedBCST, " & _
                "'' as MVaST, '' as ICMSST, '' as Regime, '' as CalculoCred, '' as CodigoANP, '' as UFComb, '' as Cest " & _
                "FROM Produto where Not Exists (SELECT Nfe.Codigo FROM Nfe where Nfe.CodProd = Produto.Codigo and " & _
                "Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "')")
            Else
                dtProd = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
                "Produto.Nome as Produto,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI as IPI, Tributos.CodEnq, " & _
                "Tributos.CSTPIS as PIS, Tributos.CSTCOFINS as COFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, " & _
                "Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, " & _
                "Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest FROM (Produto left join Nfe on Produto.Codigo = " & _
                "Nfe.CodProd) left join Tributos on Nfe.CodProd = Tributos.CodProd and Nfe.Regime = Tributos.Regime " & _
                "where Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "'" & strPesquisa & " And Produto.Inativo=0 group by Produto.Codigo, Produto.CodigoInterno, " & _
                "Produto.Nome,Nfe.CST, Nfe.CFOP, Nfe.NCM, Tributos.CSTIPI, Tributos.CodEnq, Tributos.CSTPIS, " & _
                "Tributos.CSTCOFINS, PerIPI, PerPIS, PerCOFINS, Nfe.ICMS, Nfe.Origem, Nfe.ModBC, Nfe.RedBC, Nfe.ModBCST, " & _
                "Nfe.RedBCST, Nfe.MVaST, Nfe.ICMSST, Nfe.Regime, Nfe.CalculoCred, Nfe.CodigoANP, Nfe.UFComb, Nfe.Cest " & _
                "UNION SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, Produto.Nome as Produto,'' as CST, " & _
                "'' as CFOP, '' as NCM, '' as IPI, '' as CodEnq, '' as PIS, '' as COFINS, '' as PerIPI, '' as PerPIS, " & _
                "'' as PerCOFINS, '' as ICMS, '' as Origem, '' as ModBC, '' as RedBC, '' as ModBCST, '' as RedBCST, " & _
                "'' as MVaST, '' as ICMSST, '' as Regime, '' as CalculoCred, '' as CodigoANP, '' as UFComb, '' as Cest " & _
                "FROM Produto where Not Exists (SELECT Nfe.Codigo FROM Nfe where Nfe.CodProd = Produto.Codigo and " & _
                "Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "')UNION SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
                "Produto.Nome as Produto,'' as CST, '' as CFOP, '' as NCM, '' as IPI, '' as CodEnq, '' as PIS, '' as COFINS, " & _
                "'' as PerIPI, '' as PerPIS, '' as PerCOFINS, '' as ICMS, '' as Origem, '' as ModBC, '' as RedBC, '' as ModBCST, " & _
                "'' as RedBCST, '' as MVaST, '' as ICMSST, '' as Regime, '' as CalculoCred, '' as CodigoANP, '' as UFComb, " & _
                "'' as Cest FROM Produto where Not Exists (SELECT tributos.Codigo FROM tributos left join Nfe  on " & _
                "tributos.codprod = nfe.codprod and tributos.Regime =Nfe.Regime  where tributos.CodProd = Produto.Codigo " & _
                "and Nfe.Regime = '" & strRegimeNFe & strTipoFiscal & "')")
            End If

        End If


        Me.tbProd.Rows.Clear()
        Dim I As Integer
        With Me.tbProd.Rows
            For I = 0 To dtProd.Rows.Count - 1
                .Add()
                .Item(I).Item("CodProd") = dtProd.Rows.Item(I).Item("CodProd").ToString
                .Item(I).Item("Produto") = dtProd.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("CFOP") = dtProd.Rows.Item(I).Item("CFOP").ToString
                .Item(I).Item("NCM") = dtProd.Rows.Item(I).Item("NCM").ToString
                .Item(I).Item("CST") = dtProd.Rows.Item(I).Item("CST").ToString
                .Item(I).Item("IPI") = dtProd.Rows.Item(I).Item("IPI").ToString
                .Item(I).Item("PIS") = dtProd.Rows.Item(I).Item("PIS").ToString
                .Item(I).Item("COFINS") = dtProd.Rows.Item(I).Item("COFINS").ToString
                .Item(I).Item("CodEnq") = dtProd.Rows.Item(I).Item("CodEnq").ToString

                .Item(I).Item("AliquotaICMS") = dtProd.Rows.Item(I).Item("ICMS").ToString
                .Item(I).Item("AliquotaIPI") = dtProd.Rows.Item(I).Item("PerIPI").ToString
                .Item(I).Item("AliquotaPIS") = dtProd.Rows.Item(I).Item("PerPIS").ToString
                .Item(I).Item("AliquotaCOFINS") = dtProd.Rows.Item(I).Item("PerCOFINS").ToString

                .Item(I).Item("Origem") = dtProd.Rows.Item(I).Item("Origem").ToString
                .Item(I).Item("ModBC") = dtProd.Rows.Item(I).Item("ModBC").ToString
                .Item(I).Item("ModBCST") = dtProd.Rows.Item(I).Item("ModBCST").ToString
                .Item(I).Item("RedBCST") = dtProd.Rows.Item(I).Item("RedBCST").ToString
                .Item(I).Item("ICMSST") = dtProd.Rows.Item(I).Item("ICMSST").ToString
                .Item(I).Item("Regime") = dtProd.Rows.Item(I).Item("Regime").ToString
                .Item(I).Item("CalculoCred") = dtProd.Rows.Item(I).Item("CalculoCred").ToString
                .Item(I).Item("CodigoANP") = dtProd.Rows.Item(I).Item("CodigoANP").ToString
                .Item(I).Item("UFComb") = dtProd.Rows.Item(I).Item("UFComb").ToString

                .Item(I).Item("Codigo") = dtProd.Rows.Item(I).Item("Codigo").ToString
                .Item(I).Item("Cest") = dtProd.Rows.Item(I).Item("Cest").ToString
            Next
        End With

    End Sub

    Private Sub CarregarGridCupom()
        Dim strPesquisa As String = ""
        Dim strTipo As String = ""
        Dim strNull As String = ""
        If Me.rgpTipo.SelectedIndex > 0 Then
            If Me.rgpTipo.SelectedIndex = 1 Then
                strTipo = "= ''"
                strNull = "is null"
            Else
                strTipo = "<> ''"
                strNull = "<> ''"
            End If
            Select Case Me.rgpDados.SelectedIndex
                Case 0
                    strPesquisa = " where Tributacao " & strTipo & " or Tributacao " & strNull
                Case 1
                    strPesquisa = " where ICMS = 0 or ICMS " & strNull
                Case 2
                    strPesquisa = " where NCM " & strTipo & " or NCM " & strNull
            
            End Select
        End If

        Dim dtProd As DataTable = CarregarDataTable("SELECT Produto.Codigo, Produto.CodigoInterno as CodProd, " & _
        "Produto.Nome as Produto,ImpostoProduto.CST, ImpostoProduto.Tributacao as CFOP, ImpostoProduto.NCM, " & _
        "ImpostoProduto.ICMS, ImpostoProduto.OrigemIcms as Origem FROM Produto left join ImpostoProduto " & _
        "on Produto.Codigo = ImpostoProduto.CodProd" & strPesquisa)
        Me.tbProd.Rows.Clear()
        Dim I As Integer
        With Me.tbProd.Rows
            For I = 0 To dtProd.Rows.Count - 1
                .Add()
                .Item(I).Item("CodProd") = dtProd.Rows.Item(I).Item("CodProd").ToString
                .Item(I).Item("Produto") = dtProd.Rows.Item(I).Item("Produto").ToString
                .Item(I).Item("CFOP") = dtProd.Rows.Item(I).Item("CFOP").ToString
                .Item(I).Item("NCM") = dtProd.Rows.Item(I).Item("NCM").ToString
                .Item(I).Item("AliquotaICMS") = dtProd.Rows.Item(I).Item("ICMS").ToString
                .Item(I).Item("Codigo") = dtProd.Rows.Item(I).Item("Codigo").ToString
            Next

        End With

    End Sub
    Private Sub btnFechar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFechar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnVisualizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVisualizar.ItemClick
        Dim rel As New relPesquisaImp
        rel.lblTitulo.Text = Me.Text.Replace("Consulta", "Relatório")
        rel.lblQtd.Text = Me.lblQtd.Text.Replace("Nº de Registros : ", "")
        rel.picLogo.Image = LogoTipo
        Dim I As Integer
        Dim A As Integer = 0
        With rel.tbProd.Rows
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    .Add()
                    .Item(A).Item("CodProd") = Me.grd1.GetRowCellDisplayText(I, Me.colCodProd)
                    .Item(A).Item("Produto") = Me.grd1.GetRowCellDisplayText(I, Me.colProduto)
                    .Item(A).Item("CFOP") = Me.grd1.GetRowCellDisplayText(I, Me.colCFOP)
                    .Item(A).Item("NCM") = Me.grd1.GetRowCellDisplayText(I, Me.colNCM)
                    .Item(A).Item("ICMS") = Me.grd1.GetRowCellDisplayText(I, Me.colICMS)
                    .Item(A).Item("IPI") = Me.grd1.GetRowCellDisplayText(I, Me.colIPI)
                    .Item(A).Item("PIS") = Me.grd1.GetRowCellDisplayText(I, Me.colPIS)
                    .Item(A).Item("COFINS") = Me.grd1.GetRowCellDisplayText(I, Me.colCOFINS)
                    .Item(A).Item("CodEnq") = Me.grd1.GetRowCellDisplayText(I, Me.colCodEnq)
                    A += 1
                End If
            Next
        End With

        If Me.Tag = "CUPOM" Then
            rel.colCFOP.Caption = "Tributação"
            rel.colCodEnq.Visible = False
            rel.colCOFINS.Visible = False
            rel.colIPI.Visible = False
            rel.colPIS.Visible = False
        End If
        rel.ShowPreview()
    End Sub

    Private Sub btnRelCust_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelCust.ItemClick
        Me.GridControl1.ShowPrintPreview()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim I As Integer
        Dim dblQtd As Double
        If Me.Tag = "PESQUISA" Then
            For I = 0 To Me.grd1.RowCount - 1
                If Me.grd1.GetRowCellDisplayText(I, Me.colProduto) <> "" Then
                    dblQtd += 1
                End If
            Next
            Me.lblQtd.Text = "Nº de Registros: " & dblQtd
        Else
            For I = 0 To Me.grd1.RowCount - 1
                dblQtd += 1
            Next
            Me.lblQtd.Text = "Nº de Registros: " & dblQtd
        End If
        
    End Sub
    Private Sub Condition()
        Dim I As Integer

        For I = 0 To 13
            Me.grd1.FormatConditions(I).Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            Me.grd1.FormatConditions(I).Value1 = "TESTE"
        Next

    End Sub

    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        Selecionar()
    End Sub

    Private Sub txtAlterar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlterar.DoubleClick
        If Me.Tag = "" Then
            Selecionar()
        End If

    End Sub
    Private Sub Selecionar()
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        Dim intIndex As Integer = Me.grd1.FocusedRowHandle

        If Me.grd1.GetRowCellDisplayText(intIndex, Me.colRegime).Contains("SIMPLES NACIONAL") Then
            frmCadProduto.cboRegime.SelectedIndex = 1

            frmCadProduto.lueCFOP.EditValue = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCFOP)
            frmCadProduto.txtICMSST.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMSST)
            frmCadProduto.txtAliquotaIPI.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaIPI)
            frmCadProduto.txtAliquotaPIS.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaPIS)
            frmCadProduto.txtAliquotaCOFINS.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaCOFINS)

            frmCadProduto.txtNfeNCM.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNCM)

            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboNfeCST, Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMS))
            End If
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colOrigem) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboOrigem, Me.grd1.GetRowCellDisplayText(intIndex, Me.colOrigem))

            End If
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBC) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboModBC, Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBC))

            End If

            frmCadProduto.txtRedBC.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRedBC)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBCST) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboModBCST, Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBCST))
            End If

            frmCadProduto.txtRedBCST.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRedBCST)
            frmCadProduto.txtMVAST.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colMVaST)
            frmCadProduto.txtICMSST.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMSST)
            frmCadProduto.txtCalcCred.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCalculoCred)


            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colIPI) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCSTIPI, Me.grd1.GetRowCellDisplayText(intIndex, Me.colIPI))
            End If

            frmCadProduto.txtCodEnq.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodEnq)
            frmCadProduto.txtAliquotaIPI.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaIPI)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colPIS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCSTPIS, Me.grd1.GetRowCellDisplayText(intIndex, Me.colPIS))
            End If

            frmCadProduto.txtAliquotaPIS.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaPIS)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCOFINS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCSTCOFINS, Me.grd1.GetRowCellDisplayText(intIndex, Me.colCOFINS))

            End If

            frmCadProduto.txtAliquotaCOFINS.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaCOFINS)

            frmCadProduto.txtNfeICMS.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaICMS)


            frmCadProduto.cboCodigoANP.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoANP)

            frmCadProduto.cboUF.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colUFComb)

            frmCadProduto.txtCest.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCest)

        Else
            frmCadProduto.cboRegime.SelectedIndex = 0

            frmCadProduto.lueCFOP.EditValue = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCFOP)
            frmCadProduto.txtIcmsStTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMSST)
            frmCadProduto.txtAliquotaIpiTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaIPI)
            frmCadProduto.txtAliquotaPisTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaPIS)
            frmCadProduto.txtAliquotaCofinsTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaCOFINS)

            frmCadProduto.txtNfeNCM.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colNCM)

            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCstTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMS))
            End If
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colOrigem) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboOrigemTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colOrigem))

            End If
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBC) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboModBcTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBC))

            End If

            frmCadProduto.txtRedBcTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRedBC)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBCST) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboModBcStTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colModBCST))
            End If

            frmCadProduto.txtRedBcStTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colRedBCST)
            frmCadProduto.txtMvaStTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colMVaST)
            frmCadProduto.txtIcmsStTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colICMSST)
            frmCadProduto.txtCalcCredTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCalculoCred)


            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colIPI) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCstIpiTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colIPI))
            End If

            frmCadProduto.txtCodEnqTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodEnq)
            frmCadProduto.txtAliquotaIpiTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaIPI)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colPIS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCstPisTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colPIS))
            End If

            frmCadProduto.txtAliquotaPisTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaPIS)
            If Me.grd1.GetRowCellDisplayText(intIndex, Me.colCOFINS) <> "" Then
                frmCadProduto.SelecionarCombo(frmCadProduto.cboCstCofinsTN, Me.grd1.GetRowCellDisplayText(intIndex, Me.colCOFINS))

            End If

            frmCadProduto.txtAliquotaCofinsTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaCOFINS)

            frmCadProduto.txtIcmsTN.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colAliquotaICMS)


            frmCadProduto.cboCodigoANP.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCodigoANP)

            frmCadProduto.cboUF.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colUFComb)

            frmCadProduto.txtCest.Text = Me.grd1.GetRowCellDisplayText(intIndex, Me.colCest)

        End If


        
        Me.Close()
    End Sub

    Private Sub btnEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        If Me.grd1.FocusedRowHandle < 0 Then Exit Sub
        If Me.Tag = "PESQUISA" Then
            Dim frm As New frmDetProduto
            frm.Tag = "PESQUISA"
            frm.strRegime = strRegimeNFe & strTipoFiscal
            frm.strCodigoAut = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            frm.intIndex = Me.grd1.FocusedRowHandle
            frm.txtCodProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodProd)
            frm.txtProduto.Text = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colProduto)
            frm.ShowDialog()
        Else
            Dim frm As New frmDetalharCupom
            frm.Tag = "CUPOM"
            frm.strCodigoAut = Me.grd1.GetRowCellDisplayText(Me.grd1.FocusedRowHandle, Me.colCodigo)
            frm.intIndex = Me.grd1.FocusedRowHandle
            frm.ShowDialog()
        End If
      
    End Sub
End Class