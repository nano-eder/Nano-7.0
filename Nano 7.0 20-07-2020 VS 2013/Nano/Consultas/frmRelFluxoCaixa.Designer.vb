<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelFluxoCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelFluxoCaixa))
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.lueLoja = New DevExpress.XtraBars.BarEditItem
        Me.lueLojas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.cboAno = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.cboMes = New DevExpress.XtraBars.BarEditItem
        Me.cboMeses = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelFluxo = New DevExpress.XtraBars.BarButtonItem
        Me.btnCus = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.dsFluxo = New System.Data.DataSet
        Me.tbFluxo = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCartao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldoAtual = New Campos.NanoCampo
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldo = New Campos.NanoCampo
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldos = New Campos.NanoCampo
        Me.BancoTableAdapter = New Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.cboBanco = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLojas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsFluxo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFluxo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSaldoAtual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colSaldo
        '
        Me.colSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaldo.Caption = "Saldo Dia R$"
        Me.colSaldo.DisplayFormat.FormatString = "c"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSaldo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 215
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cboMes, Me.btnFechar, Me.cboAno, Me.bsiVisu, Me.btnRelFluxo, Me.btnCus, Me.lueLoja, Me.dtInicial, Me.dtFinal, Me.btnFiltrar})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboMeses, Me.RepositoryItemComboBox2, Me.lueLojas, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.lueLoja, "", False, True, True, 148, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboAno, "", True, True, True, 20, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboMes, "", True, True, True, 20, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 107, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 113, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'lueLoja
        '
        Me.lueLoja.Caption = "Loja"
        Me.lueLoja.Edit = Me.lueLojas
        Me.lueLoja.Id = 8
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'lueLojas
        '
        Me.lueLojas.AutoHeight = False
        Me.lueLojas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLojas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Loja", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLojas.DataSource = Me.ConfigBindingSource
        Me.lueLojas.DisplayMember = "Descricao"
        Me.lueLojas.Name = "lueLojas"
        Me.lueLojas.NullText = ""
        Me.lueLojas.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerceBindingSource
        '
        'DsNanoCommerceBindingSource
        '
        Me.DsNanoCommerceBindingSource.DataSource = Me.DsNanoCommerce
        Me.DsNanoCommerceBindingSource.Position = 0
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboAno
        '
        Me.cboAno.Caption = "Ano"
        Me.cboAno.Edit = Me.RepositoryItemComboBox2
        Me.cboAno.Id = 4
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'cboMes
        '
        Me.cboMes.Caption = "Mês"
        Me.cboMes.Edit = Me.cboMeses
        Me.cboMes.Id = 0
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cboMeses
        '
        Me.cboMeses.AutoHeight = False
        Me.cboMeses.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMeses.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cboMeses.Name = "cboMeses"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 9
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
        Me.dtFinal.Id = 10
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
        Me.btnFiltrar.Id = 11
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 5
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelFluxo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCus)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelFluxo
        '
        Me.btnRelFluxo.Caption = "Relatório de Fluxo de Caixa"
        Me.btnRelFluxo.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelFluxo.Id = 6
        Me.btnRelFluxo.Name = "btnRelFluxo"
        '
        'btnCus
        '
        Me.btnCus.Caption = "Relatório Customizado"
        Me.btnCus.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnCus.Id = 7
        Me.btnCus.Name = "btnCus"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'Grid1
        '
        Me.Grid1.DataMember = "tbFluxo"
        Me.Grid1.DataSource = Me.dsFluxo
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 2)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1004, 576)
        Me.Grid1.TabIndex = 4
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsFluxo
        '
        Me.dsFluxo.DataSetName = "Fluxo"
        Me.dsFluxo.Tables.AddRange(New System.Data.DataTable() {Me.tbFluxo})
        '
        'tbFluxo
        '
        Me.tbFluxo.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbFluxo.TableName = "tbFluxo"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Dia"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Cartão"
        Me.DataColumn2.ColumnName = "Cartao"
        Me.DataColumn2.DataType = GetType(Double)
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Conta Receber"
        Me.DataColumn3.ColumnName = "Receber"
        Me.DataColumn3.DataType = GetType(Double)
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Conta Pagar"
        Me.DataColumn4.ColumnName = "Pagar"
        Me.DataColumn4.DataType = GetType(Double)
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Saldo Dia"
        Me.DataColumn5.ColumnName = "Saldo"
        Me.DataColumn5.DataType = GetType(Double)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Data"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Tipo"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDia, Me.colCartao, Me.colReceber, Me.colPagar, Me.colSaldo, Me.colData, Me.colTipo})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lavender
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colSaldo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.MistyRose
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colSaldo
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = 0
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colDia
        '
        Me.colDia.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDia.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDia.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDia.AppearanceCell.Options.UseBackColor = True
        Me.colDia.AppearanceCell.Options.UseTextOptions = True
        Me.colDia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDia.Caption = "Dia"
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.Width = 85
        '
        'colCartao
        '
        Me.colCartao.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.colCartao.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCartao.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCartao.AppearanceCell.Options.UseBackColor = True
        Me.colCartao.AppearanceCell.Options.UseTextOptions = True
        Me.colCartao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCartao.Caption = "Cartão R$"
        Me.colCartao.DisplayFormat.FormatString = "c"
        Me.colCartao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCartao.FieldName = "Cartao"
        Me.colCartao.Name = "colCartao"
        Me.colCartao.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCartao.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCartao.Visible = True
        Me.colCartao.VisibleIndex = 1
        Me.colCartao.Width = 222
        '
        'colReceber
        '
        Me.colReceber.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.colReceber.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colReceber.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colReceber.AppearanceCell.Options.UseBackColor = True
        Me.colReceber.AppearanceCell.Options.UseTextOptions = True
        Me.colReceber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colReceber.Caption = "Conta Receber R$"
        Me.colReceber.DisplayFormat.FormatString = "c"
        Me.colReceber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReceber.FieldName = "Receber"
        Me.colReceber.Name = "colReceber"
        Me.colReceber.SummaryItem.DisplayFormat = "{0:c}"
        Me.colReceber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colReceber.Visible = True
        Me.colReceber.VisibleIndex = 2
        Me.colReceber.Width = 222
        '
        'colPagar
        '
        Me.colPagar.AppearanceCell.BackColor = System.Drawing.Color.MistyRose
        Me.colPagar.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPagar.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colPagar.AppearanceCell.Options.UseBackColor = True
        Me.colPagar.AppearanceCell.Options.UseTextOptions = True
        Me.colPagar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPagar.Caption = "Conta Pagar R$"
        Me.colPagar.DisplayFormat.FormatString = "c"
        Me.colPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPagar.FieldName = "Pagar"
        Me.colPagar.Name = "colPagar"
        Me.colPagar.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPagar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPagar.Visible = True
        Me.colPagar.VisibleIndex = 3
        Me.colPagar.Width = 222
        '
        'colData
        '
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colData.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colData.AppearanceCell.Options.UseBackColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 102
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.cboBanco)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtSaldoAtual)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtSaldo)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtSaldos)
        Me.GroupControl1.Controls.Add(Me.Grid1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 646)
        Me.GroupControl1.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(611, 618)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(156, 18)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Saldo Atual Caixa R$"
        '
        'txtSaldoAtual
        '
        Me.txtSaldoAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoAtual.CasasDecimais = 2
        Me.txtSaldoAtual.Location = New System.Drawing.Point(773, 614)
        Me.txtSaldoAtual.Name = "txtSaldoAtual"
        Me.txtSaldoAtual.Numerico = True
        Me.txtSaldoAtual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoAtual.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoAtual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoAtual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoAtual.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSaldoAtual.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoAtual.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldoAtual.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldoAtual.Properties.ReadOnly = True
        Me.txtSaldoAtual.Size = New System.Drawing.Size(221, 26)
        Me.txtSaldoAtual.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(373, 588)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(12, 18)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "="
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.CasasDecimais = 2
        Me.txtSaldo.Location = New System.Drawing.Point(391, 584)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Numerico = True
        Me.txtSaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.Properties.Appearance.Options.UseFont = True
        Me.txtSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSaldo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldo.Properties.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(221, 26)
        Me.txtSaldo.TabIndex = 9
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataMember = "Banco"
        Me.BancoBindingSource.DataSource = Me.DsNanoCommerceBindingSource
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(61, 588)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 18)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Saldo Banco"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(643, 588)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 18)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Saldo Bancos R$"
        '
        'txtSaldos
        '
        Me.txtSaldos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldos.CasasDecimais = 2
        Me.txtSaldos.Location = New System.Drawing.Point(773, 584)
        Me.txtSaldos.Name = "txtSaldos"
        Me.txtSaldos.Numerico = True
        Me.txtSaldos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldos.Properties.Appearance.Options.UseFont = True
        Me.txtSaldos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSaldos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSaldos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldos.Properties.ReadOnly = True
        Me.txtSaldos.Size = New System.Drawing.Size(221, 26)
        Me.txtSaldos.TabIndex = 5
        '
        'BancoTableAdapter
        '
        Me.BancoTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'cboBanco
        '
        Me.cboBanco.EditValue = "Selecione o Banco"
        Me.cboBanco.Location = New System.Drawing.Point(158, 584)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboBanco.Properties.Appearance.Options.UseFont = True
        Me.cboBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBanco.Size = New System.Drawing.Size(209, 26)
        Me.cboBanco.TabIndex = 16
        '
        'frmRelFluxoCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 682)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRelFluxoCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Fluxo de Caixa"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLojas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsFluxo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFluxo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtSaldoAtual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsFluxo As System.Data.DataSet
    Friend WithEvents tbFluxo As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents cboMes As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboMeses As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboAno As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelFluxo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldos As Campos.NanoCampo
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldo As Campos.NanoCampo
    Friend WithEvents DsNanoCommerceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoTableAdapter As Nano.dsNanoCommerceTableAdapters.BancoTableAdapter
    Friend WithEvents lueLoja As DevExpress.XtraBars.BarEditItem
    Friend WithEvents lueLojas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoAtual As Campos.NanoCampo
    Friend WithEvents cboBanco As DevExpress.XtraEditors.ComboBoxEdit
End Class
