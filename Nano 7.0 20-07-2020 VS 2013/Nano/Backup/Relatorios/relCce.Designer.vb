<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relCce
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
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsCce = New System.Data.DataSet
        Me.tbCce = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVersao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCUF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoAmb = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChave = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHEmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTZD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoEvento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumSeqEvento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCNPJ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescEvento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCorrecao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCondUso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbCce"
        Me.GridControl1.DataSource = Me.dsCce
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.grd1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1064, 72)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsCce
        '
        Me.dsCce.DataSetName = "NewDataSet"
        Me.dsCce.Tables.AddRange(New System.Data.DataTable() {Me.tbCce})
        '
        'tbCce
        '
        Me.tbCce.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.tbCce.TableName = "tbCce"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodOrdem"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DEmi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "HEmi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Correcao"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NumSeqEvento"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colCodOrdem, Me.colVersao, Me.colId, Me.colCUF, Me.colTipoAmb, Me.colChave, Me.colDEmi, Me.colHEmi, Me.colTZD, Me.colTipoEvento, Me.colNumSeqEvento, Me.colCNPJ, Me.colDescEvento, Me.colCorrecao, Me.colCondUso})
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
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodOrdem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodOrdem.AppearanceHeader.Options.UseBackColor = True
        Me.colCodOrdem.AppearanceHeader.Options.UseFont = True
        Me.colCodOrdem.Caption = "Núm. NF"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.OptionsColumn.ReadOnly = True
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 85
        '
        'colVersao
        '
        Me.colVersao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVersao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVersao.AppearanceHeader.Options.UseBackColor = True
        Me.colVersao.AppearanceHeader.Options.UseFont = True
        Me.colVersao.Caption = "Versao"
        Me.colVersao.FieldName = "Versao"
        Me.colVersao.Name = "colVersao"
        '
        'colId
        '
        Me.colId.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colId.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colId.AppearanceHeader.Options.UseBackColor = True
        Me.colId.AppearanceHeader.Options.UseFont = True
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colCUF
        '
        Me.colCUF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCUF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCUF.AppearanceHeader.Options.UseBackColor = True
        Me.colCUF.AppearanceHeader.Options.UseFont = True
        Me.colCUF.Caption = "CUF"
        Me.colCUF.FieldName = "CUF"
        Me.colCUF.Name = "colCUF"
        '
        'colTipoAmb
        '
        Me.colTipoAmb.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoAmb.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoAmb.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoAmb.AppearanceHeader.Options.UseFont = True
        Me.colTipoAmb.Caption = "TipoAmb"
        Me.colTipoAmb.FieldName = "TipoAmb"
        Me.colTipoAmb.Name = "colTipoAmb"
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
        Me.colDEmi.Width = 78
        '
        'colHEmi
        '
        Me.colHEmi.AppearanceCell.Options.UseTextOptions = True
        Me.colHEmi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHEmi.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colHEmi.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colHEmi.AppearanceHeader.Options.UseBackColor = True
        Me.colHEmi.AppearanceHeader.Options.UseFont = True
        Me.colHEmi.Caption = "Hora"
        Me.colHEmi.FieldName = "HEmi"
        Me.colHEmi.Name = "colHEmi"
        Me.colHEmi.OptionsColumn.ReadOnly = True
        Me.colHEmi.Visible = True
        Me.colHEmi.VisibleIndex = 2
        Me.colHEmi.Width = 77
        '
        'colTZD
        '
        Me.colTZD.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTZD.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTZD.AppearanceHeader.Options.UseBackColor = True
        Me.colTZD.AppearanceHeader.Options.UseFont = True
        Me.colTZD.Caption = "TZD"
        Me.colTZD.FieldName = "TZD"
        Me.colTZD.Name = "colTZD"
        '
        'colTipoEvento
        '
        Me.colTipoEvento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoEvento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoEvento.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoEvento.AppearanceHeader.Options.UseFont = True
        Me.colTipoEvento.Caption = "TipoEvento"
        Me.colTipoEvento.FieldName = "TipoEvento"
        Me.colTipoEvento.Name = "colTipoEvento"
        '
        'colNumSeqEvento
        '
        Me.colNumSeqEvento.AppearanceCell.Options.UseTextOptions = True
        Me.colNumSeqEvento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumSeqEvento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumSeqEvento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumSeqEvento.AppearanceHeader.Options.UseBackColor = True
        Me.colNumSeqEvento.AppearanceHeader.Options.UseFont = True
        Me.colNumSeqEvento.Caption = "Núm. Seq."
        Me.colNumSeqEvento.FieldName = "NumSeqEvento"
        Me.colNumSeqEvento.Name = "colNumSeqEvento"
        Me.colNumSeqEvento.OptionsColumn.ReadOnly = True
        Me.colNumSeqEvento.Visible = True
        Me.colNumSeqEvento.VisibleIndex = 4
        Me.colNumSeqEvento.Width = 71
        '
        'colCNPJ
        '
        Me.colCNPJ.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCNPJ.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCNPJ.AppearanceHeader.Options.UseBackColor = True
        Me.colCNPJ.AppearanceHeader.Options.UseFont = True
        Me.colCNPJ.Caption = "CNPJ"
        Me.colCNPJ.FieldName = "CNPJ"
        Me.colCNPJ.Name = "colCNPJ"
        '
        'colDescEvento
        '
        Me.colDescEvento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDescEvento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDescEvento.AppearanceHeader.Options.UseBackColor = True
        Me.colDescEvento.AppearanceHeader.Options.UseFont = True
        Me.colDescEvento.Caption = "DescEvento"
        Me.colDescEvento.FieldName = "DescEvento"
        Me.colDescEvento.Name = "colDescEvento"
        '
        'colCorrecao
        '
        Me.colCorrecao.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCorrecao.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCorrecao.AppearanceHeader.Options.UseBackColor = True
        Me.colCorrecao.AppearanceHeader.Options.UseFont = True
        Me.colCorrecao.Caption = "Correção"
        Me.colCorrecao.FieldName = "Correcao"
        Me.colCorrecao.Name = "colCorrecao"
        Me.colCorrecao.OptionsColumn.ReadOnly = True
        Me.colCorrecao.Visible = True
        Me.colCorrecao.VisibleIndex = 3
        Me.colCorrecao.Width = 672
        '
        'colCondUso
        '
        Me.colCondUso.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCondUso.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCondUso.AppearanceHeader.Options.UseBackColor = True
        Me.colCondUso.AppearanceHeader.Options.UseFont = True
        Me.colCondUso.Caption = "CondUso"
        Me.colCondUso.FieldName = "CondUso"
        Me.colCondUso.Name = "colCondUso"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
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
        'relCce
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCce, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVersao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoAmb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHEmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTZD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoEvento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumSeqEvento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCNPJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescEvento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCorrecao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCondUso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsCce As System.Data.DataSet
    Friend WithEvents tbCce As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
End Class
