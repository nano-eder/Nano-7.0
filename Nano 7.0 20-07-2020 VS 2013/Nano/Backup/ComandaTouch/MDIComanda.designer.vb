<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIComanda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIComanda))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.btnConfigComanda = New DevExpress.XtraEditors.SimpleButton
        Me.btnTeclado = New DevExpress.XtraEditors.SimpleButton
        Me.btnAbrirComanda = New DevExpress.XtraEditors.SimpleButton
        Me.btnVoltar = New DevExpress.XtraEditors.SimpleButton
        Me.btnComandaPrincipal = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lblHora = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton
        Me.btnReabrirComanda = New DevExpress.XtraEditors.SimpleButton
        Me.btnVender = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 557)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(1008, 105)
        Me.PictureEdit1.TabIndex = 3
        '
        'btnConfigComanda
        '
        Me.btnConfigComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigComanda.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnConfigComanda.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnConfigComanda.Appearance.Options.UseBackColor = True
        Me.btnConfigComanda.Appearance.Options.UseBorderColor = True
        Me.btnConfigComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnConfigComanda.Image = Global.Nano.My.Resources.Resources.blockdevice50
        Me.btnConfigComanda.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConfigComanda.Location = New System.Drawing.Point(820, 558)
        Me.btnConfigComanda.Name = "btnConfigComanda"
        Me.btnConfigComanda.Size = New System.Drawing.Size(85, 80)
        Me.btnConfigComanda.TabIndex = 18
        '
        'btnTeclado
        '
        Me.btnTeclado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeclado.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTeclado.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnTeclado.Appearance.Options.UseBackColor = True
        Me.btnTeclado.Appearance.Options.UseBorderColor = True
        Me.btnTeclado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnTeclado.Image = Global.Nano.My.Resources.Resources.diagram
        Me.btnTeclado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnTeclado.Location = New System.Drawing.Point(729, 558)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(85, 80)
        Me.btnTeclado.TabIndex = 16
        '
        'btnAbrirComanda
        '
        Me.btnAbrirComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirComanda.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAbrirComanda.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnAbrirComanda.Appearance.Options.UseBackColor = True
        Me.btnAbrirComanda.Appearance.Options.UseBorderColor = True
        Me.btnAbrirComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAbrirComanda.Image = Global.Nano.My.Resources.Resources.playlist50
        Me.btnAbrirComanda.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAbrirComanda.Location = New System.Drawing.Point(3, 558)
        Me.btnAbrirComanda.Name = "btnAbrirComanda"
        Me.btnAbrirComanda.Size = New System.Drawing.Size(85, 80)
        Me.btnAbrirComanda.TabIndex = 14
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVoltar.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnVoltar.Appearance.Options.UseBackColor = True
        Me.btnVoltar.Appearance.Options.UseBorderColor = True
        Me.btnVoltar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnVoltar.Image = Global.Nano.My.Resources.Resources.Back
        Me.btnVoltar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVoltar.Location = New System.Drawing.Point(185, 558)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(85, 80)
        Me.btnVoltar.TabIndex = 12
        '
        'btnComandaPrincipal
        '
        Me.btnComandaPrincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComandaPrincipal.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnComandaPrincipal.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnComandaPrincipal.Appearance.Options.UseBackColor = True
        Me.btnComandaPrincipal.Appearance.Options.UseBorderColor = True
        Me.btnComandaPrincipal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnComandaPrincipal.Image = Global.Nano.My.Resources.Resources.Cadastross
        Me.btnComandaPrincipal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnComandaPrincipal.Location = New System.Drawing.Point(94, 558)
        Me.btnComandaPrincipal.Name = "btnComandaPrincipal"
        Me.btnComandaPrincipal.Size = New System.Drawing.Size(85, 80)
        Me.btnComandaPrincipal.TabIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = Global.Nano.My.Resources.Resources.act_delete
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(911, 558)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(85, 80)
        Me.SimpleButton1.TabIndex = 9
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblHora.Appearance.Options.UseFont = True
        Me.lblHora.Appearance.Options.UseForeColor = True
        Me.lblHora.Location = New System.Drawing.Point(881, 641)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(115, 16)
        Me.lblHora.TabIndex = 22
        Me.lblHora.Text = "25/03/2020 20:00:00"
        '
        'Timer1
        '
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnConsultar.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnConsultar.Appearance.Options.UseBackColor = True
        Me.btnConsultar.Appearance.Options.UseBorderColor = True
        Me.btnConsultar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnConsultar.Image = Global.Nano.My.Resources.Resources.playlist50
        Me.btnConsultar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConsultar.Location = New System.Drawing.Point(490, 558)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(85, 80)
        Me.btnConsultar.TabIndex = 24
        '
        'btnReabrirComanda
        '
        Me.btnReabrirComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReabrirComanda.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnReabrirComanda.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnReabrirComanda.Appearance.Options.UseBackColor = True
        Me.btnReabrirComanda.Appearance.Options.UseBorderColor = True
        Me.btnReabrirComanda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnReabrirComanda.Image = Global.Nano.My.Resources.Resources.playlist50
        Me.btnReabrirComanda.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnReabrirComanda.Location = New System.Drawing.Point(581, 558)
        Me.btnReabrirComanda.Name = "btnReabrirComanda"
        Me.btnReabrirComanda.Size = New System.Drawing.Size(85, 80)
        Me.btnReabrirComanda.TabIndex = 26
        '
        'btnVender
        '
        Me.btnVender.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVender.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVender.Appearance.BorderColor = System.Drawing.Color.Black
        Me.btnVender.Appearance.Options.UseBackColor = True
        Me.btnVender.Appearance.Options.UseBorderColor = True
        Me.btnVender.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnVender.Image = Global.Nano.My.Resources.Resources.playlist50
        Me.btnVender.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnVender.Location = New System.Drawing.Point(672, 558)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(85, 80)
        Me.btnVender.TabIndex = 28
        '
        'MDIComanda
        '
        Me.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseTextOptions = True
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.btnReabrirComanda)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.btnConfigComanda)
        Me.Controls.Add(Me.btnTeclado)
        Me.Controls.Add(Me.btnAbrirComanda)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnComandaPrincipal)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIComanda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comandas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnComandaPrincipal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVoltar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAbrirComanda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfigComanda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblHora As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReabrirComanda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVender As DevExpress.XtraEditors.SimpleButton
End Class
