<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesfaturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesfaturar))
        Me.lblNum = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluirVen = New DevExpress.XtraBars.BarButtonItem
        Me.btnDesfaturar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.memMotivo = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.rdgOpcao = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.txtPed = New Campos.NanoCampo
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdgOpcao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Appearance.Options.UseFont = True
        Me.lblNum.Location = New System.Drawing.Point(12, 57)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(68, 13)
        Me.lblNum.TabIndex = 1
        Me.lblNum.Text = "Nº da venda"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluirVen, Me.btnDesfaturar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluirVen, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDesfaturar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluirVen
        '
        Me.btnExcluirVen.Caption = "&Excluir"
        Me.btnExcluirVen.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluirVen.Id = 0
        Me.btnExcluirVen.Name = "btnExcluirVen"
        '
        'btnDesfaturar
        '
        Me.btnDesfaturar.Caption = "&Desfaturar"
        Me.btnDesfaturar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnDesfaturar.Id = 1
        Me.btnDesfaturar.Name = "btnDesfaturar"
        Me.btnDesfaturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'memMotivo
        '
        Me.memMotivo.EnterMoveNextControl = True
        Me.memMotivo.Location = New System.Drawing.Point(12, 116)
        Me.memMotivo.Name = "memMotivo"
        Me.memMotivo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memMotivo.Properties.MaxLength = 150
        Me.memMotivo.Size = New System.Drawing.Size(222, 51)
        Me.memMotivo.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 101)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Motivo"
        '
        'rdgOpcao
        '
        Me.rdgOpcao.EditValue = 0
        Me.rdgOpcao.Location = New System.Drawing.Point(12, 12)
        Me.rdgOpcao.Name = "rdgOpcao"
        Me.rdgOpcao.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdgOpcao.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.rdgOpcao.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Excluir Venda"), New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Desfaturar Pedido")})
        Me.rdgOpcao.Size = New System.Drawing.Size(222, 23)
        Me.rdgOpcao.TabIndex = 14
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Location = New System.Drawing.Point(5, 44)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(232, 5)
        Me.PanelControl2.TabIndex = 64
        '
        'txtPed
        '
        Me.txtPed.CasasDecimais = 0
        Me.txtPed.EnterMoveNextControl = True
        Me.txtPed.Location = New System.Drawing.Point(12, 74)
        Me.txtPed.Name = "txtPed"
        Me.txtPed.Numerico = True
        Me.txtPed.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPed.Properties.Appearance.Options.UseFont = True
        Me.txtPed.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPed.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPed.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPed.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPed.Size = New System.Drawing.Size(107, 21)
        Me.txtPed.TabIndex = 0
        '
        'frmDesfaturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 209)
        Me.Controls.Add(Me.txtPed)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.rdgOpcao)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.memMotivo)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDesfaturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excluir Venda"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdgOpcao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnExcluirVen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memMotivo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rdgOpcao As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDesfaturar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPed As Campos.NanoCampo
End Class
