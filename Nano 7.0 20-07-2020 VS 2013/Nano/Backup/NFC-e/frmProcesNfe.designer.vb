<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesNfe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesNfe))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.marquee = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lstValidando = New DevExpress.XtraEditors.ListBoxControl
        Me.lstErro = New DevExpress.XtraEditors.ListBoxControl
        Me.btnInicio = New DevExpress.XtraEditors.SimpleButton
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnVerificar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.pb = New System.Windows.Forms.ProgressBar
        CType(Me.marquee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstValidando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(395, 24)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Aguarde enquanto a nota é processada"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'marquee
        '
        Me.marquee.EditValue = "15"
        Me.marquee.Location = New System.Drawing.Point(170, 103)
        Me.marquee.Name = "marquee"
        Me.marquee.Properties.Appearance.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.marquee.Properties.Appearance.Options.UseFont = True
        Me.marquee.Properties.ShowTitle = True
        Me.marquee.Size = New System.Drawing.Size(100, 28)
        Me.marquee.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Interval = 15000
        '
        'lstValidando
        '
        Me.lstValidando.HorizontalScrollbar = True
        Me.lstValidando.Location = New System.Drawing.Point(12, 41)
        Me.lstValidando.Name = "lstValidando"
        Me.lstValidando.Size = New System.Drawing.Size(398, 273)
        Me.lstValidando.TabIndex = 3
        '
        'lstErro
        '
        Me.lstErro.HorizontalScrollbar = True
        Me.lstErro.Location = New System.Drawing.Point(12, 237)
        Me.lstErro.Name = "lstErro"
        Me.lstErro.Size = New System.Drawing.Size(398, 77)
        Me.lstErro.TabIndex = 4
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(335, 135)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "SimpleButton1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnVerificar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVerificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnVerificar
        '
        Me.btnVerificar.Caption = "&Verificar Nota"
        Me.btnVerificar.Glyph = Global.Nano.My.Resources.Resources.lupa
        Me.btnVerificar.Id = 1
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(24, 218)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 14)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Erro"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(12, 226)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(400, 5)
        Me.PanelControl1.TabIndex = 11
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(12, 320)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(398, 18)
        Me.pb.TabIndex = 12
        '
        'frmProcesNfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lstValidando)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lstErro)
        Me.Controls.Add(Me.marquee)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcesNfe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Processamento"
        CType(Me.marquee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstValidando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents marquee As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lstValidando As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lstErro As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btnInicio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnVerificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
End Class
