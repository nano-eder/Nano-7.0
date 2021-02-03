<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relNfetotal
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblICMS = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblST = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblProd = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblIPI = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblNF = New DevExpress.XtraReports.UI.XRTableCell
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.TotalNfeGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsTotal = New System.Data.DataSet
        Me.tbTotal = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChave = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodCli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNatOp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSerie = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodVenda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalNfeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.WinControlContainer1})
        Me.Detail.Height = 206
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Location = New System.Drawing.Point(867, 100)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow5, Me.XrTableRow4})
        Me.XrTable1.Size = New System.Drawing.Size(233, 100)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.lblICMS})
        Me.XrTableRow1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(233, 20)
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.StylePriority.UseTextAlignment = False
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Size = New System.Drawing.Size(117, 20)
        Me.XrTableCell1.Text = "Total ICMS R$"
        '
        'lblICMS
        '
        Me.lblICMS.Location = New System.Drawing.Point(117, 0)
        Me.lblICMS.Name = "lblICMS"
        Me.lblICMS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblICMS.Size = New System.Drawing.Size(116, 20)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.lblST})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(233, 20)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Size = New System.Drawing.Size(117, 20)
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Total ST R$"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblST
        '
        Me.lblST.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblST.Location = New System.Drawing.Point(117, 0)
        Me.lblST.Name = "lblST"
        Me.lblST.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblST.Size = New System.Drawing.Size(116, 20)
        Me.lblST.StylePriority.UseFont = False
        Me.lblST.StylePriority.UseTextAlignment = False
        Me.lblST.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.lblProd})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(233, 20)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Size = New System.Drawing.Size(117, 20)
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Total Prod. R$"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblProd
        '
        Me.lblProd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblProd.Location = New System.Drawing.Point(117, 0)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblProd.Size = New System.Drawing.Size(116, 20)
        Me.lblProd.StylePriority.UseFont = False
        Me.lblProd.StylePriority.UseTextAlignment = False
        Me.lblProd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.lblIPI})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(233, 20)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.Size = New System.Drawing.Size(117, 20)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Total IPI R$"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblIPI
        '
        Me.lblIPI.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblIPI.Location = New System.Drawing.Point(117, 0)
        Me.lblIPI.Name = "lblIPI"
        Me.lblIPI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblIPI.Size = New System.Drawing.Size(116, 20)
        Me.lblIPI.StylePriority.UseFont = False
        Me.lblIPI.StylePriority.UseTextAlignment = False
        Me.lblIPI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.lblNF})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(233, 20)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.Size = New System.Drawing.Size(117, 20)
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Total NF R$"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblNF
        '
        Me.lblNF.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblNF.Location = New System.Drawing.Point(117, 0)
        Me.lblNF.Name = "lblNF"
        Me.lblNF.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNF.Size = New System.Drawing.Size(116, 20)
        Me.lblNF.StylePriority.UseFont = False
        Me.lblNF.StylePriority.UseTextAlignment = False
        Me.lblNF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 83)
        Me.WinControlContainer1.WinControl = Me.TotalNfeGridControl
        '
        'TotalNfeGridControl
        '
        Me.TotalNfeGridControl.DataMember = "tbTotal"
        Me.TotalNfeGridControl.DataSource = Me.dsTotal
        Me.TotalNfeGridControl.EmbeddedNavigator.Name = ""
        Me.TotalNfeGridControl.Location = New System.Drawing.Point(2, 2)
        Me.TotalNfeGridControl.MainView = Me.grd1
        Me.TotalNfeGridControl.Name = "TotalNfeGridControl"
        Me.TotalNfeGridControl.Size = New System.Drawing.Size(1064, 80)
        Me.TotalNfeGridControl.TabIndex = 0
        Me.TotalNfeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsTotal
        '
        Me.dsTotal.DataSetName = "NewDataSet"
        Me.dsTotal.Tables.AddRange(New System.Data.DataTable() {Me.tbTotal})
        '
        'tbTotal
        '
        Me.tbTotal.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.tbTotal.TableName = "tbTotal"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NumNF"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DEmi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Chave"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Cliente"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "VICMS"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "VST"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "VProd"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "VIPI"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "VNF"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "NatOp"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodNF"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Serie"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "CodVenda"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumNF, Me.colChave, Me.colDEmi, Me.colCodCli, Me.colVICMS, Me.colVST, Me.colVProd, Me.colVIPI, Me.colVNF, Me.colCliente, Me.colNatOp, Me.colCodNF, Me.colSerie, Me.colCodVenda})
        Me.grd1.GridControl = Me.TotalNfeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colNumNF
        '
        Me.colNumNF.AppearanceCell.Options.UseTextOptions = True
        Me.colNumNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumNF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumNF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumNF.AppearanceHeader.Options.UseBackColor = True
        Me.colNumNF.AppearanceHeader.Options.UseFont = True
        Me.colNumNF.Caption = "Nº NF"
        Me.colNumNF.FieldName = "NumNF"
        Me.colNumNF.Name = "colNumNF"
        Me.colNumNF.OptionsColumn.ReadOnly = True
        Me.colNumNF.Visible = True
        Me.colNumNF.VisibleIndex = 0
        Me.colNumNF.Width = 74
        '
        'colChave
        '
        Me.colChave.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colChave.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colChave.AppearanceHeader.Options.UseBackColor = True
        Me.colChave.AppearanceHeader.Options.UseFont = True
        Me.colChave.Caption = "Chave"
        Me.colChave.FieldName = "Chave"
        Me.colChave.Name = "colChave"
        Me.colChave.OptionsColumn.ReadOnly = True
        Me.colChave.Width = 244
        '
        'colDEmi
        '
        Me.colDEmi.AppearanceCell.Options.UseTextOptions = True
        Me.colDEmi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDEmi.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDEmi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDEmi.AppearanceHeader.Options.UseBackColor = True
        Me.colDEmi.AppearanceHeader.Options.UseFont = True
        Me.colDEmi.Caption = "Data"
        Me.colDEmi.FieldName = "DEmi"
        Me.colDEmi.Name = "colDEmi"
        Me.colDEmi.OptionsColumn.ReadOnly = True
        Me.colDEmi.Visible = True
        Me.colDEmi.VisibleIndex = 1
        Me.colDEmi.Width = 81
        '
        'colCodCli
        '
        Me.colCodCli.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodCli.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodCli.AppearanceHeader.Options.UseBackColor = True
        Me.colCodCli.AppearanceHeader.Options.UseFont = True
        Me.colCodCli.Caption = "CodCli"
        Me.colCodCli.FieldName = "CodCli"
        Me.colCodCli.Name = "colCodCli"
        Me.colCodCli.OptionsColumn.ReadOnly = True
        Me.colCodCli.Width = 124
        '
        'colVICMS
        '
        Me.colVICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colVICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVICMS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVICMS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVICMS.AppearanceHeader.Options.UseBackColor = True
        Me.colVICMS.AppearanceHeader.Options.UseFont = True
        Me.colVICMS.Caption = "Val. ICMS R$"
        Me.colVICMS.FieldName = "VICMS"
        Me.colVICMS.Name = "colVICMS"
        Me.colVICMS.OptionsColumn.ReadOnly = True
        Me.colVICMS.SummaryItem.DisplayFormat = "{0:c}"
        Me.colVICMS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colVICMS.Visible = True
        Me.colVICMS.VisibleIndex = 5
        Me.colVICMS.Width = 92
        '
        'colVST
        '
        Me.colVST.AppearanceCell.Options.UseTextOptions = True
        Me.colVST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVST.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVST.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVST.AppearanceHeader.Options.UseBackColor = True
        Me.colVST.AppearanceHeader.Options.UseFont = True
        Me.colVST.Caption = "Val. ST R$"
        Me.colVST.FieldName = "VST"
        Me.colVST.Name = "colVST"
        Me.colVST.OptionsColumn.ReadOnly = True
        Me.colVST.Visible = True
        Me.colVST.VisibleIndex = 6
        Me.colVST.Width = 77
        '
        'colVProd
        '
        Me.colVProd.AppearanceCell.Options.UseTextOptions = True
        Me.colVProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVProd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVProd.AppearanceHeader.Options.UseBackColor = True
        Me.colVProd.AppearanceHeader.Options.UseFont = True
        Me.colVProd.Caption = "Val. Prod. R$"
        Me.colVProd.FieldName = "VProd"
        Me.colVProd.Name = "colVProd"
        Me.colVProd.OptionsColumn.ReadOnly = True
        Me.colVProd.Visible = True
        Me.colVProd.VisibleIndex = 7
        Me.colVProd.Width = 92
        '
        'colVIPI
        '
        Me.colVIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colVIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVIPI.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVIPI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVIPI.AppearanceHeader.Options.UseBackColor = True
        Me.colVIPI.AppearanceHeader.Options.UseFont = True
        Me.colVIPI.Caption = "Val. IPI R$"
        Me.colVIPI.FieldName = "VIPI"
        Me.colVIPI.Name = "colVIPI"
        Me.colVIPI.OptionsColumn.ReadOnly = True
        Me.colVIPI.Visible = True
        Me.colVIPI.VisibleIndex = 8
        Me.colVIPI.Width = 78
        '
        'colVNF
        '
        Me.colVNF.AppearanceCell.Options.UseTextOptions = True
        Me.colVNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVNF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVNF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVNF.AppearanceHeader.Options.UseBackColor = True
        Me.colVNF.AppearanceHeader.Options.UseFont = True
        Me.colVNF.Caption = "Val. NF R$"
        Me.colVNF.FieldName = "VNF"
        Me.colVNF.Name = "colVNF"
        Me.colVNF.OptionsColumn.ReadOnly = True
        Me.colVNF.Visible = True
        Me.colVNF.VisibleIndex = 9
        Me.colVNF.Width = 81
        '
        'colCliente
        '
        Me.colCliente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCliente.AppearanceHeader.Options.UseBackColor = True
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.Caption = "Cliente"
        Me.colCliente.FieldName = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.ReadOnly = True
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 4
        Me.colCliente.Width = 218
        '
        'colNatOp
        '
        Me.colNatOp.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNatOp.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNatOp.AppearanceHeader.Options.UseBackColor = True
        Me.colNatOp.AppearanceHeader.Options.UseFont = True
        Me.colNatOp.Caption = "Nat. Op."
        Me.colNatOp.FieldName = "NatOp"
        Me.colNatOp.Name = "colNatOp"
        Me.colNatOp.Visible = True
        Me.colNatOp.VisibleIndex = 10
        Me.colNatOp.Width = 79
        '
        'colCodNF
        '
        Me.colCodNF.AppearanceCell.Options.UseTextOptions = True
        Me.colCodNF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodNF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodNF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodNF.AppearanceHeader.Options.UseBackColor = True
        Me.colCodNF.AppearanceHeader.Options.UseFont = True
        Me.colCodNF.Caption = "Cód. NF"
        Me.colCodNF.FieldName = "CodNF"
        Me.colCodNF.Name = "colCodNF"
        Me.colCodNF.Visible = True
        Me.colCodNF.VisibleIndex = 3
        Me.colCodNF.Width = 74
        '
        'colSerie
        '
        Me.colSerie.AppearanceCell.Options.UseTextOptions = True
        Me.colSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSerie.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSerie.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSerie.AppearanceHeader.Options.UseBackColor = True
        Me.colSerie.AppearanceHeader.Options.UseFont = True
        Me.colSerie.Caption = "Série"
        Me.colSerie.FieldName = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.Visible = True
        Me.colSerie.VisibleIndex = 2
        Me.colSerie.Width = 59
        '
        'colCodVenda
        '
        Me.colCodVenda.AppearanceCell.Options.UseTextOptions = True
        Me.colCodVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodVenda.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodVenda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodVenda.AppearanceHeader.Options.UseBackColor = True
        Me.colCodVenda.AppearanceHeader.Options.UseFont = True
        Me.colCodVenda.Caption = "Cód. Venda"
        Me.colCodVenda.FieldName = "CodVenda"
        Me.colCodVenda.Name = "colCodVenda"
        Me.colCodVenda.Visible = True
        Me.colCodVenda.VisibleIndex = 11
        Me.colCodVenda.Width = 83
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.TotalNfeGridControl
        Me.GridView2.Name = "GridView2"
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
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1108, 8)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(167, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(925, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "lblTitulo"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1108, 8)
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
        'relNfetotal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalNfeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TotalNfeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsTotal As System.Data.DataSet
    Friend WithEvents tbTotal As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodCli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblICMS As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblST As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblProd As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblIPI As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblNF As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colNatOp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents colCodNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerie As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodVenda As DevExpress.XtraGrid.Columns.GridColumn
End Class
