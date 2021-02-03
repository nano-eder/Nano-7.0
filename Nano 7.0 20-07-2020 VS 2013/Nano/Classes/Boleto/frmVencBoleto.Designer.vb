<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVencBoleto
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
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVencBoleto))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnGerar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.lblRecebi = New DevExpress.XtraEditors.LabelControl
        Me.dtVencimento = New DevExpress.XtraEditors.DateEdit
        Me.txtValorConta = New Campos.NanoCampo
        Me.txtCliente = New Campos.NanoCampo
        ValorLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorConta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(9, 41)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(74, 13)
        ValorLabel.TabIndex = 110
        ValorLabel.Text = "Valor Total R$"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(43, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 13)
        Label2.TabIndex = 113
        Label2.Text = "Cliente"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnGerar})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGerar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnGerar
        '
        Me.btnGerar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnGerar.Caption = "&Gerar"
        Me.btnGerar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnGerar.Id = 1
        Me.btnGerar.Name = "btnGerar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'lblRecebi
        '
        Me.lblRecebi.Location = New System.Drawing.Point(238, 41)
        Me.lblRecebi.Name = "lblRecebi"
        Me.lblRecebi.Size = New System.Drawing.Size(55, 13)
        Me.lblRecebi.TabIndex = 111
        Me.lblRecebi.Text = "Vencimento"
        '
        'dtVencimento
        '
        Me.dtVencimento.EditValue = Nothing
        Me.dtVencimento.EnterMoveNextControl = True
        Me.dtVencimento.Location = New System.Drawing.Point(299, 38)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtVencimento.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtVencimento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVencimento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVencimento.Size = New System.Drawing.Size(107, 20)
        Me.dtVencimento.TabIndex = 109
        Me.dtVencimento.Tag = "Data Recebimento"
        '
        'txtValorConta
        '
        Me.txtValorConta.CasasDecimais = 2
        Me.txtValorConta.EnterMoveNextControl = True
        Me.txtValorConta.Location = New System.Drawing.Point(89, 38)
        Me.txtValorConta.Name = "txtValorConta"
        Me.txtValorConta.Numerico = True
        Me.txtValorConta.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorConta.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtValorConta.Size = New System.Drawing.Size(107, 20)
        Me.txtValorConta.TabIndex = 108
        '
        'txtCliente
        '
        Me.txtCliente.CasasDecimais = 0
        Me.txtCliente.EnterMoveNextControl = True
        Me.txtCliente.Location = New System.Drawing.Point(89, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Numerico = False
        Me.txtCliente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCliente.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCliente.Properties.MaxLength = 100
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(317, 20)
        Me.txtCliente.TabIndex = 112
        '
        'frmVencBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 102)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblRecebi)
        Me.Controls.Add(Me.dtVencimento)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.txtValorConta)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVencBoleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boleto"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVencimento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVencimento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorConta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGerar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblRecebi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtVencimento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtValorConta As Campos.NanoCampo
    Friend WithEvents txtCliente As Campos.NanoCampo
End Class
