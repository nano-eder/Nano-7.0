<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigBoleto
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigBoleto))
        Me.txtCodBanco = New Campos.NanoCampo
        Me.txtContaCorrente = New Campos.NanoCampo
        Me.txtCedente = New Campos.NanoCampo
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtCPF = New Campos.NanoCampo
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.txtDescricao = New Campos.NanoCampo
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.btnCaminhoArquivo = New DevExpress.XtraEditors.SimpleButton
        Me.txtCaminhoArquivo = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtDvContaCorrente = New Campos.NanoCampo
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup
        Me.txtDvAgencia = New Campos.NanoCampo
        Me.txtDvCedente = New Campos.NanoCampo
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodCedente = New Campos.NanoCampo
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtAgencia = New Campos.NanoCampo
        Me.cboNomeBanco = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtCodigoTransmissao = New Campos.NanoCampo
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.chkrecibo = New DevExpress.XtraEditors.CheckEdit
        Me.chkPadrao = New DevExpress.XtraEditors.CheckEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCedente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNomeBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContaCorrente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPerMulta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCarteira = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoOcorrencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSeuNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEspecie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoAceite = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimeiraInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSegundaInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorMora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorIOF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCedente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiasProtesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPadrao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkPadraoGrid = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colDiasMora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTransmissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecibo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkReciboGrid = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colInstrucao2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoVinculacao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoIdenticador = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoAmbiente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCaminhoArquivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtInstrucao2 = New DevExpress.XtraEditors.TextEdit
        Me.txtInstrucao = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtDiasMora = New Campos.NanoCampo
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtDiasProtesto = New Campos.NanoCampo
        Me.cboSegundaInstrucao = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.cboPrimeriaInstrucao = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtValorMora = New Campos.NanoCampo
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtSeuNumero = New Campos.NanoCampo
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.txtPerMulta = New Campos.NanoCampo
        Me.cboTipoAmbiente = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.cboEspecie = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.txtValorIOF = New Campos.NanoCampo
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.txtTipoAceite = New Campos.NanoCampo
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.cboCarteira = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoOcorrencia = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Label6 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.txtCodBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaminhoArquivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvContaCorrente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDvCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCedente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNomeBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTransmissao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkrecibo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPadrao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPadraoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReciboGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtInstrucao2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInstrucao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasProtesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSegundaInstrucao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPrimeriaInstrucao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeuNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerMulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoAmbiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEspecie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIOF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoAceite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCarteira.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoOcorrencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.Blue
        Label6.Location = New System.Drawing.Point(19, 4)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(106, 14)
        Label6.TabIndex = 105
        Label6.Text = "Dados do Banco"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Blue
        Label2.Location = New System.Drawing.Point(19, 137)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(109, 14)
        Label2.TabIndex = 109
        Label2.Text = "Dados do Boleto"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(37, 90)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 13)
        Label3.TabIndex = 162
        Label3.Text = "Instrução"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(77, 13)
        Label1.TabIndex = 164
        Label1.Text = "Demonstrativo"
        '
        'txtCodBanco
        '
        Me.txtCodBanco.CasasDecimais = 0
        Me.txtCodBanco.EnterMoveNextControl = True
        Me.txtCodBanco.Location = New System.Drawing.Point(443, 71)
        Me.txtCodBanco.Name = "txtCodBanco"
        Me.txtCodBanco.Numerico = False
        Me.txtCodBanco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodBanco.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodBanco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBanco.Properties.MaxLength = 100
        Me.txtCodBanco.Size = New System.Drawing.Size(118, 20)
        Me.txtCodBanco.TabIndex = 5
        Me.txtCodBanco.Tag = "Cód. Banco"
        '
        'txtContaCorrente
        '
        Me.txtContaCorrente.CasasDecimais = 0
        Me.txtContaCorrente.EnterMoveNextControl = True
        Me.txtContaCorrente.Location = New System.Drawing.Point(317, 66)
        Me.txtContaCorrente.Name = "txtContaCorrente"
        Me.txtContaCorrente.Numerico = False
        Me.txtContaCorrente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtContaCorrente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtContaCorrente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContaCorrente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtContaCorrente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaCorrente.Properties.MaxLength = 10
        Me.txtContaCorrente.Size = New System.Drawing.Size(92, 20)
        Me.txtContaCorrente.TabIndex = 7
        Me.txtContaCorrente.Tag = "Número Banco"
        '
        'txtCedente
        '
        Me.txtCedente.CasasDecimais = 0
        Me.txtCedente.EnterMoveNextControl = True
        Me.txtCedente.Location = New System.Drawing.Point(317, 14)
        Me.txtCedente.Name = "txtCedente"
        Me.txtCedente.Numerico = False
        Me.txtCedente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCedente.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtCedente.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtCedente.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtCedente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCedente.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCedente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedente.Properties.MaxLength = 150
        Me.txtCedente.Size = New System.Drawing.Size(353, 20)
        Me.txtCedente.TabIndex = 2
        Me.txtCedente.Tag = "Cedente"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(382, 74)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl13.TabIndex = 83
        Me.LabelControl13.Text = "Cód. Banco"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(236, 69)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl11.TabIndex = 82
        Me.LabelControl11.Text = "Conta Corrente"
        '
        'txtCPF
        '
        Me.txtCPF.CasasDecimais = 0
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(115, 14)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Numerico = False
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPF.Properties.MaxLength = 20
        Me.txtCPF.Size = New System.Drawing.Size(116, 20)
        Me.txtCPF.TabIndex = 1
        Me.txtCPF.Tag = "CPF/CNPJ"
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(50, 43)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl43.TabIndex = 93
        Me.LabelControl43.Text = "Nome Banco"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(270, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Cedente"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnAlterar, Me.btnLimpar})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
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
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.txtDescricao)
        Me.PanelControl5.Controls.Add(Me.LabelControl12)
        Me.PanelControl5.Controls.Add(Me.btnCaminhoArquivo)
        Me.PanelControl5.Controls.Add(Me.txtCaminhoArquivo)
        Me.PanelControl5.Controls.Add(Me.LabelControl9)
        Me.PanelControl5.Controls.Add(Me.txtDvContaCorrente)
        Me.PanelControl5.Controls.Add(Me.rdgDoc)
        Me.PanelControl5.Controls.Add(Me.txtDvAgencia)
        Me.PanelControl5.Controls.Add(Me.txtDvCedente)
        Me.PanelControl5.Controls.Add(Me.LabelControl8)
        Me.PanelControl5.Controls.Add(Me.txtCodCedente)
        Me.PanelControl5.Controls.Add(Me.txtContaCorrente)
        Me.PanelControl5.Controls.Add(Me.LabelControl11)
        Me.PanelControl5.Controls.Add(Me.LabelControl7)
        Me.PanelControl5.Controls.Add(Me.txtAgencia)
        Me.PanelControl5.Controls.Add(Me.cboNomeBanco)
        Me.PanelControl5.Controls.Add(Me.txtCedente)
        Me.PanelControl5.Controls.Add(Me.txtCPF)
        Me.PanelControl5.Controls.Add(Me.LabelControl1)
        Me.PanelControl5.Controls.Add(Me.LabelControl43)
        Me.PanelControl5.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(679, 122)
        Me.PanelControl5.TabIndex = 0
        '
        'txtDescricao
        '
        Me.txtDescricao.CasasDecimais = 0
        Me.txtDescricao.EnterMoveNextControl = True
        Me.txtDescricao.Location = New System.Drawing.Point(317, 40)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Numerico = False
        Me.txtDescricao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescricao.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtDescricao.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDescricao.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtDescricao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDescricao.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Properties.MaxLength = 150
        Me.txtDescricao.Size = New System.Drawing.Size(353, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.Tag = "Cedente"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(265, 43)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl12.TabIndex = 113
        Me.LabelControl12.Text = "Descrição"
        '
        'btnCaminhoArquivo
        '
        Me.btnCaminhoArquivo.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnCaminhoArquivo.Location = New System.Drawing.Point(650, 92)
        Me.btnCaminhoArquivo.Name = "btnCaminhoArquivo"
        Me.btnCaminhoArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnCaminhoArquivo.TabIndex = 111
        '
        'txtCaminhoArquivo
        '
        Me.txtCaminhoArquivo.CasasDecimais = 0
        Me.txtCaminhoArquivo.EnterMoveNextControl = True
        Me.txtCaminhoArquivo.Location = New System.Drawing.Point(115, 92)
        Me.txtCaminhoArquivo.Name = "txtCaminhoArquivo"
        Me.txtCaminhoArquivo.Numerico = False
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCaminhoArquivo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCaminhoArquivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaminhoArquivo.Properties.MaxLength = 150
        Me.txtCaminhoArquivo.Size = New System.Drawing.Size(534, 20)
        Me.txtCaminhoArquivo.TabIndex = 11
        Me.txtCaminhoArquivo.Tag = "Cedente"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(60, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl9.TabIndex = 110
        Me.LabelControl9.Text = "Cam. Arq."
        '
        'txtDvContaCorrente
        '
        Me.txtDvContaCorrente.CasasDecimais = 0
        Me.txtDvContaCorrente.EnterMoveNextControl = True
        Me.txtDvContaCorrente.Location = New System.Drawing.Point(415, 66)
        Me.txtDvContaCorrente.Name = "txtDvContaCorrente"
        Me.txtDvContaCorrente.Numerico = True
        Me.txtDvContaCorrente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDvContaCorrente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDvContaCorrente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvContaCorrente.Properties.MaxLength = 10
        Me.txtDvContaCorrente.Size = New System.Drawing.Size(38, 20)
        Me.txtDvContaCorrente.TabIndex = 8
        Me.txtDvContaCorrente.Tag = "Número"
        '
        'rdgDoc
        '
        Me.rdgDoc.EditValue = True
        Me.rdgDoc.Location = New System.Drawing.Point(8, 14)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(101, 20)
        Me.rdgDoc.TabIndex = 0
        '
        'txtDvAgencia
        '
        Me.txtDvAgencia.CasasDecimais = 0
        Me.txtDvAgencia.EnterMoveNextControl = True
        Me.txtDvAgencia.Location = New System.Drawing.Point(193, 66)
        Me.txtDvAgencia.Name = "txtDvAgencia"
        Me.txtDvAgencia.Numerico = True
        Me.txtDvAgencia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDvAgencia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDvAgencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvAgencia.Properties.MaxLength = 10
        Me.txtDvAgencia.Size = New System.Drawing.Size(38, 20)
        Me.txtDvAgencia.TabIndex = 6
        Me.txtDvAgencia.Tag = "Número"
        '
        'txtDvCedente
        '
        Me.txtDvCedente.CasasDecimais = 0
        Me.txtDvCedente.EnterMoveNextControl = True
        Me.txtDvCedente.Location = New System.Drawing.Point(631, 66)
        Me.txtDvCedente.Name = "txtDvCedente"
        Me.txtDvCedente.Numerico = True
        Me.txtDvCedente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDvCedente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDvCedente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDvCedente.Properties.MaxLength = 10
        Me.txtDvCedente.Size = New System.Drawing.Size(39, 20)
        Me.txtDvCedente.TabIndex = 10
        Me.txtDvCedente.Tag = ""
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(460, 69)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl8.TabIndex = 108
        Me.LabelControl8.Text = "Cód. Cedente"
        '
        'txtCodCedente
        '
        Me.txtCodCedente.CasasDecimais = 0
        Me.txtCodCedente.EnterMoveNextControl = True
        Me.txtCodCedente.Location = New System.Drawing.Point(533, 66)
        Me.txtCodCedente.Name = "txtCodCedente"
        Me.txtCodCedente.Numerico = False
        Me.txtCodCedente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodCedente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCodCedente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodCedente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodCedente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCedente.Properties.MaxLength = 10
        Me.txtCodCedente.Size = New System.Drawing.Size(92, 20)
        Me.txtCodCedente.TabIndex = 9
        Me.txtCodCedente.Tag = "Cód. Cedente"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(71, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 106
        Me.LabelControl7.Text = "Agência"
        '
        'txtAgencia
        '
        Me.txtAgencia.CasasDecimais = 0
        Me.txtAgencia.EnterMoveNextControl = True
        Me.txtAgencia.Location = New System.Drawing.Point(115, 66)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Numerico = False
        Me.txtAgencia.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAgencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAgencia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAgencia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAgencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAgencia.Properties.MaxLength = 10
        Me.txtAgencia.Size = New System.Drawing.Size(72, 20)
        Me.txtAgencia.TabIndex = 5
        Me.txtAgencia.Tag = "Agência"
        '
        'cboNomeBanco
        '
        Me.cboNomeBanco.EnterMoveNextControl = True
        Me.cboNomeBanco.Location = New System.Drawing.Point(115, 40)
        Me.cboNomeBanco.Name = "cboNomeBanco"
        Me.cboNomeBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNomeBanco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNomeBanco.Properties.Items.AddRange(New Object() {"SANTANDER", "ITAÚ", "CAIXA ECONÔMICA", "BRADESCO", "BANCO DO BRASIL", "SICOOB"})
        Me.cboNomeBanco.Size = New System.Drawing.Size(116, 20)
        Me.cboNomeBanco.TabIndex = 3
        Me.cboNomeBanco.Tag = "Nome Banco"
        '
        'txtCodigoTransmissao
        '
        Me.txtCodigoTransmissao.CasasDecimais = 0
        Me.txtCodigoTransmissao.EnterMoveNextControl = True
        Me.txtCodigoTransmissao.Location = New System.Drawing.Point(96, 113)
        Me.txtCodigoTransmissao.Name = "txtCodigoTransmissao"
        Me.txtCodigoTransmissao.Numerico = False
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodigoTransmissao.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCodigoTransmissao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTransmissao.Properties.MaxLength = 150
        Me.txtCodigoTransmissao.Size = New System.Drawing.Size(325, 20)
        Me.txtCodigoTransmissao.TabIndex = 109
        Me.txtCodigoTransmissao.Tag = "Cedente"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 116)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl5.TabIndex = 110
        Me.LabelControl5.Text = "Cód. Transmissão"
        '
        'chkrecibo
        '
        Me.chkrecibo.Location = New System.Drawing.Point(527, 0)
        Me.chkrecibo.Name = "chkrecibo"
        Me.chkrecibo.Properties.Caption = "Recibo"
        Me.chkrecibo.Size = New System.Drawing.Size(55, 19)
        Me.chkrecibo.TabIndex = 13
        Me.chkrecibo.Visible = False
        '
        'chkPadrao
        '
        Me.chkPadrao.Location = New System.Drawing.Point(606, 0)
        Me.chkPadrao.Name = "chkPadrao"
        Me.chkPadrao.Properties.Caption = "Padrão"
        Me.chkPadrao.Size = New System.Drawing.Size(55, 19)
        Me.chkPadrao.TabIndex = 14
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.chkPadraoGrid, Me.chkReciboGrid})
        Me.GridControl1.Size = New System.Drawing.Size(697, 213)
        Me.GridControl1.TabIndex = 111
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCedente, Me.colCPF, Me.colCodigoBanco, Me.colNomeBanco, Me.colContaCorrente, Me.colPerMulta, Me.colCodigoCarteira, Me.colCodigoOcorrencia, Me.colSeuNumero, Me.colEspecie, Me.colTipoAceite, Me.colPrimeiraInstrucao, Me.colSegundaInstrucao, Me.colValorMora, Me.colValorIOF, Me.colAgencia, Me.colCodigoCedente, Me.colDiasProtesto, Me.colPadrao, Me.colDiasMora, Me.colCodigoTransmissao, Me.colInstrucao, Me.colRecibo, Me.colInstrucao2, Me.colCodigoVinculacao, Me.colCodigoIdenticador, Me.colTipoAmbiente, Me.colCaminhoArquivo, Me.colDescricao})
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
        'colCedente
        '
        Me.colCedente.Caption = "Cedente"
        Me.colCedente.ColumnEdit = Me.txtAlterar
        Me.colCedente.FieldName = "Cedente"
        Me.colCedente.Name = "colCedente"
        Me.colCedente.OptionsColumn.ReadOnly = True
        Me.colCedente.Visible = True
        Me.colCedente.VisibleIndex = 1
        Me.colCedente.Width = 252
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF"
        Me.colCPF.ColumnEdit = Me.txtAlterar
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 2
        Me.colCPF.Width = 120
        '
        'colCodigoBanco
        '
        Me.colCodigoBanco.Caption = "Cód. Banco"
        Me.colCodigoBanco.ColumnEdit = Me.txtAlterar
        Me.colCodigoBanco.FieldName = "CodigoBanco"
        Me.colCodigoBanco.Name = "colCodigoBanco"
        Me.colCodigoBanco.OptionsColumn.ReadOnly = True
        Me.colCodigoBanco.Visible = True
        Me.colCodigoBanco.VisibleIndex = 6
        Me.colCodigoBanco.Width = 103
        '
        'colNomeBanco
        '
        Me.colNomeBanco.Caption = "Nome Banco"
        Me.colNomeBanco.ColumnEdit = Me.txtAlterar
        Me.colNomeBanco.FieldName = "NomeBanco"
        Me.colNomeBanco.Name = "colNomeBanco"
        Me.colNomeBanco.OptionsColumn.ReadOnly = True
        Me.colNomeBanco.Visible = True
        Me.colNomeBanco.VisibleIndex = 7
        Me.colNomeBanco.Width = 165
        '
        'colContaCorrente
        '
        Me.colContaCorrente.Caption = "Conta Corrente"
        Me.colContaCorrente.ColumnEdit = Me.txtAlterar
        Me.colContaCorrente.FieldName = "ContaCorrente"
        Me.colContaCorrente.Name = "colContaCorrente"
        Me.colContaCorrente.OptionsColumn.ReadOnly = True
        Me.colContaCorrente.Visible = True
        Me.colContaCorrente.VisibleIndex = 4
        Me.colContaCorrente.Width = 90
        '
        'colPerMulta
        '
        Me.colPerMulta.Caption = "Per. Multa"
        Me.colPerMulta.ColumnEdit = Me.txtAlterar
        Me.colPerMulta.FieldName = "PerMulta"
        Me.colPerMulta.Name = "colPerMulta"
        Me.colPerMulta.OptionsColumn.ReadOnly = True
        Me.colPerMulta.Visible = True
        Me.colPerMulta.VisibleIndex = 15
        '
        'colCodigoCarteira
        '
        Me.colCodigoCarteira.Caption = "Cód. Carteira"
        Me.colCodigoCarteira.ColumnEdit = Me.txtAlterar
        Me.colCodigoCarteira.FieldName = "CodigoCarteira"
        Me.colCodigoCarteira.Name = "colCodigoCarteira"
        Me.colCodigoCarteira.OptionsColumn.ReadOnly = True
        Me.colCodigoCarteira.Visible = True
        Me.colCodigoCarteira.VisibleIndex = 8
        Me.colCodigoCarteira.Width = 82
        '
        'colCodigoOcorrencia
        '
        Me.colCodigoOcorrencia.Caption = "Cód. Ocorrência"
        Me.colCodigoOcorrencia.ColumnEdit = Me.txtAlterar
        Me.colCodigoOcorrencia.FieldName = "CodigoOcorrencia"
        Me.colCodigoOcorrencia.Name = "colCodigoOcorrencia"
        Me.colCodigoOcorrencia.OptionsColumn.ReadOnly = True
        Me.colCodigoOcorrencia.Visible = True
        Me.colCodigoOcorrencia.VisibleIndex = 9
        '
        'colSeuNumero
        '
        Me.colSeuNumero.Caption = "Seu Número"
        Me.colSeuNumero.ColumnEdit = Me.txtAlterar
        Me.colSeuNumero.FieldName = "SeuNumero"
        Me.colSeuNumero.Name = "colSeuNumero"
        Me.colSeuNumero.OptionsColumn.ReadOnly = True
        '
        'colEspecie
        '
        Me.colEspecie.Caption = "Espécie"
        Me.colEspecie.ColumnEdit = Me.txtAlterar
        Me.colEspecie.FieldName = "Especie"
        Me.colEspecie.Name = "colEspecie"
        Me.colEspecie.OptionsColumn.ReadOnly = True
        '
        'colTipoAceite
        '
        Me.colTipoAceite.Caption = "Tipo Aceite"
        Me.colTipoAceite.ColumnEdit = Me.txtAlterar
        Me.colTipoAceite.FieldName = "TipoAceite"
        Me.colTipoAceite.Name = "colTipoAceite"
        Me.colTipoAceite.OptionsColumn.ReadOnly = True
        '
        'colPrimeiraInstrucao
        '
        Me.colPrimeiraInstrucao.Caption = "1ª Instrução"
        Me.colPrimeiraInstrucao.ColumnEdit = Me.txtAlterar
        Me.colPrimeiraInstrucao.FieldName = "PrimeiraInstrucao"
        Me.colPrimeiraInstrucao.Name = "colPrimeiraInstrucao"
        Me.colPrimeiraInstrucao.OptionsColumn.ReadOnly = True
        Me.colPrimeiraInstrucao.Visible = True
        Me.colPrimeiraInstrucao.VisibleIndex = 10
        '
        'colSegundaInstrucao
        '
        Me.colSegundaInstrucao.Caption = "2ª Cobrança"
        Me.colSegundaInstrucao.ColumnEdit = Me.txtAlterar
        Me.colSegundaInstrucao.FieldName = "SegundaInstrucao"
        Me.colSegundaInstrucao.Name = "colSegundaInstrucao"
        Me.colSegundaInstrucao.OptionsColumn.ReadOnly = True
        Me.colSegundaInstrucao.Visible = True
        Me.colSegundaInstrucao.VisibleIndex = 11
        '
        'colValorMora
        '
        Me.colValorMora.Caption = "Valor Mora"
        Me.colValorMora.ColumnEdit = Me.txtAlterar
        Me.colValorMora.FieldName = "ValorMora"
        Me.colValorMora.Name = "colValorMora"
        Me.colValorMora.OptionsColumn.ReadOnly = True
        Me.colValorMora.Visible = True
        Me.colValorMora.VisibleIndex = 14
        '
        'colValorIOF
        '
        Me.colValorIOF.Caption = "Valor IOF"
        Me.colValorIOF.ColumnEdit = Me.txtAlterar
        Me.colValorIOF.FieldName = "ValorIOF"
        Me.colValorIOF.Name = "colValorIOF"
        Me.colValorIOF.OptionsColumn.ReadOnly = True
        '
        'colAgencia
        '
        Me.colAgencia.Caption = "Agência"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 3
        '
        'colCodigoCedente
        '
        Me.colCodigoCedente.Caption = "Cód. Cedente"
        Me.colCodigoCedente.FieldName = "CodigoCedente"
        Me.colCodigoCedente.Name = "colCodigoCedente"
        Me.colCodigoCedente.OptionsColumn.ReadOnly = True
        Me.colCodigoCedente.Visible = True
        Me.colCodigoCedente.VisibleIndex = 5
        Me.colCodigoCedente.Width = 79
        '
        'colDiasProtesto
        '
        Me.colDiasProtesto.Caption = "Nº Dias Protesto"
        Me.colDiasProtesto.FieldName = "DiasProtesto"
        Me.colDiasProtesto.Name = "colDiasProtesto"
        Me.colDiasProtesto.OptionsColumn.ReadOnly = True
        Me.colDiasProtesto.Visible = True
        Me.colDiasProtesto.VisibleIndex = 12
        Me.colDiasProtesto.Width = 91
        '
        'colPadrao
        '
        Me.colPadrao.Caption = "Padrão"
        Me.colPadrao.ColumnEdit = Me.chkPadraoGrid
        Me.colPadrao.FieldName = "Padrao"
        Me.colPadrao.Name = "colPadrao"
        Me.colPadrao.OptionsColumn.ReadOnly = True
        Me.colPadrao.Visible = True
        Me.colPadrao.VisibleIndex = 16
        '
        'chkPadraoGrid
        '
        Me.chkPadraoGrid.AutoHeight = False
        Me.chkPadraoGrid.Name = "chkPadraoGrid"
        '
        'colDiasMora
        '
        Me.colDiasMora.Caption = "Nº Dias mora"
        Me.colDiasMora.FieldName = "DiasMora"
        Me.colDiasMora.Name = "colDiasMora"
        Me.colDiasMora.OptionsColumn.ReadOnly = True
        Me.colDiasMora.Visible = True
        Me.colDiasMora.VisibleIndex = 13
        '
        'colCodigoTransmissao
        '
        Me.colCodigoTransmissao.Caption = "Cód. Transmissão"
        Me.colCodigoTransmissao.FieldName = "CodigoTransmissao"
        Me.colCodigoTransmissao.Name = "colCodigoTransmissao"
        Me.colCodigoTransmissao.OptionsColumn.ReadOnly = True
        Me.colCodigoTransmissao.Width = 97
        '
        'colInstrucao
        '
        Me.colInstrucao.Caption = "Instrução"
        Me.colInstrucao.FieldName = "Instrucao"
        Me.colInstrucao.Name = "colInstrucao"
        Me.colInstrucao.OptionsColumn.ReadOnly = True
        Me.colInstrucao.Visible = True
        Me.colInstrucao.VisibleIndex = 17
        Me.colInstrucao.Width = 138
        '
        'colRecibo
        '
        Me.colRecibo.Caption = "Recibo"
        Me.colRecibo.ColumnEdit = Me.chkReciboGrid
        Me.colRecibo.FieldName = "Recibo"
        Me.colRecibo.Name = "colRecibo"
        Me.colRecibo.OptionsColumn.ReadOnly = True
        Me.colRecibo.Visible = True
        Me.colRecibo.VisibleIndex = 18
        '
        'chkReciboGrid
        '
        Me.chkReciboGrid.AutoHeight = False
        Me.chkReciboGrid.Name = "chkReciboGrid"
        '
        'colInstrucao2
        '
        Me.colInstrucao2.Caption = "Instrução 2"
        Me.colInstrucao2.FieldName = "Instrucao2"
        Me.colInstrucao2.Name = "colInstrucao2"
        Me.colInstrucao2.Visible = True
        Me.colInstrucao2.VisibleIndex = 19
        '
        'colCodigoVinculacao
        '
        Me.colCodigoVinculacao.Caption = "Cód. Vinculação"
        Me.colCodigoVinculacao.FieldName = "CodigoVinculacao"
        Me.colCodigoVinculacao.Name = "colCodigoVinculacao"
        Me.colCodigoVinculacao.OptionsColumn.ReadOnly = True
        '
        'colCodigoIdenticador
        '
        Me.colCodigoIdenticador.Caption = "Cód. Identificador"
        Me.colCodigoIdenticador.FieldName = "CodigoIdentificador"
        Me.colCodigoIdenticador.Name = "colCodigoIdenticador"
        Me.colCodigoIdenticador.OptionsColumn.ReadOnly = True
        '
        'colTipoAmbiente
        '
        Me.colTipoAmbiente.Caption = "Tipo Ambiente"
        Me.colTipoAmbiente.FieldName = "TipoAmbiente"
        Me.colTipoAmbiente.Name = "colTipoAmbiente"
        Me.colTipoAmbiente.OptionsColumn.ReadOnly = True
        '
        'colCaminhoArquivo
        '
        Me.colCaminhoArquivo.Caption = "CaminhoArquivo"
        Me.colCaminhoArquivo.FieldName = "CaminhoArquivo"
        Me.colCaminhoArquivo.Name = "colCaminhoArquivo"
        Me.colCaminhoArquivo.OptionsColumn.ReadOnly = True
        Me.colCaminhoArquivo.Visible = True
        Me.colCaminhoArquivo.VisibleIndex = 20
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 21
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Controls.Add(Me.chkrecibo)
        Me.GroupControl1.Controls.Add(Me.chkPadrao)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 291)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(701, 235)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Bancos Cadastrados"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtCodigoTransmissao)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Controls.Add(Me.txtInstrucao2)
        Me.PanelControl2.Controls.Add(Label1)
        Me.PanelControl2.Controls.Add(Me.txtInstrucao)
        Me.PanelControl2.Controls.Add(Label3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.txtDiasMora)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.txtDiasProtesto)
        Me.PanelControl2.Controls.Add(Me.cboSegundaInstrucao)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.cboPrimeriaInstrucao)
        Me.PanelControl2.Controls.Add(Me.LabelControl25)
        Me.PanelControl2.Controls.Add(Me.txtValorMora)
        Me.PanelControl2.Controls.Add(Me.LabelControl21)
        Me.PanelControl2.Controls.Add(Me.txtSeuNumero)
        Me.PanelControl2.Controls.Add(Me.LabelControl38)
        Me.PanelControl2.Controls.Add(Me.txtPerMulta)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 145)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(679, 140)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(563, 110)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl6.TabIndex = 165
        Me.LabelControl6.Text = "<br> quebra de linha"
        '
        'txtInstrucao2
        '
        Me.txtInstrucao2.Location = New System.Drawing.Point(96, 87)
        Me.txtInstrucao2.Name = "txtInstrucao2"
        Me.txtInstrucao2.Size = New System.Drawing.Size(573, 20)
        Me.txtInstrucao2.TabIndex = 5
        '
        'txtInstrucao
        '
        Me.txtInstrucao.Location = New System.Drawing.Point(96, 61)
        Me.txtInstrucao.Name = "txtInstrucao"
        Me.txtInstrucao.Size = New System.Drawing.Size(573, 20)
        Me.txtInstrucao.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(465, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 160
        Me.LabelControl2.Text = "Nº Dias Mora"
        '
        'txtDiasMora
        '
        Me.txtDiasMora.CasasDecimais = 0
        Me.txtDiasMora.EnterMoveNextControl = True
        Me.txtDiasMora.Location = New System.Drawing.Point(533, 9)
        Me.txtDiasMora.Name = "txtDiasMora"
        Me.txtDiasMora.Numerico = True
        Me.txtDiasMora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasMora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasMora.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiasMora.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDiasMora.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasMora.Properties.MaxLength = 10
        Me.txtDiasMora.Size = New System.Drawing.Size(136, 20)
        Me.txtDiasMora.TabIndex = 5
        Me.txtDiasMora.Tag = "Nº Dias Protesto"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(448, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl4.TabIndex = 157
        Me.LabelControl4.Text = "Nº Dias Protesto"
        '
        'txtDiasProtesto
        '
        Me.txtDiasProtesto.CasasDecimais = 0
        Me.txtDiasProtesto.EnterMoveNextControl = True
        Me.txtDiasProtesto.Location = New System.Drawing.Point(533, 35)
        Me.txtDiasProtesto.Name = "txtDiasProtesto"
        Me.txtDiasProtesto.Numerico = True
        Me.txtDiasProtesto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDiasProtesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDiasProtesto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiasProtesto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtDiasProtesto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasProtesto.Properties.MaxLength = 10
        Me.txtDiasProtesto.Size = New System.Drawing.Size(136, 20)
        Me.txtDiasProtesto.TabIndex = 11
        Me.txtDiasProtesto.Tag = "Nº Dias Protesto"
        '
        'cboSegundaInstrucao
        '
        Me.cboSegundaInstrucao.EnterMoveNextControl = True
        Me.cboSegundaInstrucao.Location = New System.Drawing.Point(305, 9)
        Me.cboSegundaInstrucao.Name = "cboSegundaInstrucao"
        Me.cboSegundaInstrucao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSegundaInstrucao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSegundaInstrucao.Size = New System.Drawing.Size(116, 20)
        Me.cboSegundaInstrucao.TabIndex = 1
        Me.cboSegundaInstrucao.Tag = "2ª Instrução"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(239, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 154
        Me.LabelControl3.Text = "2ª Instrução"
        '
        'cboPrimeriaInstrucao
        '
        Me.cboPrimeriaInstrucao.EnterMoveNextControl = True
        Me.cboPrimeriaInstrucao.Location = New System.Drawing.Point(96, 9)
        Me.cboPrimeriaInstrucao.Name = "cboPrimeriaInstrucao"
        Me.cboPrimeriaInstrucao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPrimeriaInstrucao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPrimeriaInstrucao.Size = New System.Drawing.Size(132, 20)
        Me.cboPrimeriaInstrucao.TabIndex = 0
        Me.cboPrimeriaInstrucao.Tag = "1ª Instrução"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(39, 38)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl25.TabIndex = 148
        Me.LabelControl25.Text = "Valor Mora"
        '
        'txtValorMora
        '
        Me.txtValorMora.CasasDecimais = 2
        Me.txtValorMora.EnterMoveNextControl = True
        Me.txtValorMora.Location = New System.Drawing.Point(96, 35)
        Me.txtValorMora.Name = "txtValorMora"
        Me.txtValorMora.Numerico = True
        Me.txtValorMora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorMora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtValorMora.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorMora.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorMora.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorMora.Properties.MaxLength = 15
        Me.txtValorMora.Size = New System.Drawing.Size(132, 20)
        Me.txtValorMora.TabIndex = 2
        Me.txtValorMora.Tag = "Valor Mora"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(30, 12)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl21.TabIndex = 117
        Me.LabelControl21.Text = "1ª Instrução"
        '
        'txtSeuNumero
        '
        Me.txtSeuNumero.CasasDecimais = 0
        Me.txtSeuNumero.EnterMoveNextControl = True
        Me.txtSeuNumero.Location = New System.Drawing.Point(115, 35)
        Me.txtSeuNumero.Name = "txtSeuNumero"
        Me.txtSeuNumero.Numerico = False
        Me.txtSeuNumero.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSeuNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSeuNumero.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSeuNumero.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSeuNumero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeuNumero.Properties.MaxLength = 15
        Me.txtSeuNumero.Size = New System.Drawing.Size(10, 20)
        Me.txtSeuNumero.TabIndex = 2
        Me.txtSeuNumero.Tag = "Seu Número"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(250, 38)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl38.TabIndex = 101
        Me.LabelControl38.Text = "Per. Multa"
        '
        'txtPerMulta
        '
        Me.txtPerMulta.CasasDecimais = 2
        Me.txtPerMulta.EditValue = ""
        Me.txtPerMulta.EnterMoveNextControl = True
        Me.txtPerMulta.Location = New System.Drawing.Point(305, 35)
        Me.txtPerMulta.Name = "txtPerMulta"
        Me.txtPerMulta.Numerico = True
        Me.txtPerMulta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPerMulta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPerMulta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerMulta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPerMulta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerMulta.Properties.MaxLength = 15
        Me.txtPerMulta.Size = New System.Drawing.Size(116, 20)
        Me.txtPerMulta.TabIndex = 3
        Me.txtPerMulta.Tag = "Per. Multa"
        '
        'cboTipoAmbiente
        '
        Me.cboTipoAmbiente.EnterMoveNextControl = True
        Me.cboTipoAmbiente.Location = New System.Drawing.Point(244, 19)
        Me.cboTipoAmbiente.Name = "cboTipoAmbiente"
        Me.cboTipoAmbiente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoAmbiente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoAmbiente.Properties.Items.AddRange(New Object() {"HOMOLOGAÇÃO", "PRODUÇÃO"})
        Me.cboTipoAmbiente.Size = New System.Drawing.Size(136, 20)
        Me.cboTipoAmbiente.TabIndex = 0
        Me.cboTipoAmbiente.Tag = "Tipo Carteira"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(190, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl10.TabIndex = 166
        Me.LabelControl10.Text = "Tipo Amb."
        '
        'cboEspecie
        '
        Me.cboEspecie.EnterMoveNextControl = True
        Me.cboEspecie.Location = New System.Drawing.Point(244, 45)
        Me.cboEspecie.Name = "cboEspecie"
        Me.cboEspecie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEspecie.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEspecie.Properties.Items.AddRange(New Object() {"0 - Entrada", "1 - Saída"})
        Me.cboEspecie.Size = New System.Drawing.Size(132, 20)
        Me.cboEspecie.TabIndex = 3
        Me.cboEspecie.Tag = "2ª Instrução"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(372, 48)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl27.TabIndex = 150
        Me.LabelControl27.Text = "Valor IOF"
        '
        'txtValorIOF
        '
        Me.txtValorIOF.CasasDecimais = 2
        Me.txtValorIOF.EnterMoveNextControl = True
        Me.txtValorIOF.Location = New System.Drawing.Point(426, 45)
        Me.txtValorIOF.Name = "txtValorIOF"
        Me.txtValorIOF.Numerico = True
        Me.txtValorIOF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorIOF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtValorIOF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorIOF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorIOF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorIOF.Properties.MaxLength = 15
        Me.txtValorIOF.Size = New System.Drawing.Size(118, 20)
        Me.txtValorIOF.TabIndex = 8
        Me.txtValorIOF.Tag = "Valor IOF"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(352, 22)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl40.TabIndex = 146
        Me.LabelControl40.Text = "Tipo de Aceite"
        '
        'txtTipoAceite
        '
        Me.txtTipoAceite.CasasDecimais = 0
        Me.txtTipoAceite.EditValue = "N"
        Me.txtTipoAceite.EnterMoveNextControl = True
        Me.txtTipoAceite.Location = New System.Drawing.Point(426, 19)
        Me.txtTipoAceite.Name = "txtTipoAceite"
        Me.txtTipoAceite.Numerico = False
        Me.txtTipoAceite.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTipoAceite.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTipoAceite.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAceite.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTipoAceite.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAceite.Properties.MaxLength = 15
        Me.txtTipoAceite.Size = New System.Drawing.Size(118, 20)
        Me.txtTipoAceite.TabIndex = 4
        Me.txtTipoAceite.Tag = "Tipo Aceite"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(202, 48)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl39.TabIndex = 1
        Me.LabelControl39.Text = "Espécie"
        '
        'cboCarteira
        '
        Me.cboCarteira.EnterMoveNextControl = True
        Me.cboCarteira.Location = New System.Drawing.Point(84, 19)
        Me.cboCarteira.Name = "cboCarteira"
        Me.cboCarteira.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCarteira.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCarteira.Properties.Items.AddRange(New Object() {"COM REGISTRO", "SEM REGISTRO"})
        Me.cboCarteira.Size = New System.Drawing.Size(118, 20)
        Me.cboCarteira.TabIndex = 0
        Me.cboCarteira.Tag = "Tipo Carteira"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(13, 22)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl29.TabIndex = 109
        Me.LabelControl29.Text = "Cód. Carteira"
        '
        'cboTipoOcorrencia
        '
        Me.cboTipoOcorrencia.EnterMoveNextControl = True
        Me.cboTipoOcorrencia.Location = New System.Drawing.Point(84, 45)
        Me.cboTipoOcorrencia.Name = "cboTipoOcorrencia"
        Me.cboTipoOcorrencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoOcorrencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOcorrencia.Size = New System.Drawing.Size(116, 20)
        Me.cboTipoOcorrencia.TabIndex = 1
        Me.cboTipoOcorrencia.Tag = "Tipo Ocorrência"
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(3, 48)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl36.TabIndex = 105
        Me.LabelControl36.Text = "Tipo Ocorrência"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTipoAceite)
        Me.PanelControl1.Controls.Add(Me.cboTipoAmbiente)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl40)
        Me.PanelControl1.Controls.Add(Me.txtValorIOF)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.cboCarteira)
        Me.PanelControl1.Controls.Add(Me.LabelControl29)
        Me.PanelControl1.Controls.Add(Me.LabelControl39)
        Me.PanelControl1.Controls.Add(Me.cboTipoOcorrencia)
        Me.PanelControl1.Controls.Add(Me.cboEspecie)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.LabelControl36)
        Me.PanelControl1.Controls.Add(Me.txtCodBanco)
        Me.PanelControl1.Location = New System.Drawing.Point(226, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(61, 38)
        Me.PanelControl1.TabIndex = 167
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmConfigBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 562)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigBoleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração Banco"
        CType(Me.txtCodBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.txtDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaminhoArquivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvContaCorrente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDvCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCedente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNomeBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTransmissao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkrecibo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPadrao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPadraoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReciboGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtInstrucao2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInstrucao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasProtesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSegundaInstrucao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPrimeriaInstrucao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeuNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerMulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoAmbiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEspecie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIOF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoAceite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCarteira.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoOcorrencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodBanco As Campos.NanoCampo
    Friend WithEvents txtContaCorrente As Campos.NanoCampo
    Friend WithEvents txtCedente As Campos.NanoCampo
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCPF As Campos.NanoCampo
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCedente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContaCorrente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerMulta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCarteira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoOcorrencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeuNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEspecie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoAceite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimeiraInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSegundaInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorIOF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCarteira As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoOcorrencia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSeuNumero As Campos.NanoCampo
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPerMulta As Campos.NanoCampo
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorIOF As Campos.NanoCampo
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValorMora As Campos.NanoCampo
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoAceite As Campos.NanoCampo
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNomeBanco As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCedente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDvCedente As Campos.NanoCampo
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodCedente As Campos.NanoCampo
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgencia As Campos.NanoCampo
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiasProtesto As Campos.NanoCampo
    Friend WithEvents cboSegundaInstrucao As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPrimeriaInstrucao As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDvAgencia As Campos.NanoCampo
    Friend WithEvents colDiasProtesto As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cboEspecie As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkPadrao As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPadraoGrid As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtDvContaCorrente As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiasMora As Campos.NanoCampo
    Friend WithEvents colDiasMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodigoTransmissao As Campos.NanoCampo
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCodigoTransmissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtInstrucao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkrecibo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkReciboGrid As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtInstrucao2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colInstrucao2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoVinculacao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoIdenticador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTipoAmbiente As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colTipoAmbiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCaminhoArquivo As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCaminhoArquivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCaminhoArquivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtDescricao As Campos.NanoCampo
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
End Class
