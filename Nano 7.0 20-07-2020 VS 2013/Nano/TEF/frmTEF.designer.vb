<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTEF
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
        Me.lblProcesso = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnCancelar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnInicio = New DevExpress.XtraEditors.SimpleButton
        Me.lblProcesso2 = New DevExpress.XtraEditors.MemoEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnMensagem = New DevExpress.XtraEditors.SimpleButton
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProcesso2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProcesso
        '
        Me.lblProcesso.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblProcesso.Appearance.Options.UseFont = True
        Me.lblProcesso.Location = New System.Drawing.Point(41, 76)
        Me.lblProcesso.Name = "lblProcesso"
        Me.lblProcesso.Size = New System.Drawing.Size(138, 28)
        Me.lblProcesso.TabIndex = 3
        Me.lblProcesso.Text = "CONECTANDO"
        Me.lblProcesso.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnCancelar})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnCancelar.Caption = "&Cancelar"
        Me.btnCancelar.Glyph = Global.Nano.My.Resources.Resources.Erro
        Me.btnCancelar.Id = 0
        Me.btnCancelar.Name = "btnCancelar"
        '
        'Timer1
        '
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(396, 87)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 2
        Me.btnInicio.Text = "SimpleButton1"
        Me.btnInicio.Visible = False
        '
        'lblProcesso2
        '
        Me.lblProcesso2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblProcesso2.EditValue = ""
        Me.lblProcesso2.Location = New System.Drawing.Point(0, 65)
        Me.lblProcesso2.Name = "lblProcesso2"
        Me.lblProcesso2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblProcesso2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblProcesso2.Properties.Appearance.Options.UseBackColor = True
        Me.lblProcesso2.Properties.Appearance.Options.UseFont = True
        Me.lblProcesso2.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent
        Me.lblProcesso2.Properties.AppearanceDisabled.BackColor2 = System.Drawing.Color.Transparent
        Me.lblProcesso2.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblProcesso2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.lblProcesso2.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lblProcesso2.Properties.AppearanceDisabled.Options.UseFont = True
        Me.lblProcesso2.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.lblProcesso2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblProcesso2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblProcesso2.Size = New System.Drawing.Size(483, 72)
        Me.lblProcesso2.TabIndex = 1
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(261, 84)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nano.My.Resources.Resources.NANO_COMMERCE
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnMensagem
        '
        Me.btnMensagem.Location = New System.Drawing.Point(104, 87)
        Me.btnMensagem.Name = "btnMensagem"
        Me.btnMensagem.Size = New System.Drawing.Size(75, 23)
        Me.btnMensagem.TabIndex = 5
        Me.btnMensagem.Text = "SimpleButton1"
        '
        'frmTEF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblProcesso2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.lblProcesso)
        Me.Controls.Add(Me.btnMensagem)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTEF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProcesso2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProcesso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnInicio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblProcesso2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMensagem As DevExpress.XtraEditors.SimpleButton
End Class
