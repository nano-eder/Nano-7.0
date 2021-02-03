<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConInventario))
        Me.colQtdInventario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiferenca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtData = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualiazar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodProdAut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoItem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colQtdInventario
        '
        Me.colQtdInventario.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtdInventario.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colQtdInventario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtdInventario.AppearanceCell.Options.UseFont = True
        Me.colQtdInventario.AppearanceCell.Options.UseForeColor = True
        Me.colQtdInventario.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdInventario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdInventario.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtdInventario.AppearanceHeader.Options.UseFont = True
        Me.colQtdInventario.Caption = "Qtd Inventário"
        Me.colQtdInventario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtdInventario.FieldName = "QtdInventario"
        Me.colQtdInventario.Name = "colQtdInventario"
        Me.colQtdInventario.OptionsColumn.ReadOnly = True
        Me.colQtdInventario.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtdInventario.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtdInventario.Visible = True
        Me.colQtdInventario.VisibleIndex = 3
        Me.colQtdInventario.Width = 108
        '
        'colDiferenca
        '
        Me.colDiferenca.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferenca.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colDiferenca.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDiferenca.AppearanceCell.Options.UseFont = True
        Me.colDiferenca.AppearanceCell.Options.UseForeColor = True
        Me.colDiferenca.AppearanceCell.Options.UseTextOptions = True
        Me.colDiferenca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDiferenca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDiferenca.AppearanceHeader.Options.UseFont = True
        Me.colDiferenca.Caption = "Diferença"
        Me.colDiferenca.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiferenca.FieldName = "Diferenca"
        Me.colDiferenca.Name = "colDiferenca"
        Me.colDiferenca.OptionsColumn.ReadOnly = True
        Me.colDiferenca.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colDiferenca.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDiferenca.Visible = True
        Me.colDiferenca.VisibleIndex = 4
        Me.colDiferenca.Width = 85
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.dtData, Me.btnFiltrar, Me.btnVisualiazar, Me.BarSubItem1, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtData, "", False, True, True, 103, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtData
        '
        Me.dtData.Caption = "Data"
        Me.dtData.Edit = Me.RepositoryItemDateEdit1
        Me.dtData.Id = 1
        Me.dtData.Name = "dtData"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
        Me.BarSubItem1.Id = 4
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualiazar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualiazar
        '
        Me.btnVisualiazar.Caption = "&Relatório de Inventário"
        Me.btnVisualiazar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualiazar.Id = 3
        Me.btnVisualiazar.Name = "btnVisualiazar"
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
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
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
        Me.GroupControl1.TabIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbItens"
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1004, 589)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView1})
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProdAut, Me.colCodProd, Me.colCodigoItem, Me.colProduto, Me.colQtde, Me.colData, Me.colTipo, Me.colQtdInventario, Me.colDiferenca})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colQtdInventario
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtdAntiga", Me.colQtde, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QtdInventario", Me.colQtdInventario, "{0:0.000}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diferenca", Me.colDiferenca, "{0:0.000}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsNavigation.AutoFocusNewRow = True
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodProdAut
        '
        Me.colCodProdAut.Caption = "CodProdAut"
        Me.colCodProdAut.FieldName = "CodProdAut"
        Me.colCodProdAut.Name = "colCodProdAut"
        Me.colCodProdAut.OptionsColumn.ReadOnly = True
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProd.AppearanceCell.Options.UseFont = True
        Me.colCodProd.AppearanceCell.Options.UseForeColor = True
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceHeader.Options.UseFont = True
        Me.colCodProd.Caption = "Código"
        Me.colCodProd.FieldName = "CodigoInterno"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Visible = True
        Me.colCodProd.VisibleIndex = 0
        Me.colCodProd.Width = 80
        '
        'colCodigoItem
        '
        Me.colCodigoItem.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoItem.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colCodigoItem.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoItem.AppearanceCell.Options.UseFont = True
        Me.colCodigoItem.AppearanceCell.Options.UseForeColor = True
        Me.colCodigoItem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoItem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoItem.AppearanceHeader.Options.UseFont = True
        Me.colCodigoItem.Caption = "Loja"
        Me.colCodigoItem.FieldName = "CodConfig"
        Me.colCodigoItem.Name = "colCodigoItem"
        Me.colCodigoItem.OptionsColumn.ReadOnly = True
        Me.colCodigoItem.Visible = True
        Me.colCodigoItem.VisibleIndex = 6
        Me.colCodigoItem.Width = 95
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.AppearanceCell.Options.UseFont = True
        Me.colProduto.AppearanceCell.Options.UseForeColor = True
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 337
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtde.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colQtde.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtde.AppearanceCell.Options.UseFont = True
        Me.colQtde.AppearanceCell.Options.UseForeColor = True
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtde.AppearanceHeader.Options.UseFont = True
        Me.colQtde.Caption = "Qtde Estoque"
        Me.colQtde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtde.FieldName = "QtdAntiga"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.OptionsColumn.ReadOnly = True
        Me.colQtde.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colQtde.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 2
        Me.colQtde.Width = 87
        '
        'colData
        '
        Me.colData.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colData.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colData.AppearanceCell.Options.UseFont = True
        Me.colData.AppearanceCell.Options.UseForeColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 5
        Me.colData.Width = 89
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colTipo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colTipo.AppearanceCell.Options.UseFont = True
        Me.colTipo.AppearanceCell.Options.UseForeColor = True
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipo.AppearanceHeader.Options.UseFont = True
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Width = 102
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProdAut, Me.colCodProd, Me.colProduto, Me.colQtde})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'frmConInventario
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
        Me.Name = "frmConInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Inventário"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodProdAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtData As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualiazar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colQtdInventario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferenca As DevExpress.XtraGrid.Columns.GridColumn
End Class
