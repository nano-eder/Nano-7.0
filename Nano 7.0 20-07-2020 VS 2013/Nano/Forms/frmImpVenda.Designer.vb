<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpVenda))
        Me.rdgOrdem = New DevExpress.XtraEditors.RadioGroup
        Me.txtCodOrdem = New Campos.NanoCampo
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.rdgOrdem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodOrdem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdgOrdem
        '
        Me.rdgOrdem.EditValue = 0
        Me.rdgOrdem.Location = New System.Drawing.Point(11, 12)
        Me.rdgOrdem.Name = "rdgOrdem"
        Me.rdgOrdem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgOrdem.Properties.Appearance.Options.UseFont = True
        Me.rdgOrdem.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgOrdem.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.rdgOrdem.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Última"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Outra")})
        Me.rdgOrdem.Size = New System.Drawing.Size(185, 25)
        Me.rdgOrdem.TabIndex = 2
        Me.rdgOrdem.Tag = ""
        '
        'txtCodOrdem
        '
        Me.txtCodOrdem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodOrdem.CasasDecimais = 0
        Me.txtCodOrdem.Enabled = False
        Me.txtCodOrdem.EnterMoveNextControl = True
        Me.txtCodOrdem.Location = New System.Drawing.Point(11, 76)
        Me.txtCodOrdem.Name = "txtCodOrdem"
        Me.txtCodOrdem.Numerico = True
        Me.txtCodOrdem.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCodOrdem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodOrdem.Properties.Appearance.Options.UseFont = True
        Me.txtCodOrdem.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodOrdem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodOrdem.Size = New System.Drawing.Size(185, 29)
        Me.txtCodOrdem.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Image = Global.Nano.My.Resources.Resources.Impressora50
        Me.btnImprimir.Location = New System.Drawing.Point(9, 113)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(185, 39)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "&Imprimir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nº da Venda"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(3, 47)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(199, 5)
        Me.PanelControl2.TabIndex = 90
        '
        'frmImpVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 164)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtCodOrdem)
        Me.Controls.Add(Me.rdgOrdem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impressão de Venda"
        CType(Me.rdgOrdem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodOrdem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdgOrdem As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCodOrdem As Campos.NanoCampo
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
