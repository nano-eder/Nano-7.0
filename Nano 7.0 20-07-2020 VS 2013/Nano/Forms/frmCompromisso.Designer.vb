<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompromisso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompromisso))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtCodPedido = New DevExpress.XtraEditors.TextEdit
        Me.memDescricao = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.cboLembrete = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memDescricao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLembrete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSalvar, Me.btnFechar, Me.btnExcluir})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 2
        Me.btnExcluir.Name = "btnExcluir"
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
        'txtCodPedido
        '
        Me.txtCodPedido.Location = New System.Drawing.Point(6, 31)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodPedido.Properties.Appearance.Options.UseFont = True
        Me.txtCodPedido.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCodPedido.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtCodPedido.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodPedido.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodPedido.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodPedido.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodPedido.Properties.ReadOnly = True
        Me.txtCodPedido.Size = New System.Drawing.Size(125, 21)
        Me.txtCodPedido.TabIndex = 5
        '
        'memDescricao
        '
        Me.memDescricao.Location = New System.Drawing.Point(6, 74)
        Me.memDescricao.Name = "memDescricao"
        Me.memDescricao.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.memDescricao.Properties.Appearance.Options.UseFont = True
        Me.memDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.memDescricao.Size = New System.Drawing.Size(449, 96)
        Me.memDescricao.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Nº Pedido"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(147, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Data / Hora"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(6, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Descrição"
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(147, 31)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dtData.Properties.Appearance.Options.UseFont = True
        Me.dtData.Properties.Appearance.Options.UseTextOptions = True
        Me.dtData.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.dtData.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gainsboro
        Me.dtData.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.dtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtData.Properties.HighlightHolidays = False
        Me.dtData.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(142, 21)
        Me.dtData.TabIndex = 0
        '
        'cboLembrete
        '
        Me.cboLembrete.Location = New System.Drawing.Point(307, 31)
        Me.cboLembrete.Name = "cboLembrete"
        Me.cboLembrete.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cboLembrete.Properties.Appearance.Options.UseFont = True
        Me.cboLembrete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLembrete.Properties.Items.AddRange(New Object() {"", "5 minutos", "10 minutos", "15 minutos", "20 minutos", "30 minutos", "1 hora", "2 horas", "3 horas", "4 horas", "5 horas", "6 horas", "7 horas", "8 horas", "9 horas", "10 horas", "11 horas", "1 dia", "2 dias", "3 dias", "4 dias", "1 semana", "2 semanas"})
        Me.cboLembrete.Size = New System.Drawing.Size(148, 21)
        Me.cboLembrete.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(307, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 14)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Lembrete"
        '
        'frmCompromisso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 212)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cboLembrete)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.memDescricao)
        Me.Controls.Add(Me.txtCodPedido)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompromisso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compromisso"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memDescricao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLembrete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents memDescricao As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCodPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLembrete As DevExpress.XtraEditors.ComboBoxEdit
End Class
