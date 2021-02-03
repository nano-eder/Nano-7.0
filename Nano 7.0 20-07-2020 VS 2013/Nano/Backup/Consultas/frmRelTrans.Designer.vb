<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelTrans))
        Me.dsTrans = New System.Data.DataSet
        Me.tbTrans = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnRelTra = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        CType(Me.dsTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsTrans
        '
        Me.dsTrans.DataSetName = "NewDataSet"
        Me.dsTrans.Tables.AddRange(New System.Data.DataTable() {Me.tbTrans})
        '
        'tbTrans
        '
        Me.tbTrans.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.tbTrans.TableName = "tbTrans"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodOrdem"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodProd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CodigoInterno"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Produto"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Tamanho"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Qtd"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ValorCusto"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Loja"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Data"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Usuario"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Custo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Lote"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GroupControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbTrans"
        Me.GridControl1.DataSource = Me.dsTrans
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueLoja})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 589)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colCodProd, Me.colCodigoInterno, Me.colProduto, Me.colTamanho, Me.colQtd, Me.colValorCusto, Me.colLoja, Me.colData, Me.colUsuario, Me.colCusto, Me.colLote, Me.colCodConfig})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtd", Me.colQtd, "{0:0.000}")})
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
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Ordem"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 69
        '
        'colCodProd
        '
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Cód. Prod."
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 2
        Me.colCodigoInterno.Width = 88
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 3
        Me.colProduto.Width = 181
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
        Me.colTamanho.VisibleIndex = 4
        Me.colTamanho.Width = 46
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.DisplayFormat.FormatString = "{0:0.000}"
        Me.colQtd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 5
        Me.colQtd.Width = 71
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Custo Total R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Width = 93
        '
        'colLoja
        '
        Me.colLoja.Caption = "Loja"
        Me.colLoja.FieldName = "Loja"
        Me.colLoja.Name = "colLoja"
        Me.colLoja.OptionsColumn.ReadOnly = True
        Me.colLoja.Visible = True
        Me.colLoja.VisibleIndex = 8
        Me.colLoja.Width = 99
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 72
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuario"
        Me.colUsuario.FieldName = "Usuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.OptionsColumn.ReadOnly = True
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 9
        Me.colUsuario.Width = 127
        '
        'colCusto
        '
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
        Me.colCusto.VisibleIndex = 6
        Me.colCusto.Width = 85
        '
        'colLote
        '
        Me.colLote.AppearanceCell.Options.UseTextOptions = True
        Me.colLote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Lote"
        Me.colLote.Name = "colLote"
        Me.colLote.OptionsColumn.ReadOnly = True
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 7
        Me.colLote.Width = 72
        '
        'colCodConfig
        '
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 10
        Me.colCodConfig.Width = 73
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFiltrar, Me.dtInicial, Me.dtFinal, Me.btnFechar, Me.BarSubItem1, Me.btnRelTra, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 8
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 103, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 106, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 0
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelTra), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnRelTra
        '
        Me.btnRelTra.Caption = "Relatório de Transferência"
        Me.btnRelTra.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelTra.Id = 6
        Me.btnRelTra.Name = "btnRelTra"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 7
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'frmRelTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRelTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Transferências"
        CType(Me.dsTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsTrans As System.Data.DataSet
    Friend WithEvents tbTrans As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelTra As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
End Class
