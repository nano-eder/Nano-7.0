<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuNFCe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuNFCe))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.btnInstalacao = New DevExpress.XtraEditors.SimpleButton
        Me.btnConfig = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.picFundo = New DevExpress.XtraEditors.PictureEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnLocalizarXml = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimirXml = New DevExpress.XtraEditors.SimpleButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.btnConChave = New DevExpress.XtraEditors.SimpleButton
        Me.txtChave = New Campos.NanoCampo
        Me.lblValCus = New DevExpress.XtraEditors.LabelControl
        Me.rtfConsulta = New System.Windows.Forms.RichTextBox
        Me.rdgTipoAmb = New DevExpress.XtraEditors.RadioGroup
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.btnCancelarNFCe = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChave = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroCupom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChaveCancelamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroCupomCancelado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAssinatura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVendaExcluida = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCancelado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btnInutilizacao = New DevExpress.XtraEditors.SimpleButton
        Me.memMotivo = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtInicial = New Campos.NanoCampo
        Me.txtFinal = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnInutilizar = New DevExpress.XtraEditors.CheckButton
        Me.btnCancelar = New DevExpress.XtraEditors.CheckButton
        Me.btnConsultaChave = New DevExpress.XtraEditors.CheckButton
        Me.btnImprimir = New DevExpress.XtraEditors.CheckButton
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.ofdXml = New System.Windows.Forms.OpenFileDialog
        Me.btnAtualizacao = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipoAmb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.memMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 100.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.btnAtualizacao)
        Me.GroupControl1.Controls.Add(Me.btnInstalacao)
        Me.GroupControl1.Controls.Add(Me.btnConfig)
        Me.GroupControl1.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl1.Controls.Add(Me.btnInutilizar)
        Me.GroupControl1.Controls.Add(Me.btnCancelar)
        Me.GroupControl1.Controls.Add(Me.btnConsultaChave)
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(791, 397)
        Me.GroupControl1.TabIndex = 0
        '
        'btnInstalacao
        '
        Me.btnInstalacao.Enabled = False
        Me.btnInstalacao.Image = Global.Nano.My.Resources.Resources.Download_2
        Me.btnInstalacao.Location = New System.Drawing.Point(12, 244)
        Me.btnInstalacao.Name = "btnInstalacao"
        Me.btnInstalacao.Size = New System.Drawing.Size(140, 43)
        Me.btnInstalacao.TabIndex = 11
        Me.btnInstalacao.Text = "Instalação"
        '
        'btnConfig
        '
        Me.btnConfig.Enabled = False
        Me.btnConfig.Image = Global.Nano.My.Resources.Resources.Produto
        Me.btnConfig.Location = New System.Drawing.Point(12, 342)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(140, 43)
        Me.btnConfig.TabIndex = 10
        Me.btnConfig.Text = "Configuração"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(166, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(623, 393)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.picFundo)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(614, 372)
        '
        'picFundo
        '
        Me.picFundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFundo.EditValue = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.picFundo.Location = New System.Drawing.Point(0, 0)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(614, 372)
        Me.picFundo.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(614, 372)
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.btnLocalizarXml)
        Me.GroupControl2.Controls.Add(Me.btnImprimirXml)
        Me.GroupControl2.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(614, 372)
        Me.GroupControl2.TabIndex = 3
        '
        'btnLocalizarXml
        '
        Me.btnLocalizarXml.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnLocalizarXml.Appearance.Options.UseBackColor = True
        Me.btnLocalizarXml.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnLocalizarXml.Image = Global.Nano.My.Resources.Resources.lupa
        Me.btnLocalizarXml.Location = New System.Drawing.Point(5, 341)
        Me.btnLocalizarXml.Name = "btnLocalizarXml"
        Me.btnLocalizarXml.Size = New System.Drawing.Size(107, 28)
        Me.btnLocalizarXml.TabIndex = 5
        Me.btnLocalizarXml.Text = "Localizar Xml"
        '
        'btnImprimirXml
        '
        Me.btnImprimirXml.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirXml.Appearance.Options.UseBackColor = True
        Me.btnImprimirXml.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnImprimirXml.Image = Global.Nano.My.Resources.Resources.Print24
        Me.btnImprimirXml.Location = New System.Drawing.Point(519, 341)
        Me.btnImprimirXml.Name = "btnImprimirXml"
        Me.btnImprimirXml.Size = New System.Drawing.Size(90, 28)
        Me.btnImprimirXml.TabIndex = 4
        Me.btnImprimirXml.Text = "Imprimir"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayBackgroundEdge = False
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.EnableDrillDown = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(610, 335)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.btnConChave)
        Me.XtraTabPage3.Controls.Add(Me.txtChave)
        Me.XtraTabPage3.Controls.Add(Me.lblValCus)
        Me.XtraTabPage3.Controls.Add(Me.rtfConsulta)
        Me.XtraTabPage3.Controls.Add(Me.rdgTipoAmb)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(614, 372)
        '
        'btnConChave
        '
        Me.btnConChave.Location = New System.Drawing.Point(526, 5)
        Me.btnConChave.Name = "btnConChave"
        Me.btnConChave.Size = New System.Drawing.Size(85, 20)
        Me.btnConChave.TabIndex = 43
        Me.btnConChave.Text = "Consultar"
        '
        'txtChave
        '
        Me.txtChave.CasasDecimais = 0
        Me.txtChave.EnterMoveNextControl = True
        Me.txtChave.Location = New System.Drawing.Point(221, 5)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Numerico = False
        Me.txtChave.Properties.Appearance.Options.UseTextOptions = True
        Me.txtChave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtChave.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChave.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtChave.Properties.MaxLength = 44
        Me.txtChave.Size = New System.Drawing.Size(299, 20)
        Me.txtChave.TabIndex = 41
        Me.txtChave.Tag = "Chave"
        '
        'lblValCus
        '
        Me.lblValCus.Location = New System.Drawing.Point(184, 8)
        Me.lblValCus.Name = "lblValCus"
        Me.lblValCus.Size = New System.Drawing.Size(31, 13)
        Me.lblValCus.TabIndex = 42
        Me.lblValCus.Text = "Chave"
        '
        'rtfConsulta
        '
        Me.rtfConsulta.Location = New System.Drawing.Point(3, 31)
        Me.rtfConsulta.Name = "rtfConsulta"
        Me.rtfConsulta.ReadOnly = True
        Me.rtfConsulta.Size = New System.Drawing.Size(608, 336)
        Me.rtfConsulta.TabIndex = 39
        Me.rtfConsulta.Text = ""
        '
        'rdgTipoAmb
        '
        Me.rdgTipoAmb.Location = New System.Drawing.Point(3, 5)
        Me.rdgTipoAmb.Name = "rdgTipoAmb"
        Me.rdgTipoAmb.Properties.Appearance.Options.UseTextOptions = True
        Me.rdgTipoAmb.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.rdgTipoAmb.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Produção"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Homologação")})
        Me.rdgTipoAmb.Size = New System.Drawing.Size(172, 20)
        Me.rdgTipoAmb.TabIndex = 40
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(614, 372)
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.btnCancelarNFCe)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(614, 372)
        Me.GroupControl3.TabIndex = 3
        '
        'btnCancelarNFCe
        '
        Me.btnCancelarNFCe.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarNFCe.Appearance.Options.UseBackColor = True
        Me.btnCancelarNFCe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCancelarNFCe.Image = Global.Nano.My.Resources.Resources.cancel24
        Me.btnCancelarNFCe.Location = New System.Drawing.Point(9, 341)
        Me.btnCancelarNFCe.Name = "btnCancelarNFCe"
        Me.btnCancelarNFCe.Size = New System.Drawing.Size(92, 28)
        Me.btnCancelarNFCe.TabIndex = 6
        Me.btnCancelarNFCe.Text = "Cancelar"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(610, 335)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodOrdem, Me.colChave, Me.colNumeroCupom, Me.colNumeroCaixa, Me.colChaveCancelamento, Me.colData, Me.colNumeroCupomCancelado, Me.colValorTotal, Me.colCPF, Me.colAssinatura, Me.colCodConfig, Me.colVendaExcluida, Me.colCancelado})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ColumnAutoWidth = False
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Nº Venda"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 63
        '
        'colChave
        '
        Me.colChave.AppearanceCell.Options.UseTextOptions = True
        Me.colChave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colChave.Caption = "Chave"
        Me.colChave.FieldName = "Chave"
        Me.colChave.Name = "colChave"
        Me.colChave.OptionsColumn.ReadOnly = True
        Me.colChave.Visible = True
        Me.colChave.VisibleIndex = 3
        Me.colChave.Width = 283
        '
        'colNumeroCupom
        '
        Me.colNumeroCupom.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroCupom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroCupom.Caption = "Nº NFC-e"
        Me.colNumeroCupom.FieldName = "NumeroCupom"
        Me.colNumeroCupom.Name = "colNumeroCupom"
        Me.colNumeroCupom.OptionsColumn.ReadOnly = True
        Me.colNumeroCupom.Visible = True
        Me.colNumeroCupom.VisibleIndex = 2
        Me.colNumeroCupom.Width = 70
        '
        'colNumeroCaixa
        '
        Me.colNumeroCaixa.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroCaixa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroCaixa.Caption = "Nº Caixa"
        Me.colNumeroCaixa.FieldName = "NumeroCaixa"
        Me.colNumeroCaixa.Name = "colNumeroCaixa"
        Me.colNumeroCaixa.OptionsColumn.ReadOnly = True
        Me.colNumeroCaixa.Width = 80
        '
        'colChaveCancelamento
        '
        Me.colChaveCancelamento.AppearanceCell.Options.UseTextOptions = True
        Me.colChaveCancelamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colChaveCancelamento.Caption = "Chave Canc."
        Me.colChaveCancelamento.FieldName = "ChaveCancelamento"
        Me.colChaveCancelamento.Name = "colChaveCancelamento"
        Me.colChaveCancelamento.OptionsColumn.ReadOnly = True
        Me.colChaveCancelamento.Width = 82
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
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 85
        '
        'colNumeroCupomCancelado
        '
        Me.colNumeroCupomCancelado.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroCupomCancelado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroCupomCancelado.Caption = "Nº Cup. Canc."
        Me.colNumeroCupomCancelado.FieldName = "NumeroCupomCancelado"
        Me.colNumeroCupomCancelado.Name = "colNumeroCupomCancelado"
        Me.colNumeroCupomCancelado.OptionsColumn.ReadOnly = True
        Me.colNumeroCupomCancelado.Width = 95
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.Caption = "Valor R$"
        Me.colValorTotal.DisplayFormat.FormatString = "c"
        Me.colValorTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.OptionsColumn.ReadOnly = True
        Me.colValorTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 4
        Me.colValorTotal.Width = 86
        '
        'colCPF
        '
        Me.colCPF.AppearanceCell.Options.UseTextOptions = True
        Me.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CFPDest"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 5
        Me.colCPF.Width = 139
        '
        'colAssinatura
        '
        Me.colAssinatura.Caption = "Assinatura"
        Me.colAssinatura.FieldName = "AssinaturaQrCode"
        Me.colAssinatura.Name = "colAssinatura"
        Me.colAssinatura.OptionsColumn.ReadOnly = True
        Me.colAssinatura.Width = 187
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        '
        'colVendaExcluida
        '
        Me.colVendaExcluida.Caption = "Venda Excluída"
        Me.colVendaExcluida.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colVendaExcluida.FieldName = "VendaExcluida"
        Me.colVendaExcluida.Name = "colVendaExcluida"
        Me.colVendaExcluida.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colCancelado
        '
        Me.colCancelado.Caption = "Cancelado"
        Me.colCancelado.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colCancelado.FieldName = "Cancelado"
        Me.colCancelado.Name = "colCancelado"
        Me.colCancelado.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(614, 372)
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.btnInutilizacao)
        Me.GroupControl4.Controls.Add(Me.memMotivo)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.txtInicial)
        Me.GroupControl4.Controls.Add(Me.txtFinal)
        Me.GroupControl4.Controls.Add(Me.LabelControl2)
        Me.GroupControl4.Controls.Add(Me.LabelControl1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(614, 372)
        Me.GroupControl4.TabIndex = 0
        '
        'btnInutilizacao
        '
        Me.btnInutilizacao.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnInutilizacao.Appearance.Options.UseBackColor = True
        Me.btnInutilizacao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnInutilizacao.Image = Global.Nano.My.Resources.Resources.Bin24x24
        Me.btnInutilizacao.Location = New System.Drawing.Point(517, 340)
        Me.btnInutilizacao.Name = "btnInutilizacao"
        Me.btnInutilizacao.Size = New System.Drawing.Size(92, 28)
        Me.btnInutilizacao.TabIndex = 56
        Me.btnInutilizacao.Text = "Inutilizar"
        '
        'memMotivo
        '
        Me.memMotivo.EnterMoveNextControl = True
        Me.memMotivo.Location = New System.Drawing.Point(66, 62)
        Me.memMotivo.Name = "memMotivo"
        Me.memMotivo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.memMotivo.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.memMotivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memMotivo.Properties.MaxLength = 250
        Me.memMotivo.Size = New System.Drawing.Size(545, 272)
        Me.memMotivo.TabIndex = 55
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(28, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Motivo"
        '
        'txtInicial
        '
        Me.txtInicial.CasasDecimais = 0
        Me.txtInicial.EnterMoveNextControl = True
        Me.txtInicial.Location = New System.Drawing.Point(66, 10)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Numerico = True
        Me.txtInicial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInicial.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtInicial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtInicial.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtInicial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtInicial.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtInicial.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtInicial.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtInicial.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtInicial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInicial.Properties.MaxLength = 16
        Me.txtInicial.Size = New System.Drawing.Size(130, 20)
        Me.txtInicial.TabIndex = 50
        '
        'txtFinal
        '
        Me.txtFinal.CasasDecimais = 0
        Me.txtFinal.EnterMoveNextControl = True
        Me.txtFinal.Location = New System.Drawing.Point(66, 36)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Numerico = True
        Me.txtFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFinal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFinal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtFinal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFinal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFinal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFinal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtFinal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFinal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFinal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFinal.Properties.MaxLength = 16
        Me.txtFinal.Size = New System.Drawing.Size(130, 20)
        Me.txtFinal.TabIndex = 51
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 53
        Me.LabelControl2.Text = "Nº Final"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Nº Inicial"
        '
        'btnInutilizar
        '
        Me.btnInutilizar.Image = Global.Nano.My.Resources.Resources.Bin24x24
        Me.btnInutilizar.Location = New System.Drawing.Point(12, 162)
        Me.btnInutilizar.Name = "btnInutilizar"
        Me.btnInutilizar.Size = New System.Drawing.Size(140, 43)
        Me.btnInutilizar.TabIndex = 6
        Me.btnInutilizar.Text = "Inutilizar Numeração"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Nano.My.Resources.Resources.cancel24
        Me.btnCancelar.Location = New System.Drawing.Point(12, 113)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 43)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar NFC-e"
        '
        'btnConsultaChave
        '
        Me.btnConsultaChave.Image = Global.Nano.My.Resources.Resources.viewmag
        Me.btnConsultaChave.Location = New System.Drawing.Point(12, 64)
        Me.btnConsultaChave.Name = "btnConsultaChave"
        Me.btnConsultaChave.Size = New System.Drawing.Size(140, 43)
        Me.btnConsultaChave.TabIndex = 4
        Me.btnConsultaChave.Text = "Consultar Chave"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Nano.My.Resources.Resources.Impressora
        Me.btnImprimir.Location = New System.Drawing.Point(12, 15)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(140, 43)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir Via Xml"
        '
        'ofdXml
        '
        Me.ofdXml.FileName = "OpenFileDialog1"
        '
        'btnAtualizacao
        '
        Me.btnAtualizacao.Enabled = False
        Me.btnAtualizacao.Image = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAtualizacao.Location = New System.Drawing.Point(12, 293)
        Me.btnAtualizacao.Name = "btnAtualizacao"
        Me.btnAtualizacao.Size = New System.Drawing.Size(140, 43)
        Me.btnAtualizacao.TabIndex = 12
        Me.btnAtualizacao.Text = "Atualização"
        '
        'frmMenuNFCe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 397)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenuNFCe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NFC-e"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.picFundo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipoAmb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.memMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnInutilizar As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnConsultaChave As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.CheckButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents ofdXml As System.Windows.Forms.OpenFileDialog
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents picFundo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnImprimirXml As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnConChave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtChave As Campos.NanoCampo
    Friend WithEvents lblValCus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rtfConsulta As System.Windows.Forms.RichTextBox
    Friend WithEvents rdgTipoAmb As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnLocalizarXml As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroCupom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChaveCancelamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroCupomCancelado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAssinatura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendaExcluida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCancelado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelarNFCe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnInutilizacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents memMotivo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInicial As Campos.NanoCampo
    Friend WithEvents txtFinal As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConfig As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInstalacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAtualizacao As DevExpress.XtraEditors.SimpleButton
End Class
