<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrediario2
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
        Dim lblPar As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrediario2))
        Me.txtValCred = New Campos.NanoCampo
        Me.seParcela = New DevExpress.XtraEditors.SpinEdit
        Me.dtVen = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCred = New System.Data.DataSet
        Me.tdCred = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtVal = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dtVenc = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem
        Me.btnClear = New DevExpress.XtraBars.BarButtonItem
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.txtJuros = New Campos.NanoCampo
        Me.txtDias = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        lblPar = New System.Windows.Forms.Label
        ValorLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CType(Me.txtValCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVen.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdCred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVenc.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJuros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPar
        '
        lblPar.AutoSize = True
        lblPar.Location = New System.Drawing.Point(331, 41)
        lblPar.Name = "lblPar"
        lblPar.Size = New System.Drawing.Size(47, 13)
        lblPar.TabIndex = 87
        lblPar.Text = "Nº Parc."
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(3, 15)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(108, 13)
        ValorLabel.TabIndex = 90
        ValorLabel.Text = "Valor do Crediário R$"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(35, 41)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 13)
        Label1.TabIndex = 92
        Label1.Text = "1º Vencimento"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(225, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 95
        Label2.Text = "Juros %"
        '
        'txtValCred
        '
        Me.txtValCred.CasasDecimais = 2
        Me.txtValCred.Enabled = False
        Me.txtValCred.EnterMoveNextControl = True
        Me.txtValCred.Location = New System.Drawing.Point(117, 12)
        Me.txtValCred.Name = "txtValCred"
        Me.txtValCred.Numerico = True
        Me.txtValCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValCred.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtValCred.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtValCred.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtValCred.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtValCred.Size = New System.Drawing.Size(106, 20)
        Me.txtValCred.TabIndex = 80
        Me.txtValCred.Tag = "Valor do Crediário R$"
        '
        'seParcela
        '
        Me.seParcela.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seParcela.Location = New System.Drawing.Point(384, 38)
        Me.seParcela.Name = "seParcela"
        Me.seParcela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seParcela.Size = New System.Drawing.Size(46, 20)
        Me.seParcela.TabIndex = 2
        Me.seParcela.Tag = "Nº Parcelas"
        '
        'dtVen
        '
        Me.dtVen.EditValue = Nothing
        Me.dtVen.EnterMoveNextControl = True
        Me.dtVen.Location = New System.Drawing.Point(117, 38)
        Me.dtVen.Name = "dtVen"
        Me.dtVen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVen.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtVen.Size = New System.Drawing.Size(106, 20)
        Me.dtVen.TabIndex = 1
        Me.dtVen.Tag = "1º Vencimento"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(442, 253)
        Me.GroupControl1.TabIndex = 93
        Me.GroupControl1.Text = "Datas e Valores"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbCred"
        Me.GridControl1.DataSource = Me.dsCred
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtVal, Me.dtVenc})
        Me.GridControl1.Size = New System.Drawing.Size(438, 231)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCred
        '
        Me.dsCred.DataSetName = "NewDataSet"
        Me.dsCred.Tables.AddRange(New System.Data.DataTable() {Me.tdCred})
        '
        'tdCred
        '
        Me.tdCred.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.tdCred.TableName = "tbCred"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Parcela"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Valor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Vencimento"
        Me.DataColumn3.DataType = GetType(Date)
        Me.DataColumn3.DateTimeMode = System.Data.DataSetDateTime.Local
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Documento"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Pagamento"
        '
        'grd1
        '
        Me.grd1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White
        Me.grd1.Appearance.EvenRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grd1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grd1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.grd1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grd1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grd1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.grd1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.grd1.Appearance.OddRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grd1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParcela, Me.colValor, Me.colVencimento, Me.colDocumento, Me.colPagamento})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.EnableAppearanceEvenRow = True
        Me.grd1.OptionsView.EnableAppearanceOddRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colParcela
        '
        Me.colParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcela.Caption = "Parcela Nº"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.ReadOnly = True
        Me.colParcela.Visible = True
        Me.colParcela.VisibleIndex = 0
        Me.colParcela.Width = 72
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.ColumnEdit = Me.txtVal
        Me.colValor.DisplayFormat.FormatString = "c"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 1
        Me.colValor.Width = 87
        '
        'txtVal
        '
        Me.txtVal.AutoHeight = False
        Me.txtVal.Name = "txtVal"
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.ColumnEdit = Me.dtVenc
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 2
        Me.colVencimento.Width = 101
        '
        'dtVenc
        '
        Me.dtVenc.AutoHeight = False
        Me.dtVenc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colDocumento
        '
        Me.colDocumento.Caption = "Nº Documento"
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 3
        Me.colDocumento.Width = 157
        '
        'colPagamento
        '
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnClose, Me.btnSave, Me.btnClear})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClear, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnClose, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnSave
        '
        Me.btnSave.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSave.Caption = "&OK"
        Me.btnSave.Glyph = Global.Nano.My.Resources.Resources.apply
        Me.btnSave.Id = 2
        Me.btnSave.Name = "btnSave"
        '
        'btnClear
        '
        Me.btnClear.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnClear.Caption = "&Limpar"
        Me.btnClear.Glyph = Global.Nano.My.Resources.Resources.Comando_Limpar_32x32
        Me.btnClear.Id = 3
        Me.btnClear.Name = "btnClear"
        '
        'btnClose
        '
        Me.btnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnClose.Caption = "&Fechar"
        Me.btnClose.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnClose.Id = 0
        Me.btnClose.Name = "btnClose"
        '
        'txtJuros
        '
        Me.txtJuros.CasasDecimais = 2
        Me.txtJuros.EnterMoveNextControl = True
        Me.txtJuros.Location = New System.Drawing.Point(278, 12)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Numerico = True
        Me.txtJuros.Properties.Appearance.Options.UseTextOptions = True
        Me.txtJuros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtJuros.Size = New System.Drawing.Size(152, 20)
        Me.txtJuros.TabIndex = 0
        Me.txtJuros.Tag = "Juros %"
        '
        'txtDias
        '
        Me.txtDias.EditValue = "30"
        Me.txtDias.EnterMoveNextControl = True
        Me.txtDias.Location = New System.Drawing.Point(278, 38)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Properties.Appearance.Options.UseFont = True
        Me.txtDias.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDias.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDias.Properties.MaxLength = 2
        Me.txtDias.Size = New System.Drawing.Size(47, 20)
        Me.txtDias.TabIndex = 98
        Me.txtDias.Tag = "Vezes"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(237, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl8.TabIndex = 99
        Me.LabelControl8.Text = "Nº Dias"
        '
        'frmCrediario2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 359)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtJuros)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.dtVen)
        Me.Controls.Add(Me.txtValCred)
        Me.Controls.Add(lblPar)
        Me.Controls.Add(Me.seParcela)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrediario2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Crediário"
        CType(Me.txtValCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seParcela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVen.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdCred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVenc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJuros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValCred As Campos.NanoCampo
    Friend WithEvents seParcela As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtVen As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dsCred As System.Data.DataSet
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents tdCred As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtJuros As Campos.NanoCampo
    Friend WithEvents txtVal As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents dtVenc As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
