<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbertura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbertura))
        Me.txtValRec = New Campos.NanoCampo
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.PagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnOk = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.PagamentoTableAdapter = New Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
        CType(Me.txtValRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValRec
        '
        Me.txtValRec.CasasDecimais = 2
        Me.txtValRec.EnterMoveNextControl = True
        Me.txtValRec.Location = New System.Drawing.Point(29, 30)
        Me.txtValRec.Name = "txtValRec"
        Me.txtValRec.Numerico = True
        Me.txtValRec.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtValRec.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValRec.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtValRec.Properties.Appearance.Options.UseBackColor = True
        Me.txtValRec.Properties.Appearance.Options.UseFont = True
        Me.txtValRec.Properties.Appearance.Options.UseForeColor = True
        Me.txtValRec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValRec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValRec.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValRec.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValRec.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtValRec.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtValRec.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtValRec.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtValRec.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txtValRec.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValRec.Size = New System.Drawing.Size(251, 28)
        Me.txtValRec.TabIndex = 130
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(28, 15)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(52, 14)
        Me.LabelControl13.TabIndex = 132
        Me.LabelControl13.Text = "Valor R$"
        '
        'PagamentoBindingSource
        '
        Me.PagamentoBindingSource.DataMember = "Pagamento"
        Me.PagamentoBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnOk, Me.btnCancelar})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnOk
        '
        Me.btnOk.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnOk.Caption = "OK"
        Me.btnOk.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnOk.Id = 0
        Me.btnOk.Name = "btnOk"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "Cancelar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnCancelar.Id = 1
        Me.btnCancelar.Name = "btnCancelar"
        '
        'PagamentoTableAdapter
        '
        Me.PagamentoTableAdapter.ClearBeforeFill = True
        '
        'frmAbertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 110)
        Me.Controls.Add(Me.txtValRec)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abertura do Dia"
        CType(Me.txtValRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValRec As Campos.NanoCampo
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnOk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents PagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoTableAdapter As Nano.dsNanoCommerceTableAdapters.PagamentoTableAdapter
End Class
