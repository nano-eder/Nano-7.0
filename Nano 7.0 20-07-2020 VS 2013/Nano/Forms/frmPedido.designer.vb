<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedido
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim LimiteLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedido))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFocus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.lblCodPed = New DevExpress.XtraEditors.LabelControl
        Me.txtQtd = New Campos.NanoCampo
        Me.txtNomePro = New Campos.NanoCampo
        Me.txtTamanho = New Campos.NanoCampo
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.grpItens = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage
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
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn96 = New System.Data.DataColumn
        Me.DataColumn99 = New System.Data.DataColumn
        Me.DataColumn102 = New System.Data.DataColumn
        Me.DataColumn103 = New System.Data.DataColumn
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
        Me.tbItens2 = New System.Data.DataTable
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn97 = New System.Data.DataColumn
        Me.DataColumn100 = New System.Data.DataColumn
        Me.tbItens3 = New System.Data.DataTable
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.DataColumn79 = New System.Data.DataColumn
        Me.DataColumn80 = New System.Data.DataColumn
        Me.DataColumn81 = New System.Data.DataColumn
        Me.DataColumn82 = New System.Data.DataColumn
        Me.DataColumn83 = New System.Data.DataColumn
        Me.DataColumn84 = New System.Data.DataColumn
        Me.DataColumn85 = New System.Data.DataColumn
        Me.DataColumn86 = New System.Data.DataColumn
        Me.DataColumn87 = New System.Data.DataColumn
        Me.DataColumn88 = New System.Data.DataColumn
        Me.DataColumn89 = New System.Data.DataColumn
        Me.DataColumn90 = New System.Data.DataColumn
        Me.DataColumn91 = New System.Data.DataColumn
        Me.DataColumn92 = New System.Data.DataColumn
        Me.DataColumn93 = New System.Data.DataColumn
        Me.DataColumn94 = New System.Data.DataColumn
        Me.DataColumn95 = New System.Data.DataColumn
        Me.DataColumn98 = New System.Data.DataColumn
        Me.DataColumn101 = New System.Data.DataColumn
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
        Me.colValorAnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAntPorc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAdd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoFuncionario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAutorizado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkAut = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colLocacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCampoPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage10 = New DevExpress.XtraTab.XtraTabPage
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colQtd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabelaPreco1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPromocao1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaA1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaB1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMedida1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAnt1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAntPorc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAdd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoFuncionario1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAutorizado1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage11 = New DevExpress.XtraTab.XtraTabPage
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoProduto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colQtd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTabelaPreco2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoInterno1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPedAut2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeso1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUniSemDesc2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExcluir3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPromocao2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaA2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMedidaB2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMedida2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAnt2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorAntPorc2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataAdd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoFuncionario2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAutorizado2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.txtTotalServ = New DevExpress.XtraEditors.TextEdit
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalprod = New DevExpress.XtraEditors.TextEdit
        Me.cboTabela = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.btnLucro = New DevExpress.XtraEditors.CheckButton
        Me.lblTotalServ = New DevExpress.XtraEditors.LabelControl
        Me.lblTotalprod = New DevExpress.XtraEditors.LabelControl
        Me.grdDesc = New DevExpress.XtraEditors.GroupControl
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.bmComandos = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisualizar = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizarComValores = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisuaPaisagem = New DevExpress.XtraBars.BarButtonItem
        Me.btnVisualizarSemValores = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnTermo = New DevExpress.XtraBars.BarButtonItem
        Me.btnProcesso = New DevExpress.XtraBars.BarButtonItem
        Me.btnChekList = New DevExpress.XtraBars.BarButtonItem
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
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.lblValorFrete = New DevExpress.XtraEditors.LabelControl
        Me.txtValorFrete = New DevExpress.XtraEditors.TextEdit
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.pnlPedidos = New DevExpress.XtraEditors.PanelControl
        Me.txtKMPedidos = New DevExpress.XtraEditors.TextEdit
        Me.txtSaiPedidos = New DevExpress.XtraEditors.TextEdit
        Me.txtEntPedidos = New DevExpress.XtraEditors.TextEdit
        Me.txtTotItem = New DevExpress.XtraEditors.TextEdit
        Me.txtTotPeso = New DevExpress.XtraEditors.TextEdit
        Me.lblTipoprod = New System.Windows.Forms.Label
        Me.rdgDesc = New DevExpress.XtraEditors.RadioGroup
        Me.Label12 = New System.Windows.Forms.Label
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtEntrega = New DevExpress.XtraEditors.TextEdit
        Me.lblValDesc = New DevExpress.XtraEditors.LabelControl
        Me.txtValDesc = New DevExpress.XtraEditors.TextEdit
        Me.lblPor = New DevExpress.XtraEditors.LabelControl
        Me.lblDesc = New System.Windows.Forms.Label
        Me.lblTro = New DevExpress.XtraEditors.LabelControl
        Me.lblRec = New DevExpress.XtraEditors.LabelControl
        Me.txtTro = New DevExpress.XtraEditors.TextEdit
        Me.txtRec = New DevExpress.XtraEditors.TextEdit
        Me.pcLinha = New DevExpress.XtraEditors.PanelControl
        Me.pnlTipoprod = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
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
        Me.pnlProduto = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.grpVeiculo = New DevExpress.XtraEditors.GroupControl
        Me.txtProbVeiculo = New DevExpress.XtraEditors.MemoEdit
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
        Me.lueTabelaPreco = New DevExpress.XtraEditors.LookUpEdit
        Me.dsTabPreco = New System.Data.DataSet
        Me.tbTabPreco = New System.Data.DataTable
        Me.DataColumn104 = New System.Data.DataColumn
        Me.DataColumn105 = New System.Data.DataColumn
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.NanoCampo3 = New Campos.NanoCampo
        Me.NanoCampo2 = New Campos.NanoCampo
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.NanoCampo1 = New Campos.NanoCampo
        Me.rdgTipoProd = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.cboCodFunc = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.lblCusto = New DevExpress.XtraEditors.LabelControl
        Me.txtCusto = New Campos.NanoCampo
        Me.chkCusto = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldoQtd = New Campos.NanoCampo
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtEmPedido = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtEmEstoque = New Campos.NanoCampo
        Me.txtValDesconto = New Campos.NanoCampo
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.txtValor = New Campos.NanoCampo
        Me.txtPerDesc = New Campos.NanoCampo
        Me.chkAutoAdd = New DevExpress.XtraEditors.CheckEdit
        Me.lblTamanho = New DevExpress.XtraEditors.LabelControl
        Me.Label25 = New System.Windows.Forms.Label
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.lblTamanho2 = New DevExpress.XtraEditors.LabelControl
        Me.chkAuto = New DevExpress.XtraEditors.CheckEdit
        Me.btnRemover = New DevExpress.XtraEditors.SimpleButton
        Me.txtQtd2 = New Campos.NanoCampo
        Me.txtTamanho2 = New Campos.NanoCampo
        Me.txtNomePro2 = New Campos.NanoCampo
        Me.txtCodPro2 = New DevExpress.XtraEditors.ButtonEdit
        Me.lblSin = New DevExpress.XtraEditors.LabelControl
        Me.txtSinistro = New DevExpress.XtraEditors.TextEdit
        Me.lblSeg = New DevExpress.XtraEditors.LabelControl
        Me.lblMedTot = New DevExpress.XtraEditors.LabelControl
        Me.lblMedB = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdMedida = New Campos.NanoCampo
        Me.txtMedidaB = New Campos.NanoCampo
        Me.lblMedA = New DevExpress.XtraEditors.LabelControl
        Me.txtMedidaA = New Campos.NanoCampo
        Me.txtComanda = New Campos.NanoCampo
        Me.lblComanda = New DevExpress.XtraEditors.LabelControl
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCadGrp = New DevExpress.XtraEditors.SimpleButton
        Me.cboGrp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.txtCPFCNPJ = New DevExpress.XtraEditors.TextEdit
        Me.btnCadCar = New DevExpress.XtraEditors.SimpleButton
        Me.luePlaca = New DevExpress.XtraEditors.LookUpEdit
        Me.txtNivCom = New Campos.NanoCampo
        Me.txtCor = New Campos.NanoCampo
        Me.txtAno = New Campos.NanoCampo
        Me.txtMotor = New Campos.NanoCampo
        Me.txtMod = New Campos.NanoCampo
        Me.lblEntrega = New DevExpress.XtraEditors.LabelControl
        Me.lblRetirada = New DevExpress.XtraEditors.LabelControl
        Me.lblKMEntrada = New DevExpress.XtraEditors.LabelControl
        Me.lblModelo = New DevExpress.XtraEditors.LabelControl
        Me.lblCor = New DevExpress.XtraEditors.LabelControl
        Me.lblMotor = New DevExpress.XtraEditors.LabelControl
        Me.lblAno = New DevExpress.XtraEditors.LabelControl
        Me.lblNivelComb = New DevExpress.XtraEditors.LabelControl
        Me.lblKMSaida = New DevExpress.XtraEditors.LabelControl
        Me.lblPlaca = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.txtCli = New DevExpress.XtraEditors.ButtonEdit
        Me.txtLimite = New DevExpress.XtraEditors.TextEdit
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.dtRetirada = New DevExpress.XtraEditors.DateEdit
        Me.txtKMSaida = New DevExpress.XtraEditors.TextEdit
        Me.dtEntrega = New DevExpress.XtraEditors.DateEdit
        Me.txtKm = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDiasEmAtraso = New Campos.NanoCampo
        Me.btnConsumo = New DevExpress.XtraEditors.SimpleButton
        Me.btnRelVendas = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.txtLimCli = New Campos.NanoCampo
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.txtSalDev = New Campos.NanoCampo
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.lblCred = New System.Windows.Forms.Label
        Me.txtCredito = New Campos.NanoCampo
        Me.txtLimiteCliente = New Campos.NanoCampo
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtNumCom = New Campos.NanoCampo
        Me.txtdtCad = New Campos.NanoCampo
        Me.lblTotalGasto = New System.Windows.Forms.Label
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalGasto = New Campos.NanoCampo
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtUltVis = New Campos.NanoCampo
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.txtSeguradora = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnCadSeg = New DevExpress.XtraEditors.SimpleButton
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        Label18 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label19 = New System.Windows.Forms.Label
        Label20 = New System.Windows.Forms.Label
        Label22 = New System.Windows.Forms.Label
        Label23 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        LimiteLabel = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label28 = New System.Windows.Forms.Label
        Label29 = New System.Windows.Forms.Label
        Label30 = New System.Windows.Forms.Label
        Label31 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label21 = New System.Windows.Forms.Label
        Label24 = New System.Windows.Forms.Label
        Label27 = New System.Windows.Forms.Label
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage10.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage11.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalServ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalprod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTabela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdDesc.SuspendLayout()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVal.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFrete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPedidos.SuspendLayout()
        CType(Me.txtKMPedidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaiPedidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntPedidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlTipoprod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProduto.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVeiculo.SuspendLayout()
        CType(Me.txtProbVeiculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lueTabelaPreco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsTabPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTabPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmEstoque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.chkAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamanho2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSinistro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedidaB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMedidaA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.txtCPFCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRetirada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRetirada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKMSaida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.txtDiasEmAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimiteCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtCad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalGasto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUltVis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.txtSeguradora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(36, 45)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(241, 45)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(827, 70)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 13)
        Label6.TabIndex = 53
        Label6.Text = "Preço R$"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(852, 45)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 58
        Label7.Text = "Qtd"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(850, 15)
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
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(11, 342)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 18)
        Label5.TabIndex = 60
        Label5.Text = "Total Peso"
        Label5.Visible = False
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
        Label15.Location = New System.Drawing.Point(614, 70)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(66, 13)
        Label15.TabIndex = 63
        Label15.Text = "Desconto %"
        '
        'Label19
        '
        Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label19.AutoSize = True
        Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(11, 386)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(89, 18)
        Label19.TabIndex = 78
        Label19.Text = "Total Itens"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(851, 76)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(25, 13)
        Label20.TabIndex = 67
        Label20.Text = "Qtd"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(41, 76)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(40, 13)
        Label22.TabIndex = 65
        Label22.Text = "Código"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(238, 76)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(45, 13)
        Label23.TabIndex = 66
        Label23.Text = "Produto"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(22, 10)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 13)
        Label2.TabIndex = 42
        Label2.Text = "F7 - Nome"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(242, 36)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "E-Mail"
        '
        'LimiteLabel
        '
        LimiteLabel.AutoSize = True
        LimiteLabel.Location = New System.Drawing.Point(391, 10)
        LimiteLabel.Name = "LimiteLabel"
        LimiteLabel.Size = New System.Drawing.Size(38, 13)
        LimiteLabel.TabIndex = 71
        LimiteLabel.Text = "Limite:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(627, 10)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(49, 13)
        Label13.TabIndex = 88
        Label13.Text = "Telefone"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(636, 36)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(40, 13)
        Label14.TabIndex = 89
        Label14.Text = "Celular"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(414, 70)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(68, 13)
        Label28.TabIndex = 76
        Label28.Text = "Desconto R$"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Label29.Location = New System.Drawing.Point(8, 95)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(30, 17)
        Label29.TabIndex = 81
        Label29.Text = "KM"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Label30.Location = New System.Drawing.Point(5, 48)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(45, 17)
        Label30.TabIndex = 79
        Label30.Text = "Saída"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Label31.Location = New System.Drawing.Point(5, 2)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(63, 17)
        Label31.TabIndex = 77
        Label31.Text = "Entrada"
        '
        'Label9
        '
        Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(592, 3)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(87, 13)
        Label9.TabIndex = 155
        Label9.Text = "Total Geral R$"
        '
        'Label21
        '
        Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(398, 3)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(108, 13)
        Label21.TabIndex = 156
        Label21.Text = "Total Produtos R$"
        '
        'Label24
        '
        Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(201, 3)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(105, 13)
        Label24.TabIndex = 157
        Label24.Text = "Total Serviços R$"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(23, 36)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(55, 13)
        Label27.TabIndex = 179
        Label27.Text = "CPF/CNPJ"
        '
        'colTipo
        '
        Me.colTipo.AppearanceCell.Options.UseTextOptions = True
        Me.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
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
        Me.txtCodPed.Location = New System.Drawing.Point(90, 11)
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
        Me.txtCodPed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodPed.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodPed.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodPed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPed.Size = New System.Drawing.Size(104, 21)
        Me.txtCodPed.TabIndex = 0
        Me.txtCodPed.Tag = "Nº Pedido"
        '
        'lblCodPed
        '
        Me.lblCodPed.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPed.Appearance.Options.UseFont = True
        Me.lblCodPed.Location = New System.Drawing.Point(30, 14)
        Me.lblCodPed.Name = "lblCodPed"
        Me.lblCodPed.Size = New System.Drawing.Size(54, 13)
        Me.lblCodPed.TabIndex = 1
        Me.lblCodPed.Text = "Nº Ordem"
        '
        'txtQtd
        '
        Me.txtQtd.CasasDecimais = 3
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(880, 41)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Numerico = True
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd.Properties.MaxLength = 13
        Me.txtQtd.Size = New System.Drawing.Size(110, 20)
        Me.txtQtd.TabIndex = 2
        Me.txtQtd.Tag = "Qtd"
        '
        'txtNomePro
        '
        Me.txtNomePro.CasasDecimais = 0
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(289, 41)
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
        Me.txtNomePro.Size = New System.Drawing.Size(305, 20)
        Me.txtNomePro.TabIndex = 61
        Me.txtNomePro.Tag = "Tamanho"
        '
        'txtTamanho
        '
        Me.txtTamanho.CasasDecimais = 0
        Me.txtTamanho.EnterMoveNextControl = True
        Me.txtTamanho.Location = New System.Drawing.Point(682, 41)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Numerico = False
        Me.txtTamanho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTamanho.Properties.Appearance.Options.UseFont = True
        Me.txtTamanho.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho.Properties.MaxLength = 30
        Me.txtTamanho.Size = New System.Drawing.Size(110, 20)
        Me.txtTamanho.TabIndex = 1
        Me.txtTamanho.Tag = "Tamanho"
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(78, 41)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Properties.MaxLength = 50
        Me.txtCodPro.Size = New System.Drawing.Size(131, 20)
        Me.txtCodPro.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(880, 95)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 26)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "&Adicionar"
        '
        'grpItens
        '
        Me.grpItens.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItens.AppearanceCaption.Options.UseFont = True
        Me.grpItens.Controls.Add(Me.SimpleButton2)
        Me.grpItens.Controls.Add(Me.XtraTabControl3)
        Me.grpItens.Controls.Add(Me.SimpleButton1)
        Me.grpItens.Controls.Add(Me.GroupControl1)
        Me.grpItens.Controls.Add(Me.cboTabela)
        Me.grpItens.Controls.Add(Me.btnPadrao)
        Me.grpItens.Controls.Add(Me.btnManter)
        Me.grpItens.Controls.Add(Me.btnLucro)
        Me.grpItens.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpItens.Location = New System.Drawing.Point(2, 2)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(796, 345)
        Me.grpItens.TabIndex = 6
        Me.grpItens.Text = "Itens - Tab."
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.Nano.My.Resources.Resources.viewmag18x18
        Me.SimpleButton2.Location = New System.Drawing.Point(287, 0)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(96, 19)
        Me.SimpleButton2.TabIndex = 162
        Me.SimpleButton2.Text = "Compras"
        Me.SimpleButton2.Visible = False
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.Location = New System.Drawing.Point(2, 20)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage9
        Me.XtraTabControl3.Size = New System.Drawing.Size(792, 268)
        Me.XtraTabControl3.TabIndex = 164
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage9, Me.XtraTabPage10, Me.XtraTabPage11})
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.picFundo)
        Me.XtraTabPage9.Controls.Add(Me.PedidoGridControl)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(783, 237)
        Me.XtraTabPage9.Text = "Pedido Atual"
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(0, 0)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(783, 237)
        Me.picFundo.TabIndex = 9
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbItens"
        Me.PedidoGridControl.DataSource = Me.dsItens
        Me.PedidoGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PedidoGridControl.LookAndFeel.SkinName = "Black"
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlt, Me.RepositoryItemCheckEdit1, Me.memAlt, Me.chkAut})
        Me.PedidoGridControl.Size = New System.Drawing.Size(783, 237)
        Me.PedidoGridControl.TabIndex = 7
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens, Me.tbAtivo, Me.tbAmbos, Me.tbEntrada, Me.tbItens2, Me.tbItens3})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn10, Me.DataColumn11, Me.DataColumn9, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn96, Me.DataColumn99, Me.DataColumn102, Me.DataColumn103})
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
        Me.DataColumn44.ColumnName = "Tipo"
        '
        'DataColumn45
        '
        Me.DataColumn45.Caption = "ValorAnt"
        Me.DataColumn45.ColumnName = "ValorAnt"
        '
        'DataColumn46
        '
        Me.DataColumn46.Caption = "ValorAntPorc"
        Me.DataColumn46.ColumnName = "ValorAntPorc"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "DataAdd"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "CodigoFuncionario"
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "Autorizado"
        Me.DataColumn99.DataType = GetType(Boolean)
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "Locacao"
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "CampoPedido"
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
        'tbItens2
        '
        Me.tbItens2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn97, Me.DataColumn100})
        Me.tbItens2.TableName = "tbItens2"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "CodigoProduto"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "Produto"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "Qtd"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ValorUnitario"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "ValorTotal"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "TabelaPreco"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "CodigoInterno"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "CodPedAut"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "Custo"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "UM"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "Peso"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "UniSemDesc"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "Tamanho"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "Excluir"
        Me.DataColumn61.DataType = GetType(Boolean)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "Promocao"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "Desconto"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "Lucro"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "MedidaA"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "MedidaB"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "QtdMedida"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "Tipo"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "ValorAnt"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "ValorAntPorc"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "DataAdd"
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "CodigoFuncionario"
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "Autorizado"
        Me.DataColumn100.DataType = GetType(Boolean)
        '
        'tbItens3
        '
        Me.tbItens3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn98, Me.DataColumn101})
        Me.tbItens3.TableName = "tbItens3"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "CodigoProduto"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "Produto"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "Qtd"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "ValorUnitario"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "ValorTotal"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "TabelaPreco"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "CodigoInterno"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "CodPedAut"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "Custo"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "UM"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "Peso"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "UniSemDesc"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "Tamanho"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "Excluir"
        Me.DataColumn85.DataType = GetType(Boolean)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "Promocao"
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "Desconto"
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "Lucro"
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "MedidaA"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "MedidaB"
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "QtdMedida"
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "Tipo"
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "ValorAnt"
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "ValorAntPorc"
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "DataAdd"
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "CodigoFuncionario"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "Autorizado"
        Me.DataColumn101.DataType = GetType(Boolean)
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtd, Me.colCodigoProduto, Me.colProduto, Me.colValorUnitario, Me.colValorTotal, Me.colTabelaPreco, Me.colCodigoPeca, Me.colCodPedAut, Me.colCusto, Me.colUM, Me.colTamanho, Me.colExcluir, Me.colUniSemDesc, Me.colPromocao, Me.colDesconto, Me.colLucro, Me.colMedidaA, Me.colMedidaB, Me.colQtdMedida, Me.colTipo, Me.colValorAnt, Me.colValorAntPorc, Me.colDataAdd, Me.colCodigoFuncionario, Me.colAutorizado, Me.colLocacao, Me.colCampoPedido})
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Bisque
        StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colTipo
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition4.Value1 = "SERVIÇO"
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition5.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colTipo
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = "SERVIÇO"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition4, StyleFormatCondition5})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.RowAutoHeight = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtAlt
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 46
        '
        'txtAlt
        '
        Me.txtAlt.AutoHeight = False
        Me.txtAlt.Name = "txtAlt"
        '
        'colCodigoProduto
        '
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
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.memAlt
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 204
        '
        'memAlt
        '
        Me.memAlt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memAlt.Name = "memAlt"
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Valor Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtAlt
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 86
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor Tot. R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlt
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 83
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
        Me.colCodigoPeca.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoPeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoPeca.Caption = "Código"
        Me.colCodigoPeca.ColumnEdit = Me.txtAlt
        Me.colCodigoPeca.FieldName = "CodigoInterno"
        Me.colCodigoPeca.Name = "colCodigoPeca"
        Me.colCodigoPeca.OptionsColumn.ReadOnly = True
        Me.colCodigoPeca.Visible = True
        Me.colCodigoPeca.VisibleIndex = 0
        Me.colCodigoPeca.Width = 69
        '
        'colCodPedAut
        '
        Me.colCodPedAut.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPedAut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPedAut.Caption = "CodPedAut"
        Me.colCodPedAut.ColumnEdit = Me.txtAlt
        Me.colCodPedAut.FieldName = "CodPedAut"
        Me.colCodPedAut.Name = "colCodPedAut"
        Me.colCodPedAut.OptionsColumn.ReadOnly = True
        Me.colCodPedAut.Width = 76
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.Caption = "Custo"
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.OptionsColumn.ReadOnly = True
        '
        'colUM
        '
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
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 3
        Me.colTamanho.Width = 46
        '
        'colExcluir
        '
        Me.colExcluir.Caption = "Excluir"
        Me.colExcluir.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colExcluir.FieldName = "Excluir"
        Me.colExcluir.Name = "colExcluir"
        Me.colExcluir.Visible = True
        Me.colExcluir.VisibleIndex = 8
        Me.colExcluir.Width = 51
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colUniSemDesc
        '
        Me.colUniSemDesc.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc.Caption = "Sem Desc. R$"
        Me.colUniSemDesc.FieldName = "UniSemDesc"
        Me.colUniSemDesc.Name = "colUniSemDesc"
        Me.colUniSemDesc.OptionsColumn.ReadOnly = True
        Me.colUniSemDesc.Visible = True
        Me.colUniSemDesc.VisibleIndex = 5
        Me.colUniSemDesc.Width = 89
        '
        'colPromocao
        '
        Me.colPromocao.Caption = "Promocao"
        Me.colPromocao.FieldName = "Promocao"
        Me.colPromocao.Name = "colPromocao"
        Me.colPromocao.OptionsColumn.ReadOnly = True
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDesconto.Caption = "Desconto"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        '
        'colLucro
        '
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
        Me.colMedidaA.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colMedidaA.AppearanceCell.Options.UseTextOptions = True
        Me.colMedidaA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMedidaA.Caption = "Medida A"
        Me.colMedidaA.FieldName = "MedidaA"
        Me.colMedidaA.Name = "colMedidaA"
        Me.colMedidaA.OptionsColumn.ReadOnly = True
        '
        'colMedidaB
        '
        Me.colMedidaB.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colMedidaB.AppearanceCell.Options.UseTextOptions = True
        Me.colMedidaB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMedidaB.Caption = "Medida B"
        Me.colMedidaB.FieldName = "MedidaB"
        Me.colMedidaB.Name = "colMedidaB"
        Me.colMedidaB.OptionsColumn.ReadOnly = True
        '
        'colQtdMedida
        '
        Me.colQtdMedida.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtdMedida.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMedida.Caption = "Qtd Med."
        Me.colQtdMedida.FieldName = "QtdMedida"
        Me.colQtdMedida.Name = "colQtdMedida"
        Me.colQtdMedida.OptionsColumn.ReadOnly = True
        '
        'colValorAnt
        '
        Me.colValorAnt.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorAnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValorAnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorAnt.Caption = "P. Ant. R$"
        Me.colValorAnt.FieldName = "ValorAnt"
        Me.colValorAnt.Name = "colValorAnt"
        Me.colValorAnt.OptionsColumn.ReadOnly = True
        '
        'colValorAntPorc
        '
        Me.colValorAntPorc.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorAntPorc.AppearanceCell.Options.UseTextOptions = True
        Me.colValorAntPorc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorAntPorc.Caption = "P. A. Desc. %"
        Me.colValorAntPorc.FieldName = "ValorAntPorc"
        Me.colValorAntPorc.Name = "colValorAntPorc"
        Me.colValorAntPorc.OptionsColumn.ReadOnly = True
        '
        'colDataAdd
        '
        Me.colDataAdd.AppearanceCell.Options.UseTextOptions = True
        Me.colDataAdd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataAdd.Caption = "Data Adic."
        Me.colDataAdd.FieldName = "DataAdd"
        Me.colDataAdd.Name = "colDataAdd"
        Me.colDataAdd.OptionsColumn.ReadOnly = True
        '
        'colCodigoFuncionario
        '
        Me.colCodigoFuncionario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoFuncionario.Caption = "Cód. Func."
        Me.colCodigoFuncionario.FieldName = "CodigoFuncionario"
        Me.colCodigoFuncionario.Name = "colCodigoFuncionario"
        Me.colCodigoFuncionario.OptionsColumn.ReadOnly = True
        '
        'colAutorizado
        '
        Me.colAutorizado.Caption = "Aut."
        Me.colAutorizado.ColumnEdit = Me.chkAut
        Me.colAutorizado.FieldName = "Autorizado"
        Me.colAutorizado.Name = "colAutorizado"
        Me.colAutorizado.OptionsColumn.ReadOnly = True
        Me.colAutorizado.Visible = True
        Me.colAutorizado.VisibleIndex = 9
        Me.colAutorizado.Width = 43
        '
        'chkAut
        '
        Me.chkAut.AutoHeight = False
        Me.chkAut.Name = "chkAut"
        '
        'colLocacao
        '
        Me.colLocacao.Caption = "Loc."
        Me.colLocacao.FieldName = "Locacao"
        Me.colLocacao.Name = "colLocacao"
        Me.colLocacao.OptionsColumn.ReadOnly = True
        '
        'colCampoPedido
        '
        Me.colCampoPedido.Caption = "CampoPedido"
        Me.colCampoPedido.FieldName = "CampoPedido"
        Me.colCampoPedido.Name = "colCampoPedido"
        Me.colCampoPedido.OptionsColumn.ReadOnly = True
        '
        'XtraTabPage10
        '
        Me.XtraTabPage10.Controls.Add(Me.PictureEdit1)
        Me.XtraTabPage10.Controls.Add(Me.GridControl3)
        Me.XtraTabPage10.Name = "XtraTabPage10"
        Me.XtraTabPage10.Size = New System.Drawing.Size(783, 237)
        Me.XtraTabPage10.Text = "Útimo Pedido"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(783, 237)
        Me.PictureEdit1.TabIndex = 10
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbItens2"
        Me.GridControl3.DataSource = Me.dsItens
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemCheckEdit3})
        Me.GridControl3.Size = New System.Drawing.Size(783, 237)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProduto1, Me.colProduto1, Me.colQtd1, Me.colValorUnitario1, Me.colValorTotal1, Me.colTabelaPreco1, Me.colCodigoInterno, Me.colCodPedAut1, Me.colCusto1, Me.colUM1, Me.colPeso, Me.colUniSemDesc1, Me.colTamanho1, Me.colExcluir1, Me.colPromocao1, Me.colDesconto1, Me.colLucro1, Me.colMedidaA1, Me.colMedidaB1, Me.colQtdMedida1, Me.colTipo1, Me.colValorAnt1, Me.colValorAntPorc1, Me.colDataAdd1, Me.colCodigoFuncionario1, Me.colAutorizado1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(622, 282, 216, 199)
        Me.GridView1.GridControl = Me.GridControl3
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colCodigoProduto1
        '
        Me.colCodigoProduto1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoProduto1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoProduto1.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoProduto1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto1.Caption = "Código"
        Me.colCodigoProduto1.FieldName = "CodigoProduto"
        Me.colCodigoProduto1.Name = "colCodigoProduto1"
        Me.colCodigoProduto1.OptionsColumn.ReadOnly = True
        Me.colCodigoProduto1.Width = 90
        '
        'colProduto1
        '
        Me.colProduto1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto1.AppearanceCell.Options.UseBackColor = True
        Me.colProduto1.Caption = "Produto"
        Me.colProduto1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colProduto1.FieldName = "Produto"
        Me.colProduto1.Name = "colProduto1"
        Me.colProduto1.OptionsColumn.ReadOnly = True
        Me.colProduto1.Visible = True
        Me.colProduto1.VisibleIndex = 1
        Me.colProduto1.Width = 192
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colQtd1
        '
        Me.colQtd1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtd1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtd1.AppearanceCell.Options.UseBackColor = True
        Me.colQtd1.Caption = "Qtde"
        Me.colQtd1.FieldName = "Qtd"
        Me.colQtd1.Name = "colQtd1"
        Me.colQtd1.OptionsColumn.ReadOnly = True
        Me.colQtd1.Visible = True
        Me.colQtd1.VisibleIndex = 3
        Me.colQtd1.Width = 64
        '
        'colValorUnitario1
        '
        Me.colValorUnitario1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorUnitario1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorUnitario1.AppearanceCell.Options.UseBackColor = True
        Me.colValorUnitario1.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario1.Caption = "Valor. Unit. R$"
        Me.colValorUnitario1.FieldName = "ValorUnitario"
        Me.colValorUnitario1.Name = "colValorUnitario1"
        Me.colValorUnitario1.OptionsColumn.ReadOnly = True
        Me.colValorUnitario1.Visible = True
        Me.colValorUnitario1.VisibleIndex = 5
        Me.colValorUnitario1.Width = 99
        '
        'colValorTotal1
        '
        Me.colValorTotal1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorTotal1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorTotal1.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal1.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal1.Caption = "Valor Total R$"
        Me.colValorTotal1.FieldName = "ValorTotal"
        Me.colValorTotal1.Name = "colValorTotal1"
        Me.colValorTotal1.OptionsColumn.ReadOnly = True
        Me.colValorTotal1.Visible = True
        Me.colValorTotal1.VisibleIndex = 6
        Me.colValorTotal1.Width = 88
        '
        'colTabelaPreco1
        '
        Me.colTabelaPreco1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTabelaPreco1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTabelaPreco1.AppearanceCell.Options.UseBackColor = True
        Me.colTabelaPreco1.Caption = "TabelaPreco"
        Me.colTabelaPreco1.FieldName = "TabelaPreco"
        Me.colTabelaPreco1.Name = "colTabelaPreco1"
        Me.colTabelaPreco1.OptionsColumn.ReadOnly = True
        Me.colTabelaPreco1.Width = 81
        '
        'colCodigoInterno
        '
        Me.colCodigoInterno.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoInterno.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoInterno.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno.Caption = "Código Interno"
        Me.colCodigoInterno.FieldName = "CodigoInterno"
        Me.colCodigoInterno.Name = "colCodigoInterno"
        Me.colCodigoInterno.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno.Visible = True
        Me.colCodigoInterno.VisibleIndex = 0
        Me.colCodigoInterno.Width = 110
        '
        'colCodPedAut1
        '
        Me.colCodPedAut1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodPedAut1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodPedAut1.AppearanceCell.Options.UseBackColor = True
        Me.colCodPedAut1.Caption = "Cód Ped"
        Me.colCodPedAut1.FieldName = "CodPedAut"
        Me.colCodPedAut1.Name = "colCodPedAut1"
        Me.colCodPedAut1.OptionsColumn.ReadOnly = True
        Me.colCodPedAut1.Width = 100
        '
        'colCusto1
        '
        Me.colCusto1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCusto1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCusto1.AppearanceCell.Options.UseBackColor = True
        Me.colCusto1.Caption = "Custo"
        Me.colCusto1.FieldName = "Custo"
        Me.colCusto1.Name = "colCusto1"
        Me.colCusto1.OptionsColumn.ReadOnly = True
        Me.colCusto1.Width = 45
        '
        'colUM1
        '
        Me.colUM1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUM1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUM1.AppearanceCell.Options.UseBackColor = True
        Me.colUM1.AppearanceCell.Options.UseTextOptions = True
        Me.colUM1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM1.Caption = "UM"
        Me.colUM1.FieldName = "UM"
        Me.colUM1.Name = "colUM1"
        Me.colUM1.OptionsColumn.ReadOnly = True
        Me.colUM1.Visible = True
        Me.colUM1.VisibleIndex = 2
        Me.colUM1.Width = 58
        '
        'colPeso
        '
        Me.colPeso.Caption = "Peso"
        Me.colPeso.FieldName = "Peso"
        Me.colPeso.Name = "colPeso"
        Me.colPeso.OptionsColumn.ReadOnly = True
        Me.colPeso.Width = 45
        '
        'colUniSemDesc1
        '
        Me.colUniSemDesc1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUniSemDesc1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUniSemDesc1.AppearanceCell.Options.UseBackColor = True
        Me.colUniSemDesc1.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc1.Caption = "Sem Desc R$"
        Me.colUniSemDesc1.FieldName = "UniSemDesc"
        Me.colUniSemDesc1.Name = "colUniSemDesc1"
        Me.colUniSemDesc1.OptionsColumn.ReadOnly = True
        Me.colUniSemDesc1.Visible = True
        Me.colUniSemDesc1.VisibleIndex = 4
        Me.colUniSemDesc1.Width = 96
        '
        'colTamanho1
        '
        Me.colTamanho1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTamanho1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTamanho1.AppearanceCell.Options.UseBackColor = True
        Me.colTamanho1.Caption = "Tam."
        Me.colTamanho1.FieldName = "Tamanho"
        Me.colTamanho1.Name = "colTamanho1"
        Me.colTamanho1.OptionsColumn.ReadOnly = True
        Me.colTamanho1.Width = 68
        '
        'colExcluir1
        '
        Me.colExcluir1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExcluir1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colExcluir1.AppearanceCell.Options.UseBackColor = True
        Me.colExcluir1.Caption = "Excluir"
        Me.colExcluir1.FieldName = "Excluir"
        Me.colExcluir1.Name = "colExcluir1"
        Me.colExcluir1.OptionsColumn.ReadOnly = True
        Me.colExcluir1.Width = 96
        '
        'colPromocao1
        '
        Me.colPromocao1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPromocao1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPromocao1.AppearanceCell.Options.UseBackColor = True
        Me.colPromocao1.Caption = "Promocao"
        Me.colPromocao1.FieldName = "Promocao"
        Me.colPromocao1.Name = "colPromocao1"
        Me.colPromocao1.OptionsColumn.ReadOnly = True
        Me.colPromocao1.Width = 97
        '
        'colDesconto1
        '
        Me.colDesconto1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDesconto1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDesconto1.AppearanceCell.Options.UseBackColor = True
        Me.colDesconto1.Caption = "Desconto"
        Me.colDesconto1.FieldName = "Desconto"
        Me.colDesconto1.Name = "colDesconto1"
        Me.colDesconto1.OptionsColumn.ReadOnly = True
        Me.colDesconto1.Width = 23
        '
        'colLucro1
        '
        Me.colLucro1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLucro1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colLucro1.AppearanceCell.Options.UseBackColor = True
        Me.colLucro1.Caption = "Lucro"
        Me.colLucro1.FieldName = "Lucro"
        Me.colLucro1.Name = "colLucro1"
        Me.colLucro1.OptionsColumn.ReadOnly = True
        Me.colLucro1.Width = 23
        '
        'colMedidaA1
        '
        Me.colMedidaA1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaA1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaA1.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaA1.Caption = "MedidaA"
        Me.colMedidaA1.FieldName = "MedidaA"
        Me.colMedidaA1.Name = "colMedidaA1"
        Me.colMedidaA1.OptionsColumn.ReadOnly = True
        Me.colMedidaA1.Width = 23
        '
        'colMedidaB1
        '
        Me.colMedidaB1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaB1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaB1.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaB1.Caption = "MedidaB"
        Me.colMedidaB1.FieldName = "MedidaB"
        Me.colMedidaB1.Name = "colMedidaB1"
        Me.colMedidaB1.OptionsColumn.ReadOnly = True
        Me.colMedidaB1.Width = 23
        '
        'colQtdMedida1
        '
        Me.colQtdMedida1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colQtdMedida1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtdMedida1.AppearanceCell.Options.UseBackColor = True
        Me.colQtdMedida1.Caption = "QtdMedida"
        Me.colQtdMedida1.FieldName = "QtdMedida"
        Me.colQtdMedida1.Name = "colQtdMedida1"
        Me.colQtdMedida1.OptionsColumn.ReadOnly = True
        Me.colQtdMedida1.Width = 23
        '
        'colTipo1
        '
        Me.colTipo1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTipo1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTipo1.AppearanceCell.Options.UseBackColor = True
        Me.colTipo1.Caption = "Tipo"
        Me.colTipo1.FieldName = "Tipo"
        Me.colTipo1.Name = "colTipo1"
        Me.colTipo1.OptionsColumn.ReadOnly = True
        Me.colTipo1.Width = 23
        '
        'colValorAnt1
        '
        Me.colValorAnt1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colValorAnt1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorAnt1.AppearanceCell.Options.UseBackColor = True
        Me.colValorAnt1.Caption = "ValorAnt"
        Me.colValorAnt1.FieldName = "ValorAnt"
        Me.colValorAnt1.Name = "colValorAnt1"
        Me.colValorAnt1.OptionsColumn.ReadOnly = True
        Me.colValorAnt1.Width = 23
        '
        'colValorAntPorc1
        '
        Me.colValorAntPorc1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorAntPorc1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorAntPorc1.AppearanceCell.Options.UseBackColor = True
        Me.colValorAntPorc1.Caption = "ValorAntPorc"
        Me.colValorAntPorc1.FieldName = "ValorAntPorc"
        Me.colValorAntPorc1.Name = "colValorAntPorc1"
        Me.colValorAntPorc1.OptionsColumn.ReadOnly = True
        Me.colValorAntPorc1.Width = 23
        '
        'colDataAdd1
        '
        Me.colDataAdd1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDataAdd1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDataAdd1.AppearanceCell.Options.UseBackColor = True
        Me.colDataAdd1.Caption = "DataAdd"
        Me.colDataAdd1.FieldName = "DataAdd"
        Me.colDataAdd1.Name = "colDataAdd1"
        Me.colDataAdd1.OptionsColumn.ReadOnly = True
        Me.colDataAdd1.Width = 47
        '
        'colCodigoFuncionario1
        '
        Me.colCodigoFuncionario1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodigoFuncionario1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoFuncionario1.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoFuncionario1.Caption = "Cód. Func."
        Me.colCodigoFuncionario1.FieldName = "CodigoFuncionario"
        Me.colCodigoFuncionario1.Name = "colCodigoFuncionario1"
        Me.colCodigoFuncionario1.OptionsColumn.ReadOnly = True
        '
        'colAutorizado1
        '
        Me.colAutorizado1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colAutorizado1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colAutorizado1.AppearanceCell.Options.UseBackColor = True
        Me.colAutorizado1.Caption = "Aut."
        Me.colAutorizado1.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colAutorizado1.FieldName = "Autorizado"
        Me.colAutorizado1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colAutorizado1.Name = "colAutorizado1"
        Me.colAutorizado1.OptionsColumn.ReadOnly = True
        Me.colAutorizado1.Visible = True
        Me.colAutorizado1.VisibleIndex = 7
        Me.colAutorizado1.Width = 55
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'XtraTabPage11
        '
        Me.XtraTabPage11.Controls.Add(Me.PictureEdit2)
        Me.XtraTabPage11.Controls.Add(Me.GridControl4)
        Me.XtraTabPage11.Name = "XtraTabPage11"
        Me.XtraTabPage11.Size = New System.Drawing.Size(783, 237)
        Me.XtraTabPage11.Text = "Todos Pedidos"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit2.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.PictureEdit2.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Size = New System.Drawing.Size(783, 237)
        Me.PictureEdit2.TabIndex = 10
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbItens3"
        Me.GridControl4.DataSource = Me.dsItens
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView2
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2, Me.RepositoryItemCheckEdit4})
        Me.GridControl4.Size = New System.Drawing.Size(783, 237)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoProduto2, Me.colProduto2, Me.colQtd2, Me.colValorUnitario2, Me.colValorTotal2, Me.colTabelaPreco2, Me.colCodigoInterno1, Me.colCodPedAut2, Me.colCusto2, Me.colUM2, Me.colPeso1, Me.colUniSemDesc2, Me.colTamanho2, Me.colExcluir3, Me.colPromocao2, Me.colDesconto2, Me.colLucro2, Me.colMedidaA2, Me.colMedidaB2, Me.colQtdMedida2, Me.colTipo2, Me.colValorAnt2, Me.colValorAntPorc2, Me.colDataAdd2, Me.colCodigoFuncionario2, Me.colAutorizado2})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(622, 313, 216, 199)
        Me.GridView2.GridControl = Me.GridControl4
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'colCodigoProduto2
        '
        Me.colCodigoProduto2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoProduto2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoProduto2.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoProduto2.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoProduto2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoProduto2.Caption = "Código"
        Me.colCodigoProduto2.FieldName = "CodigoProduto"
        Me.colCodigoProduto2.Name = "colCodigoProduto2"
        Me.colCodigoProduto2.OptionsColumn.ReadOnly = True
        '
        'colProduto2
        '
        Me.colProduto2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProduto2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colProduto2.AppearanceCell.Options.UseBackColor = True
        Me.colProduto2.Caption = "Produto"
        Me.colProduto2.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colProduto2.FieldName = "Produto"
        Me.colProduto2.Name = "colProduto2"
        Me.colProduto2.OptionsColumn.ReadOnly = True
        Me.colProduto2.Visible = True
        Me.colProduto2.VisibleIndex = 1
        Me.colProduto2.Width = 204
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colQtd2
        '
        Me.colQtd2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colQtd2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtd2.AppearanceCell.Options.UseBackColor = True
        Me.colQtd2.Caption = "Qtde"
        Me.colQtd2.FieldName = "Qtd"
        Me.colQtd2.Name = "colQtd2"
        Me.colQtd2.OptionsColumn.ReadOnly = True
        Me.colQtd2.Visible = True
        Me.colQtd2.VisibleIndex = 3
        Me.colQtd2.Width = 63
        '
        'colValorUnitario2
        '
        Me.colValorUnitario2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorUnitario2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorUnitario2.AppearanceCell.Options.UseBackColor = True
        Me.colValorUnitario2.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario2.Caption = "Valor Unit. R$"
        Me.colValorUnitario2.FieldName = "ValorUnitario"
        Me.colValorUnitario2.Name = "colValorUnitario2"
        Me.colValorUnitario2.OptionsColumn.ReadOnly = True
        Me.colValorUnitario2.Visible = True
        Me.colValorUnitario2.VisibleIndex = 5
        Me.colValorUnitario2.Width = 88
        '
        'colValorTotal2
        '
        Me.colValorTotal2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorTotal2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorTotal2.AppearanceCell.Options.UseBackColor = True
        Me.colValorTotal2.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal2.Caption = "Valor Total R$"
        Me.colValorTotal2.FieldName = "ValorTotal"
        Me.colValorTotal2.Name = "colValorTotal2"
        Me.colValorTotal2.OptionsColumn.ReadOnly = True
        Me.colValorTotal2.Visible = True
        Me.colValorTotal2.VisibleIndex = 6
        Me.colValorTotal2.Width = 100
        '
        'colTabelaPreco2
        '
        Me.colTabelaPreco2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTabelaPreco2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTabelaPreco2.AppearanceCell.Options.UseBackColor = True
        Me.colTabelaPreco2.Caption = "TabelaPreco"
        Me.colTabelaPreco2.FieldName = "TabelaPreco"
        Me.colTabelaPreco2.Name = "colTabelaPreco2"
        Me.colTabelaPreco2.OptionsColumn.ReadOnly = True
        '
        'colCodigoInterno1
        '
        Me.colCodigoInterno1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodigoInterno1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoInterno1.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoInterno1.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoInterno1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoInterno1.Caption = "Código Interno"
        Me.colCodigoInterno1.FieldName = "CodigoInterno"
        Me.colCodigoInterno1.Name = "colCodigoInterno1"
        Me.colCodigoInterno1.OptionsColumn.ReadOnly = True
        Me.colCodigoInterno1.Visible = True
        Me.colCodigoInterno1.VisibleIndex = 0
        Me.colCodigoInterno1.Width = 110
        '
        'colCodPedAut2
        '
        Me.colCodPedAut2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colCodPedAut2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodPedAut2.AppearanceCell.Options.UseBackColor = True
        Me.colCodPedAut2.Caption = "Cód Ped"
        Me.colCodPedAut2.FieldName = "CodPedAut"
        Me.colCodPedAut2.Name = "colCodPedAut2"
        Me.colCodPedAut2.OptionsColumn.ReadOnly = True
        '
        'colCusto2
        '
        Me.colCusto2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCusto2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCusto2.AppearanceCell.Options.UseBackColor = True
        Me.colCusto2.Caption = "Custo"
        Me.colCusto2.FieldName = "Custo"
        Me.colCusto2.Name = "colCusto2"
        Me.colCusto2.OptionsColumn.ReadOnly = True
        '
        'colUM2
        '
        Me.colUM2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUM2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUM2.AppearanceCell.Options.UseBackColor = True
        Me.colUM2.AppearanceCell.Options.UseTextOptions = True
        Me.colUM2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUM2.Caption = "UM"
        Me.colUM2.FieldName = "UM"
        Me.colUM2.Name = "colUM2"
        Me.colUM2.OptionsColumn.ReadOnly = True
        Me.colUM2.Visible = True
        Me.colUM2.VisibleIndex = 2
        Me.colUM2.Width = 58
        '
        'colPeso1
        '
        Me.colPeso1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPeso1.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPeso1.AppearanceCell.Options.UseBackColor = True
        Me.colPeso1.Caption = "Peso"
        Me.colPeso1.FieldName = "Peso"
        Me.colPeso1.Name = "colPeso1"
        Me.colPeso1.OptionsColumn.ReadOnly = True
        '
        'colUniSemDesc2
        '
        Me.colUniSemDesc2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUniSemDesc2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colUniSemDesc2.AppearanceCell.Options.UseBackColor = True
        Me.colUniSemDesc2.AppearanceCell.Options.UseTextOptions = True
        Me.colUniSemDesc2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUniSemDesc2.Caption = "Sem Desc R$"
        Me.colUniSemDesc2.FieldName = "UniSemDesc"
        Me.colUniSemDesc2.Name = "colUniSemDesc2"
        Me.colUniSemDesc2.OptionsColumn.ReadOnly = True
        Me.colUniSemDesc2.Visible = True
        Me.colUniSemDesc2.VisibleIndex = 4
        Me.colUniSemDesc2.Width = 84
        '
        'colTamanho2
        '
        Me.colTamanho2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTamanho2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTamanho2.AppearanceCell.Options.UseBackColor = True
        Me.colTamanho2.Caption = "Tam."
        Me.colTamanho2.FieldName = "Tamanho"
        Me.colTamanho2.Name = "colTamanho2"
        Me.colTamanho2.OptionsColumn.ReadOnly = True
        Me.colTamanho2.Width = 73
        '
        'colExcluir3
        '
        Me.colExcluir3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExcluir3.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colExcluir3.AppearanceCell.Options.UseBackColor = True
        Me.colExcluir3.Caption = "Excluir"
        Me.colExcluir3.FieldName = "Excluir"
        Me.colExcluir3.Name = "colExcluir3"
        Me.colExcluir3.OptionsColumn.ReadOnly = True
        '
        'colPromocao2
        '
        Me.colPromocao2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPromocao2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPromocao2.AppearanceCell.Options.UseBackColor = True
        Me.colPromocao2.Caption = "Promocao"
        Me.colPromocao2.FieldName = "Promocao"
        Me.colPromocao2.Name = "colPromocao2"
        Me.colPromocao2.OptionsColumn.ReadOnly = True
        '
        'colDesconto2
        '
        Me.colDesconto2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDesconto2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDesconto2.AppearanceCell.Options.UseBackColor = True
        Me.colDesconto2.Caption = "Desconto"
        Me.colDesconto2.FieldName = "Desconto"
        Me.colDesconto2.Name = "colDesconto2"
        Me.colDesconto2.OptionsColumn.ReadOnly = True
        '
        'colLucro2
        '
        Me.colLucro2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colLucro2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colLucro2.AppearanceCell.Options.UseBackColor = True
        Me.colLucro2.Caption = "Lucro"
        Me.colLucro2.FieldName = "Lucro"
        Me.colLucro2.Name = "colLucro2"
        Me.colLucro2.OptionsColumn.ReadOnly = True
        '
        'colMedidaA2
        '
        Me.colMedidaA2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaA2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaA2.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaA2.Caption = "MedidaA"
        Me.colMedidaA2.FieldName = "MedidaA"
        Me.colMedidaA2.Name = "colMedidaA2"
        Me.colMedidaA2.OptionsColumn.ReadOnly = True
        '
        'colMedidaB2
        '
        Me.colMedidaB2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMedidaB2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colMedidaB2.AppearanceCell.Options.UseBackColor = True
        Me.colMedidaB2.Caption = "MedidaB"
        Me.colMedidaB2.FieldName = "MedidaB"
        Me.colMedidaB2.Name = "colMedidaB2"
        Me.colMedidaB2.OptionsColumn.ReadOnly = True
        '
        'colQtdMedida2
        '
        Me.colQtdMedida2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colQtdMedida2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colQtdMedida2.AppearanceCell.Options.UseBackColor = True
        Me.colQtdMedida2.Caption = "QtdMedida"
        Me.colQtdMedida2.FieldName = "QtdMedida"
        Me.colQtdMedida2.Name = "colQtdMedida2"
        Me.colQtdMedida2.OptionsColumn.ReadOnly = True
        '
        'colTipo2
        '
        Me.colTipo2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTipo2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colTipo2.AppearanceCell.Options.UseBackColor = True
        Me.colTipo2.Caption = "Tipo"
        Me.colTipo2.FieldName = "Tipo"
        Me.colTipo2.Name = "colTipo2"
        Me.colTipo2.OptionsColumn.ReadOnly = True
        '
        'colValorAnt2
        '
        Me.colValorAnt2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colValorAnt2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorAnt2.AppearanceCell.Options.UseBackColor = True
        Me.colValorAnt2.Caption = "ValorAnt"
        Me.colValorAnt2.FieldName = "ValorAnt"
        Me.colValorAnt2.Name = "colValorAnt2"
        Me.colValorAnt2.OptionsColumn.ReadOnly = True
        '
        'colValorAntPorc2
        '
        Me.colValorAntPorc2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colValorAntPorc2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colValorAntPorc2.AppearanceCell.Options.UseBackColor = True
        Me.colValorAntPorc2.Caption = "ValorAntPorc"
        Me.colValorAntPorc2.FieldName = "ValorAntPorc"
        Me.colValorAntPorc2.Name = "colValorAntPorc2"
        Me.colValorAntPorc2.OptionsColumn.ReadOnly = True
        '
        'colDataAdd2
        '
        Me.colDataAdd2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDataAdd2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDataAdd2.AppearanceCell.Options.UseBackColor = True
        Me.colDataAdd2.Caption = "DataAdd"
        Me.colDataAdd2.FieldName = "DataAdd"
        Me.colDataAdd2.Name = "colDataAdd2"
        Me.colDataAdd2.OptionsColumn.ReadOnly = True
        '
        'colCodigoFuncionario2
        '
        Me.colCodigoFuncionario2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodigoFuncionario2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigoFuncionario2.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoFuncionario2.Caption = "Cód. Func."
        Me.colCodigoFuncionario2.FieldName = "CodigoFuncionario"
        Me.colCodigoFuncionario2.Name = "colCodigoFuncionario2"
        Me.colCodigoFuncionario2.OptionsColumn.ReadOnly = True
        '
        'colAutorizado2
        '
        Me.colAutorizado2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colAutorizado2.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colAutorizado2.AppearanceCell.Options.UseBackColor = True
        Me.colAutorizado2.Caption = "Aut."
        Me.colAutorizado2.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.colAutorizado2.FieldName = "Autorizado"
        Me.colAutorizado2.Name = "colAutorizado2"
        Me.colAutorizado2.OptionsColumn.ReadOnly = True
        Me.colAutorizado2.Visible = True
        Me.colAutorizado2.VisibleIndex = 7
        Me.colAutorizado2.Width = 55
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.Nano.My.Resources.Resources.OS18x18
        Me.SimpleButton1.Location = New System.Drawing.Point(191, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(96, 19)
        Me.SimpleButton1.TabIndex = 161
        Me.SimpleButton1.Text = "Comprar"
        Me.SimpleButton1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.PictureEdit3)
        Me.GroupControl1.Controls.Add(Label24)
        Me.GroupControl1.Controls.Add(Label21)
        Me.GroupControl1.Controls.Add(Label9)
        Me.GroupControl1.Controls.Add(Me.txtTotalServ)
        Me.GroupControl1.Controls.Add(Me.btnDelete)
        Me.GroupControl1.Controls.Add(Me.txtTotal)
        Me.GroupControl1.Controls.Add(Me.txtTotalprod)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(2, 288)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(792, 55)
        Me.GroupControl1.TabIndex = 109
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(-113, -3)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Size = New System.Drawing.Size(100, 96)
        Me.PictureEdit3.TabIndex = 10
        '
        'txtTotalServ
        '
        Me.txtTotalServ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalServ.EditValue = ""
        Me.txtTotalServ.EnterMoveNextControl = True
        Me.txtTotalServ.Location = New System.Drawing.Point(202, 22)
        Me.txtTotalServ.Name = "txtTotalServ"
        Me.txtTotalServ.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotalServ.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalServ.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalServ.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalServ.Properties.Appearance.Options.UseFont = True
        Me.txtTotalServ.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalServ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalServ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalServ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalServ.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalServ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalServ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalServ.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotalServ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalServ.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalServ.Properties.MaxLength = 13
        Me.txtTotalServ.Properties.ReadOnly = True
        Me.txtTotalServ.Size = New System.Drawing.Size(192, 31)
        Me.txtTotalServ.TabIndex = 154
        Me.txtTotalServ.Tag = "Desconto %"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(4, 22)
        Me.btnDelete.LookAndFeel.SkinName = "Money Twins"
        Me.btnDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(193, 30)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Excluir Item(ns)"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.EditValue = ""
        Me.txtTotal.EnterMoveNextControl = True
        Me.txtTotal.Location = New System.Drawing.Point(595, 22)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Properties.MaxLength = 13
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(192, 31)
        Me.txtTotal.TabIndex = 160
        Me.txtTotal.Tag = ""
        '
        'txtTotalprod
        '
        Me.txtTotalprod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalprod.EditValue = ""
        Me.txtTotalprod.EnterMoveNextControl = True
        Me.txtTotalprod.Location = New System.Drawing.Point(399, 22)
        Me.txtTotalprod.Name = "txtTotalprod"
        Me.txtTotalprod.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtTotalprod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalprod.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotalprod.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalprod.Properties.Appearance.Options.UseFont = True
        Me.txtTotalprod.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalprod.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalprod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalprod.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Moccasin
        Me.txtTotalprod.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalprod.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalprod.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalprod.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotalprod.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalprod.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalprod.Properties.MaxLength = 13
        Me.txtTotalprod.Properties.ReadOnly = True
        Me.txtTotalprod.Size = New System.Drawing.Size(192, 31)
        Me.txtTotalprod.TabIndex = 152
        Me.txtTotalprod.Tag = "Desconto %"
        '
        'cboTabela
        '
        Me.cboTabela.EditValue = "PADRÃO"
        Me.cboTabela.Location = New System.Drawing.Point(79, 0)
        Me.cboTabela.Name = "cboTabela"
        Me.cboTabela.Properties.AllowFocused = False
        Me.cboTabela.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboTabela.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTabela.Properties.Appearance.Options.UseBackColor = True
        Me.cboTabela.Properties.Appearance.Options.UseFont = True
        Me.cboTabela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTabela.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTabela.Size = New System.Drawing.Size(112, 19)
        Me.cboTabela.TabIndex = 108
        Me.cboTabela.Visible = False
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
        Me.btnPadrao.TabIndex = 107
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
        Me.btnManter.TabIndex = 106
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'btnLucro
        '
        Me.btnLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLucro.Location = New System.Drawing.Point(771, 1)
        Me.btnLucro.Name = "btnLucro"
        Me.btnLucro.Size = New System.Drawing.Size(22, 19)
        Me.btnLucro.TabIndex = 10
        Me.btnLucro.Text = "%"
        Me.btnLucro.ToolTip = "Clique para visualizar"
        Me.btnLucro.ToolTipTitle = "Margem de Lucro"
        '
        'lblTotalServ
        '
        Me.lblTotalServ.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalServ.Appearance.Options.UseFont = True
        Me.lblTotalServ.Location = New System.Drawing.Point(14, 201)
        Me.lblTotalServ.Name = "lblTotalServ"
        Me.lblTotalServ.Size = New System.Drawing.Size(69, 16)
        Me.lblTotalServ.TabIndex = 155
        Me.lblTotalServ.Text = "Serviço R$"
        Me.lblTotalServ.Visible = False
        '
        'lblTotalprod
        '
        Me.lblTotalprod.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalprod.Appearance.Options.UseFont = True
        Me.lblTotalprod.Location = New System.Drawing.Point(12, 225)
        Me.lblTotalprod.Name = "lblTotalprod"
        Me.lblTotalprod.Size = New System.Drawing.Size(73, 16)
        Me.lblTotalprod.TabIndex = 153
        Me.lblTotalprod.Text = "Produto R$"
        Me.lblTotalprod.Visible = False
        '
        'grdDesc
        '
        Me.grdDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDesc.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDesc.AppearanceCaption.Options.UseFont = True
        Me.grdDesc.Controls.Add(Me.txtDesc)
        Me.grdDesc.Location = New System.Drawing.Point(2, 350)
        Me.grdDesc.Name = "grdDesc"
        Me.grdDesc.Size = New System.Drawing.Size(400, 63)
        Me.grdDesc.TabIndex = 5
        Me.grdDesc.Text = "Observações"
        '
        'txtDesc
        '
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesc.Location = New System.Drawing.Point(2, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Size = New System.Drawing.Size(396, 41)
        Me.txtDesc.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 162)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Valor R$"
        Me.LabelControl3.Visible = False
        '
        'bmComandos
        '
        Me.bmComandos.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.bmComandos.DockControls.Add(Me.barDockControlTop)
        Me.bmComandos.DockControls.Add(Me.barDockControlBottom)
        Me.bmComandos.DockControls.Add(Me.barDockControlLeft)
        Me.bmComandos.DockControls.Add(Me.barDockControlRight)
        Me.bmComandos.Form = Me
        Me.bmComandos.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnExcluir, Me.btnPromissoria, Me.btnAtivo, Me.bsiVisualizar, Me.btnVisualizarSemValores, Me.btnVisualizarComValores, Me.btnMail, Me.btnImprimir, Me.btnCompromisso, Me.btnEntrada, Me.btnVender, Me.btnTermo, Me.btnProcesso, Me.btnChekList, Me.BarButtonItem1, Me.btnVisuaPaisagem})
        Me.bmComandos.MaxItemId = 27
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
        Me.bsiVisualizar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizarComValores), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisuaPaisagem), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizarSemValores), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTermo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnProcesso), New DevExpress.XtraBars.LinkPersistInfo(Me.btnChekList)})
        Me.bsiVisualizar.Name = "bsiVisualizar"
        '
        'btnVisualizarComValores
        '
        Me.btnVisualizarComValores.Caption = "&Com Valores"
        Me.btnVisualizarComValores.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizarComValores.Id = 16
        Me.btnVisualizarComValores.Name = "btnVisualizarComValores"
        '
        'btnVisuaPaisagem
        '
        Me.btnVisuaPaisagem.Caption = "Com Valores &Paisagem"
        Me.btnVisuaPaisagem.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisuaPaisagem.Id = 26
        Me.btnVisuaPaisagem.Name = "btnVisuaPaisagem"
        '
        'btnVisualizarSemValores
        '
        Me.btnVisualizarSemValores.Caption = "&Sem Valores"
        Me.btnVisualizarSemValores.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizarSemValores.Id = 15
        Me.btnVisualizarSemValores.Name = "btnVisualizarSemValores"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Com &Imagem"
        Me.BarButtonItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarButtonItem1.Id = 25
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnTermo
        '
        Me.btnTermo.Caption = "Termo Quitação"
        Me.btnTermo.Glyph = Global.Nano.My.Resources.Resources.Papier2
        Me.btnTermo.Id = 22
        Me.btnTermo.Name = "btnTermo"
        '
        'btnProcesso
        '
        Me.btnProcesso.Caption = "Processo"
        Me.btnProcesso.Glyph = Global.Nano.My.Resources.Resources.invoice
        Me.btnProcesso.Id = 23
        Me.btnProcesso.Name = "btnProcesso"
        '
        'btnChekList
        '
        Me.btnChekList.Caption = "Check-List"
        Me.btnChekList.Glyph = Global.Nano.My.Resources.Resources.MenuFiscal
        Me.btnChekList.Id = 24
        Me.btnChekList.Name = "btnChekList"
        '
        'btnPromissoria
        '
        Me.btnPromissoria.Caption = "&Promissória"
        Me.btnPromissoria.Glyph = Global.Nano.My.Resources.Resources.playlist
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
        'btnCompromisso
        '
        Me.btnCompromisso.Caption = "&Compromisso"
        Me.btnCompromisso.Glyph = Global.Nano.My.Resources.Resources.cal_2
        Me.btnCompromisso.Id = 19
        Me.btnCompromisso.Name = "btnCompromisso"
        '
        'btnVender
        '
        Me.btnVender.Caption = "&Vender"
        Me.btnVender.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnVender.Id = 21
        Me.btnVender.Name = "btnVender"
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
        Me.grpVal.AppearanceCaption.Options.UseFont = True
        Me.grpVal.Controls.Add(Me.PanelControl5)
        Me.grpVal.Controls.Add(Me.lblValorFrete)
        Me.grpVal.Controls.Add(Me.txtValorFrete)
        Me.grpVal.Controls.Add(Me.txtDesconto)
        Me.grpVal.Controls.Add(Me.LabelControl4)
        Me.grpVal.Controls.Add(Me.pnlPedidos)
        Me.grpVal.Controls.Add(Me.txtTotItem)
        Me.grpVal.Controls.Add(Me.lblTotalprod)
        Me.grpVal.Controls.Add(Me.lblTotalServ)
        Me.grpVal.Controls.Add(Me.txtTotPeso)
        Me.grpVal.Controls.Add(Me.lblTipoprod)
        Me.grpVal.Controls.Add(Label19)
        Me.grpVal.Controls.Add(Me.LabelControl3)
        Me.grpVal.Controls.Add(Me.rdgDesc)
        Me.grpVal.Controls.Add(Me.Label12)
        Me.grpVal.Controls.Add(Me.LabelControl1)
        Me.grpVal.Controls.Add(Me.txtEntrega)
        Me.grpVal.Controls.Add(Me.lblValDesc)
        Me.grpVal.Controls.Add(Me.txtValDesc)
        Me.grpVal.Controls.Add(Me.lblPor)
        Me.grpVal.Controls.Add(Me.lblDesc)
        Me.grpVal.Controls.Add(Label5)
        Me.grpVal.Controls.Add(Me.lblTro)
        Me.grpVal.Controls.Add(Me.lblRec)
        Me.grpVal.Controls.Add(Me.txtTro)
        Me.grpVal.Controls.Add(Me.txtRec)
        Me.grpVal.Controls.Add(Me.pcLinha)
        Me.grpVal.Controls.Add(Label10)
        Me.grpVal.Controls.Add(Me.pnlTipoprod)
        Me.grpVal.Controls.Add(Me.PanelControl1)
        Me.grpVal.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpVal.Location = New System.Drawing.Point(800, 0)
        Me.grpVal.Name = "grpVal"
        Me.grpVal.Size = New System.Drawing.Size(208, 414)
        Me.grpVal.TabIndex = 4
        Me.grpVal.Text = "Deconto/Acréscimo do Pedido"
        '
        'PanelControl5
        '
        Me.PanelControl5.Location = New System.Drawing.Point(3, 179)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(200, 5)
        Me.PanelControl5.TabIndex = 172
        '
        'lblValorFrete
        '
        Me.lblValorFrete.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorFrete.Appearance.Options.UseFont = True
        Me.lblValorFrete.Location = New System.Drawing.Point(14, 192)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(109, 18)
        Me.lblValorFrete.TabIndex = 171
        Me.lblValorFrete.Text = "Valor Frete R$"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.EditValue = ""
        Me.txtValorFrete.EnterMoveNextControl = True
        Me.txtValorFrete.Location = New System.Drawing.Point(12, 211)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValorFrete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorFrete.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValorFrete.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorFrete.Properties.Appearance.Options.UseFont = True
        Me.txtValorFrete.Properties.Appearance.Options.UseForeColor = True
        Me.txtValorFrete.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorFrete.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorFrete.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorFrete.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValorFrete.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorFrete.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValorFrete.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValorFrete.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValorFrete.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorFrete.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValorFrete.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorFrete.Properties.MaxLength = 13
        Me.txtValorFrete.Size = New System.Drawing.Size(188, 35)
        Me.txtValorFrete.TabIndex = 170
        Me.txtValorFrete.Tag = "Desconto %"
        '
        'txtDesconto
        '
        Me.txtDesconto.EditValue = ""
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(12, 133)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtDesconto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtDesconto.Properties.Appearance.Options.UseForeColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDesconto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDesconto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.Properties.MaxLength = 13
        Me.txtDesconto.Size = New System.Drawing.Size(189, 35)
        Me.txtDesconto.TabIndex = 1
        Me.txtDesconto.Tag = "Desconto %"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(8, 344)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(92, 18)
        Me.LabelControl4.TabIndex = 169
        Me.LabelControl4.Text = "Qtd de Itens"
        '
        'pnlPedidos
        '
        Me.pnlPedidos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlPedidos.Controls.Add(Label29)
        Me.pnlPedidos.Controls.Add(Me.txtKMPedidos)
        Me.pnlPedidos.Controls.Add(Label30)
        Me.pnlPedidos.Controls.Add(Me.txtSaiPedidos)
        Me.pnlPedidos.Controls.Add(Label31)
        Me.pnlPedidos.Controls.Add(Me.txtEntPedidos)
        Me.pnlPedidos.Location = New System.Drawing.Point(2, 192)
        Me.pnlPedidos.Name = "pnlPedidos"
        Me.pnlPedidos.Size = New System.Drawing.Size(202, 141)
        Me.pnlPedidos.TabIndex = 162
        Me.pnlPedidos.Visible = False
        '
        'txtKMPedidos
        '
        Me.txtKMPedidos.EnterMoveNextControl = True
        Me.txtKMPedidos.Location = New System.Drawing.Point(6, 115)
        Me.txtKMPedidos.Name = "txtKMPedidos"
        Me.txtKMPedidos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKMPedidos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKMPedidos.Properties.Appearance.Options.UseBackColor = True
        Me.txtKMPedidos.Properties.Appearance.Options.UseFont = True
        Me.txtKMPedidos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKMPedidos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKMPedidos.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtKMPedidos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKMPedidos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtKMPedidos.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtKMPedidos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtKMPedidos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtKMPedidos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKMPedidos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtKMPedidos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtKMPedidos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtKMPedidos.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtKMPedidos.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKMPedidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKMPedidos.Properties.MaxLength = 40
        Me.txtKMPedidos.Properties.ReadOnly = True
        Me.txtKMPedidos.Size = New System.Drawing.Size(191, 23)
        Me.txtKMPedidos.TabIndex = 80
        '
        'txtSaiPedidos
        '
        Me.txtSaiPedidos.EnterMoveNextControl = True
        Me.txtSaiPedidos.Location = New System.Drawing.Point(6, 69)
        Me.txtSaiPedidos.Name = "txtSaiPedidos"
        Me.txtSaiPedidos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaiPedidos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaiPedidos.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaiPedidos.Properties.Appearance.Options.UseFont = True
        Me.txtSaiPedidos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaiPedidos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSaiPedidos.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtSaiPedidos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaiPedidos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtSaiPedidos.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSaiPedidos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtSaiPedidos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtSaiPedidos.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSaiPedidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaiPedidos.Properties.MaxLength = 40
        Me.txtSaiPedidos.Properties.ReadOnly = True
        Me.txtSaiPedidos.Size = New System.Drawing.Size(191, 23)
        Me.txtSaiPedidos.TabIndex = 78
        '
        'txtEntPedidos
        '
        Me.txtEntPedidos.EnterMoveNextControl = True
        Me.txtEntPedidos.Location = New System.Drawing.Point(6, 22)
        Me.txtEntPedidos.Name = "txtEntPedidos"
        Me.txtEntPedidos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEntPedidos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntPedidos.Properties.Appearance.Options.UseBackColor = True
        Me.txtEntPedidos.Properties.Appearance.Options.UseFont = True
        Me.txtEntPedidos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEntPedidos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEntPedidos.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtEntPedidos.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntPedidos.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtEntPedidos.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtEntPedidos.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtEntPedidos.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtEntPedidos.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEntPedidos.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEntPedidos.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEntPedidos.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEntPedidos.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtEntPedidos.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEntPedidos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntPedidos.Properties.MaxLength = 40
        Me.txtEntPedidos.Properties.ReadOnly = True
        Me.txtEntPedidos.Size = New System.Drawing.Size(191, 23)
        Me.txtEntPedidos.TabIndex = 76
        '
        'txtTotItem
        '
        Me.txtTotItem.EditValue = ""
        Me.txtTotItem.EnterMoveNextControl = True
        Me.txtTotItem.Location = New System.Drawing.Point(9, 368)
        Me.txtTotItem.Name = "txtTotItem"
        Me.txtTotItem.Properties.Appearance.BackColor = System.Drawing.Color.BlueViolet
        Me.txtTotItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotItem.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotItem.Properties.Appearance.Options.UseFont = True
        Me.txtTotItem.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotItem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtTotItem.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotItem.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTotItem.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotItem.Properties.MaxLength = 13
        Me.txtTotItem.Properties.ReadOnly = True
        Me.txtTotItem.Size = New System.Drawing.Size(192, 35)
        Me.txtTotItem.TabIndex = 158
        Me.txtTotItem.Tag = ""
        '
        'txtTotPeso
        '
        Me.txtTotPeso.EditValue = ""
        Me.txtTotPeso.EnterMoveNextControl = True
        Me.txtTotPeso.Location = New System.Drawing.Point(8, 363)
        Me.txtTotPeso.Name = "txtTotPeso"
        Me.txtTotPeso.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtTotPeso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPeso.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTotPeso.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotPeso.Properties.Appearance.Options.UseFont = True
        Me.txtTotPeso.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotPeso.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotPeso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotPeso.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTotPeso.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotPeso.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotPeso.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotPeso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotPeso.Properties.MaxLength = 13
        Me.txtTotPeso.Size = New System.Drawing.Size(192, 35)
        Me.txtTotPeso.TabIndex = 161
        Me.txtTotPeso.Tag = ""
        Me.txtTotPeso.Visible = False
        '
        'lblTipoprod
        '
        Me.lblTipoprod.AutoSize = True
        Me.lblTipoprod.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoprod.ForeColor = System.Drawing.Color.Blue
        Me.lblTipoprod.Location = New System.Drawing.Point(10, 135)
        Me.lblTipoprod.Name = "lblTipoprod"
        Me.lblTipoprod.Size = New System.Drawing.Size(68, 14)
        Me.lblTipoprod.TabIndex = 157
        Me.lblTipoprod.Text = "Total Tipo"
        Me.lblTipoprod.Visible = False
        '
        'rdgDesc
        '
        Me.rdgDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgDesc.EditValue = True
        Me.rdgDesc.Location = New System.Drawing.Point(8, 27)
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
        Me.Label12.Location = New System.Drawing.Point(9, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 14)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Acréscimo"
        Me.Label12.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(25, 159)
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
        Me.txtEntrega.Location = New System.Drawing.Point(86, 148)
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
        Me.lblValDesc.Location = New System.Drawing.Point(14, 54)
        Me.lblValDesc.Name = "lblValDesc"
        Me.lblValDesc.Size = New System.Drawing.Size(65, 18)
        Me.lblValDesc.TabIndex = 72
        Me.lblValDesc.Text = "Valor R$"
        '
        'txtValDesc
        '
        Me.txtValDesc.EditValue = ""
        Me.txtValDesc.EnterMoveNextControl = True
        Me.txtValDesc.Location = New System.Drawing.Point(12, 73)
        Me.txtValDesc.Name = "txtValDesc"
        Me.txtValDesc.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValDesc.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseFont = True
        Me.txtValDesc.Properties.Appearance.Options.UseForeColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValDesc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValDesc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValDesc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValDesc.Properties.MaxLength = 13
        Me.txtValDesc.Size = New System.Drawing.Size(188, 35)
        Me.txtValDesc.TabIndex = 0
        Me.txtValDesc.Tag = "Desconto %"
        '
        'lblPor
        '
        Me.lblPor.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.Appearance.Options.UseFont = True
        Me.lblPor.Location = New System.Drawing.Point(14, 114)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(120, 18)
        Me.lblPor.TabIndex = 70
        Me.lblPor.Text = "Porcentagem %"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.Blue
        Me.lblDesc.Location = New System.Drawing.Point(8, 27)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(65, 14)
        Me.lblDesc.TabIndex = 69
        Me.lblDesc.Text = "Desconto"
        '
        'lblTro
        '
        Me.lblTro.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTro.Appearance.Options.UseFont = True
        Me.lblTro.Location = New System.Drawing.Point(14, 122)
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
        Me.lblRec.Location = New System.Drawing.Point(14, 69)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(94, 18)
        Me.lblRec.TabIndex = 9
        Me.lblRec.Text = "Recebido R$"
        Me.lblRec.Visible = False
        '
        'txtTro
        '
        Me.txtTro.Enabled = False
        Me.txtTro.Location = New System.Drawing.Point(11, 151)
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
        Me.txtRec.Location = New System.Drawing.Point(11, 88)
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
        Me.pcLinha.Location = New System.Drawing.Point(11, 33)
        Me.pcLinha.Name = "pcLinha"
        Me.pcLinha.Size = New System.Drawing.Size(184, 5)
        Me.pcLinha.TabIndex = 59
        '
        'pnlTipoprod
        '
        Me.pnlTipoprod.Location = New System.Drawing.Point(5, 141)
        Me.pnlTipoprod.Name = "pnlTipoprod"
        Me.pnlTipoprod.Size = New System.Drawing.Size(197, 5)
        Me.pnlTipoprod.TabIndex = 156
        Me.pnlTipoprod.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(5, 137)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(197, 5)
        Me.PanelControl1.TabIndex = 75
        Me.PanelControl1.Visible = False
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(886, 12)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtData.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(110, 20)
        Me.dtData.TabIndex = 5
        Me.dtData.Tag = "Data"
        '
        'chkAlterado
        '
        Me.chkAlterado.Location = New System.Drawing.Point(907, 12)
        Me.chkAlterado.Name = "chkAlterado"
        Me.chkAlterado.Properties.Caption = "Alterado"
        Me.chkAlterado.Properties.ReadOnly = True
        Me.chkAlterado.Size = New System.Drawing.Size(87, 19)
        Me.chkAlterado.TabIndex = 5
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsulta.Location = New System.Drawing.Point(194, 11)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(21, 21)
        Me.btnConsulta.TabIndex = 83
        Me.btnConsulta.ToolTipTitle = "Consulta de Pedido"
        '
        'lueFunc
        '
        Me.lueFunc.EnterMoveNextControl = True
        Me.lueFunc.Location = New System.Drawing.Point(289, 12)
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
        Me.lueFunc.Size = New System.Drawing.Size(306, 20)
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
        Me.lblVenc.Location = New System.Drawing.Point(237, 15)
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
        'pnlProduto
        '
        Me.pnlProduto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProduto.Controls.Add(Me.PanelControl2)
        Me.pnlProduto.Controls.Add(Me.grpVal)
        Me.pnlProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProduto.Location = New System.Drawing.Point(0, 0)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(1008, 414)
        Me.pnlProduto.TabIndex = 8
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grpVeiculo)
        Me.PanelControl2.Controls.Add(Me.grpItens)
        Me.PanelControl2.Controls.Add(Me.grdDesc)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(800, 414)
        Me.PanelControl2.TabIndex = 7
        '
        'grpVeiculo
        '
        Me.grpVeiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVeiculo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVeiculo.AppearanceCaption.Options.UseFont = True
        Me.grpVeiculo.Controls.Add(Me.txtProbVeiculo)
        Me.grpVeiculo.Location = New System.Drawing.Point(403, 350)
        Me.grpVeiculo.Name = "grpVeiculo"
        Me.grpVeiculo.Size = New System.Drawing.Size(395, 63)
        Me.grpVeiculo.TabIndex = 17
        Me.grpVeiculo.Text = "Defeitos do Veículo"
        '
        'txtProbVeiculo
        '
        Me.txtProbVeiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProbVeiculo.Location = New System.Drawing.Point(2, 20)
        Me.txtProbVeiculo.Name = "txtProbVeiculo"
        Me.txtProbVeiculo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtProbVeiculo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtProbVeiculo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtProbVeiculo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtProbVeiculo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProbVeiculo.Size = New System.Drawing.Size(391, 41)
        Me.txtProbVeiculo.TabIndex = 1
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
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 240)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(1008, 414)
        Me.pnlPrincipal.TabIndex = 90
        '
        'Timer2
        '
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(623, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Text = "Status Nano"
        '
        'cboStatus
        '
        Me.cboStatus.EditValue = "Pendente"
        Me.cboStatus.EnterMoveNextControl = True
        Me.cboStatus.Location = New System.Drawing.Point(688, 12)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboStatus.Properties.Appearance.Options.UseFont = True
        Me.cboStatus.Properties.Appearance.Options.UseForeColor = True
        Me.cboStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboStatus.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cboStatus.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboStatus.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.Items.AddRange(New Object() {"Pendente", "Orçamento"})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(110, 20)
        Me.cboStatus.TabIndex = 3
        '
        'tabProd
        '
        Me.tabProd.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.AppearancePage.Header.Options.UseFont = True
        Me.tabProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabProd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabProd.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.tabProd.Location = New System.Drawing.Point(0, 0)
        Me.tabProd.Name = "tabProd"
        Me.tabProd.SelectedTabPage = Me.XtraTabPage3
        Me.tabProd.Size = New System.Drawing.Size(999, 162)
        Me.tabProd.TabIndex = 0
        Me.tabProd.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.lueTabelaPreco)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage3.Controls.Add(Me.NanoCampo3)
        Me.XtraTabPage3.Controls.Add(Me.NanoCampo2)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage3.Controls.Add(Me.NanoCampo1)
        Me.XtraTabPage3.Controls.Add(Me.rdgTipoProd)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage3.Controls.Add(Me.cboCodFunc)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage3.Controls.Add(Me.lblCusto)
        Me.XtraTabPage3.Controls.Add(Me.txtCusto)
        Me.XtraTabPage3.Controls.Add(Me.chkCusto)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage3.Controls.Add(Me.txtSaldoQtd)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage3.Controls.Add(Me.txtEmPedido)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage3.Controls.Add(Me.txtEmEstoque)
        Me.XtraTabPage3.Controls.Add(Me.txtValDesconto)
        Me.XtraTabPage3.Controls.Add(Label28)
        Me.XtraTabPage3.Controls.Add(Me.lblStatus)
        Me.XtraTabPage3.Controls.Add(Me.txtValor)
        Me.XtraTabPage3.Controls.Add(Me.txtPerDesc)
        Me.XtraTabPage3.Controls.Add(Me.btnAdd)
        Me.XtraTabPage3.Controls.Add(Me.txtQtd)
        Me.XtraTabPage3.Controls.Add(Label7)
        Me.XtraTabPage3.Controls.Add(Label6)
        Me.XtraTabPage3.Controls.Add(Label3)
        Me.XtraTabPage3.Controls.Add(Me.txtNomePro)
        Me.XtraTabPage3.Controls.Add(Label4)
        Me.XtraTabPage3.Controls.Add(Label15)
        Me.XtraTabPage3.Controls.Add(Me.txtCodPro)
        Me.XtraTabPage3.Controls.Add(Me.chkAutoAdd)
        Me.XtraTabPage3.Controls.Add(Me.txtTamanho)
        Me.XtraTabPage3.Controls.Add(Me.lblTamanho)
        Me.XtraTabPage3.Controls.Add(Me.Label25)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(990, 131)
        Me.XtraTabPage3.Text = "Adicionar Produtos"
        '
        'lueTabelaPreco
        '
        Me.lueTabelaPreco.Location = New System.Drawing.Point(968, 67)
        Me.lueTabelaPreco.Name = "lueTabelaPreco"
        Me.lueTabelaPreco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.lueTabelaPreco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tabela", "Tabela", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Valor", "Valor R$", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)})
        Me.lueTabelaPreco.Properties.DataSource = Me.dsTabPreco
        Me.lueTabelaPreco.Properties.DisplayMember = "Tabela"
        Me.lueTabelaPreco.Properties.NullText = ""
        Me.lueTabelaPreco.Properties.PopupWidth = 400
        Me.lueTabelaPreco.Properties.ValueMember = "Tabela"
        Me.lueTabelaPreco.Size = New System.Drawing.Size(22, 20)
        Me.lueTabelaPreco.TabIndex = 187
        '
        'dsTabPreco
        '
        Me.dsTabPreco.DataSetName = "NewDataSet"
        Me.dsTabPreco.Tables.AddRange(New System.Data.DataTable() {Me.tbTabPreco})
        '
        'tbTabPreco
        '
        Me.tbTabPreco.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn104, Me.DataColumn105})
        Me.tbTabPreco.TableName = "tbTabPreco"
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "Tabela"
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "Valor"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl14.TabIndex = 186
        Me.LabelControl14.Text = "Qtd Por Emb."
        Me.LabelControl14.Visible = False
        '
        'NanoCampo3
        '
        Me.NanoCampo3.CasasDecimais = 2
        Me.NanoCampo3.Enabled = False
        Me.NanoCampo3.EnterMoveNextControl = True
        Me.NanoCampo3.Location = New System.Drawing.Point(78, 4)
        Me.NanoCampo3.Name = "NanoCampo3"
        Me.NanoCampo3.Numerico = True
        Me.NanoCampo3.Properties.Appearance.Options.UseTextOptions = True
        Me.NanoCampo3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NanoCampo3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo3.Properties.MaxLength = 18
        Me.NanoCampo3.Size = New System.Drawing.Size(131, 20)
        Me.NanoCampo3.TabIndex = 185
        Me.NanoCampo3.Tag = "Valor Custo R$"
        Me.NanoCampo3.Visible = False
        '
        'NanoCampo2
        '
        Me.NanoCampo2.CasasDecimais = 0
        Me.NanoCampo2.EnterMoveNextControl = True
        Me.NanoCampo2.Location = New System.Drawing.Point(289, 93)
        Me.NanoCampo2.Name = "NanoCampo2"
        Me.NanoCampo2.Numerico = False
        Me.NanoCampo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NanoCampo2.Properties.Appearance.Options.UseFont = True
        Me.NanoCampo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.NanoCampo2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NanoCampo2.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.NanoCampo2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.NanoCampo2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.NanoCampo2.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.NanoCampo2.Properties.MaxLength = 200
        Me.NanoCampo2.Size = New System.Drawing.Size(503, 20)
        Me.NanoCampo2.TabIndex = 182
        Me.NanoCampo2.Tag = "Tamanho"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(223, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl13.TabIndex = 181
        Me.LabelControl13.Text = "Qtd de Emb."
        Me.LabelControl13.Visible = False
        '
        'NanoCampo1
        '
        Me.NanoCampo1.CasasDecimais = 2
        Me.NanoCampo1.EnterMoveNextControl = True
        Me.NanoCampo1.Location = New System.Drawing.Point(289, 5)
        Me.NanoCampo1.Name = "NanoCampo1"
        Me.NanoCampo1.Numerico = True
        Me.NanoCampo1.Properties.Appearance.Options.UseTextOptions = True
        Me.NanoCampo1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NanoCampo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo1.Properties.MaxLength = 18
        Me.NanoCampo1.Size = New System.Drawing.Size(110, 20)
        Me.NanoCampo1.TabIndex = 180
        Me.NanoCampo1.Tag = "Valor Custo R$"
        Me.NanoCampo1.Visible = False
        '
        'rdgTipoProd
        '
        Me.rdgTipoProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdgTipoProd.EditValue = True
        Me.rdgTipoProd.Location = New System.Drawing.Point(78, 5)
        Me.rdgTipoProd.Name = "rdgTipoProd"
        Me.rdgTipoProd.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rdgTipoProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTipoProd.Properties.Appearance.Options.UseBackColor = True
        Me.rdgTipoProd.Properties.Appearance.Options.UseFont = True
        Me.rdgTipoProd.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "P"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "S")})
        Me.rdgTipoProd.Size = New System.Drawing.Size(131, 20)
        Me.rdgTipoProd.TabIndex = 171
        '
        'PanelControl4
        '
        Me.PanelControl4.Location = New System.Drawing.Point(1, 32)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(989, 2)
        Me.PanelControl4.TabIndex = 179
        '
        'cboCodFunc
        '
        Me.cboCodFunc.EnterMoveNextControl = True
        Me.cboCodFunc.Location = New System.Drawing.Point(289, 67)
        Me.cboCodFunc.Name = "cboCodFunc"
        Me.cboCodFunc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodFunc.Properties.Appearance.Options.UseFont = True
        Me.cboCodFunc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cboCodFunc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCodFunc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCodFunc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCodFunc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCodFunc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCodFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, CType(resources.GetObject("cboCodFunc.Properties.Buttons"), System.Drawing.Image), Nothing)})
        Me.cboCodFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod", "Código", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboCodFunc.Properties.DataSource = Me.FuncionarioBindingSource
        Me.cboCodFunc.Properties.DisplayMember = "Cod"
        Me.cboCodFunc.Properties.NullText = ""
        Me.cboCodFunc.Properties.ValueMember = "Cod"
        Me.cboCodFunc.Size = New System.Drawing.Size(106, 20)
        Me.cboCodFunc.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(239, 70)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 177
        Me.LabelControl6.Text = "Mecânico"
        '
        'lblCusto
        '
        Me.lblCusto.Location = New System.Drawing.Point(28, 70)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(44, 13)
        Me.lblCusto.TabIndex = 176
        Me.lblCusto.Text = "Custo R$"
        Me.lblCusto.Visible = False
        '
        'txtCusto
        '
        Me.txtCusto.CasasDecimais = 3
        Me.txtCusto.EnterMoveNextControl = True
        Me.txtCusto.Location = New System.Drawing.Point(78, 67)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Numerico = True
        Me.txtCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCusto.Properties.Appearance.Options.UseFont = True
        Me.txtCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCusto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCusto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCusto.Properties.MaxLength = 13
        Me.txtCusto.Size = New System.Drawing.Size(131, 20)
        Me.txtCusto.TabIndex = 175
        Me.txtCusto.Tag = "Qtd"
        Me.txtCusto.Visible = False
        '
        'chkCusto
        '
        Me.chkCusto.Location = New System.Drawing.Point(3, 68)
        Me.chkCusto.Name = "chkCusto"
        Me.chkCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCusto.Properties.Appearance.Options.UseFont = True
        Me.chkCusto.Properties.Caption = ""
        Me.chkCusto.Size = New System.Drawing.Size(19, 19)
        Me.chkCusto.TabIndex = 174
        Me.chkCusto.ToolTip = "Selecione para alterar o valor de custo do produto"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(848, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl7.TabIndex = 172
        Me.LabelControl7.Text = "Saldo"
        '
        'txtSaldoQtd
        '
        Me.txtSaldoQtd.CasasDecimais = 2
        Me.txtSaldoQtd.EnterMoveNextControl = True
        Me.txtSaldoQtd.Location = New System.Drawing.Point(880, 5)
        Me.txtSaldoQtd.Name = "txtSaldoQtd"
        Me.txtSaldoQtd.Numerico = True
        Me.txtSaldoQtd.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSaldoQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoQtd.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSaldoQtd.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoQtd.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoQtd.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoQtd.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSaldoQtd.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSaldoQtd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.MintCream
        Me.txtSaldoQtd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSaldoQtd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldoQtd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldoQtd.Properties.MaxLength = 15
        Me.txtSaldoQtd.Properties.ReadOnly = True
        Me.txtSaldoQtd.Size = New System.Drawing.Size(110, 20)
        Me.txtSaldoQtd.TabIndex = 169
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(627, 6)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl8.TabIndex = 171
        Me.LabelControl8.Text = "Em Pedido"
        '
        'txtEmPedido
        '
        Me.txtEmPedido.CasasDecimais = 2
        Me.txtEmPedido.EnterMoveNextControl = True
        Me.txtEmPedido.Location = New System.Drawing.Point(682, 5)
        Me.txtEmPedido.Name = "txtEmPedido"
        Me.txtEmPedido.Numerico = False
        Me.txtEmPedido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmPedido.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtEmPedido.Properties.Appearance.Options.UseFont = True
        Me.txtEmPedido.Properties.Appearance.Options.UseForeColor = True
        Me.txtEmPedido.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmPedido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEmPedido.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmPedido.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtEmPedido.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmPedido.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtEmPedido.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.MintCream
        Me.txtEmPedido.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEmPedido.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEmPedido.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEmPedido.Properties.MaxLength = 15
        Me.txtEmPedido.Properties.ReadOnly = True
        Me.txtEmPedido.Size = New System.Drawing.Size(110, 20)
        Me.txtEmPedido.TabIndex = 168
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(422, 6)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl9.TabIndex = 170
        Me.LabelControl9.Text = "Em Estoque"
        '
        'txtEmEstoque
        '
        Me.txtEmEstoque.CasasDecimais = 2
        Me.txtEmEstoque.EnterMoveNextControl = True
        Me.txtEmEstoque.Location = New System.Drawing.Point(484, 5)
        Me.txtEmEstoque.Name = "txtEmEstoque"
        Me.txtEmEstoque.Numerico = False
        Me.txtEmEstoque.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtEmEstoque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmEstoque.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtEmEstoque.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmEstoque.Properties.Appearance.Options.UseFont = True
        Me.txtEmEstoque.Properties.Appearance.Options.UseForeColor = True
        Me.txtEmEstoque.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmEstoque.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEmEstoque.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmEstoque.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtEmEstoque.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmEstoque.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtEmEstoque.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.MintCream
        Me.txtEmEstoque.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEmEstoque.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEmEstoque.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEmEstoque.Properties.MaxLength = 15
        Me.txtEmEstoque.Properties.ReadOnly = True
        Me.txtEmEstoque.Size = New System.Drawing.Size(110, 20)
        Me.txtEmEstoque.TabIndex = 167
        Me.txtEmEstoque.Tag = "Limite Atual"
        '
        'txtValDesconto
        '
        Me.txtValDesconto.CasasDecimais = 3
        Me.txtValDesconto.EnterMoveNextControl = True
        Me.txtValDesconto.Location = New System.Drawing.Point(484, 67)
        Me.txtValDesconto.Name = "txtValDesconto"
        Me.txtValDesconto.Numerico = True
        Me.txtValDesconto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtValDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValDesconto.Properties.MaxLength = 13
        Me.txtValDesconto.Size = New System.Drawing.Size(110, 20)
        Me.txtValDesconto.TabIndex = 75
        Me.txtValDesconto.Tag = "Qtd"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Location = New System.Drawing.Point(885, -6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 11)
        Me.lblStatus.TabIndex = 74
        '
        'txtValor
        '
        Me.txtValor.CasasDecimais = 3
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(880, 67)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico = True
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.MaxLength = 13
        Me.txtValor.Size = New System.Drawing.Size(89, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.Tag = "Qtd"
        '
        'txtPerDesc
        '
        Me.txtPerDesc.CasasDecimais = 3
        Me.txtPerDesc.EnterMoveNextControl = True
        Me.txtPerDesc.Location = New System.Drawing.Point(682, 67)
        Me.txtPerDesc.Name = "txtPerDesc"
        Me.txtPerDesc.Numerico = True
        Me.txtPerDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPerDesc.Properties.Appearance.Options.UseFont = True
        Me.txtPerDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPerDesc.Properties.MaxLength = 13
        Me.txtPerDesc.Size = New System.Drawing.Size(110, 20)
        Me.txtPerDesc.TabIndex = 5
        Me.txtPerDesc.Tag = "Qtd"
        '
        'chkAutoAdd
        '
        Me.chkAutoAdd.Location = New System.Drawing.Point(3, 42)
        Me.chkAutoAdd.Name = "chkAutoAdd"
        Me.chkAutoAdd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoAdd.Properties.Appearance.Options.UseFont = True
        Me.chkAutoAdd.Properties.Caption = ""
        Me.chkAutoAdd.Size = New System.Drawing.Size(19, 19)
        Me.chkAutoAdd.TabIndex = 73
        Me.chkAutoAdd.ToolTip = "Selecione para adicionar o produto automaticamente"
        '
        'lblTamanho
        '
        Me.lblTamanho.Location = New System.Drawing.Point(632, 45)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(44, 13)
        Me.lblTamanho.TabIndex = 178
        Me.lblTamanho.Text = "Tamanho"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(191, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(96, 17)
        Me.Label25.TabIndex = 184
        Me.Label25.Text = "Aplicação"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.lblTamanho2)
        Me.XtraTabPage4.Controls.Add(Me.chkAuto)
        Me.XtraTabPage4.Controls.Add(Me.btnRemover)
        Me.XtraTabPage4.Controls.Add(Me.txtQtd2)
        Me.XtraTabPage4.Controls.Add(Me.txtTamanho2)
        Me.XtraTabPage4.Controls.Add(Label20)
        Me.XtraTabPage4.Controls.Add(Label22)
        Me.XtraTabPage4.Controls.Add(Me.txtNomePro2)
        Me.XtraTabPage4.Controls.Add(Label23)
        Me.XtraTabPage4.Controls.Add(Me.txtCodPro2)
        Me.XtraTabPage4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(990, 131)
        Me.XtraTabPage4.Text = "Remover Produtos"
        '
        'lblTamanho2
        '
        Me.lblTamanho2.Location = New System.Drawing.Point(633, 76)
        Me.lblTamanho2.Name = "lblTamanho2"
        Me.lblTamanho2.Size = New System.Drawing.Size(44, 13)
        Me.lblTamanho2.TabIndex = 71
        Me.lblTamanho2.Text = "Tamanho"
        '
        'chkAuto
        '
        Me.chkAuto.Location = New System.Drawing.Point(5, 73)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuto.Properties.Appearance.Options.UseFont = True
        Me.chkAuto.Properties.Caption = ""
        Me.chkAuto.Size = New System.Drawing.Size(19, 19)
        Me.chkAuto.TabIndex = 70
        Me.chkAuto.ToolTip = "Selecione para remover o produto automaticamente"
        '
        'btnRemover
        '
        Me.btnRemover.Image = Global.Nano.My.Resources.Resources.Remove_Item
        Me.btnRemover.Location = New System.Drawing.Point(880, 99)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(110, 25)
        Me.btnRemover.TabIndex = 3
        Me.btnRemover.Text = "&Remover"
        '
        'txtQtd2
        '
        Me.txtQtd2.CasasDecimais = 3
        Me.txtQtd2.EnterMoveNextControl = True
        Me.txtQtd2.Location = New System.Drawing.Point(880, 73)
        Me.txtQtd2.Name = "txtQtd2"
        Me.txtQtd2.Numerico = True
        Me.txtQtd2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQtd2.Properties.Appearance.Options.UseFont = True
        Me.txtQtd2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd2.Properties.MaxLength = 13
        Me.txtQtd2.Size = New System.Drawing.Size(110, 20)
        Me.txtQtd2.TabIndex = 2
        Me.txtQtd2.Tag = "Qtd"
        '
        'txtTamanho2
        '
        Me.txtTamanho2.CasasDecimais = 0
        Me.txtTamanho2.EnterMoveNextControl = True
        Me.txtTamanho2.Location = New System.Drawing.Point(682, 73)
        Me.txtTamanho2.Name = "txtTamanho2"
        Me.txtTamanho2.Numerico = False
        Me.txtTamanho2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTamanho2.Properties.Appearance.Options.UseFont = True
        Me.txtTamanho2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTamanho2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTamanho2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTamanho2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTamanho2.Properties.MaxLength = 30
        Me.txtTamanho2.Size = New System.Drawing.Size(110, 20)
        Me.txtTamanho2.TabIndex = 1
        Me.txtTamanho2.Tag = "Tamanho"
        '
        'txtNomePro2
        '
        Me.txtNomePro2.CasasDecimais = 0
        Me.txtNomePro2.EnterMoveNextControl = True
        Me.txtNomePro2.Location = New System.Drawing.Point(289, 73)
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
        Me.txtNomePro2.Size = New System.Drawing.Size(305, 20)
        Me.txtNomePro2.TabIndex = 69
        Me.txtNomePro2.Tag = "Tamanho"
        '
        'txtCodPro2
        '
        Me.txtCodPro2.EnterMoveNextControl = True
        Me.txtCodPro2.Location = New System.Drawing.Point(84, 73)
        Me.txtCodPro2.Name = "txtCodPro2"
        Me.txtCodPro2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro2.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodPro2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodPro2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro2.Properties.MaxLength = 50
        Me.txtCodPro2.Size = New System.Drawing.Size(125, 20)
        Me.txtCodPro2.TabIndex = 0
        '
        'lblSin
        '
        Me.lblSin.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSin.Appearance.Options.UseFont = True
        Me.lblSin.Location = New System.Drawing.Point(248, 40)
        Me.lblSin.Name = "lblSin"
        Me.lblSin.Size = New System.Drawing.Size(35, 13)
        Me.lblSin.TabIndex = 182
        Me.lblSin.Text = "Sinistro"
        '
        'txtSinistro
        '
        Me.txtSinistro.EnterMoveNextControl = True
        Me.txtSinistro.Location = New System.Drawing.Point(289, 38)
        Me.txtSinistro.Name = "txtSinistro"
        Me.txtSinistro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinistro.Properties.Appearance.Options.UseFont = True
        Me.txtSinistro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSinistro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSinistro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtSinistro.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinistro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtSinistro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSinistro.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtSinistro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSinistro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSinistro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSinistro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSinistro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSinistro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSinistro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSinistro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSinistro.Properties.MaxLength = 25
        Me.txtSinistro.Size = New System.Drawing.Size(311, 20)
        Me.txtSinistro.TabIndex = 2
        '
        'lblSeg
        '
        Me.lblSeg.Location = New System.Drawing.Point(227, 15)
        Me.lblSeg.Name = "lblSeg"
        Me.lblSeg.Size = New System.Drawing.Size(56, 13)
        Me.lblSeg.TabIndex = 179
        Me.lblSeg.Text = "Seguradora"
        '
        'lblMedTot
        '
        Me.lblMedTot.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedTot.Appearance.Options.UseFont = True
        Me.lblMedTot.Location = New System.Drawing.Point(452, 84)
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
        Me.lblMedB.Location = New System.Drawing.Point(449, 84)
        Me.lblMedB.Name = "lblMedB"
        Me.lblMedB.Size = New System.Drawing.Size(43, 13)
        Me.lblMedB.TabIndex = 71
        Me.lblMedB.Text = "Medida B"
        Me.lblMedB.Visible = False
        '
        'txtQtdMedida
        '
        Me.txtQtdMedida.CasasDecimais = 3
        Me.txtQtdMedida.EnterMoveNextControl = True
        Me.txtQtdMedida.Location = New System.Drawing.Point(509, 81)
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
        Me.txtQtdMedida.Size = New System.Drawing.Size(98, 20)
        Me.txtQtdMedida.TabIndex = 6
        Me.txtQtdMedida.Tag = "Qtd"
        Me.txtQtdMedida.Visible = False
        '
        'txtMedidaB
        '
        Me.txtMedidaB.CasasDecimais = 3
        Me.txtMedidaB.EnterMoveNextControl = True
        Me.txtMedidaB.Location = New System.Drawing.Point(498, 81)
        Me.txtMedidaB.Name = "txtMedidaB"
        Me.txtMedidaB.Numerico = True
        Me.txtMedidaB.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMedidaB.Properties.Appearance.Options.UseFont = True
        Me.txtMedidaB.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMedidaB.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMedidaB.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMedidaB.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMedidaB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMedidaB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMedidaB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMedidaB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMedidaB.Properties.MaxLength = 13
        Me.txtMedidaB.Size = New System.Drawing.Size(90, 20)
        Me.txtMedidaB.TabIndex = 5
        Me.txtMedidaB.Tag = "Medida B"
        Me.txtMedidaB.Visible = False
        '
        'lblMedA
        '
        Me.lblMedA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedA.Appearance.Options.UseFont = True
        Me.lblMedA.Location = New System.Drawing.Point(448, 84)
        Me.lblMedA.Name = "lblMedA"
        Me.lblMedA.Size = New System.Drawing.Size(44, 13)
        Me.lblMedA.TabIndex = 70
        Me.lblMedA.Text = "Medida A"
        Me.lblMedA.Visible = False
        '
        'txtMedidaA
        '
        Me.txtMedidaA.CasasDecimais = 3
        Me.txtMedidaA.EnterMoveNextControl = True
        Me.txtMedidaA.Location = New System.Drawing.Point(498, 81)
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
        'txtComanda
        '
        Me.txtComanda.CasasDecimais = 3
        Me.txtComanda.EnterMoveNextControl = True
        Me.txtComanda.Location = New System.Drawing.Point(886, 38)
        Me.txtComanda.Name = "txtComanda"
        Me.txtComanda.Numerico = False
        Me.txtComanda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtComanda.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComanda.Properties.Appearance.Options.UseFont = True
        Me.txtComanda.Properties.Appearance.Options.UseForeColor = True
        Me.txtComanda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComanda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtComanda.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComanda.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComanda.Properties.MaxLength = 10
        Me.txtComanda.Size = New System.Drawing.Size(110, 20)
        Me.txtComanda.TabIndex = 6
        Me.txtComanda.Tag = "Comanda"
        Me.txtComanda.Visible = False
        '
        'lblComanda
        '
        Me.lblComanda.Location = New System.Drawing.Point(833, 41)
        Me.lblComanda.Name = "lblComanda"
        Me.lblComanda.Size = New System.Drawing.Size(45, 13)
        Me.lblComanda.TabIndex = 95
        Me.lblComanda.Text = "Comanda"
        Me.lblComanda.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'btnCadGrp
        '
        Me.btnCadGrp.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadGrp.Location = New System.Drawing.Point(779, 38)
        Me.btnCadGrp.Name = "btnCadGrp"
        Me.btnCadGrp.Size = New System.Drawing.Size(20, 20)
        Me.btnCadGrp.TabIndex = 96
        Me.btnCadGrp.Text = "SimpleButton1"
        '
        'cboGrp
        '
        Me.cboGrp.EnterMoveNextControl = True
        Me.cboGrp.Location = New System.Drawing.Point(688, 38)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGrp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrp.Properties.MaxLength = 55
        Me.cboGrp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGrp.Size = New System.Drawing.Size(91, 20)
        Me.cboGrp.TabIndex = 4
        Me.cboGrp.Tag = "Grupo"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(619, 42)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl20.TabIndex = 98
        Me.LabelControl20.Text = "Nosso Status"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 47)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl1.Size = New System.Drawing.Size(1008, 193)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage5.Appearance.HeaderActive.Options.UseForeColor = True
        Me.XtraTabPage5.Controls.Add(Me.XtraTabControl2)
        Me.XtraTabPage5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(999, 162)
        Me.XtraTabPage5.Text = "Clientes - F7"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage7
        Me.XtraTabControl2.Size = New System.Drawing.Size(999, 162)
        Me.XtraTabControl2.TabIndex = 162
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage7.Appearance.HeaderActive.Options.UseForeColor = True
        Me.XtraTabPage7.Controls.Add(Me.txtCPFCNPJ)
        Me.XtraTabPage7.Controls.Add(Label27)
        Me.XtraTabPage7.Controls.Add(Me.btnCadCar)
        Me.XtraTabPage7.Controls.Add(Me.luePlaca)
        Me.XtraTabPage7.Controls.Add(Me.txtNivCom)
        Me.XtraTabPage7.Controls.Add(Me.txtCor)
        Me.XtraTabPage7.Controls.Add(Me.txtAno)
        Me.XtraTabPage7.Controls.Add(Me.txtMotor)
        Me.XtraTabPage7.Controls.Add(Me.txtMod)
        Me.XtraTabPage7.Controls.Add(Me.lblEntrega)
        Me.XtraTabPage7.Controls.Add(Me.lblRetirada)
        Me.XtraTabPage7.Controls.Add(Me.lblKMEntrada)
        Me.XtraTabPage7.Controls.Add(Me.lblModelo)
        Me.XtraTabPage7.Controls.Add(Me.lblCor)
        Me.XtraTabPage7.Controls.Add(Me.lblMotor)
        Me.XtraTabPage7.Controls.Add(Me.lblAno)
        Me.XtraTabPage7.Controls.Add(Me.lblNivelComb)
        Me.XtraTabPage7.Controls.Add(Me.lblKMSaida)
        Me.XtraTabPage7.Controls.Add(Me.lblPlaca)
        Me.XtraTabPage7.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage7.Controls.Add(Me.txtCli)
        Me.XtraTabPage7.Controls.Add(LimiteLabel)
        Me.XtraTabPage7.Controls.Add(Me.txtLimite)
        Me.XtraTabPage7.Controls.Add(Me.txtEmail)
        Me.XtraTabPage7.Controls.Add(EmailLabel)
        Me.XtraTabPage7.Controls.Add(Label13)
        Me.XtraTabPage7.Controls.Add(Me.txtFax)
        Me.XtraTabPage7.Controls.Add(Label14)
        Me.XtraTabPage7.Controls.Add(Me.txtPlaca)
        Me.XtraTabPage7.Controls.Add(Me.txtTel)
        Me.XtraTabPage7.Controls.Add(Label2)
        Me.XtraTabPage7.Controls.Add(Me.dtRetirada)
        Me.XtraTabPage7.Controls.Add(Me.txtKMSaida)
        Me.XtraTabPage7.Controls.Add(Me.dtEntrega)
        Me.XtraTabPage7.Controls.Add(Me.txtKm)
        Me.XtraTabPage7.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage7.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(990, 131)
        Me.XtraTabPage7.Text = "Dados"
        '
        'txtCPFCNPJ
        '
        Me.txtCPFCNPJ.EnterMoveNextControl = True
        Me.txtCPFCNPJ.Location = New System.Drawing.Point(84, 33)
        Me.txtCPFCNPJ.Name = "txtCPFCNPJ"
        Me.txtCPFCNPJ.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPFCNPJ.Properties.Appearance.Options.UseFont = True
        Me.txtCPFCNPJ.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPFCNPJ.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPFCNPJ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCPFCNPJ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCPFCNPJ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCPFCNPJ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCPFCNPJ.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPFCNPJ.Properties.ReadOnly = True
        Me.txtCPFCNPJ.Size = New System.Drawing.Size(125, 20)
        Me.txtCPFCNPJ.TabIndex = 178
        '
        'btnCadCar
        '
        Me.btnCadCar.Image = CType(resources.GetObject("btnCadCar.Image"), System.Drawing.Image)
        Me.btnCadCar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadCar.Location = New System.Drawing.Point(188, 75)
        Me.btnCadCar.Name = "btnCadCar"
        Me.btnCadCar.Size = New System.Drawing.Size(21, 21)
        Me.btnCadCar.TabIndex = 175
        Me.btnCadCar.Text = "Veículo"
        Me.btnCadCar.ToolTipTitle = "Cadastrar"
        '
        'luePlaca
        '
        Me.luePlaca.EnterMoveNextControl = True
        Me.luePlaca.Location = New System.Drawing.Point(166, 76)
        Me.luePlaca.Name = "luePlaca"
        Me.luePlaca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, CType(resources.GetObject("luePlaca.Properties.Buttons"), System.Drawing.Image), Nothing)})
        Me.luePlaca.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Placa", "Placa", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modelo", "Modelo", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cor", "Cor", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ano", "Ano", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomeCliente", "Cliente", 150)})
        Me.luePlaca.Properties.DisplayMember = "Placa"
        Me.luePlaca.Properties.NullText = ""
        Me.luePlaca.Properties.PopupWidth = 700
        Me.luePlaca.Properties.ValueMember = "Placa"
        Me.luePlaca.Size = New System.Drawing.Size(22, 20)
        Me.luePlaca.TabIndex = 174
        '
        'txtNivCom
        '
        Me.txtNivCom.CasasDecimais = 0
        Me.txtNivCom.EnterMoveNextControl = True
        Me.txtNivCom.Location = New System.Drawing.Point(84, 102)
        Me.txtNivCom.Name = "txtNivCom"
        Me.txtNivCom.Numerico = False
        Me.txtNivCom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivCom.Properties.Appearance.Options.UseFont = True
        Me.txtNivCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNivCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNivCom.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNivCom.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNivCom.Properties.MaxLength = 20
        Me.txtNivCom.Size = New System.Drawing.Size(125, 20)
        Me.txtNivCom.TabIndex = 9
        Me.txtNivCom.Tag = "Tamanho"
        '
        'txtCor
        '
        Me.txtCor.CasasDecimais = 0
        Me.txtCor.EnterMoveNextControl = True
        Me.txtCor.Location = New System.Drawing.Point(283, 102)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Numerico = False
        Me.txtCor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCor.Properties.Appearance.Options.UseFont = True
        Me.txtCor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCor.Properties.MaxLength = 30
        Me.txtCor.Size = New System.Drawing.Size(311, 20)
        Me.txtCor.TabIndex = 10
        Me.txtCor.Tag = "Tamanho"
        '
        'txtAno
        '
        Me.txtAno.CasasDecimais = 0
        Me.txtAno.EnterMoveNextControl = True
        Me.txtAno.Location = New System.Drawing.Point(682, 102)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Numerico = False
        Me.txtAno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.Properties.Appearance.Options.UseFont = True
        Me.txtAno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAno.Properties.MaxLength = 10
        Me.txtAno.Size = New System.Drawing.Size(110, 20)
        Me.txtAno.TabIndex = 11
        Me.txtAno.Tag = "Tamanho"
        '
        'txtMotor
        '
        Me.txtMotor.CasasDecimais = 0
        Me.txtMotor.EnterMoveNextControl = True
        Me.txtMotor.Location = New System.Drawing.Point(682, 76)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Numerico = False
        Me.txtMotor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotor.Properties.Appearance.Options.UseFont = True
        Me.txtMotor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMotor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMotor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMotor.Properties.MaxLength = 30
        Me.txtMotor.Size = New System.Drawing.Size(110, 20)
        Me.txtMotor.TabIndex = 8
        Me.txtMotor.Tag = "Tamanho"
        '
        'txtMod
        '
        Me.txtMod.CasasDecimais = 0
        Me.txtMod.EnterMoveNextControl = True
        Me.txtMod.Location = New System.Drawing.Point(283, 76)
        Me.txtMod.Name = "txtMod"
        Me.txtMod.Numerico = False
        Me.txtMod.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMod.Properties.Appearance.Options.UseFont = True
        Me.txtMod.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMod.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMod.Properties.MaxLength = 50
        Me.txtMod.Size = New System.Drawing.Size(311, 20)
        Me.txtMod.TabIndex = 7
        Me.txtMod.Tag = "Tamanho"
        '
        'lblEntrega
        '
        Me.lblEntrega.Location = New System.Drawing.Point(810, 32)
        Me.lblEntrega.Name = "lblEntrega"
        Me.lblEntrega.Size = New System.Drawing.Size(64, 13)
        Me.lblEntrega.TabIndex = 173
        Me.lblEntrega.Text = "Data Entrega"
        '
        'lblRetirada
        '
        Me.lblRetirada.Location = New System.Drawing.Point(807, 8)
        Me.lblRetirada.Name = "lblRetirada"
        Me.lblRetirada.Size = New System.Drawing.Size(67, 13)
        Me.lblRetirada.TabIndex = 172
        Me.lblRetirada.Text = "Data Retirada"
        '
        'lblKMEntrada
        '
        Me.lblKMEntrada.Location = New System.Drawing.Point(818, 79)
        Me.lblKMEntrada.Name = "lblKMEntrada"
        Me.lblKMEntrada.Size = New System.Drawing.Size(55, 13)
        Me.lblKMEntrada.TabIndex = 171
        Me.lblKMEntrada.Text = "KM Entrada"
        '
        'lblModelo
        '
        Me.lblModelo.Location = New System.Drawing.Point(243, 79)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(34, 13)
        Me.lblModelo.TabIndex = 170
        Me.lblModelo.Text = "Modelo"
        '
        'lblCor
        '
        Me.lblCor.Location = New System.Drawing.Point(260, 105)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(17, 13)
        Me.lblCor.TabIndex = 169
        Me.lblCor.Text = "Cor"
        '
        'lblMotor
        '
        Me.lblMotor.Location = New System.Drawing.Point(648, 79)
        Me.lblMotor.Name = "lblMotor"
        Me.lblMotor.Size = New System.Drawing.Size(28, 13)
        Me.lblMotor.TabIndex = 168
        Me.lblMotor.Text = "Motor"
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(657, 105)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(19, 13)
        Me.lblAno.TabIndex = 167
        Me.lblAno.Text = "Ano"
        '
        'lblNivelComb
        '
        Me.lblNivelComb.Location = New System.Drawing.Point(21, 105)
        Me.lblNivelComb.Name = "lblNivelComb"
        Me.lblNivelComb.Size = New System.Drawing.Size(57, 13)
        Me.lblNivelComb.TabIndex = 166
        Me.lblNivelComb.Text = "Nivel Comb."
        '
        'lblKMSaida
        '
        Me.lblKMSaida.Location = New System.Drawing.Point(830, 105)
        Me.lblKMSaida.Name = "lblKMSaida"
        Me.lblKMSaida.Size = New System.Drawing.Size(43, 13)
        Me.lblKMSaida.TabIndex = 165
        Me.lblKMSaida.Text = "KM Saída"
        '
        'lblPlaca
        '
        Me.lblPlaca.Location = New System.Drawing.Point(53, 79)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(25, 13)
        Me.lblPlaca.TabIndex = 164
        Me.lblPlaca.Text = "Placa"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(11, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 14)
        Me.LabelControl5.TabIndex = 163
        Me.LabelControl5.Text = "Dados do Veículo"
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(3, 62)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(985, 5)
        Me.PanelControl3.TabIndex = 162
        '
        'txtCli
        '
        Me.txtCli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCli.EnterMoveNextControl = True
        Me.txtCli.Location = New System.Drawing.Point(84, 5)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.Appearance.Options.UseFont = True
        Me.txtCli.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCli.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCli.Properties.ReadOnly = True
        Me.txtCli.Size = New System.Drawing.Size(510, 22)
        Me.txtCli.TabIndex = 0
        Me.txtCli.Tag = "Nome Cliente"
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(298, 5)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Properties.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(158, 20)
        Me.txtLimite.TabIndex = 72
        '
        'txtEmail
        '
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(283, 33)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEmail.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Properties.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(311, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtFax
        '
        Me.txtFax.EnterMoveNextControl = True
        Me.txtFax.Location = New System.Drawing.Point(682, 33)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFax.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFax.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtFax.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtFax.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFax.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFax.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Properties.Mask.EditMask = "(99)0000-0000"
        Me.txtFax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtFax.Properties.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(110, 20)
        Me.txtFax.TabIndex = 4
        '
        'txtPlaca
        '
        Me.txtPlaca.EnterMoveNextControl = True
        Me.txtPlaca.Location = New System.Drawing.Point(84, 76)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Properties.Appearance.Options.UseFont = True
        Me.txtPlaca.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPlaca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPlaca.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPlaca.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPlaca.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtPlaca.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtPlaca.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPlaca.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPlaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Properties.MaxLength = 7
        Me.txtPlaca.Size = New System.Drawing.Size(82, 20)
        Me.txtPlaca.TabIndex = 1
        Me.txtPlaca.Tag = "Placa"
        '
        'txtTel
        '
        Me.txtTel.EnterMoveNextControl = True
        Me.txtTel.Location = New System.Drawing.Point(682, 7)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Properties.Appearance.Options.UseFont = True
        Me.txtTel.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtTel.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTel.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel.Properties.Mask.EditMask = "(99)0000-0000"
        Me.txtTel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTel.Properties.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(110, 20)
        Me.txtTel.TabIndex = 5
        '
        'dtRetirada
        '
        Me.dtRetirada.EditValue = ""
        Me.dtRetirada.EnterMoveNextControl = True
        Me.dtRetirada.Location = New System.Drawing.Point(880, 3)
        Me.dtRetirada.Name = "dtRetirada"
        Me.dtRetirada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRetirada.Properties.Appearance.Options.UseFont = True
        Me.dtRetirada.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtRetirada.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtRetirada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRetirada.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtRetirada.Size = New System.Drawing.Size(110, 20)
        Me.dtRetirada.TabIndex = 12
        Me.dtRetirada.Tag = "Data"
        '
        'txtKMSaida
        '
        Me.txtKMSaida.EditValue = "0"
        Me.txtKMSaida.EnterMoveNextControl = True
        Me.txtKMSaida.Location = New System.Drawing.Point(880, 102)
        Me.txtKMSaida.Name = "txtKMSaida"
        Me.txtKMSaida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKMSaida.Properties.Appearance.Options.UseFont = True
        Me.txtKMSaida.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKMSaida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKMSaida.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKMSaida.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKMSaida.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtKMSaida.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtKMSaida.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtKMSaida.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtKMSaida.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKMSaida.Properties.MaxLength = 8
        Me.txtKMSaida.Size = New System.Drawing.Size(108, 20)
        Me.txtKMSaida.TabIndex = 13
        Me.txtKMSaida.Tag = "Km"
        '
        'dtEntrega
        '
        Me.dtEntrega.EditValue = ""
        Me.dtEntrega.EnterMoveNextControl = True
        Me.dtEntrega.Location = New System.Drawing.Point(880, 29)
        Me.dtEntrega.Name = "dtEntrega"
        Me.dtEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEntrega.Properties.Appearance.Options.UseFont = True
        Me.dtEntrega.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtEntrega.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEntrega.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtEntrega.Size = New System.Drawing.Size(110, 20)
        Me.dtEntrega.TabIndex = 5
        Me.dtEntrega.Tag = "Data"
        '
        'txtKm
        '
        Me.txtKm.EditValue = "0"
        Me.txtKm.EnterMoveNextControl = True
        Me.txtKm.Location = New System.Drawing.Point(880, 76)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKm.Properties.Appearance.Options.UseFont = True
        Me.txtKm.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKm.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKm.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKm.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKm.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtKm.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtKm.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtKm.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtKm.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKm.Properties.MaxLength = 8
        Me.txtKm.Size = New System.Drawing.Size(108, 20)
        Me.txtKm.TabIndex = 2
        Me.txtKm.Tag = "Km Entrada"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(810, 8)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl11.TabIndex = 176
        Me.LabelControl11.Text = "Data Entrada"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(822, 32)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl12.TabIndex = 177
        Me.LabelControl12.Text = "Data Saída"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Appearance.HeaderActive.ForeColor = System.Drawing.Color.Blue
        Me.XtraTabPage8.Appearance.HeaderActive.Options.UseForeColor = True
        Me.XtraTabPage8.Controls.Add(Me.Label11)
        Me.XtraTabPage8.Controls.Add(Me.txtDiasEmAtraso)
        Me.XtraTabPage8.Controls.Add(Me.btnConsumo)
        Me.XtraTabPage8.Controls.Add(Me.btnRelVendas)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl38)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl37)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl36)
        Me.XtraTabPage8.Controls.Add(Me.txtLimCli)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl35)
        Me.XtraTabPage8.Controls.Add(Me.txtSalDev)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage8.Controls.Add(Me.lblCred)
        Me.XtraTabPage8.Controls.Add(Me.txtCredito)
        Me.XtraTabPage8.Controls.Add(Me.txtLimiteCliente)
        Me.XtraTabPage8.Controls.Add(Me.Label26)
        Me.XtraTabPage8.Controls.Add(Me.txtNumCom)
        Me.XtraTabPage8.Controls.Add(Me.txtdtCad)
        Me.XtraTabPage8.Controls.Add(Me.lblTotalGasto)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage8.Controls.Add(Me.txtTotalGasto)
        Me.XtraTabPage8.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage8.Controls.Add(Me.txtUltVis)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(990, 131)
        Me.XtraTabPage8.Text = "Histórico"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(416, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Dias Atraso"
        '
        'txtDiasEmAtraso
        '
        Me.txtDiasEmAtraso.CasasDecimais = 0
        Me.txtDiasEmAtraso.Location = New System.Drawing.Point(484, 58)
        Me.txtDiasEmAtraso.Name = "txtDiasEmAtraso"
        Me.txtDiasEmAtraso.Numerico = True
        Me.txtDiasEmAtraso.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasEmAtraso.Properties.Appearance.Options.UseFont = True
        Me.txtDiasEmAtraso.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasEmAtraso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDiasEmAtraso.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiasEmAtraso.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightCoral
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtDiasEmAtraso.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasEmAtraso.Properties.ReadOnly = True
        Me.txtDiasEmAtraso.Size = New System.Drawing.Size(110, 20)
        Me.txtDiasEmAtraso.TabIndex = 126
        '
        'btnConsumo
        '
        Me.btnConsumo.Image = Global.Nano.My.Resources.Resources.Itens_24x24
        Me.btnConsumo.Location = New System.Drawing.Point(283, 32)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(110, 23)
        Me.btnConsumo.TabIndex = 125
        Me.btnConsumo.Text = "Consumo"
        '
        'btnRelVendas
        '
        Me.btnRelVendas.Image = Global.Nano.My.Resources.Resources.Itens_24x24
        Me.btnRelVendas.Location = New System.Drawing.Point(283, 5)
        Me.btnRelVendas.Name = "btnRelVendas"
        Me.btnRelVendas.Size = New System.Drawing.Size(110, 23)
        Me.btnRelVendas.TabIndex = 124
        Me.btnRelVendas.Text = "Vendas"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl38.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl38.Appearance.Options.UseFont = True
        Me.LabelControl38.Appearance.Options.UseForeColor = True
        Me.LabelControl38.Location = New System.Drawing.Point(798, 47)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl38.TabIndex = 123
        Me.LabelControl38.Text = "="
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl37.Appearance.Options.UseFont = True
        Me.LabelControl37.Appearance.Options.UseForeColor = True
        Me.LabelControl37.Location = New System.Drawing.Point(798, 22)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(10, 14)
        Me.LabelControl37.TabIndex = 122
        Me.LabelControl37.Text = "+"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Appearance.Options.UseFont = True
        Me.LabelControl36.Location = New System.Drawing.Point(811, 61)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl36.TabIndex = 121
        Me.LabelControl36.Text = "Limite Cliente"
        '
        'txtLimCli
        '
        Me.txtLimCli.CasasDecimais = 2
        Me.txtLimCli.EnterMoveNextControl = True
        Me.txtLimCli.Location = New System.Drawing.Point(880, 57)
        Me.txtLimCli.Name = "txtLimCli"
        Me.txtLimCli.Numerico = True
        Me.txtLimCli.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.txtLimCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimCli.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtLimCli.Properties.Appearance.Options.UseBackColor = True
        Me.txtLimCli.Properties.Appearance.Options.UseFont = True
        Me.txtLimCli.Properties.Appearance.Options.UseForeColor = True
        Me.txtLimCli.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLimCli.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLimCli.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimCli.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtLimCli.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLimCli.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtLimCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightBlue
        Me.txtLimCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLimCli.Properties.MaxLength = 15
        Me.txtLimCli.Properties.ReadOnly = True
        Me.txtLimCli.Size = New System.Drawing.Size(110, 21)
        Me.txtLimCli.TabIndex = 116
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Appearance.Options.UseFont = True
        Me.LabelControl35.Location = New System.Drawing.Point(814, 35)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl35.TabIndex = 120
        Me.LabelControl35.Text = "Limite Usado"
        '
        'txtSalDev
        '
        Me.txtSalDev.CasasDecimais = 2
        Me.txtSalDev.EnterMoveNextControl = True
        Me.txtSalDev.Location = New System.Drawing.Point(880, 31)
        Me.txtSalDev.Name = "txtSalDev"
        Me.txtSalDev.Numerico = False
        Me.txtSalDev.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalDev.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSalDev.Properties.Appearance.Options.UseFont = True
        Me.txtSalDev.Properties.Appearance.Options.UseForeColor = True
        Me.txtSalDev.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSalDev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSalDev.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalDev.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtSalDev.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSalDev.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSalDev.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightBlue
        Me.txtSalDev.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSalDev.Properties.MaxLength = 15
        Me.txtSalDev.Properties.ReadOnly = True
        Me.txtSalDev.Size = New System.Drawing.Size(110, 21)
        Me.txtSalDev.TabIndex = 115
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(819, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl10.TabIndex = 118
        Me.LabelControl10.Text = "Limite Atual"
        '
        'lblCred
        '
        Me.lblCred.AutoSize = True
        Me.lblCred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCred.Location = New System.Drawing.Point(620, 61)
        Me.lblCred.Name = "lblCred"
        Me.lblCred.Size = New System.Drawing.Size(60, 13)
        Me.lblCred.TabIndex = 119
        Me.lblCred.Text = "Créd. Dev."
        '
        'txtCredito
        '
        Me.txtCredito.CasasDecimais = 2
        Me.txtCredito.Location = New System.Drawing.Point(683, 58)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Numerico = True
        Me.txtCredito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredito.Properties.Appearance.Options.UseFont = True
        Me.txtCredito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredito.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCredito.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCredito.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCredito.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCredito.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCredito.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCredito.Properties.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(110, 20)
        Me.txtCredito.TabIndex = 117
        '
        'txtLimiteCliente
        '
        Me.txtLimiteCliente.CasasDecimais = 2
        Me.txtLimiteCliente.EnterMoveNextControl = True
        Me.txtLimiteCliente.Location = New System.Drawing.Point(880, 5)
        Me.txtLimiteCliente.Name = "txtLimiteCliente"
        Me.txtLimiteCliente.Numerico = False
        Me.txtLimiteCliente.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtLimiteCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteCliente.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtLimiteCliente.Properties.Appearance.Options.UseBackColor = True
        Me.txtLimiteCliente.Properties.Appearance.Options.UseFont = True
        Me.txtLimiteCliente.Properties.Appearance.Options.UseForeColor = True
        Me.txtLimiteCliente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLimiteCliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLimiteCliente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimiteCliente.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtLimiteCliente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLimiteCliente.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtLimiteCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightBlue
        Me.txtLimiteCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLimiteCliente.Properties.MaxLength = 15
        Me.txtLimiteCliente.Properties.ReadOnly = True
        Me.txtLimiteCliente.Size = New System.Drawing.Size(110, 21)
        Me.txtLimiteCliente.TabIndex = 114
        Me.txtLimiteCliente.Tag = "Limite Atual"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(612, 9)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(64, 13)
        Me.Label26.TabIndex = 113
        Me.Label26.Text = "Nº Compras"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtNumCom
        '
        Me.txtNumCom.CasasDecimais = 2
        Me.txtNumCom.EnterMoveNextControl = True
        Me.txtNumCom.Location = New System.Drawing.Point(682, 5)
        Me.txtNumCom.Name = "txtNumCom"
        Me.txtNumCom.Numerico = True
        Me.txtNumCom.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumCom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCom.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumCom.Properties.Appearance.Options.UseFont = True
        Me.txtNumCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNumCom.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumCom.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumCom.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtNumCom.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNumCom.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumCom.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumCom.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumCom.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumCom.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtNumCom.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNumCom.Properties.ReadOnly = True
        Me.txtNumCom.Size = New System.Drawing.Size(110, 20)
        Me.txtNumCom.TabIndex = 108
        '
        'txtdtCad
        '
        Me.txtdtCad.CasasDecimais = 0
        Me.txtdtCad.EnterMoveNextControl = True
        Me.txtdtCad.Location = New System.Drawing.Point(484, 5)
        Me.txtdtCad.Name = "txtdtCad"
        Me.txtdtCad.Numerico = False
        Me.txtdtCad.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtdtCad.Properties.Appearance.Options.UseBackColor = True
        Me.txtdtCad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtdtCad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtdtCad.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtdtCad.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtdtCad.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdtCad.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtdtCad.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtdtCad.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtdtCad.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtdtCad.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtdtCad.Properties.ReadOnly = True
        Me.txtdtCad.Size = New System.Drawing.Size(110, 20)
        Me.txtdtCad.TabIndex = 106
        '
        'lblTotalGasto
        '
        Me.lblTotalGasto.AutoSize = True
        Me.lblTotalGasto.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblTotalGasto.Location = New System.Drawing.Point(605, 35)
        Me.lblTotalGasto.Name = "lblTotalGasto"
        Me.lblTotalGasto.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalGasto.TabIndex = 112
        Me.lblTotalGasto.Text = "Comprado R$"
        Me.lblTotalGasto.Visible = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(421, 34)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl18.TabIndex = 110
        Me.LabelControl18.Text = "Última Visita"
        '
        'txtTotalGasto
        '
        Me.txtTotalGasto.CasasDecimais = 2
        Me.txtTotalGasto.EnterMoveNextControl = True
        Me.txtTotalGasto.Location = New System.Drawing.Point(682, 32)
        Me.txtTotalGasto.Name = "txtTotalGasto"
        Me.txtTotalGasto.Numerico = True
        Me.txtTotalGasto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalGasto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGasto.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalGasto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalGasto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalGasto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalGasto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalGasto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTotalGasto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalGasto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalGasto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalGasto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalGasto.Properties.ReadOnly = True
        Me.txtTotalGasto.Size = New System.Drawing.Size(110, 20)
        Me.txtTotalGasto.TabIndex = 109
        Me.txtTotalGasto.Visible = False
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseTextOptions = True
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Location = New System.Drawing.Point(408, 9)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl19.TabIndex = 111
        Me.LabelControl19.Text = "Data Cadastro "
        '
        'txtUltVis
        '
        Me.txtUltVis.CasasDecimais = 0
        Me.txtUltVis.EnterMoveNextControl = True
        Me.txtUltVis.Location = New System.Drawing.Point(484, 32)
        Me.txtUltVis.Name = "txtUltVis"
        Me.txtUltVis.Numerico = False
        Me.txtUltVis.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.txtUltVis.Properties.Appearance.Options.UseBackColor = True
        Me.txtUltVis.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUltVis.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUltVis.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtUltVis.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUltVis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUltVis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtUltVis.Properties.AppearanceFocused.Options.UseTextOptions = True
        Me.txtUltVis.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUltVis.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtUltVis.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUltVis.Properties.ReadOnly = True
        Me.txtUltVis.Size = New System.Drawing.Size(110, 20)
        Me.txtUltVis.TabIndex = 107
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.tabProd)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(999, 162)
        Me.XtraTabPage6.Text = "Produtos - F2"
        '
        'txtSeguradora
        '
        Me.txtSeguradora.EnterMoveNextControl = True
        Me.txtSeguradora.Location = New System.Drawing.Point(289, 12)
        Me.txtSeguradora.Name = "txtSeguradora"
        Me.txtSeguradora.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSeguradora.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSeguradora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSeguradora.Properties.MaxLength = 55
        Me.txtSeguradora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtSeguradora.Size = New System.Drawing.Size(291, 20)
        Me.txtSeguradora.TabIndex = 1
        Me.txtSeguradora.Tag = "Grupo"
        '
        'btnCadSeg
        '
        Me.btnCadSeg.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadSeg.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadSeg.Location = New System.Drawing.Point(580, 12)
        Me.btnCadSeg.Name = "btnCadSeg"
        Me.btnCadSeg.Size = New System.Drawing.Size(20, 20)
        Me.btnCadSeg.TabIndex = 184
        Me.btnCadSeg.Text = "SimpleButton1"
        '
        'frmPedido
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 696)
        Me.Controls.Add(Me.lblSin)
        Me.Controls.Add(Me.txtSinistro)
        Me.Controls.Add(Me.btnCadGrp)
        Me.Controls.Add(Me.cboGrp)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.txtComanda)
        Me.Controls.Add(Me.lblComanda)
        Me.Controls.Add(Me.btnCadSeg)
        Me.Controls.Add(Me.lblSeg)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblVenc)
        Me.Controls.Add(Me.lblMedTot)
        Me.Controls.Add(Me.lblMedB)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.txtQtdMedida)
        Me.Controls.Add(Me.txtMedidaB)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.lblCodPed)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.chkAlterado)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.txtMedidaA)
        Me.Controls.Add(Me.lblMedA)
        Me.Controls.Add(Me.txtSeguradora)
        Me.Controls.Add(Me.lueFunc)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Cadastro de Pedido"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAmbos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memAlt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage10.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage11.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalServ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalprod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTabela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdDesc.ResumeLayout(False)
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmComandos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVal.ResumeLayout(False)
        Me.grpVal.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFrete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPedidos.ResumeLayout(False)
        Me.pnlPedidos.PerformLayout()
        CType(Me.txtKMPedidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaiPedidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntPedidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLinha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlTipoprod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProduto.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVeiculo.ResumeLayout(False)
        CType(Me.txtProbVeiculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lueTabelaPreco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsTabPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTabPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmEstoque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutoAdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.chkAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamanho2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSinistro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedidaB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMedidaA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        Me.XtraTabPage7.PerformLayout()
        CType(Me.txtCPFCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRetirada.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRetirada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKMSaida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraTabPage8.PerformLayout()
        CType(Me.txtDiasEmAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimiteCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtCad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalGasto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUltVis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.txtSeguradora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCodPed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpItens As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents lblValDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnConsulta As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalServ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalprod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalprod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTipoprod As System.Windows.Forms.Label
    Friend WithEvents pnlTipoprod As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTabela As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtComanda As Campos.NanoCampo
    Friend WithEvents lblComanda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents colValorAnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAntPorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtValor As Campos.NanoCampo
    Friend WithEvents txtPerDesc As Campos.NanoCampo
    Friend WithEvents chkAuto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAutoAdd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents colDataAdd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCadGrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboGrp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dtEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCli As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dtRetirada As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLimite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKMSaida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtValDesconto As Campos.NanoCampo
    Friend WithEvents grpVeiculo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtProbVeiculo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage10 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage11 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tbItens2 As System.Data.DataTable
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents tbItens3 As System.Data.DataTable
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents colCodigoProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabelaPreco1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedAut1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUniSemDesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromocao1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLucro1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidaA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidaB1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdMedida1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAnt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAntPorc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProduto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTabelaPreco2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoInterno1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPedAut2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeso1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUniSemDesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExcluir3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromocao2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesconto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLucro2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidaA2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMedidaB2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdMedida2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAnt2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorAntPorc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTotalServ As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotPeso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pnlPedidos As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtKMPedidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaiPedidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEntPedidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTermo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProcesso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnChekList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblKMEntrada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblModelo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMotor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNivelComb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblKMSaida As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPlaca As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtNumCom As Campos.NanoCampo
    Friend WithEvents txtdtCad As Campos.NanoCampo
    Friend WithEvents lblTotalGasto As System.Windows.Forms.Label
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalGasto As Campos.NanoCampo
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUltVis As Campos.NanoCampo
    Friend WithEvents btnConsumo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRelVendas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLimCli As Campos.NanoCampo
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSalDev As Campos.NanoCampo
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCred As System.Windows.Forms.Label
    Friend WithEvents txtCredito As Campos.NanoCampo
    Friend WithEvents txtLimiteCliente As Campos.NanoCampo
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldoQtd As Campos.NanoCampo
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmPedido As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmEstoque As Campos.NanoCampo
    Friend WithEvents chkCusto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCusto As Campos.NanoCampo
    Friend WithEvents lblCusto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSeg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSinistro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodigoFuncionario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents colCodigoFuncionario1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoFuncionario2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblEntrega As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRetirada As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents colAutorizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAut As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colAutorizado1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colAutorizado2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents lblTamanho2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSeguradora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCadSeg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTamanho As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNivCom As Campos.NanoCampo
    Friend WithEvents txtCor As Campos.NanoCampo
    Friend WithEvents txtAno As Campos.NanoCampo
    Friend WithEvents txtMotor As Campos.NanoCampo
    Friend WithEvents txtMod As Campos.NanoCampo
    Friend WithEvents btnCadCar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents luePlaca As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCodFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rdgTipoProd As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents colLocacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDiasEmAtraso As Campos.NanoCampo
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NanoCampo1 As Campos.NanoCampo
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents NanoCampo2 As Campos.NanoCampo
    Friend WithEvents colCampoPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NanoCampo3 As Campos.NanoCampo
    Friend WithEvents txtCPFCNPJ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorFrete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorFrete As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnVisuaPaisagem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lueTabelaPreco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dsTabPreco As System.Data.DataSet
    Friend WithEvents tbTabPreco As System.Data.DataTable
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
End Class
