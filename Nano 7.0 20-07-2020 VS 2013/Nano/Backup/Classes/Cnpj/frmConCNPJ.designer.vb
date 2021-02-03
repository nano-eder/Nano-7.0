<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConCNPJ
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
        Me.picLetras = New System.Windows.Forms.PictureBox
        Me.txtLetras = New DevExpress.XtraEditors.TextEdit
        Me.btnAlterar = New DevExpress.XtraEditors.SimpleButton
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.wb1 = New System.Windows.Forms.WebBrowser
        Me.wb2 = New System.Windows.Forms.WebBrowser
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.picLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLetras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLetras
        '
        Me.picLetras.Location = New System.Drawing.Point(6, 7)
        Me.picLetras.Name = "picLetras"
        Me.picLetras.Size = New System.Drawing.Size(156, 61)
        Me.picLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLetras.TabIndex = 0
        Me.picLetras.TabStop = False
        Me.picLetras.Visible = False
        '
        'txtLetras
        '
        Me.txtLetras.EnterMoveNextControl = True
        Me.txtLetras.Location = New System.Drawing.Point(6, 74)
        Me.txtLetras.Name = "txtLetras"
        Me.txtLetras.Size = New System.Drawing.Size(156, 20)
        Me.txtLetras.TabIndex = 61
        Me.txtLetras.Tag = ""
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = Global.Nano.My.Resources.Resources.Alterar_18x18
        Me.btnAlterar.Location = New System.Drawing.Point(6, 106)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 62
        Me.btnAlterar.Text = "&Alterar"
        '
        'btnOk
        '
        Me.btnOk.Image = Global.Nano.My.Resources.Resources.apply18x18
        Me.btnOk.Location = New System.Drawing.Point(87, 106)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 63
        Me.btnOk.Text = "&OK"
        '
        'wb1
        '
        Me.wb1.Location = New System.Drawing.Point(6, 7)
        Me.wb1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb1.Name = "wb1"
        Me.wb1.ScrollBarsEnabled = False
        Me.wb1.Size = New System.Drawing.Size(156, 61)
        Me.wb1.TabIndex = 64
        Me.wb1.Visible = False
        '
        'wb2
        '
        Me.wb2.Location = New System.Drawing.Point(50, 12)
        Me.wb2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb2.Name = "wb2"
        Me.wb2.Size = New System.Drawing.Size(20, 20)
        Me.wb2.TabIndex = 65
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(6, 7)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(156, 61)
        Me.PictureEdit1.TabIndex = 66
        Me.PictureEdit1.Visible = False
        '
        'frmConCNPJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 134)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.txtLetras)
        Me.Controls.Add(Me.wb1)
        Me.Controls.Add(Me.wb2)
        Me.Controls.Add(Me.picLetras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConCNPJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLetras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLetras As System.Windows.Forms.PictureBox
    Friend WithEvents txtLetras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAlterar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents wb1 As System.Windows.Forms.WebBrowser
    Friend WithEvents wb2 As System.Windows.Forms.WebBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
