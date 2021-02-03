<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecibo
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibo))
        Me.txtCli = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCPF = New DevExpress.XtraEditors.TextEdit
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup
        Me.txtReferente = New DevExpress.XtraEditors.TextEdit
        Me.txtValor = New DevExpress.XtraEditors.TextEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.txtValorExtenso = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Label6 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorExtenso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(388, 15)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(47, 13)
        Label6.TabIndex = 81
        Label6.Text = "Valor R$"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(405, 93)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 83
        Label8.Text = "Data"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(56, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 85
        Label1.Text = "Referente"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(20, 41)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(92, 13)
        Label3.TabIndex = 86
        Label3.Text = "Valor por Extenso"
        '
        'txtCli
        '
        Me.txtCli.EnterMoveNextControl = True
        Me.txtCli.Location = New System.Drawing.Point(118, 64)
        Me.txtCli.Name = "txtCli"
        Me.txtCli.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.Appearance.Options.UseFont = True
        Me.txtCli.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCli.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCli.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCli.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCli.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtCli.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCli.Size = New System.Drawing.Size(466, 20)
        Me.txtCli.TabIndex = 2
        '
        'txtCPF
        '
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(118, 90)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Properties.Appearance.Options.UseFont = True
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPF.Properties.MaxLength = 18
        Me.txtCPF.Size = New System.Drawing.Size(199, 20)
        Me.txtCPF.TabIndex = 3
        '
        'rdgDoc
        '
        Me.rdgDoc.EditValue = True
        Me.rdgDoc.Location = New System.Drawing.Point(11, 90)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(101, 20)
        Me.rdgDoc.TabIndex = 6
        '
        'txtReferente
        '
        Me.txtReferente.EnterMoveNextControl = True
        Me.txtReferente.Location = New System.Drawing.Point(118, 116)
        Me.txtReferente.Name = "txtReferente"
        Me.txtReferente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtReferente.Properties.Appearance.Options.UseFont = True
        Me.txtReferente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtReferente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtReferente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferente.Size = New System.Drawing.Size(466, 20)
        Me.txtReferente.TabIndex = 5
        Me.txtReferente.Tag = "Referente"
        '
        'txtValor
        '
        Me.txtValor.EnterMoveNextControl = True
        Me.txtValor.Location = New System.Drawing.Point(441, 12)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValor.Size = New System.Drawing.Size(143, 20)
        Me.txtValor.TabIndex = 0
        Me.txtValor.Tag = "Valor R$"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnVisualizar, Me.btnLimpar, Me.btnFechar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Visualizar"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 0
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 1
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'dtData
        '
        Me.dtData.EditValue = ""
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(441, 90)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(143, 20)
        Me.dtData.TabIndex = 4
        Me.dtData.Tag = "Data"
        '
        'txtValorExtenso
        '
        Me.txtValorExtenso.EnterMoveNextControl = True
        Me.txtValorExtenso.Location = New System.Drawing.Point(118, 38)
        Me.txtValorExtenso.Name = "txtValorExtenso"
        Me.txtValorExtenso.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtValorExtenso.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorExtenso.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtValorExtenso.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValorExtenso.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtValorExtenso.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValorExtenso.Properties.ReadOnly = True
        Me.txtValorExtenso.Size = New System.Drawing.Size(466, 20)
        Me.txtValorExtenso.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(81, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 87
        Me.LabelControl1.Text = "Nome"
        Me.LabelControl1.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 88
        Me.LabelControl2.Text = "Funcionário"
        Me.LabelControl2.Visible = False
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = True
        Me.RadioGroup1.Location = New System.Drawing.Point(11, 64)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Func."), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Forn.")})
        Me.RadioGroup1.Size = New System.Drawing.Size(101, 20)
        Me.RadioGroup1.TabIndex = 89
        Me.RadioGroup1.Visible = False
        '
        'frmRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 188)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtValorExtenso)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.txtReferente)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.rdgDoc)
        Me.Controls.Add(Me.txtCli)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo"
        CType(Me.txtCli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorExtenso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCli As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCPF As DevExpress.XtraEditors.TextEdit
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtReferente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtValorExtenso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
End Class
