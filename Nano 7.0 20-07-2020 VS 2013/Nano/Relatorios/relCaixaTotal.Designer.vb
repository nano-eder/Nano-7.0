<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCaixaTotal
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colCreditoTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCredito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCaixa = New System.Data.DataSet
        Me.tbCaixa = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.tbTotal = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPagamentoTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDebitoTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldoTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCaixaTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.CaixaGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDebito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCaixa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lueLoja = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComputador = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'colCreditoTotal
        '
        Me.colCreditoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colCreditoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCreditoTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCreditoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCreditoTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colCreditoTotal.AppearanceHeader.Options.UseFont = True
        Me.colCreditoTotal.Caption = "Crédito R$"
        Me.colCreditoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCreditoTotal.FieldName = "CreditoTotal"
        Me.colCreditoTotal.GroupFormat.FormatString = "0.00"
        Me.colCreditoTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCreditoTotal.Name = "colCreditoTotal"
        Me.colCreditoTotal.OptionsColumn.ReadOnly = True
        Me.colCreditoTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCreditoTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCreditoTotal.Visible = True
        Me.colCreditoTotal.VisibleIndex = 2
        Me.colCreditoTotal.Width = 270
        '
        'colCredito
        '
        Me.colCredito.AppearanceCell.Options.UseTextOptions = True
        Me.colCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCredito.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCredito.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCredito.AppearanceHeader.Options.UseBackColor = True
        Me.colCredito.AppearanceHeader.Options.UseFont = True
        Me.colCredito.Caption = "Crédito R$"
        Me.colCredito.DisplayFormat.FormatString = "c"
        Me.colCredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCredito.FieldName = "Credito"
        Me.colCredito.GroupFormat.FormatString = "0.00"
        Me.colCredito.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCredito.Name = "colCredito"
        Me.colCredito.OptionsColumn.ReadOnly = True
        Me.colCredito.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCredito.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCredito.Visible = True
        Me.colCredito.VisibleIndex = 2
        Me.colCredito.Width = 273
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer2, Me.WinControlContainer1})
        Me.Detail.Height = 208
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 117)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(750, 83)
        Me.WinControlContainer2.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbTotal"
        Me.GridControl1.DataSource = Me.dsCaixa
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(720, 80)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsCaixa
        '
        Me.dsCaixa.DataSetName = "NewDataSet"
        Me.dsCaixa.Tables.AddRange(New System.Data.DataTable() {Me.tbCaixa, Me.tbTotal})
        '
        'tbCaixa
        '
        Me.tbCaixa.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.tbCaixa.TableName = "tbCaixa"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Caixa"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Pagamento"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Credito"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Debito"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Saldo"
        '
        'tbTotal
        '
        Me.tbTotal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.tbTotal.TableName = "tbTotal"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CaixaTotal"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "PagamentoTotal"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CreditoTotal"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "DebitoTotal"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "SaldoTotal"
        '
        'GridView1
        '
        Me.GridView1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.GridView1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.GridView1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.AppearancePrint.Row.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPagamentoTotal, Me.colCreditoTotal, Me.colDebitoTotal, Me.colSaldoTotal, Me.colCaixaTotal})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Tomato
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCreditoTotal
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "D"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.UsePrintStyles = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPagamentoTotal
        '
        Me.colPagamentoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamentoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamentoTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagamentoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPagamentoTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colPagamentoTotal.AppearanceHeader.Options.UseFont = True
        Me.colPagamentoTotal.Caption = "Pagamento"
        Me.colPagamentoTotal.FieldName = "PagamentoTotal"
        Me.colPagamentoTotal.Name = "colPagamentoTotal"
        Me.colPagamentoTotal.OptionsColumn.ReadOnly = True
        Me.colPagamentoTotal.Visible = True
        Me.colPagamentoTotal.VisibleIndex = 1
        Me.colPagamentoTotal.Width = 276
        '
        'colDebitoTotal
        '
        Me.colDebitoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colDebitoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDebitoTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDebitoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDebitoTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colDebitoTotal.AppearanceHeader.Options.UseFont = True
        Me.colDebitoTotal.Caption = "Débito R$"
        Me.colDebitoTotal.DisplayFormat.FormatString = "c"
        Me.colDebitoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDebitoTotal.FieldName = "DebitoTotal"
        Me.colDebitoTotal.GroupFormat.FormatString = "0.00"
        Me.colDebitoTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDebitoTotal.Name = "colDebitoTotal"
        Me.colDebitoTotal.OptionsColumn.ReadOnly = True
        Me.colDebitoTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDebitoTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDebitoTotal.Visible = True
        Me.colDebitoTotal.VisibleIndex = 3
        Me.colDebitoTotal.Width = 240
        '
        'colSaldoTotal
        '
        Me.colSaldoTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colSaldoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaldoTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSaldoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSaldoTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colSaldoTotal.AppearanceHeader.Options.UseFont = True
        Me.colSaldoTotal.Caption = "Saldo R$"
        Me.colSaldoTotal.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colSaldoTotal.DisplayFormat.FormatString = "c"
        Me.colSaldoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldoTotal.FieldName = "SaldoTotal"
        Me.colSaldoTotal.GroupFormat.FormatString = "0.00"
        Me.colSaldoTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSaldoTotal.Name = "colSaldoTotal"
        Me.colSaldoTotal.OptionsColumn.ReadOnly = True
        Me.colSaldoTotal.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSaldoTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldoTotal.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSaldoTotal.Visible = True
        Me.colSaldoTotal.VisibleIndex = 4
        Me.colSaldoTotal.Width = 199
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemTextEdit1.Mask.EditMask = "0.00"
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colCaixaTotal
        '
        Me.colCaixaTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCaixaTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCaixaTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colCaixaTotal.AppearanceHeader.Options.UseFont = True
        Me.colCaixaTotal.Caption = "Caixa"
        Me.colCaixaTotal.FieldName = "CaixaTotal"
        Me.colCaixaTotal.Name = "colCaixaTotal"
        Me.colCaixaTotal.OptionsColumn.ReadOnly = True
        Me.colCaixaTotal.Visible = True
        Me.colCaixaTotal.VisibleIndex = 0
        Me.colCaixaTotal.Width = 189
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 50, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Codigo"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Codigo"
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(750, 92)
        Me.WinControlContainer1.WinControl = Me.CaixaGridControl
        '
        'CaixaGridControl
        '
        Me.CaixaGridControl.DataMember = "tbCaixa"
        Me.CaixaGridControl.DataSource = Me.dsCaixa
        Me.CaixaGridControl.EmbeddedNavigator.Name = ""
        Me.CaixaGridControl.Location = New System.Drawing.Point(2, 2)
        Me.CaixaGridControl.MainView = Me.grd1
        Me.CaixaGridControl.Name = "CaixaGridControl"
        Me.CaixaGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtValor, Me.lueLoja})
        Me.CaixaGridControl.Size = New System.Drawing.Size(720, 88)
        Me.CaixaGridControl.TabIndex = 1
        Me.CaixaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'grd1
        '
        Me.grd1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grd1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grd1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupRow.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupRow.Options.UseFont = True
        Me.grd1.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDebito, Me.colCredito, Me.colPagamento, Me.colSaldo, Me.colCaixa, Me.colCodConfig, Me.colCentroCusto, Me.colComputador})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Tomato
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colCredito
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "D"
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.grd1.GridControl = Me.CaixaGridControl
        Me.grd1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", Me.colSaldo, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito", Me.colCredito, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito", Me.colDebito, "{0:c}")})
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsPrint.UsePrintStyles = True
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colDebito
        '
        Me.colDebito.AppearanceCell.Options.UseTextOptions = True
        Me.colDebito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDebito.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDebito.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDebito.AppearanceHeader.Options.UseBackColor = True
        Me.colDebito.AppearanceHeader.Options.UseFont = True
        Me.colDebito.Caption = "Débito R$"
        Me.colDebito.DisplayFormat.FormatString = "c"
        Me.colDebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDebito.FieldName = "Debito"
        Me.colDebito.GroupFormat.FormatString = "0.00"
        Me.colDebito.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDebito.Name = "colDebito"
        Me.colDebito.OptionsColumn.ReadOnly = True
        Me.colDebito.SummaryItem.DisplayFormat = "{0:c}"
        Me.colDebito.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDebito.Visible = True
        Me.colDebito.VisibleIndex = 3
        Me.colDebito.Width = 236
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagamento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPagamento.AppearanceHeader.Options.UseBackColor = True
        Me.colPagamento.AppearanceHeader.Options.UseFont = True
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.OptionsColumn.ReadOnly = True
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 1
        Me.colPagamento.Width = 276
        '
        'colSaldo
        '
        Me.colSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaldo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSaldo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSaldo.AppearanceHeader.Options.UseBackColor = True
        Me.colSaldo.AppearanceHeader.Options.UseFont = True
        Me.colSaldo.Caption = "Saldo R$"
        Me.colSaldo.ColumnEdit = Me.txtValor
        Me.colSaldo.DisplayFormat.FormatString = "c"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.GroupFormat.FormatString = "0.00"
        Me.colSaldo.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.ReadOnly = True
        Me.colSaldo.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSaldo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldo.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 200
        '
        'txtValor
        '
        Me.txtValor.AutoHeight = False
        Me.txtValor.DisplayFormat.FormatString = "0.00"
        Me.txtValor.Mask.EditMask = "0.00"
        Me.txtValor.Name = "txtValor"
        '
        'colCaixa
        '
        Me.colCaixa.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCaixa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCaixa.AppearanceHeader.Options.UseBackColor = True
        Me.colCaixa.AppearanceHeader.Options.UseFont = True
        Me.colCaixa.Caption = "Caixa"
        Me.colCaixa.FieldName = "Caixa"
        Me.colCaixa.Name = "colCaixa"
        Me.colCaixa.OptionsColumn.ReadOnly = True
        Me.colCaixa.Visible = True
        Me.colCaixa.VisibleIndex = 0
        Me.colCaixa.Width = 189
        '
        'colCodConfig
        '
        Me.colCodConfig.AppearanceCell.Options.UseTextOptions = True
        Me.colCodConfig.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodConfig.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodConfig.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodConfig.AppearanceHeader.Options.UseBackColor = True
        Me.colCodConfig.AppearanceHeader.Options.UseFont = True
        Me.colCodConfig.Caption = "Cód. Loja"
        Me.colCodConfig.ColumnEdit = Me.lueLoja
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Width = 103
        '
        'lueLoja
        '
        Me.lueLoja.AutoHeight = False
        Me.lueLoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoja.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código", 50, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descricao", "Descrição", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.lueLoja.DisplayMember = "Codigo"
        Me.lueLoja.Name = "lueLoja"
        Me.lueLoja.NullText = ""
        Me.lueLoja.ValueMember = "Codigo"
        '
        'colCentroCusto
        '
        Me.colCentroCusto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCentroCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCentroCusto.AppearanceHeader.Options.UseBackColor = True
        Me.colCentroCusto.AppearanceHeader.Options.UseFont = True
        Me.colCentroCusto.Caption = "Centro Custo"
        Me.colCentroCusto.FieldName = "CentroCusto"
        Me.colCentroCusto.Name = "colCentroCusto"
        Me.colCentroCusto.OptionsColumn.ReadOnly = True
        Me.colCentroCusto.Width = 157
        '
        'colComputador
        '
        Me.colComputador.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colComputador.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colComputador.AppearanceHeader.Options.UseBackColor = True
        Me.colComputador.AppearanceHeader.Options.UseFont = True
        Me.colComputador.Caption = "Computador"
        Me.colComputador.FieldName = "Auxiliar"
        Me.colComputador.Name = "colComputador"
        Me.colComputador.OptionsColumn.ReadOnly = True
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.lblTitulo, Me.XrLine3, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(8, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(750, 8)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(533, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Caixa"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(8, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(750, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(8, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 65)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.picLogo.StylePriority.UseBorderColor = False
        Me.picLogo.StylePriority.UseBorders = False
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relCaixaTotal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents CaixaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCaixa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueLoja As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComputador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsCaixa As System.Data.DataSet
    Friend WithEvents tbCaixa As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPagamentoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreditoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebitoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCaixaTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tbTotal As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
End Class
