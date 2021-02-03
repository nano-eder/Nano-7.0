<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relConsumo
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
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblPorc = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPed = New System.Data.DataSet
        Me.tbPed = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLucro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPorcentagem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblLucro = New DevExpress.XtraReports.UI.XRLabel
        Me.lbl2 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblCusto = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.lblPeriodo = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.lblPorc, Me.XrLine1, Me.WinControlContainer1, Me.XrLabel5, Me.lblLucro, Me.lbl2, Me.lblCusto, Me.XrLabel1, Me.lblTotal})
        Me.Detail.Height = 208
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.Location = New System.Drawing.Point(792, 175)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.Size = New System.Drawing.Size(158, 17)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Perc. Lucro %"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblPorc
        '
        Me.lblPorc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorc.Location = New System.Drawing.Point(958, 175)
        Me.lblPorc.Name = "lblPorc"
        Me.lblPorc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPorc.Size = New System.Drawing.Size(133, 17)
        Me.lblPorc.StylePriority.UseFont = False
        Me.lblPorc.StylePriority.UseTextAlignment = False
        Me.lblPorc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(0, 75)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(1100, 8)
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1100, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbPed"
        Me.GridControl1.DataSource = Me.dsPed
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1056, 72)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsPed
        '
        Me.dsPed.DataSetName = "NewDataSet"
        Me.dsPed.Tables.AddRange(New System.Data.DataTable() {Me.tbPed})
        '
        'tbPed
        '
        Me.tbPed.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbPed.TableName = "tbPed"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Produto"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Qtd"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Valor"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Custo"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Lucro"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Porcentagem"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Tamanho"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduto, Me.colQtd, Me.colValor, Me.colCusto, Me.colLucro, Me.colPorcentagem, Me.colTamanho})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.colProduto.Visible = True
        Me.colProduto.VisibleIndex = 0
        Me.colProduto.Width = 436
        '
        'colQtd
        '
        Me.colQtd.AppearanceCell.Options.UseTextOptions = True
        Me.colQtd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtd.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtd.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtd.AppearanceHeader.Options.UseBackColor = True
        Me.colQtd.AppearanceHeader.Options.UseFont = True
        Me.colQtd.Caption = "Qtde"
        Me.colQtd.FieldName = "Qtd"
        Me.colQtd.Name = "colQtd"
        Me.colQtd.Visible = True
        Me.colQtd.VisibleIndex = 2
        Me.colQtd.Width = 121
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor R$"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 3
        Me.colValor.Width = 143
        '
        'colCusto
        '
        Me.colCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCusto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCusto.AppearanceHeader.Options.UseBackColor = True
        Me.colCusto.AppearanceHeader.Options.UseFont = True
        Me.colCusto.Caption = "Valor Custo R$"
        Me.colCusto.FieldName = "Custo"
        Me.colCusto.Name = "colCusto"
        Me.colCusto.Visible = True
        Me.colCusto.VisibleIndex = 4
        Me.colCusto.Width = 143
        '
        'colLucro
        '
        Me.colLucro.AppearanceCell.Options.UseTextOptions = True
        Me.colLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLucro.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colLucro.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colLucro.AppearanceHeader.Options.UseBackColor = True
        Me.colLucro.AppearanceHeader.Options.UseFont = True
        Me.colLucro.Caption = "Lucro R$"
        Me.colLucro.FieldName = "Lucro"
        Me.colLucro.Name = "colLucro"
        Me.colLucro.Visible = True
        Me.colLucro.VisibleIndex = 5
        Me.colLucro.Width = 128
        '
        'colPorcentagem
        '
        Me.colPorcentagem.AppearanceCell.Options.UseTextOptions = True
        Me.colPorcentagem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPorcentagem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPorcentagem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPorcentagem.AppearanceHeader.Options.UseBackColor = True
        Me.colPorcentagem.AppearanceHeader.Options.UseFont = True
        Me.colPorcentagem.Caption = "Perc. Lucro %"
        Me.colPorcentagem.FieldName = "Porcentagem"
        Me.colPorcentagem.Name = "colPorcentagem"
        Me.colPorcentagem.Visible = True
        Me.colPorcentagem.VisibleIndex = 6
        Me.colPorcentagem.Width = 117
        '
        'colTamanho
        '
        Me.colTamanho.AppearanceCell.Options.UseTextOptions = True
        Me.colTamanho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTamanho.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTamanho.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTamanho.AppearanceHeader.Options.UseBackColor = True
        Me.colTamanho.AppearanceHeader.Options.UseFont = True
        Me.colTamanho.Caption = "Tam."
        Me.colTamanho.FieldName = "Tamanho"
        Me.colTamanho.Name = "colTamanho"
        Me.colTamanho.Visible = True
        Me.colTamanho.VisibleIndex = 1
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.Location = New System.Drawing.Point(792, 150)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(158, 17)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Lucro R$"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblLucro
        '
        Me.lblLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLucro.Location = New System.Drawing.Point(958, 150)
        Me.lblLucro.Name = "lblLucro"
        Me.lblLucro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblLucro.Size = New System.Drawing.Size(133, 17)
        Me.lblLucro.StylePriority.UseFont = False
        Me.lblLucro.StylePriority.UseTextAlignment = False
        Me.lblLucro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(792, 125)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl2.Size = New System.Drawing.Size(158, 17)
        Me.lbl2.StylePriority.UseFont = False
        Me.lbl2.StylePriority.UseTextAlignment = False
        Me.lbl2.Text = "Total de Custo R$"
        Me.lbl2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblCusto
        '
        Me.lblCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusto.Location = New System.Drawing.Point(958, 125)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblCusto.Size = New System.Drawing.Size(133, 17)
        Me.lblCusto.StylePriority.UseFont = False
        Me.lblCusto.StylePriority.UseTextAlignment = False
        Me.lblCusto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(808, 100)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(142, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total Geral R$"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(958, 100)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(133, 17)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPeriodo, Me.XrLine2, Me.lblTitulo, Me.picLogo, Me.XrLine3})
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
        Me.lblTitulo.Location = New System.Drawing.Point(225, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(767, 25)
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
        Me.picLogo.Location = New System.Drawing.Point(17, 17)
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
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(225, 50)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPeriodo.Size = New System.Drawing.Size(767, 25)
        Me.lblPeriodo.StylePriority.UseFont = False
        Me.lblPeriodo.StylePriority.UseTextAlignment = False
        Me.lblPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'relConsumo
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
        CType(Me.dsPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblLucro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblCusto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dsPed As System.Data.DataSet
    Friend WithEvents tbPed As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLucro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents colPorcentagem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPorc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraReports.UI.XRLabel
End Class
