<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackUP))
        Me.txtLocal = New DevExpress.XtraEditors.ButtonEdit
        Me.lbl = New DevExpress.XtraEditors.LabelControl
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.sfdSalvar = New System.Windows.Forms.SaveFileDialog
        Me.btnOK2 = New DevExpress.XtraEditors.SimpleButton
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(12, 31)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, Global.Nano.My.Resources.Resources.Lupa_Azul_12x12, Nothing)})
        Me.txtLocal.Size = New System.Drawing.Size(426, 20)
        Me.txtLocal.TabIndex = 0
        '
        'lbl
        '
        Me.lbl.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Appearance.Options.UseFont = True
        Me.lbl.Location = New System.Drawing.Point(14, 13)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(155, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Local de destino do Backup "
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(257, 71)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(363, 71)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        '
        'sfdSalvar
        '
        Me.sfdSalvar.CheckPathExists = False
        '
        'btnOK2
        '
        Me.btnOK2.Location = New System.Drawing.Point(257, 71)
        Me.btnOK2.Name = "btnOK2"
        Me.btnOK2.Size = New System.Drawing.Size(75, 23)
        Me.btnOK2.TabIndex = 4
        Me.btnOK2.Text = "&OK"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmBackUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 110)
        Me.Controls.Add(Me.btnOK2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtLocal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBackUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Nano"
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocal As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdSalvar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnOK2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
End Class
