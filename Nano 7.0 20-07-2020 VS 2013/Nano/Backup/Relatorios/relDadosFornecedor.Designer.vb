<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relDadosFornecedor
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
        Me.WinControlContainer2 = New DevExpress.XtraReports.UI.WinControlContainer
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.dsFor = New System.Data.DataSet
        Me.tbFor = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFornecedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCPF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRG = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTel1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTel2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContato = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer2})
        Me.Detail.Height = 86
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer2
        '
        Me.WinControlContainer2.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer2.Name = "WinControlContainer2"
        Me.WinControlContainer2.Size = New System.Drawing.Size(1108, 67)
        Me.WinControlContainer2.WinControl = Me.GridControl1
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "tbFor"
        Me.GridControl1.DataSource = Me.dsFor
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1064, 64)
        Me.GridControl1.TabIndex = 108
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'dsFor
        '
        Me.dsFor.DataSetName = "NewDataSet"
        Me.dsFor.Tables.AddRange(New System.Data.DataTable() {Me.tbFor})
        '
        'tbFor
        '
        Me.tbFor.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.tbFor.TableName = "tbFor"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Fornecedor"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "CPF"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "RG"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Tel1"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Tel2"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Email"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Contato"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFornecedor, Me.colCPF, Me.colRG, Me.colTel1, Me.colTel2, Me.colEmail, Me.colContato})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.colFornecedor.VisibleIndex = 0
        Me.colFornecedor.Width = 334
        '
        'colCPF
        '
        Me.colCPF.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCPF.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCPF.AppearanceHeader.Options.UseBackColor = True
        Me.colCPF.AppearanceHeader.Options.UseFont = True
        Me.colCPF.Caption = "CPF/CNPJ"
        Me.colCPF.FieldName = "CPF"
        Me.colCPF.Name = "colCPF"
        Me.colCPF.Visible = True
        Me.colCPF.VisibleIndex = 1
        Me.colCPF.Width = 105
        '
        'colRG
        '
        Me.colRG.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colRG.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colRG.AppearanceHeader.Options.UseBackColor = True
        Me.colRG.AppearanceHeader.Options.UseFont = True
        Me.colRG.Caption = "RG/IE"
        Me.colRG.FieldName = "RG"
        Me.colRG.Name = "colRG"
        Me.colRG.Visible = True
        Me.colRG.VisibleIndex = 2
        Me.colRG.Width = 104
        '
        'colTel1
        '
        Me.colTel1.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTel1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTel1.AppearanceHeader.Options.UseBackColor = True
        Me.colTel1.AppearanceHeader.Options.UseFont = True
        Me.colTel1.Caption = "Telefone 1"
        Me.colTel1.FieldName = "Tel1"
        Me.colTel1.Name = "colTel1"
        Me.colTel1.Visible = True
        Me.colTel1.VisibleIndex = 4
        Me.colTel1.Width = 112
        '
        'colTel2
        '
        Me.colTel2.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colTel2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTel2.AppearanceHeader.Options.UseBackColor = True
        Me.colTel2.AppearanceHeader.Options.UseFont = True
        Me.colTel2.Caption = "Telefone 2"
        Me.colTel2.FieldName = "Tel2"
        Me.colTel2.Name = "colTel2"
        Me.colTel2.Visible = True
        Me.colTel2.VisibleIndex = 5
        Me.colTel2.Width = 112
        '
        'colEmail
        '
        Me.colEmail.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colEmail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colEmail.AppearanceHeader.Options.UseBackColor = True
        Me.colEmail.AppearanceHeader.Options.UseFont = True
        Me.colEmail.Caption = "E-mail"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 6
        Me.colEmail.Width = 197
        '
        'colContato
        '
        Me.colContato.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colContato.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colContato.AppearanceHeader.Options.UseBackColor = True
        Me.colContato.AppearanceHeader.Options.UseFont = True
        Me.colContato.Caption = "Contato"
        Me.colContato.FieldName = "Contato"
        Me.colContato.Name = "colContato"
        Me.colContato.Visible = True
        Me.colContato.VisibleIndex = 3
        Me.colContato.Width = 124
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.picLogo, Me.XrLine2, Me.XrLine3, Me.lblTitulo})
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(0, 92)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(1108, 8)
        '
        'XrLine3
        '
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.Location = New System.Drawing.Point(0, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(1108, 8)
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
        Me.lblTitulo.Text = "Relatório de Fornecedores"
        Me.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'relDadosFornecedor
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
        CType(Me.dsFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents picLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents WinControlContainer2 As DevExpress.XtraReports.UI.WinControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dsFor As System.Data.DataSet
    Friend WithEvents tbFor As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents colFornecedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCPF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTel2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContato As DevExpress.XtraGrid.Columns.GridColumn
End Class
