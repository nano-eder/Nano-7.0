<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescarte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescarte))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtTotal = New Campos.NanoCampo
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUni = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.lueFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtTamanho = New Campos.NanoCampo
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtMotivo = New Campos.NanoCampo
        Me.btnAdicionar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtQtde = New Campos.NanoCampo
        Me.txtProd = New Campos.NanoCampo
        Me.txtValor = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodProd = New DevExpress.XtraEditors.ButtonEdit
        Me.chkTamanho = New DevExpress.XtraEditors.CheckEdit
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 111)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 517)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Itens Descartados"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(940, 2)
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
        Me.btnManter.Location = New System.Drawing.Point(886, 2)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.txtTotal)
        Me.GroupControl2.Controls.Add(Me.LabelControl20)
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1004, 495)
        Me.GroupControl2.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.CasasDecimais = 2
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(810, 464)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Numerico = True
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtTotal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtTotal.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Size = New System.Drawing.Size(185, 29)
        Me.txtTotal.TabIndex = 90
        '
        'LabelControl20
        '
        Me.LabelControl20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(693, 471)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl20.TabIndex = 89
        Me.LabelControl20.Text = "Valor Total R$"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 458)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtde"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ValorUni"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ValorTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ValorCusto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Tamanho"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Motivo"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "UM"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodProdInterno"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colProduto, Me.colQtde, Me.colValorUni, Me.colValorTotal, Me.colValorCusto, Me.colTamanho, Me.colMotivo, Me.colUM, Me.colCodProdInterno})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 80
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 196
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtde.Caption = "Qtde"
        Me.colQtde.ColumnEdit = Me.txtAlterar
        Me.colQtde.FieldName = "Qtde"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.OptionsColumn.ReadOnly = True
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 4
        '
        'colValorUni
        '
        Me.colValorUni.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUni.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUni.Caption = "Valor Uni. R$"
        Me.colValorUni.ColumnEdit = Me.txtAlterar
        Me.colValorUni.FieldName = "ValorUni"
        Me.colValorUni.Name = "colValorUni"
        Me.colValorUni.OptionsColumn.ReadOnly = True
        Me.colValorUni.Visible = True
        Me.colValorUni.VisibleIndex = 5
        Me.colValorUni.Width = 102
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlterar
        Me.colValorTotal.DisplayFormat.FormatString = "c"
        Me.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 6
        Me.colValorTotal.Width = 102
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Valor Custo R$"
        Me.colValorCusto.ColumnEdit = Me.txtAlterar
        Me.colValorCusto.DisplayFormat.FormatString = "c"
        Me.colValorCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.SummaryItem.DisplayFormat = "{0:0.000}"
        Me.colValorCusto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorCusto.Visible = True
        Me.colValorCusto.VisibleIndex = 7
        Me.colValorCusto.Width = 102
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.ColumnEdit = Me.txtAlterar
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 2
        Me.colTamanho.Width = 64
        '
        'colMotivo
        '
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.ColumnEdit = Me.txtAlterar
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.OptionsColumn.ReadOnly = True
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 8
        Me.colMotivo.Width = 202
        '
        'colUM
        '
        Me.colUM.Caption = "UM"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.ReadOnly = True
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 3
        Me.colUM.Width = 40
        '
        'colCodProdInterno
        '
        Me.colCodProdInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdInterno.Caption = "Cód. Prod."
        Me.colCodProdInterno.FieldName = "CodProdInterno"
        Me.colCodProdInterno.Name = "colCodProdInterno"
        Me.colCodProdInterno.Visible = True
        Me.colCodProdInterno.VisibleIndex = 0
        Me.colCodProdInterno.Width = 96
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnLimpar, Me.btnSalvar, Me.btnExcluir})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 3
        Me.btnExcluir.Name = "btnExcluir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 2
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 1
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(73, 12)
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueFunc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.lueFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.Properties.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc.Properties.DisplayMember = "Nome"
        Me.lueFunc.Properties.NullText = ""
        Me.lueFunc.Properties.PopupWidth = 90
        Me.lueFunc.Properties.ValueMember = "Nome"
        Me.lueFunc.Size = New System.Drawing.Size(458, 20)
        Me.lueFunc.TabIndex = 0
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
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Funcionário"
        '
        'txtTamanho
        '
        Me.txtTamanho.CasasDecimais = 0
        Me.txtTamanho.EnterMoveNextControl = True
        Me.txtTamanho.Location = New System.Drawing.Point(567, 84)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Numerico = False
        Me.txtTamanho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTamanho.Size = New System.Drawing.Size(66, 20)
        Me.txtTamanho.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(537, 87)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 100
        Me.LabelControl12.Text = "Tam."
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(35, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 99
        Me.LabelControl10.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.CasasDecimais = 0
        Me.txtMotivo.EnterMoveNextControl = True
        Me.txtMotivo.Location = New System.Drawing.Point(73, 58)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Numerico = False
        Me.txtMotivo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMotivo.Size = New System.Drawing.Size(458, 20)
        Me.txtMotivo.TabIndex = 1
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdicionar.Location = New System.Drawing.Point(919, 82)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 6
        Me.btnAdicionar.Text = "Adicionar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(28, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 98
        Me.LabelControl3.Text = "Dados do Produto"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(7, 44)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(990, 5)
        Me.PanelControl2.TabIndex = 97
        '
        'txtQtde
        '
        Me.txtQtde.CasasDecimais = 3
        Me.txtQtde.EnterMoveNextControl = True
        Me.txtQtde.Location = New System.Drawing.Point(669, 84)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Numerico = False
        Me.txtQtde.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtde.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtde.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtde.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtQtde.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtde.Size = New System.Drawing.Size(63, 20)
        Me.txtQtde.TabIndex = 4
        '
        'txtProd
        '
        Me.txtProd.CasasDecimais = 0
        Me.txtProd.EnterMoveNextControl = True
        Me.txtProd.Location = New System.Drawing.Point(234, 84)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Numerico = False
        Me.txtProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProd.Size = New System.Drawing.Size(297, 20)
        Me.txtProd.TabIndex = 7
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(806, 84)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(34, 87)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl9.TabIndex = 96
        Me.LabelControl9.Text = "Código"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(190, 87)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 95
        Me.LabelControl8.Text = "Produto"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(639, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 93
        Me.LabelControl7.Text = "Qtde"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(738, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl6.TabIndex = 90
        Me.LabelControl6.Text = "Valor Uni. R$"
        '
        'txtCodProd
        '
        Me.txtCodProd.EnterMoveNextControl = True
        Me.txtCodProd.Location = New System.Drawing.Point(73, 84)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodProd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodProd.Size = New System.Drawing.Size(97, 20)
        Me.txtCodProd.TabIndex = 2
        '
        'chkTamanho
        '
        Me.chkTamanho.Location = New System.Drawing.Point(615, 85)
        Me.chkTamanho.Name = "chkTamanho"
        Me.chkTamanho.Properties.Caption = ""
        Me.chkTamanho.Size = New System.Drawing.Size(17, 19)
        Me.chkTamanho.TabIndex = 101
        Me.chkTamanho.ToolTip = "Clique para adicionar um tamanho diferente de U"
        Me.chkTamanho.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkTamanho.ToolTipTitle = "Tamanho do Produto"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'frmDescarte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.chkTamanho)
        Me.Controls.Add(Me.txtTamanho)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmDescarte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descarte"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTamanho As Campos.NanoCampo
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivo As Campos.NanoCampo
    Friend WithEvents btnAdicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtQtde As Campos.NanoCampo
    Friend WithEvents txtProd As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodProd As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTotal As Campos.NanoCampo
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkTamanho As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCodProdInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
End Class
