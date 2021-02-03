<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelLucro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelLucro))
        Me.sfdSalvar = New System.Windows.Forms.SaveFileDialog
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelLuc = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.chkTroco = New DevExpress.XtraBars.BarEditItem
        Me.chk1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.chkPerDesc = New DevExpress.XtraBars.BarEditItem
        Me.chk2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.chkDesc = New DevExpress.XtraBars.BarEditItem
        Me.chk3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.TotalGridControl = New DevExpress.XtraGrid.GridControl
        Me.TotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTroco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueFunc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPorcentagemDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumPed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colServico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalFrete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtLucroProd = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustoProd = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtServico = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtProduto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.txtPorc = New DevExpress.XtraEditors.TextEdit
        Me.txtTotCusto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtLucro = New DevExpress.XtraEditors.TextEdit
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtTot = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TotalTableAdapter = New Nano.dsNanoCommerceTableAdapters.TotalTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.colOperador = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtLucroProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustoProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLucro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.bsiVisu, Me.btnRelLuc, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 150, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 150, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 3
        Me.dtInicial.Name = "dtInicial"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtFinal
        '
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit2
        Me.dtFinal.Id = 4
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 5
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 7
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelLuc), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelLuc
        '
        Me.btnRelLuc.Caption = "Relatório de Lucro"
        Me.btnRelLuc.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelLuc.Id = 8
        Me.btnRelLuc.Name = "btnRelLuc"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 9
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.chkTroco, Me.chkPerDesc, Me.chkDesc})
        Me.RibbonControl1.Location = New System.Drawing.Point(464, 405)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chk1, Me.chk2, Me.chk3})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 115)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Visible = False
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "Ver Colulnas"
        Me.BarStaticItem1.Id = 7
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'chkTroco
        '
        Me.chkTroco.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkTroco.Caption = "Troco R$"
        Me.chkTroco.Edit = Me.chk1
        Me.chkTroco.EditValue = False
        Me.chkTroco.Id = 8
        Me.chkTroco.Name = "chkTroco"
        '
        'chk1
        '
        Me.chk1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chk1.Appearance.Options.UseBackColor = True
        Me.chk1.AutoHeight = False
        Me.chk1.Name = "chk1"
        '
        'chkPerDesc
        '
        Me.chkPerDesc.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkPerDesc.Caption = "% Desconto"
        Me.chkPerDesc.Edit = Me.chk2
        Me.chkPerDesc.EditValue = False
        Me.chkPerDesc.Id = 9
        Me.chkPerDesc.Name = "chkPerDesc"
        '
        'chk2
        '
        Me.chk2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chk2.Appearance.Options.UseBackColor = True
        Me.chk2.AutoHeight = False
        Me.chk2.Name = "chk2"
        '
        'chkDesc
        '
        Me.chkDesc.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkDesc.Caption = "Val. Desc. R$"
        Me.chkDesc.Edit = Me.chk3
        Me.chkDesc.EditValue = False
        Me.chkDesc.Id = 10
        Me.chkDesc.Name = "chkDesc"
        '
        'chk3
        '
        Me.chk3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chk3.Appearance.Options.UseBackColor = True
        Me.chk3.AutoHeight = False
        Me.chk3.Name = "chk3"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.KeyTip = ""
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkTroco, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkPerDesc, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkDesc, True)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1008, 24)
        '
        'TotalGridControl
        '
        Me.TotalGridControl.DataSource = Me.TotalBindingSource
        Me.TotalGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalGridControl.EmbeddedNavigator.Name = ""
        Me.TotalGridControl.Location = New System.Drawing.Point(2, 2)
        Me.TotalGridControl.MainView = Me.grd1
        Me.TotalGridControl.Name = "TotalGridControl"
        Me.TotalGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.lueLoja, Me.lueFunc})
        Me.TotalGridControl.Size = New System.Drawing.Size(1004, 508)
        Me.TotalGridControl.TabIndex = 7
        Me.TotalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'TotalBindingSource
        '
        Me.TotalBindingSource.DataMember = "Total"
        Me.TotalBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grd1.Appearance.FooterPanel.Options.UseFont = True
        Me.grd1.Appearance.FooterPanel.Options.UseForeColor = True
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCod, Me.colData, Me.colCliente, Me.colCPF, Me.colTotal, Me.colRealizado, Me.colCusto, Me.colLucro, Me.colCodConfig, Me.colTroco, Me.colPorDesc, Me.colValDesc, Me.colCodFunc, Me.colPorcentagemDesconto, Me.colFantasia, Me.colNumPed, Me.colNumNF, Me.colProduto, Me.colServico, Me.colPlaca, Me.colModelo, Me.colCustoProduto, Me.colTotalSemDesc, Me.colTotalFrete, Me.colOperador})
        Me.grd1.GridControl = Me.TotalGridControl
        Me.grd1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.colTotal, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Custo", Me.colCusto, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Lucro", Me.colLucro, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Troco", Me.colTroco, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValDesc", Me.colValDesc, "{0:c}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCod
        '
        Me.colCod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCod.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCod.AppearanceCell.Options.UseBackColor = True
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCod.Caption = "Nº Venda"
        Me.colCod.ColumnEdit = Me.txtAlterar
        Me.colCod.FieldName = "CodOrdem"
        Me.colCod.Name = "colCod"
        Me.colCod.OptionsColumn.ReadOnly = True
        Me.colCod.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colCod.ToolTip = "Nº de Vendas"
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 0
        Me.colCod.Width = 56
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colData
        '
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colData.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceCell.Options.UseBackColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.ColumnEdit = Me.txtAlterar
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 80
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCliente.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCliente.AppearanceCell.Options.UseBackColor = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtAlterar
        Me.colCliente.FieldName = "Nome"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 210
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTotal.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotal.AppearanceCell.Options.UseBackColor = True
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.Caption = "Total R$"
        Me.colTotal.ColumnEdit = Me.txtAlterar
        Me.colTotal.DisplayFormat.FormatString = "c"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 7
        '
        'colRealizado
        '
        Me.colRealizado.Caption = "Faturado?"
        Me.colRealizado.FieldName = "Realizado"
        Me.colRealizado.Name = "colRealizado"
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCusto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCusto.AppearanceCell.Options.UseBackColor = True
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.Caption = "Custo R$"
        Me.colCusto.DisplayFormat.FormatString = "c"
        Me.colCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        Me.colCusto.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCusto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 8
        Me.colCusto.Width = 76
        '
        'colLucro
        '
        Me.colLucro.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLucro.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colLucro.AppearanceCell.Options.UseBackColor = True
        Me.colLucro.AppearanceCell.Options.UseTextOptions = True
        Me.colLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLucro.Caption = "Lucro R$"
        Me.colLucro.DisplayFormat.FormatString = "c"
        Me.colLucro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLucro.FieldName = "Lucro"
        Me.colLucro.Name = "colLucro"
        Me.colLucro.OptionsColumn.ReadOnly = True
        Me.colLucro.SummaryItem.DisplayFormat = "{0:c}"
        Me.colLucro.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colLucro.Visible = True
        Me.colLucro.VisibleIndex = 9
        Me.colLucro.Width = 72
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCodConfig.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodConfig.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.colCodConfig.AppearanceCell.Options.UseBackColor = True
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 10
        Me.colCodConfig.Width = 72
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DataSource = Me.ConfigBindingSource
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'colTroco
        '
        Me.colTroco.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colTroco.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTroco.AppearanceCell.Options.UseBackColor = True
        Me.colTroco.Caption = "Troco R$"
        Me.colTroco.DisplayFormat.FormatString = "c"
        Me.colTroco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTroco.FieldName = "Troco"
        Me.colTroco.Name = "colTroco"
        Me.colTroco.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTroco.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTroco.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'colPorDesc
        '
        Me.colPorDesc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPorDesc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPorDesc.AppearanceCell.Options.UseBackColor = True
        Me.colPorDesc.Caption = "% Desconto"
        Me.colPorDesc.FieldName = "PorDesc"
        Me.colPorDesc.Name = "colPorDesc"
        '
        'colValDesc
        '
        Me.colValDesc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValDesc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValDesc.AppearanceCell.Options.UseBackColor = True
        Me.colValDesc.Caption = "Val. Desc. R$"
        Me.colValDesc.FieldName = "ValDesc"
        Me.colValDesc.Name = "colValDesc"
        Me.colValDesc.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValDesc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colCodFunc
        '
        Me.colCodFunc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodFunc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodFunc.AppearanceCell.Options.UseBackColor = True
        Me.colCodFunc.Caption = "Vend."
        Me.colCodFunc.ColumnEdit = Me.lueFunc
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
        Me.colCodFunc.OptionsColumn.ReadOnly = True
        '
        'lueFunc
        '
        Me.lueFunc.AutoHeight = False
        Me.lueFunc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc.DisplayMember = "Codigo"
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.NullText = ""
        Me.lueFunc.ValueMember = "Codigo"
        '
        'FuncionarioBindingSource
        '
        Me.FuncionarioBindingSource.DataMember = "Funcionario"
        Me.FuncionarioBindingSource.DataSource = Me.DsNanoCommerce
        '
        'colPorcentagemDesconto
        '
        Me.colPorcentagemDesconto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPorcentagemDesconto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPorcentagemDesconto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colPorcentagemDesconto.AppearanceCell.Options.UseBackColor = True
        Me.colPorcentagemDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagemDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagemDesconto.Caption = "% Markup"
        Me.colPorcentagemDesconto.FieldName = "PorcentagemDesconto"
        Me.colPorcentagemDesconto.Name = "colPorcentagemDesconto"
        Me.colPorcentagemDesconto.OptionsColumn.ReadOnly = True
        '
        'colFantasia
        '
        Me.colFantasia.Caption = "Fantasia"
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.OptionsColumn.ReadOnly = True
        '
        'colNumPed
        '
        Me.colNumPed.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNumPed.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colNumPed.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colNumPed.AppearanceCell.Options.UseBackColor = True
        Me.colNumPed.AppearanceCell.Options.UseTextOptions = True
        Me.colNumPed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumPed.Caption = "Nº Pedido"
        Me.colNumPed.FieldName = "NumPed"
        Me.colNumPed.Name = "colNumPed"
        Me.colNumPed.OptionsColumn.ReadOnly = True
        '
        'colNumNF
        '
        Me.colNumNF.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colNumNF.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colNumNF.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colNumNF.AppearanceCell.Options.UseBackColor = True
        Me.colNumNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumNF.Caption = "Nº NFe"
        Me.colNumNF.FieldName = "NumNF"
        Me.colNumNF.Name = "colNumNF"
        Me.colNumNF.OptionsColumn.ReadOnly = True
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colProduto.Caption = "Produtos R$"
        Me.colProduto.DisplayFormat.FormatString = "c"
        Me.colProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.SummaryItem.DisplayFormat = "{0:c}"
        Me.colProduto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 5
        Me.colProduto.Width = 84
        '
        'colServico
        '
        Me.colServico.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colServico.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colServico.AppearanceCell.Options.UseBackColor = True
        Me.colServico.AppearanceCell.Options.UseTextOptions = True
        Me.colServico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colServico.Caption = "Serviços R$"
        Me.colServico.DisplayFormat.FormatString = "c"
        Me.colServico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colServico.FieldName = "Servico"
        Me.colServico.Name = "colServico"
        Me.colServico.OptionsColumn.ReadOnly = True
        Me.colServico.SummaryItem.DisplayFormat = "{0:c}"
        Me.colServico.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colServico.Visible = True
        Me.colServico.VisibleIndex = 6
        Me.colServico.Width = 78
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPlaca.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPlaca.AppearanceCell.Options.UseBackColor = True
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.OptionsColumn.ReadOnly = True
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 2
        Me.colPlaca.Width = 63
        '
        'colModelo
        '
        Me.colModelo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colModelo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colModelo.AppearanceCell.Options.UseBackColor = True
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.OptionsColumn.ReadOnly = True
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 3
        Me.colModelo.Width = 117
        '
        'colCustoProduto
        '
        Me.colCustoProduto.Caption = "Custo Produto R$"
        Me.colCustoProduto.FieldName = "CustoProduto"
        Me.colCustoProduto.Name = "colCustoProduto"
        Me.colCustoProduto.OptionsColumn.ReadOnly = True
        '
        'colTotalSemDesc
        '
        Me.colTotalSemDesc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colTotalSemDesc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotalSemDesc.AppearanceCell.Options.UseBackColor = True
        Me.colTotalSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colTotalSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalSemDesc.Caption = "Total S. Desc. R$"
        Me.colTotalSemDesc.DisplayFormat.FormatString = "c"
        Me.colTotalSemDesc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalSemDesc.FieldName = "TotalSemDesc"
        Me.colTotalSemDesc.Name = "colTotalSemDesc"
        Me.colTotalSemDesc.OptionsColumn.ReadOnly = True
        Me.colTotalSemDesc.SummaryItem.DisplayFormat = "{0:c}"
        Me.colTotalSemDesc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colTotalFrete
        '
        Me.colTotalFrete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTotalFrete.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTotalFrete.AppearanceCell.Options.UseBackColor = True
        Me.colTotalFrete.Caption = "Val. Frete R$"
        Me.colTotalFrete.DisplayFormat.FormatString = "c"
        Me.colTotalFrete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalFrete.FieldName = "TotalFrete"
        Me.colTotalFrete.Name = "colTotalFrete"
        Me.colTotalFrete.OptionsColumn.ReadOnly = True
        Me.colTotalFrete.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtLucroProd)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtCustoProd)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtServico)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtProduto)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.txtPorc)
        Me.GroupControl1.Controls.Add(Me.txtTotCusto)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtLucro)
        Me.GroupControl1.Controls.Add(Me.TotalGridControl)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.txtTot)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 24)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 574)
        Me.GroupControl1.TabIndex = 10
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(308, 521)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(5, 14)
        Me.LabelControl14.TabIndex = 121
        Me.LabelControl14.Text = "-"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(542, 550)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(5, 14)
        Me.LabelControl13.TabIndex = 120
        Me.LabelControl13.Text = "-"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(540, 520)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl12.TabIndex = 119
        Me.LabelControl12.Text = "="
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(308, 549)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl11.TabIndex = 118
        Me.LabelControl11.Text = "="
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(146, 536)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl10.TabIndex = 117
        Me.LabelControl10.Text = "+"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(751, 547)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl9.TabIndex = 116
        Me.LabelControl9.Text = "="
        '
        'txtLucroProd
        '
        Me.txtLucroProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLucroProd.EditValue = ""
        Me.txtLucroProd.Location = New System.Drawing.Point(639, 518)
        Me.txtLucroProd.Name = "txtLucroProd"
        Me.txtLucroProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLucroProd.Properties.Appearance.Options.UseFont = True
        Me.txtLucroProd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLucroProd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLucroProd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtLucroProd.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txtLucroProd.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtLucroProd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtLucroProd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLucroProd.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtLucroProd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtLucroProd.Properties.ReadOnly = True
        Me.txtLucroProd.Size = New System.Drawing.Size(110, 21)
        Me.txtLucroProd.TabIndex = 115
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(558, 514)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 12)
        Me.LabelControl8.TabIndex = 114
        Me.LabelControl8.Text = "Lucro Prod. R$"
        '
        'txtCustoProd
        '
        Me.txtCustoProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCustoProd.EditValue = ""
        Me.txtCustoProd.Location = New System.Drawing.Point(426, 518)
        Me.txtCustoProd.Name = "txtCustoProd"
        Me.txtCustoProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustoProd.Properties.Appearance.Options.UseFont = True
        Me.txtCustoProd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCustoProd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCustoProd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCustoProd.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txtCustoProd.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCustoProd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCustoProd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCustoProd.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCustoProd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCustoProd.Properties.ReadOnly = True
        Me.txtCustoProd.Size = New System.Drawing.Size(110, 21)
        Me.txtCustoProd.TabIndex = 113
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(322, 514)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(98, 12)
        Me.LabelControl7.TabIndex = 112
        Me.LabelControl7.Text = "Tot. Custo Prod. R$"
        '
        'txtServico
        '
        Me.txtServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServico.EditValue = ""
        Me.txtServico.Location = New System.Drawing.Point(193, 545)
        Me.txtServico.Name = "txtServico"
        Me.txtServico.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServico.Properties.Appearance.Options.UseFont = True
        Me.txtServico.Properties.Appearance.Options.UseTextOptions = True
        Me.txtServico.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtServico.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtServico.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txtServico.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtServico.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtServico.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtServico.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtServico.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtServico.Properties.ReadOnly = True
        Me.txtServico.Size = New System.Drawing.Size(110, 21)
        Me.txtServico.TabIndex = 111
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(110, 541)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(77, 12)
        Me.LabelControl6.TabIndex = 110
        Me.LabelControl6.Text = "Tot. Serviço R$"
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.EditValue = ""
        Me.txtProduto.Location = New System.Drawing.Point(193, 518)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.Properties.Appearance.Options.UseFont = True
        Me.txtProduto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtProduto.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txtProduto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtProduto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtProduto.Properties.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(110, 21)
        Me.txtProduto.TabIndex = 109
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(107, 514)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 12)
        Me.LabelControl5.TabIndex = 108
        Me.LabelControl5.Text = "Tot. Produto R$"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(930, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 107
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(987, 541)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(12, 12)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "%"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(930, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'txtPorc
        '
        Me.txtPorc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorc.EditValue = ""
        Me.txtPorc.Location = New System.Drawing.Point(934, 545)
        Me.txtPorc.Name = "txtPorc"
        Me.txtPorc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorc.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtPorc.Properties.Appearance.Options.UseFont = True
        Me.txtPorc.Properties.Appearance.Options.UseForeColor = True
        Me.txtPorc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPorc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Bisque
        Me.txtPorc.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtPorc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtPorc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPorc.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtPorc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPorc.Properties.ReadOnly = True
        Me.txtPorc.Size = New System.Drawing.Size(50, 21)
        Me.txtPorc.TabIndex = 19
        '
        'txtTotCusto
        '
        Me.txtTotCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotCusto.EditValue = ""
        Me.txtTotCusto.Location = New System.Drawing.Point(639, 545)
        Me.txtTotCusto.Name = "txtTotCusto"
        Me.txtTotCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotCusto.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotCusto.Properties.Appearance.Options.UseFont = True
        Me.txtTotCusto.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotCusto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotCusto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTotCusto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotCusto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotCusto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotCusto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotCusto.Properties.ReadOnly = True
        Me.txtTotCusto.Size = New System.Drawing.Size(110, 21)
        Me.txtTotCusto.TabIndex = 18
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(565, 541)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 12)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Tot. Custo R$"
        '
        'txtLucro
        '
        Me.txtLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLucro.EditValue = ""
        Me.txtLucro.Location = New System.Drawing.Point(824, 545)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLucro.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtLucro.Properties.Appearance.Options.UseFont = True
        Me.txtLucro.Properties.Appearance.Options.UseForeColor = True
        Me.txtLucro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLucro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLucro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtLucro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtLucro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtLucro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLucro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtLucro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtLucro.Properties.ReadOnly = True
        Me.txtLucro.Size = New System.Drawing.Size(110, 21)
        Me.txtLucro.TabIndex = 16
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(5, 517)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(95, 26)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        '
        'txtTot
        '
        Me.txtTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTot.EditValue = ""
        Me.txtTot.Location = New System.Drawing.Point(426, 545)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Properties.Appearance.Options.UseFont = True
        Me.txtTot.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTot.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTot.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.txtTot.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtTot.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTot.Properties.ReadOnly = True
        Me.txtTot.Size = New System.Drawing.Size(110, 21)
        Me.txtTot.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(353, 540)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 12)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tot. Geral R$"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(773, 540)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 12)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Lucro R$"
        '
        'TotalTableAdapter
        '
        Me.TotalTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'colOperador
        '
        Me.colOperador.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOperador.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colOperador.AppearanceCell.Options.UseBackColor = True
        Me.colOperador.Caption = "Caixa"
        Me.colOperador.FieldName = "Operador"
        Me.colOperador.Name = "colOperador"
        Me.colOperador.OptionsColumn.ReadOnly = True
        Me.colOperador.Visible = True
        Me.colOperador.VisibleIndex = 11
        '
        'frmRelLucro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 634)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRelLucro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Faturamento"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtLucroProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustoProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLucro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sfdSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TotalGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLucro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLucro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtPorc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents TotalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalTableAdapter As Nano.dsNanoCommerceTableAdapters.TotalTableAdapter
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents colTroco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents chkTroco As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chk1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkPerDesc As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chk2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkDesc As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chk3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelLuc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueFunc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents colPorcentagemDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtServico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCustoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLucroProd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustoProd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colTotalSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalFrete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperador As DevExpress.XtraGrid.Columns.GridColumn
End Class
