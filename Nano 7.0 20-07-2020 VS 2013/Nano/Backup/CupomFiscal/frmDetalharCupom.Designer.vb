<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalharCupom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalharCupom))
        Me.txtNCMImpProd = New Campos.NanoCampo
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtIcms = New Campos.NanoCampo
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.cboTrib2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvarTodos = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.txtNCMImpProd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIcms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrib2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNCMImpProd
        '
        Me.txtNCMImpProd.CasasDecimais = 0
        Me.txtNCMImpProd.EnterMoveNextControl = True
        Me.txtNCMImpProd.Location = New System.Drawing.Point(81, 64)
        Me.txtNCMImpProd.Name = "txtNCMImpProd"
        Me.txtNCMImpProd.Numerico = False
        Me.txtNCMImpProd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCMImpProd.Properties.MaxLength = 8
        Me.txtNCMImpProd.Size = New System.Drawing.Size(166, 20)
        Me.txtNCMImpProd.TabIndex = 120
        Me.txtNCMImpProd.Tag = "NCM Cupom Fiscal"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(53, 67)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl6.TabIndex = 121
        Me.LabelControl6.Text = "NCM"
        '
        'txtIcms
        '
        Me.txtIcms.CasasDecimais = 2
        Me.txtIcms.EnterMoveNextControl = True
        Me.txtIcms.Location = New System.Drawing.Point(81, 38)
        Me.txtIcms.Name = "txtIcms"
        Me.txtIcms.Numerico = True
        Me.txtIcms.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIcms.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIcms.Properties.AppearanceDisabled.Options.UseTextOptions = True
        Me.txtIcms.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIcms.Size = New System.Drawing.Size(166, 20)
        Me.txtIcms.TabIndex = 115
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(23, 15)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl30.TabIndex = 119
        Me.LabelControl30.Text = "Tributação"
        '
        'cboTrib2
        '
        Me.cboTrib2.EnterMoveNextControl = True
        Me.cboTrib2.Location = New System.Drawing.Point(81, 12)
        Me.cboTrib2.Name = "cboTrib2"
        Me.cboTrib2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTrib2.Properties.Items.AddRange(New Object() {"T - Produto tributado", "F - Substituição tributária", "I - Isento", "N - Não incidência"})
        Me.cboTrib2.Properties.MaxLength = 55
        Me.cboTrib2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTrib2.Size = New System.Drawing.Size(166, 20)
        Me.cboTrib2.TabIndex = 112
        Me.cboTrib2.Tag = "Grupo"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(21, 41)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl10.TabIndex = 116
        Me.LabelControl10.Text = "Alíquota %"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnSalvarTodos, Me.btnFechar})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvarTodos, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'btnSalvarTodos
        '
        Me.btnSalvarTodos.Caption = "Salvar &Todos"
        Me.btnSalvarTodos.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvarTodos.Id = 1
        Me.btnSalvarTodos.Name = "btnSalvarTodos"
        '
        'btnFechar
        '
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 2
        Me.btnFechar.Name = "btnFechar"
        '
        'frmDetalharCupom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 132)
        Me.Controls.Add(Me.txtNCMImpProd)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtIcms)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.cboTrib2)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDetalharCupom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Imposto"
        CType(Me.txtNCMImpProd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIcms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrib2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNCMImpProd As Campos.NanoCampo
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIcms As Campos.NanoCampo
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTrib2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvarTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
