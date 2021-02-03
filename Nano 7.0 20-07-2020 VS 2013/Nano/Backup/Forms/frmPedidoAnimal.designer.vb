<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoAnimal
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoAnimal))
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtPerDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtQtd = New Campos.NanoCampo
        Me.txtNomePro = New Campos.NanoCampo
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
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
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisualizar = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizarComValores = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizarSemValores = New DevExpress.XtraBars.BarButtonItem
        Me.btnPromissoria = New DevExpress.XtraBars.BarButtonItem
        Me.btnMail = New DevExpress.XtraBars.BarButtonItem
        Me.btnAtivo = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem
        Me.lblFicha = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnN = New DevExpress.XtraBars.BarButtonItem
        Me.btnI = New DevExpress.XtraBars.BarButtonItem
        Me.btnS = New DevExpress.XtraBars.BarButtonItem
        Me.btnMax = New DevExpress.XtraBars.BarButtonItem
        Me.btnLinha = New DevExpress.XtraBars.BarButtonItem
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.chkAlterado = New DevExpress.XtraEditors.CheckEdit
        Me.btnConsulta = New DevExpress.XtraEditors.SimpleButton
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.lueFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.FuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.lblVenc = New DevExpress.XtraEditors.LabelControl
        Me.FuncionarioTableAdapter = New Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdAdd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdOk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdDesc = New DevExpress.XtraEditors.GroupControl
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.grpVal = New DevExpress.XtraEditors.GroupControl
        Me.txtTotPeso = New DevExpress.XtraEditors.TextEdit
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
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
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabelaPreco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoPeca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPromocao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRetorno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.txtNomeProp = New Campos.NanoCampo
        Me.txtNomeAnimal = New DevExpress.XtraEditors.ButtonEdit
        Me.GroupControl11 = New DevExpress.XtraEditors.GroupControl
        Me.txtRetorno = New Campos.NanoCampo
        Me.rtbFicha = New System.Windows.Forms.RichTextBox
        Me.txtSexo = New Campos.NanoCampo
        Me.txtNasc = New Campos.NanoCampo
        Me.txtRaca = New Campos.NanoCampo
        Me.txtID = New Campos.NanoCampo
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.btnL = New DevExpress.XtraBars.BarButtonItem
        Me.btnC = New DevExpress.XtraBars.BarButtonItem
        Me.btnR = New DevExpress.XtraBars.BarButtonItem
        Me.btnF = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem
        Me.barAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Label6 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label19 = New System.Windows.Forms.Label
        Label36 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdDesc.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVal.SuspendLayout()
        CType(Me.txtTotPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeProp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeAnimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl11.SuspendLayout()
        CType(Me.txtRetorno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNasc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(690, 56)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 13)
        Label6.TabIndex = 53
        Label6.Text = "Preço R$"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(859, 13)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 59
        Label8.Text = "Data"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(527, 56)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(48, 13)
        Label15.TabIndex = 63
        Label15.Text = "Desc. %"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(21, 30)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(222, 30)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(870, 30)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 58
        Label7.Text = "Qtd"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(9, 34)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(142, 18)
        Label10.TabIndex = 55
        Label10.Text = "Total Produtos R$"
        Label10.Visible = False
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(14, 199)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 18)
        Label5.TabIndex = 60
        Label5.Text = "Total Peso"
        Label5.Visible = False
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(10, 35)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(116, 18)
        Label11.TabIndex = 56
        Label11.Text = "Total Geral R$"
        '
        'Label19
        '
        Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(12, 201)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(89, 18)
        Label19.TabIndex = 78
        Label19.Text = "Total Itens"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Location = New System.Drawing.Point(698, 29)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(45, 13)
        Label36.TabIndex = 96
        Label36.Text = "Proprie."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(689, 30)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 65
        Label1.Text = "Ret. Dias"
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
        Me.txtCodPed.Location = New System.Drawing.Point(68, 9)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtCodPed.Size = New System.Drawing.Size(120, 20)
        Me.txtCodPed.TabIndex = 0
        Me.txtCodPed.Tag = "Nº Pedido"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(8, 12)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(54, 13)
        Me.lblCodPed.TabIndex = 1
        Me.lblCodPed.Text = "Nº Ordem"
        '
        'txtPerDesc
        '
        Me.txtPerDesc.EnterMoveNextControl = True
        Me.txtPerDesc.Location = New System.Drawing.Point(581, 53)
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
        Me.txtPerDesc.Size = New System.Drawing.Size(96, 20)
        Me.txtPerDesc.TabIndex = 4
        Me.txtPerDesc.Tag = "Preço R$"
        '
        'txtQtd
        '
        Me.txtQtd.CasasDecimais = 3
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(898, 27)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Numerico = True
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd.Properties.MaxLength = 4
        Me.txtQtd.Size = New System.Drawing.Size(96, 20)
        Me.txtQtd.TabIndex = 3
        Me.txtQtd.Tag = "Tamanho"
        '
        'txtNomePro
        '
        Me.txtNomePro.CasasDecimais = 0
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(273, 27)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Numerico = False
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomePro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomePro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomePro.Properties.MaxLength = 200
        Me.txtNomePro.Size = New System.Drawing.Size(404, 20)
        Me.txtNomePro.TabIndex = 1
        Me.txtNomePro.Tag = "Tamanho"
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(746, 53)
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
        Me.txtValor.Size = New System.Drawing.Size(95, 20)
        Me.txtValor.TabIndex = 5
        Me.txtValor.Tag = "Preço R$"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(67, 27)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Properties.MaxLength = 50
        Me.txtCodPro.Size = New System.Drawing.Size(141, 20)
        Me.txtCodPro.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(898, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 22)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Adicionar"
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens, Me.tbAtivo, Me.tbAmbos})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn10, Me.DataColumn11, Me.DataColumn9, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
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
        Me.DataColumn35.ColumnName = "Retorno"
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
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnExcluir, Me.btnPromissoria, Me.btnAtivo, Me.bsiVisualizar, Me.btnVisualizarSemValores, Me.btnVisualizarComValores, Me.btnMail, Me.btnImprimir})
        Me.bmComandos.MaxItemId = 19
        Me.bmComandos.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnImprimir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisualizar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnPromissoria, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnMail, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAtivo, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        Me.btnPromissoria.Glyph = Global.Nano.My.Resources.Resources.OS
        Me.btnPromissoria.Id = 12
        Me.btnPromissoria.Name = "btnPromissoria"
        '
        'btnMail
        '
        Me.btnMail.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnMail.Caption = "&Enviar"
        Me.btnMail.Glyph = Global.Nano.My.Resources.Resources.Mail
        Me.btnMail.Id = 17
        Me.btnMail.Name = "btnMail"
        '
        'btnAtivo
        '
        Me.btnAtivo.Caption = "Barril/Chopeira"
        Me.btnAtivo.Glyph = Global.Nano.My.Resources.Resources.Barril26
        Me.btnAtivo.Id = 13
        Me.btnAtivo.Name = "btnAtivo"
        Me.btnAtivo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnN, True)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnI)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnS)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnMax)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.btnLinha, True)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.bmComandos.SetPopupContextMenu(Me.RibbonStatusBar1, Me.popupMenu1)
        Me.RibbonControl1.SetPopupContextMenu(Me.RibbonStatusBar1, Me.popupMenu1)
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1001, 24)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Edit = Me.lblFicha
        Me.BarEditItem1.EditValue = "Ficha do Animal"
        Me.BarEditItem1.Enabled = False
        Me.BarEditItem1.Id = 16
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 96
        '
        'lblFicha
        '
        Me.lblFicha.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblFicha.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFicha.Appearance.Options.UseBackColor = True
        Me.lblFicha.Appearance.Options.UseFont = True
        Me.lblFicha.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent
        Me.lblFicha.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFicha.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.lblFicha.AppearanceDisabled.Options.UseBackColor = True
        Me.lblFicha.AppearanceDisabled.Options.UseFont = True
        Me.lblFicha.AppearanceDisabled.Options.UseForeColor = True
        Me.lblFicha.AutoHeight = False
        Me.lblFicha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblFicha.Name = "lblFicha"
        '
        'btnN
        '
        Me.btnN.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnN.Id = 12
        Me.btnN.ImageIndex = 15
        Me.btnN.Name = "btnN"
        ToolTipTitleItem1.Text = "Negrito"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnN.SuperTip = SuperToolTip1
        '
        'btnI
        '
        Me.btnI.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnI.Id = 13
        Me.btnI.ImageIndex = 16
        Me.btnI.Name = "btnI"
        ToolTipTitleItem2.Text = "Itálico"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        Me.btnI.SuperTip = SuperToolTip2
        '
        'btnS
        '
        Me.btnS.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnS.Id = 14
        Me.btnS.ImageIndex = 17
        Me.btnS.Name = "btnS"
        ToolTipTitleItem3.Text = "Sublinhado"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        Me.btnS.SuperTip = SuperToolTip3
        '
        'btnMax
        '
        Me.btnMax.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnMax.Glyph = Global.Nano.My.Resources.Resources.kpersonalizer18x18
        Me.btnMax.Id = 17
        Me.btnMax.Name = "btnMax"
        ToolTipTitleItem4.Text = "Maximizar"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        Me.btnMax.SuperTip = SuperToolTip4
        Me.btnMax.Tag = "MAX"
        '
        'btnLinha
        '
        Me.btnLinha.Id = 18
        Me.btnLinha.ImageIndex = 22
        Me.btnLinha.Name = "btnLinha"
        ToolTipTitleItem5.Text = "Inserir Linha"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        Me.btnLinha.SuperTip = SuperToolTip5
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonKeyTip = ""
        Me.RibbonControl1.ApplicationIcon = Nothing
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.Images = Me.imageList1
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnN, Me.btnI, Me.btnS, Me.BarEditItem1, Me.btnMax, Me.btnLinha})
        Me.RibbonControl1.LargeImages = Me.imageList1
        Me.RibbonControl1.Location = New System.Drawing.Point(820, 69)
        Me.RibbonControl1.MaxItemId = 19
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.SetPopupContextMenu(Me.RibbonControl1, Me.popupMenu1)
        Me.bmComandos.SetPopupContextMenu(Me.RibbonControl1, Me.popupMenu1)
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lblFicha})
        Me.RibbonControl1.Size = New System.Drawing.Size(22, 20)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
        Me.RibbonControl1.Visible = False
        '
        'popupMenu1
        '
        Me.popupMenu1.MenuBarWidth = 20
        Me.popupMenu1.Name = "popupMenu1"
        Me.popupMenu1.Ribbon = Me.RibbonControl1
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        Me.imageList1.Images.SetKeyName(8, "")
        Me.imageList1.Images.SetKeyName(9, "")
        Me.imageList1.Images.SetKeyName(10, "")
        Me.imageList1.Images.SetKeyName(11, "")
        Me.imageList1.Images.SetKeyName(12, "")
        Me.imageList1.Images.SetKeyName(13, "")
        Me.imageList1.Images.SetKeyName(14, "")
        Me.imageList1.Images.SetKeyName(15, "")
        Me.imageList1.Images.SetKeyName(16, "")
        Me.imageList1.Images.SetKeyName(17, "")
        Me.imageList1.Images.SetKeyName(18, "")
        Me.imageList1.Images.SetKeyName(19, "")
        Me.imageList1.Images.SetKeyName(20, "")
        Me.imageList1.Images.SetKeyName(21, "")
        Me.imageList1.Images.SetKeyName(22, "")
        Me.imageList1.Images.SetKeyName(23, "")
        Me.imageList1.Images.SetKeyName(24, "")
        Me.imageList1.Images.SetKeyName(25, "")
        Me.imageList1.Images.SetKeyName(26, "")
        Me.imageList1.Images.SetKeyName(27, "kpersonalizer18x18.png")
        Me.imageList1.Images.SetKeyName(28, "kwin18x18.png")
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(895, 10)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(100, 20)
        Me.dtData.TabIndex = 2
        Me.dtData.Tag = "Data"
        '
        'chkAlterado
        '
        Me.chkAlterado.Location = New System.Drawing.Point(897, 9)
        Me.chkAlterado.Name = "chkAlterado"
        Me.chkAlterado.Properties.Caption = "Alterado"
        Me.chkAlterado.Properties.ReadOnly = True
        Me.chkAlterado.Size = New System.Drawing.Size(87, 19)
        Me.chkAlterado.TabIndex = 61
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(188, 9)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 83
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(274, 9)
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
        Me.lueFunc.Properties.ValueMember = "Nome"
        Me.lueFunc.Size = New System.Drawing.Size(404, 20)
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
        Me.lblVenc.Location = New System.Drawing.Point(222, 13)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(46, 13)
        Me.lblVenc.TabIndex = 84
        Me.lblVenc.Text = "Vendedor"
        '
        'FuncionarioTableAdapter
        '
        Me.FuncionarioTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProduto, Me.colCodigoInterno, Me.colProduto, Me.colCodigoPedido, Me.colQtd, Me.colUM, Me.colQtdAdd, Me.colQtdOk})
        Me.GridView1.Name = "GridView1"
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
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.Caption = "CodigoInterno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto.AppearanceCell.Options.UseBackColor = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlt
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 236
        '
        'colCodigoPedido
        '
        Me.colCodigoPedido.Caption = "CodigoPedido"
        Me.colCodigoPedido.FieldName = "CodigoPedido"
        Me.colCodigoPedido.Name = "colCodigoPedido"
        Me.colCodigoPedido.Visible = True
        Me.colCodigoPedido.VisibleIndex = 3
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
        Me.colQtd.VisibleIndex = 3
        Me.colQtd.Width = 49
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
        Me.colUM.Width = 45
        '
        'colQtdAdd
        '
        Me.colQtdAdd.Caption = "QtdAdd"
        Me.colQtdAdd.FieldName = "QtdAdd"
        Me.colQtdAdd.Name = "colQtdAdd"
        Me.colQtdAdd.Visible = True
        Me.colQtdAdd.VisibleIndex = 5
        '
        'colQtdOk
        '
        Me.colQtdOk.Caption = "QtdOk"
        Me.colQtdOk.FieldName = "QtdOk"
        Me.colQtdOk.Name = "colQtdOk"
        Me.colQtdOk.Visible = True
        Me.colQtdOk.VisibleIndex = 6
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colExcluir, Me.colProduto1, Me.colCodPedAut, Me.colVencimento})
        Me.GridView2.Name = "GridView2"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
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
        Me.colExcluir.VisibleIndex = 6
        Me.colExcluir.Width = 51
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colProduto1
        '
        Me.colProduto1.Caption = "Produto"
        Me.colProduto1.FieldName = "Produto"
        Me.colProduto1.Name = "colProduto1"
        Me.colProduto1.Visible = True
        Me.colProduto1.VisibleIndex = 2
        '
        'colCodPedAut
        '
        Me.colCodPedAut.Caption = "CodPedAut"
        Me.colCodPedAut.ColumnEdit = Me.txtAlt
        Me.colCodPedAut.FieldName = "CodPedAut"
        Me.colCodPedAut.Name = "colCodPedAut"
        Me.colCodPedAut.OptionsColumn.ReadOnly = True
        Me.colCodPedAut.Width = 76
        '
        'colVencimento
        '
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 3
        '
        'grdDesc
        '
        Me.grdDesc.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDesc.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grdDesc.AppearanceCaption.Options.UseFont = True
        Me.grdDesc.AppearanceCaption.Options.UseForeColor = True
        Me.grdDesc.Controls.Add(Me.txtDesc)
        Me.grdDesc.Location = New System.Drawing.Point(1, 569)
        Me.grdDesc.Name = "grdDesc"
        Me.grdDesc.Size = New System.Drawing.Size(792, 52)
        Me.grdDesc.TabIndex = 6
        Me.grdDesc.Text = "Observações"
        '
        'txtDesc
        '
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.EditValue = ""
        Me.txtDesc.Location = New System.Drawing.Point(2, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Size = New System.Drawing.Size(788, 30)
        Me.txtDesc.TabIndex = 0
        '
        'grpVal
        '
        Me.grpVal.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVal.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpVal.AppearanceCaption.Options.UseFont = True
        Me.grpVal.AppearanceCaption.Options.UseForeColor = True
        Me.grpVal.Controls.Add(Me.txtTotPeso)
        Me.grpVal.Controls.Add(Me.txtTotal)
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
        Me.grpVal.Controls.Add(Label5)
        Me.grpVal.Controls.Add(Me.lblTro)
        Me.grpVal.Controls.Add(Me.lblRec)
        Me.grpVal.Controls.Add(Me.txtTro)
        Me.grpVal.Controls.Add(Me.txtRec)
        Me.grpVal.Controls.Add(Me.pcLinha)
        Me.grpVal.Controls.Add(Label10)
        Me.grpVal.Location = New System.Drawing.Point(792, 361)
        Me.grpVal.Name = "grpVal"
        Me.grpVal.Size = New System.Drawing.Size(214, 260)
        Me.grpVal.TabIndex = 5
        Me.grpVal.Text = "Valores do Pedido"
        '
        'txtTotPeso
        '
        Me.txtTotPeso.EditValue = ""
        Me.txtTotPeso.EnterMoveNextControl = True
        Me.txtTotPeso.Location = New System.Drawing.Point(13, 220)
        Me.txtTotPeso.Name = "txtTotPeso"
        Me.txtTotPeso.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotPeso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPeso.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotPeso.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotPeso.Properties.Appearance.Options.UseFont = True
        Me.txtTotPeso.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotPeso.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotPeso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotPeso.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotPeso.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotPeso.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotPeso.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotPeso.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotPeso.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotPeso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotPeso.Properties.MaxLength = 13
        Me.txtTotPeso.Properties.ReadOnly = True
        Me.txtTotPeso.Size = New System.Drawing.Size(190, 35)
        Me.txtTotPeso.TabIndex = 80
        Me.txtTotPeso.Tag = "Desconto %"
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = ""
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(13, 56)
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
        Me.txtTotal.Size = New System.Drawing.Size(190, 35)
        Me.txtTotal.TabIndex = 79
        Me.txtTotal.Tag = "Desconto %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(12, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 14)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Acréscimo"
        Me.Label12.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(8, 216)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 5)
        Me.PanelControl1.TabIndex = 75
        Me.PanelControl1.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 197)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 74
        Me.LabelControl1.Text = "Valor R$"
        Me.LabelControl1.Visible = False
        '
        'txtEntrega
        '
        Me.txtEntrega.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEntrega.EditValue = ""
        Me.txtEntrega.EnterMoveNextControl = True
        Me.txtEntrega.Location = New System.Drawing.Point(89, 183)
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
        Me.lblValDesc.Location = New System.Drawing.Point(19, 129)
        Me.lblValDesc.Name = "lblValDesc"
        Me.lblValDesc.Size = New System.Drawing.Size(65, 18)
        Me.lblValDesc.TabIndex = 72
        Me.lblValDesc.Text = "Valor R$"
        '
        'txtValDesc
        '
        Me.txtValDesc.EditValue = ""
        Me.txtValDesc.EnterMoveNextControl = True
        Me.txtValDesc.Location = New System.Drawing.Point(90, 118)
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
        Me.lblPor.Location = New System.Drawing.Point(66, 165)
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
        Me.lblDesc.Location = New System.Drawing.Point(11, 100)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(65, 14)
        Me.lblDesc.TabIndex = 69
        Me.lblDesc.Text = "Desconto"
        '
        'txtDesconto
        '
        Me.txtDesconto.EditValue = ""
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(90, 159)
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
        Me.lblTro.Location = New System.Drawing.Point(17, 201)
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
        Me.lblRec.Location = New System.Drawing.Point(17, 142)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(94, 18)
        Me.lblRec.TabIndex = 9
        Me.lblRec.Text = "Recebido R$"
        Me.lblRec.Visible = False
        '
        'txtTro
        '
        Me.txtTro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTro.Enabled = False
        Me.txtTro.Location = New System.Drawing.Point(14, 192)
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
        Me.txtRec.Location = New System.Drawing.Point(14, 161)
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
        Me.pcLinha.Location = New System.Drawing.Point(7, 106)
        Me.pcLinha.Name = "pcLinha"
        Me.pcLinha.Size = New System.Drawing.Size(200, 5)
        Me.pcLinha.TabIndex = 59
        '
        'grpItens
        '
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.AppearanceCaption.Options.UseForeColor = True
        Me.grpItens.Controls.Add(Me.picFundo)
        Me.grpItens.Controls.Add(Me.PedidoGridControl)
        Me.grpItens.Controls.Add(Me.btnDelete)
        Me.grpItens.Location = New System.Drawing.Point(0, 361)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(793, 209)
        Me.grpItens.TabIndex = 7
        Me.grpItens.Text = "Itens do Pedido"
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(2, 20)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(789, 166)
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
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt, Me.RepositoryItemCheckEdit1})
        Me.PedidoGridControl.Size = New System.Drawing.Size(789, 166)
        Me.PedidoGridControl.TabIndex = 7
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView3})
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colTabelaPreco, Me.colCodigoPeca, Me.colCodPedAut, Me.colCusto, Me.colUM, Me.colTamanho, Me.colExcluir, Me.colUniSemDesc, Me.colPromocao, Me.colDesconto, Me.colRetorno})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
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
        Me.colValorUnitario.VisibleIndex = 4
        Me.colValorUnitario.Width = 88
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
        Me.colValorTotal.VisibleIndex = 5
        Me.colValorTotal.Width = 85
        '
        'colTabelaPreco
        '
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
        Me.colCodigoPeca.Width = 77
        '
        'colCusto
        '
        Me.colCusto.Caption = "Custo"
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
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
        Me.colTamanho.Width = 46
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
        Me.colUniSemDesc.Width = 88
        '
        'colPromocao
        '
        Me.colPromocao.Caption = "Promocao"
        Me.colPromocao.FieldName = "Promocao"
        Me.colPromocao.Name = "colPromocao"
        '
        'colDesconto
        '
        Me.colDesconto.Caption = "Desconto"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        '
        'colRetorno
        '
        Me.colRetorno.Caption = "Retorno"
        Me.colRetorno.FieldName = "Retorno"
        Me.colRetorno.Name = "colRetorno"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProduto1, Me.colProduto2, Me.colQtd1, Me.colValorUnitario, Me.colValorTotal, Me.colTabelaPreco, Me.colCodigoInterno1, Me.colCodPedAut1, Me.colCusto, Me.colUM1, Me.colPeso, Me.colUniSemDesc, Me.colTamanho, Me.colExcluir1, Me.colPromocao, Me.colDesconto})
        Me.GridView3.GridControl = Me.PedidoGridControl
        Me.GridView3.Name = "GridView3"
        '
        'colCodigoProduto1
        '
        Me.colCodigoProduto1.Caption = "CodigoProduto"
        Me.colCodigoProduto1.FieldName = "CodigoProduto"
        Me.colCodigoProduto1.Name = "colCodigoProduto1"
        Me.colCodigoProduto1.Visible = True
        Me.colCodigoProduto1.VisibleIndex = 0
        '
        'colProduto2
        '
        Me.colProduto2.Caption = "Produto"
        Me.colProduto2.FieldName = "Produto"
        Me.colProduto2.Name = "colProduto2"
        Me.colProduto2.Visible = True
        Me.colProduto2.VisibleIndex = 1
        '
        'colQtd1
        '
        Me.colQtd1.Caption = "Qtd"
        Me.colQtd1.FieldName = "Qtd"
        Me.colQtd1.Name = "colQtd1"
        Me.colQtd1.Visible = True
        Me.colQtd1.VisibleIndex = 2
        '
        'colCodigoInterno1
        '
        Me.colCodigoInterno1.Caption = "CodigoInterno"
        Me.colCodigoInterno1.FieldName = "CodigoInterno"
        Me.colCodigoInterno1.Name = "colCodigoInterno1"
        Me.colCodigoInterno1.Visible = True
        Me.colCodigoInterno1.VisibleIndex = 4
        '
        'colCodPedAut1
        '
        Me.colCodPedAut1.Caption = "CodPedAut"
        Me.colCodPedAut1.FieldName = "CodPedAut"
        Me.colCodPedAut1.Name = "colCodPedAut1"
        Me.colCodPedAut1.Visible = True
        Me.colCodPedAut1.VisibleIndex = 6
        '
        'colUM1
        '
        Me.colUM1.Caption = "UM"
        Me.colUM1.FieldName = "UM"
        Me.colUM1.Name = "colUM1"
        Me.colUM1.Visible = True
        Me.colUM1.VisibleIndex = 7
        '
        'colPeso
        '
        Me.colPeso.Caption = "Peso"
        Me.colPeso.FieldName = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.Visible = True
        Me.colPeso.VisibleIndex = 8
        '
        'colExcluir1
        '
        Me.colExcluir1.Caption = "Excluir"
        Me.colExcluir1.FieldName = "Excluir"
        Me.colExcluir1.Name = "colExcluir1"
        Me.colExcluir1.Visible = True
        Me.colExcluir1.VisibleIndex = 9
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(2, 186)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(789, 21)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'txtNomeProp
        '
        Me.txtNomeProp.CasasDecimais = 0
        Me.txtNomeProp.EnterMoveNextControl = True
        Me.txtNomeProp.Location = New System.Drawing.Point(746, 26)
        Me.txtNomeProp.Name = "txtNomeProp"
        Me.txtNomeProp.Numerico = False
        Me.txtNomeProp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomeProp.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtNomeProp.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNomeProp.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtNomeProp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomeProp.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNomeProp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeProp.Properties.MaxLength = 50
        Me.txtNomeProp.Size = New System.Drawing.Size(248, 20)
        Me.txtNomeProp.TabIndex = 5
        Me.txtNomeProp.Tag = "Cedente"
        '
        'txtNomeAnimal
        '
        Me.txtNomeAnimal.EnterMoveNextControl = True
        Me.txtNomeAnimal.Location = New System.Drawing.Point(67, 26)
        Me.txtNomeAnimal.Name = "txtNomeAnimal"
        Me.txtNomeAnimal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAnimal.Properties.Appearance.Options.UseFont = True
        Me.txtNomeAnimal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNomeAnimal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNomeAnimal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNomeAnimal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNomeAnimal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNomeAnimal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtNomeAnimal.Properties.ReadOnly = True
        Me.txtNomeAnimal.Size = New System.Drawing.Size(141, 20)
        Me.txtNomeAnimal.TabIndex = 0
        Me.txtNomeAnimal.Tag = "Nome Animal"
        '
        'GroupControl11
        '
        Me.GroupControl11.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl11.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.GroupControl11.AppearanceCaption.Options.UseFont = True
        Me.GroupControl11.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl11.Controls.Add(Label1)
        Me.GroupControl11.Controls.Add(Me.txtRetorno)
        Me.GroupControl11.Controls.Add(Me.txtCodPro)
        Me.GroupControl11.Controls.Add(Label3)
        Me.GroupControl11.Controls.Add(Label4)
        Me.GroupControl11.Controls.Add(Me.txtValor)
        Me.GroupControl11.Controls.Add(Label6)
        Me.GroupControl11.Controls.Add(Me.btnAdd)
        Me.GroupControl11.Controls.Add(Label7)
        Me.GroupControl11.Controls.Add(Me.txtNomePro)
        Me.GroupControl11.Controls.Add(Me.txtQtd)
        Me.GroupControl11.Controls.Add(Me.txtPerDesc)
        Me.GroupControl11.Controls.Add(Label15)
        Me.GroupControl11.Location = New System.Drawing.Point(1, 281)
        Me.GroupControl11.Name = "GroupControl11"
        Me.GroupControl11.Size = New System.Drawing.Size(1005, 79)
        Me.GroupControl11.TabIndex = 4
        Me.GroupControl11.Text = "Dados do Produto"
        '
        'txtRetorno
        '
        Me.txtRetorno.CasasDecimais = 0
        Me.txtRetorno.EnterMoveNextControl = True
        Me.txtRetorno.Location = New System.Drawing.Point(746, 27)
        Me.txtRetorno.Name = "txtRetorno"
        Me.txtRetorno.Numerico = True
        Me.txtRetorno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRetorno.Properties.Appearance.Options.UseFont = True
        Me.txtRetorno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRetorno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRetorno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRetorno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRetorno.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtRetorno.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtRetorno.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtRetorno.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtRetorno.Properties.MaxLength = 150
        Me.txtRetorno.Size = New System.Drawing.Size(95, 20)
        Me.txtRetorno.TabIndex = 2
        Me.txtRetorno.Tag = "Tamanho"
        '
        'rtbFicha
        '
        Me.rtbFicha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbFicha.Location = New System.Drawing.Point(0, 24)
        Me.rtbFicha.Name = "rtbFicha"
        Me.rtbFicha.Size = New System.Drawing.Size(1001, 167)
        Me.rtbFicha.TabIndex = 0
        Me.rtbFicha.Tag = "Mensagem"
        Me.rtbFicha.Text = ""
        '
        'txtSexo
        '
        Me.txtSexo.CasasDecimais = 0
        Me.txtSexo.EnterMoveNextControl = True
        Me.txtSexo.Location = New System.Drawing.Point(384, 26)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Numerico = False
        Me.txtSexo.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtSexo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSexo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSexo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtSexo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtSexo.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtSexo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSexo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSexo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo.Properties.MaxLength = 50
        Me.txtSexo.Size = New System.Drawing.Size(57, 20)
        Me.txtSexo.TabIndex = 2
        Me.txtSexo.Tag = "Cedente"
        '
        'txtNasc
        '
        Me.txtNasc.CasasDecimais = 0
        Me.txtNasc.EditValue = ""
        Me.txtNasc.EnterMoveNextControl = True
        Me.txtNasc.Location = New System.Drawing.Point(273, 28)
        Me.txtNasc.Name = "txtNasc"
        Me.txtNasc.Numerico = False
        Me.txtNasc.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtNasc.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNasc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNasc.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtNasc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNasc.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtNasc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNasc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNasc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNasc.Properties.MaxLength = 50
        Me.txtNasc.Size = New System.Drawing.Size(72, 20)
        Me.txtNasc.TabIndex = 1
        Me.txtNasc.Tag = "Cedente"
        '
        'txtRaca
        '
        Me.txtRaca.CasasDecimais = 0
        Me.txtRaca.EnterMoveNextControl = True
        Me.txtRaca.Location = New System.Drawing.Point(480, 26)
        Me.txtRaca.Name = "txtRaca"
        Me.txtRaca.Numerico = False
        Me.txtRaca.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRaca.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtRaca.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtRaca.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtRaca.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRaca.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtRaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRaca.Properties.MaxLength = 50
        Me.txtRaca.Size = New System.Drawing.Size(95, 20)
        Me.txtRaca.TabIndex = 3
        Me.txtRaca.Tag = "Cedente"
        '
        'txtID
        '
        Me.txtID.CasasDecimais = 0
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(609, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Numerico = False
        Me.txtID.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtID.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtID.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtID.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtID.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtID.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Properties.MaxLength = 50
        Me.txtID.Size = New System.Drawing.Size(68, 20)
        Me.txtID.TabIndex = 4
        Me.txtID.Tag = "Cedente"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(450, 29)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl14.TabIndex = 99
        Me.LabelControl14.Text = "Raça"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(354, 29)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl15.TabIndex = 98
        Me.LabelControl15.Text = "Sexo"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(212, 29)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl16.TabIndex = 97
        Me.LabelControl16.Text = "Nascimento"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(592, 29)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl17.TabIndex = 1
        Me.LabelControl17.Text = "ID"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(34, 29)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl18.TabIndex = 100
        Me.LabelControl18.Text = "Nome"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.ImageIndex = 15
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.ImageIndex = 16
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem3.Id = 6
        Me.BarButtonItem3.ImageIndex = 17
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnL
        '
        Me.btnL.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnL.Id = 7
        Me.btnL.ImageIndex = 18
        Me.btnL.Name = "btnL"
        '
        'btnC
        '
        Me.btnC.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnC.Id = 8
        Me.btnC.ImageIndex = 19
        Me.btnC.Name = "btnC"
        '
        'btnR
        '
        Me.btnR.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnR.Id = 9
        Me.btnR.ImageIndex = 20
        Me.btnR.Name = "btnR"
        '
        'btnF
        '
        Me.btnF.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnF.Id = 10
        Me.btnF.ImageIndex = 4
        Me.btnF.Name = "btnF"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageIndex = 15
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageIndex = 16
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageIndex = 17
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageIndex = 18
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageIndex = 19
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageIndex = 20
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ImageIndex = 4
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem18.Id = 4
        Me.BarButtonItem18.ImageIndex = 15
        Me.BarButtonItem18.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem19.Id = 5
        Me.BarButtonItem19.ImageIndex = 16
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem20.Id = 6
        Me.BarButtonItem20.ImageIndex = 17
        Me.BarButtonItem20.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem21.Id = 7
        Me.BarButtonItem21.ImageIndex = 18
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem22.Id = 8
        Me.BarButtonItem22.ImageIndex = 19
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem23.Id = 9
        Me.BarButtonItem23.ImageIndex = 20
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem24.Id = 10
        Me.BarButtonItem24.ImageIndex = 4
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'barAndDockingController1
        '
        Me.barAndDockingController1.PaintStyleName = "Skin"
        Me.barAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtNomeAnimal)
        Me.GroupControl1.Controls.Add(Label36)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.txtNomeProp)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.txtSexo)
        Me.GroupControl1.Controls.Add(Me.txtNasc)
        Me.GroupControl1.Controls.Add(Me.txtRaca)
        Me.GroupControl1.Controls.Add(Me.txtID)
        Me.GroupControl1.Controls.Add(Me.PanelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(1, 35)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1005, 247)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Dados do Animal"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.rtbFicha)
        Me.PanelControl3.Controls.Add(Me.RibbonStatusBar1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(2, 54)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1001, 191)
        Me.PanelControl3.TabIndex = 112
        '
        'frmPedidoAnimal
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 664)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl11)
        Me.Controls.Add(Me.grdDesc)
        Me.Controls.Add(Me.grpVal)
        Me.Controls.Add(Me.grpItens)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.chkAlterado)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPedidoAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Cadastro de Pedido"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFicha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdDesc.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVal.ResumeLayout(False)
        Me.grpVal.PerformLayout()
        CType(Me.txtTotPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeProp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeAnimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl11.ResumeLayout(False)
        Me.GroupControl11.PerformLayout()
        CType(Me.txtRetorno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNasc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bmComandos As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkAlterado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
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
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lueFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents lblVenc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents FuncionarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionarioTableAdapter As Nano.dsNanoCommerceTableAdapters.FuncionarioTableAdapter
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPromissoria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents btnAtivo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbAtivo As System.Data.DataTable
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
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
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents bsiVisualizar As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnVisualizarSemValores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizarComValores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPerDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents btnMail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txtQtd As Campos.NanoCampo
    Friend WithEvents txtNomePro As Campos.NanoCampo
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
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
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colUniSemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromocao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpVal As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRec As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pcLinha As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdDesc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdAdd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdOk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedAut1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNomeProp As Campos.NanoCampo
    Friend WithEvents txtNomeAnimal As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl11 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rtbFicha As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSexo As Campos.NanoCampo
    Friend WithEvents txtNasc As Campos.NanoCampo
    Friend WithEvents txtRaca As Campos.NanoCampo
    Friend WithEvents txtID As Campos.NanoCampo
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
    Private WithEvents barAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents btnN As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnI As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents lblFicha As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnMax As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtRetorno As Campos.NanoCampo
    Friend WithEvents btnLinha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents colRetorno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotPeso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
End Class
