<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim ModeloCarneLabel As System.Windows.Forms.Label
        Dim TipoNanoLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim NomePCImpressoraLabel As System.Windows.Forms.Label
        Dim ToleranciaLabel As System.Windows.Forms.Label
        Dim JurosLabel As System.Windows.Forms.Label
        Dim ImpressoraLabel As System.Windows.Forms.Label
        Dim JurosParcelaLabel As System.Windows.Forms.Label
        Dim TipoDescLabel As System.Windows.Forms.Label
        Dim ImpCodBarraLabel As System.Windows.Forms.Label
        Dim DescontoMaximoLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label38 As System.Windows.Forms.Label
        Dim ValorMinimoGaxetaLabel As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim Label52 As System.Windows.Forms.Label
        Dim Label57 As System.Windows.Forms.Label
        Dim Label58 As System.Windows.Forms.Label
        Dim Label60 As System.Windows.Forms.Label
        Dim Label61 As System.Windows.Forms.Label
        Dim Label63 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim PortaImpCodBarraLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim CampoPedidoLabel As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label53 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtVersaoNano = New DevExpress.XtraEditors.TextEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.btnBuscaCPF = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDescricao = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtCidade = New DevExpress.XtraEditors.TextEdit
        Me.txtCNPJ = New DevExpress.XtraEditors.TextEdit
        Me.txtEnd = New DevExpress.XtraEditors.TextEdit
        Me.txtTel = New DevExpress.XtraEditors.TextEdit
        Me.txtNome = New DevExpress.XtraEditors.TextEdit
        Me.memDescVenda = New DevExpress.XtraEditors.MemoEdit
        Me.cboSetor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboCPFCliente = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblImp = New DevExpress.XtraEditors.LabelControl
        Me.lblPorta = New DevExpress.XtraEditors.LabelControl
        Me.memDescPedido = New DevExpress.XtraEditors.MemoEdit
        Me.txtPortaImpCodBarra = New DevExpress.XtraEditors.TextEdit
        Me.cboImpCodBarra = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboTipoDesc = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNomeImpressora = New DevExpress.XtraEditors.TextEdit
        Me.cboImpressora = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNomePCImpressora = New DevExpress.XtraEditors.TextEdit
        Me.cboTipoNano = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboModeloCarne = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboBalancaPor = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDescontoMaximo = New DevExpress.XtraEditors.TextEdit
        Me.txtCredito = New Campos.NanoCampo
        Me.lblValCus = New DevExpress.XtraEditors.LabelControl
        Me.txtJurosParcela = New DevExpress.XtraEditors.TextEdit
        Me.txtJuros = New DevExpress.XtraEditors.TextEdit
        Me.txtTolerancia = New DevExpress.XtraEditors.TextEdit
        Me.chkAcresZero = New DevExpress.XtraEditors.CheckEdit
        Me.chkPAFECF = New DevExpress.XtraEditors.CheckEdit
        Me.chkBaixaPorLote = New DevExpress.XtraEditors.CheckEdit
        Me.chk2ViaRecibo = New DevExpress.XtraEditors.CheckEdit
        Me.chkImpostoItem = New DevExpress.XtraEditors.CheckEdit
        Me.chkMensalista = New DevExpress.XtraEditors.CheckEdit
        Me.chkTemGaveta = New DevExpress.XtraEditors.CheckEdit
        Me.chkValidarCep = New DevExpress.XtraEditors.CheckEdit
        Me.chkAlterarParcelas = New DevExpress.XtraEditors.CheckEdit
        Me.chkEstoqueZerado = New DevExpress.XtraEditors.CheckEdit
        Me.chkValidarCPF = New DevExpress.XtraEditors.CheckEdit
        Me.chkGerarComissao = New DevExpress.XtraEditors.CheckEdit
        Me.chkTemGuilhotina = New DevExpress.XtraEditors.CheckEdit
        Me.chkTemImpressora = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.btnGerarArqCF = New DevExpress.XtraEditors.SimpleButton
        Me.ValorMinimoGaxetaTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.btnPastaMestra = New DevExpress.XtraEditors.SimpleButton
        Me.ofdLogo = New System.Windows.Forms.OpenFileDialog
        Me.fbdOpen = New System.Windows.Forms.FolderBrowserDialog
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnCadCli = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.ConfigBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.btnPastaNotaNfe = New DevExpress.XtraEditors.SimpleButton
        Me.txtPastaNotaNfe = New DevExpress.XtraEditors.TextEdit
        Me.chkImpPadrao = New DevExpress.XtraEditors.CheckEdit
        Me.chkTotalEconomizado = New DevExpress.XtraEditors.CheckEdit
        Me.chkVincularUser = New DevExpress.XtraEditors.CheckEdit
        Me.chkAltDataCaixa = New DevExpress.XtraEditors.CheckEdit
        Me.chkTemBalanca = New DevExpress.XtraEditors.CheckEdit
        Me.chkTEF = New DevExpress.XtraEditors.CheckEdit
        Me.chkSenhaAdm = New DevExpress.XtraEditors.CheckEdit
        Me.chkImprimeContaPagar = New DevExpress.XtraEditors.CheckEdit
        Me.chkPDV = New DevExpress.XtraEditors.CheckEdit
        Me.chkSATFiscal = New DevExpress.XtraEditors.CheckEdit
        Me.chkNanoNFCe = New DevExpress.XtraEditors.CheckEdit
        Me.chkObsClientePed = New DevExpress.XtraEditors.CheckEdit
        Me.chkMediaCusto = New DevExpress.XtraEditors.CheckEdit
        Me.chkMontarKit = New DevExpress.XtraEditors.CheckEdit
        Me.chkSimplesNacional = New DevExpress.XtraEditors.CheckEdit
        Me.chkCompararFornecedor = New DevExpress.XtraEditors.CheckEdit
        Me.chkAgruparProdutoVenda = New DevExpress.XtraEditors.CheckEdit
        Me.chkVisCobranca = New DevExpress.XtraEditors.CheckEdit
        Me.chkObsPedVenda = New DevExpress.XtraEditors.CheckEdit
        Me.chkComandaPedido = New DevExpress.XtraEditors.CheckEdit
        Me.chkManterPorcProd = New DevExpress.XtraEditors.CheckEdit
        Me.chkImpComanda = New DevExpress.XtraEditors.CheckEdit
        Me.chkObsProduto = New DevExpress.XtraEditors.CheckEdit
        Me.chkComissaoProd = New DevExpress.XtraEditors.CheckEdit
        Me.chkUsarBoleto = New DevExpress.XtraEditors.CheckEdit
        Me.chkDezPorcento = New DevExpress.XtraEditors.CheckEdit
        Me.chkAutorizacaoPedido = New DevExpress.XtraEditors.CheckEdit
        Me.chkCodigoBarraCupom = New DevExpress.XtraEditors.CheckEdit
        Me.chkImprimirDireto = New DevExpress.XtraEditors.CheckEdit
        Me.chkNanoNFe = New DevExpress.XtraEditors.CheckEdit
        Me.chkEstoqueSomado = New DevExpress.XtraEditors.CheckEdit
        Me.chkPrecoEntNF = New DevExpress.XtraEditors.CheckEdit
        Me.chkImpPedCompleto = New DevExpress.XtraEditors.CheckEdit
        Me.chkVisTrocoCaixa = New DevExpress.XtraEditors.CheckEdit
        Me.chkAltNomePed = New DevExpress.XtraEditors.CheckEdit
        Me.chkAltPrecoPed = New DevExpress.XtraEditors.CheckEdit
        Me.chkOlhoImposto = New DevExpress.XtraEditors.CheckEdit
        Me.txtPorcValAprox = New DevExpress.XtraEditors.TextEdit
        Me.cboCasaDecimal = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.btnBoleto = New DevExpress.XtraEditors.SimpleButton
        Me.txtPastaBoleto = New DevExpress.XtraEditors.TextEdit
        Me.txtEmailsArq = New DevExpress.XtraEditors.TextEdit
        Me.btnPastaNFCe = New DevExpress.XtraEditors.SimpleButton
        Me.txtPastaNFCe = New DevExpress.XtraEditors.TextEdit
        Me.cboModeloSAT = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.txtServidor = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
        Me.cboTipoBalanca = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.pnlAutomotivo = New DevExpress.XtraEditors.PanelControl
        Me.chkSemCarro = New DevExpress.XtraEditors.CheckEdit
        Me.chkMoto = New DevExpress.XtraEditors.CheckEdit
        Me.chkFuni = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.btnImgApp = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit
        Me.chkManterMargemVenda = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit
        Me.cboTabelaPreco = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CampoPedidoTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl13 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
        Me.chkFiltroProdutoContem = New DevExpress.XtraEditors.CheckEdit
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl18 = New DevExpress.XtraEditors.PanelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl16 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl15 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl14 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl17 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage
        Me.ItensReceitaTableAdapter1 = New Nano.dsNanoTableAdapters.ItensReceitaTableAdapter
        Me.lblExplicacao = New DevExpress.XtraEditors.MemoEdit
        Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit
        CNPJLabel = New System.Windows.Forms.Label
        EnderecoLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        EmpresaLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        ModeloCarneLabel = New System.Windows.Forms.Label
        TipoNanoLabel = New System.Windows.Forms.Label
        DescricaoLabel = New System.Windows.Forms.Label
        NomePCImpressoraLabel = New System.Windows.Forms.Label
        ToleranciaLabel = New System.Windows.Forms.Label
        JurosLabel = New System.Windows.Forms.Label
        ImpressoraLabel = New System.Windows.Forms.Label
        JurosParcelaLabel = New System.Windows.Forms.Label
        TipoDescLabel = New System.Windows.Forms.Label
        ImpCodBarraLabel = New System.Windows.Forms.Label
        DescontoMaximoLabel = New System.Windows.Forms.Label
        Label10 = New System.Windows.Forms.Label
        Label19 = New System.Windows.Forms.Label
        Label21 = New System.Windows.Forms.Label
        Label27 = New System.Windows.Forms.Label
        Label29 = New System.Windows.Forms.Label
        Label32 = New System.Windows.Forms.Label
        Label33 = New System.Windows.Forms.Label
        Label37 = New System.Windows.Forms.Label
        Label38 = New System.Windows.Forms.Label
        ValorMinimoGaxetaLabel = New System.Windows.Forms.Label
        Label44 = New System.Windows.Forms.Label
        Label52 = New System.Windows.Forms.Label
        Label57 = New System.Windows.Forms.Label
        Label58 = New System.Windows.Forms.Label
        Label60 = New System.Windows.Forms.Label
        Label61 = New System.Windows.Forms.Label
        Label63 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Label11 = New System.Windows.Forms.Label
        PortaImpCodBarraLabel = New System.Windows.Forms.Label
        Label13 = New System.Windows.Forms.Label
        Label14 = New System.Windows.Forms.Label
        Label15 = New System.Windows.Forms.Label
        Label12 = New System.Windows.Forms.Label
        Label16 = New System.Windows.Forms.Label
        Label17 = New System.Windows.Forms.Label
        CampoPedidoLabel = New System.Windows.Forms.Label
        Label18 = New System.Windows.Forms.Label
        Label20 = New System.Windows.Forms.Label
        Label53 = New System.Windows.Forms.Label
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtVersaoNano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memDescVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSetor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCPFCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memDescPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPortaImpCodBarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboImpCodBarra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomeImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomePCImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoNano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloCarne.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBalancaPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescontoMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJurosParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJuros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTolerancia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAcresZero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPAFECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBaixaPorLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk2ViaRecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpostoItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMensalista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTemGaveta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValidarCep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAlterarParcelas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstoqueZerado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValidarCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGerarComissao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTemGuilhotina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTemImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.ValorMinimoGaxetaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfigBindingNavigator.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtPastaNotaNfe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpPadrao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTotalEconomizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVincularUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAltDataCaixa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTemBalanca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSenhaAdm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImprimeContaPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSATFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNanoNFCe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkObsClientePed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMediaCusto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMontarKit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSimplesNacional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCompararFornecedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAgruparProdutoVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisCobranca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkObsPedVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComandaPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkManterPorcProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpComanda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkObsProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComissaoProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkUsarBoleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDezPorcento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAutorizacaoPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCodigoBarraCupom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImprimirDireto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNanoNFe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEstoqueSomado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPrecoEntNF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpPedCompleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisTrocoCaixa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAltNomePed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAltPrecoPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOlhoImposto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcValAprox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCasaDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.txtPastaBoleto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailsArq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPastaNFCe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloSAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.cboTipoBalanca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.pnlAutomotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAutomotivo.SuspendLayout()
        CType(Me.chkSemCarro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFuni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl12.SuspendLayout()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkManterMargemVenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTabelaPreco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampoPedidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl13.SuspendLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFiltroProdutoContem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl18.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl16.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl15.SuspendLayout()
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl14.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl17.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.lblExplicacao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Location = New System.Drawing.Point(435, 39)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(32, 13)
        CNPJLabel.TabIndex = 53
        CNPJLabel.Text = "CNPJ"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(34, 65)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(52, 13)
        EnderecoLabel.TabIndex = 7
        EnderecoLabel.Text = "Endereço"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(33, 117)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(53, 13)
        TelefoneLabel.TabIndex = 5
        TelefoneLabel.Text = "Tel./Email"
        '
        'EmpresaLabel
        '
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Location = New System.Drawing.Point(8, 13)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(78, 13)
        EmpresaLabel.TabIndex = 3
        EmpresaLabel.Text = "Nome Empresa"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(46, 91)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(40, 13)
        CidadeLabel.TabIndex = 61
        CidadeLabel.Text = "Cidade"
        '
        'ModeloCarneLabel
        '
        ModeloCarneLabel.AutoSize = True
        ModeloCarneLabel.Location = New System.Drawing.Point(13, 14)
        ModeloCarneLabel.Name = "ModeloCarneLabel"
        ModeloCarneLabel.Size = New System.Drawing.Size(73, 13)
        ModeloCarneLabel.TabIndex = 60
        ModeloCarneLabel.Text = "Modelo Carne"
        '
        'TipoNanoLabel
        '
        TipoNanoLabel.AutoSize = True
        TipoNanoLabel.Location = New System.Drawing.Point(31, 13)
        TipoNanoLabel.Name = "TipoNanoLabel"
        TipoNanoLabel.Size = New System.Drawing.Size(55, 13)
        TipoNanoLabel.TabIndex = 61
        TipoNanoLabel.Text = "Tipo Nano"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(33, 39)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(53, 13)
        DescricaoLabel.TabIndex = 61
        DescricaoLabel.Text = "Descrição"
        '
        'NomePCImpressoraLabel
        '
        NomePCImpressoraLabel.AutoSize = True
        NomePCImpressoraLabel.Location = New System.Drawing.Point(223, 14)
        NomePCImpressoraLabel.Name = "NomePCImpressoraLabel"
        NomePCImpressoraLabel.Size = New System.Drawing.Size(90, 13)
        NomePCImpressoraLabel.TabIndex = 65
        NomePCImpressoraLabel.Text = "Nome PC Impres."
        '
        'ToleranciaLabel
        '
        ToleranciaLabel.AutoSize = True
        ToleranciaLabel.Location = New System.Drawing.Point(30, 13)
        ToleranciaLabel.Name = "ToleranciaLabel"
        ToleranciaLabel.Size = New System.Drawing.Size(56, 13)
        ToleranciaLabel.TabIndex = 65
        ToleranciaLabel.Text = "Tolerância"
        '
        'JurosLabel
        '
        JurosLabel.AutoSize = True
        JurosLabel.Location = New System.Drawing.Point(236, 13)
        JurosLabel.Name = "JurosLabel"
        JurosLabel.Size = New System.Drawing.Size(33, 13)
        JurosLabel.TabIndex = 66
        JurosLabel.Text = "Juros"
        '
        'ImpressoraLabel
        '
        ImpressoraLabel.AutoSize = True
        ImpressoraLabel.Location = New System.Drawing.Point(27, 40)
        ImpressoraLabel.Name = "ImpressoraLabel"
        ImpressoraLabel.Size = New System.Drawing.Size(65, 13)
        ImpressoraLabel.TabIndex = 68
        ImpressoraLabel.Text = "Imp. Cupom"
        '
        'JurosParcelaLabel
        '
        JurosParcelaLabel.AutoSize = True
        JurosParcelaLabel.Location = New System.Drawing.Point(8, 39)
        JurosParcelaLabel.Name = "JurosParcelaLabel"
        JurosParcelaLabel.Size = New System.Drawing.Size(77, 13)
        JurosParcelaLabel.TabIndex = 70
        JurosParcelaLabel.Text = "Parcelas/Juros"
        '
        'TipoDescLabel
        '
        TipoDescLabel.AutoSize = True
        TipoDescLabel.Location = New System.Drawing.Point(29, 13)
        TipoDescLabel.Name = "TipoDescLabel"
        TipoDescLabel.Size = New System.Drawing.Size(57, 13)
        TipoDescLabel.TabIndex = 71
        TipoDescLabel.Text = "Tipo Desc."
        '
        'ImpCodBarraLabel
        '
        ImpCodBarraLabel.AutoSize = True
        ImpCodBarraLabel.Location = New System.Drawing.Point(16, 66)
        ImpCodBarraLabel.Name = "ImpCodBarraLabel"
        ImpCodBarraLabel.Size = New System.Drawing.Size(76, 13)
        ImpCodBarraLabel.TabIndex = 72
        ImpCodBarraLabel.Text = "Imp Cód Barra"
        '
        'DescontoMaximoLabel
        '
        DescontoMaximoLabel.AutoSize = True
        DescontoMaximoLabel.Location = New System.Drawing.Point(388, 13)
        DescontoMaximoLabel.Name = "DescontoMaximoLabel"
        DescontoMaximoLabel.Size = New System.Drawing.Size(91, 13)
        DescontoMaximoLabel.TabIndex = 78
        DescontoMaximoLabel.Text = "Desconto Máximo"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(26, 13)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(60, 13)
        Label10.TabIndex = 70
        Label10.Text = "Pasta NF-e"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(21, 58)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(63, 13)
        Label19.TabIndex = 80
        Label19.Text = "Balança Por"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(17, 42)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(69, 13)
        Label21.TabIndex = 82
        Label21.Text = "Desc. Pedido"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.Location = New System.Drawing.Point(3, 13)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(89, 13)
        Label27.TabIndex = 102
        Label27.Text = "Porc. Val. Aprox."
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.ForeColor = System.Drawing.Color.Black
        Label29.Location = New System.Drawing.Point(12, 74)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(49, 13)
        Label29.TabIndex = 94
        Label29.Text = "BOLETO"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Location = New System.Drawing.Point(19, 13)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(67, 13)
        Label32.TabIndex = 70
        Label32.Text = "Pasta Boleto"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Location = New System.Drawing.Point(389, 39)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(55, 13)
        Label33.TabIndex = 87
        Label33.Text = "CPF/CNPJ"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label37.ForeColor = System.Drawing.Color.Black
        Label37.Location = New System.Drawing.Point(14, 125)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(39, 13)
        Label37.TabIndex = 95
        Label37.Text = "NFC-e"
        '
        'Label38
        '
        Label38.AutoSize = True
        Label38.Location = New System.Drawing.Point(361, 13)
        Label38.Name = "Label38"
        Label38.Size = New System.Drawing.Size(80, 13)
        Label38.TabIndex = 90
        Label38.Text = "Sep. Est. Setor"
        '
        'ValorMinimoGaxetaLabel
        '
        ValorMinimoGaxetaLabel.AutoSize = True
        ValorMinimoGaxetaLabel.Location = New System.Drawing.Point(-37, 8)
        ValorMinimoGaxetaLabel.Name = "ValorMinimoGaxetaLabel"
        ValorMinimoGaxetaLabel.Size = New System.Drawing.Size(92, 13)
        ValorMinimoGaxetaLabel.TabIndex = 102
        ValorMinimoGaxetaLabel.Text = "Valor Min. Gaxeta"
        '
        'Label44
        '
        Label44.AutoSize = True
        Label44.Location = New System.Drawing.Point(17, 89)
        Label44.Name = "Label44"
        Label44.Size = New System.Drawing.Size(67, 13)
        Label44.TabIndex = 92
        Label44.Text = "Desc. Venda"
        '
        'Label52
        '
        Label52.AutoSize = True
        Label52.Location = New System.Drawing.Point(19, 13)
        Label52.Name = "Label52"
        Label52.Size = New System.Drawing.Size(67, 13)
        Label52.TabIndex = 72
        Label52.Text = "Pasta NFC-e"
        '
        'Label57
        '
        Label57.AutoSize = True
        Label57.Location = New System.Drawing.Point(10, 39)
        Label57.Name = "Label57"
        Label57.Size = New System.Drawing.Size(76, 13)
        Label57.TabIndex = 142
        Label57.Text = "Emails Arquivo"
        '
        'Label58
        '
        Label58.AutoSize = True
        Label58.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label58.ForeColor = System.Drawing.Color.Black
        Label58.Location = New System.Drawing.Point(12, 124)
        Label58.Name = "Label58"
        Label58.Size = New System.Drawing.Size(99, 13)
        Label58.TabIndex = 97
        Label58.Text = "SINCRONIZAÇÃO"
        '
        'Label60
        '
        Label60.AutoSize = True
        Label60.Location = New System.Drawing.Point(39, 12)
        Label60.Name = "Label60"
        Label60.Size = New System.Drawing.Size(47, 13)
        Label60.TabIndex = 72
        Label60.Text = "Servidor"
        '
        'Label61
        '
        Label61.AutoSize = True
        Label61.Location = New System.Drawing.Point(18, 32)
        Label61.Name = "Label61"
        Label61.Size = New System.Drawing.Size(67, 13)
        Label61.TabIndex = 82
        Label61.Text = "Tipo Balança"
        '
        'Label63
        '
        Label63.AutoSize = True
        Label63.Location = New System.Drawing.Point(399, 39)
        Label63.Name = "Label63"
        Label63.Size = New System.Drawing.Size(80, 13)
        Label63.TabIndex = 105
        Label63.Text = "Casas Decimais"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(231, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 143
        Label1.Text = "Modelo SAT"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(17, 73)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(32, 13)
        Label2.TabIndex = 146
        Label2.Text = "NF-e"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(16, -1)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 146
        Label3.Text = "GERAL"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(575, -2)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(91, 13)
        Label4.TabIndex = 147
        Label4.Text = "DADOS GERAIS"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(13, -2)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(57, 13)
        Label5.TabIndex = 148
        Label5.Text = "VALORES"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(577, -2)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(91, 13)
        Label6.TabIndex = 148
        Label6.Text = "DADOS GERAIS"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(16, -2)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(97, 13)
        Label7.TabIndex = 148
        Label7.Text = "PEDIDO/VENDER"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(13, -2)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(91, 13)
        Label8.TabIndex = 148
        Label8.Text = "DADOS GERAIS"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(576, -2)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(91, 13)
        Label9.TabIndex = 148
        Label9.Text = "DADOS GERAIS"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Black
        Label11.Location = New System.Drawing.Point(16, -1)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(71, 13)
        Label11.TabIndex = 149
        Label11.Text = "SAT FISCAL"
        '
        'PortaImpCodBarraLabel
        '
        PortaImpCodBarraLabel.AutoSize = True
        PortaImpCodBarraLabel.Location = New System.Drawing.Point(224, 66)
        PortaImpCodBarraLabel.Name = "PortaImpCodBarraLabel"
        PortaImpCodBarraLabel.Size = New System.Drawing.Size(84, 13)
        PortaImpCodBarraLabel.TabIndex = 76
        PortaImpCodBarraLabel.Text = "Porta Cod Barra"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.Black
        Label13.Location = New System.Drawing.Point(575, -2)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(91, 13)
        Label13.TabIndex = 149
        Label13.Text = "DADOS GERAIS"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.Color.Black
        Label14.Location = New System.Drawing.Point(13, -1)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(58, 13)
        Label14.TabIndex = 149
        Label14.Text = "BALANÇA"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.Black
        Label15.Location = New System.Drawing.Point(13, -1)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(59, 13)
        Label15.TabIndex = 149
        Label15.Text = "EMPRESA"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Black
        Label12.Location = New System.Drawing.Point(12, 175)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(83, 13)
        Label12.TabIndex = 149
        Label12.Text = "AUTOMOTIVO"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.Color.Black
        Label16.Location = New System.Drawing.Point(14, 174)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(71, 13)
        Label16.TabIndex = 150
        Label16.Text = "Consultoria"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(24, 12)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(62, 13)
        Label17.TabIndex = 72
        Label17.Text = "Email Cons."
        '
        'CampoPedidoLabel
        '
        CampoPedidoLabel.AutoSize = True
        CampoPedidoLabel.Location = New System.Drawing.Point(198, 13)
        CampoPedidoLabel.Name = "CampoPedidoLabel"
        CampoPedidoLabel.Size = New System.Drawing.Size(75, 13)
        CampoPedidoLabel.TabIndex = 92
        CampoPedidoLabel.Text = "Campo Pedido"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(630, 13)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(68, 13)
        Label18.TabIndex = 96
        Label18.Text = "Frete Mínimo"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(637, 39)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(61, 13)
        Label20.TabIndex = 97
        Label20.Text = "Porc. Frete"
        '
        'Label53
        '
        Label53.AutoSize = True
        Label53.Location = New System.Drawing.Point(17, 144)
        Label53.Name = "Label53"
        Label53.Size = New System.Drawing.Size(69, 13)
        Label53.TabIndex = 96
        Label53.Text = "Tabela Preço"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl2)
        Me.PanelControl4.Controls.Add(Me.btnBuscaCPF)
        Me.PanelControl4.Controls.Add(Me.GroupControl1)
        Me.PanelControl4.Controls.Add(DescricaoLabel)
        Me.PanelControl4.Controls.Add(Me.cboUF)
        Me.PanelControl4.Controls.Add(Me.txtDescricao)
        Me.PanelControl4.Controls.Add(Me.LabelControl16)
        Me.PanelControl4.Controls.Add(CidadeLabel)
        Me.PanelControl4.Controls.Add(Me.txtCidade)
        Me.PanelControl4.Controls.Add(Me.txtCNPJ)
        Me.PanelControl4.Controls.Add(Me.txtEnd)
        Me.PanelControl4.Controls.Add(Me.txtTel)
        Me.PanelControl4.Controls.Add(CNPJLabel)
        Me.PanelControl4.Controls.Add(Me.txtNome)
        Me.PanelControl4.Controls.Add(EnderecoLabel)
        Me.PanelControl4.Controls.Add(TelefoneLabel)
        Me.PanelControl4.Controls.Add(EmpresaLabel)
        Me.PanelControl4.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(825, 141)
        Me.PanelControl4.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl2.Controls.Add(Me.txtVersaoNano)
        Me.GroupControl2.Location = New System.Drawing.Point(632, 95)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(188, 41)
        Me.GroupControl2.TabIndex = 62
        Me.GroupControl2.Text = "Versão"
        '
        'txtVersaoNano
        '
        Me.txtVersaoNano.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "VersaoNano", True))
        Me.txtVersaoNano.EnterMoveNextControl = True
        Me.txtVersaoNano.Location = New System.Drawing.Point(22, 3)
        Me.txtVersaoNano.Name = "txtVersaoNano"
        Me.txtVersaoNano.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersaoNano.Properties.Appearance.Options.UseFont = True
        Me.txtVersaoNano.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVersaoNano.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVersaoNano.Properties.MaxLength = 5
        Me.txtVersaoNano.Properties.ReadOnly = True
        Me.txtVersaoNano.Size = New System.Drawing.Size(161, 35)
        Me.txtVersaoNano.TabIndex = 16
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
        'btnBuscaCPF
        '
        Me.btnBuscaCPF.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnBuscaCPF.Location = New System.Drawing.Point(606, 36)
        Me.btnBuscaCPF.Name = "btnBuscaCPF"
        Me.btnBuscaCPF.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscaCPF.TabIndex = 70
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.imgLogo)
        Me.GroupControl1.Location = New System.Drawing.Point(632, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(188, 82)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Logotipo"
        '
        'imgLogo
        '
        Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgLogo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ConfigBindingSource, "Logo", True))
        Me.imgLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgLogo.Location = New System.Drawing.Point(19, 2)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(167, 78)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 61
        Me.imgLogo.TabStop = False
        '
        'cboUF
        '
        Me.cboUF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "UF", True))
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(471, 88)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboUF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(155, 20)
        Me.cboUF.TabIndex = 5
        '
        'txtDescricao
        '
        Me.txtDescricao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Descricao", True))
        Me.txtDescricao.Location = New System.Drawing.Point(92, 36)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(329, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(452, 91)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl16.TabIndex = 63
        Me.LabelControl16.Text = "UF"
        '
        'txtCidade
        '
        Me.txtCidade.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Cidade", True))
        Me.txtCidade.Location = New System.Drawing.Point(92, 88)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(329, 20)
        Me.txtCidade.TabIndex = 4
        '
        'txtCNPJ
        '
        Me.txtCNPJ.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CNPJ", True))
        Me.txtCNPJ.EnterMoveNextControl = True
        Me.txtCNPJ.Location = New System.Drawing.Point(471, 36)
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Properties.MaxLength = 14
        Me.txtCNPJ.Size = New System.Drawing.Size(134, 20)
        Me.txtCNPJ.TabIndex = 2
        Me.txtCNPJ.Tag = "CNPJ"
        '
        'txtEnd
        '
        Me.txtEnd.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Endereco", True))
        Me.txtEnd.EnterMoveNextControl = True
        Me.txtEnd.Location = New System.Drawing.Point(92, 62)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Properties.MaxLength = 100
        Me.txtEnd.Size = New System.Drawing.Size(534, 20)
        Me.txtEnd.TabIndex = 3
        Me.txtEnd.Tag = "Endereço"
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Telefone", True))
        Me.txtTel.EnterMoveNextControl = True
        Me.txtTel.Location = New System.Drawing.Point(92, 114)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Properties.MaxLength = 100
        Me.txtTel.Size = New System.Drawing.Size(534, 20)
        Me.txtTel.TabIndex = 6
        Me.txtTel.Tag = "Telefones/Email"
        '
        'txtNome
        '
        Me.txtNome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Empresa", True))
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(92, 10)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Properties.MaxLength = 100
        Me.txtNome.Size = New System.Drawing.Size(534, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Tag = "Nome da Empresa"
        '
        'memDescVenda
        '
        Me.memDescVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "DescricaoVenda", True))
        Me.memDescVenda.EditValue = ""
        Me.memDescVenda.Location = New System.Drawing.Point(92, 86)
        Me.memDescVenda.Name = "memDescVenda"
        Me.memDescVenda.Size = New System.Drawing.Size(456, 50)
        Me.memDescVenda.TabIndex = 91
        '
        'cboSetor
        '
        Me.cboSetor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SepararEstoqueSetor", True))
        Me.cboSetor.Location = New System.Drawing.Point(447, 10)
        Me.cboSetor.Name = "cboSetor"
        Me.cboSetor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSetor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSetor.Size = New System.Drawing.Size(100, 20)
        Me.cboSetor.TabIndex = 89
        '
        'cboCPFCliente
        '
        Me.cboCPFCliente.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "BuscaCpfCnpj", True))
        Me.cboCPFCliente.Location = New System.Drawing.Point(447, 36)
        Me.cboCPFCliente.Name = "cboCPFCliente"
        Me.cboCPFCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCPFCliente.Properties.Items.AddRange(New Object() {"", "CPF", "CNPJ", "CPF/CNPJ"})
        Me.cboCPFCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCPFCliente.Size = New System.Drawing.Size(100, 20)
        Me.cboCPFCliente.TabIndex = 86
        '
        'lblImp
        '
        Me.lblImp.Location = New System.Drawing.Point(224, 39)
        Me.lblImp.Name = "lblImp"
        Me.lblImp.Size = New System.Drawing.Size(84, 13)
        Me.lblImp.TabIndex = 85
        Me.lblImp.Text = "Nome Impressora"
        '
        'lblPorta
        '
        Me.lblPorta.Location = New System.Drawing.Point(225, 39)
        Me.lblPorta.Name = "lblPorta"
        Me.lblPorta.Size = New System.Drawing.Size(83, 13)
        Me.lblPorta.TabIndex = 84
        Me.lblPorta.Text = "Porta Impressora"
        '
        'memDescPedido
        '
        Me.memDescPedido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "DescricaoPedido", True))
        Me.memDescPedido.EditValue = ""
        Me.memDescPedido.Location = New System.Drawing.Point(92, 36)
        Me.memDescPedido.Name = "memDescPedido"
        Me.memDescPedido.Size = New System.Drawing.Size(456, 44)
        Me.memDescPedido.TabIndex = 16
        '
        'txtPortaImpCodBarra
        '
        Me.txtPortaImpCodBarra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PortaImpCodBarra", True))
        Me.txtPortaImpCodBarra.Location = New System.Drawing.Point(314, 63)
        Me.txtPortaImpCodBarra.Name = "txtPortaImpCodBarra"
        Me.txtPortaImpCodBarra.Size = New System.Drawing.Size(230, 20)
        Me.txtPortaImpCodBarra.TabIndex = 9
        '
        'cboImpCodBarra
        '
        Me.cboImpCodBarra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImpCodBarra", True))
        Me.cboImpCodBarra.Location = New System.Drawing.Point(92, 63)
        Me.cboImpCodBarra.Name = "cboImpCodBarra"
        Me.cboImpCodBarra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboImpCodBarra.Properties.Items.AddRange(New Object() {"", "ARGOX OS-214 PLUS", "ZEBRA TLP 2844", "SMART LABEL PRINTER 440", "BEMA LB-1000", "IMPRESSORA NORMAL", "ZEBRA ZT"})
        Me.cboImpCodBarra.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboImpCodBarra.Size = New System.Drawing.Size(106, 20)
        Me.cboImpCodBarra.TabIndex = 8
        '
        'cboTipoDesc
        '
        Me.cboTipoDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TipoDesc", True))
        Me.cboTipoDesc.EnterMoveNextControl = True
        Me.cboTipoDesc.Location = New System.Drawing.Point(92, 10)
        Me.cboTipoDesc.Name = "cboTipoDesc"
        Me.cboTipoDesc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoDesc.Properties.Items.AddRange(New Object() {"ITENS", "TOTAL"})
        Me.cboTipoDesc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoDesc.Size = New System.Drawing.Size(100, 20)
        Me.cboTipoDesc.TabIndex = 4
        '
        'txtNomeImpressora
        '
        Me.txtNomeImpressora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Porta", True))
        Me.txtNomeImpressora.Location = New System.Drawing.Point(314, 37)
        Me.txtNomeImpressora.Name = "txtNomeImpressora"
        Me.txtNomeImpressora.Size = New System.Drawing.Size(231, 20)
        Me.txtNomeImpressora.TabIndex = 7
        '
        'cboImpressora
        '
        Me.cboImpressora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Impressora", True))
        Me.cboImpressora.EnterMoveNextControl = True
        Me.cboImpressora.Location = New System.Drawing.Point(92, 37)
        Me.cboImpressora.Name = "cboImpressora"
        Me.cboImpressora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboImpressora.Properties.Items.AddRange(New Object() {"", "DARUMA", "BEMATECH MP-20", "BEMATECH MP-4000", "EPSON", "ARQUIVO", "NANO PRINT", "NANO PRINT ARQUIVO", "NANO PRINT ARQUIVO DIRETO", "ESC/POS DARUMA", "ESC/POS BEMATECH", "ESC/POS EPSON", "MATRICIAL", "MATRICIAL 80"})
        Me.cboImpressora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboImpressora.Size = New System.Drawing.Size(106, 20)
        Me.cboImpressora.TabIndex = 6
        '
        'txtNomePCImpressora
        '
        Me.txtNomePCImpressora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "NomePCImpressora", True))
        Me.txtNomePCImpressora.Location = New System.Drawing.Point(314, 11)
        Me.txtNomePCImpressora.Name = "txtNomePCImpressora"
        Me.txtNomePCImpressora.Size = New System.Drawing.Size(231, 20)
        Me.txtNomePCImpressora.TabIndex = 5
        '
        'cboTipoNano
        '
        Me.cboTipoNano.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TipoNano", True))
        Me.cboTipoNano.Location = New System.Drawing.Point(92, 10)
        Me.cboTipoNano.Name = "cboTipoNano"
        Me.cboTipoNano.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoNano.Properties.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cboTipoNano.Size = New System.Drawing.Size(262, 20)
        Me.cboTipoNano.TabIndex = 0
        '
        'cboModeloCarne
        '
        Me.cboModeloCarne.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ModeloCarne", True))
        Me.cboModeloCarne.Location = New System.Drawing.Point(92, 10)
        Me.cboModeloCarne.Name = "cboModeloCarne"
        Me.cboModeloCarne.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModeloCarne.Properties.Appearance.Options.UseFont = True
        Me.cboModeloCarne.Properties.Appearance.Options.UseTextOptions = True
        Me.cboModeloCarne.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboModeloCarne.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModeloCarne.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModeloCarne.Properties.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cboModeloCarne.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModeloCarne.Size = New System.Drawing.Size(106, 21)
        Me.cboModeloCarne.TabIndex = 2
        '
        'cboBalancaPor
        '
        Me.cboBalancaPor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "BalancaPor", True))
        Me.cboBalancaPor.Location = New System.Drawing.Point(90, 55)
        Me.cboBalancaPor.Name = "cboBalancaPor"
        Me.cboBalancaPor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBalancaPor.Properties.Items.AddRange(New Object() {"QTDE", "VALOR"})
        Me.cboBalancaPor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBalancaPor.Size = New System.Drawing.Size(106, 20)
        Me.cboBalancaPor.TabIndex = 15
        '
        'txtDescontoMaximo
        '
        Me.txtDescontoMaximo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "DescontoMaximo", True))
        Me.txtDescontoMaximo.EditValue = "0"
        Me.txtDescontoMaximo.Location = New System.Drawing.Point(485, 10)
        Me.txtDescontoMaximo.Name = "txtDescontoMaximo"
        Me.txtDescontoMaximo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescontoMaximo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescontoMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtDescontoMaximo.TabIndex = 12
        '
        'txtCredito
        '
        Me.txtCredito.CasasDecimais = 2
        Me.txtCredito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Credito", True))
        Me.txtCredito.EditValue = "0"
        Me.txtCredito.EnterMoveNextControl = True
        Me.txtCredito.Location = New System.Drawing.Point(275, 36)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Numerico = True
        Me.txtCredito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredito.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCredito.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCredito.Properties.MaxLength = 18
        Me.txtCredito.Size = New System.Drawing.Size(100, 20)
        Me.txtCredito.TabIndex = 14
        Me.txtCredito.Tag = "Valor Custo R$"
        '
        'lblValCus
        '
        Me.lblValCus.Location = New System.Drawing.Point(218, 39)
        Me.lblValCus.Name = "lblValCus"
        Me.lblValCus.Size = New System.Drawing.Size(51, 13)
        Me.lblValCus.TabIndex = 76
        Me.lblValCus.Text = "Crédito R$"
        '
        'txtJurosParcela
        '
        Me.txtJurosParcela.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "JurosParcela", True))
        Me.txtJurosParcela.EditValue = "0"
        Me.txtJurosParcela.EnterMoveNextControl = True
        Me.txtJurosParcela.Location = New System.Drawing.Point(92, 36)
        Me.txtJurosParcela.Name = "txtJurosParcela"
        Me.txtJurosParcela.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJurosParcela.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJurosParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosParcela.TabIndex = 13
        '
        'txtJuros
        '
        Me.txtJuros.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Juros", True))
        Me.txtJuros.EditValue = "0"
        Me.txtJuros.Location = New System.Drawing.Point(275, 10)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJuros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJuros.Size = New System.Drawing.Size(100, 20)
        Me.txtJuros.TabIndex = 11
        '
        'txtTolerancia
        '
        Me.txtTolerancia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Tolerancia", True))
        Me.txtTolerancia.EditValue = "0"
        Me.txtTolerancia.Location = New System.Drawing.Point(92, 10)
        Me.txtTolerancia.Name = "txtTolerancia"
        Me.txtTolerancia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTolerancia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTolerancia.Size = New System.Drawing.Size(100, 20)
        Me.txtTolerancia.TabIndex = 10
        '
        'chkAcresZero
        '
        Me.chkAcresZero.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ZeroCodProd", True))
        Me.chkAcresZero.Location = New System.Drawing.Point(231, 60)
        Me.chkAcresZero.Name = "chkAcresZero"
        Me.chkAcresZero.Properties.Caption = "Acres. Zero Cod Prod?"
        Me.chkAcresZero.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAcresZero.Size = New System.Drawing.Size(130, 19)
        Me.chkAcresZero.TabIndex = 12
        '
        'chkPAFECF
        '
        Me.chkPAFECF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PafEcfNano", True))
        Me.chkPAFECF.Location = New System.Drawing.Point(62, 135)
        Me.chkPAFECF.Name = "chkPAFECF"
        Me.chkPAFECF.Properties.Caption = "PAF-ECF?"
        Me.chkPAFECF.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkPAFECF.Size = New System.Drawing.Size(69, 19)
        Me.chkPAFECF.TabIndex = 13
        '
        'chkBaixaPorLote
        '
        Me.chkBaixaPorLote.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "BaixaPorLote", True))
        Me.chkBaixaPorLote.Location = New System.Drawing.Point(488, 10)
        Me.chkBaixaPorLote.Name = "chkBaixaPorLote"
        Me.chkBaixaPorLote.Properties.Caption = "Baixa Por Lote?"
        Me.chkBaixaPorLote.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkBaixaPorLote.Size = New System.Drawing.Size(96, 19)
        Me.chkBaixaPorLote.TabIndex = 6
        '
        'chk2ViaRecibo
        '
        Me.chk2ViaRecibo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SegViaRecibo", True))
        Me.chk2ViaRecibo.Location = New System.Drawing.Point(32, 86)
        Me.chk2ViaRecibo.Name = "chk2ViaRecibo"
        Me.chk2ViaRecibo.Properties.Caption = "2ª Via Recibo?"
        Me.chk2ViaRecibo.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chk2ViaRecibo.Size = New System.Drawing.Size(90, 19)
        Me.chk2ViaRecibo.TabIndex = 5
        '
        'chkImpostoItem
        '
        Me.chkImpostoItem.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImpostoPorItem", True))
        Me.chkImpostoItem.Location = New System.Drawing.Point(699, 35)
        Me.chkImpostoItem.Name = "chkImpostoItem"
        Me.chkImpostoItem.Properties.Caption = "Imposto por Item?"
        Me.chkImpostoItem.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpostoItem.Size = New System.Drawing.Size(110, 19)
        Me.chkImpostoItem.TabIndex = 4
        '
        'chkMensalista
        '
        Me.chkMensalista.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Mensalista", True))
        Me.chkMensalista.Location = New System.Drawing.Point(46, 10)
        Me.chkMensalista.Name = "chkMensalista"
        Me.chkMensalista.Properties.Caption = "Mensalista?"
        Me.chkMensalista.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMensalista.Size = New System.Drawing.Size(77, 19)
        Me.chkMensalista.TabIndex = 11
        '
        'chkTemGaveta
        '
        Me.chkTemGaveta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TemGaveta", True))
        Me.chkTemGaveta.Location = New System.Drawing.Point(37, 61)
        Me.chkTemGaveta.Name = "chkTemGaveta"
        Me.chkTemGaveta.Properties.Caption = "Tem Gaveta?"
        Me.chkTemGaveta.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTemGaveta.Size = New System.Drawing.Size(85, 19)
        Me.chkTemGaveta.TabIndex = 2
        '
        'chkValidarCep
        '
        Me.chkValidarCep.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ValidarCep", True))
        Me.chkValidarCep.Location = New System.Drawing.Point(175, 10)
        Me.chkValidarCep.Name = "chkValidarCep"
        Me.chkValidarCep.Properties.Caption = "Validar Cep?"
        Me.chkValidarCep.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkValidarCep.Size = New System.Drawing.Size(81, 19)
        Me.chkValidarCep.TabIndex = 9
        '
        'chkAlterarParcelas
        '
        Me.chkAlterarParcelas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AlterarParcelas", True))
        Me.chkAlterarParcelas.Location = New System.Drawing.Point(3, 133)
        Me.chkAlterarParcelas.Name = "chkAlterarParcelas"
        Me.chkAlterarParcelas.Properties.Caption = "Bloquear Parcelas?"
        Me.chkAlterarParcelas.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAlterarParcelas.Size = New System.Drawing.Size(113, 19)
        Me.chkAlterarParcelas.TabIndex = 8
        '
        'chkEstoqueZerado
        '
        Me.chkEstoqueZerado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "EstoqueZerado", True))
        Me.chkEstoqueZerado.Location = New System.Drawing.Point(135, 11)
        Me.chkEstoqueZerado.Name = "chkEstoqueZerado"
        Me.chkEstoqueZerado.Properties.Caption = "Permite Est. Zerado?"
        Me.chkEstoqueZerado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstoqueZerado.Size = New System.Drawing.Size(122, 19)
        Me.chkEstoqueZerado.TabIndex = 7
        '
        'chkValidarCPF
        '
        Me.chkValidarCPF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ValidarCPF", True))
        Me.chkValidarCPF.Location = New System.Drawing.Point(175, 35)
        Me.chkValidarCPF.Name = "chkValidarCPF"
        Me.chkValidarCPF.Properties.Caption = "Validar CPF?"
        Me.chkValidarCPF.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkValidarCPF.Size = New System.Drawing.Size(81, 19)
        Me.chkValidarCPF.TabIndex = 10
        '
        'chkGerarComissao
        '
        Me.chkGerarComissao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "GerarComissao", True))
        Me.chkGerarComissao.Location = New System.Drawing.Point(14, 10)
        Me.chkGerarComissao.Name = "chkGerarComissao"
        Me.chkGerarComissao.Properties.Caption = "Gerar Comissão?"
        Me.chkGerarComissao.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkGerarComissao.Size = New System.Drawing.Size(102, 19)
        Me.chkGerarComissao.TabIndex = 3
        '
        'chkTemGuilhotina
        '
        Me.chkTemGuilhotina.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TemGuilhotina", True))
        Me.chkTemGuilhotina.Location = New System.Drawing.Point(25, 36)
        Me.chkTemGuilhotina.Name = "chkTemGuilhotina"
        Me.chkTemGuilhotina.Properties.Caption = "Tem Guilhotina?"
        Me.chkTemGuilhotina.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTemGuilhotina.Size = New System.Drawing.Size(97, 19)
        Me.chkTemGuilhotina.TabIndex = 1
        '
        'chkTemImpressora
        '
        Me.chkTemImpressora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TemImpressora", True))
        Me.chkTemImpressora.Location = New System.Drawing.Point(18, 11)
        Me.chkTemImpressora.Name = "chkTemImpressora"
        Me.chkTemImpressora.Properties.Caption = "Tem Impressora?"
        Me.chkTemImpressora.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTemImpressora.Size = New System.Drawing.Size(104, 19)
        Me.chkTemImpressora.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(ValorMinimoGaxetaLabel)
        Me.PanelControl3.Controls.Add(Me.btnGerarArqCF)
        Me.PanelControl3.Controls.Add(Me.ValorMinimoGaxetaTextEdit)
        Me.PanelControl3.Controls.Add(Me.btnPastaMestra)
        Me.PanelControl3.Location = New System.Drawing.Point(386, 111)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(113, 33)
        Me.PanelControl3.TabIndex = 2
        '
        'btnGerarArqCF
        '
        Me.btnGerarArqCF.Location = New System.Drawing.Point(517, 9)
        Me.btnGerarArqCF.Name = "btnGerarArqCF"
        Me.btnGerarArqCF.Size = New System.Drawing.Size(105, 20)
        Me.btnGerarArqCF.TabIndex = 3
        Me.btnGerarArqCF.Text = "&Gerar Arquivos ECP"
        '
        'ValorMinimoGaxetaTextEdit
        '
        Me.ValorMinimoGaxetaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ValorMinimoGaxeta", True))
        Me.ValorMinimoGaxetaTextEdit.Location = New System.Drawing.Point(61, 6)
        Me.ValorMinimoGaxetaTextEdit.Name = "ValorMinimoGaxetaTextEdit"
        Me.ValorMinimoGaxetaTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.ValorMinimoGaxetaTextEdit.TabIndex = 103
        '
        'btnPastaMestra
        '
        Me.btnPastaMestra.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnPastaMestra.Location = New System.Drawing.Point(602, 38)
        Me.btnPastaMestra.Name = "btnPastaMestra"
        Me.btnPastaMestra.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaMestra.TabIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnSalvar, Me.btnCadCli})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCadCli, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnCadCli
        '
        Me.btnCadCli.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnCadCli.Caption = "Cadastrar Era"
        Me.btnCadCli.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnCadCli.Id = 2
        Me.btnCadCli.Name = "btnCadCli"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'ConfigBindingNavigator
        '
        Me.ConfigBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConfigBindingNavigator.BindingSource = Me.ConfigBindingSource
        Me.ConfigBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConfigBindingNavigator.CountItemFormat = "de {0}"
        Me.ConfigBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConfigBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.ConfigBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConfigBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConfigBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConfigBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConfigBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConfigBindingNavigator.Name = "ConfigBindingNavigator"
        Me.ConfigBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConfigBindingNavigator.Size = New System.Drawing.Size(846, 25)
        Me.ConfigBindingNavigator.TabIndex = 70
        Me.ConfigBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.btnPastaNotaNfe)
        Me.PanelControl5.Controls.Add(Label10)
        Me.PanelControl5.Controls.Add(Me.txtPastaNotaNfe)
        Me.PanelControl5.Location = New System.Drawing.Point(5, 82)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(557, 39)
        Me.PanelControl5.TabIndex = 3
        '
        'btnPastaNotaNfe
        '
        Me.btnPastaNotaNfe.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnPastaNotaNfe.Location = New System.Drawing.Point(525, 10)
        Me.btnPastaNotaNfe.Name = "btnPastaNotaNfe"
        Me.btnPastaNotaNfe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaNotaNfe.TabIndex = 69
        '
        'txtPastaNotaNfe
        '
        Me.txtPastaNotaNfe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CaminhoPastaNotaNfe", True))
        Me.txtPastaNotaNfe.Location = New System.Drawing.Point(92, 10)
        Me.txtPastaNotaNfe.Name = "txtPastaNotaNfe"
        Me.txtPastaNotaNfe.Size = New System.Drawing.Size(431, 20)
        Me.txtPastaNotaNfe.TabIndex = 3
        '
        'chkImpPadrao
        '
        Me.chkImpPadrao.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImpressaoPadrao", True))
        Me.chkImpPadrao.Location = New System.Drawing.Point(36, 136)
        Me.chkImpPadrao.Name = "chkImpPadrao"
        Me.chkImpPadrao.Properties.Caption = "Imp. Padrao?"
        Me.chkImpPadrao.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpPadrao.Size = New System.Drawing.Size(86, 19)
        Me.chkImpPadrao.TabIndex = 146
        '
        'chkTotalEconomizado
        '
        Me.chkTotalEconomizado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TotalEconomizado", True))
        Me.chkTotalEconomizado.Location = New System.Drawing.Point(160, 86)
        Me.chkTotalEconomizado.Name = "chkTotalEconomizado"
        Me.chkTotalEconomizado.Properties.Caption = "Imp. Economia?"
        Me.chkTotalEconomizado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTotalEconomizado.Size = New System.Drawing.Size(97, 19)
        Me.chkTotalEconomizado.TabIndex = 144
        '
        'chkVincularUser
        '
        Me.chkVincularUser.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "VincularUser", True))
        Me.chkVincularUser.Location = New System.Drawing.Point(4, 35)
        Me.chkVincularUser.Name = "chkVincularUser"
        Me.chkVincularUser.Properties.Caption = "Vincular User Func.?"
        Me.chkVincularUser.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkVincularUser.Size = New System.Drawing.Size(119, 19)
        Me.chkVincularUser.TabIndex = 143
        '
        'chkAltDataCaixa
        '
        Me.chkAltDataCaixa.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AlterarDataCaixa", True))
        Me.chkAltDataCaixa.Location = New System.Drawing.Point(140, 110)
        Me.chkAltDataCaixa.Name = "chkAltDataCaixa"
        Me.chkAltDataCaixa.Properties.Caption = "Alterar Data Caixa?"
        Me.chkAltDataCaixa.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAltDataCaixa.Size = New System.Drawing.Size(116, 19)
        Me.chkAltDataCaixa.TabIndex = 142
        '
        'chkTemBalanca
        '
        Me.chkTemBalanca.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TemBalanca", True))
        Me.chkTemBalanca.Location = New System.Drawing.Point(15, 5)
        Me.chkTemBalanca.Name = "chkTemBalanca"
        Me.chkTemBalanca.Properties.Caption = "Tem Balança?"
        Me.chkTemBalanca.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTemBalanca.Size = New System.Drawing.Size(93, 19)
        Me.chkTemBalanca.TabIndex = 140
        '
        'chkTEF
        '
        Me.chkTEF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TEF", True))
        Me.chkTEF.Location = New System.Drawing.Point(206, 35)
        Me.chkTEF.Name = "chkTEF"
        Me.chkTEF.Properties.Caption = "TEF"
        Me.chkTEF.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTEF.Size = New System.Drawing.Size(40, 19)
        Me.chkTEF.TabIndex = 140
        '
        'chkSenhaAdm
        '
        Me.chkSenhaAdm.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SenhaAdm", True))
        Me.chkSenhaAdm.Location = New System.Drawing.Point(42, 60)
        Me.chkSenhaAdm.Name = "chkSenhaAdm"
        Me.chkSenhaAdm.Properties.Caption = "Senha Adm?"
        Me.chkSenhaAdm.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSenhaAdm.Size = New System.Drawing.Size(81, 19)
        Me.chkSenhaAdm.TabIndex = 138
        '
        'chkImprimeContaPagar
        '
        Me.chkImprimeContaPagar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImprimeContaPagar", True))
        Me.chkImprimeContaPagar.Location = New System.Drawing.Point(145, 62)
        Me.chkImprimeContaPagar.Name = "chkImprimeContaPagar"
        Me.chkImprimeContaPagar.Properties.Caption = "Imp. Conta Pagar?"
        Me.chkImprimeContaPagar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImprimeContaPagar.Size = New System.Drawing.Size(112, 19)
        Me.chkImprimeContaPagar.TabIndex = 136
        '
        'chkPDV
        '
        Me.chkPDV.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PDV", True))
        Me.chkPDV.Location = New System.Drawing.Point(205, 10)
        Me.chkPDV.Name = "chkPDV"
        Me.chkPDV.Properties.Caption = "PDV"
        Me.chkPDV.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkPDV.Size = New System.Drawing.Size(41, 19)
        Me.chkPDV.TabIndex = 93
        '
        'chkSATFiscal
        '
        Me.chkSATFiscal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SATFiscal", True))
        Me.chkSATFiscal.Location = New System.Drawing.Point(56, 110)
        Me.chkSATFiscal.Name = "chkSATFiscal"
        Me.chkSATFiscal.Properties.Caption = "SAT Fiscal?"
        Me.chkSATFiscal.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSATFiscal.Size = New System.Drawing.Size(75, 19)
        Me.chkSATFiscal.TabIndex = 85
        '
        'chkNanoNFCe
        '
        Me.chkNanoNFCe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "NANONFCe", True))
        Me.chkNanoNFCe.Location = New System.Drawing.Point(46, 85)
        Me.chkNanoNFCe.Name = "chkNanoNFCe"
        Me.chkNanoNFCe.Properties.Caption = "Nano NFC-e?"
        Me.chkNanoNFCe.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkNanoNFCe.Size = New System.Drawing.Size(85, 19)
        Me.chkNanoNFCe.TabIndex = 138
        '
        'chkObsClientePed
        '
        Me.chkObsClientePed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ObsClientePedido", True))
        Me.chkObsClientePed.Location = New System.Drawing.Point(9, 110)
        Me.chkObsClientePed.Name = "chkObsClientePed"
        Me.chkObsClientePed.Properties.Caption = "Obs Cliente Ped.?"
        Me.chkObsClientePed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkObsClientePed.Size = New System.Drawing.Size(107, 19)
        Me.chkObsClientePed.TabIndex = 134
        '
        'chkMediaCusto
        '
        Me.chkMediaCusto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "MediaCusto", True))
        Me.chkMediaCusto.Location = New System.Drawing.Point(275, 35)
        Me.chkMediaCusto.Name = "chkMediaCusto"
        Me.chkMediaCusto.Properties.Caption = "Média Custo?"
        Me.chkMediaCusto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMediaCusto.Size = New System.Drawing.Size(86, 19)
        Me.chkMediaCusto.TabIndex = 133
        '
        'chkMontarKit
        '
        Me.chkMontarKit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "MontarKit", True))
        Me.chkMontarKit.Location = New System.Drawing.Point(285, 10)
        Me.chkMontarKit.Name = "chkMontarKit"
        Me.chkMontarKit.Properties.Caption = "Montar Kit?"
        Me.chkMontarKit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMontarKit.Size = New System.Drawing.Size(76, 19)
        Me.chkMontarKit.TabIndex = 131
        '
        'chkSimplesNacional
        '
        Me.chkSimplesNacional.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SimplesNacional", True))
        Me.chkSimplesNacional.Location = New System.Drawing.Point(26, 35)
        Me.chkSimplesNacional.Name = "chkSimplesNacional"
        Me.chkSimplesNacional.Properties.Caption = "Simples Nacional?"
        Me.chkSimplesNacional.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSimplesNacional.Size = New System.Drawing.Size(105, 19)
        Me.chkSimplesNacional.TabIndex = 112
        '
        'chkCompararFornecedor
        '
        Me.chkCompararFornecedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CompararFornecedor", True))
        Me.chkCompararFornecedor.Location = New System.Drawing.Point(677, 10)
        Me.chkCompararFornecedor.Name = "chkCompararFornecedor"
        Me.chkCompararFornecedor.Properties.Caption = "Comparar Fornecedor?"
        Me.chkCompararFornecedor.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCompararFornecedor.Size = New System.Drawing.Size(132, 19)
        Me.chkCompararFornecedor.TabIndex = 128
        '
        'chkAgruparProdutoVenda
        '
        Me.chkAgruparProdutoVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AgruparProdutoVenda", True))
        Me.chkAgruparProdutoVenda.Location = New System.Drawing.Point(117, 61)
        Me.chkAgruparProdutoVenda.Name = "chkAgruparProdutoVenda"
        Me.chkAgruparProdutoVenda.Properties.Caption = "Agrupar Produto Venda?"
        Me.chkAgruparProdutoVenda.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAgruparProdutoVenda.Size = New System.Drawing.Size(140, 19)
        Me.chkAgruparProdutoVenda.TabIndex = 127
        '
        'chkVisCobranca
        '
        Me.chkVisCobranca.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "VisualizarCobranca", True))
        Me.chkVisCobranca.Location = New System.Drawing.Point(3, 110)
        Me.chkVisCobranca.Name = "chkVisCobranca"
        Me.chkVisCobranca.Properties.Caption = "Visualizar Cobrança?"
        Me.chkVisCobranca.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkVisCobranca.Size = New System.Drawing.Size(120, 19)
        Me.chkVisCobranca.TabIndex = 126
        '
        'chkObsPedVenda
        '
        Me.chkObsPedVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImpObsPedidoVenda", True))
        Me.chkObsPedVenda.Location = New System.Drawing.Point(128, 36)
        Me.chkObsPedVenda.Name = "chkObsPedVenda"
        Me.chkObsPedVenda.Properties.Caption = "Obs Pedido na Venda?"
        Me.chkObsPedVenda.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkObsPedVenda.Size = New System.Drawing.Size(129, 19)
        Me.chkObsPedVenda.TabIndex = 124
        '
        'chkComandaPedido
        '
        Me.chkComandaPedido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ComandaPedido", True))
        Me.chkComandaPedido.Location = New System.Drawing.Point(9, 85)
        Me.chkComandaPedido.Name = "chkComandaPedido"
        Me.chkComandaPedido.Properties.Caption = "Comanda Pedido?"
        Me.chkComandaPedido.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkComandaPedido.Size = New System.Drawing.Size(107, 19)
        Me.chkComandaPedido.TabIndex = 122
        '
        'chkManterPorcProd
        '
        Me.chkManterPorcProd.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ManterPorcProd", True))
        Me.chkManterPorcProd.Location = New System.Drawing.Point(36, 60)
        Me.chkManterPorcProd.Name = "chkManterPorcProd"
        Me.chkManterPorcProd.Properties.Caption = "Manter Porc Prod?"
        Me.chkManterPorcProd.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkManterPorcProd.Size = New System.Drawing.Size(111, 19)
        Me.chkManterPorcProd.TabIndex = 118
        '
        'chkImpComanda
        '
        Me.chkImpComanda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImprimeComanda", True))
        Me.chkImpComanda.Location = New System.Drawing.Point(160, 36)
        Me.chkImpComanda.Name = "chkImpComanda"
        Me.chkImpComanda.Properties.Caption = "Imp. Comanda?"
        Me.chkImpComanda.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpComanda.Size = New System.Drawing.Size(97, 19)
        Me.chkImpComanda.TabIndex = 116
        '
        'chkObsProduto
        '
        Me.chkObsProduto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ObsProduto", True))
        Me.chkObsProduto.Location = New System.Drawing.Point(60, 35)
        Me.chkObsProduto.Name = "chkObsProduto"
        Me.chkObsProduto.Properties.Caption = "Obs Produto?"
        Me.chkObsProduto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkObsProduto.Size = New System.Drawing.Size(87, 19)
        Me.chkObsProduto.TabIndex = 114
        '
        'chkComissaoProd
        '
        Me.chkComissaoProd.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ComissaoProduto", True))
        Me.chkComissaoProd.Location = New System.Drawing.Point(471, 60)
        Me.chkComissaoProd.Name = "chkComissaoProd"
        Me.chkComissaoProd.Properties.Caption = "Comissão Produto?"
        Me.chkComissaoProd.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkComissaoProd.Size = New System.Drawing.Size(113, 19)
        Me.chkComissaoProd.TabIndex = 109
        '
        'chkUsarBoleto
        '
        Me.chkUsarBoleto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "UsaBoleto", True))
        Me.chkUsarBoleto.Location = New System.Drawing.Point(174, 85)
        Me.chkUsarBoleto.Name = "chkUsarBoleto"
        Me.chkUsarBoleto.Properties.Caption = "Usar Boleto?"
        Me.chkUsarBoleto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkUsarBoleto.Size = New System.Drawing.Size(82, 19)
        Me.chkUsarBoleto.TabIndex = 108
        '
        'chkDezPorcento
        '
        Me.chkDezPorcento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "DezPorcento", True))
        Me.chkDezPorcento.Location = New System.Drawing.Point(32, 85)
        Me.chkDezPorcento.Name = "chkDezPorcento"
        Me.chkDezPorcento.Properties.Caption = "Dez Porcento?"
        Me.chkDezPorcento.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDezPorcento.Size = New System.Drawing.Size(91, 19)
        Me.chkDezPorcento.TabIndex = 106
        '
        'chkAutorizacaoPedido
        '
        Me.chkAutorizacaoPedido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AutorizacaoPedido", True))
        Me.chkAutorizacaoPedido.Location = New System.Drawing.Point(138, 85)
        Me.chkAutorizacaoPedido.Name = "chkAutorizacaoPedido"
        Me.chkAutorizacaoPedido.Properties.Caption = "Autorização Pedido?"
        Me.chkAutorizacaoPedido.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAutorizacaoPedido.Size = New System.Drawing.Size(119, 19)
        Me.chkAutorizacaoPedido.TabIndex = 105
        '
        'chkCodigoBarraCupom
        '
        Me.chkCodigoBarraCupom.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CodigoBarraCupom", True))
        Me.chkCodigoBarraCupom.Location = New System.Drawing.Point(7, 111)
        Me.chkCodigoBarraCupom.Name = "chkCodigoBarraCupom"
        Me.chkCodigoBarraCupom.Properties.Caption = "Cód. Barra Cupom?"
        Me.chkCodigoBarraCupom.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCodigoBarraCupom.Size = New System.Drawing.Size(115, 19)
        Me.chkCodigoBarraCupom.TabIndex = 104
        '
        'chkImprimirDireto
        '
        Me.chkImprimirDireto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ImprimirDireto", True))
        Me.chkImprimirDireto.Location = New System.Drawing.Point(160, 11)
        Me.chkImprimirDireto.Name = "chkImprimirDireto"
        Me.chkImprimirDireto.Properties.Caption = "Imprimir Direto?"
        Me.chkImprimirDireto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImprimirDireto.Size = New System.Drawing.Size(97, 19)
        Me.chkImprimirDireto.TabIndex = 103
        '
        'chkNanoNFe
        '
        Me.chkNanoNFe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "NfeNano", True))
        Me.chkNanoNFe.Location = New System.Drawing.Point(53, 10)
        Me.chkNanoNFe.Name = "chkNanoNFe"
        Me.chkNanoNFe.Properties.Caption = "NF-e Nano?"
        Me.chkNanoNFe.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkNanoNFe.Size = New System.Drawing.Size(78, 19)
        Me.chkNanoNFe.TabIndex = 101
        '
        'chkEstoqueSomado
        '
        Me.chkEstoqueSomado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "EstoqueSomado", True))
        Me.chkEstoqueSomado.Location = New System.Drawing.Point(477, 35)
        Me.chkEstoqueSomado.Name = "chkEstoqueSomado"
        Me.chkEstoqueSomado.Properties.Caption = "Estoque Somado?"
        Me.chkEstoqueSomado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkEstoqueSomado.Size = New System.Drawing.Size(107, 19)
        Me.chkEstoqueSomado.TabIndex = 99
        '
        'chkPrecoEntNF
        '
        Me.chkPrecoEntNF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AtuPreCusto", True))
        Me.chkPrecoEntNF.Location = New System.Drawing.Point(30, 10)
        Me.chkPrecoEntNF.Name = "chkPrecoEntNF"
        Me.chkPrecoEntNF.Properties.Caption = "Atu. Preço Ent. NF?"
        Me.chkPrecoEntNF.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkPrecoEntNF.Size = New System.Drawing.Size(117, 19)
        Me.chkPrecoEntNF.TabIndex = 97
        '
        'chkImpPedCompleto
        '
        Me.chkImpPedCompleto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PedidoCompleto", True))
        Me.chkImpPedCompleto.Location = New System.Drawing.Point(135, 136)
        Me.chkImpPedCompleto.Name = "chkImpPedCompleto"
        Me.chkImpPedCompleto.Properties.Caption = "Imp. Ped. Completo?"
        Me.chkImpPedCompleto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkImpPedCompleto.Size = New System.Drawing.Size(122, 19)
        Me.chkImpPedCompleto.TabIndex = 95
        '
        'chkVisTrocoCaixa
        '
        Me.chkVisTrocoCaixa.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TrocoCaixa", True))
        Me.chkVisTrocoCaixa.Location = New System.Drawing.Point(152, 60)
        Me.chkVisTrocoCaixa.Name = "chkVisTrocoCaixa"
        Me.chkVisTrocoCaixa.Properties.Caption = "Vis. Troco Caixa?"
        Me.chkVisTrocoCaixa.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkVisTrocoCaixa.Size = New System.Drawing.Size(104, 19)
        Me.chkVisTrocoCaixa.TabIndex = 93
        '
        'chkAltNomePed
        '
        Me.chkAltNomePed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AltNomePedido", True))
        Me.chkAltNomePed.Location = New System.Drawing.Point(17, 60)
        Me.chkAltNomePed.Name = "chkAltNomePed"
        Me.chkAltNomePed.Properties.Caption = "Alt. Nome Ped.?"
        Me.chkAltNomePed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAltNomePed.Size = New System.Drawing.Size(99, 19)
        Me.chkAltNomePed.TabIndex = 91
        '
        'chkAltPrecoPed
        '
        Me.chkAltPrecoPed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AltPrecoPedido", True))
        Me.chkAltPrecoPed.Location = New System.Drawing.Point(17, 35)
        Me.chkAltPrecoPed.Name = "chkAltPrecoPed"
        Me.chkAltPrecoPed.Properties.Caption = "Alt. Preço Ped.?"
        Me.chkAltPrecoPed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAltPrecoPed.Size = New System.Drawing.Size(99, 19)
        Me.chkAltPrecoPed.TabIndex = 15
        '
        'chkOlhoImposto
        '
        Me.chkOlhoImposto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ValorAproximado", True))
        Me.chkOlhoImposto.Location = New System.Drawing.Point(9, 60)
        Me.chkOlhoImposto.Name = "chkOlhoImposto"
        Me.chkOlhoImposto.Properties.Caption = "De Olho no Imposto?"
        Me.chkOlhoImposto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkOlhoImposto.Size = New System.Drawing.Size(122, 19)
        Me.chkOlhoImposto.TabIndex = 14
        '
        'txtPorcValAprox
        '
        Me.txtPorcValAprox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PorValorAproximado", True))
        Me.txtPorcValAprox.Location = New System.Drawing.Point(92, 10)
        Me.txtPorcValAprox.Name = "txtPorcValAprox"
        Me.txtPorcValAprox.Size = New System.Drawing.Size(106, 20)
        Me.txtPorcValAprox.TabIndex = 101
        '
        'cboCasaDecimal
        '
        Me.cboCasaDecimal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CasaDecimal", True))
        Me.cboCasaDecimal.EditValue = "3"
        Me.cboCasaDecimal.Location = New System.Drawing.Point(485, 36)
        Me.cboCasaDecimal.Name = "cboCasaDecimal"
        Me.cboCasaDecimal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCasaDecimal.Properties.Appearance.Options.UseFont = True
        Me.cboCasaDecimal.Properties.Appearance.Options.UseTextOptions = True
        Me.cboCasaDecimal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboCasaDecimal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCasaDecimal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCasaDecimal.Properties.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7"})
        Me.cboCasaDecimal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCasaDecimal.Size = New System.Drawing.Size(100, 21)
        Me.cboCasaDecimal.TabIndex = 104
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.btnBoleto)
        Me.PanelControl7.Controls.Add(Me.txtPastaBoleto)
        Me.PanelControl7.Controls.Add(Label32)
        Me.PanelControl7.Location = New System.Drawing.Point(5, 82)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(557, 39)
        Me.PanelControl7.TabIndex = 93
        '
        'btnBoleto
        '
        Me.btnBoleto.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnBoleto.Location = New System.Drawing.Point(357, 10)
        Me.btnBoleto.Name = "btnBoleto"
        Me.btnBoleto.Size = New System.Drawing.Size(20, 20)
        Me.btnBoleto.TabIndex = 69
        '
        'txtPastaBoleto
        '
        Me.txtPastaBoleto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CaminhoPastaBoleto", True))
        Me.txtPastaBoleto.Location = New System.Drawing.Point(92, 10)
        Me.txtPastaBoleto.Name = "txtPastaBoleto"
        Me.txtPastaBoleto.Size = New System.Drawing.Size(262, 20)
        Me.txtPastaBoleto.TabIndex = 3
        '
        'txtEmailsArq
        '
        Me.txtEmailsArq.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "EmailArquivo", True))
        Me.txtEmailsArq.Location = New System.Drawing.Point(92, 36)
        Me.txtEmailsArq.Name = "txtEmailsArq"
        Me.txtEmailsArq.Size = New System.Drawing.Size(431, 20)
        Me.txtEmailsArq.TabIndex = 141
        '
        'btnPastaNFCe
        '
        Me.btnPastaNFCe.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnPastaNFCe.Location = New System.Drawing.Point(525, 9)
        Me.btnPastaNFCe.Name = "btnPastaNFCe"
        Me.btnPastaNFCe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaNFCe.TabIndex = 71
        '
        'txtPastaNFCe
        '
        Me.txtPastaNFCe.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CaminhoPastaNFCe", True))
        Me.txtPastaNFCe.Location = New System.Drawing.Point(92, 9)
        Me.txtPastaNFCe.Name = "txtPastaNFCe"
        Me.txtPastaNFCe.Size = New System.Drawing.Size(431, 20)
        Me.txtPastaNFCe.TabIndex = 71
        '
        'cboModeloSAT
        '
        Me.cboModeloSAT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ModeloSAT", True))
        Me.cboModeloSAT.Location = New System.Drawing.Point(300, 10)
        Me.cboModeloSAT.Name = "cboModeloSAT"
        Me.cboModeloSAT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModeloSAT.Properties.Items.AddRange(New Object() {"", "DIMEP", "BEMATECHDLL", "ELGIN", "ELGIN 2", "TANCA", "GERTEC", "EASYS", "EPSON", "SWEDA", "CONTROLID", "CUSTOM"})
        Me.cboModeloSAT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModeloSAT.Size = New System.Drawing.Size(223, 20)
        Me.cboModeloSAT.TabIndex = 113
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Label60)
        Me.PanelControl9.Controls.Add(Me.txtServidor)
        Me.PanelControl9.Location = New System.Drawing.Point(5, 133)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(557, 39)
        Me.PanelControl9.TabIndex = 96
        '
        'txtServidor
        '
        Me.txtServidor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CompServidor", True))
        Me.txtServidor.Location = New System.Drawing.Point(92, 9)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(262, 20)
        Me.txtServidor.TabIndex = 71
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.chkTemBalanca)
        Me.PanelControl10.Controls.Add(Me.cboTipoBalanca)
        Me.PanelControl10.Controls.Add(Label61)
        Me.PanelControl10.Controls.Add(Me.cboBalancaPor)
        Me.PanelControl10.Controls.Add(Label19)
        Me.PanelControl10.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(825, 85)
        Me.PanelControl10.TabIndex = 98
        '
        'cboTipoBalanca
        '
        Me.cboTipoBalanca.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TipoBalanca", True))
        Me.cboTipoBalanca.Location = New System.Drawing.Point(91, 29)
        Me.cboTipoBalanca.Name = "cboTipoBalanca"
        Me.cboTipoBalanca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoBalanca.Properties.Items.AddRange(New Object() {"TOLEDO SEM ZERO", "TOLEDO COM UM ZERO", "TOLEDO COM DOIS ZEROS", "FILIZOLA SEM ZERO", "FILIZOLA COM UM ZERO", "FILIZOLA COM DOIS ZEROS", "TOLEDO SEM ZERO MGV6", "TOLEDO COM UM ZERO MGV6", "TOLEDO COM DOIS ZEROS MGV6"})
        Me.cboTipoBalanca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTipoBalanca.Size = New System.Drawing.Size(106, 20)
        Me.cboTipoBalanca.TabIndex = 81
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 25)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(846, 184)
        Me.XtraTabControl1.TabIndex = 100
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Label15)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage1.Text = "Empresa"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.AutoScroll = True
        Me.XtraTabPage2.Controls.Add(Label12)
        Me.XtraTabPage2.Controls.Add(Me.pnlAutomotivo)
        Me.XtraTabPage2.Controls.Add(Label4)
        Me.XtraTabPage2.Controls.Add(Label3)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage2.Controls.Add(Label58)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage2.Controls.Add(Label29)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage2.Text = "Cliente"
        '
        'pnlAutomotivo
        '
        Me.pnlAutomotivo.Controls.Add(Me.chkSemCarro)
        Me.pnlAutomotivo.Controls.Add(Me.chkMoto)
        Me.pnlAutomotivo.Controls.Add(Me.chkFuni)
        Me.pnlAutomotivo.Location = New System.Drawing.Point(5, 184)
        Me.pnlAutomotivo.Name = "pnlAutomotivo"
        Me.pnlAutomotivo.Size = New System.Drawing.Size(557, 39)
        Me.pnlAutomotivo.TabIndex = 148
        '
        'chkSemCarro
        '
        Me.chkSemCarro.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SemCarro", True))
        Me.chkSemCarro.Location = New System.Drawing.Point(247, 11)
        Me.chkSemCarro.Name = "chkSemCarro"
        Me.chkSemCarro.Properties.Caption = "Sem Veículo"
        Me.chkSemCarro.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkSemCarro.Size = New System.Drawing.Size(79, 19)
        Me.chkSemCarro.TabIndex = 146
        '
        'chkMoto
        '
        Me.chkMoto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Moto", True))
        Me.chkMoto.Location = New System.Drawing.Point(134, 11)
        Me.chkMoto.Name = "chkMoto"
        Me.chkMoto.Properties.Caption = "Moto Peças?"
        Me.chkMoto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkMoto.Size = New System.Drawing.Size(82, 19)
        Me.chkMoto.TabIndex = 145
        '
        'chkFuni
        '
        Me.chkFuni.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "Funilaria", True))
        Me.chkFuni.Location = New System.Drawing.Point(38, 11)
        Me.chkFuni.Name = "chkFuni"
        Me.chkFuni.Properties.Caption = "Funilaria?"
        Me.chkFuni.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkFuni.Size = New System.Drawing.Size(68, 19)
        Me.chkFuni.TabIndex = 144
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.CheckEdit4)
        Me.PanelControl2.Controls.Add(Me.CheckEdit1)
        Me.PanelControl2.Controls.Add(Me.btnImgApp)
        Me.PanelControl2.Controls.Add(Me.chkDezPorcento)
        Me.PanelControl2.Controls.Add(Me.chkMensalista)
        Me.PanelControl2.Controls.Add(Me.chkAltDataCaixa)
        Me.PanelControl2.Controls.Add(Me.chkSenhaAdm)
        Me.PanelControl2.Controls.Add(Me.chkVincularUser)
        Me.PanelControl2.Controls.Add(Me.chkVisCobranca)
        Me.PanelControl2.Controls.Add(Me.chkUsarBoleto)
        Me.PanelControl2.Controls.Add(Me.chkVisTrocoCaixa)
        Me.PanelControl2.Controls.Add(Me.chkValidarCPF)
        Me.PanelControl2.Controls.Add(Me.chkValidarCep)
        Me.PanelControl2.Location = New System.Drawing.Point(568, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(263, 218)
        Me.PanelControl2.TabIndex = 145
        '
        'CheckEdit4
        '
        Me.CheckEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "AbrirFecharCaixa", True))
        Me.CheckEdit4.Location = New System.Drawing.Point(140, 160)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Caption = "Abrir Fechar Caixa?"
        Me.CheckEdit4.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit4.Size = New System.Drawing.Size(116, 19)
        Me.CheckEdit4.TabIndex = 146
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "SaldoCaixa", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(171, 135)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Saldo Caixa?"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Size = New System.Drawing.Size(85, 19)
        Me.CheckEdit1.TabIndex = 145
        '
        'btnImgApp
        '
        Me.btnImgApp.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnImgApp.Location = New System.Drawing.Point(5, 151)
        Me.btnImgApp.Name = "btnImgApp"
        Me.btnImgApp.Size = New System.Drawing.Size(118, 20)
        Me.btnImgApp.TabIndex = 144
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboTipoNano)
        Me.PanelControl1.Controls.Add(TipoNanoLabel)
        Me.PanelControl1.Controls.Add(Me.cboCPFCliente)
        Me.PanelControl1.Controls.Add(Label33)
        Me.PanelControl1.Controls.Add(Me.cboSetor)
        Me.PanelControl1.Controls.Add(Label38)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(557, 67)
        Me.PanelControl1.TabIndex = 144
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Label5)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage3.Text = "Valores"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.TextEdit2)
        Me.PanelControl6.Controls.Add(Me.txtTolerancia)
        Me.PanelControl6.Controls.Add(Label18)
        Me.PanelControl6.Controls.Add(Label63)
        Me.PanelControl6.Controls.Add(Me.TextEdit3)
        Me.PanelControl6.Controls.Add(Label20)
        Me.PanelControl6.Controls.Add(ToleranciaLabel)
        Me.PanelControl6.Controls.Add(Me.cboCasaDecimal)
        Me.PanelControl6.Controls.Add(Me.txtJuros)
        Me.PanelControl6.Controls.Add(Me.txtCredito)
        Me.PanelControl6.Controls.Add(Me.lblValCus)
        Me.PanelControl6.Controls.Add(Me.txtDescontoMaximo)
        Me.PanelControl6.Controls.Add(DescontoMaximoLabel)
        Me.PanelControl6.Controls.Add(Me.txtJurosParcela)
        Me.PanelControl6.Controls.Add(JurosParcelaLabel)
        Me.PanelControl6.Controls.Add(JurosLabel)
        Me.PanelControl6.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(828, 65)
        Me.PanelControl6.TabIndex = 106
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "FreteMinimo", True))
        Me.TextEdit2.EditValue = "0"
        Me.TextEdit2.Location = New System.Drawing.Point(704, 10)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 94
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "PorcentagemFrete", True))
        Me.TextEdit3.EditValue = "0"
        Me.TextEdit3.Location = New System.Drawing.Point(704, 36)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit3.TabIndex = 95
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.AutoScroll = True
        Me.XtraTabPage4.Controls.Add(Label7)
        Me.XtraTabPage4.Controls.Add(Label6)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl12)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl11)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage4.Text = "Pedidos/Vender"
        '
        'PanelControl12
        '
        Me.PanelControl12.Controls.Add(Me.CheckEdit5)
        Me.PanelControl12.Controls.Add(Me.chkManterMargemVenda)
        Me.PanelControl12.Controls.Add(Me.chkGerarComissao)
        Me.PanelControl12.Controls.Add(Me.chkAltPrecoPed)
        Me.PanelControl12.Controls.Add(Me.chkObsClientePed)
        Me.PanelControl12.Controls.Add(Me.chkEstoqueZerado)
        Me.PanelControl12.Controls.Add(Me.chkAgruparProdutoVenda)
        Me.PanelControl12.Controls.Add(Me.chkObsPedVenda)
        Me.PanelControl12.Controls.Add(Me.chkAlterarParcelas)
        Me.PanelControl12.Controls.Add(Me.chkComandaPedido)
        Me.PanelControl12.Controls.Add(Me.chkAutorizacaoPedido)
        Me.PanelControl12.Controls.Add(Me.chkAltNomePed)
        Me.PanelControl12.Location = New System.Drawing.Point(568, 5)
        Me.PanelControl12.Name = "PanelControl12"
        Me.PanelControl12.Size = New System.Drawing.Size(262, 167)
        Me.PanelControl12.TabIndex = 137
        '
        'CheckEdit5
        '
        Me.CheckEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TabelaPrecoItem", True))
        Me.CheckEdit5.Location = New System.Drawing.Point(122, 133)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Caption = "Tabela Preço por Item?"
        Me.CheckEdit5.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit5.Size = New System.Drawing.Size(135, 19)
        Me.CheckEdit5.TabIndex = 136
        '
        'chkManterMargemVenda
        '
        Me.chkManterMargemVenda.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ManterMargemProd", True))
        Me.chkManterMargemVenda.Location = New System.Drawing.Point(121, 106)
        Me.chkManterMargemVenda.Name = "chkManterMargemVenda"
        Me.chkManterMargemVenda.Properties.Caption = "Manter Margem Venda?"
        Me.chkManterMargemVenda.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkManterMargemVenda.Size = New System.Drawing.Size(136, 19)
        Me.chkManterMargemVenda.TabIndex = 135
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.CheckEdit7)
        Me.PanelControl11.Controls.Add(Me.CheckEdit6)
        Me.PanelControl11.Controls.Add(Label53)
        Me.PanelControl11.Controls.Add(Me.cboTabelaPreco)
        Me.PanelControl11.Controls.Add(CampoPedidoLabel)
        Me.PanelControl11.Controls.Add(Me.CampoPedidoTextEdit)
        Me.PanelControl11.Controls.Add(Me.memDescPedido)
        Me.PanelControl11.Controls.Add(Label44)
        Me.PanelControl11.Controls.Add(Label21)
        Me.PanelControl11.Controls.Add(TipoDescLabel)
        Me.PanelControl11.Controls.Add(Me.cboTipoDesc)
        Me.PanelControl11.Controls.Add(Me.memDescVenda)
        Me.PanelControl11.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(557, 167)
        Me.PanelControl11.TabIndex = 136
        '
        'CheckEdit6
        '
        Me.CheckEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "ValePresente", True))
        Me.CheckEdit6.Location = New System.Drawing.Point(456, 142)
        Me.CheckEdit6.Name = "CheckEdit6"
        Me.CheckEdit6.Properties.Caption = "Vale Presente?"
        Me.CheckEdit6.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit6.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit6.TabIndex = 137
        '
        'cboTabelaPreco
        '
        Me.cboTabelaPreco.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TabelaPreco", True))
        Me.cboTabelaPreco.Location = New System.Drawing.Point(92, 141)
        Me.cboTabelaPreco.Name = "cboTabelaPreco"
        Me.cboTabelaPreco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTabelaPreco.Properties.Appearance.Options.UseFont = True
        Me.cboTabelaPreco.Properties.Appearance.Options.UseTextOptions = True
        Me.cboTabelaPreco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboTabelaPreco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTabelaPreco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTabelaPreco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTabelaPreco.Size = New System.Drawing.Size(100, 21)
        Me.cboTabelaPreco.TabIndex = 95
        '
        'CampoPedidoTextEdit
        '
        Me.CampoPedidoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CampoPedido", True))
        Me.CampoPedidoTextEdit.Location = New System.Drawing.Point(279, 10)
        Me.CampoPedidoTextEdit.Name = "CampoPedidoTextEdit"
        Me.CampoPedidoTextEdit.Properties.MaxLength = 30
        Me.CampoPedidoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CampoPedidoTextEdit.TabIndex = 93
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Label8)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl13)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage5.Text = "Estoque"
        '
        'PanelControl13
        '
        Me.PanelControl13.Controls.Add(Me.CheckEdit3)
        Me.PanelControl13.Controls.Add(Me.chkFiltroProdutoContem)
        Me.PanelControl13.Controls.Add(Me.chkPrecoEntNF)
        Me.PanelControl13.Controls.Add(Me.chkImpostoItem)
        Me.PanelControl13.Controls.Add(Me.chkManterPorcProd)
        Me.PanelControl13.Controls.Add(Me.chkCompararFornecedor)
        Me.PanelControl13.Controls.Add(Me.chkComissaoProd)
        Me.PanelControl13.Controls.Add(Me.chkEstoqueSomado)
        Me.PanelControl13.Controls.Add(Me.chkBaixaPorLote)
        Me.PanelControl13.Controls.Add(Me.chkAcresZero)
        Me.PanelControl13.Controls.Add(Me.chkMediaCusto)
        Me.PanelControl13.Controls.Add(Me.chkMontarKit)
        Me.PanelControl13.Controls.Add(Me.chkObsProduto)
        Me.PanelControl13.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl13.Name = "PanelControl13"
        Me.PanelControl13.Size = New System.Drawing.Size(825, 114)
        Me.PanelControl13.TabIndex = 134
        '
        'CheckEdit3
        '
        Me.CheckEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "CalcImpProd", True))
        Me.CheckEdit3.Location = New System.Drawing.Point(699, 86)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Calcular Imp Prod?"
        Me.CheckEdit3.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit3.Size = New System.Drawing.Size(110, 19)
        Me.CheckEdit3.TabIndex = 135
        '
        'chkFiltroProdutoContem
        '
        Me.chkFiltroProdutoContem.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "FiltroProdutoContem", True))
        Me.chkFiltroProdutoContem.Location = New System.Drawing.Point(677, 61)
        Me.chkFiltroProdutoContem.Name = "chkFiltroProdutoContem"
        Me.chkFiltroProdutoContem.Properties.Caption = "Filtro Produto Contem?"
        Me.chkFiltroProdutoContem.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkFiltroProdutoContem.Size = New System.Drawing.Size(132, 19)
        Me.chkFiltroProdutoContem.TabIndex = 134
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Label16)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl18)
        Me.XtraTabPage6.Controls.Add(Label11)
        Me.XtraTabPage6.Controls.Add(Label9)
        Me.XtraTabPage6.Controls.Add(Label2)
        Me.XtraTabPage6.Controls.Add(Label37)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl16)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl15)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl14)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage6.Text = "Fiscal"
        '
        'PanelControl18
        '
        Me.PanelControl18.Controls.Add(Me.TextEdit1)
        Me.PanelControl18.Controls.Add(Label17)
        Me.PanelControl18.Location = New System.Drawing.Point(5, 182)
        Me.PanelControl18.Name = "PanelControl18"
        Me.PanelControl18.Size = New System.Drawing.Size(557, 39)
        Me.PanelControl18.TabIndex = 151
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "EmailConsultoria", True))
        Me.TextEdit1.Location = New System.Drawing.Point(92, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(431, 20)
        Me.TextEdit1.TabIndex = 71
        '
        'PanelControl16
        '
        Me.PanelControl16.Controls.Add(Me.CheckEdit2)
        Me.PanelControl16.Controls.Add(Me.chkNanoNFe)
        Me.PanelControl16.Controls.Add(Me.chkSimplesNacional)
        Me.PanelControl16.Controls.Add(Me.chkNanoNFCe)
        Me.PanelControl16.Controls.Add(Me.chkSATFiscal)
        Me.PanelControl16.Controls.Add(Me.chkOlhoImposto)
        Me.PanelControl16.Controls.Add(Me.chkPAFECF)
        Me.PanelControl16.Controls.Add(Me.chkPDV)
        Me.PanelControl16.Controls.Add(Me.chkTEF)
        Me.PanelControl16.Location = New System.Drawing.Point(568, 5)
        Me.PanelControl16.Name = "PanelControl16"
        Me.PanelControl16.Size = New System.Drawing.Size(262, 167)
        Me.PanelControl16.TabIndex = 145
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "NfseNano", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(161, 60)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Nano NFS-e?"
        Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit2.Size = New System.Drawing.Size(85, 19)
        Me.CheckEdit2.TabIndex = 141
        '
        'PanelControl15
        '
        Me.PanelControl15.Controls.Add(Me.txtPastaNFCe)
        Me.PanelControl15.Controls.Add(Label52)
        Me.PanelControl15.Controls.Add(Me.btnPastaNFCe)
        Me.PanelControl15.Location = New System.Drawing.Point(5, 133)
        Me.PanelControl15.Name = "PanelControl15"
        Me.PanelControl15.Size = New System.Drawing.Size(557, 39)
        Me.PanelControl15.TabIndex = 144
        '
        'PanelControl14
        '
        Me.PanelControl14.Controls.Add(Label1)
        Me.PanelControl14.Controls.Add(Me.txtPorcValAprox)
        Me.PanelControl14.Controls.Add(Me.cboModeloSAT)
        Me.PanelControl14.Controls.Add(Label57)
        Me.PanelControl14.Controls.Add(Label27)
        Me.PanelControl14.Controls.Add(Me.txtEmailsArq)
        Me.PanelControl14.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl14.Name = "PanelControl14"
        Me.PanelControl14.Size = New System.Drawing.Size(557, 64)
        Me.PanelControl14.TabIndex = 143
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage7.Controls.Add(Label13)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl17)
        Me.XtraTabPage7.Controls.Add(Me.PanelControl8)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage7.Text = "Impressão"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, -2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 86
        Me.LabelControl1.Text = "IMPRESSÃO"
        '
        'PanelControl17
        '
        Me.PanelControl17.Controls.Add(Me.chkTemImpressora)
        Me.PanelControl17.Controls.Add(Me.chkTemGuilhotina)
        Me.PanelControl17.Controls.Add(Me.chkImpPadrao)
        Me.PanelControl17.Controls.Add(Me.chkImprimeContaPagar)
        Me.PanelControl17.Controls.Add(Me.chkTotalEconomizado)
        Me.PanelControl17.Controls.Add(Me.chkTemGaveta)
        Me.PanelControl17.Controls.Add(Me.chkCodigoBarraCupom)
        Me.PanelControl17.Controls.Add(Me.chk2ViaRecibo)
        Me.PanelControl17.Controls.Add(Me.chkImprimirDireto)
        Me.PanelControl17.Controls.Add(Me.chkImpPedCompleto)
        Me.PanelControl17.Controls.Add(Me.chkImpComanda)
        Me.PanelControl17.Location = New System.Drawing.Point(568, 5)
        Me.PanelControl17.Name = "PanelControl17"
        Me.PanelControl17.Size = New System.Drawing.Size(262, 167)
        Me.PanelControl17.TabIndex = 148
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.cboModeloCarne)
        Me.PanelControl8.Controls.Add(Me.lblImp)
        Me.PanelControl8.Controls.Add(Me.txtNomeImpressora)
        Me.PanelControl8.Controls.Add(ImpressoraLabel)
        Me.PanelControl8.Controls.Add(Me.cboImpCodBarra)
        Me.PanelControl8.Controls.Add(NomePCImpressoraLabel)
        Me.PanelControl8.Controls.Add(ImpCodBarraLabel)
        Me.PanelControl8.Controls.Add(Me.lblPorta)
        Me.PanelControl8.Controls.Add(Me.txtNomePCImpressora)
        Me.PanelControl8.Controls.Add(ModeloCarneLabel)
        Me.PanelControl8.Controls.Add(Me.txtPortaImpCodBarra)
        Me.PanelControl8.Controls.Add(PortaImpCodBarraLabel)
        Me.PanelControl8.Controls.Add(Me.cboImpressora)
        Me.PanelControl8.Location = New System.Drawing.Point(5, 5)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(557, 167)
        Me.PanelControl8.TabIndex = 147
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Label14)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl10)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(837, 153)
        Me.XtraTabPage8.Text = "Balança"
        '
        'ItensReceitaTableAdapter1
        '
        Me.ItensReceitaTableAdapter1.ClearBeforeFill = True
        '
        'lblExplicacao
        '
        Me.lblExplicacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExplicacao.Location = New System.Drawing.Point(0, 209)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblExplicacao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblExplicacao.Properties.Appearance.Options.UseBackColor = True
        Me.lblExplicacao.Properties.Appearance.Options.UseFont = True
        Me.lblExplicacao.Size = New System.Drawing.Size(846, 206)
        Me.lblExplicacao.TabIndex = 101
        '
        'CheckEdit7
        '
        Me.CheckEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConfigBindingSource, "TotalPendenciaImp", True))
        Me.CheckEdit7.Location = New System.Drawing.Point(297, 143)
        Me.CheckEdit7.Name = "CheckEdit7"
        Me.CheckEdit7.Properties.Caption = "Total Pendência na Imp.?"
        Me.CheckEdit7.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit7.Size = New System.Drawing.Size(144, 19)
        Me.CheckEdit7.TabIndex = 138
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(846, 449)
        Me.Controls.Add(Me.lblExplicacao)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.ConfigBindingNavigator)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração Nano Commerce"
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txtVersaoNano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memDescVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSetor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCPFCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memDescPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPortaImpCodBarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboImpCodBarra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomeImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomePCImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoNano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloCarne.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBalancaPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescontoMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJurosParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJuros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTolerancia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAcresZero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPAFECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBaixaPorLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk2ViaRecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpostoItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMensalista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTemGaveta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValidarCep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAlterarParcelas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstoqueZerado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValidarCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGerarComissao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTemGuilhotina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTemImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.ValorMinimoGaxetaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfigBindingNavigator.ResumeLayout(False)
        Me.ConfigBindingNavigator.PerformLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.txtPastaNotaNfe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpPadrao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTotalEconomizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVincularUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAltDataCaixa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTemBalanca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSenhaAdm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImprimeContaPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSATFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNanoNFCe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkObsClientePed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMediaCusto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMontarKit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSimplesNacional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCompararFornecedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAgruparProdutoVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisCobranca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkObsPedVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComandaPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkManterPorcProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpComanda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkObsProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComissaoProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkUsarBoleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDezPorcento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAutorizacaoPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCodigoBarraCupom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImprimirDireto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNanoNFe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEstoqueSomado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPrecoEntNF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpPedCompleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisTrocoCaixa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAltNomePed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAltPrecoPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOlhoImposto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcValAprox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCasaDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.txtPastaBoleto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailsArq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPastaNFCe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloSAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        Me.PanelControl10.PerformLayout()
        CType(Me.cboTipoBalanca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.pnlAutomotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAutomotivo.ResumeLayout(False)
        CType(Me.chkSemCarro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFuni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.PanelControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl12.ResumeLayout(False)
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkManterMargemVenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        Me.PanelControl11.PerformLayout()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTabelaPreco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampoPedidoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.PanelControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl13.ResumeLayout(False)
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFiltroProdutoContem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage6.PerformLayout()
        CType(Me.PanelControl18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl18.ResumeLayout(False)
        Me.PanelControl18.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl16.ResumeLayout(False)
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl15.ResumeLayout(False)
        Me.PanelControl15.PerformLayout()
        CType(Me.PanelControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl14.ResumeLayout(False)
        Me.PanelControl14.PerformLayout()
        Me.XtraTabPage7.ResumeLayout(False)
        Me.XtraTabPage7.PerformLayout()
        CType(Me.PanelControl17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl17.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        Me.XtraTabPage8.ResumeLayout(False)
        Me.XtraTabPage8.PerformLayout()
        CType(Me.lblExplicacao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPastaMestra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofdLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fbdOpen As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtCNPJ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVersaoNano As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnGerarArqCF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCidade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkTemImpressora As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboModeloCarne As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboTipoNano As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDescricao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkGerarComissao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkValidarCPF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtNomePCImpressora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkTemGuilhotina As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtJuros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTolerancia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAlterarParcelas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEstoqueZerado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboImpressora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNomeImpressora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtJurosParcela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTipoDesc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboImpCodBarra As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ConfigBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents chkValidarCep As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCredito As Campos.NanoCampo
    Friend WithEvents lblValCus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPortaImpCodBarra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkTemGaveta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDescontoMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkMensalista As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkImpostoItem As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnPastaNotaNfe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPastaNotaNfe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chk2ViaRecibo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBaixaPorLote As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPAFECF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAcresZero As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkOlhoImposto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboBalancaPor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkAltPrecoPed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents memDescPedido As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkAltNomePed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVisTrocoCaixa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImpPedCompleto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPrecoEntNF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkEstoqueSomado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPorcValAprox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkNanoNFe As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImprimirDireto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblImp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPorta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAutorizacaoPedido As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCodigoBarraCupom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDezPorcento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkUsarBoleto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnBoleto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPastaBoleto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkComissaoProd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSimplesNacional As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboCPFCliente As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkObsProduto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSATFiscal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboSetor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkImpComanda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValorMinimoGaxetaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboModeloSAT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkManterPorcProd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkComandaPedido As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents memDescVenda As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkObsPedVenda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVisCobranca As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAgruparProdutoVenda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCompararFornecedor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMontarKit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMediaCusto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkObsClientePed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkImprimeContaPagar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNanoNFCe As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnPastaNFCe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPastaNFCe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkPDV As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTEF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSenhaAdm As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTemBalanca As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEmailsArq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtServidor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboTipoBalanca As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkAltDataCaixa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCadCli As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkTotalEconomizado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVincularUser As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboCasaDecimal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkImpPadrao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl13 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl14 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl16 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl15 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl17 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItensReceitaTableAdapter1 As Nano.dsNanoTableAdapters.ItensReceitaTableAdapter
    Friend WithEvents lblExplicacao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnBuscaCPF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkMoto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFuni As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlAutomotivo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkSemCarro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFiltroProdutoContem As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnImgApp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl18 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CampoPedidoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkManterMargemVenda As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboTabelaPreco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
End Class
