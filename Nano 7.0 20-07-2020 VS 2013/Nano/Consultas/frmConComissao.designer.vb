<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConComissao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConComissao))
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.editCboFun = New DevExpress.XtraBars.BarEditItem
        Me.cboFunc2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnTotais = New DevExpress.XtraBars.BarButtonItem
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCod = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorServico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grpGrid = New DevExpress.XtraEditors.GroupControl
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotGer = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.grpCom = New DevExpress.XtraEditors.GroupControl
        Me.txtComP = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtComS = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtComT = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.grpCD = New DevExpress.XtraEditors.GroupControl
        Me.btnDelCredDeb = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ComissaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNano = New Nano.dsNano
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedido2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colFuncionario2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCred = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtDeb = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtTot = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.sfdSalvar = New System.Windows.Forms.SaveFileDialog
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dtDate = New DevExpress.XtraEditors.DateEdit
        Me.txtVal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnInserir = New DevExpress.XtraEditors.SimpleButton
        Me.cboFun = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboMot = New DevExpress.XtraEditors.LookUpEdit
        Me.LancamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComissaoTableAdapter = New Nano.dsNanoTableAdapters.ComissaoTableAdapter
        Me.LancamentosTableAdapter = New Nano.dsNanoTableAdapters.LancamentosTableAdapter
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFunc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrid.SuspendLayout()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCom.SuspendLayout()
        CType(Me.txtComP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCD.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComissaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LancamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.btnVisualizar, Me.editCboFun, Me.btnTotais, Me.btnClose})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.cboFunc2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", False, True, True, 89, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 85, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.editCboFun, "", True, True, True, 195, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTotais, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Dt. Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.EditValue = ""
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
        Me.dtFinal.Caption = "Dt. Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit2
        Me.dtFinal.EditValue = ""
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
        'editCboFun
        '
        Me.editCboFun.Caption = "Funcionário"
        Me.editCboFun.Edit = Me.cboFunc2
        Me.editCboFun.EditValue = ""
        Me.editCboFun.Id = 8
        Me.editCboFun.Name = "editCboFun"
        '
        'cboFunc2
        '
        Me.cboFunc2.AutoHeight = False
        Me.cboFunc2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFunc2.Name = "cboFunc2"
        Me.cboFunc2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "&Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 2
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 4
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnTotais
        '
        Me.btnTotais.Caption = "&Totais"
        Me.btnTotais.Glyph = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnTotais.Id = 9
        Me.btnTotais.Name = "btnTotais"
        '
        'btnClose
        '
        Me.btnClose.Caption = "&Fechar"
        Me.btnClose.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnClose.Id = 10
        Me.btnClose.Name = "btnClose"
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 20)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCod})
        Me.Grid1.Size = New System.Drawing.Size(951, 280)
        Me.Grid1.TabIndex = 8
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodigoPedido, Me.colFuncionario, Me.colValorServico, Me.colPorcentagem, Me.colComissao, Me.colData, Me.colMotivo, Me.colTipo, Me.colTipoProduto})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'colCodigoPedido
        '
        Me.colCodigoPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPedido.Caption = "Cód. Ped."
        Me.colCodigoPedido.ColumnEdit = Me.txtCod
        Me.colCodigoPedido.FieldName = "CodigoPedido"
        Me.colCodigoPedido.Name = "colCodigoPedido"
        Me.colCodigoPedido.OptionsColumn.ReadOnly = True
        Me.colCodigoPedido.Visible = True
        Me.colCodigoPedido.VisibleIndex = 0
        Me.colCodigoPedido.Width = 77
        '
        'txtCod
        '
        Me.txtCod.AutoHeight = False
        Me.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCod.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCod.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value
        Me.txtCod.Name = "txtCod"
        '
        'colFuncionario
        '
        Me.colFuncionario.Caption = "Funcionário"
        Me.colFuncionario.FieldName = "Funcionario"
        Me.colFuncionario.Name = "colFuncionario"
        Me.colFuncionario.OptionsColumn.ReadOnly = True
        Me.colFuncionario.Visible = True
        Me.colFuncionario.VisibleIndex = 2
        Me.colFuncionario.Width = 247
        '
        'colValorServico
        '
        Me.colValorServico.AppearanceCell.Options.UseTextOptions = True
        Me.colValorServico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorServico.Caption = "Valor Prod. R$"
        Me.colValorServico.FieldName = "ValorServico"
        Me.colValorServico.Name = "colValorServico"
        Me.colValorServico.OptionsColumn.ReadOnly = True
        Me.colValorServico.Visible = True
        Me.colValorServico.VisibleIndex = 4
        Me.colValorServico.Width = 123
        '
        'colPorcentagem
        '
        Me.colPorcentagem.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagem.Caption = "Por. %"
        Me.colPorcentagem.FieldName = "Porcentagem"
        Me.colPorcentagem.Name = "colPorcentagem"
        Me.colPorcentagem.OptionsColumn.ReadOnly = True
        Me.colPorcentagem.Visible = True
        Me.colPorcentagem.VisibleIndex = 5
        Me.colPorcentagem.Width = 67
        '
        'colComissao
        '
        Me.colComissao.AppearanceCell.Options.UseTextOptions = True
        Me.colComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissao.Caption = "Comissão R$"
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 6
        Me.colComissao.Width = 105
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
        Me.colData.Width = 80
        '
        'colMotivo
        '
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.OptionsColumn.ReadOnly = True
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 3
        Me.colMotivo.Width = 156
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Width = 71
        '
        'colTipoProduto
        '
        Me.colTipoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoProduto.Caption = "Tip. Prod."
        Me.colTipoProduto.FieldName = "TipoProduto"
        Me.colTipoProduto.Name = "colTipoProduto"
        Me.colTipoProduto.OptionsColumn.ReadOnly = True
        Me.colTipoProduto.Visible = True
        Me.colTipoProduto.VisibleIndex = 7
        '
        'grpGrid
        '
        Me.grpGrid.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGrid.AppearanceCaption.Options.UseFont = True
        Me.grpGrid.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.grpGrid.Controls.Add(Me.btnCalcular)
        Me.grpGrid.Controls.Add(Me.txtTotGer)
        Me.grpGrid.Controls.Add(Me.LabelControl4)
        Me.grpGrid.Controls.Add(Me.grpCom)
        Me.grpGrid.Controls.Add(Me.txtComP)
        Me.grpGrid.Controls.Add(Me.LabelControl9)
        Me.grpGrid.Controls.Add(Me.txtComS)
        Me.grpGrid.Controls.Add(Me.LabelControl10)
        Me.grpGrid.Controls.Add(Me.txtComT)
        Me.grpGrid.Controls.Add(Me.LabelControl11)
        Me.grpGrid.Controls.Add(Me.grpCD)
        Me.grpGrid.Controls.Add(Me.txtCred)
        Me.grpGrid.Controls.Add(Me.LabelControl8)
        Me.grpGrid.Controls.Add(Me.txtDeb)
        Me.grpGrid.Controls.Add(Me.LabelControl7)
        Me.grpGrid.Controls.Add(Me.txtTot)
        Me.grpGrid.Controls.Add(Me.LabelControl1)
        Me.grpGrid.Location = New System.Drawing.Point(0, 67)
        Me.grpGrid.Name = "grpGrid"
        Me.grpGrid.Size = New System.Drawing.Size(959, 524)
        Me.grpGrid.TabIndex = 9
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(65, 464)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(130, 26)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.Text = "Calcular"
        '
        'txtTotGer
        '
        Me.txtTotGer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotGer.EditValue = ""
        Me.txtTotGer.Location = New System.Drawing.Point(65, 496)
        Me.txtTotGer.Name = "txtTotGer"
        Me.txtTotGer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.Appearance.Options.UseFont = True
        Me.txtTotGer.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotGer.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotGer.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotGer.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTotGer.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotGer.Properties.ReadOnly = True
        Me.txtTotGer.Size = New System.Drawing.Size(130, 26)
        Me.txtTotGer.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 504)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Total R$"
        '
        'grpCom
        '
        Me.grpCom.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCom.AppearanceCaption.Options.UseFont = True
        Me.grpCom.Controls.Add(Me.Grid1)
        Me.grpCom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCom.Location = New System.Drawing.Point(2, 2)
        Me.grpCom.Name = "grpCom"
        Me.grpCom.Size = New System.Drawing.Size(955, 302)
        Me.grpCom.TabIndex = 17
        Me.grpCom.Text = "Comissões"
        '
        'txtComP
        '
        Me.txtComP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComP.EditValue = ""
        Me.txtComP.Location = New System.Drawing.Point(307, 464)
        Me.txtComP.Name = "txtComP"
        Me.txtComP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComP.Properties.Appearance.Options.UseFont = True
        Me.txtComP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComP.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComP.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtComP.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComP.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtComP.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtComP.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtComP.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComP.Properties.ReadOnly = True
        Me.txtComP.Size = New System.Drawing.Size(130, 26)
        Me.txtComP.TabIndex = 24
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(210, 472)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl9.TabIndex = 23
        Me.LabelControl9.Text = "Comis. Peças R$"
        '
        'txtComS
        '
        Me.txtComS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComS.EditValue = ""
        Me.txtComS.Location = New System.Drawing.Point(561, 464)
        Me.txtComS.Name = "txtComS"
        Me.txtComS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComS.Properties.Appearance.Options.UseFont = True
        Me.txtComS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComS.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtComS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComS.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtComS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtComS.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtComS.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComS.Properties.ReadOnly = True
        Me.txtComS.Size = New System.Drawing.Size(130, 26)
        Me.txtComS.TabIndex = 22
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(449, 472)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "Comis. Serviços R$"
        '
        'txtComT
        '
        Me.txtComT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComT.EditValue = ""
        Me.txtComT.Location = New System.Drawing.Point(816, 464)
        Me.txtComT.Name = "txtComT"
        Me.txtComT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComT.Properties.Appearance.Options.UseFont = True
        Me.txtComT.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComT.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComT.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtComT.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComT.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtComT.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtComT.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtComT.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComT.Properties.ReadOnly = True
        Me.txtComT.Size = New System.Drawing.Size(130, 26)
        Me.txtComT.TabIndex = 20
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(706, 472)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Total Comissão R$"
        '
        'grpCD
        '
        Me.grpCD.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCD.AppearanceCaption.Options.UseFont = True
        Me.grpCD.Controls.Add(Me.btnDelCredDeb)
        Me.grpCD.Controls.Add(Me.GridControl1)
        Me.grpCD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpCD.Location = New System.Drawing.Point(2, 304)
        Me.grpCD.Name = "grpCD"
        Me.grpCD.Size = New System.Drawing.Size(955, 156)
        Me.grpCD.TabIndex = 18
        Me.grpCD.Text = "Outros Créditos e Débitos"
        '
        'btnDelCredDeb
        '
        Me.btnDelCredDeb.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelCredDeb.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnDelCredDeb.Location = New System.Drawing.Point(920, 0)
        Me.btnDelCredDeb.Name = "btnDelCredDeb"
        Me.btnDelCredDeb.Size = New System.Drawing.Size(30, 20)
        ToolTipTitleItem1.Text = "Exluir Crédito ou Débito"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnDelCredDeb.SuperTip = SuperToolTip1
        Me.btnDelCredDeb.TabIndex = 24
        Me.btnDelCredDeb.ToolTipTitle = "Exluir Crédito ou Débito"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ComissaoBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(951, 134)
        Me.GridControl1.TabIndex = 16
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'ComissaoBindingSource
        '
        Me.ComissaoBindingSource.DataMember = "Comissao"
        Me.ComissaoBindingSource.DataSource = Me.DsNano
        '
        'DsNano
        '
        Me.DsNano.DataSetName = "dsNano"
        Me.DsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo2, Me.colCodigoPedido2, Me.colFuncionario2, Me.GridColumn4, Me.GridColumn5, Me.colComissao2, Me.colData2, Me.colMotivo2, Me.colTipo2})
        Me.grd2.GridControl = Me.GridControl1
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colCodigo2
        '
        Me.colCodigo2.Caption = "Codigo"
        Me.colCodigo2.FieldName = "Codigo"
        Me.colCodigo2.Name = "colCodigo2"
        '
        'colCodigoPedido2
        '
        Me.colCodigoPedido2.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPedido2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPedido2.Caption = "Cód. Ped."
        Me.colCodigoPedido2.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodigoPedido2.FieldName = "CodigoPedido"
        Me.colCodigoPedido2.Name = "colCodigoPedido2"
        Me.colCodigoPedido2.OptionsColumn.ReadOnly = True
        Me.colCodigoPedido2.Visible = True
        Me.colCodigoPedido2.VisibleIndex = 0
        Me.colCodigoPedido2.Width = 82
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colFuncionario2
        '
        Me.colFuncionario2.Caption = "Funcionário"
        Me.colFuncionario2.FieldName = "Funcionario"
        Me.colFuncionario2.Name = "colFuncionario2"
        Me.colFuncionario2.OptionsColumn.ReadOnly = True
        Me.colFuncionario2.Visible = True
        Me.colFuncionario2.VisibleIndex = 2
        Me.colFuncionario2.Width = 188
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Valor R$"
        Me.GridColumn4.FieldName = "ValorServico"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Width = 90
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Por. %"
        Me.GridColumn5.FieldName = "Porcentagem"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Width = 56
        '
        'colComissao2
        '
        Me.colComissao2.AppearanceCell.Options.UseTextOptions = True
        Me.colComissao2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colComissao2.Caption = "Valor Créd/Déb R$"
        Me.colComissao2.FieldName = "Comissao"
        Me.colComissao2.Name = "colComissao2"
        Me.colComissao2.OptionsColumn.ReadOnly = True
        Me.colComissao2.Visible = True
        Me.colComissao2.VisibleIndex = 4
        Me.colComissao2.Width = 123
        '
        'colData2
        '
        Me.colData2.AppearanceCell.Options.UseTextOptions = True
        Me.colData2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData2.Caption = "Data"
        Me.colData2.FieldName = "Data"
        Me.colData2.Name = "colData2"
        Me.colData2.OptionsColumn.ReadOnly = True
        Me.colData2.Visible = True
        Me.colData2.VisibleIndex = 1
        Me.colData2.Width = 88
        '
        'colMotivo2
        '
        Me.colMotivo2.Caption = "Motivo"
        Me.colMotivo2.FieldName = "Motivo"
        Me.colMotivo2.Name = "colMotivo2"
        Me.colMotivo2.OptionsColumn.ReadOnly = True
        Me.colMotivo2.Visible = True
        Me.colMotivo2.VisibleIndex = 3
        Me.colMotivo2.Width = 388
        '
        'colTipo2
        '
        Me.colTipo2.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo2.Caption = "Tipo"
        Me.colTipo2.FieldName = "Tipo"
        Me.colTipo2.Name = "colTipo2"
        Me.colTipo2.OptionsColumn.ReadOnly = True
        Me.colTipo2.Visible = True
        Me.colTipo2.VisibleIndex = 5
        Me.colTipo2.Width = 61
        '
        'txtCred
        '
        Me.txtCred.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCred.EditValue = ""
        Me.txtCred.Location = New System.Drawing.Point(307, 496)
        Me.txtCred.Name = "txtCred"
        Me.txtCred.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCred.Properties.Appearance.Options.UseFont = True
        Me.txtCred.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCred.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCred.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCred.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCred.Properties.ReadOnly = True
        Me.txtCred.Size = New System.Drawing.Size(130, 26)
        Me.txtCred.TabIndex = 15
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(210, 502)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Total Crédito R$"
        '
        'txtDeb
        '
        Me.txtDeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeb.EditValue = ""
        Me.txtDeb.Location = New System.Drawing.Point(561, 496)
        Me.txtDeb.Name = "txtDeb"
        Me.txtDeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.Properties.Appearance.Options.UseFont = True
        Me.txtDeb.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDeb.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtDeb.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDeb.Properties.ReadOnly = True
        Me.txtDeb.Size = New System.Drawing.Size(130, 26)
        Me.txtDeb.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(468, 502)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Total Débito R$"
        '
        'txtTot
        '
        Me.txtTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTot.EditValue = ""
        Me.txtTot.Location = New System.Drawing.Point(816, 496)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Properties.Appearance.Options.UseFont = True
        Me.txtTot.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTot.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTot.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTot.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtTot.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTot.Properties.ReadOnly = True
        Me.txtTot.Size = New System.Drawing.Size(130, 26)
        Me.txtTot.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(761, 501)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Saldo R$"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Funcionário"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(440, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Motivo"
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.EnterMoveNextControl = True
        Me.dtDate.Location = New System.Drawing.Point(830, 9)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtDate.Size = New System.Drawing.Size(117, 20)
        Me.dtDate.TabIndex = 2
        Me.dtDate.Tag = "Data"
        '
        'txtVal
        '
        Me.txtVal.EnterMoveNextControl = True
        Me.txtVal.Location = New System.Drawing.Point(80, 35)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVal.Size = New System.Drawing.Size(115, 20)
        Me.txtVal.TabIndex = 3
        Me.txtVal.Tag = "Valor R$"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(801, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Data"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(34, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "Valor R$"
        '
        'btnInserir
        '
        Me.btnInserir.Image = Global.Nano.My.Resources.Resources.apply
        Me.btnInserir.Location = New System.Drawing.Point(286, 35)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(101, 26)
        Me.btnInserir.TabIndex = 5
        Me.btnInserir.Text = "Inserir"
        '
        'cboFun
        '
        Me.cboFun.EnterMoveNextControl = True
        Me.cboFun.Location = New System.Drawing.Point(80, 9)
        Me.cboFun.Name = "cboFun"
        Me.cboFun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFun.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFun.Size = New System.Drawing.Size(307, 20)
        Me.cboFun.TabIndex = 0
        Me.cboFun.Tag = "Motivo"
        '
        'cboMot
        '
        Me.cboMot.EnterMoveNextControl = True
        Me.cboMot.Location = New System.Drawing.Point(478, 9)
        Me.cboMot.Name = "cboMot"
        Me.cboMot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMot.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMot.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tipo", "Tipo", 26, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMot.Properties.DataSource = Me.LancamentosBindingSource
        Me.cboMot.Properties.DisplayMember = "Descricao"
        Me.cboMot.Properties.NullText = ""
        Me.cboMot.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboMot.Properties.ValueMember = "Descricao"
        Me.cboMot.Size = New System.Drawing.Size(285, 20)
        Me.cboMot.TabIndex = 22
        '
        'LancamentosBindingSource
        '
        Me.LancamentosBindingSource.DataMember = "Lancamentos"
        Me.LancamentosBindingSource.DataSource = Me.DsNano
        '
        'ComissaoTableAdapter
        '
        Me.ComissaoTableAdapter.ClearBeforeFill = True
        '
        'LancamentosTableAdapter
        '
        Me.LancamentosTableAdapter.ClearBeforeFill = True
        '
        'frmConComissao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 627)
        Me.Controls.Add(Me.grpGrid)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboFun)
        Me.Controls.Add(Me.cboMot)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConComissao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Comissões"
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFunc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrid.ResumeLayout(False)
        Me.grpGrid.PerformLayout()
        CType(Me.txtTotGer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCom.ResumeLayout(False)
        CType(Me.txtComP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCD.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComissaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LancamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorServico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpGrid As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtTot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sfdSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtCod As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInserir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCred As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents editCboFun As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboFunc2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboFun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colTipoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedido2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colFuncionario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComissao2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpCD As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpCom As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtComP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTotais As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboMot As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnDelCredDeb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtTotGer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNano As Nano.dsNano
    Friend WithEvents ComissaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComissaoTableAdapter As Nano.dsNanoTableAdapters.ComissaoTableAdapter
    Friend WithEvents LancamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LancamentosTableAdapter As Nano.dsNanoTableAdapters.LancamentosTableAdapter
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
End Class
