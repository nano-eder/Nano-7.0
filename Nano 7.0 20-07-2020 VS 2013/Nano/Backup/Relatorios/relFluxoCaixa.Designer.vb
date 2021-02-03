<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relFluxoCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relFluxoCaixa))
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.celSado = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.celSaldoAtual = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.dsFluxo = New System.Data.DataSet
        Me.tbFluxo = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCartao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReceber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.lblPeriodo = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsFluxo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFluxo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'colSaldo
        '
        Me.colSaldo.AppearanceCell.Options.UseTextOptions = True
        Me.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSaldo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSaldo.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colSaldo.AppearanceHeader.Options.UseBackColor = True
        Me.colSaldo.AppearanceHeader.Options.UseFont = True
        Me.colSaldo.AppearanceHeader.Options.UseForeColor = True
        Me.colSaldo.Caption = "Saldo Dia R$"
        Me.colSaldo.DisplayFormat.FormatString = "c"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.SummaryItem.DisplayFormat = "{0:c}"
        Me.colSaldo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 259
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrLine1, Me.WinControlContainer1})
        Me.Detail.Height = 198
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.Location = New System.Drawing.Point(483, 142)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.Size = New System.Drawing.Size(275, 50)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.celSado})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(275, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(133, 25)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.Text = "Saldo Bancos R$"
        '
        'celSado
        '
        Me.celSado.Location = New System.Drawing.Point(133, 0)
        Me.celSado.Name = "celSado"
        Me.celSado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.celSado.Size = New System.Drawing.Size(142, 25)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.celSaldoAtual})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(275, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(133, 25)
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.Text = "Saldo Atual Caixa R$"
        '
        'celSaldoAtual
        '
        Me.celSaldoAtual.Location = New System.Drawing.Point(133, 0)
        Me.celSaldoAtual.Name = "celSaldoAtual"
        Me.celSaldoAtual.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.celSaldoAtual.Size = New System.Drawing.Size(142, 25)
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(0, 117)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(758, 10)
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(758, 114)
        Me.WinControlContainer1.WinControl = Me.Grid1
        '
        'Grid1
        '
        Me.Grid1.DataMember = "tbFluxo"
        Me.Grid1.DataSource = Me.dsFluxo
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(2, 2)
        Me.Grid1.MainView = Me.grd1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(728, 109)
        Me.Grid1.TabIndex = 4
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsFluxo
        '
        Me.dsFluxo.DataSetName = "Fluxo"
        Me.dsFluxo.Tables.AddRange(New System.Data.DataTable() {Me.tbFluxo})
        '
        'tbFluxo
        '
        Me.tbFluxo.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.tbFluxo.TableName = "tbFluxo"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Dia"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Cartão"
        Me.DataColumn2.ColumnName = "Cartao"
        Me.DataColumn2.DataType = GetType(Double)
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Conta Receber"
        Me.DataColumn3.ColumnName = "Receber"
        Me.DataColumn3.DataType = GetType(Double)
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Conta Pagar"
        Me.DataColumn4.ColumnName = "Pagar"
        Me.DataColumn4.DataType = GetType(Double)
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Saldo Dia"
        Me.DataColumn5.ColumnName = "Saldo"
        Me.DataColumn5.DataType = GetType(Double)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Data"
        '
        'grd1
        '
        Me.grd1.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.grd1.Appearance.FooterPanel.Options.UseFont = True
        Me.grd1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.grd1.Appearance.GroupFooter.BackColor = System.Drawing.Color.White
        Me.grd1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grd1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.grd1.Appearance.GroupFooter.Options.UseFont = True
        Me.grd1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.grd1.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.grd1.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.grd1.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.White
        Me.grd1.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grd1.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.grd1.AppearancePrint.GroupFooter.Options.UseBackColor = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.grd1.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDia, Me.colCartao, Me.colReceber, Me.colPagar, Me.colSaldo, Me.colData})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lavender
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colSaldo
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.MistyRose
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        StyleFormatCondition2.Appearance.Options.HighPriority = True
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colSaldo
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = 0
        Me.grd1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.grd1.GridControl = Me.Grid1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowFooter = True
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colDia
        '
        Me.colDia.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDia.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colDia.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colDia.AppearanceCell.Options.UseBackColor = True
        Me.colDia.AppearanceCell.Options.UseTextOptions = True
        Me.colDia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDia.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDia.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colDia.AppearanceHeader.Options.UseBackColor = True
        Me.colDia.AppearanceHeader.Options.UseFont = True
        Me.colDia.AppearanceHeader.Options.UseForeColor = True
        Me.colDia.Caption = "Dia"
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.Width = 85
        '
        'colCartao
        '
        Me.colCartao.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.colCartao.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colCartao.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colCartao.AppearanceCell.Options.UseBackColor = True
        Me.colCartao.AppearanceCell.Options.UseTextOptions = True
        Me.colCartao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCartao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCartao.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colCartao.AppearanceHeader.Options.UseBackColor = True
        Me.colCartao.AppearanceHeader.Options.UseFont = True
        Me.colCartao.AppearanceHeader.Options.UseForeColor = True
        Me.colCartao.Caption = "Cartão R$"
        Me.colCartao.DisplayFormat.FormatString = "c"
        Me.colCartao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCartao.FieldName = "Cartao"
        Me.colCartao.Name = "colCartao"
        Me.colCartao.SummaryItem.DisplayFormat = "{0:c}"
        Me.colCartao.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCartao.Visible = True
        Me.colCartao.VisibleIndex = 1
        Me.colCartao.Width = 265
        '
        'colReceber
        '
        Me.colReceber.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.colReceber.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colReceber.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colReceber.AppearanceCell.Options.UseBackColor = True
        Me.colReceber.AppearanceCell.Options.UseTextOptions = True
        Me.colReceber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colReceber.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colReceber.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colReceber.AppearanceHeader.Options.UseBackColor = True
        Me.colReceber.AppearanceHeader.Options.UseFont = True
        Me.colReceber.AppearanceHeader.Options.UseForeColor = True
        Me.colReceber.Caption = "Conta Receber R$"
        Me.colReceber.DisplayFormat.FormatString = "c"
        Me.colReceber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colReceber.FieldName = "Receber"
        Me.colReceber.Name = "colReceber"
        Me.colReceber.SummaryItem.DisplayFormat = "{0:c}"
        Me.colReceber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colReceber.Visible = True
        Me.colReceber.VisibleIndex = 2
        Me.colReceber.Width = 265
        '
        'colPagar
        '
        Me.colPagar.AppearanceCell.BackColor = System.Drawing.Color.MistyRose
        Me.colPagar.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colPagar.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colPagar.AppearanceCell.Options.UseBackColor = True
        Me.colPagar.AppearanceCell.Options.UseTextOptions = True
        Me.colPagar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPagar.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagar.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colPagar.AppearanceHeader.Options.UseBackColor = True
        Me.colPagar.AppearanceHeader.Options.UseFont = True
        Me.colPagar.AppearanceHeader.Options.UseForeColor = True
        Me.colPagar.Caption = "Conta Pagar R$"
        Me.colPagar.DisplayFormat.FormatString = "c"
        Me.colPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPagar.FieldName = "Pagar"
        Me.colPagar.Name = "colPagar"
        Me.colPagar.SummaryItem.DisplayFormat = "{0:c}"
        Me.colPagar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colPagar.Visible = True
        Me.colPagar.VisibleIndex = 3
        Me.colPagar.Width = 265
        '
        'colData
        '
        Me.colData.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colData.AppearanceCell.BackColor2 = System.Drawing.Color.White
        Me.colData.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.colData.AppearanceCell.Options.UseBackColor = True
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseForeColor = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 0
        Me.colData.Width = 120
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPeriodo, Me.XrLine2, Me.lblTitulo, Me.picLogo, Me.XrLine3})
        Me.PageHeader.Height = 110
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 100)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(758, 10)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(158, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(592, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Fluxo de Caixa"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(0, 17)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(150, 75)
        Me.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(758, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(158, 58)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPeriodo.Size = New System.Drawing.Size(592, 25)
        Me.lblPeriodo.StylePriority.UseFont = False
        Me.lblPeriodo.StylePriority.UseTextAlignment = False
        Me.lblPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'relFluxoCaixa
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsFluxo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFluxo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsFluxo As System.Data.DataSet
    Friend WithEvents tbFluxo As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCartao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents celSado As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents celSaldoAtual As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblPeriodo As DevExpress.XtraReports.UI.XRLabel
End Class
