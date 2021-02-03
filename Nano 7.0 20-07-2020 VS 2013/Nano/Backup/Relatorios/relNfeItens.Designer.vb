<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relNfeItens
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
        Me.lblQtde = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblProd = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblICMS = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblST = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblIPI = New DevExpress.XtraReports.UI.XRTableCell
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.ItensNfeGridControl = New DevExpress.XtraGrid.GridControl
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
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodBarra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVUnCom = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValICMSST = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCSTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVCalcCred = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumNF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.WinControlContainer1})
        Me.Detail.Height = 209
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Location = New System.Drawing.Point(867, 92)
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
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.lblQtde})
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
        Me.XrTableCell1.Text = "Qtde Total"
        '
        'lblQtde
        '
        Me.lblQtde.Location = New System.Drawing.Point(117, 0)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQtde.Size = New System.Drawing.Size(116, 20)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.lblProd})
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
        Me.XrTableCell2.Text = "Total Prod R$"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblProd
        '
        Me.lblProd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.Location = New System.Drawing.Point(117, 0)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblProd.Size = New System.Drawing.Size(116, 20)
        Me.lblProd.StylePriority.UseFont = False
        Me.lblProd.StylePriority.UseTextAlignment = False
        Me.lblProd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.lblICMS})
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
        Me.XrTableCell3.Text = "Total ICMS R$"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblICMS
        '
        Me.lblICMS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblICMS.Location = New System.Drawing.Point(117, 0)
        Me.lblICMS.Name = "lblICMS"
        Me.lblICMS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblICMS.Size = New System.Drawing.Size(116, 20)
        Me.lblICMS.StylePriority.UseFont = False
        Me.lblICMS.StylePriority.UseTextAlignment = False
        Me.lblICMS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.lblST})
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
        Me.XrTableCell7.Text = "Total ST R$"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblST
        '
        Me.lblST.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblST.Location = New System.Drawing.Point(117, 0)
        Me.lblST.Name = "lblST"
        Me.lblST.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblST.Size = New System.Drawing.Size(116, 20)
        Me.lblST.StylePriority.UseFont = False
        Me.lblST.StylePriority.UseTextAlignment = False
        Me.lblST.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.lblIPI})
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
        Me.XrTableCell5.Text = "Total IPI R$"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer1.WinControl = Me.ItensNfeGridControl
        '
        'ItensNfeGridControl
        '
        Me.ItensNfeGridControl.DataMember = "tbItens"
        Me.ItensNfeGridControl.DataSource = Me.dsItens
        Me.ItensNfeGridControl.EmbeddedNavigator.Name = ""
        Me.ItensNfeGridControl.Location = New System.Drawing.Point(2, 2)
        Me.ItensNfeGridControl.MainView = Me.grd1
        Me.ItensNfeGridControl.Name = "ItensNfeGridControl"
        Me.ItensNfeGridControl.Size = New System.Drawing.Size(1064, 72)
        Me.ItensNfeGridControl.TabIndex = 0
        Me.ItensNfeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsItens
        '
        Me.dsItens.DataSetName = "NewDataSet"
        Me.dsItens.Tables.AddRange(New System.Data.DataTable() {Me.tbItens})
        '
        'tbItens
        '
        Me.tbItens.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.tbItens.TableName = "tbItens"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NumNF"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Data"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CodInterno"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Produto"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "QCom"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "VUnCom"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "VProd"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CSTICMS"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValICMS"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ValICMSST"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CSTIPI"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ValIPI"
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colCodInterno, Me.colCodBarra, Me.colProduto, Me.colQCom, Me.colVUnCom, Me.colVProd, Me.colCSTICMS, Me.colValICMS, Me.colValICMSST, Me.colCSTIPI, Me.colValIPI, Me.colVCalcCred, Me.colNumNF, Me.colData})
        Me.grd1.GridControl = Me.ItensNfeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceHeader.Options.UseBackColor = True
        Me.colCodProd.AppearanceHeader.Options.UseFont = True
        Me.colCodProd.Caption = "CodProd"
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        '
        'colCodInterno
        '
        Me.colCodInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodInterno.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodInterno.AppearanceHeader.Options.UseBackColor = True
        Me.colCodInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodInterno.Caption = "Cód. Prod."
        Me.colCodInterno.FieldName = "CodInterno"
        Me.colCodInterno.Name = "colCodInterno"
        Me.colCodInterno.OptionsColumn.ReadOnly = True
        Me.colCodInterno.Visible = True
        Me.colCodInterno.VisibleIndex = 2
        Me.colCodInterno.Width = 74
        '
        'colCodBarra
        '
        Me.colCodBarra.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodBarra.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodBarra.AppearanceHeader.Options.UseBackColor = True
        Me.colCodBarra.AppearanceHeader.Options.UseFont = True
        Me.colCodBarra.Caption = "Cód. Barra"
        Me.colCodBarra.FieldName = "CodBarra"
        Me.colCodBarra.Name = "colCodBarra"
        Me.colCodBarra.OptionsColumn.ReadOnly = True
        Me.colCodBarra.Width = 80
        '
        'colProduto
        '
        Me.colProduto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colProduto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colProduto.AppearanceHeader.Options.UseBackColor = True
        Me.colProduto.AppearanceHeader.Options.UseFont = True
        Me.colProduto.Caption = "Produto"
        Me.colProduto.FieldName = "Produto"
        Me.colProduto.Name = "colProduto"
        Me.colProduto.OptionsColumn.ReadOnly = True
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 3
        Me.colProduto.Width = 224
        '
        'colQCom
        '
        Me.colQCom.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQCom.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQCom.AppearanceHeader.Options.UseBackColor = True
        Me.colQCom.AppearanceHeader.Options.UseFont = True
        Me.colQCom.Caption = "Qtde"
        Me.colQCom.FieldName = "QCom"
        Me.colQCom.Name = "colQCom"
        Me.colQCom.OptionsColumn.ReadOnly = True
        Me.colQCom.Visible = True
        Me.colQCom.VisibleIndex = 4
        Me.colQCom.Width = 50
        '
        'colVUnCom
        '
        Me.colVUnCom.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVUnCom.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVUnCom.AppearanceHeader.Options.UseBackColor = True
        Me.colVUnCom.AppearanceHeader.Options.UseFont = True
        Me.colVUnCom.Caption = "V. Unit. R$"
        Me.colVUnCom.FieldName = "VUnCom"
        Me.colVUnCom.Name = "colVUnCom"
        Me.colVUnCom.OptionsColumn.ReadOnly = True
        Me.colVUnCom.Visible = True
        Me.colVUnCom.VisibleIndex = 5
        Me.colVUnCom.Width = 74
        '
        'colVProd
        '
        Me.colVProd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVProd.AppearanceHeader.Options.UseBackColor = True
        Me.colVProd.AppearanceHeader.Options.UseFont = True
        Me.colVProd.Caption = "V. Total R$"
        Me.colVProd.FieldName = "VProd"
        Me.colVProd.Name = "colVProd"
        Me.colVProd.OptionsColumn.ReadOnly = True
        Me.colVProd.Visible = True
        Me.colVProd.VisibleIndex = 6
        '
        'colCSTICMS
        '
        Me.colCSTICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTICMS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCSTICMS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCSTICMS.AppearanceHeader.Options.UseBackColor = True
        Me.colCSTICMS.AppearanceHeader.Options.UseFont = True
        Me.colCSTICMS.Caption = "CST ICMS"
        Me.colCSTICMS.FieldName = "CSTICMS"
        Me.colCSTICMS.Name = "colCSTICMS"
        Me.colCSTICMS.OptionsColumn.ReadOnly = True
        Me.colCSTICMS.Visible = True
        Me.colCSTICMS.VisibleIndex = 7
        Me.colCSTICMS.Width = 69
        '
        'colValICMS
        '
        Me.colValICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValICMS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValICMS.AppearanceHeader.Options.UseBackColor = True
        Me.colValICMS.AppearanceHeader.Options.UseFont = True
        Me.colValICMS.Caption = "V. ICMS R$"
        Me.colValICMS.FieldName = "ValICMS"
        Me.colValICMS.Name = "colValICMS"
        Me.colValICMS.OptionsColumn.ReadOnly = True
        Me.colValICMS.Visible = True
        Me.colValICMS.VisibleIndex = 8
        Me.colValICMS.Width = 76
        '
        'colValICMSST
        '
        Me.colValICMSST.AppearanceCell.Options.UseTextOptions = True
        Me.colValICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValICMSST.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValICMSST.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValICMSST.AppearanceHeader.Options.UseBackColor = True
        Me.colValICMSST.AppearanceHeader.Options.UseFont = True
        Me.colValICMSST.Caption = "V. ST R$"
        Me.colValICMSST.FieldName = "ValICMSST"
        Me.colValICMSST.Name = "colValICMSST"
        Me.colValICMSST.OptionsColumn.ReadOnly = True
        Me.colValICMSST.Visible = True
        Me.colValICMSST.VisibleIndex = 9
        Me.colValICMSST.Width = 63
        '
        'colCSTIPI
        '
        Me.colCSTIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colCSTIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCSTIPI.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCSTIPI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCSTIPI.AppearanceHeader.Options.UseBackColor = True
        Me.colCSTIPI.AppearanceHeader.Options.UseFont = True
        Me.colCSTIPI.Caption = "CST IPI"
        Me.colCSTIPI.FieldName = "CSTIPI"
        Me.colCSTIPI.Name = "colCSTIPI"
        Me.colCSTIPI.OptionsColumn.ReadOnly = True
        Me.colCSTIPI.Visible = True
        Me.colCSTIPI.VisibleIndex = 10
        Me.colCSTIPI.Width = 58
        '
        'colValIPI
        '
        Me.colValIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colValIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValIPI.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValIPI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValIPI.AppearanceHeader.Options.UseBackColor = True
        Me.colValIPI.AppearanceHeader.Options.UseFont = True
        Me.colValIPI.Caption = "V. IPI R$"
        Me.colValIPI.FieldName = "ValIPI"
        Me.colValIPI.Name = "colValIPI"
        Me.colValIPI.OptionsColumn.ReadOnly = True
        Me.colValIPI.Visible = True
        Me.colValIPI.VisibleIndex = 11
        Me.colValIPI.Width = 63
        '
        'colVCalcCred
        '
        Me.colVCalcCred.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVCalcCred.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVCalcCred.AppearanceHeader.Options.UseBackColor = True
        Me.colVCalcCred.AppearanceHeader.Options.UseFont = True
        Me.colVCalcCred.Caption = "VCalcCred"
        Me.colVCalcCred.FieldName = "VCalcCred"
        Me.colVCalcCred.Name = "colVCalcCred"
        Me.colVCalcCred.OptionsColumn.ReadOnly = True
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
        Me.colNumNF.Width = 81
        '
        'colData
        '
        Me.colData.AppearanceCell.Options.UseTextOptions = True
        Me.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colData.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colData.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colData.AppearanceHeader.Options.UseBackColor = True
        Me.colData.AppearanceHeader.Options.UseFont = True
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsColumn.ReadOnly = True
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
        Me.colData.Width = 76
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.lblTitulo, Me.picLogo, Me.XrLine3})
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
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1108, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relNfeItens
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
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbItens, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ItensNfeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodBarra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVUnCom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValICMSST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCSTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVCalcCred As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumNF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblQtde As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblProd As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblICMS As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblST As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblIPI As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
End Class
