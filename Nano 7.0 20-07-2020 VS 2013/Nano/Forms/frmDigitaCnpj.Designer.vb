<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitaCnpj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDigitaCnpj))
        Me.rdgDoc = New DevExpress.XtraEditors.RadioGroup
        Me.txtCPF = New Campos.NanoCampo
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.lblEmp = New DevExpress.XtraEditors.LabelControl
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdgDoc
        '
        Me.rdgDoc.Location = New System.Drawing.Point(14, 53)
        Me.rdgDoc.Name = "rdgDoc"
        Me.rdgDoc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDoc.Properties.Appearance.Options.UseFont = True
        Me.rdgDoc.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CPF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "CNPJ")})
        Me.rdgDoc.Size = New System.Drawing.Size(101, 20)
        Me.rdgDoc.TabIndex = 0
        '
        'txtCPF
        '
        Me.txtCPF.CasasDecimais = 0
        Me.txtCPF.EnterMoveNextControl = True
        Me.txtCPF.Location = New System.Drawing.Point(121, 53)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Numerico = False
        Me.txtCPF.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCPF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCPF.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCPF.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCPF.Properties.MaxLength = 20
        Me.txtCPF.Size = New System.Drawing.Size(193, 20)
        Me.txtCPF.TabIndex = 1
        Me.txtCPF.Tag = "CPF/CNPJ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(261, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Digite o CPF para Pessoa Física ou CNPJ para Empresa"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(5, 79)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(315, 5)
        Me.PanelControl1.TabIndex = 39
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(139, 94)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(235, 94)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        '
        'lblEmp
        '
        Me.lblEmp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp.Appearance.Options.UseFont = True
        Me.lblEmp.Location = New System.Drawing.Point(14, 32)
        Me.lblEmp.Name = "lblEmp"
        Me.lblEmp.Size = New System.Drawing.Size(0, 13)
        Me.lblEmp.TabIndex = 40
        '
        'frmDigitaCnpj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 128)
        Me.Controls.Add(Me.lblEmp)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.rdgDoc)
        Me.Controls.Add(Me.txtCPF)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDigitaCnpj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificação Nano"
        CType(Me.rdgDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCPF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents rdgDoc As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCPF As Campos.NanoCampo
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblEmp As DevExpress.XtraEditors.LabelControl
End Class
