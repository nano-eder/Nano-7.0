<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTamanhoProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTamanhoProd))
        Me.lueTamanho = New DevExpress.XtraEditors.LookUpEdit
        Me.QtdeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.lblTamanho = New DevExpress.XtraEditors.LabelControl
        Me.lblSelecao = New DevExpress.XtraEditors.LabelControl
        Me.QtdeTableAdapter = New Nano.dsNanoCommerceTableAdapters.QtdeTableAdapter
        Me.cboQtd = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.lueTamanho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtdeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboQtd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lueTamanho
        '
        Me.lueTamanho.EnterMoveNextControl = True
        Me.lueTamanho.Location = New System.Drawing.Point(12, 32)
        Me.lueTamanho.Name = "lueTamanho"
        Me.lueTamanho.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueTamanho.Properties.Appearance.Options.UseFont = True
        Me.lueTamanho.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueTamanho.Properties.AppearanceDropDown.Options.UseFont = True
        Me.lueTamanho.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTamanho.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tamanho", "Tamanho", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qtd", "Qtde", 24, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueTamanho.Properties.DataSource = Me.QtdeBindingSource
        Me.lueTamanho.Properties.DisplayMember = "Tamanho"
        Me.lueTamanho.Properties.NullText = ""
        Me.lueTamanho.Properties.ValueMember = "Tamanho"
        Me.lueTamanho.Size = New System.Drawing.Size(280, 35)
        Me.lueTamanho.TabIndex = 0
        '
        'QtdeBindingSource
        '
        Me.QtdeBindingSource.DataMember = "Qtde"
        Me.QtdeBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTamanho
        '
        Me.lblTamanho.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamanho.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblTamanho.Appearance.Options.UseFont = True
        Me.lblTamanho.Appearance.Options.UseForeColor = True
        Me.lblTamanho.Location = New System.Drawing.Point(12, 10)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(84, 19)
        Me.lblTamanho.TabIndex = 1
        Me.lblTamanho.Text = "Tamanhos"
        '
        'lblSelecao
        '
        Me.lblSelecao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecao.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.lblSelecao.Appearance.Options.UseFont = True
        Me.lblSelecao.Appearance.Options.UseForeColor = True
        Me.lblSelecao.Location = New System.Drawing.Point(14, 70)
        Me.lblSelecao.Name = "lblSelecao"
        Me.lblSelecao.Size = New System.Drawing.Size(200, 13)
        Me.lblSelecao.TabIndex = 2
        Me.lblSelecao.Text = "Selecione o tamanho e pressione 'ENTER'."
        '
        'QtdeTableAdapter
        '
        Me.QtdeTableAdapter.ClearBeforeFill = True
        '
        'cboQtd
        '
        Me.cboQtd.EnterMoveNextControl = True
        Me.cboQtd.Location = New System.Drawing.Point(12, 32)
        Me.cboQtd.Name = "cboQtd"
        Me.cboQtd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.cboQtd.Properties.Appearance.Options.UseFont = True
        Me.cboQtd.Properties.Appearance.Options.UseTextOptions = True
        Me.cboQtd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cboQtd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboQtd.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboQtd.Size = New System.Drawing.Size(330, 35)
        Me.cboQtd.TabIndex = 3
        Me.cboQtd.Visible = False
        '
        'frmTamanhoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 91)
        Me.Controls.Add(Me.cboQtd)
        Me.Controls.Add(Me.lblSelecao)
        Me.Controls.Add(Me.lblTamanho)
        Me.Controls.Add(Me.lueTamanho)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTamanhoProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecione o Tamanho do Produto"
        CType(Me.lueTamanho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtdeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboQtd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lueTamanho As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTamanho As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSelecao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents QtdeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QtdeTableAdapter As Nano.dsNanoCommerceTableAdapters.QtdeTableAdapter
    Friend WithEvents cboQtd As DevExpress.XtraEditors.ComboBoxEdit
End Class
