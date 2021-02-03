<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterarQtde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlterarQtde))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtLoja = New Campos.NanoCampo
        Me.txtQtde = New Campos.NanoCampo
        Me.txtQtdNova = New Campos.NanoCampo
        Me.txtProduto = New Campos.NanoCampo
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCodInterno = New Campos.NanoCampo
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdNova.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodInterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 0
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 1
        Me.btnFechar.Name = "btnFechar"
        '
        'txtLoja
        '
        Me.txtLoja.CasasDecimais = 0
        Me.txtLoja.EnterMoveNextControl = True
        Me.txtLoja.Location = New System.Drawing.Point(27, 115)
        Me.txtLoja.Name = "txtLoja"
        Me.txtLoja.Numerico = True
        Me.txtLoja.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtLoja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtLoja.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtLoja.Properties.Appearance.Options.UseBackColor = True
        Me.txtLoja.Properties.Appearance.Options.UseFont = True
        Me.txtLoja.Properties.Appearance.Options.UseForeColor = True
        Me.txtLoja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLoja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLoja.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtLoja.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtLoja.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtLoja.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtLoja.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLoja.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtLoja.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtLoja.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtLoja.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtLoja.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLoja.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtLoja.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtLoja.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtLoja.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLoja.Properties.MaxLength = 14
        Me.txtLoja.Properties.ReadOnly = True
        Me.txtLoja.Size = New System.Drawing.Size(182, 35)
        Me.txtLoja.TabIndex = 2
        Me.txtLoja.Tag = "Qtd Mínima"
        '
        'txtQtde
        '
        Me.txtQtde.CasasDecimais = 0
        Me.txtQtde.EnterMoveNextControl = True
        Me.txtQtde.Location = New System.Drawing.Point(236, 115)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Numerico = True
        Me.txtQtde.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtQtde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtQtde.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtde.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtde.Properties.Appearance.Options.UseFont = True
        Me.txtQtde.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtde.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtde.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtde.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtQtde.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtQtde.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtQtde.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtQtde.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtde.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtde.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtQtde.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtQtde.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtQtde.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtde.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtQtde.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtde.Properties.MaxLength = 14
        Me.txtQtde.Properties.ReadOnly = True
        Me.txtQtde.Size = New System.Drawing.Size(182, 35)
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.Tag = "Qtd"
        '
        'txtQtdNova
        '
        Me.txtQtdNova.CasasDecimais = 0
        Me.txtQtdNova.EnterMoveNextControl = True
        Me.txtQtdNova.Location = New System.Drawing.Point(443, 115)
        Me.txtQtdNova.Name = "txtQtdNova"
        Me.txtQtdNova.Numerico = True
        Me.txtQtdNova.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtQtdNova.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtQtdNova.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtQtdNova.Properties.Appearance.Options.UseBackColor = True
        Me.txtQtdNova.Properties.Appearance.Options.UseFont = True
        Me.txtQtdNova.Properties.Appearance.Options.UseForeColor = True
        Me.txtQtdNova.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQtdNova.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQtdNova.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtQtdNova.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtQtdNova.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtQtdNova.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtQtdNova.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtdNova.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtQtdNova.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtQtdNova.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtQtdNova.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtQtdNova.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtQtdNova.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtQtdNova.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtQtdNova.Properties.MaxLength = 14
        Me.txtQtdNova.Size = New System.Drawing.Size(182, 35)
        Me.txtQtdNova.TabIndex = 4
        Me.txtQtdNova.Tag = "Qtd Mínima"
        '
        'txtProduto
        '
        Me.txtProduto.CasasDecimais = 0
        Me.txtProduto.EnterMoveNextControl = True
        Me.txtProduto.Location = New System.Drawing.Point(236, 34)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Numerico = False
        Me.txtProduto.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtProduto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtProduto.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtProduto.Properties.Appearance.Options.UseBackColor = True
        Me.txtProduto.Properties.Appearance.Options.UseFont = True
        Me.txtProduto.Properties.Appearance.Options.UseForeColor = True
        Me.txtProduto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtProduto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtProduto.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtProduto.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProduto.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtProduto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtProduto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtProduto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtProduto.Properties.MaxLength = 14
        Me.txtProduto.Properties.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(389, 35)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.Tag = "Qtd Mínima"
        '
        'Timer1
        '
        '
        'txtCodInterno
        '
        Me.txtCodInterno.CasasDecimais = 0
        Me.txtCodInterno.EnterMoveNextControl = True
        Me.txtCodInterno.Location = New System.Drawing.Point(27, 34)
        Me.txtCodInterno.Name = "txtCodInterno"
        Me.txtCodInterno.Numerico = False
        Me.txtCodInterno.Properties.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCodInterno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtCodInterno.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtCodInterno.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodInterno.Properties.Appearance.Options.UseFont = True
        Me.txtCodInterno.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodInterno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCodInterno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodInterno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodInterno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodInterno.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodInterno.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCodInterno.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCodInterno.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtCodInterno.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtCodInterno.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodInterno.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodInterno.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodInterno.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtCodInterno.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodInterno.Properties.MaxLength = 14
        Me.txtCodInterno.Properties.ReadOnly = True
        Me.txtCodInterno.Size = New System.Drawing.Size(182, 35)
        Me.txtCodInterno.TabIndex = 0
        Me.txtCodInterno.Tag = "Qtd Mínima"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(27, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 29)
        Me.LabelControl6.TabIndex = 119
        Me.LabelControl6.Text = "Código"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(236, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(96, 29)
        Me.LabelControl4.TabIndex = 120
        Me.LabelControl4.Text = "Produto"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(236, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 29)
        Me.LabelControl5.TabIndex = 121
        Me.LabelControl5.Text = "Qtde"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(443, 82)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(126, 29)
        Me.LabelControl7.TabIndex = 122
        Me.LabelControl7.Text = "Qtde Nova"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(27, 82)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(52, 29)
        Me.LabelControl9.TabIndex = 123
        Me.LabelControl9.Text = "Loja"
        '
        'frmAlterarQtde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 202)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtCodInterno)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtQtdNova)
        Me.Controls.Add(Me.txtLoja)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAlterarQtde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Qtde"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdNova.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProduto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodInterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtProduto As Campos.NanoCampo
    Friend WithEvents txtQtdNova As Campos.NanoCampo
    Friend WithEvents txtLoja As Campos.NanoCampo
    Friend WithEvents txtQtde As Campos.NanoCampo
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtCodInterno As Campos.NanoCampo
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
