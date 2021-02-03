<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoCompra
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim LimiteLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoCompra))
        Me.colFocus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.txtPerDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtQtd = New Campos.NanoCampo
        Me.txtNomePro = New Campos.NanoCampo
        Me.txtTamanho = New Campos.NanoCampo
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.btnLucro = New DevExpress.XtraEditors.CheckButton
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsItens = New System.Data.DataSet
        Me.tbItens = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.tbAtivo = New System.Data.DataTable
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.tbAmbos = New System.Data.DataTable
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.tbEntrada = New System.Data.DataTable
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.memAlt = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabelaPreco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPeca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colUniSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPromocao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaB = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMedida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdDesc = New DevExpress.XtraEditors.GroupControl
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisualizar = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizarComValores = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizarSemValores = New DevExpress.XtraBars.BarButtonItem
        Me.btnPromissoria = New DevExpress.XtraBars.BarButtonItem
        Me.btnMail = New DevExpress.XtraBars.BarButtonItem
        Me.btnCompromisso = New DevExpress.XtraBars.BarButtonItem
        Me.btnVender = New DevExpress.XtraBars.BarButtonItem
        Me.btnAtivo = New DevExpress.XtraBars.BarButtonItem
        Me.btnEntrada = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.grpVal = New DevExpress.XtraEditors.GroupControl
        Me.rdgDesc = New DevExpress.XtraEditors.RadioGroup
        Me.Label12 = New System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtEntrega = New DevExpress.XtraEditors.TextEdit
        Me.lblValDesc = New DevExpress.XtraEditors.LabelControl
        Me.txtValDesc = New DevExpress.XtraEditors.TextEdit
        Me.lblPor = New DevExpress.XtraEditors.LabelControl
        Me.lblDesc = New System.Windows.Forms.Label
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit
        Me.lblTro = New DevExpress.XtraEditors.LabelControl
        Me.lblRec = New DevExpress.XtraEditors.LabelControl
        Me.txtTro = New DevExpress.XtraEditors.TextEdit
        Me.txtRec = New DevExpress.XtraEditors.TextEdit
        Me.pcLinha = New DevExpress.XtraEditors.PanelControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.chkAlterado = New DevExpress.XtraEditors.CheckEdit
        Me.txtLimite = New DevExpress.XtraEditors.TextEdit
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.dtEntrega = New DevExpress.XtraEditors.DateEdit
        Me.dtRetirada = New DevExpress.XtraEditors.DateEdit
        Me.txtCli = New DevExpress.XtraEditors.ButtonEdit
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.lueFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.lblVenc = New DevExpress.XtraEditors.LabelControl
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlProduto = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.tabAtivo = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPadrao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkExcluir2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCodAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProdutoAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedidoAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimentoAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnExcluirAtivo = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.dtVencimento = New DevExpress.XtraEditors.DateEdit
        Me.txtNomeAtivo = New Campos.NanoCampo
        Me.txtValorAtivo = New DevExpress.XtraEditors.TextEdit
        Me.txtCodAtivo = New DevExpress.XtraEditors.ButtonEdit
        Me.btnAddAtivo = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colQtdAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtFocus = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoProdutoAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProdutoAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedidoAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUMAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdeAddAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInternoAmbos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlPrincipal = New DevExpress.XtraEditors.PanelControl
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.tabProd = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.chkAutoAdd = New DevExpress.XtraEditors.CheckEdit
        Me.lblMedTot = New DevExpress.XtraEditors.LabelControl
        Me.lblMedB = New DevExpress.XtraEditors.LabelControl
        Me.lblMedA = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdMedida = New Campos.NanoCampo
        Me.txtMedidaB = New Campos.NanoCampo
        Me.txtMedidaA = New Campos.NanoCampo
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton
        Me.txtQtd2 = New Campos.NanoCampo
        Me.txtTamanho2 = New Campos.NanoCampo
        Me.txtNomePro2 = New Campos.NanoCampo
        Me.txtCodPro2 = New DevExpress.XtraEditors.ButtonEdit
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtTotItem = New DevExpress.XtraEditors.TextEdit
        EmailLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        LimiteLabel = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        Label18 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label19 = New System.Windows.Forms.Label
        Label20 = New System.Windows.Forms.Label
        Label21 = New System.Windows.Forms.Label
        Label22 = New System.Windows.Forms.Label
        Label23 = New System.Windows.Forms.Label
        Label24 = New System.Windows.Forms.Label
        Label25 = New System.Windows.Forms.Label
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdDesc.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVal.SuspendLayout()
        CType(Me.rdgDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRetirada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRetirada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProduto.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.tabAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAtivo.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExcluir2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeAtivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorAtivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodAtivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFocus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProd.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedidaB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedidaA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtQtd2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(31, 60)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "E-Mail"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(32, 34)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 13)
        Label2.TabIndex = 42
        Label2.Text = "Nome"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(23, 14)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(193, 14)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(526, 40)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 13)
        Label6.TabIndex = 53
        Label6.Text = "Preço R$"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(865, 14)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 58
        Label7.Text = "Qtd"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(861, 14)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 59
        Label8.Text = "Data"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(6, 34)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(142, 18)
        Label10.TabIndex = 55
        Label10.Text = "Total Produtos R$"
        Label10.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(7, 35)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(116, 18)
        Label11.TabIndex = 56
        Label11.Text = "Total Geral R$"
        '
        'LimiteLabel
        '
        LimiteLabel.AutoSize = True
        LimiteLabel.Location = New System.Drawing.Point(407, 34)
        LimiteLabel.Name = "LimiteLabel"
        LimiteLabel.Size = New System.Drawing.Size(38, 13)
        LimiteLabel.TabIndex = 71
        LimiteLabel.Text = "Limite:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(530, 34)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(49, 13)
        Label13.TabIndex = 88
        Label13.Text = "Telefone"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(539, 60)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(40, 13)
        Label14.TabIndex = 89
        Label14.Text = "Celular"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(733, 14)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 60
        Label9.Text = "Tamanho"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(426, 35)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(50, 13)
        Label16.TabIndex = 53
        Label16.Text = "Preço R$"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(187, 35)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(53, 13)
        Label17.TabIndex = 45
        Label17.Text = "Descrição"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(4, 35)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(59, 13)
        Label18.TabIndex = 43
        Label18.Text = "Cód. Barra"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(754, 35)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 13)
        Label1.TabIndex = 63
        Label1.Text = "Validade"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(736, 40)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(48, 13)
        Label15.TabIndex = 63
        Label15.Text = "Desc. %"
        '
        'Label19
        '
        Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(6, 319)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(89, 18)
        Label19.TabIndex = 78
        Label19.Text = "Total Itens"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(865, 14)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(25, 13)
        Label20.TabIndex = 67
        Label20.Text = "Qtd"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(733, 14)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(51, 13)
        Label21.TabIndex = 68
        Label21.Text = "Tamanho"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(23, 14)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(40, 13)
        Label22.TabIndex = 65
        Label22.Text = "Código"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(193, 14)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(45, 13)
        Label23.TabIndex = 66
        Label23.Text = "Produto"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(815, 34)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(74, 13)
        Label24.TabIndex = 92
        Label24.Text = "Data Retirada"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(818, 60)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(71, 13)
        Label25.TabIndex = 94
        Label25.Text = "Data Entrega"
        '
        'colFocus
        '
        Me.colFocus.Caption = "Focus"
        Me.colFocus.FieldName = "Focus"
        Me.colFocus.Name = "colFocus"
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'txtCodPed
        '
        Me.txtCodPed.Enabled = False
        Me.txtCodPed.EnterMoveNextControl = True
        Me.txtCodPed.Location = New System.Drawing.Point(72, 11)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.Appearance.Options.UseFont = True
        Me.txtCodPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodPed.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtCodPed.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodPed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPed.Size = New System.Drawing.Size(90, 21)
        Me.txtCodPed.TabIndex = 0
        Me.txtCodPed.Tag = "Nº Pedido"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(10, 15)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(54, 13)
        Me.lblCodPed.TabIndex = 1
        Me.lblCodPed.Text = "Nº Ordem"
        '
        'txtTel
        '
        Me.txtTel.EnterMoveNextControl = True
        Me.txtTel.Location = New System.Drawing.Point(585, 31)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTel.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel.Properties.Mask.EditMask = "(99)0000-0000"
        Me.txtTel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTel.Properties.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(132, 20)
        Me.txtTel.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(72, 57)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEmail.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Properties.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(444, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtPerDesc
        '
        Me.txtPerDesc.EnterMoveNextControl = True
        Me.txtPerDesc.Location = New System.Drawing.Point(790, 37)
        Me.txtPerDesc.Name = "txtPerDesc"
        Me.txtPerDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerDesc.Properties.Appearance.Options.UseFont = True
        Me.txtPerDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtPerDesc.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPerDesc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPerDesc.Size = New System.Drawing.Size(67, 20)
        Me.txtPerDesc.TabIndex = 62
        Me.txtPerDesc.Tag = "Desc. %"
        '
        'txtQtd
        '
        Me.txtQtd.CasasDecimais = 3
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(896, 11)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Numerico = True
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd.Properties.MaxLength = 13
        Me.txtQtd.Size = New System.Drawing.Size(95, 20)
        Me.txtQtd.TabIndex = 3
        Me.txtQtd.Tag = "Qtd"
        '
        'txtNomePro
        '
        Me.txtNomePro.CasasDecimais = 0
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(242, 11)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Numerico = False
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomePro.Properties.MaxLength = 200
        Me.txtNomePro.Size = New System.Drawing.Size(472, 20)
        Me.txtNomePro.TabIndex = 61
        Me.txtNomePro.Tag = "Tamanho"
        '
        'txtTamanho
        '
        Me.txtTamanho.CasasDecimais = 0
        Me.txtTamanho.EnterMoveNextControl = True
        Me.txtTamanho.Location = New System.Drawing.Point(790, 11)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Numerico = False
        Me.txtTamanho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTamanho.Properties.Appearance.Options.UseFont = True
        Me.txtTamanho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho.Properties.MaxLength = 4
        Me.txtTamanho.Size = New System.Drawing.Size(67, 20)
        Me.txtTamanho.TabIndex = 2
        Me.txtTamanho.Tag = "Tamanho"
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(582, 37)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtValor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValor.Size = New System.Drawing.Size(132, 20)
        Me.txtValor.TabIndex = 7
        Me.txtValor.Tag = "Preço R$"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(69, 11)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Properties.MaxLength = 50
        Me.txtCodPro.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPro.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(896, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 22)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Adicionar"
        '
        'grpItens
        '
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.AppearanceCaption.Options.UseForeColor = True
        Me.grpItens.Controls.Add(Me.btnPadrao)
        Me.grpItens.Controls.Add(Me.btnManter)
        Me.grpItens.Controls.Add(Me.btnLucro)
        Me.grpItens.Controls.Add(Me.btnDelete)
        Me.grpItens.Controls.Add(Me.picFundo)
        Me.grpItens.Controls.Add(Me.PedidoGridControl)
        Me.grpItens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpItens.Location = New System.Drawing.Point(2, 2)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(796, 322)
        Me.grpItens.TabIndex = 6
        Me.grpItens.Text = "Itens do Pedido"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(715, 1)
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
        Me.btnManter.Location = New System.Drawing.Point(662, 1)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 19)
        Me.btnManter.TabIndex = 108
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'btnLucro
        '
        Me.btnLucro.Location = New System.Drawing.Point(771, 1)
        Me.btnLucro.Name = "btnLucro"
        Me.btnLucro.Size = New System.Drawing.Size(22, 19)
        Me.btnLucro.TabIndex = 10
        Me.btnLucro.Text = "%"
        Me.btnLucro.ToolTip = "Clique para visualizar"
        Me.btnLucro.ToolTipTitle = "Margem de Lucro"
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(2, 299)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(792, 21)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(2, 20)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(792, 300)
        Me.picFundo.TabIndex = 9
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbItens"
        Me.PedidoGridControl.DataSource = Me.dsItens
        Me.PedidoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(2, 20)
        Me.PedidoGridControl.LookAndFeel.SkinName = "Black"
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt, Me.RepositoryItemCheckEdit1, Me.memAlt})
        Me.PedidoGridControl.Size = New System.Drawing.Size(792, 300)
        Me.PedidoGridControl.TabIndex = 7
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens, Me.tbAtivo, Me.tbAmbos, Me.tbEntrada})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn10, Me.DataColumn11, Me.DataColumn9, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44})
        Me.tbItens.TableName = "tbItens"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodigoProduto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Produto"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Qtd"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ValorUnitario"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ValorTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "TabelaPreco"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "CodigoInterno"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodPedAut"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Custo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "UM"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "Peso"
        Me.DataColumn9.ColumnName = "Peso"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "UniSemDesc"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Tamanho"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Excluir"
        Me.DataColumn14.DataType = GetType(Boolean)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Promocao"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Desconto"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Lucro"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "MedidaA"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "MedidaB"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "QtdMedida"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "CodProdFor"
        '
        'tbAtivo
        '
        Me.tbAtivo.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn30})
        Me.tbAtivo.TableName = "tbAtivo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Codigo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "CodPadrao"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Nome"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Valor"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "CodAtivo"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Excluir"
        Me.DataColumn20.DataType = GetType(Boolean)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Produto"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "CodPedAut"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "Vencimento"
        '
        'tbAmbos
        '
        Me.tbAmbos.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn31, Me.DataColumn32})
        Me.tbAmbos.TableName = "tbAmbos"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "CodigoProduto"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "CodigoInterno"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Produto"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "CodigoPedido"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Qtd"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "UM"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "QtdAdd"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Focus"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "QtdOk"
        '
        'tbEntrada
        '
        Me.tbEntrada.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40})
        Me.tbEntrada.TableName = "tbEntrada"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Pagamento"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "FormaPagamento"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Valor"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Data"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Codigo"
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colTabelaPreco, Me.colCodigoPeca, Me.colCodPedAut, Me.colCusto, Me.colUM, Me.colTamanho, Me.colExcluir, Me.colUniSemDesc, Me.colPromocao, Me.colDesconto, Me.colLucro, Me.colMedidaA, Me.colMedidaB, Me.colQtdMedida, Me.colCodProdFor})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.RowAutoHeight = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtd.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtd.AppearanceCell.Options.UseBackColor = True
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtAlt
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 44
        '
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colCodigoProduto
        '
        Me.colCodigoProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoProduto.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto.Caption = "Código"
        Me.colCodigoProduto.ColumnEdit = Me.txtAlt
        Me.colCodigoProduto.FieldName = "CodigoProduto"
        Me.colCodigoProduto.Name = "colCodigoProduto"
        Me.colCodigoProduto.OptionsColumn.ReadOnly = True
        Me.colCodigoProduto.Width = 56
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.memAlt
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 214
        '
        'memAlt
        '
        Me.memAlt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memAlt.Name = "memAlt"
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorUnitario.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorUnitario.AppearanceCell.Options.UseBackColor = True
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtAlt
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 80
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorTotal.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Tot. R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlt
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 77
        '
        'colTabelaPreco
        '
        Me.colTabelaPreco.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTabelaPreco.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTabelaPreco.AppearanceCell.Options.UseBackColor = True
        Me.colTabelaPreco.Caption = "TabelaPreco"
        Me.colTabelaPreco.ColumnEdit = Me.txtAlt
        Me.colTabelaPreco.FieldName = "TabelaPreco"
        Me.colTabelaPreco.Name = "colTabelaPreco"
        Me.colTabelaPreco.OptionsColumn.ReadOnly = True
        Me.colTabelaPreco.Width = 60
        '
        'colCodigoPeca
        '
        Me.colCodigoPeca.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoPeca.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoPeca.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoPeca.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPeca.Caption = "Código"
        Me.colCodigoPeca.ColumnEdit = Me.txtAlt
        Me.colCodigoPeca.FieldName = "CodigoInterno"
        Me.colCodigoPeca.Name = "colCodigoPeca"
        Me.colCodigoPeca.OptionsColumn.ReadOnly = True
        Me.colCodigoPeca.Visible = True
        Me.colCodigoPeca.VisibleIndex = 0
        Me.colCodigoPeca.Width = 70
        '
        'colCodPedAut
        '
        Me.colCodPedAut.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodPedAut.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodPedAut.AppearanceCell.Options.UseBackColor = True
        Me.colCodPedAut.Caption = "CodPedAut"
        Me.colCodPedAut.ColumnEdit = Me.txtAlt
        Me.colCodPedAut.FieldName = "CodPedAut"
        Me.colCodPedAut.Name = "colCodPedAut"
        Me.colCodPedAut.OptionsColumn.ReadOnly = True
        Me.colCodPedAut.Width = 76
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCusto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCusto.AppearanceCell.Options.UseBackColor = True
        Me.colCusto.Caption = "Custo"
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        '
        'colUM
        '
        Me.colUM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUM.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUM.AppearanceCell.Options.UseBackColor = True
        Me.colUM.AppearanceCell.Options.UseTextOptions = True
        Me.colUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM.Caption = "U.M."
        Me.colUM.ColumnEdit = Me.txtAlt
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.ReadOnly = True
        Me.colUM.Visible = True
        Me.colUM.VisibleIndex = 2
        Me.colUM.Width = 40
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTamanho.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTamanho.AppearanceCell.Options.UseBackColor = True
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 3
        Me.colTamanho.Width = 41
        '
        'colExcluir
        '
        Me.colExcluir.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExcluir.AppearanceCell.Options.UseBackColor = True
        Me.colExcluir.Caption = "Excluir"
        Me.colExcluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.Visible = True
        Me.colExcluir.VisibleIndex = 8
        Me.colExcluir.Width = 46
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colUniSemDesc
        '
        Me.colUniSemDesc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUniSemDesc.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUniSemDesc.AppearanceCell.Options.UseBackColor = True
        Me.colUniSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc.Caption = "Sem Desc. R$"
        Me.colUniSemDesc.FieldName = "UniSemDesc"
        Me.colUniSemDesc.Name = "colUniSemDesc"
        Me.colUniSemDesc.OptionsColumn.ReadOnly = True
        Me.colUniSemDesc.Visible = True
        Me.colUniSemDesc.VisibleIndex = 5
        Me.colUniSemDesc.Width = 80
        '
        'colPromocao
        '
        Me.colPromocao.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPromocao.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPromocao.AppearanceCell.Options.UseBackColor = True
        Me.colPromocao.Caption = "Promocao"
        Me.colPromocao.FieldName = "Promocao"
        Me.colPromocao.Name = "colPromocao"
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDesconto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDesconto.AppearanceCell.Options.UseBackColor = True
        Me.colDesconto.Caption = "Desconto"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        '
        'colLucro
        '
        Me.colLucro.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLucro.AppearanceCell.Options.UseBackColor = True
        Me.colLucro.AppearanceCell.Options.UseTextOptions = True
        Me.colLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLucro.Caption = "%"
        Me.colLucro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLucro.FieldName = "Lucro"
        Me.colLucro.Name = "colLucro"
        Me.colLucro.OptionsColumn.ReadOnly = True
        Me.colLucro.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        Me.colLucro.Width = 40
        '
        'colMedidaA
        '
        Me.colMedidaA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaA.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaA.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colMedidaA.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaA.AppearanceCell.Options.UseTextOptions = True
        Me.colMedidaA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMedidaA.Caption = "Medida A"
        Me.colMedidaA.FieldName = "MedidaA"
        Me.colMedidaA.Name = "colMedidaA"
        Me.colMedidaA.OptionsColumn.ReadOnly = True
        '
        'colMedidaB
        '
        Me.colMedidaB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaB.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaB.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colMedidaB.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaB.AppearanceCell.Options.UseTextOptions = True
        Me.colMedidaB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMedidaB.Caption = "Medida B"
        Me.colMedidaB.FieldName = "MedidaB"
        Me.colMedidaB.Name = "colMedidaB"
        Me.colMedidaB.OptionsColumn.ReadOnly = True
        '
        'colQtdMedida
        '
        Me.colQtdMedida.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colQtdMedida.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtdMedida.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtdMedida.AppearanceCell.Options.UseBackColor = True
        Me.colQtdMedida.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMedida.Caption = "Qtd Med."
        Me.colQtdMedida.FieldName = "QtdMedida"
        Me.colQtdMedida.Name = "colQtdMedida"
        Me.colQtdMedida.OptionsColumn.ReadOnly = True
        '
        'colCodProdFor
        '
        Me.colCodProdFor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodProdFor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodProdFor.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProdFor.AppearanceCell.Options.UseBackColor = True
        Me.colCodProdFor.Caption = "Cód. For."
        Me.colCodProdFor.FieldName = "CodProdFor"
        Me.colCodProdFor.Name = "colCodProdFor"
        Me.colCodProdFor.OptionsColumn.ReadOnly = True
        '
        'grdDesc
        '
        Me.grdDesc.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDesc.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grdDesc.AppearanceCaption.Options.UseFont = True
        Me.grdDesc.AppearanceCaption.Options.UseForeColor = True
        Me.grdDesc.Controls.Add(Me.txtDesc)
        Me.grdDesc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdDesc.Location = New System.Drawing.Point(2, 324)
        Me.grdDesc.Name = "grdDesc"
        Me.grdDesc.Size = New System.Drawing.Size(796, 61)
        Me.grdDesc.TabIndex = 5
        Me.grdDesc.Text = "Observações"
        '
        'txtDesc
        '
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.Location = New System.Drawing.Point(2, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Size = New System.Drawing.Size(792, 39)
        Me.txtDesc.TabIndex = 0
        '
        'txtFax
        '
        Me.txtFax.EnterMoveNextControl = True
        Me.txtFax.Location = New System.Drawing.Point(585, 57)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtFax.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtFax.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFax.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFax.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Properties.Mask.EditMask = "(99)0000-0000"
        Me.txtFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtFax.Properties.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(132, 20)
        Me.txtFax.TabIndex = 2
        '
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnExcluir, Me.btnPromissoria, Me.btnAtivo, Me.bsiVisualizar, Me.btnVisualizarSemValores, Me.btnVisualizarComValores, Me.btnMail, Me.btnImprimir, Me.btnCompromisso, Me.btnEntrada, Me.btnVender})
        Me.bmComandos.MaxItemId = 22
        Me.bmComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImprimir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisualizar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPromissoria, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnMail, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCompromisso, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVender, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAtivo, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEntrada, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 11
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "&Imprimir"
        Me.btnImprimir.Glyph = Global.Nano.My.Resources.Resources.Impressora
        Me.btnImprimir.Id = 18
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bsiVisualizar
        '
        Me.bsiVisualizar.Caption = "&Visualizar"
        Me.bsiVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisualizar.Id = 14
        Me.bsiVisualizar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizarComValores), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizarSemValores)})
        Me.bsiVisualizar.Name = "bsiVisualizar"
        '
        'btnVisualizarComValores
        '
        Me.btnVisualizarComValores.Caption = "&Com Valores"
        Me.btnVisualizarComValores.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizarComValores.Id = 16
        Me.btnVisualizarComValores.Name = "btnVisualizarComValores"
        '
        'btnVisualizarSemValores
        '
        Me.btnVisualizarSemValores.Caption = "&Sem Valores"
        Me.btnVisualizarSemValores.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizarSemValores.Id = 15
        Me.btnVisualizarSemValores.Name = "btnVisualizarSemValores"
        '
        'btnPromissoria
        '
        Me.btnPromissoria.Caption = "&Promissória"
        Me.btnPromissoria.Glyph = Global.Nano.My.Resources.Resources.playlist
        Me.btnPromissoria.Id = 12
        Me.btnPromissoria.Name = "btnPromissoria"
        Me.btnPromissoria.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnMail
        '
        Me.btnMail.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnMail.Caption = "&Enviar"
        Me.btnMail.Glyph = Global.Nano.My.Resources.Resources.Mail
        Me.btnMail.Id = 17
        Me.btnMail.Name = "btnMail"
        '
        'btnCompromisso
        '
        Me.btnCompromisso.Caption = "&Compromisso"
        Me.btnCompromisso.Glyph = Global.Nano.My.Resources.Resources.cal_2
        Me.btnCompromisso.Id = 19
        Me.btnCompromisso.Name = "btnCompromisso"
        Me.btnCompromisso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnVender
        '
        Me.btnVender.Caption = "&Vender"
        Me.btnVender.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnVender.Id = 21
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnAtivo
        '
        Me.btnAtivo.Caption = "Barril/Chopeira"
        Me.btnAtivo.Glyph = Global.Nano.My.Resources.Resources.Barril26
        Me.btnAtivo.Id = 13
        Me.btnAtivo.Name = "btnAtivo"
        Me.btnAtivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnEntrada
        '
        Me.btnEntrada.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEntrada.Caption = "&Entrada"
        Me.btnEntrada.Glyph = Global.Nano.My.Resources.Resources.credit_card24
        Me.btnEntrada.Id = 20
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "F6 &Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
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
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Fechar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 2
        Me.btnCancelar.Name = "btnCancelar"
        '
        'grpVal
        '
        Me.grpVal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVal.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpVal.AppearanceCaption.Options.UseFont = True
        Me.grpVal.AppearanceCaption.Options.UseForeColor = True
        Me.grpVal.Controls.Add(Me.txtTotItem)
        Me.grpVal.Controls.Add(Me.txtTotal)
        Me.grpVal.Controls.Add(Me.rdgDesc)
        Me.grpVal.Controls.Add(Label19)
        Me.grpVal.Controls.Add(Me.Label12)
        Me.grpVal.Controls.Add(Me.PanelControl1)
        Me.grpVal.Controls.Add(Me.LabelControl1)
        Me.grpVal.Controls.Add(Me.txtEntrega)
        Me.grpVal.Controls.Add(Label11)
        Me.grpVal.Controls.Add(Me.lblValDesc)
        Me.grpVal.Controls.Add(Me.txtValDesc)
        Me.grpVal.Controls.Add(Me.lblPor)
        Me.grpVal.Controls.Add(Me.lblDesc)
        Me.grpVal.Controls.Add(Me.txtDesconto)
        Me.grpVal.Controls.Add(Me.lblTro)
        Me.grpVal.Controls.Add(Me.lblRec)
        Me.grpVal.Controls.Add(Me.txtTro)
        Me.grpVal.Controls.Add(Me.txtRec)
        Me.grpVal.Controls.Add(Me.pcLinha)
        Me.grpVal.Controls.Add(Label10)
        Me.grpVal.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpVal.Location = New System.Drawing.Point(800, 0)
        Me.grpVal.Name = "grpVal"
        Me.grpVal.Size = New System.Drawing.Size(208, 387)
        Me.grpVal.TabIndex = 4
        Me.grpVal.Text = "Valores do Pedido"
        '
        'rdgDesc
        '
        Me.rdgDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgDesc.EditValue = True
        Me.rdgDesc.Location = New System.Drawing.Point(6, 97)
        Me.rdgDesc.Name = "rdgDesc"
        Me.rdgDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDesc.Properties.Appearance.Options.UseFont = True
        Me.rdgDesc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Desconto"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Acréscimo")})
        Me.rdgDesc.Size = New System.Drawing.Size(193, 20)
        Me.rdgDesc.TabIndex = 147
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(9, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 14)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Acréscimo"
        Me.Label12.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(5, 210)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(197, 5)
        Me.PanelControl1.TabIndex = 75
        Me.PanelControl1.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(25, 232)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 74
        Me.LabelControl1.Text = "Valor R$"
        Me.LabelControl1.Visible = False
        '
        'txtEntrega
        '
        Me.txtEntrega.EditValue = ""
        Me.txtEntrega.EnterMoveNextControl = True
        Me.txtEntrega.Location = New System.Drawing.Point(86, 221)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrega.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtEntrega.Properties.Appearance.Options.UseBackColor = True
        Me.txtEntrega.Properties.Appearance.Options.UseFont = True
        Me.txtEntrega.Properties.Appearance.Options.UseForeColor = True
        Me.txtEntrega.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEntrega.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEntrega.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEntrega.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEntrega.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEntrega.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEntrega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrega.Properties.MaxLength = 13
        Me.txtEntrega.Size = New System.Drawing.Size(114, 35)
        Me.txtEntrega.TabIndex = 2
        Me.txtEntrega.Tag = "Desconto %"
        Me.txtEntrega.Visible = False
        '
        'lblValDesc
        '
        Me.lblValDesc.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValDesc.Appearance.Options.UseFont = True
        Me.lblValDesc.Location = New System.Drawing.Point(16, 138)
        Me.lblValDesc.Name = "lblValDesc"
        Me.lblValDesc.Size = New System.Drawing.Size(65, 18)
        Me.lblValDesc.TabIndex = 72
        Me.lblValDesc.Text = "Valor R$"
        '
        'txtValDesc
        '
        Me.txtValDesc.EditValue = ""
        Me.txtValDesc.EnterMoveNextControl = True
        Me.txtValDesc.Location = New System.Drawing.Point(87, 127)
        Me.txtValDesc.Name = "txtValDesc"
        Me.txtValDesc.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtValDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValDesc.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseFont = True
        Me.txtValDesc.Properties.Appearance.Options.UseForeColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValDesc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValDesc.Properties.MaxLength = 13
        Me.txtValDesc.Size = New System.Drawing.Size(113, 35)
        Me.txtValDesc.TabIndex = 0
        Me.txtValDesc.Tag = "Desconto %"
        '
        'lblPor
        '
        Me.lblPor.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.Appearance.Options.UseFont = True
        Me.lblPor.Location = New System.Drawing.Point(63, 174)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(18, 18)
        Me.lblPor.TabIndex = 70
        Me.lblPor.Text = "%"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblDesc.Location = New System.Drawing.Point(8, 100)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(65, 14)
        Me.lblDesc.TabIndex = 69
        Me.lblDesc.Text = "Desconto"
        '
        'txtDesconto
        '
        Me.txtDesconto.EditValue = ""
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(87, 168)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtDesconto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtDesconto.Properties.Appearance.Options.UseForeColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDesconto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.Properties.MaxLength = 13
        Me.txtDesconto.Size = New System.Drawing.Size(114, 35)
        Me.txtDesconto.TabIndex = 1
        Me.txtDesconto.Tag = "Desconto %"
        '
        'lblTro
        '
        Me.lblTro.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTro.Appearance.Options.UseFont = True
        Me.lblTro.Location = New System.Drawing.Point(14, 195)
        Me.lblTro.Name = "lblTro"
        Me.lblTro.Size = New System.Drawing.Size(67, 18)
        Me.lblTro.TabIndex = 10
        Me.lblTro.Text = "Troco R$"
        Me.lblTro.Visible = False
        '
        'lblRec
        '
        Me.lblRec.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec.Appearance.Options.UseFont = True
        Me.lblRec.Location = New System.Drawing.Point(14, 142)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(94, 18)
        Me.lblRec.TabIndex = 9
        Me.lblRec.Text = "Recebido R$"
        Me.lblRec.Visible = False
        '
        'txtTro
        '
        Me.txtTro.Enabled = False
        Me.txtTro.Location = New System.Drawing.Point(11, 224)
        Me.txtTro.Name = "txtTro"
        Me.txtTro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTro.Properties.Appearance.Options.UseFont = True
        Me.txtTro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTro.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTro.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTro.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtTro.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTro.Properties.MaxLength = 14
        Me.txtTro.Size = New System.Drawing.Size(189, 35)
        Me.txtTro.TabIndex = 4
        Me.txtTro.Visible = False
        '
        'txtRec
        '
        Me.txtRec.EnterMoveNextControl = True
        Me.txtRec.Location = New System.Drawing.Point(11, 161)
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRec.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec.Properties.Appearance.Options.UseBackColor = True
        Me.txtRec.Properties.Appearance.Options.UseFont = True
        Me.txtRec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRec.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRec.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRec.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtRec.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtRec.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtRec.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtRec.Properties.MaxLength = 14
        Me.txtRec.Size = New System.Drawing.Size(189, 29)
        Me.txtRec.TabIndex = 3
        Me.txtRec.Tag = "Recebido R$"
        Me.txtRec.Visible = False
        '
        'pcLinha
        '
        Me.pcLinha.Location = New System.Drawing.Point(11, 106)
        Me.pcLinha.Name = "pcLinha"
        Me.pcLinha.Size = New System.Drawing.Size(184, 5)
        Me.pcLinha.TabIndex = 59
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(895, 11)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(100, 20)
        Me.dtData.TabIndex = 20
        Me.dtData.Tag = "Data"
        '
        'chkAlterado
        '
        Me.chkAlterado.Location = New System.Drawing.Point(907, 12)
        Me.chkAlterado.Name = "chkAlterado"
        Me.chkAlterado.Properties.Caption = "Alterado"
        Me.chkAlterado.Properties.ReadOnly = True
        Me.chkAlterado.Size = New System.Drawing.Size(87, 19)
        Me.chkAlterado.TabIndex = 61
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(314, 31)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Properties.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(158, 20)
        Me.txtLimite.TabIndex = 72
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(163, 11)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 83
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.dtEntrega)
        Me.GroupControl1.Controls.Add(Label25)
        Me.GroupControl1.Controls.Add(Me.dtRetirada)
        Me.GroupControl1.Controls.Add(Label24)
        Me.GroupControl1.Controls.Add(Label14)
        Me.GroupControl1.Controls.Add(Label13)
        Me.GroupControl1.Controls.Add(Me.txtCli)
        Me.GroupControl1.Controls.Add(Me.txtLimite)
        Me.GroupControl1.Controls.Add(LimiteLabel)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(EmailLabel)
        Me.GroupControl1.Controls.Add(Me.txtFax)
        Me.GroupControl1.Controls.Add(Me.txtTel)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 44)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 88)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Dados do Fornecedor"
        '
        'dtEntrega
        '
        Me.dtEntrega.EditValue = ""
        Me.dtEntrega.EnterMoveNextControl = True
        Me.dtEntrega.Location = New System.Drawing.Point(895, 57)
        Me.dtEntrega.Name = "dtEntrega"
        Me.dtEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEntrega.Properties.Appearance.Options.UseFont = True
        Me.dtEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEntrega.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtEntrega.Size = New System.Drawing.Size(100, 20)
        Me.dtEntrega.TabIndex = 4
        Me.dtEntrega.Tag = "Data"
        '
        'dtRetirada
        '
        Me.dtRetirada.EditValue = ""
        Me.dtRetirada.EnterMoveNextControl = True
        Me.dtRetirada.Location = New System.Drawing.Point(895, 31)
        Me.dtRetirada.Name = "dtRetirada"
        Me.dtRetirada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRetirada.Properties.Appearance.Options.UseFont = True
        Me.dtRetirada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRetirada.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtRetirada.Size = New System.Drawing.Size(100, 20)
        Me.dtRetirada.TabIndex = 3
        Me.dtRetirada.Tag = "Data"
        '
        'txtCli
        '
        Me.txtCli.EnterMoveNextControl = True
        Me.txtCli.Location = New System.Drawing.Point(72, 29)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.Appearance.Options.UseFont = True
        Me.txtCli.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCli.Properties.ReadOnly = True
        Me.txtCli.Size = New System.Drawing.Size(444, 22)
        Me.txtCli.TabIndex = 0
        Me.txtCli.Tag = "Nome Cliente"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(245, 12)
        Me.lueFunc.Name = "lueFunc"
        Me.lueFunc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lueFunc.Properties.Appearance.Options.UseFont = True
        Me.lueFunc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.lueFunc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.lueFunc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueFunc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.lueFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueFunc.Properties.DataSource = Me.FuncionarioBindingSource
        Me.lueFunc.Properties.DisplayMember = "Nome"
        Me.lueFunc.Properties.NullText = ""
        Me.lueFunc.Properties.ValueMember = "Nome"
        Me.lueFunc.Size = New System.Drawing.Size(271, 20)
        Me.lueFunc.TabIndex = 1
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
        'lblVenc
        '
        Me.lblVenc.Location = New System.Drawing.Point(190, 15)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(53, 13)
        Me.lblVenc.TabIndex = 84
        Me.lblVenc.Text = "Comprador"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'pnlProduto
        '
        Me.pnlProduto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProduto.Controls.Add(Me.PanelControl2)
        Me.pnlProduto.Controls.Add(Me.grpVal)
        Me.pnlProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProduto.Location = New System.Drawing.Point(0, 0)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(1008, 387)
        Me.pnlProduto.TabIndex = 8
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grpItens)
        Me.PanelControl2.Controls.Add(Me.grdDesc)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(800, 387)
        Me.PanelControl2.TabIndex = 7
        '
        'tabAtivo
        '
        Me.tabAtivo.Location = New System.Drawing.Point(811, 41)
        Me.tabAtivo.Name = "tabAtivo"
        Me.tabAtivo.SelectedTabPage = Me.XtraTabPage1
        Me.tabAtivo.Size = New System.Drawing.Size(197, 456)
        Me.tabAtivo.TabIndex = 7
        Me.tabAtivo.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(188, 425)
        Me.XtraTabPage1.Text = "Produto"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(188, 425)
        Me.XtraTabPage2.Text = "Barril/Chopeira"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.btnExcluirAtivo)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 195)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(188, 230)
        Me.GroupControl2.TabIndex = 8
        Me.GroupControl2.Text = "Itens do Pedido"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbAtivo"
        Me.GridControl1.DataSource = Me.dsItens
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.LookAndFeel.SkinName = "Black"
        Me.GridControl1.MainView = Me.grd2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar2, Me.chkExcluir2})
        Me.GridControl1.Size = New System.Drawing.Size(184, 187)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.grd2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grd2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd2.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grd2.Appearance.GroupFooter.Options.UseFont = True
        Me.grd2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grd2.Appearance.GroupRow.Options.UseFont = True
        Me.grd2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd2.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd2.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd2.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd2.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd2.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grd2.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo2, Me.colNome, Me.colValor, Me.GridColumn5, Me.colCodPadrao, Me.colExcluir2, Me.colCodAtivo, Me.colProdutoAtivo, Me.colCodigoPedidoAtivo, Me.colVencimentoAtivo})
        Me.grd2.GridControl = Me.GridControl1
        Me.grd2.GroupCount = 1
        Me.grd2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Excluir", Me.colExcluir2, "{0:0}")})
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowAutoFilterRow = True
        Me.grd2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNome, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigo2
        '
        Me.colCodigo2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigo2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigo2.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo2.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo2.Caption = "Código"
        Me.colCodigo2.ColumnEdit = Me.txtAlterar2
        Me.colCodigo2.FieldName = "Codigo"
        Me.colCodigo2.Name = "colCodigo2"
        Me.colCodigo2.OptionsColumn.ReadOnly = True
        Me.colCodigo2.Width = 56
        '
        'txtAlterar2
        '
        Me.txtAlterar2.AutoHeight = False
        Me.txtAlterar2.Name = "txtAlterar2"
        '
        'colNome
        '
        Me.colNome.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colNome.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colNome.AppearanceCell.Options.UseBackColor = True
        Me.colNome.Caption = "Descrição"
        Me.colNome.ColumnEdit = Me.txtAlterar2
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        Me.colNome.Width = 381
        '
        'colValor
        '
        Me.colValor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValor.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValor.AppearanceCell.Options.UseBackColor = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor Unit. R$"
        Me.colValor.ColumnEdit = Me.txtAlterar2
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.Width = 88
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn5.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Valor Total R$"
        Me.GridColumn5.ColumnEdit = Me.txtAlterar2
        Me.GridColumn5.FieldName = "ValorTotal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Width = 89
        '
        'colCodPadrao
        '
        Me.colCodPadrao.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodPadrao.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodPadrao.AppearanceCell.Options.UseBackColor = True
        Me.colCodPadrao.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPadrao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPadrao.Caption = "Cód. Barra"
        Me.colCodPadrao.ColumnEdit = Me.txtAlterar2
        Me.colCodPadrao.FieldName = "CodPadrao"
        Me.colCodPadrao.Name = "colCodPadrao"
        Me.colCodPadrao.OptionsColumn.ReadOnly = True
        Me.colCodPadrao.Visible = True
        Me.colCodPadrao.VisibleIndex = 0
        Me.colCodPadrao.Width = 117
        '
        'colExcluir2
        '
        Me.colExcluir2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExcluir2.AppearanceCell.Options.UseBackColor = True
        Me.colExcluir2.Caption = "Excluir"
        Me.colExcluir2.ColumnEdit = Me.chkExcluir2
        Me.colExcluir2.FieldName = "Excluir"
        Me.colExcluir2.Name = "colExcluir2"
        Me.colExcluir2.Visible = True
        Me.colExcluir2.VisibleIndex = 3
        Me.colExcluir2.Width = 76
        '
        'chkExcluir2
        '
        Me.chkExcluir2.AutoHeight = False
        Me.chkExcluir2.Name = "chkExcluir2"
        '
        'colCodAtivo
        '
        Me.colCodAtivo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodAtivo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodAtivo.AppearanceCell.Options.UseBackColor = True
        Me.colCodAtivo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodAtivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodAtivo.Caption = "Código"
        Me.colCodAtivo.FieldName = "CodAtivo"
        Me.colCodAtivo.Name = "colCodAtivo"
        Me.colCodAtivo.OptionsColumn.ReadOnly = True
        '
        'colProdutoAtivo
        '
        Me.colProdutoAtivo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProdutoAtivo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProdutoAtivo.AppearanceCell.Options.UseBackColor = True
        Me.colProdutoAtivo.Caption = "Produto"
        Me.colProdutoAtivo.ColumnEdit = Me.txtAlterar2
        Me.colProdutoAtivo.FieldName = "Produto"
        Me.colProdutoAtivo.Name = "colProdutoAtivo"
        Me.colProdutoAtivo.OptionsColumn.ReadOnly = True
        Me.colProdutoAtivo.Visible = True
        Me.colProdutoAtivo.VisibleIndex = 1
        Me.colProdutoAtivo.Width = 268
        '
        'colCodigoPedidoAtivo
        '
        Me.colCodigoPedidoAtivo.Caption = "CodigoPedido"
        Me.colCodigoPedidoAtivo.FieldName = "CodPedAut"
        Me.colCodigoPedidoAtivo.Name = "colCodigoPedidoAtivo"
        '
        'colVencimentoAtivo
        '
        Me.colVencimentoAtivo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colVencimentoAtivo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colVencimentoAtivo.AppearanceCell.Options.UseBackColor = True
        Me.colVencimentoAtivo.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimentoAtivo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimentoAtivo.Caption = "Vencimento"
        Me.colVencimentoAtivo.FieldName = "Vencimento"
        Me.colVencimentoAtivo.Name = "colVencimentoAtivo"
        Me.colVencimentoAtivo.OptionsColumn.ReadOnly = True
        Me.colVencimentoAtivo.Visible = True
        Me.colVencimentoAtivo.VisibleIndex = 2
        Me.colVencimentoAtivo.Width = 132
        '
        'btnExcluirAtivo
        '
        Me.btnExcluirAtivo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcluirAtivo.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnExcluirAtivo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExcluirAtivo.Location = New System.Drawing.Point(2, 207)
        Me.btnExcluirAtivo.LookAndFeel.SkinName = "Money Twins"
        Me.btnExcluirAtivo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExcluirAtivo.Name = "btnExcluirAtivo"
        Me.btnExcluirAtivo.Size = New System.Drawing.Size(184, 21)
        Me.btnExcluirAtivo.TabIndex = 6
        Me.btnExcluirAtivo.Text = "Excluir Item(ns)"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.dtVencimento)
        Me.GroupControl3.Controls.Add(Label1)
        Me.GroupControl3.Controls.Add(Me.txtNomeAtivo)
        Me.GroupControl3.Controls.Add(Me.txtValorAtivo)
        Me.GroupControl3.Controls.Add(Me.txtCodAtivo)
        Me.GroupControl3.Controls.Add(Me.btnAddAtivo)
        Me.GroupControl3.Controls.Add(Label16)
        Me.GroupControl3.Controls.Add(Label17)
        Me.GroupControl3.Controls.Add(Label18)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 131)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(188, 64)
        Me.GroupControl3.TabIndex = 7
        Me.GroupControl3.Text = "Adicionar Barril/Chopeira"
        '
        'dtVencimento
        '
        Me.dtVencimento.EditValue = ""
        Me.dtVencimento.EnterMoveNextControl = True
        Me.dtVencimento.Location = New System.Drawing.Point(804, 32)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtVencimento.Properties.Appearance.Options.UseFont = True
        Me.dtVencimento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVencimento.Size = New System.Drawing.Size(100, 20)
        Me.dtVencimento.TabIndex = 2
        Me.dtVencimento.Tag = "Data"
        '
        'txtNomeAtivo
        '
        Me.txtNomeAtivo.CasasDecimais = 0
        Me.txtNomeAtivo.EnterMoveNextControl = True
        Me.txtNomeAtivo.Location = New System.Drawing.Point(246, 32)
        Me.txtNomeAtivo.Name = "txtNomeAtivo"
        Me.txtNomeAtivo.Numerico = False
        Me.txtNomeAtivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomeAtivo.Properties.Appearance.Options.UseFont = True
        Me.txtNomeAtivo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomeAtivo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomeAtivo.Properties.MaxLength = 4
        Me.txtNomeAtivo.Size = New System.Drawing.Size(496, 20)
        Me.txtNomeAtivo.TabIndex = 1
        Me.txtNomeAtivo.Tag = "Tamanho"
        '
        'txtValorAtivo
        '
        Me.txtValorAtivo.EnterMoveNextControl = True
        Me.txtValorAtivo.Location = New System.Drawing.Point(482, 32)
        Me.txtValorAtivo.Name = "txtValorAtivo"
        Me.txtValorAtivo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValorAtivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorAtivo.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorAtivo.Properties.Appearance.Options.UseFont = True
        Me.txtValorAtivo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorAtivo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorAtivo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValorAtivo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValorAtivo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValorAtivo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValorAtivo.Size = New System.Drawing.Size(85, 20)
        Me.txtValorAtivo.TabIndex = 5
        Me.txtValorAtivo.Tag = "Preço R$"
        '
        'txtCodAtivo
        '
        Me.txtCodAtivo.EnterMoveNextControl = True
        Me.txtCodAtivo.Location = New System.Drawing.Point(69, 32)
        Me.txtCodAtivo.Name = "txtCodAtivo"
        Me.txtCodAtivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodAtivo.Properties.Appearance.Options.UseFont = True
        Me.txtCodAtivo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodAtivo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodAtivo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodAtivo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodAtivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12)})
        Me.txtCodAtivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodAtivo.Properties.MaxLength = 50
        Me.txtCodAtivo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodAtivo.TabIndex = 0
        '
        'btnAddAtivo
        '
        Me.btnAddAtivo.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAddAtivo.Location = New System.Drawing.Point(910, 28)
        Me.btnAddAtivo.Name = "btnAddAtivo"
        Me.btnAddAtivo.Size = New System.Drawing.Size(78, 30)
        Me.btnAddAtivo.TabIndex = 4
        Me.btnAddAtivo.Text = "&Adicionar"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.GridControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(188, 131)
        Me.GroupControl4.TabIndex = 9
        Me.GroupControl4.Text = "Itens do Pedido"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbAmbos"
        Me.GridControl2.DataSource = Me.dsItens
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.LookAndFeel.SkinName = "Black"
        Me.GridControl2.MainView = Me.grd3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtFocus, Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(184, 109)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'grd3
        '
        Me.grd3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedCell.Options.UseFont = True
        Me.grd3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedRow.Options.UseFont = True
        Me.grd3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd3.Appearance.HideSelectionRow.Options.UseFont = True
        Me.grd3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd3.Appearance.SelectedRow.Options.UseFont = True
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtdAmbos, Me.colCodigoProdutoAmbos, Me.colProdutoAmbos, Me.colCodigoPedidoAmbos, Me.colUMAmbos, Me.colQtdeAddAmbos, Me.colCodigoInternoAmbos, Me.colFocus})
        Me.grd3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colFocus
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        Me.grd3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd3.GridControl = Me.GridControl2
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.EnableAppearanceEvenRow = True
        Me.grd3.OptionsView.EnableAppearanceOddRow = True
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colQtdAmbos
        '
        Me.colQtdAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdAmbos.Caption = "Qtde"
        Me.colQtdAmbos.ColumnEdit = Me.txtFocus
        Me.colQtdAmbos.FieldName = "Qtd"
        Me.colQtdAmbos.Name = "colQtdAmbos"
        Me.colQtdAmbos.OptionsColumn.ReadOnly = True
        Me.colQtdAmbos.Visible = True
        Me.colQtdAmbos.VisibleIndex = 3
        Me.colQtdAmbos.Width = 74
        '
        'txtFocus
        '
        Me.txtFocus.AutoHeight = False
        Me.txtFocus.Name = "txtFocus"
        '
        'colCodigoProdutoAmbos
        '
        Me.colCodigoProdutoAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProdutoAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProdutoAmbos.Caption = "Código"
        Me.colCodigoProdutoAmbos.ColumnEdit = Me.txtFocus
        Me.colCodigoProdutoAmbos.FieldName = "CodigoProduto"
        Me.colCodigoProdutoAmbos.Name = "colCodigoProdutoAmbos"
        Me.colCodigoProdutoAmbos.OptionsColumn.ReadOnly = True
        Me.colCodigoProdutoAmbos.Width = 56
        '
        'colProdutoAmbos
        '
        Me.colProdutoAmbos.Caption = "Produto"
        Me.colProdutoAmbos.ColumnEdit = Me.txtFocus
        Me.colProdutoAmbos.FieldName = "Produto"
        Me.colProdutoAmbos.Name = "colProdutoAmbos"
        Me.colProdutoAmbos.OptionsColumn.ReadOnly = True
        Me.colProdutoAmbos.Visible = True
        Me.colProdutoAmbos.VisibleIndex = 1
        Me.colProdutoAmbos.Width = 275
        '
        'colCodigoPedidoAmbos
        '
        Me.colCodigoPedidoAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPedidoAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPedidoAmbos.Caption = "Código"
        Me.colCodigoPedidoAmbos.ColumnEdit = Me.txtFocus
        Me.colCodigoPedidoAmbos.FieldName = "CodigoPedido"
        Me.colCodigoPedidoAmbos.Name = "colCodigoPedidoAmbos"
        Me.colCodigoPedidoAmbos.OptionsColumn.ReadOnly = True
        Me.colCodigoPedidoAmbos.Width = 84
        '
        'colUMAmbos
        '
        Me.colUMAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colUMAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUMAmbos.Caption = "U.M."
        Me.colUMAmbos.ColumnEdit = Me.txtFocus
        Me.colUMAmbos.FieldName = "UM"
        Me.colUMAmbos.Name = "colUMAmbos"
        Me.colUMAmbos.OptionsColumn.ReadOnly = True
        Me.colUMAmbos.Visible = True
        Me.colUMAmbos.VisibleIndex = 2
        Me.colUMAmbos.Width = 45
        '
        'colQtdeAddAmbos
        '
        Me.colQtdeAddAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdeAddAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdeAddAmbos.Caption = "Qtd Adicionada"
        Me.colQtdeAddAmbos.ColumnEdit = Me.txtFocus
        Me.colQtdeAddAmbos.FieldName = "QtdAdd"
        Me.colQtdeAddAmbos.Name = "colQtdeAddAmbos"
        Me.colQtdeAddAmbos.OptionsColumn.ReadOnly = True
        Me.colQtdeAddAmbos.Visible = True
        Me.colQtdeAddAmbos.VisibleIndex = 4
        '
        'colCodigoInternoAmbos
        '
        Me.colCodigoInternoAmbos.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInternoAmbos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInternoAmbos.Caption = "Cód. Prod."
        Me.colCodigoInternoAmbos.ColumnEdit = Me.txtFocus
        Me.colCodigoInternoAmbos.FieldName = "CodigoInterno"
        Me.colCodigoInternoAmbos.Name = "colCodigoInternoAmbos"
        Me.colCodigoInternoAmbos.OptionsColumn.ReadOnly = True
        Me.colCodigoInternoAmbos.Visible = True
        Me.colCodigoInternoAmbos.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlPrincipal.Controls.Add(Me.pnlProduto)
        Me.pnlPrincipal.Controls.Add(Me.tabAtivo)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 235)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1008, 387)
        Me.pnlPrincipal.TabIndex = 90
        '
        'Timer2
        '
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(545, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.EditValue = "Pendente"
        Me.cboStatus.Location = New System.Drawing.Point(585, 11)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Appearance.Options.UseForeColor = True
        Me.cboStatus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cboStatus.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.Items.AddRange(New Object() {"Pendente"})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(132, 20)
        Me.cboStatus.TabIndex = 93
        '
        'tabProd
        '
        Me.tabProd.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.AppearancePage.Header.Options.UseFont = True
        Me.tabProd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabProd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.tabProd.Location = New System.Drawing.Point(0, 138)
        Me.tabProd.Name = "tabProd"
        Me.tabProd.SelectedTabPage = Me.XtraTabPage3
        Me.tabProd.Size = New System.Drawing.Size(1008, 97)
        Me.tabProd.TabIndex = 3
        Me.tabProd.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.chkAutoAdd)
        Me.XtraTabPage3.Controls.Add(Me.lblMedTot)
        Me.XtraTabPage3.Controls.Add(Me.lblMedB)
        Me.XtraTabPage3.Controls.Add(Me.lblMedA)
        Me.XtraTabPage3.Controls.Add(Me.txtQtdMedida)
        Me.XtraTabPage3.Controls.Add(Me.txtMedidaB)
        Me.XtraTabPage3.Controls.Add(Me.txtMedidaA)
        Me.XtraTabPage3.Controls.Add(Me.txtPerDesc)
        Me.XtraTabPage3.Controls.Add(Me.btnAdd)
        Me.XtraTabPage3.Controls.Add(Me.txtQtd)
        Me.XtraTabPage3.Controls.Add(Me.txtTamanho)
        Me.XtraTabPage3.Controls.Add(Label7)
        Me.XtraTabPage3.Controls.Add(Label9)
        Me.XtraTabPage3.Controls.Add(Label6)
        Me.XtraTabPage3.Controls.Add(Label3)
        Me.XtraTabPage3.Controls.Add(Me.txtNomePro)
        Me.XtraTabPage3.Controls.Add(Me.txtValor)
        Me.XtraTabPage3.Controls.Add(Label4)
        Me.XtraTabPage3.Controls.Add(Label15)
        Me.XtraTabPage3.Controls.Add(Me.txtCodPro)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(999, 66)
        Me.XtraTabPage3.Text = "Adicionar Produtos"
        '
        'chkAutoAdd
        '
        Me.chkAutoAdd.Location = New System.Drawing.Point(3, 11)
        Me.chkAutoAdd.Name = "chkAutoAdd"
        Me.chkAutoAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoAdd.Properties.Appearance.Options.UseFont = True
        Me.chkAutoAdd.Properties.Caption = ""
        Me.chkAutoAdd.Size = New System.Drawing.Size(19, 19)
        Me.chkAutoAdd.TabIndex = 74
        Me.chkAutoAdd.ToolTip = "Selecione para adicionar o produto automaticamente"
        '
        'lblMedTot
        '
        Me.lblMedTot.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedTot.Appearance.Options.UseFont = True
        Me.lblMedTot.Location = New System.Drawing.Point(350, 40)
        Me.lblMedTot.Name = "lblMedTot"
        Me.lblMedTot.Size = New System.Drawing.Size(51, 13)
        Me.lblMedTot.TabIndex = 72
        Me.lblMedTot.Text = "Med. Total"
        Me.lblMedTot.Visible = False
        '
        'lblMedB
        '
        Me.lblMedB.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedB.Appearance.Options.UseFont = True
        Me.lblMedB.Location = New System.Drawing.Point(193, 40)
        Me.lblMedB.Name = "lblMedB"
        Me.lblMedB.Size = New System.Drawing.Size(43, 13)
        Me.lblMedB.TabIndex = 71
        Me.lblMedB.Text = "Medida B"
        Me.lblMedB.Visible = False
        '
        'lblMedA
        '
        Me.lblMedA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedA.Appearance.Options.UseFont = True
        Me.lblMedA.Location = New System.Drawing.Point(19, 40)
        Me.lblMedA.Name = "lblMedA"
        Me.lblMedA.Size = New System.Drawing.Size(44, 13)
        Me.lblMedA.TabIndex = 70
        Me.lblMedA.Text = "Medida A"
        Me.lblMedA.Visible = False
        '
        'txtQtdMedida
        '
        Me.txtQtdMedida.CasasDecimais = 3
        Me.txtQtdMedida.EnterMoveNextControl = True
        Me.txtQtdMedida.Location = New System.Drawing.Point(407, 37)
        Me.txtQtdMedida.Name = "txtQtdMedida"
        Me.txtQtdMedida.Numerico = True
        Me.txtQtdMedida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtdMedida.Properties.Appearance.Options.UseFont = True
        Me.txtQtdMedida.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdMedida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdMedida.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdMedida.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdMedida.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdMedida.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdMedida.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdMedida.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdMedida.Properties.MaxLength = 13
        Me.txtQtdMedida.Properties.ReadOnly = True
        Me.txtQtdMedida.Size = New System.Drawing.Size(106, 20)
        Me.txtQtdMedida.TabIndex = 6
        Me.txtQtdMedida.Tag = "Qtd"
        Me.txtQtdMedida.Visible = False
        '
        'txtMedidaB
        '
        Me.txtMedidaB.CasasDecimais = 3
        Me.txtMedidaB.EnterMoveNextControl = True
        Me.txtMedidaB.Location = New System.Drawing.Point(242, 37)
        Me.txtMedidaB.Name = "txtMedidaB"
        Me.txtMedidaB.Numerico = True
        Me.txtMedidaB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMedidaB.Properties.Appearance.Options.UseFont = True
        Me.txtMedidaB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMedidaB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMedidaB.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMedidaB.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMedidaB.Properties.MaxLength = 13
        Me.txtMedidaB.Size = New System.Drawing.Size(92, 20)
        Me.txtMedidaB.TabIndex = 5
        Me.txtMedidaB.Tag = "Medida B"
        Me.txtMedidaB.Visible = False
        '
        'txtMedidaA
        '
        Me.txtMedidaA.CasasDecimais = 3
        Me.txtMedidaA.EnterMoveNextControl = True
        Me.txtMedidaA.Location = New System.Drawing.Point(69, 37)
        Me.txtMedidaA.Name = "txtMedidaA"
        Me.txtMedidaA.Numerico = True
        Me.txtMedidaA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMedidaA.Properties.Appearance.Options.UseFont = True
        Me.txtMedidaA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMedidaA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMedidaA.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMedidaA.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMedidaA.Properties.MaxLength = 13
        Me.txtMedidaA.Size = New System.Drawing.Size(112, 20)
        Me.txtMedidaA.TabIndex = 4
        Me.txtMedidaA.Tag = "Medida A"
        Me.txtMedidaA.Visible = False
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.btnRemover)
        Me.XtraTabPage4.Controls.Add(Me.txtQtd2)
        Me.XtraTabPage4.Controls.Add(Me.txtTamanho2)
        Me.XtraTabPage4.Controls.Add(Label20)
        Me.XtraTabPage4.Controls.Add(Label21)
        Me.XtraTabPage4.Controls.Add(Label22)
        Me.XtraTabPage4.Controls.Add(Me.txtNomePro2)
        Me.XtraTabPage4.Controls.Add(Label23)
        Me.XtraTabPage4.Controls.Add(Me.txtCodPro2)
        Me.XtraTabPage4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(999, 66)
        Me.XtraTabPage4.Text = "Remover Produtos"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRemover.Location = New System.Drawing.Point(896, 37)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(95, 22)
        Me.btnRemover.TabIndex = 3
        Me.btnRemover.Text = "&Remover"
        '
        'txtQtd2
        '
        Me.txtQtd2.CasasDecimais = 3
        Me.txtQtd2.EnterMoveNextControl = True
        Me.txtQtd2.Location = New System.Drawing.Point(896, 11)
        Me.txtQtd2.Name = "txtQtd2"
        Me.txtQtd2.Numerico = True
        Me.txtQtd2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtd2.Properties.Appearance.Options.UseFont = True
        Me.txtQtd2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd2.Properties.MaxLength = 13
        Me.txtQtd2.Size = New System.Drawing.Size(95, 20)
        Me.txtQtd2.TabIndex = 2
        Me.txtQtd2.Tag = "Qtd"
        '
        'txtTamanho2
        '
        Me.txtTamanho2.CasasDecimais = 0
        Me.txtTamanho2.EnterMoveNextControl = True
        Me.txtTamanho2.Location = New System.Drawing.Point(790, 11)
        Me.txtTamanho2.Name = "txtTamanho2"
        Me.txtTamanho2.Numerico = False
        Me.txtTamanho2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTamanho2.Properties.Appearance.Options.UseFont = True
        Me.txtTamanho2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho2.Properties.MaxLength = 4
        Me.txtTamanho2.Size = New System.Drawing.Size(67, 20)
        Me.txtTamanho2.TabIndex = 1
        Me.txtTamanho2.Tag = "Tamanho"
        '
        'txtNomePro2
        '
        Me.txtNomePro2.CasasDecimais = 0
        Me.txtNomePro2.EnterMoveNextControl = True
        Me.txtNomePro2.Location = New System.Drawing.Point(242, 11)
        Me.txtNomePro2.Name = "txtNomePro2"
        Me.txtNomePro2.Numerico = False
        Me.txtNomePro2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro2.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomePro2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro2.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNomePro2.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomePro2.Properties.MaxLength = 200
        Me.txtNomePro2.Size = New System.Drawing.Size(472, 20)
        Me.txtNomePro2.TabIndex = 69
        Me.txtNomePro2.Tag = "Tamanho"
        '
        'txtCodPro2
        '
        Me.txtCodPro2.EnterMoveNextControl = True
        Me.txtCodPro2.Location = New System.Drawing.Point(69, 11)
        Me.txtCodPro2.Name = "txtCodPro2"
        Me.txtCodPro2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro2.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro2.Properties.MaxLength = 50
        Me.txtCodPro2.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPro2.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = ""
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(9, 56)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Properties.MaxLength = 13
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(192, 35)
        Me.txtTotal.TabIndex = 94
        Me.txtTotal.Tag = "Desconto %"
        '
        'txtTotItem
        '
        Me.txtTotItem.EditValue = ""
        Me.txtTotItem.EnterMoveNextControl = True
        Me.txtTotItem.Location = New System.Drawing.Point(9, 340)
        Me.txtTotItem.Name = "txtTotItem"
        Me.txtTotItem.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotItem.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotItem.Properties.Appearance.Options.UseFont = True
        Me.txtTotItem.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotItem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotItem.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotItem.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotItem.Properties.MaxLength = 13
        Me.txtTotItem.Properties.ReadOnly = True
        Me.txtTotItem.Size = New System.Drawing.Size(192, 35)
        Me.txtTotItem.TabIndex = 148
        Me.txtTotItem.Tag = "Desconto %"
        '
        'frmPedidoCompra
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 664)
        Me.Controls.Add(Me.tabProd)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.chkAlterado)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPedidoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Cadastro Pedido de Compra"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdDesc.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVal.ResumeLayout(False)
        Me.grpVal.PerformLayout()
        CType(Me.rdgDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRetirada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRetirada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProduto.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.tabAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAtivo.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExcluir2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeAtivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorAtivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodAtivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFocus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProd.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedidaB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedidaA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txtQtd2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bmComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents grpVal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pcLinha As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRec As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdDesc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkAlterado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dsItens As System.Data.DataSet
    Friend WithEvents tbItens As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCodigoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabelaPreco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedAut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtLimite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCli As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lueFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTamanho As Campos.NanoCampo
    Friend WithEvents lblVenc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtNomePro As Campos.NanoCampo
    Friend WithEvents txtQtd As Campos.NanoCampo
    Friend WithEvents btnPromissoria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnAtivo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnlProduto As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabAtivo As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkExcluir2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnExcluirAtivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNomeAtivo As Campos.NanoCampo
    Friend WithEvents txtValorAtivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodAtivo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnAddAtivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbAtivo As System.Data.DataTable
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents colCodAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colQtdAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFocus As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCodigoProdutoAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdutoAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedidoAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUMAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colQtdeAddAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInternoAmbos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdutoAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents tbAmbos As System.Data.DataTable
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents colCodigoPedidoAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents colVencimentoAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtVencimento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colFocus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents bsiVisualizar As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizarSemValores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizarComValores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPerDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colUniSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents colPromocao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents memAlt As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnLucro As DevExpress.XtraEditors.CheckButton
    Friend WithEvents colLucro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents btnCompromisso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbEntrada As System.Data.DataTable
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents btnEntrada As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rdgDesc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tabProd As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtQtd2 As Campos.NanoCampo
    Friend WithEvents txtTamanho2 As Campos.NanoCampo
    Friend WithEvents txtNomePro2 As Campos.NanoCampo
    Friend WithEvents txtCodPro2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dtEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtRetirada As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colMedidaA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidaB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMedidaB As Campos.NanoCampo
    Friend WithEvents txtMedidaA As Campos.NanoCampo
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents colQtdMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtQtdMedida As Campos.NanoCampo
    Friend WithEvents lblMedTot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMedB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMedA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents colCodProdFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAutoAdd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTotItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
End Class
