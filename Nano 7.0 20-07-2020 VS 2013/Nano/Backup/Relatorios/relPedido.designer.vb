<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relPedido))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblPro = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.PedidoGridControl = New DevExpress.XtraGrid.GridControl
        Me.dsPedido = New System.Data.DataSet
        Me.tbPedido = New System.Data.DataTable
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
        Me.colCodOrdem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQtde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProduto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorUni = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodProdInterno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTamanho = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlaca = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblPeriodo = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.DataColumn13 = New System.Data.DataColumn
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPro, Me.lblTotal, Me.XrLabel1, Me.XrLine4, Me.XrLabel4, Me.WinControlContainer1})
        Me.Detail.Height = 161
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPro
        '
        Me.lblPro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPro.Location = New System.Drawing.Point(958, 100)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPro.Size = New System.Drawing.Size(142, 25)
        Me.lblPro.StylePriority.UseFont = False
        Me.lblPro.StylePriority.UseTextAlignment = False
        Me.lblPro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(958, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(142, 25)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(808, 125)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total Geral R$"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(0, 83)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(1100, 8)
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.Location = New System.Drawing.Point(808, 100)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.Size = New System.Drawing.Size(142, 25)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Qtde Produto"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1100, 83)
        Me.WinControlContainer1.WinControl = Me.PedidoGridControl
        '
        'PedidoGridControl
        '
        Me.PedidoGridControl.DataMember = "tbPedido"
        Me.PedidoGridControl.DataSource = Me.dsPedido
        Me.PedidoGridControl.EmbeddedNavigator.Name = ""
        Me.PedidoGridControl.Location = New System.Drawing.Point(0, 23)
        Me.PedidoGridControl.MainView = Me.grd1
        Me.PedidoGridControl.Name = "PedidoGridControl"
        Me.PedidoGridControl.Size = New System.Drawing.Size(1056, 80)
        Me.PedidoGridControl.TabIndex = 3
        Me.PedidoGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1, Me.GridView2})
        '
        'dsPedido
        '
        Me.dsPedido.DataSetName = "NewDataSet"
        Me.dsPedido.Tables.AddRange(New System.Data.DataTable() {Me.tbPedido})
        '
        'tbPedido
        '
        Me.tbPedido.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.tbPedido.TableName = "tbPedido"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "CodOrdem"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Data"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Cliente"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Qtde"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Produto"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ValorUni"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ValorTotal"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "CodProdInterno"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Tamanho"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodConfig"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Placa"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Modelo"
        '
        'grd1
        '
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodOrdem, Me.colData, Me.colCliente, Me.colQtde, Me.colProduto, Me.colValorUni, Me.colValorTotal, Me.colCodProdInterno, Me.colTamanho, Me.colCodConfig, Me.colPlaca, Me.colModelo})
        Me.grd1.GridControl = Me.PedidoGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colCodOrdem
        '
        Me.colCodOrdem.AppearanceCell.Options.UseTextOptions = True
        Me.colCodOrdem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodOrdem.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodOrdem.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodOrdem.AppearanceHeader.Options.UseBackColor = True
        Me.colCodOrdem.AppearanceHeader.Options.UseFont = True
        Me.colCodOrdem.Caption = "N° Venda"
        Me.colCodOrdem.FieldName = "CodOrdem"
        Me.colCodOrdem.Name = "colCodOrdem"
        Me.colCodOrdem.Visible = True
        Me.colCodOrdem.VisibleIndex = 0
        Me.colCodOrdem.Width = 67
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
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 1
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
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 2
        Me.colCliente.Width = 197
        '
        'colQtde
        '
        Me.colQtde.AppearanceCell.Options.UseTextOptions = True
        Me.colQtde.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtde.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colQtde.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colQtde.AppearanceHeader.Options.UseBackColor = True
        Me.colQtde.AppearanceHeader.Options.UseFont = True
        Me.colQtde.Caption = "Qtde"
        Me.colQtde.FieldName = "Qtde"
        Me.colQtde.Name = "colQtde"
        Me.colQtde.Visible = True
        Me.colQtde.VisibleIndex = 8
        Me.colQtde.Width = 52
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
        Me.colProduto.VisibleIndex = 4
        Me.colProduto.Width = 180
        '
        'colValorUni
        '
        Me.colValorUni.AppearanceCell.Options.UseTextOptions = True
        Me.colValorUni.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorUni.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorUni.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorUni.AppearanceHeader.Options.UseBackColor = True
        Me.colValorUni.AppearanceHeader.Options.UseFont = True
        Me.colValorUni.Caption = "Valor Uni. R$"
        Me.colValorUni.FieldName = "ValorUni"
        Me.colValorUni.Name = "colValorUni"
        Me.colValorUni.Visible = True
        Me.colValorUni.VisibleIndex = 9
        Me.colValorUni.Width = 94
        '
        'colValorTotal
        '
        Me.colValorTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorTotal.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorTotal.AppearanceHeader.Options.UseBackColor = True
        Me.colValorTotal.AppearanceHeader.Options.UseFont = True
        Me.colValorTotal.Caption = "Valor Total R$"
        Me.colValorTotal.FieldName = "ValorTotal"
        Me.colValorTotal.Name = "colValorTotal"
        Me.colValorTotal.Visible = True
        Me.colValorTotal.VisibleIndex = 10
        Me.colValorTotal.Width = 108
        '
        'colCodProdInterno
        '
        Me.colCodProdInterno.AppearanceCell.Options.UseTextOptions = True
        Me.colCodProdInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodProdInterno.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodProdInterno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodProdInterno.AppearanceHeader.Options.UseBackColor = True
        Me.colCodProdInterno.AppearanceHeader.Options.UseFont = True
        Me.colCodProdInterno.Caption = "Código"
        Me.colCodProdInterno.FieldName = "CodProdInterno"
        Me.colCodProdInterno.Name = "colCodProdInterno"
        Me.colCodProdInterno.Visible = True
        Me.colCodProdInterno.VisibleIndex = 3
        Me.colCodProdInterno.Width = 79
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
        Me.colTamanho.VisibleIndex = 7
        Me.colTamanho.Width = 58
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
        Me.colCodConfig.Visible = True
        Me.colCodConfig.VisibleIndex = 11
        Me.colCodConfig.Width = 86
        '
        'colPlaca
        '
        Me.colPlaca.AppearanceCell.Options.UseTextOptions = True
        Me.colPlaca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlaca.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPlaca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPlaca.AppearanceHeader.Options.UseBackColor = True
        Me.colPlaca.AppearanceHeader.Options.UseFont = True
        Me.colPlaca.Caption = "Placa"
        Me.colPlaca.FieldName = "Placa"
        Me.colPlaca.Name = "colPlaca"
        Me.colPlaca.Visible = True
        Me.colPlaca.VisibleIndex = 5
        Me.colPlaca.Width = 70
        '
        'colModelo
        '
        Me.colModelo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colModelo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colModelo.AppearanceHeader.Options.UseBackColor = True
        Me.colModelo.AppearanceHeader.Options.UseFont = True
        Me.colModelo.Caption = "Modelo"
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 6
        Me.colModelo.Width = 92
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.PedidoGridControl
        Me.GridView2.Name = "GridView2"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPeriodo, Me.lblTitulo, Me.XrLine3, Me.XrLine2, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(192, 50)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPeriodo.Size = New System.Drawing.Size(875, 25)
        Me.lblPeriodo.StylePriority.UseFont = False
        Me.lblPeriodo.StylePriority.UseTextAlignment = False
        Me.lblPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(192, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(875, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.Text = "Relatório de Vendas"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1100, 8)
        '
        'picLogo
        '
        Me.picLogo.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.picLogo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
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
        Me.PageFooter.Height = 0
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KM"
        '
        'relPedido
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.PedidoGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents PedidoGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dsPedido As System.Data.DataSet
    Friend WithEvents tbPedido As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colCodOrdem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorUni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colCodProdInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colTamanho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
End Class
