<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class relRemessas
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
        Me.ItensNfeGridControl = New DevExpress.XtraGrid.GridControl
        Me.grd1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNomeBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAgencia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCedente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Vencimento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCodBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNossoNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkGerar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.lblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.picLogo = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.dsBoleto = New System.Data.DataSet
        Me.tbBoleto = New System.Data.DataTable
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
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGerar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.WinControlContainer1})
        Me.Detail.Height = 122
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.WinControlContainer1.Name = "WinControlContainer1"
        Me.WinControlContainer1.Size = New System.Drawing.Size(1108, 83)
        Me.WinControlContainer1.WinControl = Me.ItensNfeGridControl
        '
        'ItensNfeGridControl
        '
        Me.ItensNfeGridControl.DataMember = "tbBoleto"
        Me.ItensNfeGridControl.DataSource = Me.dsBoleto
        Me.ItensNfeGridControl.EmbeddedNavigator.Name = ""
        Me.ItensNfeGridControl.Location = New System.Drawing.Point(2, 2)
        Me.ItensNfeGridControl.MainView = Me.grd1
        Me.ItensNfeGridControl.Name = "ItensNfeGridControl"
        Me.ItensNfeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkGerar})
        Me.ItensNfeGridControl.Size = New System.Drawing.Size(1064, 80)
        Me.ItensNfeGridControl.TabIndex = 0
        Me.ItensNfeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grd1})
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
        Me.grd1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNomeBanco, Me.colAgencia, Me.colCodigoCedente, Me.Vencimento, Me.colValor, Me.colNumeroDocumento, Me.colStatus, Me.colCodigo, Me.ColCodBanco, Me.colNossoNumero})
        Me.grd1.GridControl = Me.ItensNfeGridControl
        Me.grd1.Name = "grd1"
        Me.grd1.OptionsView.ShowGroupPanel = False
        '
        'colNomeBanco
        '
        Me.colNomeBanco.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNomeBanco.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNomeBanco.AppearanceHeader.Options.UseBackColor = True
        Me.colNomeBanco.AppearanceHeader.Options.UseFont = True
        Me.colNomeBanco.Caption = "Nome Banco"
        Me.colNomeBanco.FieldName = "NomeBanco"
        Me.colNomeBanco.Name = "colNomeBanco"
        Me.colNomeBanco.OptionsColumn.ReadOnly = True
        Me.colNomeBanco.Visible = True
        Me.colNomeBanco.VisibleIndex = 0
        Me.colNomeBanco.Width = 135
        '
        'colAgencia
        '
        Me.colAgencia.AppearanceCell.Options.UseTextOptions = True
        Me.colAgencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgencia.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colAgencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colAgencia.AppearanceHeader.Options.UseBackColor = True
        Me.colAgencia.AppearanceHeader.Options.UseFont = True
        Me.colAgencia.Caption = "Agência"
        Me.colAgencia.FieldName = "Agencia"
        Me.colAgencia.Name = "colAgencia"
        Me.colAgencia.OptionsColumn.ReadOnly = True
        Me.colAgencia.Visible = True
        Me.colAgencia.VisibleIndex = 1
        Me.colAgencia.Width = 107
        '
        'colCodigoCedente
        '
        Me.colCodigoCedente.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCedente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCedente.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colCodigoCedente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCedente.AppearanceHeader.Options.UseBackColor = True
        Me.colCodigoCedente.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCedente.Caption = "Cód. Cedente"
        Me.colCodigoCedente.FieldName = "CodigoCedente"
        Me.colCodigoCedente.Name = "colCodigoCedente"
        Me.colCodigoCedente.OptionsColumn.ReadOnly = True
        Me.colCodigoCedente.Visible = True
        Me.colCodigoCedente.VisibleIndex = 2
        Me.colCodigoCedente.Width = 114
        '
        'Vencimento
        '
        Me.Vencimento.AppearanceCell.Options.UseTextOptions = True
        Me.Vencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Vencimento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.Vencimento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Vencimento.AppearanceHeader.Options.UseBackColor = True
        Me.Vencimento.AppearanceHeader.Options.UseFont = True
        Me.Vencimento.Caption = "Vencimento"
        Me.Vencimento.FieldName = "Vencimento"
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.OptionsColumn.ReadOnly = True
        Me.Vencimento.Visible = True
        Me.Vencimento.VisibleIndex = 5
        Me.Vencimento.Width = 119
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
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.SummaryItem.DisplayFormat = "{0:c}"
        Me.colValor.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 6
        Me.colValor.Width = 104
        '
        'colNumeroDocumento
        '
        Me.colNumeroDocumento.AppearanceCell.Options.UseTextOptions = True
        Me.colNumeroDocumento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroDocumento.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNumeroDocumento.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNumeroDocumento.AppearanceHeader.Options.UseBackColor = True
        Me.colNumeroDocumento.AppearanceHeader.Options.UseFont = True
        Me.colNumeroDocumento.Caption = "Nº Documento"
        Me.colNumeroDocumento.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento.Name = "colNumeroDocumento"
        Me.colNumeroDocumento.OptionsColumn.ReadOnly = True
        Me.colNumeroDocumento.Visible = True
        Me.colNumeroDocumento.VisibleIndex = 4
        Me.colNumeroDocumento.Width = 133
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStatus.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colStatus.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colStatus.AppearanceHeader.Options.UseBackColor = True
        Me.colStatus.AppearanceHeader.Options.UseFont = True
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 7
        Me.colStatus.Width = 98
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
        '
        'ColCodBanco
        '
        Me.ColCodBanco.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.ColCodBanco.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColCodBanco.AppearanceHeader.Options.UseBackColor = True
        Me.ColCodBanco.AppearanceHeader.Options.UseFont = True
        Me.ColCodBanco.Caption = "CodBanco"
        Me.ColCodBanco.FieldName = "CodBanco"
        Me.ColCodBanco.Name = "ColCodBanco"
        '
        'colNossoNumero
        '
        Me.colNossoNumero.AppearanceCell.Options.UseTextOptions = True
        Me.colNossoNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNossoNumero.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colNossoNumero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNossoNumero.AppearanceHeader.Options.UseBackColor = True
        Me.colNossoNumero.AppearanceHeader.Options.UseFont = True
        Me.colNossoNumero.Caption = "Nosso Número"
        Me.colNossoNumero.FieldName = "NossoNumero"
        Me.colNossoNumero.Name = "colNossoNumero"
        Me.colNossoNumero.OptionsColumn.ReadOnly = True
        Me.colNossoNumero.Visible = True
        Me.colNossoNumero.VisibleIndex = 3
        Me.colNossoNumero.Width = 125
        '
        'chkGerar
        '
        Me.chkGerar.AutoHeight = False
        Me.chkGerar.Name = "chkGerar"
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
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'dsBoleto
        '
        Me.dsBoleto.DataSetName = "NewDataSet"
        Me.dsBoleto.Tables.AddRange(New System.Data.DataTable() {Me.tbBoleto})
        '
        'tbBoleto
        '
        Me.tbBoleto.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.tbBoleto.TableName = "tbBoleto"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Codigo"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "NomeBanco"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Agencia"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CodigoCedente"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "NumeroDocumento"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Vencimento"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Valor"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Status"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Gerar"
        Me.DataColumn9.DataType = GetType(Boolean)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CodBanco"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "NossoNumero"
        '
        'relRemessas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(30, 30, 30, 30)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreviewMarginLines = False
        Me.Version = "8.2"
        CType(Me.ItensNfeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGerar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBoleto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colNomeBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCedente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vencimento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkGerar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCodBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNossoNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dsBoleto As System.Data.DataSet
    Friend WithEvents tbBoleto As System.Data.DataTable
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
End Class
