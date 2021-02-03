<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relProdFalta
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
        Me.dsProd = New System.Data.DataSet
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
        Me.DataColumn11 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodProd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtdMin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSetor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdFor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WinControlContainer1.Size = New System.Drawing.Size(1083, 100)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbProd"
        Me.GridControl1.DataSource = Me.dsProd
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1040, 96)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsProd
        '
        Me.dsProd.DataSetName = "NewDataSet"
        Me.dsProd.Tables.AddRange(New System.Data.DataTable() {Me.tbProd})
        '
        'tbProd
        '
        Me.tbProd.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbProd.TableName = "tbProd"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodProd"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CodInterno"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Nome"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "QtdMin"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Qtd"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Tamanho"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Grupo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Setor"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CodConfig"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Fabricante"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodProdFor"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodProd, Me.colCodInterno, Me.colNome, Me.colQtdMin, Me.colQtd, Me.colTamanho, Me.colGrupo, Me.colSetor, Me.colCodConfig, Me.colFabricante, Me.colCodProdFor})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.colCodInterno.Caption = "Código"
        Me.colCodInterno.FieldName = "CodInterno"
        Me.colCodInterno.Name = "colCodInterno"
        Me.colCodInterno.OptionsColumn.ReadOnly = True
        Me.colCodInterno.Visible = True
        Me.colCodInterno.VisibleIndex = 0
        Me.colCodInterno.Width = 96
        '
        'colNome
        '
        Me.colNome.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNome.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNome.AppearanceHeader.Options.UseBackColor = True
        Me.colNome.AppearanceHeader.Options.UseFont = True
        Me.colNome.Caption = "Produto"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsColumn.ReadOnly = True
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 2
        Me.colNome.Width = 250
        '
        'colQtdMin
        '
        Me.colQtdMin.AppearanceCell.Options.UseTextOptions = True
        Me.colQtdMin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtdMin.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtdMin.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtdMin.AppearanceHeader.Options.UseBackColor = True
        Me.colQtdMin.AppearanceHeader.Options.UseFont = True
        Me.colQtdMin.Caption = "Qtd. Mín."
        Me.colQtdMin.FieldName = "QtdMin"
        Me.colQtdMin.Name = "colQtdMin"
        Me.colQtdMin.OptionsColumn.ReadOnly = True
        Me.colQtdMin.Visible = True
        Me.colQtdMin.VisibleIndex = 6
        Me.colQtdMin.Width = 92
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQtd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtd.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.Caption = "Qtd"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.OptionsColumn.ReadOnly = True
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 7
        Me.colQtd.Width = 90
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTamanho.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTamanho.AppearanceHeader.Options.UseBackColor = True
        Me.colTamanho.AppearanceHeader.Options.UseFont = True
        Me.colTamanho.Caption = "Tamanho"
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.OptionsColumn.ReadOnly = True
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 8
        Me.colTamanho.Width = 73
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
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 4
        Me.colGrupo.Width = 100
        '
        'colSetor
        '
        Me.colSetor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colSetor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSetor.AppearanceHeader.Options.UseBackColor = True
        Me.colSetor.AppearanceHeader.Options.UseFont = True
        Me.colSetor.Caption = "Setor"
        Me.colSetor.FieldName = "Setor"
        Me.colSetor.Name = "colSetor"
        Me.colSetor.OptionsColumn.ReadOnly = True
        Me.colSetor.Visible = True
        Me.colSetor.VisibleIndex = 5
        Me.colSetor.Width = 100
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
        Me.colCodConfig.FieldName = "CodConfig"
        Me.colCodConfig.Name = "colCodConfig"
        Me.colCodConfig.OptionsColumn.ReadOnly = True
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 9
        Me.colCodConfig.Width = 102
        '
        'colFabricante
        '
        Me.colFabricante.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFabricante.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFabricante.AppearanceHeader.Options.UseBackColor = True
        Me.colFabricante.AppearanceHeader.Options.UseFont = True
        Me.colFabricante.Caption = "Fornecedor"
        Me.colFabricante.FieldName = "Fabricante"
        Me.colFabricante.Name = "colFabricante"
        Me.colFabricante.OptionsColumn.ReadOnly = True
        Me.colFabricante.Visible = True
        Me.colFabricante.VisibleIndex = 3
        Me.colFabricante.Width = 162
        '
        'colCodProdFor
        '
        Me.colCodProdFor.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdFor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodProdFor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProdFor.AppearanceHeader.Options.UseBackColor = True
        Me.colCodProdFor.AppearanceHeader.Options.UseFont = True
        Me.colCodProdFor.Caption = "Cód. Prod. Forn."
        Me.colCodProdFor.FieldName = "CodProdFor"
        Me.colCodProdFor.Name = "colCodProdFor"
        Me.colCodProdFor.Visible = True
        Me.colCodProdFor.VisibleIndex = 1
        Me.colCodProdFor.Width = 109
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitulo, Me.XrLine3, Me.XrLine2, Me.picLogo})
        Me.PageHeader.Height = 91
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(158, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(917, 33)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Produtos em Falta"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1083, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 83)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1083, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.ImageUrl = "C:\NANO\Logo.png"
        Me.picLogo.Location = New System.Drawing.Point(0, 17)
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
        'relProdFalta
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(40, 39, 40, 40)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dsProd As System.Data.DataSet
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtdMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colCodProdFor As DevExpress.XtraGrid.Columns.GridColumn
End Class
