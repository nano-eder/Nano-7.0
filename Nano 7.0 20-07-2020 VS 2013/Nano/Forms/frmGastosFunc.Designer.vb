<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosFunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastosFunc))
        Me.txtValor = New Campos.NanoCampo
        Me.txtMotivo = New Campos.NanoCampo
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblVenc = New DevExpress.XtraEditors.LabelControl
        Me.lueFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.lueFuncionario = New DevExpress.XtraBars.BarEditItem
        Me.lueFunc2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsGasto = New System.Data.DataSet
        Me.tbGasto = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtTotalGeral = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnCalc = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtValorTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtCred = New DevExpress.XtraEditors.TextEdit
        Me.txtComissaoVend = New DevExpress.XtraEditors.TextEdit
        Me.txtSaldo = New DevExpress.XtraEditors.TextEdit
        Me.txtDeb = New DevExpress.XtraEditors.TextEdit
        Me.lblTotalComissao = New DevExpress.XtraEditors.LabelControl
        Me.lblDebito = New DevExpress.XtraEditors.LabelControl
        Me.lblValorTotal = New DevExpress.XtraEditors.LabelControl
        Me.lblTotalSaldo = New DevExpress.XtraEditors.LabelControl
        Me.lblCredito = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncionario1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissaoFunc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissaoEsc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.lblNumPar = New System.Windows.Forms.Label
        Me.seParcela = New DevExpress.XtraEditors.SpinEdit
        Me.lblDias = New System.Windows.Forms.Label
        Me.txtDias = New DevExpress.XtraEditors.SpinEdit
        Me.btnRelCustomizado = New DevExpress.XtraBars.BarButtonItem
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTotalGeral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComissaoVend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(259, 38)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Size = New System.Drawing.Size(109, 20)
        Me.txtValor.TabIndex = 4
        Me.txtValor.Tag = "Valor R$"
        '
        'txtMotivo
        '
        Me.txtMotivo.CasasDecimais = 0
        Me.txtMotivo.EnterMoveNextControl = True
        Me.txtMotivo.Location = New System.Drawing.Point(438, 12)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Numerico = False
        Me.txtMotivo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMotivo.Properties.MaxLength = 255
        Me.txtMotivo.Size = New System.Drawing.Size(302, 20)
        Me.txtMotivo.TabIndex = 1
        Me.txtMotivo.Tag = "Número"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(213, 42)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Valor R$"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(37, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 18
        Me.LabelControl3.Text = "Data"
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(66, 38)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtData.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(109, 20)
        Me.dtData.TabIndex = 3
        Me.dtData.Tag = "Data"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(762, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Crédito/Débito"
        '
        'cboTipo
        '
        Me.cboTipo.EnterMoveNextControl = True
        Me.cboTipo.Location = New System.Drawing.Point(838, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Properties.Items.AddRange(New Object() {"C", "D"})
        Me.cboTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipo.Size = New System.Drawing.Size(109, 20)
        Me.cboTipo.TabIndex = 2
        Me.cboTipo.Tag = "Crédito/Débito"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(400, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Motivo"
        '
        'lblVenc
        '
        Me.lblVenc.Location = New System.Drawing.Point(5, 15)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(55, 13)
        Me.lblVenc.TabIndex = 91
        Me.lblVenc.Text = "Funcionário"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(66, 12)
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.lueFunc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.lueFunc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueFunc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lueFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.Properties.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc.Properties.DisplayMember = "Nome"
        Me.lueFunc.Properties.NullText = ""
        Me.lueFunc.Properties.ValueMember = "Codigo"
        Me.lueFunc.Size = New System.Drawing.Size(302, 20)
        Me.lueFunc.TabIndex = 0
        Me.lueFunc.Tag = "Vendedor"
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
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(838, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 21)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Adicionar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.BarSubItem1, Me.btnFechar, Me.btnVisualizar, Me.btnRelCust, Me.lueFuncionario, Me.btnRelCustomizado})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.lueFunc2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 104, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 100, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.lueFuncionario, "", True, True, True, 192, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
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
        'lueFuncionario
        '
        Me.lueFuncionario.Caption = "Vendedor"
        Me.lueFuncionario.Edit = Me.lueFunc2
        Me.lueFuncionario.Id = 9
        Me.lueFuncionario.Name = "lueFuncionario"
        '
        'lueFunc2
        '
        Me.lueFunc2.AutoHeight = False
        Me.lueFunc2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc2.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc2.DisplayMember = "Nome"
        Me.lueFunc2.Name = "lueFunc2"
        Me.lueFunc2.NullText = ""
        Me.lueFunc2.ValueMember = "Codigo"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 3
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 4
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCustomizado)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Gastos com Funcioários"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 6
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 8
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 5
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbGasto"
        Me.GridControl1.DataSource = Me.dsGasto
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(959, 135)
        Me.GridControl1.TabIndex = 96
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsGasto
        '
        Me.dsGasto.DataSetName = "NewDataSet"
        Me.dsGasto.Tables.AddRange(New System.Data.DataTable() {Me.tbGasto})
        '
        'tbGasto
        '
        Me.tbGasto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbGasto.TableName = "tbGasto"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodFunc"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Funcionario"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Tipo"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Valor"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Motivo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Data"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodFunc, Me.colFuncionario, Me.colTipo, Me.colValor, Me.colMotivo, Me.colData})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodFunc
        '
        Me.colCodFunc.Caption = "CodFunc"
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
        Me.colCodFunc.OptionsColumn.ReadOnly = True
        '
        'colFuncionario
        '
        Me.colFuncionario.Caption = "Vendedor"
        Me.colFuncionario.FieldName = "Funcionario"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.OptionsColumn.ReadOnly = True
        Me.colFuncionario.Visible = True
        Me.colFuncionario.VisibleIndex = 1
        Me.colFuncionario.Width = 295
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
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 70
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 104
        '
        'colMotivo
        '
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.OptionsColumn.ReadOnly = True
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 3
        Me.colMotivo.Width = 364
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
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 105
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 36.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.txtTotalGeral)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.btnCalc)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.txtValorTotal)
        Me.GroupControl1.Controls.Add(Me.txtCred)
        Me.GroupControl1.Controls.Add(Me.txtComissaoVend)
        Me.GroupControl1.Controls.Add(Me.txtSaldo)
        Me.GroupControl1.Controls.Add(Me.txtDeb)
        Me.GroupControl1.Controls.Add(Me.lblTotalComissao)
        Me.GroupControl1.Controls.Add(Me.lblDebito)
        Me.GroupControl1.Controls.Add(Me.lblValorTotal)
        Me.GroupControl1.Controls.Add(Me.lblTotalSaldo)
        Me.GroupControl1.Controls.Add(Me.lblCredito)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 65)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(967, 561)
        Me.GroupControl1.TabIndex = 97
        '
        'txtTotalGeral
        '
        Me.txtTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGeral.EnterMoveNextControl = True
        Me.txtTotalGeral.Location = New System.Drawing.Point(811, 504)
        Me.txtTotalGeral.Name = "txtTotalGeral"
        Me.txtTotalGeral.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGeral.Properties.Appearance.Options.UseFont = True
        Me.txtTotalGeral.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalGeral.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalGeral.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotalGeral.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalGeral.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalGeral.Properties.ReadOnly = True
        Me.txtTotalGeral.Size = New System.Drawing.Size(146, 21)
        Me.txtTotalGeral.TabIndex = 105
        Me.txtTotalGeral.Tag = "Valor R$"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(725, 508)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 104
        Me.LabelControl4.Text = "Total Geral R$"
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalc.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalc.Location = New System.Drawing.Point(66, 527)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(93, 27)
        Me.btnCalc.TabIndex = 97
        Me.btnCalc.Text = "&Calcular"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 340)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(963, 157)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Gastos Cadastrados"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.EnterMoveNextControl = True
        Me.txtValorTotal.Location = New System.Drawing.Point(279, 504)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Properties.Appearance.Options.UseFont = True
        Me.txtValorTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValorTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorTotal.Properties.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(146, 21)
        Me.txtValorTotal.TabIndex = 96
        Me.txtValorTotal.Tag = "Valor R$"
        '
        'txtCred
        '
        Me.txtCred.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCred.EnterMoveNextControl = True
        Me.txtCred.Location = New System.Drawing.Point(279, 531)
        Me.txtCred.Name = "txtCred"
        Me.txtCred.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCred.Properties.Appearance.Options.UseFont = True
        Me.txtCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCred.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCred.Properties.ReadOnly = True
        Me.txtCred.Size = New System.Drawing.Size(146, 21)
        Me.txtCred.TabIndex = 102
        Me.txtCred.Tag = "Valor R$"
        '
        'txtComissaoVend
        '
        Me.txtComissaoVend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComissaoVend.EnterMoveNextControl = True
        Me.txtComissaoVend.Location = New System.Drawing.Point(548, 504)
        Me.txtComissaoVend.Name = "txtComissaoVend"
        Me.txtComissaoVend.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComissaoVend.Properties.Appearance.Options.UseFont = True
        Me.txtComissaoVend.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComissaoVend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComissaoVend.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComissaoVend.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComissaoVend.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComissaoVend.Properties.ReadOnly = True
        Me.txtComissaoVend.Size = New System.Drawing.Size(146, 21)
        Me.txtComissaoVend.TabIndex = 95
        Me.txtComissaoVend.Tag = "Valor R$"
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.EnterMoveNextControl = True
        Me.txtSaldo.Location = New System.Drawing.Point(811, 531)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Properties.Appearance.Options.UseFont = True
        Me.txtSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.Properties.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(146, 21)
        Me.txtSaldo.TabIndex = 96
        Me.txtSaldo.Tag = "Valor R$"
        '
        'txtDeb
        '
        Me.txtDeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeb.EnterMoveNextControl = True
        Me.txtDeb.Location = New System.Drawing.Point(548, 531)
        Me.txtDeb.Name = "txtDeb"
        Me.txtDeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.Properties.Appearance.Options.UseFont = True
        Me.txtDeb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDeb.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDeb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeb.Properties.ReadOnly = True
        Me.txtDeb.Size = New System.Drawing.Size(146, 21)
        Me.txtDeb.TabIndex = 101
        Me.txtDeb.Tag = "Valor R$"
        '
        'lblTotalComissao
        '
        Me.lblTotalComissao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalComissao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalComissao.Appearance.Options.UseFont = True
        Me.lblTotalComissao.Location = New System.Drawing.Point(438, 508)
        Me.lblTotalComissao.Name = "lblTotalComissao"
        Me.lblTotalComissao.Size = New System.Drawing.Size(104, 13)
        Me.lblTotalComissao.TabIndex = 92
        Me.lblTotalComissao.Text = "Total Comissão R$"
        '
        'lblDebito
        '
        Me.lblDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDebito.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebito.Appearance.Options.UseFont = True
        Me.lblDebito.Location = New System.Drawing.Point(455, 535)
        Me.lblDebito.Name = "lblDebito"
        Me.lblDebito.Size = New System.Drawing.Size(87, 13)
        Me.lblDebito.TabIndex = 98
        Me.lblDebito.Text = "Total Débito R$"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotal.Appearance.Options.UseFont = True
        Me.lblValorTotal.Location = New System.Drawing.Point(194, 508)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(79, 13)
        Me.lblValorTotal.TabIndex = 93
        Me.lblValorTotal.Text = "Valor Total R$"
        '
        'lblTotalSaldo
        '
        Me.lblTotalSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSaldo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSaldo.Appearance.Options.UseFont = True
        Me.lblTotalSaldo.Location = New System.Drawing.Point(756, 534)
        Me.lblTotalSaldo.Name = "lblTotalSaldo"
        Me.lblTotalSaldo.Size = New System.Drawing.Size(49, 13)
        Me.lblTotalSaldo.TabIndex = 100
        Me.lblTotalSaldo.Text = "Saldo R$"
        '
        'lblCredito
        '
        Me.lblCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCredito.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredito.Appearance.Options.UseFont = True
        Me.lblCredito.Location = New System.Drawing.Point(182, 534)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(91, 13)
        Me.lblCredito.TabIndex = 99
        Me.lblCredito.Text = "Total Crédito R$"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.btnPadrao)
        Me.GroupControl3.Controls.Add(Me.btnManter)
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(963, 338)
        Me.GroupControl3.TabIndex = 103
        Me.GroupControl3.Text = "Comissões Cadastradas"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(886, 36)
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
        Me.btnManter.Location = New System.Drawing.Point(886, 18)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 19)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbRep"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.grd2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(959, 316)
        Me.GridControl2.TabIndex = 5
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colCodPed, Me.colCodCli, Me.colCliente, Me.GridColumn2, Me.colFuncionario1, Me.colValor1, Me.colPorcentagem, Me.colComissaoFunc, Me.colComissaoEsc, Me.colData1, Me.GridColumn3, Me.GridColumn4})
        Me.grd2.GridControl = Me.GridControl2
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colCodPed
        '
        Me.colCodPed.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPed.Caption = "Cód. Venda."
        Me.colCodPed.FieldName = "CodPed"
        Me.colCodPed.Name = "colCodPed"
        Me.colCodPed.OptionsColumn.ReadOnly = True
        Me.colCodPed.Visible = True
        Me.colCodPed.VisibleIndex = 0
        Me.colCodPed.Width = 90
        '
        'colCodCli
        '
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 254
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "CodFunc"
        Me.GridColumn2.FieldName = "CodFunc"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'colFuncionario1
        '
        Me.colFuncionario1.Caption = "Vendedor"
        Me.colFuncionario1.FieldName = "Funcionario"
        Me.colFuncionario1.Name = "colFuncionario1"
        Me.colFuncionario1.OptionsColumn.ReadOnly = True
        Me.colFuncionario1.Visible = True
        Me.colFuncionario1.VisibleIndex = 3
        Me.colFuncionario1.Width = 234
        '
        'colValor1
        '
        Me.colValor1.AppearanceCell.Options.UseTextOptions = True
        Me.colValor1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor1.Caption = "Valor R$"
        Me.colValor1.FieldName = "Valor"
        Me.colValor1.Name = "colValor1"
        Me.colValor1.OptionsColumn.ReadOnly = True
        Me.colValor1.Visible = True
        Me.colValor1.VisibleIndex = 4
        Me.colValor1.Width = 83
        '
        'colPorcentagem
        '
        Me.colPorcentagem.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagem.Caption = "% Comissão"
        Me.colPorcentagem.FieldName = "Porcentagem"
        Me.colPorcentagem.Name = "colPorcentagem"
        Me.colPorcentagem.OptionsColumn.ReadOnly = True
        Me.colPorcentagem.Visible = True
        Me.colPorcentagem.VisibleIndex = 5
        Me.colPorcentagem.Width = 90
        '
        'colComissaoFunc
        '
        Me.colComissaoFunc.AppearanceCell.Options.UseTextOptions = True
        Me.colComissaoFunc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissaoFunc.Caption = "Com. Vend. R$"
        Me.colComissaoFunc.FieldName = "ComissaoFunc"
        Me.colComissaoFunc.Name = "colComissaoFunc"
        Me.colComissaoFunc.OptionsColumn.ReadOnly = True
        Me.colComissaoFunc.Visible = True
        Me.colComissaoFunc.VisibleIndex = 6
        Me.colComissaoFunc.Width = 101
        '
        'colComissaoEsc
        '
        Me.colComissaoEsc.AppearanceCell.Options.UseTextOptions = True
        Me.colComissaoEsc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissaoEsc.Caption = "Com. Esc. R$"
        Me.colComissaoEsc.FieldName = "ComissaoEsc"
        Me.colComissaoEsc.Name = "colComissaoEsc"
        Me.colComissaoEsc.OptionsColumn.ReadOnly = True
        Me.colComissaoEsc.Width = 86
        '
        'colData1
        '
        Me.colData1.AppearanceCell.Options.UseTextOptions = True
        Me.colData1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData1.Caption = "Data"
        Me.colData1.FieldName = "Data"
        Me.colData1.Name = "colData1"
        Me.colData1.OptionsColumn.ReadOnly = True
        Me.colData1.Visible = True
        Me.colData1.VisibleIndex = 1
        Me.colData1.Width = 86
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Placa"
        Me.GridColumn3.FieldName = "Placa"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Modelo"
        Me.GridColumn4.FieldName = "Modelo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'lblNumPar
        '
        Me.lblNumPar.AutoSize = True
        Me.lblNumPar.Location = New System.Drawing.Point(554, 41)
        Me.lblNumPar.Name = "lblNumPar"
        Me.lblNumPar.Size = New System.Drawing.Size(62, 13)
        Me.lblNumPar.TabIndex = 135
        Me.lblNumPar.Text = "Nº Parcelas"
        '
        'seParcela
        '
        Me.seParcela.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seParcela.EnterMoveNextControl = True
        Me.seParcela.Location = New System.Drawing.Point(622, 38)
        Me.seParcela.Name = "seParcela"
        Me.seParcela.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seParcela.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.seParcela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seParcela.Properties.MaxLength = 2
        Me.seParcela.Size = New System.Drawing.Size(118, 20)
        Me.seParcela.TabIndex = 6
        Me.seParcela.Tag = "Nº Parcelas"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(390, 42)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(42, 13)
        Me.lblDias.TabIndex = 136
        Me.lblDias.Text = "Nº Dias"
        '
        'txtDias
        '
        Me.txtDias.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDias.EnterMoveNextControl = True
        Me.txtDias.Location = New System.Drawing.Point(438, 39)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDias.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDias.Properties.MaxLength = 2
        Me.txtDias.Size = New System.Drawing.Size(104, 20)
        Me.txtDias.TabIndex = 5
        Me.txtDias.Tag = "Nº Dias"
        '
        'btnRelCustomizado
        '
        Me.btnRelCustomizado.Caption = "Relatório C&ustomizado"
        Me.btnRelCustomizado.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCustomizado.Id = 11
        Me.btnRelCustomizado.Name = "btnRelCustomizado"
        '
        'frmGastosFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblNumPar)
        Me.Controls.Add(Me.seParcela)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGastosFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos com Funcionários"
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTotalGeral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtValorTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComissaoVend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents txtMotivo As Campos.NanoCampo
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVenc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents dsGasto As System.Data.DataSet
    Friend WithEvents tbGasto As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCred As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDebito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotalSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCredito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComissaoVend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalComissao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValorTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueFuncionario As DevExpress.XtraBars.BarEditItem
    Friend WithEvents lueFunc2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissaoFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissaoEsc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalGeral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNumPar As System.Windows.Forms.Label
    Friend WithEvents seParcela As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents txtDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRelCustomizado As DevExpress.XtraBars.BarButtonItem
End Class
