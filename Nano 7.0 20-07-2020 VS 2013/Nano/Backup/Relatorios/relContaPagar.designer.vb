<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relContaPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relContaPagar))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.lblRelTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsPagar = New System.Data.DataSet
        Me.tbPagar = New System.Data.DataTable
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoConta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colParcelas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorParcela = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValorPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCentroCusto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.lblPeriodo = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.DataColumn11 = New System.Data.DataColumn
        Me.colCodConfig = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblRelTotal, Me.lblTotal, Me.WinControlContainer1})
        Me.Detail.Height = 142
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblRelTotal
        '
        Me.lblRelTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelTotal.Location = New System.Drawing.Point(758, 108)
        Me.lblRelTotal.Name = "lblRelTotal"
        Me.lblRelTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRelTotal.Size = New System.Drawing.Size(183, 25)
        Me.lblRelTotal.StylePriority.UseFont = False
        Me.lblRelTotal.StylePriority.UseTextAlignment = False
        Me.lblRelTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(942, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(158, 25)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1100, 92)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbPagar"
        Me.GridControl1.DataSource = Me.dsPagar
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1056, 88)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsPagar
        '
        Me.dsPagar.DataSetName = "NewDataSet"
        Me.dsPagar.Tables.AddRange(New System.Data.DataTable() {Me.tbPagar})
        '
        'tbPagar
        '
        Me.tbPagar.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbPagar.TableName = "tbPagar"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Fornecedor"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TipoConta"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Valor"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Parcelas"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ValorParcelas"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Vencimento"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "DataPagamento"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ValorPago"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CentroCusto"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colTipoConta, Me.colValor, Me.colParcelas, Me.colValorParcela, Me.colVencimento, Me.colDataPagamento, Me.colValorPago, Me.colFornecedor, Me.colCentroCusto, Me.colCodConfig})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 63
        '
        'colTipoConta
        '
        Me.colTipoConta.AppearanceCell.Options.UseTextOptions = True
        Me.colTipoConta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoConta.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTipoConta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTipoConta.AppearanceHeader.Options.UseBackColor = True
        Me.colTipoConta.AppearanceHeader.Options.UseFont = True
        Me.colTipoConta.Caption = "Tipo de Conta"
        Me.colTipoConta.FieldName = "TipoConta"
        Me.colTipoConta.Name = "colTipoConta"
        Me.colTipoConta.Visible = True
        Me.colTipoConta.VisibleIndex = 2
        Me.colTipoConta.Width = 117
        '
        'colValor
        '
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValor.AppearanceHeader.Options.UseBackColor = True
        Me.colValor.AppearanceHeader.Options.UseFont = True
        Me.colValor.Caption = "Valor da Conta"
        Me.colValor.FieldName = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 4
        Me.colValor.Width = 121
        '
        'colParcelas
        '
        Me.colParcelas.AppearanceCell.Options.UseTextOptions = True
        Me.colParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcelas.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colParcelas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colParcelas.AppearanceHeader.Options.UseBackColor = True
        Me.colParcelas.AppearanceHeader.Options.UseFont = True
        Me.colParcelas.Caption = "N° Parcelas"
        Me.colParcelas.FieldName = "Parcelas"
        Me.colParcelas.Name = "colParcelas"
        Me.colParcelas.Visible = True
        Me.colParcelas.VisibleIndex = 5
        Me.colParcelas.Width = 86
        '
        'colValorParcela
        '
        Me.colValorParcela.AppearanceCell.Options.UseTextOptions = True
        Me.colValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorParcela.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorParcela.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorParcela.AppearanceHeader.Options.UseBackColor = True
        Me.colValorParcela.AppearanceHeader.Options.UseFont = True
        Me.colValorParcela.Caption = "Valor Parcela R$"
        Me.colValorParcela.FieldName = "ValorParcelas"
        Me.colValorParcela.Name = "colValorParcela"
        Me.colValorParcela.Visible = True
        Me.colValorParcela.VisibleIndex = 6
        Me.colValorParcela.Width = 114
        '
        'colVencimento
        '
        Me.colVencimento.AppearanceCell.Options.UseTextOptions = True
        Me.colVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVencimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colVencimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colVencimento.AppearanceHeader.Options.UseBackColor = True
        Me.colVencimento.AppearanceHeader.Options.UseFont = True
        Me.colVencimento.Caption = "Vencimento"
        Me.colVencimento.FieldName = "Vencimento"
        Me.colVencimento.Name = "colVencimento"
        Me.colVencimento.Visible = True
        Me.colVencimento.VisibleIndex = 7
        Me.colVencimento.Width = 109
        '
        'colDataPagamento
        '
        Me.colDataPagamento.AppearanceCell.Options.UseTextOptions = True
        Me.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDataPagamento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colDataPagamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDataPagamento.AppearanceHeader.Options.UseBackColor = True
        Me.colDataPagamento.AppearanceHeader.Options.UseFont = True
        Me.colDataPagamento.Caption = "Pagamento"
        Me.colDataPagamento.FieldName = "DataPagamento"
        Me.colDataPagamento.Name = "colDataPagamento"
        Me.colDataPagamento.Visible = True
        Me.colDataPagamento.VisibleIndex = 8
        Me.colDataPagamento.Width = 103
        '
        'colValorPago
        '
        Me.colValorPago.AppearanceCell.Options.UseTextOptions = True
        Me.colValorPago.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colValorPago.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colValorPago.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colValorPago.AppearanceHeader.Options.UseBackColor = True
        Me.colValorPago.AppearanceHeader.Options.UseFont = True
        Me.colValorPago.Caption = "Valor Pago R$"
        Me.colValorPago.FieldName = "ValorPago"
        Me.colValorPago.Name = "colValorPago"
        Me.colValorPago.Visible = True
        Me.colValorPago.VisibleIndex = 9
        Me.colValorPago.Width = 107
        '
        'colFornecedor
        '
        Me.colFornecedor.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colFornecedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFornecedor.AppearanceHeader.Options.UseBackColor = True
        Me.colFornecedor.AppearanceHeader.Options.UseFont = True
        Me.colFornecedor.Caption = "Fornecedor"
        Me.colFornecedor.FieldName = "Fornecedor"
        Me.colFornecedor.Name = "colFornecedor"
        Me.colFornecedor.Visible = True
        Me.colFornecedor.VisibleIndex = 1
        Me.colFornecedor.Width = 235
        '
        'colCentroCusto
        '
        Me.colCentroCusto.AppearanceCell.Options.UseTextOptions = True
        Me.colCentroCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCentroCusto.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCentroCusto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCentroCusto.AppearanceHeader.Options.UseBackColor = True
        Me.colCentroCusto.AppearanceHeader.Options.UseFont = True
        Me.colCentroCusto.Caption = "Centro Custo"
        Me.colCentroCusto.FieldName = "CentroCusto"
        Me.colCentroCusto.Name = "colCentroCusto"
        Me.colCentroCusto.Visible = True
        Me.colCentroCusto.VisibleIndex = 3
        Me.colCentroCusto.Width = 119
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPeriodo, Me.lblTitulo, Me.XrLine2, Me.picLogo, Me.XrLine3})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(225, 50)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPeriodo.Size = New System.Drawing.Size(850, 25)
        Me.lblPeriodo.StylePriority.UseFont = False
        Me.lblPeriodo.StylePriority.UseTextAlignment = False
        Me.lblPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(225, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(850, 25)
        Me.lblTitulo.StylePriority.UseFont = False
        Me.lblTitulo.StylePriority.UseTextAlignment = False
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.picLogo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
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
        Me.XrLine3.Size = New System.Drawing.Size(1100, 8)
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CodConfig"
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
        '
        'relContaPagar
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
        CType(Me.dsPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcelas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorParcela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValorPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblRelTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dsPagar As System.Data.DataSet
    Friend WithEvents tbPagar As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colCentroCusto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents lblPeriodo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents colCodConfig As DevExpress.XtraGrid.Columns.GridColumn
End Class
