<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigNfe
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigNfe))
        Me.cboCidade = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtFant = New Campos.NanoCampo()
        Me.txtEnd = New Campos.NanoCampo()
        Me.txtBairro = New Campos.NanoCampo()
        Me.txtTel1 = New Campos.NanoCampo()
        Me.txtCep = New Campos.NanoCampo()
        Me.txtNum = New Campos.NanoCampo()
        Me.txtNome = New Campos.NanoCampo()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCNPJ = New Campos.NanoCampo()
        Me.txtIE = New Campos.NanoCampo()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodMun = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnVoltar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAvancar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCSC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIM = New Campos.NanoCampo()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCNAE = New Campos.NanoCampo()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.chkIsento = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodMunicipioFG = New Campos.NanoCampo()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCRT = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnBuscaCNPJ = New DevExpress.XtraEditors.SimpleButton()
        Me.chkPadrao = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txtToken = New DevExpress.XtraEditors.TextEdit()
        Me.txtValAprox = New Campos.NanoCampo()
        Me.lblValAprox = New DevExpress.XtraEditors.LabelControl()
        Me.cboTipoEmi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIndPres = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIdDest = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIndFinal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTZD = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.btnNatOpe = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.memContribuinte = New DevExpress.XtraEditors.MemoEdit()
        Me.cboNat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboModFrete = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVersaoProc = New Campos.NanoCampo()
        Me.cboProcEmi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.cboFinalidade = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTipoImp = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTipoNf = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerie = New Campos.NanoCampo()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtModelo = New Campos.NanoCampo()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.txtComplemento = New Campos.NanoCampo()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtPortaImpressora = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.chkMensImpCupom = New DevExpress.XtraEditors.CheckEdit()
        Me.chkImpDireto = New DevExpress.XtraEditors.CheckEdit()
        Me.cboModeloImp = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.picLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumUltNota = New Campos.NanoCampo()
        Me.cboTipoAmb = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txtPastaBackup = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerialName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.dtVencimento = New DevExpress.XtraEditors.DateEdit()
        Me.txtCertificadoDigital = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.dsNfe = New System.Data.DataSet()
        Me.tbAut = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.tbNFe = New System.Data.DataTable()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.grd4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAddCPF = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExcluirCPF = New DevExpress.XtraEditors.SimpleButton()
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup()
        Me.txtCPFAut = New Campos.NanoCampo()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colRazao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFantasia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCNPJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodMun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodUF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodPais = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCRT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNatOp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoNF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoImp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoEmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoAmb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinNfe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProcEmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerProc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModFrete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObsCont = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTZDCce = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPadrao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colPastaBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCertificadoDigital = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVencimentoCertificado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerialName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdDest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndPres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVersaoXml = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAutXml = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComplemento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodMunicipioFG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCNAE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorValorAproximado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCSC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImpressora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPortaImpressora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImpDireto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMensImpCupom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colTokenNFCe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.fbdBackup = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog()
        Me.chkMensalista = New DevExpress.XtraEditors.CheckEdit()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtCSC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCNAE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodMunicipioFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCRT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPadrao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtToken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValAprox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoEmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIndPres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIdDest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIndFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTZD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memContribuinte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModFrete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersaoProc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProcEmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFinalidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoNf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.txtComplemento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtPortaImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.chkMensImpCupom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpDireto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.txtNumUltNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAmb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtPastaBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtSerialName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCertificadoDigital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsNfe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbNFe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPFAut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkMensalista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(19, 64)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(146, 18)
        Label6.TabIndex = 105
        Label6.Text = "Dados do Emitente"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(19, 5)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(116, 18)
        Label1.TabIndex = 107
        Label1.Text = "Dados da NF-e"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Blue
        Label3.Location = New System.Drawing.Point(19, 5)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(145, 18)
        Label3.TabIndex = 108
        Label3.Text = "Certificado Digital"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Blue
        Label2.Location = New System.Drawing.Point(19, 5)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(183, 18)
        Label2.TabIndex = 128
        Label2.Text = "Autorização CPF/CNPJ "
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Blue
        Label5.Location = New System.Drawing.Point(19, 160)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(169, 18)
        Label5.TabIndex = 106
        Label5.Text = "Endereço do Emitente"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.Blue
        Label7.Location = New System.Drawing.Point(19, 171)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(78, 18)
        Label7.TabIndex = 114
        Label7.Text = "Ambiente"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Blue
        Label4.Location = New System.Drawing.Point(19, 122)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(62, 18)
        Label4.TabIndex = 110
        Label4.Text = "Backup"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Blue
        Label8.Location = New System.Drawing.Point(463, 5)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(44, 18)
        Label8.TabIndex = 116
        Label8.Text = "Logo"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.Blue
        Label9.Location = New System.Drawing.Point(19, 5)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(96, 18)
        Label9.TabIndex = 109
        Label9.Text = "Busca CNPJ"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Blue
        Label10.Location = New System.Drawing.Point(19, 223)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(87, 18)
        Label10.TabIndex = 118
        Label10.Text = "Impressão"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(17, 11)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(110, 17)
        Label13.TabIndex = 120
        Label13.Text = "Mod. Impressora"
        '
        'cboCidade
        '
        Me.cboCidade.EnterMoveNextControl = True
        Me.cboCidade.Location = New System.Drawing.Point(80, 79)
        Me.cboCidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCidade.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCidade.Size = New System.Drawing.Size(138, 22)
        Me.cboCidade.TabIndex = 9
        Me.cboCidade.Tag = "Cidade"
        '
        'cboUF
        '
        Me.cboUF.EditValue = ""
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(80, 11)
        Me.cboUF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(138, 22)
        Me.cboUF.TabIndex = 0
        Me.cboUF.Tag = "UF"
        '
        'txtFant
        '
        Me.txtFant.CasasDecimais = 0
        Me.txtFant.EnterMoveNextControl = True
        Me.txtFant.Location = New System.Drawing.Point(80, 46)
        Me.txtFant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFant.Name = "txtFant"
        Me.txtFant.Numerico = False
        Me.txtFant.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFant.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtFant.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFant.Properties.MaxLength = 80
        Me.txtFant.Size = New System.Drawing.Size(138, 22)
        Me.txtFant.TabIndex = 3
        Me.txtFant.Tag = "Fantasia"
        '
        'txtEnd
        '
        Me.txtEnd.CasasDecimais = 0
        Me.txtEnd.EnterMoveNextControl = True
        Me.txtEnd.Location = New System.Drawing.Point(290, 15)
        Me.txtEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Numerico = False
        Me.txtEnd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEnd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnd.Properties.MaxLength = 100
        Me.txtEnd.Size = New System.Drawing.Size(373, 22)
        Me.txtEnd.TabIndex = 6
        Me.txtEnd.Tag = "Endereço"
        '
        'txtBairro
        '
        Me.txtBairro.CasasDecimais = 0
        Me.txtBairro.EnterMoveNextControl = True
        Me.txtBairro.Location = New System.Drawing.Point(290, 47)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Numerico = False
        Me.txtBairro.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBairro.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Properties.MaxLength = 100
        Me.txtBairro.Size = New System.Drawing.Size(152, 22)
        Me.txtBairro.TabIndex = 8
        Me.txtBairro.Tag = "Bairro"
        '
        'txtTel1
        '
        Me.txtTel1.CasasDecimais = 0
        Me.txtTel1.EnterMoveNextControl = True
        Me.txtTel1.Location = New System.Drawing.Point(532, 79)
        Me.txtTel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.Numerico = False
        Me.txtTel1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTel1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTel1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTel1.Properties.MaxLength = 18
        Me.txtTel1.Size = New System.Drawing.Size(132, 22)
        Me.txtTel1.TabIndex = 14
        Me.txtTel1.Tag = "Tel."
        '
        'txtCep
        '
        Me.txtCep.CasasDecimais = 0
        Me.txtCep.EnterMoveNextControl = True
        Me.txtCep.Location = New System.Drawing.Point(80, 15)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Numerico = False
        Me.txtCep.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCep.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCep.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCep.Properties.MaxLength = 10
        Me.txtCep.Size = New System.Drawing.Size(138, 22)
        Me.txtCep.TabIndex = 5
        Me.txtCep.Tag = "Cep"
        '
        'txtNum
        '
        Me.txtNum.CasasDecimais = 0
        Me.txtNum.EnterMoveNextControl = True
        Me.txtNum.Location = New System.Drawing.Point(80, 47)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Numerico = True
        Me.txtNum.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNum.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum.Properties.MaxLength = 10
        Me.txtNum.Size = New System.Drawing.Size(138, 22)
        Me.txtNum.TabIndex = 7
        Me.txtNum.Tag = "Número"
        '
        'txtNome
        '
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(80, 14)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtNome.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Properties.MaxLength = 150
        Me.txtNome.Size = New System.Drawing.Size(362, 22)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Tag = "Razão"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(476, 82)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl21.TabIndex = 87
        Me.LabelControl21.Text = "Telefone"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(231, 18)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl6.TabIndex = 80
        Me.LabelControl6.Text = "Endereço"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(251, 50)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl13.TabIndex = 83
        Me.LabelControl13.Text = "Bairro"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(59, 50)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl11.TabIndex = 82
        Me.LabelControl11.Text = "Nº"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(51, 18)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl14.TabIndex = 84
        Me.LabelControl14.Text = "Cep"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(58, 15)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(15, 16)
        Me.LabelControl16.TabIndex = 86
        Me.LabelControl16.Text = "UF"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(35, 82)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl15.TabIndex = 85
        Me.LabelControl15.Text = "Cidade"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.CasasDecimais = 0
        Me.txtCNPJ.EditValue = ""
        Me.txtCNPJ.EnterMoveNextControl = True
        Me.txtCNPJ.Location = New System.Drawing.Point(290, 11)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Numerico = False
        Me.txtCNPJ.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCNPJ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCNPJ.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCNPJ.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCNPJ.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNPJ.Properties.MaxLength = 20
        Me.txtCNPJ.Size = New System.Drawing.Size(152, 22)
        Me.txtCNPJ.TabIndex = 1
        Me.txtCNPJ.Tag = "CPF/CNPJ"
        '
        'txtIE
        '
        Me.txtIE.CasasDecimais = 0
        Me.txtIE.EnterMoveNextControl = True
        Me.txtIE.Location = New System.Drawing.Point(532, 14)
        Me.txtIE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Numerico = False
        Me.txtIE.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIE.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtIE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIE.Properties.MaxLength = 15
        Me.txtIE.Size = New System.Drawing.Size(132, 22)
        Me.txtIE.TabIndex = 2
        Me.txtIE.Tag = "IE - Aba Emitente"
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(225, 82)
        Me.LabelControl44.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl44.TabIndex = 91
        Me.LabelControl44.Text = "Cód. Mun."
        '
        'txtCodMun
        '
        Me.txtCodMun.EnterMoveNextControl = True
        Me.txtCodMun.Location = New System.Drawing.Point(290, 79)
        Me.txtCodMun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodMun.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodMun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodMun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodMun.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodMun.Properties.MaxLength = 10
        Me.txtCodMun.Size = New System.Drawing.Size(152, 22)
        Me.txtCodMun.TabIndex = 10
        Me.txtCodMun.Tag = "Cód. Mun."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(26, 53)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl4.TabIndex = 96
        Me.LabelControl4.Text = "Fantasia"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 17)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Razão"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(471, 17)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl3.TabIndex = 95
        Me.LabelControl3.Text = "Insc. Est."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelControl2.Location = New System.Drawing.Point(475, 15)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl2.TabIndex = 98
        Me.LabelControl2.Text = "Regime"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(254, 15)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 16)
        Me.LabelControl5.TabIndex = 99
        Me.LabelControl5.Text = "CNPJ"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnAlterar, Me.btnLimpar, Me.btnVoltar, Me.btnAvancar})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVoltar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAvancar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVoltar
        '
        Me.btnVoltar.Caption = "&Voltar"
        Me.btnVoltar.Glyph = Global.Nano.My.Resources.Resources.Back
        Me.btnVoltar.Id = 4
        Me.btnVoltar.Name = "btnVoltar"
        '
        'btnAvancar
        '
        Me.btnAvancar.Caption = "Ava&nçar"
        Me.btnAvancar.Glyph = Global.Nano.My.Resources.Resources._Next
        Me.btnAvancar.Id = 5
        Me.btnAvancar.Name = "btnAvancar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(885, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 649)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(885, 43)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 649)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(885, 0)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 649)
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.txtCSC)
        Me.PanelControl5.Controls.Add(Me.LabelControl38)
        Me.PanelControl5.Controls.Add(Me.txtIM)
        Me.PanelControl5.Controls.Add(Me.LabelControl37)
        Me.PanelControl5.Controls.Add(Me.txtCNAE)
        Me.PanelControl5.Controls.Add(Me.LabelControl36)
        Me.PanelControl5.Controls.Add(Me.txtFant)
        Me.PanelControl5.Controls.Add(Me.chkIsento)
        Me.PanelControl5.Controls.Add(Me.txtNome)
        Me.PanelControl5.Controls.Add(Me.txtIE)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Location = New System.Drawing.Point(6, 74)
        Me.PanelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(673, 81)
        Me.PanelControl5.TabIndex = 0
        '
        'txtCSC
        '
        Me.txtCSC.EnterMoveNextControl = True
        Me.txtCSC.Location = New System.Drawing.Point(290, 46)
        Me.txtCSC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCSC.Name = "txtCSC"
        Me.txtCSC.Size = New System.Drawing.Size(373, 22)
        Me.txtCSC.TabIndex = 108
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(260, 49)
        Me.LabelControl38.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl38.TabIndex = 107
        Me.LabelControl38.Text = "CSC"
        '
        'txtIM
        '
        Me.txtIM.CasasDecimais = 0
        Me.txtIM.EnterMoveNextControl = True
        Me.txtIM.Location = New System.Drawing.Point(532, 46)
        Me.txtIM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIM.Name = "txtIM"
        Me.txtIM.Numerico = False
        Me.txtIM.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIM.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtIM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIM.Properties.MaxLength = 15
        Me.txtIM.Size = New System.Drawing.Size(132, 22)
        Me.txtIM.TabIndex = 104
        Me.txtIM.Tag = "IE - Aba Emitente"
        Me.txtIM.Visible = False
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(465, 49)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl37.TabIndex = 105
        Me.LabelControl37.Text = "Insc. Mun."
        Me.LabelControl37.Visible = False
        '
        'txtCNAE
        '
        Me.txtCNAE.CasasDecimais = 0
        Me.txtCNAE.EnterMoveNextControl = True
        Me.txtCNAE.Location = New System.Drawing.Point(290, 46)
        Me.txtCNAE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCNAE.Name = "txtCNAE"
        Me.txtCNAE.Numerico = False
        Me.txtCNAE.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCNAE.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCNAE.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNAE.Properties.MaxLength = 7
        Me.txtCNAE.Size = New System.Drawing.Size(152, 22)
        Me.txtCNAE.TabIndex = 102
        Me.txtCNAE.Tag = "IE - Aba Emitente"
        Me.txtCNAE.Visible = False
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(252, 49)
        Me.LabelControl36.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl36.TabIndex = 103
        Me.LabelControl36.Text = "CNAE"
        Me.LabelControl36.Visible = False
        '
        'chkIsento
        '
        Me.chkIsento.Location = New System.Drawing.Point(643, 16)
        Me.chkIsento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIsento.Name = "chkIsento"
        Me.chkIsento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.chkIsento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsento.Properties.Appearance.Options.UseBackColor = True
        Me.chkIsento.Properties.Appearance.Options.UseFont = True
        Me.chkIsento.Properties.Caption = ""
        Me.chkIsento.Size = New System.Drawing.Size(19, 19)
        Me.chkIsento.TabIndex = 101
        Me.chkIsento.ToolTip = "Selecione se for Isento"
        Me.chkIsento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.chkIsento.ToolTipTitle = "Isento"
        '
        'txtCodMunicipioFG
        '
        Me.txtCodMunicipioFG.CasasDecimais = 0
        Me.txtCodMunicipioFG.EnterMoveNextControl = True
        Me.txtCodMunicipioFG.Location = New System.Drawing.Point(370, 15)
        Me.txtCodMunicipioFG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodMunicipioFG.Name = "txtCodMunicipioFG"
        Me.txtCodMunicipioFG.Numerico = False
        Me.txtCodMunicipioFG.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodMunicipioFG.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodMunicipioFG.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodMunicipioFG.Properties.MaxLength = 15
        Me.txtCodMunicipioFG.Size = New System.Drawing.Size(132, 22)
        Me.txtCodMunicipioFG.TabIndex = 102
        Me.txtCodMunicipioFG.Tag = "IE - Aba Emitente"
        Me.txtCodMunicipioFG.Visible = False
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(316, 18)
        Me.LabelControl33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl33.TabIndex = 103
        Me.LabelControl33.Text = "Mun. FG"
        Me.LabelControl33.Visible = False
        '
        'cboCRT
        '
        Me.cboCRT.EnterMoveNextControl = True
        Me.cboCRT.Location = New System.Drawing.Point(532, 11)
        Me.cboCRT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCRT.Name = "cboCRT"
        Me.cboCRT.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCRT.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCRT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCRT.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCRT.Properties.Items.AddRange(New Object() {"SIMPLES NACIONAL", "TRIBUTAÇÃO NORMAL"})
        Me.cboCRT.Size = New System.Drawing.Size(132, 22)
        Me.cboCRT.TabIndex = 2
        Me.cboCRT.Tag = "Regime - Aba Emitente"
        '
        'btnBuscaCNPJ
        '
        Me.btnBuscaCNPJ.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnBuscaCNPJ.Location = New System.Drawing.Point(441, 10)
        Me.btnBuscaCNPJ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscaCNPJ.Name = "btnBuscaCNPJ"
        Me.btnBuscaCNPJ.Size = New System.Drawing.Size(24, 26)
        Me.btnBuscaCNPJ.TabIndex = 2
        Me.btnBuscaCNPJ.Text = "SimpleButton1"
        '
        'chkPadrao
        '
        Me.chkPadrao.Location = New System.Drawing.Point(601, 0)
        Me.chkPadrao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkPadrao.Name = "chkPadrao"
        Me.chkPadrao.Properties.Caption = "Principal"
        Me.chkPadrao.Size = New System.Drawing.Size(87, 21)
        Me.chkPadrao.TabIndex = 100
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl40)
        Me.PanelControl1.Controls.Add(Me.txtToken)
        Me.PanelControl1.Controls.Add(Me.txtValAprox)
        Me.PanelControl1.Controls.Add(Me.lblValAprox)
        Me.PanelControl1.Controls.Add(Me.cboTipoEmi)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.cboIndPres)
        Me.PanelControl1.Controls.Add(Me.LabelControl28)
        Me.PanelControl1.Controls.Add(Me.cboIdDest)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.cboIndFinal)
        Me.PanelControl1.Controls.Add(Me.LabelControl25)
        Me.PanelControl1.Controls.Add(Me.cboTZD)
        Me.PanelControl1.Controls.Add(Me.LabelControl26)
        Me.PanelControl1.Controls.Add(Me.btnNatOpe)
        Me.PanelControl1.Controls.Add(Me.LabelControl24)
        Me.PanelControl1.Controls.Add(Me.memContribuinte)
        Me.PanelControl1.Controls.Add(Me.cboNat)
        Me.PanelControl1.Controls.Add(Me.cboModFrete)
        Me.PanelControl1.Controls.Add(Me.LabelControl23)
        Me.PanelControl1.Controls.Add(Me.LabelControl22)
        Me.PanelControl1.Controls.Add(Me.txtVersaoProc)
        Me.PanelControl1.Controls.Add(Me.cboProcEmi)
        Me.PanelControl1.Controls.Add(Me.LabelControl20)
        Me.PanelControl1.Controls.Add(Me.cboFinalidade)
        Me.PanelControl1.Controls.Add(Me.LabelControl19)
        Me.PanelControl1.Controls.Add(Me.cboTipoImp)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.cboTipoNf)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txtSerie)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txtModelo)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 15)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(672, 272)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(477, 229)
        Me.LabelControl40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl40.TabIndex = 150
        Me.LabelControl40.Text = "Token"
        '
        'txtToken
        '
        Me.txtToken.EnterMoveNextControl = True
        Me.txtToken.Location = New System.Drawing.Point(518, 225)
        Me.txtToken.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(138, 22)
        Me.txtToken.TabIndex = 149
        '
        'txtValAprox
        '
        Me.txtValAprox.CasasDecimais = 2
        Me.txtValAprox.EnterMoveNextControl = True
        Me.txtValAprox.Location = New System.Drawing.Point(518, 140)
        Me.txtValAprox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtValAprox.Name = "txtValAprox"
        Me.txtValAprox.Numerico = True
        Me.txtValAprox.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValAprox.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValAprox.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValAprox.Properties.MaxLength = 7
        Me.txtValAprox.Size = New System.Drawing.Size(138, 22)
        Me.txtValAprox.TabIndex = 147
        Me.txtValAprox.Tag = ""
        Me.txtValAprox.Visible = False
        '
        'lblValAprox
        '
        Me.lblValAprox.Location = New System.Drawing.Point(448, 144)
        Me.lblValAprox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblValAprox.Name = "lblValAprox"
        Me.lblValAprox.Size = New System.Drawing.Size(63, 16)
        Me.lblValAprox.TabIndex = 148
        Me.lblValAprox.Text = "Val. Aprox."
        Me.lblValAprox.Visible = False
        '
        'cboTipoEmi
        '
        Me.cboTipoEmi.EditValue = "1 - Normal - emissão normal"
        Me.cboTipoEmi.Enabled = False
        Me.cboTipoEmi.EnterMoveNextControl = True
        Me.cboTipoEmi.Location = New System.Drawing.Point(80, 44)
        Me.cboTipoEmi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoEmi.Name = "cboTipoEmi"
        Me.cboTipoEmi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoEmi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipoEmi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoEmi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoEmi.Properties.Items.AddRange(New Object() {"1 - Normal - emissão normal", "2 - Contingência FS - emissão em contingência com impressão do DANFE em Formulári" & _
                "o de Segurança", "3 - Contingência SCAN - emissão em contingência no Sistema de Contingência do Amb" & _
                "iente Nacional", "4 - Contingência DPEC - emissão em contingência com envio da Declaração Prévia de" & _
                " Emissão em Contingência - DPEC", "5 - Contingência FS-DA - emissão em contingência com impressão do DANFE em Formul" & _
                "ário de Segurança para Impressão de Documento Auxiliar de Documento Fiscal Eletr" & _
                "ônico (FS-DA)"})
        Me.cboTipoEmi.Size = New System.Drawing.Size(358, 22)
        Me.cboTipoEmi.TabIndex = 1
        Me.cboTipoEmi.Tag = "Tipo Emi."
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(23, 48)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl17.TabIndex = 109
        Me.LabelControl17.Text = "Tipo Emi."
        '
        'cboIndPres
        '
        Me.cboIndPres.EnterMoveNextControl = True
        Me.cboIndPres.Location = New System.Drawing.Point(518, 172)
        Me.cboIndPres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIndPres.Name = "cboIndPres"
        Me.cboIndPres.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboIndPres.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboIndPres.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIndPres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIndPres.Properties.Items.AddRange(New Object() {"0 - Não se aplica", "1 - Operação presencial", "2 - Operação não presencial, pela Internet", "3 - Operação não presencial, Teleatendimento", "9 - Operação não presencial, outros"})
        Me.cboIndPres.Size = New System.Drawing.Size(138, 22)
        Me.cboIndPres.TabIndex = 15
        Me.cboIndPres.Tag = "Tipo Ate"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(460, 176)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl28.TabIndex = 146
        Me.LabelControl28.Text = "Tipo Ate."
        '
        'cboIdDest
        '
        Me.cboIdDest.EnterMoveNextControl = True
        Me.cboIdDest.Location = New System.Drawing.Point(302, 172)
        Me.cboIdDest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIdDest.Name = "cboIdDest"
        Me.cboIdDest.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboIdDest.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboIdDest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIdDest.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIdDest.Properties.Items.AddRange(New Object() {"1 - Operação Interna", "2 - Operação Interestadual", "3 - Operação com Exterior"})
        Me.cboIdDest.Size = New System.Drawing.Size(136, 22)
        Me.cboIdDest.TabIndex = 14
        Me.cboIdDest.Tag = "Dest. Ope."
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(233, 176)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl27.TabIndex = 144
        Me.LabelControl27.Text = "Dest. Ope."
        '
        'cboIndFinal
        '
        Me.cboIndFinal.EnterMoveNextControl = True
        Me.cboIndFinal.Location = New System.Drawing.Point(80, 172)
        Me.cboIndFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIndFinal.Name = "cboIndFinal"
        Me.cboIndFinal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboIndFinal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboIndFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIndFinal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIndFinal.Properties.Items.AddRange(New Object() {"0 - Não", "1 - Sim"})
        Me.cboIndFinal.Size = New System.Drawing.Size(138, 22)
        Me.cboIndFinal.TabIndex = 13
        Me.cboIndFinal.Tag = "Cons. Final"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(12, 175)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl25.TabIndex = 142
        Me.LabelControl25.Text = "Cons. Final"
        '
        'cboTZD
        '
        Me.cboTZD.EnterMoveNextControl = True
        Me.cboTZD.Location = New System.Drawing.Point(302, 140)
        Me.cboTZD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTZD.Name = "cboTZD"
        Me.cboTZD.Properties.Appearance.Options.UseTextOptions = True
        Me.cboTZD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboTZD.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTZD.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTZD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTZD.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTZD.Properties.Items.AddRange(New Object() {"-02:00", "-03:00", "-04:00"})
        Me.cboTZD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTZD.Size = New System.Drawing.Size(136, 22)
        Me.cboTZD.TabIndex = 11
        Me.cboTZD.Tag = "TZD"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(224, 144)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl26.TabIndex = 140
        Me.LabelControl26.Text = "Fuso Horário"
        '
        'btnNatOpe
        '
        Me.btnNatOpe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnNatOpe.Location = New System.Drawing.Point(440, 12)
        Me.btnNatOpe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNatOpe.Name = "btnNatOpe"
        Me.btnNatOpe.Size = New System.Drawing.Size(23, 25)
        Me.btnNatOpe.TabIndex = 138
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Location = New System.Drawing.Point(12, 206)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(262, 17)
        Me.LabelControl24.TabIndex = 137
        Me.LabelControl24.Text = "Informações Complementares Padrão"
        '
        'memContribuinte
        '
        Me.memContribuinte.Location = New System.Drawing.Point(6, 226)
        Me.memContribuinte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.memContribuinte.Name = "memContribuinte"
        Me.memContribuinte.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.memContribuinte.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.memContribuinte.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memContribuinte.Size = New System.Drawing.Size(433, 37)
        Me.memContribuinte.TabIndex = 16
        Me.memContribuinte.Tag = "Inf. Comp."
        '
        'cboNat
        '
        Me.cboNat.EnterMoveNextControl = True
        Me.cboNat.Location = New System.Drawing.Point(80, 12)
        Me.cboNat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNat.Name = "cboNat"
        Me.cboNat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNat.Properties.Items.AddRange(New Object() {"VENDA", "COMPRA", "DEVOLUÇÃO"})
        Me.cboNat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNat.Size = New System.Drawing.Size(358, 22)
        Me.cboNat.TabIndex = 0
        Me.cboNat.Tag = "Nat. Oper."
        '
        'cboModFrete
        '
        Me.cboModFrete.EnterMoveNextControl = True
        Me.cboModFrete.Location = New System.Drawing.Point(80, 140)
        Me.cboModFrete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModFrete.Name = "cboModFrete"
        Me.cboModFrete.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboModFrete.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboModFrete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModFrete.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModFrete.Properties.Items.AddRange(New Object() {"0 - Por conta do emitente", "1 - Por conta do destinatário/remetente", "2 - Por conta de terceiros", "9 - Sem frete"})
        Me.cboModFrete.Size = New System.Drawing.Size(138, 22)
        Me.cboModFrete.TabIndex = 10
        Me.cboModFrete.Tag = "Mod. Frete"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(12, 144)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl23.TabIndex = 119
        Me.LabelControl23.Text = "Mod. Frete"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(455, 112)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl22.TabIndex = 117
        Me.LabelControl22.Text = "Ver. Proc."
        '
        'txtVersaoProc
        '
        Me.txtVersaoProc.CasasDecimais = 0
        Me.txtVersaoProc.Enabled = False
        Me.txtVersaoProc.EnterMoveNextControl = True
        Me.txtVersaoProc.Location = New System.Drawing.Point(518, 108)
        Me.txtVersaoProc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVersaoProc.Name = "txtVersaoProc"
        Me.txtVersaoProc.Numerico = False
        Me.txtVersaoProc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVersaoProc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVersaoProc.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVersaoProc.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtVersaoProc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVersaoProc.Properties.MaxLength = 15
        Me.txtVersaoProc.Size = New System.Drawing.Size(138, 22)
        Me.txtVersaoProc.TabIndex = 9
        Me.txtVersaoProc.Tag = "Ver. Proc."
        '
        'cboProcEmi
        '
        Me.cboProcEmi.EditValue = "0 - emissão de NF-e com aplicativo do contribuinte"
        Me.cboProcEmi.Enabled = False
        Me.cboProcEmi.EnterMoveNextControl = True
        Me.cboProcEmi.Location = New System.Drawing.Point(80, 108)
        Me.cboProcEmi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboProcEmi.Name = "cboProcEmi"
        Me.cboProcEmi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboProcEmi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboProcEmi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProcEmi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProcEmi.Properties.Items.AddRange(New Object() {"0 - emissão de NF-e com aplicativo do contribuinte", "1 - emissão de NF-e avulsa pelo Fisco", "2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, atravé" & _
                "s do site do Fisco", "3- emissão NF-e pelo contribuinte com aplicativo fornecido pelo Fisco"})
        Me.cboProcEmi.Size = New System.Drawing.Size(358, 22)
        Me.cboProcEmi.TabIndex = 8
        Me.cboProcEmi.Tag = "Proc. Emi."
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(17, 112)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl20.TabIndex = 115
        Me.LabelControl20.Text = "Proc. Emi."
        '
        'cboFinalidade
        '
        Me.cboFinalidade.EditValue = "1 - NF-e normal"
        Me.cboFinalidade.Enabled = False
        Me.cboFinalidade.EnterMoveNextControl = True
        Me.cboFinalidade.Location = New System.Drawing.Point(518, 76)
        Me.cboFinalidade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFinalidade.Name = "cboFinalidade"
        Me.cboFinalidade.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboFinalidade.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboFinalidade.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFinalidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFinalidade.Properties.Items.AddRange(New Object() {"1 - NF-e normal", "2 - NF-e complementar", "3 - NF-e de ajuste"})
        Me.cboFinalidade.Size = New System.Drawing.Size(138, 22)
        Me.cboFinalidade.TabIndex = 7
        Me.cboFinalidade.Tag = "Finalidade"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(455, 80)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl19.TabIndex = 113
        Me.LabelControl19.Text = "Finalidade"
        '
        'cboTipoImp
        '
        Me.cboTipoImp.EditValue = "4 - Cupom"
        Me.cboTipoImp.Enabled = False
        Me.cboTipoImp.EnterMoveNextControl = True
        Me.cboTipoImp.Location = New System.Drawing.Point(302, 76)
        Me.cboTipoImp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoImp.Name = "cboTipoImp"
        Me.cboTipoImp.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoImp.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipoImp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoImp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoImp.Properties.Items.AddRange(New Object() {"1 - Retrato", "2 - Paisagem", "4 - Cupom"})
        Me.cboTipoImp.Size = New System.Drawing.Size(136, 22)
        Me.cboTipoImp.TabIndex = 5
        Me.cboTipoImp.Tag = "Tipo Imp."
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(243, 80)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl12.TabIndex = 107
        Me.LabelControl12.Text = "Tipo Imp."
        '
        'cboTipoNf
        '
        Me.cboTipoNf.EnterMoveNextControl = True
        Me.cboTipoNf.Location = New System.Drawing.Point(80, 76)
        Me.cboTipoNf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoNf.Name = "cboTipoNf"
        Me.cboTipoNf.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoNf.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipoNf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoNf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoNf.Properties.Items.AddRange(New Object() {"0 - Entrada", "1 - Saída"})
        Me.cboTipoNf.Size = New System.Drawing.Size(138, 22)
        Me.cboTipoNf.TabIndex = 4
        Me.cboTipoNf.Tag = "Tipo NF"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(31, 80)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl10.TabIndex = 105
        Me.LabelControl10.Text = "Tipo NF"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(483, 48)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl9.TabIndex = 103
        Me.LabelControl9.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.CasasDecimais = 0
        Me.txtSerie.EnterMoveNextControl = True
        Me.txtSerie.Location = New System.Drawing.Point(518, 44)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Numerico = False
        Me.txtSerie.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSerie.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSerie.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSerie.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Properties.MaxLength = 15
        Me.txtSerie.Size = New System.Drawing.Size(138, 22)
        Me.txtSerie.TabIndex = 3
        Me.txtSerie.Tag = "Série"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(471, 16)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl8.TabIndex = 101
        Me.LabelControl8.Text = "Modelo"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 16)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl7.TabIndex = 98
        Me.LabelControl7.Text = "Nat. Oper."
        '
        'txtModelo
        '
        Me.txtModelo.CasasDecimais = 0
        Me.txtModelo.EditValue = "65"
        Me.txtModelo.Enabled = False
        Me.txtModelo.EnterMoveNextControl = True
        Me.txtModelo.Location = New System.Drawing.Point(518, 12)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Numerico = False
        Me.txtModelo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtModelo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtModelo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModelo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Properties.MaxLength = 15
        Me.txtModelo.Size = New System.Drawing.Size(138, 22)
        Me.txtModelo.TabIndex = 2
        Me.txtModelo.Tag = "Modelo"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(885, 338)
        Me.XtraTabControl1.TabIndex = 110
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage4, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Label9)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage1.Controls.Add(Label6)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage1.Controls.Add(Label5)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(879, 309)
        Me.XtraTabPage1.Text = "Emitente"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.cboCRT)
        Me.PanelControl9.Controls.Add(Me.cboUF)
        Me.PanelControl9.Controls.Add(Me.LabelControl16)
        Me.PanelControl9.Controls.Add(Me.txtCNPJ)
        Me.PanelControl9.Controls.Add(Me.LabelControl2)
        Me.PanelControl9.Controls.Add(Me.LabelControl5)
        Me.PanelControl9.Controls.Add(Me.btnBuscaCNPJ)
        Me.PanelControl9.Location = New System.Drawing.Point(6, 15)
        Me.PanelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(673, 46)
        Me.PanelControl9.TabIndex = 0
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.txtEnd)
        Me.PanelControl6.Controls.Add(Me.txtComplemento)
        Me.PanelControl6.Controls.Add(Me.txtCodMunicipioFG)
        Me.PanelControl6.Controls.Add(Me.LabelControl33)
        Me.PanelControl6.Controls.Add(Me.LabelControl30)
        Me.PanelControl6.Controls.Add(Me.txtCep)
        Me.PanelControl6.Controls.Add(Me.cboCidade)
        Me.PanelControl6.Controls.Add(Me.txtCodMun)
        Me.PanelControl6.Controls.Add(Me.LabelControl15)
        Me.PanelControl6.Controls.Add(Me.txtBairro)
        Me.PanelControl6.Controls.Add(Me.LabelControl44)
        Me.PanelControl6.Controls.Add(Me.txtTel1)
        Me.PanelControl6.Controls.Add(Me.LabelControl14)
        Me.PanelControl6.Controls.Add(Me.LabelControl11)
        Me.PanelControl6.Controls.Add(Me.txtNum)
        Me.PanelControl6.Controls.Add(Me.LabelControl13)
        Me.PanelControl6.Controls.Add(Me.LabelControl21)
        Me.PanelControl6.Controls.Add(Me.LabelControl6)
        Me.PanelControl6.Location = New System.Drawing.Point(6, 171)
        Me.PanelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(672, 113)
        Me.PanelControl6.TabIndex = 2
        '
        'txtComplemento
        '
        Me.txtComplemento.CasasDecimais = 0
        Me.txtComplemento.EnterMoveNextControl = True
        Me.txtComplemento.Location = New System.Drawing.Point(532, 47)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Numerico = False
        Me.txtComplemento.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComplemento.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Properties.MaxLength = 100
        Me.txtComplemento.Size = New System.Drawing.Size(132, 22)
        Me.txtComplemento.TabIndex = 92
        Me.txtComplemento.Tag = "Bairro"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(449, 50)
        Me.LabelControl30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl30.TabIndex = 93
        Me.LabelControl30.Text = "Complemento"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Label1)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(693, 309)
        Me.XtraTabPage2.Text = "NF-e"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txtPortaImpressora)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl39)
        Me.XtraTabPage4.Controls.Add(Label10)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl10)
        Me.XtraTabPage4.Controls.Add(Label8)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl8)
        Me.XtraTabPage4.Controls.Add(Label7)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage4.Controls.Add(Label4)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage4.Controls.Add(Label3)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(693, 309)
        Me.XtraTabPage4.Text = "Configurações"
        '
        'txtPortaImpressora
        '
        Me.txtPortaImpressora.Location = New System.Drawing.Point(353, 240)
        Me.txtPortaImpressora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPortaImpressora.Name = "txtPortaImpressora"
        Me.txtPortaImpressora.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtPortaImpressora.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtPortaImpressora.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPortaImpressora.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPortaImpressora.Size = New System.Drawing.Size(317, 22)
        Me.txtPortaImpressora.TabIndex = 126
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(288, 244)
        Me.LabelControl39.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl39.TabIndex = 125
        Me.LabelControl39.Text = "Nome Imp."
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.chkMensImpCupom)
        Me.PanelControl10.Controls.Add(Me.chkImpDireto)
        Me.PanelControl10.Controls.Add(Label13)
        Me.PanelControl10.Controls.Add(Me.cboModeloImp)
        Me.PanelControl10.Location = New System.Drawing.Point(5, 233)
        Me.PanelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(671, 64)
        Me.PanelControl10.TabIndex = 119
        '
        'chkMensImpCupom
        '
        Me.chkMensImpCupom.Location = New System.Drawing.Point(449, 36)
        Me.chkMensImpCupom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkMensImpCupom.Name = "chkMensImpCupom"
        Me.chkMensImpCupom.Properties.Caption = "Mens. Imp. Cupom?"
        Me.chkMensImpCupom.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMensImpCupom.Size = New System.Drawing.Size(135, 21)
        Me.chkMensImpCupom.TabIndex = 129
        '
        'chkImpDireto
        '
        Me.chkImpDireto.Location = New System.Drawing.Point(348, 36)
        Me.chkImpDireto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkImpDireto.Name = "chkImpDireto"
        Me.chkImpDireto.Properties.Caption = "Imp. Direto"
        Me.chkImpDireto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpDireto.Size = New System.Drawing.Size(87, 21)
        Me.chkImpDireto.TabIndex = 128
        '
        'cboModeloImp
        '
        Me.cboModeloImp.EnterMoveNextControl = True
        Me.cboModeloImp.Location = New System.Drawing.Point(124, 7)
        Me.cboModeloImp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModeloImp.Name = "cboModeloImp"
        Me.cboModeloImp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModeloImp.Properties.Items.AddRange(New Object() {"", "TERMICA", "TERMICA MARGEM", "MP-4200 TH", "DARUMA", "EPSON", "NORMAL"})
        Me.cboModeloImp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModeloImp.Size = New System.Drawing.Size(154, 22)
        Me.cboModeloImp.TabIndex = 119
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.picLogo)
        Me.PanelControl8.Location = New System.Drawing.Point(455, 15)
        Me.PanelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(220, 208)
        Me.PanelControl8.TabIndex = 117
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(6, 10)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(210, 186)
        Me.picLogo.TabIndex = 0
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.LabelControl29)
        Me.PanelControl7.Controls.Add(Me.txtNumUltNota)
        Me.PanelControl7.Controls.Add(Me.cboTipoAmb)
        Me.PanelControl7.Controls.Add(Me.LabelControl18)
        Me.PanelControl7.Location = New System.Drawing.Point(5, 181)
        Me.PanelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(443, 42)
        Me.PanelControl7.TabIndex = 115
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(285, 14)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl29.TabIndex = 115
        Me.LabelControl29.Text = "Ult. NCF-e"
        '
        'txtNumUltNota
        '
        Me.txtNumUltNota.CasasDecimais = 0
        Me.txtNumUltNota.EnterMoveNextControl = True
        Me.txtNumUltNota.Location = New System.Drawing.Point(349, 10)
        Me.txtNumUltNota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumUltNota.Name = "txtNumUltNota"
        Me.txtNumUltNota.Numerico = True
        Me.txtNumUltNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumUltNota.Properties.Appearance.Options.UseFont = True
        Me.txtNumUltNota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumUltNota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumUltNota.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumUltNota.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumUltNota.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumUltNota.Properties.MaxLength = 10
        Me.txtNumUltNota.Size = New System.Drawing.Size(83, 23)
        Me.txtNumUltNota.TabIndex = 114
        Me.txtNumUltNota.Tag = "Número Ult NF-e"
        '
        'cboTipoAmb
        '
        Me.cboTipoAmb.EditValue = "2 - Homologação"
        Me.cboTipoAmb.EnterMoveNextControl = True
        Me.cboTipoAmb.Location = New System.Drawing.Point(124, 10)
        Me.cboTipoAmb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoAmb.Name = "cboTipoAmb"
        Me.cboTipoAmb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboTipoAmb.Properties.Appearance.Options.UseFont = True
        Me.cboTipoAmb.Properties.Appearance.Options.UseTextOptions = True
        Me.cboTipoAmb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboTipoAmb.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoAmb.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboTipoAmb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAmb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoAmb.Properties.Items.AddRange(New Object() {"1 - Produção", "2 - Homologação"})
        Me.cboTipoAmb.Size = New System.Drawing.Size(154, 23)
        Me.cboTipoAmb.TabIndex = 112
        Me.cboTipoAmb.Tag = "Tipo. Amb."
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(37, 14)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl18.TabIndex = 113
        Me.LabelControl18.Text = "Tipo Ambiente"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.txtPastaBackup)
        Me.PanelControl4.Controls.Add(Me.LabelControl32)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 132)
        Me.PanelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(442, 38)
        Me.PanelControl4.TabIndex = 111
        '
        'txtPastaBackup
        '
        Me.txtPastaBackup.EnterMoveNextControl = True
        Me.txtPastaBackup.Location = New System.Drawing.Point(124, 7)
        Me.txtPastaBackup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPastaBackup.Name = "txtPastaBackup"
        Me.txtPastaBackup.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPastaBackup.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtPastaBackup.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPastaBackup.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPastaBackup.Size = New System.Drawing.Size(308, 22)
        Me.txtPastaBackup.TabIndex = 103
        Me.txtPastaBackup.Tag = "Pasta Backup"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(34, 11)
        Me.LabelControl32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl32.TabIndex = 3
        Me.LabelControl32.Text = "Caminho Pasta"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl35)
        Me.PanelControl3.Controls.Add(Me.txtSerialName)
        Me.PanelControl3.Controls.Add(Me.LabelControl34)
        Me.PanelControl3.Controls.Add(Me.dtVencimento)
        Me.PanelControl3.Controls.Add(Me.txtCertificadoDigital)
        Me.PanelControl3.Controls.Add(Me.LabelControl31)
        Me.PanelControl3.Location = New System.Drawing.Point(5, 15)
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(443, 107)
        Me.PanelControl3.TabIndex = 109
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(51, 48)
        Me.LabelControl35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl35.TabIndex = 107
        Me.LabelControl35.Text = "Serial Name"
        '
        'txtSerialName
        '
        Me.txtSerialName.Enabled = False
        Me.txtSerialName.Location = New System.Drawing.Point(124, 44)
        Me.txtSerialName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSerialName.Name = "txtSerialName"
        Me.txtSerialName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtSerialName.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtSerialName.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSerialName.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSerialName.Size = New System.Drawing.Size(308, 22)
        Me.txtSerialName.TabIndex = 106
        Me.txtSerialName.Tag = "Serial Name"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(52, 80)
        Me.LabelControl34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl34.TabIndex = 105
        Me.LabelControl34.Text = "Vencimento"
        '
        'dtVencimento
        '
        Me.dtVencimento.EditValue = Nothing
        Me.dtVencimento.Enabled = False
        Me.dtVencimento.Location = New System.Drawing.Point(124, 76)
        Me.dtVencimento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dtVencimento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dtVencimento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtVencimento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtVencimento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtVencimento.Size = New System.Drawing.Size(308, 22)
        Me.dtVencimento.TabIndex = 103
        Me.dtVencimento.Tag = "Vencimento"
        '
        'txtCertificadoDigital
        '
        Me.txtCertificadoDigital.EnterMoveNextControl = True
        Me.txtCertificadoDigital.Location = New System.Drawing.Point(124, 12)
        Me.txtCertificadoDigital.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCertificadoDigital.Name = "txtCertificadoDigital"
        Me.txtCertificadoDigital.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCertificadoDigital.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCertificadoDigital.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCertificadoDigital.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCertificadoDigital.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCertificadoDigital.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtCertificadoDigital.Size = New System.Drawing.Size(308, 22)
        Me.txtCertificadoDigital.TabIndex = 102
        Me.txtCertificadoDigital.Tag = "Nome Certificado"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(47, 16)
        Me.LabelControl31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl31.TabIndex = 3
        Me.LabelControl31.Text = "Razão Social"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Label2)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(693, 309)
        Me.XtraTabPage3.Text = "Autorização Download"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GridControl3)
        Me.PanelControl2.Controls.Add(Me.btnAddCPF)
        Me.PanelControl2.Controls.Add(Me.btnExcluirCPF)
        Me.PanelControl2.Controls.Add(Me.rdgDoc)
        Me.PanelControl2.Controls.Add(Me.txtCPFAut)
        Me.PanelControl2.Location = New System.Drawing.Point(10, 17)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(665, 271)
        Me.PanelControl2.TabIndex = 128
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbAut"
        Me.GridControl3.DataSource = Me.dsNfe
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl3.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl3.Location = New System.Drawing.Point(2, 49)
        Me.GridControl3.MainView = Me.grd4
        Me.GridControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(661, 194)
        Me.GridControl3.TabIndex = 126
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd4})
        '
        'dsNfe
        '
        Me.dsNfe.DataSetName = "NewDataSet"
        Me.dsNfe.Tables.AddRange(New System.Data.DataTable() {Me.tbAut, Me.tbNFe})
        '
        'tbAut
        '
        Me.tbAut.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbAut.TableName = "tbAut"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Item"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CPF"
        '
        'tbNFe
        '
        Me.tbNFe.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54})
        Me.tbNFe.TableName = "tbNFe"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Codigo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Razao"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Fantasia"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CNPJ"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "IE"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Endereco"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Bairro"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Numero"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Cidade"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "CodMun"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Cep"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "UF"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "CodUF"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Pais"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "CodPais"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "CRT"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Telefone"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "NatOp"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Mod"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Serie"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "TipoNF"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "TipoImp"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "TipoEmi"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "TipoAmb"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "FinNfe"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ProcEmi"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "VerProc"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ModFrete"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ObsCont"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "TZDCce"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Padrao"
        Me.DataColumn33.DataType = GetType(Boolean)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Email"
        Me.DataColumn34.DataType = GetType(Boolean)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "PastaBackup"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "SerialName"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "CertificadoDigital"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "VencimentoCertificado"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "IndFinal"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "IndPres"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "IdDest"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "VersaoXml"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "AutXml"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "Complemento"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "CodMunicipioFG"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "IM"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "CNAE"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "PorValorAproximado"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "CSC"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "Impressora"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "PortaImpressora"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "ImpDireto"
        Me.DataColumn52.DataType = GetType(Boolean)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "MensImpCupom"
        Me.DataColumn53.DataType = GetType(Boolean)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "TokenNFCe"
        '
        'grd4
        '
        Me.grd4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItem, Me.colCPF})
        Me.grd4.GridControl = Me.GridControl3
        Me.grd4.Name = "grd4"
        Me.grd4.OptionsView.ShowGroupPanel = False
        '
        'colItem
        '
        Me.colItem.Caption = "Item"
        Me.colItem.FieldName = "Item"
        Me.colItem.Name = "colItem"
        Me.colItem.OptionsColumn.ReadOnly = True
        Me.colItem.Visible = True
        Me.colItem.VisibleIndex = 0
        Me.colItem.Width = 455
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 1
        Me.colCPF.Width = 449
        '
        'btnAddCPF
        '
        Me.btnAddCPF.Location = New System.Drawing.Point(534, 15)
        Me.btnAddCPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddCPF.Name = "btnAddCPF"
        Me.btnAddCPF.Size = New System.Drawing.Size(117, 26)
        Me.btnAddCPF.TabIndex = 125
        Me.btnAddCPF.Text = "&Adicionar"
        '
        'btnExcluirCPF
        '
        Me.btnExcluirCPF.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcluirCPF.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnExcluirCPF.Location = New System.Drawing.Point(2, 243)
        Me.btnExcluirCPF.LookAndFeel.SkinName = "Money Twins"
        Me.btnExcluirCPF.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnExcluirCPF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluirCPF.Name = "btnExcluirCPF"
        Me.btnExcluirCPF.Size = New System.Drawing.Size(661, 26)
        Me.btnExcluirCPF.TabIndex = 127
        Me.btnExcluirCPF.Text = "Excluir Item"
        '
        'rdgDoc
        '
        Me.rdgDoc.EditValue = True
        Me.rdgDoc.Location = New System.Drawing.Point(22, 16)
        Me.rdgDoc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(118, 25)
        Me.rdgDoc.TabIndex = 4
        '
        'txtCPFAut
        '
        Me.txtCPFAut.CasasDecimais = 0
        Me.txtCPFAut.EnterMoveNextControl = True
        Me.txtCPFAut.Location = New System.Drawing.Point(147, 16)
        Me.txtCPFAut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCPFAut.Name = "txtCPFAut"
        Me.txtCPFAut.Numerico = False
        Me.txtCPFAut.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPFAut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPFAut.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPFAut.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPFAut.Properties.MaxLength = 20
        Me.txtCPFAut.Size = New System.Drawing.Size(227, 22)
        Me.txtCPFAut.TabIndex = 5
        Me.txtCPFAut.Tag = "CPF/CNPJ"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbNFe"
        Me.GridControl1.DataSource = Me.dsNfe
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 25)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4})
        Me.GridControl1.Size = New System.Drawing.Size(881, 284)
        Me.GridControl1.TabIndex = 111
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colRazao, Me.colFantasia, Me.colCNPJ, Me.colIE, Me.colEndereco, Me.colBairro, Me.colNumero, Me.colCidade, Me.colCodMun, Me.colCep, Me.colUF, Me.colCodUF, Me.colPais, Me.colCodPais, Me.colCRT, Me.colTelefone, Me.colNatOp, Me.colMod, Me.colSerie, Me.colTipoNF, Me.colTipoImp, Me.colTipoEmi, Me.colTipoAmb, Me.colFinNfe, Me.colProcEmi, Me.colVerProc, Me.colModFrete, Me.colObsCont, Me.colTZDCce, Me.colPadrao, Me.colPastaBackup, Me.colEmail, Me.colCertificadoDigital, Me.colVencimentoCertificado, Me.colSerialName, Me.colIdDest, Me.colIndFinal, Me.colIndPres, Me.colVersaoXml, Me.colAutXml, Me.colComplemento, Me.colCodMunicipioFG, Me.colCNAE, Me.colIM, Me.colPorValorAproximado, Me.colCSC, Me.colImpressora, Me.colPortaImpressora, Me.colImpDireto, Me.colMensImpCupom, Me.colTokenNFCe})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.ColumnEdit = Me.txtAlterar
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 72
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colRazao
        '
        Me.colRazao.Caption = "Razão"
        Me.colRazao.ColumnEdit = Me.txtAlterar
        Me.colRazao.FieldName = "Razao"
        Me.colRazao.Name = "colRazao"
        Me.colRazao.Visible = True
        Me.colRazao.VisibleIndex = 1
        Me.colRazao.Width = 252
        '
        'colFantasia
        '
        Me.colFantasia.Caption = "Fantasia"
        Me.colFantasia.ColumnEdit = Me.txtAlterar
        Me.colFantasia.FieldName = "Fantasia"
        Me.colFantasia.Name = "colFantasia"
        Me.colFantasia.Visible = True
        Me.colFantasia.VisibleIndex = 2
        Me.colFantasia.Width = 142
        '
        'colCNPJ
        '
        Me.colCNPJ.Caption = "CNPJ"
        Me.colCNPJ.ColumnEdit = Me.txtAlterar
        Me.colCNPJ.FieldName = "CNPJ"
        Me.colCNPJ.Name = "colCNPJ"
        Me.colCNPJ.Visible = True
        Me.colCNPJ.VisibleIndex = 3
        Me.colCNPJ.Width = 120
        '
        'colIE
        '
        Me.colIE.Caption = "IE"
        Me.colIE.ColumnEdit = Me.txtAlterar
        Me.colIE.FieldName = "IE"
        Me.colIE.Name = "colIE"
        Me.colIE.Visible = True
        Me.colIE.VisibleIndex = 4
        Me.colIE.Width = 103
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.ColumnEdit = Me.txtAlterar
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.Visible = True
        Me.colEndereco.VisibleIndex = 5
        Me.colEndereco.Width = 165
        '
        'colBairro
        '
        Me.colBairro.Caption = "Bairro"
        Me.colBairro.ColumnEdit = Me.txtAlterar
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.Visible = True
        Me.colBairro.VisibleIndex = 6
        Me.colBairro.Width = 123
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.ColumnEdit = Me.txtAlterar
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 7
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.ColumnEdit = Me.txtAlterar
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.Visible = True
        Me.colCidade.VisibleIndex = 8
        Me.colCidade.Width = 107
        '
        'colCodMun
        '
        Me.colCodMun.Caption = "Cód. Mun."
        Me.colCodMun.ColumnEdit = Me.txtAlterar
        Me.colCodMun.FieldName = "CodMun"
        Me.colCodMun.Name = "colCodMun"
        Me.colCodMun.Visible = True
        Me.colCodMun.VisibleIndex = 9
        Me.colCodMun.Width = 82
        '
        'colCep
        '
        Me.colCep.Caption = "Cep"
        Me.colCep.ColumnEdit = Me.txtAlterar
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.Visible = True
        Me.colCep.VisibleIndex = 10
        '
        'colUF
        '
        Me.colUF.Caption = "UF"
        Me.colUF.ColumnEdit = Me.txtAlterar
        Me.colUF.FieldName = "UF"
        Me.colUF.Name = "colUF"
        Me.colUF.Visible = True
        Me.colUF.VisibleIndex = 11
        '
        'colCodUF
        '
        Me.colCodUF.Caption = "Cód. UF"
        Me.colCodUF.ColumnEdit = Me.txtAlterar
        Me.colCodUF.FieldName = "CodUF"
        Me.colCodUF.Name = "colCodUF"
        Me.colCodUF.Visible = True
        Me.colCodUF.VisibleIndex = 12
        '
        'colPais
        '
        Me.colPais.Caption = "País"
        Me.colPais.ColumnEdit = Me.txtAlterar
        Me.colPais.FieldName = "Pais"
        Me.colPais.Name = "colPais"
        Me.colPais.Visible = True
        Me.colPais.VisibleIndex = 13
        '
        'colCodPais
        '
        Me.colCodPais.Caption = "Cód. País"
        Me.colCodPais.ColumnEdit = Me.txtAlterar
        Me.colCodPais.FieldName = "CodPais"
        Me.colCodPais.Name = "colCodPais"
        Me.colCodPais.Visible = True
        Me.colCodPais.VisibleIndex = 14
        '
        'colCRT
        '
        Me.colCRT.Caption = "CRT"
        Me.colCRT.ColumnEdit = Me.txtAlterar
        Me.colCRT.FieldName = "CRT"
        Me.colCRT.Name = "colCRT"
        Me.colCRT.Visible = True
        Me.colCRT.VisibleIndex = 15
        '
        'colTelefone
        '
        Me.colTelefone.Caption = "Telefone"
        Me.colTelefone.ColumnEdit = Me.txtAlterar
        Me.colTelefone.FieldName = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.Visible = True
        Me.colTelefone.VisibleIndex = 16
        '
        'colNatOp
        '
        Me.colNatOp.Caption = "Nat. Op."
        Me.colNatOp.ColumnEdit = Me.txtAlterar
        Me.colNatOp.FieldName = "NatOp"
        Me.colNatOp.Name = "colNatOp"
        Me.colNatOp.Visible = True
        Me.colNatOp.VisibleIndex = 17
        '
        'colMod
        '
        Me.colMod.Caption = "Mod."
        Me.colMod.ColumnEdit = Me.txtAlterar
        Me.colMod.FieldName = "Mod"
        Me.colMod.Name = "colMod"
        Me.colMod.Visible = True
        Me.colMod.VisibleIndex = 18
        '
        'colSerie
        '
        Me.colSerie.Caption = "Série"
        Me.colSerie.ColumnEdit = Me.txtAlterar
        Me.colSerie.FieldName = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.Visible = True
        Me.colSerie.VisibleIndex = 19
        '
        'colTipoNF
        '
        Me.colTipoNF.Caption = "Tipo NF"
        Me.colTipoNF.ColumnEdit = Me.txtAlterar
        Me.colTipoNF.FieldName = "TipoNF"
        Me.colTipoNF.Name = "colTipoNF"
        Me.colTipoNF.Visible = True
        Me.colTipoNF.VisibleIndex = 20
        '
        'colTipoImp
        '
        Me.colTipoImp.Caption = "Tipo Imp."
        Me.colTipoImp.ColumnEdit = Me.txtAlterar
        Me.colTipoImp.FieldName = "TipoImp"
        Me.colTipoImp.Name = "colTipoImp"
        Me.colTipoImp.Visible = True
        Me.colTipoImp.VisibleIndex = 21
        '
        'colTipoEmi
        '
        Me.colTipoEmi.Caption = "Tipo Emi."
        Me.colTipoEmi.ColumnEdit = Me.txtAlterar
        Me.colTipoEmi.FieldName = "TipoEmi"
        Me.colTipoEmi.Name = "colTipoEmi"
        Me.colTipoEmi.Visible = True
        Me.colTipoEmi.VisibleIndex = 22
        '
        'colTipoAmb
        '
        Me.colTipoAmb.Caption = "Tipo Amb."
        Me.colTipoAmb.ColumnEdit = Me.txtAlterar
        Me.colTipoAmb.FieldName = "TipoAmb"
        Me.colTipoAmb.Name = "colTipoAmb"
        Me.colTipoAmb.Visible = True
        Me.colTipoAmb.VisibleIndex = 23
        '
        'colFinNfe
        '
        Me.colFinNfe.Caption = "Fin. NF-e"
        Me.colFinNfe.ColumnEdit = Me.txtAlterar
        Me.colFinNfe.FieldName = "FinNfe"
        Me.colFinNfe.Name = "colFinNfe"
        Me.colFinNfe.Visible = True
        Me.colFinNfe.VisibleIndex = 24
        '
        'colProcEmi
        '
        Me.colProcEmi.Caption = "Proc. Emi."
        Me.colProcEmi.ColumnEdit = Me.txtAlterar
        Me.colProcEmi.FieldName = "ProcEmi"
        Me.colProcEmi.Name = "colProcEmi"
        Me.colProcEmi.Visible = True
        Me.colProcEmi.VisibleIndex = 25
        '
        'colVerProc
        '
        Me.colVerProc.Caption = "Ver. Proc."
        Me.colVerProc.ColumnEdit = Me.txtAlterar
        Me.colVerProc.FieldName = "VerProc"
        Me.colVerProc.Name = "colVerProc"
        Me.colVerProc.Visible = True
        Me.colVerProc.VisibleIndex = 26
        '
        'colModFrete
        '
        Me.colModFrete.Caption = "Mod. Frete"
        Me.colModFrete.ColumnEdit = Me.txtAlterar
        Me.colModFrete.FieldName = "ModFrete"
        Me.colModFrete.Name = "colModFrete"
        Me.colModFrete.Visible = True
        Me.colModFrete.VisibleIndex = 27
        '
        'colObsCont
        '
        Me.colObsCont.Caption = "Obs Cont."
        Me.colObsCont.ColumnEdit = Me.txtAlterar
        Me.colObsCont.FieldName = "ObsCont"
        Me.colObsCont.Name = "colObsCont"
        Me.colObsCont.Visible = True
        Me.colObsCont.VisibleIndex = 28
        '
        'colTZDCce
        '
        Me.colTZDCce.Caption = "TZD CC-e"
        Me.colTZDCce.ColumnEdit = Me.txtAlterar
        Me.colTZDCce.FieldName = "TZDCce"
        Me.colTZDCce.Name = "colTZDCce"
        Me.colTZDCce.Visible = True
        Me.colTZDCce.VisibleIndex = 29
        '
        'colPadrao
        '
        Me.colPadrao.Caption = "Padrão"
        Me.colPadrao.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colPadrao.FieldName = "Padrao"
        Me.colPadrao.Name = "colPadrao"
        Me.colPadrao.Visible = True
        Me.colPadrao.VisibleIndex = 30
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colPastaBackup
        '
        Me.colPastaBackup.Caption = "Backup"
        Me.colPastaBackup.FieldName = "PastaBackup"
        Me.colPastaBackup.Name = "colPastaBackup"
        Me.colPastaBackup.OptionsColumn.ReadOnly = True
        Me.colPastaBackup.Visible = True
        Me.colPastaBackup.VisibleIndex = 32
        '
        'colEmail
        '
        Me.colEmail.Caption = "E-Mail"
        Me.colEmail.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 33
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colCertificadoDigital
        '
        Me.colCertificadoDigital.Caption = "Certificado Digital"
        Me.colCertificadoDigital.FieldName = "CertificadoDigital"
        Me.colCertificadoDigital.Name = "colCertificadoDigital"
        Me.colCertificadoDigital.OptionsColumn.ReadOnly = True
        Me.colCertificadoDigital.Visible = True
        Me.colCertificadoDigital.VisibleIndex = 31
        Me.colCertificadoDigital.Width = 146
        '
        'colVencimentoCertificado
        '
        Me.colVencimentoCertificado.Caption = "Venc. Certificado"
        Me.colVencimentoCertificado.FieldName = "VencimentoCertificado"
        Me.colVencimentoCertificado.Name = "colVencimentoCertificado"
        Me.colVencimentoCertificado.OptionsColumn.ReadOnly = True
        Me.colVencimentoCertificado.Visible = True
        Me.colVencimentoCertificado.VisibleIndex = 34
        '
        'colSerialName
        '
        Me.colSerialName.Caption = "Serial Name"
        Me.colSerialName.FieldName = "SerialName"
        Me.colSerialName.Name = "colSerialName"
        Me.colSerialName.OptionsColumn.ReadOnly = True
        Me.colSerialName.Visible = True
        Me.colSerialName.VisibleIndex = 35
        '
        'colIdDest
        '
        Me.colIdDest.Caption = "Dest. Ope."
        Me.colIdDest.FieldName = "IdDest"
        Me.colIdDest.Name = "colIdDest"
        Me.colIdDest.OptionsColumn.ReadOnly = True
        Me.colIdDest.Visible = True
        Me.colIdDest.VisibleIndex = 36
        '
        'colIndFinal
        '
        Me.colIndFinal.Caption = "Cons. Final"
        Me.colIndFinal.FieldName = "IndFinal"
        Me.colIndFinal.Name = "colIndFinal"
        Me.colIndFinal.OptionsColumn.ReadOnly = True
        Me.colIndFinal.Visible = True
        Me.colIndFinal.VisibleIndex = 37
        '
        'colIndPres
        '
        Me.colIndPres.Caption = "Tipo Ate."
        Me.colIndPres.FieldName = "IndPres"
        Me.colIndPres.Name = "colIndPres"
        Me.colIndPres.OptionsColumn.ReadOnly = True
        Me.colIndPres.Visible = True
        Me.colIndPres.VisibleIndex = 38
        '
        'colVersaoXml
        '
        Me.colVersaoXml.Caption = "Versão Xml"
        Me.colVersaoXml.FieldName = "VersaoXml"
        Me.colVersaoXml.Name = "colVersaoXml"
        Me.colVersaoXml.OptionsColumn.ReadOnly = True
        Me.colVersaoXml.Visible = True
        Me.colVersaoXml.VisibleIndex = 39
        '
        'colAutXml
        '
        Me.colAutXml.Caption = "Aut. Xml"
        Me.colAutXml.FieldName = "AutXml"
        Me.colAutXml.Name = "colAutXml"
        Me.colAutXml.OptionsColumn.ReadOnly = True
        Me.colAutXml.Visible = True
        Me.colAutXml.VisibleIndex = 40
        '
        'colComplemento
        '
        Me.colComplemento.Caption = "Complemento"
        Me.colComplemento.FieldName = "Complemento"
        Me.colComplemento.Name = "colComplemento"
        Me.colComplemento.OptionsColumn.ReadOnly = True
        Me.colComplemento.Visible = True
        Me.colComplemento.VisibleIndex = 41
        '
        'colCodMunicipioFG
        '
        Me.colCodMunicipioFG.Caption = "Cód. Mun. FG"
        Me.colCodMunicipioFG.FieldName = "CodMunicipioFG"
        Me.colCodMunicipioFG.Name = "colCodMunicipioFG"
        Me.colCodMunicipioFG.OptionsColumn.ReadOnly = True
        '
        'colCNAE
        '
        Me.colCNAE.Caption = "CNAE"
        Me.colCNAE.FieldName = "CNAE"
        Me.colCNAE.Name = "colCNAE"
        Me.colCNAE.OptionsColumn.ReadOnly = True
        Me.colCNAE.Visible = True
        Me.colCNAE.VisibleIndex = 42
        '
        'colIM
        '
        Me.colIM.Caption = "IM"
        Me.colIM.FieldName = "IM"
        Me.colIM.Name = "colIM"
        Me.colIM.OptionsColumn.ReadOnly = True
        Me.colIM.Visible = True
        Me.colIM.VisibleIndex = 43
        '
        'colPorValorAproximado
        '
        Me.colPorValorAproximado.Caption = "Val. Aprox."
        Me.colPorValorAproximado.FieldName = "PorValorAproximado"
        Me.colPorValorAproximado.Name = "colPorValorAproximado"
        Me.colPorValorAproximado.OptionsColumn.ReadOnly = True
        '
        'colCSC
        '
        Me.colCSC.Caption = "CSC"
        Me.colCSC.FieldName = "CSC"
        Me.colCSC.Name = "colCSC"
        Me.colCSC.OptionsColumn.ReadOnly = True
        Me.colCSC.Visible = True
        Me.colCSC.VisibleIndex = 44
        '
        'colImpressora
        '
        Me.colImpressora.Caption = "Impressora"
        Me.colImpressora.FieldName = "Impressora"
        Me.colImpressora.Name = "colImpressora"
        Me.colImpressora.OptionsColumn.ReadOnly = True
        Me.colImpressora.Visible = True
        Me.colImpressora.VisibleIndex = 45
        '
        'colPortaImpressora
        '
        Me.colPortaImpressora.Caption = "Porta Imp."
        Me.colPortaImpressora.FieldName = "PortaImpressora"
        Me.colPortaImpressora.Name = "colPortaImpressora"
        Me.colPortaImpressora.OptionsColumn.ReadOnly = True
        Me.colPortaImpressora.Visible = True
        Me.colPortaImpressora.VisibleIndex = 46
        '
        'colImpDireto
        '
        Me.colImpDireto.Caption = "Imp. Direto"
        Me.colImpDireto.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.colImpDireto.FieldName = "ImpDireto"
        Me.colImpDireto.Name = "colImpDireto"
        Me.colImpDireto.OptionsColumn.ReadOnly = True
        Me.colImpDireto.Visible = True
        Me.colImpDireto.VisibleIndex = 47
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'colMensImpCupom
        '
        Me.colMensImpCupom.Caption = "Mens. Imp. Cupom"
        Me.colMensImpCupom.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.colMensImpCupom.FieldName = "MensImpCupom"
        Me.colMensImpCupom.Name = "colMensImpCupom"
        Me.colMensImpCupom.OptionsColumn.ReadOnly = True
        Me.colMensImpCupom.Visible = True
        Me.colMensImpCupom.VisibleIndex = 48
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'colTokenNFCe
        '
        Me.colTokenNFCe.Caption = "Token"
        Me.colTokenNFCe.FieldName = "TokenNFCe"
        Me.colTokenNFCe.Name = "colTokenNFCe"
        Me.colTokenNFCe.OptionsColumn.ReadOnly = True
        Me.colTokenNFCe.Visible = True
        Me.colTokenNFCe.VisibleIndex = 49
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.chkPadrao)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 338)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(885, 311)
        Me.GroupControl1.TabIndex = 112
        Me.GroupControl1.Text = "Emitentes Cadastrados"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ofdImagem
        '
        Me.ofdImagem.FileName = "OpenFileDialog1"
        '
        'chkMensalista
        '
        Me.chkMensalista.Location = New System.Drawing.Point(580, 4)
        Me.chkMensalista.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkMensalista.Name = "chkMensalista"
        Me.chkMensalista.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkMensalista.Properties.Appearance.Options.UseFont = True
        Me.chkMensalista.Properties.Caption = "Mensalista"
        Me.chkMensalista.Size = New System.Drawing.Size(100, 22)
        Me.chkMensalista.TabIndex = 112
        Me.chkMensalista.Visible = False
        '
        'frmConfigNfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 692)
        Me.Controls.Add(Me.chkMensalista)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigNfe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração Emitente NF-e"
        CType(Me.cboCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBairro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodMun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.txtCSC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCNAE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodMunicipioFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCRT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPadrao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtToken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValAprox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoEmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIndPres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIdDest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIndFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTZD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memContribuinte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModFrete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersaoProc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProcEmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFinalidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoNf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.txtComplemento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txtPortaImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        CType(Me.chkMensImpCupom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpDireto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.picLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.txtNumUltNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAmb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txtPastaBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtSerialName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCertificadoDigital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsNfe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbNFe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPFAut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkMensalista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboCidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtFant As Campos.NanoCampo
    Friend WithEvents txtEnd As Campos.NanoCampo
    Friend WithEvents txtBairro As Campos.NanoCampo
    Friend WithEvents txtTel1 As Campos.NanoCampo
    Friend WithEvents txtCep As Campos.NanoCampo
    Friend WithEvents txtNum As Campos.NanoCampo
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCNPJ As Campos.NanoCampo
    Friend WithEvents txtIE As Campos.NanoCampo
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodMun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboTipoNf As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerie As Campos.NanoCampo
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModelo As Campos.NanoCampo
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVersaoProc As Campos.NanoCampo
    Friend WithEvents cboProcEmi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFinalidade As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoEmi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoImp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboModFrete As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents memContribuinte As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNatOpe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFantasia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCNPJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodMun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodUF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPais As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCRT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNatOp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoImp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoAmb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinNfe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerProc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModFrete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObsCont As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTZDCce As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents chkPadrao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkIsento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCertificadoDigital As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtVencimento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colPastaBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCertificadoDigital As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimentoCertificado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fbdBackup As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents colSerialName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerialName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTZD As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIndPres As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIdDest As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIndFinal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIdDest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndPres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVersaoXml As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCPFAut As Campos.NanoCampo
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddCPF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExcluirCPF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsNfe As System.Data.DataSet
    Friend WithEvents tbAut As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents colAutXml As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbNFe As System.Data.DataTable
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
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
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
    Friend WithEvents btnBuscaCNPJ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCRT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnVoltar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAvancar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumUltNota As Campos.NanoCampo
    Friend WithEvents cboTipoAmb As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPastaBackup As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ofdImagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkMensalista As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents colComplemento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtComplemento As Campos.NanoCampo
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCodMunicipioFG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodMunicipioFG As Campos.NanoCampo
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents colCNAE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIM As Campos.NanoCampo
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCNAE As Campos.NanoCampo
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValAprox As Campos.NanoCampo
    Friend WithEvents lblValAprox As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colPorValorAproximado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents colCSC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCSC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboModeloImp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPortaImpressora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMensImpCupom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImpDireto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents colImpressora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPortaImpressora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImpDireto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMensImpCupom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents colTokenNFCe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToken As DevExpress.XtraEditors.TextEdit
End Class
