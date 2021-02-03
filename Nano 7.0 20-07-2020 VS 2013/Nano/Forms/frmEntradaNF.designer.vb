<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaNF
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim FormaPagamentoLabel1 As System.Windows.Forms.Label
        Dim TipoContaLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradaNF))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colValProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtNF = New DevExpress.XtraEditors.TextEdit
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsNano = New Nano.dsNano
        Me.txtCPF = New DevExpress.XtraEditors.TextEdit
        Me.FornecedorTableAdapter = New Nano.dsNanoTableAdapters.FornecedorTableAdapter
        Me.grpProd = New DevExpress.XtraEditors.GroupControl
        Me.lblQtdProd = New DevExpress.XtraEditors.LabelControl
        Me.lblConv = New DevExpress.XtraEditors.LabelControl
        Me.txtQtdProd = New Campos.NanoCampo
        Me.cboUniMed = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtValorCusto = New DevExpress.XtraEditors.TextEdit
        Me.txtCodProdFor = New Campos.NanoCampo
        Me.lblCodProdFor = New DevExpress.XtraEditors.LabelControl
        Me.txtCodBarra = New Campos.NanoCampo
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoProduto = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.lblICMS = New DevExpress.XtraEditors.LabelControl
        Me.lblIPI = New DevExpress.XtraEditors.LabelControl
        Me.txtICMSItem = New DevExpress.XtraEditors.TextEdit
        Me.txtIPIItem = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.btnCadSet = New DevExpress.XtraEditors.SimpleButton
        Me.cboSet = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnCadGrp = New DevExpress.XtraEditors.SimpleButton
        Me.cboGrp = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtPor1 = New Campos.NanoCampo
        Me.txtVal = New Campos.NanoCampo
        Me.lblPor = New DevExpress.XtraEditors.LabelControl
        Me.lblVenda = New DevExpress.XtraEditors.LabelControl
        Me.chkTamanho = New DevExpress.XtraEditors.CheckEdit
        Me.txtTam = New Campos.NanoCampo
        Me.txtQtd = New Campos.NanoCampo
        Me.txtPerDesc = New DevExpress.XtraEditors.TextEdit
        Me.lueHis = New DevExpress.XtraEditors.LookUpEdit
        Me.EntradaNFBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNomePro = New DevExpress.XtraEditors.TextEdit
        Me.txtCodPro = New DevExpress.XtraEditors.ButtonEdit
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.lblMVaST = New DevExpress.XtraEditors.LabelControl
        Me.txtMVaST = New DevExpress.XtraEditors.TextEdit
        Me.lblLoja = New DevExpress.XtraEditors.LabelControl
        Me.lueLoja = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.EntradaNFGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsEntrada = New System.Data.DataSet
        Me.tbEntrada = New System.Data.DataTable
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
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
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
        Me.DataColumn99 = New System.Data.DataColumn
        Me.tbFor = New System.Data.DataTable
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.tbContaPagar = New System.Data.DataTable
        Me.DataColumn93 = New System.Data.DataColumn
        Me.DataColumn94 = New System.Data.DataColumn
        Me.DataColumn95 = New System.Data.DataColumn
        Me.DataColumn96 = New System.Data.DataColumn
        Me.DataColumn97 = New System.Data.DataColumn
        Me.DataColumn98 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescontoNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitarioImposto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodTotNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCFOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEXTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidTrib = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValTrib = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdTrib = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrigem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCalculoCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIcmsNfe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVaST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIcmsST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEnq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPerIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPerPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPerCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoANP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUFComb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRegime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCFOPEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNCMEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRegimeEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrigemEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCalculoCredEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCredEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaICMSEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMSEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModBCSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRedBCSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMVaSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaICMSSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMSSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTIPIEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEnqEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaIPIEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValIPIEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTPISEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaPISEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValPISEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTCOFINSEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquotaCOFINSEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValCOFINSEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoANPEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUFCombEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUMProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCest = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVFCPSTEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkDescontoItens = New DevExpress.XtraEditors.CheckEdit
        Me.chkEstoqueOK = New DevExpress.XtraEditors.CheckEdit
        Me.TotalEntradaNFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalEntradaNFGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroNF1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstoqueOK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorFrete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorSeguro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOutrasDespesas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMS1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPI1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfigTot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtValTotProd = New DevExpress.XtraEditors.TextEdit
        Me.btnVincularProduto = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditarNfe = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.btnEditarNFeEntrada = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDesc = New DevExpress.XtraEditors.LabelControl
        Me.txtValNota = New DevExpress.XtraEditors.TextEdit
        Me.txtValDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtDesconto = New DevExpress.XtraEditors.TextEdit
        Me.chkImpostoItens = New DevExpress.XtraEditors.CheckEdit
        Me.EntradaNFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnEtiq = New DevExpress.XtraBars.BarButtonItem
        Me.btnConPagar = New DevExpress.XtraBars.BarButtonItem
        Me.btnNfe = New DevExpress.XtraBars.BarButtonItem
        Me.btnXML = New DevExpress.XtraBars.BarButtonItem
        Me.txtValVendaPorc = New DevExpress.XtraBars.BarEditItem
        Me.txtValVendaPor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.btnAddValor = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCanNota = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txtObs = New DevExpress.XtraEditors.MemoEdit
        Me.TotalEntradaNFTableAdapter = New Nano.dsNanoTableAdapters.TotalEntradaNFTableAdapter
        Me.EntradaNFTableAdapter = New Nano.dsNanoTableAdapters.EntradaNFTableAdapter
        Me.txtSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txFrete = New DevExpress.XtraEditors.TextEdit
        Me.txtSeguro = New DevExpress.XtraEditors.TextEdit
        Me.txtDespesas = New DevExpress.XtraEditors.TextEdit
        Me.txtIPI = New DevExpress.XtraEditors.TextEdit
        Me.txtICMS = New DevExpress.XtraEditors.TextEdit
        Me.txtFor = New DevExpress.XtraEditors.ButtonEdit
        Me.ofdArquivo = New System.Windows.Forms.OpenFileDialog
        Me.lblValIPI = New DevExpress.XtraEditors.LabelControl
        Me.lblValICMS = New DevExpress.XtraEditors.LabelControl
        Me.lblPorICMS = New DevExpress.XtraEditors.LabelControl
        Me.txtPorICMS = New DevExpress.XtraEditors.TextEdit
        Me.btnConsultar = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodPed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.btnConPed = New DevExpress.XtraEditors.ButtonEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.grpConta = New DevExpress.XtraEditors.GroupControl
        Me.btnCenCus = New DevExpress.XtraEditors.SimpleButton
        Me.cboCenCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboTipCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboTipConta = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblDias = New System.Windows.Forms.Label
        Me.txtDias = New DevExpress.XtraEditors.SpinEdit
        Me.lblVenc = New System.Windows.Forms.Label
        Me.dtVenc = New DevExpress.XtraEditors.DateEdit
        Me.lblNumPar = New System.Windows.Forms.Label
        Me.seParcela = New DevExpress.XtraEditors.SpinEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValorParcela = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colValorConta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.luePag = New DevExpress.XtraEditors.LookUpEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtChave = New DevExpress.XtraEditors.TextEdit
        Me.colFreteEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDespesasEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSeguroEnt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataColumn100 = New System.Data.DataColumn
        Me.DataColumn101 = New System.Data.DataColumn
        Me.DataColumn102 = New System.Data.DataColumn
        NomeLabel = New System.Windows.Forms.Label
        CPFLabel = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        FormaPagamentoLabel1 = New System.Windows.Forms.Label
        TipoContaLabel = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        CType(Me.txtNF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProd.SuspendLayout()
        CType(Me.txtQtdProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProdFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodBarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtICMSItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIPIItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueHis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaNFBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMVaST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.EntradaNFGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbContaPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDescontoItens.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstoqueOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalEntradaNFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalEntradaNFGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtValTotProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpostoItens.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradaNFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValVendaPor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txFrete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDespesas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtICMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorICMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConsultar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpConta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConta.SuspendLayout()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(25, 90)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(56, 13)
        NomeLabel.TabIndex = 15
        NomeLabel.Text = "Raz.Social"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(620, 90)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(55, 13)
        CPFLabel.TabIndex = 17
        CPFLabel.Text = "CPF/CNPJ"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(219, 58)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(25, 13)
        Label7.TabIndex = 58
        Label7.Text = "Qtd"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 84)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(67, 13)
        Label6.TabIndex = 53
        Label6.Text = "Val. Unit. R$"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(199, 32)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 45
        Label4.Text = "Produto"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(41, 32)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 43
        Label3.Text = "Código"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 136)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 13)
        Label1.TabIndex = 100
        Label1.Text = "Frete R$"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(199, 136)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(45, 13)
        Label2.TabIndex = 102
        Label2.Text = "Seg. R$"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(421, 136)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(69, 13)
        Label5.TabIndex = 104
        Label5.Text = "Despesas R$"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(819, 59)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(48, 13)
        Label8.TabIndex = 17
        Label8.Text = "Desc. %"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(336, 58)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(31, 13)
        Label11.TabIndex = 66
        Label11.Text = "Tam."
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(439, 59)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 145
        Label9.Text = "Custo R$"
        '
        'FormaPagamentoLabel1
        '
        FormaPagamentoLabel1.AutoSize = True
        FormaPagamentoLabel1.Location = New System.Drawing.Point(236, 52)
        FormaPagamentoLabel1.Name = "FormaPagamentoLabel1"
        FormaPagamentoLabel1.Size = New System.Drawing.Size(94, 13)
        FormaPagamentoLabel1.TabIndex = 141
        FormaPagamentoLabel1.Text = "Forma Pagamento"
        '
        'TipoContaLabel
        '
        TipoContaLabel.AutoSize = True
        TipoContaLabel.Location = New System.Drawing.Point(29, 26)
        TipoContaLabel.Name = "TipoContaLabel"
        TipoContaLabel.Size = New System.Drawing.Size(74, 13)
        TipoContaLabel.TabIndex = 149
        TipoContaLabel.Text = "Tipo de Conta"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(3, 52)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(100, 13)
        Label10.TabIndex = 151
        Label10.Text = "Custo Fixo/Variável"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(239, 26)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(71, 13)
        Label12.TabIndex = 153
        Label12.Text = "Centro Custo"
        '
        'colValProd
        '
        Me.colValProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValProd.AppearanceCell.Options.UseTextOptions = True
        Me.colValProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValProd.Caption = "Val. Venda R$"
        Me.colValProd.FieldName = "ValProd"
        Me.colValProd.Name = "colValProd"
        Me.colValProd.OptionsColumn.ReadOnly = True
        Me.colValProd.Visible = True
        Me.colValProd.VisibleIndex = 8
        Me.colValProd.Width = 97
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 153
        Me.Label13.Text = "Chave"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nº NF"
        '
        'txtNF
        '
        Me.txtNF.EnterMoveNextControl = True
        Me.txtNF.Location = New System.Drawing.Point(87, 12)
        Me.txtNF.Name = "txtNF"
        Me.txtNF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNF.Properties.Appearance.Options.UseFont = True
        Me.txtNF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNF.Size = New System.Drawing.Size(83, 20)
        Me.txtNF.TabIndex = 0
        Me.txtNF.Tag = "Nº NF"
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(873, 12)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Options.UseTextOptions = True
        Me.dtData.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtData.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtData.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(109, 20)
        Me.dtData.TabIndex = 4
        Me.dtData.Tag = "Data"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(844, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Data"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(5, 71)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(997, 5)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(21, 65)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(130, 14)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Dados do Fornecedor"
        '
        'FornecedorBindingSource
        '
        Me.FornecedorBindingSource.DataMember = "Fornecedor"
        Me.FornecedorBindingSource.DataSource = Me.dsNano
        '
        'dsNano
        '
        Me.dsNano.DataSetName = "dsNano"
        Me.dsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCPF
        '
        Me.txtCPF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FornecedorBindingSource, "CPF", True))
        Me.txtCPF.Location = New System.Drawing.Point(679, 87)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Properties.Appearance.Options.UseFont = True
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCPF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCPF.Properties.ReadOnly = True
        Me.txtCPF.Size = New System.Drawing.Size(303, 20)
        Me.txtCPF.TabIndex = 18
        '
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'grpProd
        '
        Me.grpProd.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProd.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.grpProd.AppearanceCaption.Options.UseFont = True
        Me.grpProd.AppearanceCaption.Options.UseForeColor = True
        Me.grpProd.Controls.Add(Me.lblQtdProd)
        Me.grpProd.Controls.Add(Me.lblConv)
        Me.grpProd.Controls.Add(Me.txtQtdProd)
        Me.grpProd.Controls.Add(Me.cboUniMed)
        Me.grpProd.Controls.Add(Me.txtValorCusto)
        Me.grpProd.Controls.Add(Label9)
        Me.grpProd.Controls.Add(Me.txtCodProdFor)
        Me.grpProd.Controls.Add(Me.lblCodProdFor)
        Me.grpProd.Controls.Add(Me.txtCodBarra)
        Me.grpProd.Controls.Add(Me.LabelControl10)
        Me.grpProd.Controls.Add(Me.cboTipoProduto)
        Me.grpProd.Controls.Add(Me.LabelControl9)
        Me.grpProd.Controls.Add(Me.lblICMS)
        Me.grpProd.Controls.Add(Me.lblIPI)
        Me.grpProd.Controls.Add(Me.txtICMSItem)
        Me.grpProd.Controls.Add(Me.txtIPIItem)
        Me.grpProd.Controls.Add(Me.LabelControl18)
        Me.grpProd.Controls.Add(Me.btnCadSet)
        Me.grpProd.Controls.Add(Me.cboSet)
        Me.grpProd.Controls.Add(Me.btnCadGrp)
        Me.grpProd.Controls.Add(Me.cboGrp)
        Me.grpProd.Controls.Add(Me.LabelControl20)
        Me.grpProd.Controls.Add(Me.txtPor1)
        Me.grpProd.Controls.Add(Me.txtVal)
        Me.grpProd.Controls.Add(Me.lblPor)
        Me.grpProd.Controls.Add(Me.lblVenda)
        Me.grpProd.Controls.Add(Me.chkTamanho)
        Me.grpProd.Controls.Add(Me.txtTam)
        Me.grpProd.Controls.Add(Label11)
        Me.grpProd.Controls.Add(Me.txtQtd)
        Me.grpProd.Controls.Add(Label8)
        Me.grpProd.Controls.Add(Me.txtPerDesc)
        Me.grpProd.Controls.Add(Me.lueHis)
        Me.grpProd.Controls.Add(Me.txtNomePro)
        Me.grpProd.Controls.Add(Me.txtCodPro)
        Me.grpProd.Controls.Add(Me.txtValor)
        Me.grpProd.Controls.Add(Label7)
        Me.grpProd.Controls.Add(Me.btnAdd)
        Me.grpProd.Controls.Add(Label6)
        Me.grpProd.Controls.Add(Label4)
        Me.grpProd.Controls.Add(Label3)
        Me.grpProd.Controls.Add(Me.TextEdit1)
        Me.grpProd.Controls.Add(Me.lblMVaST)
        Me.grpProd.Controls.Add(Me.txtMVaST)
        Me.grpProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpProd.Location = New System.Drawing.Point(0, 0)
        Me.grpProd.Name = "grpProd"
        Me.grpProd.Size = New System.Drawing.Size(1008, 108)
        Me.grpProd.TabIndex = 11
        Me.grpProd.Text = "Adicionar Produtos"
        '
        'lblQtdProd
        '
        Me.lblQtdProd.Location = New System.Drawing.Point(316, 84)
        Me.lblQtdProd.Name = "lblQtdProd"
        Me.lblQtdProd.Size = New System.Drawing.Size(47, 13)
        Me.lblQtdProd.TabIndex = 146
        Me.lblQtdProd.Text = "Qtd Prod."
        '
        'lblConv
        '
        Me.lblConv.Location = New System.Drawing.Point(201, 84)
        Me.lblConv.Name = "lblConv"
        Me.lblConv.Size = New System.Drawing.Size(42, 13)
        Me.lblConv.TabIndex = 144
        Me.lblConv.Text = "Conv. p/"
        '
        'txtQtdProd
        '
        Me.txtQtdProd.CasasDecimais = 0
        Me.txtQtdProd.EnterMoveNextControl = True
        Me.txtQtdProd.Location = New System.Drawing.Point(367, 81)
        Me.txtQtdProd.Name = "txtQtdProd"
        Me.txtQtdProd.Numerico = True
        Me.txtQtdProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdProd.Properties.Appearance.Options.UseFont = True
        Me.txtQtdProd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdProd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdProd.Properties.MaxLength = 13
        Me.txtQtdProd.Size = New System.Drawing.Size(60, 20)
        Me.txtQtdProd.TabIndex = 12
        '
        'cboUniMed
        '
        Me.cboUniMed.EditValue = "UN"
        Me.cboUniMed.EnterMoveNextControl = True
        Me.cboUniMed.Location = New System.Drawing.Point(250, 81)
        Me.cboUniMed.Name = "cboUniMed"
        Me.cboUniMed.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUniMed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUniMed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUniMed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUniMed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUniMed.Properties.Items.AddRange(New Object() {"UN", "JG", "KT", "KG", "LT", "MT", "CX", "GL", "FD", "CJ", "CT", "PC", "DP", "FR", "ML", "PR", "DZ", "SC", "M2"})
        Me.cboUniMed.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUniMed.Size = New System.Drawing.Size(59, 20)
        Me.cboUniMed.TabIndex = 11
        Me.cboUniMed.Tag = "Unid. de Medida"
        '
        'txtValorCusto
        '
        Me.txtValorCusto.EnterMoveNextControl = True
        Me.txtValorCusto.Location = New System.Drawing.Point(496, 56)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCusto.Properties.Appearance.Options.UseFont = True
        Me.txtValorCusto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCusto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCusto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorCusto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorCusto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorCusto.Properties.MaxLength = 19
        Me.txtValorCusto.Size = New System.Drawing.Size(114, 20)
        Me.txtValorCusto.TabIndex = 7
        Me.txtValorCusto.Tag = "Preço R$"
        Me.txtValorCusto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtCodProdFor
        '
        Me.txtCodProdFor.CasasDecimais = 0
        Me.txtCodProdFor.EnterMoveNextControl = True
        Me.txtCodProdFor.Location = New System.Drawing.Point(496, 81)
        Me.txtCodProdFor.Name = "txtCodProdFor"
        Me.txtCodProdFor.Numerico = False
        Me.txtCodProdFor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodProdFor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodProdFor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodProdFor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodProdFor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodProdFor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodProdFor.Properties.MaxLength = 25
        Me.txtCodProdFor.Size = New System.Drawing.Size(114, 20)
        Me.txtCodProdFor.TabIndex = 13
        Me.txtCodProdFor.Tag = "Cod. Barra"
        '
        'lblCodProdFor
        '
        Me.lblCodProdFor.Location = New System.Drawing.Point(444, 84)
        Me.lblCodProdFor.Name = "lblCodProdFor"
        Me.lblCodProdFor.Size = New System.Drawing.Size(46, 13)
        Me.lblCodProdFor.TabIndex = 143
        Me.lblCodProdFor.Text = "Cód. For."
        '
        'txtCodBarra
        '
        Me.txtCodBarra.CasasDecimais = 0
        Me.txtCodBarra.EnterMoveNextControl = True
        Me.txtCodBarra.Location = New System.Drawing.Point(87, 55)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Numerico = False
        Me.txtCodBarra.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodBarra.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodBarra.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodBarra.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodBarra.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodBarra.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodBarra.Properties.MaxLength = 25
        Me.txtCodBarra.Size = New System.Drawing.Size(106, 20)
        Me.txtCodBarra.TabIndex = 4
        Me.txtCodBarra.Tag = "Cod. Barra"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(27, 59)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl10.TabIndex = 141
        Me.LabelControl10.Text = "Cód. Barra"
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.EditValue = ""
        Me.cboTipoProduto.EnterMoveNextControl = True
        Me.cboTipoProduto.Location = New System.Drawing.Point(679, 81)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoProduto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipoProduto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoProduto.Properties.Items.AddRange(New Object() {"", "VENDA", "CONSUMO", "AMBOS"})
        Me.cboTipoProduto.Properties.MaxLength = 55
        Me.cboTipoProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoProduto.Size = New System.Drawing.Size(114, 20)
        Me.cboTipoProduto.TabIndex = 14
        Me.cboTipoProduto.Tag = "Tipo"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(653, 84)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl9.TabIndex = 138
        Me.LabelControl9.Text = "Tipo"
        '
        'lblICMS
        '
        Me.lblICMS.Location = New System.Drawing.Point(436, 84)
        Me.lblICMS.Name = "lblICMS"
        Me.lblICMS.Size = New System.Drawing.Size(54, 13)
        Me.lblICMS.TabIndex = 134
        Me.lblICMS.Text = "ICMS ST %"
        '
        'lblIPI
        '
        Me.lblIPI.Location = New System.Drawing.Point(216, 84)
        Me.lblIPI.Name = "lblIPI"
        Me.lblIPI.Size = New System.Drawing.Size(28, 13)
        Me.lblIPI.TabIndex = 133
        Me.lblIPI.Text = "IPI %"
        '
        'txtICMSItem
        '
        Me.txtICMSItem.EnterMoveNextControl = True
        Me.txtICMSItem.Location = New System.Drawing.Point(496, 81)
        Me.txtICMSItem.Name = "txtICMSItem"
        Me.txtICMSItem.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtICMSItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICMSItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtICMSItem.Properties.Appearance.Options.UseFont = True
        Me.txtICMSItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtICMSItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtICMSItem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtICMSItem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtICMSItem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtICMSItem.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtICMSItem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtICMSItem.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtICMSItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtICMSItem.Properties.MaxLength = 19
        Me.txtICMSItem.Size = New System.Drawing.Size(114, 20)
        Me.txtICMSItem.TabIndex = 13
        Me.txtICMSItem.Tag = "ICMS"
        Me.txtICMSItem.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtIPIItem
        '
        Me.txtIPIItem.EnterMoveNextControl = True
        Me.txtIPIItem.Location = New System.Drawing.Point(250, 81)
        Me.txtIPIItem.Name = "txtIPIItem"
        Me.txtIPIItem.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIPIItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPIItem.Properties.Appearance.Options.UseBackColor = True
        Me.txtIPIItem.Properties.Appearance.Options.UseFont = True
        Me.txtIPIItem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIPIItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIPIItem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIPIItem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtIPIItem.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtIPIItem.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtIPIItem.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIPIItem.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIPIItem.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIPIItem.Properties.MaxLength = 19
        Me.txtIPIItem.Size = New System.Drawing.Size(60, 20)
        Me.txtIPIItem.TabIndex = 11
        Me.txtIPIItem.Tag = "IPI"
        Me.txtIPIItem.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(647, 32)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl18.TabIndex = 130
        Me.LabelControl18.Text = "Setor"
        '
        'btnCadSet
        '
        Me.btnCadSet.Image = CType(resources.GetObject("btnCadSet.Image"), System.Drawing.Image)
        Me.btnCadSet.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadSet.Location = New System.Drawing.Point(793, 29)
        Me.btnCadSet.Name = "btnCadSet"
        Me.btnCadSet.Size = New System.Drawing.Size(20, 20)
        Me.btnCadSet.TabIndex = 129
        Me.btnCadSet.Text = "SimpleButton1"
        '
        'cboSet
        '
        Me.cboSet.EnterMoveNextControl = True
        Me.cboSet.Location = New System.Drawing.Point(679, 29)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboSet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSet.Properties.MaxLength = 55
        Me.cboSet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSet.Size = New System.Drawing.Size(114, 20)
        Me.cboSet.TabIndex = 2
        Me.cboSet.Tag = "Grupo"
        '
        'btnCadGrp
        '
        Me.btnCadGrp.Image = CType(resources.GetObject("btnCadGrp.Image"), System.Drawing.Image)
        Me.btnCadGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadGrp.Location = New System.Drawing.Point(982, 30)
        Me.btnCadGrp.Name = "btnCadGrp"
        Me.btnCadGrp.Size = New System.Drawing.Size(20, 20)
        Me.btnCadGrp.TabIndex = 125
        Me.btnCadGrp.Text = "SimpleButton1"
        '
        'cboGrp
        '
        Me.cboGrp.EnterMoveNextControl = True
        Me.cboGrp.Location = New System.Drawing.Point(873, 30)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGrp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboGrp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrp.Properties.MaxLength = 55
        Me.cboGrp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboGrp.Size = New System.Drawing.Size(109, 20)
        Me.cboGrp.TabIndex = 3
        Me.cboGrp.Tag = "Grupo"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(838, 33)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl20.TabIndex = 128
        Me.LabelControl20.Text = "Grupo"
        '
        'txtPor1
        '
        Me.txtPor1.CasasDecimais = 2
        Me.txtPor1.EditValue = ""
        Me.txtPor1.EnterMoveNextControl = True
        Me.txtPor1.Location = New System.Drawing.Point(759, 55)
        Me.txtPor1.Name = "txtPor1"
        Me.txtPor1.Numerico = True
        Me.txtPor1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPor1.Properties.Appearance.Options.UseBackColor = True
        Me.txtPor1.Size = New System.Drawing.Size(34, 20)
        Me.txtPor1.TabIndex = 18
        Me.txtPor1.Tag = "%"
        '
        'txtVal
        '
        Me.txtVal.CasasDecimais = 2
        Me.txtVal.EnterMoveNextControl = True
        Me.txtVal.Location = New System.Drawing.Point(679, 55)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Numerico = True
        Me.txtVal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtVal.Properties.MaxLength = 18
        Me.txtVal.Size = New System.Drawing.Size(81, 20)
        Me.txtVal.TabIndex = 8
        Me.txtVal.Tag = "Valor Venda R$"
        '
        'lblPor
        '
        Me.lblPor.Location = New System.Drawing.Point(799, 59)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(11, 13)
        Me.lblPor.TabIndex = 8
        Me.lblPor.Text = "%"
        '
        'lblVenda
        '
        Me.lblVenda.Location = New System.Drawing.Point(627, 58)
        Me.lblVenda.Name = "lblVenda"
        Me.lblVenda.Size = New System.Drawing.Size(46, 13)
        Me.lblVenda.TabIndex = 123
        Me.lblVenda.Text = "Venda R$"
        '
        'chkTamanho
        '
        Me.chkTamanho.EditValue = True
        Me.chkTamanho.Location = New System.Drawing.Point(407, 56)
        Me.chkTamanho.Name = "chkTamanho"
        Me.chkTamanho.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkTamanho.Properties.Appearance.Options.UseBackColor = True
        Me.chkTamanho.Properties.Caption = ""
        Me.chkTamanho.Size = New System.Drawing.Size(17, 19)
        Me.chkTamanho.TabIndex = 20
        Me.chkTamanho.ToolTip = "Clique para adicionar um tamanho diferente de U"
        Me.chkTamanho.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkTamanho.ToolTipTitle = "Tamanho do Produto"
        '
        'txtTam
        '
        Me.txtTam.CasasDecimais = 0
        Me.txtTam.EnterMoveNextControl = True
        Me.txtTam.Location = New System.Drawing.Point(367, 55)
        Me.txtTam.Name = "txtTam"
        Me.txtTam.Numerico = False
        Me.txtTam.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTam.Properties.Appearance.Options.UseFont = True
        Me.txtTam.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTam.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTam.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTam.Properties.MaxLength = 30
        Me.txtTam.Size = New System.Drawing.Size(39, 20)
        Me.txtTam.TabIndex = 6
        Me.txtTam.Tag = "Tamanho"
        '
        'txtQtd
        '
        Me.txtQtd.CasasDecimais = 0
        Me.txtQtd.EnterMoveNextControl = True
        Me.txtQtd.Location = New System.Drawing.Point(250, 55)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Numerico = True
        Me.txtQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Properties.Appearance.Options.UseFont = True
        Me.txtQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtd.Properties.MaxLength = 13
        Me.txtQtd.Size = New System.Drawing.Size(60, 20)
        Me.txtQtd.TabIndex = 5
        Me.txtQtd.Tag = "Qtd"
        '
        'txtPerDesc
        '
        Me.txtPerDesc.EditValue = ""
        Me.txtPerDesc.EnterMoveNextControl = True
        Me.txtPerDesc.Location = New System.Drawing.Point(873, 56)
        Me.txtPerDesc.Name = "txtPerDesc"
        Me.txtPerDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerDesc.Properties.Appearance.Options.UseFont = True
        Me.txtPerDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPerDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerDesc.Properties.MaxLength = 19
        Me.txtPerDesc.Size = New System.Drawing.Size(109, 20)
        Me.txtPerDesc.TabIndex = 9
        Me.txtPerDesc.Tag = "Outras Desp. Aces. R$"
        Me.txtPerDesc.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lueHis
        '
        Me.lueHis.Location = New System.Drawing.Point(171, 81)
        Me.lueHis.Name = "lueHis"
        Me.lueHis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.lueHis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValorUnitario", "Valor Pago R$", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Data", "Data", 67, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None)})
        Me.lueHis.Properties.DataSource = Me.EntradaNFBindingSource1
        Me.lueHis.Properties.DisplayMember = "CodProd"
        Me.lueHis.Properties.NullText = ""
        Me.lueHis.Properties.PopupWidth = 400
        Me.lueHis.Properties.ValueMember = "CodProd"
        Me.lueHis.Size = New System.Drawing.Size(22, 20)
        Me.lueHis.TabIndex = 64
        '
        'EntradaNFBindingSource1
        '
        Me.EntradaNFBindingSource1.DataMember = "EntradaNF"
        Me.EntradaNFBindingSource1.DataSource = Me.dsNano
        '
        'txtNomePro
        '
        Me.txtNomePro.EnterMoveNextControl = True
        Me.txtNomePro.Location = New System.Drawing.Point(250, 29)
        Me.txtNomePro.Name = "txtNomePro"
        Me.txtNomePro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePro.Properties.Appearance.Options.UseFont = True
        Me.txtNomePro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomePro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomePro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomePro.Properties.MaxLength = 200
        Me.txtNomePro.Size = New System.Drawing.Size(360, 20)
        Me.txtNomePro.TabIndex = 1
        Me.txtNomePro.Tag = "Qtd"
        Me.txtNomePro.ToolTip = "Unidade de Medida"
        Me.txtNomePro.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtCodPro
        '
        Me.txtCodPro.EnterMoveNextControl = True
        Me.txtCodPro.Location = New System.Drawing.Point(87, 29)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPro.Properties.Appearance.Options.UseFont = True
        Me.txtCodPro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCodPro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPro.Size = New System.Drawing.Size(106, 20)
        Me.txtCodPro.TabIndex = 0
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(87, 81)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Properties.MaxLength = 19
        Me.txtValor.Size = New System.Drawing.Size(85, 20)
        Me.txtValor.TabIndex = 10
        Me.txtValor.Tag = "Preço R$"
        Me.txtValor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(873, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 21)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Adicionar"
        '
        'TextEdit1
        '
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(390, 55)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TextEdit1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.TextEdit1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.TextEdit1.Properties.MaxLength = 3
        Me.TextEdit1.Size = New System.Drawing.Size(36, 20)
        Me.TextEdit1.TabIndex = 139
        Me.TextEdit1.Tag = "Série"
        '
        'lblMVaST
        '
        Me.lblMVaST.Location = New System.Drawing.Point(315, 84)
        Me.lblMVaST.Name = "lblMVaST"
        Me.lblMVaST.Size = New System.Drawing.Size(46, 13)
        Me.lblMVaST.TabIndex = 136
        Me.lblMVaST.Text = "MVaST %"
        '
        'txtMVaST
        '
        Me.txtMVaST.EnterMoveNextControl = True
        Me.txtMVaST.Location = New System.Drawing.Point(367, 81)
        Me.txtMVaST.Name = "txtMVaST"
        Me.txtMVaST.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtMVaST.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMVaST.Properties.Appearance.Options.UseBackColor = True
        Me.txtMVaST.Properties.Appearance.Options.UseFont = True
        Me.txtMVaST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMVaST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMVaST.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMVaST.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMVaST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMVaST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMVaST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMVaST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMVaST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMVaST.Properties.MaxLength = 19
        Me.txtMVaST.Size = New System.Drawing.Size(60, 20)
        Me.txtMVaST.TabIndex = 12
        Me.txtMVaST.Tag = "MVaST"
        Me.txtMVaST.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'lblLoja
        '
        Me.lblLoja.Location = New System.Drawing.Point(651, 3)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(20, 13)
        Me.lblLoja.TabIndex = 120
        Me.lblLoja.Text = "Loja"
        '
        'lueLoja
        '
        Me.lueLoja.EnterMoveNextControl = True
        Me.lueLoja.Location = New System.Drawing.Point(679, 0)
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lueLoja.Properties.Appearance.Options.UseFont = True
        Me.lueLoja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.Properties.DisplayMember = "Descricao"
        Me.lueLoja.Properties.NullText = ""
        Me.lueLoja.Properties.ValueMember = "Codigo"
        Me.lueLoja.Size = New System.Drawing.Size(114, 19)
        Me.lueLoja.TabIndex = 0
        Me.lueLoja.Tag = "Loja"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.btnPadrao)
        Me.GroupControl1.Controls.Add(Me.btnManter)
        Me.GroupControl1.Controls.Add(Me.EntradaNFGridControl)
        Me.GroupControl1.Controls.Add(Me.chkDescontoItens)
        Me.GroupControl1.Controls.Add(Me.lueLoja)
        Me.GroupControl1.Controls.Add(Me.lblLoja)
        Me.GroupControl1.Controls.Add(Me.chkEstoqueOK)
        Me.GroupControl1.Controls.Add(Me.TotalEntradaNFGridControl)
        Me.GroupControl1.Controls.Add(Me.picFundo)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 108)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 201)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Itens da Nota"
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(929, 3)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 128
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(875, 3)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 127
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'EntradaNFGridControl
        '
        Me.EntradaNFGridControl.DataMember = "tbEntrada"
        Me.EntradaNFGridControl.DataSource = Me.dsEntrada
        Me.EntradaNFGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EntradaNFGridControl.EmbeddedNavigator.Name = ""
        Me.EntradaNFGridControl.Location = New System.Drawing.Point(2, 20)
        Me.EntradaNFGridControl.MainView = Me.grd1
        Me.EntradaNFGridControl.Name = "EntradaNFGridControl"
        Me.EntradaNFGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.EntradaNFGridControl.Size = New System.Drawing.Size(1004, 124)
        Me.EntradaNFGridControl.TabIndex = 1
        Me.EntradaNFGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsEntrada
        '
        Me.dsEntrada.DataSetName = "NewDataSet"
        Me.dsEntrada.Tables.AddRange(New System.Data.DataTable() {Me.tbEntrada, Me.tbFor, Me.tbContaPagar})
        '
        'tbEntrada
        '
        Me.tbEntrada.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn102})
        Me.tbEntrada.TableName = "tbEntrada"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodProd"
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
        Me.DataColumn6.ColumnName = "Produto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "CodProdInterno"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ICMS"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Desconto"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "IPI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "UnitarioImposto"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Tamanho"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CodConfig"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "CodTotNF"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ValProd"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "PorProd"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "UM"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "CodigoBarra"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "NCM"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "CFOP"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "EXTIPI"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "Genero"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "UnidTrib"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ValTrib"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "QtdTrib"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "UnidCom"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "ValCom"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "CST"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Origem"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "CalculoCred"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ModBC"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "RedBC"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "IcmsNfe"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "ModBCST"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "RedBCST"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "MVaST"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "IcmsST"
        '
        'DataColumn47
        '
        Me.DataColumn47.Caption = "Grupo"
        Me.DataColumn47.ColumnName = "Grupo"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Setor"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "CodProdFor"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "TipoProduto"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "CSTIPI"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "CodEnq"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "PerIPI"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "CSTPIS"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "PerPIS"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "CSTCOFINS"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "PerCOFINS"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "CodigoANP"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "UFComb"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "Regime"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "NCMEnt"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "CFOPEnt"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "CodigoANPEnt"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "UFCombEnt"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "RegimeEnt"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "CSTEnt"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "OrigemEnt"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "CalculoCredEnt"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "ValCredEnt"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "ModBCEnt"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "RedBCEnt"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "AliquotaICMSEnt"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "ValICMSEnt"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "ModBCSTEnt"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "RedBCSTEnt"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "MaVSTEnt"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "AliquotaICMSSTEnt"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "ValICMSSTEnt"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "CSTIPIEnt"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "CodEnqEnt"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "AliquotaIPIEnt"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "ValIPIEnt"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "CSTPISEnt"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "AliquotaPISEnt"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "ValPISEnt"
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "CSTCOFINSEnt"
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "AliquotaCOFINSEnt"
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "ValCOFINSEnt"
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "ValorCusto"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "UMProd"
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "QtdProd"
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "Cest"
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "VFCPSTEnt"
        '
        'tbFor
        '
        Me.tbFor.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.tbFor.TableName = "tbFor"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Endereco"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Numero"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Bairro"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Cidade"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Estado"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Cep"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "IE"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Fantasia"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Telefone"
        '
        'tbContaPagar
        '
        Me.tbContaPagar.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97, Me.DataColumn98})
        Me.tbContaPagar.TableName = "tbContaPagar"
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "ValorConta"
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "Parcela"
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "ValorParcela"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "Vencimento"
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "FormaPagamento"
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "Pagamento"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodProd, Me.colQtd, Me.colValorUnitario, Me.colValorTotal, Me.colProduto, Me.colCodProdInterno, Me.colICMS, Me.colDescontoNF, Me.colIPI, Me.colUnitarioImposto, Me.colCodTotNF, Me.colTamanho, Me.colCodConfig, Me.colValProd, Me.colPorProd, Me.colUM, Me.colCodigoBarra, Me.colNCM, Me.colCFOP, Me.colEXTIPI, Me.colGenero, Me.colUnidTrib, Me.colValTrib, Me.colQtdTrib, Me.colUnidCom, Me.colValCom, Me.colCST, Me.colOrigem, Me.colCalculoCred, Me.colModBC, Me.colRedBC, Me.colIcmsNfe, Me.colModBCST, Me.colRedBCST, Me.colMVaST, Me.colIcmsST, Me.colGrupo, Me.colSetor, Me.colCodProdFor, Me.colTipoProduto, Me.colCSTIPI, Me.colCodEnq, Me.colPerIPI, Me.colCSTPIS, Me.colPerPIS, Me.colCSTCOFINS, Me.colPerCOFINS, Me.colCodigoANP, Me.colUFComb, Me.colRegime, Me.colCFOPEnt, Me.colNCMEnt, Me.colRegimeEnt, Me.colCSTEnt, Me.colOrigemEnt, Me.colCalculoCredEnt, Me.colValCredEnt, Me.colModBCEnt, Me.colRedBCEnt, Me.colAliquotaICMSEnt, Me.colValICMSEnt, Me.colModBCSTEnt, Me.colRedBCSTEnt, Me.colMVaSTEnt, Me.colAliquotaICMSSTEnt, Me.colValICMSSTEnt, Me.colCSTIPIEnt, Me.colCodEnqEnt, Me.colAliquotaIPIEnt, Me.colValIPIEnt, Me.colCSTPISEnt, Me.colAliquotaPISEnt, Me.colValPISEnt, Me.colCSTCOFINSEnt, Me.colAliquotaCOFINSEnt, Me.colValCOFINSEnt, Me.colCodigoANPEnt, Me.colUFCombEnt, Me.colValorCusto, Me.colUMProd, Me.colQtdProd, Me.colCest, Me.colVFCPSTEnt, Me.colFreteEnt, Me.colDespesasEnt, Me.colSeguroEnt})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colValProd
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        StyleFormatCondition1.Value1 = ""
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.EntradaNFGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodigo.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodigo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigo.AppearanceCell.Options.UseBackColor = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Width = 88
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCodProd.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCodProd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProd.AppearanceCell.Options.UseBackColor = True
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.Caption = "Cód. do Produto"
        Me.colCodProd.ColumnEdit = Me.txtAlterar
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Width = 93
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.ColumnEdit = Me.txtAlterar
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 4
        Me.colQtd.Width = 60
        '
        'colValorUnitario
        '
        Me.colValorUnitario.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorUnitario.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUnitario.Caption = "Val. Unit. R$"
        Me.colValorUnitario.ColumnEdit = Me.txtAlterar
        Me.colValorUnitario.FieldName = "ValorUnitario"
        Me.colValorUnitario.Name = "colValorUnitario"
        Me.colValorUnitario.OptionsColumn.ReadOnly = True
        Me.colValorUnitario.Visible = True
        Me.colValorUnitario.VisibleIndex = 6
        Me.colValorUnitario.Width = 99
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Val. Total R$"
        Me.colValorTotal.ColumnEdit = Me.txtAlterar
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 7
        Me.colValorTotal.Width = 97
        '
        'colProduto
        '
        Me.colProduto.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colProduto.Caption = "Descrição do Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 2
        Me.colProduto.Width = 311
        '
        'colCodProdInterno
        '
        Me.colCodProdInterno.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodProdInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdInterno.Caption = "Cód. Prod."
        Me.colCodProdInterno.ColumnEdit = Me.txtAlterar
        Me.colCodProdInterno.FieldName = "CodProdInterno"
        Me.colCodProdInterno.Name = "colCodProdInterno"
        Me.colCodProdInterno.OptionsColumn.ReadOnly = True
        Me.colCodProdInterno.Visible = True
        Me.colCodProdInterno.VisibleIndex = 0
        Me.colCodProdInterno.Width = 72
        '
        'colICMS
        '
        Me.colICMS.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colICMS.Caption = "Alíq ICMS ST"
        Me.colICMS.ColumnEdit = Me.txtAlterar
        Me.colICMS.FieldName = "ICMS"
        Me.colICMS.Name = "colICMS"
        Me.colICMS.OptionsColumn.ReadOnly = True
        Me.colICMS.Width = 80
        '
        'colDescontoNF
        '
        Me.colDescontoNF.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDescontoNF.AppearanceCell.Options.UseTextOptions = True
        Me.colDescontoNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDescontoNF.Caption = "Desc. %"
        Me.colDescontoNF.ColumnEdit = Me.txtAlterar
        Me.colDescontoNF.FieldName = "Desconto"
        Me.colDescontoNF.Name = "colDescontoNF"
        Me.colDescontoNF.OptionsColumn.ReadOnly = True
        Me.colDescontoNF.Visible = True
        Me.colDescontoNF.VisibleIndex = 5
        Me.colDescontoNF.Width = 68
        '
        'colIPI
        '
        Me.colIPI.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colIPI.Caption = "Alíq. IPI"
        Me.colIPI.FieldName = "IPI"
        Me.colIPI.Name = "colIPI"
        Me.colIPI.OptionsColumn.ReadOnly = True
        Me.colIPI.Width = 65
        '
        'colUnitarioImposto
        '
        Me.colUnitarioImposto.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitarioImposto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitarioImposto.Caption = "Preço S/Imp. R$"
        Me.colUnitarioImposto.FieldName = "UnitarioImposto"
        Me.colUnitarioImposto.Name = "colUnitarioImposto"
        Me.colUnitarioImposto.OptionsColumn.ReadOnly = True
        Me.colUnitarioImposto.Width = 98
        '
        'colCodTotNF
        '
        Me.colCodTotNF.Caption = "CodTotNF"
        Me.colCodTotNF.FieldName = "CodTotNF"
        Me.colCodTotNF.Name = "colCodTotNF"
        Me.colCodTotNF.OptionsColumn.ReadOnly = True
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
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
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.FixedWidth = True
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 16
        Me.colCodConfig.Width = 66
        '
        'colPorProd
        '
        Me.colPorProd.Caption = "PorProd"
        Me.colPorProd.FieldName = "PorProd"
        Me.colPorProd.Name = "colPorProd"
        Me.colPorProd.OptionsColumn.ReadOnly = True
        '
        'colUM
        '
        Me.colUM.Caption = "UM"
        Me.colUM.FieldName = "UM"
        Me.colUM.Name = "colUM"
        Me.colUM.OptionsColumn.ReadOnly = True
        '
        'colCodigoBarra
        '
        Me.colCodigoBarra.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCodigoBarra.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoBarra.Caption = "Cod. Barra"
        Me.colCodigoBarra.ColumnEdit = Me.txtAlterar
        Me.colCodigoBarra.FieldName = "CodigoBarra"
        Me.colCodigoBarra.Name = "colCodigoBarra"
        Me.colCodigoBarra.OptionsColumn.ReadOnly = True
        Me.colCodigoBarra.Visible = True
        Me.colCodigoBarra.VisibleIndex = 1
        Me.colCodigoBarra.Width = 117
        '
        'colNCM
        '
        Me.colNCM.Caption = "NCM"
        Me.colNCM.FieldName = "NCM"
        Me.colNCM.Name = "colNCM"
        Me.colNCM.OptionsColumn.ReadOnly = True
        '
        'colCFOP
        '
        Me.colCFOP.Caption = "CFOP"
        Me.colCFOP.FieldName = "CFOP"
        Me.colCFOP.Name = "colCFOP"
        Me.colCFOP.OptionsColumn.ReadOnly = True
        '
        'colEXTIPI
        '
        Me.colEXTIPI.Caption = "GridColumn3"
        Me.colEXTIPI.FieldName = "EXTIPI"
        Me.colEXTIPI.Name = "colEXTIPI"
        Me.colEXTIPI.OptionsColumn.ReadOnly = True
        '
        'colGenero
        '
        Me.colGenero.Caption = "GridColumn4"
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.Name = "colGenero"
        Me.colGenero.OptionsColumn.ReadOnly = True
        '
        'colUnidTrib
        '
        Me.colUnidTrib.Caption = "GridColumn5"
        Me.colUnidTrib.FieldName = "UnidTrib"
        Me.colUnidTrib.Name = "colUnidTrib"
        Me.colUnidTrib.OptionsColumn.ReadOnly = True
        '
        'colValTrib
        '
        Me.colValTrib.Caption = "GridColumn6"
        Me.colValTrib.FieldName = "ValTrib"
        Me.colValTrib.Name = "colValTrib"
        Me.colValTrib.OptionsColumn.ReadOnly = True
        '
        'colQtdTrib
        '
        Me.colQtdTrib.Caption = "GridColumn7"
        Me.colQtdTrib.FieldName = "QtdTrib"
        Me.colQtdTrib.Name = "colQtdTrib"
        Me.colQtdTrib.OptionsColumn.ReadOnly = True
        '
        'colUnidCom
        '
        Me.colUnidCom.Caption = "GridColumn8"
        Me.colUnidCom.FieldName = "UnidCom"
        Me.colUnidCom.Name = "colUnidCom"
        Me.colUnidCom.OptionsColumn.ReadOnly = True
        '
        'colValCom
        '
        Me.colValCom.Caption = "GridColumn9"
        Me.colValCom.FieldName = "ValCom"
        Me.colValCom.Name = "colValCom"
        Me.colValCom.OptionsColumn.ReadOnly = True
        '
        'colCST
        '
        Me.colCST.Caption = "CST"
        Me.colCST.FieldName = "CST"
        Me.colCST.Name = "colCST"
        Me.colCST.OptionsColumn.ReadOnly = True
        '
        'colOrigem
        '
        Me.colOrigem.Caption = "GridColumn11"
        Me.colOrigem.FieldName = "Origem"
        Me.colOrigem.Name = "colOrigem"
        Me.colOrigem.OptionsColumn.ReadOnly = True
        '
        'colCalculoCred
        '
        Me.colCalculoCred.Caption = "GridColumn12"
        Me.colCalculoCred.FieldName = "CalculoCred"
        Me.colCalculoCred.Name = "colCalculoCred"
        Me.colCalculoCred.OptionsColumn.ReadOnly = True
        '
        'colModBC
        '
        Me.colModBC.Caption = "GridColumn13"
        Me.colModBC.FieldName = "ModBC"
        Me.colModBC.Name = "colModBC"
        Me.colModBC.OptionsColumn.ReadOnly = True
        '
        'colRedBC
        '
        Me.colRedBC.Caption = "GridColumn14"
        Me.colRedBC.FieldName = "RedBC"
        Me.colRedBC.Name = "colRedBC"
        Me.colRedBC.OptionsColumn.ReadOnly = True
        '
        'colIcmsNfe
        '
        Me.colIcmsNfe.Caption = "Aliq. ICMS"
        Me.colIcmsNfe.FieldName = "IcmsNfe"
        Me.colIcmsNfe.Name = "colIcmsNfe"
        Me.colIcmsNfe.OptionsColumn.ReadOnly = True
        '
        'colModBCST
        '
        Me.colModBCST.Caption = "GridColumn16"
        Me.colModBCST.FieldName = "ModBCST"
        Me.colModBCST.Name = "colModBCST"
        Me.colModBCST.OptionsColumn.ReadOnly = True
        '
        'colRedBCST
        '
        Me.colRedBCST.Caption = "GridColumn17"
        Me.colRedBCST.FieldName = "RedBCST"
        Me.colRedBCST.Name = "colRedBCST"
        Me.colRedBCST.OptionsColumn.ReadOnly = True
        '
        'colMVaST
        '
        Me.colMVaST.Caption = "GridColumn18"
        Me.colMVaST.FieldName = "MVaST"
        Me.colMVaST.Name = "colMVaST"
        Me.colMVaST.OptionsColumn.ReadOnly = True
        '
        'colIcmsST
        '
        Me.colIcmsST.Caption = "GridColumn19"
        Me.colIcmsST.FieldName = "IcmsST"
        Me.colIcmsST.Name = "colIcmsST"
        Me.colIcmsST.OptionsColumn.ReadOnly = True
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.ColumnEdit = Me.txtAlterar
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 12
        Me.colGrupo.Width = 118
        '
        'colSetor
        '
        Me.colSetor.Caption = "Setor"
        Me.colSetor.ColumnEdit = Me.txtAlterar
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        Me.colSetor.Visible = True
        Me.colSetor.VisibleIndex = 13
        Me.colSetor.Width = 102
        '
        'colCodProdFor
        '
        Me.colCodProdFor.Caption = "Cód. Fornec."
        Me.colCodProdFor.FieldName = "CodProdFor"
        Me.colCodProdFor.Name = "colCodProdFor"
        Me.colCodProdFor.OptionsColumn.ReadOnly = True
        Me.colCodProdFor.Visible = True
        Me.colCodProdFor.VisibleIndex = 15
        Me.colCodProdFor.Width = 85
        '
        'colTipoProduto
        '
        Me.colTipoProduto.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoProduto.Caption = "Tipo"
        Me.colTipoProduto.FieldName = "TipoProduto"
        Me.colTipoProduto.Name = "colTipoProduto"
        Me.colTipoProduto.OptionsColumn.ReadOnly = True
        Me.colTipoProduto.Visible = True
        Me.colTipoProduto.VisibleIndex = 14
        Me.colTipoProduto.Width = 82
        '
        'colCSTIPI
        '
        Me.colCSTIPI.Caption = "CST IPI"
        Me.colCSTIPI.FieldName = "CSTIPI"
        Me.colCSTIPI.Name = "colCSTIPI"
        Me.colCSTIPI.OptionsColumn.ReadOnly = True
        '
        'colCodEnq
        '
        Me.colCodEnq.Caption = "Cód. Enq"
        Me.colCodEnq.FieldName = "CodEnq"
        Me.colCodEnq.Name = "colCodEnq"
        Me.colCodEnq.OptionsColumn.ReadOnly = True
        '
        'colPerIPI
        '
        Me.colPerIPI.Caption = "Aliq. IPI"
        Me.colPerIPI.FieldName = "PerIPI"
        Me.colPerIPI.Name = "colPerIPI"
        Me.colPerIPI.OptionsColumn.ReadOnly = True
        '
        'colCSTPIS
        '
        Me.colCSTPIS.Caption = "CSTPIS"
        Me.colCSTPIS.FieldName = "CSTPIS"
        Me.colCSTPIS.Name = "colCSTPIS"
        Me.colCSTPIS.OptionsColumn.ReadOnly = True
        '
        'colPerPIS
        '
        Me.colPerPIS.Caption = "Aliq. PIS"
        Me.colPerPIS.FieldName = "PerPIS"
        Me.colPerPIS.Name = "colPerPIS"
        Me.colPerPIS.OptionsColumn.ReadOnly = True
        '
        'colCSTCOFINS
        '
        Me.colCSTCOFINS.Caption = "CST COFINS"
        Me.colCSTCOFINS.FieldName = "CSTCOFINS"
        Me.colCSTCOFINS.Name = "colCSTCOFINS"
        Me.colCSTCOFINS.OptionsColumn.ReadOnly = True
        '
        'colPerCOFINS
        '
        Me.colPerCOFINS.Caption = "Aliq. COFINS"
        Me.colPerCOFINS.FieldName = "PerCOFINS"
        Me.colPerCOFINS.Name = "colPerCOFINS"
        Me.colPerCOFINS.OptionsColumn.ReadOnly = True
        '
        'colCodigoANP
        '
        Me.colCodigoANP.Caption = "Cód. ANP"
        Me.colCodigoANP.FieldName = "CodigoANP"
        Me.colCodigoANP.Name = "colCodigoANP"
        Me.colCodigoANP.OptionsColumn.ReadOnly = True
        '
        'colUFComb
        '
        Me.colUFComb.Caption = "UF Comb."
        Me.colUFComb.FieldName = "UFComb"
        Me.colUFComb.Name = "colUFComb"
        Me.colUFComb.OptionsColumn.ReadOnly = True
        '
        'colRegime
        '
        Me.colRegime.Caption = "Regime"
        Me.colRegime.FieldName = "Regime"
        Me.colRegime.Name = "colRegime"
        Me.colRegime.OptionsColumn.ReadOnly = True
        '
        'colCFOPEnt
        '
        Me.colCFOPEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCFOPEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCFOPEnt.Caption = "CFOP Ent."
        Me.colCFOPEnt.FieldName = "CFOPEnt"
        Me.colCFOPEnt.Name = "colCFOPEnt"
        Me.colCFOPEnt.OptionsColumn.ReadOnly = True
        Me.colCFOPEnt.Visible = True
        Me.colCFOPEnt.VisibleIndex = 17
        '
        'colNCMEnt
        '
        Me.colNCMEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colNCMEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNCMEnt.Caption = "NCM Ent."
        Me.colNCMEnt.FieldName = "NCMEnt"
        Me.colNCMEnt.Name = "colNCMEnt"
        Me.colNCMEnt.OptionsColumn.ReadOnly = True
        Me.colNCMEnt.Visible = True
        Me.colNCMEnt.VisibleIndex = 18
        '
        'colRegimeEnt
        '
        Me.colRegimeEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colRegimeEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRegimeEnt.Caption = "Regime Ent."
        Me.colRegimeEnt.FieldName = "RegimeEnt"
        Me.colRegimeEnt.Name = "colRegimeEnt"
        Me.colRegimeEnt.OptionsColumn.ReadOnly = True
        Me.colRegimeEnt.Visible = True
        Me.colRegimeEnt.VisibleIndex = 19
        '
        'colCSTEnt
        '
        Me.colCSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTEnt.Caption = "CST Ent."
        Me.colCSTEnt.FieldName = "CSTEnt"
        Me.colCSTEnt.Name = "colCSTEnt"
        Me.colCSTEnt.OptionsColumn.ReadOnly = True
        Me.colCSTEnt.Visible = True
        Me.colCSTEnt.VisibleIndex = 20
        '
        'colOrigemEnt
        '
        Me.colOrigemEnt.Caption = "Origem Ent."
        Me.colOrigemEnt.FieldName = "OrigemEnt"
        Me.colOrigemEnt.Name = "colOrigemEnt"
        Me.colOrigemEnt.OptionsColumn.ReadOnly = True
        Me.colOrigemEnt.Visible = True
        Me.colOrigemEnt.VisibleIndex = 21
        '
        'colCalculoCredEnt
        '
        Me.colCalculoCredEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCalculoCredEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCalculoCredEnt.Caption = "Calc. Cred. Ent."
        Me.colCalculoCredEnt.FieldName = "CalculoCredEnt"
        Me.colCalculoCredEnt.Name = "colCalculoCredEnt"
        Me.colCalculoCredEnt.OptionsColumn.ReadOnly = True
        Me.colCalculoCredEnt.Visible = True
        Me.colCalculoCredEnt.VisibleIndex = 22
        '
        'colValCredEnt
        '
        Me.colValCredEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValCredEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValCredEnt.Caption = "Val. Cred. Ent."
        Me.colValCredEnt.FieldName = "ValCredEnt"
        Me.colValCredEnt.Name = "colValCredEnt"
        Me.colValCredEnt.OptionsColumn.ReadOnly = True
        Me.colValCredEnt.Visible = True
        Me.colValCredEnt.VisibleIndex = 23
        '
        'colModBCEnt
        '
        Me.colModBCEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colModBCEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModBCEnt.Caption = "Mod. BC. Ent."
        Me.colModBCEnt.FieldName = "ModBCEnt"
        Me.colModBCEnt.Name = "colModBCEnt"
        Me.colModBCEnt.OptionsColumn.ReadOnly = True
        Me.colModBCEnt.Visible = True
        Me.colModBCEnt.VisibleIndex = 24
        '
        'colRedBCEnt
        '
        Me.colRedBCEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBCEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBCEnt.Caption = "Red. BC Ent."
        Me.colRedBCEnt.FieldName = "RedBCEnt"
        Me.colRedBCEnt.Name = "colRedBCEnt"
        Me.colRedBCEnt.OptionsColumn.ReadOnly = True
        Me.colRedBCEnt.Visible = True
        Me.colRedBCEnt.VisibleIndex = 25
        '
        'colAliquotaICMSEnt
        '
        Me.colAliquotaICMSEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaICMSEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaICMSEnt.Caption = "Aliq. ICMS Ent."
        Me.colAliquotaICMSEnt.FieldName = "AliquotaICMSEnt"
        Me.colAliquotaICMSEnt.Name = "colAliquotaICMSEnt"
        Me.colAliquotaICMSEnt.OptionsColumn.ReadOnly = True
        Me.colAliquotaICMSEnt.Visible = True
        Me.colAliquotaICMSEnt.VisibleIndex = 26
        '
        'colValICMSEnt
        '
        Me.colValICMSEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMSEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMSEnt.Caption = "Val. ICMS Ent."
        Me.colValICMSEnt.FieldName = "ValICMSEnt"
        Me.colValICMSEnt.Name = "colValICMSEnt"
        Me.colValICMSEnt.OptionsColumn.ReadOnly = True
        Me.colValICMSEnt.Visible = True
        Me.colValICMSEnt.VisibleIndex = 27
        '
        'colModBCSTEnt
        '
        Me.colModBCSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colModBCSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModBCSTEnt.Caption = "Mod. BC ST Ent."
        Me.colModBCSTEnt.FieldName = "ModBCSTEnt"
        Me.colModBCSTEnt.Name = "colModBCSTEnt"
        Me.colModBCSTEnt.OptionsColumn.ReadOnly = True
        Me.colModBCSTEnt.Visible = True
        Me.colModBCSTEnt.VisibleIndex = 28
        '
        'colRedBCSTEnt
        '
        Me.colRedBCSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colRedBCSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRedBCSTEnt.Caption = "Red. BC ST Ent"
        Me.colRedBCSTEnt.FieldName = "RedBCSTEnt"
        Me.colRedBCSTEnt.Name = "colRedBCSTEnt"
        Me.colRedBCSTEnt.OptionsColumn.ReadOnly = True
        Me.colRedBCSTEnt.Visible = True
        Me.colRedBCSTEnt.VisibleIndex = 29
        '
        'colMVaSTEnt
        '
        Me.colMVaSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colMVaSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMVaSTEnt.Caption = "MVaST Ent."
        Me.colMVaSTEnt.FieldName = "MVaSTEnt"
        Me.colMVaSTEnt.Name = "colMVaSTEnt"
        Me.colMVaSTEnt.OptionsColumn.ReadOnly = True
        Me.colMVaSTEnt.Visible = True
        Me.colMVaSTEnt.VisibleIndex = 30
        '
        'colAliquotaICMSSTEnt
        '
        Me.colAliquotaICMSSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaICMSSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaICMSSTEnt.Caption = "Aliq. ICMS ST Ent."
        Me.colAliquotaICMSSTEnt.FieldName = "AliquotaICMSSTEnt"
        Me.colAliquotaICMSSTEnt.Name = "colAliquotaICMSSTEnt"
        Me.colAliquotaICMSSTEnt.OptionsColumn.ReadOnly = True
        Me.colAliquotaICMSSTEnt.Visible = True
        Me.colAliquotaICMSSTEnt.VisibleIndex = 31
        '
        'colValICMSSTEnt
        '
        Me.colValICMSSTEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMSSTEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMSSTEnt.Caption = "Val. ICMS ST Ent."
        Me.colValICMSSTEnt.FieldName = "ValICMSSTEnt"
        Me.colValICMSSTEnt.Name = "colValICMSSTEnt"
        Me.colValICMSSTEnt.OptionsColumn.ReadOnly = True
        Me.colValICMSSTEnt.Visible = True
        Me.colValICMSSTEnt.VisibleIndex = 32
        '
        'colCSTIPIEnt
        '
        Me.colCSTIPIEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTIPIEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTIPIEnt.Caption = "CST IPI Ent."
        Me.colCSTIPIEnt.FieldName = "CSTIPIEnt"
        Me.colCSTIPIEnt.Name = "colCSTIPIEnt"
        Me.colCSTIPIEnt.OptionsColumn.ReadOnly = True
        Me.colCSTIPIEnt.Visible = True
        Me.colCSTIPIEnt.VisibleIndex = 33
        '
        'colCodEnqEnt
        '
        Me.colCodEnqEnt.Caption = "Cód. Enq. Ent."
        Me.colCodEnqEnt.FieldName = "CodEnqEnt"
        Me.colCodEnqEnt.Name = "colCodEnqEnt"
        Me.colCodEnqEnt.OptionsColumn.ReadOnly = True
        Me.colCodEnqEnt.Visible = True
        Me.colCodEnqEnt.VisibleIndex = 34
        '
        'colAliquotaIPIEnt
        '
        Me.colAliquotaIPIEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaIPIEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaIPIEnt.Caption = "Aliq. IPI Ent."
        Me.colAliquotaIPIEnt.FieldName = "AliquotaIPIEnt"
        Me.colAliquotaIPIEnt.Name = "colAliquotaIPIEnt"
        Me.colAliquotaIPIEnt.OptionsColumn.ReadOnly = True
        Me.colAliquotaIPIEnt.Visible = True
        Me.colAliquotaIPIEnt.VisibleIndex = 35
        '
        'colValIPIEnt
        '
        Me.colValIPIEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValIPIEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValIPIEnt.Caption = "Val. IPI Ent."
        Me.colValIPIEnt.FieldName = "ValIPIEnt"
        Me.colValIPIEnt.Name = "colValIPIEnt"
        Me.colValIPIEnt.OptionsColumn.ReadOnly = True
        Me.colValIPIEnt.Visible = True
        Me.colValIPIEnt.VisibleIndex = 36
        '
        'colCSTPISEnt
        '
        Me.colCSTPISEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTPISEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTPISEnt.Caption = "CST PIS Ent."
        Me.colCSTPISEnt.FieldName = "CSTPISEnt"
        Me.colCSTPISEnt.Name = "colCSTPISEnt"
        Me.colCSTPISEnt.OptionsColumn.ReadOnly = True
        Me.colCSTPISEnt.Visible = True
        Me.colCSTPISEnt.VisibleIndex = 37
        '
        'colAliquotaPISEnt
        '
        Me.colAliquotaPISEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaPISEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaPISEnt.Caption = "Aliq. PIS Ent."
        Me.colAliquotaPISEnt.FieldName = "AliquotaPISEnt"
        Me.colAliquotaPISEnt.Name = "colAliquotaPISEnt"
        Me.colAliquotaPISEnt.OptionsColumn.ReadOnly = True
        Me.colAliquotaPISEnt.Visible = True
        Me.colAliquotaPISEnt.VisibleIndex = 38
        '
        'colValPISEnt
        '
        Me.colValPISEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValPISEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValPISEnt.Caption = "Val. PIS Ent."
        Me.colValPISEnt.FieldName = "ValPISEnt"
        Me.colValPISEnt.Name = "colValPISEnt"
        Me.colValPISEnt.OptionsColumn.ReadOnly = True
        Me.colValPISEnt.Visible = True
        Me.colValPISEnt.VisibleIndex = 39
        '
        'colCSTCOFINSEnt
        '
        Me.colCSTCOFINSEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTCOFINSEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTCOFINSEnt.Caption = "CST COFINS Ent."
        Me.colCSTCOFINSEnt.FieldName = "CSTCOFINSEnt"
        Me.colCSTCOFINSEnt.Name = "colCSTCOFINSEnt"
        Me.colCSTCOFINSEnt.OptionsColumn.ReadOnly = True
        Me.colCSTCOFINSEnt.Visible = True
        Me.colCSTCOFINSEnt.VisibleIndex = 40
        '
        'colAliquotaCOFINSEnt
        '
        Me.colAliquotaCOFINSEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquotaCOFINSEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquotaCOFINSEnt.Caption = "Aliq. COFINS Ent."
        Me.colAliquotaCOFINSEnt.FieldName = "AliquotaCOFINSEnt"
        Me.colAliquotaCOFINSEnt.Name = "colAliquotaCOFINSEnt"
        Me.colAliquotaCOFINSEnt.OptionsColumn.ReadOnly = True
        Me.colAliquotaCOFINSEnt.Visible = True
        Me.colAliquotaCOFINSEnt.VisibleIndex = 41
        '
        'colValCOFINSEnt
        '
        Me.colValCOFINSEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colValCOFINSEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValCOFINSEnt.Caption = "Val. COFINS Ent."
        Me.colValCOFINSEnt.FieldName = "ValCOFINSEnt"
        Me.colValCOFINSEnt.Name = "colValCOFINSEnt"
        Me.colValCOFINSEnt.OptionsColumn.ReadOnly = True
        Me.colValCOFINSEnt.Visible = True
        Me.colValCOFINSEnt.VisibleIndex = 42
        '
        'colCodigoANPEnt
        '
        Me.colCodigoANPEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoANPEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoANPEnt.Caption = "Cód. ANP Ent."
        Me.colCodigoANPEnt.FieldName = "CodigoANPEnt"
        Me.colCodigoANPEnt.Name = "colCodigoANPEnt"
        Me.colCodigoANPEnt.OptionsColumn.ReadOnly = True
        Me.colCodigoANPEnt.Visible = True
        Me.colCodigoANPEnt.VisibleIndex = 43
        '
        'colUFCombEnt
        '
        Me.colUFCombEnt.AppearanceCell.Options.UseTextOptions = True
        Me.colUFCombEnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUFCombEnt.Caption = "UF Comb. Ent."
        Me.colUFCombEnt.FieldName = "UFCombEnt"
        Me.colUFCombEnt.Name = "colUFCombEnt"
        Me.colUFCombEnt.OptionsColumn.ReadOnly = True
        Me.colUFCombEnt.Visible = True
        Me.colUFCombEnt.VisibleIndex = 44
        '
        'colValorCusto
        '
        Me.colValorCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colValorCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorCusto.Caption = "Val. Custo R$"
        Me.colValorCusto.FieldName = "ValorCusto"
        Me.colValorCusto.Name = "colValorCusto"
        Me.colValorCusto.OptionsColumn.ReadOnly = True
        Me.colValorCusto.Visible = True
        Me.colValorCusto.VisibleIndex = 9
        Me.colValorCusto.Width = 95
        '
        'colUMProd
        '
        Me.colUMProd.AppearanceCell.Options.UseTextOptions = True
        Me.colUMProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUMProd.Caption = "UM Prod."
        Me.colUMProd.FieldName = "UMProd"
        Me.colUMProd.Name = "colUMProd"
        Me.colUMProd.OptionsColumn.ReadOnly = True
        Me.colUMProd.Visible = True
        Me.colUMProd.VisibleIndex = 10
        '
        'colQtdProd
        '
        Me.colQtdProd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdProd.Caption = "Qtd Prod."
        Me.colQtdProd.FieldName = "QtdProd"
        Me.colQtdProd.Name = "colQtdProd"
        Me.colQtdProd.OptionsColumn.ReadOnly = True
        Me.colQtdProd.Visible = True
        Me.colQtdProd.VisibleIndex = 11
        '
        'colCest
        '
        Me.colCest.Caption = "CEST"
        Me.colCest.FieldName = "Cest"
        Me.colCest.Name = "colCest"
        Me.colCest.OptionsColumn.ReadOnly = True
        '
        'colVFCPSTEnt
        '
        Me.colVFCPSTEnt.Caption = "VFCPST Ent."
        Me.colVFCPSTEnt.FieldName = "VFCPSTEnt"
        Me.colVFCPSTEnt.Name = "colVFCPSTEnt"
        Me.colVFCPSTEnt.OptionsColumn.ReadOnly = True
        Me.colVFCPSTEnt.Visible = True
        Me.colVFCPSTEnt.VisibleIndex = 45
        '
        'chkDescontoItens
        '
        Me.chkDescontoItens.Location = New System.Drawing.Point(315, 2)
        Me.chkDescontoItens.Name = "chkDescontoItens"
        Me.chkDescontoItens.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDescontoItens.Properties.Appearance.Options.UseFont = True
        Me.chkDescontoItens.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDescontoItens.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.chkDescontoItens.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chkDescontoItens.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chkDescontoItens.Properties.Caption = "Desconto Itens"
        Me.chkDescontoItens.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDescontoItens.Size = New System.Drawing.Size(111, 19)
        Me.chkDescontoItens.TabIndex = 67
        '
        'chkEstoqueOK
        '
        Me.chkEstoqueOK.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TotalEntradaNFBindingSource, "EstoqueOK", True))
        Me.chkEstoqueOK.Location = New System.Drawing.Point(271, 37)
        Me.chkEstoqueOK.Name = "chkEstoqueOK"
        Me.chkEstoqueOK.Properties.Caption = "EstoqueOK"
        Me.chkEstoqueOK.Size = New System.Drawing.Size(74, 19)
        Me.chkEstoqueOK.TabIndex = 61
        '
        'TotalEntradaNFBindingSource
        '
        Me.TotalEntradaNFBindingSource.DataMember = "TotalEntradaNF"
        Me.TotalEntradaNFBindingSource.DataSource = Me.dsNano
        '
        'TotalEntradaNFGridControl
        '
        Me.TotalEntradaNFGridControl.DataSource = Me.TotalEntradaNFBindingSource
        Me.TotalEntradaNFGridControl.EmbeddedNavigator.Name = ""
        Me.TotalEntradaNFGridControl.Location = New System.Drawing.Point(211, 62)
        Me.TotalEntradaNFGridControl.MainView = Me.grd2
        Me.TotalEntradaNFGridControl.Name = "TotalEntradaNFGridControl"
        Me.TotalEntradaNFGridControl.Size = New System.Drawing.Size(188, 10)
        Me.TotalEntradaNFGridControl.TabIndex = 1
        Me.TotalEntradaNFGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo1, Me.colNumeroNF1, Me.colTotal, Me.colDescricao, Me.colData1, Me.colEstoqueOK, Me.colDesconto, Me.colTipo, Me.colSerie, Me.colValorFrete, Me.colValorSeguro, Me.colOutrasDespesas, Me.colICMS1, Me.colIPI1, Me.colCodFor, Me.colLote, Me.colCodConfigTot})
        Me.grd2.GridControl = Me.TotalEntradaNFGridControl
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colCodigo1
        '
        Me.colCodigo1.Caption = "Codigo"
        Me.colCodigo1.FieldName = "Codigo"
        Me.colCodigo1.Name = "colCodigo1"
        Me.colCodigo1.OptionsColumn.ReadOnly = True
        Me.colCodigo1.Visible = True
        Me.colCodigo1.VisibleIndex = 0
        '
        'colNumeroNF1
        '
        Me.colNumeroNF1.Caption = "NumeroNF"
        Me.colNumeroNF1.FieldName = "NumeroNF"
        Me.colNumeroNF1.Name = "colNumeroNF1"
        Me.colNumeroNF1.OptionsColumn.ReadOnly = True
        Me.colNumeroNF1.Visible = True
        Me.colNumeroNF1.VisibleIndex = 1
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 2
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Descricao"
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 3
        '
        'colData1
        '
        Me.colData1.Caption = "Data"
        Me.colData1.FieldName = "Data"
        Me.colData1.Name = "colData1"
        Me.colData1.OptionsColumn.ReadOnly = True
        Me.colData1.Visible = True
        Me.colData1.VisibleIndex = 4
        '
        'colEstoqueOK
        '
        Me.colEstoqueOK.Caption = "EstoqueOK"
        Me.colEstoqueOK.FieldName = "EstoqueOK"
        Me.colEstoqueOK.Name = "colEstoqueOK"
        Me.colEstoqueOK.OptionsColumn.ReadOnly = True
        Me.colEstoqueOK.Visible = True
        Me.colEstoqueOK.VisibleIndex = 5
        '
        'colDesconto
        '
        Me.colDesconto.Caption = "Desconto"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 6
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.OptionsColumn.ReadOnly = True
        Me.colTipo.Visible = True
        Me.colTipo.VisibleIndex = 7
        '
        'colSerie
        '
        Me.colSerie.Caption = "Serie"
        Me.colSerie.FieldName = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.OptionsColumn.ReadOnly = True
        Me.colSerie.Visible = True
        Me.colSerie.VisibleIndex = 8
        '
        'colValorFrete
        '
        Me.colValorFrete.Caption = "ValorFrete"
        Me.colValorFrete.FieldName = "ValorFrete"
        Me.colValorFrete.Name = "colValorFrete"
        Me.colValorFrete.OptionsColumn.ReadOnly = True
        Me.colValorFrete.Visible = True
        Me.colValorFrete.VisibleIndex = 9
        '
        'colValorSeguro
        '
        Me.colValorSeguro.Caption = "ValorSeguro"
        Me.colValorSeguro.FieldName = "ValorSeguro"
        Me.colValorSeguro.Name = "colValorSeguro"
        Me.colValorSeguro.OptionsColumn.ReadOnly = True
        Me.colValorSeguro.Visible = True
        Me.colValorSeguro.VisibleIndex = 10
        '
        'colOutrasDespesas
        '
        Me.colOutrasDespesas.Caption = "OutrasDespesas"
        Me.colOutrasDespesas.FieldName = "OutrasDespesas"
        Me.colOutrasDespesas.Name = "colOutrasDespesas"
        Me.colOutrasDespesas.OptionsColumn.ReadOnly = True
        Me.colOutrasDespesas.Visible = True
        Me.colOutrasDespesas.VisibleIndex = 11
        '
        'colICMS1
        '
        Me.colICMS1.Caption = "colICMS1"
        Me.colICMS1.FieldName = "ICMS"
        Me.colICMS1.Name = "colICMS1"
        Me.colICMS1.OptionsColumn.ReadOnly = True
        Me.colICMS1.Visible = True
        Me.colICMS1.VisibleIndex = 12
        '
        'colIPI1
        '
        Me.colIPI1.Caption = "colIPI"
        Me.colIPI1.FieldName = "IPI"
        Me.colIPI1.Name = "colIPI1"
        Me.colIPI1.OptionsColumn.ReadOnly = True
        Me.colIPI1.Visible = True
        Me.colIPI1.VisibleIndex = 13
        '
        'colCodFor
        '
        Me.colCodFor.Caption = "CodFor"
        Me.colCodFor.FieldName = "CodFor"
        Me.colCodFor.Name = "colCodFor"
        Me.colCodFor.OptionsColumn.ReadOnly = True
        Me.colCodFor.Visible = True
        Me.colCodFor.VisibleIndex = 14
        '
        'colLote
        '
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "Lote"
        Me.colLote.Name = "colLote"
        Me.colLote.OptionsColumn.ReadOnly = True
        Me.colLote.Visible = True
        Me.colLote.VisibleIndex = 15
        '
        'colCodConfigTot
        '
        Me.colCodConfigTot.Caption = "CodConfig"
        Me.colCodConfigTot.FieldName = "CodConfig"
        Me.colCodConfigTot.Name = "colCodConfigTot"
        Me.colCodConfigTot.OptionsColumn.ReadOnly = True
        Me.colCodConfigTot.Visible = True
        Me.colCodConfigTot.VisibleIndex = 16
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.FUNDO
        Me.picFundo.Location = New System.Drawing.Point(2, 20)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(1004, 124)
        Me.picFundo.TabIndex = 66
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtValTotProd)
        Me.GroupControl2.Controls.Add(Me.btnVincularProduto)
        Me.GroupControl2.Controls.Add(Me.btnEditarNfe)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.btnEditarNFeEntrada)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.txtDesc)
        Me.GroupControl2.Controls.Add(Me.txtValNota)
        Me.GroupControl2.Controls.Add(Me.txtValDesc)
        Me.GroupControl2.Controls.Add(Me.txtDesconto)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(2, 144)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1004, 55)
        Me.GroupControl2.TabIndex = 58
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(415, 1)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(126, 17)
        Me.LabelControl12.TabIndex = 71
        Me.LabelControl12.Text = "Total Produtos R$"
        '
        'txtValTotProd
        '
        Me.txtValTotProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValTotProd.EnterMoveNextControl = True
        Me.txtValTotProd.Location = New System.Drawing.Point(415, 22)
        Me.txtValTotProd.Name = "txtValTotProd"
        Me.txtValTotProd.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin
        Me.txtValTotProd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValTotProd.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValTotProd.Properties.Appearance.Options.UseBackColor = True
        Me.txtValTotProd.Properties.Appearance.Options.UseFont = True
        Me.txtValTotProd.Properties.Appearance.Options.UseForeColor = True
        Me.txtValTotProd.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValTotProd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValTotProd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValTotProd.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValTotProd.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValTotProd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValTotProd.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtValTotProd.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValTotProd.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Moccasin
        Me.txtValTotProd.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValTotProd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValTotProd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValTotProd.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValTotProd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValTotProd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValTotProd.Properties.MaxLength = 19
        Me.txtValTotProd.Properties.ReadOnly = True
        Me.txtValTotProd.Size = New System.Drawing.Size(146, 31)
        Me.txtValTotProd.TabIndex = 70
        Me.txtValTotProd.Tag = "Preço R$"
        '
        'btnVincularProduto
        '
        Me.btnVincularProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVincularProduto.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnVincularProduto.Appearance.Options.UseBackColor = True
        Me.btnVincularProduto.Image = Global.Nano.My.Resources.Resources.randr24x24
        Me.btnVincularProduto.Location = New System.Drawing.Point(7, 22)
        Me.btnVincularProduto.Name = "btnVincularProduto"
        Me.btnVincularProduto.Size = New System.Drawing.Size(130, 31)
        Me.btnVincularProduto.TabIndex = 69
        Me.btnVincularProduto.Text = "Vincular Produto"
        '
        'btnEditarNfe
        '
        Me.btnEditarNfe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarNfe.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarNfe.Appearance.Options.UseBackColor = True
        Me.btnEditarNfe.Enabled = False
        Me.btnEditarNfe.Image = Global.Nano.My.Resources.Resources.Alterar_18x18
        Me.btnEditarNfe.Location = New System.Drawing.Point(279, 22)
        Me.btnEditarNfe.Name = "btnEditarNfe"
        Me.btnEditarNfe.Size = New System.Drawing.Size(130, 31)
        Me.btnEditarNfe.TabIndex = 67
        Me.btnEditarNfe.Text = "Editar NF-e Saída"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(704, 1)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 17)
        Me.LabelControl8.TabIndex = 65
        Me.LabelControl8.Text = "Desconto R$"
        '
        'btnEditarNFeEntrada
        '
        Me.btnEditarNFeEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarNFeEntrada.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarNFeEntrada.Appearance.Options.UseBackColor = True
        Me.btnEditarNFeEntrada.Image = Global.Nano.My.Resources.Resources.Alterar_18x18
        Me.btnEditarNFeEntrada.Location = New System.Drawing.Point(143, 22)
        Me.btnEditarNFeEntrada.Name = "btnEditarNFeEntrada"
        Me.btnEditarNFeEntrada.Size = New System.Drawing.Size(130, 31)
        Me.btnEditarNFeEntrada.TabIndex = 68
        Me.btnEditarNFeEntrada.Text = "Editar NF-e Entrada"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(840, 1)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(117, 17)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = "Total da Nota R$"
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Appearance.Options.UseFont = True
        Me.txtDesc.Location = New System.Drawing.Point(568, 1)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(86, 17)
        Me.txtDesc.TabIndex = 63
        Me.txtDesc.Text = "Desconto %"
        '
        'txtValNota
        '
        Me.txtValNota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValNota.EnterMoveNextControl = True
        Me.txtValNota.Location = New System.Drawing.Point(839, 22)
        Me.txtValNota.Name = "txtValNota"
        Me.txtValNota.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtValNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValNota.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValNota.Properties.Appearance.Options.UseBackColor = True
        Me.txtValNota.Properties.Appearance.Options.UseFont = True
        Me.txtValNota.Properties.Appearance.Options.UseForeColor = True
        Me.txtValNota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValNota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValNota.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtValNota.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValNota.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValNota.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValNota.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValNota.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValNota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValNota.Properties.MaxLength = 19
        Me.txtValNota.Properties.ReadOnly = True
        Me.txtValNota.Size = New System.Drawing.Size(160, 31)
        Me.txtValNota.TabIndex = 4
        Me.txtValNota.Tag = "Preço R$"
        '
        'txtValDesc
        '
        Me.txtValDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValDesc.EditValue = ""
        Me.txtValDesc.EnterMoveNextControl = True
        Me.txtValDesc.Location = New System.Drawing.Point(703, 22)
        Me.txtValDesc.Name = "txtValDesc"
        Me.txtValDesc.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValDesc.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseFont = True
        Me.txtValDesc.Properties.Appearance.Options.UseForeColor = True
        Me.txtValDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValDesc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValDesc.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValDesc.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtValDesc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValDesc.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtValDesc.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtValDesc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtValDesc.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValDesc.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValDesc.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValDesc.Properties.MaxLength = 19
        Me.txtValDesc.Size = New System.Drawing.Size(130, 31)
        Me.txtValDesc.TabIndex = 64
        Me.txtValDesc.Tag = "Preço R$"
        '
        'txtDesconto
        '
        Me.txtDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesconto.EnterMoveNextControl = True
        Me.txtDesconto.Location = New System.Drawing.Point(567, 22)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtDesconto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseFont = True
        Me.txtDesconto.Properties.Appearance.Options.UseForeColor = True
        Me.txtDesconto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDesconto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesconto.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtDesconto.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtDesconto.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDesconto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtDesconto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtDesconto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDesconto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDesconto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesconto.Properties.MaxLength = 19
        Me.txtDesconto.Size = New System.Drawing.Size(130, 31)
        Me.txtDesconto.TabIndex = 62
        Me.txtDesconto.Tag = "Preço R$"
        '
        'chkImpostoItens
        '
        Me.chkImpostoItens.Location = New System.Drawing.Point(856, 38)
        Me.chkImpostoItens.Name = "chkImpostoItens"
        Me.chkImpostoItens.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkImpostoItens.Properties.Appearance.Options.UseFont = True
        Me.chkImpostoItens.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkImpostoItens.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.chkImpostoItens.Properties.AppearanceDisabled.Options.UseFont = True
        Me.chkImpostoItens.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.chkImpostoItens.Properties.Caption = "Imposto nos Itens"
        Me.chkImpostoItens.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpostoItens.Size = New System.Drawing.Size(127, 19)
        Me.chkImpostoItens.TabIndex = 129
        '
        'EntradaNFBindingSource
        '
        Me.EntradaNFBindingSource.DataMember = "EntradaNF"
        Me.EntradaNFBindingSource.DataSource = Me.dsNano
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnExcluir, Me.btnCanNota, Me.btnConPagar, Me.btnEtiq, Me.btnNfe, Me.txtValVendaPorc, Me.btnAddValor, Me.btnXML})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.txtValVendaPor})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEtiq, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnConPagar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnNfe, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnXML, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.txtValVendaPorc, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAddValor, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCanNota, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'btnEtiq
        '
        Me.btnEtiq.Caption = "Etiquetas"
        Me.btnEtiq.Glyph = Global.Nano.My.Resources.Resources.Print24
        Me.btnEtiq.Id = 6
        Me.btnEtiq.Name = "btnEtiq"
        '
        'btnConPagar
        '
        Me.btnConPagar.Caption = "&Gerar Conta Pagar"
        Me.btnConPagar.Glyph = Global.Nano.My.Resources.Resources.cash_registerx
        Me.btnConPagar.Id = 5
        Me.btnConPagar.Name = "btnConPagar"
        Me.btnConPagar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnNfe
        '
        Me.btnNfe.Caption = "&Abrir XML"
        Me.btnNfe.Glyph = Global.Nano.My.Resources.Resources.XML24
        Me.btnNfe.Id = 7
        Me.btnNfe.Name = "btnNfe"
        Me.btnNfe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnXML
        '
        Me.btnXML.Caption = "&Baixar XML"
        Me.btnXML.Glyph = Global.Nano.My.Resources.Resources.Download_2
        Me.btnXML.Id = 12
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'txtValVendaPorc
        '
        Me.txtValVendaPorc.Caption = "Marg. Lucro %"
        Me.txtValVendaPorc.Edit = Me.txtValVendaPor
        Me.txtValVendaPorc.Id = 9
        Me.txtValVendaPorc.Name = "txtValVendaPorc"
        Me.txtValVendaPorc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'txtValVendaPor
        '
        Me.txtValVendaPor.Appearance.Options.UseTextOptions = True
        Me.txtValVendaPor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValVendaPor.AutoHeight = False
        Me.txtValVendaPor.Name = "txtValVendaPor"
        '
        'btnAddValor
        '
        Me.btnAddValor.Caption = "Inserir Margem"
        Me.btnAddValor.Glyph = Global.Nano.My.Resources.Resources.Porcentagem2
        Me.btnAddValor.Id = 10
        Me.btnAddValor.Name = "btnAddValor"
        Me.btnAddValor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
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
        'btnCanNota
        '
        Me.btnCanNota.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCanNota.Caption = "&Cancelar Nota Fiscal"
        Me.btnCanNota.Id = 4
        Me.btnCanNota.Name = "btnCanNota"
        Me.btnCanNota.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.txtObs)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 409)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1008, 52)
        Me.GroupControl3.TabIndex = 10
        Me.GroupControl3.Text = "Observações"
        '
        'txtObs
        '
        Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObs.Location = New System.Drawing.Point(2, 20)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Properties.Appearance.Options.UseFont = True
        Me.txtObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Size = New System.Drawing.Size(1004, 30)
        Me.txtObs.TabIndex = 0
        '
        'TotalEntradaNFTableAdapter
        '
        Me.TotalEntradaNFTableAdapter.ClearBeforeFill = True
        '
        'EntradaNFTableAdapter
        '
        Me.EntradaNFTableAdapter.ClearBeforeFill = True
        '
        'txtSerie
        '
        Me.txtSerie.EnterMoveNextControl = True
        Me.txtSerie.Location = New System.Drawing.Point(250, 12)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Properties.Appearance.Options.UseFont = True
        Me.txtSerie.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSerie.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSerie.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSerie.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSerie.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSerie.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSerie.Properties.MaxLength = 3
        Me.txtSerie.Size = New System.Drawing.Size(60, 20)
        Me.txtSerie.TabIndex = 1
        Me.txtSerie.Tag = "Série"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(220, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 93
        Me.LabelControl4.Text = "Série"
        '
        'cboTipo
        '
        Me.cboTipo.EnterMoveNextControl = True
        Me.cboTipo.Location = New System.Drawing.Point(352, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.Properties.Appearance.Options.UseFont = True
        Me.cboTipo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.cboTipo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cboTipo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cboTipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Properties.Items.AddRange(New Object() {"N", "F"})
        Me.cboTipo.Properties.MaxLength = 1
        Me.cboTipo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipo.Size = New System.Drawing.Size(60, 20)
        Me.cboTipo.TabIndex = 2
        Me.cboTipo.Tag = "Tipo"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(326, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl5.TabIndex = 96
        Me.LabelControl5.Text = "Tipo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(22, 113)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl6.TabIndex = 98
        Me.LabelControl6.Text = "Valores"
        '
        'PanelControl2
        '
        Me.PanelControl2.Location = New System.Drawing.Point(6, 119)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(997, 5)
        Me.PanelControl2.TabIndex = 97
        '
        'txFrete
        '
        Me.txFrete.EnterMoveNextControl = True
        Me.txFrete.Location = New System.Drawing.Point(87, 133)
        Me.txFrete.Name = "txFrete"
        Me.txFrete.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txFrete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txFrete.Properties.Appearance.Options.UseBackColor = True
        Me.txFrete.Properties.Appearance.Options.UseFont = True
        Me.txFrete.Properties.Appearance.Options.UseTextOptions = True
        Me.txFrete.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txFrete.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txFrete.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txFrete.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txFrete.Properties.MaxLength = 19
        Me.txFrete.Size = New System.Drawing.Size(106, 20)
        Me.txFrete.TabIndex = 6
        Me.txFrete.Tag = "Valor Frete R$"
        Me.txFrete.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtSeguro
        '
        Me.txtSeguro.EnterMoveNextControl = True
        Me.txtSeguro.Location = New System.Drawing.Point(250, 133)
        Me.txtSeguro.Name = "txtSeguro"
        Me.txtSeguro.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSeguro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguro.Properties.Appearance.Options.UseBackColor = True
        Me.txtSeguro.Properties.Appearance.Options.UseFont = True
        Me.txtSeguro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSeguro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSeguro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSeguro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSeguro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeguro.Properties.MaxLength = 19
        Me.txtSeguro.Size = New System.Drawing.Size(162, 20)
        Me.txtSeguro.TabIndex = 7
        Me.txtSeguro.Tag = "Valor Seguro R$"
        Me.txtSeguro.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtDespesas
        '
        Me.txtDespesas.EnterMoveNextControl = True
        Me.txtDespesas.Location = New System.Drawing.Point(496, 133)
        Me.txtDespesas.Name = "txtDespesas"
        Me.txtDespesas.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDespesas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespesas.Properties.Appearance.Options.UseBackColor = True
        Me.txtDespesas.Properties.Appearance.Options.UseFont = True
        Me.txtDespesas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDespesas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDespesas.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDespesas.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDespesas.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDespesas.Properties.MaxLength = 19
        Me.txtDespesas.Size = New System.Drawing.Size(114, 20)
        Me.txtDespesas.TabIndex = 8
        Me.txtDespesas.Tag = "Outras Desp. Aces. R$"
        Me.txtDespesas.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtIPI
        '
        Me.txtIPI.EnterMoveNextControl = True
        Me.txtIPI.Location = New System.Drawing.Point(679, 133)
        Me.txtIPI.Name = "txtIPI"
        Me.txtIPI.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIPI.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPI.Properties.Appearance.Options.UseBackColor = True
        Me.txtIPI.Properties.Appearance.Options.UseFont = True
        Me.txtIPI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIPI.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIPI.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtIPI.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtIPI.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtIPI.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIPI.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIPI.Properties.MaxLength = 19
        Me.txtIPI.Size = New System.Drawing.Size(114, 20)
        Me.txtIPI.TabIndex = 9
        Me.txtIPI.Tag = "IPI"
        Me.txtIPI.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtICMS
        '
        Me.txtICMS.EnterMoveNextControl = True
        Me.txtICMS.Location = New System.Drawing.Point(873, 134)
        Me.txtICMS.Name = "txtICMS"
        Me.txtICMS.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtICMS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICMS.Properties.Appearance.Options.UseBackColor = True
        Me.txtICMS.Properties.Appearance.Options.UseFont = True
        Me.txtICMS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtICMS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtICMS.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtICMS.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtICMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtICMS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtICMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtICMS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtICMS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtICMS.Properties.MaxLength = 19
        Me.txtICMS.Size = New System.Drawing.Size(109, 20)
        Me.txtICMS.TabIndex = 10
        Me.txtICMS.Tag = "ICMS"
        Me.txtICMS.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'txtFor
        '
        Me.txtFor.EnterMoveNextControl = True
        Me.txtFor.Location = New System.Drawing.Point(87, 87)
        Me.txtFor.Name = "txtFor"
        Me.txtFor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFor.Properties.Appearance.Options.UseFont = True
        Me.txtFor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtFor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFor.Size = New System.Drawing.Size(523, 20)
        Me.txtFor.TabIndex = 5
        '
        'ofdArquivo
        '
        Me.ofdArquivo.FileName = "OpenFileDialog1"
        '
        'lblValIPI
        '
        Me.lblValIPI.Location = New System.Drawing.Point(643, 136)
        Me.lblValIPI.Name = "lblValIPI"
        Me.lblValIPI.Size = New System.Drawing.Size(30, 13)
        Me.lblValIPI.TabIndex = 110
        Me.lblValIPI.Text = "IPI R$"
        '
        'lblValICMS
        '
        Me.lblValICMS.Location = New System.Drawing.Point(811, 137)
        Me.lblValICMS.Name = "lblValICMS"
        Me.lblValICMS.Size = New System.Drawing.Size(56, 13)
        Me.lblValICMS.TabIndex = 111
        Me.lblValICMS.Text = "ICMS ST R$"
        '
        'lblPorICMS
        '
        Me.lblPorICMS.Location = New System.Drawing.Point(634, 15)
        Me.lblPorICMS.Name = "lblPorICMS"
        Me.lblPorICMS.Size = New System.Drawing.Size(39, 13)
        Me.lblPorICMS.TabIndex = 138
        Me.lblPorICMS.Text = "ICMS %"
        '
        'txtPorICMS
        '
        Me.txtPorICMS.EnterMoveNextControl = True
        Me.txtPorICMS.Location = New System.Drawing.Point(679, 12)
        Me.txtPorICMS.Name = "txtPorICMS"
        Me.txtPorICMS.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPorICMS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorICMS.Properties.Appearance.Options.UseBackColor = True
        Me.txtPorICMS.Properties.Appearance.Options.UseFont = True
        Me.txtPorICMS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorICMS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPorICMS.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPorICMS.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPorICMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtPorICMS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtPorICMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPorICMS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPorICMS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorICMS.Properties.MaxLength = 19
        Me.txtPorICMS.Size = New System.Drawing.Size(111, 20)
        Me.txtPorICMS.TabIndex = 10
        Me.txtPorICMS.Tag = "ICMS"
        Me.txtPorICMS.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'btnConsultar
        '
        Me.btnConsultar.Enabled = False
        Me.btnConsultar.EnterMoveNextControl = True
        Me.btnConsultar.Location = New System.Drawing.Point(169, 12)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Properties.Appearance.Options.UseFont = True
        Me.btnConsultar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConsultar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.btnConsultar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.btnConsultar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.btnConsultar.Size = New System.Drawing.Size(24, 20)
        Me.btnConsultar.TabIndex = 142
        '
        'txtCodPed
        '
        Me.txtCodPed.EnterMoveNextControl = True
        Me.txtCodPed.Location = New System.Drawing.Point(496, 12)
        Me.txtCodPed.Name = "txtCodPed"
        Me.txtCodPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPed.Properties.Appearance.Options.UseFont = True
        Me.txtCodPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodPed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPed.Size = New System.Drawing.Size(91, 20)
        Me.txtCodPed.TabIndex = 3
        Me.txtCodPed.Tag = "Nº NF"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(443, 15)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl11.TabIndex = 149
        Me.LabelControl11.Text = "Nº Pedido"
        '
        'btnConPed
        '
        Me.btnConPed.EnterMoveNextControl = True
        Me.btnConPed.Location = New System.Drawing.Point(586, 12)
        Me.btnConPed.Name = "btnConPed"
        Me.btnConPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConPed.Properties.Appearance.Options.UseFont = True
        Me.btnConPed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConPed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.btnConPed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.btnConPed.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.btnConPed.Size = New System.Drawing.Size(24, 20)
        Me.btnConPed.TabIndex = 148
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.grpProd)
        Me.PanelControl3.Controls.Add(Me.grpConta)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Location = New System.Drawing.Point(0, 165)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1008, 461)
        Me.PanelControl3.TabIndex = 151
        '
        'grpConta
        '
        Me.grpConta.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConta.AppearanceCaption.Options.UseFont = True
        Me.grpConta.Controls.Add(Me.btnCenCus)
        Me.grpConta.Controls.Add(Me.cboCenCus)
        Me.grpConta.Controls.Add(Label12)
        Me.grpConta.Controls.Add(Me.cboTipCus)
        Me.grpConta.Controls.Add(Label10)
        Me.grpConta.Controls.Add(Me.cboTipConta)
        Me.grpConta.Controls.Add(TipoContaLabel)
        Me.grpConta.Controls.Add(Me.lblDias)
        Me.grpConta.Controls.Add(Me.txtDias)
        Me.grpConta.Controls.Add(Me.lblVenc)
        Me.grpConta.Controls.Add(Me.dtVenc)
        Me.grpConta.Controls.Add(Me.lblNumPar)
        Me.grpConta.Controls.Add(Me.seParcela)
        Me.grpConta.Controls.Add(FormaPagamentoLabel1)
        Me.grpConta.Controls.Add(Me.GridControl1)
        Me.grpConta.Controls.Add(Me.luePag)
        Me.grpConta.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpConta.Location = New System.Drawing.Point(0, 309)
        Me.grpConta.Name = "grpConta"
        Me.grpConta.Size = New System.Drawing.Size(1008, 100)
        Me.grpConta.TabIndex = 141
        Me.grpConta.Text = "Conta Pagar"
        Me.grpConta.Visible = False
        '
        'btnCenCus
        '
        Me.btnCenCus.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCenCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCenCus.Location = New System.Drawing.Point(481, 23)
        Me.btnCenCus.Name = "btnCenCus"
        Me.btnCenCus.Size = New System.Drawing.Size(20, 20)
        Me.btnCenCus.TabIndex = 154
        Me.btnCenCus.Text = "SimpleButton1"
        '
        'cboCenCus
        '
        Me.cboCenCus.EnterMoveNextControl = True
        Me.cboCenCus.Location = New System.Drawing.Point(336, 23)
        Me.cboCenCus.Name = "cboCenCus"
        Me.cboCenCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCenCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCenCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCenCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCenCus.Size = New System.Drawing.Size(145, 20)
        Me.cboCenCus.TabIndex = 1
        Me.cboCenCus.Tag = "Centro de Custo"
        '
        'cboTipCus
        '
        Me.cboTipCus.EnterMoveNextControl = True
        Me.cboTipCus.Location = New System.Drawing.Point(109, 49)
        Me.cboTipCus.Name = "cboTipCus"
        Me.cboTipCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipCus.Properties.Items.AddRange(New Object() {"F", "V", "C"})
        Me.cboTipCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipCus.Size = New System.Drawing.Size(121, 20)
        Me.cboTipCus.TabIndex = 2
        Me.cboTipCus.Tag = "Forma Pagamento"
        '
        'cboTipConta
        '
        Me.cboTipConta.EnterMoveNextControl = True
        Me.cboTipConta.Location = New System.Drawing.Point(109, 23)
        Me.cboTipConta.Name = "cboTipConta"
        Me.cboTipConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipConta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipConta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipConta.Properties.MaxLength = 24
        Me.cboTipConta.Size = New System.Drawing.Size(121, 20)
        Me.cboTipConta.TabIndex = 0
        Me.cboTipConta.Tag = "Tipo de Conta"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(288, 78)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(42, 13)
        Me.lblDias.TabIndex = 147
        Me.lblDias.Text = "Nº Dias"
        '
        'txtDias
        '
        Me.txtDias.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDias.EnterMoveNextControl = True
        Me.txtDias.Location = New System.Drawing.Point(336, 75)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDias.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDias.Properties.MaxLength = 2
        Me.txtDias.Size = New System.Drawing.Size(52, 20)
        Me.txtDias.TabIndex = 5
        Me.txtDias.Tag = "Nº Dias"
        '
        'lblVenc
        '
        Me.lblVenc.AutoSize = True
        Me.lblVenc.Location = New System.Drawing.Point(27, 78)
        Me.lblVenc.Name = "lblVenc"
        Me.lblVenc.Size = New System.Drawing.Size(76, 13)
        Me.lblVenc.TabIndex = 145
        Me.lblVenc.Text = "1º Vencimento"
        '
        'dtVenc
        '
        Me.dtVenc.EditValue = Nothing
        Me.dtVenc.EnterMoveNextControl = True
        Me.dtVenc.Location = New System.Drawing.Point(109, 75)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtVenc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtVenc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVenc.Properties.Mask.IgnoreMaskBlank = False
        Me.dtVenc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVenc.Size = New System.Drawing.Size(121, 20)
        Me.dtVenc.TabIndex = 4
        Me.dtVenc.Tag = "Vencimento"
        '
        'lblNumPar
        '
        Me.lblNumPar.AutoSize = True
        Me.lblNumPar.Location = New System.Drawing.Point(396, 78)
        Me.lblNumPar.Name = "lblNumPar"
        Me.lblNumPar.Size = New System.Drawing.Size(47, 13)
        Me.lblNumPar.TabIndex = 143
        Me.lblNumPar.Text = "Nº Parc."
        '
        'seParcela
        '
        Me.seParcela.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seParcela.EnterMoveNextControl = True
        Me.seParcela.Location = New System.Drawing.Point(449, 75)
        Me.seParcela.Name = "seParcela"
        Me.seParcela.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seParcela.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.seParcela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seParcela.Properties.MaxLength = 2
        Me.seParcela.Size = New System.Drawing.Size(52, 20)
        Me.seParcela.TabIndex = 6
        Me.seParcela.Tag = "Nº Parcelas"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbContaPagar"
        Me.GridControl1.DataSource = Me.dsEntrada
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(509, 20)
        Me.GridControl1.MainView = Me.grd3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.txtValorParcela})
        Me.GridControl1.Size = New System.Drawing.Size(497, 78)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'grd3
        '
        Me.grd3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grd3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd3.Appearance.Row.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.Row.Options.UseBackColor = True
        Me.grd3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.grd3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParcela, Me.colValorParcela, Me.colVencimento, Me.colValorConta})
        Me.grd3.GridControl = Me.GridControl1
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.Caption = "Parcela"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.ReadOnly = True
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        '
        'colValorParcela
        '
        Me.colValorParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorParcela.Caption = "Valor Parcela R$"
        Me.colValorParcela.ColumnEdit = Me.txtValorParcela
        Me.colValorParcela.FieldName = "ValorParcela"
        Me.colValorParcela.Name = "colValorParcela"
        Me.colValorParcela.Visible = True
        Me.colValorParcela.VisibleIndex = 1
        '
        'txtValorParcela
        '
        Me.txtValorParcela.AutoHeight = False
        Me.txtValorParcela.Name = "txtValorParcela"
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 2
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colValorConta
        '
        Me.colValorConta.AppearanceCell.Options.UseTextOptions = True
        Me.colValorConta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorConta.Caption = "Valor Conta R$"
        Me.colValorConta.FieldName = "ValorConta"
        Me.colValorConta.Name = "colValorConta"
        Me.colValorConta.OptionsColumn.ReadOnly = True
        '
        'luePag
        '
        Me.luePag.EnterMoveNextControl = True
        Me.luePag.Location = New System.Drawing.Point(336, 49)
        Me.luePag.Name = "luePag"
        Me.luePag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.luePag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.luePag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luePag.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormaPagamento", "Pagamento", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luePag.Properties.DisplayMember = "Descricao"
        Me.luePag.Properties.NullText = ""
        Me.luePag.Properties.ValueMember = "Descricao"
        Me.luePag.Size = New System.Drawing.Size(165, 20)
        Me.luePag.TabIndex = 3
        Me.luePag.Tag = "Forma Pagamento"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'txtChave
        '
        Me.txtChave.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FornecedorBindingSource, "CPF", True))
        Me.txtChave.Location = New System.Drawing.Point(87, 38)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChave.Properties.Appearance.Options.UseFont = True
        Me.txtChave.Properties.Appearance.Options.UseTextOptions = True
        Me.txtChave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtChave.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChave.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtChave.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtChave.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtChave.Properties.MaxLength = 44
        Me.txtChave.Size = New System.Drawing.Size(325, 20)
        Me.txtChave.TabIndex = 152
        '
        'colFreteEnt
        '
        Me.colFreteEnt.Caption = "Frete Ent."
        Me.colFreteEnt.FieldName = "FreteEnt"
        Me.colFreteEnt.Name = "colFreteEnt"
        Me.colFreteEnt.OptionsColumn.ReadOnly = True
        Me.colFreteEnt.Visible = True
        Me.colFreteEnt.VisibleIndex = 46
        '
        'colDespesasEnt
        '
        Me.colDespesasEnt.Caption = "Despesas Ent."
        Me.colDespesasEnt.FieldName = "DespesasEnt"
        Me.colDespesasEnt.Name = "colDespesasEnt"
        Me.colDespesasEnt.OptionsColumn.ReadOnly = True
        Me.colDespesasEnt.Visible = True
        Me.colDespesasEnt.VisibleIndex = 47
        '
        'colSeguroEnt
        '
        Me.colSeguroEnt.Caption = "Seguro Ent."
        Me.colSeguroEnt.FieldName = "SeguroEnt"
        Me.colSeguroEnt.Name = "colSeguroEnt"
        Me.colSeguroEnt.OptionsColumn.ReadOnly = True
        Me.colSeguroEnt.Visible = True
        Me.colSeguroEnt.VisibleIndex = 48
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "FreteEnt"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "DespesasEnt"
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "SeguroEnt"
        '
        'frmEntradaNF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.chkImpostoItens)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtChave)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.txtCodPed)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.btnConPed)
        Me.Controls.Add(Me.lblPorICMS)
        Me.Controls.Add(Me.lblValIPI)
        Me.Controls.Add(Me.txtPorICMS)
        Me.Controls.Add(Me.lblValICMS)
        Me.Controls.Add(Me.txtFor)
        Me.Controls.Add(Me.txtICMS)
        Me.Controls.Add(Me.txtIPI)
        Me.Controls.Add(Me.txtDespesas)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtSeguro)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txFrete)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.txtNF)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmEntradaNF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Nota Fiscal"
        CType(Me.txtNF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProd.ResumeLayout(False)
        Me.grpProd.PerformLayout()
        CType(Me.txtQtdProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUniMed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProdFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodBarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtICMSItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIPIItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueHis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaNFBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMVaST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.EntradaNFGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbContaPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDescontoItens.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstoqueOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalEntradaNFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalEntradaNFGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtValTotProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpostoItens.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradaNFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValVendaPor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txFrete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDespesas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtICMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorICMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConsultar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpConta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConta.ResumeLayout(False)
        Me.grpConta.PerformLayout()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luePag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dsNano As Nano.dsNano
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As Nano.dsNanoTableAdapters.FornecedorTableAdapter
    Friend WithEvents txtCPF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpProd As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TotalEntradaNFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalEntradaNFTableAdapter As Nano.dsNanoTableAdapters.TotalEntradaNFTableAdapter
    Friend WithEvents TotalEntradaNFGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroNF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EntradaNFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradaNFTableAdapter As Nano.dsNanoTableAdapters.EntradaNFTableAdapter
    Friend WithEvents EntradaNFGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtValNota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCodPro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents colEstoqueOK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCanNota As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkEstoqueOK As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnConPagar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCodProdInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNomePro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueHis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EntradaNFBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDesconto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDespesas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSeguro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txFrete As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorFrete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorSeguro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutrasDespesas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPerDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colDescontoNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtICMS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIPI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitarioImposto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMS1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtQtd As Campos.NanoCampo
    Friend WithEvents colCodFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodTotNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTam As Campos.NanoCampo
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkTamanho As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblLoja As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLoja As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfigTot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsEntrada As System.Data.DataSet
    Friend WithEvents tbEntrada As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents btnEtiq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPor1 As Campos.NanoCampo
    Friend WithEvents txtVal As Campos.NanoCampo
    Friend WithEvents lblPor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVenda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colValProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ofdArquivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbFor As System.Data.DataTable
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents colUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNfe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents colNCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidTrib As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValTrib As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdTrib As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculoCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIcmsNfe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVaST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIcmsST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCadSet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSet As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCadGrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboGrp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtValVendaPorc As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txtValVendaPor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnAddValor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents colCodProdFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtICMSItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIPIItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblICMS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblIPI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValIPI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValICMS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorICMS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorICMS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMVaST As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMVaST As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoProduto As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents colTipoProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtCodBarra As Campos.NanoCampo
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkDescontoItens As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colCSTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodEnq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditarNfe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents colCodigoANP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUFComb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnEditarNFeEntrada As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCFOPEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCMEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegimeEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigemEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalculoCredEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCredEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaICMSEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMSEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModBCSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRedBCSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMVaSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaICMSSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMSSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTIPIEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodEnqEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaIPIEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValIPIEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTPISEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaPISEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValPISEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTCOFINSEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquotaCOFINSEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValCOFINSEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoANPEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUFCombEnt As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents txtCodProdFor As Campos.NanoCampo
    Friend WithEvents lblCodProdFor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorCusto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents colValorCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtQtdProd As Campos.NanoCampo
    Friend WithEvents lblConv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUniMed As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents colUMProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblQtdProd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents txtCodPed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConPed As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tbContaPagar As System.Data.DataTable
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents grpConta As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents txtDias As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblVenc As System.Windows.Forms.Label
    Friend WithEvents dtVenc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblNumPar As System.Windows.Forms.Label
    Friend WithEvents seParcela As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtValorParcela As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colValorConta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luePag As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVincularProduto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTipConta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboTipCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCenCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCenCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtChave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValTotProd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkImpostoItens As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colVFCPSTEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents colFreteEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDespesasEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeguroEnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
End Class
