<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relPesquisaImp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relPesquisaImp))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblQtd = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsProduto = New System.Data.DataSet
        Me.tbProd = New System.Data.DataTable
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
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCFOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colICMS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCOFINS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodEnq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.lblQtd, Me.WinControlContainer1})
        Me.Detail.Height = 139
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(575, 100)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Qtd Itens"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblQtd
        '
        Me.lblQtd.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblQtd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblQtd.Location = New System.Drawing.Point(675, 100)
        Me.lblQtd.Name = "lblQtd"
        Me.lblQtd.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblQtd.Size = New System.Drawing.Size(92, 17)
        Me.lblQtd.StylePriority.UseBorders = False
        Me.lblQtd.StylePriority.UseFont = False
        Me.lblQtd.StylePriority.UseTextAlignment = False
        Me.lblQtd.Text = "lblQtd"
        Me.lblQtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(767, 83)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProduto
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(736, 80)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
        '
        'dsProduto
        '
        Me.dsProduto.DataSetName = "NewDataSet"
        Me.dsProduto.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodProd"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Produto"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CFOP"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NCM"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ICMS"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "IPI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "PIS"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "COFINS"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodEnq"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodProd, Me.colProduto, Me.colCFOP, Me.colNCM, Me.colICMS, Me.colIPI, Me.colPIS, Me.colCOFINS, Me.colCodEnq})
        Me.grd1.GridControl = Me.GridControl1
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        '
        'colCodProd
        '
        Me.colCodProd.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodProd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProd.AppearanceHeader.Options.UseBackColor = True
        Me.colCodProd.AppearanceHeader.Options.UseFont = True
        Me.colCodProd.Caption = "Cód. Prod."
        Me.colCodProd.FieldName = "CodProd"
        Me.colCodProd.Name = "colCodProd"
        Me.colCodProd.OptionsColumn.ReadOnly = True
        Me.colCodProd.Visible = True
        Me.colCodProd.VisibleIndex = 0
        Me.colCodProd.Width = 96
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
        Me.colProduto.VisibleIndex = 1
        Me.colProduto.Width = 312
        '
        'colCFOP
        '
        Me.colCFOP.AppearanceCell.Options.UseTextOptions = True
        Me.colCFOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCFOP.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCFOP.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCFOP.AppearanceHeader.Options.UseBackColor = True
        Me.colCFOP.AppearanceHeader.Options.UseFont = True
        Me.colCFOP.Caption = "CFOP"
        Me.colCFOP.FieldName = "CFOP"
        Me.colCFOP.Name = "colCFOP"
        Me.colCFOP.OptionsColumn.ReadOnly = True
        Me.colCFOP.Visible = True
        Me.colCFOP.VisibleIndex = 2
        Me.colCFOP.Width = 72
        '
        'colNCM
        '
        Me.colNCM.AppearanceCell.Options.UseTextOptions = True
        Me.colNCM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNCM.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNCM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNCM.AppearanceHeader.Options.UseBackColor = True
        Me.colNCM.AppearanceHeader.Options.UseFont = True
        Me.colNCM.Caption = "NCM"
        Me.colNCM.FieldName = "NCM"
        Me.colNCM.Name = "colNCM"
        Me.colNCM.OptionsColumn.ReadOnly = True
        Me.colNCM.Visible = True
        Me.colNCM.VisibleIndex = 3
        Me.colNCM.Width = 85
        '
        'colICMS
        '
        Me.colICMS.AppearanceCell.Options.UseTextOptions = True
        Me.colICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colICMS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colICMS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colICMS.AppearanceHeader.Options.UseBackColor = True
        Me.colICMS.AppearanceHeader.Options.UseFont = True
        Me.colICMS.Caption = "CST ICMS"
        Me.colICMS.FieldName = "ICMS"
        Me.colICMS.Name = "colICMS"
        Me.colICMS.OptionsColumn.ReadOnly = True
        Me.colICMS.Visible = True
        Me.colICMS.VisibleIndex = 4
        Me.colICMS.Width = 84
        '
        'colIPI
        '
        Me.colIPI.AppearanceCell.Options.UseTextOptions = True
        Me.colIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIPI.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colIPI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colIPI.AppearanceHeader.Options.UseBackColor = True
        Me.colIPI.AppearanceHeader.Options.UseFont = True
        Me.colIPI.Caption = "CST IPI"
        Me.colIPI.FieldName = "IPI"
        Me.colIPI.Name = "colIPI"
        Me.colIPI.OptionsColumn.ReadOnly = True
        Me.colIPI.Visible = True
        Me.colIPI.VisibleIndex = 5
        Me.colIPI.Width = 83
        '
        'colPIS
        '
        Me.colPIS.AppearanceCell.Options.UseTextOptions = True
        Me.colPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPIS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPIS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPIS.AppearanceHeader.Options.UseBackColor = True
        Me.colPIS.AppearanceHeader.Options.UseFont = True
        Me.colPIS.Caption = "CST PIS"
        Me.colPIS.FieldName = "PIS"
        Me.colPIS.Name = "colPIS"
        Me.colPIS.OptionsColumn.ReadOnly = True
        Me.colPIS.Visible = True
        Me.colPIS.VisibleIndex = 7
        Me.colPIS.Width = 77
        '
        'colCOFINS
        '
        Me.colCOFINS.AppearanceCell.Options.UseTextOptions = True
        Me.colCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCOFINS.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCOFINS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCOFINS.AppearanceHeader.Options.UseBackColor = True
        Me.colCOFINS.AppearanceHeader.Options.UseFont = True
        Me.colCOFINS.Caption = "CST COFINS"
        Me.colCOFINS.FieldName = "COFINS"
        Me.colCOFINS.Name = "colCOFINS"
        Me.colCOFINS.OptionsColumn.ReadOnly = True
        Me.colCOFINS.Visible = True
        Me.colCOFINS.VisibleIndex = 8
        Me.colCOFINS.Width = 86
        '
        'colCodEnq
        '
        Me.colCodEnq.AppearanceCell.Options.UseTextOptions = True
        Me.colCodEnq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodEnq.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodEnq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodEnq.AppearanceHeader.Options.UseBackColor = True
        Me.colCodEnq.AppearanceHeader.Options.UseFont = True
        Me.colCodEnq.Caption = "Cód. Enq."
        Me.colCodEnq.FieldName = "CodEnq"
        Me.colCodEnq.Name = "colCodEnq"
        Me.colCodEnq.OptionsColumn.ReadOnly = True
        Me.colCodEnq.Visible = True
        Me.colCodEnq.VisibleIndex = 6
        Me.colCodEnq.Width = 84
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.lblTitulo, Me.XrLine3, Me.picLogo})
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
        Me.lblTitulo.Location = New System.Drawing.Point(167, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(592, 25)
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
        Me.XrLine3.Size = New System.Drawing.Size(758, 8)
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
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relPesquisaImp
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCFOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colICMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOFINS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodEnq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblQtd As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dsProduto As System.Data.DataSet
    Friend WithEvents tbProd As System.Data.DataTable
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
End Class
