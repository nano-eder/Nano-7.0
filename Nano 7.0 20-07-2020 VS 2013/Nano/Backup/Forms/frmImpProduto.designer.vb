<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpProduto
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpProduto))
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnAbrir = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidadeMedida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdEmb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkExcluir = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colValorAnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCustoAnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pb1 = New System.Windows.Forms.ProgressBar
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.rgpBoleto = New DevExpress.XtraEditors.RadioGroup
        Me.chkCusto = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.NanoCampo2 = New Campos.NanoCampo
        Me.NanoCampo1 = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExcluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.rgpBoleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(48, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 65
        Label1.Text = "Valor Venda %"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(50, 42)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(76, 13)
        Label2.TabIndex = 67
        Label2.Text = "Valor Custo %"
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 78
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.btnAbrir, Me.btnSalvar, Me.btnLimpar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAbrir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "Produtos"
        Me.BarButtonItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnAbrir
        '
        Me.btnAbrir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAbrir.Caption = "Abrir Excel"
        Me.btnAbrir.Glyph = Global.Nano.My.Resources.Resources.excel8
        Me.btnAbrir.Id = 1
        Me.btnAbrir.Name = "btnAbrir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 2
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Caption = "Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.grpItens)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 82)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 544)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Produtos Adicionados"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(951, 1)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 19)
        Me.btnPadrao.TabIndex = 109
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(898, 1)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 19)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'grpItens
        '
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.AppearanceCaption.Options.UseTextOptions = True
        Me.grpItens.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.grpItens.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.grpItens.Controls.Add(Me.picFundo)
        Me.grpItens.Controls.Add(Me.GridControl1)
        Me.grpItens.Controls.Add(Me.pb1)
        Me.grpItens.Controls.Add(Me.btnDelete)
        Me.grpItens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpItens.Location = New System.Drawing.Point(2, 20)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(1004, 522)
        Me.grpItens.TabIndex = 8
        Me.grpItens.Text = "Nº Itens : 0"
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(2, 2)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(1000, 470)
        Me.picFundo.TabIndex = 9
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkExcluir})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 470)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn2, Me.DataColumn6, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodigoInterno"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Nome"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "UnidadeMedida"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Grupo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ValorCusto"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Valor"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fabricante"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodigoBarra"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "NCM"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Peso"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "QtdEmb"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Excluir"
        Me.DataColumn13.DataType = GetType(Boolean)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Obs"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ValorCustoAnt"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ValorAnt"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Qtd"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodigoInterno, Me.colNome, Me.colUnidadeMedida, Me.colGrupo, Me.colValorCusto, Me.colValor, Me.colFabricante, Me.colCodigoBarra, Me.colObs, Me.colNCM, Me.colPeso, Me.colQtdEmb, Me.colExcluir, Me.colValorAnt, Me.colValorCustoAnt, Me.colQtd})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCodigo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = ""
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        Me.grd1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodigo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodigoInterno.Caption = "Código Interno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 2
        Me.colCodigoInterno.Width = 106
        '
        'colNome
        '
        Me.colNome.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome.AppearanceHeader.Options.UseFont = True
        Me.colNome.Caption = "Nome"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 4
        Me.colNome.Width = 351
        '
        'colUnidadeMedida
        '
        Me.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = True
        Me.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnidadeMedida.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colUnidadeMedida.AppearanceHeader.Options.UseFont = True
        Me.colUnidadeMedida.Caption = "Unidade Medida"
        Me.colUnidadeMedida.FieldName = "UnidadeMedida"
        Me.colUnidadeMedida.Name = "colUnidadeMedida"
        Me.colUnidadeMedida.OptionsColumn.ReadOnly = True
        Me.colUnidadeMedida.Visible = True
        Me.colUnidadeMedida.VisibleIndex = 7
        Me.colUnidadeMedida.Width = 112
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceCell.Options.UseTextOptions = True
        Me.colGrupo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupo.AppearanceHeader.Options.UseFont = True
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 8
        Me.colGrupo.Width = 82
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorCusto.AppearanceHeader.Options.UseFont = True
        Me.colValorCusto.Caption = "Valor Custo R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Visible = True
        Me.colValorCusto.VisibleIndex = 5
        Me.colValorCusto.Width = 104
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 6
        Me.colValor.Width = 71
        '
        'colFabricante
        '
        Me.colFabricante.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFabricante.AppearanceHeader.Options.UseFont = True
        Me.colFabricante.Caption = "Fabricante"
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        Me.colFabricante.Visible = True
        Me.colFabricante.VisibleIndex = 9
        Me.colFabricante.Width = 93
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarra.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoBarra.AppearanceHeader.Options.UseFont = True
        Me.colCodigoBarra.Caption = "Código Barra"
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.OptionsColumn.ReadOnly = True
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 3
        Me.colCodigoBarra.Width = 95
        '
        'colObs
        '
        Me.colObs.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colObs.AppearanceHeader.Options.UseFont = True
        Me.colObs.Caption = "Observação"
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 13
        Me.colObs.Width = 130
        '
        'colNCM
        '
        Me.colNCM.AppearanceCell.Options.UseTextOptions = True
        Me.colNCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNCM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNCM.AppearanceHeader.Options.UseFont = True
        Me.colNCM.Caption = "NCM"
        Me.colNCM.FieldName = "NCM"
        Me.colNCM.Name = "colNCM"
        Me.colNCM.OptionsColumn.ReadOnly = True
        Me.colNCM.Visible = True
        Me.colNCM.VisibleIndex = 10
        '
        'colPeso
        '
        Me.colPeso.AppearanceCell.Options.UseTextOptions = True
        Me.colPeso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPeso.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPeso.AppearanceHeader.Options.UseFont = True
        Me.colPeso.Caption = "Peso"
        Me.colPeso.FieldName = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.OptionsColumn.ReadOnly = True
        Me.colPeso.Visible = True
        Me.colPeso.VisibleIndex = 11
        Me.colPeso.Width = 78
        '
        'colQtdEmb
        '
        Me.colQtdEmb.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdEmb.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdEmb.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtdEmb.AppearanceHeader.Options.UseFont = True
        Me.colQtdEmb.Caption = "Qtd. Emb."
        Me.colQtdEmb.FieldName = "QtdEmb"
        Me.colQtdEmb.Name = "colQtdEmb"
        Me.colQtdEmb.OptionsColumn.ReadOnly = True
        Me.colQtdEmb.Visible = True
        Me.colQtdEmb.VisibleIndex = 12
        Me.colQtdEmb.Width = 80
        '
        'colExcluir
        '
        Me.colExcluir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colExcluir.AppearanceHeader.Options.UseFont = True
        Me.colExcluir.Caption = "Excluir"
        Me.colExcluir.ColumnEdit = Me.chkExcluir
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.Visible = True
        Me.colExcluir.VisibleIndex = 0
        Me.colExcluir.Width = 83
        '
        'chkExcluir
        '
        Me.chkExcluir.AutoHeight = False
        Me.chkExcluir.Name = "chkExcluir"
        '
        'colValorAnt
        '
        Me.colValorAnt.Caption = "Valor Ant. R$"
        Me.colValorAnt.FieldName = "ValorAnt"
        Me.colValorAnt.Name = "colValorAnt"
        '
        'colValorCustoAnt
        '
        Me.colValorCustoAnt.Caption = "Valor Custo Ant. R$"
        Me.colValorCustoAnt.FieldName = "ValorCustoAnt"
        Me.colValorCustoAnt.Name = "colValorCustoAnt"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.Caption = "Quantidade"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(3, 496)
        Me.pb1.Maximum = 320
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(999, 23)
        Me.pb1.TabIndex = 11
        Me.pb1.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(2, 472)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(1000, 21)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Dados do Produtos"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.rgpBoleto)
        Me.PanelControl1.Controls.Add(Me.chkCusto)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(407, 66)
        Me.PanelControl1.TabIndex = 11
        '
        'rgpBoleto
        '
        Me.rgpBoleto.Location = New System.Drawing.Point(88, 11)
        Me.rgpBoleto.Name = "rgpBoleto"
        Me.rgpBoleto.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Código Interno"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Código Barra"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Nome Produto")})
        Me.rgpBoleto.Size = New System.Drawing.Size(302, 20)
        Me.rgpBoleto.TabIndex = 14
        '
        'chkCusto
        '
        Me.chkCusto.Location = New System.Drawing.Point(22, 37)
        Me.chkCusto.Name = "chkCusto"
        Me.chkCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCusto.Properties.Appearance.Options.UseFont = True
        Me.chkCusto.Properties.Caption = " Carregar Quantidade"
        Me.chkCusto.Size = New System.Drawing.Size(149, 19)
        Me.chkCusto.TabIndex = 175
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(24, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Verificar por"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.NanoCampo2)
        Me.PanelControl2.Controls.Add(Label2)
        Me.PanelControl2.Controls.Add(Me.NanoCampo1)
        Me.PanelControl2.Controls.Add(Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(418, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(259, 66)
        Me.PanelControl2.TabIndex = 13
        '
        'NanoCampo2
        '
        Me.NanoCampo2.CasasDecimais = 3
        Me.NanoCampo2.EnterMoveNextControl = True
        Me.NanoCampo2.Location = New System.Drawing.Point(132, 39)
        Me.NanoCampo2.Name = "NanoCampo2"
        Me.NanoCampo2.Numerico = True
        Me.NanoCampo2.Size = New System.Drawing.Size(110, 20)
        Me.NanoCampo2.TabIndex = 66
        Me.NanoCampo2.Tag = "Qtd"
        '
        'NanoCampo1
        '
        Me.NanoCampo1.CasasDecimais = 3
        Me.NanoCampo1.EnterMoveNextControl = True
        Me.NanoCampo1.Location = New System.Drawing.Point(132, 13)
        Me.NanoCampo1.Name = "NanoCampo1"
        Me.NanoCampo1.Numerico = True
        Me.NanoCampo1.Size = New System.Drawing.Size(110, 20)
        Me.NanoCampo1.TabIndex = 64
        Me.NanoCampo1.Tag = "Qtd"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(429, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl2.TabIndex = 176
        Me.LabelControl2.Text = "Valores do Produtos"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(566, 4)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = " Diminuir Valor"
        Me.CheckEdit1.Size = New System.Drawing.Size(105, 19)
        Me.CheckEdit1.TabIndex = 177
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(683, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 26)
        Me.btnAdd.TabIndex = 178
        Me.btnAdd.Text = "&Calcular"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.SimpleButton1.Location = New System.Drawing.Point(683, 47)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 26)
        Me.SimpleButton1.TabIndex = 179
        Me.SimpleButton1.Text = "&Calcular"
        '
        'frmImpProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmImpProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Produto"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExcluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.rgpBoleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAbrir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dsProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rgpBoleto As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadeMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdEmb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NanoCampo1 As Campos.NanoCampo
    Friend WithEvents NanoCampo2 As Campos.NanoCampo
    Friend WithEvents colValorAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorCustoAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents chkCusto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkExcluir As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
