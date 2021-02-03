<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim Label15 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colInadimplente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInativo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProtestado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem()
        Me.cboModelo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnAddEtiq = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.btnEti = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEtiquetaGeral = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.btnRelCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRelCli = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQtdCli = New DevExpress.XtraEditors.TextEdit()
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton()
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClienteGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRGIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCelular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservacao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNascimento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLimite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMarcas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPessoa1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPessoa2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRG1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRG2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTempoTrabalho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoradia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeConjuge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelConjuge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomePais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSuframa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesconto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContaCorrente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodFunc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnderecoEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplementoEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairroEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCepEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCidadeEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnVisualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkInativar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtObs = New DevExpress.XtraEditors.MemoEdit()
        Me.chkIna = New DevExpress.XtraEditors.CheckEdit()
        Me.tbbCli = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPrincipal = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtBairro = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnCadBairro = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCidade = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtComp = New Campos.NanoCampo()
        Me.txtNum = New Campos.NanoCampo()
        Me.txtCep = New Campos.NanoCampo()
        Me.txtEnd = New Campos.NanoCampo()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnCadBairro2 = New DevExpress.XtraEditors.SimpleButton()
        Me.NanoCampo1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.NanoCampo2 = New Campos.NanoCampo()
        Me.NanoCampo3 = New Campos.NanoCampo()
        Me.NanoCampo4 = New Campos.NanoCampo()
        Me.NanoCampo5 = New Campos.NanoCampo()
        Me.txtContato = New Campos.NanoCampo()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.nbcImagem = New DevExpress.XtraNavBar.NavBarControl()
        Me.nbgImagem = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.picCod = New DevExpress.XtraEditors.PictureEdit()
        Me.btnCarregar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTirar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOcultar = New DevExpress.XtraEditors.SimpleButton()
        Me.picImagem = New DevExpress.XtraEditors.PictureEdit()
        Me.btnConCPF = New DevExpress.XtraEditors.SimpleButton()
        Me.chkIsento = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFant = New Campos.NanoCampo()
        Me.txtTel3 = New Campos.NanoCampo()
        Me.txtTel1 = New Campos.NanoCampo()
        Me.txtTel2 = New Campos.NanoCampo()
        Me.txtWeb = New Campos.NanoCampo()
        Me.txtNome = New Campos.NanoCampo()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.chkCPF = New DevExpress.XtraEditors.CheckEdit()
        Me.cboSexo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtNasc = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cboStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCPF = New Campos.NanoCampo()
        Me.txtRGIE = New Campos.NanoCampo()
        Me.txtPerDesc = New DevExpress.XtraEditors.TextEdit()
        Me.txtMarcas = New Campos.NanoCampo()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.lueCodFunc = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl()
        Me.tabComp = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBanco = New Campos.NanoCampo()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.txtContaCorrente = New Campos.NanoCampo()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgencia = New Campos.NanoCampo()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelConj = New Campos.NanoCampo()
        Me.txtNomeConj = New Campos.NanoCampo()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.cboMor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTempTra = New Campos.NanoCampo()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRG2 = New Campos.NanoCampo()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRG1 = New Campos.NanoCampo()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPessoa2 = New Campos.NanoCampo()
        Me.txtPessoa1 = New Campos.NanoCampo()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtEmp = New Campos.NanoCampo()
        Me.txtTelEmp = New Campos.NanoCampo()
        Me.txtSal = New Campos.NanoCampo()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiasEmAtraso = New Campos.NanoCampo()
        Me.btnConsumo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRelVendas = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLimCli = New Campos.NanoCampo()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSalDev = New Campos.NanoCampo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumCom = New Campos.NanoCampo()
        Me.txtdtCad = New Campos.NanoCampo()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotalGasto = New System.Windows.Forms.Label()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalGasto = New Campos.NanoCampo()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCred = New System.Windows.Forms.Label()
        Me.txtUltVis = New Campos.NanoCampo()
        Me.txtCredito = New Campos.NanoCampo()
        Me.txtLimite = New Campos.NanoCampo()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.tabNFE = New DevExpress.XtraTab.XtraTabPage()
        Me.txtSuframa = New Campos.NanoCampo()
        Me.txtCodPais = New Campos.NanoCampo()
        Me.txtCodMun = New Campos.NanoCampo()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPais = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ClienteTableAdapter = New Nano.dsNanoCommerceTableAdapters.ClienteTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tbbCliente = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCliente = New DevExpress.XtraTab.XtraTabPage()
        Me.tabVeiculo = New DevExpress.XtraTab.XtraTabPage()
        Me.tab = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPri = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCli = New DevExpress.XtraEditors.ButtonEdit()
        Me.chkCli = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.txtKMMes = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCha = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMod = New DevExpress.XtraEditors.TextEdit()
        Me.txtVal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCil = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMot = New DevExpress.XtraEditors.TextEdit()
        Me.txtKM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.cboComb = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.cboFab = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.tabOpc = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl()
        Me.lstItens = New DevExpress.XtraEditors.ListBoxControl()
        Me.btnRemTudo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRem = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.lstOpc = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.tabImagem = New DevExpress.XtraTab.XtraTabPage()
        Me.btnImagem6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImagem5 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImagem4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImagem3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImagem2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImagem1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem2 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem3 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem5 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem6 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem4 = New DevExpress.XtraEditors.PictureEdit()
        Me.picImagem1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.CarroGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustivel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMotor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCilindros = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValvulas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChassi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpcionais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKMMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Label15 = New System.Windows.Forms.Label()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtQtdCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbbCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbbCli.SuspendLayout()
        Me.tabPrincipal.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoCampo5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbcImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nbcImagem.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.picCod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRGIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCodFunc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabComp.SuspendLayout()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelConj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeConj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTempTra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRG2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRG1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPessoa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPessoa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtDiasEmAtraso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtCad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalGasto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUltVis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNFE.SuspendLayout()
        CType(Me.txtSuframa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbbCliente.SuspendLayout()
        Me.tabCliente.SuspendLayout()
        Me.tabVeiculo.SuspendLayout()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabPri.SuspendLayout()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKMMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboComb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOpc.SuspendLayout()
        CType(Me.lstItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstOpc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImagem.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.CarroGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(875, 245)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(60, 17)
        Label15.TabIndex = 127
        Label15.Text = "Desc. %"
        '
        'colInadimplente
        '
        Me.colInadimplente.Caption = "Pendência"
        Me.colInadimplente.FieldName = "Inadimplente"
        Me.colInadimplente.Name = "colInadimplente"
        Me.colInadimplente.OptionsColumn.ReadOnly = True
        '
        'colInativo
        '
        Me.colInativo.Caption = "Inativo"
        Me.colInativo.FieldName = "Inativo"
        Me.colInativo.Name = "colInativo"
        Me.colInativo.OptionsColumn.ReadOnly = True
        Me.colInativo.Visible = True
        Me.colInativo.VisibleIndex = 24
        '
        'colProtestado
        '
        Me.colProtestado.Caption = "Protestado"
        Me.colProtestado.FieldName = "Protestado"
        Me.colProtestado.Name = "colProtestado"
        Me.colProtestado.OptionsColumn.ReadOnly = True
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
        Me.colNome.Width = 254
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnLimpar, Me.btnCancelar, Me.btnAlterar, Me.btnExcluir, Me.BarSubItem1, Me.btnRelCli, Me.btnRelCust, Me.btnEmail, Me.btnEti, Me.btnAddEtiq, Me.cboModelo, Me.BarSubItem2, Me.btnEtiquetaGeral, Me.btnRelCliente})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboModelo, "", True, True, True, 90, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddEtiq, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem2, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEmail, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 4
        Me.btnExcluir.Name = "btnExcluir"
        '
        'cboModelo
        '
        Me.cboModelo.Caption = "Modelo"
        Me.cboModelo.Edit = Me.RepositoryItemComboBox1
        Me.cboModelo.Id = 13
        Me.cboModelo.Name = "cboModelo"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"DUPLA", "TRIPLA"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnAddEtiq
        '
        Me.btnAddEtiq.Caption = "Add"
        Me.btnAddEtiq.Glyph = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAddEtiq.Id = 12
        Me.btnAddEtiq.Name = "btnAddEtiq"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "E&tiquetas"
        Me.BarSubItem2.Glyph = Global.Nano.My.Resources.Resources.Enveloppe_Blue
        Me.BarSubItem2.Id = 14
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEti, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEtiquetaGeral)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'btnEti
        '
        Me.btnEti.Caption = "Se&lecionado"
        Me.btnEti.Glyph = Global.Nano.My.Resources.Resources.Enveloppe_Blue
        Me.btnEti.Id = 11
        Me.btnEti.Name = "btnEti"
        '
        'btnEtiquetaGeral
        '
        Me.btnEtiquetaGeral.Caption = "&Geral"
        Me.btnEtiquetaGeral.Glyph = Global.Nano.My.Resources.Resources.Enveloppe_Blue
        Me.btnEtiquetaGeral.Id = 15
        Me.btnEtiquetaGeral.Name = "btnEtiquetaGeral"
        '
        'btnEmail
        '
        Me.btnEmail.Caption = "Enviar E-&Mail"
        Me.btnEmail.Glyph = Global.Nano.My.Resources.Resources.NanoMail
        Me.btnEmail.Id = 10
        Me.btnEmail.Name = "btnEmail"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 7
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCliente), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCli), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnRelCliente
        '
        Me.btnRelCliente.Caption = "Relatório de Clientes"
        Me.btnRelCliente.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCliente.Id = 16
        Me.btnRelCliente.Name = "btnRelCliente"
        '
        'btnRelCli
        '
        Me.btnRelCli.Caption = "Relatório Dados Clientes"
        Me.btnRelCli.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCli.Id = 8
        Me.btnRelCli.Name = "btnRelCli"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório Customizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.kghostview
        Me.btnRelCust.Id = 9
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 3
        Me.btnAlterar.Name = "btnAlterar"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1176, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 768)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1176, 47)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 768)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1176, 0)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 768)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(56, 21)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Nome/Razão"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(400, 53)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "RG/IE"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(694, 17)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Endereço"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 388)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1170, 350)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Clientes Cadastrados"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.RibbonControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl51)
        Me.GroupControl3.Controls.Add(Me.txtQtdCli)
        Me.GroupControl3.Controls.Add(Me.btnPadrao)
        Me.GroupControl3.Controls.Add(Me.btnManter)
        Me.GroupControl3.Controls.Add(Me.Panel1)
        Me.GroupControl3.Controls.Add(Me.ClienteGridControl)
        Me.GroupControl3.Controls.Add(Me.cboMes)
        Me.GroupControl3.Controls.Add(Me.btnVisualizar)
        Me.GroupControl3.Controls.Add(Me.Panel2)
        Me.GroupControl3.Controls.Add(Me.btnFiltrar)
        Me.GroupControl3.Controls.Add(Me.LabelControl33)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 25)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1166, 323)
        Me.GroupControl3.TabIndex = 2
        '
        'LabelControl51
        '
        Me.LabelControl51.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl51.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl51.Location = New System.Drawing.Point(903, 295)
        Me.LabelControl51.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(145, 17)
        Me.LabelControl51.TabIndex = 105
        Me.LabelControl51.Text = "Clientes Cadastrados"
        '
        'txtQtdCli
        '
        Me.txtQtdCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdCli.Location = New System.Drawing.Point(1049, 290)
        Me.txtQtdCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQtdCli.Name = "txtQtdCli"
        Me.txtQtdCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdCli.Properties.Appearance.Options.UseFont = True
        Me.txtQtdCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdCli.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdCli.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdCli.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtQtdCli.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdCli.Properties.ReadOnly = True
        Me.txtQtdCli.Size = New System.Drawing.Size(111, 31)
        Me.txtQtdCli.TabIndex = 104
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(1075, 21)
        Me.btnPadrao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(63, 20)
        Me.btnPadrao.TabIndex = 103
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(1075, 3)
        Me.btnManter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(63, 20)
        Me.btnManter.TabIndex = 102
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(383, 291)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 28)
        Me.Panel1.TabIndex = 23
        '
        'ClienteGridControl
        '
        Me.ClienteGridControl.DataSource = Me.ClienteBindingSource
        Me.ClienteGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClienteGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClienteGridControl.Location = New System.Drawing.Point(2, 2)
        Me.ClienteGridControl.MainView = Me.grd1
        Me.ClienteGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ClienteGridControl.Name = "ClienteGridControl"
        Me.ClienteGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.ClienteGridControl.Size = New System.Drawing.Size(1162, 284)
        Me.ClienteGridControl.TabIndex = 0
        Me.ClienteGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grd1
        '
        Me.grd1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNome, Me.colRGIE, Me.colCPF, Me.colEndereco, Me.colNumero, Me.colComplemento, Me.colBairro, Me.colCep, Me.colCidade, Me.colEstado, Me.colTelefone, Me.colFax, Me.colCelular, Me.colEmail, Me.colData, Me.colFantasia, Me.colObservacao, Me.colInadimplente, Me.colStatus, Me.colNascimento, Me.colSexo, Me.colLimite, Me.colEmpresa, Me.colTelEmpresa, Me.colSalario, Me.colCredito, Me.colMarcas, Me.colPessoa1, Me.colPessoa2, Me.colRG1, Me.colRG2, Me.colInativo, Me.colTempoTrabalho, Me.colMoradia, Me.colNomeConjuge, Me.colTelConjuge, Me.colCodPais, Me.colNomePais, Me.colSuframa, Me.colProtestado, Me.colDesconto, Me.colAgencia, Me.colContaCorrente, Me.colBanco, Me.colContato, Me.colCodFunc, Me.colEnderecoEntrega, Me.colNumeroEntrega, Me.colComplementoEntrega, Me.colBairroEntrega, Me.colCepEntrega, Me.colCidadeEntrega, Me.colEstadoEntrega})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colInadimplente
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.DimGray
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colInativo
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colProtestado
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "PROTESTADO"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.grd1.GridControl = Me.ClienteGridControl
        Me.grd1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 72
        '
        'colRGIE
        '
        Me.colRGIE.AppearanceCell.Options.UseTextOptions = True
        Me.colRGIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRGIE.Caption = "RG/IE"
        Me.colRGIE.ColumnEdit = Me.txtAlterar
        Me.colRGIE.FieldName = "RGIE"
        Me.colRGIE.Name = "colRGIE"
        Me.colRGIE.OptionsColumn.ReadOnly = True
        Me.colRGIE.Visible = True
        Me.colRGIE.VisibleIndex = 4
        Me.colRGIE.Width = 103
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
        Me.colCPF.Width = 124
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.ColumnEdit = Me.txtAlterar
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.OptionsColumn.ReadOnly = True
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 5
        Me.colEndereco.Width = 252
        '
        'colNumero
        '
        Me.colNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.Caption = "Número"
        Me.colNumero.ColumnEdit = Me.txtAlterar
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 6
        '
        'colComplemento
        '
        Me.colComplemento.Caption = "Complemento"
        Me.colComplemento.ColumnEdit = Me.txtAlterar
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Visible = True
        Me.colComplemento.VisibleIndex = 7
        Me.colComplemento.Width = 140
        '
        'colBairro
        '
        Me.colBairro.Caption = "Bairro"
        Me.colBairro.ColumnEdit = Me.txtAlterar
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.ReadOnly = True
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 8
        Me.colBairro.Width = 170
        '
        'colCep
        '
        Me.colCep.AppearanceCell.Options.UseTextOptions = True
        Me.colCep.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCep.Caption = "Cep"
        Me.colCep.ColumnEdit = Me.txtAlterar
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.OptionsColumn.ReadOnly = True
        Me.colCep.Visible = True
        Me.colCep.VisibleIndex = 9
        Me.colCep.Width = 87
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
        Me.colCidade.Width = 200
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "Estado"
        Me.colEstado.ColumnEdit = Me.txtAlterar
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 11
        Me.colEstado.Width = 110
        '
        'colTelefone
        '
        Me.colTelefone.AppearanceCell.Options.UseTextOptions = True
        Me.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelefone.Caption = "Telefone 1"
        Me.colTelefone.ColumnEdit = Me.txtAlterar
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.OptionsColumn.ReadOnly = True
        Me.colTelefone.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 12
        Me.colTelefone.Width = 95
        '
        'colFax
        '
        Me.colFax.AppearanceCell.Options.UseTextOptions = True
        Me.colFax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFax.Caption = "Telefone 2"
        Me.colFax.ColumnEdit = Me.txtAlterar
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.ReadOnly = True
        Me.colFax.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFax.Visible = True
        Me.colFax.VisibleIndex = 13
        Me.colFax.Width = 95
        '
        'colCelular
        '
        Me.colCelular.AppearanceCell.Options.UseTextOptions = True
        Me.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCelular.Caption = "Telefone 3"
        Me.colCelular.ColumnEdit = Me.txtAlterar
        Me.colCelular.FieldName = "Celular"
        Me.colCelular.Name = "colCelular"
        Me.colCelular.OptionsColumn.ReadOnly = True
        Me.colCelular.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCelular.Visible = True
        Me.colCelular.VisibleIndex = 14
        Me.colCelular.Width = 95
        '
        'colEmail
        '
        Me.colEmail.Caption = "Web"
        Me.colEmail.ColumnEdit = Me.txtAlterar
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 15
        Me.colEmail.Width = 200
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
        Me.colData.VisibleIndex = 16
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
        Me.colFantasia.Width = 175
        '
        'colObservacao
        '
        Me.colObservacao.Caption = "Observação"
        Me.colObservacao.ColumnEdit = Me.txtAlterar
        Me.colObservacao.FieldName = "Observacao"
        Me.colObservacao.Name = "colObservacao"
        Me.colObservacao.OptionsColumn.ReadOnly = True
        Me.colObservacao.Visible = True
        Me.colObservacao.VisibleIndex = 17
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.ColumnEdit = Me.txtAlterar
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 20
        '
        'colNascimento
        '
        Me.colNascimento.Caption = "Nascimento"
        Me.colNascimento.FieldName = "Nascimento"
        Me.colNascimento.Name = "colNascimento"
        Me.colNascimento.OptionsColumn.ReadOnly = True
        Me.colNascimento.Visible = True
        Me.colNascimento.VisibleIndex = 18
        '
        'colSexo
        '
        Me.colSexo.Caption = "Sexo"
        Me.colSexo.ColumnEdit = Me.txtAlterar
        Me.colSexo.FieldName = "Sexo"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.OptionsColumn.ReadOnly = True
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 19
        '
        'colLimite
        '
        Me.colLimite.Caption = "Limite Créd."
        Me.colLimite.ColumnEdit = Me.txtAlterar
        Me.colLimite.FieldName = "Limite"
        Me.colLimite.Name = "colLimite"
        Me.colLimite.OptionsColumn.ReadOnly = True
        Me.colLimite.Visible = True
        Me.colLimite.VisibleIndex = 21
        '
        'colEmpresa
        '
        Me.colEmpresa.Caption = "Empresa"
        Me.colEmpresa.FieldName = "Empresa"
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.OptionsColumn.ReadOnly = True
        '
        'colTelEmpresa
        '
        Me.colTelEmpresa.Caption = "Tel. Empresa"
        Me.colTelEmpresa.FieldName = "TelEmpresa"
        Me.colTelEmpresa.Name = "colTelEmpresa"
        Me.colTelEmpresa.OptionsColumn.ReadOnly = True
        '
        'colSalario
        '
        Me.colSalario.Caption = "Salário"
        Me.colSalario.FieldName = "Salario"
        Me.colSalario.Name = "colSalario"
        Me.colSalario.OptionsColumn.ReadOnly = True
        '
        'colCredito
        '
        Me.colCredito.Caption = "Crédito"
        Me.colCredito.ColumnEdit = Me.txtAlterar
        Me.colCredito.FieldName = "Credito"
        Me.colCredito.Name = "colCredito"
        Me.colCredito.OptionsColumn.ReadOnly = True
        Me.colCredito.Visible = True
        Me.colCredito.VisibleIndex = 22
        '
        'colMarcas
        '
        Me.colMarcas.Caption = "Marcas Preferidas"
        Me.colMarcas.ColumnEdit = Me.txtAlterar
        Me.colMarcas.FieldName = "Marcas"
        Me.colMarcas.Name = "colMarcas"
        Me.colMarcas.OptionsColumn.ReadOnly = True
        Me.colMarcas.Visible = True
        Me.colMarcas.VisibleIndex = 23
        '
        'colPessoa1
        '
        Me.colPessoa1.Caption = "Pessoa1"
        Me.colPessoa1.FieldName = "Pessoa1"
        Me.colPessoa1.Name = "colPessoa1"
        Me.colPessoa1.OptionsColumn.ReadOnly = True
        '
        'colPessoa2
        '
        Me.colPessoa2.Caption = "Pessoa2"
        Me.colPessoa2.FieldName = "Pessoa2"
        Me.colPessoa2.Name = "colPessoa2"
        Me.colPessoa2.OptionsColumn.ReadOnly = True
        '
        'colRG1
        '
        Me.colRG1.Caption = "RG1"
        Me.colRG1.FieldName = "RG1"
        Me.colRG1.Name = "colRG1"
        Me.colRG1.OptionsColumn.ReadOnly = True
        '
        'colRG2
        '
        Me.colRG2.Caption = "RG2"
        Me.colRG2.FieldName = "RG2"
        Me.colRG2.Name = "colRG2"
        Me.colRG2.OptionsColumn.ReadOnly = True
        '
        'colTempoTrabalho
        '
        Me.colTempoTrabalho.Caption = "Tempo Trabalho"
        Me.colTempoTrabalho.FieldName = "TempoTrabalho"
        Me.colTempoTrabalho.Name = "colTempoTrabalho"
        Me.colTempoTrabalho.OptionsColumn.ReadOnly = True
        '
        'colMoradia
        '
        Me.colMoradia.Caption = "Moradia"
        Me.colMoradia.FieldName = "Moradia"
        Me.colMoradia.Name = "colMoradia"
        Me.colMoradia.OptionsColumn.ReadOnly = True
        Me.colMoradia.Visible = True
        Me.colMoradia.VisibleIndex = 25
        '
        'colNomeConjuge
        '
        Me.colNomeConjuge.Caption = "NomeConjuge"
        Me.colNomeConjuge.FieldName = "NomeConjuge"
        Me.colNomeConjuge.Name = "colNomeConjuge"
        Me.colNomeConjuge.Visible = True
        Me.colNomeConjuge.VisibleIndex = 26
        '
        'colTelConjuge
        '
        Me.colTelConjuge.Caption = "TelConjuge"
        Me.colTelConjuge.FieldName = "TelConjuge"
        Me.colTelConjuge.Name = "colTelConjuge"
        Me.colTelConjuge.Visible = True
        Me.colTelConjuge.VisibleIndex = 27
        '
        'colCodPais
        '
        Me.colCodPais.Caption = "Cód. Pais"
        Me.colCodPais.FieldName = "CodPais"
        Me.colCodPais.Name = "colCodPais"
        Me.colCodPais.OptionsColumn.ReadOnly = True
        Me.colCodPais.Visible = True
        Me.colCodPais.VisibleIndex = 28
        '
        'colNomePais
        '
        Me.colNomePais.Caption = "Pais"
        Me.colNomePais.FieldName = "NomePais"
        Me.colNomePais.Name = "colNomePais"
        Me.colNomePais.OptionsColumn.ReadOnly = True
        Me.colNomePais.Visible = True
        Me.colNomePais.VisibleIndex = 29
        '
        'colSuframa
        '
        Me.colSuframa.Caption = "Suframa"
        Me.colSuframa.FieldName = "Suframa"
        Me.colSuframa.Name = "colSuframa"
        Me.colSuframa.OptionsColumn.ReadOnly = True
        Me.colSuframa.Visible = True
        Me.colSuframa.VisibleIndex = 30
        '
        'colDesconto
        '
        Me.colDesconto.AppearanceCell.Options.UseTextOptions = True
        Me.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDesconto.Caption = "Desc. %"
        Me.colDesconto.FieldName = "Desconto"
        Me.colDesconto.Name = "colDesconto"
        Me.colDesconto.OptionsColumn.ReadOnly = True
        Me.colDesconto.Visible = True
        Me.colDesconto.VisibleIndex = 31
        '
        'colAgencia
        '
        Me.colAgencia.Caption = "Agência"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 32
        '
        'colContaCorrente
        '
        Me.colContaCorrente.Caption = "Conta Corrente"
        Me.colContaCorrente.FieldName = "ContaCorrente"
        Me.colContaCorrente.Name = "colContaCorrente"
        Me.colContaCorrente.OptionsColumn.ReadOnly = True
        Me.colContaCorrente.Visible = True
        Me.colContaCorrente.VisibleIndex = 33
        '
        'colBanco
        '
        Me.colBanco.Caption = "Banco"
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.ReadOnly = True
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 34
        '
        'colContato
        '
        Me.colContato.Caption = "Contato"
        Me.colContato.FieldName = "Contato"
        Me.colContato.Name = "colContato"
        Me.colContato.OptionsColumn.ReadOnly = True
        Me.colContato.Visible = True
        Me.colContato.VisibleIndex = 35
        '
        'colCodFunc
        '
        Me.colCodFunc.Caption = "Cód. Func."
        Me.colCodFunc.FieldName = "CodFunc"
        Me.colCodFunc.Name = "colCodFunc"
        Me.colCodFunc.OptionsColumn.ReadOnly = True
        Me.colCodFunc.Visible = True
        Me.colCodFunc.VisibleIndex = 36
        '
        'colEnderecoEntrega
        '
        Me.colEnderecoEntrega.Caption = "Endereço Entrega"
        Me.colEnderecoEntrega.FieldName = "EnderecoEntrega"
        Me.colEnderecoEntrega.Name = "colEnderecoEntrega"
        Me.colEnderecoEntrega.OptionsColumn.ReadOnly = True
        Me.colEnderecoEntrega.Visible = True
        Me.colEnderecoEntrega.VisibleIndex = 37
        '
        'colNumeroEntrega
        '
        Me.colNumeroEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroEntrega.Caption = "Número Entrega"
        Me.colNumeroEntrega.FieldName = "NumeroEntrega"
        Me.colNumeroEntrega.Name = "colNumeroEntrega"
        Me.colNumeroEntrega.OptionsColumn.ReadOnly = True
        Me.colNumeroEntrega.Visible = True
        Me.colNumeroEntrega.VisibleIndex = 38
        '
        'colComplementoEntrega
        '
        Me.colComplementoEntrega.Caption = "Complemento Entrega"
        Me.colComplementoEntrega.FieldName = "ComplementoEntrega"
        Me.colComplementoEntrega.Name = "colComplementoEntrega"
        Me.colComplementoEntrega.OptionsColumn.ReadOnly = True
        Me.colComplementoEntrega.Visible = True
        Me.colComplementoEntrega.VisibleIndex = 39
        '
        'colBairroEntrega
        '
        Me.colBairroEntrega.Caption = "Bairro Entrega"
        Me.colBairroEntrega.FieldName = "BairroEntrega"
        Me.colBairroEntrega.Name = "colBairroEntrega"
        Me.colBairroEntrega.OptionsColumn.ReadOnly = True
        Me.colBairroEntrega.Visible = True
        Me.colBairroEntrega.VisibleIndex = 40
        '
        'colCepEntrega
        '
        Me.colCepEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colCepEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCepEntrega.Caption = "Cep Entrega"
        Me.colCepEntrega.FieldName = "CepEntrega"
        Me.colCepEntrega.Name = "colCepEntrega"
        Me.colCepEntrega.OptionsColumn.ReadOnly = True
        Me.colCepEntrega.Visible = True
        Me.colCepEntrega.VisibleIndex = 41
        '
        'colCidadeEntrega
        '
        Me.colCidadeEntrega.Caption = "Cidade Entrega"
        Me.colCidadeEntrega.FieldName = "CidadeEntrega"
        Me.colCidadeEntrega.Name = "colCidadeEntrega"
        Me.colCidadeEntrega.OptionsColumn.ReadOnly = True
        Me.colCidadeEntrega.Visible = True
        Me.colCidadeEntrega.VisibleIndex = 42
        '
        'colEstadoEntrega
        '
        Me.colEstadoEntrega.AppearanceCell.Options.UseTextOptions = True
        Me.colEstadoEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstadoEntrega.Caption = "Estado Entrega"
        Me.colEstadoEntrega.FieldName = "EstadoEntrega"
        Me.colEstadoEntrega.Name = "colEstadoEntrega"
        Me.colEstadoEntrega.OptionsColumn.ReadOnly = True
        Me.colEstadoEntrega.Visible = True
        Me.colEstadoEntrega.VisibleIndex = 43
        '
        'cboMes
        '
        Me.cboMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMes.Location = New System.Drawing.Point(149, 294)
        Me.cboMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMes.Properties.Items.AddRange(New Object() {"", "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO"})
        Me.cboMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMes.Size = New System.Drawing.Size(121, 22)
        Me.cboMes.TabIndex = 22
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnVisualizar.Appearance.Options.UseBackColor = True
        Me.btnVisualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnVisualizar.Image = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnVisualizar.Location = New System.Drawing.Point(393, 290)
        Me.btnVisualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(105, 31)
        Me.btnVisualizar.TabIndex = 21
        Me.btnVisualizar.Text = "&Visualizar"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(280, 291)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 28)
        Me.Panel2.TabIndex = 20
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltrar.Appearance.Options.UseBackColor = True
        Me.btnFiltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFiltrar.Image = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(292, 290)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(84, 31)
        Me.btnFiltrar.TabIndex = 5
        Me.btnFiltrar.Text = "F&iltrar"
        '
        'LabelControl33
        '
        Me.LabelControl33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl33.Location = New System.Drawing.Point(12, 294)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(134, 16)
        Me.LabelControl33.TabIndex = 3
        Me.LabelControl33.Text = "Aniversariantes do mês"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(106, 49)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl11.TabIndex = 16
        Me.LabelControl11.Text = "Nº"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(250, 49)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Comp."
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(714, 49)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "Bairro"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(98, 17)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl14.TabIndex = 33
        Me.LabelControl14.Text = "Cep"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(388, 17)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl15.TabIndex = 35
        Me.LabelControl15.Text = "Cidade"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(271, 17)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl16.TabIndex = 37
        Me.LabelControl16.Text = "UF"
        '
        'rdgDoc
        '
        Me.rdgDoc.EditValue = True
        Me.rdgDoc.Location = New System.Drawing.Point(9, 49)
        Me.rdgDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(118, 25)
        Me.rdgDoc.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(706, 21)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl4.TabIndex = 44
        Me.LabelControl4.Text = "Fantasia"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.chkInativar)
        Me.GroupControl2.Controls.Add(Me.txtObs)
        Me.GroupControl2.Controls.Add(Me.chkIna)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 273)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1101, 66)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Observações"
        '
        'chkInativar
        '
        Me.chkInativar.Location = New System.Drawing.Point(252, 1)
        Me.chkInativar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkInativar.Name = "chkInativar"
        Me.chkInativar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkInativar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkInativar.Properties.Appearance.Options.UseFont = True
        Me.chkInativar.Properties.Appearance.Options.UseForeColor = True
        Me.chkInativar.Properties.Caption = "Inativo"
        Me.chkInativar.Size = New System.Drawing.Size(77, 23)
        Me.chkInativar.TabIndex = 6
        '
        'txtObs
        '
        Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObs.Location = New System.Drawing.Point(2, 25)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObs.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtObs.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtObs.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Size = New System.Drawing.Size(1097, 39)
        Me.txtObs.TabIndex = 0
        '
        'chkIna
        '
        Me.chkIna.Location = New System.Drawing.Point(135, 1)
        Me.chkIna.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIna.Name = "chkIna"
        Me.chkIna.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIna.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkIna.Properties.Appearance.Options.UseFont = True
        Me.chkIna.Properties.Appearance.Options.UseForeColor = True
        Me.chkIna.Properties.Caption = "Pendência"
        Me.chkIna.Size = New System.Drawing.Size(110, 23)
        Me.chkIna.TabIndex = 5
        '
        'tbbCli
        '
        Me.tbbCli.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbCli.AppearancePage.Header.Options.UseFont = True
        Me.tbbCli.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbbCli.Location = New System.Drawing.Point(0, 0)
        Me.tbbCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbbCli.Name = "tbbCli"
        Me.tbbCli.SelectedTabPage = Me.tabPrincipal
        Me.tbbCli.Size = New System.Drawing.Size(1170, 379)
        Me.tbbCli.TabIndex = 0
        Me.tbbCli.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPrincipal, Me.tabComp, Me.tabNFE})
        '
        'tabPrincipal
        '
        Me.tabPrincipal.Controls.Add(Me.XtraTabControl1)
        Me.tabPrincipal.Controls.Add(Me.txtContato)
        Me.tabPrincipal.Controls.Add(Me.LabelControl50)
        Me.tabPrincipal.Controls.Add(Me.nbcImagem)
        Me.tabPrincipal.Controls.Add(Me.GroupControl2)
        Me.tabPrincipal.Controls.Add(Me.btnConCPF)
        Me.tabPrincipal.Controls.Add(Me.chkIsento)
        Me.tabPrincipal.Controls.Add(Me.txtFant)
        Me.tabPrincipal.Controls.Add(Me.txtTel3)
        Me.tabPrincipal.Controls.Add(Me.txtTel1)
        Me.tabPrincipal.Controls.Add(Me.txtTel2)
        Me.tabPrincipal.Controls.Add(Me.txtWeb)
        Me.tabPrincipal.Controls.Add(Me.txtNome)
        Me.tabPrincipal.Controls.Add(Me.LabelControl5)
        Me.tabPrincipal.Controls.Add(Me.LabelControl23)
        Me.tabPrincipal.Controls.Add(Me.LabelControl22)
        Me.tabPrincipal.Controls.Add(Me.LabelControl21)
        Me.tabPrincipal.Controls.Add(Me.chkCPF)
        Me.tabPrincipal.Controls.Add(Me.cboSexo)
        Me.tabPrincipal.Controls.Add(Me.dtNasc)
        Me.tabPrincipal.Controls.Add(Me.LabelControl9)
        Me.tabPrincipal.Controls.Add(Me.LabelControl7)
        Me.tabPrincipal.Controls.Add(Me.cboStatus)
        Me.tabPrincipal.Controls.Add(Me.LabelControl8)
        Me.tabPrincipal.Controls.Add(Me.LabelControl4)
        Me.tabPrincipal.Controls.Add(Me.rdgDoc)
        Me.tabPrincipal.Controls.Add(Me.LabelControl1)
        Me.tabPrincipal.Controls.Add(Me.LabelControl3)
        Me.tabPrincipal.Controls.Add(Me.txtCPF)
        Me.tabPrincipal.Controls.Add(Me.txtRGIE)
        Me.tabPrincipal.Controls.Add(Me.txtPerDesc)
        Me.tabPrincipal.Controls.Add(Label15)
        Me.tabPrincipal.Controls.Add(Me.txtMarcas)
        Me.tabPrincipal.Controls.Add(Me.LabelControl24)
        Me.tabPrincipal.Controls.Add(Me.lueCodFunc)
        Me.tabPrincipal.Controls.Add(Me.LabelControl68)
        Me.tabPrincipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.Size = New System.Drawing.Size(1164, 349)
        Me.tabPrincipal.Text = "Principal"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 84)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1102, 118)
        Me.XtraTabControl1.TabIndex = 180
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.txtBairro)
        Me.XtraTabPage1.Controls.Add(Me.btnCadBairro)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.cboCidade)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.cboUF)
        Me.XtraTabPage1.Controls.Add(Me.txtComp)
        Me.XtraTabPage1.Controls.Add(Me.txtNum)
        Me.XtraTabPage1.Controls.Add(Me.txtCep)
        Me.XtraTabPage1.Controls.Add(Me.txtEnd)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1096, 88)
        Me.XtraTabPage1.Text = "Endereço Cliente"
        '
        'txtBairro
        '
        Me.txtBairro.EnterMoveNextControl = True
        Me.txtBairro.Location = New System.Drawing.Point(754, 46)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Properties.MaxLength = 50
        Me.txtBairro.Size = New System.Drawing.Size(310, 22)
        Me.txtBairro.TabIndex = 14
        '
        'btnCadBairro
        '
        Me.btnCadBairro.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadBairro.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadBairro.Location = New System.Drawing.Point(1065, 46)
        Me.btnCadBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCadBairro.Name = "btnCadBairro"
        Me.btnCadBairro.Size = New System.Drawing.Size(23, 25)
        Me.btnCadBairro.TabIndex = 118
        Me.btnCadBairro.Text = "SimpleButton1"
        '
        'cboCidade
        '
        Me.cboCidade.EnterMoveNextControl = True
        Me.cboCidade.Location = New System.Drawing.Point(434, 14)
        Me.cboCidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCidade.Properties.MaxLength = 50
        Me.cboCidade.Size = New System.Drawing.Size(220, 22)
        Me.cboCidade.TabIndex = 10
        '
        'cboUF
        '
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(293, 14)
        Me.cboUF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(62, 22)
        Me.cboUF.TabIndex = 9
        '
        'txtComp
        '
        Me.txtComp.CasasDecimais = 0
        Me.txtComp.EnterMoveNextControl = True
        Me.txtComp.Location = New System.Drawing.Point(293, 46)
        Me.txtComp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Numerico = False
        Me.txtComp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComp.Properties.MaxLength = 75
        Me.txtComp.Size = New System.Drawing.Size(360, 22)
        Me.txtComp.TabIndex = 13
        '
        'txtNum
        '
        Me.txtNum.CasasDecimais = 0
        Me.txtNum.EnterMoveNextControl = True
        Me.txtNum.Location = New System.Drawing.Point(127, 46)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Numerico = True
        Me.txtNum.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNum.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNum.Properties.MaxLength = 10
        Me.txtNum.Size = New System.Drawing.Size(107, 22)
        Me.txtNum.TabIndex = 12
        Me.txtNum.Tag = "Número"
        '
        'txtCep
        '
        Me.txtCep.CasasDecimais = 0
        Me.txtCep.EnterMoveNextControl = True
        Me.txtCep.Location = New System.Drawing.Point(127, 14)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Numerico = False
        Me.txtCep.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCep.Properties.MaxLength = 10
        Me.txtCep.Size = New System.Drawing.Size(107, 22)
        Me.txtCep.TabIndex = 8
        '
        'txtEnd
        '
        Me.txtEnd.CasasDecimais = 0
        Me.txtEnd.EnterMoveNextControl = True
        Me.txtEnd.Location = New System.Drawing.Point(754, 14)
        Me.txtEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Numerico = False
        Me.txtEnd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEnd.Properties.MaxLength = 100
        Me.txtEnd.Size = New System.Drawing.Size(335, 22)
        Me.txtEnd.TabIndex = 11
        Me.txtEnd.Tag = "Endereço"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.btnCadBairro2)
        Me.XtraTabPage2.Controls.Add(Me.NanoCampo1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl69)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl70)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl71)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl72)
        Me.XtraTabPage2.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl73)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl74)
        Me.XtraTabPage2.Controls.Add(Me.ComboBoxEdit2)
        Me.XtraTabPage2.Controls.Add(Me.NanoCampo2)
        Me.XtraTabPage2.Controls.Add(Me.NanoCampo3)
        Me.XtraTabPage2.Controls.Add(Me.NanoCampo4)
        Me.XtraTabPage2.Controls.Add(Me.NanoCampo5)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1096, 88)
        Me.XtraTabPage2.Text = "Endereço Entrega"
        '
        'btnCadBairro2
        '
        Me.btnCadBairro2.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadBairro2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadBairro2.Location = New System.Drawing.Point(1065, 46)
        Me.btnCadBairro2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCadBairro2.Name = "btnCadBairro2"
        Me.btnCadBairro2.Size = New System.Drawing.Size(23, 25)
        Me.btnCadBairro2.TabIndex = 121
        Me.btnCadBairro2.Text = "SimpleButton1"
        '
        'NanoCampo1
        '
        Me.NanoCampo1.EnterMoveNextControl = True
        Me.NanoCampo1.Location = New System.Drawing.Point(754, 46)
        Me.NanoCampo1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NanoCampo1.Name = "NanoCampo1"
        Me.NanoCampo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NanoCampo1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NanoCampo1.Properties.MaxLength = 50
        Me.NanoCampo1.Size = New System.Drawing.Size(310, 22)
        Me.NanoCampo1.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(388, 17)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "Cidade"
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(271, 17)
        Me.LabelControl69.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl69.TabIndex = 51
        Me.LabelControl69.Text = "UF"
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(98, 17)
        Me.LabelControl70.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl70.TabIndex = 49
        Me.LabelControl70.Text = "Cep"
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(106, 49)
        Me.LabelControl71.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl71.TabIndex = 46
        Me.LabelControl71.Text = "Nº"
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(714, 49)
        Me.LabelControl72.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl72.TabIndex = 48
        Me.LabelControl72.Text = "Bairro"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EnterMoveNextControl = True
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(434, 14)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComboBoxEdit1.Properties.MaxLength = 50
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(220, 22)
        Me.ComboBoxEdit1.TabIndex = 40
        '
        'LabelControl73
        '
        Me.LabelControl73.Location = New System.Drawing.Point(694, 17)
        Me.LabelControl73.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl73.TabIndex = 44
        Me.LabelControl73.Text = "Endereço"
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(250, 49)
        Me.LabelControl74.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl74.TabIndex = 47
        Me.LabelControl74.Text = "Comp."
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.EditValue = "SP"
        Me.ComboBoxEdit2.EnterMoveNextControl = True
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(293, 14)
        Me.ComboBoxEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.ComboBoxEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ComboBoxEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBoxEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.ComboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(62, 22)
        Me.ComboBoxEdit2.TabIndex = 39
        '
        'NanoCampo2
        '
        Me.NanoCampo2.CasasDecimais = 0
        Me.NanoCampo2.EnterMoveNextControl = True
        Me.NanoCampo2.Location = New System.Drawing.Point(293, 46)
        Me.NanoCampo2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NanoCampo2.Name = "NanoCampo2"
        Me.NanoCampo2.Numerico = False
        Me.NanoCampo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo2.Properties.MaxLength = 75
        Me.NanoCampo2.Size = New System.Drawing.Size(360, 22)
        Me.NanoCampo2.TabIndex = 43
        '
        'NanoCampo3
        '
        Me.NanoCampo3.CasasDecimais = 0
        Me.NanoCampo3.EnterMoveNextControl = True
        Me.NanoCampo3.Location = New System.Drawing.Point(127, 46)
        Me.NanoCampo3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NanoCampo3.Name = "NanoCampo3"
        Me.NanoCampo3.Numerico = True
        Me.NanoCampo3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo3.Properties.MaxLength = 10
        Me.NanoCampo3.Size = New System.Drawing.Size(107, 22)
        Me.NanoCampo3.TabIndex = 42
        Me.NanoCampo3.Tag = "Número"
        '
        'NanoCampo4
        '
        Me.NanoCampo4.CasasDecimais = 0
        Me.NanoCampo4.EnterMoveNextControl = True
        Me.NanoCampo4.Location = New System.Drawing.Point(127, 14)
        Me.NanoCampo4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NanoCampo4.Name = "NanoCampo4"
        Me.NanoCampo4.Numerico = False
        Me.NanoCampo4.Properties.Appearance.Options.UseTextOptions = True
        Me.NanoCampo4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NanoCampo4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo4.Properties.MaxLength = 10
        Me.NanoCampo4.Size = New System.Drawing.Size(107, 22)
        Me.NanoCampo4.TabIndex = 38
        '
        'NanoCampo5
        '
        Me.NanoCampo5.CasasDecimais = 0
        Me.NanoCampo5.EnterMoveNextControl = True
        Me.NanoCampo5.Location = New System.Drawing.Point(754, 14)
        Me.NanoCampo5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NanoCampo5.Name = "NanoCampo5"
        Me.NanoCampo5.Numerico = False
        Me.NanoCampo5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NanoCampo5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.NanoCampo5.Properties.MaxLength = 100
        Me.NanoCampo5.Size = New System.Drawing.Size(335, 22)
        Me.NanoCampo5.TabIndex = 41
        Me.NanoCampo5.Tag = "Endereço"
        '
        'txtContato
        '
        Me.txtContato.CasasDecimais = 0
        Me.txtContato.EnterMoveNextControl = True
        Me.txtContato.Location = New System.Drawing.Point(441, 241)
        Me.txtContato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Numerico = False
        Me.txtContato.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContato.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContato.Properties.MaxLength = 50
        Me.txtContato.Size = New System.Drawing.Size(220, 22)
        Me.txtContato.TabIndex = 18
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(388, 245)
        Me.LabelControl50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl50.TabIndex = 129
        Me.LabelControl50.Text = "Contato"
        '
        'nbcImagem
        '
        Me.nbcImagem.ActiveGroup = Me.nbgImagem
        Me.nbcImagem.ContentButtonHint = Nothing
        Me.nbcImagem.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.nbcImagem.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nbgImagem})
        Me.nbcImagem.Location = New System.Drawing.Point(1111, 0)
        Me.nbcImagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nbcImagem.Name = "nbcImagem"
        Me.nbcImagem.OptionsNavPane.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.nbcImagem.OptionsNavPane.ExpandedWidth = 412
        Me.nbcImagem.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed
        Me.nbcImagem.OptionsNavPane.ShowOverflowPanel = False
        Me.nbcImagem.OptionsNavPane.ShowSplitter = False
        Me.nbcImagem.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.nbcImagem.Size = New System.Drawing.Size(44, 340)
        Me.nbcImagem.TabIndex = 125
        Me.nbcImagem.Text = "NavBarControl1"
        '
        'nbgImagem
        '
        Me.nbgImagem.Caption = "Foto"
        Me.nbgImagem.ControlContainer = Me.NavBarGroupControlContainer1
        Me.nbgImagem.Expanded = True
        Me.nbgImagem.GroupClientHeight = 80
        Me.nbgImagem.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.nbgImagem.Name = "nbgImagem"
        Me.nbgImagem.SmallImage = Global.Nano.My.Resources.Resources.Webcam
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.PanelControl8)
        Me.NavBarGroupControlContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(476, 223)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Controls.Add(Me.picCod)
        Me.PanelControl8.Controls.Add(Me.btnCarregar)
        Me.PanelControl8.Controls.Add(Me.btnTirar)
        Me.PanelControl8.Controls.Add(Me.btnOcultar)
        Me.PanelControl8.Controls.Add(Me.picImagem)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(476, 223)
        Me.PanelControl8.TabIndex = 5
        '
        'picCod
        '
        Me.picCod.Location = New System.Drawing.Point(313, 175)
        Me.picCod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picCod.Name = "picCod"
        Me.picCod.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picCod.Properties.Appearance.Options.UseBackColor = True
        Me.picCod.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picCod.Size = New System.Drawing.Size(139, 44)
        Me.picCod.TabIndex = 57
        '
        'btnCarregar
        '
        Me.btnCarregar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnCarregar.Appearance.Options.UseBackColor = True
        Me.btnCarregar.Appearance.Options.UseFont = True
        Me.btnCarregar.Appearance.Options.UseForeColor = True
        Me.btnCarregar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCarregar.Location = New System.Drawing.Point(322, 4)
        Me.btnCarregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(26, 27)
        Me.btnCarregar.TabIndex = 54
        Me.btnCarregar.Text = "..."
        '
        'btnTirar
        '
        Me.btnTirar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnTirar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnTirar.Appearance.Options.UseBackColor = True
        Me.btnTirar.Appearance.Options.UseFont = True
        Me.btnTirar.Appearance.Options.UseForeColor = True
        Me.btnTirar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTirar.Image = Global.Nano.My.Resources.Resources.Webcam
        Me.btnTirar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTirar.Location = New System.Drawing.Point(322, 36)
        Me.btnTirar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(26, 27)
        Me.btnTirar.TabIndex = 53
        '
        'btnOcultar
        '
        Me.btnOcultar.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnOcultar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnOcultar.Appearance.Options.UseBackColor = True
        Me.btnOcultar.Appearance.Options.UseFont = True
        Me.btnOcultar.Appearance.Options.UseForeColor = True
        Me.btnOcultar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOcultar.Location = New System.Drawing.Point(322, 234)
        Me.btnOcultar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(26, 27)
        Me.btnOcultar.TabIndex = 52
        Me.btnOcultar.Text = ">>"
        Me.btnOcultar.Visible = False
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(2, 4)
        Me.picImagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picImagem.Size = New System.Drawing.Size(306, 262)
        Me.picImagem.TabIndex = 0
        '
        'btnConCPF
        '
        Me.btnConCPF.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConCPF.Location = New System.Drawing.Point(363, 49)
        Me.btnConCPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConCPF.Name = "btnConCPF"
        Me.btnConCPF.Size = New System.Drawing.Size(26, 25)
        ToolTipTitleItem1.Text = "Busca CPF/CNPJ"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.btnConCPF.SuperTip = SuperToolTip1
        Me.btnConCPF.TabIndex = 90
        '
        'chkIsento
        '
        Me.chkIsento.Location = New System.Drawing.Point(640, 50)
        Me.chkIsento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIsento.Name = "chkIsento"
        Me.chkIsento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkIsento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsento.Properties.Appearance.Options.UseBackColor = True
        Me.chkIsento.Properties.Appearance.Options.UseFont = True
        Me.chkIsento.Properties.Caption = ""
        Me.chkIsento.Size = New System.Drawing.Size(20, 19)
        Me.chkIsento.TabIndex = 86
        Me.chkIsento.ToolTip = "Selecione se for Isento"
        Me.chkIsento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkIsento.ToolTipTitle = "Isento"
        '
        'txtFant
        '
        Me.txtFant.CasasDecimais = 0
        Me.txtFant.EnterMoveNextControl = True
        Me.txtFant.Location = New System.Drawing.Point(761, 17)
        Me.txtFant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFant.Name = "txtFant"
        Me.txtFant.Numerico = False
        Me.txtFant.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFant.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFant.Properties.MaxLength = 80
        Me.txtFant.Size = New System.Drawing.Size(343, 22)
        Me.txtFant.TabIndex = 1
        '
        'txtTel3
        '
        Me.txtTel3.CasasDecimais = 0
        Me.txtTel3.EnterMoveNextControl = True
        Me.txtTel3.Location = New System.Drawing.Point(134, 241)
        Me.txtTel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel3.Name = "txtTel3"
        Me.txtTel3.Numerico = False
        Me.txtTel3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel3.Properties.MaxLength = 18
        Me.txtTel3.Size = New System.Drawing.Size(227, 22)
        Me.txtTel3.TabIndex = 17
        '
        'txtTel1
        '
        Me.txtTel1.CasasDecimais = 0
        Me.txtTel1.EnterMoveNextControl = True
        Me.txtTel1.Location = New System.Drawing.Point(134, 209)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Numerico = False
        Me.txtTel1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel1.Properties.MaxLength = 18
        Me.txtTel1.Size = New System.Drawing.Size(227, 22)
        Me.txtTel1.TabIndex = 15
        '
        'txtTel2
        '
        Me.txtTel2.CasasDecimais = 0
        Me.txtTel2.EnterMoveNextControl = True
        Me.txtTel2.Location = New System.Drawing.Point(441, 209)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Numerico = False
        Me.txtTel2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel2.Properties.MaxLength = 18
        Me.txtTel2.Size = New System.Drawing.Size(220, 22)
        Me.txtTel2.TabIndex = 16
        '
        'txtWeb
        '
        Me.txtWeb.CasasDecimais = 0
        Me.txtWeb.EnterMoveNextControl = True
        Me.txtWeb.Location = New System.Drawing.Point(761, 209)
        Me.txtWeb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Numerico = False
        Me.txtWeb.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtWeb.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtWeb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtWeb.Properties.MaxLength = 200
        Me.txtWeb.Size = New System.Drawing.Size(343, 22)
        Me.txtWeb.TabIndex = 19
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(134, 17)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtNome.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNome.Properties.MaxLength = 150
        Me.txtNome.Size = New System.Drawing.Size(527, 22)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Tag = "Nome"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(721, 210)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl5.TabIndex = 72
        Me.LabelControl5.Text = "E-mail"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(374, 214)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl23.TabIndex = 71
        Me.LabelControl23.Text = "Telefone 2"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(68, 245)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl22.TabIndex = 70
        Me.LabelControl22.Text = "Telefone 3"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(68, 212)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl21.TabIndex = 69
        Me.LabelControl21.Text = "Telefone 1"
        '
        'chkCPF
        '
        Me.chkCPF.Location = New System.Drawing.Point(341, 50)
        Me.chkCPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCPF.Name = "chkCPF"
        Me.chkCPF.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkCPF.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkCPF.Properties.Appearance.Options.UseBackColor = True
        Me.chkCPF.Properties.Appearance.Options.UseForeColor = True
        Me.chkCPF.Properties.Caption = ""
        Me.chkCPF.Size = New System.Drawing.Size(20, 21)
        Me.chkCPF.TabIndex = 68
        Me.chkCPF.ToolTip = "Selecione para alterar"
        Me.chkCPF.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkCPF.ToolTipTitle = "Alterar CPF/CNPJ"
        Me.chkCPF.Visible = False
        '
        'cboSexo
        '
        Me.cboSexo.EditValue = ""
        Me.cboSexo.EnterMoveNextControl = True
        Me.cboSexo.Location = New System.Drawing.Point(932, 49)
        Me.cboSexo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Properties.Appearance.Options.UseTextOptions = True
        Me.cboSexo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboSexo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSexo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSexo.Properties.Items.AddRange(New Object() {"M", "F"})
        Me.cboSexo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSexo.Size = New System.Drawing.Size(55, 22)
        Me.cboSexo.TabIndex = 6
        '
        'dtNasc
        '
        Me.dtNasc.EditValue = ""
        Me.dtNasc.EnterMoveNextControl = True
        Me.dtNasc.Location = New System.Drawing.Point(761, 49)
        Me.dtNasc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtNasc.Name = "dtNasc"
        Me.dtNasc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtNasc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtNasc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNasc.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtNasc.Size = New System.Drawing.Size(111, 22)
        Me.dtNasc.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(897, 53)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 16)
        Me.LabelControl9.TabIndex = 57
        Me.LabelControl9.Text = "Sexo"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(710, 53)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "Nascim."
        '
        'cboStatus
        '
        Me.cboStatus.EditValue = "3"
        Me.cboStatus.EnterMoveNextControl = True
        Me.cboStatus.Location = New System.Drawing.Point(1041, 49)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.cboStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboStatus.Size = New System.Drawing.Size(63, 22)
        Me.cboStatus.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(997, 53)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl8.TabIndex = 53
        Me.LabelControl8.Text = "Status"
        '
        'txtCPF
        '
        Me.txtCPF.CasasDecimais = 0
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(134, 49)
        Me.txtCPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Numerico = False
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.MaxLength = 20
        Me.txtCPF.Size = New System.Drawing.Size(227, 22)
        Me.txtCPF.TabIndex = 3
        Me.txtCPF.Tag = "CPF/CNPJ"
        '
        'txtRGIE
        '
        Me.txtRGIE.CasasDecimais = 0
        Me.txtRGIE.EnterMoveNextControl = True
        Me.txtRGIE.Location = New System.Drawing.Point(440, 49)
        Me.txtRGIE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRGIE.Name = "txtRGIE"
        Me.txtRGIE.Numerico = False
        Me.txtRGIE.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRGIE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtRGIE.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRGIE.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRGIE.Properties.MaxLength = 20
        Me.txtRGIE.Size = New System.Drawing.Size(222, 22)
        Me.txtRGIE.TabIndex = 4
        '
        'txtPerDesc
        '
        Me.txtPerDesc.EnterMoveNextControl = True
        Me.txtPerDesc.Location = New System.Drawing.Point(932, 241)
        Me.txtPerDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPerDesc.Name = "txtPerDesc"
        Me.txtPerDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerDesc.Properties.Appearance.Options.UseFont = True
        Me.txtPerDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPerDesc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtPerDesc.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPerDesc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtPerDesc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPerDesc.Size = New System.Drawing.Size(55, 23)
        Me.txtPerDesc.TabIndex = 22
        Me.txtPerDesc.Tag = "Desc. %"
        '
        'txtMarcas
        '
        Me.txtMarcas.CasasDecimais = 0
        Me.txtMarcas.EnterMoveNextControl = True
        Me.txtMarcas.Location = New System.Drawing.Point(761, 241)
        Me.txtMarcas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMarcas.Name = "txtMarcas"
        Me.txtMarcas.Numerico = False
        Me.txtMarcas.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMarcas.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMarcas.Properties.MaxLength = 200
        Me.txtMarcas.Size = New System.Drawing.Size(111, 22)
        Me.txtMarcas.TabIndex = 20
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(691, 245)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl24.TabIndex = 89
        Me.LabelControl24.Text = "Marc. Pref."
        '
        'lueCodFunc
        '
        Me.lueCodFunc.EnterMoveNextControl = True
        Me.lueCodFunc.Location = New System.Drawing.Point(1041, 241)
        Me.lueCodFunc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lueCodFunc.Name = "lueCodFunc"
        Me.lueCodFunc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueCodFunc.Properties.Appearance.Options.UseFont = True
        Me.lueCodFunc.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.lueCodFunc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.lueCodFunc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueCodFunc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.lueCodFunc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueCodFunc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.lueCodFunc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("lueCodFunc.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.lueCodFunc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cod", "Código", 15, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueCodFunc.Properties.DisplayMember = "Cod"
        Me.lueCodFunc.Properties.NullText = ""
        Me.lueCodFunc.Properties.ValueMember = "Cod"
        Me.lueCodFunc.Size = New System.Drawing.Size(63, 23)
        Me.lueCodFunc.TabIndex = 178
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(1002, 245)
        Me.LabelControl68.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl68.TabIndex = 179
        Me.LabelControl68.Text = "Func."
        '
        'tabComp
        '
        Me.tabComp.Controls.Add(Me.LabelControl49)
        Me.tabComp.Controls.Add(Me.txtBanco)
        Me.tabComp.Controls.Add(Me.LabelControl48)
        Me.tabComp.Controls.Add(Me.txtContaCorrente)
        Me.tabComp.Controls.Add(Me.LabelControl47)
        Me.tabComp.Controls.Add(Me.txtAgencia)
        Me.tabComp.Controls.Add(Me.LabelControl46)
        Me.tabComp.Controls.Add(Me.PanelControl5)
        Me.tabComp.Controls.Add(Me.LabelControl40)
        Me.tabComp.Controls.Add(Me.txtTelConj)
        Me.tabComp.Controls.Add(Me.txtNomeConj)
        Me.tabComp.Controls.Add(Me.LabelControl41)
        Me.tabComp.Controls.Add(Me.LabelControl39)
        Me.tabComp.Controls.Add(Me.PanelControl4)
        Me.tabComp.Controls.Add(Me.cboMor)
        Me.tabComp.Controls.Add(Me.LabelControl17)
        Me.tabComp.Controls.Add(Me.LabelControl34)
        Me.tabComp.Controls.Add(Me.txtTempTra)
        Me.tabComp.Controls.Add(Me.LabelControl32)
        Me.tabComp.Controls.Add(Me.txtRG2)
        Me.tabComp.Controls.Add(Me.LabelControl30)
        Me.tabComp.Controls.Add(Me.txtRG1)
        Me.tabComp.Controls.Add(Me.LabelControl31)
        Me.tabComp.Controls.Add(Me.txtPessoa2)
        Me.tabComp.Controls.Add(Me.txtPessoa1)
        Me.tabComp.Controls.Add(Me.LabelControl29)
        Me.tabComp.Controls.Add(Me.LabelControl28)
        Me.tabComp.Controls.Add(Me.LabelControl27)
        Me.tabComp.Controls.Add(Me.PanelControl3)
        Me.tabComp.Controls.Add(Me.txtEmp)
        Me.tabComp.Controls.Add(Me.txtTelEmp)
        Me.tabComp.Controls.Add(Me.txtSal)
        Me.tabComp.Controls.Add(Me.LabelControl26)
        Me.tabComp.Controls.Add(Me.LabelControl25)
        Me.tabComp.Controls.Add(Me.PanelControl2)
        Me.tabComp.Controls.Add(Me.LabelControl20)
        Me.tabComp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabComp.Name = "tabComp"
        Me.tabComp.Size = New System.Drawing.Size(1164, 349)
        Me.tabComp.Text = "Complemento"
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(62, 265)
        Me.LabelControl49.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl49.TabIndex = 119
        Me.LabelControl49.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.CasasDecimais = 0
        Me.txtBanco.EnterMoveNextControl = True
        Me.txtBanco.Location = New System.Drawing.Point(103, 261)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Numerico = False
        Me.txtBanco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBanco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBanco.Properties.MaxLength = 50
        Me.txtBanco.Size = New System.Drawing.Size(146, 22)
        Me.txtBanco.TabIndex = 118
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(489, 265)
        Me.LabelControl48.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl48.TabIndex = 117
        Me.LabelControl48.Text = "Conta Corrente"
        '
        'txtContaCorrente
        '
        Me.txtContaCorrente.CasasDecimais = 0
        Me.txtContaCorrente.EnterMoveNextControl = True
        Me.txtContaCorrente.Location = New System.Drawing.Point(583, 261)
        Me.txtContaCorrente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContaCorrente.Name = "txtContaCorrente"
        Me.txtContaCorrente.Numerico = False
        Me.txtContaCorrente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContaCorrente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContaCorrente.Properties.MaxLength = 10
        Me.txtContaCorrente.Size = New System.Drawing.Size(146, 22)
        Me.txtContaCorrente.TabIndex = 116
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(285, 265)
        Me.LabelControl47.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl47.TabIndex = 115
        Me.LabelControl47.Text = "Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.CasasDecimais = 0
        Me.txtAgencia.EnterMoveNextControl = True
        Me.txtAgencia.Location = New System.Drawing.Point(336, 261)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Numerico = False
        Me.txtAgencia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAgencia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAgencia.Properties.MaxLength = 10
        Me.txtAgencia.Size = New System.Drawing.Size(146, 22)
        Me.txtAgencia.TabIndex = 114
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl46.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl46.Location = New System.Drawing.Point(24, 240)
        Me.LabelControl46.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(43, 17)
        Me.LabelControl46.TabIndex = 113
        Me.LabelControl46.Text = "Banco"
        '
        'PanelControl5
        '
        Me.PanelControl5.Location = New System.Drawing.Point(6, 247)
        Me.PanelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(726, 6)
        Me.PanelControl5.TabIndex = 112
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(527, 213)
        Me.LabelControl40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl40.TabIndex = 111
        Me.LabelControl40.Text = "Telefone"
        '
        'txtTelConj
        '
        Me.txtTelConj.CasasDecimais = 0
        Me.txtTelConj.EnterMoveNextControl = True
        Me.txtTelConj.Location = New System.Drawing.Point(583, 209)
        Me.txtTelConj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelConj.Name = "txtTelConj"
        Me.txtTelConj.Numerico = False
        Me.txtTelConj.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelConj.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelConj.Properties.MaxLength = 18
        Me.txtTelConj.Size = New System.Drawing.Size(146, 22)
        Me.txtTelConj.TabIndex = 10
        '
        'txtNomeConj
        '
        Me.txtNomeConj.CasasDecimais = 0
        Me.txtNomeConj.EnterMoveNextControl = True
        Me.txtNomeConj.Location = New System.Drawing.Point(103, 209)
        Me.txtNomeConj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeConj.Name = "txtNomeConj"
        Me.txtNomeConj.Numerico = False
        Me.txtNomeConj.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomeConj.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNomeConj.Properties.MaxLength = 80
        Me.txtNomeConj.Size = New System.Drawing.Size(379, 22)
        Me.txtNomeConj.TabIndex = 9
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(64, 213)
        Me.LabelControl41.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl41.TabIndex = 110
        Me.LabelControl41.Text = "Nome"
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl39.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl39.Location = New System.Drawing.Point(24, 188)
        Me.LabelControl39.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(59, 17)
        Me.LabelControl39.TabIndex = 107
        Me.LabelControl39.Text = "Cônjuge"
        '
        'PanelControl4
        '
        Me.PanelControl4.Location = New System.Drawing.Point(6, 196)
        Me.PanelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(726, 6)
        Me.PanelControl4.TabIndex = 106
        '
        'cboMor
        '
        Me.cboMor.EditValue = ""
        Me.cboMor.EnterMoveNextControl = True
        Me.cboMor.Location = New System.Drawing.Point(103, 7)
        Me.cboMor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMor.Name = "cboMor"
        Me.cboMor.Properties.Appearance.Options.UseTextOptions = True
        Me.cboMor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboMor.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMor.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboMor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMor.Properties.Items.AddRange(New Object() {"PRÓPRIA", "ALUGADA", "CEDIDA"})
        Me.cboMor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMor.Size = New System.Drawing.Size(146, 22)
        Me.cboMor.TabIndex = 0
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(51, 11)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl17.TabIndex = 105
        Me.LabelControl17.Text = "Moradia"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(258, 78)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl34.TabIndex = 97
        Me.LabelControl34.Text = "Tempo Trab."
        '
        'txtTempTra
        '
        Me.txtTempTra.CasasDecimais = 0
        Me.txtTempTra.EnterMoveNextControl = True
        Me.txtTempTra.Location = New System.Drawing.Point(336, 74)
        Me.txtTempTra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTempTra.Name = "txtTempTra"
        Me.txtTempTra.Numerico = False
        Me.txtTempTra.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTempTra.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTempTra.Properties.MaxLength = 25
        Me.txtTempTra.Size = New System.Drawing.Size(145, 22)
        Me.txtTempTra.TabIndex = 4
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(560, 162)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(16, 16)
        Me.LabelControl32.TabIndex = 95
        Me.LabelControl32.Text = "RG"
        '
        'txtRG2
        '
        Me.txtRG2.CasasDecimais = 0
        Me.txtRG2.EnterMoveNextControl = True
        Me.txtRG2.Location = New System.Drawing.Point(583, 159)
        Me.txtRG2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRG2.Name = "txtRG2"
        Me.txtRG2.Numerico = False
        Me.txtRG2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRG2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRG2.Properties.MaxLength = 15
        Me.txtRG2.Size = New System.Drawing.Size(146, 22)
        Me.txtRG2.TabIndex = 8
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(560, 130)
        Me.LabelControl30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(16, 16)
        Me.LabelControl30.TabIndex = 93
        Me.LabelControl30.Text = "RG"
        '
        'txtRG1
        '
        Me.txtRG1.CasasDecimais = 0
        Me.txtRG1.EnterMoveNextControl = True
        Me.txtRG1.Location = New System.Drawing.Point(583, 127)
        Me.txtRG1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRG1.Name = "txtRG1"
        Me.txtRG1.Numerico = False
        Me.txtRG1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRG1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtRG1.Properties.MaxLength = 15
        Me.txtRG1.Size = New System.Drawing.Size(146, 22)
        Me.txtRG1.TabIndex = 6
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(64, 162)
        Me.LabelControl31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl31.TabIndex = 91
        Me.LabelControl31.Text = "Nome"
        '
        'txtPessoa2
        '
        Me.txtPessoa2.CasasDecimais = 0
        Me.txtPessoa2.EnterMoveNextControl = True
        Me.txtPessoa2.Location = New System.Drawing.Point(103, 159)
        Me.txtPessoa2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPessoa2.Name = "txtPessoa2"
        Me.txtPessoa2.Numerico = False
        Me.txtPessoa2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPessoa2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPessoa2.Properties.MaxLength = 100
        Me.txtPessoa2.Size = New System.Drawing.Size(379, 22)
        Me.txtPessoa2.TabIndex = 7
        '
        'txtPessoa1
        '
        Me.txtPessoa1.CasasDecimais = 0
        Me.txtPessoa1.EnterMoveNextControl = True
        Me.txtPessoa1.Location = New System.Drawing.Point(103, 127)
        Me.txtPessoa1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPessoa1.Name = "txtPessoa1"
        Me.txtPessoa1.Numerico = False
        Me.txtPessoa1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPessoa1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPessoa1.Properties.MaxLength = 100
        Me.txtPessoa1.Size = New System.Drawing.Size(379, 22)
        Me.txtPessoa1.TabIndex = 5
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(64, 130)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl29.TabIndex = 88
        Me.LabelControl29.Text = "Nome"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl28.Location = New System.Drawing.Point(743, -4)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl28.TabIndex = 9
        Me.LabelControl28.Text = "Histórico"
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl27.Location = New System.Drawing.Point(22, 107)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(141, 17)
        Me.LabelControl27.TabIndex = 85
        Me.LabelControl27.Text = "Pessoas Autorizadas"
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(3, 114)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(726, 6)
        Me.PanelControl3.TabIndex = 84
        '
        'txtEmp
        '
        Me.txtEmp.CasasDecimais = 0
        Me.txtEmp.EnterMoveNextControl = True
        Me.txtEmp.Location = New System.Drawing.Point(103, 42)
        Me.txtEmp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Numerico = False
        Me.txtEmp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmp.Properties.MaxLength = 100
        Me.txtEmp.Size = New System.Drawing.Size(379, 22)
        Me.txtEmp.TabIndex = 1
        '
        'txtTelEmp
        '
        Me.txtTelEmp.CasasDecimais = 0
        Me.txtTelEmp.EnterMoveNextControl = True
        Me.txtTelEmp.Location = New System.Drawing.Point(583, 42)
        Me.txtTelEmp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelEmp.Name = "txtTelEmp"
        Me.txtTelEmp.Numerico = False
        Me.txtTelEmp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelEmp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelEmp.Properties.MaxLength = 18
        Me.txtTelEmp.Size = New System.Drawing.Size(146, 22)
        Me.txtTelEmp.TabIndex = 2
        '
        'txtSal
        '
        Me.txtSal.CasasDecimais = 2
        Me.txtSal.EnterMoveNextControl = True
        Me.txtSal.Location = New System.Drawing.Point(103, 74)
        Me.txtSal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Numerico = True
        Me.txtSal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSal.Properties.MaxLength = 15
        Me.txtSal.Size = New System.Drawing.Size(146, 22)
        Me.txtSal.TabIndex = 3
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(22, 78)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl26.TabIndex = 83
        Me.LabelControl26.Text = "Faixa Salarial"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(527, 46)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl25.TabIndex = 81
        Me.LabelControl25.Text = "Telefone"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.txtDiasEmAtraso)
        Me.PanelControl2.Controls.Add(Me.btnConsumo)
        Me.PanelControl2.Controls.Add(Me.btnRelVendas)
        Me.PanelControl2.Controls.Add(Me.LabelControl38)
        Me.PanelControl2.Controls.Add(Me.LabelControl37)
        Me.PanelControl2.Controls.Add(Me.LabelControl36)
        Me.PanelControl2.Controls.Add(Me.txtLimCli)
        Me.PanelControl2.Controls.Add(Me.LabelControl35)
        Me.PanelControl2.Controls.Add(Me.txtSalDev)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.txtNumCom)
        Me.PanelControl2.Controls.Add(Me.txtdtCad)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.lblTotalGasto)
        Me.PanelControl2.Controls.Add(Me.LabelControl18)
        Me.PanelControl2.Controls.Add(Me.txtTotalGasto)
        Me.PanelControl2.Controls.Add(Me.LabelControl19)
        Me.PanelControl2.Controls.Add(Me.lblCred)
        Me.PanelControl2.Controls.Add(Me.txtUltVis)
        Me.PanelControl2.Controls.Add(Me.txtCredito)
        Me.PanelControl2.Controls.Add(Me.txtLimite)
        Me.PanelControl2.Location = New System.Drawing.Point(736, 4)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(415, 245)
        Me.PanelControl2.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Dias Em Atraso"
        '
        'txtDiasEmAtraso
        '
        Me.txtDiasEmAtraso.CasasDecimais = 0
        Me.txtDiasEmAtraso.Location = New System.Drawing.Point(233, 214)
        Me.txtDiasEmAtraso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.txtDiasEmAtraso.Size = New System.Drawing.Size(166, 23)
        Me.txtDiasEmAtraso.TabIndex = 114
        '
        'btnConsumo
        '
        Me.btnConsumo.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnConsumo.Location = New System.Drawing.Point(108, 212)
        Me.btnConsumo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsumo.Name = "btnConsumo"
        Me.btnConsumo.Size = New System.Drawing.Size(82, 28)
        Me.btnConsumo.TabIndex = 113
        Me.btnConsumo.Text = "Consumo"
        '
        'btnRelVendas
        '
        Me.btnRelVendas.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnRelVendas.Location = New System.Drawing.Point(22, 212)
        Me.btnRelVendas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRelVendas.Name = "btnRelVendas"
        Me.btnRelVendas.Size = New System.Drawing.Size(82, 28)
        Me.btnRelVendas.TabIndex = 112
        Me.btnRelVendas.Text = "Vendas"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl38.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl38.Location = New System.Drawing.Point(384, 105)
        Me.LabelControl38.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(12, 18)
        Me.LabelControl38.TabIndex = 111
        Me.LabelControl38.Text = "="
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl37.Location = New System.Drawing.Point(174, 106)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(12, 18)
        Me.LabelControl37.TabIndex = 110
        Me.LabelControl37.Text = "+"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Location = New System.Drawing.Point(24, 153)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(114, 17)
        Me.LabelControl36.TabIndex = 109
        Me.LabelControl36.Text = "Limite do Cliente"
        '
        'txtLimCli
        '
        Me.txtLimCli.CasasDecimais = 2
        Me.txtLimCli.EnterMoveNextControl = True
        Me.txtLimCli.Location = New System.Drawing.Point(24, 170)
        Me.txtLimCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLimCli.Name = "txtLimCli"
        Me.txtLimCli.Numerico = True
        Me.txtLimCli.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
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
        Me.txtLimCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtLimCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLimCli.Properties.MaxLength = 15
        Me.txtLimCli.Size = New System.Drawing.Size(166, 25)
        Me.txtLimCli.TabIndex = 6
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Location = New System.Drawing.Point(233, 107)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(100, 17)
        Me.LabelControl35.TabIndex = 107
        Me.LabelControl35.Text = "Saldo Devedor"
        '
        'txtSalDev
        '
        Me.txtSalDev.CasasDecimais = 2
        Me.txtSalDev.EnterMoveNextControl = True
        Me.txtSalDev.Location = New System.Drawing.Point(233, 124)
        Me.txtSalDev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSalDev.Name = "txtSalDev"
        Me.txtSalDev.Numerico = False
        Me.txtSalDev.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalDev.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSalDev.Properties.Appearance.Options.UseFont = True
        Me.txtSalDev.Properties.Appearance.Options.UseForeColor = True
        Me.txtSalDev.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSalDev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSalDev.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalDev.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSalDev.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtSalDev.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSalDev.Properties.MaxLength = 15
        Me.txtSalDev.Properties.ReadOnly = True
        Me.txtSalDev.Size = New System.Drawing.Size(166, 25)
        Me.txtSalDev.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(21, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Nº Compras"
        '
        'txtNumCom
        '
        Me.txtNumCom.CasasDecimais = 2
        Me.txtNumCom.EnterMoveNextControl = True
        Me.txtNumCom.Location = New System.Drawing.Point(24, 80)
        Me.txtNumCom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumCom.Name = "txtNumCom"
        Me.txtNumCom.Numerico = True
        Me.txtNumCom.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumCom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCom.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumCom.Properties.Appearance.Options.UseFont = True
        Me.txtNumCom.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumCom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumCom.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumCom.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumCom.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNumCom.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumCom.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumCom.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumCom.Properties.ReadOnly = True
        Me.txtNumCom.Size = New System.Drawing.Size(166, 23)
        Me.txtNumCom.TabIndex = 2
        '
        'txtdtCad
        '
        Me.txtdtCad.CasasDecimais = 0
        Me.txtdtCad.EnterMoveNextControl = True
        Me.txtdtCad.Location = New System.Drawing.Point(24, 34)
        Me.txtdtCad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdtCad.Name = "txtdtCad"
        Me.txtdtCad.Numerico = False
        Me.txtdtCad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdtCad.Properties.Appearance.Options.UseBackColor = True
        Me.txtdtCad.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdtCad.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtdtCad.Properties.ReadOnly = True
        Me.txtdtCad.Size = New System.Drawing.Size(166, 22)
        Me.txtdtCad.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(24, 107)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(81, 17)
        Me.LabelControl10.TabIndex = 69
        Me.LabelControl10.Text = "Limite Atual"
        '
        'lblTotalGasto
        '
        Me.lblTotalGasto.AutoSize = True
        Me.lblTotalGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalGasto.Location = New System.Drawing.Point(230, 63)
        Me.lblTotalGasto.Name = "lblTotalGasto"
        Me.lblTotalGasto.Size = New System.Drawing.Size(110, 17)
        Me.lblTotalGasto.TabIndex = 103
        Me.lblTotalGasto.Text = "Total Gasto R$"
        Me.lblTotalGasto.Visible = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(233, 17)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl18.TabIndex = 73
        Me.LabelControl18.Text = "Últ. Visita"
        '
        'txtTotalGasto
        '
        Me.txtTotalGasto.CasasDecimais = 2
        Me.txtTotalGasto.EnterMoveNextControl = True
        Me.txtTotalGasto.Location = New System.Drawing.Point(233, 80)
        Me.txtTotalGasto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.txtTotalGasto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalGasto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtTotalGasto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTotalGasto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTotalGasto.Properties.ReadOnly = True
        Me.txtTotalGasto.Size = New System.Drawing.Size(166, 23)
        Me.txtTotalGasto.TabIndex = 3
        Me.txtTotalGasto.Visible = False
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(24, 17)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl19.TabIndex = 75
        Me.LabelControl19.Text = "Cadastro"
        '
        'lblCred
        '
        Me.lblCred.AutoSize = True
        Me.lblCred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCred.Location = New System.Drawing.Point(230, 153)
        Me.lblCred.Name = "lblCred"
        Me.lblCred.Size = New System.Drawing.Size(134, 17)
        Me.lblCred.TabIndex = 101
        Me.lblCred.Text = "Crédito Devolução"
        Me.lblCred.Visible = False
        '
        'txtUltVis
        '
        Me.txtUltVis.CasasDecimais = 0
        Me.txtUltVis.EnterMoveNextControl = True
        Me.txtUltVis.Location = New System.Drawing.Point(233, 34)
        Me.txtUltVis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUltVis.Name = "txtUltVis"
        Me.txtUltVis.Numerico = False
        Me.txtUltVis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUltVis.Properties.Appearance.Options.UseBackColor = True
        Me.txtUltVis.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUltVis.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtUltVis.Properties.ReadOnly = True
        Me.txtUltVis.Size = New System.Drawing.Size(166, 22)
        Me.txtUltVis.TabIndex = 1
        '
        'txtCredito
        '
        Me.txtCredito.CasasDecimais = 2
        Me.txtCredito.Location = New System.Drawing.Point(233, 170)
        Me.txtCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Numerico = True
        Me.txtCredito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredito.Properties.Appearance.Options.UseFont = True
        Me.txtCredito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredito.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCredito.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCredito.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.LightGreen
        Me.txtCredito.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCredito.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCredito.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCredito.Properties.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(166, 23)
        Me.txtCredito.TabIndex = 7
        Me.txtCredito.Visible = False
        '
        'txtLimite
        '
        Me.txtLimite.CasasDecimais = 2
        Me.txtLimite.EnterMoveNextControl = True
        Me.txtLimite.Location = New System.Drawing.Point(24, 124)
        Me.txtLimite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Numerico = False
        Me.txtLimite.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtLimite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtLimite.Properties.Appearance.Options.UseBackColor = True
        Me.txtLimite.Properties.Appearance.Options.UseFont = True
        Me.txtLimite.Properties.Appearance.Options.UseForeColor = True
        Me.txtLimite.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLimite.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLimite.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimite.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtLimite.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLimite.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtLimite.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtLimite.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLimite.Properties.MaxLength = 15
        Me.txtLimite.Properties.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(166, 25)
        Me.txtLimite.TabIndex = 4
        Me.txtLimite.Tag = "Limite Atual"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(48, 46)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl20.TabIndex = 77
        Me.LabelControl20.Text = "Empresa"
        '
        'tabNFE
        '
        Me.tabNFE.Controls.Add(Me.txtSuframa)
        Me.tabNFE.Controls.Add(Me.txtCodPais)
        Me.tabNFE.Controls.Add(Me.txtCodMun)
        Me.tabNFE.Controls.Add(Me.LabelControl42)
        Me.tabNFE.Controls.Add(Me.LabelControl43)
        Me.tabNFE.Controls.Add(Me.cboPais)
        Me.tabNFE.Controls.Add(Me.LabelControl44)
        Me.tabNFE.Controls.Add(Me.LabelControl45)
        Me.tabNFE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabNFE.Name = "tabNFE"
        Me.tabNFE.Size = New System.Drawing.Size(1164, 349)
        Me.tabNFE.Text = "NFE"
        '
        'txtSuframa
        '
        Me.txtSuframa.CasasDecimais = 0
        Me.txtSuframa.EnterMoveNextControl = True
        Me.txtSuframa.Location = New System.Drawing.Point(112, 81)
        Me.txtSuframa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSuframa.Name = "txtSuframa"
        Me.txtSuframa.Numerico = False
        Me.txtSuframa.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSuframa.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSuframa.Properties.MaxLength = 10
        Me.txtSuframa.Size = New System.Drawing.Size(385, 22)
        Me.txtSuframa.TabIndex = 3
        Me.txtSuframa.Tag = "Número"
        '
        'txtCodPais
        '
        Me.txtCodPais.CasasDecimais = 0
        Me.txtCodPais.EnterMoveNextControl = True
        Me.txtCodPais.Location = New System.Drawing.Point(112, 49)
        Me.txtCodPais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodPais.Name = "txtCodPais"
        Me.txtCodPais.Numerico = True
        Me.txtCodPais.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodPais.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodPais.Properties.MaxLength = 10
        Me.txtCodPais.Size = New System.Drawing.Size(103, 22)
        Me.txtCodPais.TabIndex = 1
        Me.txtCodPais.Tag = "Número"
        '
        'txtCodMun
        '
        Me.txtCodMun.CasasDecimais = 0
        Me.txtCodMun.EnterMoveNextControl = True
        Me.txtCodMun.Location = New System.Drawing.Point(112, 17)
        Me.txtCodMun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Numerico = True
        Me.txtCodMun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodMun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodMun.Properties.MaxLength = 10
        Me.txtCodMun.Size = New System.Drawing.Size(103, 22)
        Me.txtCodMun.TabIndex = 0
        Me.txtCodMun.Tag = "Número"
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(58, 85)
        Me.LabelControl42.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl42.TabIndex = 51
        Me.LabelControl42.Text = "Suframa"
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(52, 53)
        Me.LabelControl43.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl43.TabIndex = 50
        Me.LabelControl43.Text = "Cód. País"
        '
        'cboPais
        '
        Me.cboPais.EnterMoveNextControl = True
        Me.cboPais.Location = New System.Drawing.Point(275, 49)
        Me.cboPais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPais.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPais.Size = New System.Drawing.Size(222, 22)
        Me.cboPais.TabIndex = 2
        Me.cboPais.Tag = "Cidade"
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(24, 21)
        Me.LabelControl44.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl44.TabIndex = 48
        Me.LabelControl44.Text = "Cód. Município"
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(246, 53)
        Me.LabelControl45.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl45.TabIndex = 49
        Me.LabelControl45.Text = "País"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        '
        'tbbCliente
        '
        Me.tbbCliente.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbCliente.AppearancePage.Header.Options.UseFont = True
        Me.tbbCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbbCliente.Location = New System.Drawing.Point(0, 0)
        Me.tbbCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbbCliente.Name = "tbbCliente"
        Me.tbbCliente.SelectedTabPage = Me.tabCliente
        Me.tbbCliente.Size = New System.Drawing.Size(1176, 768)
        Me.tbbCliente.TabIndex = 3
        Me.tbbCliente.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCliente, Me.tabVeiculo})
        '
        'tabCliente
        '
        Me.tabCliente.Controls.Add(Me.tbbCli)
        Me.tabCliente.Controls.Add(Me.GroupControl1)
        Me.tabCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabCliente.Name = "tabCliente"
        Me.tabCliente.Size = New System.Drawing.Size(1170, 738)
        Me.tabCliente.Text = "Cliente"
        '
        'tabVeiculo
        '
        Me.tabVeiculo.Controls.Add(Me.tab)
        Me.tabVeiculo.Controls.Add(Me.GroupControl7)
        Me.tabVeiculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabVeiculo.Name = "tabVeiculo"
        Me.tabVeiculo.PageVisible = False
        Me.tabVeiculo.Size = New System.Drawing.Size(1170, 738)
        Me.tabVeiculo.Text = "Veículo"
        '
        'tab
        '
        Me.tab.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Appearance.Options.UseFont = True
        Me.tab.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.AppearancePage.Header.Options.UseFont = True
        Me.tab.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabPri
        Me.tab.Size = New System.Drawing.Size(1170, 305)
        Me.tab.TabIndex = 38
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPri, Me.tabOpc, Me.tabImagem})
        '
        'tabPri
        '
        Me.tabPri.Controls.Add(Me.txtCli)
        Me.tabPri.Controls.Add(Me.chkCli)
        Me.tabPri.Controls.Add(Me.LabelControl53)
        Me.tabPri.Controls.Add(Me.PanelControl6)
        Me.tabPri.Controls.Add(Me.LabelControl52)
        Me.tabPri.Controls.Add(Me.txtKMMes)
        Me.tabPri.Controls.Add(Me.LabelControl54)
        Me.tabPri.Controls.Add(Me.GroupControl4)
        Me.tabPri.Controls.Add(Me.LabelControl55)
        Me.tabPri.Controls.Add(Me.txtCha)
        Me.tabPri.Controls.Add(Me.LabelControl56)
        Me.tabPri.Controls.Add(Me.LabelControl57)
        Me.tabPri.Controls.Add(Me.txtMod)
        Me.tabPri.Controls.Add(Me.txtVal)
        Me.tabPri.Controls.Add(Me.LabelControl58)
        Me.tabPri.Controls.Add(Me.LabelControl59)
        Me.tabPri.Controls.Add(Me.txtCor)
        Me.tabPri.Controls.Add(Me.txtCil)
        Me.tabPri.Controls.Add(Me.LabelControl60)
        Me.tabPri.Controls.Add(Me.LabelControl61)
        Me.tabPri.Controls.Add(Me.txtAno)
        Me.tabPri.Controls.Add(Me.LabelControl62)
        Me.tabPri.Controls.Add(Me.txtMot)
        Me.tabPri.Controls.Add(Me.txtKM)
        Me.tabPri.Controls.Add(Me.LabelControl63)
        Me.tabPri.Controls.Add(Me.LabelControl64)
        Me.tabPri.Controls.Add(Me.LabelControl65)
        Me.tabPri.Controls.Add(Me.txtPlaca)
        Me.tabPri.Controls.Add(Me.cboComb)
        Me.tabPri.Controls.Add(Me.LabelControl66)
        Me.tabPri.Controls.Add(Me.cboFab)
        Me.tabPri.Controls.Add(Me.PanelControl7)
        Me.tabPri.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPri.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabPri.Name = "tabPri"
        Me.tabPri.Size = New System.Drawing.Size(1164, 274)
        Me.tabPri.Text = "Principal"
        '
        'txtCli
        '
        Me.txtCli.EnterMoveNextControl = True
        Me.txtCli.Location = New System.Drawing.Point(96, 159)
        Me.txtCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCli.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtCli.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCli.Size = New System.Drawing.Size(426, 22)
        Me.txtCli.TabIndex = 105
        '
        'chkCli
        '
        Me.chkCli.Location = New System.Drawing.Point(726, 161)
        Me.chkCli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCli.Name = "chkCli"
        Me.chkCli.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chkCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCli.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.chkCli.Properties.Appearance.Options.UseBackColor = True
        Me.chkCli.Properties.Appearance.Options.UseFont = True
        Me.chkCli.Properties.Appearance.Options.UseForeColor = True
        Me.chkCli.Properties.Caption = ""
        Me.chkCli.Size = New System.Drawing.Size(19, 19)
        Me.chkCli.TabIndex = 104
        Me.chkCli.ToolTip = "Selecione para alterar"
        Me.chkCli.Visible = False
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl53.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl53.Location = New System.Drawing.Point(26, 132)
        Me.LabelControl53.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(157, 17)
        Me.LabelControl53.TabIndex = 99
        Me.LabelControl53.Text = "Proprietário do Veículo"
        '
        'PanelControl6
        '
        Me.PanelControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl6.Location = New System.Drawing.Point(5, 139)
        Me.PanelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1153, 6)
        Me.PanelControl6.TabIndex = 98
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(282, 66)
        Me.LabelControl52.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl52.TabIndex = 96
        Me.LabelControl52.Text = "KM por Mês"
        '
        'txtKMMes
        '
        Me.txtKMMes.EnterMoveNextControl = True
        Me.txtKMMes.Location = New System.Drawing.Point(353, 63)
        Me.txtKMMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKMMes.Name = "txtKMMes"
        Me.txtKMMes.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKMMes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKMMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKMMes.Properties.MaxLength = 6
        Me.txtKMMes.Size = New System.Drawing.Size(168, 22)
        Me.txtKMMes.TabIndex = 5
        Me.txtKMMes.Tag = "KM"
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl54.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl54.Location = New System.Drawing.Point(26, 6)
        Me.LabelControl54.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(118, 17)
        Me.LabelControl54.TabIndex = 24
        Me.LabelControl54.Text = "Dados do Veículo"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.Controls.Add(Me.MemoEdit1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(0, 205)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1164, 69)
        Me.GroupControl4.TabIndex = 12
        Me.GroupControl4.Text = "Observações"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(2, 25)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MemoEdit1.Size = New System.Drawing.Size(1160, 42)
        Me.MemoEdit1.TabIndex = 0
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(59, 34)
        Me.LabelControl55.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl55.TabIndex = 2
        Me.LabelControl55.Text = "Placa"
        '
        'txtCha
        '
        Me.txtCha.EnterMoveNextControl = True
        Me.txtCha.Location = New System.Drawing.Point(638, 95)
        Me.txtCha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCha.Name = "txtCha"
        Me.txtCha.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCha.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCha.Properties.MaxLength = 30
        Me.txtCha.Size = New System.Drawing.Size(243, 22)
        Me.txtCha.TabIndex = 10
        Me.txtCha.Tag = "KM"
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(591, 34)
        Me.LabelControl56.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl56.TabIndex = 4
        Me.LabelControl56.Text = "Modelo"
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(595, 98)
        Me.LabelControl57.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl57.TabIndex = 36
        Me.LabelControl57.Text = "Chassi"
        '
        'txtMod
        '
        Me.txtMod.EnterMoveNextControl = True
        Me.txtMod.Location = New System.Drawing.Point(638, 31)
        Me.txtMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMod.Name = "txtMod"
        Me.txtMod.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMod.Properties.MaxLength = 49
        Me.txtMod.Size = New System.Drawing.Size(243, 22)
        Me.txtMod.TabIndex = 2
        Me.txtMod.Tag = "Modelo"
        '
        'txtVal
        '
        Me.txtVal.EnterMoveNextControl = True
        Me.txtVal.Location = New System.Drawing.Point(353, 95)
        Me.txtVal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVal.Properties.MaxLength = 5
        Me.txtVal.Size = New System.Drawing.Size(168, 22)
        Me.txtVal.TabIndex = 9
        Me.txtVal.Tag = "KM"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(966, 34)
        Me.LabelControl58.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(20, 16)
        Me.LabelControl58.TabIndex = 6
        Me.LabelControl58.Text = "Cor"
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(301, 98)
        Me.LabelControl59.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl59.TabIndex = 34
        Me.LabelControl59.Text = "Válvulas"
        '
        'txtCor
        '
        Me.txtCor.EnterMoveNextControl = True
        Me.txtCor.Location = New System.Drawing.Point(993, 31)
        Me.txtCor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCor.Properties.MaxLength = 29
        Me.txtCor.Size = New System.Drawing.Size(159, 22)
        Me.txtCor.TabIndex = 3
        Me.txtCor.Tag = "Cor"
        '
        'txtCil
        '
        Me.txtCil.EnterMoveNextControl = True
        Me.txtCil.Location = New System.Drawing.Point(96, 95)
        Me.txtCil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCil.Name = "txtCil"
        Me.txtCil.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCil.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCil.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCil.Properties.MaxLength = 10
        Me.txtCil.Size = New System.Drawing.Size(143, 22)
        Me.txtCil.TabIndex = 8
        Me.txtCil.Tag = "KM"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(22, 66)
        Me.LabelControl60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl60.TabIndex = 8
        Me.LabelControl60.Text = "Ano/Modelo"
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(42, 98)
        Me.LabelControl61.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl61.TabIndex = 32
        Me.LabelControl61.Text = "Cilindros"
        '
        'txtAno
        '
        Me.txtAno.EnterMoveNextControl = True
        Me.txtAno.Location = New System.Drawing.Point(96, 63)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAno.Properties.MaxLength = 9
        Me.txtAno.Size = New System.Drawing.Size(143, 22)
        Me.txtAno.TabIndex = 4
        Me.txtAno.Tag = "Ano"
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(937, 98)
        Me.LabelControl62.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl62.TabIndex = 10
        Me.LabelControl62.Text = "KM Atual"
        '
        'txtMot
        '
        Me.txtMot.EnterMoveNextControl = True
        Me.txtMot.Location = New System.Drawing.Point(993, 63)
        Me.txtMot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMot.Name = "txtMot"
        Me.txtMot.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMot.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMot.Properties.MaxLength = 30
        Me.txtMot.Size = New System.Drawing.Size(159, 22)
        Me.txtMot.TabIndex = 7
        Me.txtMot.Tag = "KM"
        '
        'txtKM
        '
        Me.txtKM.EnterMoveNextControl = True
        Me.txtKM.Location = New System.Drawing.Point(993, 95)
        Me.txtKM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKM.Properties.MaxLength = 6
        Me.txtKM.Size = New System.Drawing.Size(159, 22)
        Me.txtKM.TabIndex = 11
        Me.txtKM.Tag = "KM"
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(953, 66)
        Me.LabelControl63.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl63.TabIndex = 30
        Me.LabelControl63.Text = "Motor"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(57, 162)
        Me.LabelControl64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl64.TabIndex = 12
        Me.LabelControl64.Text = "Nome"
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(563, 66)
        Me.LabelControl65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl65.TabIndex = 28
        Me.LabelControl65.Text = "Combustível"
        '
        'txtPlaca
        '
        Me.txtPlaca.EnterMoveNextControl = True
        Me.txtPlaca.Location = New System.Drawing.Point(96, 31)
        Me.txtPlaca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPlaca.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPlaca.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Properties.MaxLength = 7
        Me.txtPlaca.Size = New System.Drawing.Size(143, 22)
        Me.txtPlaca.TabIndex = 0
        Me.txtPlaca.Tag = "Placa"
        '
        'cboComb
        '
        Me.cboComb.EnterMoveNextControl = True
        Me.cboComb.Location = New System.Drawing.Point(638, 63)
        Me.cboComb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboComb.Name = "cboComb"
        Me.cboComb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboComb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboComb.Properties.Items.AddRange(New Object() {"", "DIESEL", "ETANOL", "FLEX", "GASOLINA", "GNV", "GNV/GAS", "GNV/ETANOL", "GAS/ALC/GNV", "TETRAFUEL"})
        Me.cboComb.Properties.MaxLength = 20
        Me.cboComb.Size = New System.Drawing.Size(243, 22)
        Me.cboComb.TabIndex = 6
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(286, 34)
        Me.LabelControl66.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl66.TabIndex = 26
        Me.LabelControl66.Text = "Montadora"
        '
        'cboFab
        '
        Me.cboFab.EnterMoveNextControl = True
        Me.cboFab.Location = New System.Drawing.Point(353, 31)
        Me.cboFab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFab.Name = "cboFab"
        Me.cboFab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFab.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFab.Properties.Items.AddRange(New Object() {"", "AGRALE", "ALFA ROMEO", "AUDI", "BMW", "CHAMONIX", "CHERY", "CHRYSLER", "CITROEN", "CN AUTO", "DACIA", "DAEWOO", "DODGE", "EFFA", "FIAT", "FORD", "GM", "HAFEI", "HOLDEN", "HONDA", "HYUNDAI", "IVECO", "JAC", "JEEP", "KIA", "LANCIA", "LAND ROVER", "LEXUS", "MAHINDRA", "MAZDA", "MERCEDEZ-BENS", "MITSUBISHI", "NISSAN", "PEUGEOT", "RENAULT", "SEAT", "SHINERAY", "SKODA", "SSANGYOUNG", "SUZUKI", "TOYOTA", "TROLLER", "VOLKSWAGEN", "VOLVO", "YAMAHA", "OUTROS"})
        Me.cboFab.Properties.MaxLength = 50
        Me.cboFab.Size = New System.Drawing.Size(168, 22)
        Me.cboFab.TabIndex = 1
        '
        'PanelControl7
        '
        Me.PanelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl7.Location = New System.Drawing.Point(5, 14)
        Me.PanelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(1153, 6)
        Me.PanelControl7.TabIndex = 23
        '
        'tabOpc
        '
        Me.tabOpc.Controls.Add(Me.LabelControl67)
        Me.tabOpc.Controls.Add(Me.lstItens)
        Me.tabOpc.Controls.Add(Me.btnRemTudo)
        Me.tabOpc.Controls.Add(Me.btnRem)
        Me.tabOpc.Controls.Add(Me.btnAdd)
        Me.tabOpc.Controls.Add(Me.lstOpc)
        Me.tabOpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabOpc.Name = "tabOpc"
        Me.tabOpc.Size = New System.Drawing.Size(1164, 274)
        Me.tabOpc.Text = "Opcionais"
        '
        'LabelControl67
        '
        Me.LabelControl67.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl67.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl67.Location = New System.Drawing.Point(315, 5)
        Me.LabelControl67.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(141, 17)
        Me.LabelControl67.TabIndex = 27
        Me.LabelControl67.Text = "Opcionais do Veículo"
        '
        'lstItens
        '
        Me.lstItens.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItens.Appearance.Options.UseFont = True
        Me.lstItens.Location = New System.Drawing.Point(315, 23)
        Me.lstItens.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstItens.Name = "lstItens"
        Me.lstItens.Size = New System.Drawing.Size(187, 230)
        Me.lstItens.TabIndex = 4
        '
        'btnRemTudo
        '
        Me.btnRemTudo.Location = New System.Drawing.Point(202, 150)
        Me.btnRemTudo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemTudo.Name = "btnRemTudo"
        Me.btnRemTudo.Size = New System.Drawing.Size(106, 28)
        Me.btnRemTudo.TabIndex = 3
        Me.btnRemTudo.Text = "<< Todos"
        '
        'btnRem
        '
        Me.btnRem.Location = New System.Drawing.Point(202, 114)
        Me.btnRem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(106, 28)
        Me.btnRem.TabIndex = 2
        Me.btnRem.Text = "<<"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(202, 79)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 28)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = ">>"
        '
        'lstOpc
        '
        Me.lstOpc.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOpc.Appearance.Options.UseFont = True
        Me.lstOpc.CheckOnClick = True
        Me.lstOpc.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("4x2"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("4x4"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Turbo"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Aspirado"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("ABS"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Air Bag"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("A/C"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("D/H"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Câmbio Manual"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Câmbio Automático"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Direção Elétrica")})
        Me.lstOpc.Location = New System.Drawing.Point(8, 5)
        Me.lstOpc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstOpc.Name = "lstOpc"
        Me.lstOpc.Size = New System.Drawing.Size(187, 249)
        Me.lstOpc.TabIndex = 0
        '
        'tabImagem
        '
        Me.tabImagem.Controls.Add(Me.btnImagem6)
        Me.tabImagem.Controls.Add(Me.btnImagem5)
        Me.tabImagem.Controls.Add(Me.btnImagem4)
        Me.tabImagem.Controls.Add(Me.btnImagem3)
        Me.tabImagem.Controls.Add(Me.btnImagem2)
        Me.tabImagem.Controls.Add(Me.btnImagem1)
        Me.tabImagem.Controls.Add(Me.GroupControl5)
        Me.tabImagem.Controls.Add(Me.picImagem2)
        Me.tabImagem.Controls.Add(Me.picImagem3)
        Me.tabImagem.Controls.Add(Me.picImagem5)
        Me.tabImagem.Controls.Add(Me.picImagem6)
        Me.tabImagem.Controls.Add(Me.picImagem4)
        Me.tabImagem.Controls.Add(Me.picImagem1)
        Me.tabImagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabImagem.Name = "tabImagem"
        Me.tabImagem.Size = New System.Drawing.Size(1164, 274)
        Me.tabImagem.Text = "Imagens"
        '
        'btnImagem6
        '
        Me.btnImagem6.Location = New System.Drawing.Point(211, 603)
        Me.btnImagem6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem6.Name = "btnImagem6"
        Me.btnImagem6.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem6.TabIndex = 13
        Me.btnImagem6.Text = "Imagem 6"
        '
        'btnImagem5
        '
        Me.btnImagem5.Location = New System.Drawing.Point(26, 603)
        Me.btnImagem5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem5.Name = "btnImagem5"
        Me.btnImagem5.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem5.TabIndex = 12
        Me.btnImagem5.Text = "Imagem 5"
        '
        'btnImagem4
        '
        Me.btnImagem4.Location = New System.Drawing.Point(211, 390)
        Me.btnImagem4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem4.Name = "btnImagem4"
        Me.btnImagem4.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem4.TabIndex = 11
        Me.btnImagem4.Text = "Imagem 4"
        '
        'btnImagem3
        '
        Me.btnImagem3.Location = New System.Drawing.Point(26, 390)
        Me.btnImagem3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem3.Name = "btnImagem3"
        Me.btnImagem3.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem3.TabIndex = 10
        Me.btnImagem3.Text = "Imagem 3"
        '
        'btnImagem2
        '
        Me.btnImagem2.Location = New System.Drawing.Point(211, 176)
        Me.btnImagem2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem2.Name = "btnImagem2"
        Me.btnImagem2.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem2.TabIndex = 9
        Me.btnImagem2.Text = "Imagem 2"
        '
        'btnImagem1
        '
        Me.btnImagem1.Location = New System.Drawing.Point(26, 176)
        Me.btnImagem1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnImagem1.Name = "btnImagem1"
        Me.btnImagem1.Size = New System.Drawing.Size(140, 28)
        Me.btnImagem1.TabIndex = 8
        Me.btnImagem1.Text = "Imagem 1"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GroupControl6)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl5.Location = New System.Drawing.Point(398, 0)
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(766, 274)
        Me.GroupControl5.TabIndex = 7
        Me.GroupControl5.Text = "Imagem"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl6.Controls.Add(Me.SimpleButton1)
        Me.GroupControl6.Controls.Add(Me.PictureEdit1)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(2, 24)
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(762, 248)
        Me.GroupControl6.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = Global.Nano.My.Resources.Resources.viewmag
        Me.SimpleButton1.Location = New System.Drawing.Point(638, 206)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(121, 41)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "&Visualizar"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(758, 201)
        Me.PictureEdit1.TabIndex = 1
        '
        'picImagem2
        '
        Me.picImagem2.Location = New System.Drawing.Point(211, 22)
        Me.picImagem2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem2.Name = "picImagem2"
        Me.picImagem2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem2.Size = New System.Drawing.Size(140, 146)
        Me.picImagem2.TabIndex = 5
        '
        'picImagem3
        '
        Me.picImagem3.Location = New System.Drawing.Point(26, 236)
        Me.picImagem3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem3.Name = "picImagem3"
        Me.picImagem3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem3.Size = New System.Drawing.Size(140, 146)
        Me.picImagem3.TabIndex = 4
        '
        'picImagem5
        '
        Me.picImagem5.Location = New System.Drawing.Point(26, 449)
        Me.picImagem5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem5.Name = "picImagem5"
        Me.picImagem5.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem5.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem5.Size = New System.Drawing.Size(140, 146)
        Me.picImagem5.TabIndex = 3
        '
        'picImagem6
        '
        Me.picImagem6.Location = New System.Drawing.Point(211, 449)
        Me.picImagem6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem6.Name = "picImagem6"
        Me.picImagem6.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.picImagem6.Properties.Appearance.Options.UseBackColor = True
        Me.picImagem6.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem6.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem6.Size = New System.Drawing.Size(140, 146)
        Me.picImagem6.TabIndex = 2
        '
        'picImagem4
        '
        Me.picImagem4.Location = New System.Drawing.Point(211, 236)
        Me.picImagem4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem4.Name = "picImagem4"
        Me.picImagem4.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem4.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem4.Size = New System.Drawing.Size(140, 146)
        Me.picImagem4.TabIndex = 1
        '
        'picImagem1
        '
        Me.picImagem1.Location = New System.Drawing.Point(26, 22)
        Me.picImagem1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picImagem1.Name = "picImagem1"
        Me.picImagem1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Navy
        Me.picImagem1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.picImagem1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picImagem1.Size = New System.Drawing.Size(140, 146)
        Me.picImagem1.TabIndex = 0
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.Controls.Add(Me.SimpleButton2)
        Me.GroupControl7.Controls.Add(Me.SimpleButton3)
        Me.GroupControl7.Controls.Add(Me.CarroGridControl)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl7.Location = New System.Drawing.Point(0, 315)
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(1170, 423)
        Me.GroupControl7.TabIndex = 39
        Me.GroupControl7.Text = "Veículos Cadastrados no sistema"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Enabled = False
        Me.SimpleButton2.Location = New System.Drawing.Point(1079, 47)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(63, 20)
        Me.SimpleButton2.TabIndex = 105
        Me.SimpleButton2.Text = "Padrão"
        Me.SimpleButton2.ToolTip = "Configurações da grid padrão"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(1079, 28)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(63, 20)
        Me.SimpleButton3.TabIndex = 104
        Me.SimpleButton3.Text = "Manter"
        Me.SimpleButton3.ToolTip = "Manter as configurações da grid"
        '
        'CarroGridControl
        '
        Me.CarroGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarroGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CarroGridControl.Location = New System.Drawing.Point(2, 25)
        Me.CarroGridControl.MainView = Me.GridView1
        Me.CarroGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CarroGridControl.Name = "CarroGridControl"
        Me.CarroGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.lueLoja})
        Me.CarroGridControl.Size = New System.Drawing.Size(1166, 396)
        Me.CarroGridControl.TabIndex = 0
        Me.CarroGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.AliceBlue
        Me.GridView1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Row.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colPlaca, Me.colModelo, Me.colCor, Me.colAno, Me.colKM, Me.GridColumn2, Me.colNomeCliente, Me.colFabricante, Me.colCombustivel, Me.colMotor, Me.colCilindros, Me.colValvulas, Me.colChassi, Me.colObs, Me.colOpcionais, Me.colKMMes, Me.colCodConfig, Me.colCodCli})
        Me.GridView1.GridControl = Me.CarroGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Codigo"
        Me.GridColumn1.FieldName = "CodigoCarro"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.OptionsColumn.ReadOnly = True
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 0
        Me.colPlaca.Width = 98
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colModelo
        '
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.OptionsColumn.ReadOnly = True
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 1
        Me.colModelo.Width = 219
        '
        'colCor
        '
        Me.colCor.AppearanceCell.Options.UseTextOptions = True
        Me.colCor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCor.Caption = "Cor"
        Me.colCor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCor.FieldName = "Cor"
        Me.colCor.Name = "colCor"
        Me.colCor.OptionsColumn.ReadOnly = True
        Me.colCor.Visible = True
        Me.colCor.VisibleIndex = 2
        Me.colCor.Width = 112
        '
        'colAno
        '
        Me.colAno.AppearanceCell.Options.UseTextOptions = True
        Me.colAno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAno.Caption = "Ano"
        Me.colAno.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colAno.FieldName = "Ano"
        Me.colAno.Name = "colAno"
        Me.colAno.OptionsColumn.ReadOnly = True
        Me.colAno.Visible = True
        Me.colAno.VisibleIndex = 3
        Me.colAno.Width = 81
        '
        'colKM
        '
        Me.colKM.AppearanceCell.Options.UseTextOptions = True
        Me.colKM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKM.Caption = "KM Atual"
        Me.colKM.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colKM.FieldName = "KM"
        Me.colKM.Name = "colKM"
        Me.colKM.OptionsColumn.ReadOnly = True
        Me.colKM.Visible = True
        Me.colKM.VisibleIndex = 13
        Me.colKM.Width = 95
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Data Cadastro"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn2.FieldName = "Data"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 110
        '
        'colNomeCliente
        '
        Me.colNomeCliente.Caption = "Nome do Cliente"
        Me.colNomeCliente.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colNomeCliente.FieldName = "NomeCliente"
        Me.colNomeCliente.Name = "colNomeCliente"
        Me.colNomeCliente.OptionsColumn.ReadOnly = True
        Me.colNomeCliente.Visible = True
        Me.colNomeCliente.VisibleIndex = 5
        Me.colNomeCliente.Width = 253
        '
        'colFabricante
        '
        Me.colFabricante.Caption = "Fabricante"
        Me.colFabricante.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        Me.colFabricante.Visible = True
        Me.colFabricante.VisibleIndex = 7
        Me.colFabricante.Width = 90
        '
        'colCombustivel
        '
        Me.colCombustivel.Caption = "Combustível"
        Me.colCombustivel.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCombustivel.FieldName = "Combustivel"
        Me.colCombustivel.Name = "colCombustivel"
        Me.colCombustivel.OptionsColumn.ReadOnly = True
        Me.colCombustivel.Visible = True
        Me.colCombustivel.VisibleIndex = 8
        Me.colCombustivel.Width = 90
        '
        'colMotor
        '
        Me.colMotor.Caption = "Motor"
        Me.colMotor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colMotor.FieldName = "Motor"
        Me.colMotor.Name = "colMotor"
        Me.colMotor.OptionsColumn.ReadOnly = True
        Me.colMotor.Visible = True
        Me.colMotor.VisibleIndex = 9
        '
        'colCilindros
        '
        Me.colCilindros.Caption = "Cilindros"
        Me.colCilindros.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCilindros.FieldName = "Cilindros"
        Me.colCilindros.Name = "colCilindros"
        Me.colCilindros.OptionsColumn.ReadOnly = True
        Me.colCilindros.Visible = True
        Me.colCilindros.VisibleIndex = 10
        '
        'colValvulas
        '
        Me.colValvulas.Caption = "Válvulas"
        Me.colValvulas.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colValvulas.FieldName = "Valvulas"
        Me.colValvulas.Name = "colValvulas"
        Me.colValvulas.OptionsColumn.ReadOnly = True
        Me.colValvulas.Visible = True
        Me.colValvulas.VisibleIndex = 11
        '
        'colChassi
        '
        Me.colChassi.Caption = "Chassi"
        Me.colChassi.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colChassi.FieldName = "Chassi"
        Me.colChassi.Name = "colChassi"
        Me.colChassi.OptionsColumn.ReadOnly = True
        Me.colChassi.Visible = True
        Me.colChassi.VisibleIndex = 12
        '
        'colObs
        '
        Me.colObs.Caption = "Obs"
        Me.colObs.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colObs.FieldName = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.OptionsColumn.ReadOnly = True
        Me.colObs.Visible = True
        Me.colObs.VisibleIndex = 14
        '
        'colOpcionais
        '
        Me.colOpcionais.Caption = "Opcionais"
        Me.colOpcionais.FieldName = "Opcionais"
        Me.colOpcionais.Name = "colOpcionais"
        Me.colOpcionais.OptionsColumn.ReadOnly = True
        '
        'colKMMes
        '
        Me.colKMMes.AppearanceCell.Options.UseTextOptions = True
        Me.colKMMes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKMMes.Caption = "KM por Mês"
        Me.colKMMes.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colKMMes.FieldName = "KMMes"
        Me.colKMMes.Name = "colKMMes"
        Me.colKMMes.OptionsColumn.ReadOnly = True
        Me.colKMMes.Visible = True
        Me.colKMMes.VisibleIndex = 4
        Me.colKMMes.Width = 90
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
        Me.colCodConfig.VisibleIndex = 15
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 20, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.ValueMember = "Codigo"
        '
        'colCodCli
        '
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
        '
        'ofdImagem
        '
        Me.ofdImagem.FileName = "OpenFileDialog1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(2, 2)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.Size = New System.Drawing.Size(1162, 151)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1176, 815)
        Me.Controls.Add(Me.tbbCliente)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtQtdCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.chkInativar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbbCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbbCli.ResumeLayout(False)
        Me.tabPrincipal.ResumeLayout(False)
        Me.tabPrincipal.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.NanoCampo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoCampo5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbcImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nbcImagem.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.picCod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNasc.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNasc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRGIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCodFunc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabComp.ResumeLayout(False)
        Me.tabComp.PerformLayout()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelConj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeConj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTempTra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRG2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRG1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPessoa2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPessoa1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtDiasEmAtraso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtCad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalGasto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUltVis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNFE.ResumeLayout(False)
        Me.tabNFE.PerformLayout()
        CType(Me.txtSuframa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbbCliente.ResumeLayout(False)
        Me.tabCliente.ResumeLayout(False)
        Me.tabVeiculo.ResumeLayout(False)
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabPri.ResumeLayout(False)
        Me.tabPri.PerformLayout()
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKMMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboComb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOpc.ResumeLayout(False)
        Me.tabOpc.PerformLayout()
        CType(Me.lstItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstOpc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImagem.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.CarroGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ClienteGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRGIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCelular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtObs As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkIna As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colObservacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInadimplente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbbCli As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPrincipal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabComp As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtNasc As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSexo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNascimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLimite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkCPF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTel3 As Campos.NanoCampo
    Friend WithEvents txtEnd As Campos.NanoCampo
    Friend WithEvents txtTel1 As Campos.NanoCampo
    Friend WithEvents txtTel2 As Campos.NanoCampo
    Friend WithEvents txtWeb As Campos.NanoCampo
    Friend WithEvents txtCep As Campos.NanoCampo
    Friend WithEvents txtNum As Campos.NanoCampo
    Friend WithEvents txtComp As Campos.NanoCampo
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents txtCPF As Campos.NanoCampo
    Friend WithEvents txtRGIE As Campos.NanoCampo
    Friend WithEvents txtFant As Campos.NanoCampo
    Friend WithEvents chkIsento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtEmp As Campos.NanoCampo
    Friend WithEvents txtTelEmp As Campos.NanoCampo
    Friend WithEvents txtSal As Campos.NanoCampo
    Friend WithEvents txtLimite As Campos.NanoCampo
    Friend WithEvents txtdtCad As Campos.NanoCampo
    Friend WithEvents txtUltVis As Campos.NanoCampo
    Friend WithEvents colCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMarcas As Campos.NanoCampo
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colMarcas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRG2 As Campos.NanoCampo
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRG1 As Campos.NanoCampo
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPessoa2 As Campos.NanoCampo
    Friend WithEvents txtPessoa1 As Campos.NanoCampo
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colPessoa1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPessoa2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRG1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRG2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboMes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnVisualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkInativar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colInativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As Nano.dsNanoCommerceTableAdapters.ClienteTableAdapter
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTempTra As Campos.NanoCampo
    Friend WithEvents colTempoTrabalho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoradia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTotalGasto As System.Windows.Forms.Label
    Friend WithEvents txtTotalGasto As Campos.NanoCampo
    Friend WithEvents lblCred As System.Windows.Forms.Label
    Friend WithEvents txtCredito As Campos.NanoCampo
    Friend WithEvents cboMor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSalDev As Campos.NanoCampo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumCom As Campos.NanoCampo
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLimCli As Campos.NanoCampo
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelConj As Campos.NanoCampo
    Friend WithEvents txtNomeConj As Campos.NanoCampo
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colNomeConjuge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelConjuge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelCli As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabNFE As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPais As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCodPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomePais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSuframa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtCodMun As Campos.NanoCampo
    Friend WithEvents txtCodPais As Campos.NanoCampo
    Friend WithEvents txtSuframa As Campos.NanoCampo
    Friend WithEvents btnEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEti As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddEtiq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboModelo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnEtiquetaGeral As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConCPF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colProtestado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbcImagem As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nbgImagem As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picImagem As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnOcultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTirar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCarregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnConsumo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRelVendas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPerDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colDesconto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents picCod As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtContaCorrente As Campos.NanoCampo
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgencia As Campos.NanoCampo
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContaCorrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanco As Campos.NanoCampo
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents colContato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtContato As Campos.NanoCampo
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtdCli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRelCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbbCliente As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCliente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabVeiculo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CarroGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCombustivel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCilindros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValvulas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChassi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcionais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKMMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPri As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtKMMes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboComb As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFab As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabOpc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lstItens As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btnRemTudo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstOpc As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents tabImagem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnImagem6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImagem5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImagem4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImagem3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImagem2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImagem1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents picImagem1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ofdImagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkCli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCli As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueCodFunc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCodFunc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDiasEmAtraso As Campos.NanoCampo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents NanoCampo2 As Campos.NanoCampo
    Friend WithEvents NanoCampo3 As Campos.NanoCampo
    Friend WithEvents NanoCampo4 As Campos.NanoCampo
    Friend WithEvents NanoCampo5 As Campos.NanoCampo
    Friend WithEvents colEnderecoEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComplementoEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairroEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCepEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidadeEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCadBairro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBairro As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCadBairro2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NanoCampo1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
