<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagar
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
        Dim TipoContaLabel As System.Windows.Forms.Label
        Dim FormaPagamentoLabel1 As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataServiçoLabel As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagar))
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rdgFim = New DevExpress.XtraEditors.RadioGroup
        Me.dtPag = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.seParcela = New DevExpress.XtraEditors.SpinEdit
        Me.dtVenc = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.cboTipConta = New DevExpress.XtraEditors.ComboBoxEdit
        Me.grpPag = New DevExpress.XtraEditors.GroupControl
        Me.btnSel = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cboVencimentos = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.lblTot = New DevExpress.XtraEditors.LabelControl
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtRecebido = New DevExpress.XtraEditors.TextEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContaPagarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTipoConta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcelas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagoOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colConta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstornar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.bComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnEstornar = New DevExpress.XtraBars.BarButtonItem
        Me.dtInicial1 = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelConta = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cboTipCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtFornecedor = New DevExpress.XtraEditors.ButtonEdit
        Me.txtValTotPag = New Campos.NanoCampo
        Me.txtValConta = New Campos.NanoCampo
        Me.btnCadBanco = New DevExpress.XtraEditors.SimpleButton
        Me.cboBanco = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.luePag = New DevExpress.XtraEditors.LookUpEdit
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCred = New System.Data.DataSet
        Me.tdCred = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.gridPar = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtVal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colVenc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lblVenc = New System.Windows.Forms.Label
        Me.lblNumPar = New System.Windows.Forms.Label
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.txtTotal = New Campos.NanoCampo
        Me.lblFimCont = New System.Windows.Forms.Label
        Me.ContaPagarTableAdapter = New Nano.dsNanoCommerceTableAdapters.ContaPagarTableAdapter
        Me.PagamentoTableAdapter = New Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.cboCenCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnCenCus = New DevExpress.XtraEditors.SimpleButton
        Me.txtDias = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.lblDtPag = New System.Windows.Forms.Label
        Me.lblValPag = New System.Windows.Forms.Label
        Me.dtConta = New DevExpress.XtraEditors.DateEdit
        Me.btnCTPagarNF = New DevExpress.XtraEditors.SimpleButton
        TipoContaLabel = New System.Windows.Forms.Label
        FormaPagamentoLabel1 = New System.Windows.Forms.Label
        ClienteLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        DataServiçoLabel = New System.Windows.Forms.Label
        CType(Me.rdgFim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPag.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPag.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboVencimentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecebido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaPagarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFornecedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValTotPag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtConta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoContaLabel
        '
        TipoContaLabel.AutoSize = True
        TipoContaLabel.Location = New System.Drawing.Point(43, 38)
        TipoContaLabel.Name = "TipoContaLabel"
        TipoContaLabel.Size = New System.Drawing.Size(74, 13)
        TipoContaLabel.TabIndex = 7
        TipoContaLabel.Text = "Tipo de Conta"
        '
        'FormaPagamentoLabel1
        '
        FormaPagamentoLabel1.AutoSize = True
        FormaPagamentoLabel1.Location = New System.Drawing.Point(247, 84)
        FormaPagamentoLabel1.Name = "FormaPagamentoLabel1"
        FormaPagamentoLabel1.Size = New System.Drawing.Size(94, 13)
        FormaPagamentoLabel1.TabIndex = 77
        FormaPagamentoLabel1.Text = "Forma Pagamento"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(55, 12)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(62, 13)
        ClienteLabel.TabIndex = 82
        ClienteLabel.Text = "Fornecedor"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(23, 84)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(94, 13)
        Label3.TabIndex = 84
        Label3.Text = "Valor da Conta R$"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(241, 38)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(100, 13)
        Label6.TabIndex = 101
        Label6.Text = "Custo Fixo/Variável"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(460, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 117
        Label1.Text = "Centro Custo"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(199, 170)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 111
        Label4.Text = "Total R$"
        '
        'DataServiçoLabel
        '
        DataServiçoLabel.AutoSize = True
        DataServiçoLabel.Location = New System.Drawing.Point(497, 12)
        DataServiçoLabel.Name = "DataServiçoLabel"
        DataServiçoLabel.Size = New System.Drawing.Size(30, 13)
        DataServiçoLabel.TabIndex = 122
        DataServiçoLabel.Text = "Data"
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceCell.Options.UseFont = True
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 8
        Me.colVencimento.Width = 96
        '
        'rdgFim
        '
        Me.rdgFim.Location = New System.Drawing.Point(533, 133)
        Me.rdgFim.Name = "rdgFim"
        Me.rdgFim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgFim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.rdgFim.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Parcial"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Total")})
        Me.rdgFim.Size = New System.Drawing.Size(136, 20)
        Me.rdgFim.TabIndex = 12
        Me.rdgFim.Tag = "Finalizar Conta?"
        Me.rdgFim.Visible = False
        '
        'dtPag
        '
        Me.dtPag.EditValue = Nothing
        Me.dtPag.EnterMoveNextControl = True
        Me.dtPag.Location = New System.Drawing.Point(123, 133)
        Me.dtPag.Name = "dtPag"
        Me.dtPag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtPag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtPag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPag.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtPag.Size = New System.Drawing.Size(99, 20)
        Me.dtPag.TabIndex = 10
        Me.dtPag.Tag = "Data Pagamento"
        Me.dtPag.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl1.TabIndex = 90
        Me.LabelControl1.Text = "Dados do Pagamento"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(5, 67)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(669, 5)
        Me.PanelControl2.TabIndex = 89
        '
        'seParcela
        '
        Me.seParcela.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seParcela.EnterMoveNextControl = True
        Me.seParcela.Location = New System.Drawing.Point(533, 107)
        Me.seParcela.Name = "seParcela"
        Me.seParcela.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seParcela.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.seParcela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seParcela.Properties.MaxLength = 2
        Me.seParcela.Size = New System.Drawing.Size(136, 20)
        Me.seParcela.TabIndex = 9
        Me.seParcela.Tag = "Nº Parcelas"
        '
        'dtVenc
        '
        Me.dtVenc.EditValue = Nothing
        Me.dtVenc.EnterMoveNextControl = True
        Me.dtVenc.Location = New System.Drawing.Point(123, 107)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtVenc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtVenc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVenc.Properties.Mask.IgnoreMaskBlank = False
        Me.dtVenc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVenc.Size = New System.Drawing.Size(99, 20)
        Me.dtVenc.TabIndex = 7
        Me.dtVenc.Tag = "Vencimento"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.txtDesc)
        Me.GroupControl3.Location = New System.Drawing.Point(2, 160)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(674, 68)
        Me.GroupControl3.TabIndex = 13
        Me.GroupControl3.Text = "Observações"
        '
        'txtDesc
        '
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.Location = New System.Drawing.Point(2, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Properties.MaxLength = 500
        Me.txtDesc.Size = New System.Drawing.Size(670, 46)
        Me.txtDesc.TabIndex = 0
        '
        'cboTipConta
        '
        Me.cboTipConta.EnterMoveNextControl = True
        Me.cboTipConta.Location = New System.Drawing.Point(123, 35)
        Me.cboTipConta.Name = "cboTipConta"
        Me.cboTipConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipConta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipConta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipConta.Properties.MaxLength = 24
        Me.cboTipConta.Size = New System.Drawing.Size(99, 20)
        Me.cboTipConta.TabIndex = 1
        Me.cboTipConta.Tag = "Tipo de Conta"
        '
        'grpPag
        '
        Me.grpPag.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPag.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPag.AppearanceCaption.Options.UseFont = True
        Me.grpPag.Controls.Add(Me.btnSel)
        Me.grpPag.Controls.Add(Me.GroupControl1)
        Me.grpPag.Location = New System.Drawing.Point(3, 229)
        Me.grpPag.Name = "grpPag"
        Me.grpPag.Size = New System.Drawing.Size(1003, 396)
        Me.grpPag.TabIndex = 14
        Me.grpPag.Text = "Contas Cadastradas"
        '
        'btnSel
        '
        Me.btnSel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnSel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSel.Appearance.Options.UseBackColor = True
        Me.btnSel.Appearance.Options.UseFont = True
        Me.btnSel.Appearance.Options.UseForeColor = True
        Me.btnSel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSel.Image = Global.Nano.My.Resources.Resources.db_add2
        Me.btnSel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnSel.Location = New System.Drawing.Point(128, 0)
        Me.btnSel.Name = "btnSel"
        Me.btnSel.Size = New System.Drawing.Size(91, 20)
        Me.btnSel.TabIndex = 135
        Me.btnSel.Text = "Selecionar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.cboVencimentos)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.lblTot)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.txtRecebido)
        Me.GroupControl1.Controls.Add(Me.Grid1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(999, 374)
        Me.GroupControl1.TabIndex = 1
        '
        'cboVencimentos
        '
        Me.cboVencimentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVencimentos.EditValue = "TODOS"
        Me.cboVencimentos.Location = New System.Drawing.Point(499, 346)
        Me.cboVencimentos.Name = "cboVencimentos"
        Me.cboVencimentos.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cboVencimentos.Properties.Appearance.Options.UseFont = True
        Me.cboVencimentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVencimentos.Properties.Items.AddRange(New Object() {"TODOS", "ATRASADOS", "HOJE", "EM DIA", "CADUCADOS"})
        Me.cboVencimentos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboVencimentos.Size = New System.Drawing.Size(134, 22)
        Me.cboVencimentos.TabIndex = 124
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(420, 350)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 123
        Me.LabelControl3.Text = "Vencimentos"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(920, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 122
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(920, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 121
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'lblTot
        '
        Me.lblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTot.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Appearance.Options.UseFont = True
        Me.lblTot.Location = New System.Drawing.Point(747, 351)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(93, 13)
        Me.lblTot.TabIndex = 77
        Me.lblTot.Text = "Total a Pagar R$"
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(639, 341)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(97, 28)
        Me.btnCalcular.TabIndex = 75
        Me.btnCalcular.Text = "Calcular"
        '
        'txtRecebido
        '
        Me.txtRecebido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecebido.Location = New System.Drawing.Point(846, 343)
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecebido.Properties.Appearance.Options.UseFont = True
        Me.txtRecebido.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtRecebido.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecebido.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtRecebido.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtRecebido.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtRecebido.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtRecebido.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtRecebido.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRecebido.Properties.ReadOnly = True
        Me.txtRecebido.Size = New System.Drawing.Size(144, 26)
        Me.txtRecebido.TabIndex = 73
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.ContaPagarBindingSource
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 2)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.lueLoja, Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(995, 333)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'ContaPagarBindingSource
        '
        Me.ContaPagarBindingSource.DataMember = "ContaPagar"
        Me.ContaPagarBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colFornecedor, Me.colTipoConta, Me.colValor, Me.colFormaPagamento, Me.colParcelas, Me.colValorParcela, Me.colVencimento, Me.colDataPagamento, Me.colValorPago, Me.colDescricao, Me.colPagoOK, Me.colPagamento, Me.colNumeroDocumento, Me.colTipoCusto, Me.colBanco, Me.colCodFor, Me.colCodConfig, Me.colCentroCusto, Me.colFantasia, Me.colVencido, Me.colConta, Me.colEstornar})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colVencimento
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colVencimento
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorParcela", Me.colValorParcela, "{0:c}")})
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
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colFornecedor
        '
        Me.colFornecedor.Caption = "Nome do Fornecedor"
        Me.colFornecedor.ColumnEdit = Me.txtAlterar
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.OptionsColumn.ReadOnly = True
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 1
        Me.colFornecedor.Width = 251
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colTipoConta
        '
        Me.colTipoConta.Caption = "Tipo de Conta"
        Me.colTipoConta.ColumnEdit = Me.txtAlterar
        Me.colTipoConta.FieldName = "TipoConta"
        Me.colTipoConta.Name = "colTipoConta"
        Me.colTipoConta.OptionsColumn.ReadOnly = True
        Me.colTipoConta.Visible = True
        Me.colTipoConta.VisibleIndex = 2
        Me.colTipoConta.Width = 89
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor da Conta R$"
        Me.colValor.ColumnEdit = Me.txtAlterar
        Me.colValor.DisplayFormat.FormatString = "c"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 107
        '
        'colFormaPagamento
        '
        Me.colFormaPagamento.Caption = "Forma Pagamento"
        Me.colFormaPagamento.ColumnEdit = Me.txtAlterar
        Me.colFormaPagamento.FieldName = "FormaPagamento"
        Me.colFormaPagamento.Name = "colFormaPagamento"
        Me.colFormaPagamento.OptionsColumn.ReadOnly = True
        Me.colFormaPagamento.Visible = True
        Me.colFormaPagamento.VisibleIndex = 5
        Me.colFormaPagamento.Width = 109
        '
        'colParcelas
        '
        Me.colParcelas.AppearanceCell.Options.UseTextOptions = True
        Me.colParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.Caption = "Nº Parcelas"
        Me.colParcelas.ColumnEdit = Me.txtAlterar
        Me.colParcelas.FieldName = "Parcelas"
        Me.colParcelas.Name = "colParcelas"
        Me.colParcelas.OptionsColumn.ReadOnly = True
        Me.colParcelas.Visible = True
        Me.colParcelas.VisibleIndex = 6
        Me.colParcelas.Width = 77
        '
        'colValorParcela
        '
        Me.colValorParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorParcela.Caption = "Valor Parcela R$"
        Me.colValorParcela.ColumnEdit = Me.txtAlterar
        Me.colValorParcela.DisplayFormat.FormatString = "c"
        Me.colValorParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorParcela.FieldName = "ValorParcela"
        Me.colValorParcela.Name = "colValorParcela"
        Me.colValorParcela.OptionsColumn.ReadOnly = True
        Me.colValorParcela.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorParcela.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorParcela.Visible = True
        Me.colValorParcela.VisibleIndex = 7
        Me.colValorParcela.Width = 100
        '
        'colDataPagamento
        '
        Me.colDataPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento.Caption = "Dt. Pagamento"
        Me.colDataPagamento.FieldName = "DataPagamento"
        Me.colDataPagamento.Name = "colDataPagamento"
        Me.colDataPagamento.OptionsColumn.ReadOnly = True
        Me.colDataPagamento.Visible = True
        Me.colDataPagamento.VisibleIndex = 9
        Me.colDataPagamento.Width = 97
        '
        'colValorPago
        '
        Me.colValorPago.AppearanceCell.Options.UseTextOptions = True
        Me.colValorPago.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorPago.Caption = "Valor Pago R$"
        Me.colValorPago.ColumnEdit = Me.txtAlterar
        Me.colValorPago.FieldName = "ValorPago"
        Me.colValorPago.Name = "colValorPago"
        Me.colValorPago.OptionsColumn.ReadOnly = True
        Me.colValorPago.Visible = True
        Me.colValorPago.VisibleIndex = 10
        Me.colValorPago.Width = 89
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.ColumnEdit = Me.txtAlterar
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 14
        Me.colDescricao.Width = 220
        '
        'colPagoOK
        '
        Me.colPagoOK.Caption = "Finalizada?"
        Me.colPagoOK.FieldName = "PagoOK"
        Me.colPagoOK.Name = "colPagoOK"
        Me.colPagoOK.OptionsColumn.ReadOnly = True
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.ColumnEdit = Me.txtAlterar
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.OptionsColumn.ReadOnly = True
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 11
        '
        'colNumeroDocumento
        '
        Me.colNumeroDocumento.Caption = "Nº Documento"
        Me.colNumeroDocumento.ColumnEdit = Me.txtAlterar
        Me.colNumeroDocumento.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento.Name = "colNumeroDocumento"
        Me.colNumeroDocumento.OptionsColumn.ReadOnly = True
        Me.colNumeroDocumento.Visible = True
        Me.colNumeroDocumento.VisibleIndex = 12
        Me.colNumeroDocumento.Width = 100
        '
        'colTipoCusto
        '
        Me.colTipoCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoCusto.Caption = "Tipo Custo"
        Me.colTipoCusto.ColumnEdit = Me.txtAlterar
        Me.colTipoCusto.FieldName = "TipoCusto"
        Me.colTipoCusto.Name = "colTipoCusto"
        Me.colTipoCusto.OptionsColumn.ReadOnly = True
        Me.colTipoCusto.Visible = True
        Me.colTipoCusto.VisibleIndex = 13
        Me.colTipoCusto.Width = 73
        '
        'colBanco
        '
        Me.colBanco.Caption = "Banco"
        Me.colBanco.ColumnEdit = Me.txtAlterar
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.ReadOnly = True
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 15
        Me.colBanco.Width = 141
        '
        'colCodFor
        '
        Me.colCodFor.Caption = "CodFor"
        Me.colCodFor.FieldName = "CodFor"
        Me.colCodFor.Name = "colCodFor"
        Me.colCodFor.Visible = True
        Me.colCodFor.VisibleIndex = 16
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 0
        Me.colCodConfig.Width = 64
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
        'colCentroCusto
        '
        Me.colCentroCusto.Caption = "Centro Custo"
        Me.colCentroCusto.FieldName = "CentroCusto"
        Me.colCentroCusto.Name = "colCentroCusto"
        Me.colCentroCusto.OptionsColumn.ReadOnly = True
        Me.colCentroCusto.Visible = True
        Me.colCentroCusto.VisibleIndex = 3
        Me.colCentroCusto.Width = 86
        '
        'colFantasia
        '
        Me.colFantasia.Caption = "Fantasia"
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.OptionsColumn.ReadOnly = True
        '
        'colVencido
        '
        Me.colVencido.Caption = "Vencimentos"
        Me.colVencido.FieldName = "Vencido"
        Me.colVencido.Name = "colVencido"
        Me.colVencido.OptionsColumn.ReadOnly = True
        Me.colVencido.Visible = True
        Me.colVencido.VisibleIndex = 17
        Me.colVencido.Width = 82
        '
        'colConta
        '
        Me.colConta.Caption = "Dt. Conta"
        Me.colConta.FieldName = "Data"
        Me.colConta.Name = "colConta"
        Me.colConta.OptionsColumn.ReadOnly = True
        Me.colConta.Visible = True
        Me.colConta.VisibleIndex = 18
        '
        'colEstornar
        '
        Me.colEstornar.Caption = "Estornar"
        Me.colEstornar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colEstornar.FieldName = "Estornar"
        Me.colEstornar.Name = "colEstornar"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'bComandos
        '
        Me.bComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bComandos.DockControls.Add(Me.barDockControlTop)
        Me.bComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bComandos.DockControls.Add(Me.barDockControlRight)
        Me.bComandos.Form = Me
        Me.bComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnCancelar, Me.dtInicial1, Me.dtFinal, Me.btnFiltrar, Me.bsiVisu, Me.btnRelConta, Me.btnRelCust, Me.btnEstornar})
        Me.bComandos.MaxItemId = 15
        Me.bComandos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.bComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEstornar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial1, "", True, True, True, 93, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 86, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnExcluir.Caption = "Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnEstornar
        '
        Me.btnEstornar.Caption = "&Estornar"
        Me.btnEstornar.Glyph = Global.Nano.My.Resources.Resources.Receber
        Me.btnEstornar.Id = 14
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'dtInicial1
        '
        Me.dtInicial1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.dtInicial1.Caption = "Data Inicial"
        Me.dtInicial1.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial1.Id = 5
        Me.dtInicial1.Name = "dtInicial1"
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
        Me.dtFinal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit2
        Me.dtFinal.Id = 6
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
        Me.btnFiltrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnFiltrar.Caption = "&Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 7
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 11
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelConta), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelConta
        '
        Me.btnRelConta.Caption = "Relatório de Contas a Pagar"
        Me.btnRelConta.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelConta.Id = 12
        Me.btnRelConta.Name = "btnRelConta"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 13
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "Limpar"
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
        'cboTipCus
        '
        Me.cboTipCus.EnterMoveNextControl = True
        Me.cboTipCus.Location = New System.Drawing.Point(347, 35)
        Me.cboTipCus.Name = "cboTipCus"
        Me.cboTipCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipCus.Properties.Items.AddRange(New Object() {"F", "V", "C"})
        Me.cboTipCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipCus.Size = New System.Drawing.Size(104, 20)
        Me.cboTipCus.TabIndex = 2
        Me.cboTipCus.Tag = "Forma Pagamento"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.EnterMoveNextControl = True
        Me.txtFornecedor.Location = New System.Drawing.Point(123, 9)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtFornecedor.Properties.Appearance.Options.UseForeColor = True
        Me.txtFornecedor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFornecedor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFornecedor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtFornecedor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFornecedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtFornecedor.Properties.ReadOnly = True
        Me.txtFornecedor.Size = New System.Drawing.Size(328, 20)
        Me.txtFornecedor.TabIndex = 0
        '
        'txtValTotPag
        '
        Me.txtValTotPag.CasasDecimais = 2
        Me.txtValTotPag.EnterMoveNextControl = True
        Me.txtValTotPag.Location = New System.Drawing.Point(347, 133)
        Me.txtValTotPag.Name = "txtValTotPag"
        Me.txtValTotPag.Numerico = True
        Me.txtValTotPag.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValTotPag.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValTotPag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValTotPag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValTotPag.Size = New System.Drawing.Size(104, 20)
        Me.txtValTotPag.TabIndex = 11
        Me.txtValTotPag.Visible = False
        '
        'txtValConta
        '
        Me.txtValConta.CasasDecimais = 2
        Me.txtValConta.EnterMoveNextControl = True
        Me.txtValConta.Location = New System.Drawing.Point(123, 81)
        Me.txtValConta.Name = "txtValConta"
        Me.txtValConta.Numerico = True
        Me.txtValConta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValConta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValConta.Size = New System.Drawing.Size(99, 20)
        Me.txtValConta.TabIndex = 4
        '
        'btnCadBanco
        '
        Me.btnCadBanco.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadBanco.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadBanco.Location = New System.Drawing.Point(651, 81)
        Me.btnCadBanco.Name = "btnCadBanco"
        Me.btnCadBanco.Size = New System.Drawing.Size(20, 20)
        Me.btnCadBanco.TabIndex = 107
        Me.btnCadBanco.Text = "SimpleButton1"
        '
        'cboBanco
        '
        Me.cboBanco.EnterMoveNextControl = True
        Me.cboBanco.Location = New System.Drawing.Point(533, 81)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboBanco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBanco.Properties.MaxLength = 55
        Me.cboBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBanco.Size = New System.Drawing.Size(118, 20)
        Me.cboBanco.TabIndex = 6
        Me.cboBanco.Tag = "Grupo"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(498, 84)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl20.TabIndex = 106
        Me.LabelControl20.Text = "Banco"
        '
        'luePag
        '
        Me.luePag.EnterMoveNextControl = True
        Me.luePag.Location = New System.Drawing.Point(347, 81)
        Me.luePag.Name = "luePag"
        Me.luePag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.luePag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePag.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormaPagamento", "Pagamento", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luePag.Properties.DataSource = Me.PagamentoBindingSource
        Me.luePag.Properties.DisplayMember = "Descricao"
        Me.luePag.Properties.NullText = ""
        Me.luePag.Properties.ValueMember = "Descricao"
        Me.luePag.Size = New System.Drawing.Size(104, 20)
        Me.luePag.TabIndex = 5
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'dsCred
        '
        Me.dsCred.DataSetName = "NewDataSet"
        Me.dsCred.Tables.AddRange(New System.Data.DataTable() {Me.tdCred})
        '
        'tdCred
        '
        Me.tdCred.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.tdCred.TableName = "tbCred"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Parcela"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Valor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Vencimento"
        Me.DataColumn3.DataType = GetType(Date)
        Me.DataColumn3.DateTimeMode = System.Data.DataSetDateTime.Local
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Documento"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "CodigoParcela"
        Me.DataColumn5.ColumnName = "CodigoParcela"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodigoFornecedor"
        '
        'gridPar
        '
        Me.gridPar.DataMember = "tbCred"
        Me.gridPar.DataSource = Me.dsCred
        Me.gridPar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPar.EmbeddedNavigator.Name = ""
        Me.gridPar.Location = New System.Drawing.Point(2, 2)
        Me.gridPar.MainView = Me.grd2
        Me.gridPar.Name = "gridPar"
        Me.gridPar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtVal, Me.RepositoryItemDateEdit4})
        Me.gridPar.Size = New System.Drawing.Size(325, 165)
        Me.gridPar.TabIndex = 109
        Me.gridPar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White
        Me.grd2.Appearance.EvenRow.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedRow.BackColor = System.Drawing.Color.White
        Me.grd2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.grd2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grd2.Appearance.OddRow.Options.UseBackColor = True
        Me.grd2.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grd2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParcela, Me.colValParcela, Me.colVenc, Me.colDocumento, Me.colCodigoParcela, Me.colCodFornecedor})
        Me.grd2.GridControl = Me.gridPar
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.Caption = "Parc. Nº"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.ReadOnly = True
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 62
        '
        'colValParcela
        '
        Me.colValParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValParcela.Caption = "Valor R$"
        Me.colValParcela.ColumnEdit = Me.txtVal
        Me.colValParcela.FieldName = "Valor"
        Me.colValParcela.Name = "colValParcela"
        Me.colValParcela.Visible = True
        Me.colValParcela.VisibleIndex = 1
        Me.colValParcela.Width = 76
        '
        'txtVal
        '
        Me.txtVal.AutoHeight = False
        Me.txtVal.Name = "txtVal"
        '
        'colVenc
        '
        Me.colVenc.AppearanceCell.Options.UseTextOptions = True
        Me.colVenc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVenc.Caption = "Venc."
        Me.colVenc.ColumnEdit = Me.RepositoryItemDateEdit4
        Me.colVenc.FieldName = "Vencimento"
        Me.colVenc.Name = "colVenc"
        Me.colVenc.Visible = True
        Me.colVenc.VisibleIndex = 2
        Me.colVenc.Width = 77
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Nº Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 3
        Me.colDocumento.Width = 101
        '
        'colCodigoParcela
        '
        Me.colCodigoParcela.Caption = "Codigo Parcela"
        Me.colCodigoParcela.FieldName = "CodigoParcela"
        Me.colCodigoParcela.Name = "colCodigoParcela"
        '
        'colCodFornecedor
        '
        Me.colCodFornecedor.Caption = "Codigo Fornecedor"
        Me.colCodFornecedor.FieldName = "CodigoFornecedor"
        Me.colCodFornecedor.Name = "colCodFornecedor"
        '
        'lblVenc
        '
        Me.lblVenc.AutoSize = True
        Me.lblVenc.Location = New System.Drawing.Point(55, 110)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(62, 13)
        Me.lblVenc.TabIndex = 112
        Me.lblVenc.Text = "Vencimento"
        '
        'lblNumPar
        '
        Me.lblNumPar.AutoSize = True
        Me.lblNumPar.Location = New System.Drawing.Point(480, 110)
        Me.lblNumPar.Name = "lblNumPar"
        Me.lblNumPar.Size = New System.Drawing.Size(47, 13)
        Me.lblNumPar.TabIndex = 113
        Me.lblNumPar.Text = "Nº Parc."
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(675, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(333, 228)
        Me.GroupControl2.TabIndex = 114
        Me.GroupControl2.Text = "Parcelas da Conta"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.gridPar)
        Me.GroupControl4.Controls.Add(Label4)
        Me.GroupControl4.Controls.Add(Me.txtTotal)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(329, 206)
        Me.GroupControl4.TabIndex = 111
        '
        'txtTotal
        '
        Me.txtTotal.CasasDecimais = 2
        Me.txtTotal.Enabled = False
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(201, 184)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Numerico = True
        Me.txtTotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtTotal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTotal.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtTotal.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Properties.MaxLength = 18
        Me.txtTotal.Size = New System.Drawing.Size(118, 20)
        Me.txtTotal.TabIndex = 110
        '
        'lblFimCont
        '
        Me.lblFimCont.AutoSize = True
        Me.lblFimCont.Location = New System.Drawing.Point(466, 136)
        Me.lblFimCont.Name = "lblFimCont"
        Me.lblFimCont.Size = New System.Drawing.Size(61, 13)
        Me.lblFimCont.TabIndex = 115
        Me.lblFimCont.Text = "Pagamento"
        Me.lblFimCont.Visible = False
        '
        'ContaPagarTableAdapter
        '
        Me.ContaPagarTableAdapter.ClearBeforeFill = True
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'cboCenCus
        '
        Me.cboCenCus.EnterMoveNextControl = True
        Me.cboCenCus.Location = New System.Drawing.Point(533, 35)
        Me.cboCenCus.Name = "cboCenCus"
        Me.cboCenCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCenCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCenCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCenCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCenCus.Size = New System.Drawing.Size(118, 20)
        Me.cboCenCus.TabIndex = 3
        Me.cboCenCus.Tag = "Centro de Custo"
        '
        'btnCenCus
        '
        Me.btnCenCus.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCenCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCenCus.Location = New System.Drawing.Point(651, 35)
        Me.btnCenCus.Name = "btnCenCus"
        Me.btnCenCus.Size = New System.Drawing.Size(20, 20)
        Me.btnCenCus.TabIndex = 118
        Me.btnCenCus.Text = "SimpleButton1"
        '
        'txtDias
        '
        Me.txtDias.EditValue = "30"
        Me.txtDias.EnterMoveNextControl = True
        Me.txtDias.Location = New System.Drawing.Point(347, 107)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Properties.Appearance.Options.UseFont = True
        Me.txtDias.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDias.Properties.MaxLength = 2
        Me.txtDias.Size = New System.Drawing.Size(104, 20)
        Me.txtDias.TabIndex = 8
        Me.txtDias.Tag = "Vezes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(306, 110)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 120
        Me.LabelControl8.Text = "Nº Dias"
        '
        'lblDtPag
        '
        Me.lblDtPag.AutoSize = True
        Me.lblDtPag.Location = New System.Drawing.Point(30, 136)
        Me.lblDtPag.Name = "lblDtPag"
        Me.lblDtPag.Size = New System.Drawing.Size(87, 13)
        Me.lblDtPag.TabIndex = 116
        Me.lblDtPag.Text = "Data Pagamento"
        Me.lblDtPag.Visible = False
        '
        'lblValPag
        '
        Me.lblValPag.AutoSize = True
        Me.lblValPag.Location = New System.Drawing.Point(267, 136)
        Me.lblValPag.Name = "lblValPag"
        Me.lblValPag.Size = New System.Drawing.Size(74, 13)
        Me.lblValPag.TabIndex = 117
        Me.lblValPag.Text = "Valor Pago R$"
        Me.lblValPag.Visible = False
        '
        'dtConta
        '
        Me.dtConta.EditValue = Nothing
        Me.dtConta.EnterMoveNextControl = True
        Me.dtConta.Location = New System.Drawing.Point(533, 9)
        Me.dtConta.Name = "dtConta"
        Me.dtConta.Properties.Appearance.Options.UseTextOptions = True
        Me.dtConta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtConta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtConta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtConta.Size = New System.Drawing.Size(136, 20)
        Me.dtConta.TabIndex = 121
        Me.dtConta.Tag = "Data Serviço"
        '
        'btnCTPagarNF
        '
        Me.btnCTPagarNF.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCTPagarNF.Appearance.Options.UseBackColor = True
        Me.btnCTPagarNF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCTPagarNF.Image = Global.Nano.My.Resources.Resources.invoice_24x24
        Me.btnCTPagarNF.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCTPagarNF.Location = New System.Drawing.Point(452, 7)
        Me.btnCTPagarNF.Name = "btnCTPagarNF"
        Me.btnCTPagarNF.Size = New System.Drawing.Size(21, 24)
        Me.btnCTPagarNF.TabIndex = 123
        '
        'frmPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.grpPag)
        Me.Controls.Add(Me.lblFimCont)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.lblNumPar)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.rdgFim)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(FormaPagamentoLabel1)
        Me.Controls.Add(Me.seParcela)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.cboTipCus)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.cboTipConta)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(TipoContaLabel)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.txtValConta)
        Me.Controls.Add(Me.btnCadBanco)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.luePag)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.dtConta)
        Me.Controls.Add(DataServiçoLabel)
        Me.Controls.Add(Me.btnCenCus)
        Me.Controls.Add(Me.cboCenCus)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.lblValPag)
        Me.Controls.Add(Me.lblDtPag)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.dtPag)
        Me.Controls.Add(Me.dtVenc)
        Me.Controls.Add(Me.txtValTotPag)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.btnCTPagarNF)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Contas a Pagar"
        CType(Me.rdgFim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPag.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPag.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboVencimentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecebido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaPagarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFornecedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValTotPag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtConta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdgFim As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents dtPag As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents seParcela As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtVenc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboTipConta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grpPag As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagoOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblTot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRecebido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtInicial1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colTipoCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFornecedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtValConta As Campos.NanoCampo
    Friend WithEvents txtValTotPag As Campos.NanoCampo
    Friend WithEvents btnCadBanco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboBanco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luePag As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gridPar As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsCred As System.Data.DataSet
    Friend WithEvents tdCred As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtVal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colVenc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblNumPar As System.Windows.Forms.Label
    Friend WithEvents lblVenc As System.Windows.Forms.Label
    Friend WithEvents lblFimCont As System.Windows.Forms.Label
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ContaPagarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContaPagarTableAdapter As Nano.dsNanoCommerceTableAdapters.ContaPagarTableAdapter
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents cboCenCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCenCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelConta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstornar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboVencimentos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTotal As Campos.NanoCampo
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colCodigoParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colCodFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDtPag As System.Windows.Forms.Label
    Friend WithEvents lblValPag As System.Windows.Forms.Label
    Friend WithEvents btnSel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtConta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colConta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCTPagarNF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colEstornar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
