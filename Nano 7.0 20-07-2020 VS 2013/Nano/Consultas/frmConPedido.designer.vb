<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConPedido
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConPedido))
        Me.colDevolvido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtRetorna = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueFunc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMarkup = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMargem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNFe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorFrete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComputador = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.PedidoTableAdapter = New Nano.dsNanoCommerceTableAdapters.PedidoTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.colOperador = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.chkCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'colDevolvido
        '
        Me.colDevolvido.Caption = "Devolvido"
        Me.colDevolvido.FieldName = "Devolvido"
        Me.colDevolvido.Name = "colDevolvido"
        Me.colDevolvido.OptionsColumn.ReadOnly = True
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDesconto.Caption = "Desconto %"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
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
        Me.chkCus.Caption = "Custo R$"
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
        Me.chkDevol.Caption = "Devolvido"
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
        Me.PedidoGridControl.DataSource = Me.PedidoBindingSource
        Me.PedidoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(0, 24)
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtRetorna, Me.lueLoja, Me.lueFunc, Me.RepositoryItemCheckEdit2})
        Me.PedidoGridControl.Size = New System.Drawing.Size(1008, 548)
        Me.PedidoGridControl.TabIndex = 3
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'PedidoBindingSource
        '
        Me.PedidoBindingSource.DataMember = "Pedido"
        Me.PedidoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCod, Me.colData, Me.colCliente, Me.colCPF, Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colRealizado, Me.colTipoProduto, Me.colCodProdInterno, Me.colDevolvido, Me.colCodConfig, Me.colCodFunc, Me.colTamanho, Me.colCodigoBarra, Me.colCusto, Me.colStatus, Me.colGrupo, Me.colFabricante, Me.colSetor, Me.colCidade, Me.colTipo, Me.colDesconto, Me.colUniSemDesc, Me.colMarkup, Me.colFantasia, Me.colSAT, Me.colVendedor, Me.colComissao, Me.colLucro, Me.colMargem, Me.colPlaca, Me.colModelo, Me.colKM, Me.colCodigoInterno, Me.colCodPedido, Me.colNFe, Me.colValorFrete, Me.colComputador, Me.colOperador})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colDevolvido
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Yellow
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colDesconto
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = 99.98
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorUnitario", Me.colValorUnitario, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotal", Me.colValorTotal, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Custo", Me.colCusto, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtd", Me.colQtd, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comissao", Me.colComissao, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Lucro", Me.colLucro, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Margem", Me.colMargem, "{0:0.000}")})
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
        'colCod
        '
        Me.colCod.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCod.Caption = "Nº Venda"
        Me.colCod.ColumnEdit = Me.txtRetorna
        Me.colCod.FieldName = "CodOrdem"
        Me.colCod.Name = "colCod"
        Me.colCod.OptionsColumn.ReadOnly = True
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 0
        Me.colCod.Width = 67
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 105
        '
        'colCliente
        '
        Me.colCliente.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtRetorna
        Me.colCliente.FieldName = "Nome"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 173
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF"
        Me.colCPF.ColumnEdit = Me.txtRetorna
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtRetorna
        Me.colQtd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 8
        Me.colQtd.Width = 46
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.Caption = "Cód. Prod."
        Me.colCodigoProduto.ColumnEdit = Me.txtRetorna
        Me.colCodigoProduto.FieldName = "CodigoProduto"
        Me.colCodigoProduto.Name = "colCodigoProduto"
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
        Me.colProduto.Width = 184
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Vlr Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtRetorna
        Me.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colValorUnitario.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 9
        Me.colValorUnitario.Width = 74
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
        Me.colValorTotal.Width = 83
        '
        'colRealizado
        '
        Me.colRealizado.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colRealizado.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colRealizado.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colRealizado.AppearanceCell.Options.UseBackColor = True
        Me.colRealizado.Caption = "Faturado?"
        Me.colRealizado.ColumnEdit = Me.txtRetorna
        Me.colRealizado.FieldName = "Realizado"
        Me.colRealizado.Name = "colRealizado"
        Me.colRealizado.OptionsColumn.ReadOnly = True
        Me.colRealizado.Width = 71
        '
        'colTipoProduto
        '
        Me.colTipoProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTipoProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTipoProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colTipoProduto.AppearanceCell.Options.UseBackColor = True
        Me.colTipoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoProduto.Caption = "Tip. Prod."
        Me.colTipoProduto.ColumnEdit = Me.txtRetorna
        Me.colTipoProduto.FieldName = "TipoProduto"
        Me.colTipoProduto.Name = "colTipoProduto"
        Me.colTipoProduto.OptionsColumn.ReadOnly = True
        Me.colTipoProduto.Width = 69
        '
        'colCodProdInterno
        '
        Me.colCodProdInterno.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProdInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdInterno.Caption = "Código"
        Me.colCodProdInterno.ColumnEdit = Me.txtRetorna
        Me.colCodProdInterno.FieldName = "CodProdInterno"
        Me.colCodProdInterno.Name = "colCodProdInterno"
        Me.colCodProdInterno.OptionsColumn.ReadOnly = True
        Me.colCodProdInterno.Visible = True
        Me.colCodProdInterno.VisibleIndex = 6
        Me.colCodProdInterno.Width = 64
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
        Me.colCodConfig.Width = 68
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
        'colCodFunc
        '
        Me.colCodFunc.AppearanceCell.Options.UseTextOptions = True
        Me.colCodFunc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodFunc.Caption = "Vend."
        Me.colCodFunc.ColumnEdit = Me.lueFunc
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
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
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Width = 44
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.Caption = "Cód. For."
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.Width = 80
        '
        'colCusto
        '
        Me.colCusto.Caption = "Custo R$"
        Me.colCusto.DisplayFormat.FormatString = "c"
        Me.colCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCusto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status Cli."
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        '
        'colFabricante
        '
        Me.colFabricante.Caption = "Fabricante"
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        '
        'colSetor
        '
        Me.colSetor.Caption = "Setor"
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 11
        '
        'colUniSemDesc
        '
        Me.colUniSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc.Caption = "Vlr Sem Desc. R$"
        Me.colUniSemDesc.FieldName = "UniSemDesc"
        Me.colUniSemDesc.Name = "colUniSemDesc"
        Me.colUniSemDesc.OptionsColumn.ReadOnly = True
        '
        'colMarkup
        '
        Me.colMarkup.AppearanceCell.Options.UseTextOptions = True
        Me.colMarkup.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMarkup.Caption = "% Markup"
        Me.colMarkup.FieldName = "Markup"
        Me.colMarkup.Name = "colMarkup"
        Me.colMarkup.OptionsColumn.ReadOnly = True
        '
        'colFantasia
        '
        Me.colFantasia.Caption = "Fantasia"
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.OptionsColumn.ReadOnly = True
        Me.colFantasia.Width = 150
        '
        'colSAT
        '
        Me.colSAT.Caption = "SAT"
        Me.colSAT.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colSAT.FieldName = "SAT"
        Me.colSAT.Name = "colSAT"
        Me.colSAT.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colVendedor
        '
        Me.colVendedor.Caption = "Vendedor"
        Me.colVendedor.FieldName = "Vendedor"
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.OptionsColumn.ReadOnly = True
        '
        'colComissao
        '
        Me.colComissao.Caption = "Comissão"
        Me.colComissao.DisplayFormat.FormatString = "c"
        Me.colComissao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.SummaryItem.DisplayFormat = "{0:c}"
        Me.colComissao.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 13
        '
        'colLucro
        '
        Me.colLucro.Caption = "Lucro"
        Me.colLucro.DisplayFormat.FormatString = "c"
        Me.colLucro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLucro.FieldName = "Lucro"
        Me.colLucro.Name = "colLucro"
        Me.colLucro.OptionsColumn.ReadOnly = True
        Me.colLucro.SummaryItem.DisplayFormat = "{0:c}"
        Me.colLucro.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colLucro.Visible = True
        Me.colLucro.VisibleIndex = 14
        '
        'colMargem
        '
        Me.colMargem.Caption = "Margem %"
        Me.colMargem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMargem.FieldName = "Margem"
        Me.colMargem.Name = "colMargem"
        Me.colMargem.OptionsColumn.ReadOnly = True
        Me.colMargem.Visible = True
        Me.colMargem.VisibleIndex = 15
        '
        'colPlaca
        '
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.OptionsColumn.ReadOnly = True
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 3
        Me.colPlaca.Width = 80
        '
        'colModelo
        '
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.OptionsColumn.ReadOnly = True
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 4
        Me.colModelo.Width = 107
        '
        'colKM
        '
        Me.colKM.AppearanceCell.Options.UseTextOptions = True
        Me.colKM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKM.Caption = "KM"
        Me.colKM.FieldName = "KM"
        Me.colKM.Name = "colKM"
        Me.colKM.OptionsColumn.ReadOnly = True
        Me.colKM.Visible = True
        Me.colKM.VisibleIndex = 5
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Cód. Interno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        '
        'colCodPedido
        '
        Me.colCodPedido.Caption = "Cód. Pedido"
        Me.colCodPedido.FieldName = "CodPedido"
        Me.colCodPedido.Name = "colCodPedido"
        Me.colCodPedido.OptionsColumn.ReadOnly = True
        '
        'colNFe
        '
        Me.colNFe.Caption = "Nº NF-e"
        Me.colNFe.FieldName = "NFe"
        Me.colNFe.Name = "colNFe"
        Me.colNFe.OptionsColumn.ReadOnly = True
        '
        'colValorFrete
        '
        Me.colValorFrete.AppearanceCell.Options.UseTextOptions = True
        Me.colValorFrete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorFrete.Caption = "Valor Frete R$"
        Me.colValorFrete.FieldName = "ValorFrete"
        Me.colValorFrete.Name = "colValorFrete"
        Me.colValorFrete.OptionsColumn.ReadOnly = True
        Me.colValorFrete.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '
        'colComputador
        '
        Me.colComputador.Caption = "Computador"
        Me.colComputador.FieldName = "Computador"
        Me.colComputador.Name = "colComputador"
        Me.colComputador.OptionsColumn.ReadOnly = True
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 127, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 128, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.txtTotPro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotPro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotPro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotPro.Properties.ReadOnly = True
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
        Me.txtTotGer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotGer.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotGer.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Blue
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotGer.Properties.ReadOnly = True
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
        'PedidoTableAdapter
        '
        Me.PedidoTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(932, 41)
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
        Me.btnManter.Location = New System.Drawing.Point(932, 26)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'colOperador
        '
        Me.colOperador.Caption = "Caixa"
        Me.colOperador.FieldName = "Operador"
        Me.colOperador.Name = "colOperador"
        Me.colOperador.OptionsColumn.ReadOnly = True
        Me.colOperador.Visible = True
        Me.colOperador.VisibleIndex = 16
        '
        'frmConPedido
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
        Me.Name = "frmConPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.chkCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetorna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealizado As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colTipoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodProdInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtRetorna As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDevolvido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueFunc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidoTableAdapter As Nano.dsNanoCommerceTableAdapters.PedidoTableAdapter
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents chkCus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chkCusto As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelVend As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkDevol As DevExpress.XtraBars.BarEditItem
    Friend WithEvents chkDev As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUniSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLucro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMargem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNFe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorFrete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComputador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperador As DevExpress.XtraGrid.Columns.GridColumn
End Class
