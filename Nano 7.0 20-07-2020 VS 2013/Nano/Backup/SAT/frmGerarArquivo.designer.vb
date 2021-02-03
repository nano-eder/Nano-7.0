<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerarArquivo
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerarArquivo))
        Me.cboAno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.cboMes = New DevExpress.XtraEditors.ComboBoxEdit
        Me.rdgTipo = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDestino = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnGerar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.dtFinal = New DevExpress.XtraEditors.DateEdit
        Me.dtInicial = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtNumFinal = New Campos.NanoCampo
        Me.txtNumInicial = New Campos.NanoCampo
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.fbdDestino = New System.Windows.Forms.FolderBrowserDialog
        Label4 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtNumFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Blue
        Label4.Location = New System.Drawing.Point(16, 62)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(63, 14)
        Label4.TabIndex = 112
        Label4.Text = "Mês/Ano"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(16, 111)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 14)
        Label1.TabIndex = 118
        Label1.Text = "Período"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Blue
        Label2.Location = New System.Drawing.Point(16, 160)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 14)
        Label2.TabIndex = 120
        Label2.Text = "Nº Cupom"
        '
        'cboAno
        '
        Me.cboAno.EnterMoveNextControl = True
        Me.cboAno.Location = New System.Drawing.Point(67, 9)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAno.Size = New System.Drawing.Size(100, 20)
        Me.cboAno.TabIndex = 0
        '
        'cboMes
        '
        Me.cboMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMes.EnterMoveNextControl = True
        Me.cboMes.Location = New System.Drawing.Point(240, 9)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMes.Properties.Items.AddRange(New Object() {"", "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO"})
        Me.cboMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboMes.Size = New System.Drawing.Size(100, 20)
        Me.cboMes.TabIndex = 23
        '
        'rdgTipo
        '
        Me.rdgTipo.Location = New System.Drawing.Point(76, 38)
        Me.rdgTipo.Name = "rdgTipo"
        Me.rdgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "MÊS/ANO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "PERÍODO"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Nº CUPOM")})
        Me.rdgTipo.Size = New System.Drawing.Size(273, 22)
        Me.rdgTipo.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.cboAno)
        Me.PanelControl4.Controls.Add(Me.cboMes)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Location = New System.Drawing.Point(9, 70)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(350, 38)
        Me.PanelControl4.TabIndex = 113
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(215, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 115
        Me.LabelControl2.Text = "Mês"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(42, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 114
        Me.LabelControl1.Text = "Ano"
        '
        'txtDestino
        '
        Me.txtDestino.EnterMoveNextControl = True
        Me.txtDestino.Location = New System.Drawing.Point(76, 12)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDestino.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtDestino.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDestino.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtDestino.Size = New System.Drawing.Size(273, 20)
        Me.txtDestino.TabIndex = 0
        Me.txtDestino.Tag = "Nome Cliente"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(34, 15)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl32.TabIndex = 3
        Me.LabelControl32.Text = "Destino"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnGerar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGerar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnGerar
        '
        Me.btnGerar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnGerar.Caption = "&Gerar"
        Me.btnGerar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnGerar.Id = 0
        Me.btnGerar.Name = "btnGerar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtFinal)
        Me.PanelControl1.Controls.Add(Me.dtInicial)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 119)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(350, 38)
        Me.PanelControl1.TabIndex = 119
        '
        'dtFinal
        '
        Me.dtFinal.EditValue = Nothing
        Me.dtFinal.EnterMoveNextControl = True
        Me.dtFinal.Location = New System.Drawing.Point(240, 9)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFinal.Size = New System.Drawing.Size(100, 20)
        Me.dtFinal.TabIndex = 117
        '
        'dtInicial
        '
        Me.dtInicial.EditValue = Nothing
        Me.dtInicial.EnterMoveNextControl = True
        Me.dtInicial.Location = New System.Drawing.Point(67, 9)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicial.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtInicial.Size = New System.Drawing.Size(100, 20)
        Me.dtInicial.TabIndex = 116
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl3.TabIndex = 115
        Me.LabelControl3.Text = "Data Inicial"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(186, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl4.TabIndex = 114
        Me.LabelControl4.Text = "Data Final"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtNumFinal)
        Me.PanelControl2.Controls.Add(Me.txtNumInicial)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 168)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(350, 38)
        Me.PanelControl2.TabIndex = 121
        '
        'txtNumFinal
        '
        Me.txtNumFinal.CasasDecimais = 0
        Me.txtNumFinal.EnterMoveNextControl = True
        Me.txtNumFinal.Location = New System.Drawing.Point(240, 9)
        Me.txtNumFinal.Name = "txtNumFinal"
        Me.txtNumFinal.Numerico = True
        Me.txtNumFinal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumFinal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumFinal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumFinal.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumFinal.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumFinal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumFinal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumFinal.Properties.MaxLength = 15
        Me.txtNumFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtNumFinal.TabIndex = 123
        '
        'txtNumInicial
        '
        Me.txtNumInicial.CasasDecimais = 0
        Me.txtNumInicial.EnterMoveNextControl = True
        Me.txtNumInicial.Location = New System.Drawing.Point(67, 9)
        Me.txtNumInicial.Name = "txtNumInicial"
        Me.txtNumInicial.Numerico = True
        Me.txtNumInicial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumInicial.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumInicial.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNumInicial.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumInicial.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumInicial.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumInicial.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumInicial.Properties.MaxLength = 15
        Me.txtNumInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtNumInicial.TabIndex = 122
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(19, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl5.TabIndex = 115
        Me.LabelControl5.Text = "Nº Inicial"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(197, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 114
        Me.LabelControl6.Text = "Nº Final"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl7.TabIndex = 122
        Me.LabelControl7.Text = "Tipo Pesquisa"
        '
        'frmGerarArquivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 252)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.rdgTipo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGerarArquivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar Arquivo"
        CType(Me.cboAno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txtDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dtFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtNumFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboMes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents rdgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDestino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dtFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumFinal As Campos.NanoCampo
    Friend WithEvents txtNumInicial As Campos.NanoCampo
    Friend WithEvents btnGerar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fbdDestino As System.Windows.Forms.FolderBrowserDialog
End Class
