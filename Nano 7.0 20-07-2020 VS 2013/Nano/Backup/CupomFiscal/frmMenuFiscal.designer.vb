<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuFiscal))
        Me.nbcMenu = New DevExpress.XtraNavBar.NavBarControl
        Me.nbgCaixa = New DevExpress.XtraNavBar.NavBarGroup
        Me.nbiEntradaOperador = New DevExpress.XtraNavBar.NavBarItem
        Me.nbiSuprimento = New DevExpress.XtraNavBar.NavBarItem
        Me.nbiSangria = New DevExpress.XtraNavBar.NavBarItem
        Me.nbiSaidaOperador = New DevExpress.XtraNavBar.NavBarItem
        Me.nbiCancelaCupom = New DevExpress.XtraNavBar.NavBarItem
        Me.nbiFechamento = New DevExpress.XtraNavBar.NavBarItem
        Me.nbgECF = New DevExpress.XtraNavBar.NavBarGroup
        Me.nbiECF = New DevExpress.XtraNavBar.NavBarItem
        Me.nbgMenuFiscal = New DevExpress.XtraNavBar.NavBarGroup
        Me.nbiMenuFiscal = New DevExpress.XtraNavBar.NavBarItem
        Me.nbgConfig = New DevExpress.XtraNavBar.NavBarGroup
        Me.nbiConfig = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup
        Me.nbi1 = New DevExpress.XtraNavBar.NavBarItem
        Me.nbi2 = New DevExpress.XtraNavBar.NavBarItem
        Me.nbi3 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem8 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem9 = New DevExpress.XtraNavBar.NavBarItem
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.pnlConfig = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton
        Me.btnGerar = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.txtChavePublica = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.txtChavePrivada = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.btnSalvarEcf = New DevExpress.XtraEditors.SimpleButton
        Me.btnConsultarDadosECF = New DevExpress.XtraEditors.SimpleButton
        Me.btnGerarDadosECF = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.txtMFAdicional = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoEquipamento = New DevExpress.XtraEditors.TextEdit
        Me.txtEcfVersaoSB = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfNumSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfMarca = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfModelo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfDataSB = New DevExpress.XtraEditors.TextEdit
        Me.txtEcfNumECF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfTipo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.txtEcfCliche = New System.Windows.Forms.RichTextBox
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfIE = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfCNPJ = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.txtCadAliquota = New Campos.NanoCampo
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.dsEcf = New System.Data.DataSet
        Me.tbAliquota = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.tbFormaPag = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.tbAliquotaBD = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.tbFormaPagBD = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquota2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndica = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnCarregarAliquota = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalvarAliquota = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btnCarregarFormaPag = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.grd4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPag2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlMenuFiscal = New DevExpress.XtraEditors.PanelControl
        Me.btnNFP = New DevExpress.XtraEditors.SimpleButton
        Me.btnIndPAF = New DevExpress.XtraEditors.SimpleButton
        Me.btnMeioPag = New DevExpress.XtraEditors.SimpleButton
        Me.btnLMFS = New DevExpress.XtraEditors.SimpleButton
        Me.btnDavEmitido = New DevExpress.XtraEditors.SimpleButton
        Me.btnMovPorECF = New DevExpress.XtraEditors.SimpleButton
        Me.btnEstoque = New DevExpress.XtraEditors.SimpleButton
        Me.btnTabProd = New DevExpress.XtraEditors.SimpleButton
        Me.btnArqMDF = New DevExpress.XtraEditors.SimpleButton
        Me.btnEspelho = New DevExpress.XtraEditors.SimpleButton
        Me.btnLMFC = New DevExpress.XtraEditors.SimpleButton
        Me.btnLX = New DevExpress.XtraEditors.SimpleButton
        Me.pnlInf = New DevExpress.XtraEditors.PanelControl
        Me.btnAtualizarECF = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtDataUltimoMov = New DevExpress.XtraEditors.TextEdit
        Me.txtDataUltimaRZ = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtVerao = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.txtAliquotasCad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.txtDataHoraECF = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtCC = New DevExpress.XtraEditors.TextEdit
        Me.txtGT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtCDC = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtGNF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtGRG = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtCRO = New DevExpress.XtraEditors.TextEdit
        Me.txtCRZ = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtCOO = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtCRZ_R = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtCCF = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtVersaoSB = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtMarca = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtModelo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtDataSB = New DevExpress.XtraEditors.TextEdit
        Me.txtNumECF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtTipo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.memCliche = New System.Windows.Forms.RichTextBox
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtIE = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCnpj = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.pnlCaixa = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.txtSangriaDia = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalCaixaDia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtEntradaDia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.txtVendaDia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtSuprimentoDia = New DevExpress.XtraEditors.TextEdit
        Me.btnAtualizaCaixa = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalCaixaOp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.txtVendaOp = New DevExpress.XtraEditors.TextEdit
        Me.txtDataHoraOp = New DevExpress.XtraEditors.TextEdit
        Me.txtSuprimentoOp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.txtOperador = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.txtSangriaOp = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.txtEntradaOp = New DevExpress.XtraEditors.TextEdit
        Me.Bar4 = New DevExpress.XtraBars.Bar
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnFecha = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar
        Me.lblData = New DevExpress.XtraBars.BarStaticItem
        Me.lblOperador = New DevExpress.XtraBars.BarStaticItem
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.nbcMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.pnlConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfig.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.txtChavePublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChavePrivada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.txtMFAdicional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoEquipamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfVersaoSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfNumSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfDataSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfNumECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.txtEcfIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.txtCadAliquota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsEcf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAliquota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFormaPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAliquotaBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFormaPagBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMenuFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuFiscal.SuspendLayout()
        CType(Me.pnlInf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInf.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtDataUltimoMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataUltimaRZ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVerao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotasCad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataHoraECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCDC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGNF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGRG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCRO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCRZ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCOO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCRZ_R.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtVersaoSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCaixa.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.txtSangriaDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCaixaDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntradaDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendaDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuprimentoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtTotalCaixaOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendaOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataHoraOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuprimentoOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSangriaOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntradaOp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nbcMenu
        '
        Me.nbcMenu.ActiveGroup = Me.nbgCaixa
        Me.nbcMenu.Appearance.Background.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nbcMenu.Appearance.Background.BackColor2 = System.Drawing.Color.White
        Me.nbcMenu.Appearance.Background.Options.UseBackColor = True
        Me.nbcMenu.Appearance.GroupBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nbcMenu.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.White
        Me.nbcMenu.Appearance.GroupBackground.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.nbcMenu.Appearance.GroupBackground.Options.UseBackColor = True
        Me.nbcMenu.ContentButtonHint = Nothing
        Me.nbcMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nbcMenu.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nbgCaixa, Me.nbgECF, Me.nbgMenuFiscal, Me.nbgConfig, Me.NavBarGroup1})
        Me.nbcMenu.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbi1, Me.nbi2, Me.nbi3, Me.nbiEntradaOperador, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7, Me.NavBarItem8, Me.NavBarItem9, Me.nbiECF, Me.nbiMenuFiscal, Me.nbiSuprimento, Me.nbiSangria, Me.nbiSaidaOperador, Me.nbiCancelaCupom, Me.nbiFechamento, Me.nbiConfig})
        Me.nbcMenu.Location = New System.Drawing.Point(0, 0)
        Me.nbcMenu.Name = "nbcMenu"
        Me.nbcMenu.OptionsNavPane.ExpandedWidth = 251
        Me.nbcMenu.Size = New System.Drawing.Size(253, 571)
        Me.nbcMenu.TabIndex = 8
        Me.nbcMenu.Text = "NavBarControl1"
        Me.nbcMenu.View = New DevExpress.XtraNavBar.ViewInfo.XPExplorerBarViewInfoRegistrator
        '
        'nbgCaixa
        '
        Me.nbgCaixa.Caption = "Caixa"
        Me.nbgCaixa.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.nbgCaixa.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEntradaOperador), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSuprimento), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSangria), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSaidaOperador), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCancelaCupom), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFechamento)})
        Me.nbgCaixa.Name = "nbgCaixa"
        '
        'nbiEntradaOperador
        '
        Me.nbiEntradaOperador.Caption = "Entrada de Operador"
        Me.nbiEntradaOperador.LargeImage = CType(resources.GetObject("nbiEntradaOperador.LargeImage"), System.Drawing.Image)
        Me.nbiEntradaOperador.Name = "nbiEntradaOperador"
        '
        'nbiSuprimento
        '
        Me.nbiSuprimento.Caption = "Suprimento"
        Me.nbiSuprimento.LargeImage = Global.Nano.My.Resources.Resources.Suprimento
        Me.nbiSuprimento.Name = "nbiSuprimento"
        '
        'nbiSangria
        '
        Me.nbiSangria.Caption = "Sangria"
        Me.nbiSangria.LargeImage = Global.Nano.My.Resources.Resources.Sangria
        Me.nbiSangria.Name = "nbiSangria"
        '
        'nbiSaidaOperador
        '
        Me.nbiSaidaOperador.Caption = "Saida de Operador"
        Me.nbiSaidaOperador.LargeImage = Global.Nano.My.Resources.Resources.cadeado
        Me.nbiSaidaOperador.Name = "nbiSaidaOperador"
        '
        'nbiCancelaCupom
        '
        Me.nbiCancelaCupom.Caption = "Cancela Cupom"
        Me.nbiCancelaCupom.LargeImage = Global.Nano.My.Resources.Resources.cancel36
        Me.nbiCancelaCupom.Name = "nbiCancelaCupom"
        '
        'nbiFechamento
        '
        Me.nbiFechamento.Caption = "Fechamento do Dia"
        Me.nbiFechamento.LargeImage = Global.Nano.My.Resources.Resources.Log_Off
        Me.nbiFechamento.Name = "nbiFechamento"
        '
        'nbgECF
        '
        Me.nbgECF.Caption = "Dados do ECF"
        Me.nbgECF.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
        Me.nbgECF.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiECF)})
        Me.nbgECF.Name = "nbgECF"
        '
        'nbiECF
        '
        Me.nbiECF.Caption = "ECF"
        Me.nbiECF.LargeImage = Global.Nano.My.Resources.Resources.Isento36x36
        Me.nbiECF.Name = "nbiECF"
        '
        'nbgMenuFiscal
        '
        Me.nbgMenuFiscal.Caption = "Menu Fiscal"
        Me.nbgMenuFiscal.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList
        Me.nbgMenuFiscal.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiMenuFiscal)})
        Me.nbgMenuFiscal.Name = "nbgMenuFiscal"
        '
        'nbiMenuFiscal
        '
        Me.nbiMenuFiscal.Caption = "Menu Fiscal"
        Me.nbiMenuFiscal.LargeImage = Global.Nano.My.Resources.Resources.MenuFiscal
        Me.nbiMenuFiscal.Name = "nbiMenuFiscal"
        '
        'nbgConfig
        '
        Me.nbgConfig.Caption = "Configurações"
        Me.nbgConfig.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiConfig)})
        Me.nbgConfig.Name = "nbgConfig"
        Me.nbgConfig.Visible = False
        '
        'nbiConfig
        '
        Me.nbiConfig.Caption = "Configurações"
        Me.nbiConfig.LargeImage = Global.Nano.My.Resources.Resources.prodto
        Me.nbiConfig.Name = "nbiConfig"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Inicialização"
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbi1), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbi2), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbi3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem8), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem9)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.Visible = False
        '
        'nbi1
        '
        Me.nbi1.Caption = "Altera Símbolo da Moeda"
        Me.nbi1.Name = "nbi1"
        '
        'nbi2
        '
        Me.nbi2.Caption = "Ativa/Desativa Horario de Verão"
        Me.nbi2.Name = "nbi2"
        '
        'nbi3
        '
        Me.nbi3.Caption = "Ativa/Desativa Alinhamento a Esquerda"
        Me.nbi3.Name = "nbi3"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "Programa Aliquota"
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "Programa Forma de Pagamento"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = "Programa Relatório Gerencial"
        Me.NavBarItem7.Name = "NavBarItem7"
        '
        'NavBarItem8
        '
        Me.NavBarItem8.Caption = "Programa Espaço Entre Linhas"
        Me.NavBarItem8.Name = "NavBarItem8"
        '
        'NavBarItem9
        '
        Me.NavBarItem9.Caption = "Programa Linhas Entre Cupons"
        Me.NavBarItem9.Name = "NavBarItem9"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.nbcMenu)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnlConfig)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnlMenuFiscal)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnlInf)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.pnlCaixa)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 575)
        Me.SplitContainerControl1.SplitterPosition = 257
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'pnlConfig
        '
        Me.pnlConfig.Location = New System.Drawing.Point(0, 223)
        Me.pnlConfig.Name = "pnlConfig"
        Me.pnlConfig.SelectedTabPage = Me.XtraTabPage1
        Me.pnlConfig.Size = New System.Drawing.Size(136, 348)
        Me.pnlConfig.TabIndex = 17
        Me.pnlConfig.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnConsultar)
        Me.XtraTabPage1.Controls.Add(Me.btnGerar)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(127, 318)
        Me.XtraTabPage1.Text = "Chave"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(8, 106)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(651, 106)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGerar.TabIndex = 5
        Me.btnGerar.Text = "Gerar"
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.txtChavePublica)
        Me.PanelControl7.Controls.Add(Me.LabelControl35)
        Me.PanelControl7.Controls.Add(Me.LabelControl34)
        Me.PanelControl7.Controls.Add(Me.txtChavePrivada)
        Me.PanelControl7.Location = New System.Drawing.Point(8, 21)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(715, 79)
        Me.PanelControl7.TabIndex = 4
        '
        'txtChavePublica
        '
        Me.txtChavePublica.Location = New System.Drawing.Point(81, 20)
        Me.txtChavePublica.Name = "txtChavePublica"
        Me.txtChavePublica.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtChavePublica.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtChavePublica.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtChavePublica.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtChavePublica.Properties.ReadOnly = True
        Me.txtChavePublica.Size = New System.Drawing.Size(626, 20)
        Me.txtChavePublica.TabIndex = 0
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(8, 49)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl35.TabIndex = 3
        Me.LabelControl35.Text = "Chave Privada"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(8, 23)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl34.TabIndex = 1
        Me.LabelControl34.Text = "Chave Pública"
        '
        'txtChavePrivada
        '
        Me.txtChavePrivada.Location = New System.Drawing.Point(81, 46)
        Me.txtChavePrivada.Name = "txtChavePrivada"
        Me.txtChavePrivada.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtChavePrivada.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtChavePrivada.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtChavePrivada.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtChavePrivada.Properties.ReadOnly = True
        Me.txtChavePrivada.Size = New System.Drawing.Size(626, 20)
        Me.txtChavePrivada.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnSalvarEcf)
        Me.XtraTabPage2.Controls.Add(Me.btnConsultarDadosECF)
        Me.XtraTabPage2.Controls.Add(Me.btnGerarDadosECF)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl42)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl43)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl8)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(127, 318)
        Me.XtraTabPage2.Text = "Dados ECF"
        '
        'btnSalvarEcf
        '
        Me.btnSalvarEcf.Location = New System.Drawing.Point(638, 250)
        Me.btnSalvarEcf.Name = "btnSalvarEcf"
        Me.btnSalvarEcf.Size = New System.Drawing.Size(83, 23)
        Me.btnSalvarEcf.TabIndex = 21
        Me.btnSalvarEcf.Text = "Salvar"
        '
        'btnConsultarDadosECF
        '
        Me.btnConsultarDadosECF.Location = New System.Drawing.Point(11, 250)
        Me.btnConsultarDadosECF.Name = "btnConsultarDadosECF"
        Me.btnConsultarDadosECF.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarDadosECF.TabIndex = 20
        Me.btnConsultarDadosECF.Text = "Consultar BD"
        '
        'btnGerarDadosECF
        '
        Me.btnGerarDadosECF.Location = New System.Drawing.Point(109, 250)
        Me.btnGerarDadosECF.Name = "btnGerarDadosECF"
        Me.btnGerarDadosECF.Size = New System.Drawing.Size(83, 23)
        Me.btnGerarDadosECF.TabIndex = 19
        Me.btnGerarDadosECF.Text = "Consulta ECF"
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl42.Appearance.Options.UseFont = True
        Me.LabelControl42.Location = New System.Drawing.Point(25, 134)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl42.TabIndex = 18
        Me.LabelControl42.Text = "Dados do ECF"
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl43.Appearance.Options.UseFont = True
        Me.LabelControl43.Location = New System.Drawing.Point(25, 14)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl43.TabIndex = 17
        Me.LabelControl43.Text = "Dados do Proprietário"
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.txtMFAdicional)
        Me.PanelControl8.Controls.Add(Me.LabelControl59)
        Me.PanelControl8.Controls.Add(Me.LabelControl58)
        Me.PanelControl8.Controls.Add(Me.txtCodigoEquipamento)
        Me.PanelControl8.Controls.Add(Me.txtEcfVersaoSB)
        Me.PanelControl8.Controls.Add(Me.LabelControl44)
        Me.PanelControl8.Controls.Add(Me.txtEcfNumSerie)
        Me.PanelControl8.Controls.Add(Me.LabelControl45)
        Me.PanelControl8.Controls.Add(Me.txtEcfMarca)
        Me.PanelControl8.Controls.Add(Me.LabelControl46)
        Me.PanelControl8.Controls.Add(Me.LabelControl47)
        Me.PanelControl8.Controls.Add(Me.txtEcfModelo)
        Me.PanelControl8.Controls.Add(Me.LabelControl52)
        Me.PanelControl8.Controls.Add(Me.txtEcfDataSB)
        Me.PanelControl8.Controls.Add(Me.txtEcfNumECF)
        Me.PanelControl8.Controls.Add(Me.LabelControl53)
        Me.PanelControl8.Controls.Add(Me.txtEcfTipo)
        Me.PanelControl8.Controls.Add(Me.LabelControl54)
        Me.PanelControl8.Location = New System.Drawing.Point(11, 141)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(710, 98)
        Me.PanelControl8.TabIndex = 16
        '
        'txtMFAdicional
        '
        Me.txtMFAdicional.Location = New System.Drawing.Point(547, 43)
        Me.txtMFAdicional.Name = "txtMFAdicional"
        Me.txtMFAdicional.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMFAdicional.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMFAdicional.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMFAdicional.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMFAdicional.Properties.ReadOnly = True
        Me.txtMFAdicional.Size = New System.Drawing.Size(150, 20)
        Me.txtMFAdicional.TabIndex = 19
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(482, 46)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl59.TabIndex = 18
        Me.LabelControl59.Text = "MF Adicional"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(485, 73)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl58.TabIndex = 16
        Me.LabelControl58.Text = "Cód. Equip."
        '
        'txtCodigoEquipamento
        '
        Me.txtCodigoEquipamento.Location = New System.Drawing.Point(547, 69)
        Me.txtCodigoEquipamento.Name = "txtCodigoEquipamento"
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigoEquipamento.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoEquipamento.TabIndex = 17
        '
        'txtEcfVersaoSB
        '
        Me.txtEcfVersaoSB.Location = New System.Drawing.Point(98, 69)
        Me.txtEcfVersaoSB.Name = "txtEcfVersaoSB"
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfVersaoSB.Properties.ReadOnly = True
        Me.txtEcfVersaoSB.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfVersaoSB.TabIndex = 11
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(44, 73)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl44.TabIndex = 10
        Me.LabelControl44.Text = "Versão SB"
        '
        'txtEcfNumSerie
        '
        Me.txtEcfNumSerie.Location = New System.Drawing.Point(547, 17)
        Me.txtEcfNumSerie.Name = "txtEcfNumSerie"
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfNumSerie.Properties.ReadOnly = True
        Me.txtEcfNumSerie.Size = New System.Drawing.Size(150, 20)
        Me.txtEcfNumSerie.TabIndex = 9
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(502, 20)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl45.TabIndex = 8
        Me.LabelControl45.Text = "Nº Serie"
        '
        'txtEcfMarca
        '
        Me.txtEcfMarca.Location = New System.Drawing.Point(318, 43)
        Me.txtEcfMarca.Name = "txtEcfMarca"
        Me.txtEcfMarca.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfMarca.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfMarca.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfMarca.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfMarca.Properties.ReadOnly = True
        Me.txtEcfMarca.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfMarca.TabIndex = 7
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(283, 46)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl46.TabIndex = 6
        Me.LabelControl46.Text = "Marca"
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(274, 72)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl47.TabIndex = 14
        Me.LabelControl47.Text = "Data SB"
        '
        'txtEcfModelo
        '
        Me.txtEcfModelo.Location = New System.Drawing.Point(98, 43)
        Me.txtEcfModelo.Name = "txtEcfModelo"
        Me.txtEcfModelo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfModelo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfModelo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfModelo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfModelo.Properties.ReadOnly = True
        Me.txtEcfModelo.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfModelo.TabIndex = 5
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(58, 46)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl52.TabIndex = 4
        Me.LabelControl52.Text = "Modelo"
        '
        'txtEcfDataSB
        '
        Me.txtEcfDataSB.Location = New System.Drawing.Point(318, 69)
        Me.txtEcfDataSB.Name = "txtEcfDataSB"
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfDataSB.Properties.ReadOnly = True
        Me.txtEcfDataSB.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfDataSB.TabIndex = 15
        '
        'txtEcfNumECF
        '
        Me.txtEcfNumECF.Location = New System.Drawing.Point(318, 17)
        Me.txtEcfNumECF.Name = "txtEcfNumECF"
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfNumECF.Properties.ReadOnly = True
        Me.txtEcfNumECF.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfNumECF.TabIndex = 3
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(278, 20)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl53.TabIndex = 2
        Me.LabelControl53.Text = "Nº ECF"
        '
        'txtEcfTipo
        '
        Me.txtEcfTipo.Location = New System.Drawing.Point(98, 17)
        Me.txtEcfTipo.Name = "txtEcfTipo"
        Me.txtEcfTipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfTipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfTipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfTipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfTipo.Properties.ReadOnly = True
        Me.txtEcfTipo.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfTipo.TabIndex = 1
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(72, 20)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl54.TabIndex = 0
        Me.LabelControl54.Text = "Tipo"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.txtEcfCliche)
        Me.PanelControl9.Controls.Add(Me.LabelControl55)
        Me.PanelControl9.Controls.Add(Me.txtEcfIE)
        Me.PanelControl9.Controls.Add(Me.LabelControl56)
        Me.PanelControl9.Controls.Add(Me.txtEcfCNPJ)
        Me.PanelControl9.Controls.Add(Me.LabelControl57)
        Me.PanelControl9.Location = New System.Drawing.Point(11, 21)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(710, 103)
        Me.PanelControl9.TabIndex = 15
        '
        'txtEcfCliche
        '
        Me.txtEcfCliche.BackColor = System.Drawing.Color.White
        Me.txtEcfCliche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEcfCliche.Location = New System.Drawing.Point(98, 44)
        Me.txtEcfCliche.Name = "txtEcfCliche"
        Me.txtEcfCliche.ReadOnly = True
        Me.txtEcfCliche.Size = New System.Drawing.Size(599, 51)
        Me.txtEcfCliche.TabIndex = 6
        Me.txtEcfCliche.Text = ""
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(64, 46)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl55.TabIndex = 1
        Me.LabelControl55.Text = "Clichê"
        '
        'txtEcfIE
        '
        Me.txtEcfIE.Location = New System.Drawing.Point(318, 18)
        Me.txtEcfIE.Name = "txtEcfIE"
        Me.txtEcfIE.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfIE.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfIE.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfIE.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfIE.Properties.ReadOnly = True
        Me.txtEcfIE.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfIE.TabIndex = 3
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(302, 21)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl56.TabIndex = 2
        Me.LabelControl56.Text = "IE"
        '
        'txtEcfCNPJ
        '
        Me.txtEcfCNPJ.Location = New System.Drawing.Point(98, 18)
        Me.txtEcfCNPJ.Name = "txtEcfCNPJ"
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfCNPJ.Properties.ReadOnly = True
        Me.txtEcfCNPJ.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfCNPJ.TabIndex = 1
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(67, 21)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl57.TabIndex = 0
        Me.LabelControl57.Text = "CNPJ"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.SplitContainerControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(127, 318)
        Me.XtraTabPage3.Text = "ECF"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.txtCadAliquota)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.LabelControl60)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(127, 318)
        Me.SplitContainerControl2.SplitterPosition = 385
        Me.SplitContainerControl2.TabIndex = 3
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'txtCadAliquota
        '
        Me.txtCadAliquota.CasasDecimais = 2
        Me.txtCadAliquota.EnterMoveNextControl = True
        Me.txtCadAliquota.Location = New System.Drawing.Point(53, 13)
        Me.txtCadAliquota.Name = "txtCadAliquota"
        Me.txtCadAliquota.Numerico = True
        Me.txtCadAliquota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCadAliquota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCadAliquota.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCadAliquota.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCadAliquota.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCadAliquota.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCadAliquota.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCadAliquota.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCadAliquota.Properties.MaxLength = 15
        Me.txtCadAliquota.Size = New System.Drawing.Size(161, 20)
        Me.txtCadAliquota.TabIndex = 3
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(8, 16)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl60.TabIndex = 2
        Me.LabelControl60.Text = "Alíquota"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.GroupControl5)
        Me.GroupControl3.Controls.Add(Me.GroupControl1)
        Me.GroupControl3.Controls.Add(Me.btnCarregarAliquota)
        Me.GroupControl3.Controls.Add(Me.btnSalvarAliquota)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, -175)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(92, 489)
        Me.GroupControl3.TabIndex = 1
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.GridControl3)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(2, 266)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(88, 184)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Alíquotas cadastradas no BD"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbAliquotaBD"
        Me.GridControl3.DataSource = Me.dsEcf
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 20)
        Me.GridControl3.MainView = Me.grd3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(84, 162)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'dsEcf
        '
        Me.dsEcf.DataSetName = "NewDataSet"
        Me.dsEcf.Tables.AddRange(New System.Data.DataTable() {Me.tbAliquota, Me.tbFormaPag, Me.tbAliquotaBD, Me.tbFormaPagBD})
        '
        'tbAliquota
        '
        Me.tbAliquota.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbAliquota.TableName = "tbAliquota"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Indica"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Aliquota"
        '
        'tbFormaPag
        '
        Me.tbFormaPag.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4})
        Me.tbFormaPag.TableName = "tbFormaPag"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Indice"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FormaPag"
        '
        'tbAliquotaBD
        '
        Me.tbAliquotaBD.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.tbAliquotaBD.TableName = "tbAliquotaBD"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Indica"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Aliquota"
        '
        'tbFormaPagBD
        '
        Me.tbFormaPagBD.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8})
        Me.tbFormaPagBD.TableName = "tbFormaPagBD"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Indice"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "FormaPag"
        '
        'grd3
        '
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice2, Me.colAliquota2})
        Me.grd3.GridControl = Me.GridControl3
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colIndice2
        '
        Me.colIndice2.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice2.Caption = "Índice"
        Me.colIndice2.FieldName = "Indica"
        Me.colIndice2.Name = "colIndice2"
        Me.colIndice2.OptionsColumn.ReadOnly = True
        Me.colIndice2.Visible = True
        Me.colIndice2.VisibleIndex = 0
        Me.colIndice2.Width = 79
        '
        'colAliquota2
        '
        Me.colAliquota2.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquota2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquota2.Caption = "Alíquota"
        Me.colAliquota2.FieldName = "Aliquota"
        Me.colAliquota2.Name = "colAliquota2"
        Me.colAliquota2.OptionsColumn.ReadOnly = True
        Me.colAliquota2.Visible = True
        Me.colAliquota2.VisibleIndex = 1
        Me.colAliquota2.Width = 135
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(88, 264)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Alíquotas cadastradas no ECF"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbAliquota"
        Me.GridControl1.DataSource = Me.dsEcf
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(84, 242)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndica, Me.colAliquota})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colIndica
        '
        Me.colIndica.AppearanceCell.Options.UseTextOptions = True
        Me.colIndica.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndica.Caption = "Índice"
        Me.colIndica.FieldName = "Indica"
        Me.colIndica.Name = "colIndica"
        Me.colIndica.OptionsColumn.ReadOnly = True
        Me.colIndica.Visible = True
        Me.colIndica.VisibleIndex = 0
        Me.colIndica.Width = 79
        '
        'colAliquota
        '
        Me.colAliquota.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquota.Caption = "Alíquota"
        Me.colAliquota.FieldName = "Aliquota"
        Me.colAliquota.Name = "colAliquota"
        Me.colAliquota.OptionsColumn.ReadOnly = True
        Me.colAliquota.Visible = True
        Me.colAliquota.VisibleIndex = 1
        Me.colAliquota.Width = 135
        '
        'btnCarregarAliquota
        '
        Me.btnCarregarAliquota.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarAliquota.Appearance.Options.UseBackColor = True
        Me.btnCarregarAliquota.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCarregarAliquota.Image = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCarregarAliquota.Location = New System.Drawing.Point(8, 454)
        Me.btnCarregarAliquota.Name = "btnCarregarAliquota"
        Me.btnCarregarAliquota.Size = New System.Drawing.Size(84, 31)
        Me.btnCarregarAliquota.TabIndex = 22
        Me.btnCarregarAliquota.Text = "Atualizar"
        '
        'btnSalvarAliquota
        '
        Me.btnSalvarAliquota.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvarAliquota.Appearance.Options.UseBackColor = True
        Me.btnSalvarAliquota.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSalvarAliquota.Image = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvarAliquota.Location = New System.Drawing.Point(289, 454)
        Me.btnSalvarAliquota.Name = "btnSalvarAliquota"
        Me.btnSalvarAliquota.Size = New System.Drawing.Size(83, 31)
        Me.btnSalvarAliquota.TabIndex = 21
        Me.btnSalvarAliquota.Text = "Salvar"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.btnCarregarFormaPag)
        Me.GroupControl4.Controls.Add(Me.GroupControl6)
        Me.GroupControl4.Controls.Add(Me.GroupControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(0, -175)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(21, 489)
        Me.GroupControl4.TabIndex = 3
        '
        'btnCarregarFormaPag
        '
        Me.btnCarregarFormaPag.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarFormaPag.Appearance.Options.UseBackColor = True
        Me.btnCarregarFormaPag.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCarregarFormaPag.Image = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCarregarFormaPag.Location = New System.Drawing.Point(16, 454)
        Me.btnCarregarFormaPag.Name = "btnCarregarFormaPag"
        Me.btnCarregarFormaPag.Size = New System.Drawing.Size(84, 31)
        Me.btnCarregarFormaPag.TabIndex = 23
        Me.btnCarregarFormaPag.Text = "Atualizar"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.Controls.Add(Me.GridControl4)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(2, 266)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(17, 184)
        Me.GroupControl6.TabIndex = 3
        Me.GroupControl6.Text = "Formas de pagamentos cadastradas no DB"
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbFormaPagBD"
        Me.GridControl4.DataSource = Me.dsEcf
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(2, 20)
        Me.GridControl4.MainView = Me.grd4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(13, 162)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd4})
        '
        'grd4
        '
        Me.grd4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice3, Me.colFormaPag2})
        Me.grd4.GridControl = Me.GridControl4
        Me.grd4.Name = "grd4"
        Me.grd4.OptionsView.ShowGroupPanel = False
        '
        'colIndice3
        '
        Me.colIndice3.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice3.Caption = "Índice"
        Me.colIndice3.FieldName = "Indice"
        Me.colIndice3.Name = "colIndice3"
        Me.colIndice3.OptionsColumn.ReadOnly = True
        Me.colIndice3.Visible = True
        Me.colIndice3.VisibleIndex = 0
        Me.colIndice3.Width = 80
        '
        'colFormaPag2
        '
        Me.colFormaPag2.Caption = "Forma Pag."
        Me.colFormaPag2.FieldName = "FormaPag"
        Me.colFormaPag2.Name = "colFormaPag2"
        Me.colFormaPag2.OptionsColumn.ReadOnly = True
        Me.colFormaPag2.Visible = True
        Me.colFormaPag2.VisibleIndex = 1
        Me.colFormaPag2.Width = 134
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(17, 264)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Formas de pagamentos cadastradas no ECF"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbFormaPag"
        Me.GridControl2.DataSource = Me.dsEcf
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.grd2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(13, 242)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice, Me.colFormaPag})
        Me.grd2.GridControl = Me.GridControl2
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colIndice
        '
        Me.colIndice.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice.Caption = "Índice"
        Me.colIndice.FieldName = "Indice"
        Me.colIndice.Name = "colIndice"
        Me.colIndice.OptionsColumn.ReadOnly = True
        Me.colIndice.Visible = True
        Me.colIndice.VisibleIndex = 0
        Me.colIndice.Width = 80
        '
        'colFormaPag
        '
        Me.colFormaPag.Caption = "Forma Pag."
        Me.colFormaPag.FieldName = "FormaPag"
        Me.colFormaPag.Name = "colFormaPag"
        Me.colFormaPag.OptionsColumn.ReadOnly = True
        Me.colFormaPag.Visible = True
        Me.colFormaPag.VisibleIndex = 1
        Me.colFormaPag.Width = 134
        '
        'pnlMenuFiscal
        '
        Me.pnlMenuFiscal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlMenuFiscal.Controls.Add(Me.btnNFP)
        Me.pnlMenuFiscal.Controls.Add(Me.btnIndPAF)
        Me.pnlMenuFiscal.Controls.Add(Me.btnMeioPag)
        Me.pnlMenuFiscal.Controls.Add(Me.btnLMFS)
        Me.pnlMenuFiscal.Controls.Add(Me.btnDavEmitido)
        Me.pnlMenuFiscal.Controls.Add(Me.btnMovPorECF)
        Me.pnlMenuFiscal.Controls.Add(Me.btnEstoque)
        Me.pnlMenuFiscal.Controls.Add(Me.btnTabProd)
        Me.pnlMenuFiscal.Controls.Add(Me.btnArqMDF)
        Me.pnlMenuFiscal.Controls.Add(Me.btnEspelho)
        Me.pnlMenuFiscal.Controls.Add(Me.btnLMFC)
        Me.pnlMenuFiscal.Controls.Add(Me.btnLX)
        Me.pnlMenuFiscal.Location = New System.Drawing.Point(0, 433)
        Me.pnlMenuFiscal.Name = "pnlMenuFiscal"
        Me.pnlMenuFiscal.Size = New System.Drawing.Size(316, 143)
        Me.pnlMenuFiscal.TabIndex = 0
        Me.pnlMenuFiscal.Visible = False
        '
        'btnNFP
        '
        Me.btnNFP.Location = New System.Drawing.Point(72, 454)
        Me.btnNFP.Name = "btnNFP"
        Me.btnNFP.Size = New System.Drawing.Size(262, 59)
        Me.btnNFP.TabIndex = 21
        Me.btnNFP.Text = "Nota Fiscal Paulista"
        '
        'btnIndPAF
        '
        Me.btnIndPAF.Location = New System.Drawing.Point(401, 454)
        Me.btnIndPAF.Name = "btnIndPAF"
        Me.btnIndPAF.Size = New System.Drawing.Size(262, 59)
        Me.btnIndPAF.TabIndex = 17
        Me.btnIndPAF.Text = "Identificação do PAF-ECF"
        '
        'btnMeioPag
        '
        Me.btnMeioPag.Location = New System.Drawing.Point(401, 299)
        Me.btnMeioPag.Name = "btnMeioPag"
        Me.btnMeioPag.Size = New System.Drawing.Size(262, 59)
        Me.btnMeioPag.TabIndex = 16
        Me.btnMeioPag.Text = "Meios de Pagto."
        '
        'btnLMFS
        '
        Me.btnLMFS.Location = New System.Drawing.Point(72, 139)
        Me.btnLMFS.Name = "btnLMFS"
        Me.btnLMFS.Size = New System.Drawing.Size(262, 59)
        Me.btnLMFS.TabIndex = 15
        Me.btnLMFS.Text = "LMFS"
        '
        'btnDavEmitido
        '
        Me.btnDavEmitido.Location = New System.Drawing.Point(72, 376)
        Me.btnDavEmitido.Name = "btnDavEmitido"
        Me.btnDavEmitido.Size = New System.Drawing.Size(262, 59)
        Me.btnDavEmitido.TabIndex = 14
        Me.btnDavEmitido.Text = "DAV Emitidos"
        '
        'btnMovPorECF
        '
        Me.btnMovPorECF.Location = New System.Drawing.Point(401, 219)
        Me.btnMovPorECF.Name = "btnMovPorECF"
        Me.btnMovPorECF.Size = New System.Drawing.Size(262, 59)
        Me.btnMovPorECF.TabIndex = 13
        Me.btnMovPorECF.Text = "Movimento por PAF-ECF"
        '
        'btnEstoque
        '
        Me.btnEstoque.Location = New System.Drawing.Point(72, 299)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(262, 59)
        Me.btnEstoque.TabIndex = 12
        Me.btnEstoque.Text = "Estoque"
        '
        'btnTabProd
        '
        Me.btnTabProd.Location = New System.Drawing.Point(401, 376)
        Me.btnTabProd.Name = "btnTabProd"
        Me.btnTabProd.Size = New System.Drawing.Size(262, 59)
        Me.btnTabProd.TabIndex = 11
        Me.btnTabProd.Text = "Tab. Prod."
        '
        'btnArqMDF
        '
        Me.btnArqMDF.Location = New System.Drawing.Point(72, 219)
        Me.btnArqMDF.Name = "btnArqMDF"
        Me.btnArqMDF.Size = New System.Drawing.Size(262, 59)
        Me.btnArqMDF.TabIndex = 10
        Me.btnArqMDF.Text = "Arq. MDF"
        '
        'btnEspelho
        '
        Me.btnEspelho.Location = New System.Drawing.Point(401, 137)
        Me.btnEspelho.Name = "btnEspelho"
        Me.btnEspelho.Size = New System.Drawing.Size(262, 59)
        Me.btnEspelho.TabIndex = 9
        Me.btnEspelho.Text = "Espelho MDF"
        '
        'btnLMFC
        '
        Me.btnLMFC.Location = New System.Drawing.Point(401, 61)
        Me.btnLMFC.Name = "btnLMFC"
        Me.btnLMFC.Size = New System.Drawing.Size(262, 59)
        Me.btnLMFC.TabIndex = 8
        Me.btnLMFC.Text = "LMFC"
        '
        'btnLX
        '
        Me.btnLX.Location = New System.Drawing.Point(72, 61)
        Me.btnLX.Name = "btnLX"
        Me.btnLX.Size = New System.Drawing.Size(262, 59)
        Me.btnLX.TabIndex = 0
        Me.btnLX.Text = "LX"
        '
        'pnlInf
        '
        Me.pnlInf.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlInf.Controls.Add(Me.btnAtualizarECF)
        Me.pnlInf.Controls.Add(Me.LabelControl24)
        Me.pnlInf.Controls.Add(Me.LabelControl23)
        Me.pnlInf.Controls.Add(Me.LabelControl22)
        Me.pnlInf.Controls.Add(Me.LabelControl21)
        Me.pnlInf.Controls.Add(Me.PanelControl4)
        Me.pnlInf.Controls.Add(Me.PanelControl3)
        Me.pnlInf.Controls.Add(Me.PanelControl2)
        Me.pnlInf.Controls.Add(Me.PanelControl1)
        Me.pnlInf.Location = New System.Drawing.Point(345, 399)
        Me.pnlInf.Name = "pnlInf"
        Me.pnlInf.Size = New System.Drawing.Size(289, 157)
        Me.pnlInf.TabIndex = 1
        '
        'btnAtualizarECF
        '
        Me.btnAtualizarECF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAtualizarECF.Image = Global.Nano.My.Resources.Resources.Giro
        Me.btnAtualizarECF.Location = New System.Drawing.Point(666, 524)
        Me.btnAtualizarECF.Name = "btnAtualizarECF"
        Me.btnAtualizarECF.Size = New System.Drawing.Size(58, 49)
        Me.btnAtualizarECF.TabIndex = 17
        Me.btnAtualizarECF.Text = "SimpleButton2"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Location = New System.Drawing.Point(28, 394)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl24.TabIndex = 16
        Me.LabelControl24.Text = "Dados Cadastrados"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(28, 255)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(155, 13)
        Me.LabelControl23.TabIndex = 15
        Me.LabelControl23.Text = "Contadores e Totalizadores"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(28, 140)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl22.TabIndex = 14
        Me.LabelControl22.Text = "Dados do ECF"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(28, 20)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl21.TabIndex = 13
        Me.LabelControl21.Text = "Dados do Proprietário"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl25)
        Me.PanelControl4.Controls.Add(Me.txtDataUltimoMov)
        Me.PanelControl4.Controls.Add(Me.txtDataUltimaRZ)
        Me.PanelControl4.Controls.Add(Me.LabelControl27)
        Me.PanelControl4.Controls.Add(Me.txtVerao)
        Me.PanelControl4.Controls.Add(Me.LabelControl28)
        Me.PanelControl4.Controls.Add(Me.txtAliquotasCad)
        Me.PanelControl4.Controls.Add(Me.LabelControl29)
        Me.PanelControl4.Controls.Add(Me.LabelControl30)
        Me.PanelControl4.Controls.Add(Me.txtDataHoraECF)
        Me.PanelControl4.Location = New System.Drawing.Point(14, 401)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(710, 122)
        Me.PanelControl4.TabIndex = 6
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(14, 97)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl25.TabIndex = 22
        Me.LabelControl25.Text = "Data Ultimo Mov"
        '
        'txtDataUltimoMov
        '
        Me.txtDataUltimoMov.Location = New System.Drawing.Point(98, 94)
        Me.txtDataUltimoMov.Name = "txtDataUltimoMov"
        Me.txtDataUltimoMov.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDataUltimoMov.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDataUltimoMov.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDataUltimoMov.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDataUltimoMov.Properties.ReadOnly = True
        Me.txtDataUltimoMov.Size = New System.Drawing.Size(160, 20)
        Me.txtDataUltimoMov.TabIndex = 23
        '
        'txtDataUltimaRZ
        '
        Me.txtDataUltimaRZ.Location = New System.Drawing.Point(98, 68)
        Me.txtDataUltimaRZ.Name = "txtDataUltimaRZ"
        Me.txtDataUltimaRZ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDataUltimaRZ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDataUltimaRZ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDataUltimaRZ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDataUltimaRZ.Properties.ReadOnly = True
        Me.txtDataUltimaRZ.Size = New System.Drawing.Size(160, 20)
        Me.txtDataUltimaRZ.TabIndex = 21
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(11, 19)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl27.TabIndex = 12
        Me.LabelControl27.Text = "Horário de Verão"
        '
        'txtVerao
        '
        Me.txtVerao.Location = New System.Drawing.Point(98, 16)
        Me.txtVerao.Name = "txtVerao"
        Me.txtVerao.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtVerao.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtVerao.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtVerao.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtVerao.Properties.ReadOnly = True
        Me.txtVerao.Size = New System.Drawing.Size(160, 20)
        Me.txtVerao.TabIndex = 13
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(21, 71)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl28.TabIndex = 20
        Me.LabelControl28.Text = "Data Ultima RZ"
        '
        'txtAliquotasCad
        '
        Me.txtAliquotasCad.Location = New System.Drawing.Point(332, 16)
        Me.txtAliquotasCad.Name = "txtAliquotasCad"
        Me.txtAliquotasCad.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtAliquotasCad.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtAliquotasCad.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtAliquotasCad.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtAliquotasCad.Properties.ReadOnly = True
        Me.txtAliquotasCad.Size = New System.Drawing.Size(365, 20)
        Me.txtAliquotasCad.TabIndex = 19
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(282, 19)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl29.TabIndex = 18
        Me.LabelControl29.Text = "Alíquotas"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(6, 45)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl30.TabIndex = 16
        Me.LabelControl30.Text = "Data Hora do ECF"
        '
        'txtDataHoraECF
        '
        Me.txtDataHoraECF.Location = New System.Drawing.Point(98, 42)
        Me.txtDataHoraECF.Name = "txtDataHoraECF"
        Me.txtDataHoraECF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDataHoraECF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDataHoraECF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDataHoraECF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDataHoraECF.Properties.ReadOnly = True
        Me.txtDataHoraECF.Size = New System.Drawing.Size(160, 20)
        Me.txtDataHoraECF.TabIndex = 17
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl19)
        Me.PanelControl3.Controls.Add(Me.txtCC)
        Me.PanelControl3.Controls.Add(Me.txtGT)
        Me.PanelControl3.Controls.Add(Me.LabelControl20)
        Me.PanelControl3.Controls.Add(Me.txtCDC)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.txtGNF)
        Me.PanelControl3.Controls.Add(Me.LabelControl8)
        Me.PanelControl3.Controls.Add(Me.txtGRG)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.txtCRO)
        Me.PanelControl3.Controls.Add(Me.txtCRZ)
        Me.PanelControl3.Controls.Add(Me.LabelControl17)
        Me.PanelControl3.Controls.Add(Me.LabelControl14)
        Me.PanelControl3.Controls.Add(Me.txtCOO)
        Me.PanelControl3.Controls.Add(Me.LabelControl18)
        Me.PanelControl3.Controls.Add(Me.txtCRZ_R)
        Me.PanelControl3.Controls.Add(Me.LabelControl15)
        Me.PanelControl3.Controls.Add(Me.LabelControl16)
        Me.PanelControl3.Controls.Add(Me.txtCCF)
        Me.PanelControl3.Location = New System.Drawing.Point(14, 261)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(710, 120)
        Me.PanelControl3.TabIndex = 5
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(301, 43)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl19.TabIndex = 34
        Me.LabelControl19.Text = "CC"
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(332, 40)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCC.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCC.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCC.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCC.Properties.ReadOnly = True
        Me.txtCC.Size = New System.Drawing.Size(160, 20)
        Me.txtCC.TabIndex = 35
        '
        'txtGT
        '
        Me.txtGT.Location = New System.Drawing.Point(547, 40)
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtGT.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtGT.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtGT.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtGT.Properties.ReadOnly = True
        Me.txtGT.Size = New System.Drawing.Size(150, 20)
        Me.txtGT.TabIndex = 33
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(520, 43)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl20.TabIndex = 32
        Me.LabelControl20.Text = "GT"
        '
        'txtCDC
        '
        Me.txtCDC.Location = New System.Drawing.Point(547, 14)
        Me.txtCDC.Name = "txtCDC"
        Me.txtCDC.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCDC.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCDC.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCDC.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCDC.Properties.ReadOnly = True
        Me.txtCDC.Size = New System.Drawing.Size(150, 20)
        Me.txtCDC.TabIndex = 29
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(520, 17)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl9.TabIndex = 28
        Me.LabelControl9.Text = "CDC"
        '
        'txtGNF
        '
        Me.txtGNF.Location = New System.Drawing.Point(332, 92)
        Me.txtGNF.Name = "txtGNF"
        Me.txtGNF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtGNF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtGNF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtGNF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtGNF.Properties.ReadOnly = True
        Me.txtGNF.Size = New System.Drawing.Size(160, 20)
        Me.txtGNF.TabIndex = 27
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(306, 95)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl8.TabIndex = 26
        Me.LabelControl8.Text = "GNF"
        '
        'txtGRG
        '
        Me.txtGRG.Location = New System.Drawing.Point(332, 66)
        Me.txtGRG.Name = "txtGRG"
        Me.txtGRG.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtGRG.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtGRG.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtGRG.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtGRG.Properties.ReadOnly = True
        Me.txtGRG.Size = New System.Drawing.Size(160, 20)
        Me.txtGRG.TabIndex = 25
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(305, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl7.TabIndex = 24
        Me.LabelControl7.Text = "GRG"
        '
        'txtCRO
        '
        Me.txtCRO.Location = New System.Drawing.Point(332, 14)
        Me.txtCRO.Name = "txtCRO"
        Me.txtCRO.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCRO.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCRO.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCRO.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCRO.Properties.ReadOnly = True
        Me.txtCRO.Size = New System.Drawing.Size(160, 20)
        Me.txtCRO.TabIndex = 23
        '
        'txtCRZ
        '
        Me.txtCRZ.Location = New System.Drawing.Point(98, 66)
        Me.txtCRZ.Name = "txtCRZ"
        Me.txtCRZ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCRZ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCRZ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCRZ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCRZ.Properties.ReadOnly = True
        Me.txtCRZ.Size = New System.Drawing.Size(160, 20)
        Me.txtCRZ.TabIndex = 21
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(295, 17)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl17.TabIndex = 22
        Me.LabelControl17.Text = "CRO"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(67, 17)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl14.TabIndex = 12
        Me.LabelControl14.Text = "COO"
        '
        'txtCOO
        '
        Me.txtCOO.Location = New System.Drawing.Point(98, 14)
        Me.txtCOO.Name = "txtCOO"
        Me.txtCOO.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCOO.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCOO.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCOO.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCOO.Properties.ReadOnly = True
        Me.txtCOO.Size = New System.Drawing.Size(160, 20)
        Me.txtCOO.TabIndex = 13
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(67, 69)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl18.TabIndex = 20
        Me.LabelControl18.Text = "CRZ"
        '
        'txtCRZ_R
        '
        Me.txtCRZ_R.Location = New System.Drawing.Point(98, 92)
        Me.txtCRZ_R.Name = "txtCRZ_R"
        Me.txtCRZ_R.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCRZ_R.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCRZ_R.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCRZ_R.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCRZ_R.Properties.ReadOnly = True
        Me.txtCRZ_R.Size = New System.Drawing.Size(160, 20)
        Me.txtCRZ_R.TabIndex = 19
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(59, 95)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl15.TabIndex = 18
        Me.LabelControl15.Text = "CRZ_R"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(67, 43)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl16.TabIndex = 16
        Me.LabelControl16.Text = "CCF"
        '
        'txtCCF
        '
        Me.txtCCF.Location = New System.Drawing.Point(98, 40)
        Me.txtCCF.Name = "txtCCF"
        Me.txtCCF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCCF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCCF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCCF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCCF.Properties.ReadOnly = True
        Me.txtCCF.Size = New System.Drawing.Size(160, 20)
        Me.txtCCF.TabIndex = 17
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtVersaoSB)
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.txtNumSerie)
        Me.PanelControl2.Controls.Add(Me.LabelControl12)
        Me.PanelControl2.Controls.Add(Me.txtMarca)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.LabelControl13)
        Me.PanelControl2.Controls.Add(Me.txtModelo)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.txtDataSB)
        Me.PanelControl2.Controls.Add(Me.txtNumECF)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.txtTipo)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Location = New System.Drawing.Point(14, 147)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(710, 98)
        Me.PanelControl2.TabIndex = 1
        '
        'txtVersaoSB
        '
        Me.txtVersaoSB.Location = New System.Drawing.Point(98, 69)
        Me.txtVersaoSB.Name = "txtVersaoSB"
        Me.txtVersaoSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtVersaoSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtVersaoSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtVersaoSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtVersaoSB.Properties.ReadOnly = True
        Me.txtVersaoSB.Size = New System.Drawing.Size(160, 20)
        Me.txtVersaoSB.TabIndex = 11
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(44, 73)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Versão SB"
        '
        'txtNumSerie
        '
        Me.txtNumSerie.Location = New System.Drawing.Point(547, 17)
        Me.txtNumSerie.Name = "txtNumSerie"
        Me.txtNumSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumSerie.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumSerie.Properties.ReadOnly = True
        Me.txtNumSerie.Size = New System.Drawing.Size(150, 20)
        Me.txtNumSerie.TabIndex = 9
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(502, 20)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl12.TabIndex = 8
        Me.LabelControl12.Text = "Nº Serie"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(332, 43)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMarca.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMarca.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMarca.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMarca.Properties.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(160, 20)
        Me.txtMarca.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(297, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Marca"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(288, 72)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl13.TabIndex = 14
        Me.LabelControl13.Text = "Data SB"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(98, 43)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtModelo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtModelo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtModelo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtModelo.Properties.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(160, 20)
        Me.txtModelo.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(58, 46)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl10.TabIndex = 4
        Me.LabelControl10.Text = "Modelo"
        '
        'txtDataSB
        '
        Me.txtDataSB.Location = New System.Drawing.Point(332, 69)
        Me.txtDataSB.Name = "txtDataSB"
        Me.txtDataSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDataSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDataSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDataSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDataSB.Properties.ReadOnly = True
        Me.txtDataSB.Size = New System.Drawing.Size(160, 20)
        Me.txtDataSB.TabIndex = 15
        '
        'txtNumECF
        '
        Me.txtNumECF.Location = New System.Drawing.Point(332, 17)
        Me.txtNumECF.Name = "txtNumECF"
        Me.txtNumECF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumECF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumECF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumECF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumECF.Properties.ReadOnly = True
        Me.txtNumECF.Size = New System.Drawing.Size(160, 20)
        Me.txtNumECF.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(292, 20)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 2
        Me.LabelControl5.Text = "Nº ECF"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(98, 17)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTipo.Properties.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(160, 20)
        Me.txtTipo.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(72, 20)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Tipo"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.memCliche)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtIE)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtCnpj)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(14, 27)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(710, 103)
        Me.PanelControl1.TabIndex = 0
        '
        'memCliche
        '
        Me.memCliche.BackColor = System.Drawing.Color.White
        Me.memCliche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.memCliche.Location = New System.Drawing.Point(98, 44)
        Me.memCliche.Name = "memCliche"
        Me.memCliche.ReadOnly = True
        Me.memCliche.Size = New System.Drawing.Size(599, 51)
        Me.memCliche.TabIndex = 6
        Me.memCliche.Text = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(64, 46)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Clichê"
        '
        'txtIE
        '
        Me.txtIE.Location = New System.Drawing.Point(332, 18)
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtIE.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtIE.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIE.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIE.Properties.ReadOnly = True
        Me.txtIE.Size = New System.Drawing.Size(160, 20)
        Me.txtIE.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(316, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "IE"
        '
        'txtCnpj
        '
        Me.txtCnpj.Location = New System.Drawing.Point(98, 18)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCnpj.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCnpj.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCnpj.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCnpj.Properties.ReadOnly = True
        Me.txtCnpj.Size = New System.Drawing.Size(160, 20)
        Me.txtCnpj.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(67, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "CNPJ"
        '
        'pnlCaixa
        '
        Me.pnlCaixa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlCaixa.Controls.Add(Me.LabelControl41)
        Me.pnlCaixa.Controls.Add(Me.PanelControl6)
        Me.pnlCaixa.Controls.Add(Me.btnAtualizaCaixa)
        Me.pnlCaixa.Controls.Add(Me.LabelControl26)
        Me.pnlCaixa.Controls.Add(Me.PanelControl5)
        Me.pnlCaixa.Location = New System.Drawing.Point(168, 180)
        Me.pnlCaixa.Name = "pnlCaixa"
        Me.pnlCaixa.Size = New System.Drawing.Size(398, 213)
        Me.pnlCaixa.TabIndex = 16
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl41.Appearance.Options.UseFont = True
        Me.LabelControl41.Location = New System.Drawing.Point(29, 181)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl41.TabIndex = 22
        Me.LabelControl41.Text = "Resumo do Dia"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.LabelControl33)
        Me.PanelControl6.Controls.Add(Me.txtSangriaDia)
        Me.PanelControl6.Controls.Add(Me.txtTotalCaixaDia)
        Me.PanelControl6.Controls.Add(Me.LabelControl48)
        Me.PanelControl6.Controls.Add(Me.txtEntradaDia)
        Me.PanelControl6.Controls.Add(Me.LabelControl49)
        Me.PanelControl6.Controls.Add(Me.txtVendaDia)
        Me.PanelControl6.Controls.Add(Me.LabelControl50)
        Me.PanelControl6.Controls.Add(Me.LabelControl51)
        Me.PanelControl6.Controls.Add(Me.txtSuprimentoDia)
        Me.PanelControl6.Location = New System.Drawing.Point(15, 187)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(710, 121)
        Me.PanelControl6.TabIndex = 21
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(487, 95)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl33.TabIndex = 38
        Me.LabelControl33.Text = "Total Caixa"
        '
        'txtSangriaDia
        '
        Me.txtSangriaDia.Location = New System.Drawing.Point(98, 66)
        Me.txtSangriaDia.Name = "txtSangriaDia"
        Me.txtSangriaDia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSangriaDia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSangriaDia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSangriaDia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSangriaDia.Properties.ReadOnly = True
        Me.txtSangriaDia.Size = New System.Drawing.Size(160, 20)
        Me.txtSangriaDia.TabIndex = 21
        '
        'txtTotalCaixaDia
        '
        Me.txtTotalCaixaDia.Location = New System.Drawing.Point(547, 92)
        Me.txtTotalCaixaDia.Name = "txtTotalCaixaDia"
        Me.txtTotalCaixaDia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotalCaixaDia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCaixaDia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalCaixaDia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalCaixaDia.Properties.ReadOnly = True
        Me.txtTotalCaixaDia.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalCaixaDia.TabIndex = 39
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(22, 17)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl48.TabIndex = 12
        Me.LabelControl48.Text = "Total Entradas"
        '
        'txtEntradaDia
        '
        Me.txtEntradaDia.Location = New System.Drawing.Point(98, 14)
        Me.txtEntradaDia.Name = "txtEntradaDia"
        Me.txtEntradaDia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEntradaDia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEntradaDia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEntradaDia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEntradaDia.Properties.ReadOnly = True
        Me.txtEntradaDia.Size = New System.Drawing.Size(160, 20)
        Me.txtEntradaDia.TabIndex = 13
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(24, 69)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl49.TabIndex = 20
        Me.LabelControl49.Text = "Total Sangrias"
        '
        'txtVendaDia
        '
        Me.txtVendaDia.Location = New System.Drawing.Point(98, 92)
        Me.txtVendaDia.Name = "txtVendaDia"
        Me.txtVendaDia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtVendaDia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtVendaDia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtVendaDia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtVendaDia.Properties.ReadOnly = True
        Me.txtVendaDia.Size = New System.Drawing.Size(160, 20)
        Me.txtVendaDia.TabIndex = 19
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(30, 95)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl50.TabIndex = 18
        Me.LabelControl50.Text = "Total Vendas"
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(6, 43)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl51.TabIndex = 16
        Me.LabelControl51.Text = "Total Suprimentos"
        '
        'txtSuprimentoDia
        '
        Me.txtSuprimentoDia.Location = New System.Drawing.Point(98, 40)
        Me.txtSuprimentoDia.Name = "txtSuprimentoDia"
        Me.txtSuprimentoDia.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSuprimentoDia.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSuprimentoDia.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSuprimentoDia.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSuprimentoDia.Properties.ReadOnly = True
        Me.txtSuprimentoDia.Size = New System.Drawing.Size(160, 20)
        Me.txtSuprimentoDia.TabIndex = 17
        '
        'btnAtualizaCaixa
        '
        Me.btnAtualizaCaixa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAtualizaCaixa.Image = Global.Nano.My.Resources.Resources.Giro
        Me.btnAtualizaCaixa.Location = New System.Drawing.Point(667, 515)
        Me.btnAtualizaCaixa.Name = "btnAtualizaCaixa"
        Me.btnAtualizaCaixa.Size = New System.Drawing.Size(58, 49)
        Me.btnAtualizaCaixa.TabIndex = 20
        Me.btnAtualizaCaixa.Text = "SimpleButton2"
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Location = New System.Drawing.Point(29, 20)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(119, 13)
        Me.LabelControl26.TabIndex = 19
        Me.LabelControl26.Text = "Resumo do Operador"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.LabelControl32)
        Me.PanelControl5.Controls.Add(Me.txtTotalCaixaOp)
        Me.PanelControl5.Controls.Add(Me.LabelControl31)
        Me.PanelControl5.Controls.Add(Me.txtVendaOp)
        Me.PanelControl5.Controls.Add(Me.txtDataHoraOp)
        Me.PanelControl5.Controls.Add(Me.txtSuprimentoOp)
        Me.PanelControl5.Controls.Add(Me.LabelControl36)
        Me.PanelControl5.Controls.Add(Me.LabelControl37)
        Me.PanelControl5.Controls.Add(Me.txtOperador)
        Me.PanelControl5.Controls.Add(Me.LabelControl38)
        Me.PanelControl5.Controls.Add(Me.txtSangriaOp)
        Me.PanelControl5.Controls.Add(Me.LabelControl39)
        Me.PanelControl5.Controls.Add(Me.LabelControl40)
        Me.PanelControl5.Controls.Add(Me.txtEntradaOp)
        Me.PanelControl5.Location = New System.Drawing.Point(15, 26)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(710, 147)
        Me.PanelControl5.TabIndex = 18
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(487, 121)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl32.TabIndex = 36
        Me.LabelControl32.Text = "Total Caixa"
        '
        'txtTotalCaixaOp
        '
        Me.txtTotalCaixaOp.Location = New System.Drawing.Point(547, 118)
        Me.txtTotalCaixaOp.Name = "txtTotalCaixaOp"
        Me.txtTotalCaixaOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotalCaixaOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCaixaOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalCaixaOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalCaixaOp.Properties.ReadOnly = True
        Me.txtTotalCaixaOp.Size = New System.Drawing.Size(150, 20)
        Me.txtTotalCaixaOp.TabIndex = 37
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(35, 121)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl31.TabIndex = 34
        Me.LabelControl31.Text = "Total Venda"
        '
        'txtVendaOp
        '
        Me.txtVendaOp.Location = New System.Drawing.Point(98, 118)
        Me.txtVendaOp.Name = "txtVendaOp"
        Me.txtVendaOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtVendaOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtVendaOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtVendaOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtVendaOp.Properties.ReadOnly = True
        Me.txtVendaOp.Size = New System.Drawing.Size(160, 20)
        Me.txtVendaOp.TabIndex = 35
        '
        'txtDataHoraOp
        '
        Me.txtDataHoraOp.Location = New System.Drawing.Point(547, 14)
        Me.txtDataHoraOp.Name = "txtDataHoraOp"
        Me.txtDataHoraOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDataHoraOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDataHoraOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDataHoraOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDataHoraOp.Properties.ReadOnly = True
        Me.txtDataHoraOp.Size = New System.Drawing.Size(150, 20)
        Me.txtDataHoraOp.TabIndex = 29
        '
        'txtSuprimentoOp
        '
        Me.txtSuprimentoOp.Location = New System.Drawing.Point(98, 66)
        Me.txtSuprimentoOp.Name = "txtSuprimentoOp"
        Me.txtSuprimentoOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSuprimentoOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSuprimentoOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSuprimentoOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSuprimentoOp.Properties.ReadOnly = True
        Me.txtSuprimentoOp.Size = New System.Drawing.Size(160, 20)
        Me.txtSuprimentoOp.TabIndex = 21
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(436, 17)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl36.TabIndex = 22
        Me.LabelControl36.Text = "Data Hora da Entrada"
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(46, 17)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl37.TabIndex = 12
        Me.LabelControl37.Text = "Operador"
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(98, 14)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtOperador.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtOperador.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtOperador.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtOperador.Properties.ReadOnly = True
        Me.txtOperador.Size = New System.Drawing.Size(160, 20)
        Me.txtOperador.TabIndex = 13
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(11, 69)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl38.TabIndex = 20
        Me.LabelControl38.Text = "Total Suprimento"
        '
        'txtSangriaOp
        '
        Me.txtSangriaOp.Location = New System.Drawing.Point(98, 92)
        Me.txtSangriaOp.Name = "txtSangriaOp"
        Me.txtSangriaOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSangriaOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSangriaOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSangriaOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSangriaOp.Properties.ReadOnly = True
        Me.txtSangriaOp.Size = New System.Drawing.Size(160, 20)
        Me.txtSangriaOp.TabIndex = 19
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(26, 95)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl39.TabIndex = 18
        Me.LabelControl39.Text = "Total Sangria "
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl40.TabIndex = 16
        Me.LabelControl40.Text = "Valor da Entrada"
        '
        'txtEntradaOp
        '
        Me.txtEntradaOp.Location = New System.Drawing.Point(98, 40)
        Me.txtEntradaOp.Name = "txtEntradaOp"
        Me.txtEntradaOp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEntradaOp.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEntradaOp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEntradaOp.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEntradaOp.Properties.ReadOnly = True
        Me.txtEntradaOp.Size = New System.Drawing.Size(160, 20)
        Me.txtEntradaOp.TabIndex = 17
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFecha})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFecha)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnFecha
        '
        Me.btnFecha.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFecha.Caption = "Fechar"
        Me.btnFecha.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar50
        Me.btnFecha.Id = 0
        Me.btnFecha.Name = "btnFecha"
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.lblData, Me.lblOperador})
        Me.BarManager2.MaxItemId = 3
        Me.BarManager2.StatusBar = Me.Bar5
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lblData), New DevExpress.XtraBars.LinkPersistInfo(Me.lblOperador), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarStaticItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'lblData
        '
        Me.lblData.Caption = "Data"
        Me.lblData.Id = 1
        Me.lblData.Name = "lblData"
        Me.lblData.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblOperador
        '
        Me.lblOperador.Caption = "Operador"
        Me.lblOperador.Id = 2
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "Era Systems Soluções em Softwares"
        Me.BarStaticItem1.Glyph = Global.Nano.My.Resources.Resources.LogotipoEra
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'Timer1
        '
        '
        'frmMenuFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Fiscal"
        CType(Me.nbcMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.pnlConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfig.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.txtChavePublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChavePrivada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.txtMFAdicional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoEquipamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfVersaoSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfNumSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfDataSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfNumECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.txtEcfIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.txtCadAliquota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsEcf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAliquota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFormaPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAliquotaBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFormaPagBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMenuFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuFiscal.ResumeLayout(False)
        CType(Me.pnlInf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInf.ResumeLayout(False)
        Me.pnlInf.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txtDataUltimoMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataUltimaRZ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVerao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotasCad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataHoraECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCDC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGNF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGRG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCRO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCRZ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCOO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCRZ_R.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtVersaoSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCaixa.ResumeLayout(False)
        Me.pnlCaixa.PerformLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.txtSangriaDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCaixaDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntradaDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendaDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuprimentoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.txtTotalCaixaOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendaOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataHoraOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuprimentoOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSangriaOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntradaOp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nbcMenu As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbi1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbi2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbi3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbgCaixa As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents nbiEntradaOperador As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbgECF As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbgMenuFiscal As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbgConfig As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem8 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem9 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiECF As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiMenuFiscal As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents pnlMenuFiscal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLX As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIndPAF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMeioPag As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLMFS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDavEmitido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMovPorECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEstoque As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTabProd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnArqMDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEspelho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLMFC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNFP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nbiSuprimento As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiSangria As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiSaidaOperador As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiCancelaCupom As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFechamento As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiConfig As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents pnlInf As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCRO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCRZ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCOO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCRZ_R As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDataSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCCF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtVersaoSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumECF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memCliche As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCDC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGNF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGRG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDataUltimaRZ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVerao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAliquotasCad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDataHoraECF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAtualizarECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDataUltimoMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlCaixa As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSangriaDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEntradaDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVendaDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSuprimentoDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAtualizaCaixa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVendaOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDataHoraOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuprimentoOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOperador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSangriaOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEntradaOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCaixaDia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCaixaOp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlConfig As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtChavePublica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChavePrivada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnConsultarDadosECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGerarDadosECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtEcfVersaoSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfNumSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfDataSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEcfNumECF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtEcfCliche As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfCNPJ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFecha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblData As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblOperador As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSalvarEcf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoEquipamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMFAdicional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dsEcf As System.Data.DataSet
    Friend WithEvents tbAliquota As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents tbFormaPag As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCarregarAliquota As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalvarAliquota As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIndica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquota2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPag2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCarregarFormaPag As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCadAliquota As Campos.NanoCampo
    Friend WithEvents tbAliquotaBD As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents tbFormaPagBD As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
End Class
