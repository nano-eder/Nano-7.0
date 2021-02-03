<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceber
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
        Dim DataServiçoLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ValorRecebidoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim FormaPagamentoLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceber))
        Me.colVencimento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProtestado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtVenda = New DevExpress.XtraEditors.DateEdit
        Me.seParcela = New DevExpress.XtraEditors.SpinEdit
        Me.dtVenc = New DevExpress.XtraEditors.DateEdit
        Me.dtRecib = New DevExpress.XtraEditors.DateEdit
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.grpRec = New DevExpress.XtraEditors.GroupControl
        Me.btnSel = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cboVencimentos = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.btnBoleto = New DevExpress.XtraEditors.SimpleButton
        Me.btnRelVen = New DevExpress.XtraEditors.SimpleButton
        Me.btnAbrirCliente = New DevExpress.XtraEditors.SimpleButton
        Me.lblTot = New DevExpress.XtraEditors.LabelControl
        Me.btnCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.txtReceber = New DevExpress.XtraEditors.TextEdit
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.ContaReceberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colFormaPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcelas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorRecebido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecebimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecebidoOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colServico = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodLojaBaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkReceber = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colJuros1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnGerarCarne = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnEstornar = New DevExpress.XtraBars.BarButtonItem
        Me.dtInicial1 = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelCont = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.rdgFim = New DevExpress.XtraEditors.RadioGroup
        Me.colVencimeto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboTipCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.luePag = New DevExpress.XtraEditors.LookUpEdit
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtValTotRec = New Campos.NanoCampo
        Me.txtValorConta = New Campos.NanoCampo
        Me.txtCodPed = New Campos.NanoCampo
        Me.txtCliente = New DevExpress.XtraEditors.ButtonEdit
        Me.btnCadBanco = New DevExpress.XtraEditors.SimpleButton
        Me.cboBanco = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblBan = New DevExpress.XtraEditors.LabelControl
        Me.dsCred = New System.Data.DataSet
        Me.tdCred = New System.Data.DataTable
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
        Me.gridPar = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtVal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJuros = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcelaImp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btnRemPar = New DevExpress.XtraEditors.SimpleButton
        Me.txtComJuros = New Campos.NanoCampo
        Me.txtTotal = New Campos.NanoCampo
        Me.lblFinali = New System.Windows.Forms.Label
        Me.lblNumPar = New System.Windows.Forms.Label
        Me.lblVenc = New System.Windows.Forms.Label
        Me.txtTroco = New Campos.NanoCampo
        Me.lblRecebi = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContaReceberTableAdapter = New Nano.dsNanoCommerceTableAdapters.ContaReceberTableAdapter
        Me.PagamentoTableAdapter = New Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.lblEmp = New DevExpress.XtraEditors.LabelControl
        Me.lblVen = New DevExpress.XtraEditors.LabelControl
        Me.txtCom = New Campos.NanoCampo
        Me.lblCom = New DevExpress.XtraEditors.LabelControl
        Me.lblCus = New DevExpress.XtraEditors.LabelControl
        Me.txtDias = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.btnCenCus = New DevExpress.XtraEditors.SimpleButton
        Me.cboCenCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblCenCus = New DevExpress.XtraEditors.LabelControl
        DataServiçoLabel = New System.Windows.Forms.Label
        ClienteLabel = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        ValorRecebidoLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        FormaPagamentoLabel1 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.dtVenda.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRecib.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRecib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRec.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboVencimentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContaReceberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgFim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValTotRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtComJuros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTroco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataServiçoLabel
        '
        DataServiçoLabel.AutoSize = True
        DataServiçoLabel.Location = New System.Drawing.Point(525, 13)
        DataServiçoLabel.Name = "DataServiçoLabel"
        DataServiçoLabel.Size = New System.Drawing.Size(30, 13)
        DataServiçoLabel.TabIndex = 23
        DataServiçoLabel.Text = "Data"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(22, 52)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(85, 13)
        ClienteLabel.TabIndex = 35
        ClienteLabel.Text = "Nome do Cliente"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(13, 78)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(94, 13)
        ValorLabel.TabIndex = 41
        ValorLabel.Text = "Valor da Conta R$"
        '
        'ValorRecebidoLabel
        '
        ValorRecebidoLabel.AutoSize = True
        ValorRecebidoLabel.Location = New System.Drawing.Point(13, 146)
        ValorRecebidoLabel.Name = "ValorRecebidoLabel"
        ValorRecebidoLabel.Size = New System.Drawing.Size(94, 13)
        ValorRecebidoLabel.TabIndex = 43
        ValorRecebidoLabel.Text = "Valor Recebido R$"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(55, 13)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 69
        Label2.Text = "Nº Venda"
        '
        'FormaPagamentoLabel1
        '
        FormaPagamentoLabel1.AutoSize = True
        FormaPagamentoLabel1.Location = New System.Drawing.Point(225, 78)
        FormaPagamentoLabel1.Name = "FormaPagamentoLabel1"
        FormaPagamentoLabel1.Size = New System.Drawing.Size(94, 13)
        FormaPagamentoLabel1.TabIndex = 25
        FormaPagamentoLabel1.Text = "Forma Pagamento"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(195, 173)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 13)
        Label1.TabIndex = 100
        Label1.Text = "Total Juros R$"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label4.Location = New System.Drawing.Point(8, 173)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 102
        Label4.Text = "Total R$"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(269, 146)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(50, 13)
        Label5.TabIndex = 106
        Label5.Text = "Troco R$"
        '
        'colVencimento1
        '
        Me.colVencimento1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento1.AppearanceCell.ForeColor = System.Drawing.Color.Blue
        Me.colVencimento1.AppearanceCell.Options.UseFont = True
        Me.colVencimento1.AppearanceCell.Options.UseForeColor = True
        Me.colVencimento1.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento1.Caption = "Vencimento"
        Me.colVencimento1.FieldName = "Vencimento"
        Me.colVencimento1.Name = "colVencimento1"
        Me.colVencimento1.OptionsColumn.ReadOnly = True
        Me.colVencimento1.Visible = True
        Me.colVencimento1.VisibleIndex = 7
        Me.colVencimento1.Width = 83
        '
        'colProtestado
        '
        Me.colProtestado.Caption = "Protestado"
        Me.colProtestado.FieldName = "Protestado"
        Me.colProtestado.Name = "colProtestado"
        Me.colProtestado.OptionsColumn.ReadOnly = True
        '
        'dtVenda
        '
        Me.dtVenda.EditValue = Nothing
        Me.dtVenda.EnterMoveNextControl = True
        Me.dtVenda.Location = New System.Drawing.Point(561, 10)
        Me.dtVenda.Name = "dtVenda"
        Me.dtVenda.Properties.Appearance.Options.UseTextOptions = True
        Me.dtVenda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtVenda.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtVenda.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtVenda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVenda.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVenda.Size = New System.Drawing.Size(115, 20)
        Me.dtVenda.TabIndex = 2
        Me.dtVenda.Tag = "Data Serviço"
        '
        'seParcela
        '
        Me.seParcela.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seParcela.EnterMoveNextControl = True
        Me.seParcela.Location = New System.Drawing.Point(429, 101)
        Me.seParcela.Name = "seParcela"
        Me.seParcela.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seParcela.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.seParcela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seParcela.Size = New System.Drawing.Size(50, 20)
        Me.seParcela.TabIndex = 10
        Me.seParcela.Tag = "Nº Parcelas"
        '
        'dtVenc
        '
        Me.dtVenc.EditValue = Nothing
        Me.dtVenc.EnterMoveNextControl = True
        Me.dtVenc.Location = New System.Drawing.Point(113, 101)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtVenc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtVenc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVenc.Properties.Mask.IgnoreMaskBlank = False
        Me.dtVenc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVenc.Size = New System.Drawing.Size(107, 20)
        Me.dtVenc.TabIndex = 6
        Me.dtVenc.Tag = "Vencimeto"
        '
        'dtRecib
        '
        Me.dtRecib.EditValue = Nothing
        Me.dtRecib.EnterMoveNextControl = True
        Me.dtRecib.Location = New System.Drawing.Point(113, 101)
        Me.dtRecib.Name = "dtRecib"
        Me.dtRecib.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtRecib.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtRecib.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRecib.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtRecib.Size = New System.Drawing.Size(107, 20)
        Me.dtRecib.TabIndex = 8
        Me.dtRecib.Tag = "Data Recebimento"
        Me.dtRecib.Visible = False
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
        Me.txtDesc.Size = New System.Drawing.Size(676, 43)
        Me.txtDesc.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(23, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl2.TabIndex = 59
        Me.LabelControl2.Text = "Informações da Conta"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(2, 36)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(674, 5)
        Me.PanelControl1.TabIndex = 58
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.txtDesc)
        Me.GroupControl3.Location = New System.Drawing.Point(1, 170)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(680, 65)
        Me.GroupControl3.TabIndex = 12
        Me.GroupControl3.Text = "Observações"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 124)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl1.TabIndex = 64
        Me.LabelControl1.Text = "Dados do Recebimento"
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(2, 129)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(672, 5)
        Me.PanelControl2.TabIndex = 63
        '
        'grpRec
        '
        Me.grpRec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRec.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRec.AppearanceCaption.Options.UseFont = True
        Me.grpRec.Controls.Add(Me.btnSel)
        Me.grpRec.Controls.Add(Me.GroupControl1)
        Me.grpRec.Location = New System.Drawing.Point(1, 236)
        Me.grpRec.Name = "grpRec"
        Me.grpRec.Size = New System.Drawing.Size(1004, 387)
        Me.grpRec.TabIndex = 13
        Me.grpRec.Text = "Contas Cadastradas"
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
        Me.btnSel.TabIndex = 136
        Me.btnSel.Text = "Selecionar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.cboVencimentos)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.btnBoleto)
        Me.GroupControl1.Controls.Add(Me.btnRelVen)
        Me.GroupControl1.Controls.Add(Me.btnAbrirCliente)
        Me.GroupControl1.Controls.Add(Me.lblTot)
        Me.GroupControl1.Controls.Add(Me.btnCalcular)
        Me.GroupControl1.Controls.Add(Me.txtReceber)
        Me.GroupControl1.Controls.Add(Me.Grid1)
        Me.GroupControl1.Controls.Add(Me.btnGerarCarne)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1000, 365)
        Me.GroupControl1.TabIndex = 1
        '
        'cboVencimentos
        '
        Me.cboVencimentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVencimentos.EditValue = "TODOS"
        Me.cboVencimentos.Location = New System.Drawing.Point(513, 339)
        Me.cboVencimentos.Name = "cboVencimentos"
        Me.cboVencimentos.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cboVencimentos.Properties.Appearance.Options.UseFont = True
        Me.cboVencimentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboVencimentos.Properties.Items.AddRange(New Object() {"TODOS", "ATRASADOS", "HOJE", "EM DIA", "CADUCADOS"})
        Me.cboVencimentos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboVencimentos.Size = New System.Drawing.Size(134, 22)
        Me.cboVencimentos.TabIndex = 119
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(434, 342)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 118
        Me.LabelControl3.Text = "Vencimentos"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(922, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 117
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(922, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 116
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'btnBoleto
        '
        Me.btnBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBoleto.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnBoleto.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnBoleto.Appearance.Options.UseBackColor = True
        Me.btnBoleto.Appearance.Options.UseForeColor = True
        Me.btnBoleto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnBoleto.Image = Global.Nano.My.Resources.Resources.OS
        Me.btnBoleto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnBoleto.Location = New System.Drawing.Point(355, 333)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(73, 30)
        Me.btnBoleto.TabIndex = 110
        Me.btnBoleto.Text = "Boleto"
        Me.btnBoleto.Visible = False
        '
        'btnRelVen
        '
        Me.btnRelVen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRelVen.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnRelVen.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnRelVen.Appearance.Options.UseBackColor = True
        Me.btnRelVen.Appearance.Options.UseForeColor = True
        Me.btnRelVen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnRelVen.Image = Global.Nano.My.Resources.Resources.playlist
        Me.btnRelVen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnRelVen.Location = New System.Drawing.Point(108, 333)
        Me.btnRelVen.Name = "btnRelVen"
        Me.btnRelVen.Size = New System.Drawing.Size(118, 30)
        Me.btnRelVen.TabIndex = 109
        Me.btnRelVen.Text = "Consultar Venda"
        '
        'btnAbrirCliente
        '
        Me.btnAbrirCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCliente.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnAbrirCliente.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnAbrirCliente.Appearance.Options.UseBackColor = True
        Me.btnAbrirCliente.Appearance.Options.UseForeColor = True
        Me.btnAbrirCliente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAbrirCliente.Image = Global.Nano.My.Resources.Resources.Cliente
        Me.btnAbrirCliente.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnAbrirCliente.Location = New System.Drawing.Point(4, 333)
        Me.btnAbrirCliente.Name = "btnAbrirCliente"
        Me.btnAbrirCliente.Size = New System.Drawing.Size(100, 30)
        Me.btnAbrirCliente.TabIndex = 106
        Me.btnAbrirCliente.Text = "Dados Cliente"
        '
        'lblTot
        '
        Me.lblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTot.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.Appearance.Options.UseFont = True
        Me.lblTot.Location = New System.Drawing.Point(754, 344)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(107, 13)
        Me.lblTot.TabIndex = 71
        Me.lblTot.Text = "Total a Receber R$"
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalcular.Location = New System.Drawing.Point(653, 334)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(97, 28)
        Me.btnCalcular.TabIndex = 70
        Me.btnCalcular.Text = "Calcular"
        '
        'txtReceber
        '
        Me.txtReceber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReceber.Location = New System.Drawing.Point(867, 336)
        Me.txtReceber.Name = "txtReceber"
        Me.txtReceber.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceber.Properties.Appearance.Options.UseFont = True
        Me.txtReceber.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtReceber.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtReceber.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtReceber.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtReceber.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtReceber.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtReceber.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtReceber.Properties.ReadOnly = True
        Me.txtReceber.Size = New System.Drawing.Size(128, 26)
        Me.txtReceber.TabIndex = 2
        '
        'Grid1
        '
        Me.Grid1.DataSource = Me.ContaReceberBindingSource
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 2)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.lueLoja, Me.chkReceber})
        Me.Grid1.Size = New System.Drawing.Size(996, 328)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'ContaReceberBindingSource
        '
        Me.ContaReceberBindingSource.DataMember = "ContaReceber"
        Me.ContaReceberBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDataVenda, Me.colCliente, Me.colFormaPagamento, Me.colParcelas, Me.colValorParcela, Me.colValor, Me.colValorRecebido, Me.colRecebimento, Me.colRecebidoOK, Me.colServico, Me.colCodOrdem, Me.colVencimento1, Me.colPagamento, Me.colComissao, Me.colNumeroDocumento, Me.colTipoCusto, Me.colBanco, Me.colCodCli, Me.colCodConfig, Me.colCPF, Me.colCodLojaBaixa, Me.colFantasia, Me.colVencido, Me.colProtestado, Me.colCentroCusto, Me.colCidade, Me.colCodPedido, Me.colReceber, Me.colJuros1})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colVencimento1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colVencimento1
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colProtestado
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "PROTESTADO"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorParcela", Me.colValorParcela, "{0:c}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBanco, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 62
        '
        'colDataVenda
        '
        Me.colDataVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataVenda.Caption = "Data Venda"
        Me.colDataVenda.FieldName = "DataVenda"
        Me.colDataVenda.Name = "colDataVenda"
        Me.colDataVenda.OptionsColumn.ReadOnly = True
        Me.colDataVenda.Visible = True
        Me.colDataVenda.VisibleIndex = 11
        Me.colDataVenda.Width = 79
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtAlterar
        Me.colCliente.FieldName = "Nome"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 224
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colFormaPagamento
        '
        Me.colFormaPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFormaPagamento.Caption = "Forma Pagamento"
        Me.colFormaPagamento.ColumnEdit = Me.txtAlterar
        Me.colFormaPagamento.FieldName = "Pagamento"
        Me.colFormaPagamento.Name = "colFormaPagamento"
        Me.colFormaPagamento.OptionsColumn.ReadOnly = True
        Me.colFormaPagamento.Visible = True
        Me.colFormaPagamento.VisibleIndex = 8
        Me.colFormaPagamento.Width = 109
        '
        'colParcelas
        '
        Me.colParcelas.AppearanceCell.Options.UseTextOptions = True
        Me.colParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.Caption = "Nº Parcela"
        Me.colParcelas.ColumnEdit = Me.txtAlterar
        Me.colParcelas.FieldName = "Parcelas"
        Me.colParcelas.Name = "colParcelas"
        Me.colParcelas.OptionsColumn.ReadOnly = True
        Me.colParcelas.Visible = True
        Me.colParcelas.VisibleIndex = 5
        Me.colParcelas.Width = 72
        '
        'colValorParcela
        '
        Me.colValorParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorParcela.Caption = "Valor Parcela R$"
        Me.colValorParcela.ColumnEdit = Me.txtAlterar
        Me.colValorParcela.FieldName = "ValorParcela"
        Me.colValorParcela.Name = "colValorParcela"
        Me.colValorParcela.OptionsColumn.ReadOnly = True
        Me.colValorParcela.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValorParcela.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorParcela.Visible = True
        Me.colValorParcela.VisibleIndex = 6
        Me.colValorParcela.Width = 100
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Val. Conta R$"
        Me.colValor.ColumnEdit = Me.txtAlterar
        Me.colValor.FieldName = "ValorVenda"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 88
        '
        'colValorRecebido
        '
        Me.colValorRecebido.AppearanceCell.Options.UseTextOptions = True
        Me.colValorRecebido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorRecebido.Caption = "Val. Recebido R$"
        Me.colValorRecebido.ColumnEdit = Me.txtAlterar
        Me.colValorRecebido.FieldName = "ValorRecebido"
        Me.colValorRecebido.Name = "colValorRecebido"
        Me.colValorRecebido.OptionsColumn.ReadOnly = True
        Me.colValorRecebido.Visible = True
        Me.colValorRecebido.VisibleIndex = 9
        Me.colValorRecebido.Width = 112
        '
        'colRecebimento
        '
        Me.colRecebimento.AppearanceCell.Options.UseTextOptions = True
        Me.colRecebimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRecebimento.Caption = "Recebimento"
        Me.colRecebimento.FieldName = "Recebimento"
        Me.colRecebimento.Name = "colRecebimento"
        Me.colRecebimento.OptionsColumn.ReadOnly = True
        Me.colRecebimento.Visible = True
        Me.colRecebimento.VisibleIndex = 10
        Me.colRecebimento.Width = 92
        '
        'colRecebidoOK
        '
        Me.colRecebidoOK.Caption = "RecebidoOK"
        Me.colRecebidoOK.FieldName = "RecebidoOK"
        Me.colRecebidoOK.Name = "colRecebidoOK"
        Me.colRecebidoOK.OptionsColumn.ReadOnly = True
        Me.colRecebidoOK.Width = 43
        '
        'colServico
        '
        Me.colServico.Caption = "Observações"
        Me.colServico.ColumnEdit = Me.txtAlterar
        Me.colServico.FieldName = "Servico"
        Me.colServico.Name = "colServico"
        Me.colServico.OptionsColumn.ReadOnly = True
        Me.colServico.Visible = True
        Me.colServico.VisibleIndex = 14
        Me.colServico.Width = 193
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Venda"
        Me.colCodOrdem.ColumnEdit = Me.txtAlterar
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 67
        '
        'colPagamento
        '
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.ColumnEdit = Me.txtAlterar
        Me.colPagamento.FieldName = "FormaPagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 15
        Me.colPagamento.Width = 105
        '
        'colComissao
        '
        Me.colComissao.Caption = "Comissão"
        Me.colComissao.ColumnEdit = Me.txtAlterar
        Me.colComissao.FieldName = "Comissao"
        Me.colComissao.Name = "colComissao"
        Me.colComissao.OptionsColumn.ReadOnly = True
        Me.colComissao.Visible = True
        Me.colComissao.VisibleIndex = 18
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
        Me.colBanco.VisibleIndex = 16
        Me.colBanco.Width = 163
        '
        'colCodCli
        '
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 1
        Me.colCodConfig.Width = 68
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
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.ColumnEdit = Me.txtAlterar
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 3
        Me.colCPF.Width = 93
        '
        'colCodLojaBaixa
        '
        Me.colCodLojaBaixa.AppearanceCell.Options.UseTextOptions = True
        Me.colCodLojaBaixa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodLojaBaixa.Caption = "Cód. Loja Baixa"
        Me.colCodLojaBaixa.ColumnEdit = Me.lueLoja
        Me.colCodLojaBaixa.FieldName = "CodLojaBaixa"
        Me.colCodLojaBaixa.Name = "colCodLojaBaixa"
        Me.colCodLojaBaixa.OptionsColumn.ReadOnly = True
        Me.colCodLojaBaixa.Visible = True
        Me.colCodLojaBaixa.VisibleIndex = 17
        Me.colCodLojaBaixa.Width = 97
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
        Me.colVencido.VisibleIndex = 19
        Me.colVencido.Width = 82
        '
        'colCentroCusto
        '
        Me.colCentroCusto.Caption = "Centro Custo"
        Me.colCentroCusto.FieldName = "CentroCusto"
        Me.colCentroCusto.Name = "colCentroCusto"
        Me.colCentroCusto.OptionsColumn.ReadOnly = True
        Me.colCentroCusto.Visible = True
        Me.colCentroCusto.VisibleIndex = 20
        Me.colCentroCusto.Width = 86
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        '
        'colCodPedido
        '
        Me.colCodPedido.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPedido.Caption = "Cód. Pedido"
        Me.colCodPedido.FieldName = "CodPedido"
        Me.colCodPedido.Name = "colCodPedido"
        Me.colCodPedido.OptionsColumn.ReadOnly = True
        '
        'colReceber
        '
        Me.colReceber.Caption = "Estornar"
        Me.colReceber.ColumnEdit = Me.chkReceber
        Me.colReceber.FieldName = "Receber"
        Me.colReceber.Name = "colReceber"
        '
        'chkReceber
        '
        Me.chkReceber.AutoHeight = False
        Me.chkReceber.Name = "chkReceber"
        '
        'colJuros1
        '
        Me.colJuros1.Caption = "Vlr. C/ Juros R$"
        Me.colJuros1.FieldName = "Juros"
        Me.colJuros1.Name = "colJuros1"
        Me.colJuros1.OptionsColumn.ReadOnly = True
        Me.colJuros1.Visible = True
        Me.colJuros1.VisibleIndex = 21
        Me.colJuros1.Width = 97
        '
        'btnGerarCarne
        '
        Me.btnGerarCarne.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGerarCarne.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnGerarCarne.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnGerarCarne.Appearance.Options.UseBackColor = True
        Me.btnGerarCarne.Appearance.Options.UseForeColor = True
        Me.btnGerarCarne.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnGerarCarne.Image = Global.Nano.My.Resources.Resources.Impressora
        Me.btnGerarCarne.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGerarCarne.Location = New System.Drawing.Point(229, 333)
        Me.btnGerarCarne.Name = "btnGerarCarne"
        Me.btnGerarCarne.Size = New System.Drawing.Size(123, 30)
        Me.btnGerarCarne.TabIndex = 105
        Me.btnGerarCarne.Text = "Carnê/Promissória"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnCancelar, Me.dtInicial1, Me.btnFiltrar, Me.dtFinal, Me.bsiVisu, Me.btnRelCont, Me.btnRelCust, Me.btnEstornar})
        Me.BarManager1.MaxItemId = 16
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEstornar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial1, "", True, True, True, 96, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", False, True, True, 92, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnEstornar
        '
        Me.btnEstornar.Caption = "&Estornar"
        Me.btnEstornar.Glyph = Global.Nano.My.Resources.Resources.Receber
        Me.btnEstornar.Id = 15
        Me.btnEstornar.Name = "btnEstornar"
        Me.btnEstornar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'dtInicial1
        '
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
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit3
        Me.dtFinal.Id = 11
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "&Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 7
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisu
        '
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 12
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCont), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelCont
        '
        Me.btnRelCont.Caption = "Relatório de Contas a Receber"
        Me.btnRelCont.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCont.Id = 13
        Me.btnRelCont.Name = "btnRelCont"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 14
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
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'rdgFim
        '
        Me.rdgFim.Location = New System.Drawing.Point(561, 141)
        Me.rdgFim.Name = "rdgFim"
        Me.rdgFim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgFim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.rdgFim.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Total"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Parcial")})
        Me.rdgFim.Size = New System.Drawing.Size(115, 23)
        Me.rdgFim.TabIndex = 14
        Me.rdgFim.Visible = False
        '
        'colVencimeto
        '
        Me.colVencimeto.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimeto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimeto.Caption = "Dt. Vencimento"
        Me.colVencimeto.FieldName = "Vencimeto"
        Me.colVencimeto.Name = "colVencimeto"
        Me.colVencimeto.OptionsColumn.ReadOnly = True
        Me.colVencimeto.Visible = True
        Me.colVencimeto.VisibleIndex = 7
        Me.colVencimeto.Width = 109
        '
        'cboTipCus
        '
        Me.cboTipCus.EnterMoveNextControl = True
        Me.cboTipCus.Location = New System.Drawing.Point(325, 10)
        Me.cboTipCus.Name = "cboTipCus"
        Me.cboTipCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipCus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipCus.Properties.Items.AddRange(New Object() {"F", "V"})
        Me.cboTipCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipCus.Size = New System.Drawing.Size(47, 20)
        Me.cboTipCus.TabIndex = 1
        Me.cboTipCus.Tag = "Cliente"
        '
        'luePag
        '
        Me.luePag.EnterMoveNextControl = True
        Me.luePag.Location = New System.Drawing.Point(325, 75)
        Me.luePag.Name = "luePag"
        Me.luePag.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luePag.Properties.Appearance.Options.UseFont = True
        Me.luePag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.luePag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.luePag.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormaPagamento", "Pagamento", 60)})
        Me.luePag.Properties.DataSource = Me.PagamentoBindingSource
        Me.luePag.Properties.DisplayMember = "Descricao"
        Me.luePag.Properties.NullText = ""
        Me.luePag.Properties.PopupWidth = 330
        Me.luePag.Properties.ValueMember = "Descricao"
        Me.luePag.Size = New System.Drawing.Size(154, 20)
        Me.luePag.TabIndex = 6
        Me.luePag.Tag = "Forma Pagamento"
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'txtValTotRec
        '
        Me.txtValTotRec.CasasDecimais = 2
        Me.txtValTotRec.EnterMoveNextControl = True
        Me.txtValTotRec.Location = New System.Drawing.Point(113, 143)
        Me.txtValTotRec.Name = "txtValTotRec"
        Me.txtValTotRec.Numerico = True
        Me.txtValTotRec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValTotRec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValTotRec.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValTotRec.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValTotRec.Size = New System.Drawing.Size(107, 20)
        Me.txtValTotRec.TabIndex = 12
        '
        'txtValorConta
        '
        Me.txtValorConta.CasasDecimais = 2
        Me.txtValorConta.EnterMoveNextControl = True
        Me.txtValorConta.Location = New System.Drawing.Point(113, 75)
        Me.txtValorConta.Name = "txtValorConta"
        Me.txtValorConta.Numerico = True
        Me.txtValorConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorConta.Size = New System.Drawing.Size(107, 20)
        Me.txtValorConta.TabIndex = 5
        '
        'txtCodPed
        '
        Me.txtCodPed.CasasDecimais = 0
        Me.txtCodPed.EnterMoveNextControl = True
        Me.txtCodPed.Location = New System.Drawing.Point(113, 10)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Numerico = False
        Me.txtCodPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodPed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPed.Properties.MaxLength = 10
        Me.txtCodPed.Size = New System.Drawing.Size(107, 20)
        Me.txtCodPed.TabIndex = 0
        '
        'txtCliente
        '
        Me.txtCliente.EnterMoveNextControl = True
        Me.txtCliente.Location = New System.Drawing.Point(113, 49)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCliente.Size = New System.Drawing.Size(366, 20)
        Me.txtCliente.TabIndex = 3
        '
        'btnCadBanco
        '
        Me.btnCadBanco.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadBanco.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadBanco.Location = New System.Drawing.Point(656, 75)
        Me.btnCadBanco.Name = "btnCadBanco"
        Me.btnCadBanco.Size = New System.Drawing.Size(20, 20)
        Me.btnCadBanco.TabIndex = 97
        Me.btnCadBanco.Text = "SimpleButton1"
        '
        'cboBanco
        '
        Me.cboBanco.EnterMoveNextControl = True
        Me.cboBanco.Location = New System.Drawing.Point(561, 75)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboBanco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBanco.Properties.MaxLength = 55
        Me.cboBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBanco.Size = New System.Drawing.Size(95, 20)
        Me.cboBanco.TabIndex = 7
        Me.cboBanco.Tag = "Grupo"
        '
        'lblBan
        '
        Me.lblBan.Location = New System.Drawing.Point(525, 78)
        Me.lblBan.Name = "lblBan"
        Me.lblBan.Size = New System.Drawing.Size(29, 13)
        Me.lblBan.TabIndex = 96
        Me.lblBan.Text = "Banco"
        '
        'dsCred
        '
        Me.dsCred.DataSetName = "NewDataSet"
        Me.dsCred.Tables.AddRange(New System.Data.DataTable() {Me.tdCred})
        '
        'tdCred
        '
        Me.tdCred.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
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
        Me.DataColumn5.ColumnName = "Juros"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CodCliente"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "CodigoParcela"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodPed"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ParcelaImp"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Pagamento"
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
        Me.gridPar.Size = New System.Drawing.Size(317, 168)
        Me.gridPar.TabIndex = 98
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
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParcela, Me.colValParcela, Me.colVencimento, Me.colDocumento, Me.colJuros, Me.colCodCliente, Me.colCodigoParcela, Me.colCodPed, Me.colParcelaImp, Me.colPagamento2})
        Me.grd2.GridControl = Me.gridPar
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsBehavior.FocusLeaveOnTab = True
        Me.grd2.OptionsBehavior.KeepFocusedRowOnUpdate = False
        Me.grd2.OptionsNavigation.EnterMoveNextColumn = True
        Me.grd2.OptionsView.EnableAppearanceEvenRow = True
        Me.grd2.OptionsView.EnableAppearanceOddRow = True
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colParcela.AppearanceCell.Options.UseFont = True
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.Caption = "Parc. Nº"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.ReadOnly = True
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 61
        '
        'colValParcela
        '
        Me.colValParcela.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colValParcela.AppearanceCell.Options.UseFont = True
        Me.colValParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValParcela.Caption = "Valor R$"
        Me.colValParcela.ColumnEdit = Me.txtVal
        Me.colValParcela.FieldName = "Valor"
        Me.colValParcela.Name = "colValParcela"
        Me.colValParcela.OptionsColumn.ReadOnly = True
        Me.colValParcela.Visible = True
        Me.colValParcela.VisibleIndex = 1
        Me.colValParcela.Width = 62
        '
        'txtVal
        '
        Me.txtVal.AutoHeight = False
        Me.txtVal.Name = "txtVal"
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceCell.Options.UseFont = True
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Venc."
        Me.colVencimento.ColumnEdit = Me.RepositoryItemDateEdit4
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 2
        Me.colVencimento.Width = 95
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.ValidateOnEnterKey = True
        Me.RepositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colDocumento
        '
        Me.colDocumento.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDocumento.AppearanceCell.Options.UseFont = True
        Me.colDocumento.Caption = "Nº Doc."
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 3
        Me.colDocumento.Width = 78
        '
        'colJuros
        '
        Me.colJuros.Caption = "Juros"
        Me.colJuros.FieldName = "Juros"
        Me.colJuros.Name = "colJuros"
        '
        'colCodCliente
        '
        Me.colCodCliente.Caption = "CodCliente"
        Me.colCodCliente.FieldName = "CodCliente"
        Me.colCodCliente.Name = "colCodCliente"
        '
        'colCodigoParcela
        '
        Me.colCodigoParcela.Caption = "CodigoParcela"
        Me.colCodigoParcela.FieldName = "CodigoParcela"
        Me.colCodigoParcela.Name = "colCodigoParcela"
        '
        'colCodPed
        '
        Me.colCodPed.Caption = "CodPed"
        Me.colCodPed.FieldName = "CodPed"
        Me.colCodPed.Name = "colCodPed"
        '
        'colParcelaImp
        '
        Me.colParcelaImp.Caption = "ParcelaImp"
        Me.colParcelaImp.FieldName = "ParcelaImp"
        Me.colParcelaImp.Name = "colParcelaImp"
        Me.colParcelaImp.OptionsColumn.ReadOnly = True
        '
        'colPagamento2
        '
        Me.colPagamento2.Caption = "Pagamento"
        Me.colPagamento2.FieldName = "Pagamento"
        Me.colPagamento2.Name = "colPagamento2"
        Me.colPagamento2.OptionsColumn.ReadOnly = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(680, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(325, 231)
        Me.GroupControl2.TabIndex = 101
        Me.GroupControl2.Text = "Parcelas da Conta"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.btnRemPar)
        Me.GroupControl4.Controls.Add(Label4)
        Me.GroupControl4.Controls.Add(Label1)
        Me.GroupControl4.Controls.Add(Me.gridPar)
        Me.GroupControl4.Controls.Add(Me.txtComJuros)
        Me.GroupControl4.Controls.Add(Me.txtTotal)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(321, 209)
        Me.GroupControl4.TabIndex = 103
        '
        'btnRemPar
        '
        Me.btnRemPar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRemPar.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRemPar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnRemPar.Location = New System.Drawing.Point(2, 150)
        Me.btnRemPar.Name = "btnRemPar"
        Me.btnRemPar.Size = New System.Drawing.Size(317, 20)
        Me.btnRemPar.TabIndex = 103
        Me.btnRemPar.Text = "SimpleButton1"
        '
        'txtComJuros
        '
        Me.txtComJuros.CasasDecimais = 2
        Me.txtComJuros.Enabled = False
        Me.txtComJuros.EnterMoveNextControl = True
        Me.txtComJuros.Location = New System.Drawing.Point(198, 187)
        Me.txtComJuros.Name = "txtComJuros"
        Me.txtComJuros.Numerico = True
        Me.txtComJuros.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtComJuros.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComJuros.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtComJuros.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtComJuros.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtComJuros.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtComJuros.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtComJuros.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtComJuros.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComJuros.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComJuros.Size = New System.Drawing.Size(118, 20)
        Me.txtComJuros.TabIndex = 99
        '
        'txtTotal
        '
        Me.txtTotal.CasasDecimais = 2
        Me.txtTotal.Enabled = False
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(10, 187)
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
        Me.txtTotal.Size = New System.Drawing.Size(118, 20)
        Me.txtTotal.TabIndex = 101
        '
        'lblFinali
        '
        Me.lblFinali.AutoSize = True
        Me.lblFinali.Location = New System.Drawing.Point(486, 146)
        Me.lblFinali.Name = "lblFinali"
        Me.lblFinali.Size = New System.Drawing.Size(69, 13)
        Me.lblFinali.TabIndex = 102
        Me.lblFinali.Text = "Recebimento"
        Me.lblFinali.Visible = False
        '
        'lblNumPar
        '
        Me.lblNumPar.AutoSize = True
        Me.lblNumPar.Location = New System.Drawing.Point(376, 104)
        Me.lblNumPar.Name = "lblNumPar"
        Me.lblNumPar.Size = New System.Drawing.Size(47, 13)
        Me.lblNumPar.TabIndex = 103
        Me.lblNumPar.Text = "Nº Parc."
        '
        'lblVenc
        '
        Me.lblVenc.AutoSize = True
        Me.lblVenc.Location = New System.Drawing.Point(45, 104)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(62, 13)
        Me.lblVenc.TabIndex = 104
        Me.lblVenc.Text = "Vencimento"
        '
        'txtTroco
        '
        Me.txtTroco.CasasDecimais = 2
        Me.txtTroco.EnterMoveNextControl = True
        Me.txtTroco.Location = New System.Drawing.Point(325, 143)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.Numerico = True
        Me.txtTroco.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTroco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTroco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTroco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTroco.Size = New System.Drawing.Size(154, 20)
        Me.txtTroco.TabIndex = 13
        '
        'lblRecebi
        '
        Me.lblRecebi.Location = New System.Drawing.Point(16, 104)
        Me.lblRecebi.Name = "lblRecebi"
        Me.lblRecebi.Size = New System.Drawing.Size(88, 13)
        Me.lblRecebi.TabIndex = 107
        Me.lblRecebi.Text = "Data Recebimento"
        Me.lblRecebi.Visible = False
        '
        'Timer1
        '
        '
        'ContaReceberTableAdapter
        '
        Me.ContaReceberTableAdapter.ClearBeforeFill = True
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'lblEmp
        '
        Me.lblEmp.Location = New System.Drawing.Point(513, 78)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(41, 13)
        Me.lblEmp.TabIndex = 108
        Me.lblEmp.Text = "Empresa"
        Me.lblEmp.Visible = False
        '
        'lblVen
        '
        Me.lblVen.Location = New System.Drawing.Point(274, 13)
        Me.lblVen.Name = "lblVen"
        Me.lblVen.Size = New System.Drawing.Size(46, 13)
        Me.lblVen.TabIndex = 109
        Me.lblVen.Text = "Vendedor"
        Me.lblVen.Visible = False
        '
        'txtCom
        '
        Me.txtCom.CasasDecimais = 2
        Me.txtCom.EditValue = ""
        Me.txtCom.EnterMoveNextControl = True
        Me.txtCom.Location = New System.Drawing.Point(561, 101)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Numerico = True
        Me.txtCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCom.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCom.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCom.Size = New System.Drawing.Size(115, 20)
        Me.txtCom.TabIndex = 11
        Me.txtCom.Tag = "Comissão"
        Me.txtCom.Visible = False
        '
        'lblCom
        '
        Me.lblCom.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCom.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblCom.Appearance.Options.UseFont = True
        Me.lblCom.Appearance.Options.UseForeColor = True
        Me.lblCom.Location = New System.Drawing.Point(496, 104)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(59, 13)
        Me.lblCom.TabIndex = 112
        Me.lblCom.Text = "Comissão %"
        Me.lblCom.Visible = False
        '
        'lblCus
        '
        Me.lblCus.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCus.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblCus.Appearance.Options.UseFont = True
        Me.lblCus.Appearance.Options.UseForeColor = True
        Me.lblCus.Location = New System.Drawing.Point(249, 13)
        Me.lblCus.Name = "lblCus"
        Me.lblCus.Size = New System.Drawing.Size(69, 13)
        Me.lblCus.TabIndex = 113
        Me.lblCus.Text = "Custo Fix/Var."
        '
        'txtDias
        '
        Me.txtDias.EditValue = "30"
        Me.txtDias.EnterMoveNextControl = True
        Me.txtDias.Location = New System.Drawing.Point(325, 101)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Properties.Appearance.Options.UseFont = True
        Me.txtDias.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDias.Properties.MaxLength = 2
        Me.txtDias.Size = New System.Drawing.Size(47, 20)
        Me.txtDias.TabIndex = 9
        Me.txtDias.Tag = "Vezes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(284, 104)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 115
        Me.LabelControl8.Text = "Nº Dias"
        '
        'btnCenCus
        '
        Me.btnCenCus.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCenCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCenCus.Location = New System.Drawing.Point(656, 47)
        Me.btnCenCus.Name = "btnCenCus"
        Me.btnCenCus.Size = New System.Drawing.Size(20, 20)
        Me.btnCenCus.TabIndex = 121
        Me.btnCenCus.Text = "SimpleButton1"
        '
        'cboCenCus
        '
        Me.cboCenCus.EnterMoveNextControl = True
        Me.cboCenCus.Location = New System.Drawing.Point(561, 47)
        Me.cboCenCus.Name = "cboCenCus"
        Me.cboCenCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCenCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCenCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCenCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCenCus.Size = New System.Drawing.Size(95, 20)
        Me.cboCenCus.TabIndex = 4
        Me.cboCenCus.Tag = "Centro de Custo"
        '
        'lblCenCus
        '
        Me.lblCenCus.Location = New System.Drawing.Point(491, 50)
        Me.lblCenCus.Name = "lblCenCus"
        Me.lblCenCus.Size = New System.Drawing.Size(64, 13)
        Me.lblCenCus.TabIndex = 122
        Me.lblCenCus.Text = "Centro Custo"
        '
        'frmReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.grpRec)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.lblRecebi)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.lblNumPar)
        Me.Controls.Add(Me.lblFinali)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.rdgFim)
        Me.Controls.Add(Me.dtRecib)
        Me.Controls.Add(ValorRecebidoLabel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.seParcela)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtVenc)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dtVenda)
        Me.Controls.Add(DataServiçoLabel)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.cboTipCus)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.luePag)
        Me.Controls.Add(FormaPagamentoLabel1)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtValorConta)
        Me.Controls.Add(Me.txtValTotRec)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.btnCadBanco)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.lblBan)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txtTroco)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.lblCom)
        Me.Controls.Add(Me.lblCus)
        Me.Controls.Add(Me.lblVen)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblCenCus)
        Me.Controls.Add(Me.btnCenCus)
        Me.Controls.Add(Me.cboCenCus)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Contas a Receber"
        CType(Me.dtVenda.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRecib.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRecib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRec.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboVencimentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContaReceberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReceber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgFim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValTotRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtComJuros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTroco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtVenda As DevExpress.XtraEditors.DateEdit
    Friend WithEvents seParcela As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtVenc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtRecib As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpRec As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
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
    Friend WithEvents rdgFim As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents colVencimeto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataServiço As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorRecebido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecebimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecebidoOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtReceber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtInicial1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colTipoCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luePag As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtCodPed As Campos.NanoCampo
    Friend WithEvents txtValorConta As Campos.NanoCampo
    Friend WithEvents txtValTotRec As Campos.NanoCampo
    Friend WithEvents txtCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnCadBanco As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboBanco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblBan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsCred As System.Data.DataSet
    Friend WithEvents tdCred As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtVal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataVenda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridPar As DevExpress.XtraGrid.GridControl
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblFinali As System.Windows.Forms.Label
    Friend WithEvents lblNumPar As System.Windows.Forms.Label
    Friend WithEvents lblVenc As System.Windows.Forms.Label
    Friend WithEvents btnGerarCarne As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAbrirCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotal As Campos.NanoCampo
    Friend WithEvents txtComJuros As Campos.NanoCampo
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colJuros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colCodCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodigoParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTroco As Campos.NanoCampo
    Friend WithEvents lblRecebi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colCodPed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ContaReceberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContaReceberTableAdapter As Nano.dsNanoCommerceTableAdapters.ContaReceberTableAdapter
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colParcelaImp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelCont As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodLojaBaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEstornar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblEmp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCom As Campos.NanoCampo
    Friend WithEvents lblCom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colComissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRelVen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRemPar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBoleto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboVencimentos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colProtestado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCenCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCenCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCenCus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCodPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkReceber As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colJuros1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
