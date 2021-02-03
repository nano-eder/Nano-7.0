<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixarXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixarXML))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCaptcha = New DevExpress.XtraEditors.TextEdit
        Me.txtChave = New DevExpress.XtraEditors.TextEdit
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.picCaptcha = New DevExpress.XtraEditors.PictureEdit
        Me.btnAlterar = New DevExpress.XtraEditors.SimpleButton
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCaptcha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCaptcha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtCaptcha)
        Me.PanelControl1.Controls.Add(Me.txtChave)
        Me.PanelControl1.Controls.Add(Me.btnOk)
        Me.PanelControl1.Controls.Add(Me.picCaptcha)
        Me.PanelControl1.Controls.Add(Me.btnAlterar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(617, 208)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(346, 183)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(259, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "O Arquivo XML deve ser salvo em C:\NANOXML"
        Me.LabelControl3.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(419, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Caracteres da imagem"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Digite a chave da NF-e"
        '
        'txtCaptcha
        '
        Me.txtCaptcha.EditValue = ""
        Me.txtCaptcha.Location = New System.Drawing.Point(419, 88)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaptcha.Properties.Appearance.Options.UseFont = True
        Me.txtCaptcha.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCaptcha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCaptcha.Properties.MaxLength = 6
        Me.txtCaptcha.Size = New System.Drawing.Size(186, 32)
        Me.txtCaptcha.TabIndex = 1
        '
        'txtChave
        '
        Me.txtChave.EditValue = ""
        Me.txtChave.Location = New System.Drawing.Point(12, 31)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChave.Properties.Appearance.Options.UseFont = True
        Me.txtChave.Properties.Appearance.Options.UseTextOptions = True
        Me.txtChave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtChave.Properties.MaxLength = 44
        Me.txtChave.Size = New System.Drawing.Size(593, 32)
        Me.txtChave.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Appearance.BackColor = System.Drawing.Color.LightGreen
        Me.btnOk.Appearance.BackColor2 = System.Drawing.Color.LimeGreen
        Me.btnOk.Appearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOk.Appearance.Options.UseBackColor = True
        Me.btnOk.Appearance.Options.UseBorderColor = True
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Appearance.Options.UseForeColor = True
        Me.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnOk.Image = Global.Nano.My.Resources.Resources.viewmag
        Me.btnOk.Location = New System.Drawing.Point(419, 126)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(186, 48)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Verificar"
        '
        'picCaptcha
        '
        Me.picCaptcha.EditValue = Global.Nano.My.Resources.Resources.NFe_Carregando
        Me.picCaptcha.Location = New System.Drawing.Point(12, 69)
        Me.picCaptcha.Name = "picCaptcha"
        Me.picCaptcha.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picCaptcha.Size = New System.Drawing.Size(156, 76)
        Me.picCaptcha.TabIndex = 4
        '
        'btnAlterar
        '
        Me.btnAlterar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnAlterar.Image = Global.Nano.My.Resources.Resources.Alterar_18x18
        Me.btnAlterar.Location = New System.Drawing.Point(12, 151)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(156, 23)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar Imagem F5"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(617, 208)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'frmBaixarXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 208)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBaixarXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixar Nota Fiscal Eletrônica"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCaptcha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCaptcha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtChave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picCaptcha As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnAlterar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtCaptcha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
