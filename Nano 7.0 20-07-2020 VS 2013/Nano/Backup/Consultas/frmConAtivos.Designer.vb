<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConAtivos
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConAtivos))
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.cboStatus = New DevExpress.XtraBars.BarEditItem
        Me.cboStatus1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisualizar = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsItens = New System.Data.DataSet
        Me.tbItens = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAlterar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCodAtivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodPadrao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescricao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.pnlLegenda = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pnlLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLegenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.OptionsColumn.ReadOnly = True
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 5
        Me.colVencimento.Width = 107
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cboStatus, Me.dtInicial, Me.dtFinal, Me.btnFiltrar, Me.bsiVisualizar, Me.btnFechar, Me.btnVisualizar, Me.btnRelCust})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboStatus1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.cboStatus, "", False, True, True, 95, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 100, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 102, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cboStatus
        '
        Me.cboStatus.Caption = "Status"
        Me.cboStatus.Edit = Me.cboStatus1
        Me.cboStatus.Id = 1
        Me.cboStatus.Name = "cboStatus"
        '
        'cboStatus1
        '
        Me.cboStatus1.AutoHeight = False
        Me.cboStatus1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus1.Items.AddRange(New Object() {"ENTREGUE", "DEVOLVIDO"})
        Me.cboStatus1.Name = "cboStatus1"
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 2
        Me.dtInicial.Name = "dtInicial"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtFinal
        '
        Me.dtFinal.Caption = "Data Final"
        Me.dtFinal.Edit = Me.RepositoryItemDateEdit2
        Me.dtFinal.Id = 3
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Caption = "&Filtrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 4
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'bsiVisualizar
        '
        Me.bsiVisualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisualizar.Caption = "&Visualizar"
        Me.bsiVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisualizar.Id = 5
        Me.bsiVisualizar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnVisualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.bsiVisualizar.Name = "bsiVisualizar"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Caption = "&Relatório de Ativos"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 7
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 8
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 6
        Me.btnFechar.Name = "btnFechar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbItens"
        Me.GridControl1.DataSource = Me.dsItens
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAlterar})
        Me.GridControl1.Size = New System.Drawing.Size(1004, 589)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.tbItens.TableName = "tbItens"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodOrdem"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodAtivo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CodPadrao"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Descricao"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Produto"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Cliente"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Vencimento"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Status"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colCodAtivo, Me.colCodPadrao, Me.colDescricao, Me.colProduto, Me.colCliente, Me.colVencimento, Me.colStatus})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colVencimento
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colVencimento
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.Caption = "Cód. Ped."
        Me.colCodOrdem.ColumnEdit = Me.txtAlterar
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 97
        '
        'txtAlterar
        '
        Me.txtAlterar.AutoHeight = False
        Me.txtAlterar.Name = "txtAlterar"
        '
        'colCodAtivo
        '
        Me.colCodAtivo.Caption = "CodAtivo"
        Me.colCodAtivo.FieldName = "CodAtivo"
        Me.colCodAtivo.Name = "colCodAtivo"
        Me.colCodAtivo.OptionsColumn.ReadOnly = True
        '
        'colCodPadrao
        '
        Me.colCodPadrao.AppearanceCell.Options.UseTextOptions = True
        Me.colCodPadrao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodPadrao.Caption = "Cód. Barra"
        Me.colCodPadrao.ColumnEdit = Me.txtAlterar
        Me.colCodPadrao.FieldName = "CodPadrao"
        Me.colCodPadrao.Name = "colCodPadrao"
        Me.colCodPadrao.OptionsColumn.ReadOnly = True
        Me.colCodPadrao.Visible = True
        Me.colCodPadrao.VisibleIndex = 1
        Me.colCodPadrao.Width = 112
        '
        'colDescricao
        '
        Me.colDescricao.Caption = "Descrição"
        Me.colDescricao.ColumnEdit = Me.txtAlterar
        Me.colDescricao.FieldName = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.OptionsColumn.ReadOnly = True
        Me.colDescricao.Visible = True
        Me.colDescricao.VisibleIndex = 2
        Me.colDescricao.Width = 255
        '
        'colProduto
        '
        Me.colProduto.Caption = "Produto"
        Me.colProduto.ColumnEdit = Me.txtAlterar
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 3
        Me.colProduto.Width = 235
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.ColumnEdit = Me.txtAlterar
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 177
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Width = 85
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.pnlLegenda)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1008, 626)
        Me.GroupControl1.TabIndex = 5
        '
        'pnlLegenda
        '
        Me.pnlLegenda.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLegenda.Appearance.Options.UseBackColor = True
        Me.pnlLegenda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlLegenda.Controls.Add(Me.LabelControl3)
        Me.pnlLegenda.Controls.Add(Me.SimpleButton1)
        Me.pnlLegenda.Controls.Add(Me.LabelControl2)
        Me.pnlLegenda.Controls.Add(Me.SimpleButton2)
        Me.pnlLegenda.Controls.Add(Me.LabelControl1)
        Me.pnlLegenda.Location = New System.Drawing.Point(7, 595)
        Me.pnlLegenda.Name = "pnlLegenda"
        Me.pnlLegenda.Size = New System.Drawing.Size(374, 28)
        Me.pnlLegenda.TabIndex = 10
        Me.pnlLegenda.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Legenda:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Red
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(65, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(23, 23)
        Me.SimpleButton1.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(212, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Menos de 4 dias para vencer"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(185, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(23, 23)
        Me.SimpleButton2.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(92, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Produto Vencido"
        '
        'frmConAtivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConAtivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Barril/Chopeira"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.pnlLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLegenda.ResumeLayout(False)
        Me.pnlLegenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cboStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboStatus1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiVisualizar As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsItens As System.Data.DataSet
    Friend WithEvents tbItens As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodAtivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodPadrao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescricao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlterar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlLegenda As DevExpress.XtraEditors.PanelControl
End Class
