<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relInformativo
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
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsInf = New System.Data.DataSet
        Me.tbInf = New System.Data.DataTable
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colJan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFev = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAbr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colJul = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDez = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'colNome
        '
        Me.colNome.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome.AppearanceHeader.Options.UseBackColor = True
        Me.colNome.AppearanceHeader.Options.UseFont = True
        Me.colNome.Caption = "Grupo"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Width = 175
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1})
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 83)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbInf"
        Me.GridControl1.DataSource = Me.dsInf
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1064, 80)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsInf
        '
        Me.dsInf.DataSetName = "NewDataSet"
        Me.dsInf.Tables.AddRange(New System.Data.DataTable() {Me.tbInf})
        '
        'tbInf
        '
        Me.tbInf.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.tbInf.TableName = "tbInf"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Nome"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "2"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "3"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "4"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "5"
        Me.DataColumn6.ColumnName = "5"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "6"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "7"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "8"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "9"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "10"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "11"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "12"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "Periodo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "Grupo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "Fornecedor"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNome, Me.colJan, Me.colFev, Me.colMar, Me.colAbr, Me.colMai, Me.colJun, Me.colJul, Me.colAgo, Me.colSet, Me.colOut, Me.colNov, Me.colDez, Me.colPeriodo, Me.colGrupo, Me.colFornecedor})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colNome
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "PA"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colNome
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "TICKET MÉDIO"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPeriodo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNome, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colJan
        '
        Me.colJan.AppearanceCell.Options.UseTextOptions = True
        Me.colJan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJan.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colJan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colJan.AppearanceHeader.Options.UseBackColor = True
        Me.colJan.AppearanceHeader.Options.UseFont = True
        Me.colJan.Caption = "Jan"
        Me.colJan.FieldName = "1"
        Me.colJan.Name = "colJan"
        Me.colJan.OptionsColumn.ReadOnly = True
        Me.colJan.Visible = True
        Me.colJan.VisibleIndex = 1
        Me.colJan.Width = 81
        '
        'colFev
        '
        Me.colFev.AppearanceCell.Options.UseTextOptions = True
        Me.colFev.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colFev.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFev.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFev.AppearanceHeader.Options.UseBackColor = True
        Me.colFev.AppearanceHeader.Options.UseFont = True
        Me.colFev.Caption = "Fev"
        Me.colFev.FieldName = "2"
        Me.colFev.Name = "colFev"
        Me.colFev.OptionsColumn.ReadOnly = True
        Me.colFev.Visible = True
        Me.colFev.VisibleIndex = 2
        Me.colFev.Width = 81
        '
        'colMar
        '
        Me.colMar.AppearanceCell.Options.UseTextOptions = True
        Me.colMar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMar.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colMar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMar.AppearanceHeader.Options.UseBackColor = True
        Me.colMar.AppearanceHeader.Options.UseFont = True
        Me.colMar.Caption = "Mar"
        Me.colMar.FieldName = "3"
        Me.colMar.Name = "colMar"
        Me.colMar.OptionsColumn.ReadOnly = True
        Me.colMar.Visible = True
        Me.colMar.VisibleIndex = 3
        Me.colMar.Width = 81
        '
        'colAbr
        '
        Me.colAbr.AppearanceCell.Options.UseTextOptions = True
        Me.colAbr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAbr.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colAbr.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAbr.AppearanceHeader.Options.UseBackColor = True
        Me.colAbr.AppearanceHeader.Options.UseFont = True
        Me.colAbr.Caption = "Abr"
        Me.colAbr.FieldName = "4"
        Me.colAbr.Name = "colAbr"
        Me.colAbr.OptionsColumn.ReadOnly = True
        Me.colAbr.Visible = True
        Me.colAbr.VisibleIndex = 4
        Me.colAbr.Width = 81
        '
        'colMai
        '
        Me.colMai.AppearanceCell.Options.UseTextOptions = True
        Me.colMai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMai.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colMai.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMai.AppearanceHeader.Options.UseBackColor = True
        Me.colMai.AppearanceHeader.Options.UseFont = True
        Me.colMai.Caption = "Mai"
        Me.colMai.FieldName = "5"
        Me.colMai.Name = "colMai"
        Me.colMai.OptionsColumn.ReadOnly = True
        Me.colMai.Visible = True
        Me.colMai.VisibleIndex = 5
        Me.colMai.Width = 81
        '
        'colJun
        '
        Me.colJun.AppearanceCell.Options.UseTextOptions = True
        Me.colJun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJun.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colJun.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colJun.AppearanceHeader.Options.UseBackColor = True
        Me.colJun.AppearanceHeader.Options.UseFont = True
        Me.colJun.Caption = "Jun"
        Me.colJun.FieldName = "6"
        Me.colJun.Name = "colJun"
        Me.colJun.OptionsColumn.ReadOnly = True
        Me.colJun.Visible = True
        Me.colJun.VisibleIndex = 6
        Me.colJun.Width = 81
        '
        'colJul
        '
        Me.colJul.AppearanceCell.Options.UseTextOptions = True
        Me.colJul.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colJul.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colJul.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colJul.AppearanceHeader.Options.UseBackColor = True
        Me.colJul.AppearanceHeader.Options.UseFont = True
        Me.colJul.Caption = "Jul"
        Me.colJul.FieldName = "7"
        Me.colJul.Name = "colJul"
        Me.colJul.OptionsColumn.ReadOnly = True
        Me.colJul.Visible = True
        Me.colJul.VisibleIndex = 7
        Me.colJul.Width = 81
        '
        'colAgo
        '
        Me.colAgo.AppearanceCell.Options.UseTextOptions = True
        Me.colAgo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAgo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colAgo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAgo.AppearanceHeader.Options.UseBackColor = True
        Me.colAgo.AppearanceHeader.Options.UseFont = True
        Me.colAgo.Caption = "Ago"
        Me.colAgo.FieldName = "8"
        Me.colAgo.Name = "colAgo"
        Me.colAgo.OptionsColumn.ReadOnly = True
        Me.colAgo.Visible = True
        Me.colAgo.VisibleIndex = 8
        Me.colAgo.Width = 81
        '
        'colSet
        '
        Me.colSet.AppearanceCell.Options.UseTextOptions = True
        Me.colSet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSet.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSet.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSet.AppearanceHeader.Options.UseBackColor = True
        Me.colSet.AppearanceHeader.Options.UseFont = True
        Me.colSet.Caption = "Set"
        Me.colSet.FieldName = "9"
        Me.colSet.Name = "colSet"
        Me.colSet.OptionsColumn.ReadOnly = True
        Me.colSet.Visible = True
        Me.colSet.VisibleIndex = 9
        Me.colSet.Width = 81
        '
        'colOut
        '
        Me.colOut.AppearanceCell.Options.UseTextOptions = True
        Me.colOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOut.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colOut.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOut.AppearanceHeader.Options.UseBackColor = True
        Me.colOut.AppearanceHeader.Options.UseFont = True
        Me.colOut.Caption = "Out"
        Me.colOut.FieldName = "10"
        Me.colOut.Name = "colOut"
        Me.colOut.OptionsColumn.ReadOnly = True
        Me.colOut.Visible = True
        Me.colOut.VisibleIndex = 10
        Me.colOut.Width = 81
        '
        'colNov
        '
        Me.colNov.AppearanceCell.Options.UseTextOptions = True
        Me.colNov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNov.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNov.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNov.AppearanceHeader.Options.UseBackColor = True
        Me.colNov.AppearanceHeader.Options.UseFont = True
        Me.colNov.Caption = "Nov"
        Me.colNov.FieldName = "11"
        Me.colNov.Name = "colNov"
        Me.colNov.OptionsColumn.ReadOnly = True
        Me.colNov.Visible = True
        Me.colNov.VisibleIndex = 11
        Me.colNov.Width = 81
        '
        'colDez
        '
        Me.colDez.AppearanceCell.Options.UseTextOptions = True
        Me.colDez.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDez.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDez.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDez.AppearanceHeader.Options.UseBackColor = True
        Me.colDez.AppearanceHeader.Options.UseFont = True
        Me.colDez.Caption = "Dez"
        Me.colDez.FieldName = "12"
        Me.colDez.Name = "colDez"
        Me.colDez.OptionsColumn.ReadOnly = True
        Me.colDez.Visible = True
        Me.colDez.VisibleIndex = 12
        Me.colDez.Width = 91
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colPeriodo.AppearanceCell.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPeriodo.AppearanceHeader.Options.UseBackColor = True
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.Caption = "Período"
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colGrupo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrupo.AppearanceHeader.Options.UseBackColor = True
        Me.colGrupo.AppearanceHeader.Options.UseFont = True
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFornecedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFornecedor.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.colFornecedor.AppearanceHeader.Options.UseBackColor = True
        Me.colFornecedor.AppearanceHeader.Options.UseFont = True
        Me.colFornecedor.AppearanceHeader.Options.UseForeColor = True
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 0
        Me.colFornecedor.Width = 192
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
        Me.XrLine2.Size = New System.Drawing.Size(1100, 8)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(300, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(767, 25)
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
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(17, 17)
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
        'relInformativo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJul As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDez As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents dsInf As System.Data.DataSet
    Friend WithEvents tbInf As System.Data.DataTable
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
End Class
