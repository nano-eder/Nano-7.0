<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteTouch
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCPF = New Campos.NanoCampo
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtNome = New Campos.NanoCampo
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtTelefone = New Campos.NanoCampo
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtEmail = New Campos.NanoCampo
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnSalvar = New DevExpress.XtraEditors.SimpleButton
        Me.btnLimpar = New DevExpress.XtraEditors.SimpleButton
        Me.lblMensagem = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTouch = New DevExpress.XtraEditors.SimpleButton
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.picImagem = New System.Windows.Forms.PictureBox
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 103)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 35)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "CPF"
        '
        'txtCPF
        '
        Me.txtCPF.CasasDecimais = 0
        Me.txtCPF.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(28, 144)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Numerico = False
        Me.txtCPF.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCPF.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtCPF.Properties.Appearance.Options.UseBackColor = True
        Me.txtCPF.Properties.Appearance.Options.UseFont = True
        Me.txtCPF.Properties.Appearance.Options.UseForeColor = True
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCPF.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtCPF.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPF.Size = New System.Drawing.Size(440, 44)
        Me.txtCPF.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(28, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 35)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.CasasDecimais = 0
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNome.EnterMoveNextControl = True
        Me.txtNome.Location = New System.Drawing.Point(28, 54)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Numerico = False
        Me.txtNome.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtNome.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNome.Properties.Appearance.Options.UseBackColor = True
        Me.txtNome.Properties.Appearance.Options.UseFont = True
        Me.txtNome.Properties.Appearance.Options.UseForeColor = True
        Me.txtNome.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNome.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Size = New System.Drawing.Size(955, 44)
        Me.txtNome.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(541, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(126, 35)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone.CasasDecimais = 0
        Me.txtTelefone.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTelefone.EnterMoveNextControl = True
        Me.txtTelefone.Location = New System.Drawing.Point(541, 144)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Numerico = False
        Me.txtTelefone.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTelefone.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTelefone.Properties.Appearance.Options.UseBackColor = True
        Me.txtTelefone.Properties.Appearance.Options.UseFont = True
        Me.txtTelefone.Properties.Appearance.Options.UseForeColor = True
        Me.txtTelefone.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTelefone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTelefone.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefone.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtTelefone.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTelefone.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtTelefone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtTelefone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone.Size = New System.Drawing.Size(442, 44)
        Me.txtTelefone.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(28, 192)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(94, 35)
        Me.LabelControl4.TabIndex = 21
        Me.LabelControl4.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.CasasDecimais = 0
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(28, 233)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Numerico = False
        Me.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.Appearance.Options.UseForeColor = True
        Me.txtEmail.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEmail.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtEmail.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Size = New System.Drawing.Size(955, 44)
        Me.txtEmail.TabIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.Appearance.Options.UseFont = True
        Me.btnSalvar.Appearance.Options.UseTextOptions = True
        Me.btnSalvar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.btnSalvar.Image = Global.Nano.My.Resources.Resources.apply50
        Me.btnSalvar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(752, 283)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(73, 73)
        Me.btnSalvar.TabIndex = 22
        Me.btnSalvar.Text = "Salvar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.Appearance.Options.UseFont = True
        Me.btnLimpar.Image = Global.Nano.My.Resources.Resources.cancel
        Me.btnLimpar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnLimpar.Location = New System.Drawing.Point(831, 283)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(73, 73)
        Me.btnLimpar.TabIndex = 23
        Me.btnLimpar.Text = "Cancelar"
        '
        'lblMensagem
        '
        Me.lblMensagem.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensagem.Appearance.Options.UseFont = True
        Me.lblMensagem.Appearance.Options.UseForeColor = True
        Me.lblMensagem.Location = New System.Drawing.Point(28, 294)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(0, 35)
        Me.lblMensagem.TabIndex = 24
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnTouch
        '
        Me.btnTouch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTouch.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnTouch.Appearance.Options.UseFont = True
        Me.btnTouch.Image = Global.Nano.My.Resources.Resources.diagram
        Me.btnTouch.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnTouch.Location = New System.Drawing.Point(910, 283)
        Me.btnTouch.Name = "btnTouch"
        Me.btnTouch.Size = New System.Drawing.Size(73, 73)
        Me.btnTouch.TabIndex = 25
        Me.btnTouch.Text = "Teclado"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(781, 531)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(100, 50)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagem.TabIndex = 29
        Me.picImagem.TabStop = False
        Me.picImagem.Visible = False
        '
        'Timer4
        '
        '
        'frmClienteTouch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.btnTouch)
        Me.Controls.Add(Me.lblMensagem)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClienteTouch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastr de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCPF As Campos.NanoCampo
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNome As Campos.NanoCampo
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefone As Campos.NanoCampo
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As Campos.NanoCampo
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalvar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMensagem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLimpar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnTouch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents picImagem As System.Windows.Forms.PictureBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
