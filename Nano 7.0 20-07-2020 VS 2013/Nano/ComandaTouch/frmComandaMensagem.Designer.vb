<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComandaMensagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComandaMensagem))
        Me.btnSim = New DevExpress.XtraEditors.SimpleButton
        Me.btnNao = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.lblMensagem = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.lblMensagem2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSim
        '
        Me.btnSim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSim.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSim.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnSim.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnSim.Appearance.Options.UseBackColor = True
        Me.btnSim.Appearance.Options.UseFont = True
        Me.btnSim.Appearance.Options.UseForeColor = True
        Me.btnSim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSim.Location = New System.Drawing.Point(241, 107)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.Size = New System.Drawing.Size(192, 63)
        Me.btnSim.TabIndex = 45
        Me.btnSim.Text = "Sim"
        '
        'btnNao
        '
        Me.btnNao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNao.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNao.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnNao.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnNao.Appearance.Options.UseBackColor = True
        Me.btnNao.Appearance.Options.UseFont = True
        Me.btnNao.Appearance.Options.UseForeColor = True
        Me.btnNao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnNao.Location = New System.Drawing.Point(439, 107)
        Me.btnNao.Name = "btnNao"
        Me.btnNao.Size = New System.Drawing.Size(192, 63)
        Me.btnNao.TabIndex = 44
        Me.btnNao.Text = "Não"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(643, 96)
        Me.PictureEdit1.TabIndex = 46
        '
        'lblMensagem
        '
        Me.lblMensagem.Appearance.BackColor = System.Drawing.Color.White
        Me.lblMensagem.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.lblMensagem.Appearance.Options.UseBackColor = True
        Me.lblMensagem.Appearance.Options.UseFont = True
        Me.lblMensagem.Location = New System.Drawing.Point(106, 31)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(427, 29)
        Me.lblMensagem.TabIndex = 47
        Me.lblMensagem.Text = "Deseja realmente reabrir a Comanda 3?"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.Nano.My.Resources.Resources.Help
        Me.PictureEdit2.Location = New System.Drawing.Point(18, 17)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.AllowFocused = False
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(59, 59)
        Me.PictureEdit2.TabIndex = 48
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit3.Location = New System.Drawing.Point(0, 96)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.NullText = " "
        Me.PictureEdit3.Size = New System.Drawing.Size(643, 86)
        Me.PictureEdit3.TabIndex = 49
        '
        'lblMensagem2
        '
        Me.lblMensagem2.Appearance.BackColor = System.Drawing.Color.White
        Me.lblMensagem2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.lblMensagem2.Appearance.Options.UseBackColor = True
        Me.lblMensagem2.Appearance.Options.UseFont = True
        Me.lblMensagem2.Location = New System.Drawing.Point(107, 59)
        Me.lblMensagem2.Name = "lblMensagem2"
        Me.lblMensagem2.Size = New System.Drawing.Size(427, 29)
        Me.lblMensagem2.TabIndex = 50
        Me.lblMensagem2.Text = "Deseja realmente reabrir a Comanda 3?"
        Me.lblMensagem2.Visible = False
        '
        'frmComandaMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMensagem2)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.lblMensagem)
        Me.Controls.Add(Me.btnSim)
        Me.Controls.Add(Me.btnNao)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComandaMensagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nano Comanda"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSim As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblMensagem As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblMensagem2 As DevExpress.XtraEditors.LabelControl
End Class
