<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelComanda
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelComanda))
        Me.colTempo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.chkCus = New DevExpress.XtraBars.BarEditItem
        Me.chkCusto = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.chkDevol = New DevExpress.XtraBars.BarEditItem
        Me.chkDev = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsComanda = New System.Data.DataSet
        Me.tbComanda = New System.Data.DataTable
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
        Me.DataColumn14 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRetorna = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodComanda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueFunc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colTroco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelVend = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotPro = New DevExpress.XtraEditors.TextEdit
        Me.lblProd = New DevExpress.XtraEditors.LabelControl
        Me.txtTotGer = New DevExpress.XtraEditors.TextEdit
        Me.lblTotGer = New DevExpress.XtraEditors.LabelControl
        Me.sfdSalvar = New System.Windows.Forms.SaveFileDialog
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.DataColumn15 = New System.Data.DataColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.chkCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsComanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbComanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colTempo
        '
        Me.colTempo.Caption = "Tempo"
        Me.colTempo.FieldName = "Tempo"
        Me.colTempo.Name = "colTempo"
        Me.colTempo.OptionsColumn.ReadOnly = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarStaticItem1, Me.chkCus, Me.chkDevol})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkCusto, Me.RepositoryItemCheckEdit1, Me.chkDev})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 115)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Visible = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "Ver Colunas:"
        Me.BarStaticItem1.Id = 8
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'chkCus
        '
        Me.chkCus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkCus.Caption = "Troco"
        Me.chkCus.Edit = Me.chkCusto
        Me.chkCus.EditValue = False
        Me.chkCus.Id = 9
        Me.chkCus.Name = "chkCus"
        '
        'chkCusto
        '
        Me.chkCusto.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chkCusto.Appearance.Options.UseBackColor = True
        Me.chkCusto.Name = "chkCusto"
        Me.chkCusto.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'chkDevol
        '
        Me.chkDevol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.chkDevol.Caption = "Tempo"
        Me.chkDevol.Edit = Me.chkDev
        Me.chkDevol.EditValue = False
        Me.chkDevol.Id = 12
        Me.chkDevol.Name = "chkDevol"
        '
        'chkDev
        '
        Me.chkDev.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.chkDev.Appearance.Options.UseBackColor = True
        Me.chkDev.AutoHeight = False
        Me.chkDev.Name = "chkDev"
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkCus, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.chkDevol, True)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1008, 24)
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbComanda"
        Me.PedidoGridControl.DataSource = Me.dsComanda
        Me.PedidoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(0, 24)
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRetorna, Me.lueLoja, Me.lueFunc})
        Me.PedidoGridControl.Size = New System.Drawing.Size(1008, 548)
        Me.PedidoGridControl.TabIndex = 3
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsComanda
        '
        Me.dsComanda.DataSetName = "NewDataSet"
        Me.dsComanda.Tables.AddRange(New System.Data.DataTable() {Me.tbComanda})
        '
        'tbComanda
        '
        Me.tbComanda.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.tbComanda.TableName = "tbComanda"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodOrdem"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodComanda"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodFunc"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Data"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Cliente"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodProduto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Produto"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Qtd"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorUnitario"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ValorTotal"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Status"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Troco"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Tempo"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "CodConfig"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colCodComanda, Me.colCodFunc, Me.colData, Me.colCliente, Me.colCodProduto, Me.colProduto, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colStatus, Me.colCodConfig, Me.colTroco, Me.colTempo, Me.colTipo})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colTempo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorUnitario", Me.colValorUnitario, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotal", Me.colValorTotal, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Custo", Nothing, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtd", Me.colQtd, "{0:0.000}")})
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
        Me.colCodigo.ColumnEdit = Me.txtRetorna
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'txtRetorna
        '
        Me.txtRetorna.AutoHeight = False
        Me.txtRetorna.Name = "txtRetorna"
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Ordem"
        Me.colCodOrdem.ColumnEdit = Me.txtRetorna
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 69
        '
        'colCodComanda
        '
        Me.colCodComanda.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodComanda.AppearanceCell.Options.UseTextOptions = True
        Me.colCodComanda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodComanda.Caption = "Nº Comanda"
        Me.colCodComanda.ColumnEdit = Me.txtRetorna
        Me.colCodComanda.FieldName = "CodComanda"
        Me.colCodComanda.Name = "colCodComanda"
        Me.colCodComanda.OptionsColumn.ReadOnly = True
        Me.colCodComanda.Visible = True
        Me.colCodComanda.VisibleIndex = 2
        Me.colCodComanda.Width = 82
        '
        'colCodFunc
        '
        Me.colCodFunc.AppearanceCell.Options.UseTextOptions = True
        Me.colCodFunc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodFunc.Caption = "Vend."
        Me.colCodFunc.ColumnEdit = Me.lueFunc
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
        Me.colCodFunc.OptionsColumn.ReadOnly = True
        Me.colCodFunc.Visible = True
        Me.colCodFunc.VisibleIndex = 3
        Me.colCodFunc.Width = 50
        '
        'lueFunc
        '
        Me.lueFunc.AutoHeight = False
        Me.lueFunc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        'colData
        '
        Me.colData.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.ColumnEdit = Me.txtRetorna
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 4
        Me.colData.Width = 89
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtRetorna
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 5
        Me.colCliente.Width = 193
        '
        'colCodProduto
        '
        Me.colCodProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProduto.Caption = "Código"
        Me.colCodProduto.ColumnEdit = Me.txtRetorna
        Me.colCodProduto.FieldName = "CodProduto"
        Me.colCodProduto.Name = "colCodProduto"
        Me.colCodProduto.OptionsColumn.ReadOnly = True
        Me.colCodProduto.Visible = True
        Me.colCodProduto.VisibleIndex = 6
        Me.colCodProduto.Width = 65
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtRetorna
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 7
        Me.colProduto.Width = 212
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtRetorna
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 8
        Me.colQtd.Width = 52
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Vlr Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtRetorna
        Me.colValorUnitario.DisplayFormat.FormatString = "c"
        Me.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorUnitario.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 9
        Me.colValorUnitario.Width = 76
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colValorTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorTotal.AppearanceCell.Options.UseFont = True
        Me.colValorTotal.AppearanceCell.Options.UseForeColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Vlr Total R$"
        Me.colValorTotal.ColumnEdit = Me.txtRetorna
        Me.colValorTotal.DisplayFormat.FormatString = "c"
        Me.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 10
        Me.colValorTotal.Width = 77
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 11
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodConfig.AppearanceCell.Options.UseFont = True
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 12
        Me.colCodConfig.Width = 67
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'colTroco
        '
        Me.colTroco.AppearanceCell.Options.UseTextOptions = True
        Me.colTroco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTroco.Caption = "Troco"
        Me.colTroco.ColumnEdit = Me.txtRetorna
        Me.colTroco.FieldName = "Troco"
        Me.colTroco.Name = "colTroco"
        Me.colTroco.OptionsColumn.ReadOnly = True
        Me.colTroco.Width = 69
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.PedidoGridControl
        Me.GridView2.Name = "GridView2"
        '
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.bsiVisu, Me.btnRelVend, Me.btnRelCust})
        Me.bmComandos.MaxItemId = 13
        Me.bmComandos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4})
        Me.bmComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 108, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 107, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit3
        Me.dtInicial.Id = 7
        Me.dtInicial.Name = "dtInicial"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtFinal
        '
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit4
        Me.dtFinal.Id = 8
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "&Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 9
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 10
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelVend), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelVend
        '
        Me.btnRelVend.Caption = "Relatório de Vendas"
        Me.btnRelVend.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelVend.Id = 11
        Me.btnRelVend.Name = "btnRelVend"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 12
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.txtTotPro)
        Me.GroupControl1.Controls.Add(Me.lblProd)
        Me.GroupControl1.Controls.Add(Me.txtTotGer)
        Me.GroupControl1.Controls.Add(Me.lblTotGer)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 572)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 32)
        Me.GroupControl1.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(324, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 26)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        '
        'txtTotPro
        '
        Me.txtTotPro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotPro.Location = New System.Drawing.Point(524, 4)
        Me.txtTotPro.Name = "txtTotPro"
        Me.txtTotPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPro.Properties.Appearance.Options.UseFont = True
        Me.txtTotPro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotPro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotPro.Size = New System.Drawing.Size(169, 26)
        Me.txtTotPro.TabIndex = 5
        '
        'lblProd
        '
        Me.lblProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Appearance.Options.UseFont = True
        Me.lblProd.Location = New System.Drawing.Point(443, 10)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(75, 13)
        Me.lblProd.TabIndex = 4
        Me.lblProd.Text = "Qtde Produto"
        '
        'txtTotGer
        '
        Me.txtTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotGer.Location = New System.Drawing.Point(803, 4)
        Me.txtTotGer.Name = "txtTotGer"
        Me.txtTotGer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.Appearance.Options.UseFont = True
        Me.txtTotGer.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotGer.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotGer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotGer.Size = New System.Drawing.Size(193, 26)
        Me.txtTotGer.TabIndex = 1
        '
        'lblTotGer
        '
        Me.lblTotGer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotGer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotGer.Appearance.Options.UseFont = True
        Me.lblTotGer.Location = New System.Drawing.Point(717, 10)
        Me.lblTotGer.Name = "lblTotGer"
        Me.lblTotGer.Size = New System.Drawing.Size(80, 13)
        Me.lblTotGer.TabIndex = 0
        Me.lblTotGer.Text = "Total Geral R$"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(932, 42)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 107
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(932, 27)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Tipo"
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 1
        '
        'frmRelComanda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 640)
        Me.Controls.Add(Me.btnPadrao)
        Me.Controls.Add(Me.btnManter)
        Me.Controls.Add(Me.PedidoGridControl)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRelComanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Comandas"
        CType(Me.chkCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsComanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbComanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTotPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodComanda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bmComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTotGer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotGer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotPro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sfdSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colTroco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRetorna As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colTempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueFunc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents chkCus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chkCusto As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelVend As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkDevol As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chkDev As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsComanda As System.Data.DataSet
    Friend WithEvents tbComanda As System.Data.DataTable
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
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
End Class
