<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelPedCompra
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelPedCompra))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnRelPed = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPed = New System.Data.DataSet
        Me.tbPed = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueFunc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colObsProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitarioSemDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotPro = New DevExpress.XtraEditors.TextEdit
        Me.lblProd = New DevExpress.XtraEditors.LabelControl
        Me.txtTotGer = New DevExpress.XtraEditors.TextEdit
        Me.lblTotGer = New DevExpress.XtraEditors.LabelControl
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.chkObsProduto = New DevExpress.XtraBars.BarEditItem
        Me.chkObsProd = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.btnConsultar = New DevExpress.XtraBars.BarButtonItem
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkObsProd, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.BarSubItem1, Me.btnRelPed, Me.btnRelCust, Me.btnFechar})
        Me.BarManager1.MaxItemId = 7
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 103, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 107, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 0
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
        Me.dtFinal.Id = 1
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
        Me.btnFiltrar.Id = 2
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 3
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelPed), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnRelPed
        '
        Me.btnRelPed.Caption = "&Relatório de Pedidos"
        Me.btnRelPed.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelPed.Id = 4
        Me.btnRelPed.Name = "btnRelPed"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 5
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 6
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbPed"
        Me.GridControl1.DataSource = Me.dsPed
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueFunc, Me.lueLoja})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 566)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsPed
        '
        Me.dsPed.DataSetName = "NewDataSet"
        Me.dsPed.Tables.AddRange(New System.Data.DataTable() {Me.tbPed})
        '
        'tbPed
        '
        Me.tbPed.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.tbPed.TableName = "tbPed"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodOrdem"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Data"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Cliente"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Vendedor"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CodProd"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Produto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Qtd"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ValorUnitario"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorTotal"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Obs"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Status"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CodConfig"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodOrdem, Me.colData, Me.colCliente, Me.colVendedor, Me.colCodProd, Me.colProduto, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colObs, Me.colStatus, Me.colCodConfig, Me.colObsProduto, Me.colCodVenda, Me.colUnitarioSemDesconto, Me.colTipo, Me.colNumNF, Me.colFabricante})
        Me.grd1.CustomizationFormBounds = New System.Drawing.Rectangle(840, 384, 216, 204)
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Pedido"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 69
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
        'colCliente
        '
        Me.colCliente.Caption = "Fornecedor"
        Me.colCliente.FieldName = "Fornecedor"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 206
        '
        'colVendedor
        '
        Me.colVendedor.AppearanceCell.Options.UseTextOptions = True
        Me.colVendedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVendedor.Caption = "Vend."
        Me.colVendedor.ColumnEdit = Me.lueFunc
        Me.colVendedor.FieldName = "Vendedor"
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.OptionsColumn.ReadOnly = True
        Me.colVendedor.Visible = True
        Me.colVendedor.VisibleIndex = 3
        Me.colVendedor.Width = 50
        '
        'lueFunc
        '
        Me.lueFunc.AutoHeight = False
        Me.lueFunc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.Caption = "Cód. Prod."
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Visible = True
        Me.colCodProd.VisibleIndex = 5
        Me.colCodProd.Width = 79
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 6
        Me.colProduto.Width = 184
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 7
        Me.colQtd.Width = 51
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Vlr Unit. R$"
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 9
        Me.colValorUnitario.Width = 76
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Vlr Total R$"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 10
        Me.colValorTotal.Width = 77
        '
        'colObs
        '
        Me.colObs.Caption = "Obs"
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 12
        Me.colObs.Width = 249
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 11
        Me.colStatus.Width = 90
        '
        'colCodConfig
        '
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 13
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DataSource = Me.ConfigBindingSource
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'colObsProduto
        '
        Me.colObsProduto.Caption = "Obs Produto"
        Me.colObsProduto.FieldName = "ObsProduto"
        Me.colObsProduto.Name = "colObsProduto"
        Me.colObsProduto.OptionsColumn.ReadOnly = True
        Me.colObsProduto.Width = 257
        '
        'colCodVenda
        '
        Me.colCodVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colCodVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodVenda.Caption = "Nº Venda"
        Me.colCodVenda.FieldName = "CodVenda"
        Me.colCodVenda.Name = "colCodVenda"
        Me.colCodVenda.OptionsColumn.ReadOnly = True
        Me.colCodVenda.Width = 67
        '
        'colUnitarioSemDesconto
        '
        Me.colUnitarioSemDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitarioSemDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitarioSemDesconto.Caption = "Un. S/ Des R$"
        Me.colUnitarioSemDesconto.FieldName = "UniSemDesc"
        Me.colUnitarioSemDesconto.Name = "colUnitarioSemDesconto"
        Me.colUnitarioSemDesconto.OptionsColumn.ReadOnly = True
        Me.colUnitarioSemDesconto.Visible = True
        Me.colUnitarioSemDesconto.VisibleIndex = 8
        Me.colUnitarioSemDesconto.Width = 89
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        '
        'colNumNF
        '
        Me.colNumNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumNF.Caption = "Nº NF."
        Me.colNumNF.FieldName = "NumNF"
        Me.colNumNF.Name = "colNumNF"
        Me.colNumNF.OptionsColumn.ReadOnly = True
        Me.colNumNF.Visible = True
        Me.colNumNF.VisibleIndex = 2
        '
        'colFabricante
        '
        Me.colFabricante.Caption = "Fabricante"
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        Me.colFabricante.Width = 150
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.txtTotPro)
        Me.GroupControl1.Controls.Add(Me.lblProd)
        Me.GroupControl1.Controls.Add(Me.txtTotGer)
        Me.GroupControl1.Controls.Add(Me.lblTotGer)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.RibbonControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 23)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 603)
        Me.GroupControl1.TabIndex = 5
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(927, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 109
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(927, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(324, 572)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 28)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        '
        'txtTotPro
        '
        Me.txtTotPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotPro.Location = New System.Drawing.Point(524, 573)
        Me.txtTotPro.Name = "txtTotPro"
        Me.txtTotPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPro.Properties.Appearance.Options.UseFont = True
        Me.txtTotPro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotPro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotPro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotPro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotPro.Properties.ReadOnly = True
        Me.txtTotPro.Size = New System.Drawing.Size(169, 26)
        Me.txtTotPro.TabIndex = 10
        '
        'lblProd
        '
        Me.lblProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Appearance.Options.UseFont = True
        Me.lblProd.Location = New System.Drawing.Point(443, 579)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(75, 13)
        Me.lblProd.TabIndex = 9
        Me.lblProd.Text = "Qtde Produto"
        '
        'txtTotGer
        '
        Me.txtTotGer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotGer.Location = New System.Drawing.Point(803, 573)
        Me.txtTotGer.Name = "txtTotGer"
        Me.txtTotGer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.Appearance.Options.UseFont = True
        Me.txtTotGer.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotGer.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotGer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotGer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotGer.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotGer.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotGer.Properties.ReadOnly = True
        Me.txtTotGer.Size = New System.Drawing.Size(193, 26)
        Me.txtTotGer.TabIndex = 8
        '
        'lblTotGer
        '
        Me.lblTotGer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotGer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGer.Appearance.Options.UseFont = True
        Me.lblTotGer.Location = New System.Drawing.Point(717, 579)
        Me.lblTotGer.Name = "lblTotGer"
        Me.lblTotGer.Size = New System.Drawing.Size(80, 13)
        Me.lblTotGer.TabIndex = 7
        Me.lblTotGer.Text = "Total Geral R$"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.chkObsProduto, Me.btnConsultar})
        Me.RibbonControl1.Location = New System.Drawing.Point(357, 145)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkObsProd})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 115)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "Ver Coluna:"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'chkObsProduto
        '
        Me.chkObsProduto.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkObsProduto.Caption = "Obs Produto"
        Me.chkObsProduto.Edit = Me.chkObsProd
        Me.chkObsProduto.Id = 2
        Me.chkObsProduto.Name = "chkObsProduto"
        '
        'chkObsProd
        '
        Me.chkObsProd.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chkObsProd.Appearance.Options.UseBackColor = True
        Me.chkObsProd.AutoHeight = False
        Me.chkObsProd.Name = "chkObsProd"
        Me.chkObsProd.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'btnConsultar
        '
        Me.btnConsultar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnConsultar.Id = 3
        Me.btnConsultar.Name = "btnConsultar"
        ToolTipTitleItem1.Text = "Consultar no Pedido"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnConsultar.SuperTip = SuperToolTip1
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.KeyTip = ""
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.KeyTip = ""
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkObsProduto)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnConsultar)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1008, 23)
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'frmRelPedCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelPedCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Pedidos"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkObsProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelPed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dsPed As System.Data.DataSet
    Friend WithEvents tbPed As System.Data.DataTable
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
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotGer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotGer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents lueFunc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents chkObsProduto As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chkObsProd As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colObsProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsultar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitarioSemDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
End Class
