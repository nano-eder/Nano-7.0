<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComandaSelecionar
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
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.btnMenos = New DevExpress.XtraEditors.SimpleButton
        Me.btnMais = New DevExpress.XtraEditors.SimpleButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFrase = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.EnterMoveNextControl = True
        Me.txtNumero.Location = New System.Drawing.Point(15, 38)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtNumero.Properties.Appearance.Options.UseFont = True
        Me.txtNumero.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumero.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumero.Size = New System.Drawing.Size(206, 55)
        Me.txtNumero.TabIndex = 52
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
        Me.btnOk.Location = New System.Drawing.Point(15, 123)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(206, 63)
        Me.btnOk.TabIndex = 53
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
        Me.btnCancelar.Location = New System.Drawing.Point(227, 123)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(196, 63)
        Me.btnCancelar.TabIndex = 54
        Me.btnCancelar.Text = "Cancelar"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit3.Location = New System.Drawing.Point(0, 111)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.NullText = " "
        Me.PictureEdit3.Size = New System.Drawing.Size(442, 87)
        Me.PictureEdit3.TabIndex = 56
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(442, 111)
        Me.PictureEdit1.TabIndex = 55
        '
        'btnMenos
        '
        Me.btnMenos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenos.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnMenos.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnMenos.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnMenos.Appearance.Options.UseBackColor = True
        Me.btnMenos.Appearance.Options.UseFont = True
        Me.btnMenos.Appearance.Options.UseForeColor = True
        Me.btnMenos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnMenos.Location = New System.Drawing.Point(227, 38)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(95, 55)
        Me.btnMenos.TabIndex = 57
        Me.btnMenos.Text = "-"
        '
        'btnMais
        '
        Me.btnMais.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMais.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnMais.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnMais.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnMais.Appearance.Options.UseBackColor = True
        Me.btnMais.Appearance.Options.UseFont = True
        Me.btnMais.Appearance.Options.UseForeColor = True
        Me.btnMais.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnMais.Location = New System.Drawing.Point(328, 38)
        Me.btnMais.Name = "btnMais"
        Me.btnMais.Size = New System.Drawing.Size(95, 55)
        Me.btnMais.TabIndex = 58
        Me.btnMais.Text = "+"
        '
        'Timer1
        '
        '
        'lblFrase
        '
        Me.lblFrase.Appearance.BackColor = System.Drawing.Color.White
        Me.lblFrase.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblFrase.Appearance.Options.UseBackColor = True
        Me.lblFrase.Appearance.Options.UseFont = True
        Me.lblFrase.Location = New System.Drawing.Point(15, 13)
        Me.lblFrase.Name = "lblFrase"
        Me.lblFrase.Size = New System.Drawing.Size(409, 19)
        Me.lblFrase.TabIndex = 59
        Me.lblFrase.Text = "Digite para qual Comanda os produtos serão transferidos."
        '
        'frmComandaSelecionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFrase)
        Me.Controls.Add(Me.btnMais)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmComandaSelecionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar Comanda"
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnMenos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMais As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblFrase As DevExpress.XtraEditors.LabelControl
End Class
