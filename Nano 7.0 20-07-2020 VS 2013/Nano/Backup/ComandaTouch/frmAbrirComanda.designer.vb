<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrirComanda
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
        Me.txtComanda = New DevExpress.XtraEditors.TextEdit
        Me.txtMesa = New DevExpress.XtraEditors.TextEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbrir = New DevExpress.XtraEditors.SimpleButton
        Me.txtCliente = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComanda
        '
        Me.txtComanda.EnterMoveNextControl = True
        Me.txtComanda.Location = New System.Drawing.Point(5, 29)
        Me.txtComanda.Name = "txtComanda"
        Me.txtComanda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtComanda.Properties.Appearance.Options.UseFont = True
        Me.txtComanda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComanda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtComanda.Size = New System.Drawing.Size(200, 55)
        Me.txtComanda.TabIndex = 0
        '
        'txtMesa
        '
        Me.txtMesa.EnterMoveNextControl = True
        Me.txtMesa.Location = New System.Drawing.Point(211, 29)
        Me.txtMesa.Name = "txtMesa"
        Me.txtMesa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtMesa.Properties.Appearance.Options.UseFont = True
        Me.txtMesa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMesa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMesa.Size = New System.Drawing.Size(200, 55)
        Me.txtMesa.TabIndex = 1
        '
        'Timer1
        '
        '
        'btnAbrir
        '
        Me.btnAbrir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrir.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAbrir.Appearance.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.btnAbrir.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAbrir.Appearance.Options.UseBackColor = True
        Me.btnAbrir.Appearance.Options.UseFont = True
        Me.btnAbrir.Appearance.Options.UseForeColor = True
        Me.btnAbrir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAbrir.Location = New System.Drawing.Point(744, 10)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(259, 90)
        Me.btnAbrir.TabIndex = 3
        Me.btnAbrir.Text = "Comanda"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.EnterMoveNextControl = True
        Me.txtCliente.Location = New System.Drawing.Point(417, 29)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.txtCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 50, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.Nano.My.Resources.Resources.viewmag)})
        Me.txtCliente.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.txtCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Size = New System.Drawing.Size(321, 55)
        Me.txtCliente.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(5, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(99, 25)
        Me.LabelControl4.TabIndex = 38
        Me.LabelControl4.Text = "Comanda"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(211, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 25)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Mesa"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(417, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 25)
        Me.LabelControl6.TabIndex = 40
        Me.LabelControl6.Text = "Cliente"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.txtComanda)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtMesa)
        Me.PanelControl1.Controls.Add(Me.txtCliente)
        Me.PanelControl1.Controls.Add(Me.btnAbrir)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 108)
        Me.PanelControl1.TabIndex = 41
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.NullText = " "
        Me.PictureEdit1.Size = New System.Drawing.Size(1008, 108)
        Me.PictureEdit1.TabIndex = 41
        '
        'frmAbrirComanda
        '
        Me.Appearance.BackColor = System.Drawing.Color.LightBlue
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbrirComanda"
        Me.Text = "frmAbrirComanda"
        CType(Me.txtComanda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtComanda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMesa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAbrir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
