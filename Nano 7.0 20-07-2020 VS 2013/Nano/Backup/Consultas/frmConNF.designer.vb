<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConNF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConNF))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelItens = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.EntradaNFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsNano = New Nano.dsNano
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colValProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCFOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRegime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrigem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCalculoCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVAST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaICMSST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMSST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEnq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoANPEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUFCombEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUMProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtValNota = New DevExpress.XtraEditors.TextEdit
        Me.sfdSalvar = New System.Windows.Forms.SaveFileDialog
        Me.EntradaNFTableAdapter = New Nano.dsNanoTableAdapters.EntradaNFTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoTableAdapters.ConfigTableAdapter
        Me.colChave = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaNFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCancelar, Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.bsiVisu, Me.btnRelItens, Me.btnRelCust})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 110, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 113, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 1
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
        Me.dtFinal.Id = 2
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
        Me.btnFiltrar.Id = 3
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 7
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelItens), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelItens
        '
        Me.btnRelItens.Caption = "Relatório de Itens de NF"
        Me.btnRelItens.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelItens.Id = 8
        Me.btnRelItens.Name = "btnRelItens"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 9
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 0
        Me.btnCancelar.Name = "btnCancelar"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Location = New System.Drawing.Point(464, 502)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 115)
        Me.RibbonControl1.Visible = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.KeyTip = ""
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.Grid1)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtValNota)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 628)
        Me.GroupControl1.TabIndex = 10
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(929, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 107
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(701, 604)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(128, 16)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Valor Total Geral R$"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(929, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.EntradaNFBindingSource
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 2)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueLoja})
        Me.Grid1.Size = New System.Drawing.Size(1004, 591)
        Me.Grid1.TabIndex = 58
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'EntradaNFBindingSource
        '
        Me.EntradaNFBindingSource.DataMember = "EntradaNF"
        Me.EntradaNFBindingSource.DataSource = Me.dsNano
        '
        'dsNano
        '
        Me.dsNano.DataSetName = "dsNano"
        Me.dsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNumeroNF, Me.colCodFor, Me.colFornecedor, Me.colCodigoProduto, Me.colQtd, Me.colValorUnitario, Me.colData, Me.colValorTotal, Me.colProduto, Me.colICMS, Me.colDesconto, Me.colCodConfig, Me.colValProd, Me.colCFOP, Me.colNCM, Me.colRegime, Me.colCST, Me.colOrigem, Me.colCalculoCred, Me.colValCred, Me.colModBC, Me.colRedBC, Me.colAliquotaICMS, Me.colValICMS, Me.colModBCST, Me.colRedBCST, Me.colMVAST, Me.colAliquotaICMSST, Me.colValICMSST, Me.colCSTIPI, Me.colCodEnq, Me.colAliquotaIPI, Me.colValIPI, Me.colCSTPIS, Me.colAliquotaPIS, Me.colValPIS, Me.colCSTCOFINS, Me.colAliquotaCOFINS, Me.colValCOFINS, Me.colCodigoANPEnt, Me.colUFCombEnt, Me.colValorCusto, Me.colUMProd, Me.colQtdProd, Me.colCodPedido, Me.colObs, Me.colChave})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtd", Me.colQtd, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotal", Me.colValorTotal, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValProd", Me.colValProd, "{0:c}  ")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colNumeroNF
        '
        Me.colNumeroNF.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colNumeroNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroNF.Caption = "Nº da NF"
        Me.colNumeroNF.FieldName = "NumeroNF"
        Me.colNumeroNF.Name = "colNumeroNF"
        Me.colNumeroNF.OptionsColumn.ReadOnly = True
        Me.colNumeroNF.Visible = True
        Me.colNumeroNF.VisibleIndex = 0
        Me.colNumeroNF.Width = 74
        '
        'colCodFor
        '
        Me.colCodFor.AppearanceCell.Options.UseTextOptions = True
        Me.colCodFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodFor.Caption = "Cód. For."
        Me.colCodFor.FieldName = "CodFor"
        Me.colCodFor.Name = "colCodFor"
        Me.colCodFor.OptionsColumn.ReadOnly = True
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colFornecedor.Caption = "Nome Fornecedor"
        Me.colFornecedor.FieldName = "Nome"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 2
        Me.colFornecedor.Width = 194
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.Caption = "Cód. Prod."
        Me.colCodigoProduto.FieldName = "CodProdInterno"
        Me.colCodigoProduto.Name = "colCodigoProduto"
        Me.colCodigoProduto.OptionsColumn.ReadOnly = True
        Me.colCodigoProduto.Visible = True
        Me.colCodigoProduto.VisibleIndex = 3
        Me.colCodigoProduto.Width = 84
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.DisplayFormat.FormatString = "{0:0.000}"
        Me.colQtd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 5
        Me.colQtd.Width = 60
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Val. Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 89
        '
        'colData
        '
        Me.colData.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 81
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorTotal.AppearanceCell.Options.UseFont = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Val. Total R$"
        Me.colValorTotal.DisplayFormat.FormatString = "{0:c}"
        Me.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 90
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 4
        Me.colProduto.Width = 217
        '
        'colICMS
        '
        Me.colICMS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colICMS.Caption = "BC ICMS %"
        Me.colICMS.FieldName = "ICMS"
        Me.colICMS.Name = "colICMS"
        Me.colICMS.OptionsColumn.ReadOnly = True
        Me.colICMS.Width = 76
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDesconto.Caption = "Desc. %"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 9
        Me.colDesconto.Width = 62
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 13
        Me.colCodConfig.Width = 68
        '
        'lueLoja
        '
        Me.lueLoja.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DataSource = Me.ConfigBindingSource
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.dsNano
        '
        'colValProd
        '
        Me.colValProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValProd.AppearanceCell.Options.UseTextOptions = True
        Me.colValProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValProd.Caption = "Val. Venda R$"
        Me.colValProd.DisplayFormat.FormatString = "{0:c}"
        Me.colValProd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValProd.FieldName = "ValProd"
        Me.colValProd.Name = "colValProd"
        Me.colValProd.OptionsColumn.ReadOnly = True
        Me.colValProd.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValProd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValProd.Visible = True
        Me.colValProd.VisibleIndex = 8
        Me.colValProd.Width = 91
        '
        'colCFOP
        '
        Me.colCFOP.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCFOP.AppearanceCell.Options.UseTextOptions = True
        Me.colCFOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCFOP.Caption = "CFOP"
        Me.colCFOP.FieldName = "CFOP"
        Me.colCFOP.Name = "colCFOP"
        Me.colCFOP.OptionsColumn.ReadOnly = True
        Me.colCFOP.Visible = True
        Me.colCFOP.VisibleIndex = 14
        '
        'colNCM
        '
        Me.colNCM.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colNCM.AppearanceCell.Options.UseTextOptions = True
        Me.colNCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNCM.Caption = "NCM"
        Me.colNCM.FieldName = "NCM"
        Me.colNCM.Name = "colNCM"
        Me.colNCM.OptionsColumn.ReadOnly = True
        Me.colNCM.Visible = True
        Me.colNCM.VisibleIndex = 15
        '
        'colRegime
        '
        Me.colRegime.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colRegime.AppearanceCell.Options.UseTextOptions = True
        Me.colRegime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRegime.Caption = "Regime"
        Me.colRegime.FieldName = "Regime"
        Me.colRegime.Name = "colRegime"
        Me.colRegime.OptionsColumn.ReadOnly = True
        Me.colRegime.Visible = True
        Me.colRegime.VisibleIndex = 16
        '
        'colCST
        '
        Me.colCST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCST.AppearanceCell.Options.UseTextOptions = True
        Me.colCST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCST.Caption = "CST/CSOSN"
        Me.colCST.FieldName = "CST"
        Me.colCST.Name = "colCST"
        Me.colCST.OptionsColumn.ReadOnly = True
        Me.colCST.Visible = True
        Me.colCST.VisibleIndex = 17
        '
        'colOrigem
        '
        Me.colOrigem.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colOrigem.AppearanceCell.Options.UseTextOptions = True
        Me.colOrigem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigem.Caption = "Origem"
        Me.colOrigem.FieldName = "Origem"
        Me.colOrigem.Name = "colOrigem"
        Me.colOrigem.OptionsColumn.ReadOnly = True
        Me.colOrigem.Visible = True
        Me.colOrigem.VisibleIndex = 18
        '
        'colCalculoCred
        '
        Me.colCalculoCred.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCalculoCred.AppearanceCell.Options.UseTextOptions = True
        Me.colCalculoCred.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCalculoCred.Caption = "Calc. Cred."
        Me.colCalculoCred.FieldName = "CalculoCred"
        Me.colCalculoCred.Name = "colCalculoCred"
        Me.colCalculoCred.OptionsColumn.ReadOnly = True
        Me.colCalculoCred.Visible = True
        Me.colCalculoCred.VisibleIndex = 19
        '
        'colValCred
        '
        Me.colValCred.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValCred.AppearanceCell.Options.UseTextOptions = True
        Me.colValCred.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValCred.Caption = "Val. Cred."
        Me.colValCred.FieldName = "ValCred"
        Me.colValCred.Name = "colValCred"
        Me.colValCred.OptionsColumn.ReadOnly = True
        Me.colValCred.Visible = True
        Me.colValCred.VisibleIndex = 20
        '
        'colModBC
        '
        Me.colModBC.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colModBC.AppearanceCell.Options.UseTextOptions = True
        Me.colModBC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModBC.Caption = "Mod. BC"
        Me.colModBC.FieldName = "ModBC"
        Me.colModBC.Name = "colModBC"
        Me.colModBC.OptionsColumn.ReadOnly = True
        Me.colModBC.Visible = True
        Me.colModBC.VisibleIndex = 21
        '
        'colRedBC
        '
        Me.colRedBC.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colRedBC.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBC.Caption = "Red. BC"
        Me.colRedBC.FieldName = "RedBC"
        Me.colRedBC.Name = "colRedBC"
        Me.colRedBC.OptionsColumn.ReadOnly = True
        Me.colRedBC.Visible = True
        Me.colRedBC.VisibleIndex = 22
        '
        'colAliquotaICMS
        '
        Me.colAliquotaICMS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colAliquotaICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaICMS.Caption = "Aliq. ICMS"
        Me.colAliquotaICMS.FieldName = "AliquotaICMS"
        Me.colAliquotaICMS.Name = "colAliquotaICMS"
        Me.colAliquotaICMS.OptionsColumn.ReadOnly = True
        Me.colAliquotaICMS.Visible = True
        Me.colAliquotaICMS.VisibleIndex = 23
        '
        'colValICMS
        '
        Me.colValICMS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMS.Caption = "Val. ICMS"
        Me.colValICMS.FieldName = "ValICMS"
        Me.colValICMS.Name = "colValICMS"
        Me.colValICMS.OptionsColumn.ReadOnly = True
        Me.colValICMS.Visible = True
        Me.colValICMS.VisibleIndex = 24
        '
        'colModBCST
        '
        Me.colModBCST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colModBCST.AppearanceCell.Options.UseTextOptions = True
        Me.colModBCST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModBCST.Caption = "Mod. BC ST"
        Me.colModBCST.FieldName = "ModBCST"
        Me.colModBCST.Name = "colModBCST"
        Me.colModBCST.OptionsColumn.ReadOnly = True
        Me.colModBCST.Visible = True
        Me.colModBCST.VisibleIndex = 25
        '
        'colRedBCST
        '
        Me.colRedBCST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colRedBCST.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBCST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBCST.Caption = "Red. BC ST"
        Me.colRedBCST.FieldName = "RedBCST"
        Me.colRedBCST.Name = "colRedBCST"
        Me.colRedBCST.OptionsColumn.ReadOnly = True
        Me.colRedBCST.Visible = True
        Me.colRedBCST.VisibleIndex = 26
        '
        'colMVAST
        '
        Me.colMVAST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colMVAST.AppearanceCell.Options.UseTextOptions = True
        Me.colMVAST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMVAST.Caption = "MVAST"
        Me.colMVAST.FieldName = "MVAST"
        Me.colMVAST.Name = "colMVAST"
        Me.colMVAST.OptionsColumn.ReadOnly = True
        Me.colMVAST.Visible = True
        Me.colMVAST.VisibleIndex = 27
        '
        'colAliquotaICMSST
        '
        Me.colAliquotaICMSST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colAliquotaICMSST.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaICMSST.Caption = "Aliq. ICMS ST"
        Me.colAliquotaICMSST.FieldName = "AliquotaICMSST"
        Me.colAliquotaICMSST.Name = "colAliquotaICMSST"
        Me.colAliquotaICMSST.OptionsColumn.ReadOnly = True
        Me.colAliquotaICMSST.Visible = True
        Me.colAliquotaICMSST.VisibleIndex = 28
        '
        'colValICMSST
        '
        Me.colValICMSST.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValICMSST.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMSST.Caption = "Val. ICMS ST"
        Me.colValICMSST.FieldName = "ValICMSST"
        Me.colValICMSST.Name = "colValICMSST"
        Me.colValICMSST.OptionsColumn.ReadOnly = True
        Me.colValICMSST.Visible = True
        Me.colValICMSST.VisibleIndex = 29
        '
        'colCSTIPI
        '
        Me.colCSTIPI.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCSTIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTIPI.Caption = "CST IPI"
        Me.colCSTIPI.FieldName = "CSTIPI"
        Me.colCSTIPI.Name = "colCSTIPI"
        Me.colCSTIPI.OptionsColumn.ReadOnly = True
        Me.colCSTIPI.Visible = True
        Me.colCSTIPI.VisibleIndex = 30
        '
        'colCodEnq
        '
        Me.colCodEnq.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodEnq.AppearanceCell.Options.UseTextOptions = True
        Me.colCodEnq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodEnq.Caption = "Cód. Enq."
        Me.colCodEnq.FieldName = "CodEnq"
        Me.colCodEnq.Name = "colCodEnq"
        Me.colCodEnq.OptionsColumn.ReadOnly = True
        Me.colCodEnq.Visible = True
        Me.colCodEnq.VisibleIndex = 31
        '
        'colAliquotaIPI
        '
        Me.colAliquotaIPI.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colAliquotaIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaIPI.Caption = "Aliq. IPI"
        Me.colAliquotaIPI.FieldName = "AliquotaIPI"
        Me.colAliquotaIPI.Name = "colAliquotaIPI"
        Me.colAliquotaIPI.OptionsColumn.ReadOnly = True
        Me.colAliquotaIPI.Visible = True
        Me.colAliquotaIPI.VisibleIndex = 32
        '
        'colValIPI
        '
        Me.colValIPI.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colValIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValIPI.Caption = "Val. IPI"
        Me.colValIPI.FieldName = "ValIPI"
        Me.colValIPI.Name = "colValIPI"
        Me.colValIPI.OptionsColumn.ReadOnly = True
        Me.colValIPI.Visible = True
        Me.colValIPI.VisibleIndex = 33
        '
        'colCSTPIS
        '
        Me.colCSTPIS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCSTPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTPIS.Caption = "CST PIS"
        Me.colCSTPIS.FieldName = "CSTPIS"
        Me.colCSTPIS.Name = "colCSTPIS"
        Me.colCSTPIS.OptionsColumn.ReadOnly = True
        Me.colCSTPIS.Visible = True
        Me.colCSTPIS.VisibleIndex = 34
        '
        'colAliquotaPIS
        '
        Me.colAliquotaPIS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colAliquotaPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaPIS.Caption = "Aliq. PIS"
        Me.colAliquotaPIS.FieldName = "AliquotaPIS"
        Me.colAliquotaPIS.Name = "colAliquotaPIS"
        Me.colAliquotaPIS.OptionsColumn.ReadOnly = True
        Me.colAliquotaPIS.Visible = True
        Me.colAliquotaPIS.VisibleIndex = 35
        '
        'colValPIS
        '
        Me.colValPIS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colValPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValPIS.Caption = "Val. PIS"
        Me.colValPIS.FieldName = "ValPIS"
        Me.colValPIS.Name = "colValPIS"
        Me.colValPIS.OptionsColumn.ReadOnly = True
        Me.colValPIS.Visible = True
        Me.colValPIS.VisibleIndex = 36
        '
        'colCSTCOFINS
        '
        Me.colCSTCOFINS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCSTCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTCOFINS.Caption = "CST COFINS"
        Me.colCSTCOFINS.FieldName = "CSTCOFINS"
        Me.colCSTCOFINS.Name = "colCSTCOFINS"
        Me.colCSTCOFINS.OptionsColumn.ReadOnly = True
        Me.colCSTCOFINS.Visible = True
        Me.colCSTCOFINS.VisibleIndex = 37
        '
        'colAliquotaCOFINS
        '
        Me.colAliquotaCOFINS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colAliquotaCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaCOFINS.Caption = "Aliq. COFINS"
        Me.colAliquotaCOFINS.FieldName = "AliquotaCOFINS"
        Me.colAliquotaCOFINS.Name = "colAliquotaCOFINS"
        Me.colAliquotaCOFINS.OptionsColumn.ReadOnly = True
        Me.colAliquotaCOFINS.Visible = True
        Me.colAliquotaCOFINS.VisibleIndex = 38
        '
        'colValCOFINS
        '
        Me.colValCOFINS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colValCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValCOFINS.Caption = "Val. COFINS"
        Me.colValCOFINS.FieldName = "ValCOFINS"
        Me.colValCOFINS.Name = "colValCOFINS"
        Me.colValCOFINS.OptionsColumn.ReadOnly = True
        Me.colValCOFINS.Visible = True
        Me.colValCOFINS.VisibleIndex = 39
        '
        'colCodigoANPEnt
        '
        Me.colCodigoANPEnt.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoANPEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoANPEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoANPEnt.Caption = "Código ANP"
        Me.colCodigoANPEnt.FieldName = "CodigoANPEnt"
        Me.colCodigoANPEnt.Name = "colCodigoANPEnt"
        Me.colCodigoANPEnt.OptionsColumn.ReadOnly = True
        Me.colCodigoANPEnt.Visible = True
        Me.colCodigoANPEnt.VisibleIndex = 40
        '
        'colUFCombEnt
        '
        Me.colUFCombEnt.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colUFCombEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colUFCombEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUFCombEnt.Caption = "UF Comb."
        Me.colUFCombEnt.FieldName = "UFCombEnt"
        Me.colUFCombEnt.Name = "colUFCombEnt"
        Me.colUFCombEnt.OptionsColumn.ReadOnly = True
        Me.colUFCombEnt.Visible = True
        Me.colUFCombEnt.VisibleIndex = 41
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorCusto.AppearanceHeader.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Custo Prod. R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Visible = True
        Me.colValorCusto.VisibleIndex = 10
        Me.colValorCusto.Width = 95
        '
        'colUMProd
        '
        Me.colUMProd.AppearanceCell.Options.UseTextOptions = True
        Me.colUMProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUMProd.Caption = "UM Prod."
        Me.colUMProd.FieldName = "UMProd"
        Me.colUMProd.Name = "colUMProd"
        Me.colUMProd.OptionsColumn.ReadOnly = True
        Me.colUMProd.Visible = True
        Me.colUMProd.VisibleIndex = 11
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
        Me.colQtdProd.VisibleIndex = 12
        '
        'colCodPedido
        '
        Me.colCodPedido.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPedido.Caption = "Cód. Ped."
        Me.colCodPedido.FieldName = "CodPedido"
        Me.colCodPedido.Name = "colCodPedido"
        '
        'colObs
        '
        Me.colObs.Caption = "Obs."
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 42
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(524, 599)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(121, 26)
        Me.btnCalcular.TabIndex = 58
        Me.btnCalcular.Text = "Calcular"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(710, 647)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl3.TabIndex = 57
        Me.LabelControl3.Text = "Total Geral R$"
        '
        'txtValNota
        '
        Me.txtValNota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValNota.EnterMoveNextControl = True
        Me.txtValNota.Location = New System.Drawing.Point(835, 597)
        Me.txtValNota.Name = "txtValNota"
        Me.txtValNota.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValNota.Properties.Appearance.Options.UseBackColor = True
        Me.txtValNota.Properties.Appearance.Options.UseFont = True
        Me.txtValNota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValNota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValNota.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValNota.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValNota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValNota.Properties.MaxLength = 19
        Me.txtValNota.Properties.ReadOnly = True
        Me.txtValNota.Size = New System.Drawing.Size(161, 29)
        Me.txtValNota.TabIndex = 56
        Me.txtValNota.Tag = "Preço R$"
        '
        'EntradaNFTableAdapter
        '
        Me.EntradaNFTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'colChave
        '
        Me.colChave.Caption = "Chave"
        Me.colChave.FieldName = "Chave"
        Me.colChave.Name = "colChave"
        Me.colChave.OptionsColumn.ReadOnly = True
        '
        'frmConNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 664)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConNF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Notas Fiscais"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaNFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValNota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents EntradaNFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsNano As Nano.dsNano
    Friend WithEvents EntradaNFTableAdapter As Nano.dsNanoTableAdapters.EntradaNFTableAdapter
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoTableAdapters.ConfigTableAdapter
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colValProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelItens As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCFOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculoCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVAST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaICMSST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMSST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodEnq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoANPEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUFCombEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChave As DevExpress.XtraGrid.Columns.GridColumn
End Class
