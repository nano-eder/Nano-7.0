<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetProduto))
        Me.tab = New DevExpress.XtraTab.XtraTabControl
        Me.tabOpc = New DevExpress.XtraTab.XtraTabPage
        Me.txtValCred = New Campos.NanoCampo
        Me.lblValCred = New DevExpress.XtraEditors.LabelControl
        Me.txtCalcCred = New Campos.NanoCampo
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.cboRegime = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboOrigem = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
        Me.txtVFCPST = New Campos.NanoCampo
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtValICMSST = New Campos.NanoCampo
        Me.lblValICMSST = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txtICMSST = New Campos.NanoCampo
        Me.cboModBCST = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.txtRedBCST = New Campos.NanoCampo
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtMVAST = New Campos.NanoCampo
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
        Me.txtValICMS = New Campos.NanoCampo
        Me.lblValICMS = New DevExpress.XtraEditors.LabelControl
        Me.cboModBC = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNfeICMS = New Campos.NanoCampo
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.txtRedBC = New Campos.NanoCampo
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.cboNfeCST = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.txtValIPI = New Campos.NanoCampo
        Me.lblValIPI = New DevExpress.XtraEditors.LabelControl
        Me.txtAliquotaIPI = New Campos.NanoCampo
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodEnq = New DevExpress.XtraEditors.TextEdit
        Me.cboCSTIPI = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.txtValPIS = New Campos.NanoCampo
        Me.lblValPIS = New DevExpress.XtraEditors.LabelControl
        Me.txtAliquotaPIS = New Campos.NanoCampo
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.cboCSTPIS = New DevExpress.XtraEditors.ComboBoxEdit
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.txtValCOFINS = New Campos.NanoCampo
        Me.lblValCOFINS = New DevExpress.XtraEditors.LabelControl
        Me.txtAliquotaCOFINS = New Campos.NanoCampo
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
        Me.cboCSTCOFINS = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lueCFOP = New DevExpress.XtraEditors.LookUpEdit
        Me.CFOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNano = New Nano.dsNano
        Me.txtNfeNCM = New Campos.NanoCampo
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtEXTIPI = New Campos.NanoCampo
        Me.txtGenero = New Campos.NanoCampo
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnTodos = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtProduto = New Campos.NanoCampo
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodProduto = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CFOPTableAdapter = New Nano.dsNanoTableAdapters.CFOPTableAdapter
        Me.cboCodigoANP = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
        Me.cboUF = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.txtCest = New Campos.NanoCampo
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtFreteEnt = New Campos.NanoCampo
        Me.lblFrete = New DevExpress.XtraEditors.LabelControl
        Me.txtDespesasEnt = New Campos.NanoCampo
        Me.lblDespesas = New DevExpress.XtraEditors.LabelControl
        Me.txtSeguroEnt = New Campos.NanoCampo
        Me.lblSeguro = New DevExpress.XtraEditors.LabelControl
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabOpc.SuspendLayout()
        CType(Me.txtValCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalcCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOrigem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.txtVFCPST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValICMSST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtICMSST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModBCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMVAST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.txtValICMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfeICMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRedBC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNfeCST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtValIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotaIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodEnq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txtValPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotaPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtValCOFINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAliquotaCOFINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCSTCOFINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCFOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfeNCM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEXTIPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGenero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCodigoANP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFreteEnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDespesasEnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguroEnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Appearance.Options.UseFont = True
        Me.tab.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.AppearancePage.Header.Options.UseFont = True
        Me.tab.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab.Location = New System.Drawing.Point(0, 88)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabOpc
        Me.tab.Size = New System.Drawing.Size(899, 222)
        Me.tab.TabIndex = 40
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabOpc, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'tabOpc
        '
        Me.tabOpc.Controls.Add(Me.txtValCred)
        Me.tabOpc.Controls.Add(Me.lblValCred)
        Me.tabOpc.Controls.Add(Me.txtCalcCred)
        Me.tabOpc.Controls.Add(Me.LabelControl58)
        Me.tabOpc.Controls.Add(Me.LabelControl57)
        Me.tabOpc.Controls.Add(Me.LabelControl54)
        Me.tabOpc.Controls.Add(Me.LabelControl53)
        Me.tabOpc.Controls.Add(Me.cboRegime)
        Me.tabOpc.Controls.Add(Me.cboOrigem)
        Me.tabOpc.Controls.Add(Me.PanelControl6)
        Me.tabOpc.Controls.Add(Me.LabelControl41)
        Me.tabOpc.Controls.Add(Me.PanelControl7)
        Me.tabOpc.Controls.Add(Me.LabelControl38)
        Me.tabOpc.Controls.Add(Me.cboNfeCST)
        Me.tabOpc.Name = "tabOpc"
        Me.tabOpc.Size = New System.Drawing.Size(890, 191)
        Me.tabOpc.Text = "ICMS"
        '
        'txtValCred
        '
        Me.txtValCred.CasasDecimais = 2
        Me.txtValCred.EnterMoveNextControl = True
        Me.txtValCred.Location = New System.Drawing.Point(746, 35)
        Me.txtValCred.Name = "txtValCred"
        Me.txtValCred.Numerico = True
        Me.txtValCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValCred.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValCred.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValCred.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValCred.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValCred.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValCred.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValCred.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValCred.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValCred.Properties.MaxLength = 5
        Me.txtValCred.Size = New System.Drawing.Size(130, 20)
        Me.txtValCred.TabIndex = 34
        '
        'lblValCred
        '
        Me.lblValCred.Location = New System.Drawing.Point(692, 38)
        Me.lblValCred.Name = "lblValCred"
        Me.lblValCred.Size = New System.Drawing.Size(48, 13)
        Me.lblValCred.TabIndex = 33
        Me.lblValCred.Text = "Val. Créd."
        '
        'txtCalcCred
        '
        Me.txtCalcCred.CasasDecimais = 2
        Me.txtCalcCred.EnterMoveNextControl = True
        Me.txtCalcCred.Location = New System.Drawing.Point(506, 35)
        Me.txtCalcCred.Name = "txtCalcCred"
        Me.txtCalcCred.Numerico = True
        Me.txtCalcCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCalcCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCalcCred.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCalcCred.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCalcCred.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCalcCred.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCalcCred.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCalcCred.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCalcCred.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCalcCred.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCalcCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalcCred.Properties.MaxLength = 5
        Me.txtCalcCred.Size = New System.Drawing.Size(138, 20)
        Me.txtCalcCred.TabIndex = 3
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(431, 38)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl58.TabIndex = 36
        Me.LabelControl58.Text = "Calc. do Créd."
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(29, 12)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl57.TabIndex = 35
        Me.LabelControl57.Text = "Regime"
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl54.Appearance.Options.UseFont = True
        Me.LabelControl54.Location = New System.Drawing.Point(421, 61)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl54.TabIndex = 33
        Me.LabelControl54.Text = "ICMS ST"
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl53.Appearance.Options.UseFont = True
        Me.LabelControl53.Location = New System.Drawing.Point(17, 61)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl53.TabIndex = 32
        Me.LabelControl53.Text = "ICMS"
        '
        'cboRegime
        '
        Me.cboRegime.EnterMoveNextControl = True
        Me.cboRegime.Location = New System.Drawing.Point(70, 9)
        Me.cboRegime.Name = "cboRegime"
        Me.cboRegime.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboRegime.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboRegime.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboRegime.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboRegime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRegime.Properties.Items.AddRange(New Object() {"TRIBUTAÇÃO NORMAL", "SIMPLES NACIONAL"})
        Me.cboRegime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboRegime.Size = New System.Drawing.Size(321, 20)
        Me.cboRegime.TabIndex = 0
        '
        'cboOrigem
        '
        Me.cboOrigem.EnterMoveNextControl = True
        Me.cboOrigem.Location = New System.Drawing.Point(70, 35)
        Me.cboOrigem.Name = "cboOrigem"
        Me.cboOrigem.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboOrigem.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboOrigem.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboOrigem.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboOrigem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOrigem.Properties.Items.AddRange(New Object() {"", "0 - Nacional", "1 - Estrangeira – Importação direta", "2 - Estrangeira – Adquirida no mercado interno", "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quaren" & _
                        "ta por cento)", "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos pro" & _
                        "dutivos básicos de que tratam as legislações citadas nos ajustes", "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40" & _
                        "% (quarenta por cento)", "6 - Estrangeira - Importação direta, sem similar nacional, constante em lista de " & _
                        "Resolução CAMEX", "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante e" & _
                        "m lista de Resolução CAMEX"})
        Me.cboOrigem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboOrigem.Size = New System.Drawing.Size(321, 20)
        Me.cboOrigem.TabIndex = 2
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.txtVFCPST)
        Me.PanelControl6.Controls.Add(Me.LabelControl3)
        Me.PanelControl6.Controls.Add(Me.txtValICMSST)
        Me.PanelControl6.Controls.Add(Me.lblValICMSST)
        Me.PanelControl6.Controls.Add(Me.LabelControl55)
        Me.PanelControl6.Controls.Add(Me.txtICMSST)
        Me.PanelControl6.Controls.Add(Me.cboModBCST)
        Me.PanelControl6.Controls.Add(Me.LabelControl50)
        Me.PanelControl6.Controls.Add(Me.txtRedBCST)
        Me.PanelControl6.Controls.Add(Me.LabelControl51)
        Me.PanelControl6.Controls.Add(Me.txtMVAST)
        Me.PanelControl6.Controls.Add(Me.LabelControl52)
        Me.PanelControl6.Location = New System.Drawing.Point(409, 68)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(475, 115)
        Me.PanelControl6.TabIndex = 5
        '
        'txtVFCPST
        '
        Me.txtVFCPST.CasasDecimais = 0
        Me.txtVFCPST.EnterMoveNextControl = True
        Me.txtVFCPST.Location = New System.Drawing.Point(337, 59)
        Me.txtVFCPST.Name = "txtVFCPST"
        Me.txtVFCPST.Numerico = True
        Me.txtVFCPST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVFCPST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVFCPST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVFCPST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtVFCPST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtVFCPST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtVFCPST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVFCPST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtVFCPST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtVFCPST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtVFCPST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVFCPST.Properties.MaxLength = 8
        Me.txtVFCPST.Size = New System.Drawing.Size(130, 20)
        Me.txtVFCPST.TabIndex = 70
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(276, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 71
        Me.LabelControl3.Text = "Val. FCP ST"
        '
        'txtValICMSST
        '
        Me.txtValICMSST.CasasDecimais = 2
        Me.txtValICMSST.EnterMoveNextControl = True
        Me.txtValICMSST.Location = New System.Drawing.Point(337, 85)
        Me.txtValICMSST.Name = "txtValICMSST"
        Me.txtValICMSST.Numerico = True
        Me.txtValICMSST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValICMSST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValICMSST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValICMSST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValICMSST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValICMSST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValICMSST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValICMSST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValICMSST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValICMSST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValICMSST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValICMSST.Properties.MaxLength = 5
        Me.txtValICMSST.Size = New System.Drawing.Size(130, 20)
        Me.txtValICMSST.TabIndex = 32
        '
        'lblValICMSST
        '
        Me.lblValICMSST.Location = New System.Drawing.Point(270, 88)
        Me.lblValICMSST.Name = "lblValICMSST"
        Me.lblValICMSST.Size = New System.Drawing.Size(61, 13)
        Me.lblValICMSST.TabIndex = 31
        Me.lblValICMSST.Text = "Val. ICMS ST"
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(51, 88)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl55.TabIndex = 30
        Me.LabelControl55.Text = "ICMS ST"
        '
        'txtICMSST
        '
        Me.txtICMSST.CasasDecimais = 2
        Me.txtICMSST.EnterMoveNextControl = True
        Me.txtICMSST.Location = New System.Drawing.Point(97, 85)
        Me.txtICMSST.Name = "txtICMSST"
        Me.txtICMSST.Numerico = True
        Me.txtICMSST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtICMSST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtICMSST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtICMSST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtICMSST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtICMSST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtICMSST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtICMSST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtICMSST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtICMSST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtICMSST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtICMSST.Properties.MaxLength = 5
        Me.txtICMSST.Size = New System.Drawing.Size(138, 20)
        Me.txtICMSST.TabIndex = 3
        '
        'cboModBCST
        '
        Me.cboModBCST.EnterMoveNextControl = True
        Me.cboModBCST.Location = New System.Drawing.Point(97, 7)
        Me.cboModBCST.Name = "cboModBCST"
        Me.cboModBCST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboModBCST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboModBCST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboModBCST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboModBCST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBCST.Properties.Items.AddRange(New Object() {"", "0 – Preço tabelado ou máximo sugerido", "1 - Lista Negativa (valor)", "2 - Lista Positiva (valor)", "3 - Lista Neutra (valor)", "4 - Margem Valor Agregado (%)", "5 - Pauta (valor)"})
        Me.cboModBCST.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBCST.Size = New System.Drawing.Size(370, 20)
        Me.cboModBCST.TabIndex = 0
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(36, 10)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl50.TabIndex = 24
        Me.LabelControl50.Text = "Mod. BC ST"
        '
        'txtRedBCST
        '
        Me.txtRedBCST.CasasDecimais = 2
        Me.txtRedBCST.EnterMoveNextControl = True
        Me.txtRedBCST.Location = New System.Drawing.Point(97, 33)
        Me.txtRedBCST.Name = "txtRedBCST"
        Me.txtRedBCST.Numerico = True
        Me.txtRedBCST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBCST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBCST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRedBCST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtRedBCST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtRedBCST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtRedBCST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRedBCST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtRedBCST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtRedBCST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtRedBCST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBCST.Properties.MaxLength = 5
        Me.txtRedBCST.Size = New System.Drawing.Size(138, 20)
        Me.txtRedBCST.TabIndex = 1
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(37, 36)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl51.TabIndex = 27
        Me.LabelControl51.Text = "Red. BC ST"
        '
        'txtMVAST
        '
        Me.txtMVAST.CasasDecimais = 2
        Me.txtMVAST.EnterMoveNextControl = True
        Me.txtMVAST.Location = New System.Drawing.Point(97, 59)
        Me.txtMVAST.Name = "txtMVAST"
        Me.txtMVAST.Numerico = True
        Me.txtMVAST.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMVAST.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMVAST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMVAST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtMVAST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtMVAST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtMVAST.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMVAST.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtMVAST.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMVAST.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtMVAST.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMVAST.Properties.MaxLength = 5
        Me.txtMVAST.Size = New System.Drawing.Size(138, 20)
        Me.txtMVAST.TabIndex = 2
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(37, 62)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl52.TabIndex = 29
        Me.LabelControl52.Text = "M. V. A. ST"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(482, 12)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl41.TabIndex = 4
        Me.LabelControl41.Text = "CST"
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.txtValICMS)
        Me.PanelControl7.Controls.Add(Me.lblValICMS)
        Me.PanelControl7.Controls.Add(Me.cboModBC)
        Me.PanelControl7.Controls.Add(Me.txtNfeICMS)
        Me.PanelControl7.Controls.Add(Me.LabelControl49)
        Me.PanelControl7.Controls.Add(Me.txtRedBC)
        Me.PanelControl7.Controls.Add(Me.LabelControl40)
        Me.PanelControl7.Controls.Add(Me.LabelControl39)
        Me.PanelControl7.Location = New System.Drawing.Point(6, 68)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(397, 115)
        Me.PanelControl7.TabIndex = 4
        '
        'txtValICMS
        '
        Me.txtValICMS.CasasDecimais = 2
        Me.txtValICMS.EnterMoveNextControl = True
        Me.txtValICMS.Location = New System.Drawing.Point(64, 85)
        Me.txtValICMS.Name = "txtValICMS"
        Me.txtValICMS.Numerico = True
        Me.txtValICMS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValICMS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValICMS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValICMS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValICMS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValICMS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValICMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValICMS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValICMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValICMS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValICMS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValICMS.Properties.MaxLength = 5
        Me.txtValICMS.Size = New System.Drawing.Size(130, 20)
        Me.txtValICMS.TabIndex = 24
        '
        'lblValICMS
        '
        Me.lblValICMS.Location = New System.Drawing.Point(12, 88)
        Me.lblValICMS.Name = "lblValICMS"
        Me.lblValICMS.Size = New System.Drawing.Size(46, 13)
        Me.lblValICMS.TabIndex = 23
        Me.lblValICMS.Text = "Val. ICMS"
        '
        'cboModBC
        '
        Me.cboModBC.EnterMoveNextControl = True
        Me.cboModBC.Location = New System.Drawing.Point(64, 7)
        Me.cboModBC.Name = "cboModBC"
        Me.cboModBC.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboModBC.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboModBC.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboModBC.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboModBC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboModBC.Properties.Items.AddRange(New Object() {"", "0 - Margem Valor Agregado (%)", "1 - Pauta (Valor)", "2 - Preço Tabelado Máx. (valor)", "3 - valor da operação"})
        Me.cboModBC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboModBC.Size = New System.Drawing.Size(321, 20)
        Me.cboModBC.TabIndex = 0
        '
        'txtNfeICMS
        '
        Me.txtNfeICMS.CasasDecimais = 2
        Me.txtNfeICMS.EnterMoveNextControl = True
        Me.txtNfeICMS.Location = New System.Drawing.Point(64, 59)
        Me.txtNfeICMS.Name = "txtNfeICMS"
        Me.txtNfeICMS.Numerico = True
        Me.txtNfeICMS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNfeICMS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNfeICMS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNfeICMS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNfeICMS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNfeICMS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNfeICMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNfeICMS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNfeICMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNfeICMS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNfeICMS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNfeICMS.Properties.MaxLength = 5
        Me.txtNfeICMS.Size = New System.Drawing.Size(130, 20)
        Me.txtNfeICMS.TabIndex = 2
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(20, 36)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl49.TabIndex = 22
        Me.LabelControl49.Text = "Red. BC"
        '
        'txtRedBC
        '
        Me.txtRedBC.CasasDecimais = 2
        Me.txtRedBC.EnterMoveNextControl = True
        Me.txtRedBC.Location = New System.Drawing.Point(64, 33)
        Me.txtRedBC.Name = "txtRedBC"
        Me.txtRedBC.Numerico = True
        Me.txtRedBC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRedBC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRedBC.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRedBC.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtRedBC.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtRedBC.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtRedBC.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRedBC.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtRedBC.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtRedBC.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtRedBC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRedBC.Properties.MaxLength = 5
        Me.txtRedBC.Size = New System.Drawing.Size(130, 20)
        Me.txtRedBC.TabIndex = 1
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(19, 10)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl40.TabIndex = 3
        Me.LabelControl40.Text = "Mod. BC"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(34, 62)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl39.TabIndex = 2
        Me.LabelControl39.Text = "ICMS"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(31, 38)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl38.TabIndex = 1
        Me.LabelControl38.Text = "Origem"
        '
        'cboNfeCST
        '
        Me.cboNfeCST.EnterMoveNextControl = True
        Me.cboNfeCST.Location = New System.Drawing.Point(506, 9)
        Me.cboNfeCST.Name = "cboNfeCST"
        Me.cboNfeCST.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboNfeCST.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboNfeCST.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboNfeCST.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboNfeCST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNfeCST.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNfeCST.Size = New System.Drawing.Size(370, 20)
        Me.cboNfeCST.TabIndex = 1
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtValIPI)
        Me.XtraTabPage2.Controls.Add(Me.lblValIPI)
        Me.XtraTabPage2.Controls.Add(Me.txtAliquotaIPI)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl27)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage2.Controls.Add(Me.txtCodEnq)
        Me.XtraTabPage2.Controls.Add(Me.cboCSTIPI)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(890, 191)
        Me.XtraTabPage2.Text = "IPI"
        '
        'txtValIPI
        '
        Me.txtValIPI.CasasDecimais = 2
        Me.txtValIPI.EnterMoveNextControl = True
        Me.txtValIPI.Location = New System.Drawing.Point(70, 66)
        Me.txtValIPI.Name = "txtValIPI"
        Me.txtValIPI.Numerico = True
        Me.txtValIPI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValIPI.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValIPI.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValIPI.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValIPI.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValIPI.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValIPI.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValIPI.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValIPI.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValIPI.Properties.MaxLength = 5
        Me.txtValIPI.Size = New System.Drawing.Size(130, 20)
        Me.txtValIPI.TabIndex = 26
        '
        'lblValIPI
        '
        Me.lblValIPI.Location = New System.Drawing.Point(24, 69)
        Me.lblValIPI.Name = "lblValIPI"
        Me.lblValIPI.Size = New System.Drawing.Size(40, 13)
        Me.lblValIPI.TabIndex = 25
        Me.lblValIPI.Text = "Valor R$"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.CasasDecimais = 2
        Me.txtAliquotaIPI.EnterMoveNextControl = True
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(70, 40)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Numerico = True
        Me.txtAliquotaIPI.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaIPI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaIPI.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAliquotaIPI.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtAliquotaIPI.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtAliquotaIPI.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtAliquotaIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaIPI.Properties.MaxLength = 16
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaIPI.TabIndex = 3
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(398, 17)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl27.TabIndex = 8
        Me.LabelControl27.Text = "Cód. Enquadramento"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(25, 43)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl26.TabIndex = 7
        Me.LabelControl26.Text = "Alíquota"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(45, 17)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl24.TabIndex = 5
        Me.LabelControl24.Text = "CST"
        '
        'txtCodEnq
        '
        Me.txtCodEnq.Location = New System.Drawing.Point(506, 14)
        Me.txtCodEnq.Name = "txtCodEnq"
        Me.txtCodEnq.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodEnq.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodEnq.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodEnq.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodEnq.Size = New System.Drawing.Size(130, 20)
        Me.txtCodEnq.TabIndex = 1
        '
        'cboCSTIPI
        '
        Me.cboCSTIPI.Location = New System.Drawing.Point(70, 14)
        Me.cboCSTIPI.Name = "cboCSTIPI"
        Me.cboCSTIPI.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboCSTIPI.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCSTIPI.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCSTIPI.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCSTIPI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTIPI.Properties.Items.AddRange(New Object() {"", "00 - Entrada com Recuperação de Crédito", "01 - Entrada Tributável com Alíquota Zero", "02 - Entrada Isenta", "03 - Entrada Não-Tributada", "04 - Entrada Imune", "05 - Entrada com Suspensão", "49 - Outras Entradas", "50 - Saída Tributada", "51 - Saída Tributável com Alíquota Zero", "52 - Saida Isenta", "53 - Saída Não-Tributada", "54 - Saída Imune", "55 - Saída com Suspensão", "99 - Outras Saídas"})
        Me.cboCSTIPI.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTIPI.Size = New System.Drawing.Size(321, 20)
        Me.cboCSTIPI.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.txtValPIS)
        Me.XtraTabPage3.Controls.Add(Me.lblValPIS)
        Me.XtraTabPage3.Controls.Add(Me.txtAliquotaPIS)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl62)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl64)
        Me.XtraTabPage3.Controls.Add(Me.cboCSTPIS)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(890, 191)
        Me.XtraTabPage3.Text = "PIS"
        '
        'txtValPIS
        '
        Me.txtValPIS.CasasDecimais = 2
        Me.txtValPIS.EnterMoveNextControl = True
        Me.txtValPIS.Location = New System.Drawing.Point(70, 65)
        Me.txtValPIS.Name = "txtValPIS"
        Me.txtValPIS.Numerico = True
        Me.txtValPIS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValPIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValPIS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValPIS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValPIS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValPIS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValPIS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValPIS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValPIS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValPIS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValPIS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValPIS.Properties.MaxLength = 5
        Me.txtValPIS.Size = New System.Drawing.Size(130, 20)
        Me.txtValPIS.TabIndex = 26
        '
        'lblValPIS
        '
        Me.lblValPIS.Location = New System.Drawing.Point(24, 68)
        Me.lblValPIS.Name = "lblValPIS"
        Me.lblValPIS.Size = New System.Drawing.Size(40, 13)
        Me.lblValPIS.TabIndex = 25
        Me.lblValPIS.Text = "Valor R$"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.CasasDecimais = 2
        Me.txtAliquotaPIS.EnterMoveNextControl = True
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(70, 39)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Numerico = True
        Me.txtAliquotaPIS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaPIS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaPIS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAliquotaPIS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtAliquotaPIS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtAliquotaPIS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtAliquotaPIS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaPIS.Properties.MaxLength = 16
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaPIS.TabIndex = 12
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(25, 42)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl62.TabIndex = 16
        Me.LabelControl62.Text = "Alíquota"
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(45, 16)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl64.TabIndex = 14
        Me.LabelControl64.Text = "CST"
        '
        'cboCSTPIS
        '
        Me.cboCSTPIS.Location = New System.Drawing.Point(70, 13)
        Me.cboCSTPIS.Name = "cboCSTPIS"
        Me.cboCSTPIS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboCSTPIS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCSTPIS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCSTPIS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCSTPIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTPIS.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno, e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno, e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCSTPIS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTPIS.Size = New System.Drawing.Size(806, 20)
        Me.cboCSTPIS.TabIndex = 10
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txtValCOFINS)
        Me.XtraTabPage4.Controls.Add(Me.lblValCOFINS)
        Me.XtraTabPage4.Controls.Add(Me.txtAliquotaCOFINS)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl66)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl68)
        Me.XtraTabPage4.Controls.Add(Me.cboCSTCOFINS)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(890, 191)
        Me.XtraTabPage4.Text = "COFINS"
        '
        'txtValCOFINS
        '
        Me.txtValCOFINS.CasasDecimais = 2
        Me.txtValCOFINS.EnterMoveNextControl = True
        Me.txtValCOFINS.Location = New System.Drawing.Point(70, 65)
        Me.txtValCOFINS.Name = "txtValCOFINS"
        Me.txtValCOFINS.Numerico = True
        Me.txtValCOFINS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValCOFINS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValCOFINS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValCOFINS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValCOFINS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValCOFINS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValCOFINS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtValCOFINS.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValCOFINS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValCOFINS.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValCOFINS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValCOFINS.Properties.MaxLength = 5
        Me.txtValCOFINS.Size = New System.Drawing.Size(130, 20)
        Me.txtValCOFINS.TabIndex = 26
        '
        'lblValCOFINS
        '
        Me.lblValCOFINS.Location = New System.Drawing.Point(24, 68)
        Me.lblValCOFINS.Name = "lblValCOFINS"
        Me.lblValCOFINS.Size = New System.Drawing.Size(40, 13)
        Me.lblValCOFINS.TabIndex = 25
        Me.lblValCOFINS.Text = "Valor R$"
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.CasasDecimais = 2
        Me.txtAliquotaCOFINS.EnterMoveNextControl = True
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(70, 39)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Numerico = True
        Me.txtAliquotaCOFINS.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAliquotaCOFINS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAliquotaCOFINS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAliquotaCOFINS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtAliquotaCOFINS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtAliquotaCOFINS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtAliquotaCOFINS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliquotaCOFINS.Properties.MaxLength = 16
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(130, 20)
        Me.txtAliquotaCOFINS.TabIndex = 20
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(25, 42)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl66.TabIndex = 24
        Me.LabelControl66.Text = "Alíquota"
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(45, 16)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl68.TabIndex = 22
        Me.LabelControl68.Text = "CST"
        '
        'cboCSTCOFINS
        '
        Me.cboCSTCOFINS.Location = New System.Drawing.Point(70, 13)
        Me.cboCSTCOFINS.Name = "cboCSTCOFINS"
        Me.cboCSTCOFINS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.cboCSTCOFINS.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCSTCOFINS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCSTCOFINS.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCSTCOFINS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCSTCOFINS.Properties.Items.AddRange(New Object() {"", "01 - Operação Tributável com Alíquota Básica", "02 - Operação Tributável com Alíquota Diferenciada", "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto", "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero", "05 - Operação Tributável por Substituição Tributária", "06 - Operação Tributável a Alíquota Zero", "07 - Operação Isenta da Contribuição", "08 - Operação sem Incidência da Contribuição", "09 - Operação com Suspensão da Contribuição", "49 - Outras Operações de Saída", "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributad" & _
                        "a no Mercado Interno", "51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não-Trib" & _
                        "utada no Mercado Interno", "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Expor" & _
                        "tação", "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno", "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado " & _
                        "Interno e de Exportação", "55 - Operação com Direito a Crédito - Vinculada a Receitas Não Tributadas no Merc" & _
                        "ado Interno e de Exportação", "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tribu" & _
                        "tadas no Mercado Interno e de Exportação", "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Tributada no Mercado Interno", "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " Não-Tributada no Mercado Interno", "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita" & _
                        " de Exportação", "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno", "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no" & _
                        " Mercado Interno e de Exportação", "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributada" & _
                        "s no Mercado Interno e de Exportação", "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e " & _
                        "Não-Tributadas no Mercado Interno e de Exportação", "67 - Crédito Presumido - Outras Operações", "70 - Operação de Aquisição sem Direito a Crédito", "71 - Operação de Aquisição com Isenção", "72 - Operação de Aquisição com Suspensão", "73 - Operação de Aquisição a Alíquota Zero", "74 - Operação de Aquisição sem Incidência da Contribuição", "75 - Operação de Aquisição por Substituição Tributária", "98 - Outras Operações de Entrada", "99 - Outras Operações"})
        Me.cboCSTCOFINS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCSTCOFINS.Size = New System.Drawing.Size(806, 20)
        Me.cboCSTCOFINS.TabIndex = 18
        '
        'lueCFOP
        '
        Me.lueCFOP.EnterMoveNextControl = True
        Me.lueCFOP.Location = New System.Drawing.Point(73, 38)
        Me.lueCFOP.Name = "lueCFOP"
        Me.lueCFOP.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.lueCFOP.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.lueCFOP.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueCFOP.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.lueCFOP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCFOP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CFOP", "CFOP", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NatOper", "Descrição", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueCFOP.Properties.DataSource = Me.CFOPBindingSource
        Me.lueCFOP.Properties.DisplayMember = "CFOP"
        Me.lueCFOP.Properties.NullText = ""
        Me.lueCFOP.Properties.PopupWidth = 500
        Me.lueCFOP.Properties.ValueMember = "CFOP"
        Me.lueCFOP.Size = New System.Drawing.Size(130, 20)
        Me.lueCFOP.TabIndex = 37
        '
        'CFOPBindingSource
        '
        Me.CFOPBindingSource.DataMember = "CFOP"
        Me.CFOPBindingSource.DataSource = Me.DsNano
        '
        'DsNano
        '
        Me.DsNano.DataSetName = "dsNano"
        Me.DsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNfeNCM
        '
        Me.txtNfeNCM.CasasDecimais = 0
        Me.txtNfeNCM.EnterMoveNextControl = True
        Me.txtNfeNCM.Location = New System.Drawing.Point(264, 38)
        Me.txtNfeNCM.Name = "txtNfeNCM"
        Me.txtNfeNCM.Numerico = True
        Me.txtNfeNCM.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNfeNCM.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNfeNCM.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNfeNCM.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNfeNCM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNfeNCM.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNfeNCM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNfeNCM.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNfeNCM.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNfeNCM.Properties.MaxLength = 8
        Me.txtNfeNCM.Size = New System.Drawing.Size(130, 20)
        Me.txtNfeNCM.TabIndex = 40
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(236, 41)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl56.TabIndex = 54
        Me.LabelControl56.Text = "NCM"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(40, 41)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl23.TabIndex = 53
        Me.LabelControl23.Text = "CFOP"
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(235, 147)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl47.TabIndex = 51
        Me.LabelControl47.Text = "Gênero"
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(41, 147)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl48.TabIndex = 52
        Me.LabelControl48.Text = "EX_TIPI"
        '
        'txtEXTIPI
        '
        Me.txtEXTIPI.CasasDecimais = 0
        Me.txtEXTIPI.EnterMoveNextControl = True
        Me.txtEXTIPI.Location = New System.Drawing.Point(85, 144)
        Me.txtEXTIPI.Name = "txtEXTIPI"
        Me.txtEXTIPI.Numerico = True
        Me.txtEXTIPI.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEXTIPI.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtEXTIPI.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtEXTIPI.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtEXTIPI.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEXTIPI.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtEXTIPI.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtEXTIPI.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtEXTIPI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEXTIPI.Properties.MaxLength = 3
        Me.txtEXTIPI.Size = New System.Drawing.Size(130, 20)
        Me.txtEXTIPI.TabIndex = 38
        '
        'txtGenero
        '
        Me.txtGenero.CasasDecimais = 0
        Me.txtGenero.EnterMoveNextControl = True
        Me.txtGenero.Location = New System.Drawing.Point(276, 144)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Numerico = True
        Me.txtGenero.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGenero.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtGenero.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtGenero.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtGenero.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGenero.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtGenero.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtGenero.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtGenero.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGenero.Properties.MaxLength = 2
        Me.txtGenero.Size = New System.Drawing.Size(130, 20)
        Me.txtGenero.TabIndex = 39
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEditar, Me.btnSalvar, Me.btnFechar, Me.btnTodos})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTodos, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnEditar
        '
        Me.btnEditar.Caption = "&Editar"
        Me.btnEditar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnEditar.Id = 0
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnTodos
        '
        Me.btnTodos.Caption = "Salvar para &Todos"
        Me.btnTodos.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnTodos.Id = 4
        Me.btnTodos.Name = "btnTodos"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'txtProduto
        '
        Me.txtProduto.CasasDecimais = 0
        Me.txtProduto.Enabled = False
        Me.txtProduto.EnterMoveNextControl = True
        Me.txtProduto.Location = New System.Drawing.Point(264, 12)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Numerico = False
        Me.txtProduto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProduto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtProduto.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProduto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Properties.MaxLength = 8
        Me.txtProduto.Size = New System.Drawing.Size(615, 20)
        Me.txtProduto.TabIndex = 64
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(220, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 65
        Me.LabelControl1.Text = "Produto"
        '
        'txtCodProduto
        '
        Me.txtCodProduto.CasasDecimais = 0
        Me.txtCodProduto.Enabled = False
        Me.txtCodProduto.EnterMoveNextControl = True
        Me.txtCodProduto.Location = New System.Drawing.Point(73, 12)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Numerico = False
        Me.txtCodProduto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodProduto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodProduto.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodProduto.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCodProduto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodProduto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodProduto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodProduto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProduto.Properties.MaxLength = 8
        Me.txtCodProduto.Size = New System.Drawing.Size(130, 20)
        Me.txtCodProduto.TabIndex = 66
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(34, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 67
        Me.LabelControl2.Text = "Código"
        '
        'CFOPTableAdapter
        '
        Me.CFOPTableAdapter.ClearBeforeFill = True
        '
        'cboCodigoANP
        '
        Me.cboCodigoANP.EnterMoveNextControl = True
        Me.cboCodigoANP.Location = New System.Drawing.Point(509, 38)
        Me.cboCodigoANP.Name = "cboCodigoANP"
        Me.cboCodigoANP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCodigoANP.Properties.Items.AddRange(New Object() {"", "810201001", "820101001", "820101010", "610101009", "210202003", "210202001", "210202002", "620501002", "620501001", "610101005", "610101006", "620601003", "340101002", "560101002", "820101026", "820101032", "820101027", "820101004", "820101005", "820101022", "820101014", "820101006", "820101031", "820101030", "820101016", "820101015", "820101025", "820101007", "820101002", "820101009", "820101008", "820101017", "820101018", "820101019", "820101020", "820101021", "420201001", "420201003", "620101002", "620101007", "210301001", "810102001", "810102004", "810102002", "810102003", "810101002", "810101001", "810101003", "210301002", "210302004", "210101001", "210302003", "210302002", "210204001", "220101003", "220101004", "220101002", "220101001", "220101005", "220101006", "520101001", "320101001", "320101003", "320101002", "320103001", "320102002", "320102001", "320102004", "320102003", "320201001", "320201002", "220102001", "320301002", "210203001", "210203002", "650101001", "620101001", "610201001", "610201002", "610201003", "620101004", "620101005", "220102002", "640201001", "640101001", "620502001", "610101002", "610401002", "610101003", "610401003", "610101004", "610401004", "510101003", "510101001", "510101002", "510102003", "510102001", "510102002", "510201001", "510201002", "510201003", "510301003", "560101001", "420105001", "420101005", "420101004", "420101003", "420102006", "420102005", "420102004", "420102003", "420104001", "820101033", "820101034", "820101011", "820101003", "820101028", "820101029", "820101013", "820101012", "420301003", "420201002", "420202001", "420301001", "610601001", "610701001", "510301002", "620601001", "660101001", "620401001", "620301001", "620201001", "630101001", "320301001", "320103002", "650101002", "640401001", "810201002", "340101003", "560101003", "210302001", "210204002", "610201004", "510301001", "420301002", "620601004", "620505001", "610501001", "620101008", "610101010", "610302001", "610301001", "620101003", "210201001", "210201002", "210201003", "620601002", "550101001", "550101005", "550101002", "550101003", "550101004", "610101001", "610401001", "620101006", "620504001", "620503001", "610101007", "610101008", "640301001"})
        Me.cboCodigoANP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCodigoANP.Size = New System.Drawing.Size(130, 20)
        Me.cboCodigoANP.TabIndex = 64
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(735, 41)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(13, 13)
        Me.LabelControl70.TabIndex = 67
        Me.LabelControl70.Text = "UF"
        '
        'cboUF
        '
        Me.cboUF.EditValue = "SP"
        Me.cboUF.EnterMoveNextControl = True
        Me.cboUF.Location = New System.Drawing.Point(754, 38)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Properties.Appearance.Options.UseTextOptions = True
        Me.cboUF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboUF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUF.Properties.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cboUF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUF.Size = New System.Drawing.Size(48, 20)
        Me.cboUF.TabIndex = 65
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(457, 41)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl69.TabIndex = 66
        Me.LabelControl69.Text = "Cód. ANP"
        '
        'txtCest
        '
        Me.txtCest.CasasDecimais = 0
        Me.txtCest.EnterMoveNextControl = True
        Me.txtCest.Location = New System.Drawing.Point(73, 64)
        Me.txtCest.Name = "txtCest"
        Me.txtCest.Numerico = True
        Me.txtCest.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCest.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCest.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCest.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCest.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCest.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCest.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCest.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCest.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCest.Properties.MaxLength = 8
        Me.txtCest.Size = New System.Drawing.Size(130, 20)
        Me.txtCest.TabIndex = 68
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(42, 67)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 69
        Me.LabelControl9.Text = "CEST"
        '
        'txtFreteEnt
        '
        Me.txtFreteEnt.CasasDecimais = 0
        Me.txtFreteEnt.EnterMoveNextControl = True
        Me.txtFreteEnt.Location = New System.Drawing.Point(264, 64)
        Me.txtFreteEnt.Name = "txtFreteEnt"
        Me.txtFreteEnt.Numerico = True
        Me.txtFreteEnt.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFreteEnt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFreteEnt.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFreteEnt.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtFreteEnt.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtFreteEnt.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtFreteEnt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFreteEnt.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtFreteEnt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFreteEnt.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFreteEnt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFreteEnt.Properties.MaxLength = 8
        Me.txtFreteEnt.Size = New System.Drawing.Size(130, 20)
        Me.txtFreteEnt.TabIndex = 72
        '
        'lblFrete
        '
        Me.lblFrete.Location = New System.Drawing.Point(216, 67)
        Me.lblFrete.Name = "lblFrete"
        Me.lblFrete.Size = New System.Drawing.Size(42, 13)
        Me.lblFrete.TabIndex = 73
        Me.lblFrete.Text = "Frete R$"
        '
        'txtDespesasEnt
        '
        Me.txtDespesasEnt.CasasDecimais = 0
        Me.txtDespesasEnt.EnterMoveNextControl = True
        Me.txtDespesasEnt.Location = New System.Drawing.Point(509, 64)
        Me.txtDespesasEnt.Name = "txtDespesasEnt"
        Me.txtDespesasEnt.Numerico = True
        Me.txtDespesasEnt.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDespesasEnt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDespesasEnt.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDespesasEnt.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDespesasEnt.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDespesasEnt.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDespesasEnt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDespesasEnt.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtDespesasEnt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDespesasEnt.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDespesasEnt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDespesasEnt.Properties.MaxLength = 8
        Me.txtDespesasEnt.Size = New System.Drawing.Size(130, 20)
        Me.txtDespesasEnt.TabIndex = 74
        '
        'lblDespesas
        '
        Me.lblDespesas.Location = New System.Drawing.Point(416, 67)
        Me.lblDespesas.Name = "lblDespesas"
        Me.lblDespesas.Size = New System.Drawing.Size(87, 13)
        Me.lblDespesas.TabIndex = 75
        Me.lblDespesas.Text = "Out. Despesas R$"
        '
        'txtSeguroEnt
        '
        Me.txtSeguroEnt.CasasDecimais = 0
        Me.txtSeguroEnt.EnterMoveNextControl = True
        Me.txtSeguroEnt.Location = New System.Drawing.Point(754, 64)
        Me.txtSeguroEnt.Name = "txtSeguroEnt"
        Me.txtSeguroEnt.Numerico = True
        Me.txtSeguroEnt.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSeguroEnt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSeguroEnt.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSeguroEnt.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtSeguroEnt.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSeguroEnt.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSeguroEnt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSeguroEnt.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtSeguroEnt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSeguroEnt.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSeguroEnt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSeguroEnt.Properties.MaxLength = 8
        Me.txtSeguroEnt.Size = New System.Drawing.Size(130, 20)
        Me.txtSeguroEnt.TabIndex = 76
        '
        'lblSeguro
        '
        Me.lblSeguro.Location = New System.Drawing.Point(698, 69)
        Me.lblSeguro.Name = "lblSeguro"
        Me.lblSeguro.Size = New System.Drawing.Size(50, 13)
        Me.lblSeguro.TabIndex = 77
        Me.lblSeguro.Text = "Seguro R$"
        '
        'frmDetProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 346)
        Me.Controls.Add(Me.txtSeguroEnt)
        Me.Controls.Add(Me.lblSeguro)
        Me.Controls.Add(Me.txtDespesasEnt)
        Me.Controls.Add(Me.lblDespesas)
        Me.Controls.Add(Me.txtFreteEnt)
        Me.Controls.Add(Me.lblFrete)
        Me.Controls.Add(Me.txtCest)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cboCodigoANP)
        Me.Controls.Add(Me.LabelControl70)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.LabelControl69)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.lueCFOP)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtEXTIPI)
        Me.Controls.Add(Me.LabelControl48)
        Me.Controls.Add(Me.txtNfeNCM)
        Me.Controls.Add(Me.LabelControl56)
        Me.Controls.Add(Me.LabelControl47)
        Me.Controls.Add(Me.LabelControl23)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Tributação do Produto"
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabOpc.ResumeLayout(False)
        Me.tabOpc.PerformLayout()
        CType(Me.txtValCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalcCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRegime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOrigem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.txtVFCPST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValICMSST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtICMSST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModBCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMVAST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.txtValICMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfeICMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRedBC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNfeCST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtValIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotaIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodEnq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txtValPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotaPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txtValCOFINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAliquotaCOFINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCSTCOFINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCFOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfeNCM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEXTIPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGenero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCodigoANP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFreteEnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDespesasEnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguroEnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents lueCFOP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNfeNCM As Campos.NanoCampo
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEXTIPI As Campos.NanoCampo
    Friend WithEvents txtGenero As Campos.NanoCampo
    Friend WithEvents tabOpc As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCalcCred As Campos.NanoCampo
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRegime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboOrigem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtICMSST As Campos.NanoCampo
    Friend WithEvents cboModBCST As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRedBCST As Campos.NanoCampo
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMVAST As Campos.NanoCampo
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboModBC As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNfeICMS As Campos.NanoCampo
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRedBC As Campos.NanoCampo
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNfeCST As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaIPI As Campos.NanoCampo
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodEnq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCSTIPI As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaPIS As Campos.NanoCampo
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCSTPIS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAliquotaCOFINS As Campos.NanoCampo
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCSTCOFINS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCodProduto As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProduto As Campos.NanoCampo
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNano As Nano.dsNano
    Friend WithEvents CFOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFOPTableAdapter As Nano.dsNanoTableAdapters.CFOPTableAdapter
    Friend WithEvents cboCodigoANP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboUF As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCest As Campos.NanoCampo
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValCred As Campos.NanoCampo
    Friend WithEvents lblValCred As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValICMSST As Campos.NanoCampo
    Friend WithEvents lblValICMSST As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValICMS As Campos.NanoCampo
    Friend WithEvents lblValICMS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValIPI As Campos.NanoCampo
    Friend WithEvents lblValIPI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValPIS As Campos.NanoCampo
    Friend WithEvents lblValPIS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValCOFINS As Campos.NanoCampo
    Friend WithEvents lblValCOFINS As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVFCPST As Campos.NanoCampo
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSeguroEnt As Campos.NanoCampo
    Friend WithEvents lblSeguro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDespesasEnt As Campos.NanoCampo
    Friend WithEvents lblDespesas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFreteEnt As Campos.NanoCampo
    Friend WithEvents lblFrete As DevExpress.XtraEditors.LabelControl
End Class
