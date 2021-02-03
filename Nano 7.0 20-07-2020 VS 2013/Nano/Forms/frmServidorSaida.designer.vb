<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServidorSaida
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
        Dim ServidorLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServidorSaida))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnTestar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ServidorTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SenhaTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.ServicoComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtPorta = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtCopia = New DevExpress.XtraEditors.TextEdit
        Me.EmailTableAdapter = New Nano.dsNanoCommerceTableAdapters.EmailTableAdapter
        ServidorLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        SenhaLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServidorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenhaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ServicoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtCopia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ServidorLabel
        '
        ServidorLabel.AutoSize = True
        ServidorLabel.Location = New System.Drawing.Point(24, 47)
        ServidorLabel.Name = "ServidorLabel"
        ServidorLabel.Size = New System.Drawing.Size(33, 13)
        ServidorLabel.TabIndex = 5
        ServidorLabel.Text = "SMTP"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(22, 15)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "E-Mail"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(20, 41)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(37, 13)
        SenhaLabel.TabIndex = 9
        SenhaLabel.Text = "Senha"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Blue
        Label3.Location = New System.Drawing.Point(17, 5)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(114, 14)
        Label3.TabIndex = 63
        Label3.Text = "Servidor de Saída"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Blue
        Label1.Location = New System.Drawing.Point(17, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(99, 14)
        Label1.TabIndex = 64
        Label1.Text = "E-Mail de Envio"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 73)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(33, 13)
        Label2.TabIndex = 7
        Label2.Text = "Porta"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(15, 21)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(42, 13)
        Label4.TabIndex = 10
        Label4.Text = "Serviço"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(22, 67)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(34, 13)
        Label5.TabIndex = 11
        Label5.Text = "Cópia"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnTestar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTestar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnTestar
        '
        Me.btnTestar.Caption = "&Testar Conta"
        Me.btnTestar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnTestar.Id = 1
        Me.btnTestar.Name = "btnTestar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'ServidorTextEdit
        '
        Me.ServidorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Servidor", True))
        Me.ServidorTextEdit.Location = New System.Drawing.Point(63, 44)
        Me.ServidorTextEdit.Name = "ServidorTextEdit"
        Me.ServidorTextEdit.Properties.MaxLength = 200
        Me.ServidorTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.ServidorTextEdit.TabIndex = 1
        '
        'EmailBindingSource
        '
        Me.EmailBindingSource.DataMember = "Email"
        Me.EmailBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNano"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(63, 12)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.MaxLength = 200
        Me.EmailTextEdit.Size = New System.Drawing.Size(263, 20)
        Me.EmailTextEdit.TabIndex = 0
        '
        'SenhaTextEdit
        '
        Me.SenhaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Senha", True))
        Me.SenhaTextEdit.Location = New System.Drawing.Point(63, 38)
        Me.SenhaTextEdit.Name = "SenhaTextEdit"
        Me.SenhaTextEdit.Properties.MaxLength = 15
        Me.SenhaTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.SenhaTextEdit.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ServicoComboBoxEdit)
        Me.PanelControl1.Controls.Add(Label4)
        Me.PanelControl1.Controls.Add(Me.txtPorta)
        Me.PanelControl1.Controls.Add(Label2)
        Me.PanelControl1.Controls.Add(Me.ServidorTextEdit)
        Me.PanelControl1.Controls.Add(ServidorLabel)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(337, 110)
        Me.PanelControl1.TabIndex = 11
        '
        'ServicoComboBoxEdit
        '
        Me.ServicoComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Servico", True))
        Me.ServicoComboBoxEdit.Location = New System.Drawing.Point(63, 18)
        Me.ServicoComboBoxEdit.Name = "ServicoComboBoxEdit"
        Me.ServicoComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ServicoComboBoxEdit.Properties.Items.AddRange(New Object() {"Gmail", "Hotmail", "Yahoo", "LocaWeb", "Outros"})
        Me.ServicoComboBoxEdit.Size = New System.Drawing.Size(263, 20)
        Me.ServicoComboBoxEdit.TabIndex = 0
        '
        'txtPorta
        '
        Me.txtPorta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Porta", True))
        Me.txtPorta.Location = New System.Drawing.Point(63, 70)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Properties.MaxLength = 200
        Me.txtPorta.Size = New System.Drawing.Size(100, 20)
        Me.txtPorta.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.txtCopia)
        Me.PanelControl2.Controls.Add(Label5)
        Me.PanelControl2.Controls.Add(Me.EmailTextEdit)
        Me.PanelControl2.Controls.Add(EmailLabel)
        Me.PanelControl2.Controls.Add(SenhaLabel)
        Me.PanelControl2.Controls.Add(Me.SenhaTextEdit)
        Me.PanelControl2.Location = New System.Drawing.Point(8, 128)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(337, 93)
        Me.PanelControl2.TabIndex = 12
        '
        'txtCopia
        '
        Me.txtCopia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmailBindingSource, "Copia", True))
        Me.txtCopia.Location = New System.Drawing.Point(63, 64)
        Me.txtCopia.Name = "txtCopia"
        Me.txtCopia.Properties.MaxLength = 200
        Me.txtCopia.Size = New System.Drawing.Size(263, 20)
        Me.txtCopia.TabIndex = 10
        '
        'EmailTableAdapter
        '
        Me.EmailTableAdapter.ClearBeforeFill = True
        '
        'frmServidorSaida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 263)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServidorSaida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração de Conta"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServidorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenhaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ServicoComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtCopia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SenhaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ServidorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents EmailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailTableAdapter As Nano.dsNanoCommerceTableAdapters.EmailTableAdapter
    Friend WithEvents btnTestar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPorta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ServicoComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtCopia As DevExpress.XtraEditors.TextEdit
End Class
