<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigFiscal))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.pnlConfig = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtAssinatura = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cboImpressora = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnSalvarEcf = New DevExpress.XtraEditors.SimpleButton
        Me.btnConsultarDadosECF = New DevExpress.XtraEditors.SimpleButton
        Me.btnGerarDadosECF = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
        Me.txtMFAdicional = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoEquipamento = New DevExpress.XtraEditors.TextEdit
        Me.txtEcfVersaoSB = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfNumSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfMarca = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfModelo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfDataSB = New DevExpress.XtraEditors.TextEdit
        Me.txtEcfNumECF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfTipo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
        Me.txtEcfCliche = New System.Windows.Forms.RichTextBox
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfIE = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtEcfCNPJ = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.txtCadAliquota = New Campos.NanoCampo
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.btnSalvarAliquota = New DevExpress.XtraEditors.SimpleButton
        Me.btnCarregarAliquota = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.dsEcf = New System.Data.DataSet
        Me.tbAliquota = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.tbFormaPag = New System.Data.DataTable
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.tbAliquotaBD = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.tbFormaPagBD = New System.Data.DataTable
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.grd3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquota2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndica = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAliquota = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.btnPagSat = New DevExpress.XtraEditors.SimpleButton
        Me.btnCarregarFormaPag = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl
        Me.grd4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPag2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.grd2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIndice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFormaPag = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton
        Me.txtChavePublica = New DevExpress.XtraEditors.TextEdit
        Me.btnGerar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.txtChavePrivada = New DevExpress.XtraEditors.TextEdit
        Me.chkDireto = New DevExpress.XtraEditors.CheckEdit
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConfig.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtAssinatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.txtMFAdicional.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoEquipamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfVersaoSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfNumSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfDataSB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfNumECF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.txtEcfIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEcfCNPJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.txtCadAliquota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsEcf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAliquota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFormaPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAliquotaBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFormaPagBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.txtChavePublica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChavePrivada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDireto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'pnlConfig
        '
        Me.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlConfig.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfig.Name = "pnlConfig"
        Me.pnlConfig.SelectedTabPage = Me.XtraTabPage2
        Me.pnlConfig.Size = New System.Drawing.Size(740, 440)
        Me.pnlConfig.TabIndex = 18
        Me.pnlConfig.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage2.Controls.Add(Me.btnSalvarEcf)
        Me.XtraTabPage2.Controls.Add(Me.btnConsultarDadosECF)
        Me.XtraTabPage2.Controls.Add(Me.btnGerarDadosECF)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl42)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl43)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl8)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(731, 409)
        Me.XtraTabPage2.Text = "Dados ECF"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 306)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Assinatura AC"
        Me.LabelControl2.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.chkDireto)
        Me.PanelControl2.Controls.Add(Me.txtAssinatura)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 313)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(710, 49)
        Me.PanelControl2.TabIndex = 27
        Me.PanelControl2.Visible = False
        '
        'txtAssinatura
        '
        Me.txtAssinatura.Location = New System.Drawing.Point(98, 15)
        Me.txtAssinatura.Name = "txtAssinatura"
        Me.txtAssinatura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAssinatura.Size = New System.Drawing.Size(380, 20)
        Me.txtAssinatura.TabIndex = 27
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(41, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Assinatura"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(25, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "Tipo da Impressora"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.cboImpressora)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 14)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(710, 49)
        Me.PanelControl1.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(38, 21)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Impressora"
        '
        'cboImpressora
        '
        Me.cboImpressora.EnterMoveNextControl = True
        Me.cboImpressora.Location = New System.Drawing.Point(98, 18)
        Me.cboImpressora.Name = "cboImpressora"
        Me.cboImpressora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboImpressora.Properties.Items.AddRange(New Object() {"DARUMA", "BEMATECH"})
        Me.cboImpressora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboImpressora.Size = New System.Drawing.Size(160, 20)
        Me.cboImpressora.TabIndex = 22
        '
        'btnSalvarEcf
        '
        Me.btnSalvarEcf.Location = New System.Drawing.Point(625, 383)
        Me.btnSalvarEcf.Name = "btnSalvarEcf"
        Me.btnSalvarEcf.Size = New System.Drawing.Size(83, 23)
        Me.btnSalvarEcf.TabIndex = 21
        Me.btnSalvarEcf.Text = "Salvar"
        '
        'btnConsultarDadosECF
        '
        Me.btnConsultarDadosECF.Location = New System.Drawing.Point(109, 383)
        Me.btnConsultarDadosECF.Name = "btnConsultarDadosECF"
        Me.btnConsultarDadosECF.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarDadosECF.TabIndex = 20
        Me.btnConsultarDadosECF.Text = "Consultar BD"
        '
        'btnGerarDadosECF
        '
        Me.btnGerarDadosECF.Location = New System.Drawing.Point(186, 383)
        Me.btnGerarDadosECF.Name = "btnGerarDadosECF"
        Me.btnGerarDadosECF.Size = New System.Drawing.Size(83, 23)
        Me.btnGerarDadosECF.TabIndex = 19
        Me.btnGerarDadosECF.Text = "Consulta ECF"
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl42.Appearance.Options.UseFont = True
        Me.LabelControl42.Location = New System.Drawing.Point(25, 191)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl42.TabIndex = 18
        Me.LabelControl42.Text = "Dados do ECF"
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl43.Appearance.Options.UseFont = True
        Me.LabelControl43.Location = New System.Drawing.Point(25, 71)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl43.TabIndex = 17
        Me.LabelControl43.Text = "Dados do Proprietário"
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.txtMFAdicional)
        Me.PanelControl8.Controls.Add(Me.LabelControl59)
        Me.PanelControl8.Controls.Add(Me.LabelControl58)
        Me.PanelControl8.Controls.Add(Me.txtCodigoEquipamento)
        Me.PanelControl8.Controls.Add(Me.txtEcfVersaoSB)
        Me.PanelControl8.Controls.Add(Me.LabelControl44)
        Me.PanelControl8.Controls.Add(Me.txtEcfNumSerie)
        Me.PanelControl8.Controls.Add(Me.LabelControl45)
        Me.PanelControl8.Controls.Add(Me.txtEcfMarca)
        Me.PanelControl8.Controls.Add(Me.LabelControl46)
        Me.PanelControl8.Controls.Add(Me.LabelControl47)
        Me.PanelControl8.Controls.Add(Me.txtEcfModelo)
        Me.PanelControl8.Controls.Add(Me.LabelControl52)
        Me.PanelControl8.Controls.Add(Me.txtEcfDataSB)
        Me.PanelControl8.Controls.Add(Me.txtEcfNumECF)
        Me.PanelControl8.Controls.Add(Me.LabelControl53)
        Me.PanelControl8.Controls.Add(Me.txtEcfTipo)
        Me.PanelControl8.Controls.Add(Me.LabelControl54)
        Me.PanelControl8.Location = New System.Drawing.Point(11, 198)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(710, 98)
        Me.PanelControl8.TabIndex = 16
        '
        'txtMFAdicional
        '
        Me.txtMFAdicional.Location = New System.Drawing.Point(547, 43)
        Me.txtMFAdicional.Name = "txtMFAdicional"
        Me.txtMFAdicional.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtMFAdicional.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMFAdicional.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMFAdicional.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMFAdicional.Properties.ReadOnly = True
        Me.txtMFAdicional.Size = New System.Drawing.Size(150, 20)
        Me.txtMFAdicional.TabIndex = 19
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(482, 46)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl59.TabIndex = 18
        Me.LabelControl59.Text = "MF Adicional"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(485, 73)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl58.TabIndex = 16
        Me.LabelControl58.Text = "Cód. Equip."
        '
        'txtCodigoEquipamento
        '
        Me.txtCodigoEquipamento.Location = New System.Drawing.Point(547, 69)
        Me.txtCodigoEquipamento.Name = "txtCodigoEquipamento"
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigoEquipamento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigoEquipamento.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoEquipamento.TabIndex = 17
        '
        'txtEcfVersaoSB
        '
        Me.txtEcfVersaoSB.Location = New System.Drawing.Point(98, 69)
        Me.txtEcfVersaoSB.Name = "txtEcfVersaoSB"
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfVersaoSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfVersaoSB.Properties.ReadOnly = True
        Me.txtEcfVersaoSB.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfVersaoSB.TabIndex = 11
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(44, 73)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl44.TabIndex = 10
        Me.LabelControl44.Text = "Versão SB"
        '
        'txtEcfNumSerie
        '
        Me.txtEcfNumSerie.Location = New System.Drawing.Point(547, 17)
        Me.txtEcfNumSerie.Name = "txtEcfNumSerie"
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfNumSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfNumSerie.Properties.ReadOnly = True
        Me.txtEcfNumSerie.Size = New System.Drawing.Size(150, 20)
        Me.txtEcfNumSerie.TabIndex = 9
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(502, 20)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl45.TabIndex = 8
        Me.LabelControl45.Text = "Nº Serie"
        '
        'txtEcfMarca
        '
        Me.txtEcfMarca.Location = New System.Drawing.Point(318, 43)
        Me.txtEcfMarca.Name = "txtEcfMarca"
        Me.txtEcfMarca.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfMarca.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfMarca.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfMarca.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfMarca.Properties.ReadOnly = True
        Me.txtEcfMarca.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfMarca.TabIndex = 7
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(283, 46)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl46.TabIndex = 6
        Me.LabelControl46.Text = "Marca"
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(274, 72)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl47.TabIndex = 14
        Me.LabelControl47.Text = "Data SB"
        '
        'txtEcfModelo
        '
        Me.txtEcfModelo.Location = New System.Drawing.Point(98, 43)
        Me.txtEcfModelo.Name = "txtEcfModelo"
        Me.txtEcfModelo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfModelo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfModelo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfModelo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfModelo.Properties.ReadOnly = True
        Me.txtEcfModelo.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfModelo.TabIndex = 5
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(58, 46)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl52.TabIndex = 4
        Me.LabelControl52.Text = "Modelo"
        '
        'txtEcfDataSB
        '
        Me.txtEcfDataSB.Location = New System.Drawing.Point(318, 69)
        Me.txtEcfDataSB.Name = "txtEcfDataSB"
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfDataSB.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfDataSB.Properties.ReadOnly = True
        Me.txtEcfDataSB.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfDataSB.TabIndex = 15
        '
        'txtEcfNumECF
        '
        Me.txtEcfNumECF.Location = New System.Drawing.Point(318, 17)
        Me.txtEcfNumECF.Name = "txtEcfNumECF"
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfNumECF.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfNumECF.Properties.ReadOnly = True
        Me.txtEcfNumECF.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfNumECF.TabIndex = 3
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(278, 20)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl53.TabIndex = 2
        Me.LabelControl53.Text = "Nº ECF"
        '
        'txtEcfTipo
        '
        Me.txtEcfTipo.Location = New System.Drawing.Point(98, 17)
        Me.txtEcfTipo.Name = "txtEcfTipo"
        Me.txtEcfTipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfTipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfTipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfTipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfTipo.Properties.ReadOnly = True
        Me.txtEcfTipo.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfTipo.TabIndex = 1
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(72, 20)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl54.TabIndex = 0
        Me.LabelControl54.Text = "Tipo"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.txtEcfCliche)
        Me.PanelControl9.Controls.Add(Me.LabelControl55)
        Me.PanelControl9.Controls.Add(Me.txtEcfIE)
        Me.PanelControl9.Controls.Add(Me.LabelControl56)
        Me.PanelControl9.Controls.Add(Me.txtEcfCNPJ)
        Me.PanelControl9.Controls.Add(Me.LabelControl57)
        Me.PanelControl9.Location = New System.Drawing.Point(11, 78)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(710, 103)
        Me.PanelControl9.TabIndex = 15
        '
        'txtEcfCliche
        '
        Me.txtEcfCliche.BackColor = System.Drawing.Color.White
        Me.txtEcfCliche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEcfCliche.Location = New System.Drawing.Point(98, 44)
        Me.txtEcfCliche.Name = "txtEcfCliche"
        Me.txtEcfCliche.ReadOnly = True
        Me.txtEcfCliche.Size = New System.Drawing.Size(599, 51)
        Me.txtEcfCliche.TabIndex = 6
        Me.txtEcfCliche.Text = ""
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(64, 46)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl55.TabIndex = 1
        Me.LabelControl55.Text = "Clichê"
        '
        'txtEcfIE
        '
        Me.txtEcfIE.Location = New System.Drawing.Point(318, 18)
        Me.txtEcfIE.Name = "txtEcfIE"
        Me.txtEcfIE.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfIE.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfIE.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfIE.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfIE.Properties.ReadOnly = True
        Me.txtEcfIE.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfIE.TabIndex = 3
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(302, 21)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl56.TabIndex = 2
        Me.LabelControl56.Text = "IE"
        '
        'txtEcfCNPJ
        '
        Me.txtEcfCNPJ.Location = New System.Drawing.Point(98, 18)
        Me.txtEcfCNPJ.Name = "txtEcfCNPJ"
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEcfCNPJ.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEcfCNPJ.Properties.ReadOnly = True
        Me.txtEcfCNPJ.Size = New System.Drawing.Size(160, 20)
        Me.txtEcfCNPJ.TabIndex = 1
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(67, 21)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl57.TabIndex = 0
        Me.LabelControl57.Text = "CNPJ"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.SplitContainerControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(731, 409)
        Me.XtraTabPage3.Text = "ECF"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.txtCadAliquota)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.LabelControl60)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(731, 409)
        Me.SplitContainerControl2.SplitterPosition = 385
        Me.SplitContainerControl2.TabIndex = 3
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'txtCadAliquota
        '
        Me.txtCadAliquota.CasasDecimais = 2
        Me.txtCadAliquota.EnterMoveNextControl = True
        Me.txtCadAliquota.Location = New System.Drawing.Point(53, 13)
        Me.txtCadAliquota.Name = "txtCadAliquota"
        Me.txtCadAliquota.Numerico = True
        Me.txtCadAliquota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCadAliquota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCadAliquota.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCadAliquota.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCadAliquota.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCadAliquota.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCadAliquota.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCadAliquota.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCadAliquota.Properties.MaxLength = 15
        Me.txtCadAliquota.Size = New System.Drawing.Size(161, 20)
        Me.txtCadAliquota.TabIndex = 3
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(8, 16)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl60.TabIndex = 2
        Me.LabelControl60.Text = "Alíquota"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl3.Controls.Add(Me.btnSalvarAliquota)
        Me.GroupControl3.Controls.Add(Me.btnCarregarAliquota)
        Me.GroupControl3.Controls.Add(Me.GroupControl5)
        Me.GroupControl3.Controls.Add(Me.GroupControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 39)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(381, 366)
        Me.GroupControl3.TabIndex = 1
        '
        'btnSalvarAliquota
        '
        Me.btnSalvarAliquota.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvarAliquota.Appearance.Options.UseBackColor = True
        Me.btnSalvarAliquota.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSalvarAliquota.Image = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvarAliquota.Location = New System.Drawing.Point(284, 332)
        Me.btnSalvarAliquota.Name = "btnSalvarAliquota"
        Me.btnSalvarAliquota.Size = New System.Drawing.Size(83, 31)
        Me.btnSalvarAliquota.TabIndex = 21
        Me.btnSalvarAliquota.Text = "Salvar"
        '
        'btnCarregarAliquota
        '
        Me.btnCarregarAliquota.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarAliquota.Appearance.Options.UseBackColor = True
        Me.btnCarregarAliquota.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCarregarAliquota.Image = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCarregarAliquota.Location = New System.Drawing.Point(8, 332)
        Me.btnCarregarAliquota.Name = "btnCarregarAliquota"
        Me.btnCarregarAliquota.Size = New System.Drawing.Size(84, 31)
        Me.btnCarregarAliquota.TabIndex = 22
        Me.btnCarregarAliquota.Text = "Atualizar"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.GridControl3)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(2, 176)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(377, 151)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Alíquotas cadastradas no BD"
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "tbAliquotaBD"
        Me.GridControl3.DataSource = Me.dsEcf
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(2, 20)
        Me.GridControl3.MainView = Me.grd3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(373, 129)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd3})
        '
        'dsEcf
        '
        Me.dsEcf.DataSetName = "NewDataSet"
        Me.dsEcf.Tables.AddRange(New System.Data.DataTable() {Me.tbAliquota, Me.tbFormaPag, Me.tbAliquotaBD, Me.tbFormaPagBD})
        '
        'tbAliquota
        '
        Me.tbAliquota.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbAliquota.TableName = "tbAliquota"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Indica"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Aliquota"
        '
        'tbFormaPag
        '
        Me.tbFormaPag.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn3, Me.DataColumn4})
        Me.tbFormaPag.TableName = "tbFormaPag"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Indice"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FormaPag"
        '
        'tbAliquotaBD
        '
        Me.tbAliquotaBD.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.tbAliquotaBD.TableName = "tbAliquotaBD"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Indica"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Aliquota"
        '
        'tbFormaPagBD
        '
        Me.tbFormaPagBD.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8})
        Me.tbFormaPagBD.TableName = "tbFormaPagBD"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Indice"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "FormaPag"
        '
        'grd3
        '
        Me.grd3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice2, Me.colAliquota2})
        Me.grd3.GridControl = Me.GridControl3
        Me.grd3.Name = "grd3"
        Me.grd3.OptionsView.ShowGroupPanel = False
        '
        'colIndice2
        '
        Me.colIndice2.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice2.Caption = "Índice"
        Me.colIndice2.FieldName = "Indica"
        Me.colIndice2.Name = "colIndice2"
        Me.colIndice2.OptionsColumn.ReadOnly = True
        Me.colIndice2.Visible = True
        Me.colIndice2.VisibleIndex = 0
        Me.colIndice2.Width = 79
        '
        'colAliquota2
        '
        Me.colAliquota2.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquota2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquota2.Caption = "Alíquota"
        Me.colAliquota2.FieldName = "Aliquota"
        Me.colAliquota2.Name = "colAliquota2"
        Me.colAliquota2.OptionsColumn.ReadOnly = True
        Me.colAliquota2.Visible = True
        Me.colAliquota2.VisibleIndex = 1
        Me.colAliquota2.Width = 135
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(377, 174)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Alíquotas cadastradas no ECF"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbAliquota"
        Me.GridControl1.DataSource = Me.dsEcf
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(373, 152)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndica, Me.colAliquota})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colIndica
        '
        Me.colIndica.AppearanceCell.Options.UseTextOptions = True
        Me.colIndica.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndica.Caption = "Índice"
        Me.colIndica.FieldName = "Indica"
        Me.colIndica.Name = "colIndica"
        Me.colIndica.OptionsColumn.ReadOnly = True
        Me.colIndica.Visible = True
        Me.colIndica.VisibleIndex = 0
        Me.colIndica.Width = 79
        '
        'colAliquota
        '
        Me.colAliquota.AppearanceCell.Options.UseTextOptions = True
        Me.colAliquota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAliquota.Caption = "Alíquota"
        Me.colAliquota.FieldName = "Aliquota"
        Me.colAliquota.Name = "colAliquota"
        Me.colAliquota.OptionsColumn.ReadOnly = True
        Me.colAliquota.Visible = True
        Me.colAliquota.VisibleIndex = 1
        Me.colAliquota.Width = 135
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl4.Controls.Add(Me.btnPagSat)
        Me.GroupControl4.Controls.Add(Me.btnCarregarFormaPag)
        Me.GroupControl4.Controls.Add(Me.GroupControl6)
        Me.GroupControl4.Controls.Add(Me.GroupControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(0, 39)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(336, 366)
        Me.GroupControl4.TabIndex = 3
        '
        'btnPagSat
        '
        Me.btnPagSat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnPagSat.Appearance.Options.UseBackColor = True
        Me.btnPagSat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnPagSat.Image = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnPagSat.Location = New System.Drawing.Point(227, 332)
        Me.btnPagSat.Name = "btnPagSat"
        Me.btnPagSat.Size = New System.Drawing.Size(104, 31)
        Me.btnPagSat.TabIndex = 24
        Me.btnPagSat.Text = "Inserir SAT"
        '
        'btnCarregarFormaPag
        '
        Me.btnCarregarFormaPag.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnCarregarFormaPag.Appearance.Options.UseBackColor = True
        Me.btnCarregarFormaPag.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCarregarFormaPag.Image = Global.Nano.My.Resources.Resources.Alterar
        Me.btnCarregarFormaPag.Location = New System.Drawing.Point(5, 332)
        Me.btnCarregarFormaPag.Name = "btnCarregarFormaPag"
        Me.btnCarregarFormaPag.Size = New System.Drawing.Size(84, 31)
        Me.btnCarregarFormaPag.TabIndex = 23
        Me.btnCarregarFormaPag.Text = "Atualizar"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.Controls.Add(Me.GridControl4)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(2, 176)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(332, 151)
        Me.GroupControl6.TabIndex = 3
        Me.GroupControl6.Text = "Formas de pagamentos cadastradas no DB"
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "tbFormaPagBD"
        Me.GridControl4.DataSource = Me.dsEcf
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Name = ""
        Me.GridControl4.Location = New System.Drawing.Point(2, 20)
        Me.GridControl4.MainView = Me.grd4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(328, 129)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd4})
        '
        'grd4
        '
        Me.grd4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice3, Me.colFormaPag2})
        Me.grd4.GridControl = Me.GridControl4
        Me.grd4.Name = "grd4"
        Me.grd4.OptionsView.ShowGroupPanel = False
        '
        'colIndice3
        '
        Me.colIndice3.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice3.Caption = "Índice"
        Me.colIndice3.FieldName = "Indice"
        Me.colIndice3.Name = "colIndice3"
        Me.colIndice3.OptionsColumn.ReadOnly = True
        Me.colIndice3.Visible = True
        Me.colIndice3.VisibleIndex = 0
        Me.colIndice3.Width = 80
        '
        'colFormaPag2
        '
        Me.colFormaPag2.Caption = "Forma Pag."
        Me.colFormaPag2.FieldName = "FormaPag"
        Me.colFormaPag2.Name = "colFormaPag2"
        Me.colFormaPag2.OptionsColumn.ReadOnly = True
        Me.colFormaPag2.Visible = True
        Me.colFormaPag2.VisibleIndex = 1
        Me.colFormaPag2.Width = 134
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(332, 174)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Formas de pagamentos cadastradas no ECF"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "tbFormaPag"
        Me.GridControl2.DataSource = Me.dsEcf
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.MainView = Me.grd2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(328, 152)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd2})
        '
        'grd2
        '
        Me.grd2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIndice, Me.colFormaPag})
        Me.grd2.GridControl = Me.GridControl2
        Me.grd2.Name = "grd2"
        Me.grd2.OptionsView.ShowGroupPanel = False
        '
        'colIndice
        '
        Me.colIndice.AppearanceCell.Options.UseTextOptions = True
        Me.colIndice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIndice.Caption = "Índice"
        Me.colIndice.FieldName = "Indice"
        Me.colIndice.Name = "colIndice"
        Me.colIndice.OptionsColumn.ReadOnly = True
        Me.colIndice.Visible = True
        Me.colIndice.VisibleIndex = 0
        Me.colIndice.Width = 80
        '
        'colFormaPag
        '
        Me.colFormaPag.Caption = "Forma Pag."
        Me.colFormaPag.FieldName = "FormaPag"
        Me.colFormaPag.Name = "colFormaPag"
        Me.colFormaPag.OptionsColumn.ReadOnly = True
        Me.colFormaPag.Visible = True
        Me.colFormaPag.VisibleIndex = 1
        Me.colFormaPag.Width = 134
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(731, 409)
        Me.XtraTabPage4.Text = "Chave"
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.btnConsultar)
        Me.PanelControl7.Controls.Add(Me.txtChavePublica)
        Me.PanelControl7.Controls.Add(Me.btnGerar)
        Me.PanelControl7.Controls.Add(Me.LabelControl35)
        Me.PanelControl7.Controls.Add(Me.LabelControl34)
        Me.PanelControl7.Controls.Add(Me.txtChavePrivada)
        Me.PanelControl7.Location = New System.Drawing.Point(9, 23)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(715, 102)
        Me.PanelControl7.TabIndex = 5
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(7, 72)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        '
        'txtChavePublica
        '
        Me.txtChavePublica.Location = New System.Drawing.Point(81, 20)
        Me.txtChavePublica.Name = "txtChavePublica"
        Me.txtChavePublica.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtChavePublica.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtChavePublica.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtChavePublica.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtChavePublica.Properties.ReadOnly = True
        Me.txtChavePublica.Size = New System.Drawing.Size(626, 20)
        Me.txtChavePublica.TabIndex = 0
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(632, 72)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGerar.TabIndex = 5
        Me.btnGerar.Text = "Gerar"
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(8, 49)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl35.TabIndex = 3
        Me.LabelControl35.Text = "Chave Privada"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(8, 23)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl34.TabIndex = 1
        Me.LabelControl34.Text = "Chave Pública"
        '
        'txtChavePrivada
        '
        Me.txtChavePrivada.Location = New System.Drawing.Point(81, 46)
        Me.txtChavePrivada.Name = "txtChavePrivada"
        Me.txtChavePrivada.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtChavePrivada.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtChavePrivada.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtChavePrivada.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtChavePrivada.Properties.ReadOnly = True
        Me.txtChavePrivada.Size = New System.Drawing.Size(626, 20)
        Me.txtChavePrivada.TabIndex = 2
        '
        'chkDireto
        '
        Me.chkDireto.Location = New System.Drawing.Point(622, 15)
        Me.chkDireto.Name = "chkDireto"
        Me.chkDireto.Properties.Caption = "Imp. Direto"
        Me.chkDireto.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkDireto.Size = New System.Drawing.Size(75, 19)
        Me.chkDireto.TabIndex = 126
        '
        'frmConfigFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 462)
        Me.Controls.Add(Me.pnlConfig)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração Cupom Fiscal"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlConfig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConfig.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtAssinatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboImpressora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.txtMFAdicional.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoEquipamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfVersaoSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfNumSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfDataSB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfNumECF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        Me.PanelControl9.PerformLayout()
        CType(Me.txtEcfIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEcfCNPJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.txtCadAliquota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsEcf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAliquota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFormaPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAliquotaBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFormaPagBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.txtChavePublica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChavePrivada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDireto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pnlConfig As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnSalvarEcf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsultarDadosECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGerarDadosECF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtMFAdicional As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoEquipamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEcfVersaoSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfNumSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfDataSB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEcfNumECF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtEcfCliche As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEcfCNPJ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtCadAliquota As Campos.NanoCampo
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquota2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAliquota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCarregarAliquota As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalvarAliquota As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCarregarFormaPag As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPag2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIndice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboImpressora As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtChavePublica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChavePrivada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dsEcf As System.Data.DataSet
    Friend WithEvents tbAliquota As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents tbFormaPag As System.Data.DataTable
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents tbAliquotaBD As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents tbFormaPagBD As System.Data.DataTable
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAssinatura As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnPagSat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkDireto As DevExpress.XtraEditors.CheckEdit
End Class
