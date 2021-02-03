
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixa))
        Me.colCredito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ConfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNanoCommerce = New Nano.dsNanoCommerce
        Me.CaixaGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsCaixaGrid = New System.Data.DataSet
        Me.tbCaixaGrid = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComputador = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBandeira = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cboCred = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.dtData = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cboPag = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lueConfig = New DevExpress.XtraEditors.LookUpEdit
        Me.lblLoja = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.btnPadrao = New DevExpress.XtraEditors.SimpleButton
        Me.txtSaldoAtualDinheiro = New DevExpress.XtraEditors.TextEdit
        Me.btnManter = New DevExpress.XtraEditors.SimpleButton
        Me.lblSaldoDinheiro = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldoCaixa = New DevExpress.XtraEditors.TextEdit
        Me.lblSaldo = New DevExpress.XtraEditors.LabelControl
        Me.btnCalc = New DevExpress.XtraEditors.SimpleButton
        Me.txtCred = New DevExpress.XtraEditors.TextEdit
        Me.txtDeb = New DevExpress.XtraEditors.TextEdit
        Me.lblTotalSaldo = New DevExpress.XtraEditors.LabelControl
        Me.lblCredito = New DevExpress.XtraEditors.LabelControl
        Me.lblDebito = New DevExpress.XtraEditors.LabelControl
        Me.txtSaldo = New DevExpress.XtraEditors.TextEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCaixa = New System.Data.DataSet
        Me.tbPagamento = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.tbCaixaSomado = New System.Data.DataTable
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.tbExtrato = New System.Data.DataTable
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMotivo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCredito1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem
        Me.dtInicial = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtFinal = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.btnFilter = New DevExpress.XtraBars.BarButtonItem
        Me.bsiVisu = New DevExpress.XtraBars.BarSubItem
        Me.btnRelCaixa = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelCust = New DevExpress.XtraBars.BarButtonItem
        Me.btnRelTotais = New DevExpress.XtraBars.BarButtonItem
        Me.btnExtrato = New DevExpress.XtraBars.BarButtonItem
        Me.btnTransferencia = New DevExpress.XtraBars.BarButtonItem
        Me.btnFechar = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CaixaTableAdapter = New Nano.dsNanoCommerceTableAdapters.CaixaTableAdapter
        Me.ConfigTableAdapter = New Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.cboCenCus = New DevExpress.XtraEditors.ComboBoxEdit
        Me.btnCenCus = New DevExpress.XtraEditors.SimpleButton
        Me.txtVal = New Campos.NanoCampo
        Me.btnCadPag = New DevExpress.XtraEditors.SimpleButton
        Me.btnCadMotivo = New DevExpress.XtraEditors.SimpleButton
        Me.txtMot = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCaixaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCaixaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lueConfig.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtSaldoAtualDinheiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoCaixa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCaixaSomado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbExtrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colCredito
        '
        Me.colCredito.AppearanceCell.Options.UseTextOptions = True
        Me.colCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCredito.Caption = "Créd/Déb"
        Me.colCredito.FieldName = "Credito"
        Me.colCredito.Name = "colCredito"
        Me.colCredito.OptionsColumn.ReadOnly = True
        Me.colCredito.Visible = True
        Me.colCredito.VisibleIndex = 4
        Me.colCredito.Width = 63
        '
        'txtValor
        '
        Me.txtValor.AutoHeight = False
        Me.txtValor.DisplayFormat.FormatString = "0.00"
        Me.txtValor.Mask.EditMask = "0.00"
        Me.txtValor.Name = "txtValor"
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 50, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DataSource = Me.ConfigBindingSource
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'ConfigBindingSource
        '
        Me.ConfigBindingSource.DataMember = "Config"
        Me.ConfigBindingSource.DataSource = Me.DsNanoCommerce
        '
        'DsNanoCommerce
        '
        Me.DsNanoCommerce.DataSetName = "dsNanoCommerce"
        Me.DsNanoCommerce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaixaGridControl
        '
        Me.CaixaGridControl.DataMember = "tbCaixaGrid"
        Me.CaixaGridControl.DataSource = Me.dsCaixaGrid
        Me.CaixaGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaixaGridControl.EmbeddedNavigator.Name = ""
        Me.CaixaGridControl.Location = New System.Drawing.Point(2, 2)
        Me.CaixaGridControl.MainView = Me.grd1
        Me.CaixaGridControl.Name = "CaixaGridControl"
        Me.CaixaGridControl.Size = New System.Drawing.Size(959, 468)
        Me.CaixaGridControl.TabIndex = 1
        Me.CaixaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsCaixaGrid
        '
        Me.dsCaixaGrid.DataSetName = "NewDataSet"
        Me.dsCaixaGrid.Tables.AddRange(New System.Data.DataTable() {Me.tbCaixaGrid})
        '
        'tbCaixaGrid
        '
        Me.tbCaixaGrid.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.tbCaixaGrid.TableName = "tbCaixaGrid"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Motivo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Credito"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Data"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Pagamento"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Valor"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "Caixa"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "CentroCusto"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "CodConfig"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Auxiliar"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Codigo"
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
        Me.grd1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.AliceBlue
        Me.grd1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.Row.Options.UseBackColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colMotivo, Me.colCredito, Me.colPagamento, Me.colValor, Me.colData, Me.colCaixa, Me.colCodConfig, Me.colCentroCusto, Me.colComputador, Me.colBandeira})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Tomato
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCredito
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "D"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.grd1.GridControl = Me.CaixaGridControl
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", Me.colValor, "{0:c}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ShowAutoFilterRow = True
        Me.grd1.OptionsView.ShowFooter = True
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colMotivo
        '
        Me.colMotivo.Caption = "Motivo"
        Me.colMotivo.FieldName = "Motivo"
        Me.colMotivo.Name = "colMotivo"
        Me.colMotivo.OptionsColumn.ReadOnly = True
        Me.colMotivo.Visible = True
        Me.colMotivo.VisibleIndex = 2
        Me.colMotivo.Width = 319
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.OptionsColumn.ReadOnly = True
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 5
        Me.colPagamento.Width = 77
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.Caption = "Valor R$"
        Me.colValor.ColumnEdit = Me.txtValor
        Me.colValor.DisplayFormat.FormatString = "c"
        Me.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValor.FieldName = "Valor"
        Me.colValor.GroupFormat.FormatString = "0.00"
        Me.colValor.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValor.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 6
        Me.colValor.Width = 80
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.Caption = "Data"
        Me.colData.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 104
        '
        'colCaixa
        '
        Me.colCaixa.Caption = "Caixa"
        Me.colCaixa.FieldName = "Caixa"
        Me.colCaixa.Name = "colCaixa"
        Me.colCaixa.OptionsColumn.ReadOnly = True
        Me.colCaixa.Visible = True
        Me.colCaixa.VisibleIndex = 1
        Me.colCaixa.Width = 96
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 7
        Me.colCodConfig.Width = 83
        '
        'colCentroCusto
        '
        Me.colCentroCusto.Caption = "Centro Custo"
        Me.colCentroCusto.FieldName = "CentroCusto"
        Me.colCentroCusto.Name = "colCentroCusto"
        Me.colCentroCusto.OptionsColumn.ReadOnly = True
        Me.colCentroCusto.Visible = True
        Me.colCentroCusto.VisibleIndex = 3
        Me.colCentroCusto.Width = 116
        '
        'colComputador
        '
        Me.colComputador.Caption = "Computador"
        Me.colComputador.FieldName = "Auxiliar"
        Me.colComputador.Name = "colComputador"
        Me.colComputador.OptionsColumn.ReadOnly = True
        '
        'colBandeira
        '
        Me.colBandeira.Caption = "Bandeira"
        Me.colBandeira.FieldName = "Bandeira"
        Me.colBandeira.Name = "colBandeira"
        Me.colBandeira.OptionsColumn.ReadOnly = True
        '
        'CaixaBindingSource
        '
        Me.CaixaBindingSource.DataMember = "Caixa"
        Me.CaixaBindingSource.DataSource = Me.DsNanoCommerce
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(44, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Motivo"
        '
        'cboCred
        '
        Me.cboCred.EnterMoveNextControl = True
        Me.cboCred.Location = New System.Drawing.Point(651, 9)
        Me.cboCred.Name = "cboCred"
        Me.cboCred.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cboCred.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCred.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCred.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCred.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCred.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCred.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCred.Properties.Items.AddRange(New Object() {"C", "D"})
        Me.cboCred.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCred.Size = New System.Drawing.Size(109, 20)
        Me.cboCred.TabIndex = 1
        Me.cboCred.Tag = "Crédito/Débito"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(575, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Crédito/Débito"
        '
        'dtData
        '
        Me.dtData.EditValue = Nothing
        Me.dtData.EnterMoveNextControl = True
        Me.dtData.Location = New System.Drawing.Point(838, 9)
        Me.dtData.Name = "dtData"
        Me.dtData.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.dtData.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.dtData.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.dtData.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.dtData.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtData.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.dtData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtData.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtData.Size = New System.Drawing.Size(117, 20)
        Me.dtData.TabIndex = 2
        Me.dtData.Tag = "Data"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(809, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Data"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(307, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Pagamento"
        '
        'cboPag
        '
        Me.cboPag.EnterMoveNextControl = True
        Me.cboPag.Location = New System.Drawing.Point(367, 36)
        Me.cboPag.Name = "cboPag"
        Me.cboPag.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cboPag.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboPag.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboPag.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboPag.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboPag.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboPag.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPag.Properties.MaxLength = 25
        Me.cboPag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboPag.Size = New System.Drawing.Size(164, 20)
        Me.cboPag.TabIndex = 4
        Me.cboPag.Tag = "Pagamento"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(605, 39)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Valor R$"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnAdd.Location = New System.Drawing.Point(838, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 27)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Adicionar"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.lueConfig)
        Me.GroupControl1.Controls.Add(Me.lblLoja)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 66)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(967, 560)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Relação de Créditos e Débitos"
        '
        'lueConfig
        '
        Me.lueConfig.EnterMoveNextControl = True
        Me.lueConfig.Location = New System.Drawing.Point(651, 1)
        Me.lueConfig.Name = "lueConfig"
        Me.lueConfig.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lueConfig.Properties.Appearance.Options.UseFont = True
        Me.lueConfig.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueConfig.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 52, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueConfig.Properties.DisplayMember = "Descricao"
        Me.lueConfig.Properties.NullText = ""
        Me.lueConfig.Properties.ValueMember = "Codigo"
        Me.lueConfig.Size = New System.Drawing.Size(109, 19)
        Me.lueConfig.TabIndex = 121
        Me.lueConfig.Tag = "Loja"
        '
        'lblLoja
        '
        Me.lblLoja.Location = New System.Drawing.Point(623, 4)
        Me.lblLoja.Name = "lblLoja"
        Me.lblLoja.Size = New System.Drawing.Size(20, 13)
        Me.lblLoja.TabIndex = 122
        Me.lblLoja.Text = "Loja"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.GroupControl2.Controls.Add(Me.btnPadrao)
        Me.GroupControl2.Controls.Add(Me.txtSaldoAtualDinheiro)
        Me.GroupControl2.Controls.Add(Me.btnManter)
        Me.GroupControl2.Controls.Add(Me.lblSaldoDinheiro)
        Me.GroupControl2.Controls.Add(Me.txtSaldoCaixa)
        Me.GroupControl2.Controls.Add(Me.lblSaldo)
        Me.GroupControl2.Controls.Add(Me.btnCalc)
        Me.GroupControl2.Controls.Add(Me.txtCred)
        Me.GroupControl2.Controls.Add(Me.txtDeb)
        Me.GroupControl2.Controls.Add(Me.lblTotalSaldo)
        Me.GroupControl2.Controls.Add(Me.lblCredito)
        Me.GroupControl2.Controls.Add(Me.lblDebito)
        Me.GroupControl2.Controls.Add(Me.txtSaldo)
        Me.GroupControl2.Controls.Add(Me.CaixaGridControl)
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(963, 538)
        Me.GroupControl2.TabIndex = 2
        '
        'btnPadrao
        '
        Me.btnPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPadrao.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnPadrao.Appearance.Options.UseFont = True
        Me.btnPadrao.Enabled = False
        Me.btnPadrao.Location = New System.Drawing.Point(885, 20)
        Me.btnPadrao.Name = "btnPadrao"
        Me.btnPadrao.Size = New System.Drawing.Size(54, 16)
        Me.btnPadrao.TabIndex = 122
        Me.btnPadrao.Text = "Padrão"
        Me.btnPadrao.ToolTip = "Configurações da grid padrão"
        '
        'txtSaldoAtualDinheiro
        '
        Me.txtSaldoAtualDinheiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoAtualDinheiro.EnterMoveNextControl = True
        Me.txtSaldoAtualDinheiro.Location = New System.Drawing.Point(559, 475)
        Me.txtSaldoAtualDinheiro.Name = "txtSaldoAtualDinheiro"
        Me.txtSaldoAtualDinheiro.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtSaldoAtualDinheiro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoAtualDinheiro.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSaldoAtualDinheiro.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoAtualDinheiro.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoAtualDinheiro.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoAtualDinheiro.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoAtualDinheiro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtSaldoAtualDinheiro.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoAtualDinheiro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoAtualDinheiro.Properties.ReadOnly = True
        Me.txtSaldoAtualDinheiro.Size = New System.Drawing.Size(146, 31)
        Me.txtSaldoAtualDinheiro.TabIndex = 28
        Me.txtSaldoAtualDinheiro.Tag = "Valor R$"
        '
        'btnManter
        '
        Me.btnManter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManter.Appearance.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.btnManter.Appearance.Options.UseFont = True
        Me.btnManter.Location = New System.Drawing.Point(885, 5)
        Me.btnManter.Name = "btnManter"
        Me.btnManter.Size = New System.Drawing.Size(54, 16)
        Me.btnManter.TabIndex = 121
        Me.btnManter.Text = "Manter"
        Me.btnManter.ToolTip = "Manter as configurações da grid"
        '
        'lblSaldoDinheiro
        '
        Me.lblSaldoDinheiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSaldoDinheiro.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoDinheiro.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSaldoDinheiro.Appearance.Options.UseFont = True
        Me.lblSaldoDinheiro.Appearance.Options.UseForeColor = True
        Me.lblSaldoDinheiro.Location = New System.Drawing.Point(421, 487)
        Me.lblSaldoDinheiro.Name = "lblSaldoDinheiro"
        Me.lblSaldoDinheiro.Size = New System.Drawing.Size(132, 13)
        Me.lblSaldoDinheiro.TabIndex = 27
        Me.lblSaldoDinheiro.Text = "Saldo Atual Dinheiro R$"
        '
        'txtSaldoCaixa
        '
        Me.txtSaldoCaixa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaldoCaixa.EnterMoveNextControl = True
        Me.txtSaldoCaixa.Location = New System.Drawing.Point(807, 475)
        Me.txtSaldoCaixa.Name = "txtSaldoCaixa"
        Me.txtSaldoCaixa.Properties.Appearance.BackColor = System.Drawing.Color.Blue
        Me.txtSaldoCaixa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCaixa.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtSaldoCaixa.Properties.Appearance.Options.UseBackColor = True
        Me.txtSaldoCaixa.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoCaixa.Properties.Appearance.Options.UseForeColor = True
        Me.txtSaldoCaixa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoCaixa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Blue
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.White
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtSaldoCaixa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoCaixa.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoCaixa.Properties.ReadOnly = True
        Me.txtSaldoCaixa.Size = New System.Drawing.Size(146, 31)
        Me.txtSaldoCaixa.TabIndex = 26
        Me.txtSaldoCaixa.Tag = "Valor R$"
        '
        'lblSaldo
        '
        Me.lblSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSaldo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSaldo.Appearance.Options.UseFont = True
        Me.lblSaldo.Appearance.Options.UseForeColor = True
        Me.lblSaldo.Location = New System.Drawing.Point(716, 487)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(85, 13)
        Me.lblSaldo.TabIndex = 25
        Me.lblSaldo.Text = "Saldo Atual  R$"
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalc.Image = Global.Nano.My.Resources.Resources.Calculator2
        Me.btnCalc.Location = New System.Drawing.Point(62, 508)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(93, 27)
        Me.btnCalc.TabIndex = 14
        Me.btnCalc.Text = "&Calcular"
        '
        'txtCred
        '
        Me.txtCred.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCred.EnterMoveNextControl = True
        Me.txtCred.Location = New System.Drawing.Point(275, 512)
        Me.txtCred.Name = "txtCred"
        Me.txtCred.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCred.Properties.Appearance.Options.UseFont = True
        Me.txtCred.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCred.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCred.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtCred.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCred.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCred.Properties.ReadOnly = True
        Me.txtCred.Size = New System.Drawing.Size(146, 21)
        Me.txtCred.TabIndex = 18
        Me.txtCred.Tag = "Valor R$"
        '
        'txtDeb
        '
        Me.txtDeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDeb.EnterMoveNextControl = True
        Me.txtDeb.Location = New System.Drawing.Point(559, 512)
        Me.txtDeb.Name = "txtDeb"
        Me.txtDeb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeb.Properties.Appearance.Options.UseFont = True
        Me.txtDeb.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDeb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDeb.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtDeb.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtDeb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeb.Properties.ReadOnly = True
        Me.txtDeb.Size = New System.Drawing.Size(146, 21)
        Me.txtDeb.TabIndex = 17
        Me.txtDeb.Tag = "Valor R$"
        '
        'lblTotalSaldo
        '
        Me.lblTotalSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSaldo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSaldo.Appearance.Options.UseFont = True
        Me.lblTotalSaldo.Location = New System.Drawing.Point(752, 516)
        Me.lblTotalSaldo.Name = "lblTotalSaldo"
        Me.lblTotalSaldo.Size = New System.Drawing.Size(49, 13)
        Me.lblTotalSaldo.TabIndex = 16
        Me.lblTotalSaldo.Text = "Saldo R$"
        '
        'lblCredito
        '
        Me.lblCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCredito.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredito.Appearance.Options.UseFont = True
        Me.lblCredito.Location = New System.Drawing.Point(178, 516)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(91, 13)
        Me.lblCredito.TabIndex = 15
        Me.lblCredito.Text = "Total Crédito R$"
        '
        'lblDebito
        '
        Me.lblDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDebito.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebito.Appearance.Options.UseFont = True
        Me.lblDebito.Location = New System.Drawing.Point(466, 516)
        Me.lblDebito.Name = "lblDebito"
        Me.lblDebito.Size = New System.Drawing.Size(87, 13)
        Me.lblDebito.TabIndex = 14
        Me.lblDebito.Text = "Total Débito R$"
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.EnterMoveNextControl = True
        Me.txtSaldo.Location = New System.Drawing.Point(807, 512)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Properties.Appearance.Options.UseFont = True
        Me.txtSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtSaldo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.Properties.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(146, 21)
        Me.txtSaldo.TabIndex = 13
        Me.txtSaldo.Tag = "Valor R$"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbExtrato"
        Me.GridControl1.DataSource = Me.dsCaixa
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(21, 194)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(437, 210)
        Me.GridControl1.TabIndex = 123
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsCaixa
        '
        Me.dsCaixa.DataSetName = "NewDataSet"
        Me.dsCaixa.Tables.AddRange(New System.Data.DataTable() {Me.tbPagamento, Me.tbCaixaSomado, Me.tbExtrato})
        '
        'tbPagamento
        '
        Me.tbPagamento.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.tbPagamento.TableName = "tbPagamento"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Pagamento"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Valor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Credito"
        '
        'tbCaixaSomado
        '
        Me.tbCaixaSomado.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbCaixaSomado.TableName = "tbCaixaSomado"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Caixa"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Pagamento"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Credito"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Valor"
        '
        'tbExtrato
        '
        Me.tbExtrato.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbExtrato.TableName = "tbExtrato"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Motivo"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Pagamento"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Valor"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Credito"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMotivo1, Me.colPagamento1, Me.colValor1, Me.colCredito1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMotivo1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colMotivo1
        '
        Me.colMotivo1.Caption = "Motivo"
        Me.colMotivo1.FieldName = "Motivo"
        Me.colMotivo1.Name = "colMotivo1"
        Me.colMotivo1.Visible = True
        Me.colMotivo1.VisibleIndex = 0
        '
        'colPagamento1
        '
        Me.colPagamento1.Caption = "Pagamento"
        Me.colPagamento1.FieldName = "Pagamento"
        Me.colPagamento1.Name = "colPagamento1"
        Me.colPagamento1.Visible = True
        Me.colPagamento1.VisibleIndex = 1
        '
        'colValor1
        '
        Me.colValor1.Caption = "Valor"
        Me.colValor1.FieldName = "Valor"
        Me.colValor1.Name = "colValor1"
        Me.colValor1.Visible = True
        Me.colValor1.VisibleIndex = 2
        '
        'colCredito1
        '
        Me.colCredito1.Caption = "Credito"
        Me.colCredito1.FieldName = "Credito"
        Me.colCredito1.Name = "colCredito1"
        Me.colCredito1.Visible = True
        Me.colCredito1.VisibleIndex = 3
        '
        'TextEdit2
        '
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(690, 456)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit2.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit2.TabIndex = 12
        Me.TextEdit2.Tag = "Valor R$"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnFechar, Me.btnFilter, Me.dtInicial, Me.dtFinal, Me.btnDelete, Me.bsiVisu, Me.btnRelCaixa, Me.btnRelCust, Me.btnTransferencia, Me.btnRelTotais, Me.btnExtrato})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnDelete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtInicial, "", True, True, True, 141, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.dtFinal, "", True, True, True, 145, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVisu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnTransferencia, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnFechar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnDelete
        '
        Me.btnDelete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.btnDelete.Caption = "&Excluir"
        Me.btnDelete.Glyph = Global.Nano.My.Resources.Resources.delete
        Me.btnDelete.Id = 6
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.dtFinal.Id = 4
        Me.dtFinal.Name = "dtFinal"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnFilter
        '
        Me.btnFilter.Caption = "&Filtrar"
        Me.btnFilter.Glyph = Global.Nano.My.Resources.Resources.Filter
        Me.btnFilter.Id = 1
        Me.btnFilter.Name = "btnFilter"
        '
        'bsiVisu
        '
        Me.bsiVisu.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bsiVisu.Caption = "&Visualizar"
        Me.bsiVisu.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.bsiVisu.Id = 7
        Me.bsiVisu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCaixa), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelCust), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRelTotais), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExtrato)})
        Me.bsiVisu.Name = "bsiVisu"
        '
        'btnRelCaixa
        '
        Me.btnRelCaixa.Caption = "Relatório de Caixa"
        Me.btnRelCaixa.Glyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCaixa.Id = 8
        Me.btnRelCaixa.LargeGlyph = Global.Nano.My.Resources.Resources.viewmag
        Me.btnRelCaixa.Name = "btnRelCaixa"
        '
        'btnRelCust
        '
        Me.btnRelCust.Caption = "Relatório C&ustomizado"
        Me.btnRelCust.Glyph = Global.Nano.My.Resources.Resources.nf
        Me.btnRelCust.Id = 9
        Me.btnRelCust.Name = "btnRelCust"
        '
        'btnRelTotais
        '
        Me.btnRelTotais.Caption = "Relatório T&otais"
        Me.btnRelTotais.Glyph = Global.Nano.My.Resources.Resources.Chart
        Me.btnRelTotais.Id = 12
        Me.btnRelTotais.Name = "btnRelTotais"
        '
        'btnExtrato
        '
        Me.btnExtrato.Caption = "Extrato Caixa"
        Me.btnExtrato.Glyph = Global.Nano.My.Resources.Resources.invoice
        Me.btnExtrato.Id = 13
        Me.btnExtrato.Name = "btnExtrato"
        '
        'btnTransferencia
        '
        Me.btnTransferencia.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnTransferencia.Caption = "&Tranferência Banco"
        Me.btnTransferencia.Glyph = Global.Nano.My.Resources.Resources.randr24x24
        Me.btnTransferencia.Id = 11
        Me.btnTransferencia.Name = "btnTransferencia"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnFechar.Caption = "&Fechar"
        Me.btnFechar.Glyph = Global.Nano.My.Resources.Resources.Comando_Fechar_32x32
        Me.btnFechar.Id = 0
        Me.btnFechar.Name = "btnFechar"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'Timer1
        '
        '
        'CaixaTableAdapter
        '
        Me.CaixaTableAdapter.ClearBeforeFill = True
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Centro Custo"
        '
        'cboCenCus
        '
        Me.cboCenCus.EnterMoveNextControl = True
        Me.cboCenCus.Location = New System.Drawing.Point(82, 36)
        Me.cboCenCus.Name = "cboCenCus"
        Me.cboCenCus.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cboCenCus.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cboCenCus.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboCenCus.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboCenCus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCenCus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboCenCus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCenCus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCenCus.Properties.MaxLength = 25
        Me.cboCenCus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboCenCus.Size = New System.Drawing.Size(168, 20)
        Me.cboCenCus.TabIndex = 3
        Me.cboCenCus.Tag = "Centro de Custo"
        '
        'btnCenCus
        '
        Me.btnCenCus.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCenCus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCenCus.Location = New System.Drawing.Point(250, 36)
        Me.btnCenCus.Name = "btnCenCus"
        Me.btnCenCus.Size = New System.Drawing.Size(20, 20)
        Me.btnCenCus.TabIndex = 119
        Me.btnCenCus.Text = "SimpleButton1"
        '
        'txtVal
        '
        Me.txtVal.CasasDecimais = 2
        Me.txtVal.EnterMoveNextControl = True
        Me.txtVal.Location = New System.Drawing.Point(651, 36)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Numerico = True
        Me.txtVal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVal.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtVal.Size = New System.Drawing.Size(109, 20)
        Me.txtVal.TabIndex = 5
        Me.txtVal.Tag = "Valor R$"
        '
        'btnCadPag
        '
        Me.btnCadPag.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadPag.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadPag.Location = New System.Drawing.Point(531, 36)
        Me.btnCadPag.Name = "btnCadPag"
        Me.btnCadPag.Size = New System.Drawing.Size(20, 20)
        Me.btnCadPag.TabIndex = 120
        Me.btnCadPag.Text = "SimpleButton1"
        '
        'btnCadMotivo
        '
        Me.btnCadMotivo.Image = Global.Nano.My.Resources.Resources.edit_add
        Me.btnCadMotivo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnCadMotivo.Location = New System.Drawing.Point(531, 8)
        Me.btnCadMotivo.Name = "btnCadMotivo"
        Me.btnCadMotivo.Size = New System.Drawing.Size(20, 20)
        Me.btnCadMotivo.TabIndex = 121
        Me.btnCadMotivo.Text = "SimpleButton1"
        '
        'txtMot
        '
        Me.txtMot.EnterMoveNextControl = True
        Me.txtMot.Location = New System.Drawing.Point(82, 8)
        Me.txtMot.Name = "txtMot"
        Me.txtMot.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMot.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMot.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMot.Properties.MaxLength = 255
        Me.txtMot.Size = New System.Drawing.Size(449, 20)
        Me.txtMot.TabIndex = 0
        Me.txtMot.Tag = "Pagamento"
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 662)
        Me.Controls.Add(Me.txtMot)
        Me.Controls.Add(Me.btnCadMotivo)
        Me.Controls.Add(Me.btnCadPag)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.btnCenCus)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cboCenCus)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cboPag)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cboCred)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa"
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNanoCommerce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCaixaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCaixaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.lueConfig.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtSaldoAtualDinheiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoCaixa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCaixaSomado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbExtrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCenCus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CaixaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCred As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPag As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCred As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCredito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDebito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnFechar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents colCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtSaldoCaixa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSaldo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsNanoCommerce As Nano.dsNanoCommerce
    Friend WithEvents CaixaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CaixaTableAdapter As Nano.dsNanoCommerceTableAdapters.CaixaTableAdapter
    Friend WithEvents ConfigBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigTableAdapter As Nano.dsNanoCommerceTableAdapters.ConfigTableAdapter
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCenCus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCenCus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsiVisu As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnRelCaixa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRelCust As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtVal As Campos.NanoCampo
    Friend WithEvents btnCadPag As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTransferencia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtSaldoAtualDinheiro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSaldoDinheiro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPadrao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnManter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsCaixa As System.Data.DataSet
    Friend WithEvents tbPagamento As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents btnRelTotais As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbCaixaSomado As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colComputador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueConfig As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblLoja As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colBandeira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExtrato As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tbExtrato As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMotivo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMot As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnCadMotivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dsCaixaGrid As System.Data.DataSet
    Friend WithEvents tbCaixaGrid As System.Data.DataTable
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
End Class
