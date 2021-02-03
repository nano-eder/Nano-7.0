<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModEtiqueta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModEtiqueta))
        Me.cboEti = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.cboEti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEti
        '
        Me.cboEti.EnterMoveNextControl = True
        Me.cboEti.Location = New System.Drawing.Point(12, 31)
        Me.cboEti.Name = "cboEti"
        Me.cboEti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEti.Properties.Appearance.Options.UseFont = True
        Me.cboEti.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboEti.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboEti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEti.Properties.Items.AddRange(New Object() {"", "DUPLA GRANDE", "DUPLA MÉDIA", "DUPLA MÉDIA ARGOX", "TRIPLA PEQUENA", "TRIPLA MINI", "TRIPLA MÉDIA ARGOX", "ETIQUETA CAIXA", "GÔNDOLA", "PIMACO A4348", "PIMACO A4360", "PIMACO A5Q1219", "LB 1000 DUPLA", "LB 1000 TRIPLA", "LB 1000 PEQUENA", "LB 1000 GÔNDOLA", "PROMOÇÃO", "ZT 230 DUPLA"})
        Me.cboEti.Properties.MaxLength = 55
        Me.cboEti.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboEti.Size = New System.Drawing.Size(279, 32)
        Me.cboEti.TabIndex = 128
        Me.cboEti.Tag = "Grupo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Selecione o modelo e pressione 'Enter'"
        '
        'frmModEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 74)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleção de Etiqueta"
        CType(Me.cboEti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEti As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
