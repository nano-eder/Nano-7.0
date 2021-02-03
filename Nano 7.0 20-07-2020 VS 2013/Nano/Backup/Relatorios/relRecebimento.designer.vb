<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relRecebimento
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
        Me.components = New System.ComponentModel.Container
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.WinControlContainer1 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.RecebimentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNano = New Nano.dsNano
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPagamento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.RecebimentoTableAdapter = New Nano.dsNanoTableAdapters.RecebimentoTableAdapter
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecebimentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1, Me.XrLabel1, Me.lblTotal, Me.XrLine1})
        Me.Detail.Height = 133
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(767, 75)
        Me.WinControlContainer1.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RecebimentoBindingSource
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(736, 72)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'RecebimentoBindingSource
        '
        Me.RecebimentoBindingSource.DataMember = "Recebimento"
        Me.RecebimentoBindingSource.DataSource = Me.DsNano
        '
        'DsNano
        '
        Me.DsNano.DataSetName = "dsNano"
        Me.DsNano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPagamento, Me.colValor})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPagamento
        '
        Me.colPagamento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPagamento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPagamento.AppearanceHeader.Options.UseBackColor = True
        Me.colPagamento.AppearanceHeader.Options.UseFont = True
        Me.colPagamento.Caption = "Pagamento"
        Me.colPagamento.FieldName = "Pagamento"
        Me.colPagamento.Name = "colPagamento"
        Me.colPagamento.Visible = True
        Me.colPagamento.VisibleIndex = 0
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
        Me.colValor.VisibleIndex = 1
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.Location = New System.Drawing.Point(458, 100)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(158, 17)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total Recebido R$"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(625, 100)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.Size = New System.Drawing.Size(133, 17)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.Text = "lblTotal"
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(0, 75)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(758, 8)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine2, Me.lblTitulo, Me.picLogo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.Location = New System.Drawing.Point(0, 0)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(758, 8)
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(758, 8)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(175, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitulo.Size = New System.Drawing.Size(558, 25)
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
        Me.picLogo.Location = New System.Drawing.Point(0, 17)
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
        'RecebimentoTableAdapter
        '
        Me.RecebimentoTableAdapter.ClearBeforeFill = True
        '
        'relRecebimento
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecebimentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents WinControlContainer1 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RecebimentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsNano As Nano.dsNano
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPagamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RecebimentoTableAdapter As Nano.dsNanoTableAdapters.RecebimentoTableAdapter
End Class