<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFornecedor
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFornecedor))
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFantasia = New Campos.NanoCampo
        Me.txtNome = New Campos.NanoCampo
        Me.txtContato = New Campos.NanoCampo
        Me.txtCep = New Campos.NanoCampo
        Me.txtTel2 = New Campos.NanoCampo
        Me.txtTel1 = New Campos.NanoCampo
        Me.txtBairro = New Campos.NanoCampo
        Me.txtComp = New Campos.NanoCampo
        Me.txtNum = New Campos.NanoCampo
        Me.txtEnd = New Campos.NanoCampo
        Me.txtIE = New Campos.NanoCampo
        Me.txtCPF = New Campos.NanoCampo
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.cboCidade = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup
        Me.lblFor = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtTel3 = New Campos.NanoCampo
        Me.txtTelRep1 = New Campos.NanoCampo
        Me.txtTelRep2 = New Campos.NanoCampo
        Me.txtNomeRep = New Campos.NanoCampo
        Me.txtWeb2 = New Campos.NanoCampo
        Me.txtWeb1 = New Campos.NanoCampo
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.abaFor = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.btnConCPF = New DevExpress.XtraEditors.SimpleButton
        Me.dtNasc = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodMun = New Campos.NanoCampo
        Me.lblCodMun = New DevExpress.XtraEditors.LabelControl
        Me.chkCPF = New DevExpress.XtraEditors.CheckEdit
        Me.chkIsento = New DevExpress.XtraEditors.CheckEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.txtWebRep = New Campos.NanoCampo
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.DsNano = New Nano.dsNano
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FornecedorTableAdapter = New Nano.dsNanoTableAdapters.FornecedorTableAdapter
        Me.FornecedorGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCelular = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContato = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNascimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdFor = New DevExpress.XtraEditors.TextEdit
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnDados = New DevExpress.XtraBars.BarButtonItem
        Me.btnDetalhado = New DevExpress.XtraBars.BarButtonItem
        Me.btnCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.chkInativar = New DevExpress.XtraEditors.CheckEdit
        Me.memObs = New DevExpress.XtraEditors.MemoEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtFantasia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelRep1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelRep2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeb2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeb1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.abaFor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.abaFor.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtWebRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedorGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtQtdFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colInativo
        '
        Me.colInativo.Caption = "Inativo"
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        Me.colInativo.OptionsColumn.ReadOnly = True
        Me.colInativo.Visible = True
        Me.colInativo.VisibleIndex = 21
        '
        'txtFantasia
        '
        Me.txtFantasia.CasasDecimais = 0
        Me.txtFantasia.EnterMoveNextControl = True
        Me.txtFantasia.Location = New System.Drawing.Point(633, 8)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Numerico = False
        Me.txtFantasia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFantasia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFantasia.Properties.MaxLength = 80
        Me.txtFantasia.Size = New System.Drawing.Size(360, 20)
        Me.txtFantasia.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(112, 8)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.MaxLength = 100
        Me.txtNome.Size = New System.Drawing.Size(434, 20)
        Me.txtNome.TabIndex = 1
        Me.txtNome.Tag = "Nome"
        '
        'txtContato
        '
        Me.txtContato.CasasDecimais = 0
        Me.txtContato.EnterMoveNextControl = True
        Me.txtContato.Location = New System.Drawing.Point(633, 34)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Numerico = False
        Me.txtContato.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContato.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContato.Properties.MaxLength = 100
        Me.txtContato.Size = New System.Drawing.Size(200, 20)
        Me.txtContato.TabIndex = 5
        '
        'txtCep
        '
        Me.txtCep.CasasDecimais = 0
        Me.txtCep.EnterMoveNextControl = True
        Me.txtCep.Location = New System.Drawing.Point(112, 76)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Numerico = False
        Me.txtCep.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCep.Properties.MaxLength = 10
        Me.txtCep.Size = New System.Drawing.Size(100, 20)
        Me.txtCep.TabIndex = 7
        '
        'txtTel2
        '
        Me.txtTel2.CasasDecimais = 0
        Me.txtTel2.EnterMoveNextControl = True
        Me.txtTel2.Location = New System.Drawing.Point(367, 128)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Numerico = False
        Me.txtTel2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel2.Properties.MaxLength = 18
        Me.txtTel2.Size = New System.Drawing.Size(179, 20)
        Me.txtTel2.TabIndex = 16
        '
        'txtTel1
        '
        Me.txtTel1.CasasDecimais = 0
        Me.txtTel1.EnterMoveNextControl = True
        Me.txtTel1.Location = New System.Drawing.Point(112, 128)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Numerico = False
        Me.txtTel1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel1.Properties.MaxLength = 18
        Me.txtTel1.Size = New System.Drawing.Size(190, 20)
        Me.txtTel1.TabIndex = 15
        '
        'txtBairro
        '
        Me.txtBairro.CasasDecimais = 0
        Me.txtBairro.EnterMoveNextControl = True
        Me.txtBairro.Location = New System.Drawing.Point(633, 102)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Numerico = False
        Me.txtBairro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBairro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBairro.Properties.MaxLength = 80
        Me.txtBairro.Size = New System.Drawing.Size(200, 20)
        Me.txtBairro.TabIndex = 13
        '
        'txtComp
        '
        Me.txtComp.CasasDecimais = 0
        Me.txtComp.EnterMoveNextControl = True
        Me.txtComp.Location = New System.Drawing.Point(255, 102)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Numerico = False
        Me.txtComp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComp.Properties.MaxLength = 50
        Me.txtComp.Size = New System.Drawing.Size(291, 20)
        Me.txtComp.TabIndex = 12
        '
        'txtNum
        '
        Me.txtNum.CasasDecimais = 0
        Me.txtNum.EnterMoveNextControl = True
        Me.txtNum.Location = New System.Drawing.Point(112, 102)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Numerico = True
        Me.txtNum.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNum.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNum.Properties.MaxLength = 10
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 11
        Me.txtNum.Tag = "Número"
        '
        'txtEnd
        '
        Me.txtEnd.CasasDecimais = 0
        Me.txtEnd.EnterMoveNextControl = True
        Me.txtEnd.Location = New System.Drawing.Point(633, 76)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Numerico = False
        Me.txtEnd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEnd.Properties.MaxLength = 100
        Me.txtEnd.Size = New System.Drawing.Size(360, 20)
        Me.txtEnd.TabIndex = 10
        Me.txtEnd.Tag = "Endereço"
        '
        'txtIE
        '
        Me.txtIE.CasasDecimais = 0
        Me.txtIE.EnterMoveNextControl = True
        Me.txtIE.Location = New System.Drawing.Point(367, 34)
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Numerico = False
        Me.txtIE.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtIE.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIE.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtIE.Properties.MaxLength = 20
        Me.txtIE.Size = New System.Drawing.Size(179, 20)
        Me.txtIE.TabIndex = 4
        '
        'txtCPF
        '
        Me.txtCPF.CasasDecimais = 0
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(112, 34)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Numerico = False
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.MaxLength = 20
        Me.txtCPF.Size = New System.Drawing.Size(190, 20)
        Me.txtCPF.TabIndex = 3
        Me.txtCPF.Tag = "CPF/CNPJ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(582, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Endereço"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(328, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Cidade"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(87, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Cep"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(236, 79)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "UF"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(333, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "IE/RG"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(588, 37)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl6.TabIndex = 17
        Me.LabelControl6.Text = "Contato"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(556, 11)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Nome Fantasia"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(79, 11)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Nome"
        '
        'cboCidade
        '
        Me.cboCidade.EnterMoveNextControl = True
        Me.cboCidade.Location = New System.Drawing.Point(367, 76)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCidade.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCidade.Properties.MaxLength = 50
        Me.cboCidade.Size = New System.Drawing.Size(179, 20)
        Me.cboCidade.TabIndex = 9
        Me.cboCidade.Tag = "Cidade"
        '
        'cboUF
        '
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(255, 76)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(47, 20)
        Me.cboUF.TabIndex = 8
        '
        'rdgDoc
        '
        Me.rdgDoc.EditValue = True
        Me.rdgDoc.Location = New System.Drawing.Point(5, 34)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(101, 20)
        Me.rdgDoc.TabIndex = 3
        '
        'lblFor
        '
        Me.lblFor.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFor.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblFor.Appearance.Options.UseFont = True
        Me.lblFor.Appearance.Options.UseForeColor = True
        Me.lblFor.Location = New System.Drawing.Point(31, 57)
        Me.lblFor.Name = "lblFor"
        Me.lblFor.Size = New System.Drawing.Size(119, 13)
        Me.lblFor.TabIndex = 71
        Me.lblFor.Text = "Dados do Fornecedor"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(10, 63)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(985, 5)
        Me.PanelControl1.TabIndex = 70
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(596, 157)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 72
        Me.LabelControl10.Text = "Web 2"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(596, 131)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl11.TabIndex = 73
        Me.LabelControl11.Text = "Web 1"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(79, 157)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl12.TabIndex = 74
        Me.LabelControl12.Text = "Tel. 3"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(334, 131)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl13.TabIndex = 75
        Me.LabelControl13.Text = "Tel. 2"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(79, 131)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl14.TabIndex = 76
        Me.LabelControl14.Text = "Tel. 1"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(599, 105)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl15.TabIndex = 77
        Me.LabelControl15.Text = "Bairro"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(218, 105)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl16.TabIndex = 78
        Me.LabelControl16.Text = "Comp."
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(69, 105)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl17.TabIndex = 79
        Me.LabelControl17.Text = "Número"
        '
        'txtTel3
        '
        Me.txtTel3.CasasDecimais = 0
        Me.txtTel3.EnterMoveNextControl = True
        Me.txtTel3.Location = New System.Drawing.Point(112, 154)
        Me.txtTel3.Name = "txtTel3"
        Me.txtTel3.Numerico = False
        Me.txtTel3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel3.Properties.MaxLength = 18
        Me.txtTel3.Size = New System.Drawing.Size(190, 20)
        Me.txtTel3.TabIndex = 17
        '
        'txtTelRep1
        '
        Me.txtTelRep1.CasasDecimais = 0
        Me.txtTelRep1.EnterMoveNextControl = True
        Me.txtTelRep1.Location = New System.Drawing.Point(571, 8)
        Me.txtTelRep1.Name = "txtTelRep1"
        Me.txtTelRep1.Numerico = False
        Me.txtTelRep1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelRep1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelRep1.Properties.MaxLength = 18
        Me.txtTelRep1.Size = New System.Drawing.Size(180, 20)
        Me.txtTelRep1.TabIndex = 2
        '
        'txtTelRep2
        '
        Me.txtTelRep2.CasasDecimais = 0
        Me.txtTelRep2.EnterMoveNextControl = True
        Me.txtTelRep2.Location = New System.Drawing.Point(813, 8)
        Me.txtTelRep2.Name = "txtTelRep2"
        Me.txtTelRep2.Numerico = False
        Me.txtTelRep2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelRep2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelRep2.Properties.MaxLength = 18
        Me.txtTelRep2.Size = New System.Drawing.Size(180, 20)
        Me.txtTelRep2.TabIndex = 3
        '
        'txtNomeRep
        '
        Me.txtNomeRep.CasasDecimais = 0
        Me.txtNomeRep.EnterMoveNextControl = True
        Me.txtNomeRep.Location = New System.Drawing.Point(90, 8)
        Me.txtNomeRep.Name = "txtNomeRep"
        Me.txtNomeRep.Numerico = False
        Me.txtNomeRep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomeRep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomeRep.Properties.MaxLength = 100
        Me.txtNomeRep.Size = New System.Drawing.Size(418, 20)
        Me.txtNomeRep.TabIndex = 1
        '
        'txtWeb2
        '
        Me.txtWeb2.CasasDecimais = 0
        Me.txtWeb2.EnterMoveNextControl = True
        Me.txtWeb2.Location = New System.Drawing.Point(633, 154)
        Me.txtWeb2.Name = "txtWeb2"
        Me.txtWeb2.Numerico = False
        Me.txtWeb2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtWeb2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtWeb2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtWeb2.Properties.MaxLength = 50
        Me.txtWeb2.Size = New System.Drawing.Size(360, 20)
        Me.txtWeb2.TabIndex = 20
        '
        'txtWeb1
        '
        Me.txtWeb1.CasasDecimais = 0
        Me.txtWeb1.EnterMoveNextControl = True
        Me.txtWeb1.Location = New System.Drawing.Point(633, 128)
        Me.txtWeb1.Name = "txtWeb1"
        Me.txtWeb1.Numerico = False
        Me.txtWeb1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtWeb1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtWeb1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtWeb1.Properties.MaxLength = 50
        Me.txtWeb1.Size = New System.Drawing.Size(360, 20)
        Me.txtWeb1.TabIndex = 19
        '
        'cboStatus
        '
        Me.cboStatus.EnterMoveNextControl = True
        Me.cboStatus.Location = New System.Drawing.Point(367, 154)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.cboStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(98, 20)
        Me.cboStatus.TabIndex = 18
        Me.cboStatus.Tag = "Estado"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(330, 157)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl19.TabIndex = 105
        Me.LabelControl19.Text = "Status"
        '
        'abaFor
        '
        Me.abaFor.Dock = System.Windows.Forms.DockStyle.Top
        Me.abaFor.Location = New System.Drawing.Point(0, 0)
        Me.abaFor.Name = "abaFor"
        Me.abaFor.SelectedTabPage = Me.XtraTabPage1
        Me.abaFor.Size = New System.Drawing.Size(1008, 211)
        Me.abaFor.TabIndex = 0
        Me.abaFor.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnConCPF)
        Me.XtraTabPage1.Controls.Add(Me.dtNasc)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.txtCodMun)
        Me.XtraTabPage1.Controls.Add(Me.lblCodMun)
        Me.XtraTabPage1.Controls.Add(Me.chkCPF)
        Me.XtraTabPage1.Controls.Add(Me.chkIsento)
        Me.XtraTabPage1.Controls.Add(Me.cboCidade)
        Me.XtraTabPage1.Controls.Add(Me.cboStatus)
        Me.XtraTabPage1.Controls.Add(Me.txtFantasia)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage1.Controls.Add(Me.txtNome)
        Me.XtraTabPage1.Controls.Add(Me.txtWeb1)
        Me.XtraTabPage1.Controls.Add(Me.txtContato)
        Me.XtraTabPage1.Controls.Add(Me.txtWeb2)
        Me.XtraTabPage1.Controls.Add(Me.txtCep)
        Me.XtraTabPage1.Controls.Add(Me.txtTel2)
        Me.XtraTabPage1.Controls.Add(Me.txtTel1)
        Me.XtraTabPage1.Controls.Add(Me.txtBairro)
        Me.XtraTabPage1.Controls.Add(Me.txtTel3)
        Me.XtraTabPage1.Controls.Add(Me.txtComp)
        Me.XtraTabPage1.Controls.Add(Me.txtNum)
        Me.XtraTabPage1.Controls.Add(Me.txtEnd)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage1.Controls.Add(Me.txtIE)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage1.Controls.Add(Me.txtCPF)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.lblFor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.rdgDoc)
        Me.XtraTabPage1.Controls.Add(Me.cboUF)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(999, 180)
        Me.XtraTabPage1.Text = "Principal"
        '
        'btnConCPF
        '
        Me.btnConCPF.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConCPF.Location = New System.Drawing.Point(303, 34)
        Me.btnConCPF.Name = "btnConCPF"
        Me.btnConCPF.Size = New System.Drawing.Size(22, 20)
        ToolTipTitleItem1.Text = "Busca CPF/CNPJ"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnConCPF.SuperTip = SuperToolTip1
        Me.btnConCPF.TabIndex = 114
        '
        'dtNasc
        '
        Me.dtNasc.EditValue = ""
        Me.dtNasc.EnterMoveNextControl = True
        Me.dtNasc.Location = New System.Drawing.Point(895, 34)
        Me.dtNasc.Name = "dtNasc"
        Me.dtNasc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtNasc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtNasc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNasc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtNasc.Size = New System.Drawing.Size(98, 20)
        Me.dtNasc.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(852, 37)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl9.TabIndex = 113
        Me.LabelControl9.Text = "Nascim."
        '
        'txtCodMun
        '
        Me.txtCodMun.CasasDecimais = 0
        Me.txtCodMun.EnterMoveNextControl = True
        Me.txtCodMun.Location = New System.Drawing.Point(895, 102)
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Numerico = True
        Me.txtCodMun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodMun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodMun.Properties.MaxLength = 10
        Me.txtCodMun.Size = New System.Drawing.Size(98, 20)
        Me.txtCodMun.TabIndex = 14
        Me.txtCodMun.Tag = "Número"
        Me.txtCodMun.Visible = False
        '
        'lblCodMun
        '
        Me.lblCodMun.Location = New System.Drawing.Point(839, 105)
        Me.lblCodMun.Name = "lblCodMun"
        Me.lblCodMun.Size = New System.Drawing.Size(50, 13)
        Me.lblCodMun.TabIndex = 111
        Me.lblCodMun.Text = "Cód. Mun."
        Me.lblCodMun.Visible = False
        '
        'chkCPF
        '
        Me.chkCPF.Location = New System.Drawing.Point(283, 35)
        Me.chkCPF.Name = "chkCPF"
        Me.chkCPF.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkCPF.Properties.Appearance.Options.UseBackColor = True
        Me.chkCPF.Properties.Caption = ""
        Me.chkCPF.Size = New System.Drawing.Size(17, 19)
        Me.chkCPF.TabIndex = 108
        Me.chkCPF.ToolTip = "Selecione para alterar"
        Me.chkCPF.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkCPF.ToolTipTitle = "Alterar CPF/CNPJ"
        '
        'chkIsento
        '
        Me.chkIsento.Location = New System.Drawing.Point(527, 35)
        Me.chkIsento.Name = "chkIsento"
        Me.chkIsento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkIsento.Properties.Appearance.Options.UseBackColor = True
        Me.chkIsento.Properties.Caption = ""
        Me.chkIsento.Size = New System.Drawing.Size(17, 19)
        Me.chkIsento.TabIndex = 109
        Me.chkIsento.ToolTip = "Selecione se for Isento"
        Me.chkIsento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkIsento.ToolTipTitle = "Isento"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtWebRep)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl20)
        Me.XtraTabPage2.Controls.Add(Me.txtNomeRep)
        Me.XtraTabPage2.Controls.Add(Me.txtTelRep1)
        Me.XtraTabPage2.Controls.Add(Me.txtTelRep2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(999, 180)
        Me.XtraTabPage2.Text = "Representante"
        '
        'txtWebRep
        '
        Me.txtWebRep.CasasDecimais = 0
        Me.txtWebRep.EnterMoveNextControl = True
        Me.txtWebRep.Location = New System.Drawing.Point(90, 37)
        Me.txtWebRep.Name = "txtWebRep"
        Me.txtWebRep.Numerico = False
        Me.txtWebRep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtWebRep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtWebRep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtWebRep.Properties.MaxLength = 50
        Me.txtWebRep.Size = New System.Drawing.Size(418, 20)
        Me.txtWebRep.TabIndex = 4
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(57, 11)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl23.TabIndex = 89
        Me.LabelControl23.Text = "Nome"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(538, 11)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl22.TabIndex = 88
        Me.LabelControl22.Text = "Tel. 1"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(780, 11)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl21.TabIndex = 87
        Me.LabelControl21.Text = "Tel. 2"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(62, 40)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl20.TabIndex = 86
        Me.LabelControl20.Text = "Web"
        '
        'DsNano
        '
        Me.DsNano.DataSetName = "dsNano"
        Me.DsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FornecedorBindingSource
        '
        Me.FornecedorBindingSource.DataMember = "Fornecedor"
        Me.FornecedorBindingSource.DataSource = Me.DsNano
        '
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'FornecedorGridControl
        '
        Me.FornecedorGridControl.DataSource = Me.FornecedorBindingSource
        Me.FornecedorGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FornecedorGridControl.EmbeddedNavigator.Name = ""
        Me.FornecedorGridControl.Location = New System.Drawing.Point(2, 2)
        Me.FornecedorGridControl.MainView = Me.grd1
        Me.FornecedorGridControl.Name = "FornecedorGridControl"
        Me.FornecedorGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.FornecedorGridControl.Size = New System.Drawing.Size(1000, 300)
        Me.FornecedorGridControl.TabIndex = 107
        Me.FornecedorGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colCPF, Me.colEndereco, Me.colNumero, Me.colComplemento, Me.colBairro, Me.colCep, Me.colCidade, Me.colEstado, Me.colTelefone, Me.colFax, Me.colCelular, Me.colEmail, Me.colData, Me.colIE, Me.colContato, Me.colSite, Me.colFantasia, Me.colStatus, Me.colObs, Me.colInativo, Me.colNascimento})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Gray
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colInativo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.FornecedorGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
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
        Me.colNome.Width = 320
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.AppearanceHeader.Options.UseTextOptions = True
        Me.colCPF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.ColumnEdit = Me.txtAlterar
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 3
        Me.colCPF.Width = 148
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.ColumnEdit = Me.txtAlterar
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.OptionsColumn.ReadOnly = True
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 7
        Me.colEndereco.Width = 292
        '
        'colNumero
        '
        Me.colNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.Caption = "Número"
        Me.colNumero.ColumnEdit = Me.txtAlterar
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 8
        '
        'colComplemento
        '
        Me.colComplemento.Caption = "Complemento"
        Me.colComplemento.ColumnEdit = Me.txtAlterar
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Visible = True
        Me.colComplemento.VisibleIndex = 10
        Me.colComplemento.Width = 176
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
        Me.colBairro.Width = 204
        '
        'colCep
        '
        Me.colCep.AppearanceCell.Options.UseTextOptions = True
        Me.colCep.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCep.AppearanceHeader.Options.UseTextOptions = True
        Me.colCep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCep.Caption = "Cep"
        Me.colCep.ColumnEdit = Me.txtAlterar
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.OptionsColumn.ReadOnly = True
        Me.colCep.Visible = True
        Me.colCep.VisibleIndex = 6
        Me.colCep.Width = 84
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.ColumnEdit = Me.txtAlterar
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        Me.colCidade.Visible = True
        Me.colCidade.VisibleIndex = 11
        Me.colCidade.Width = 185
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "Estado"
        Me.colEstado.ColumnEdit = Me.txtAlterar
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 12
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.AppearanceHeader.Options.UseTextOptions = True
        Me.colTelefone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.Caption = "Tel. 1"
        Me.colTelefone.ColumnEdit = Me.txtAlterar
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 13
        Me.colTelefone.Width = 151
        '
        'colFax
        '
        Me.colFax.AppearanceCell.Options.UseTextOptions = True
        Me.colFax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFax.AppearanceHeader.Options.UseTextOptions = True
        Me.colFax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFax.Caption = "Tel. 2"
        Me.colFax.ColumnEdit = Me.txtAlterar
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.ReadOnly = True
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 14
        Me.colFax.Width = 154
        '
        'colCelular
        '
        Me.colCelular.AppearanceCell.Options.UseTextOptions = True
        Me.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCelular.AppearanceHeader.Options.UseTextOptions = True
        Me.colCelular.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCelular.Caption = "Tel. 3"
        Me.colCelular.ColumnEdit = Me.txtAlterar
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.OptionsColumn.ReadOnly = True
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 15
        Me.colCelular.Width = 153
        '
        'colEmail
        '
        Me.colEmail.Caption = "Web 1"
        Me.colEmail.ColumnEdit = Me.txtAlterar
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 16
        Me.colEmail.Width = 236
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.Options.UseTextOptions = True
        Me.colData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 18
        Me.colData.Width = 138
        '
        'colIE
        '
        Me.colIE.AppearanceCell.Options.UseTextOptions = True
        Me.colIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIE.AppearanceHeader.Options.UseTextOptions = True
        Me.colIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIE.Caption = "I.E./RG"
        Me.colIE.ColumnEdit = Me.txtAlterar
        Me.colIE.FieldName = "IE"
        Me.colIE.Name = "colIE"
        Me.colIE.OptionsColumn.ReadOnly = True
        Me.colIE.Visible = True
        Me.colIE.VisibleIndex = 4
        Me.colIE.Width = 155
        '
        'colContato
        '
        Me.colContato.AppearanceCell.Options.UseTextOptions = True
        Me.colContato.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContato.AppearanceHeader.Options.UseTextOptions = True
        Me.colContato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContato.Caption = "Contato"
        Me.colContato.ColumnEdit = Me.txtAlterar
        Me.colContato.FieldName = "Contato"
        Me.colContato.Name = "colContato"
        Me.colContato.OptionsColumn.ReadOnly = True
        Me.colContato.Visible = True
        Me.colContato.VisibleIndex = 5
        Me.colContato.Width = 150
        '
        'colSite
        '
        Me.colSite.Caption = "Web 2"
        Me.colSite.ColumnEdit = Me.txtAlterar
        Me.colSite.FieldName = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.OptionsColumn.ReadOnly = True
        Me.colSite.Visible = True
        Me.colSite.VisibleIndex = 17
        Me.colSite.Width = 228
        '
        'colFantasia
        '
        Me.colFantasia.Caption = "Nome Fantasia"
        Me.colFantasia.ColumnEdit = Me.txtAlterar
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.OptionsColumn.ReadOnly = True
        Me.colFantasia.Visible = True
        Me.colFantasia.VisibleIndex = 2
        Me.colFantasia.Width = 239
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.Caption = "Status"
        Me.colStatus.ColumnEdit = Me.txtAlterar
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 19
        Me.colStatus.Width = 83
        '
        'colObs
        '
        Me.colObs.Caption = "Obs"
        Me.colObs.ColumnEdit = Me.txtAlterar
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 20
        Me.colObs.Width = 141
        '
        'colNascimento
        '
        Me.colNascimento.Caption = "Nascimento"
        Me.colNascimento.FieldName = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.OptionsColumn.ReadOnly = True
        Me.colNascimento.Visible = True
        Me.colNascimento.VisibleIndex = 22
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 267)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 359)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Fornecedores Cadastrados"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Controls.Add(Me.txtQtdFor)
        Me.GroupControl3.Controls.Add(Me.btnPadrao)
        Me.GroupControl3.Controls.Add(Me.btnManter)
        Me.GroupControl3.Controls.Add(Me.FornecedorGridControl)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1004, 337)
        Me.GroupControl3.TabIndex = 108
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(742, 316)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(151, 13)
        Me.LabelControl18.TabIndex = 109
        Me.LabelControl18.Text = "Fornecedores Cadastrados"
        '
        'txtQtdFor
        '
        Me.txtQtdFor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdFor.Location = New System.Drawing.Point(899, 308)
        Me.txtQtdFor.Name = "txtQtdFor"
        Me.txtQtdFor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdFor.Properties.Appearance.Options.UseFont = True
        Me.txtQtdFor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdFor.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdFor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdFor.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdFor.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdFor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdFor.Properties.ReadOnly = True
        Me.txtQtdFor.Size = New System.Drawing.Size(95, 26)
        Me.txtQtdFor.TabIndex = 108
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(923, 19)
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
        Me.btnManter.Location = New System.Drawing.Point(923, 4)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar, Me.BarSubItem1, Me.btnDados, Me.btnDetalhado, Me.btnCust})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.BarSubItem1.Caption = "Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDados), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDetalhado, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCust, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnDados
        '
        Me.btnDados.Caption = "Dados"
        Me.btnDados.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnDados.Id = 6
        Me.btnDados.Name = "btnDados"
        '
        'btnDetalhado
        '
        Me.btnDetalhado.Caption = "Dados Detalhados"
        Me.btnDetalhado.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnDetalhado.Id = 7
        Me.btnDetalhado.Name = "btnDetalhado"
        '
        'btnCust
        '
        Me.btnCust.Caption = "Customizado"
        Me.btnCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnCust.Id = 8
        Me.btnCust.Name = "btnCust"
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
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.chkInativar)
        Me.GroupControl2.Controls.Add(Me.memObs)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 211)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1008, 56)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Observações"
        '
        'chkInativar
        '
        Me.chkInativar.Location = New System.Drawing.Point(103, 0)
        Me.chkInativar.Name = "chkInativar"
        Me.chkInativar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkInativar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkInativar.Properties.Appearance.Options.UseFont = True
        Me.chkInativar.Properties.Appearance.Options.UseForeColor = True
        Me.chkInativar.Properties.Caption = "Inativo"
        Me.chkInativar.Size = New System.Drawing.Size(66, 19)
        Me.chkInativar.TabIndex = 7
        '
        'memObs
        '
        Me.memObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memObs.Location = New System.Drawing.Point(2, 20)
        Me.memObs.Name = "memObs"
        Me.memObs.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.memObs.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.memObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memObs.Size = New System.Drawing.Size(1004, 34)
        Me.memObs.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'frmCadFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.abaFor)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCadFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedor"
        CType(Me.txtFantasia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelRep1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelRep2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeb2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeb1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.abaFor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.abaFor.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtWebRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedorGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtQtdFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFantasia As Campos.NanoCampo
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents txtContato As Campos.NanoCampo
    Friend WithEvents txtCep As Campos.NanoCampo
    Friend WithEvents txtTel2 As Campos.NanoCampo
    Friend WithEvents txtTel1 As Campos.NanoCampo
    Friend WithEvents txtBairro As Campos.NanoCampo
    Friend WithEvents txtComp As Campos.NanoCampo
    Friend WithEvents txtNum As Campos.NanoCampo
    Friend WithEvents txtEnd As Campos.NanoCampo
    Friend WithEvents txtIE As Campos.NanoCampo
    Friend WithEvents txtCPF As Campos.NanoCampo
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblFor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel3 As Campos.NanoCampo
    Friend WithEvents txtTelRep1 As Campos.NanoCampo
    Friend WithEvents txtTelRep2 As Campos.NanoCampo
    Friend WithEvents txtNomeRep As Campos.NanoCampo
    Friend WithEvents txtWeb2 As Campos.NanoCampo
    Friend WithEvents txtWeb1 As Campos.NanoCampo
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents abaFor As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWebRep As Campos.NanoCampo
    Friend WithEvents DsNano As Nano.dsNano
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As Nano.dsNanoTableAdapters.FornecedorTableAdapter
    Friend WithEvents FornecedorGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents chkCPF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIsento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents memObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnDados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDetalhado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkInativar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodMun As Campos.NanoCampo
    Friend WithEvents lblCodMun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtNasc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConCPF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNascimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdFor As DevExpress.XtraEditors.TextEdit
End Class
