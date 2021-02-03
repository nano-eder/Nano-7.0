<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigTEF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigTEF))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalvar = New DevExpress.XtraBars.BarButtonItem
        Me.btnAlterar = New DevExpress.XtraBars.BarButtonItem
        Me.btnLimpar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.btnNomePc = New DevExpress.XtraEditors.SimpleButton
        Me.txtComputador = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtIP = New DevExpress.XtraEditors.TextEdit
        Me.txtNumCaixa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colNumCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComputador = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNomeAd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboNomeAd = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComputador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCaixa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNomeAd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExcluir, Me.btnSalvar, Me.btnAlterar, Me.btnLimpar, Me.btnFechar})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSalvar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnAlterar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnLimpar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 0
        Me.btnExcluir.Name = "btnExcluir"
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSalvar.Caption = "&Salvar"
        Me.btnSalvar.Glyph = Global.Nano.My.Resources.Resources.Comando_Gravar_32x32
        Me.btnSalvar.Id = 1
        Me.btnSalvar.Name = "btnSalvar"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnAlterar.Caption = "&Alterar"
        Me.btnAlterar.Glyph = Global.Nano.My.Resources.Resources.Alterar
        Me.btnAlterar.Id = 2
        Me.btnAlterar.Name = "btnAlterar"
        '
        'btnLimpar
        '
        Me.btnLimpar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnLimpar.Caption = "&Limpar"
        Me.btnLimpar.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnLimpar.Id = 3
        Me.btnLimpar.Name = "btnLimpar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'btnNomePc
        '
        Me.btnNomePc.Image = Global.Nano.My.Resources.Resources.Lupa_Azul_12x12
        Me.btnNomePc.Location = New System.Drawing.Point(209, 39)
        Me.btnNomePc.Name = "btnNomePc"
        Me.btnNomePc.Size = New System.Drawing.Size(20, 20)
        Me.btnNomePc.TabIndex = 129
        '
        'txtComputador
        '
        Me.txtComputador.Location = New System.Drawing.Point(47, 39)
        Me.txtComputador.Name = "txtComputador"
        Me.txtComputador.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtComputador.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtComputador.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtComputador.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtComputador.Size = New System.Drawing.Size(162, 20)
        Me.txtComputador.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 127
        Me.LabelControl1.Text = "Comp."
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(236, 15)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl56.TabIndex = 132
        Me.LabelControl56.Text = "Num. Caixa"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(47, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtIP.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtIP.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtIP.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtIP.Size = New System.Drawing.Size(162, 20)
        Me.txtIP.TabIndex = 0
        '
        'txtNumCaixa
        '
        Me.txtNumCaixa.Location = New System.Drawing.Point(297, 12)
        Me.txtNumCaixa.Name = "txtNumCaixa"
        Me.txtNumCaixa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtNumCaixa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNumCaixa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumCaixa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumCaixa.Size = New System.Drawing.Size(119, 20)
        Me.txtNumCaixa.TabIndex = 1
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(31, 15)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl45.TabIndex = 133
        Me.LabelControl45.Text = "IP"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 65)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(439, 168)
        Me.GroupControl1.TabIndex = 134
        Me.GroupControl1.Text = "Sat Configurado"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbConfig"
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(435, 146)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colIP, Me.colNumCaixa, Me.colComputador, Me.colNomeAd})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colIP
        '
        Me.colIP.AppearanceCell.Options.UseTextOptions = True
        Me.colIP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIP.Caption = "IP"
        Me.colIP.ColumnEdit = Me.txtAlterar
        Me.colIP.FieldName = "IP"
        Me.colIP.Name = "colIP"
        Me.colIP.Visible = True
        Me.colIP.VisibleIndex = 0
        Me.colIP.Width = 150
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colNumCaixa
        '
        Me.colNumCaixa.AppearanceCell.Options.UseTextOptions = True
        Me.colNumCaixa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCaixa.Caption = "Nº Caixa"
        Me.colNumCaixa.ColumnEdit = Me.txtAlterar
        Me.colNumCaixa.FieldName = "NumCaixa"
        Me.colNumCaixa.Name = "colNumCaixa"
        Me.colNumCaixa.Visible = True
        Me.colNumCaixa.VisibleIndex = 1
        Me.colNumCaixa.Width = 112
        '
        'colComputador
        '
        Me.colComputador.AppearanceCell.Options.UseTextOptions = True
        Me.colComputador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComputador.Caption = "Computador"
        Me.colComputador.ColumnEdit = Me.txtAlterar
        Me.colComputador.FieldName = "Computador"
        Me.colComputador.Name = "colComputador"
        Me.colComputador.Visible = True
        Me.colComputador.VisibleIndex = 2
        Me.colComputador.Width = 119
        '
        'colNomeAd
        '
        Me.colNomeAd.AppearanceCell.Options.UseTextOptions = True
        Me.colNomeAd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNomeAd.Caption = "Nome Ad."
        Me.colNomeAd.FieldName = "NomeAd"
        Me.colNomeAd.Name = "colNomeAd"
        Me.colNomeAd.OptionsColumn.ReadOnly = True
        Me.colNomeAd.Visible = True
        Me.colNomeAd.VisibleIndex = 3
        '
        'cboNomeAd
        '
        Me.cboNomeAd.EnterMoveNextControl = True
        Me.cboNomeAd.Location = New System.Drawing.Point(297, 38)
        Me.cboNomeAd.Name = "cboNomeAd"
        Me.cboNomeAd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboNomeAd.Properties.Items.AddRange(New Object() {"REDE", "CIELO", "OUTROS"})
        Me.cboNomeAd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNomeAd.Size = New System.Drawing.Size(119, 20)
        Me.cboNomeAd.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(244, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 136
        Me.LabelControl2.Text = "Nome Ad."
        '
        'frmConfigTEF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 269)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboNomeAd)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl56)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtNumCaixa)
        Me.Controls.Add(Me.LabelControl45)
        Me.Controls.Add(Me.btnNomePc)
        Me.Controls.Add(Me.txtComputador)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigTEF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração TEF"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComputador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCaixa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNomeAd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnNomePc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtComputador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumCaixa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNumCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComputador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalvar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLimpar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboNomeAd As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colNomeAd As DevExpress.XtraGrid.Columns.GridColumn
End Class
