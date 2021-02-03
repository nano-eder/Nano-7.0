<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProduto
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProduto))
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colCampanha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colEmFalta1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmFalta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.cboUniMed = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.grpProd = New DevExpress.XtraEditors.GroupControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.chkDuplicar = New DevExpress.XtraEditors.CheckEdit
        Me.chkTribPadrao = New DevExpress.XtraEditors.CheckEdit
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.chkInativar = New DevExpress.XtraEditors.CheckEdit
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.dsProduto = New System.Data.DataSet
        Me.tbProduto = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.tbFor = New System.Data.DataTable
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidadeMedida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagens = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMinima1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNivelComboCodCF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLocacao2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFamilia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValPromocao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataUltVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTributacaoPadrao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colAlterarPreco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFab = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGarantia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPesoBruto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdEmb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMaxima1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkEmFalta = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.btnConPed = New DevExpress.XtraBars.BarButtonItem
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.lueNomeLoj = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.grpCalc = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdTotal = New DevExpress.XtraEditors.TextEdit
        Me.cboPreco = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdPro = New DevExpress.XtraEditors.TextEdit
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.lblCap = New DevExpress.XtraEditors.LabelControl
        Me.txtCapital = New DevExpress.XtraEditors.TextEdit
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.cboMod = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.btnAdic = New DevExpress.XtraBars.BarButtonItem
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.bsiImposto = New DevExpress.XtraBars.BarSubItem
        Me.btnPesquisa = New DevExpress.XtraBars.BarButtonItem
        Me.btnImpCupom = New DevExpress.XtraBars.BarButtonItem
        Me.btnCodBarras = New DevExpress.XtraBars.BarButtonItem
        Me.btnBalanca = New DevExpress.XtraBars.BarButtonItem
        Me.btnPainelPrecos = New DevExpress.XtraBars.BarButtonItem
        Me.btnImportProd = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cboGrp2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtPer = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.lblValCus = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.salvar = New System.Windows.Forms.SaveFileDialog
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.btnWord = New DevExpress.XtraBars.BarButtonItem
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.btnPdf = New DevExpress.XtraBars.BarButtonItem
        Me.pdfHtml = New DevExpress.XtraBars.BarButtonItem
        Me.lblLocacao = New DevExpress.XtraEditors.LabelControl
        Me.lblFornecedor = New DevExpress.XtraEditors.LabelControl
        Me.cboGrp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtObs = New DevExpress.XtraEditors.MemoEdit
        Me.btnCadGrp = New DevExpress.XtraEditors.SimpleButton
        Me.tabProd = New DevExpress.XtraTab.XtraTabControl
        Me.tabPrinc = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl100 = New DevExpress.XtraEditors.LabelControl
        Me.txtValDesconto = New Campos.NanoCampo
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCadUni = New DevExpress.XtraEditors.SimpleButton
        Me.btnCadCodBarra = New DevExpress.XtraEditors.SimpleButton
        Me.txtCodBarra = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtCodProdFor = New Campos.NanoCampo
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.btnCadFamilia = New DevExpress.XtraEditors.SimpleButton
        Me.cboFamilia = New DevExpress.XtraEditors.ComboBoxEdit
        Me.nbcImagem = New DevExpress.XtraNavBar.NavBarControl
        Me.nbgQuantidade = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer
        Me.PanelControl14 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.grpQtd = New DevExpress.XtraEditors.GroupControl
        Me.btnPadraoQtd = New DevExpress.XtraEditors.SimpleButton
        Me.lblLoja = New DevExpress.XtraEditors.LabelControl
        Me.btnManterQtd = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsQtd = New System.Data.DataSet
        Me.tbQtd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMinima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterarQtd = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCustoQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPendente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdSemAlterar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMaxima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnExcluirItem = New DevExpress.XtraEditors.SimpleButton
        Me.lueLoja = New DevExpress.XtraEditors.LookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.chkTamanho = New DevExpress.XtraEditors.CheckEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.lblTam = New DevExpress.XtraEditors.LabelControl
        Me.lblQtdMin = New DevExpress.XtraEditors.LabelControl
        Me.lblQtd = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdeMin = New Campos.NanoCampo
        Me.txtQtde = New Campos.NanoCampo
        Me.txtTamanho = New Campos.NanoCampo
        Me.LabelControl99 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdeMax = New Campos.NanoCampo
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.picCod = New DevExpress.XtraEditors.PictureEdit
        Me.btnOcultar = New DevExpress.XtraEditors.SimpleButton
        Me.btnTirarImagem2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnTirarImagem1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCarregarImage2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnCarregarImagem1 = New DevExpress.XtraEditors.SimpleButton
        Me.picImagem3 = New DevExpress.XtraEditors.PictureEdit
        Me.picImagem4 = New DevExpress.XtraEditors.PictureEdit
        Me.nbgImagem = New DevExpress.XtraNavBar.NavBarGroup
        Me.lblObs = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
        Me.btnCadFor = New DevExpress.XtraEditors.SimpleButton
        Me.cboFabricante = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.btnCadSet = New DevExpress.XtraEditors.SimpleButton
        Me.cboSet = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDesconto = New Campos.NanoCampo
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.chkDesc = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.txtNome = New Campos.NanoCampo
        Me.txtLoc = New Campos.NanoCampo
        Me.txtPor1 = New Campos.NanoCampo
        Me.txtVal = New Campos.NanoCampo
        Me.txtValCus = New Campos.NanoCampo
        Me.chkAlterar = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodInt = New Campos.NanoCampo
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.dtValidade = New DevExpress.XtraEditors.DateEdit
        Me.btnCadTabVal = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipo = New DevExpress.XtraEditors.LabelControl
        Me.cboTipo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtLoc2 = New Campos.NanoCampo
        Me.txtComissao = New Campos.NanoCampo
        Me.lblComissao = New DevExpress.XtraEditors.LabelControl
        Me.txtRevKM = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodFab = New DevExpress.XtraEditors.TextEdit
        Me.txtGarantia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl91 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdeEstoque = New Campos.NanoCampo
        Me.LabelControl94 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdeMinima = New Campos.NanoCampo
        Me.LabelControl93 = New DevExpress.XtraEditors.LabelControl
        Me.txtPesoBruto = New Campos.NanoCampo
        Me.LabelControl95 = New DevExpress.XtraEditors.LabelControl
        Me.txtPeso = New Campos.NanoCampo
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
        Me.NanoCampo1 = New Campos.NanoCampo
        Me.LabelControl97 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdMaxima = New Campos.NanoCampo
        Me.LabelControl98 = New DevExpress.XtraEditors.LabelControl
        Me.tabImpECF = New DevExpress.XtraTab.XtraTabPage
        Me.txtNCMImpProd = New Campos.NanoCampo
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cboOrigECF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnImposto = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.cboCodCF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCF = New DevExpress.XtraEditors.LabelControl
        Me.txtIcms = New Campos.NanoCampo
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.cboFIA = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.cboPesa = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.cboIPPT = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.cboTrib2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.cboOriIcm2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.cboCst2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cboTrib = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboOriIcm = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboCst = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtIPI = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.tabNfe = New DevExpress.XtraTab.XtraTabPage
        Me.btnSalvarTributacao = New DevExpress.XtraEditors.SimpleButton
        Me.cboTipoFiscal = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl96 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.tabImpostos = New DevExpress.XtraTab.XtraTabControl
        Me.tabICMS = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.cboModBC = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtICMSST = New Campos.NanoCampo
        Me.cboModBCST = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtCalcCred = New Campos.NanoCampo
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.txtNfeICMS = New Campos.NanoCampo
        Me.txtRedBCST = New Campos.NanoCampo
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.txtMVAST = New Campos.NanoCampo
        Me.txtRedBC = New Campos.NanoCampo
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.cboOrigem = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.lblCST = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.cboNfeCST = New DevExpress.XtraEditors.ComboBoxEdit
        Me.tabIPI = New DevExpress.XtraTab.XtraTabPage
        Me.txtCodEnq = New Campos.NanoCampo
        Me.txtAliquotaIPI = New Campos.NanoCampo
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.cboCSTIPI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.tabPIS = New DevExpress.XtraTab.XtraTabPage
        Me.txtAliquotaPIS = New Campos.NanoCampo
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.cboCSTPIS = New DevExpress.XtraEditors.ComboBoxEdit
        Me.tabCofins = New DevExpress.XtraTab.XtraTabPage
        Me.txtAliquotaCOFINS = New Campos.NanoCampo
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
        Me.cboCSTCOFINS = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.txtPerICMSUF = New Campos.NanoCampo
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtPerFCPUF = New Campos.NanoCampo
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
        Me.cboModBcTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtIcmsStTN = New Campos.NanoCampo
        Me.cboModBcStTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtCalcCredTN = New Campos.NanoCampo
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
        Me.txtIcmsTN = New Campos.NanoCampo
        Me.txtRedBcStTN = New Campos.NanoCampo
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl
        Me.txtMvaStTN = New Campos.NanoCampo
        Me.txtRedBcTN = New Campos.NanoCampo
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl
        Me.cboOrigemTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl
        Me.cboCstTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.txtCodEnqTN = New Campos.NanoCampo
        Me.txtAliquotaIpiTN = New Campos.NanoCampo
        Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl
        Me.cboCstIpiTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.txtAliquotaPisTN = New Campos.NanoCampo
        Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl
        Me.cboCstPisTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.txtAliquotaCofinsTN = New Campos.NanoCampo
        Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl88 = New DevExpress.XtraEditors.LabelControl
        Me.cboCstCofinsTN = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage
        Me.txtPercIcmsTN = New Campos.NanoCampo
        Me.LabelControl89 = New DevExpress.XtraEditors.LabelControl
        Me.txtPercFcpTN = New Campos.NanoCampo
        Me.LabelControl90 = New DevExpress.XtraEditors.LabelControl
        Me.txtCest = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.btnTribPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnInsNfeTodos = New DevExpress.XtraEditors.SimpleButton
        Me.cboCodigoANP = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.lueCFOP = New DevExpress.XtraEditors.LookUpEdit
        Me.CFOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtGenero = New Campos.NanoCampo
        Me.txtEXTIPI = New Campos.NanoCampo
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtNfeNCM = New Campos.NanoCampo
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.dsNfe = New System.Data.DataSet
        Me.tbNfe = New System.Data.DataTable
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAltNfe = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colRegime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrigem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCalculoCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIcms = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVaST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIcmsST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAddNfe = New DevExpress.XtraEditors.SimpleButton
        Me.btnExcluirNfe = New DevExpress.XtraEditors.SimpleButton
        Me.txtUniCom = New Campos.NanoCampo
        Me.txtValCom = New Campos.NanoCampo
        Me.cboMIPI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtValTrib = New Campos.NanoCampo
        Me.txtQtdTrib = New Campos.NanoCampo
        Me.txtQtdN = New Campos.NanoCampo
        Me.txtUniTrib = New Campos.NanoCampo
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.cboRegime = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.nbcVenda = New DevExpress.XtraNavBar.NavBarControl
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl
        Me.dsAjuste = New System.Data.DataSet
        Me.tbAjuste = New System.Data.DataTable
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFinal = New DevExpress.XtraEditors.DateEdit
        Me.dtInicial = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdComprada = New Campos.NanoCampo
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtQtdDescarte = New Campos.NanoCampo
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.lblTotalGasto = New System.Windows.Forms.Label
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdDevolvida = New Campos.NanoCampo
        Me.lblCred = New System.Windows.Forms.Label
        Me.txtAlteracao = New Campos.NanoCampo
        Me.txtQtdVendida = New Campos.NanoCampo
        Me.txtQtdEstoque = New Campos.NanoCampo
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.grd4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tabOpc = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl7 = New DevExpress.XtraGrid.GridControl
        Me.dsOpcao = New System.Data.DataSet
        Me.tbTipoOpc = New System.Data.DataTable
        Me.DataColumn69 = New System.Data.DataColumn
        Me.tbOpc = New System.Data.DataTable
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.grd6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoOpc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOpcao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAddOpc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkAddOpc = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl
        Me.grd5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTipoOpc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtTipoOpc = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PanelControl15 = New DevExpress.XtraEditors.PanelControl
        Me.btnInserirTodosOpc = New DevExpress.XtraEditors.SimpleButton
        Me.btnCadOpc = New DevExpress.XtraEditors.SimpleButton
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.CFOPTableAdapter = New Nano.dsNanoCommerceTableAdapters.CFOPTableAdapter
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProd.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDuplicar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTribPadrao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmFalta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueNomeLoj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalc.SuspendLayout()
        CType(Me.txtQtdTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPreco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProd.SuspendLayout()
        Me.tabPrinc.SuspendLayout()
        CType(Me.txtValDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodBarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProdFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbcImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nbcImagem.SuspendLayout()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl14.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQtd.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterarQtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.picCod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFabricante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtValidade.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtValidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComissao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRevKM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodFab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeEstoque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeMinima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesoBruto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdMaxima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImpECF.SuspendLayout()
        CType(Me.txtNCMImpProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodCF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIcms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPesa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIPPT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrib2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOriIcm2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCst2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOriIcm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCst.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNfe.SuspendLayout()
        CType(Me.cboTipoFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.tabImpostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImpostos.SuspendLayout()
        Me.tabICMS.SuspendLayout()
        CType(Me.cboModBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtICMSST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModBCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalcCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfeICMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMVAST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNfeCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIPI.SuspendLayout()
        CType(Me.txtCodEnq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotaIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPIS.SuspendLayout()
        CType(Me.txtAliquotaPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCofins.SuspendLayout()
        CType(Me.txtAliquotaCOFINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTCOFINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtPerICMSUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerFCPUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.cboModBcTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIcmsStTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModBcStTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalcCredTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIcmsTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBcStTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMvaStTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBcTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigemTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCstTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.txtCodEnqTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotaIpiTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCstIpiTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.txtAliquotaPisTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCstPisTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.txtAliquotaCofinsTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCstCofinsTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.txtPercIcmsTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercFcpTN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodigoANP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCFOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEXTIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfeNCM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNfe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNfe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAltNfe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUniCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValTrib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdTrib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUniTrib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.nbcVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nbcVenda.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdComprada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdDescarte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdDevolvida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlteracao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdVendida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdEstoque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOpc.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOpcao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTipoOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl15.SuspendLayout()
        Me.SuspendLayout()
        '
        'colCampanha
        '
        Me.colCampanha.Caption = "Campanha"
        Me.colCampanha.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colCampanha.FieldName = "Campanha"
        Me.colCampanha.Name = "colCampanha"
        Me.colCampanha.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colEmFalta1
        '
        Me.colEmFalta1.Caption = "Em Falta"
        Me.colEmFalta1.FieldName = "EmFalta"
        Me.colEmFalta1.Name = "colEmFalta1"
        Me.colEmFalta1.Visible = True
        Me.colEmFalta1.VisibleIndex = 16
        '
        'colValidade
        '
        Me.colValidade.Caption = "Validade"
        Me.colValidade.FieldName = "Validade"
        Me.colValidade.Name = "colValidade"
        Me.colValidade.OptionsColumn.ReadOnly = True
        Me.colValidade.Visible = True
        Me.colValidade.VisibleIndex = 17
        '
        'colEmFalta
        '
        Me.colEmFalta.Caption = "EmFalta"
        Me.colEmFalta.FieldName = "EmFalta"
        Me.colEmFalta.Name = "colEmFalta"
        Me.colEmFalta.OptionsColumn.ReadOnly = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Código"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Produto"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(20, 122)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Unid. Med."
        '
        'cboUniMed
        '
        Me.cboUniMed.EditValue = "UN"
        Me.cboUniMed.EnterMoveNextControl = True
        Me.cboUniMed.Location = New System.Drawing.Point(76, 119)
        Me.cboUniMed.Name = "cboUniMed"
        Me.cboUniMed.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUniMed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUniMed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUniMed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUniMed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUniMed.Properties.Items.AddRange(New Object() {"UN", "JG", "KT", "KG", "LT", "MT", "CX", "GL", "FD", "CJ", "CT", "PC", "DP", "FR", "ML", "PR", "DZ", "SC", "M2"})
        Me.cboUniMed.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUniMed.Size = New System.Drawing.Size(79, 20)
        Me.cboUniMed.TabIndex = 7
        Me.cboUniMed.Tag = "Unid. de Medida"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(337, 164)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = " Venda R$"
        '
        'grpProd
        '
        Me.grpProd.Appearance.ForeColor = System.Drawing.Color.Black
        Me.grpProd.Appearance.Options.UseForeColor = True
        Me.grpProd.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProd.AppearanceCaption.Options.UseFont = True
        Me.grpProd.Controls.Add(Me.CheckEdit1)
        Me.grpProd.Controls.Add(Me.chkDuplicar)
        Me.grpProd.Controls.Add(Me.chkTribPadrao)
        Me.grpProd.Controls.Add(Me.btnPadrao)
        Me.grpProd.Controls.Add(Me.btnManter)
        Me.grpProd.Controls.Add(Me.chkInativar)
        Me.grpProd.Controls.Add(Me.GridControl2)
        Me.grpProd.Controls.Add(Me.RibbonControl1)
        Me.grpProd.Controls.Add(Me.grpCalc)
        Me.grpProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpProd.Location = New System.Drawing.Point(0, 291)
        Me.grpProd.Name = "grpProd"
        Me.grpProd.Size = New System.Drawing.Size(1008, 335)
        Me.grpProd.TabIndex = 2
        Me.grpProd.Text = "Produtos Cadastrados"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(709, 0)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Alterar Preço"
        Me.CheckEdit1.Size = New System.Drawing.Size(110, 19)
        Me.CheckEdit1.TabIndex = 117
        '
        'chkDuplicar
        '
        Me.chkDuplicar.Location = New System.Drawing.Point(141, 0)
        Me.chkDuplicar.Name = "chkDuplicar"
        Me.chkDuplicar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDuplicar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkDuplicar.Properties.Appearance.Options.UseFont = True
        Me.chkDuplicar.Properties.Appearance.Options.UseForeColor = True
        Me.chkDuplicar.Properties.Caption = "Duplicar"
        Me.chkDuplicar.Size = New System.Drawing.Size(87, 19)
        Me.chkDuplicar.TabIndex = 115
        '
        'chkTribPadrao
        '
        Me.chkTribPadrao.Location = New System.Drawing.Point(825, 0)
        Me.chkTribPadrao.Name = "chkTribPadrao"
        Me.chkTribPadrao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkTribPadrao.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.chkTribPadrao.Properties.Appearance.Options.UseFont = True
        Me.chkTribPadrao.Properties.Appearance.Options.UseForeColor = True
        Me.chkTribPadrao.Properties.Caption = "Trib. Padrão"
        Me.chkTribPadrao.Size = New System.Drawing.Size(101, 19)
        Me.chkTribPadrao.TabIndex = 107
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(930, 38)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 105
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(930, 23)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 104
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'chkInativar
        '
        Me.chkInativar.Location = New System.Drawing.Point(934, 0)
        Me.chkInativar.Name = "chkInativar"
        Me.chkInativar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkInativar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkInativar.Properties.Appearance.Options.UseFont = True
        Me.chkInativar.Properties.Appearance.Options.UseForeColor = True
        Me.chkInativar.Properties.Caption = "Inativo"
        Me.chkInativar.Size = New System.Drawing.Size(66, 19)
        Me.chkInativar.TabIndex = 7
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbProduto"
        Me.GridControl2.DataSource = Me.dsProduto
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.grd1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.chkEmFalta, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(1004, 281)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsProduto
        '
        Me.dsProduto.DataSetName = "NewDataSet"
        Me.dsProduto.Tables.AddRange(New System.Data.DataTable() {Me.tbProduto, Me.tbFor})
        '
        'tbProduto
        '
        Me.tbProduto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn24, Me.DataColumn26, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn45, Me.DataColumn55, Me.DataColumn56, Me.DataColumn67, Me.DataColumn68, Me.DataColumn75})
        Me.tbProduto.TableName = "tbProduto"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Código"
        Me.DataColumn5.ColumnName = "Codigo"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Nome"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Unidade Medida"
        Me.DataColumn7.ColumnName = "UnidadeMedida"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "Valor Unitário R$ "
        Me.DataColumn8.ColumnName = "Valor"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Valor Custo R$"
        Me.DataColumn9.ColumnName = "Valor Custo"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Faltando"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "Locação"
        Me.DataColumn11.ColumnName = "Locacao"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "Código Interno"
        Me.DataColumn12.ColumnName = "CodigoInterno"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Porcentagens"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Fabricante"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Grupo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Obs"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Data"
        '
        'DataColumn18
        '
        Me.DataColumn18.Caption = "Codigo Barra"
        Me.DataColumn18.ColumnName = "CodigoBarra"
        '
        'DataColumn19
        '
        Me.DataColumn19.Caption = "Qtd Mínima"
        Me.DataColumn19.ColumnName = "QtdMinima"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Qtd"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "EmFalta"
        Me.DataColumn24.DataType = GetType(Boolean)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "NivelComboCodCF"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "Desconto"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "Setor"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Tipo"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "CodProdFor"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "Locacao2"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "ValPromocao"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "TributacaoPadrao"
        Me.DataColumn67.DataType = GetType(Boolean)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "AlterarPreco"
        Me.DataColumn68.DataType = GetType(Boolean)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "QtdMaxima"
        '
        'tbFor
        '
        Me.tbFor.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn57})
        Me.tbFor.TableName = "tbFor"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "Fornecedor"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Codigo"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "ValorUnitario"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "Qtd"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ValorTotal"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "Data"
        Me.DataColumn52.DataType = GetType(Date)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "NumeroNF"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "QtdProd"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "ValCusto"
        '
        'grd1
        '
        Me.grd1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.AliceBlue
        Me.grd1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colUnidadeMedida, Me.colValor, Me.colValorCusto, Me.colLocacao, Me.colCodigoInterno, Me.colPorcentagens, Me.colFabricante, Me.colGrupo, Me.colObs, Me.colData, Me.colCodigoBarra, Me.colQtdMinima1, Me.colQtd1, Me.colEmFalta1, Me.colNivelComboCodCF, Me.colDesconto, Me.colSetor, Me.colTipo, Me.colInativo, Me.colCodProdFor, Me.colValidade, Me.colComissao, Me.colLocacao2, Me.colFamilia, Me.colCampanha, Me.colValPromocao, Me.colDataUltVenda, Me.colTributacaoPadrao, Me.colAlterarPreco, Me.colCodFab, Me.colGarantia, Me.colKM, Me.colPeso, Me.colPesoBruto, Me.colQtdEmb, Me.colQtdMaxima1})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colCampanha
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition3.Appearance.Options.HighPriority = True
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colEmFalta1
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Value1 = 0
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition4.Appearance.Options.HighPriority = True
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colValidade
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.grd1.GridControl = Me.GridControl2
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colNome
        '
        Me.colNome.Caption = "Nome"
        Me.colNome.ColumnEdit = Me.txtAlterar
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 2
        Me.colNome.Width = 297
        '
        'colUnidadeMedida
        '
        Me.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadeMedida.Caption = "U.M."
        Me.colUnidadeMedida.ColumnEdit = Me.txtAlterar
        Me.colUnidadeMedida.FieldName = "UnidadeMedida"
        Me.colUnidadeMedida.Name = "colUnidadeMedida"
        Me.colUnidadeMedida.OptionsColumn.ReadOnly = True
        Me.colUnidadeMedida.Visible = True
        Me.colUnidadeMedida.VisibleIndex = 8
        Me.colUnidadeMedida.Width = 63
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor Unitário R$ "
        Me.colValor.ColumnEdit = Me.txtAlterar
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 112
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Valor Custo R$"
        Me.colValorCusto.ColumnEdit = Me.txtAlterar
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Visible = True
        Me.colValorCusto.VisibleIndex = 5
        Me.colValorCusto.Width = 121
        '
        'colLocacao
        '
        Me.colLocacao.Caption = "Locação"
        Me.colLocacao.ColumnEdit = Me.txtAlterar
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.OptionsColumn.ReadOnly = True
        Me.colLocacao.Visible = True
        Me.colLocacao.VisibleIndex = 12
        Me.colLocacao.Width = 126
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Código Interno"
        Me.colCodigoInterno.ColumnEdit = Me.txtAlterar
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 118
        '
        'colPorcentagens
        '
        Me.colPorcentagens.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagens.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagens.Caption = "Porcentagens"
        Me.colPorcentagens.ColumnEdit = Me.txtAlterar
        Me.colPorcentagens.FieldName = "Porcentagens"
        Me.colPorcentagens.Name = "colPorcentagens"
        Me.colPorcentagens.OptionsColumn.ReadOnly = True
        '
        'colFabricante
        '
        Me.colFabricante.Caption = "Fornecedor"
        Me.colFabricante.ColumnEdit = Me.txtAlterar
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        Me.colFabricante.Visible = True
        Me.colFabricante.VisibleIndex = 10
        Me.colFabricante.Width = 163
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.ColumnEdit = Me.txtAlterar
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 6
        Me.colGrupo.Width = 145
        '
        'colObs
        '
        Me.colObs.Caption = "Obs"
        Me.colObs.ColumnEdit = Me.txtAlterar
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 15
        Me.colObs.Width = 183
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 11
        Me.colData.Width = 93
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarra.Caption = "Código Barra"
        Me.colCodigoBarra.ColumnEdit = Me.txtAlterar
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.OptionsColumn.ReadOnly = True
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 1
        Me.colCodigoBarra.Width = 117
        '
        'colQtdMinima1
        '
        Me.colQtdMinima1.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMinima1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMinima1.Caption = "Qtd Mínima"
        Me.colQtdMinima1.ColumnEdit = Me.txtAlterar
        Me.colQtdMinima1.FieldName = "QtdMinima"
        Me.colQtdMinima1.Name = "colQtdMinima1"
        Me.colQtdMinima1.OptionsColumn.ReadOnly = True
        '
        'colQtd1
        '
        Me.colQtd1.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd1.Caption = "Qtd"
        Me.colQtd1.ColumnEdit = Me.txtAlterar
        Me.colQtd1.FieldName = "Qtd"
        Me.colQtd1.Name = "colQtd1"
        Me.colQtd1.OptionsColumn.ReadOnly = True
        Me.colQtd1.Visible = True
        Me.colQtd1.VisibleIndex = 3
        '
        'colNivelComboCodCF
        '
        Me.colNivelComboCodCF.Caption = "NivelComboCodCF"
        Me.colNivelComboCodCF.ColumnEdit = Me.txtAlterar
        Me.colNivelComboCodCF.FieldName = "NivelComboCodCF"
        Me.colNivelComboCodCF.Name = "colNivelComboCodCF"
        Me.colNivelComboCodCF.OptionsColumn.ReadOnly = True
        '
        'colDesconto
        '
        Me.colDesconto.Caption = "Desconto %"
        Me.colDesconto.ColumnEdit = Me.txtAlterar
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 13
        Me.colDesconto.Width = 81
        '
        'colSetor
        '
        Me.colSetor.Caption = "Setor"
        Me.colSetor.ColumnEdit = Me.txtAlterar
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        Me.colSetor.Visible = True
        Me.colSetor.VisibleIndex = 7
        Me.colSetor.Width = 98
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.ColumnEdit = Me.txtAlterar
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 14
        '
        'colInativo
        '
        Me.colInativo.Caption = "Inativo"
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        '
        'colCodProdFor
        '
        Me.colCodProdFor.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdFor.Caption = "Cód. Fornec."
        Me.colCodProdFor.ColumnEdit = Me.txtAlterar
        Me.colCodProdFor.FieldName = "CodProdFor"
        Me.colCodProdFor.Name = "colCodProdFor"
        Me.colCodProdFor.OptionsColumn.ReadOnly = True
        Me.colCodProdFor.Visible = True
        Me.colCodProdFor.VisibleIndex = 9
        Me.colCodProdFor.Width = 106
        '
        'colComissao
        '
        Me.colComissao.Caption = "Comissão %"
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 18
        '
        'colLocacao2
        '
        Me.colLocacao2.Caption = "Locação"
        Me.colLocacao2.ColumnEdit = Me.txtAlterar
        Me.colLocacao2.FieldName = "Locacao2"
        Me.colLocacao2.Name = "colLocacao2"
        Me.colLocacao2.OptionsColumn.ReadOnly = True
        '
        'colFamilia
        '
        Me.colFamilia.Caption = "Família"
        Me.colFamilia.ColumnEdit = Me.txtAlterar
        Me.colFamilia.FieldName = "Familia"
        Me.colFamilia.Name = "colFamilia"
        Me.colFamilia.OptionsColumn.ReadOnly = True
        Me.colFamilia.Visible = True
        Me.colFamilia.VisibleIndex = 19
        '
        'colValPromocao
        '
        Me.colValPromocao.AppearanceCell.Options.UseTextOptions = True
        Me.colValPromocao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValPromocao.Caption = "Val. Promoção R$"
        Me.colValPromocao.ColumnEdit = Me.txtAlterar
        Me.colValPromocao.FieldName = "ValPromocao"
        Me.colValPromocao.Name = "colValPromocao"
        Me.colValPromocao.OptionsColumn.ReadOnly = True
        '
        'colDataUltVenda
        '
        Me.colDataUltVenda.Caption = "Data Ult. Venda"
        Me.colDataUltVenda.FieldName = "DataUltVenda"
        Me.colDataUltVenda.Name = "colDataUltVenda"
        Me.colDataUltVenda.OptionsColumn.ReadOnly = True
        Me.colDataUltVenda.Visible = True
        Me.colDataUltVenda.VisibleIndex = 20
        '
        'colTributacaoPadrao
        '
        Me.colTributacaoPadrao.Caption = "Trib. Padrão"
        Me.colTributacaoPadrao.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colTributacaoPadrao.FieldName = "TributacaoPadrao"
        Me.colTributacaoPadrao.Name = "colTributacaoPadrao"
        Me.colTributacaoPadrao.OptionsColumn.ReadOnly = True
        Me.colTributacaoPadrao.Visible = True
        Me.colTributacaoPadrao.VisibleIndex = 21
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colAlterarPreco
        '
        Me.colAlterarPreco.Caption = "Alt. Preço"
        Me.colAlterarPreco.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colAlterarPreco.FieldName = "AlterarPreco"
        Me.colAlterarPreco.Name = "colAlterarPreco"
        '
        'colCodFab
        '
        Me.colCodFab.Caption = "Cód. Similar"
        Me.colCodFab.ColumnEdit = Me.txtAlterar
        Me.colCodFab.FieldName = "CodigoFabricante"
        Me.colCodFab.Name = "colCodFab"
        Me.colCodFab.OptionsColumn.ReadOnly = True
        '
        'colGarantia
        '
        Me.colGarantia.Caption = "Garantia"
        Me.colGarantia.FieldName = "Garantia"
        Me.colGarantia.Name = "colGarantia"
        Me.colGarantia.OptionsColumn.ReadOnly = True
        '
        'colKM
        '
        Me.colKM.Caption = "Rev. Km"
        Me.colKM.FieldName = "KM"
        Me.colKM.Name = "colKM"
        Me.colKM.OptionsColumn.ReadOnly = True
        '
        'colPeso
        '
        Me.colPeso.Caption = "Peso"
        Me.colPeso.FieldName = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.OptionsColumn.ReadOnly = True
        Me.colPeso.Visible = True
        Me.colPeso.VisibleIndex = 22
        '
        'colPesoBruto
        '
        Me.colPesoBruto.Caption = "Peso Bruto"
        Me.colPesoBruto.FieldName = "PesoBruto"
        Me.colPesoBruto.Name = "colPesoBruto"
        Me.colPesoBruto.OptionsColumn.ReadOnly = True
        Me.colPesoBruto.Visible = True
        Me.colPesoBruto.VisibleIndex = 23
        '
        'colQtdEmb
        '
        Me.colQtdEmb.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdEmb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdEmb.Caption = "Qtd Embalagem"
        Me.colQtdEmb.FieldName = "QtdEmb"
        Me.colQtdEmb.Name = "colQtdEmb"
        Me.colQtdEmb.OptionsColumn.ReadOnly = True
        '
        'colQtdMaxima1
        '
        Me.colQtdMaxima1.Caption = "Qtd Máxima"
        Me.colQtdMaxima1.FieldName = "QtdMaxima"
        Me.colQtdMaxima1.Name = "colQtdMaxima1"
        Me.colQtdMaxima1.OptionsColumn.ReadOnly = True
        Me.colQtdMaxima1.Visible = True
        Me.colQtdMaxima1.VisibleIndex = 24
        '
        'chkEmFalta
        '
        Me.chkEmFalta.AutoHeight = False
        Me.chkEmFalta.Name = "chkEmFalta"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnConPed})
        Me.RibbonControl1.Location = New System.Drawing.Point(498, 169)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2, Me.lueNomeLoj})
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 20)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Visible = False
        '
        'btnConPed
        '
        Me.btnConPed.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnConPed.Id = 12
        Me.btnConPed.Name = "btnConPed"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'lueNomeLoj
        '
        Me.lueNomeLoj.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueNomeLoj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueNomeLoj.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descricao", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueNomeLoj.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.lueNomeLoj.DisplayMember = "Descricao"
        Me.lueNomeLoj.Name = "lueNomeLoj"
        Me.lueNomeLoj.NullText = ""
        Me.lueNomeLoj.ValueMember = "Codigo"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem1, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnConPed)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1008, 24)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Glyph = Global.Nano.My.Resources.Resources.word8
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem2.Glyph = Global.Nano.My.Resources.Resources.excel8
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem3.Glyph = Global.Nano.My.Resources.Resources.acroread
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem4.Glyph = Global.Nano.My.Resources.Resources.HTTP
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'grpCalc
        '
        Me.grpCalc.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCalc.AppearanceCaption.Options.UseFont = True
        Me.grpCalc.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.grpCalc.Controls.Add(Me.LabelControl14)
        Me.grpCalc.Controls.Add(Me.txtQtdTotal)
        Me.grpCalc.Controls.Add(Me.cboPreco)
        Me.grpCalc.Controls.Add(Me.LabelControl13)
        Me.grpCalc.Controls.Add(Me.txtQtdPro)
        Me.grpCalc.Controls.Add(Me.btnCalcular)
        Me.grpCalc.Controls.Add(Me.lblCap)
        Me.grpCalc.Controls.Add(Me.txtCapital)
        Me.grpCalc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpCalc.Location = New System.Drawing.Point(2, 301)
        Me.grpCalc.Name = "grpCalc"
        Me.grpCalc.Size = New System.Drawing.Size(1004, 32)
        Me.grpCalc.TabIndex = 1
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(506, 10)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl14.TabIndex = 39
        Me.LabelControl14.Text = "Qtd Total"
        '
        'txtQtdTotal
        '
        Me.txtQtdTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQtdTotal.Location = New System.Drawing.Point(564, 4)
        Me.txtQtdTotal.Name = "txtQtdTotal"
        Me.txtQtdTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdTotal.Properties.Appearance.Options.UseFont = True
        Me.txtQtdTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdTotal.Properties.ReadOnly = True
        Me.txtQtdTotal.Size = New System.Drawing.Size(95, 26)
        Me.txtQtdTotal.TabIndex = 38
        '
        'cboPreco
        '
        Me.cboPreco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPreco.EditValue = "Valor Custo"
        Me.cboPreco.EnterMoveNextControl = True
        Me.cboPreco.Location = New System.Drawing.Point(379, 7)
        Me.cboPreco.Name = "cboPreco"
        Me.cboPreco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPreco.Properties.Appearance.Options.UseFont = True
        Me.cboPreco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPreco.Properties.Items.AddRange(New Object() {"Valor Custo", "Valor Venda"})
        Me.cboPreco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPreco.Size = New System.Drawing.Size(107, 22)
        Me.cboPreco.TabIndex = 1
        Me.cboPreco.Tag = "Tipo"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(9, 10)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl13.TabIndex = 37
        Me.LabelControl13.Text = "Produtos Cadastrados"
        '
        'txtQtdPro
        '
        Me.txtQtdPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdPro.Location = New System.Drawing.Point(141, 4)
        Me.txtQtdPro.Name = "txtQtdPro"
        Me.txtQtdPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdPro.Properties.Appearance.Options.UseFont = True
        Me.txtQtdPro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdPro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdPro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdPro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdPro.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdPro.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdPro.Properties.ReadOnly = True
        Me.txtQtdPro.Size = New System.Drawing.Size(95, 26)
        Me.txtQtdPro.TabIndex = 36
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(265, 3)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 28)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        '
        'lblCap
        '
        Me.lblCap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCap.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap.Appearance.Options.UseFont = True
        Me.lblCap.Location = New System.Drawing.Point(678, 11)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(126, 13)
        Me.lblCap.TabIndex = 31
        Me.lblCap.Text = "Capital em Estoque R$"
        '
        'txtCapital
        '
        Me.txtCapital.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCapital.Location = New System.Drawing.Point(810, 4)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapital.Properties.Appearance.Options.UseFont = True
        Me.txtCapital.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCapital.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCapital.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCapital.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCapital.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCapital.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCapital.Properties.ReadOnly = True
        Me.txtCapital.Size = New System.Drawing.Size(188, 26)
        Me.txtCapital.TabIndex = 2
        '
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnCancelar, Me.btnPrint, Me.cboMod, Me.btnAdic, Me.btnPesquisa, Me.BarSubItem1, Me.btnVisualizar, Me.btnRelCust, Me.bsiImposto, Me.btnImpCupom, Me.btnCodBarras, Me.BarSubItem2, Me.btnBalanca, Me.btnPainelPrecos, Me.btnImportProd})
        Me.bmComandos.MaxItemId = 27
        Me.bmComandos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGrp2, Me.RepositoryItemTextEdit1, Me.txtPer, Me.RepositoryItemComboBox1})
        Me.bmComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboMod, "", True, True, True, 125, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdic, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPrint, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem2, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
        '
        'cboMod
        '
        Me.cboMod.Caption = "Modelo"
        Me.cboMod.Edit = Me.RepositoryItemComboBox1
        Me.cboMod.Id = 14
        Me.cboMod.Name = "cboMod"
        Me.cboMod.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"DUPLA GRANDE", "DUPLA MÉDIA", "DUPLA MÉDIA ARGOX", "TRIPLA PEQUENA", "TRIPLA MINI", "TRIPLA MÉDIA ARGOX", "ETIQUETA CAIXA", "GÔNDOLA", "PIMACO A4348", "PIMACO A4360", "PIMACO A5Q1219", "LB 1000 DUPLA", "LB 1000 TRIPLA", "LB 1000 PEQUENA", "LB 1000 GÔNDOLA", "PROMOÇÃO", "ZT 230 DUPLA"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'btnAdic
        '
        Me.btnAdic.Caption = "Adicionar"
        Me.btnAdic.Glyph = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdic.Id = 15
        Me.btnAdic.Name = "btnAdic"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "&Etiquetas"
        Me.btnPrint.Glyph = Global.Nano.My.Resources.Resources.Impressora
        Me.btnPrint.Id = 12
        Me.btnPrint.Name = "btnPrint"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Funções"
        Me.BarSubItem2.Glyph = Global.Nano.My.Resources.Resources.Giro24
        Me.BarSubItem2.Id = 23
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiImposto, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCodBarras, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBalanca), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPainelPrecos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImportProd)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'bsiImposto
        '
        Me.bsiImposto.Caption = "&Tributos"
        Me.bsiImposto.Glyph = Global.Nano.My.Resources.Resources.coins_24x24
        Me.bsiImposto.Id = 20
        Me.bsiImposto.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPesquisa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImpCupom)})
        Me.bsiImposto.Name = "bsiImposto"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Caption = "NF-e / S@T Fiscal"
        Me.btnPesquisa.Glyph = Global.Nano.My.Resources.Resources.Nfe32
        Me.btnPesquisa.Id = 16
        Me.btnPesquisa.Name = "btnPesquisa"
        '
        'btnImpCupom
        '
        Me.btnImpCupom.Caption = "Cupom Fiscal"
        Me.btnImpCupom.Glyph = Global.Nano.My.Resources.Resources.playlist
        Me.btnImpCupom.Id = 21
        Me.btnImpCupom.Name = "btnImpCupom"
        '
        'btnCodBarras
        '
        Me.btnCodBarras.Caption = "&Cód. Barras"
        Me.btnCodBarras.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnCodBarras.Id = 22
        Me.btnCodBarras.Name = "btnCodBarras"
        '
        'btnBalanca
        '
        Me.btnBalanca.Caption = "Arquivos Balança"
        Me.btnBalanca.Glyph = Global.Nano.My.Resources.Resources.OS1
        Me.btnBalanca.Id = 24
        Me.btnBalanca.Name = "btnBalanca"
        '
        'btnPainelPrecos
        '
        Me.btnPainelPrecos.Caption = "Painel Preços"
        Me.btnPainelPrecos.Glyph = Global.Nano.My.Resources.Resources.cal_2
        Me.btnPainelPrecos.Id = 25
        Me.btnPainelPrecos.Name = "btnPainelPrecos"
        '
        'btnImportProd
        '
        Me.btnImportProd.Caption = "Importar Produto"
        Me.btnImportProd.Glyph = Global.Nano.My.Resources.Resources.excel8
        Me.btnImportProd.Id = 26
        Me.btnImportProd.Name = "btnImportProd"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 17
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Produtos"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 18
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 19
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 4
        Me.btnCancelar.Name = "btnCancelar"
        '
        'cboGrp2
        '
        Me.cboGrp2.AutoHeight = False
        Me.cboGrp2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrp2.Name = "cboGrp2"
        Me.cboGrp2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'txtPer
        '
        Me.txtPer.AutoHeight = False
        Me.txtPer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPer.Name = "txtPer"
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(0, 148)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(531, 5)
        Me.PanelControl2.TabIndex = 23
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(17, 143)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl11.TabIndex = 28
        Me.LabelControl11.Text = "Valores do Produto"
        '
        'lblValCus
        '
        Me.lblValCus.Location = New System.Drawing.Point(184, 164)
        Me.lblValCus.Name = "lblValCus"
        Me.lblValCus.Size = New System.Drawing.Size(47, 13)
        Me.lblValCus.TabIndex = 30
        Me.lblValCus.Text = " Custo R$"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'RibbonPage2
        '
        Me.RibbonPage2.KeyTip = ""
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.KeyTip = ""
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'btnWord
        '
        Me.btnWord.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnWord.Glyph = Global.Nano.My.Resources.Resources.word8
        Me.btnWord.Id = 0
        Me.btnWord.Name = "btnWord"
        '
        'btnExcel
        '
        Me.btnExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnExcel.Glyph = Global.Nano.My.Resources.Resources.excel8
        Me.btnExcel.Id = 1
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPdf
        '
        Me.btnPdf.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnPdf.Glyph = Global.Nano.My.Resources.Resources.acroread
        Me.btnPdf.Id = 2
        Me.btnPdf.Name = "btnPdf"
        '
        'pdfHtml
        '
        Me.pdfHtml.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.pdfHtml.Glyph = Global.Nano.My.Resources.Resources.HTTP
        Me.pdfHtml.Id = 3
        Me.pdfHtml.Name = "pdfHtml"
        '
        'lblLocacao
        '
        Me.lblLocacao.Location = New System.Drawing.Point(347, 122)
        Me.lblLocacao.Name = "lblLocacao"
        Me.lblLocacao.Size = New System.Drawing.Size(39, 13)
        Me.lblLocacao.TabIndex = 33
        Me.lblLocacao.Text = "Locação"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.Location = New System.Drawing.Point(15, 96)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(55, 13)
        Me.lblFornecedor.TabIndex = 81
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'cboGrp
        '
        Me.cboGrp.EnterMoveNextControl = True
        Me.cboGrp.Location = New System.Drawing.Point(392, 67)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGrp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrp.Properties.MaxLength = 55
        Me.cboGrp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGrp.Size = New System.Drawing.Size(116, 20)
        Me.cboGrp.TabIndex = 4
        Me.cboGrp.Tag = "Grupo"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(357, 70)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl20.TabIndex = 84
        Me.LabelControl20.Text = "Grupo"
        '
        'txtObs
        '
        Me.txtObs.EditValue = ""
        Me.txtObs.Location = New System.Drawing.Point(194, 203)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObs.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Size = New System.Drawing.Size(334, 32)
        Me.txtObs.TabIndex = 16
        Me.txtObs.Visible = False
        '
        'btnCadGrp
        '
        Me.btnCadGrp.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadGrp.Location = New System.Drawing.Point(508, 67)
        Me.btnCadGrp.Name = "btnCadGrp"
        Me.btnCadGrp.Size = New System.Drawing.Size(20, 20)
        Me.btnCadGrp.TabIndex = 0
        Me.btnCadGrp.Text = "SimpleButton1"
        '
        'tabProd
        '
        Me.tabProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabProd.Location = New System.Drawing.Point(0, 24)
        Me.tabProd.Name = "tabProd"
        Me.tabProd.SelectedTabPage = Me.tabPrinc
        Me.tabProd.Size = New System.Drawing.Size(1008, 267)
        Me.tabProd.TabIndex = 0
        Me.tabProd.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPrinc, Me.tabImpECF, Me.tabNfe, Me.XtraTabPage1, Me.tabOpc})
        '
        'tabPrinc
        '
        Me.tabPrinc.AutoScroll = True
        Me.tabPrinc.Controls.Add(Me.LabelControl100)
        Me.tabPrinc.Controls.Add(Me.txtValDesconto)
        Me.tabPrinc.Controls.Add(Me.SimpleButton3)
        Me.tabPrinc.Controls.Add(Me.SimpleButton2)
        Me.tabPrinc.Controls.Add(Me.btnCadUni)
        Me.tabPrinc.Controls.Add(Me.btnCadCodBarra)
        Me.tabPrinc.Controls.Add(Me.txtCodBarra)
        Me.tabPrinc.Controls.Add(Me.txtCodProdFor)
        Me.tabPrinc.Controls.Add(Me.txtObs)
        Me.tabPrinc.Controls.Add(Me.LabelControl21)
        Me.tabPrinc.Controls.Add(Me.LabelControl37)
        Me.tabPrinc.Controls.Add(Me.btnCadFamilia)
        Me.tabPrinc.Controls.Add(Me.cboFamilia)
        Me.tabPrinc.Controls.Add(Me.nbcImagem)
        Me.tabPrinc.Controls.Add(Me.lblObs)
        Me.tabPrinc.Controls.Add(Me.PanelControl10)
        Me.tabPrinc.Controls.Add(Me.btnCadFor)
        Me.tabPrinc.Controls.Add(Me.cboFabricante)
        Me.tabPrinc.Controls.Add(Me.LabelControl18)
        Me.tabPrinc.Controls.Add(Me.btnCadSet)
        Me.tabPrinc.Controls.Add(Me.cboSet)
        Me.tabPrinc.Controls.Add(Me.txtDesconto)
        Me.tabPrinc.Controls.Add(Me.LabelControl17)
        Me.tabPrinc.Controls.Add(Me.chkDesc)
        Me.tabPrinc.Controls.Add(Me.LabelControl15)
        Me.tabPrinc.Controls.Add(Me.PanelControl5)
        Me.tabPrinc.Controls.Add(Me.txtNome)
        Me.tabPrinc.Controls.Add(Me.txtLoc)
        Me.tabPrinc.Controls.Add(Me.txtPor1)
        Me.tabPrinc.Controls.Add(Me.txtVal)
        Me.tabPrinc.Controls.Add(Me.txtValCus)
        Me.tabPrinc.Controls.Add(Me.chkAlterar)
        Me.tabPrinc.Controls.Add(Me.LabelControl4)
        Me.tabPrinc.Controls.Add(Me.btnCadGrp)
        Me.tabPrinc.Controls.Add(Me.LabelControl11)
        Me.tabPrinc.Controls.Add(Me.PanelControl2)
        Me.tabPrinc.Controls.Add(Me.lblLocacao)
        Me.tabPrinc.Controls.Add(Me.lblValCus)
        Me.tabPrinc.Controls.Add(Me.LabelControl1)
        Me.tabPrinc.Controls.Add(Me.LabelControl2)
        Me.tabPrinc.Controls.Add(Me.LabelControl7)
        Me.tabPrinc.Controls.Add(Me.cboGrp)
        Me.tabPrinc.Controls.Add(Me.LabelControl20)
        Me.tabPrinc.Controls.Add(Me.lblFornecedor)
        Me.tabPrinc.Controls.Add(Me.txtCodInt)
        Me.tabPrinc.Controls.Add(Me.LabelControl8)
        Me.tabPrinc.Controls.Add(Me.dtValidade)
        Me.tabPrinc.Controls.Add(Me.btnCadTabVal)
        Me.tabPrinc.Controls.Add(Me.lblTipo)
        Me.tabPrinc.Controls.Add(Me.cboTipo)
        Me.tabPrinc.Controls.Add(Me.LabelControl5)
        Me.tabPrinc.Controls.Add(Me.cboUniMed)
        Me.tabPrinc.Controls.Add(Me.txtLoc2)
        Me.tabPrinc.Controls.Add(Me.txtComissao)
        Me.tabPrinc.Controls.Add(Me.lblComissao)
        Me.tabPrinc.Controls.Add(Me.txtRevKM)
        Me.tabPrinc.Controls.Add(Me.LabelControl92)
        Me.tabPrinc.Controls.Add(Me.LabelControl75)
        Me.tabPrinc.Controls.Add(Me.txtCodFab)
        Me.tabPrinc.Controls.Add(Me.txtGarantia)
        Me.tabPrinc.Controls.Add(Me.LabelControl91)
        Me.tabPrinc.Controls.Add(Me.txtQtdeEstoque)
        Me.tabPrinc.Controls.Add(Me.LabelControl94)
        Me.tabPrinc.Controls.Add(Me.txtQtdeMinima)
        Me.tabPrinc.Controls.Add(Me.LabelControl93)
        Me.tabPrinc.Controls.Add(Me.txtPesoBruto)
        Me.tabPrinc.Controls.Add(Me.LabelControl95)
        Me.tabPrinc.Controls.Add(Me.txtPeso)
        Me.tabPrinc.Controls.Add(Me.LabelControl61)
        Me.tabPrinc.Controls.Add(Me.NanoCampo1)
        Me.tabPrinc.Controls.Add(Me.LabelControl97)
        Me.tabPrinc.Controls.Add(Me.txtQtdMaxima)
        Me.tabPrinc.Controls.Add(Me.LabelControl98)
        Me.tabPrinc.Name = "tabPrinc"
        Me.tabPrinc.Size = New System.Drawing.Size(999, 236)
        Me.tabPrinc.Text = "Principal"
        '
        'LabelControl100
        '
        Me.LabelControl100.Location = New System.Drawing.Point(177, 211)
        Me.LabelControl100.Name = "LabelControl100"
        Me.LabelControl100.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl100.TabIndex = 155
        Me.LabelControl100.Text = "%"
        '
        'txtValDesconto
        '
        Me.txtValDesconto.CasasDecimais = 2
        Me.txtValDesconto.Enabled = False
        Me.txtValDesconto.EnterMoveNextControl = True
        Me.txtValDesconto.Location = New System.Drawing.Point(77, 208)
        Me.txtValDesconto.Name = "txtValDesconto"
        Me.txtValDesconto.Numerico = True
        Me.txtValDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValDesconto.Properties.MaxLength = 18
        Me.txtValDesconto.Size = New System.Drawing.Size(58, 20)
        Me.txtValDesconto.TabIndex = 14
        Me.txtValDesconto.Tag = "Valor Venda R$"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(297, 93)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(20, 20)
        Me.SimpleButton3.TabIndex = 149
        Me.SimpleButton3.Text = "SimpleButton1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(944, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(22, 22)
        Me.SimpleButton2.TabIndex = 119
        Me.SimpleButton2.Text = ">>"
        Me.SimpleButton2.Visible = False
        '
        'btnCadUni
        '
        Me.btnCadUni.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadUni.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadUni.Location = New System.Drawing.Point(155, 119)
        Me.btnCadUni.Name = "btnCadUni"
        Me.btnCadUni.Size = New System.Drawing.Size(20, 20)
        Me.btnCadUni.TabIndex = 134
        Me.btnCadUni.Text = "SimpleButton1"
        '
        'btnCadCodBarra
        '
        Me.btnCadCodBarra.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadCodBarra.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadCodBarra.Location = New System.Drawing.Point(508, 16)
        Me.btnCadCodBarra.Name = "btnCadCodBarra"
        Me.btnCadCodBarra.Size = New System.Drawing.Size(20, 20)
        Me.btnCadCodBarra.TabIndex = 133
        Me.btnCadCodBarra.Text = "SimpleButton1"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.EnterMoveNextControl = True
        Me.txtCodBarra.Location = New System.Drawing.Point(392, 15)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodBarra.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodBarra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCodBarra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBarra.Properties.MaxLength = 55
        Me.txtCodBarra.Size = New System.Drawing.Size(116, 20)
        Me.txtCodBarra.TabIndex = 132
        Me.txtCodBarra.Tag = "Grupo"
        '
        'txtCodProdFor
        '
        Me.txtCodProdFor.CasasDecimais = 0
        Me.txtCodProdFor.EnterMoveNextControl = True
        Me.txtCodProdFor.Location = New System.Drawing.Point(237, 15)
        Me.txtCodProdFor.Name = "txtCodProdFor"
        Me.txtCodProdFor.Numerico = False
        Me.txtCodProdFor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodProdFor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodProdFor.Properties.MaxLength = 200
        Me.txtCodProdFor.Size = New System.Drawing.Size(80, 20)
        Me.txtCodProdFor.TabIndex = 131
        Me.txtCodProdFor.Tag = "Produto"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(185, 18)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl21.TabIndex = 130
        Me.LabelControl21.Text = "Cód. For."
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(354, 96)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl37.TabIndex = 128
        Me.LabelControl37.Text = "Família"
        '
        'btnCadFamilia
        '
        Me.btnCadFamilia.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadFamilia.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadFamilia.Location = New System.Drawing.Point(508, 93)
        Me.btnCadFamilia.Name = "btnCadFamilia"
        Me.btnCadFamilia.Size = New System.Drawing.Size(20, 20)
        Me.btnCadFamilia.TabIndex = 127
        Me.btnCadFamilia.Text = "SimpleButton1"
        '
        'cboFamilia
        '
        Me.cboFamilia.EnterMoveNextControl = True
        Me.cboFamilia.Location = New System.Drawing.Point(392, 93)
        Me.cboFamilia.Name = "cboFamilia"
        Me.cboFamilia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboFamilia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFamilia.Properties.MaxLength = 55
        Me.cboFamilia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFamilia.Size = New System.Drawing.Size(116, 20)
        Me.cboFamilia.TabIndex = 6
        Me.cboFamilia.Tag = "Grupo"
        '
        'nbcImagem
        '
        Me.nbcImagem.ActiveGroup = Me.nbgQuantidade
        Me.nbcImagem.ContentButtonHint = Nothing
        Me.nbcImagem.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.nbcImagem.Controls.Add(Me.NavBarGroupControlContainer3)
        Me.nbcImagem.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nbgQuantidade, Me.nbgImagem})
        Me.nbcImagem.Location = New System.Drawing.Point(965, -1)
        Me.nbcImagem.Name = "nbcImagem"
        Me.nbcImagem.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.nbcImagem.OptionsNavPane.ExpandedWidth = 465
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        Me.nbcImagem.OptionsNavPane.ShowOverflowPanel = False
        Me.nbcImagem.OptionsNavPane.ShowSplitter = False
        Me.nbcImagem.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.nbcImagem.Size = New System.Drawing.Size(34, 237)
        Me.nbcImagem.TabIndex = 124
        Me.nbcImagem.Text = "NavBarControl1"
        '
        'nbgQuantidade
        '
        Me.nbgQuantidade.Caption = "Quantidade"
        Me.nbgQuantidade.ControlContainer = Me.NavBarGroupControlContainer3
        Me.nbgQuantidade.Expanded = True
        Me.nbgQuantidade.GroupClientHeight = 20
        Me.nbgQuantidade.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.nbgQuantidade.Name = "nbgQuantidade"
        Me.nbgQuantidade.SmallImage = CType(resources.GetObject("nbgQuantidade.SmallImage"), System.Drawing.Image)
        '
        'NavBarGroupControlContainer3
        '
        Me.NavBarGroupControlContainer3.Controls.Add(Me.PanelControl14)
        Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
        Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(461, 139)
        Me.NavBarGroupControlContainer3.TabIndex = 1
        '
        'PanelControl14
        '
        Me.PanelControl14.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl14.Controls.Add(Me.PanelControl1)
        Me.PanelControl14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl14.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl14.Name = "PanelControl14"
        Me.PanelControl14.Size = New System.Drawing.Size(461, 139)
        Me.PanelControl14.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grpQtd)
        Me.PanelControl1.Controls.Add(Me.chkTamanho)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.lblTam)
        Me.PanelControl1.Controls.Add(Me.lblQtdMin)
        Me.PanelControl1.Controls.Add(Me.lblQtd)
        Me.PanelControl1.Controls.Add(Me.txtQtdeMin)
        Me.PanelControl1.Controls.Add(Me.txtQtde)
        Me.PanelControl1.Controls.Add(Me.txtTamanho)
        Me.PanelControl1.Controls.Add(Me.LabelControl99)
        Me.PanelControl1.Controls.Add(Me.txtQtdeMax)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(461, 139)
        Me.PanelControl1.TabIndex = 100
        '
        'grpQtd
        '
        Me.grpQtd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpQtd.Controls.Add(Me.btnPadraoQtd)
        Me.grpQtd.Controls.Add(Me.lblLoja)
        Me.grpQtd.Controls.Add(Me.btnManterQtd)
        Me.grpQtd.Controls.Add(Me.GridControl1)
        Me.grpQtd.Controls.Add(Me.btnExcluirItem)
        Me.grpQtd.Controls.Add(Me.lueLoja)
        Me.grpQtd.Location = New System.Drawing.Point(2, 34)
        Me.grpQtd.Name = "grpQtd"
        Me.grpQtd.Size = New System.Drawing.Size(457, 149)
        Me.grpQtd.TabIndex = 99
        Me.grpQtd.Text = "Qtdes do Produto"
        '
        'btnPadraoQtd
        '
        Me.btnPadraoQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadraoQtd.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadraoQtd.Appearance.Options.UseFont = True
        Me.btnPadraoQtd.Enabled = False
        Me.btnPadraoQtd.Location = New System.Drawing.Point(398, 3)
        Me.btnPadraoQtd.Name = "btnPadraoQtd"
        Me.btnPadraoQtd.Size = New System.Drawing.Size(54, 16)
        Me.btnPadraoQtd.TabIndex = 106
        Me.btnPadraoQtd.Text = "Padrão"
        Me.btnPadraoQtd.ToolTip = "Configurações da grid padrão"
        '
        'lblLoja
        '
        Me.lblLoja.Location = New System.Drawing.Point(112, 4)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(20, 13)
        Me.lblLoja.TabIndex = 118
        Me.lblLoja.Text = "Loja"
        '
        'btnManterQtd
        '
        Me.btnManterQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManterQtd.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManterQtd.Appearance.Options.UseFont = True
        Me.btnManterQtd.Location = New System.Drawing.Point(345, 3)
        Me.btnManterQtd.Name = "btnManterQtd"
        Me.btnManterQtd.Size = New System.Drawing.Size(54, 16)
        Me.btnManterQtd.TabIndex = 105
        Me.btnManterQtd.Text = "Manter"
        Me.btnManterQtd.ToolTip = "Manter as configurações da grid"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbQtd"
        Me.GridControl1.DataSource = Me.dsQtd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterarQtd})
        Me.GridControl1.Size = New System.Drawing.Size(453, 108)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'dsQtd
        '
        Me.dsQtd.DataSetName = "NewDataSet"
        Me.dsQtd.Tables.AddRange(New System.Data.DataTable() {Me.tbQtd})
        '
        'tbQtd
        '
        Me.tbQtd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn25, Me.DataColumn27, Me.DataColumn31, Me.DataColumn44, Me.DataColumn46, Me.DataColumn66, Me.DataColumn74})
        Me.tbQtd.TableName = "tbQtd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Tamanho"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "QtdMinima"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Lote"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Codigo"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Faltando"
        Me.DataColumn22.DataType = GetType(Boolean)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "EmFalta"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "ValorCusto"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Pendente"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "CodConfig"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "QtdSemAlterar"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Descricao"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "VU"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "QtdMaxima"
        '
        'grd2
        '
        Me.grd2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTamanho, Me.colQtdMinima, Me.colQtd, Me.colLote, Me.colCodigoQtd, Me.colEmFalta, Me.colValorCustoQtd, Me.colPendente, Me.colCodConfig, Me.colQtdSemAlterar, Me.colDescricao, Me.colVU, Me.colQtdMaxima})
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition5.Appearance.Options.HighPriority = True
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colEmFalta
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition5.Value1 = 0
        Me.grd2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition5})
        Me.grd2.GridControl = Me.GridControl1
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled
        Me.grd2.OptionsBehavior.FocusLeaveOnTab = True
        Me.grd2.OptionsNavigation.AutoFocusNewRow = True
        Me.grd2.OptionsNavigation.EnterMoveNextColumn = True
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        Me.grd2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 0
        Me.colTamanho.Width = 51
        '
        'colQtdMinima
        '
        Me.colQtdMinima.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMinima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMinima.Caption = "Qtd Mínima"
        Me.colQtdMinima.ColumnEdit = Me.txtAlterarQtd
        Me.colQtdMinima.FieldName = "QtdMinima"
        Me.colQtdMinima.Name = "colQtdMinima"
        Me.colQtdMinima.OptionsColumn.ReadOnly = True
        Me.colQtdMinima.Visible = True
        Me.colQtdMinima.VisibleIndex = 1
        Me.colQtdMinima.Width = 64
        '
        'txtAlterarQtd
        '
        Me.txtAlterarQtd.AutoHeight = False
        Me.txtAlterarQtd.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtAlterarQtd.Name = "txtAlterarQtd"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.ColumnEdit = Me.txtAlterarQtd
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 3
        Me.colQtd.Width = 67
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.ColumnEdit = Me.txtAlterarQtd
        Me.colLote.FieldName = "Lote"
        Me.colLote.Name = "colLote"
        Me.colLote.OptionsColumn.ReadOnly = True
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 5
        Me.colLote.Width = 74
        '
        'colCodigoQtd
        '
        Me.colCodigoQtd.Caption = "CodigoQtd"
        Me.colCodigoQtd.ColumnEdit = Me.txtAlterarQtd
        Me.colCodigoQtd.FieldName = "Codigo"
        Me.colCodigoQtd.Name = "colCodigoQtd"
        Me.colCodigoQtd.OptionsColumn.ReadOnly = True
        '
        'colValorCustoQtd
        '
        Me.colValorCustoQtd.Caption = "ValorCusto"
        Me.colValorCustoQtd.FieldName = "ValorCusto"
        Me.colValorCustoQtd.Name = "colValorCustoQtd"
        Me.colValorCustoQtd.OptionsColumn.ReadOnly = True
        Me.colValorCustoQtd.Width = 61
        '
        'colPendente
        '
        Me.colPendente.AppearanceCell.Options.UseTextOptions = True
        Me.colPendente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPendente.Caption = "Em Pedido"
        Me.colPendente.FieldName = "Pendente"
        Me.colPendente.Name = "colPendente"
        Me.colPendente.OptionsColumn.ReadOnly = True
        Me.colPendente.Visible = True
        Me.colPendente.VisibleIndex = 4
        Me.colPendente.Width = 62
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.txtAlterarQtd
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        '
        'colQtdSemAlterar
        '
        Me.colQtdSemAlterar.Caption = "Qtd Sem Alterar"
        Me.colQtdSemAlterar.FieldName = "QtdSemAlterar"
        Me.colQtdSemAlterar.Name = "colQtdSemAlterar"
        Me.colQtdSemAlterar.OptionsColumn.ReadOnly = True
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Loja"
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 6
        Me.colDescricao.Width = 50
        '
        'colVU
        '
        Me.colVU.AppearanceCell.Options.UseTextOptions = True
        Me.colVU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVU.Caption = "VU 30 dias"
        Me.colVU.FieldName = "VU"
        Me.colVU.Name = "colVU"
        Me.colVU.OptionsColumn.ReadOnly = True
        '
        'colQtdMaxima
        '
        Me.colQtdMaxima.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMaxima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMaxima.Caption = "Qtd Máx"
        Me.colQtdMaxima.ColumnEdit = Me.txtAlterarQtd
        Me.colQtdMaxima.FieldName = "QtdMaxima"
        Me.colQtdMaxima.Name = "colQtdMaxima"
        Me.colQtdMaxima.OptionsColumn.ReadOnly = True
        Me.colQtdMaxima.Visible = True
        Me.colQtdMaxima.VisibleIndex = 2
        Me.colQtdMaxima.Width = 64
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcluirItem.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnExcluirItem.Location = New System.Drawing.Point(2, 128)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Size = New System.Drawing.Size(453, 19)
        Me.btnExcluirItem.TabIndex = 3
        Me.btnExcluirItem.Text = "Excluir Item"
        '
        'lueLoja
        '
        Me.lueLoja.EnterMoveNextControl = True
        Me.lueLoja.Location = New System.Drawing.Point(138, 1)
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lueLoja.Properties.Appearance.Options.UseFont = True
        Me.lueLoja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.Properties.DataSource = Me.ConfigBindingSource
        Me.lueLoja.Properties.DisplayMember = "Descricao"
        Me.lueLoja.Properties.NullText = ""
        Me.lueLoja.Properties.ValueMember = "Codigo"
        Me.lueLoja.Size = New System.Drawing.Size(149, 19)
        Me.lueLoja.TabIndex = 1
        Me.lueLoja.Tag = "Loja"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkTamanho
        '
        Me.chkTamanho.EditValue = True
        Me.chkTamanho.Location = New System.Drawing.Point(73, 9)
        Me.chkTamanho.Name = "chkTamanho"
        Me.chkTamanho.Properties.Caption = ""
        Me.chkTamanho.Size = New System.Drawing.Size(17, 19)
        Me.chkTamanho.TabIndex = 0
        Me.chkTamanho.ToolTip = "Clique para adicionar um tamanho diferente de U"
        Me.chkTamanho.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkTamanho.ToolTipTitle = "Tamanho do Produto"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(377, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 21)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Adicionar"
        '
        'lblTam
        '
        Me.lblTam.Location = New System.Drawing.Point(5, 11)
        Me.lblTam.Name = "lblTam"
        Me.lblTam.Size = New System.Drawing.Size(24, 13)
        Me.lblTam.TabIndex = 107
        Me.lblTam.Text = "Tam."
        '
        'lblQtdMin
        '
        Me.lblQtdMin.Location = New System.Drawing.Point(98, 11)
        Me.lblQtdMin.Name = "lblQtdMin"
        Me.lblQtdMin.Size = New System.Drawing.Size(37, 13)
        Me.lblQtdMin.TabIndex = 106
        Me.lblQtdMin.Text = "Qtd Mín"
        '
        'lblQtd
        '
        Me.lblQtd.Location = New System.Drawing.Point(297, 11)
        Me.lblQtd.Name = "lblQtd"
        Me.lblQtd.Size = New System.Drawing.Size(18, 13)
        Me.lblQtd.TabIndex = 104
        Me.lblQtd.Text = "Qtd"
        '
        'txtQtdeMin
        '
        Me.txtQtdeMin.CasasDecimais = 0
        Me.txtQtdeMin.EditValue = "0"
        Me.txtQtdeMin.EnterMoveNextControl = True
        Me.txtQtdeMin.Location = New System.Drawing.Point(140, 8)
        Me.txtQtdeMin.Name = "txtQtdeMin"
        Me.txtQtdeMin.Numerico = True
        Me.txtQtdeMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdeMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdeMin.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdeMin.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdeMin.Properties.MaxLength = 14
        Me.txtQtdeMin.Size = New System.Drawing.Size(50, 20)
        Me.txtQtdeMin.TabIndex = 1
        Me.txtQtdeMin.Tag = "Qtd Mínima"
        '
        'txtQtde
        '
        Me.txtQtde.CasasDecimais = 0
        Me.txtQtde.EnterMoveNextControl = True
        Me.txtQtde.Location = New System.Drawing.Point(321, 8)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Numerico = True
        Me.txtQtde.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtde.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtde.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtde.Properties.MaxLength = 14
        Me.txtQtde.Size = New System.Drawing.Size(50, 20)
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.Tag = "Qtd"
        '
        'txtTamanho
        '
        Me.txtTamanho.CasasDecimais = 0
        Me.txtTamanho.EnterMoveNextControl = True
        Me.txtTamanho.Location = New System.Drawing.Point(32, 8)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Numerico = False
        Me.txtTamanho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho.Properties.MaxLength = 30
        Me.txtTamanho.Size = New System.Drawing.Size(60, 20)
        Me.txtTamanho.TabIndex = 0
        Me.txtTamanho.Tag = "Tamanho"
        '
        'LabelControl99
        '
        Me.LabelControl99.Location = New System.Drawing.Point(195, 11)
        Me.LabelControl99.Name = "LabelControl99"
        Me.LabelControl99.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl99.TabIndex = 1
        Me.LabelControl99.Text = "Qtd Máx"
        '
        'txtQtdeMax
        '
        Me.txtQtdeMax.CasasDecimais = 0
        Me.txtQtdeMax.EditValue = "0"
        Me.txtQtdeMax.EnterMoveNextControl = True
        Me.txtQtdeMax.Location = New System.Drawing.Point(239, 8)
        Me.txtQtdeMax.Name = "txtQtdeMax"
        Me.txtQtdeMax.Numerico = True
        Me.txtQtdeMax.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdeMax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdeMax.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdeMax.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdeMax.Properties.MaxLength = 14
        Me.txtQtdeMax.Size = New System.Drawing.Size(50, 20)
        Me.txtQtdeMax.TabIndex = 2
        Me.txtQtdeMax.Tag = "Qtd Mínima"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.PanelControl8)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(461, 78)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Controls.Add(Me.picCod)
        Me.PanelControl8.Controls.Add(Me.btnOcultar)
        Me.PanelControl8.Controls.Add(Me.btnTirarImagem2)
        Me.PanelControl8.Controls.Add(Me.btnTirarImagem1)
        Me.PanelControl8.Controls.Add(Me.btnCarregarImage2)
        Me.PanelControl8.Controls.Add(Me.btnCarregarImagem1)
        Me.PanelControl8.Controls.Add(Me.picImagem3)
        Me.PanelControl8.Controls.Add(Me.picImagem4)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(461, 78)
        Me.PanelControl8.TabIndex = 5
        '
        'picCod
        '
        Me.picCod.Location = New System.Drawing.Point(59, 154)
        Me.picCod.Name = "picCod"
        Me.picCod.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picCod.Properties.Appearance.Options.UseBackColor = True
        Me.picCod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picCod.Size = New System.Drawing.Size(302, 22)
        Me.picCod.TabIndex = 56
        '
        'btnOcultar
        '
        Me.btnOcultar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnOcultar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnOcultar.Appearance.Options.UseBackColor = True
        Me.btnOcultar.Appearance.Options.UseFont = True
        Me.btnOcultar.Appearance.Options.UseForeColor = True
        Me.btnOcultar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOcultar.Location = New System.Drawing.Point(418, 153)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(22, 22)
        Me.btnOcultar.TabIndex = 51
        Me.btnOcultar.Text = ">>"
        Me.btnOcultar.Visible = False
        '
        'btnTirarImagem2
        '
        Me.btnTirarImagem2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnTirarImagem2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarImagem2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnTirarImagem2.Appearance.Options.UseBackColor = True
        Me.btnTirarImagem2.Appearance.Options.UseFont = True
        Me.btnTirarImagem2.Appearance.Options.UseForeColor = True
        Me.btnTirarImagem2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTirarImagem2.Image = Global.Nano.My.Resources.Resources.Webcam
        Me.btnTirarImagem2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTirarImagem2.Location = New System.Drawing.Point(416, 40)
        Me.btnTirarImagem2.Name = "btnTirarImagem2"
        Me.btnTirarImagem2.Size = New System.Drawing.Size(22, 22)
        Me.btnTirarImagem2.TabIndex = 55
        Me.btnTirarImagem2.Text = "Tirar"
        '
        'btnTirarImagem1
        '
        Me.btnTirarImagem1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnTirarImagem1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarImagem1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnTirarImagem1.Appearance.Options.UseBackColor = True
        Me.btnTirarImagem1.Appearance.Options.UseFont = True
        Me.btnTirarImagem1.Appearance.Options.UseForeColor = True
        Me.btnTirarImagem1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTirarImagem1.Image = Global.Nano.My.Resources.Resources.Webcam
        Me.btnTirarImagem1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTirarImagem1.Location = New System.Drawing.Point(194, 40)
        Me.btnTirarImagem1.Name = "btnTirarImagem1"
        Me.btnTirarImagem1.Size = New System.Drawing.Size(22, 22)
        Me.btnTirarImagem1.TabIndex = 54
        '
        'btnCarregarImage2
        '
        Me.btnCarregarImage2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarImage2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregarImage2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnCarregarImage2.Appearance.Options.UseBackColor = True
        Me.btnCarregarImage2.Appearance.Options.UseFont = True
        Me.btnCarregarImage2.Appearance.Options.UseForeColor = True
        Me.btnCarregarImage2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCarregarImage2.Location = New System.Drawing.Point(416, 13)
        Me.btnCarregarImage2.Name = "btnCarregarImage2"
        Me.btnCarregarImage2.Size = New System.Drawing.Size(22, 22)
        Me.btnCarregarImage2.TabIndex = 53
        Me.btnCarregarImage2.Text = "..."
        '
        'btnCarregarImagem1
        '
        Me.btnCarregarImagem1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarImagem1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregarImagem1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnCarregarImagem1.Appearance.Options.UseBackColor = True
        Me.btnCarregarImagem1.Appearance.Options.UseFont = True
        Me.btnCarregarImagem1.Appearance.Options.UseForeColor = True
        Me.btnCarregarImagem1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCarregarImagem1.Location = New System.Drawing.Point(194, 13)
        Me.btnCarregarImagem1.Name = "btnCarregarImagem1"
        Me.btnCarregarImagem1.Size = New System.Drawing.Size(22, 22)
        Me.btnCarregarImagem1.TabIndex = 52
        Me.btnCarregarImagem1.Text = "..."
        '
        'picImagem3
        '
        Me.picImagem3.Location = New System.Drawing.Point(2, 3)
        Me.picImagem3.Name = "picImagem3"
        Me.picImagem3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picImagem3.Size = New System.Drawing.Size(185, 150)
        Me.picImagem3.TabIndex = 0
        '
        'picImagem4
        '
        Me.picImagem4.Location = New System.Drawing.Point(224, 3)
        Me.picImagem4.Name = "picImagem4"
        Me.picImagem4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picImagem4.Size = New System.Drawing.Size(185, 150)
        Me.picImagem4.TabIndex = 0
        '
        'nbgImagem
        '
        Me.nbgImagem.Caption = "Imagens"
        Me.nbgImagem.ControlContainer = Me.NavBarGroupControlContainer1
        Me.nbgImagem.GroupClientHeight = 80
        Me.nbgImagem.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.nbgImagem.Name = "nbgImagem"
        Me.nbgImagem.SmallImage = CType(resources.GetObject("nbgImagem.SmallImage"), System.Drawing.Image)
        '
        'lblObs
        '
        Me.lblObs.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblObs.Appearance.Options.UseFont = True
        Me.lblObs.Appearance.Options.UseForeColor = True
        Me.lblObs.Location = New System.Drawing.Point(203, 188)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(67, 13)
        Me.lblObs.TabIndex = 118
        Me.lblObs.Text = "Observação"
        Me.lblObs.Visible = False
        '
        'PanelControl10
        '
        Me.PanelControl10.Location = New System.Drawing.Point(191, 193)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(337, 5)
        Me.PanelControl10.TabIndex = 119
        Me.PanelControl10.Visible = False
        '
        'btnCadFor
        '
        Me.btnCadFor.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadFor.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadFor.Location = New System.Drawing.Point(277, 93)
        Me.btnCadFor.Name = "btnCadFor"
        Me.btnCadFor.Size = New System.Drawing.Size(20, 20)
        Me.btnCadFor.TabIndex = 117
        Me.btnCadFor.Text = "SimpleButton1"
        '
        'cboFabricante
        '
        Me.cboFabricante.EnterMoveNextControl = True
        Me.cboFabricante.Location = New System.Drawing.Point(76, 93)
        Me.cboFabricante.Name = "cboFabricante"
        Me.cboFabricante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFabricante.Properties.MaxLength = 150
        Me.cboFabricante.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFabricante.Size = New System.Drawing.Size(201, 20)
        Me.cboFabricante.TabIndex = 5
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(44, 70)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl18.TabIndex = 114
        Me.LabelControl18.Text = "Setor"
        '
        'btnCadSet
        '
        Me.btnCadSet.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadSet.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadSet.Location = New System.Drawing.Point(297, 67)
        Me.btnCadSet.Name = "btnCadSet"
        Me.btnCadSet.Size = New System.Drawing.Size(20, 20)
        Me.btnCadSet.TabIndex = 113
        Me.btnCadSet.Text = "SimpleButton1"
        '
        'cboSet
        '
        Me.cboSet.EnterMoveNextControl = True
        Me.cboSet.Location = New System.Drawing.Point(76, 67)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboSet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSet.Properties.MaxLength = 55
        Me.cboSet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSet.Size = New System.Drawing.Size(221, 20)
        Me.cboSet.TabIndex = 3
        Me.cboSet.Tag = "Grupo"
        '
        'txtDesconto
        '
        Me.txtDesconto.CasasDecimais = 2
        Me.txtDesconto.Enabled = False
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(134, 208)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Numerico = True
        Me.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesconto.Properties.MaxLength = 18
        Me.txtDesconto.Size = New System.Drawing.Size(42, 20)
        Me.txtDesconto.TabIndex = 15
        Me.txtDesconto.Tag = "Desconto %"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(10, 211)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl17.TabIndex = 111
        Me.LabelControl17.Text = "Desconto R$"
        '
        'chkDesc
        '
        Me.chkDesc.Location = New System.Drawing.Point(100, 187)
        Me.chkDesc.Name = "chkDesc"
        Me.chkDesc.Properties.Caption = ""
        Me.chkDesc.Size = New System.Drawing.Size(17, 19)
        Me.chkDesc.TabIndex = 13
        Me.chkDesc.ToolTip = "Clique para liberar o campo de desconto."
        Me.chkDesc.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkDesc.ToolTipTitle = "Ativar Desconto"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(19, 188)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl15.TabIndex = 104
        Me.LabelControl15.Text = "Em Promoção"
        '
        'PanelControl5
        '
        Me.PanelControl5.Location = New System.Drawing.Point(2, 193)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(177, 5)
        Me.PanelControl5.TabIndex = 103
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(76, 41)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.MaxLength = 200
        Me.txtNome.Size = New System.Drawing.Size(452, 20)
        Me.txtNome.TabIndex = 2
        Me.txtNome.Tag = "Produto"
        '
        'txtLoc
        '
        Me.txtLoc.CasasDecimais = 0
        Me.txtLoc.EnterMoveNextControl = True
        Me.txtLoc.Location = New System.Drawing.Point(392, 119)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Numerico = False
        Me.txtLoc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLoc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLoc.Size = New System.Drawing.Size(136, 20)
        Me.txtLoc.TabIndex = 9
        Me.txtLoc.Tag = "Locação"
        '
        'txtPor1
        '
        Me.txtPor1.CasasDecimais = 2
        Me.txtPor1.EditValue = ""
        Me.txtPor1.EnterMoveNextControl = True
        Me.txtPor1.Location = New System.Drawing.Point(466, 161)
        Me.txtPor1.Name = "txtPor1"
        Me.txtPor1.Numerico = True
        Me.txtPor1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPor1.Properties.Appearance.Options.UseBackColor = True
        Me.txtPor1.Size = New System.Drawing.Size(43, 20)
        Me.txtPor1.TabIndex = 20
        Me.txtPor1.Tag = "%"
        '
        'txtVal
        '
        Me.txtVal.CasasDecimais = 2
        Me.txtVal.EnterMoveNextControl = True
        Me.txtVal.Location = New System.Drawing.Point(392, 161)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Numerico = True
        Me.txtVal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtVal.Properties.MaxLength = 18
        Me.txtVal.Size = New System.Drawing.Size(75, 20)
        Me.txtVal.TabIndex = 12
        Me.txtVal.Tag = "Valor Venda R$"
        '
        'txtValCus
        '
        Me.txtValCus.CasasDecimais = 2
        Me.txtValCus.EnterMoveNextControl = True
        Me.txtValCus.Location = New System.Drawing.Point(237, 161)
        Me.txtValCus.Name = "txtValCus"
        Me.txtValCus.Numerico = True
        Me.txtValCus.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValCus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValCus.Properties.MaxLength = 18
        Me.txtValCus.Size = New System.Drawing.Size(80, 20)
        Me.txtValCus.TabIndex = 11
        Me.txtValCus.Tag = "Valor Custo R$"
        '
        'chkAlterar
        '
        Me.chkAlterar.Location = New System.Drawing.Point(157, 16)
        Me.chkAlterar.Name = "chkAlterar"
        Me.chkAlterar.Properties.Caption = ""
        Me.chkAlterar.Size = New System.Drawing.Size(18, 19)
        Me.chkAlterar.TabIndex = 101
        Me.chkAlterar.ToolTip = "Selecione para alterar o código"
        Me.chkAlterar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkAlterar.ToolTipTitle = "Alterar Código"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(334, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 95
        Me.LabelControl4.Text = "Cód. Barra"
        '
        'txtCodInt
        '
        Me.txtCodInt.CasasDecimais = 0
        Me.txtCodInt.Enabled = False
        Me.txtCodInt.EnterMoveNextControl = True
        Me.txtCodInt.Location = New System.Drawing.Point(76, 15)
        Me.txtCodInt.Name = "txtCodInt"
        Me.txtCodInt.Numerico = False
        Me.txtCodInt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodInt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodInt.Properties.MaxLength = 50
        Me.txtCodInt.Size = New System.Drawing.Size(100, 20)
        Me.txtCodInt.TabIndex = 0
        Me.txtCodInt.Tag = "Código"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(194, 211)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl8.TabIndex = 121
        Me.LabelControl8.Text = "Validade"
        '
        'dtValidade
        '
        Me.dtValidade.EditValue = Nothing
        Me.dtValidade.Location = New System.Drawing.Point(237, 208)
        Me.dtValidade.Name = "dtValidade"
        Me.dtValidade.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtValidade.Properties.Appearance.Options.UseForeColor = True
        Me.dtValidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtValidade.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtValidade.Size = New System.Drawing.Size(80, 20)
        Me.dtValidade.TabIndex = 120
        '
        'btnCadTabVal
        '
        Me.btnCadTabVal.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadTabVal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadTabVal.Location = New System.Drawing.Point(508, 161)
        Me.btnCadTabVal.Name = "btnCadTabVal"
        Me.btnCadTabVal.Size = New System.Drawing.Size(20, 20)
        Me.btnCadTabVal.TabIndex = 125
        Me.btnCadTabVal.Text = "SimpleButton1"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(211, 122)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(20, 13)
        Me.lblTipo.TabIndex = 116
        Me.lblTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.EditValue = "VENDA"
        Me.cboTipo.EnterMoveNextControl = True
        Me.cboTipo.Location = New System.Drawing.Point(237, 119)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.Items.AddRange(New Object() {"VENDA", "CONSUMO", "AMBOS", "SERVIÇO"})
        Me.cboTipo.Properties.MaxLength = 55
        Me.cboTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipo.Size = New System.Drawing.Size(80, 20)
        Me.cboTipo.TabIndex = 8
        Me.cboTipo.Tag = "Tipo"
        '
        'txtLoc2
        '
        Me.txtLoc2.CasasDecimais = 0
        Me.txtLoc2.EnterMoveNextControl = True
        Me.txtLoc2.Location = New System.Drawing.Point(237, 119)
        Me.txtLoc2.Name = "txtLoc2"
        Me.txtLoc2.Numerico = False
        Me.txtLoc2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLoc2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLoc2.Properties.MaxLength = 50
        Me.txtLoc2.Size = New System.Drawing.Size(80, 20)
        Me.txtLoc2.TabIndex = 4
        Me.txtLoc2.Tag = "Locação"
        Me.txtLoc2.Visible = False
        '
        'txtComissao
        '
        Me.txtComissao.CasasDecimais = 2
        Me.txtComissao.EnterMoveNextControl = True
        Me.txtComissao.Location = New System.Drawing.Point(76, 161)
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.Numerico = True
        Me.txtComissao.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComissao.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComissao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComissao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComissao.Properties.MaxLength = 18
        Me.txtComissao.Size = New System.Drawing.Size(100, 20)
        Me.txtComissao.TabIndex = 10
        Me.txtComissao.Tag = "Valor Custo R$"
        '
        'lblComissao
        '
        Me.lblComissao.Location = New System.Drawing.Point(12, 165)
        Me.lblComissao.Name = "lblComissao"
        Me.lblComissao.Size = New System.Drawing.Size(59, 13)
        Me.lblComissao.TabIndex = 123
        Me.lblComissao.Text = "Comissão %"
        '
        'txtRevKM
        '
        Me.txtRevKM.EnterMoveNextControl = True
        Me.txtRevKM.Location = New System.Drawing.Point(618, 41)
        Me.txtRevKM.Name = "txtRevKM"
        Me.txtRevKM.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRevKM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRevKM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevKM.Properties.MaxLength = 6
        Me.txtRevKM.Size = New System.Drawing.Size(135, 20)
        Me.txtRevKM.TabIndex = 22
        Me.txtRevKM.Tag = "Valor R$"
        Me.txtRevKM.Visible = False
        '
        'LabelControl92
        '
        Me.LabelControl92.Location = New System.Drawing.Point(555, 44)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl92.TabIndex = 142
        Me.LabelControl92.Text = "Rev. em KM"
        Me.LabelControl92.Visible = False
        '
        'LabelControl75
        '
        Me.LabelControl75.Location = New System.Drawing.Point(556, 18)
        Me.LabelControl75.Name = "LabelControl75"
        Me.LabelControl75.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl75.TabIndex = 138
        Me.LabelControl75.Text = "Cód. Similar"
        '
        'txtCodFab
        '
        Me.txtCodFab.EnterMoveNextControl = True
        Me.txtCodFab.Location = New System.Drawing.Point(618, 15)
        Me.txtCodFab.Name = "txtCodFab"
        Me.txtCodFab.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodFab.Size = New System.Drawing.Size(334, 20)
        Me.txtCodFab.TabIndex = 21
        Me.txtCodFab.Tag = "Cod. Fab."
        '
        'txtGarantia
        '
        Me.txtGarantia.EnterMoveNextControl = True
        Me.txtGarantia.Location = New System.Drawing.Point(817, 41)
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGarantia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGarantia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGarantia.Properties.MaxLength = 15
        Me.txtGarantia.Size = New System.Drawing.Size(135, 20)
        Me.txtGarantia.TabIndex = 23
        Me.txtGarantia.Tag = "Garantia"
        Me.txtGarantia.Visible = False
        '
        'LabelControl91
        '
        Me.LabelControl91.Location = New System.Drawing.Point(770, 44)
        Me.LabelControl91.Name = "LabelControl91"
        Me.LabelControl91.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl91.TabIndex = 141
        Me.LabelControl91.Text = "Garantia"
        Me.LabelControl91.Visible = False
        '
        'txtQtdeEstoque
        '
        Me.txtQtdeEstoque.CasasDecimais = 2
        Me.txtQtdeEstoque.EnterMoveNextControl = True
        Me.txtQtdeEstoque.Location = New System.Drawing.Point(817, 67)
        Me.txtQtdeEstoque.Name = "txtQtdeEstoque"
        Me.txtQtdeEstoque.Numerico = True
        Me.txtQtdeEstoque.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdeEstoque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdeEstoque.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdeEstoque.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdeEstoque.Properties.MaxLength = 18
        Me.txtQtdeEstoque.Size = New System.Drawing.Size(135, 20)
        Me.txtQtdeEstoque.TabIndex = 25
        Me.txtQtdeEstoque.Tag = "Valor Custo R$"
        '
        'LabelControl94
        '
        Me.LabelControl94.Location = New System.Drawing.Point(787, 70)
        Me.LabelControl94.Name = "LabelControl94"
        Me.LabelControl94.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl94.TabIndex = 146
        Me.LabelControl94.Text = "Qtde"
        '
        'txtQtdeMinima
        '
        Me.txtQtdeMinima.CasasDecimais = 2
        Me.txtQtdeMinima.EnterMoveNextControl = True
        Me.txtQtdeMinima.Location = New System.Drawing.Point(618, 67)
        Me.txtQtdeMinima.Name = "txtQtdeMinima"
        Me.txtQtdeMinima.Numerico = True
        Me.txtQtdeMinima.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdeMinima.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdeMinima.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdeMinima.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdeMinima.Properties.MaxLength = 18
        Me.txtQtdeMinima.Size = New System.Drawing.Size(135, 20)
        Me.txtQtdeMinima.TabIndex = 24
        Me.txtQtdeMinima.Tag = "Valor Custo R$"
        '
        'LabelControl93
        '
        Me.LabelControl93.Location = New System.Drawing.Point(553, 70)
        Me.LabelControl93.Name = "LabelControl93"
        Me.LabelControl93.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl93.TabIndex = 144
        Me.LabelControl93.Text = "Qtde Mínima"
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.CasasDecimais = 3
        Me.txtPesoBruto.EditValue = ""
        Me.txtPesoBruto.EnterMoveNextControl = True
        Me.txtPesoBruto.Location = New System.Drawing.Point(817, 119)
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.Numerico = True
        Me.txtPesoBruto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoBruto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPesoBruto.Size = New System.Drawing.Size(135, 20)
        Me.txtPesoBruto.TabIndex = 29
        Me.txtPesoBruto.Tag = "Locação"
        '
        'LabelControl95
        '
        Me.LabelControl95.Location = New System.Drawing.Point(759, 122)
        Me.LabelControl95.Name = "LabelControl95"
        Me.LabelControl95.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl95.TabIndex = 148
        Me.LabelControl95.Text = "Peso Bruto"
        '
        'txtPeso
        '
        Me.txtPeso.CasasDecimais = 3
        Me.txtPeso.EditValue = ""
        Me.txtPeso.EnterMoveNextControl = True
        Me.txtPeso.Location = New System.Drawing.Point(618, 119)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Numerico = True
        Me.txtPeso.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeso.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPeso.Size = New System.Drawing.Size(135, 20)
        Me.txtPeso.TabIndex = 28
        Me.txtPeso.Tag = "Locação"
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(589, 122)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl61.TabIndex = 136
        Me.LabelControl61.Text = "Peso"
        '
        'NanoCampo1
        '
        Me.NanoCampo1.CasasDecimais = 2
        Me.NanoCampo1.EnterMoveNextControl = True
        Me.NanoCampo1.Location = New System.Drawing.Point(817, 93)
        Me.NanoCampo1.Name = "NanoCampo1"
        Me.NanoCampo1.Numerico = True
        Me.NanoCampo1.Properties.Appearance.Options.UseTextOptions = True
        Me.NanoCampo1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NanoCampo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo1.Properties.MaxLength = 18
        Me.NanoCampo1.Size = New System.Drawing.Size(135, 20)
        Me.NanoCampo1.TabIndex = 27
        Me.NanoCampo1.Tag = "Valor Custo R$"
        '
        'LabelControl97
        '
        Me.LabelControl97.Location = New System.Drawing.Point(760, 96)
        Me.LabelControl97.Name = "LabelControl97"
        Me.LabelControl97.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl97.TabIndex = 151
        Me.LabelControl97.Text = "Qtde Emb."
        '
        'txtQtdMaxima
        '
        Me.txtQtdMaxima.CasasDecimais = 2
        Me.txtQtdMaxima.EnterMoveNextControl = True
        Me.txtQtdMaxima.Location = New System.Drawing.Point(618, 93)
        Me.txtQtdMaxima.Name = "txtQtdMaxima"
        Me.txtQtdMaxima.Numerico = True
        Me.txtQtdMaxima.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdMaxima.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdMaxima.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdMaxima.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdMaxima.Properties.MaxLength = 18
        Me.txtQtdMaxima.Size = New System.Drawing.Size(135, 20)
        Me.txtQtdMaxima.TabIndex = 26
        Me.txtQtdMaxima.Tag = "Valor Custo R$"
        '
        'LabelControl98
        '
        Me.LabelControl98.Location = New System.Drawing.Point(549, 96)
        Me.LabelControl98.Name = "LabelControl98"
        Me.LabelControl98.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl98.TabIndex = 153
        Me.LabelControl98.Text = "Qtde Máxima"
        '
        'tabImpECF
        '
        Me.tabImpECF.Controls.Add(Me.txtNCMImpProd)
        Me.tabImpECF.Controls.Add(Me.LabelControl6)
        Me.tabImpECF.Controls.Add(Me.LabelControl3)
        Me.tabImpECF.Controls.Add(Me.cboOrigECF)
        Me.tabImpECF.Controls.Add(Me.btnImposto)
        Me.tabImpECF.Controls.Add(Me.PanelControl4)
        Me.tabImpECF.Controls.Add(Me.cboCodCF)
        Me.tabImpECF.Controls.Add(Me.lblCF)
        Me.tabImpECF.Controls.Add(Me.txtIcms)
        Me.tabImpECF.Controls.Add(Me.LabelControl36)
        Me.tabImpECF.Controls.Add(Me.LabelControl35)
        Me.tabImpECF.Controls.Add(Me.cboFIA)
        Me.tabImpECF.Controls.Add(Me.LabelControl34)
        Me.tabImpECF.Controls.Add(Me.LabelControl33)
        Me.tabImpECF.Controls.Add(Me.cboPesa)
        Me.tabImpECF.Controls.Add(Me.LabelControl32)
        Me.tabImpECF.Controls.Add(Me.LabelControl31)
        Me.tabImpECF.Controls.Add(Me.cboIPPT)
        Me.tabImpECF.Controls.Add(Me.PanelControl3)
        Me.tabImpECF.Controls.Add(Me.LabelControl30)
        Me.tabImpECF.Controls.Add(Me.cboTrib2)
        Me.tabImpECF.Controls.Add(Me.LabelControl29)
        Me.tabImpECF.Controls.Add(Me.cboOriIcm2)
        Me.tabImpECF.Controls.Add(Me.LabelControl28)
        Me.tabImpECF.Controls.Add(Me.cboCst2)
        Me.tabImpECF.Controls.Add(Me.LabelControl10)
        Me.tabImpECF.Controls.Add(Me.cboTrib)
        Me.tabImpECF.Controls.Add(Me.cboOriIcm)
        Me.tabImpECF.Controls.Add(Me.cboCst)
        Me.tabImpECF.Controls.Add(Me.txtIPI)
        Me.tabImpECF.Controls.Add(Me.LabelControl12)
        Me.tabImpECF.Name = "tabImpECF"
        Me.tabImpECF.Size = New System.Drawing.Size(999, 236)
        Me.tabImpECF.Text = "Cupom Fiscal"
        '
        'txtNCMImpProd
        '
        Me.txtNCMImpProd.CasasDecimais = 0
        Me.txtNCMImpProd.EnterMoveNextControl = True
        Me.txtNCMImpProd.Location = New System.Drawing.Point(86, 58)
        Me.txtNCMImpProd.Name = "txtNCMImpProd"
        Me.txtNCMImpProd.Numerico = False
        Me.txtNCMImpProd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCMImpProd.Properties.MaxLength = 8
        Me.txtNCMImpProd.Size = New System.Drawing.Size(149, 20)
        Me.txtNCMImpProd.TabIndex = 110
        Me.txtNCMImpProd.Tag = "NCM Cupom Fiscal"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(58, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl6.TabIndex = 111
        Me.LabelControl6.Text = "NCM"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(768, 9)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 109
        Me.LabelControl3.Text = "Regime"
        Me.LabelControl3.Visible = False
        '
        'cboOrigECF
        '
        Me.cboOrigECF.EditValue = ""
        Me.cboOrigECF.EnterMoveNextControl = True
        Me.cboOrigECF.Location = New System.Drawing.Point(809, 6)
        Me.cboOrigECF.Name = "cboOrigECF"
        Me.cboOrigECF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrigECF.Properties.Items.AddRange(New Object() {"SIMPLES NACIONAL", "NORMAL"})
        Me.cboOrigECF.Properties.MaxLength = 55
        Me.cboOrigECF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOrigECF.Size = New System.Drawing.Size(149, 20)
        Me.cboOrigECF.TabIndex = 0
        Me.cboOrigECF.Tag = "Regime"
        Me.cboOrigECF.Visible = False
        '
        'btnImposto
        '
        Me.btnImposto.Location = New System.Drawing.Point(86, 84)
        Me.btnImposto.Name = "btnImposto"
        Me.btnImposto.Size = New System.Drawing.Size(149, 23)
        Me.btnImposto.TabIndex = 107
        Me.btnImposto.Text = "Inserir para todos"
        '
        'PanelControl4
        '
        Me.PanelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl4.Location = New System.Drawing.Point(251, 138)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(743, 5)
        Me.PanelControl4.TabIndex = 105
        Me.PanelControl4.Visible = False
        '
        'cboCodCF
        '
        Me.cboCodCF.EditValue = "Cód. Interno"
        Me.cboCodCF.EnterMoveNextControl = True
        Me.cboCodCF.Location = New System.Drawing.Point(328, 149)
        Me.cboCodCF.Name = "cboCodCF"
        Me.cboCodCF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodCF.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cboCodCF.Properties.Appearance.Options.UseFont = True
        Me.cboCodCF.Properties.Appearance.Options.UseForeColor = True
        Me.cboCodCF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboCodCF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboCodCF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodCF.Properties.Items.AddRange(New Object() {"Cód. Automático", "Cód. Interno", "Cód. Barra"})
        Me.cboCodCF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCodCF.Size = New System.Drawing.Size(118, 20)
        Me.cboCodCF.TabIndex = 8
        Me.cboCodCF.Tag = "Cód. C. Fiscal"
        Me.cboCodCF.Visible = False
        '
        'lblCF
        '
        Me.lblCF.Location = New System.Drawing.Point(256, 152)
        Me.lblCF.Name = "lblCF"
        Me.lblCF.Size = New System.Drawing.Size(66, 13)
        Me.lblCF.TabIndex = 104
        Me.lblCF.Text = "Cód. C. Fiscal"
        Me.lblCF.Visible = False
        '
        'txtIcms
        '
        Me.txtIcms.CasasDecimais = 2
        Me.txtIcms.Location = New System.Drawing.Point(86, 32)
        Me.txtIcms.Name = "txtIcms"
        Me.txtIcms.Numerico = True
        Me.txtIcms.Size = New System.Drawing.Size(149, 20)
        Me.txtIcms.TabIndex = 4
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.Appearance.Options.UseForeColor = True
        Me.LabelControl36.Location = New System.Drawing.Point(452, 63)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(186, 11)
        Me.LabelControl36.TabIndex = 58
        Me.LabelControl36.Text = """F"" - Produto final ""I"" - Insumo ""A"" - Ambos"
        Me.LabelControl36.Visible = False
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(302, 61)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl35.TabIndex = 57
        Me.LabelControl35.Text = "Tipo"
        Me.LabelControl35.Visible = False
        '
        'cboFIA
        '
        Me.cboFIA.EnterMoveNextControl = True
        Me.cboFIA.Location = New System.Drawing.Point(328, 58)
        Me.cboFIA.Name = "cboFIA"
        Me.cboFIA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFIA.Properties.Items.AddRange(New Object() {"F", "I", "A"})
        Me.cboFIA.Properties.MaxLength = 55
        Me.cboFIA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFIA.Size = New System.Drawing.Size(118, 20)
        Me.cboFIA.TabIndex = 7
        Me.cboFIA.Tag = "Tipo"
        Me.cboFIA.Visible = False
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl34.Appearance.Options.UseFont = True
        Me.LabelControl34.Appearance.Options.UseForeColor = True
        Me.LabelControl34.Location = New System.Drawing.Point(452, 37)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(306, 11)
        Me.LabelControl34.TabIndex = 56
        Me.LabelControl34.Text = """S"" - Produto pesável (balança) ""U"" - Produto comercializado por unidades"
        Me.LabelControl34.Visible = False
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(280, 35)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl33.TabIndex = 55
        Me.LabelControl33.Text = "Pesável?"
        Me.LabelControl33.Visible = False
        '
        'cboPesa
        '
        Me.cboPesa.EnterMoveNextControl = True
        Me.cboPesa.Location = New System.Drawing.Point(328, 32)
        Me.cboPesa.Name = "cboPesa"
        Me.cboPesa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPesa.Properties.Items.AddRange(New Object() {"S", "U"})
        Me.cboPesa.Properties.MaxLength = 55
        Me.cboPesa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPesa.Size = New System.Drawing.Size(118, 20)
        Me.cboPesa.TabIndex = 6
        Me.cboPesa.Tag = "Pesável?"
        Me.cboPesa.Visible = False
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Appearance.Options.UseForeColor = True
        Me.LabelControl32.Location = New System.Drawing.Point(452, 11)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(296, 11)
        Me.LabelControl32.TabIndex = 54
        Me.LabelControl32.Text = "Identificador do tipo de produção do produto ""P"" - Própria ""T"" - Terceiro"
        Me.LabelControl32.Visible = False
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(300, 9)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl31.TabIndex = 53
        Me.LabelControl31.Text = "IPPT"
        Me.LabelControl31.Visible = False
        '
        'cboIPPT
        '
        Me.cboIPPT.EnterMoveNextControl = True
        Me.cboIPPT.Location = New System.Drawing.Point(328, 6)
        Me.cboIPPT.Name = "cboIPPT"
        Me.cboIPPT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIPPT.Properties.Items.AddRange(New Object() {"P", "T"})
        Me.cboIPPT.Properties.MaxLength = 55
        Me.cboIPPT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboIPPT.Size = New System.Drawing.Size(118, 20)
        Me.cboIPPT.TabIndex = 5
        Me.cboIPPT.Tag = "IPPT"
        Me.cboIPPT.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(243, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(5, 231)
        Me.PanelControl3.TabIndex = 52
        Me.PanelControl3.Visible = False
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(28, 9)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl30.TabIndex = 51
        Me.LabelControl30.Text = "Tributação"
        '
        'cboTrib2
        '
        Me.cboTrib2.EnterMoveNextControl = True
        Me.cboTrib2.Location = New System.Drawing.Point(86, 6)
        Me.cboTrib2.Name = "cboTrib2"
        Me.cboTrib2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTrib2.Properties.Items.AddRange(New Object() {"T - Produto tributado", "F - Substituição tributária", "I - Isento", "N - Não incidência"})
        Me.cboTrib2.Properties.MaxLength = 55
        Me.cboTrib2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTrib2.Size = New System.Drawing.Size(149, 20)
        Me.cboTrib2.TabIndex = 1
        Me.cboTrib2.Tag = "Grupo"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(769, 87)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl29.TabIndex = 50
        Me.LabelControl29.Text = "Origem"
        Me.LabelControl29.Visible = False
        '
        'cboOriIcm2
        '
        Me.cboOriIcm2.EnterMoveNextControl = True
        Me.cboOriIcm2.Location = New System.Drawing.Point(809, 84)
        Me.cboOriIcm2.Name = "cboOriIcm2"
        Me.cboOriIcm2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOriIcm2.Properties.Items.AddRange(New Object() {"0 - Nacional", "1 - Estrangeira - Importação Direta", "2 - Estrangeira - Adquirida no Mercado Interno", "3 - Nacional - Mercadoria ou bem com Conteúdo de Importação superior a 40%", "4 - Nacional - Produção com processos produtivos básicos", "5 - Nacional - Mercadoria ou bem com Conteúdo de Importação inferior ou igual a 4" & _
                        "0%", "6 - Estrangeira - Importação direta, sem similar nacional", "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional"})
        Me.cboOriIcm2.Properties.MaxLength = 55
        Me.cboOriIcm2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOriIcm2.Size = New System.Drawing.Size(149, 20)
        Me.cboOriIcm2.TabIndex = 3
        Me.cboOriIcm2.Tag = "Grupo"
        Me.cboOriIcm2.Visible = False
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(755, 61)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl28.TabIndex = 49
        Me.LabelControl28.Text = "CST ICMS"
        Me.LabelControl28.Visible = False
        '
        'cboCst2
        '
        Me.cboCst2.EnterMoveNextControl = True
        Me.cboCst2.Location = New System.Drawing.Point(809, 58)
        Me.cboCst2.Name = "cboCst2"
        Me.cboCst2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCst2.Properties.MaxLength = 55
        Me.cboCst2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCst2.Size = New System.Drawing.Size(149, 20)
        Me.cboCst2.TabIndex = 2
        Me.cboCst2.Tag = "Grupo"
        Me.cboCst2.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(26, 35)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl10.TabIndex = 39
        Me.LabelControl10.Text = "Alíquota %"
        '
        'cboTrib
        '
        Me.cboTrib.EnterMoveNextControl = True
        Me.cboTrib.Location = New System.Drawing.Point(185, 6)
        Me.cboTrib.Name = "cboTrib"
        Me.cboTrib.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTrib.Properties.Items.AddRange(New Object() {"T", "F", "I", "N"})
        Me.cboTrib.Properties.MaxLength = 55
        Me.cboTrib.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTrib.Size = New System.Drawing.Size(50, 20)
        Me.cboTrib.TabIndex = 46
        Me.cboTrib.Tag = "Tributação"
        '
        'cboOriIcm
        '
        Me.cboOriIcm.EnterMoveNextControl = True
        Me.cboOriIcm.Location = New System.Drawing.Point(908, 84)
        Me.cboOriIcm.Name = "cboOriIcm"
        Me.cboOriIcm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOriIcm.Properties.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cboOriIcm.Properties.MaxLength = 55
        Me.cboOriIcm.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOriIcm.Size = New System.Drawing.Size(50, 20)
        Me.cboOriIcm.TabIndex = 48
        Me.cboOriIcm.Tag = "Origem ICMS"
        Me.cboOriIcm.Visible = False
        '
        'cboCst
        '
        Me.cboCst.EnterMoveNextControl = True
        Me.cboCst.Location = New System.Drawing.Point(908, 58)
        Me.cboCst.Name = "cboCst"
        Me.cboCst.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCst.Properties.MaxLength = 55
        Me.cboCst.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCst.Size = New System.Drawing.Size(50, 20)
        Me.cboCst.TabIndex = 47
        Me.cboCst.Tag = "CST ICMS"
        Me.cboCst.Visible = False
        '
        'txtIPI
        '
        Me.txtIPI.EnterMoveNextControl = True
        Me.txtIPI.Location = New System.Drawing.Point(896, 170)
        Me.txtIPI.Name = "txtIPI"
        Me.txtIPI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIPI.Properties.MaxLength = 5
        Me.txtIPI.Size = New System.Drawing.Size(100, 20)
        Me.txtIPI.TabIndex = 21
        Me.txtIPI.Tag = "Tabela 1 - Valor R$"
        Me.txtIPI.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(838, 175)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl12.TabIndex = 20
        Me.LabelControl12.Text = "Aliq. IPI %"
        Me.LabelControl12.Visible = False
        '
        'tabNfe
        '
        Me.tabNfe.Controls.Add(Me.btnSalvarTributacao)
        Me.tabNfe.Controls.Add(Me.cboTipoFiscal)
        Me.tabNfe.Controls.Add(Me.LabelControl96)
        Me.tabNfe.Controls.Add(Me.XtraTabControl1)
        Me.tabNfe.Controls.Add(Me.txtCest)
        Me.tabNfe.Controls.Add(Me.LabelControl9)
        Me.tabNfe.Controls.Add(Me.btnTribPadrao)
        Me.tabNfe.Controls.Add(Me.btnInsNfeTodos)
        Me.tabNfe.Controls.Add(Me.cboCodigoANP)
        Me.tabNfe.Controls.Add(Me.LabelControl70)
        Me.tabNfe.Controls.Add(Me.cboUF)
        Me.tabNfe.Controls.Add(Me.LabelControl69)
        Me.tabNfe.Controls.Add(Me.lueCFOP)
        Me.tabNfe.Controls.Add(Me.txtGenero)
        Me.tabNfe.Controls.Add(Me.txtEXTIPI)
        Me.tabNfe.Controls.Add(Me.LabelControl48)
        Me.tabNfe.Controls.Add(Me.txtNfeNCM)
        Me.tabNfe.Controls.Add(Me.LabelControl47)
        Me.tabNfe.Controls.Add(Me.LabelControl57)
        Me.tabNfe.Controls.Add(Me.LabelControl56)
        Me.tabNfe.Controls.Add(Me.LabelControl23)
        Me.tabNfe.Controls.Add(Me.GroupControl4)
        Me.tabNfe.Controls.Add(Me.LabelControl59)
        Me.tabNfe.Controls.Add(Me.LabelControl43)
        Me.tabNfe.Controls.Add(Me.cboRegime)
        Me.tabNfe.Controls.Add(Me.LabelControl45)
        Me.tabNfe.Controls.Add(Me.LabelControl60)
        Me.tabNfe.Controls.Add(Me.LabelControl46)
        Me.tabNfe.Controls.Add(Me.LabelControl44)
        Me.tabNfe.Controls.Add(Me.LabelControl42)
        Me.tabNfe.Name = "tabNfe"
        Me.tabNfe.Size = New System.Drawing.Size(999, 236)
        Me.tabNfe.Text = "NF-e"
        '
        'btnSalvarTributacao
        '
        Me.btnSalvarTributacao.AllowFocus = False
        Me.btnSalvarTributacao.Location = New System.Drawing.Point(846, 56)
        Me.btnSalvarTributacao.Name = "btnSalvarTributacao"
        Me.btnSalvarTributacao.Size = New System.Drawing.Size(139, 23)
        Me.btnSalvarTributacao.TabIndex = 73
        Me.btnSalvarTributacao.Text = "Salvar Tributação"
        '
        'cboTipoFiscal
        '
        Me.cboTipoFiscal.EnterMoveNextControl = True
        Me.cboTipoFiscal.Location = New System.Drawing.Point(97, 7)
        Me.cboTipoFiscal.Name = "cboTipoFiscal"
        Me.cboTipoFiscal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoFiscal.Properties.Items.AddRange(New Object() {"AMBOS", "NFE", "SAT"})
        Me.cboTipoFiscal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoFiscal.Size = New System.Drawing.Size(138, 20)
        Me.cboTipoFiscal.TabIndex = 72
        Me.cboTipoFiscal.Tag = "Origem"
        '
        'LabelControl96
        '
        Me.LabelControl96.Location = New System.Drawing.Point(71, 10)
        Me.LabelControl96.Name = "LabelControl96"
        Me.LabelControl96.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl96.TabIndex = 71
        Me.LabelControl96.Text = "Tipo"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 59)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(999, 177)
        Me.XtraTabControl1.TabIndex = 70
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.ForeColor = System.Drawing.Color.Navy
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage3.Controls.Add(Me.tabImpostos)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(990, 146)
        Me.XtraTabPage3.Text = "Simples Nacional"
        '
        'tabImpostos
        '
        Me.tabImpostos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabImpostos.Appearance.Options.UseFont = True
        Me.tabImpostos.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabImpostos.AppearancePage.Header.ForeColor = System.Drawing.Color.Navy
        Me.tabImpostos.AppearancePage.Header.Options.UseFont = True
        Me.tabImpostos.AppearancePage.Header.Options.UseForeColor = True
        Me.tabImpostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabImpostos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabImpostos.Location = New System.Drawing.Point(0, 0)
        Me.tabImpostos.Name = "tabImpostos"
        Me.tabImpostos.SelectedTabPage = Me.tabICMS
        Me.tabImpostos.Size = New System.Drawing.Size(990, 146)
        Me.tabImpostos.TabIndex = 3
        Me.tabImpostos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabICMS, Me.tabIPI, Me.tabPIS, Me.tabCofins, Me.XtraTabPage2})
        Me.tabImpostos.Tag = "IPI CST"
        '
        'tabICMS
        '
        Me.tabICMS.Controls.Add(Me.LabelControl55)
        Me.tabICMS.Controls.Add(Me.cboModBC)
        Me.tabICMS.Controls.Add(Me.txtICMSST)
        Me.tabICMS.Controls.Add(Me.cboModBCST)
        Me.tabICMS.Controls.Add(Me.txtCalcCred)
        Me.tabICMS.Controls.Add(Me.LabelControl50)
        Me.tabICMS.Controls.Add(Me.txtNfeICMS)
        Me.tabICMS.Controls.Add(Me.txtRedBCST)
        Me.tabICMS.Controls.Add(Me.LabelControl49)
        Me.tabICMS.Controls.Add(Me.LabelControl51)
        Me.tabICMS.Controls.Add(Me.LabelControl58)
        Me.tabICMS.Controls.Add(Me.txtMVAST)
        Me.tabICMS.Controls.Add(Me.txtRedBC)
        Me.tabICMS.Controls.Add(Me.LabelControl52)
        Me.tabICMS.Controls.Add(Me.LabelControl40)
        Me.tabICMS.Controls.Add(Me.LabelControl54)
        Me.tabICMS.Controls.Add(Me.LabelControl39)
        Me.tabICMS.Controls.Add(Me.LabelControl53)
        Me.tabICMS.Controls.Add(Me.cboOrigem)
        Me.tabICMS.Controls.Add(Me.PanelControl6)
        Me.tabICMS.Controls.Add(Me.lblCST)
        Me.tabICMS.Controls.Add(Me.PanelControl7)
        Me.tabICMS.Controls.Add(Me.LabelControl38)
        Me.tabICMS.Controls.Add(Me.cboNfeCST)
        Me.tabICMS.Name = "tabICMS"
        Me.tabICMS.Size = New System.Drawing.Size(981, 115)
        Me.tabICMS.Text = "ICMS"
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(535, 96)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl55.TabIndex = 30
        Me.LabelControl55.Text = "ICMS ST"
        '
        'cboModBC
        '
        Me.cboModBC.EnterMoveNextControl = True
        Me.cboModBC.Location = New System.Drawing.Point(91, 41)
        Me.cboModBC.Name = "cboModBC"
        Me.cboModBC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBC.Properties.Items.AddRange(New Object() {"", "0 - Margem Valor Agregado (%)", "1 - Pauta (Valor)", "2 - Preço Tabelado Máx. (valor)", "3 - valor da operação"})
        Me.cboModBC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBC.Size = New System.Drawing.Size(391, 20)
        Me.cboModBC.TabIndex = 0
        '
        'txtICMSST
        '
        Me.txtICMSST.CasasDecimais = 2
        Me.txtICMSST.EnterMoveNextControl = True
        Me.txtICMSST.Location = New System.Drawing.Point(581, 93)
        Me.txtICMSST.Name = "txtICMSST"
        Me.txtICMSST.Numerico = True
        Me.txtICMSST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtICMSST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtICMSST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtICMSST.Properties.MaxLength = 5
        Me.txtICMSST.Size = New System.Drawing.Size(138, 20)
        Me.txtICMSST.TabIndex = 3
        '
        'cboModBCST
        '
        Me.cboModBCST.EnterMoveNextControl = True
        Me.cboModBCST.Location = New System.Drawing.Point(581, 41)
        Me.cboModBCST.Name = "cboModBCST"
        Me.cboModBCST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBCST.Properties.Items.AddRange(New Object() {"", "0 – Preço tabelado ou máximo sugerido", "1 - Lista Negativa (valor)", "2 - Lista Positiva (valor)", "3 - Lista Neutra (valor)", "4 - Margem Valor Agregado (%)", "5 - Pauta (valor)"})
        Me.cboModBCST.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBCST.Size = New System.Drawing.Size(394, 20)
        Me.cboModBCST.TabIndex = 0
        '
        'txtCalcCred
        '
        Me.txtCalcCred.CasasDecimais = 2
        Me.txtCalcCred.EnterMoveNextControl = True
        Me.txtCalcCred.Location = New System.Drawing.Point(843, 5)
        Me.txtCalcCred.Name = "txtCalcCred"
        Me.txtCalcCred.Numerico = True
        Me.txtCalcCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCalcCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCalcCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalcCred.Properties.MaxLength = 5
        Me.txtCalcCred.Size = New System.Drawing.Size(132, 20)
        Me.txtCalcCred.TabIndex = 3
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(520, 44)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl50.TabIndex = 24
        Me.LabelControl50.Text = "Mod. BC ST"
        '
        'txtNfeICMS
        '
        Me.txtNfeICMS.CasasDecimais = 2
        Me.txtNfeICMS.EnterMoveNextControl = True
        Me.txtNfeICMS.Location = New System.Drawing.Point(91, 93)
        Me.txtNfeICMS.Name = "txtNfeICMS"
        Me.txtNfeICMS.Numerico = True
        Me.txtNfeICMS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNfeICMS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNfeICMS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNfeICMS.Properties.MaxLength = 5
        Me.txtNfeICMS.Size = New System.Drawing.Size(138, 20)
        Me.txtNfeICMS.TabIndex = 2
        '
        'txtRedBCST
        '
        Me.txtRedBCST.CasasDecimais = 2
        Me.txtRedBCST.EnterMoveNextControl = True
        Me.txtRedBCST.Location = New System.Drawing.Point(581, 67)
        Me.txtRedBCST.Name = "txtRedBCST"
        Me.txtRedBCST.Numerico = True
        Me.txtRedBCST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBCST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBCST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBCST.Properties.MaxLength = 5
        Me.txtRedBCST.Size = New System.Drawing.Size(138, 20)
        Me.txtRedBCST.TabIndex = 1
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(46, 70)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl49.TabIndex = 22
        Me.LabelControl49.Text = "Red. BC"
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(521, 70)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl51.TabIndex = 27
        Me.LabelControl51.Text = "Red. BC ST"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(768, 8)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl58.TabIndex = 36
        Me.LabelControl58.Text = "Calc. do Créd."
        '
        'txtMVAST
        '
        Me.txtMVAST.CasasDecimais = 2
        Me.txtMVAST.EnterMoveNextControl = True
        Me.txtMVAST.Location = New System.Drawing.Point(843, 67)
        Me.txtMVAST.Name = "txtMVAST"
        Me.txtMVAST.Numerico = True
        Me.txtMVAST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMVAST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMVAST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMVAST.Properties.MaxLength = 5
        Me.txtMVAST.Size = New System.Drawing.Size(132, 20)
        Me.txtMVAST.TabIndex = 2
        '
        'txtRedBC
        '
        Me.txtRedBC.CasasDecimais = 2
        Me.txtRedBC.EnterMoveNextControl = True
        Me.txtRedBC.Location = New System.Drawing.Point(91, 67)
        Me.txtRedBC.Name = "txtRedBC"
        Me.txtRedBC.Numerico = True
        Me.txtRedBC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBC.Properties.MaxLength = 5
        Me.txtRedBC.Size = New System.Drawing.Size(138, 20)
        Me.txtRedBC.TabIndex = 1
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(783, 70)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl52.TabIndex = 29
        Me.LabelControl52.Text = "M. V. A. ST"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(45, 44)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl40.TabIndex = 3
        Me.LabelControl40.Text = "Mod. BC"
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl54.Appearance.Options.UseFont = True
        Me.LabelControl54.Location = New System.Drawing.Point(503, 26)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl54.TabIndex = 33
        Me.LabelControl54.Text = "ICMS ST"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(60, 96)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl39.TabIndex = 2
        Me.LabelControl39.Text = "ICMS"
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl53.Appearance.Options.UseFont = True
        Me.LabelControl53.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl53.TabIndex = 32
        Me.LabelControl53.Text = "ICMS"
        '
        'cboOrigem
        '
        Me.cboOrigem.EnterMoveNextControl = True
        Me.cboOrigem.Location = New System.Drawing.Point(581, 5)
        Me.cboOrigem.Name = "cboOrigem"
        Me.cboOrigem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrigem.Properties.Items.AddRange(New Object() {"", "0 - Nacional", "1 - Estrangeira – Importação direta", "2 - Estrangeira – Adquirida no mercado interno", "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quaren" & _
                        "ta por cento)", "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos pro" & _
                        "dutivos básicos de que tratam as legislações citadas nos ajustes", "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40" & _
                        "% (quarenta por cento)", "6 - Estrangeira - Importação direta, sem similar nacional, constante em lista de " & _
                        "Resolução CAMEX", "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante e" & _
                        "m lista de Resolução CAMEX"})
        Me.cboOrigem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOrigem.Size = New System.Drawing.Size(138, 20)
        Me.cboOrigem.TabIndex = 2
        Me.cboOrigem.Tag = "Origem"
        '
        'PanelControl6
        '
        Me.PanelControl6.Location = New System.Drawing.Point(494, 31)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(487, 5)
        Me.PanelControl6.TabIndex = 5
        '
        'lblCST
        '
        Me.lblCST.Location = New System.Drawing.Point(51, 8)
        Me.lblCST.Name = "lblCST"
        Me.lblCST.Size = New System.Drawing.Size(34, 13)
        Me.lblCST.TabIndex = 4
        Me.lblCST.Text = "CSOSN"
        '
        'PanelControl7
        '
        Me.PanelControl7.Location = New System.Drawing.Point(4, 31)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(484, 5)
        Me.PanelControl7.TabIndex = 4
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(542, 8)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl38.TabIndex = 1
        Me.LabelControl38.Text = "Origem"
        '
        'cboNfeCST
        '
        Me.cboNfeCST.EnterMoveNextControl = True
        Me.cboNfeCST.Location = New System.Drawing.Point(91, 5)
        Me.cboNfeCST.Name = "cboNfeCST"
        Me.cboNfeCST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNfeCST.Properties.Items.AddRange(New Object() {"101 - Tributada com permissão de crédito", "102 - Tributada sem permissão de crédito", "103 - Isenção do ICMS para faixa de receita bruta", "201 - Tributada com permissão de crédito e com cobrança do ICMS por ST", "202 - Tributada sem permissão de crédito e com cobrança do ICMS por ST", "203 - Isenção do ICMS para faixa de receita bruta e com cobrança do ICMS por ST", "300 - Imune", "400 - Não Tributada", "500 - ICMS cobrado anteriormente por ST ou por antecipação", "900 - Outros"})
        Me.cboNfeCST.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNfeCST.Size = New System.Drawing.Size(391, 20)
        Me.cboNfeCST.TabIndex = 1
        Me.cboNfeCST.Tag = "ICMS CST"
        '
        'tabIPI
        '
        Me.tabIPI.Controls.Add(Me.txtCodEnq)
        Me.tabIPI.Controls.Add(Me.txtAliquotaIPI)
        Me.tabIPI.Controls.Add(Me.LabelControl27)
        Me.tabIPI.Controls.Add(Me.LabelControl26)
        Me.tabIPI.Controls.Add(Me.LabelControl24)
        Me.tabIPI.Controls.Add(Me.cboCSTIPI)
        Me.tabIPI.Name = "tabIPI"
        Me.tabIPI.Size = New System.Drawing.Size(981, 115)
        Me.tabIPI.Text = "IPI"
        '
        'txtCodEnq
        '
        Me.txtCodEnq.CasasDecimais = 0
        Me.txtCodEnq.EnterMoveNextControl = True
        Me.txtCodEnq.Location = New System.Drawing.Point(91, 35)
        Me.txtCodEnq.Name = "txtCodEnq"
        Me.txtCodEnq.Numerico = False
        Me.txtCodEnq.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodEnq.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCodEnq.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodEnq.Properties.MaxLength = 16
        Me.txtCodEnq.Size = New System.Drawing.Size(130, 20)
        Me.txtCodEnq.TabIndex = 1
        Me.txtCodEnq.Tag = "IPI Alíquota"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.CasasDecimais = 2
        Me.txtAliquotaIPI.EnterMoveNextControl = True
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(359, 35)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Numerico = True
        Me.txtAliquotaIPI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaIPI.Properties.MaxLength = 16
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaIPI.TabIndex = 2
        Me.txtAliquotaIPI.Tag = "IPI Alíquota"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(19, 38)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl27.TabIndex = 8
        Me.LabelControl27.Text = "Cód. Enquad."
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(314, 38)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl26.TabIndex = 7
        Me.LabelControl26.Tag = "IPI Alíquota"
        Me.LabelControl26.Text = "Alíquota"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl24.TabIndex = 5
        Me.LabelControl24.Text = "CST"
        '
        'cboCSTIPI
        '
        Me.cboCSTIPI.EnterMoveNextControl = True
        Me.cboCSTIPI.Location = New System.Drawing.Point(91, 9)
        Me.cboCSTIPI.Name = "cboCSTIPI"
        Me.cboCSTIPI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTIPI.Properties.Items.AddRange(New Object() {"", "00 - Entrada com Recuperação de Crédito", "01 - Entrada Tributável com Alíquota Zero", "02 - Entrada Isenta", "03 - Entrada Não-Tributada", "04 - Entrada Imune", "05 - Entrada com Suspensão", "49 - Outras Entradas", "50 - Saída Tributada", "51 - Saída Tributável com Alíquota Zero", "52 - Saida Isenta", "53 - Saída Não-Tributada", "54 - Saída Imune", "55 - Saída com Suspensão", "99 - Outras Saídas"})
        Me.cboCSTIPI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTIPI.Size = New System.Drawing.Size(884, 20)
        Me.cboCSTIPI.TabIndex = 0
        Me.cboCSTIPI.Tag = "IPI CST"
        '
        'tabPIS
        '
        Me.tabPIS.Controls.Add(Me.txtAliquotaPIS)
        Me.tabPIS.Controls.Add(Me.LabelControl62)
        Me.tabPIS.Controls.Add(Me.LabelControl64)
        Me.tabPIS.Controls.Add(Me.cboCSTPIS)
        Me.tabPIS.Name = "tabPIS"
        Me.tabPIS.Size = New System.Drawing.Size(981, 115)
        Me.tabPIS.Text = "PIS"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.CasasDecimais = 2
        Me.txtAliquotaPIS.EnterMoveNextControl = True
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(91, 35)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Numerico = True
        Me.txtAliquotaPIS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaPIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaPIS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaPIS.Properties.MaxLength = 16
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaPIS.TabIndex = 1
        Me.txtAliquotaPIS.Tag = "PIS Alíquota"
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(46, 38)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl62.TabIndex = 16
        Me.LabelControl62.Text = "Alíquota"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl64.TabIndex = 14
        Me.LabelControl64.Text = "CST"
        '
        'cboCSTPIS
        '
        Me.cboCSTPIS.EnterMoveNextControl = True
        Me.cboCSTPIS.Location = New System.Drawing.Point(91, 9)
        Me.cboCSTPIS.Name = "cboCSTPIS"
        Me.cboCSTPIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTPIS.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno, e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno, e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCSTPIS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTPIS.Size = New System.Drawing.Size(884, 20)
        Me.cboCSTPIS.TabIndex = 0
        Me.cboCSTPIS.Tag = "PIS CST"
        '
        'tabCofins
        '
        Me.tabCofins.Controls.Add(Me.txtAliquotaCOFINS)
        Me.tabCofins.Controls.Add(Me.LabelControl66)
        Me.tabCofins.Controls.Add(Me.LabelControl68)
        Me.tabCofins.Controls.Add(Me.cboCSTCOFINS)
        Me.tabCofins.Name = "tabCofins"
        Me.tabCofins.Size = New System.Drawing.Size(981, 115)
        Me.tabCofins.Text = "COFINS"
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.CasasDecimais = 2
        Me.txtAliquotaCOFINS.EnterMoveNextControl = True
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(91, 35)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Numerico = True
        Me.txtAliquotaCOFINS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaCOFINS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaCOFINS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaCOFINS.Properties.MaxLength = 16
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaCOFINS.TabIndex = 1
        Me.txtAliquotaCOFINS.Tag = "CONFINS Alíquota"
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(46, 38)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl66.TabIndex = 24
        Me.LabelControl66.Text = "Alíquota"
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl68.TabIndex = 22
        Me.LabelControl68.Text = "CST"
        '
        'cboCSTCOFINS
        '
        Me.cboCSTCOFINS.EnterMoveNextControl = True
        Me.cboCSTCOFINS.Location = New System.Drawing.Point(91, 9)
        Me.cboCSTCOFINS.Name = "cboCSTCOFINS"
        Me.cboCSTCOFINS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTCOFINS.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não-Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCSTCOFINS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTCOFINS.Size = New System.Drawing.Size(884, 20)
        Me.cboCSTCOFINS.TabIndex = 0
        Me.cboCSTCOFINS.Tag = "COFINS CST"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtPerICMSUF)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage2.Controls.Add(Me.txtPerFCPUF)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage2.Text = "ICMS UF Destino"
        '
        'txtPerICMSUF
        '
        Me.txtPerICMSUF.CasasDecimais = 2
        Me.txtPerICMSUF.EnterMoveNextControl = True
        Me.txtPerICMSUF.Location = New System.Drawing.Point(91, 35)
        Me.txtPerICMSUF.Name = "txtPerICMSUF"
        Me.txtPerICMSUF.Numerico = True
        Me.txtPerICMSUF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerICMSUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerICMSUF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerICMSUF.Properties.MaxLength = 16
        Me.txtPerICMSUF.Size = New System.Drawing.Size(130, 20)
        Me.txtPerICMSUF.TabIndex = 27
        Me.txtPerICMSUF.Tag = "CONFINS Alíquota"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(38, 12)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl22.TabIndex = 28
        Me.LabelControl22.Text = "Perc. FCP"
        '
        'txtPerFCPUF
        '
        Me.txtPerFCPUF.CasasDecimais = 2
        Me.txtPerFCPUF.EnterMoveNextControl = True
        Me.txtPerFCPUF.Location = New System.Drawing.Point(91, 9)
        Me.txtPerFCPUF.Name = "txtPerFCPUF"
        Me.txtPerFCPUF.Numerico = True
        Me.txtPerFCPUF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerFCPUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerFCPUF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerFCPUF.Properties.MaxLength = 16
        Me.txtPerFCPUF.Size = New System.Drawing.Size(130, 20)
        Me.txtPerFCPUF.TabIndex = 25
        Me.txtPerFCPUF.Tag = "CONFINS Alíquota"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(32, 38)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl19.TabIndex = 26
        Me.LabelControl19.Text = "Perc. ICMS"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage4.Appearance.Header.ForeColor = System.Drawing.Color.Black
        Me.XtraTabPage4.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage4.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage4.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(990, 146)
        Me.XtraTabPage4.Text = "Tributação Normal"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl2.Appearance.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl2.AppearancePage.Header.ForeColor = System.Drawing.Color.Black
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Options.UseForeColor = True
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl2.Size = New System.Drawing.Size(990, 146)
        Me.XtraTabControl2.TabIndex = 4
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        Me.XtraTabControl2.Tag = "IPI CST"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.LabelControl65)
        Me.XtraTabPage5.Controls.Add(Me.cboModBcTN)
        Me.XtraTabPage5.Controls.Add(Me.txtIcmsStTN)
        Me.XtraTabPage5.Controls.Add(Me.cboModBcStTN)
        Me.XtraTabPage5.Controls.Add(Me.txtCalcCredTN)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl67)
        Me.XtraTabPage5.Controls.Add(Me.txtIcmsTN)
        Me.XtraTabPage5.Controls.Add(Me.txtRedBcStTN)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl71)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl72)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl73)
        Me.XtraTabPage5.Controls.Add(Me.txtMvaStTN)
        Me.XtraTabPage5.Controls.Add(Me.txtRedBcTN)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl74)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl76)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl77)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl78)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl79)
        Me.XtraTabPage5.Controls.Add(Me.cboOrigemTN)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl80)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl13)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl81)
        Me.XtraTabPage5.Controls.Add(Me.cboCstTN)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage5.Text = "ICMS"
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(535, 96)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl65.TabIndex = 30
        Me.LabelControl65.Text = "ICMS ST"
        '
        'cboModBcTN
        '
        Me.cboModBcTN.EnterMoveNextControl = True
        Me.cboModBcTN.Location = New System.Drawing.Point(91, 41)
        Me.cboModBcTN.Name = "cboModBcTN"
        Me.cboModBcTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBcTN.Properties.Items.AddRange(New Object() {"", "0 - Margem Valor Agregado (%)", "1 - Pauta (Valor)", "2 - Preço Tabelado Máx. (valor)", "3 - valor da operação"})
        Me.cboModBcTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBcTN.Size = New System.Drawing.Size(391, 20)
        Me.cboModBcTN.TabIndex = 0
        '
        'txtIcmsStTN
        '
        Me.txtIcmsStTN.CasasDecimais = 2
        Me.txtIcmsStTN.EnterMoveNextControl = True
        Me.txtIcmsStTN.Location = New System.Drawing.Point(581, 93)
        Me.txtIcmsStTN.Name = "txtIcmsStTN"
        Me.txtIcmsStTN.Numerico = True
        Me.txtIcmsStTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIcmsStTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIcmsStTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIcmsStTN.Properties.MaxLength = 5
        Me.txtIcmsStTN.Size = New System.Drawing.Size(138, 20)
        Me.txtIcmsStTN.TabIndex = 3
        '
        'cboModBcStTN
        '
        Me.cboModBcStTN.EnterMoveNextControl = True
        Me.cboModBcStTN.Location = New System.Drawing.Point(581, 41)
        Me.cboModBcStTN.Name = "cboModBcStTN"
        Me.cboModBcStTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBcStTN.Properties.Items.AddRange(New Object() {"", "0 – Preço tabelado ou máximo sugerido", "1 - Lista Negativa (valor)", "2 - Lista Positiva (valor)", "3 - Lista Neutra (valor)", "4 - Margem Valor Agregado (%)", "5 - Pauta (valor)"})
        Me.cboModBcStTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBcStTN.Size = New System.Drawing.Size(394, 20)
        Me.cboModBcStTN.TabIndex = 0
        '
        'txtCalcCredTN
        '
        Me.txtCalcCredTN.CasasDecimais = 2
        Me.txtCalcCredTN.EnterMoveNextControl = True
        Me.txtCalcCredTN.Location = New System.Drawing.Point(843, 5)
        Me.txtCalcCredTN.Name = "txtCalcCredTN"
        Me.txtCalcCredTN.Numerico = True
        Me.txtCalcCredTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCalcCredTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCalcCredTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalcCredTN.Properties.MaxLength = 5
        Me.txtCalcCredTN.Size = New System.Drawing.Size(132, 20)
        Me.txtCalcCredTN.TabIndex = 3
        '
        'LabelControl67
        '
        Me.LabelControl67.Location = New System.Drawing.Point(520, 44)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl67.TabIndex = 24
        Me.LabelControl67.Text = "Mod. BC ST"
        '
        'txtIcmsTN
        '
        Me.txtIcmsTN.CasasDecimais = 2
        Me.txtIcmsTN.EnterMoveNextControl = True
        Me.txtIcmsTN.Location = New System.Drawing.Point(91, 93)
        Me.txtIcmsTN.Name = "txtIcmsTN"
        Me.txtIcmsTN.Numerico = True
        Me.txtIcmsTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIcmsTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIcmsTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIcmsTN.Properties.MaxLength = 5
        Me.txtIcmsTN.Size = New System.Drawing.Size(138, 20)
        Me.txtIcmsTN.TabIndex = 2
        '
        'txtRedBcStTN
        '
        Me.txtRedBcStTN.CasasDecimais = 2
        Me.txtRedBcStTN.EnterMoveNextControl = True
        Me.txtRedBcStTN.Location = New System.Drawing.Point(581, 67)
        Me.txtRedBcStTN.Name = "txtRedBcStTN"
        Me.txtRedBcStTN.Numerico = True
        Me.txtRedBcStTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBcStTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBcStTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBcStTN.Properties.MaxLength = 5
        Me.txtRedBcStTN.Size = New System.Drawing.Size(138, 20)
        Me.txtRedBcStTN.TabIndex = 1
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(46, 70)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl71.TabIndex = 22
        Me.LabelControl71.Text = "Red. BC"
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(521, 70)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl72.TabIndex = 27
        Me.LabelControl72.Text = "Red. BC ST"
        '
        'LabelControl73
        '
        Me.LabelControl73.Location = New System.Drawing.Point(768, 8)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl73.TabIndex = 36
        Me.LabelControl73.Text = "Calc. do Créd."
        '
        'txtMvaStTN
        '
        Me.txtMvaStTN.CasasDecimais = 2
        Me.txtMvaStTN.EnterMoveNextControl = True
        Me.txtMvaStTN.Location = New System.Drawing.Point(843, 67)
        Me.txtMvaStTN.Name = "txtMvaStTN"
        Me.txtMvaStTN.Numerico = True
        Me.txtMvaStTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMvaStTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMvaStTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMvaStTN.Properties.MaxLength = 5
        Me.txtMvaStTN.Size = New System.Drawing.Size(132, 20)
        Me.txtMvaStTN.TabIndex = 2
        '
        'txtRedBcTN
        '
        Me.txtRedBcTN.CasasDecimais = 2
        Me.txtRedBcTN.EnterMoveNextControl = True
        Me.txtRedBcTN.Location = New System.Drawing.Point(91, 67)
        Me.txtRedBcTN.Name = "txtRedBcTN"
        Me.txtRedBcTN.Numerico = True
        Me.txtRedBcTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBcTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBcTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBcTN.Properties.MaxLength = 5
        Me.txtRedBcTN.Size = New System.Drawing.Size(138, 20)
        Me.txtRedBcTN.TabIndex = 1
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(783, 70)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl74.TabIndex = 29
        Me.LabelControl74.Text = "M. V. A. ST"
        '
        'LabelControl76
        '
        Me.LabelControl76.Location = New System.Drawing.Point(45, 44)
        Me.LabelControl76.Name = "LabelControl76"
        Me.LabelControl76.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl76.TabIndex = 3
        Me.LabelControl76.Text = "Mod. BC"
        '
        'LabelControl77
        '
        Me.LabelControl77.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl77.Appearance.Options.UseFont = True
        Me.LabelControl77.Location = New System.Drawing.Point(503, 26)
        Me.LabelControl77.Name = "LabelControl77"
        Me.LabelControl77.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl77.TabIndex = 33
        Me.LabelControl77.Text = "ICMS ST"
        '
        'LabelControl78
        '
        Me.LabelControl78.Location = New System.Drawing.Point(60, 96)
        Me.LabelControl78.Name = "LabelControl78"
        Me.LabelControl78.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl78.TabIndex = 2
        Me.LabelControl78.Text = "ICMS"
        '
        'LabelControl79
        '
        Me.LabelControl79.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl79.Appearance.Options.UseFont = True
        Me.LabelControl79.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl79.Name = "LabelControl79"
        Me.LabelControl79.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl79.TabIndex = 32
        Me.LabelControl79.Text = "ICMS"
        '
        'cboOrigemTN
        '
        Me.cboOrigemTN.EnterMoveNextControl = True
        Me.cboOrigemTN.Location = New System.Drawing.Point(581, 5)
        Me.cboOrigemTN.Name = "cboOrigemTN"
        Me.cboOrigemTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrigemTN.Properties.Items.AddRange(New Object() {"", "0 - Nacional", "1 - Estrangeira – Importação direta", "2 - Estrangeira – Adquirida no mercado interno", "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quaren" & _
                        "ta por cento)", "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos pro" & _
                        "dutivos básicos de que tratam as legislações citadas nos ajustes", "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40" & _
                        "% (quarenta por cento)", "6 - Estrangeira - Importação direta, sem similar nacional, constante em lista de " & _
                        "Resolução CAMEX", "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante e" & _
                        "m lista de Resolução CAMEX"})
        Me.cboOrigemTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOrigemTN.Size = New System.Drawing.Size(138, 20)
        Me.cboOrigemTN.TabIndex = 2
        Me.cboOrigemTN.Tag = "Origem"
        '
        'PanelControl9
        '
        Me.PanelControl9.Location = New System.Drawing.Point(494, 31)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(487, 5)
        Me.PanelControl9.TabIndex = 5
        '
        'LabelControl80
        '
        Me.LabelControl80.Location = New System.Drawing.Point(67, 8)
        Me.LabelControl80.Name = "LabelControl80"
        Me.LabelControl80.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl80.TabIndex = 4
        Me.LabelControl80.Text = "CST"
        '
        'PanelControl13
        '
        Me.PanelControl13.Location = New System.Drawing.Point(4, 31)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(484, 5)
        Me.PanelControl13.TabIndex = 4
        '
        'LabelControl81
        '
        Me.LabelControl81.Location = New System.Drawing.Point(542, 8)
        Me.LabelControl81.Name = "LabelControl81"
        Me.LabelControl81.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl81.TabIndex = 1
        Me.LabelControl81.Text = "Origem"
        '
        'cboCstTN
        '
        Me.cboCstTN.EnterMoveNextControl = True
        Me.cboCstTN.Location = New System.Drawing.Point(91, 5)
        Me.cboCstTN.Name = "cboCstTN"
        Me.cboCstTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCstTN.Properties.Items.AddRange(New Object() {"00 – Tributada integralmente", "10 - Tributada e com cobrança do ICMS por substituição tributária", "20 - Com redução de base de cálculo", "30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária", "40 - Isenta", "41 - Não tributada", "50 – Suspensão", "51 - Diferimento - A exigência do preenchimento das informações do ICMS diferido " & _
                        "fica à critério de cada UF", "60 - ICMS cobrado anteriormente por substituição tributária", "70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributári" & _
                        "a", "90 – Outros"})
        Me.cboCstTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCstTN.Size = New System.Drawing.Size(391, 20)
        Me.cboCstTN.TabIndex = 1
        Me.cboCstTN.Tag = "ICMS CST"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.txtCodEnqTN)
        Me.XtraTabPage6.Controls.Add(Me.txtAliquotaIpiTN)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl82)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl83)
        Me.XtraTabPage6.Controls.Add(Me.LabelControl84)
        Me.XtraTabPage6.Controls.Add(Me.cboCstIpiTN)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage6.Text = "IPI"
        '
        'txtCodEnqTN
        '
        Me.txtCodEnqTN.CasasDecimais = 0
        Me.txtCodEnqTN.EnterMoveNextControl = True
        Me.txtCodEnqTN.Location = New System.Drawing.Point(91, 35)
        Me.txtCodEnqTN.Name = "txtCodEnqTN"
        Me.txtCodEnqTN.Numerico = False
        Me.txtCodEnqTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodEnqTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCodEnqTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodEnqTN.Properties.MaxLength = 16
        Me.txtCodEnqTN.Size = New System.Drawing.Size(130, 20)
        Me.txtCodEnqTN.TabIndex = 1
        Me.txtCodEnqTN.Tag = "IPI Alíquota"
        '
        'txtAliquotaIpiTN
        '
        Me.txtAliquotaIpiTN.CasasDecimais = 2
        Me.txtAliquotaIpiTN.EnterMoveNextControl = True
        Me.txtAliquotaIpiTN.Location = New System.Drawing.Point(359, 35)
        Me.txtAliquotaIpiTN.Name = "txtAliquotaIpiTN"
        Me.txtAliquotaIpiTN.Numerico = True
        Me.txtAliquotaIpiTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaIpiTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaIpiTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaIpiTN.Properties.MaxLength = 16
        Me.txtAliquotaIpiTN.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaIpiTN.TabIndex = 2
        Me.txtAliquotaIpiTN.Tag = "IPI Alíquota"
        '
        'LabelControl82
        '
        Me.LabelControl82.Location = New System.Drawing.Point(19, 38)
        Me.LabelControl82.Name = "LabelControl82"
        Me.LabelControl82.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl82.TabIndex = 8
        Me.LabelControl82.Text = "Cód. Enquad."
        '
        'LabelControl83
        '
        Me.LabelControl83.Location = New System.Drawing.Point(314, 38)
        Me.LabelControl83.Name = "LabelControl83"
        Me.LabelControl83.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl83.TabIndex = 7
        Me.LabelControl83.Tag = "IPI Alíquota"
        Me.LabelControl83.Text = "Alíquota"
        '
        'LabelControl84
        '
        Me.LabelControl84.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl84.Name = "LabelControl84"
        Me.LabelControl84.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl84.TabIndex = 5
        Me.LabelControl84.Text = "CST"
        '
        'cboCstIpiTN
        '
        Me.cboCstIpiTN.EnterMoveNextControl = True
        Me.cboCstIpiTN.Location = New System.Drawing.Point(91, 9)
        Me.cboCstIpiTN.Name = "cboCstIpiTN"
        Me.cboCstIpiTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCstIpiTN.Properties.Items.AddRange(New Object() {"", "00 - Entrada com Recuperação de Crédito", "01 - Entrada Tributável com Alíquota Zero", "02 - Entrada Isenta", "03 - Entrada Não-Tributada", "04 - Entrada Imune", "05 - Entrada com Suspensão", "49 - Outras Entradas", "50 - Saída Tributada", "51 - Saída Tributável com Alíquota Zero", "52 - Saida Isenta", "53 - Saída Não-Tributada", "54 - Saída Imune", "55 - Saída com Suspensão", "99 - Outras Saídas"})
        Me.cboCstIpiTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCstIpiTN.Size = New System.Drawing.Size(884, 20)
        Me.cboCstIpiTN.TabIndex = 0
        Me.cboCstIpiTN.Tag = "IPI CST"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.txtAliquotaPisTN)
        Me.XtraTabPage7.Controls.Add(Me.LabelControl85)
        Me.XtraTabPage7.Controls.Add(Me.LabelControl86)
        Me.XtraTabPage7.Controls.Add(Me.cboCstPisTN)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage7.Text = "PIS"
        '
        'txtAliquotaPisTN
        '
        Me.txtAliquotaPisTN.CasasDecimais = 2
        Me.txtAliquotaPisTN.EnterMoveNextControl = True
        Me.txtAliquotaPisTN.Location = New System.Drawing.Point(91, 35)
        Me.txtAliquotaPisTN.Name = "txtAliquotaPisTN"
        Me.txtAliquotaPisTN.Numerico = True
        Me.txtAliquotaPisTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaPisTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaPisTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaPisTN.Properties.MaxLength = 16
        Me.txtAliquotaPisTN.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaPisTN.TabIndex = 1
        Me.txtAliquotaPisTN.Tag = "PIS Alíquota"
        '
        'LabelControl85
        '
        Me.LabelControl85.Location = New System.Drawing.Point(46, 38)
        Me.LabelControl85.Name = "LabelControl85"
        Me.LabelControl85.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl85.TabIndex = 16
        Me.LabelControl85.Text = "Alíquota"
        '
        'LabelControl86
        '
        Me.LabelControl86.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl86.Name = "LabelControl86"
        Me.LabelControl86.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl86.TabIndex = 14
        Me.LabelControl86.Text = "CST"
        '
        'cboCstPisTN
        '
        Me.cboCstPisTN.EnterMoveNextControl = True
        Me.cboCstPisTN.Location = New System.Drawing.Point(91, 9)
        Me.cboCstPisTN.Name = "cboCstPisTN"
        Me.cboCstPisTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCstPisTN.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno, e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno, e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCstPisTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCstPisTN.Size = New System.Drawing.Size(884, 20)
        Me.cboCstPisTN.TabIndex = 0
        Me.cboCstPisTN.Tag = "PIS CST"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.txtAliquotaCofinsTN)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl87)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl88)
        Me.XtraTabPage8.Controls.Add(Me.cboCstCofinsTN)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage8.Text = "COFINS"
        '
        'txtAliquotaCofinsTN
        '
        Me.txtAliquotaCofinsTN.CasasDecimais = 2
        Me.txtAliquotaCofinsTN.EnterMoveNextControl = True
        Me.txtAliquotaCofinsTN.Location = New System.Drawing.Point(91, 35)
        Me.txtAliquotaCofinsTN.Name = "txtAliquotaCofinsTN"
        Me.txtAliquotaCofinsTN.Numerico = True
        Me.txtAliquotaCofinsTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaCofinsTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaCofinsTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaCofinsTN.Properties.MaxLength = 16
        Me.txtAliquotaCofinsTN.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaCofinsTN.TabIndex = 1
        Me.txtAliquotaCofinsTN.Tag = "CONFINS Alíquota"
        '
        'LabelControl87
        '
        Me.LabelControl87.Location = New System.Drawing.Point(46, 38)
        Me.LabelControl87.Name = "LabelControl87"
        Me.LabelControl87.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl87.TabIndex = 24
        Me.LabelControl87.Text = "Alíquota"
        '
        'LabelControl88
        '
        Me.LabelControl88.Location = New System.Drawing.Point(66, 12)
        Me.LabelControl88.Name = "LabelControl88"
        Me.LabelControl88.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl88.TabIndex = 22
        Me.LabelControl88.Text = "CST"
        '
        'cboCstCofinsTN
        '
        Me.cboCstCofinsTN.EnterMoveNextControl = True
        Me.cboCstCofinsTN.Location = New System.Drawing.Point(91, 9)
        Me.cboCstCofinsTN.Name = "cboCstCofinsTN"
        Me.cboCstCofinsTN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCstCofinsTN.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não-Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCstCofinsTN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCstCofinsTN.Size = New System.Drawing.Size(884, 20)
        Me.cboCstCofinsTN.TabIndex = 0
        Me.cboCstCofinsTN.Tag = "COFINS CST"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.txtPercIcmsTN)
        Me.XtraTabPage9.Controls.Add(Me.LabelControl89)
        Me.XtraTabPage9.Controls.Add(Me.txtPercFcpTN)
        Me.XtraTabPage9.Controls.Add(Me.LabelControl90)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(981, 115)
        Me.XtraTabPage9.Text = "ICMS UF Destino"
        '
        'txtPercIcmsTN
        '
        Me.txtPercIcmsTN.CasasDecimais = 2
        Me.txtPercIcmsTN.EnterMoveNextControl = True
        Me.txtPercIcmsTN.Location = New System.Drawing.Point(91, 35)
        Me.txtPercIcmsTN.Name = "txtPercIcmsTN"
        Me.txtPercIcmsTN.Numerico = True
        Me.txtPercIcmsTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPercIcmsTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPercIcmsTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPercIcmsTN.Properties.MaxLength = 16
        Me.txtPercIcmsTN.Size = New System.Drawing.Size(130, 20)
        Me.txtPercIcmsTN.TabIndex = 27
        Me.txtPercIcmsTN.Tag = "CONFINS Alíquota"
        '
        'LabelControl89
        '
        Me.LabelControl89.Location = New System.Drawing.Point(38, 12)
        Me.LabelControl89.Name = "LabelControl89"
        Me.LabelControl89.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl89.TabIndex = 28
        Me.LabelControl89.Text = "Perc. FCP"
        '
        'txtPercFcpTN
        '
        Me.txtPercFcpTN.CasasDecimais = 2
        Me.txtPercFcpTN.EnterMoveNextControl = True
        Me.txtPercFcpTN.Location = New System.Drawing.Point(91, 9)
        Me.txtPercFcpTN.Name = "txtPercFcpTN"
        Me.txtPercFcpTN.Numerico = True
        Me.txtPercFcpTN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPercFcpTN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPercFcpTN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPercFcpTN.Properties.MaxLength = 16
        Me.txtPercFcpTN.Size = New System.Drawing.Size(130, 20)
        Me.txtPercFcpTN.TabIndex = 25
        Me.txtPercFcpTN.Tag = "CONFINS Alíquota"
        '
        'LabelControl90
        '
        Me.LabelControl90.Location = New System.Drawing.Point(32, 38)
        Me.LabelControl90.Name = "LabelControl90"
        Me.LabelControl90.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl90.TabIndex = 26
        Me.LabelControl90.Text = "Perc. ICMS"
        '
        'txtCest
        '
        Me.txtCest.CasasDecimais = 0
        Me.txtCest.EnterMoveNextControl = True
        Me.txtCest.Location = New System.Drawing.Point(587, 7)
        Me.txtCest.Name = "txtCest"
        Me.txtCest.Numerico = False
        Me.txtCest.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCest.Properties.MaxLength = 7
        Me.txtCest.Size = New System.Drawing.Size(138, 20)
        Me.txtCest.TabIndex = 2
        Me.txtCest.Tag = "NCM"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(556, 10)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 69
        Me.LabelControl9.Text = "CEST"
        '
        'btnTribPadrao
        '
        Me.btnTribPadrao.AllowFocus = False
        Me.btnTribPadrao.Location = New System.Drawing.Point(846, 4)
        Me.btnTribPadrao.Name = "btnTribPadrao"
        Me.btnTribPadrao.Size = New System.Drawing.Size(139, 23)
        Me.btnTribPadrao.TabIndex = 62
        Me.btnTribPadrao.Text = "Verificar Padrões"
        '
        'btnInsNfeTodos
        '
        Me.btnInsNfeTodos.AllowFocus = False
        Me.btnInsNfeTodos.Location = New System.Drawing.Point(846, 30)
        Me.btnInsNfeTodos.Name = "btnInsNfeTodos"
        Me.btnInsNfeTodos.Size = New System.Drawing.Size(139, 23)
        Me.btnInsNfeTodos.TabIndex = 61
        Me.btnInsNfeTodos.Text = "Inserir para Todos"
        '
        'cboCodigoANP
        '
        Me.cboCodigoANP.EnterMoveNextControl = True
        Me.cboCodigoANP.Location = New System.Drawing.Point(346, 33)
        Me.cboCodigoANP.Name = "cboCodigoANP"
        Me.cboCodigoANP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodigoANP.Properties.Items.AddRange(New Object() {"", "110203073 | ABO 3", "110204001 | ABOOZAR", "110204002 | ABU ASAFAH", "140101027 | ÁCIDO GRAXO DE ÓLEO DE PALMA / DENDÊ", "140101026 | ÁCIDO GRAXO DE ÓLEO DE SOJA", "740101005 | ADITIVOS PARA BIODIESEL", "740101004 | ADITIVOS PARA ETANOL HIDRATADO", "740101001 | ADITIVOS PARA GASOLINA", "740101006 | ADITIVOS PARA LUBRIFICANTES", "740101002 | ADITIVOS PARA ÓLEO DIESEL", "110203083 | AGBAMI", "910101001 | ÁGUA", "110103001 | ÁGUA GRANDE", "330101001 | AGUARRÁS MINERAL", "110203091 | AKPO", "120204001 | AL KHAYMAH", "110106001 | ALAGOANO", "120206001 | ALBA FIELD", "110101001 | ALBACORA", "110101042 | ALBACORA LESTE", "810201001 | ÁLCOOL METÍLICO", "110201067 | ALEN CONDENSATE", "110204003 | ALIF", "330201005 | ALQUILBENZENO AB10", "330201006 | ALQUILBENZENO AB11", "330201004 | ALQUILBENZENO AB9", "110105001 | ALTO DO RODRIGUES", "110203072 | AMENAN BLEND", "110203001 | AMNA", "110201001 | ANACO WAX", "110101002 | ANEQUIM", "110203002 | ANGOLANO", "120205010 | ANOA", "110203003 | ANTAN", "110204004 | ARABE EXTRA LEVE", "110204005 | ARABE LEVE", "110204006 | ARABE MEDIO", "110204007 | ARABE MEDIO BANOCO", "110204008 | ARABE MEDIO ZULUF", "110204009 | ARABE PESADO", "110204010 | ARABE RECON", "110204011 | ARABE SUPER LEVE", "110105027 | ARACARI", "110103003 | ARAÇÁS", "110103002 | ARATU", "110105002 | ARATUM", "110205001 | ARDJUNA", "120203002 | ARGELINO", "120205001 | ARUM", "110203004 | ARZEW", "120203001 | AR-720", "530102001 | ASFALTO NATURAL", "530101002 | ASFALTOS DILUÍDOS", "110206023 | ASGARD BLEND", "110108001 | ATUM", "110105017 | AURI", "110206019 | AZERJ LIGHT", "110205023 | BACH HO", "110203092 | BACH HO", "110201002 | BACHAQUERO", "120202001 | BADAK", "110101003 | BADEJO", "110101004 | BAGRE", "110103004 | BAIANO BORDA NORDESTE", "110103005 | BAIANO MISTURA", "110207010 | BALNAVES", "110203097 | BAOBAB", "110205037 | BARANTAI", "110101005 | BARRACUDA", "110203096 | BARROW ISLAND", "110204012 | BASRAH LEVE", "110204013 | BASRAH MEDIO", "110204014 | BASRAH PESADO", "110102001 | BAS-60", "120207003 | BAYU UNDAN", "110201003 | BCF", "110201004 | BCF 22", "110201005 | BCF 23", "110201006 | BCF 24", "110206001 | BEATRICE", "110205002 | BEKOK", "110203005 | BELAYM", "110205003 | BELIDA", "330201001 | BENZENO", "110206002 | BERYL", "110101006 | BICUDO", "110101007 | BIJUPIRÁ", "110101038 | BIJUPIRÁ/SALEMA", "120205002 | BINTULU", "820101001 | BIODIESEL B100", "820101010 | BIODIESEL FORA DE ESPECIFICAÇÃO", "820101999 | BIODIESEL FORA DE ESPECIFICAÇÃO", "110206003 | BLACK GASOIL CRUDE OIL", "110201007 | BOLIVIAN BLEND", "120201001 | BOLIVIANO", "110201008 | BOLIVIANO", "110103017 | BOM LUGAR", "110205004 | BOMBAY HIGH", "110203077 | BONGA", "110101008 | BONITO", "110203006 | BONNY LEVE", "110203007 | BONNY MEDIO", "110201009 | BOSCAN", "110203008 | BOURI", "110203009 | BRASS BLEND", "110203010 | BRASS RIVER", "120203004 | BREGA", "110206004 | BRENT", "610101009 | BRIGHT STOCK", "610801001 | BRIGHT STOCK", "120205003 | BRUNEI", "110205005 | BRUNEI LIGHT", "610811001 | BS", "610812001 | BS", "610803003 | BS", "610805001 | BS 150", "610806003 | BS 2500", "110203092 | BU ATTIFEL", "110204015 | BURGAN", "210202003 | BUTADIENO", "210202001 | BUTANO", "210202002 | BUTANO ESPECIAL", "110105018 | BV", "110203011 | CABINA/TAKULA", "110203012 | CABINDA", "110101009 | CABIÚNAS MISTURA", "110104001 | CAÇÃO", "110104006 | CACHALOTE", "110106010 | CAJUEIRO", "610802001 | CALPAR 150", "610802002 | CALPAR 500", "110202007 | CALYPSO", "110106002 | CAMORIM", "110111002 | CANÁRIO", "110103006 | CANDEIAS", "110105003 | CANTO DO AMARO", "110201010 | CAÑADON SECO", "110201011 | CAÑO LIMÓN", "110201064 | CARABOBO", "110201012 | CARANDA", "110101010 | CARAPEBA", "110101011 | CARATINGA", "110108002 | CARAUNAS", "110107001 | CARAVELA", "120202002 | CARLINE", "110202011 | CASCADE CHINOOK", "110106003 | CASTANHAL", "110201066 | CASTILLA BLEND", "110108003 | CEARÁ MAR", "110203085 | CEIBA", "110201013 | CEUTA", "110207001 | CHALLIS", "110205034 | CHAMPION", "110105023 | CHAUÁ", "110101012 | CHERNE", "110205031 | CHIM SÃO", "110201014 | CHUBUT", "620501002 | CICLO DIESEL", "620501001 | CICLO OTTO", "610101005 | CILINDRO I", "610101006 | CILINDRO II", "530101001 | CIMENTOS ASFÁLTICOS", "530101020 | CIMENTOS ASFÁLTICOS DE PETRÓLEO MODIFICADOS POR BORRACHA MOÍDA DE PNE" & _
                        "US", "(ASFALTOS | BORRACHA)", "530101018 | CIMENTOS ASFÁLTICOS DE PETRÓLEO MODIFICADOS POR POLÍMEROS", "110205006 | CINTA", "110201015 | COBLAN BLEND", "110203013 | COCO", "110202001 | COLD LAKE BLEND", "120104001 | CONDENSADO CAMARUPIM", "120102001 | CONDENSADO PARA PETROQUÍMICA", "120104002 | CONDENSADO PEROA", "110205024 | CONDENSADO SENIPAH", "120205009 | CONDENSADO SENIPAH", "610804001 | CONOSOL 260", "540101002 | COQUE CALCINADO", "540101001 | COQUE VERDE", "110107002 | CORAL", "610806006 | CORE 100", "610806007 | CORE 150", "610806008 | CORE 2500", "610806009 | CORE 600", "620601003 | CORRENTE DE MOTOSSERRA", "110201016 | CORRIENTES", "110101013 | CORVINA", "120207001 | COSSACK", "110206020 | CPC BLEND", "110104008 | CREJOA", "110201017 | CUPIAGUA", "110108004 | CURIMÃ/ESPADA", "110201018 | CUSIANA", "330201007 | C9 DIHIDROGENADO (OU C9 DE PIRÓLISE)", "110205007 | DAÍ HUNG", "110203086 | DALIA", "110205008 | DAQUING", "340101002 | DERIVADOS LEVES INTERMEDIÁRIOS", "130202002 | DERIVADOS LEVES PARA REPROCESSAMENTO", "430101002 | DERIVADOS MÉDIOS INTERMEDIÁRIOS", "130202003 | DERIVADOS MÉDIOS PARA REPROCESSAMENTO", "560101002 | DERIVADOS PESADOS INTERMEDIÁRIOS", "130202004 | DERIVADOS PESADOS PARA REPROCESSAMENTO", "820101032 | DIESEL B S10 PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101026 | DIESEL B S1800 NÃO RODOVIÁRIO PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101026 | DIESEL B S1800 PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101032 | DIESEL B S50 PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101027 | DIESEL B S500 PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101004 | DIESEL B10", "820101005 | DIESEL B15", "820101022 | DIESEL B2 ESPECIAL - 200 PPM ENXOFRE", "820101007 | DIESEL B2 INTERIOR ADITIVADO", "820101002 | DIESEL B2 INTERIOR COMUM", "820101009 | DIESEL B2 METROPOLITANO ADITIVADO", "820101008 | DIESEL B2 METROPOLITANO COMUM", "820101014 | DIESEL B20 INTERIOR ADITIVADO", "820101006 | DIESEL B20 INTERIOR COMUM", "820101016 | DIESEL B20 METROPOLITANDO ADITIVADO", "820101015 | DIESEL B20 METROPOLITANO COMUM", "820101031 | DIESEL B20 S10 ADITIVADO", "820101030 | DIESEL B20 S10 COMUM", "820101014 | DIESEL B20 S1800 - ADITIVADO", "820101006 | DIESEL B20 S1800 - COMUM", "820101014 | DIESEL B20 S1800 NÃO RODOVIÁRIO - ADITIVADO", "820101006 | DIESEL B20 S1800 NÃO RODOVIÁRIO - COMUM", "820101031 | DIESEL B20 S50 ADITIVADO", "820101030 | DIESEL B20 S50 COMUM", "820101016 | DIESEL B20 S500 - ADITIVADO", "820101015 | DIESEL B20 S500 - COMUM", "820101025 | DIESEL B30", "820101007 | DIESEL B4 INTERIOR ADITIVADO", "820101002 | DIESEL B4 INTERIOR COMUM", "820101026 | DIESEL B4 INTERIOR PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101009 | DIESEL B4 METROPOLITANO ADITIVADO", "820101008 | DIESEL B4 METROPOLITANO COMUM", "820101027 | DIESEL B4 METROPOLITANO PARA GERAÇÃO DE ENERGIA ELÉTRICA", "820101007 | DIESEL B4 S1800 - ADITIVADO", "820101002 | DIESEL B4 S1800 - COMUM", "820101028 | DIESEL B4 S50 ADITIVADO", "820101029 | DIESEL B4 S50 COMUM", "820101009 | DIESEL B4 S500 - ADITIVADO", "820101008 | DIESEL B4 S500 - COMUM", "820101011 | DIESEL B5 INTERIOR ADITIVADO", "820101003 | DIESEL B5 INTERIOR COMUM", "820101013 | DIESEL B5 METROPOLITANO ADITIVADO", "820101012 | DIESEL B5 METROPOLITANO COMUM", "820101017 | DIESEL MARÍTIMO - DMA B2", "820101018 | DIESEL MARÍTIMO - DMA B5", "820101019 | DIESEL MARÍTIMO - DMB B2", "820101020 | DIESEL MARÍTIMO - DMB B5", "820101021 | DIESEL NÁUTICO B2 ESPECIAL - 200 PPM ENXOFRE", "330101003 | DILUENTE DE TINTAS", "130202006 | DILUENTE PARA REPROCESSAMENTO", "110203014 | DJENO BLEND", "420201001 | DMA - MGO", "420201003 | DMB - MDO", "120204010 | DOLPHIN", "110103007 | DOM JOÃO", "110204017 | DOROOD", "110204051 | DSL", "110204018 | DUBAI", "110205035 | DULANG", "110205022 | DURI CRUDE OIL", "110203069 | EA CRUDE", "110203015 | EAST ZEIT MIX", "110203104 | EBOME", "610903001 | EHC 45", "610903002 | EHC 60", "110206005 | EKOFISH", "110203016 | EL HUEMEL", "110203017 | EL MORGAN", "110203018 | EL ORIENTE", "110203088 | EL SHARARA", "110203019 | EMERAUDE", "530101003 | EMULSÕES ASFÁLTICAS", "530101019 | EMULSÕES ASFÁLTICAS CATIÔNICAS MODIFICADAS POR POLÍMEROS ELASTOMÉRICO" & _
                        "S", "110101014 | ENCHOVA", "620101002 | ENGRENAGENS E SISTEMAS CIRCULATÓRIOS", "720101001 | ENXOFRE LÍQUIDO", "720101002 | ENXOFRE SÓLIDO", "120205004 | ERAWAN", "110203079 | ERHA", "110203020 | ES SIDER", "110201019 | ESCALANTE", "110203021 | ESCRAVOS", "110108005 | ESPADA", "110101015 | ESPADARTE", "110104002 | ESPIRITO SANTO", "110101016 | ESPÍRITO SANTO SUBMARINO", "110206025 | ESPO", "120203007 | ESPOIR", "620101007 | ESTAMPAGEM", "140102001 | ÉSTER METÍLICO", "110105004 | ESTREITO", "110107003 | ESTRELA DO MAR", "110203095 | ETAME", "210301001 | ETANO", "810102001 | ETANOL ANIDRO", "810102004 | ETANOL ANIDRO COM CORANTE", "810102002 | ETANOL ANIDRO FORA DE ESPECIFICAÇÃO", "130201002 | ETANOL ANIDRO INSUMO PARA BIODIESEL", "810102003 | ETANOL ANIDRO PADRÃO", "810101002 | ETANOL HIDRATADO ADITIVADO", "810101001 | ETANOL HIDRATADO COMUM", "810101003 | ETANOL HIDRATADO FORA DE ESPECIFICAÇÃO", "210301002 | ETENO", "330201010 | ETILBENZENO", "611003001 | ETRO 4", "611003002 | ETRO 6", "611003003 | ETRO 8", "110204016 | FAO BLEND", "110105005 | FAZENDA ALEGRE", "110105006 | FAZENDA BELÉM", "110105007 | FAZENDA POCINHO", "110104003 | FAZENDA SÃO RAFAEL", "610904001 | FLINT HILLS", "110206006 | FLOTTA", "110206007 | FLOTTA OCIDENTAL", "110203022 | FORCADOS", "110204019 | FOROOZAN", "110206008 | FORTIES", "110206009 | FORTIES BLEND", "110101043 | FRADE", "110201020 | FURRIAL", "110104009 | GAIVOTA", "110203023 | GAMBA", "110101017 | GAROUPA", "110101018 | GAROUPINHA", "210302004 | GÁS ÁCIDO", "210101001 | GÁS COMBUSTÍVEL", "210302003 | GÁS DE XISTO", "210302002 | GÁS INTERMEDIÁRIO", "210204001 | GÁS LIQUEFEITO INTERMEDIÁRIO", "220101003 | GÁS NATURAL COMPRIMIDO", "220101004 | GÁS NATURAL LIQUEFEITO", "220101002 | GÁS NATURAL SECO", "220101001 | GÁS NATURAL ÚMIDO", "220101005 | GÁS NATURAL VEICULAR", "220101006 | GÁS NATURAL VEICULAR PADRÃO", "130202001 | GASES LIQUEFEITOS PARA REPROCESSAMENTO", "130202005 | GASÓLEO PARA REPROCESSAMENTO", "520101001 | GASÓLEOS", "320101001 | GASOLINA A COMUM", "320101003 | GASOLINA A FORA DE ESPECIFICAÇÃO", "320101002 | GASOLINA A PREMIUM", "320103001 | GASOLINA AUTOMOTIVA PADRÃO", "320102002 | GASOLINA C ADITIVADA", "320102001 | GASOLINA C COMUM", "320102004 | GASOLINA C FORA DE ESPECIFICAÇÃO", "320102003 | GASOLINA C PREMIUM", "320201001 | GASOLINA DE AVIAÇÃO", "320201002 | GASOLINA DE AVIAÇÃO FORA DE ESPECIFICAÇÃO", "320103001 | GASOLINA DE REFERÊNCIA", "220102001 | GASOLINA NATURAL (C5+)", "320301002 | GASOLINA PARA EXPORTAÇÃO", "110204020 | GAVARZIN", "110203024 | GEISUM", "120205012 | GERAGAI", "110207002 | GIPPSLAND BLEND", "110203087 | GIRASSOL", "730101002 | GLICERINA", "210203001 | GLP", "210203002 | GLP FORA DE ESPECIFICAÇÃO", "110104005 | GOLFINHO", "140101023 | GORDURA BOVINA", "140101024 | GORDURA DE FRANGO", "140101025 | GORDURA DE PORCO", "650101004 | GRAXAS DE CALCIO", "650101003 | GRAXAS DE LITIO", "650101001 | GRAXAS MINERAIS", "110207003 | GRIFFIN", "110201021 | GUAFITA BLEND", "110103013 | GUANAMBI", "110201022 | GUANIPA", "110203025 | GULF OF SUEZ", "110203026 | GULF OF SUEZ MIX", "110206011 | GULL FALKS", "110206010 | GULL FALKS C", "110203027 | HASSI MESSAOUD", "110203028 | HASSI RMEL", "110203028 | HASSI RMEL", "330101008 | HEPTANO", "330101002 | HEXANO", "330101009 | HEXENO", "110202009 | HIBERNIA", "110201068 | HIDES", "620101001 | HIDRÁULICO", "610201001 | HIDROGENADO LEVE", "610201002 | HIDROGENADO MÉDIO", "610201003 | HIDROGENADO PESADO", "710101001 | HIDROGÊNIO", "110203074 | HUNGO", "610808001 | HVI 120", "610808002 | HVI 60", "110201023 | HYDRA", "110103008 | ILHÉUS", "110203029 | IMA LIGHT", "120205005 | INDIANO", "110204021 | IRANIANO LEVE", "110204022 | IRANIANO MISTURA", "110204023 | IRANIANO PESADO", "620101004 | ISOLANTE TIPO A", "620101005 | ISOLANTE TIPO B", "330101010 | ISOPENTANO", "110202002 | ISTHMUS", "110202003 | ISTHMUS MAYA", "110207004 | JABIRU", "110101046 | JABUTI", "110204024 | JAMBUR BAR HASSAN", "110113001 | JIRIBATUBA", "110105015 | JOÃO DE BARRO", "110101019 | JUBARTE", "110203098 | JUBILEE", "110103015 | JURITI", "110205025 | KAJI SEMOGA", "110204025 | KANGAN", "110204026 | KHAFJI", "110204027 | KHAFJI BLEND", "120204009 | KHUFF", "110205026 | KIKEH", "110204028 | KIRKUK", "110204029 | KIRKUK BLEND", "110203080 | KISSANJE", "120207004 | KITAN", "110203030 | KITINA", "110105025 | KOCH", "110203031 | KOLE", "110203084 | KUITO", "110203032 | KUTUBU", "110204030 | KUWAIT", "110205009 | LABUAN", "110104004 | LAGOA PARDA", "110201024 | LAGOCINCO", "110201025 | LAGOCINCO LIVIANO", "110201026 | LAGOMEDIO", "110201027 | LAGOTRECO", "110201028 | LAGOTRECO HEAVY", "110201029 | LAGOTRECO MEDIO", "110201030 | LAGUNA", "110205036 | LALANG", "110207005 | LAMINARIA", "110204031 | LAVAN BLEND", "110207006 | LEGENDRE", "110201031 | LEONA", "110201032 | LEONA 21,9", "110201033 | LEONA 24", "120204002 | LIBIA", "110101020 | LINGUADO", "120203006 | LION", "220102002 | LÍQUIDO DE GÁS NATURAL", "110105008 | LIVRAMENTO", "110203033 | LOKELE", "110105009 | LORENA", "110201034 | LORETO", "110204053 | LOWER ZAKUM", "110203034 | LUCINA MARINE", "110203035 | LUCULA", "640201001 | MACROOLEOSAS", "120205011 | MALAMPAYA", "110101021 | MALHADO", "120103001 | MANATI", "110203036 | MANDJI", "120204003 | MARGHAM", "110201035 | MARIA IGNES", "110204032 | MARIB LIGHT", "110101022 | MARIMBA", "110201036 | MARLAGO", "110101023 | MARLIM", "110101024 | MARLIM LESTE", "110101025 | MARLIM SUL", "110101039 | MARLIN/VOADOR", "110204033 | MASILA BLEND", "120207002 | MAUI", "110202004 | MAYA", "110202005 | MAYA LEVE", "110201069 | MAYNA", "110203037 | MBIA", "110203037 | MBIA", "110201037 | MEDANITO", "110203078 | MELLITAH", "120203005 | MELLITAH", "120204010 | MELLITAH", "110201038 | MEREY", "110201039 | MEREY/LEONA", "120101001 | MERLUZA", "110201040 | MESA", "110201041 | MESCLA VENEZUELANO", "740101007 | METIL TERC BUTIL ETER - MTBE", "420201003 | MGO", "640101001 | MICROOLEOSAS", "110205027 | MINAS", "110103009 | MIRANGA", "110103010 | MIRANGA/ÁGUA GRANDE", "110205010 | MIRI LEVE", "120203008 | MISKAR", "820101018 | MIST. DIESEL MARÍTIMO-95% / BIODIESEL-5%", "820101017 | MIST. DIESEL MARÍTIMO-98% / BIODIESEL-2%", "820101006 | MIST. DIESEL-80% / BIODIESEL-20% - B20", "820101014 | MIST. DIESEL-80% / BIODIESEL-20% - B20 INT ADITIV", "820101006 | MIST. DIESEL-80% / BIODIESEL-20% - B20 INT COMUM", "820101016 | MIST. DIESEL-80% / BIODIESEL-20% - B20 MET ADITIV", "820101015 | MIST. DIESEL-80% / BIODIESEL-20% - B20 MET COMUM", "820101006 | MIST. DIESEL-80% / BIODIESEL-20% - B5 INT COMUM", "820101005 | MIST. DIESEL-85% / BIODIESEL-15% - B15", "820101004 | MIST. DIESEL-90% / BIODIESEL-10% - B10", "820101003 | MIST. DIESEL-95% / BIODIESEL-5% - B5", "820101011 | MIST. DIESEL-95% / BIODIESEL-5% - B5 INT ADITIVADO", "820101003 | MIST. DIESEL-95% / BIODIESEL-5% - B5 INT COMUM", "820101013 | MIST. DIESEL-95% / BIODIESEL-5% - B5 MET ADITIVADO", "820101012 | MIST. DIESEL-95% / BIODIESEL-5% - B5 MET COMUM", "820101002 | MIST. DIESEL-98% / BIODIESEL-2% - B2", "820101007 | MIST. DIESEL-98% / BIODIESEL-2% - B2 INT ADITIVADO", "820101002 | MIST. DIESEL-98% / BIODIESEL-2% - B2 INT COMUM", "820101009 | MIST. DIESEL-98% / BIODIESEL-2% - B2 MET ADITIVADO", "820101008 | MIST. DIESEL-98% / BIODIESEL-2% - B2 MET COMUM", "110301001 | MISTURA DE PETRÓLEOS", "110208001 | MISTURA DE PETRÓLEOS IMPORTADOS", "110203038 | MOANDA", "110203089 | MONDO", "110201042 | MONOGAS", "110101026 | MOREIA", "620502001 | MOTORES 2 TEMPOS", "110203039 | MOUDI", "110202008 | MSW EDMONTON", "110204034 | MURBAN", "110207009 | MUTINEER", "611201002 | MVI (N) 40 - NAFTÊNICO", "611201003 | MVI 1050 - NAFTÊNICO", "611201001 | MVI(N) 170 - NAFTÊNICO", "610803002 | N 500", "110110001 | NACIONAL MISTURA", "310102001 | NAFTA DE XISTO", "310103001 | NAFTA FORA DE ESPECIFICAÇÃO", "310101001 | NAFTA PETROQUÍMICA", "611207003 | NAFTALENOS ALQUILADOS (AN)", "110101027 | NAMORADO", "110205011 | NANHAI LIGHT", "110201062 | NAPO", "110203040 | NEMBA", "610801002 | NEUTRAL OIL 150", "610801004 | NEUTRAL OIL 500", "610801005 | NEUTRAL OIL 60", "610801003 | NEUTRAL OIL300", "610905001 | NEUTRAL 110", "610101002 | NEUTRO LEVE", "610401002 | NEUTRO LEVE RR", "610813002 | NEUTRO LEVE RR", "610906002 | NEUTRO LEVE RR", "610101003 | NEUTRO MÉDIO", "610401003 | NEUTRO MÉDIO RR", "610813003 | NEUTRO MÉDIO RR", "610906003 | NEUTRO MÉDIO RR", "610101004 | NEUTRO PESADO", "610401004 | NEUTRO PESADO RR", "610906004 | NEUTRO PESADO RR", "610813004 | NEUTRO PESADO RR", "611102001 | NEXBASE 2002", "611102002 | NEXBASE 2004", "611102003 | NEXBASE 2006", "611102004 | NEXBASE 2008", "611001001 | NEXBASE 3030", "611001002 | NEXBASE 3043", "611001003 | NEXBASE 3050", "611001004 | NEXBASE 3060", "611001005 | NEXBASE 3080", "611202001 | NH 10 - NAFTÊNICO", "611202002 | NH 140 - NAFTÊNICO", "611202003 | NH 20 - NAFTÊNICO", "110203041 | NIGERIANO BRASS LIGHT", "110203042 | NIGERIANO LEVE", "110203043 | NIGERIANO LEVE QUA IBOE", "110203094 | NILE BLEND", "110206024 | NINIAN", "110203044 | NKOSSA", "110203044 | NKOSSA", "430101001 | NORMAL PARAFINAS", "110206021 | NORNE BLEND", "120204004 | NORTH FIELD", "110207007 | NORTH WEST SHELF", "611203002 | NYNAS T22 - NAFTÊNICO", "110203045 | ODUDU", "110201043 | OFICINA", "110203046 | OGUENDJO", "110203047 | OKAN", "110203048 | OKONO", "110203099 | OKORO", "110203081 | OKWORI", "430101004 | ÓLEO COMB. P/ TURBINA GERADORA DE ENERGIA ELÉTRICA", "510101003 | ÓLEO COMBUSTÍVEL A FORA DE ESPECIFICAÇÃO", "510101001 | ÓLEO COMBUSTÍVEL A1", "510101002 | ÓLEO COMBUSTÍVEL A2", "510102003 | ÓLEO COMBUSTÍVEL B FORA DE ESPECIFICAÇÃO", "510102001 | ÓLEO COMBUSTÍVEL B1", "510102002 | ÓLEO COMBUSTÍVEL B2", "510201001 | ÓLEO COMBUSTÍVEL MARÍTIMO", "510201002 | ÓLEO COMBUSTÍVEL MARÍTIMO FORA DE ESPECIFICAÇÃO", "510201003 | ÓLEO COMBUSTÍVEL MARÍTIMO MISTURA (MF)", "510301003 | ÓLEO COMBUSTÍVEL PARA GERAÇÃO ELÉTRICA", "140101015 | ÓLEO DE ABACATE (PERSIA AMERICANA)", "140101009 | ÓLEO DE ALGODÃO (GOSSYPIUM HIRSUT)", "140101016 | ÓLEO DE AMENDOIM (ORACHIS HYPOGEAE)", "140101017 | ÓLEO DE ANDIROBA (CARAPA GUIANERSIS)", "140101005 | ÓLEO DE BABAÇU (ORBINYA MARTIANA)", "140101014 | ÓLEO DE BURITI", "140101018 | ÓLEO DE COCO (COCUS NUMIFERA)", "140101006 | ÓLEO DE COLZA/CANOLA (BRESSICA CAMPESTRIS)", "140101028 | ÓLEO DE CRAMBE", "140101021 | ÓLEO DE FRITURA USADO", "140101010 | ÓLEO DE GIRASSOL (HELLANTHUS ANNUS)", "140101012 | ÓLEO DE LINHAÇA", "140101013 | ÓLEO DE MACAÚBA", "140101001 | ÓLEO DE MAMONA (RICINUS COMMUNIS)", "140101030 | ÓLEO DE MILHO", "140101011 | ÓLEO DE NABO-FORRAGEIRO", "140101003 | ÓLEO DE PALMA/DENDÊ (ELAEIS GUINEENSIS OU ELAEIS O", "140101002 | ÓLEO DE PALMISTE", "140101008 | ÓLEO DE PEQUI (JATROPHA CURCAS)", "140101007 | ÓLEO DE PINHÃO-MANSO", "140101019 | ÓLEO DE SÉSAMO (SESAMUN INDICUM)", "140101004 | ÓLEO DE SOJA (GLYCINE MAX)", "560101001 | ÓLEO DE XISTO", "420105001 | ÓLEO DIESEL A S10", "420101005 | ÓLEO DIESEL A S1800 - ADITIVADO", "420101004 | ÓLEO DIESEL A S1800 - COMUM", "420101003 | ÓLEO DIESEL A S1800 - FORA DE ESPECIFICAÇÃO", "420101005 | ÓLEO DIESEL A S1800 NÃO RODOVIÁRIO - ADITIVADO", "420101004 | ÓLEO DIESEL A S1800 NÃO RODOVIÁRIO - COMUM", "420101003 | ÓLEO DIESEL A S1800 NÃO RODOVIÁRIO - FORA DE ESPECIFICAÇÃO", "420102006 | ÓLEO DIESEL A S50", "420102005 | ÓLEO DIESEL A S500 - ADITIVADO", "420102004 | ÓLEO DIESEL A S500 - COMUM", "420102003 | ÓLEO DIESEL A S500 - FORA DE ESPECIFICAÇÃO", "420104001 | ÓLEO DIESEL AUTOMOTIVO ESPECIAL - ENXOFRE 200 PPM", "820101033 | ÓLEO DIESEL B S10 - ADITIVADO", "820101034 | ÓLEO DIESEL B S10 - COMUM", "420106001 | ÓLEO DIESEL B S10 AMD 10", "820101011 | ÓLEO DIESEL B S1800 - ADITIVADO", "820101003 | ÓLEO DIESEL B S1800 - COMUM", "820101011 | ÓLEO DIESEL B S1800 NÃO RODOVIÁRIO - ADITIVADO", "820101003 | ÓLEO DIESEL B S1800 NÃO RODOVIÁRIO - COMUM", "820101028 | ÓLEO DIESEL B S50 - ADITIVADO", "820101029 | ÓLEO DIESEL B S50 - COMUM", "820101013 | ÓLEO DIESEL B S500 - ADITIVADO", "820101012 | ÓLEO DIESEL B S500 - COMUM", "420106002 | ÓLEO DIESEL B S500 AMD 10", "830101001 | ÓLEO DIESEL DE CANA AMD 100", "420301004 | OLEO DIESEL DE REFERÊNCIA S300", "420301003 | ÓLEO DIESEL FORA DE ESPECIFICAÇÃO", "420101005 | ÓLEO DIESEL INTERIOR ADITIVADO - ENXOFRE 1800 PPM", "420101002 | ÓLEO DIESEL INTERIOR (B) ADITIVADO", "420101001 | ÓLEO DIESEL INTERIOR (B) COMUM", "420101003 | ÓLEO DIESEL INTERIOR (B) FORA DE ESPECIFICAÇÃO", "420101004 | ÓLEO DIESEL INTERIOR COMUM - ENXOFRE 1800 PPM", "420101003 | ÓLEO DIESEL INTERIOR FORA DE ESPECIFICAÇÃO", "420201001 | ÓLEO DIESEL MARÍTIMO", "420201002 | ÓLEO DIESEL MARÍTIMO FORA DE ESPECIFICAÇÃO", "420102005 | ÓLEO DIESEL METROPOLITANO ADITIVADO - ENXOFRE 500 PPM", "420102004 | ÓLEO DIESEL METROPOLITANO COMUM - ENXOFRE 500 PPM", "420102002 | ÓLEO DIESEL METROPOLITANO (D) ADITIVADO", "420102001 | ÓLEO DIESEL METROPOLITANO (D) COMUM", "420102003 | ÓLEO DIESEL METROPOLITANO (D) FORA DE ESPECIFICAÇÃO", "420102003 | ÓLEO DIESEL METROPOLITANO FORA DE ESPECIFICAÇÃO", "420202001 | ÓLEO DIESEL NÁUTICO ESPECIAL - ENXOFRE 200 PPM", "420301001 | ÓLEO DIESEL PADRÃO", "420102006 | ÓLEO DIESEL S50", "420103002 | ÓLEO DIESEL S500 ADITIVADO", "420103001 | ÓLEO DIESEL S500 COMUM", "420103003 | ÓLEO DIESEL S500 FORA DE ESPECIFICAÇÃO", "611207002 | ÓLEO MINERAL BRANCO", "611301001 | ÓLEOS BÁSICOS - GRUPO I", "610601001 | ÓLEOS BÁSICOS - GRUPO II", "610701001 | ÓLEOS BÁSICOS - GRUPO III", "510301002 | ÓLEOS COMBUSTÍVEIS PARA EXPORTAÇÃO", "620601001 | ÓLEOS EXTENSORES E PLASTIFICANTES", "660101001 | ÓLEOS LUB. PARAF E GRAXAS INTERMEDIÁRIOS", "620401001 | ÓLEOS LUBRIFICANTES FERROVIÁRIOS", "620301001 | ÓLEOS LUBRIFICANTES MARÍTIMOS", "620201001 | ÓLEOS LUBRIFICANTES PARA AVIAÇÃO", "630101001 | ÓLEOS LUBRIFICANTES USADOS OU CONTAMINADOS", "611207004 | ÓLEOS VEGETAIS", "110202006 | OLMECA", "110203093 | OLOWI", "110204035 | OMAN", "110203049 | ORIBI", "110201044 | ORIENTE", "110201045 | ORITO", "110206012 | OSEBERG", "120203003 | OSO", "320301001 | OUTRAS GASOLINAS", "320103002 | OUTRAS GASOLINAS AUTOMOTIVAS", "650101002 | OUTRAS GRAXAS", "310102002 | OUTRAS NAFTAS", "640401001 | OUTRAS PARAFINAS", "610907001 | OUTRO", "610814001 | OUTRO", "611107001 | OUTRO", "611007001 | OUTRO", "611207006 | OUTRO", "140101029 | OUTROS ÁCIDOS GRAXOS", "740101003 | OUTROS ADITIVOS", "810201002 | OUTROS ALCOÓIS", "530103001 | OUTROS ASFALTOS", "340101003 | OUTROS DERIVADOS LEVES", "430101003 | OUTROS DERIVADOS MÉDIOS", "560101003 | OUTROS DERIVADOS PESADOS", "611207001 | OUTROS ÉSTERES SINTÉTICOS", "210302001 | OUTROS GASES", "210204002 | OUTROS GASES LIQUEFEITOS", "130201001 | OUTROS INSUMOS BRUTOS", "530104001 | OUTROS INSUMOS PARA ASFALTOS", "140101022 | OUTROS MATERIAIS GRAXOS", "140101999 | OUTROS MATERIAIS GRAXOS", "610201004 | OUTROS NAFTÊNICOS", "510301001 | OUTROS ÓLEOS COMBUSTÍVEIS", "420301002 | OUTROS ÓLEOS DIESEL", "620601004 | OUTROS ÓLEOS LUBRIFICANTES ACABADOS", "620505001 | OUTROS ÓLEOS LUBRIFICANTES AUTOMOTIVOS", "610501001 | OUTROS ÓLEOS LUBRIFICANTES BÁSICOS", "620101008 | OUTROS ÓLEOS LUBRIFICANTES INDUSTRIAIS", "610101010 | OUTROS PARAFÍNICOS", "110208002 | OUTROS PETRÓLEOS IMPORTADOS", "110110002 | OUTROS PETRÓLEOS NACIONAIS", "130202008 | OUTROS PRODUTOS PARA REPROCESSAMENTO", "410103001 | OUTROS QUEROSENES", "610301002 | OUTROS SINTÉTICOS", "610302001 | OUTROS SINTÉTICOS", "330101007 | OUTROS SOLVENTES ALIFÁTICOS", "330201009 | OUTROS SOLVENTES AROMÁTICOS", "730101001 | OUTROS SUB-PRODUTOS", "110205033 | OYONG", "110203050 | PALANCA", "110101028 | PAMPO", "611103001 | PAO 4", "611106002 | PAO 4", "611104001 | PAO 40", "611106003 | PAO 6", "611101007 | PAO 8", "611106001 | PAO 8", "110101049 | PAPATERRA", "110101029 | PARATI", "110101030 | PARGO", "110104007 | PARQUE DAS CONCHAS", "110111001 | PAU LAVADO", "110203102 | PAZFLOR", "610809002 | PBS 30", "610809001 | PBS 33", "610809003 | PCL 45", "610809004 | PCL 60", "120205006 | PEMBINA", "110205032 | PENARA BLEND", "110203051 | PENNINGTON", "110101050 | PEREGRINO", "110201065 | PERENCO PERU BLEND", "110105028 | PERIQUITO", "110105016 | PESCADA/ARABAIANA", "611204001 | PIB 24 - POLIBUTENO", "110201046 | PILON", "110106007 | PIRANEMA", "110101031 | PIRAUNA", "611207005 | PLIGLICÓIS", "110207008 | PLUTO CONDENSADO", "110203082 | PLUTONIO", "610809005 | PNL 30", "610809006 | PNM 55", "610809007 | PNM 80", "610809008 | PNP 95", "610301001 | POLIALFAOLEFINA", "110101032 | POLO NORDESTE", "110101047 | POLVO", "110105021 | POTI", "110105010 | POTIGUAR TERRA", "611206001 | PRIOLUBE 3970 - ÉSTER", "611206002 | PRIOLUBE 3999 - ÉSTER", "620101003 | PROCESSO", "210201001 | PROPANO", "210201002 | PROPANO ESPECIAL", "210201003 | PROPENO", "610809009 | PSP 09", "610809010 | PTL 25", "610809011 | PTP 85", "110105020 | PTX", "110105022 | PTX-11", "110205012 | PULAI", "620601002 | PULVERIZAÇÃO AGRÍCOLA", "120206003 | PUROVSKY", "110204036 | QATAR DUKHAN", "110204037 | QATAR LAND", "110204038 | QATAR MARINE", "110203101 | QUARUN", "410101001 | QUEROSENE DE AVIAÇÃO", "410101002 | QUEROSENE DE AVIAÇÃO FORA DE ESPECIFICAÇÃO", "410102001 | QUEROSENE ILUMINANTE", "410102002 | QUEROSENE ILUMINANTE FORA DE ESPECIFICAÇÃO", "110103014 | QUIAMBINA", "110203052 | RABI", "330101005 | RAFINADO DE PIRÓLISE", "330101006 | RAFINADO DE REFORMA", "110205029 | RANG DONG", "110203053 | RAS BUDRAN", "120204008 | RAS GAS", "110203054 | RAS GHARIB", "110204039 | RATAWI", "110201047 | RECON BOLIVIANO", "110201048 | RECON MEREY", "110103011 | RECÔNCAVO", "340101001 | REFORMADOS", "550101001 | RESÍDUO AROMÁTICO (RARO)", "550101005 | RESÍDUO ASFÁLTICO(RASF)", "550101002 | RESÍDUO ATMOSFÉRICO (RAT)", "550101003 | RESÍDUO DE VÁCUO", "550101004 | RESÍDUO DE VÁCUO DE ALTO TEOR DE ENXOGRE", "130202007 | RESÍDUO PARA REPROCESSAMENTO", "110105011 | RGN MISTURA", "110201049 | RINCÓN DE LOS SAUCES", "110101048 | RJS-609", "110101033 | RONCADOR", "110101040 | RONCADOR LESTE", "110101045 | RONCADOR MISTURA", "110101041 | RONCADOR OESTE", "110204040 | ROSTAM", "110105019 | RT", "110205030 | RUBY", "110204041 | RUMAILA", "110105024 | RV-1", "110203070 | SABLE CRUDE OIL", "110203055 | SAHARA MISTURA", "110204042 | SALMAN", "110203075 | SALTPOND", "110201050 | SAN SEBASTIAN", "110201051 | SANTA BARBARA", "110201052 | SANTA CRUZ", "110201053 | SANTA CRUZ DO SUL", "120201002 | SANTA ROSA", "110105029 | SÃO MANOEL", "110203056 | SARIR", "110204043 | SARKHOON", "110203103 | SATURNO BLEND", "110203090 | SAXI BLEND", "140101020 | SEBO", "110103018 | SEMPRE VIVA", "110106004 | SERGIPANO MAR", "110106005 | SERGIPANO MISTURA", "110106006 | SERGIPANO TERRA", "110205028 | SERIA LIGHT", "110105012 | SERRARIA", "120204005 | SHARJAH", "110205013 | SHENGLI", "110201054 | SHIVIYACU", "110101044 | SIRI", "110204044 | SIRRI", "110203057 | SIRTICA", "110203058 | SKIKDA", "120206002 | SLEIPNER", "610811002 | SN 150", "610806001 | SN 150", "610807001 | SN 150", "610805002 | SN 150", "610810001 | SN 150", "610803001 | SN 150", "610812002 | SN 150", "610806004 | SN 275", "610812003 | SN 330", "610806005 | SN 330", "610811003 | SN 500", "610810002 | SN 500", "610807002 | SN 500", "610805003 | SN 500", "610812004 | SN 500", "610812005 | SN 600", "610806002 | SN 600", "610812006 | SN 85", "120206004 | SNOHVIT", "330201008 | SOLVENTE C9 (OU C9 AROMÁTICO)", "330101004 | SOLVENTE PARA BORRACHA", "110204045 | SORROSH", "110204046 | SOUEDIA", "110201063 | SOUTH BLEND", "110204055 | SOUTHERN PARS", "110206013 | SOVIET EXPORT BLEND", "110203059 | SOYO", "110203060 | SOYO 38", "611101001 | SPECTRASYN 100", "611101002 | SPECTRASYN 2", "611101003 | SPECTRASYN 4", "611101004 | SPECTRASYN 40", "611101005 | SPECTRASYN 6", "611101006 | SPECTRASYN 8", "610101001 | SPINDLE", "610401001 | SPINDLE RR", "610906001 | SPINDLE RR", "610813001 | SPINDLE RR", "611203001 | SR 130 - NAFTÊNICO", "610905002 | STAR 10", "610905003 | STAR 12", "610905004 | STAR 4", "610905005 | STAR 6", "110206015 | STATFJORD", "110206014 | STATFJORD LOW SULFUR", "110204052 | SUEDIE", "110205015 | SUMATRAN HEAVY", "110205014 | SUMATRAN LIGHT", "611105001 | SYNFLUID PAO 100", "611105002 | SYNFLUID PAO 4", "611105003 | SYNFLUID PAO 40", "611105004 | SYNFLUID PAO 6", "611105005 | SYNFLUID PAO 8", "110204047 | SYRIAN LIGHT", "611203003 | T 9 - NAFTÊNICO", "110205016 | TACHING", "110203061 | TAKULA", "110205017 | TAPIS", "110204054 | TAQ TAQ", "110106009 | TARTARUGA", "110203062 | TCHATAMBA", "110206016 | TENGIZ", "120205007 | TERENGANU", "120201003 | TERRA DEL FUEGO", "620101006 | TÊXTIL / AMACIANTE DE FIBRAS", "120205008 | THAI", "120204006 | THAMAMA", "110201055 | TIA JUANA", "110201056 | TIA JUANA MEDIO", "110201057 | TIA JUANA PESADO", "110103016 | TIGRE", "110205018 | TIONG", "110107005 | TIRO", "330201002 | TOLUENO", "620504001 | TRANSMISSÃO AUTOMÁTICA", "620503001 | TRANSMISSÕES E SISTEMAS HIDRÁULICOS", "110101034 | TRILHA", "110107004 | TUPI", "610101007 | TURBINA LEVE", "610101008 | TURBINA PESADO", "110105014 | UBARANA/AGULHA", "110205019 | UDANG", "110103012 | UIRAPURU", "110203063 | UKPOKITI", "611004001 | ULTRA-S 2", "611004002 | ULTRA-S 4", "611004003 | ULTRA-S 6", "611004004 | ULTRA-S 8", "120204007 | UMM SAIF", "110204048 | UMM SHAIF", "110105013 | UPANEMA", "110204049 | UPPER ZAKUM", "110206017 | URAL", "110109001 | URUCU", "110107006 | URUGUA-TAMBAU", "110203100 | USAN BLEND", "110203100 | USAN BLEND", "110206027 | VARANDEY", "120207006 | VARANUS", "110201059 | VASCONIA BLEND", "110201058 | VASCONIA 29,3", "640301001 | VASELINA", "110101035 | VERMELHO", "611002001 | VHVI 4", "611002002 | VHVI 6", "611002003 | VHVI 8", "110101036 | VIOLA", "611205001 | VISTONE A-10 - ÉSTER", "110206022 | VITYAZ", "110101037 | VOADOR", "110202010 | WHITE ROSE", "110205020 | WIDURI", "120207005 | WOOLLYBUTT CRUDE", "110206018 | WYTCH FARM", "110108006 | XAREU/ATUM", "611005001 | XHVI 4", "611005002 | XHVI 8", "110203076 | XICOMBA", "110205021 | XIJIANG", "330201003 | XILENOS", "130101001 | XISTO BRUTO", "110201060 | YANAYACU", "110203071 | YOHO", "611006001 | YUBASE 3", "611006002 | YUBASE 4", "611006003 | YUBASE 6", "110203065 | ZAFIRO", "110203064 | ZAIRE", "110206026 | ZAKINSKAYA", "110204050 | ZAKUM", "110203066 | ZARZAITINE", "110203067 | ZEIT BAY", "110201061 | ZUATA", "110203068 | ZUEITINA", "110105026 | 1-FAC-2-RN", "110106008 | 1-WW-1-BA", "610902001 | 100N", "610901005 | 100N", "610901001 | 100R", "610901002 | 150R", "610901003 | 220R", "610902002 | 225N", "610902003 | 600N", "610901004 | 600R"})
        Me.cboCodigoANP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCodigoANP.Size = New System.Drawing.Size(379, 20)
        Me.cboCodigoANP.TabIndex = 64
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(755, 36)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl70.TabIndex = 67
        Me.LabelControl70.Text = "UF"
        '
        'cboUF
        '
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(774, 33)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(48, 20)
        Me.cboUF.TabIndex = 65
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(284, 36)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl69.TabIndex = 66
        Me.LabelControl69.Text = "Código ANP"
        '
        'lueCFOP
        '
        Me.lueCFOP.EnterMoveNextControl = True
        Me.lueCFOP.Location = New System.Drawing.Point(97, 33)
        Me.lueCFOP.Name = "lueCFOP"
        Me.lueCFOP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCFOP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CFOP", "CFOP", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NatOper", "Descrição", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueCFOP.Properties.DataSource = Me.CFOPBindingSource
        Me.lueCFOP.Properties.DisplayMember = "CFOP"
        Me.lueCFOP.Properties.NullText = ""
        Me.lueCFOP.Properties.PopupWidth = 500
        Me.lueCFOP.Properties.ValueMember = "CFOP"
        Me.lueCFOP.Size = New System.Drawing.Size(138, 20)
        Me.lueCFOP.TabIndex = 0
        Me.lueCFOP.Tag = "CFOP"
        '
        'CFOPBindingSource
        '
        Me.CFOPBindingSource.DataMember = "CFOP"
        Me.CFOPBindingSource.DataSource = Me.DsNanoCommerce
        '
        'txtGenero
        '
        Me.txtGenero.CasasDecimais = 0
        Me.txtGenero.EnterMoveNextControl = True
        Me.txtGenero.Location = New System.Drawing.Point(495, 68)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Numerico = True
        Me.txtGenero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGenero.Properties.MaxLength = 2
        Me.txtGenero.Size = New System.Drawing.Size(138, 20)
        Me.txtGenero.TabIndex = 3
        Me.txtGenero.Visible = False
        '
        'txtEXTIPI
        '
        Me.txtEXTIPI.CasasDecimais = 0
        Me.txtEXTIPI.EnterMoveNextControl = True
        Me.txtEXTIPI.Location = New System.Drawing.Point(495, 68)
        Me.txtEXTIPI.Name = "txtEXTIPI"
        Me.txtEXTIPI.Numerico = True
        Me.txtEXTIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEXTIPI.Properties.MaxLength = 3
        Me.txtEXTIPI.Size = New System.Drawing.Size(130, 20)
        Me.txtEXTIPI.TabIndex = 1
        Me.txtEXTIPI.Visible = False
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(451, 71)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl48.TabIndex = 52
        Me.LabelControl48.Text = "EX_TIPI"
        Me.LabelControl48.Visible = False
        '
        'txtNfeNCM
        '
        Me.txtNfeNCM.CasasDecimais = 0
        Me.txtNfeNCM.EnterMoveNextControl = True
        Me.txtNfeNCM.Location = New System.Drawing.Point(346, 7)
        Me.txtNfeNCM.Name = "txtNfeNCM"
        Me.txtNfeNCM.Numerico = False
        Me.txtNfeNCM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNfeNCM.Properties.MaxLength = 8
        Me.txtNfeNCM.Size = New System.Drawing.Size(142, 20)
        Me.txtNfeNCM.TabIndex = 1
        Me.txtNfeNCM.Tag = "NCM"
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(454, 71)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl47.TabIndex = 51
        Me.LabelControl47.Text = "Gênero"
        Me.LabelControl47.Visible = False
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(379, 91)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl57.TabIndex = 35
        Me.LabelControl57.Text = "Regime"
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(318, 10)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl56.TabIndex = 54
        Me.LabelControl56.Text = "NCM"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(64, 36)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl23.TabIndex = 53
        Me.LabelControl23.Text = "CFOP"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GridControl3)
        Me.GroupControl4.Controls.Add(Me.btnAddNfe)
        Me.GroupControl4.Controls.Add(Me.btnExcluirNfe)
        Me.GroupControl4.Controls.Add(Me.txtUniCom)
        Me.GroupControl4.Controls.Add(Me.txtValCom)
        Me.GroupControl4.Controls.Add(Me.cboMIPI)
        Me.GroupControl4.Controls.Add(Me.txtValTrib)
        Me.GroupControl4.Controls.Add(Me.txtQtdTrib)
        Me.GroupControl4.Controls.Add(Me.txtQtdN)
        Me.GroupControl4.Controls.Add(Me.txtUniTrib)
        Me.GroupControl4.Location = New System.Drawing.Point(735, 125)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(120, 22)
        Me.GroupControl4.TabIndex = 7
        Me.GroupControl4.Text = "CST Adiconados"
        Me.GroupControl4.Visible = False
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbNfe"
        Me.GridControl3.DataSource = Me.dsNfe
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 20)
        Me.GridControl3.MainView = Me.grd3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAltNfe})
        Me.GridControl3.Size = New System.Drawing.Size(985, 80)
        Me.GridControl3.TabIndex = 37
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'dsNfe
        '
        Me.dsNfe.DataSetName = "NewDataSet"
        Me.dsNfe.Tables.AddRange(New System.Data.DataTable() {Me.tbNfe})
        '
        'tbNfe
        '
        Me.tbNfe.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43})
        Me.tbNfe.TableName = "tbNfe"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Codigo"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "CST"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Regime"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Origem"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "CalculoCred"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ModBC"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "RedBC"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Icms"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ModBCST"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "RedBCST"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "MVaST"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "IcmsST"
        '
        'grd3
        '
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo1, Me.colCST, Me.colRegime, Me.colOrigem, Me.colCalculoCred, Me.colModBC, Me.colRedBC, Me.colIcms, Me.colModBCST, Me.colRedBCST, Me.colMVaST, Me.colIcmsST})
        Me.grd3.GridControl = Me.GridControl3
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colCodigo1
        '
        Me.colCodigo1.Caption = "Codigo"
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.Name = "colCodigo1"
        Me.colCodigo1.OptionsColumn.ReadOnly = True
        '
        'colCST
        '
        Me.colCST.Caption = "CST"
        Me.colCST.ColumnEdit = Me.txtAltNfe
        Me.colCST.FieldName = "CST"
        Me.colCST.Name = "colCST"
        Me.colCST.OptionsColumn.ReadOnly = True
        Me.colCST.Visible = True
        Me.colCST.VisibleIndex = 1
        Me.colCST.Width = 61
        '
        'txtAltNfe
        '
        Me.txtAltNfe.AutoHeight = False
        Me.txtAltNfe.Name = "txtAltNfe"
        '
        'colRegime
        '
        Me.colRegime.Caption = "Regime"
        Me.colRegime.ColumnEdit = Me.txtAltNfe
        Me.colRegime.FieldName = "Regime"
        Me.colRegime.Name = "colRegime"
        Me.colRegime.OptionsColumn.ReadOnly = True
        Me.colRegime.Visible = True
        Me.colRegime.VisibleIndex = 0
        Me.colRegime.Width = 206
        '
        'colOrigem
        '
        Me.colOrigem.Caption = "Origem"
        Me.colOrigem.ColumnEdit = Me.txtAltNfe
        Me.colOrigem.FieldName = "Origem"
        Me.colOrigem.Name = "colOrigem"
        Me.colOrigem.OptionsColumn.ReadOnly = True
        Me.colOrigem.Visible = True
        Me.colOrigem.VisibleIndex = 2
        Me.colOrigem.Width = 71
        '
        'colCalculoCred
        '
        Me.colCalculoCred.AppearanceCell.Options.UseTextOptions = True
        Me.colCalculoCred.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCalculoCred.Caption = "Calc. do Créd."
        Me.colCalculoCred.FieldName = "CalculoCred"
        Me.colCalculoCred.Name = "colCalculoCred"
        Me.colCalculoCred.OptionsColumn.ReadOnly = True
        Me.colCalculoCred.Visible = True
        Me.colCalculoCred.VisibleIndex = 3
        Me.colCalculoCred.Width = 91
        '
        'colModBC
        '
        Me.colModBC.Caption = "Mod. BC"
        Me.colModBC.FieldName = "ModBC"
        Me.colModBC.Name = "colModBC"
        Me.colModBC.OptionsColumn.ReadOnly = True
        Me.colModBC.Visible = True
        Me.colModBC.VisibleIndex = 4
        '
        'colRedBC
        '
        Me.colRedBC.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBC.Caption = "Red. BC"
        Me.colRedBC.FieldName = "RedBC"
        Me.colRedBC.Name = "colRedBC"
        Me.colRedBC.OptionsColumn.ReadOnly = True
        Me.colRedBC.Visible = True
        Me.colRedBC.VisibleIndex = 5
        '
        'colIcms
        '
        Me.colIcms.AppearanceCell.Options.UseTextOptions = True
        Me.colIcms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colIcms.Caption = "ICMS"
        Me.colIcms.FieldName = "Icms"
        Me.colIcms.Name = "colIcms"
        Me.colIcms.OptionsColumn.ReadOnly = True
        Me.colIcms.Visible = True
        Me.colIcms.VisibleIndex = 6
        '
        'colModBCST
        '
        Me.colModBCST.Caption = "Mod. BC ST"
        Me.colModBCST.FieldName = "ModBCST"
        Me.colModBCST.Name = "colModBCST"
        Me.colModBCST.OptionsColumn.ReadOnly = True
        Me.colModBCST.Visible = True
        Me.colModBCST.VisibleIndex = 7
        '
        'colRedBCST
        '
        Me.colRedBCST.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBCST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBCST.Caption = "Red. BC ST"
        Me.colRedBCST.FieldName = "RedBCST"
        Me.colRedBCST.Name = "colRedBCST"
        Me.colRedBCST.OptionsColumn.ReadOnly = True
        Me.colRedBCST.Visible = True
        Me.colRedBCST.VisibleIndex = 8
        '
        'colMVaST
        '
        Me.colMVaST.AppearanceCell.Options.UseTextOptions = True
        Me.colMVaST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMVaST.Caption = "M. V. A. ST"
        Me.colMVaST.FieldName = "MVaST"
        Me.colMVaST.Name = "colMVaST"
        Me.colMVaST.OptionsColumn.ReadOnly = True
        Me.colMVaST.Visible = True
        Me.colMVaST.VisibleIndex = 9
        '
        'colIcmsST
        '
        Me.colIcmsST.AppearanceCell.Options.UseTextOptions = True
        Me.colIcmsST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colIcmsST.Caption = "ICMS ST"
        Me.colIcmsST.FieldName = "IcmsST"
        Me.colIcmsST.Name = "colIcmsST"
        Me.colIcmsST.OptionsColumn.ReadOnly = True
        Me.colIcmsST.Visible = True
        Me.colIcmsST.VisibleIndex = 10
        '
        'btnAddNfe
        '
        Me.btnAddNfe.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAddNfe.Location = New System.Drawing.Point(98, 100)
        Me.btnAddNfe.Name = "btnAddNfe"
        Me.btnAddNfe.Size = New System.Drawing.Size(88, 25)
        Me.btnAddNfe.TabIndex = 6
        Me.btnAddNfe.Text = "Adicionar"
        '
        'btnExcluirNfe
        '
        Me.btnExcluirNfe.AllowFocus = False
        Me.btnExcluirNfe.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnExcluirNfe.Location = New System.Drawing.Point(1, 100)
        Me.btnExcluirNfe.Name = "btnExcluirNfe"
        Me.btnExcluirNfe.Size = New System.Drawing.Size(88, 25)
        Me.btnExcluirNfe.TabIndex = 39
        Me.btnExcluirNfe.Text = "Excluir"
        '
        'txtUniCom
        '
        Me.txtUniCom.CasasDecimais = 0
        Me.txtUniCom.EnterMoveNextControl = True
        Me.txtUniCom.Location = New System.Drawing.Point(1, 2)
        Me.txtUniCom.Name = "txtUniCom"
        Me.txtUniCom.Numerico = False
        Me.txtUniCom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUniCom.Properties.MaxLength = 6
        Me.txtUniCom.Size = New System.Drawing.Size(130, 20)
        Me.txtUniCom.TabIndex = 55
        Me.txtUniCom.Visible = False
        '
        'txtValCom
        '
        Me.txtValCom.CasasDecimais = 4
        Me.txtValCom.EnterMoveNextControl = True
        Me.txtValCom.Location = New System.Drawing.Point(24, -1)
        Me.txtValCom.Name = "txtValCom"
        Me.txtValCom.Numerico = True
        Me.txtValCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValCom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValCom.Properties.MaxLength = 16
        Me.txtValCom.Size = New System.Drawing.Size(130, 20)
        Me.txtValCom.TabIndex = 57
        Me.txtValCom.Visible = False
        '
        'cboMIPI
        '
        Me.cboMIPI.EnterMoveNextControl = True
        Me.cboMIPI.Location = New System.Drawing.Point(0, 1)
        Me.cboMIPI.Name = "cboMIPI"
        Me.cboMIPI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMIPI.Properties.Items.AddRange(New Object() {"", "1"})
        Me.cboMIPI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMIPI.Size = New System.Drawing.Size(100, 20)
        Me.cboMIPI.TabIndex = 48
        Me.cboMIPI.Visible = False
        '
        'txtValTrib
        '
        Me.txtValTrib.CasasDecimais = 4
        Me.txtValTrib.EnterMoveNextControl = True
        Me.txtValTrib.Location = New System.Drawing.Point(5, -1)
        Me.txtValTrib.Name = "txtValTrib"
        Me.txtValTrib.Numerico = True
        Me.txtValTrib.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValTrib.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValTrib.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValTrib.Properties.MaxLength = 16
        Me.txtValTrib.Size = New System.Drawing.Size(130, 20)
        Me.txtValTrib.TabIndex = 44
        Me.txtValTrib.Visible = False
        '
        'txtQtdTrib
        '
        Me.txtQtdTrib.CasasDecimais = 4
        Me.txtQtdTrib.EnterMoveNextControl = True
        Me.txtQtdTrib.Location = New System.Drawing.Point(5, -1)
        Me.txtQtdTrib.Name = "txtQtdTrib"
        Me.txtQtdTrib.Numerico = True
        Me.txtQtdTrib.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdTrib.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdTrib.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdTrib.Properties.MaxLength = 12
        Me.txtQtdTrib.Size = New System.Drawing.Size(130, 20)
        Me.txtQtdTrib.TabIndex = 42
        Me.txtQtdTrib.Visible = False
        '
        'txtQtdN
        '
        Me.txtQtdN.CasasDecimais = 3
        Me.txtQtdN.EnterMoveNextControl = True
        Me.txtQtdN.Location = New System.Drawing.Point(20, 2)
        Me.txtQtdN.Name = "txtQtdN"
        Me.txtQtdN.Numerico = True
        Me.txtQtdN.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtdN.Properties.MaxLength = 12
        Me.txtQtdN.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdN.TabIndex = 45
        Me.txtQtdN.Visible = False
        '
        'txtUniTrib
        '
        Me.txtUniTrib.CasasDecimais = 0
        Me.txtUniTrib.EnterMoveNextControl = True
        Me.txtUniTrib.Location = New System.Drawing.Point(2, 2)
        Me.txtUniTrib.Name = "txtUniTrib"
        Me.txtUniTrib.Numerico = False
        Me.txtUniTrib.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUniTrib.Properties.MaxLength = 6
        Me.txtUniTrib.Size = New System.Drawing.Size(130, 20)
        Me.txtUniTrib.TabIndex = 41
        Me.txtUniTrib.Visible = False
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(742, 132)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl59.TabIndex = 58
        Me.LabelControl59.Text = "Val. Com. R$"
        Me.LabelControl59.Visible = False
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(759, 129)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl43.TabIndex = 46
        Me.LabelControl43.Text = "Merc. IPI"
        Me.LabelControl43.Visible = False
        '
        'cboRegime
        '
        Me.cboRegime.EnterMoveNextControl = True
        Me.cboRegime.Location = New System.Drawing.Point(419, 88)
        Me.cboRegime.Name = "cboRegime"
        Me.cboRegime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRegime.Properties.Items.AddRange(New Object() {"TRIBUTAÇÃO NORMAL", "SIMPLES NACIONAL"})
        Me.cboRegime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRegime.Size = New System.Drawing.Size(97, 20)
        Me.cboRegime.TabIndex = 0
        Me.cboRegime.Tag = "Regime"
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(745, 132)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl45.TabIndex = 49
        Me.LabelControl45.Text = "Uni. Trib."
        Me.LabelControl45.Visible = False
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(742, 129)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl60.TabIndex = 59
        Me.LabelControl60.Text = "Uni. Com."
        Me.LabelControl60.Visible = False
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(742, 127)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl46.TabIndex = 50
        Me.LabelControl46.Text = "Qtd Trib."
        Me.LabelControl46.Visible = False
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(762, 134)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl44.TabIndex = 47
        Me.LabelControl44.Text = "Val. Trib. R$"
        Me.LabelControl44.Visible = False
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(827, 127)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl42.TabIndex = 43
        Me.LabelControl42.Text = "Qtd N"
        Me.LabelControl42.Visible = False
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.nbcVenda)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl63)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl11)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(999, 236)
        Me.XtraTabPage1.Text = "Histórico"
        '
        'nbcVenda
        '
        Me.nbcVenda.ActiveGroup = Me.NavBarGroup1
        Me.nbcVenda.ContentButtonHint = Nothing
        Me.nbcVenda.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.nbcVenda.Dock = System.Windows.Forms.DockStyle.Right
        Me.nbcVenda.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.nbcVenda.Location = New System.Drawing.Point(967, 0)
        Me.nbcVenda.Name = "nbcVenda"
        Me.nbcVenda.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.nbcVenda.OptionsNavPane.ExpandedWidth = 999
        Me.nbcVenda.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        Me.nbcVenda.OptionsNavPane.ShowOverflowPanel = False
        Me.nbcVenda.OptionsNavPane.ShowSplitter = False
        Me.nbcVenda.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.nbcVenda.Size = New System.Drawing.Size(32, 236)
        Me.nbcVenda.TabIndex = 125
        Me.nbcVenda.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Ajuste"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 80
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.PanelControl12)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(995, 180)
        Me.NavBarGroupControlContainer2.TabIndex = 0
        '
        'PanelControl12
        '
        Me.PanelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl12.Controls.Add(Me.SimpleButton1)
        Me.PanelControl12.Controls.Add(Me.GroupControl2)
        Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl12.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(995, 180)
        Me.PanelControl12.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(954, 184)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(22, 22)
        Me.SimpleButton1.TabIndex = 52
        Me.SimpleButton1.Text = ">>"
        Me.SimpleButton1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GridControl5)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(995, 179)
        Me.GroupControl2.TabIndex = 54
        Me.GroupControl2.Text = "Hitórico de Ajuste"
        '
        'GridControl5
        '
        Me.GridControl5.DataMember = "tbAjuste"
        Me.GridControl5.DataSource = Me.dsAjuste
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.EmbeddedNavigator.Name = ""
        Me.GridControl5.Location = New System.Drawing.Point(2, 20)
        Me.GridControl5.MainView = Me.GridView3
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(991, 157)
        Me.GridControl5.TabIndex = 0
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'dsAjuste
        '
        Me.dsAjuste.DataSetName = "NewDataSet"
        Me.dsAjuste.Tables.AddRange(New System.Data.DataTable() {Me.tbAjuste})
        '
        'tbAjuste
        '
        Me.tbAjuste.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65})
        Me.tbAjuste.TableName = "tbAjuste"
        '
        'DataColumn58
        '
        Me.DataColumn58.Caption = "Codigo"
        Me.DataColumn58.ColumnName = "Codigo"
        '
        'DataColumn59
        '
        Me.DataColumn59.Caption = "CodProd"
        Me.DataColumn59.ColumnName = "CodProd"
        '
        'DataColumn60
        '
        Me.DataColumn60.Caption = "Nome"
        Me.DataColumn60.ColumnName = "Nome"
        '
        'DataColumn61
        '
        Me.DataColumn61.Caption = "Qtd"
        Me.DataColumn61.ColumnName = "Qtd"
        '
        'DataColumn62
        '
        Me.DataColumn62.Caption = "Data"
        Me.DataColumn62.ColumnName = "Data"
        '
        'DataColumn63
        '
        Me.DataColumn63.Caption = "CodConfig"
        Me.DataColumn63.ColumnName = "CodConfig"
        '
        'DataColumn64
        '
        Me.DataColumn64.Caption = "CodInterno"
        Me.DataColumn64.ColumnName = "CodInterno"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "Tabela"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo3, Me.colCodProd, Me.colNome1, Me.colQtd3, Me.colData2, Me.colCodConfig1, Me.colCodInterno, Me.colTabela})
        Me.GridView3.GridControl = Me.GridControl5
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCodigo3
        '
        Me.colCodigo3.Caption = "Codigo"
        Me.colCodigo3.FieldName = "Codigo"
        Me.colCodigo3.Name = "colCodigo3"
        Me.colCodigo3.OptionsColumn.ReadOnly = True
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colNome1
        '
        Me.colNome1.Caption = "Nome"
        Me.colNome1.FieldName = "Nome"
        Me.colNome1.Name = "colNome1"
        Me.colNome1.OptionsColumn.ReadOnly = True
        Me.colNome1.Visible = True
        Me.colNome1.VisibleIndex = 1
        Me.colNome1.Width = 492
        '
        'colQtd3
        '
        Me.colQtd3.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd3.Caption = "Qtd "
        Me.colQtd3.FieldName = "Qtd"
        Me.colQtd3.Name = "colQtd3"
        Me.colQtd3.OptionsColumn.ReadOnly = True
        Me.colQtd3.Visible = True
        Me.colQtd3.VisibleIndex = 3
        Me.colQtd3.Width = 139
        '
        'colData2
        '
        Me.colData2.AppearanceCell.Options.UseTextOptions = True
        Me.colData2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData2.Caption = "Data"
        Me.colData2.FieldName = "Data"
        Me.colData2.Name = "colData2"
        Me.colData2.OptionsColumn.ReadOnly = True
        Me.colData2.Visible = True
        Me.colData2.VisibleIndex = 4
        Me.colData2.Width = 134
        '
        'colCodConfig1
        '
        Me.colCodConfig1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCodConfig1.Caption = "Código Loja"
        Me.colCodConfig1.FieldName = "CodConfig"
        Me.colCodConfig1.Name = "colCodConfig1"
        Me.colCodConfig1.OptionsColumn.ReadOnly = True
        Me.colCodConfig1.Visible = True
        Me.colCodConfig1.VisibleIndex = 5
        Me.colCodConfig1.Width = 156
        '
        'colCodInterno
        '
        Me.colCodInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodInterno.Caption = "Código Interno"
        Me.colCodInterno.FieldName = "CodInterno"
        Me.colCodInterno.Name = "colCodInterno"
        Me.colCodInterno.OptionsColumn.ReadOnly = True
        Me.colCodInterno.Visible = True
        Me.colCodInterno.VisibleIndex = 0
        Me.colCodInterno.Width = 116
        '
        'colTabela
        '
        Me.colTabela.Caption = "Ajuste"
        Me.colTabela.FieldName = "Tabela"
        Me.colTabela.Name = "colTabela"
        Me.colTabela.OptionsColumn.ReadOnly = True
        Me.colTabela.Visible = True
        Me.colTabela.VisibleIndex = 2
        Me.colTabela.Width = 137
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl5
        Me.GridView4.Name = "GridView4"
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl63.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl63.Appearance.Options.UseFont = True
        Me.LabelControl63.Appearance.Options.UseForeColor = True
        Me.LabelControl63.Location = New System.Drawing.Point(710, -2)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl63.TabIndex = 80
        Me.LabelControl63.Text = "Histórico"
        '
        'PanelControl11
        '
        Me.PanelControl11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl11.Controls.Add(Me.btnFiltrar)
        Me.PanelControl11.Controls.Add(Me.Label3)
        Me.PanelControl11.Controls.Add(Me.Label2)
        Me.PanelControl11.Controls.Add(Me.dtFinal)
        Me.PanelControl11.Controls.Add(Me.dtInicial)
        Me.PanelControl11.Controls.Add(Me.LabelControl16)
        Me.PanelControl11.Controls.Add(Me.txtQtdComprada)
        Me.PanelControl11.Controls.Add(Me.Label1)
        Me.PanelControl11.Controls.Add(Me.txtQtdDescarte)
        Me.PanelControl11.Controls.Add(Me.LabelControl25)
        Me.PanelControl11.Controls.Add(Me.lblTotalGasto)
        Me.PanelControl11.Controls.Add(Me.LabelControl41)
        Me.PanelControl11.Controls.Add(Me.txtQtdDevolvida)
        Me.PanelControl11.Controls.Add(Me.lblCred)
        Me.PanelControl11.Controls.Add(Me.txtAlteracao)
        Me.PanelControl11.Controls.Add(Me.txtQtdVendida)
        Me.PanelControl11.Controls.Add(Me.txtQtdEstoque)
        Me.PanelControl11.Location = New System.Drawing.Point(704, 7)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(252, 229)
        Me.PanelControl11.TabIndex = 79
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(135, 188)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(110, 23)
        Me.btnFiltrar.TabIndex = 114
        Me.btnFiltrar.Text = "Filtrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Data Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Data Inicial"
        '
        'dtFinal
        '
        Me.dtFinal.EditValue = Nothing
        Me.dtFinal.Location = New System.Drawing.Point(135, 162)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFinal.Size = New System.Drawing.Size(110, 20)
        Me.dtFinal.TabIndex = 111
        '
        'dtInicial
        '
        Me.dtInicial.EditValue = Nothing
        Me.dtInicial.Location = New System.Drawing.Point(12, 162)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.dtInicial.Properties.Appearance.Options.UseBackColor = True
        Me.dtInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtInicial.Size = New System.Drawing.Size(110, 20)
        Me.dtInicial.TabIndex = 110
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(135, 11)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl16.TabIndex = 109
        Me.LabelControl16.Text = "Qtd Comprada"
        '
        'txtQtdComprada
        '
        Me.txtQtdComprada.CasasDecimais = 2
        Me.txtQtdComprada.EnterMoveNextControl = True
        Me.txtQtdComprada.Location = New System.Drawing.Point(135, 30)
        Me.txtQtdComprada.Name = "txtQtdComprada"
        Me.txtQtdComprada.Numerico = True
        Me.txtQtdComprada.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtQtdComprada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdComprada.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtdComprada.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdComprada.Properties.Appearance.Options.UseFont = True
        Me.txtQtdComprada.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtdComprada.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdComprada.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdComprada.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdComprada.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtQtdComprada.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdComprada.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtQtdComprada.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtQtdComprada.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdComprada.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdComprada.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdComprada.Properties.MaxLength = 15
        Me.txtQtdComprada.Properties.ReadOnly = True
        Me.txtQtdComprada.Size = New System.Drawing.Size(110, 21)
        Me.txtQtdComprada.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(132, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Qtd Descartada"
        '
        'txtQtdDescarte
        '
        Me.txtQtdDescarte.CasasDecimais = 2
        Me.txtQtdDescarte.EnterMoveNextControl = True
        Me.txtQtdDescarte.Location = New System.Drawing.Point(135, 69)
        Me.txtQtdDescarte.Name = "txtQtdDescarte"
        Me.txtQtdDescarte.Numerico = True
        Me.txtQtdDescarte.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQtdDescarte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdDescarte.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdDescarte.Properties.Appearance.Options.UseFont = True
        Me.txtQtdDescarte.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdDescarte.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtQtdDescarte.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdDescarte.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdDescarte.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdDescarte.Properties.ReadOnly = True
        Me.txtQtdDescarte.Size = New System.Drawing.Size(110, 20)
        Me.txtQtdDescarte.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl25.TabIndex = 69
        Me.LabelControl25.Text = "Qtd Estoque"
        '
        'lblTotalGasto
        '
        Me.lblTotalGasto.AutoSize = True
        Me.lblTotalGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalGasto.Location = New System.Drawing.Point(9, 53)
        Me.lblTotalGasto.Name = "lblTotalGasto"
        Me.lblTotalGasto.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalGasto.TabIndex = 103
        Me.lblTotalGasto.Text = "Qtd Devolvida"
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl41.Appearance.Options.UseFont = True
        Me.LabelControl41.Location = New System.Drawing.Point(135, 90)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl41.TabIndex = 73
        Me.LabelControl41.Text = "Alteração"
        '
        'txtQtdDevolvida
        '
        Me.txtQtdDevolvida.CasasDecimais = 2
        Me.txtQtdDevolvida.EnterMoveNextControl = True
        Me.txtQtdDevolvida.Location = New System.Drawing.Point(12, 69)
        Me.txtQtdDevolvida.Name = "txtQtdDevolvida"
        Me.txtQtdDevolvida.Numerico = True
        Me.txtQtdDevolvida.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtQtdDevolvida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdDevolvida.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdDevolvida.Properties.Appearance.Options.UseFont = True
        Me.txtQtdDevolvida.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdDevolvida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdDevolvida.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdDevolvida.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdDevolvida.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtQtdDevolvida.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdDevolvida.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdDevolvida.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdDevolvida.Properties.ReadOnly = True
        Me.txtQtdDevolvida.Size = New System.Drawing.Size(110, 20)
        Me.txtQtdDevolvida.TabIndex = 3
        '
        'lblCred
        '
        Me.lblCred.AutoSize = True
        Me.lblCred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCred.Location = New System.Drawing.Point(9, 90)
        Me.lblCred.Name = "lblCred"
        Me.lblCred.Size = New System.Drawing.Size(75, 13)
        Me.lblCred.TabIndex = 101
        Me.lblCred.Text = "Qtd Vendida"
        '
        'txtAlteracao
        '
        Me.txtAlteracao.CasasDecimais = 0
        Me.txtAlteracao.EnterMoveNextControl = True
        Me.txtAlteracao.Location = New System.Drawing.Point(135, 106)
        Me.txtAlteracao.Name = "txtAlteracao"
        Me.txtAlteracao.Numerico = False
        Me.txtAlteracao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlteracao.Properties.Appearance.Options.UseBackColor = True
        Me.txtAlteracao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlteracao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlteracao.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAlteracao.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtAlteracao.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtAlteracao.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAlteracao.Properties.ReadOnly = True
        Me.txtAlteracao.Size = New System.Drawing.Size(110, 20)
        Me.txtAlteracao.TabIndex = 1
        '
        'txtQtdVendida
        '
        Me.txtQtdVendida.CasasDecimais = 2
        Me.txtQtdVendida.Location = New System.Drawing.Point(12, 106)
        Me.txtQtdVendida.Name = "txtQtdVendida"
        Me.txtQtdVendida.Numerico = True
        Me.txtQtdVendida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdVendida.Properties.Appearance.Options.UseFont = True
        Me.txtQtdVendida.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdVendida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdVendida.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdVendida.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdVendida.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightGreen
        Me.txtQtdVendida.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdVendida.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdVendida.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdVendida.Properties.ReadOnly = True
        Me.txtQtdVendida.Size = New System.Drawing.Size(110, 20)
        Me.txtQtdVendida.TabIndex = 7
        '
        'txtQtdEstoque
        '
        Me.txtQtdEstoque.CasasDecimais = 2
        Me.txtQtdEstoque.EnterMoveNextControl = True
        Me.txtQtdEstoque.Location = New System.Drawing.Point(12, 30)
        Me.txtQtdEstoque.Name = "txtQtdEstoque"
        Me.txtQtdEstoque.Numerico = False
        Me.txtQtdEstoque.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtQtdEstoque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdEstoque.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtdEstoque.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdEstoque.Properties.Appearance.Options.UseFont = True
        Me.txtQtdEstoque.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtdEstoque.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdEstoque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdEstoque.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdEstoque.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtQtdEstoque.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdEstoque.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtQtdEstoque.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtQtdEstoque.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdEstoque.Properties.MaxLength = 15
        Me.txtQtdEstoque.Properties.ReadOnly = True
        Me.txtQtdEstoque.Size = New System.Drawing.Size(110, 21)
        Me.txtQtdEstoque.TabIndex = 4
        Me.txtQtdEstoque.Tag = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(698, 236)
        Me.GroupControl1.TabIndex = 82
        Me.GroupControl1.Text = "Hitórico de Compra"
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbFor"
        Me.GridControl4.DataSource = Me.dsProduto
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(2, 20)
        Me.GridControl4.MainView = Me.grd4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(694, 214)
        Me.GridControl4.TabIndex = 81
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd4, Me.GridView1})
        '
        'grd4
        '
        Me.grd4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFornecedor, Me.colCodigo2, Me.colValorUnitario, Me.colQtd2, Me.colValorTotal, Me.colData1, Me.colNumeroNF, Me.colQtdProd, Me.colValCusto})
        Me.grd4.GridControl = Me.GridControl4
        Me.grd4.Name = "grd4"
        Me.grd4.OptionsView.ShowAutoFilterRow = True
        Me.grd4.OptionsView.ShowGroupPanel = False
        '
        'colFornecedor
        '
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 3
        Me.colFornecedor.Width = 157
        '
        'colCodigo2
        '
        Me.colCodigo2.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo2.Caption = "Código"
        Me.colCodigo2.FieldName = "Codigo"
        Me.colCodigo2.Name = "colCodigo2"
        Me.colCodigo2.OptionsColumn.ReadOnly = True
        Me.colCodigo2.Visible = True
        Me.colCodigo2.VisibleIndex = 2
        Me.colCodigo2.Width = 60
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Val. Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 7
        Me.colValorUnitario.Width = 82
        '
        'colQtd2
        '
        Me.colQtd2.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd2.Caption = "Qtd"
        Me.colQtd2.FieldName = "Qtd"
        Me.colQtd2.Name = "colQtd2"
        Me.colQtd2.OptionsColumn.ReadOnly = True
        Me.colQtd2.Visible = True
        Me.colQtd2.VisibleIndex = 5
        Me.colQtd2.Width = 40
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Val. Total R$"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 8
        Me.colValorTotal.Width = 83
        '
        'colData1
        '
        Me.colData1.AppearanceCell.Options.UseTextOptions = True
        Me.colData1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData1.Caption = "Data"
        Me.colData1.FieldName = "Data"
        Me.colData1.Name = "colData1"
        Me.colData1.OptionsColumn.ReadOnly = True
        Me.colData1.Visible = True
        Me.colData1.VisibleIndex = 1
        Me.colData1.Width = 73
        '
        'colNumeroNF
        '
        Me.colNumeroNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroNF.Caption = "Nº NF"
        Me.colNumeroNF.FieldName = "NumeroNF"
        Me.colNumeroNF.Name = "colNumeroNF"
        Me.colNumeroNF.OptionsColumn.ReadOnly = True
        Me.colNumeroNF.Visible = True
        Me.colNumeroNF.VisibleIndex = 0
        Me.colNumeroNF.Width = 59
        '
        'colQtdProd
        '
        Me.colQtdProd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdProd.Caption = "Qtd Prod."
        Me.colQtdProd.FieldName = "QtdProd"
        Me.colQtdProd.Name = "colQtdProd"
        Me.colQtdProd.OptionsColumn.ReadOnly = True
        Me.colQtdProd.Visible = True
        Me.colQtdProd.VisibleIndex = 4
        Me.colQtdProd.Width = 69
        '
        'colValCusto
        '
        Me.colValCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValCusto.Caption = "Val. Custo R$"
        Me.colValCusto.FieldName = "ValCusto"
        Me.colValCusto.Name = "colValCusto"
        Me.colValCusto.OptionsColumn.ReadOnly = True
        Me.colValCusto.Visible = True
        Me.colValCusto.VisibleIndex = 6
        Me.colValCusto.Width = 87
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFornecedor, Me.colCodigo2, Me.colValorUnitario, Me.colQtd2, Me.colValorTotal, Me.colData1, Me.colNumeroNF, Me.colQtdProd, Me.colValCusto})
        Me.GridView1.GridControl = Me.GridControl4
        Me.GridView1.Name = "GridView1"
        '
        'tabOpc
        '
        Me.tabOpc.Controls.Add(Me.GroupControl5)
        Me.tabOpc.Controls.Add(Me.GroupControl3)
        Me.tabOpc.Controls.Add(Me.PanelControl15)
        Me.tabOpc.Name = "tabOpc"
        Me.tabOpc.PageVisible = False
        Me.tabOpc.Size = New System.Drawing.Size(999, 236)
        Me.tabOpc.Text = "Opções"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridControl7)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(299, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(543, 236)
        Me.GroupControl5.TabIndex = 1
        Me.GroupControl5.Text = "Opções"
        '
        'GridControl7
        '
        Me.GridControl7.DataMember = "tbOpc"
        Me.GridControl7.DataSource = Me.dsOpcao
        Me.GridControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl7.EmbeddedNavigator.Name = ""
        Me.GridControl7.Location = New System.Drawing.Point(2, 20)
        Me.GridControl7.MainView = Me.grd6
        Me.GridControl7.Name = "GridControl7"
        Me.GridControl7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkAddOpc})
        Me.GridControl7.Size = New System.Drawing.Size(539, 214)
        Me.GridControl7.TabIndex = 0
        Me.GridControl7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd6})
        '
        'dsOpcao
        '
        Me.dsOpcao.DataSetName = "NewDataSet"
        Me.dsOpcao.Tables.AddRange(New System.Data.DataTable() {Me.tbTipoOpc, Me.tbOpc})
        '
        'tbTipoOpc
        '
        Me.tbTipoOpc.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn69})
        Me.tbTipoOpc.TableName = "tbTipoOpc"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "TipoOpc"
        '
        'tbOpc
        '
        Me.tbOpc.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73})
        Me.tbOpc.TableName = "tbOpc"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "Codigo"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "TipoOpc"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "Opcao"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "AddOpc"
        Me.DataColumn73.DataType = GetType(Boolean)
        '
        'grd6
        '
        Me.grd6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo4, Me.colTipoOpc1, Me.colOpcao, Me.colAddOpc})
        Me.grd6.GridControl = Me.GridControl7
        Me.grd6.Name = "grd6"
        Me.grd6.OptionsView.ShowAutoFilterRow = True
        Me.grd6.OptionsView.ShowGroupPanel = False
        '
        'colCodigo4
        '
        Me.colCodigo4.Caption = "Codigo"
        Me.colCodigo4.FieldName = "Codigo"
        Me.colCodigo4.Name = "colCodigo4"
        Me.colCodigo4.OptionsColumn.ReadOnly = True
        '
        'colTipoOpc1
        '
        Me.colTipoOpc1.Caption = "TipoOpc"
        Me.colTipoOpc1.FieldName = "TipoOpc"
        Me.colTipoOpc1.Name = "colTipoOpc1"
        Me.colTipoOpc1.OptionsColumn.ReadOnly = True
        '
        'colOpcao
        '
        Me.colOpcao.Caption = "Opção"
        Me.colOpcao.FieldName = "Opcao"
        Me.colOpcao.Name = "colOpcao"
        Me.colOpcao.OptionsColumn.ReadOnly = True
        Me.colOpcao.Visible = True
        Me.colOpcao.VisibleIndex = 0
        Me.colOpcao.Width = 301
        '
        'colAddOpc
        '
        Me.colAddOpc.Caption = "Add"
        Me.colAddOpc.ColumnEdit = Me.chkAddOpc
        Me.colAddOpc.FieldName = "AddOpc"
        Me.colAddOpc.Name = "colAddOpc"
        Me.colAddOpc.Visible = True
        Me.colAddOpc.VisibleIndex = 1
        Me.colAddOpc.Width = 174
        '
        'chkAddOpc
        '
        Me.chkAddOpc.AutoHeight = False
        Me.chkAddOpc.Name = "chkAddOpc"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl6)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(299, 236)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Tipo Opções"
        '
        'GridControl6
        '
        Me.GridControl6.DataMember = "tbTipoOpc"
        Me.GridControl6.DataSource = Me.dsOpcao
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.EmbeddedNavigator.Name = ""
        Me.GridControl6.Location = New System.Drawing.Point(2, 20)
        Me.GridControl6.MainView = Me.grd5
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtTipoOpc})
        Me.GridControl6.Size = New System.Drawing.Size(295, 214)
        Me.GridControl6.TabIndex = 0
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd5})
        '
        'grd5
        '
        Me.grd5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grd5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd5.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd5.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd5.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd5.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd5.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoOpc})
        Me.grd5.GridControl = Me.GridControl6
        Me.grd5.Name = "grd5"
        Me.grd5.OptionsView.ShowAutoFilterRow = True
        Me.grd5.OptionsView.ShowGroupPanel = False
        '
        'colTipoOpc
        '
        Me.colTipoOpc.Caption = "Tipo"
        Me.colTipoOpc.ColumnEdit = Me.txtTipoOpc
        Me.colTipoOpc.FieldName = "TipoOpc"
        Me.colTipoOpc.Name = "colTipoOpc"
        Me.colTipoOpc.OptionsColumn.ReadOnly = True
        Me.colTipoOpc.Visible = True
        Me.colTipoOpc.VisibleIndex = 0
        '
        'txtTipoOpc
        '
        Me.txtTipoOpc.AutoHeight = False
        Me.txtTipoOpc.Name = "txtTipoOpc"
        '
        'PanelControl15
        '
        Me.PanelControl15.Controls.Add(Me.btnInserirTodosOpc)
        Me.PanelControl15.Controls.Add(Me.btnCadOpc)
        Me.PanelControl15.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl15.Location = New System.Drawing.Point(842, 0)
        Me.PanelControl15.Name = "PanelControl15"
        Me.PanelControl15.Size = New System.Drawing.Size(157, 236)
        Me.PanelControl15.TabIndex = 2
        '
        'btnInserirTodosOpc
        '
        Me.btnInserirTodosOpc.Location = New System.Drawing.Point(11, 32)
        Me.btnInserirTodosOpc.Name = "btnInserirTodosOpc"
        Me.btnInserirTodosOpc.Size = New System.Drawing.Size(139, 23)
        Me.btnInserirTodosOpc.TabIndex = 1
        Me.btnInserirTodosOpc.Text = "Inserir para Todos"
        '
        'btnCadOpc
        '
        Me.btnCadOpc.Location = New System.Drawing.Point(11, 3)
        Me.btnCadOpc.Name = "btnCadOpc"
        Me.btnCadOpc.Size = New System.Drawing.Size(139, 23)
        Me.btnCadOpc.TabIndex = 0
        Me.btnCadOpc.Text = "Cadastrar Opções"
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'CFOPTableAdapter
        '
        Me.CFOPTableAdapter.ClearBeforeFill = True
        '
        'ofdImagem
        '
        Me.ofdImagem.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'frmCadProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.grpProd)
        Me.Controls.Add(Me.tabProd)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCadProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produto"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProd.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDuplicar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTribPadrao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmFalta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueNomeLoj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCalc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalc.ResumeLayout(False)
        Me.grpCalc.PerformLayout()
        CType(Me.txtQtdTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPreco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProd.ResumeLayout(False)
        Me.tabPrinc.ResumeLayout(False)
        Me.tabPrinc.PerformLayout()
        CType(Me.txtValDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodBarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProdFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbcImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nbcImagem.ResumeLayout(False)
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl14.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grpQtd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQtd.ResumeLayout(False)
        Me.grpQtd.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterarQtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.picCod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFabricante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtValidade.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtValidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComissao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRevKM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodFab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeEstoque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeMinima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesoBruto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdMaxima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImpECF.ResumeLayout(False)
        Me.tabImpECF.PerformLayout()
        CType(Me.txtNCMImpProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodCF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIcms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPesa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIPPT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrib2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOriIcm2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCst2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOriIcm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCst.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNfe.ResumeLayout(False)
        Me.tabNfe.PerformLayout()
        CType(Me.cboTipoFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.tabImpostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImpostos.ResumeLayout(False)
        Me.tabICMS.ResumeLayout(False)
        Me.tabICMS.PerformLayout()
        CType(Me.cboModBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtICMSST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModBCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalcCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfeICMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMVAST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNfeCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIPI.ResumeLayout(False)
        Me.tabIPI.PerformLayout()
        CType(Me.txtCodEnq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotaIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPIS.ResumeLayout(False)
        Me.tabPIS.PerformLayout()
        CType(Me.txtAliquotaPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCofins.ResumeLayout(False)
        Me.tabCofins.PerformLayout()
        CType(Me.txtAliquotaCOFINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTCOFINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtPerICMSUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerFCPUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.cboModBcTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIcmsStTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModBcStTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalcCredTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIcmsTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBcStTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMvaStTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBcTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigemTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCstTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.txtCodEnqTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotaIpiTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCstIpiTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        Me.XtraTabPage7.PerformLayout()
        CType(Me.txtAliquotaPisTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCstPisTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraTabPage8.PerformLayout()
        CType(Me.txtAliquotaCofinsTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCstCofinsTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage9.ResumeLayout(False)
        Me.XtraTabPage9.PerformLayout()
        CType(Me.txtPercIcmsTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercFcpTN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodigoANP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCFOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEXTIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfeNCM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNfe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNfe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAltNfe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUniCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValTrib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdTrib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUniTrib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.nbcVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nbcVenda.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        Me.PanelControl11.PerformLayout()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdComprada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdDescarte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdDevolvida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlteracao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdVendida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdEstoque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOpc.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOpcao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTipoOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoOpc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUniMed As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpProd As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bmComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValCus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpCalc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCap As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCapital As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents salvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnWord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPdf As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pdfHtml As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblLocacao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFornecedor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGrp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGrp2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPer As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnCadGrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabProd As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPrinc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabImpECF As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtIPI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPreco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpQtd As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTam As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblQtdMin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblQtd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdeMin As Campos.NanoCampo
    Friend WithEvents txtQtde As Campos.NanoCampo
    Friend WithEvents txtTamanho As Campos.NanoCampo
    Friend WithEvents btnExcluirItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkAlterar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsQtd As System.Data.DataSet
    Friend WithEvents tbQtd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdMinima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsProduto As System.Data.DataSet
    Friend WithEvents tbProduto As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadeMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentagens As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdMinima1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAlterarQtd As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents txtCodInt As Campos.NanoCampo
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents txtLoc As Campos.NanoCampo
    Friend WithEvents txtPor1 As Campos.NanoCampo
    Friend WithEvents txtVal As Campos.NanoCampo
    Friend WithEvents txtValCus As Campos.NanoCampo
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents colEmFalta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents colEmFalta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFIA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPesa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIPPT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTrib2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboOriIcm2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCst2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTrib As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboOriIcm As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboCst As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtIcms As Campos.NanoCampo
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents colValorCustoQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboCodCF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblCF As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colNivelComboCodCF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents chkTamanho As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colPendente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents chkDesc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesconto As Campos.NanoCampo
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCadSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSet As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblTipo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboFabricante As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lueNomeLoj As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lueLoja As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLoja As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboMod As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnAdic As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents btnImposto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkEmFalta As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnCadFor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabNfe As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabImpostos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents btnInsNfeTodos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUniCom As Campos.NanoCampo
    Friend WithEvents txtValCom As Campos.NanoCampo
    Friend WithEvents lueCFOP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNfeNCM As Campos.NanoCampo
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdN As Campos.NanoCampo
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUniTrib As Campos.NanoCampo
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdTrib As Campos.NanoCampo
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValTrib As Campos.NanoCampo
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMIPI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtEXTIPI As Campos.NanoCampo
    Friend WithEvents txtGenero As Campos.NanoCampo
    Friend WithEvents tabICMS As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCalcCred As Campos.NanoCampo
    Friend WithEvents btnAddNfe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAltNfe As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colRegime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculoCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIcms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVaST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIcmsST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExcluirNfe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRegime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboOrigem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtICMSST As Campos.NanoCampo
    Friend WithEvents cboModBCST As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRedBCST As Campos.NanoCampo
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMVAST As Campos.NanoCampo
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCST As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboModBC As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNfeICMS As Campos.NanoCampo
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRedBC As Campos.NanoCampo
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNfeCST As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dsNfe As System.Data.DataSet
    Friend WithEvents tbNfe As System.Data.DataTable
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents CFOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOPTableAdapter As Nano.dsNanoCommerceTableAdapters.CFOPTableAdapter
    Friend WithEvents tabIPI As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCSTIPI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents tabPIS As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabCofins As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaIPI As Campos.NanoCampo
    Friend WithEvents txtAliquotaPIS As Campos.NanoCampo
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCSTPIS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtAliquotaCOFINS As Campos.NanoCampo
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCSTCOFINS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtCodEnq As Campos.NanoCampo
    Friend WithEvents btnConPed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents colQtdSemAlterar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboOrigECF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnPesquisa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkInativar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNCMImpProd As Campos.NanoCampo
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents colCodProdFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCodigoANP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblObs As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTribPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtValidade As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colValidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtComissao As Campos.NanoCampo
    Friend WithEvents lblComissao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofdImagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents nbcImagem As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nbgImagem As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents picImagem4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnOcultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bsiImposto As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnImpCupom As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tbFor As System.Data.DataTable
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents txtLoc2 As Campos.NanoCampo
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents colLocacao2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCest As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTirarImagem2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTirarImagem1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCarregarImage2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCarregarImagem1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picCod As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnCadTabVal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPerICMSUF As Campos.NanoCampo
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPerFCPUF As Campos.NanoCampo
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCadFamilia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboFamilia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCampanha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents colValPromocao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodProdFor As Campos.NanoCampo
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents colDataUltVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdComprada As Campos.NanoCampo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQtdDescarte As Campos.NanoCampo
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalGasto As System.Windows.Forms.Label
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdDevolvida As Campos.NanoCampo
    Friend WithEvents lblCred As System.Windows.Forms.Label
    Friend WithEvents txtAlteracao As Campos.NanoCampo
    Friend WithEvents txtQtdVendida As Campos.NanoCampo
    Friend WithEvents txtQtdEstoque As Campos.NanoCampo
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsAjuste As System.Data.DataSet
    Friend WithEvents tbAjuste As System.Data.DataTable
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents nbcVenda As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents colTabela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCadCodBarra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodBarra As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCodBarras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboModBcTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtIcmsStTN As Campos.NanoCampo
    Friend WithEvents cboModBcStTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtCalcCredTN As Campos.NanoCampo
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIcmsTN As Campos.NanoCampo
    Friend WithEvents txtRedBcStTN As Campos.NanoCampo
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMvaStTN As Campos.NanoCampo
    Friend WithEvents txtRedBcTN As Campos.NanoCampo
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboOrigemTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCstTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCodEnqTN As Campos.NanoCampo
    Friend WithEvents txtAliquotaIpiTN As Campos.NanoCampo
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCstIpiTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaPisTN As Campos.NanoCampo
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCstPisTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaCofinsTN As Campos.NanoCampo
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl88 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCstCofinsTN As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPercIcmsTN As Campos.NanoCampo
    Friend WithEvents LabelControl89 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPercFcpTN As Campos.NanoCampo
    Friend WithEvents LabelControl90 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadraoQtd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManterQtd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents colVU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnBalanca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colTributacaoPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkTribPadrao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents chkDuplicar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colAlterarPreco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents btnCadUni As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPeso As Campos.NanoCampo
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nbgQuantidade As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents PanelControl14 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGarantia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl91 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRevKM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodFab As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodFab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarantia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtQtdeEstoque As Campos.NanoCampo
    Friend WithEvents LabelControl94 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdeMinima As Campos.NanoCampo
    Friend WithEvents LabelControl93 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPesoBruto As Campos.NanoCampo
    Friend WithEvents LabelControl95 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colPesoBruto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTipoFiscal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl96 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalvarTributacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NanoCampo1 As Campos.NanoCampo
    Friend WithEvents LabelControl97 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colQtdEmb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabOpc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsOpcao As System.Data.DataSet
    Friend WithEvents tbTipoOpc As System.Data.DataTable
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents tbOpc As System.Data.DataTable
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents grd5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipoOpc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoOpc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddOpc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl15 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTipoOpc As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkAddOpc As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnInserirTodosOpc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCadOpc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPainelPrecos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImportProd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtQtdMaxima As Campos.NanoCampo
    Friend WithEvents LabelControl98 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl99 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdeMax As Campos.NanoCampo
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents colQtdMaxima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents colQtdMaxima1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl100 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValDesconto As Campos.NanoCampo
End Class
