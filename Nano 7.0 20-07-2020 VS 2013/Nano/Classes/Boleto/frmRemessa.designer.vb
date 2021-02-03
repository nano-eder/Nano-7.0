<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemessa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemessa))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnExcluir = New DevExpress.XtraBars.BarButtonItem
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFiltrar = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.btnVisualizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnGerar = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkTodos = New DevExpress.XtraEditors.CheckEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsBoleto = New System.Data.DataSet
        Me.tbBoleto = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNomeBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCedente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGerar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkGerar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCodBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNossoNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMora = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPerMulta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiasProtesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrimeiraInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSegundaInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDemonstrativo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInstrucao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataEmissao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEndereco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBairro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCidade = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOpcional = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fbdCaminho = New System.Windows.Forms.FolderBrowserDialog
        Me.colParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataColumn27 = New System.Data.DataColumn
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkTodos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGerar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFiltrar, Me.dtInicial, Me.dtFinal, Me.btnVisualizar, Me.btnFechar, Me.btnGerar, Me.BarSubItem1, Me.btnRelCust, Me.btnExcluir})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnExcluir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 104, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 106, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFiltrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGerar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnExcluir
        '
        Me.btnExcluir.Caption = "&Excluir"
        Me.btnExcluir.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnExcluir.Id = 8
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'dtInicial
        '
        Me.dtInicial.Caption = "Data Inicial"
        Me.dtInicial.Edit = Me.RepositoryItemDateEdit1
        Me.dtInicial.Id = 1
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
        Me.dtFinal.Id = 2
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
        Me.btnFiltrar.Caption = "F&iltrar"
        Me.btnFiltrar.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFiltrar.Id = 0
        Me.btnFiltrar.Name = "btnFiltrar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarSubItem1.Caption = "&Visualizar"
        Me.BarSubItem1.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.BarSubItem1.Id = 6
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnVisualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnVisualizar.Caption = "&Relatório de Remessas"
        Me.btnVisualizar.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnVisualizar.Id = 3
        Me.btnVisualizar.Name = "btnVisualizar"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCust.Id = 7
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnGerar
        '
        Me.btnGerar.Caption = "&Gerar"
        Me.btnGerar.Glyph = Global.Nano.My.Resources.Resources.apply18x18
        Me.btnGerar.Id = 5
        Me.btnGerar.Name = "btnGerar"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 4
        Me.btnFechar.Name = "btnFechar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl1.Controls.Add(Me.chkTodos)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(984, 526)
        Me.GroupControl1.TabIndex = 4
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.Location = New System.Drawing.Point(12, 499)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkTodos.Properties.Appearance.Options.UseFont = True
        Me.chkTodos.Properties.Caption = "Marcar Todos"
        Me.chkTodos.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTodos.Size = New System.Drawing.Size(103, 19)
        Me.chkTodos.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbBoleto"
        Me.GridControl1.DataSource = Me.dsBoleto
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkGerar})
        Me.GridControl1.Size = New System.Drawing.Size(980, 489)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsBoleto
        '
        Me.dsBoleto.DataSetName = "NewDataSet"
        Me.dsBoleto.Tables.AddRange(New System.Data.DataTable() {Me.tbBoleto})
        '
        'tbBoleto
        '
        Me.tbBoleto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.tbBoleto.TableName = "tbBoleto"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "NomeBanco"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Agencia"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CodigoCedente"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NumeroDocumento"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Vencimento"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Valor"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Status"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Gerar"
        Me.DataColumn9.DataType = GetType(Boolean)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodBanco"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "NossoNumero"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Cliente"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CPF"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Endereco"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Numero"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Bairro"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Cidade"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "Estado"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Cep"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "DiasProtesto"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "PerMulta"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Mora"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Demonstrativo"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Instrucao"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "PrimeiraInstrucao"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "DataEmissao"
        '
        'grd1
        '
        Me.grd1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNomeBanco, Me.colAgencia, Me.colCodigoCedente, Me.colVencimento, Me.colValor, Me.colNumeroDocumento, Me.colStatus, Me.colGerar, Me.colCodigo, Me.ColCodBanco, Me.colNossoNumero, Me.colMora, Me.colPerMulta, Me.colDiasProtesto, Me.colPrimeiraInstrucao, Me.colSegundaInstrucao, Me.colDemonstrativo, Me.colInstrucao, Me.colDataEmissao, Me.colCliente, Me.colCPF, Me.colEndereco, Me.colNumero, Me.colBairro, Me.colCidade, Me.colCep, Me.colOpcional, Me.colEstado, Me.colParcela})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colNomeBanco
        '
        Me.colNomeBanco.Caption = "Nome Banco"
        Me.colNomeBanco.FieldName = "NomeBanco"
        Me.colNomeBanco.Name = "colNomeBanco"
        Me.colNomeBanco.OptionsColumn.ReadOnly = True
        Me.colNomeBanco.Visible = True
        Me.colNomeBanco.VisibleIndex = 0
        Me.colNomeBanco.Width = 98
        '
        'colAgencia
        '
        Me.colAgencia.AppearanceCell.Options.UseTextOptions = True
        Me.colAgencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgencia.Caption = "Agência"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 1
        Me.colAgencia.Width = 60
        '
        'colCodigoCedente
        '
        Me.colCodigoCedente.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCedente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCedente.Caption = "Cód. Cedente"
        Me.colCodigoCedente.FieldName = "CodigoCedente"
        Me.colCodigoCedente.Name = "colCodigoCedente"
        Me.colCodigoCedente.OptionsColumn.ReadOnly = True
        Me.colCodigoCedente.Visible = True
        Me.colCodigoCedente.VisibleIndex = 2
        Me.colCodigoCedente.Width = 89
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
        Me.colVencimento.VisibleIndex = 6
        Me.colVencimento.Width = 94
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 7
        Me.colValor.Width = 83
        '
        'colNumeroDocumento
        '
        Me.colNumeroDocumento.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroDocumento.Caption = "Nº Documento"
        Me.colNumeroDocumento.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento.Name = "colNumeroDocumento"
        Me.colNumeroDocumento.OptionsColumn.ReadOnly = True
        Me.colNumeroDocumento.Visible = True
        Me.colNumeroDocumento.VisibleIndex = 5
        Me.colNumeroDocumento.Width = 91
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 8
        Me.colStatus.Width = 77
        '
        'colGerar
        '
        Me.colGerar.Caption = "Gerar"
        Me.colGerar.ColumnEdit = Me.chkGerar
        Me.colGerar.FieldName = "Gerar"
        Me.colGerar.Name = "colGerar"
        Me.colGerar.Visible = True
        Me.colGerar.VisibleIndex = 9
        Me.colGerar.Width = 64
        '
        'chkGerar
        '
        Me.chkGerar.AutoHeight = False
        Me.chkGerar.Name = "chkGerar"
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        '
        'ColCodBanco
        '
        Me.ColCodBanco.Caption = "CodBanco"
        Me.ColCodBanco.FieldName = "CodBanco"
        Me.ColCodBanco.Name = "ColCodBanco"
        '
        'colNossoNumero
        '
        Me.colNossoNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNossoNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNossoNumero.Caption = "Nosso Número"
        Me.colNossoNumero.FieldName = "NossoNumero"
        Me.colNossoNumero.Name = "colNossoNumero"
        Me.colNossoNumero.OptionsColumn.ReadOnly = True
        Me.colNossoNumero.Visible = True
        Me.colNossoNumero.VisibleIndex = 4
        Me.colNossoNumero.Width = 91
        '
        'colMora
        '
        Me.colMora.Caption = "Valor Mora"
        Me.colMora.FieldName = "Mora"
        Me.colMora.Name = "colMora"
        Me.colMora.OptionsColumn.ReadOnly = True
        '
        'colPerMulta
        '
        Me.colPerMulta.Caption = "Perc. Multa"
        Me.colPerMulta.FieldName = "PerMulta"
        Me.colPerMulta.Name = "colPerMulta"
        Me.colPerMulta.OptionsColumn.ReadOnly = True
        '
        'colDiasProtesto
        '
        Me.colDiasProtesto.Caption = "Dias Protesto"
        Me.colDiasProtesto.FieldName = "DiasProtesto"
        Me.colDiasProtesto.Name = "colDiasProtesto"
        Me.colDiasProtesto.OptionsColumn.ReadOnly = True
        '
        'colPrimeiraInstrucao
        '
        Me.colPrimeiraInstrucao.Caption = "1ª Instrução"
        Me.colPrimeiraInstrucao.FieldName = "PrimeiraInstrucao"
        Me.colPrimeiraInstrucao.Name = "colPrimeiraInstrucao"
        Me.colPrimeiraInstrucao.OptionsColumn.ReadOnly = True
        '
        'colSegundaInstrucao
        '
        Me.colSegundaInstrucao.Caption = "2ª Instrução"
        Me.colSegundaInstrucao.FieldName = "SegundaInstrucao"
        Me.colSegundaInstrucao.Name = "colSegundaInstrucao"
        Me.colSegundaInstrucao.OptionsColumn.ReadOnly = True
        '
        'colDemonstrativo
        '
        Me.colDemonstrativo.Caption = "Demonstrativo"
        Me.colDemonstrativo.FieldName = "Demonstrativo"
        Me.colDemonstrativo.Name = "colDemonstrativo"
        Me.colDemonstrativo.OptionsColumn.ReadOnly = True
        '
        'colInstrucao
        '
        Me.colInstrucao.Caption = "Instrução"
        Me.colInstrucao.FieldName = "Instrucao"
        Me.colInstrucao.Name = "colInstrucao"
        Me.colInstrucao.OptionsColumn.ReadOnly = True
        '
        'colDataEmissao
        '
        Me.colDataEmissao.Caption = "Data Emissão"
        Me.colDataEmissao.FieldName = "DataEmissao"
        Me.colDataEmissao.Name = "colDataEmissao"
        Me.colDataEmissao.OptionsColumn.ReadOnly = True
        '
        'colCliente
        '
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 3
        Me.colCliente.Width = 212
        '
        'colCPF
        '
        Me.colCPF.Caption = "CPF"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.OptionsColumn.ReadOnly = True
        '
        'colEndereco
        '
        Me.colEndereco.Caption = "Endereço"
        Me.colEndereco.FieldName = "Endereco"
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.OptionsColumn.ReadOnly = True
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.ReadOnly = True
        '
        'colBairro
        '
        Me.colBairro.Caption = "Bairro"
        Me.colBairro.FieldName = "Bairro"
        Me.colBairro.Name = "colBairro"
        Me.colBairro.OptionsColumn.ReadOnly = True
        '
        'colCidade
        '
        Me.colCidade.Caption = "Cidade"
        Me.colCidade.FieldName = "Cidade"
        Me.colCidade.Name = "colCidade"
        Me.colCidade.OptionsColumn.ReadOnly = True
        '
        'colCep
        '
        Me.colCep.Caption = "Cep"
        Me.colCep.FieldName = "Cep"
        Me.colCep.Name = "colCep"
        Me.colCep.OptionsColumn.ReadOnly = True
        '
        'colOpcional
        '
        Me.colOpcional.Caption = "Opcional"
        Me.colOpcional.FieldName = "Opcional"
        Me.colOpcional.Name = "colOpcional"
        Me.colOpcional.OptionsColumn.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.ReadOnly = True
        '
        'colParcela
        '
        Me.colParcela.Caption = "Parcela"
        Me.colParcela.FieldName = "Parcela"
        Me.colParcela.Name = "colParcela"
        Me.colParcela.OptionsColumn.ReadOnly = True
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "Parcela"
        '
        'frmRemessa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRemessa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar Arquivo de Remessa"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkTodos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGerar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnFiltrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnVisualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colNomeBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCedente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGerar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGerar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkGerar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCodBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsBoleto As System.Data.DataSet
    Friend WithEvents tbBoleto As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colNossoNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fbdCaminho As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkTodos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents colMora As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPerMulta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiasProtesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimeiraInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDemonstrativo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataEmissao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndereco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBairro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCidade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSegundaInstrucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcional As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExcluir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
End Class
