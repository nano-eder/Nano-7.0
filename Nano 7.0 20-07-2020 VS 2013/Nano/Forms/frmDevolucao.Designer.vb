<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucao))
        Me.txtCliente = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodProd = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtCpf = New Campos.NanoCampo
        Me.txtValor = New Campos.NanoCampo
        Me.txtProd = New Campos.NanoCampo
        Me.txtQtde = New Campos.NanoCampo
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnAdicionar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtTotal = New Campos.NanoCampo
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dtProd = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUni = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdDev = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodLoja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMotivo = New Campos.NanoCampo
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.lueFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtTamanho = New Campos.NanoCampo
        Me.chkTamanho = New DevExpress.XtraEditors.CheckEdit
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.colUniSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataColumn14 = New System.Data.DataColumn
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.EnterMoveNextControl = True
        Me.txtCliente.Location = New System.Drawing.Point(66, 84)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(250, 20)
        Me.txtCliente.TabIndex = 2
        Me.txtCliente.Tag = "Cliente"
        '
        'txtCodProd
        '
        Me.txtCodProd.EnterMoveNextControl = True
        Me.txtCodProd.Location = New System.Drawing.Point(66, 132)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodProd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodProd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodProd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodProd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodProd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodProd.Properties.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(97, 20)
        Me.txtCodProd.TabIndex = 4
        Me.txtCodProd.Tag = "Código"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Cliente"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(341, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "CPF"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(740, 135)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Valor Uni. R$"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(641, 135)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Qtde"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(177, 135)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Produto"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(27, 135)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Código"
        '
        'txtCpf
        '
        Me.txtCpf.CasasDecimais = 0
        Me.txtCpf.EnterMoveNextControl = True
        Me.txtCpf.Location = New System.Drawing.Point(366, 84)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Numerico = False
        Me.txtCpf.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCpf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCpf.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCpf.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCpf.Size = New System.Drawing.Size(167, 20)
        Me.txtCpf.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 2
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(808, 132)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.MaxLength = 18
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 8
        Me.txtValor.Tag = "Valor"
        '
        'txtProd
        '
        Me.txtProd.CasasDecimais = 0
        Me.txtProd.EnterMoveNextControl = True
        Me.txtProd.Location = New System.Drawing.Point(221, 132)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Numerico = False
        Me.txtProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProd.Size = New System.Drawing.Size(312, 20)
        Me.txtProd.TabIndex = 5
        '
        'txtQtde
        '
        Me.txtQtde.CasasDecimais = 0
        Me.txtQtde.EnterMoveNextControl = True
        Me.txtQtde.Location = New System.Drawing.Point(671, 132)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Numerico = True
        Me.txtQtde.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtde.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtde.Properties.MaxLength = 10
        Me.txtQtde.Size = New System.Drawing.Size(63, 20)
        Me.txtQtde.TabIndex = 7
        Me.txtQtde.Tag = "Qtde"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnSalvar, Me.btnLimpar, Me.btnExcluir})
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
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 2
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
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(30, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl2.TabIndex = 73
        Me.LabelControl2.Text = "Dados do Cliente "
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 68)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(990, 5)
        Me.PanelControl1.TabIndex = 72
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(30, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 75
        Me.LabelControl3.Text = "Dados do Produto"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 116)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(990, 5)
        Me.PanelControl2.TabIndex = 74
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdicionar.Location = New System.Drawing.Point(921, 130)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 9
        Me.btnAdicionar.Text = "Adicionar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 162)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 466)
        Me.GroupControl1.TabIndex = 77
        Me.GroupControl1.Text = "Itens da Devolução"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.txtTotal)
        Me.GroupControl3.Controls.Add(Me.LabelControl20)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1004, 444)
        Me.GroupControl3.TabIndex = 85
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.CasasDecimais = 2
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(809, 412)
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
        Me.txtTotal.TabIndex = 88
        '
        'LabelControl20
        '
        Me.LabelControl20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(692, 419)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(108, 18)
        Me.LabelControl20.TabIndex = 87
        Me.LabelControl20.Text = "Total Geral R$"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dtProd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(1000, 407)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dtProd
        '
        Me.dtProd.DataSetName = "NewDataSet"
        Me.dtProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn2, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtde"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Valor Uni. R$"
        Me.DataColumn4.ColumnName = "ValorUni"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Valor Total R$"
        Me.DataColumn5.ColumnName = "ValorTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Produto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Tamanho"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ValorCusto"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodVenda"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CodOrdem"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "QtdDev"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodLoja"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CodProdInterno"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CodigoBarra"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colQtde, Me.colValorUni, Me.colValorTotal, Me.colProduto, Me.colTamanho, Me.colValorCusto, Me.colCodVenda, Me.colCodOrdem, Me.colQtdDev, Me.colCodLoja, Me.colCodProdInterno, Me.colCodigoBarra, Me.colUniSemDesc})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodigo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 132
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtde.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtde.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtde.AppearanceCell.Options.UseBackColor = True
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtde.Caption = "Qtde"
        Me.colQtde.ColumnEdit = Me.txtAlterar
        Me.colQtde.FieldName = "Qtde"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.OptionsColumn.ReadOnly = True
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 4
        Me.colQtde.Width = 62
        '
        'colValorUni
        '
        Me.colValorUni.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorUni.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorUni.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorUni.AppearanceCell.Options.UseBackColor = True
        Me.colValorUni.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUni.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUni.Caption = "Valor Uni. R$"
        Me.colValorUni.ColumnEdit = Me.txtAlterar
        Me.colValorUni.FieldName = "ValorUni"
        Me.colValorUni.Name = "colValorUni"
        Me.colValorUni.OptionsColumn.ReadOnly = True
        Me.colValorUni.Visible = True
        Me.colValorUni.VisibleIndex = 5
        Me.colValorUni.Width = 104
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colValorTotal.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorTotal.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlterar
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 6
        Me.colValorTotal.Width = 135
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 2
        Me.colProduto.Width = 405
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTamanho.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTamanho.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colTamanho.AppearanceCell.Options.UseBackColor = True
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 3
        Me.colTamanho.Width = 70
        '
        'colValorCusto
        '
        Me.colValorCusto.Caption = "ValorCusto"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        '
        'colCodVenda
        '
        Me.colCodVenda.Caption = "CodVenda"
        Me.colCodVenda.FieldName = "CodVenda"
        Me.colCodVenda.Name = "colCodVenda"
        '
        'colCodOrdem
        '
        Me.colCodOrdem.Caption = "CodOrdem"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        '
        'colQtdDev
        '
        Me.colQtdDev.Caption = "QtdDev"
        Me.colQtdDev.FieldName = "QtdDev"
        Me.colQtdDev.Name = "colQtdDev"
        '
        'colCodLoja
        '
        Me.colCodLoja.Caption = "CodLoja"
        Me.colCodLoja.FieldName = "CodLoja"
        Me.colCodLoja.Name = "colCodLoja"
        Me.colCodLoja.OptionsColumn.ReadOnly = True
        '
        'colCodProdInterno
        '
        Me.colCodProdInterno.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodProdInterno.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodProdInterno.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProdInterno.AppearanceCell.Options.UseBackColor = True
        Me.colCodProdInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdInterno.Caption = "Código"
        Me.colCodProdInterno.FieldName = "CodProdInterno"
        Me.colCodProdInterno.Name = "colCodProdInterno"
        Me.colCodProdInterno.OptionsColumn.ReadOnly = True
        Me.colCodProdInterno.Visible = True
        Me.colCodProdInterno.VisibleIndex = 0
        Me.colCodProdInterno.Width = 91
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodigoBarra.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoBarra.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoBarra.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoBarra.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarra.Caption = "Cód. Barra"
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.OptionsColumn.ReadOnly = True
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 1
        Me.colCodigoBarra.Width = 112
        '
        'txtMotivo
        '
        Me.txtMotivo.CasasDecimais = 0
        Me.txtMotivo.EnterMoveNextControl = True
        Me.txtMotivo.Location = New System.Drawing.Point(66, 38)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Numerico = False
        Me.txtMotivo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMotivo.Properties.MaxLength = 100
        Me.txtMotivo.Size = New System.Drawing.Size(467, 20)
        Me.txtMotivo.TabIndex = 1
        Me.txtMotivo.Tag = "Motivo"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl5.TabIndex = 81
        Me.LabelControl5.Text = "Vendedor"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(28, 41)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 82
        Me.LabelControl10.Text = "Motivo"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(66, 12)
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueFunc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.lueFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.Properties.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc.Properties.DisplayMember = "Nome"
        Me.lueFunc.Properties.NullText = ""
        Me.lueFunc.Properties.ValueMember = "Nome"
        Me.lueFunc.Size = New System.Drawing.Size(467, 20)
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
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(539, 135)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 85
        Me.LabelControl12.Text = "Tam."
        '
        'txtTamanho
        '
        Me.txtTamanho.CasasDecimais = 0
        Me.txtTamanho.EnterMoveNextControl = True
        Me.txtTamanho.Location = New System.Drawing.Point(569, 132)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Numerico = False
        Me.txtTamanho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho.Size = New System.Drawing.Size(66, 20)
        Me.txtTamanho.TabIndex = 6
        Me.txtTamanho.Tag = "Tamanho"
        '
        'chkTamanho
        '
        Me.chkTamanho.EditValue = True
        Me.chkTamanho.Location = New System.Drawing.Point(617, 133)
        Me.chkTamanho.Name = "chkTamanho"
        Me.chkTamanho.Properties.Caption = ""
        Me.chkTamanho.Size = New System.Drawing.Size(17, 19)
        Me.chkTamanho.TabIndex = 109
        Me.chkTamanho.ToolTip = "Clique para adicionar um tamanho diferente de U"
        Me.chkTamanho.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkTamanho.ToolTipTitle = "Tamanho do Produto"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'colUniSemDesc
        '
        Me.colUniSemDesc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUniSemDesc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUniSemDesc.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colUniSemDesc.AppearanceCell.Options.UseBackColor = True
        Me.colUniSemDesc.Caption = "Val. Sem Desc. R$"
        Me.colUniSemDesc.FieldName = "UniSemDesc"
        Me.colUniSemDesc.Name = "colUniSemDesc"
        Me.colUniSemDesc.OptionsColumn.ReadOnly = True
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "UniSemDesc"
        '
        'frmDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.chkTamanho)
        Me.Controls.Add(Me.txtTamanho)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmDevolucao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Devoluções"
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodProd As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCpf As Campos.NanoCampo
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents txtProd As Campos.NanoCampo
    Friend WithEvents txtQtde As Campos.NanoCampo
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAdicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtProd As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMotivo As Campos.NanoCampo
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTamanho As Campos.NanoCampo
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotal As Campos.NanoCampo
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkTamanho As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colCodVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colQtdDev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colCodLoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colCodProdInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUniSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
End Class
