<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComandaExcluir
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
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.txtSenha = New DevExpress.XtraEditors.TextEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit3.Location = New System.Drawing.Point(0, 96)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.NullText = " "
        Me.PictureEdit3.Size = New System.Drawing.Size(414, 86)
        Me.PictureEdit3.TabIndex = 51
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(414, 96)
        Me.PictureEdit1.TabIndex = 50
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnOk.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnOk.Appearance.Options.UseBackColor = True
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Appearance.Options.UseForeColor = True
        Me.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnOk.Location = New System.Drawing.Point(12, 107)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(192, 63)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnCancelar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Appearance.Options.UseBackColor = True
        Me.btnCancelar.Appearance.Options.UseFont = True
        Me.btnCancelar.Appearance.Options.UseForeColor = True
        Me.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnCancelar.Location = New System.Drawing.Point(210, 107)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(192, 63)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSenha.EnterMoveNextControl = True
        Me.txtSenha.Location = New System.Drawing.Point(12, 22)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtSenha.Properties.Appearance.Options.UseFont = True
        Me.txtSenha.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(390, 55)
        Me.txtSenha.TabIndex = 0
        '
        'Timer1
        '
        '
        'frmComandaExcluir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmComandaExcluir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificação de Senha"
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSenha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSenha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
