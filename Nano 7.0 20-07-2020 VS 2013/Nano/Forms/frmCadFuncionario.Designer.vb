<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFuncionario))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.txtQtdFun = New DevExpress.XtraEditors.TextEdit
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.FuncionarioGridControl = New DevExpress.XtraGrid.GridControl
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsNano = New Nano.dsNano
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCelular = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNascimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFuncao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAdmissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataDemissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSangue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAlergia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCEP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContaCorrente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMeta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodUser = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComServ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtObs = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.FuncionarioTableAdapter = New Nano.dsNanoTableAdapters.FuncionarioTableAdapter
        Me.dtNasc = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.dtAdim = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.dtDemis = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.rdgStatus = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtComPec = New Campos.NanoCampo
        Me.txtTipSan = New Campos.NanoCampo
        Me.txtEmail = New Campos.NanoCampo
        Me.txtFun = New Campos.NanoCampo
        Me.txtAler = New Campos.NanoCampo
        Me.txtCel = New Campos.NanoCampo
        Me.txtTel = New Campos.NanoCampo
        Me.txtBai = New Campos.NanoCampo
        Me.txtEnd = New Campos.NanoCampo
        Me.txtRG = New Campos.NanoCampo
        Me.txtCpf = New Campos.NanoCampo
        Me.txtNome = New Campos.NanoCampo
        Me.cboCidade = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtNum = New Campos.NanoCampo
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtCep = New Campos.NanoCampo
        Me.txtComp = New Campos.NanoCampo
        Me.chkCPF = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.txtBanco = New Campos.NanoCampo
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtContaCorrente = New Campos.NanoCampo
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txtAgencia = New Campos.NanoCampo
        Me.txtMeta = New Campos.NanoCampo
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.lblLoja = New DevExpress.XtraEditors.LabelControl
        Me.lueLoja = New DevExpress.XtraEditors.LookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.NanoCampo1 = New Campos.NanoCampo
        Me.txtComServ = New Campos.NanoCampo
        Me.lblComServ = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtQtdFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAdim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAdim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDemis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDemis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComPec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipSan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCpf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComServ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnCancelar, Me.BarSubItem1, Me.btnVisualizar, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Funionário"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 6
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 7
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 4
        Me.btnCancelar.Name = "btnCancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Nome"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 142)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Telefone"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "CPF"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(4, 73)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1000, 5)
        Me.PanelControl1.TabIndex = 12
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(17, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(132, 14)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Dados do Funcionário"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 275)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 351)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "Funcionários Cadastrados"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.LabelControl24)
        Me.GroupControl3.Controls.Add(Me.btnPadrao)
        Me.GroupControl3.Controls.Add(Me.txtQtdFun)
        Me.GroupControl3.Controls.Add(Me.btnManter)
        Me.GroupControl3.Controls.Add(Me.FuncionarioGridControl)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1004, 329)
        Me.GroupControl3.TabIndex = 108
        '
        'LabelControl24
        '
        Me.LabelControl24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Location = New System.Drawing.Point(748, 308)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl24.TabIndex = 110
        Me.LabelControl24.Text = "Funcionários Cadastrados"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(929, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 107
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'txtQtdFun
        '
        Me.txtQtdFun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdFun.Location = New System.Drawing.Point(899, 300)
        Me.txtQtdFun.Name = "txtQtdFun"
        Me.txtQtdFun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdFun.Properties.Appearance.Options.UseFont = True
        Me.txtQtdFun.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdFun.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdFun.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdFun.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdFun.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdFun.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdFun.Properties.ReadOnly = True
        Me.txtQtdFun.Size = New System.Drawing.Size(95, 26)
        Me.txtQtdFun.TabIndex = 109
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(929, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'FuncionarioGridControl
        '
        Me.FuncionarioGridControl.DataSource = Me.FuncionarioBindingSource
        Me.FuncionarioGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FuncionarioGridControl.EmbeddedNavigator.Name = ""
        Me.FuncionarioGridControl.Location = New System.Drawing.Point(2, 2)
        Me.FuncionarioGridControl.MainView = Me.grd1
        Me.FuncionarioGridControl.Name = "FuncionarioGridControl"
        Me.FuncionarioGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.FuncionarioGridControl.Size = New System.Drawing.Size(1000, 292)
        Me.FuncionarioGridControl.TabIndex = 0
        Me.FuncionarioGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'FuncionarioBindingSource
        '
        Me.FuncionarioBindingSource.DataMember = "Funcionario"
        Me.FuncionarioBindingSource.DataSource = Me.dsNano
        '
        'dsNano
        '
        Me.dsNano.DataSetName = "dsNano"
        Me.dsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colCPF, Me.colTelefone, Me.colRG, Me.colCelular, Me.colEndereco, Me.colBairro, Me.colCidade, Me.colNascimento, Me.colObservacao, Me.colCod, Me.colFuncao, Me.colPorcComissao, Me.colDataAdmissao, Me.colDataDemissao, Me.colAtivo, Me.colEmail, Me.colSangue, Me.colAlergia, Me.colCEP, Me.colUF, Me.colComplemento, Me.colNum, Me.colBanco, Me.colAgencia, Me.colContaCorrente, Me.colMeta, Me.colCodConfig, Me.colCodUser, Me.colComServ})
        Me.grd1.GridControl = Me.FuncionarioGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colNome
        '
        Me.colNome.Caption = "Nome"
        Me.colNome.ColumnEdit = Me.txtAlterar
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        Me.colNome.Width = 229
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF"
        Me.colCPF.ColumnEdit = Me.txtAlterar
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 4
        Me.colCPF.Width = 124
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.Caption = "Telefone"
        Me.colTelefone.ColumnEdit = Me.txtAlterar
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 6
        Me.colTelefone.Width = 94
        '
        'colRG
        '
        Me.colRG.AppearanceCell.Options.UseTextOptions = True
        Me.colRG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRG.Caption = "RG"
        Me.colRG.ColumnEdit = Me.txtAlterar
        Me.colRG.FieldName = "RG"
        Me.colRG.Name = "colRG"
        Me.colRG.OptionsColumn.ReadOnly = True
        Me.colRG.Visible = True
        Me.colRG.VisibleIndex = 5
        Me.colRG.Width = 102
        '
        'colCelular
        '
        Me.colCelular.AppearanceCell.Options.UseTextOptions = True
        Me.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCelular.Caption = "Celular"
        Me.colCelular.ColumnEdit = Me.txtAlterar
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.OptionsColumn.ReadOnly = True
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 7
        Me.colCelular.Width = 93
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.ColumnEdit = Me.txtAlterar
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.OptionsColumn.ReadOnly = True
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 8
        Me.colEndereco.Width = 183
        '
        'colBairro
        '
        Me.colBairro.Caption = "Bairro"
        Me.colBairro.ColumnEdit = Me.txtAlterar
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.ReadOnly = True
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 9
        Me.colBairro.Width = 156
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.ColumnEdit = Me.txtAlterar
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        Me.colCidade.Visible = True
        Me.colCidade.VisibleIndex = 10
        Me.colCidade.Width = 134
        '
        'colNascimento
        '
        Me.colNascimento.Caption = "Dt. Nasc."
        Me.colNascimento.FieldName = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.OptionsColumn.ReadOnly = True
        Me.colNascimento.Visible = True
        Me.colNascimento.VisibleIndex = 11
        '
        'colObservacao
        '
        Me.colObservacao.Caption = "Observações"
        Me.colObservacao.ColumnEdit = Me.txtAlterar
        Me.colObservacao.FieldName = "Obs"
        Me.colObservacao.Name = "colObservacao"
        Me.colObservacao.OptionsColumn.ReadOnly = True
        Me.colObservacao.Visible = True
        Me.colObservacao.VisibleIndex = 14
        Me.colObservacao.Width = 120
        '
        'colCod
        '
        Me.colCod.AppearanceCell.Options.UseTextOptions = True
        Me.colCod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCod.Caption = "Código"
        Me.colCod.ColumnEdit = Me.txtAlterar
        Me.colCod.FieldName = "Codigo"
        Me.colCod.Name = "colCod"
        Me.colCod.OptionsColumn.ReadOnly = True
        Me.colCod.Visible = True
        Me.colCod.VisibleIndex = 0
        Me.colCod.Width = 62
        '
        'colFuncao
        '
        Me.colFuncao.Caption = "Função"
        Me.colFuncao.ColumnEdit = Me.txtAlterar
        Me.colFuncao.FieldName = "Funcao"
        Me.colFuncao.Name = "colFuncao"
        Me.colFuncao.OptionsColumn.ReadOnly = True
        Me.colFuncao.Visible = True
        Me.colFuncao.VisibleIndex = 3
        Me.colFuncao.Width = 150
        '
        'colPorcComissao
        '
        Me.colPorcComissao.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPorcComissao.Caption = "Comissão"
        Me.colPorcComissao.ColumnEdit = Me.txtAlterar
        Me.colPorcComissao.FieldName = "PorcComissao"
        Me.colPorcComissao.Name = "colPorcComissao"
        Me.colPorcComissao.OptionsColumn.ReadOnly = True
        Me.colPorcComissao.Visible = True
        Me.colPorcComissao.VisibleIndex = 2
        Me.colPorcComissao.Width = 85
        '
        'colDataAdmissao
        '
        Me.colDataAdmissao.Caption = "Dt. Admissão"
        Me.colDataAdmissao.ColumnEdit = Me.txtAlterar
        Me.colDataAdmissao.FieldName = "DataAdmissao"
        Me.colDataAdmissao.Name = "colDataAdmissao"
        Me.colDataAdmissao.OptionsColumn.ReadOnly = True
        Me.colDataAdmissao.Visible = True
        Me.colDataAdmissao.VisibleIndex = 12
        Me.colDataAdmissao.Width = 80
        '
        'colDataDemissao
        '
        Me.colDataDemissao.Caption = "Data Demisão"
        Me.colDataDemissao.FieldName = "DataDemissao"
        Me.colDataDemissao.Name = "colDataDemissao"
        Me.colDataDemissao.OptionsColumn.ReadOnly = True
        Me.colDataDemissao.Visible = True
        Me.colDataDemissao.VisibleIndex = 13
        '
        'colAtivo
        '
        Me.colAtivo.Caption = "Ativo?"
        Me.colAtivo.FieldName = "Ativo"
        Me.colAtivo.Name = "colAtivo"
        Me.colAtivo.OptionsColumn.ReadOnly = True
        Me.colAtivo.Visible = True
        Me.colAtivo.VisibleIndex = 15
        '
        'colEmail
        '
        Me.colEmail.Caption = "E-Mail"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 16
        '
        'colSangue
        '
        Me.colSangue.Caption = "Tip. Sang."
        Me.colSangue.FieldName = "Sangue"
        Me.colSangue.Name = "colSangue"
        Me.colSangue.OptionsColumn.ReadOnly = True
        Me.colSangue.Visible = True
        Me.colSangue.VisibleIndex = 17
        '
        'colAlergia
        '
        Me.colAlergia.Caption = "Alergias"
        Me.colAlergia.FieldName = "Alergia"
        Me.colAlergia.Name = "colAlergia"
        Me.colAlergia.OptionsColumn.ReadOnly = True
        Me.colAlergia.Visible = True
        Me.colAlergia.VisibleIndex = 18
        '
        'colCEP
        '
        Me.colCEP.Caption = "CEP"
        Me.colCEP.ColumnEdit = Me.txtAlterar
        Me.colCEP.FieldName = "CEP"
        Me.colCEP.Name = "colCEP"
        Me.colCEP.OptionsColumn.ReadOnly = True
        Me.colCEP.Visible = True
        Me.colCEP.VisibleIndex = 19
        '
        'colUF
        '
        Me.colUF.Caption = "UF"
        Me.colUF.ColumnEdit = Me.txtAlterar
        Me.colUF.FieldName = "UF"
        Me.colUF.Name = "colUF"
        Me.colUF.OptionsColumn.ReadOnly = True
        Me.colUF.Visible = True
        Me.colUF.VisibleIndex = 20
        '
        'colComplemento
        '
        Me.colComplemento.Caption = "Complemento"
        Me.colComplemento.ColumnEdit = Me.txtAlterar
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Visible = True
        Me.colComplemento.VisibleIndex = 21
        '
        'colNum
        '
        Me.colNum.Caption = "N°"
        Me.colNum.ColumnEdit = Me.txtAlterar
        Me.colNum.FieldName = "Num"
        Me.colNum.Name = "colNum"
        Me.colNum.OptionsColumn.ReadOnly = True
        Me.colNum.Visible = True
        Me.colNum.VisibleIndex = 22
        '
        'colBanco
        '
        Me.colBanco.AppearanceCell.Options.UseTextOptions = True
        Me.colBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBanco.Caption = "Banco"
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.ReadOnly = True
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 23
        '
        'colAgencia
        '
        Me.colAgencia.AppearanceCell.Options.UseTextOptions = True
        Me.colAgencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgencia.Caption = "Agência"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 24
        '
        'colContaCorrente
        '
        Me.colContaCorrente.AppearanceCell.Options.UseTextOptions = True
        Me.colContaCorrente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContaCorrente.Caption = "Conta Corrente"
        Me.colContaCorrente.FieldName = "ContaCorrente"
        Me.colContaCorrente.Name = "colContaCorrente"
        Me.colContaCorrente.OptionsColumn.ReadOnly = True
        Me.colContaCorrente.Visible = True
        Me.colContaCorrente.VisibleIndex = 25
        '
        'colMeta
        '
        Me.colMeta.AppearanceCell.Options.UseTextOptions = True
        Me.colMeta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMeta.Caption = "Meta R$"
        Me.colMeta.FieldName = "Meta"
        Me.colMeta.Name = "colMeta"
        Me.colMeta.OptionsColumn.ReadOnly = True
        Me.colMeta.Visible = True
        Me.colMeta.VisibleIndex = 26
        '
        'colCodConfig
        '
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        '
        'colCodUser
        '
        Me.colCodUser.Caption = "Cód. Usuario"
        Me.colCodUser.ColumnEdit = Me.txtAlterar
        Me.colCodUser.FieldName = "CodUser"
        Me.colCodUser.Name = "colCodUser"
        Me.colCodUser.Visible = True
        Me.colCodUser.VisibleIndex = 27
        '
        'colComServ
        '
        Me.colComServ.Caption = "Com. Serv."
        Me.colComServ.FieldName = "ComServ"
        Me.colComServ.Name = "colComServ"
        Me.colComServ.OptionsColumn.ReadOnly = True
        Me.colComServ.Visible = True
        Me.colComServ.VisibleIndex = 28
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(316, 41)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "RG"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(579, 90)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Endereço"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(297, 142)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 20
        Me.LabelControl7.Text = "Celular"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(297, 90)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "Cidade"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(596, 116)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl10.TabIndex = 27
        Me.LabelControl10.Text = "Bairro"
        '
        'txtObs
        '
        Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObs.Location = New System.Drawing.Point(2, 20)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObs.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Size = New System.Drawing.Size(1004, 34)
        Me.txtObs.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.txtObs)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 219)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1008, 56)
        Me.GroupControl2.TabIndex = 25
        Me.GroupControl2.Text = "Observações"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'dtNasc
        '
        Me.dtNasc.EditValue = Nothing
        Me.dtNasc.EnterMoveNextControl = True
        Me.dtNasc.Location = New System.Drawing.Point(849, 12)
        Me.dtNasc.Name = "dtNasc"
        Me.dtNasc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtNasc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtNasc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNasc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtNasc.Size = New System.Drawing.Size(147, 20)
        Me.dtNasc.TabIndex = 2
        Me.dtNasc.Tag = "Dt. Nasc."
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(798, 15)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl12.TabIndex = 33
        Me.LabelControl12.Text = "Dt. Nasc."
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(589, 15)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl13.TabIndex = 35
        Me.LabelControl13.Text = "Função"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(565, 168)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl14.TabIndex = 37
        Me.LabelControl14.Text = "% Comissão"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(574, 41)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl15.TabIndex = 39
        Me.LabelControl15.Text = "Dt. Admis."
        '
        'dtAdim
        '
        Me.dtAdim.EditValue = Nothing
        Me.dtAdim.EnterMoveNextControl = True
        Me.dtAdim.Location = New System.Drawing.Point(630, 38)
        Me.dtAdim.Name = "dtAdim"
        Me.dtAdim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtAdim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtAdim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAdim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtAdim.Size = New System.Drawing.Size(140, 20)
        Me.dtAdim.TabIndex = 5
        Me.dtAdim.Tag = "Dt. Nasc."
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(793, 41)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl16.TabIndex = 41
        Me.LabelControl16.Text = "Dt. Demis."
        '
        'dtDemis
        '
        Me.dtDemis.EditValue = Nothing
        Me.dtDemis.EnterMoveNextControl = True
        Me.dtDemis.Location = New System.Drawing.Point(849, 38)
        Me.dtDemis.Name = "dtDemis"
        Me.dtDemis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtDemis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtDemis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDemis.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtDemis.Size = New System.Drawing.Size(147, 20)
        Me.dtDemis.TabIndex = 6
        Me.dtDemis.Tag = "Dt. Nasc."
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(596, 142)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl17.TabIndex = 43
        Me.LabelControl17.Text = "E-mail"
        '
        'rdgStatus
        '
        Me.rdgStatus.Location = New System.Drawing.Point(849, 165)
        Me.rdgStatus.Name = "rdgStatus"
        Me.rdgStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.rdgStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ativo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Inativo")})
        Me.rdgStatus.Size = New System.Drawing.Size(147, 20)
        Me.rdgStatus.TabIndex = 26
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(165, 168)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl18.TabIndex = 46
        Me.LabelControl18.Text = "Tip. Sang."
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(20, 168)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl19.TabIndex = 48
        Me.LabelControl19.Text = "Alergias"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(812, 168)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl20.TabIndex = 49
        Me.LabelControl20.Text = "Status"
        '
        'txtComPec
        '
        Me.txtComPec.CasasDecimais = 2
        Me.txtComPec.EnterMoveNextControl = True
        Me.txtComPec.Location = New System.Drawing.Point(630, 165)
        Me.txtComPec.Name = "txtComPec"
        Me.txtComPec.Numerico = True
        Me.txtComPec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComPec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComPec.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComPec.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComPec.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtComPec.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComPec.Properties.MaxLength = 15
        Me.txtComPec.Size = New System.Drawing.Size(140, 20)
        Me.txtComPec.TabIndex = 20
        Me.txtComPec.Tag = "% Comissão"
        '
        'txtTipSan
        '
        Me.txtTipSan.CasasDecimais = 0
        Me.txtTipSan.EnterMoveNextControl = True
        Me.txtTipSan.Location = New System.Drawing.Point(220, 165)
        Me.txtTipSan.Name = "txtTipSan"
        Me.txtTipSan.Numerico = False
        Me.txtTipSan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipSan.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTipSan.Properties.MaxLength = 15
        Me.txtTipSan.Size = New System.Drawing.Size(59, 20)
        Me.txtTipSan.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.CasasDecimais = 0
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(630, 139)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Numerico = False
        Me.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Properties.MaxLength = 50
        Me.txtEmail.Size = New System.Drawing.Size(366, 20)
        Me.txtEmail.TabIndex = 16
        '
        'txtFun
        '
        Me.txtFun.CasasDecimais = 0
        Me.txtFun.EnterMoveNextControl = True
        Me.txtFun.Location = New System.Drawing.Point(630, 12)
        Me.txtFun.Name = "txtFun"
        Me.txtFun.Numerico = False
        Me.txtFun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFun.Properties.MaxLength = 25
        Me.txtFun.Size = New System.Drawing.Size(140, 20)
        Me.txtFun.TabIndex = 1
        '
        'txtAler
        '
        Me.txtAler.CasasDecimais = 0
        Me.txtAler.EnterMoveNextControl = True
        Me.txtAler.Location = New System.Drawing.Point(64, 165)
        Me.txtAler.Name = "txtAler"
        Me.txtAler.Numerico = False
        Me.txtAler.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAler.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAler.Properties.MaxLength = 80
        Me.txtAler.Size = New System.Drawing.Size(96, 20)
        Me.txtAler.TabIndex = 17
        '
        'txtCel
        '
        Me.txtCel.CasasDecimais = 0
        Me.txtCel.EnterMoveNextControl = True
        Me.txtCel.Location = New System.Drawing.Point(336, 139)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Numerico = False
        Me.txtCel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCel.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCel.Properties.MaxLength = 18
        Me.txtCel.Size = New System.Drawing.Size(210, 20)
        Me.txtCel.TabIndex = 15
        '
        'txtTel
        '
        Me.txtTel.CasasDecimais = 0
        Me.txtTel.EnterMoveNextControl = True
        Me.txtTel.Location = New System.Drawing.Point(64, 139)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Numerico = False
        Me.txtTel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel.Properties.MaxLength = 18
        Me.txtTel.Size = New System.Drawing.Size(215, 20)
        Me.txtTel.TabIndex = 14
        '
        'txtBai
        '
        Me.txtBai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBai.CasasDecimais = 0
        Me.txtBai.EnterMoveNextControl = True
        Me.txtBai.Location = New System.Drawing.Point(630, 113)
        Me.txtBai.Name = "txtBai"
        Me.txtBai.Numerico = False
        Me.txtBai.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBai.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBai.Properties.MaxLength = 80
        Me.txtBai.Size = New System.Drawing.Size(366, 20)
        Me.txtBai.TabIndex = 13
        '
        'txtEnd
        '
        Me.txtEnd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnd.CasasDecimais = 0
        Me.txtEnd.EnterMoveNextControl = True
        Me.txtEnd.Location = New System.Drawing.Point(630, 87)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Numerico = False
        Me.txtEnd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEnd.Properties.MaxLength = 100
        Me.txtEnd.Size = New System.Drawing.Size(366, 20)
        Me.txtEnd.TabIndex = 10
        '
        'txtRG
        '
        Me.txtRG.CasasDecimais = 0
        Me.txtRG.EnterMoveNextControl = True
        Me.txtRG.Location = New System.Drawing.Point(336, 38)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Numerico = False
        Me.txtRG.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRG.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRG.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRG.Properties.MaxLength = 12
        Me.txtRG.Size = New System.Drawing.Size(210, 20)
        Me.txtRG.TabIndex = 4
        '
        'txtCpf
        '
        Me.txtCpf.CasasDecimais = 0
        Me.txtCpf.EnterMoveNextControl = True
        Me.txtCpf.Location = New System.Drawing.Point(64, 38)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Numerico = False
        Me.txtCpf.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCpf.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCpf.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCpf.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCpf.Properties.MaxLength = 20
        Me.txtCpf.Size = New System.Drawing.Size(215, 20)
        Me.txtCpf.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(64, 12)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.MaxLength = 100
        Me.txtNome.Size = New System.Drawing.Size(482, 20)
        Me.txtNome.TabIndex = 0
        '
        'cboCidade
        '
        Me.cboCidade.EnterMoveNextControl = True
        Me.cboCidade.Location = New System.Drawing.Point(336, 87)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCidade.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCidade.Properties.MaxLength = 50
        Me.cboCidade.Size = New System.Drawing.Size(210, 20)
        Me.cboCidade.TabIndex = 9
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(201, 90)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl21.TabIndex = 65
        Me.LabelControl21.Text = "UF"
        '
        'cboUF
        '
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(220, 87)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Size = New System.Drawing.Size(59, 20)
        Me.cboUF.TabIndex = 8
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(46, 116)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl22.TabIndex = 67
        Me.LabelControl22.Text = "N°"
        '
        'txtNum
        '
        Me.txtNum.CasasDecimais = 0
        Me.txtNum.EnterMoveNextControl = True
        Me.txtNum.Location = New System.Drawing.Point(64, 113)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Numerico = True
        Me.txtNum.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNum.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNum.Properties.MaxLength = 10
        Me.txtNum.Size = New System.Drawing.Size(96, 20)
        Me.txtNum.TabIndex = 11
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(39, 90)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl11.TabIndex = 69
        Me.LabelControl11.Text = "CEP"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(183, 116)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl23.TabIndex = 70
        Me.LabelControl23.Text = "Comp."
        '
        'txtCep
        '
        Me.txtCep.CasasDecimais = 0
        Me.txtCep.EnterMoveNextControl = True
        Me.txtCep.Location = New System.Drawing.Point(64, 87)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Numerico = False
        Me.txtCep.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCep.Properties.MaxLength = 10
        Me.txtCep.Size = New System.Drawing.Size(96, 20)
        Me.txtCep.TabIndex = 7
        '
        'txtComp
        '
        Me.txtComp.CasasDecimais = 0
        Me.txtComp.EnterMoveNextControl = True
        Me.txtComp.Location = New System.Drawing.Point(220, 113)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Numerico = False
        Me.txtComp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComp.Properties.MaxLength = 50
        Me.txtComp.Size = New System.Drawing.Size(326, 20)
        Me.txtComp.TabIndex = 12
        '
        'chkCPF
        '
        Me.chkCPF.Location = New System.Drawing.Point(261, 39)
        Me.chkCPF.Name = "chkCPF"
        Me.chkCPF.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkCPF.Properties.Appearance.Options.UseBackColor = True
        Me.chkCPF.Properties.Caption = ""
        Me.chkCPF.Size = New System.Drawing.Size(17, 19)
        Me.chkCPF.TabIndex = 109
        Me.chkCPF.ToolTip = "Selecione para alterar"
        Me.chkCPF.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkCPF.ToolTipTitle = "Alterar CPF"
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(29, 194)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl49.TabIndex = 125
        Me.LabelControl49.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.CasasDecimais = 0
        Me.txtBanco.EnterMoveNextControl = True
        Me.txtBanco.Location = New System.Drawing.Point(64, 191)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Numerico = False
        Me.txtBanco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBanco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBanco.Properties.MaxLength = 50
        Me.txtBanco.Size = New System.Drawing.Size(96, 20)
        Me.txtBanco.TabIndex = 22
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(287, 194)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl48.TabIndex = 123
        Me.LabelControl48.Text = "Conta C."
        '
        'txtContaCorrente
        '
        Me.txtContaCorrente.CasasDecimais = 0
        Me.txtContaCorrente.EnterMoveNextControl = True
        Me.txtContaCorrente.Location = New System.Drawing.Point(336, 191)
        Me.txtContaCorrente.Name = "txtContaCorrente"
        Me.txtContaCorrente.Numerico = False
        Me.txtContaCorrente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContaCorrente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContaCorrente.Properties.MaxLength = 10
        Me.txtContaCorrente.Size = New System.Drawing.Size(95, 20)
        Me.txtContaCorrente.TabIndex = 24
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(176, 194)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl47.TabIndex = 121
        Me.LabelControl47.Text = "Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.CasasDecimais = 0
        Me.txtAgencia.EnterMoveNextControl = True
        Me.txtAgencia.Location = New System.Drawing.Point(220, 191)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Numerico = False
        Me.txtAgencia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAgencia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAgencia.Properties.MaxLength = 10
        Me.txtAgencia.Size = New System.Drawing.Size(59, 20)
        Me.txtAgencia.TabIndex = 23
        '
        'txtMeta
        '
        Me.txtMeta.CasasDecimais = 2
        Me.txtMeta.EnterMoveNextControl = True
        Me.txtMeta.Location = New System.Drawing.Point(336, 165)
        Me.txtMeta.Name = "txtMeta"
        Me.txtMeta.Numerico = True
        Me.txtMeta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMeta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMeta.Size = New System.Drawing.Size(210, 20)
        Me.txtMeta.TabIndex = 19
        Me.txtMeta.Tag = "% Comissão"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(290, 168)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl8.TabIndex = 127
        Me.LabelControl8.Text = "Meta R$"
        '
        'lblLoja
        '
        Me.lblLoja.Location = New System.Drawing.Point(823, 194)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(20, 13)
        Me.lblLoja.TabIndex = 129
        Me.lblLoja.Text = "Loja"
        '
        'lueLoja
        '
        Me.lueLoja.EnterMoveNextControl = True
        Me.lueLoja.Location = New System.Drawing.Point(849, 191)
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.Properties.DataSource = Me.ConfigBindingSource
        Me.lueLoja.Properties.DisplayMember = "Descricao"
        Me.lueLoja.Properties.NullText = ""
        Me.lueLoja.Properties.ValueMember = "Codigo"
        Me.lueLoja.Size = New System.Drawing.Size(147, 20)
        Me.lueLoja.TabIndex = 27
        Me.lueLoja.Tag = "Loja"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(549, 191)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 131
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(437, 194)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl25.TabIndex = 133
        Me.LabelControl25.Text = "Cod. User"
        '
        'NanoCampo1
        '
        Me.NanoCampo1.CasasDecimais = 0
        Me.NanoCampo1.EnterMoveNextControl = True
        Me.NanoCampo1.Location = New System.Drawing.Point(491, 191)
        Me.NanoCampo1.Name = "NanoCampo1"
        Me.NanoCampo1.Numerico = False
        Me.NanoCampo1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.NanoCampo1.Properties.Appearance.Options.UseBackColor = True
        Me.NanoCampo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo1.Properties.MaxLength = 10
        Me.NanoCampo1.Size = New System.Drawing.Size(55, 20)
        Me.NanoCampo1.TabIndex = 25
        '
        'txtComServ
        '
        Me.txtComServ.CasasDecimais = 2
        Me.txtComServ.EnterMoveNextControl = True
        Me.txtComServ.Location = New System.Drawing.Point(630, 191)
        Me.txtComServ.Name = "txtComServ"
        Me.txtComServ.Numerico = True
        Me.txtComServ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComServ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComServ.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComServ.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComServ.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtComServ.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComServ.Properties.MaxLength = 15
        Me.txtComServ.Size = New System.Drawing.Size(140, 20)
        Me.txtComServ.TabIndex = 21
        Me.txtComServ.Tag = "% Serviço"
        '
        'lblComServ
        '
        Me.lblComServ.Location = New System.Drawing.Point(575, 194)
        Me.lblComServ.Name = "lblComServ"
        Me.lblComServ.Size = New System.Drawing.Size(49, 13)
        Me.lblComServ.TabIndex = 136
        Me.lblComServ.Text = "% Serviço"
        '
        'frmCadFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.txtComServ)
        Me.Controls.Add(Me.lblComServ)
        Me.Controls.Add(Me.NanoCampo1)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.lblLoja)
        Me.Controls.Add(Me.lueLoja)
        Me.Controls.Add(Me.txtMeta)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl49)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.LabelControl48)
        Me.Controls.Add(Me.txtContaCorrente)
        Me.Controls.Add(Me.LabelControl47)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.chkCPF)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.LabelControl23)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.cboCidade)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtBai)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.txtAler)
        Me.Controls.Add(Me.txtFun)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTipSan)
        Me.Controls.Add(Me.txtComPec)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.rdgStatus)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.dtDemis)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.dtAdim)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.dtNasc)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCadFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionário"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtQtdFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAdim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAdim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDemis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDemis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComPec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipSan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCpf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComServ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsNano As Nano.dsNano
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoTableAdapters.FuncionarioTableAdapter
    Friend WithEvents FuncionarioGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNascimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtNasc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colFuncao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colPorcComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtAdim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colDataAdmissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDemis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rdgStatus As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDataDemissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSangue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlergia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents txtCpf As Campos.NanoCampo
    Friend WithEvents txtRG As Campos.NanoCampo
    Friend WithEvents txtEnd As Campos.NanoCampo
    Friend WithEvents txtBai As Campos.NanoCampo
    Friend WithEvents txtTel As Campos.NanoCampo
    Friend WithEvents txtCel As Campos.NanoCampo
    Friend WithEvents txtAler As Campos.NanoCampo
    Friend WithEvents txtFun As Campos.NanoCampo
    Friend WithEvents txtEmail As Campos.NanoCampo
    Friend WithEvents txtTipSan As Campos.NanoCampo
    Friend WithEvents txtComPec As Campos.NanoCampo
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNum As Campos.NanoCampo
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComp As Campos.NanoCampo
    Friend WithEvents txtCep As Campos.NanoCampo
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCEP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCPF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanco As Campos.NanoCampo
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContaCorrente As Campos.NanoCampo
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgencia As Campos.NanoCampo
    Friend WithEvents txtMeta As Campos.NanoCampo
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContaCorrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblLoja As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLoja As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdFun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NanoCampo1 As Campos.NanoCampo
    Friend WithEvents colCodUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtComServ As Campos.NanoCampo
    Friend WithEvents lblComServ As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colComServ As DevExpress.XtraGrid.Columns.GridColumn
End Class
